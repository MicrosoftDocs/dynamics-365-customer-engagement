---
title: Build a smart assist agent
description: Read how you can build a smart assist agent to help representatives resolve customer queries faster and more effectively.
ms.date: 04/25/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---
# Build a smart assist agent

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

To quickly get started, follow the instructions mentioned in this topic for building a smart assist AI agent that displays knowledge article recommendations to the customer service representative (service representative or representative). After this, you can do additional steps for creating custom scenarios.

## Prerequisites

You must understand how to create an agent using [Azure Bot Service](/azure/bot-service/abs-quickstart?preserve-view=true&view=azure-bot-service-4.0).

## How the smart assist agent works

A smart assist agent is an Azure Bot Framework bot that listens to the conversation between a customer and a customer service representative (service representative or representative) in real time. The agent analyzes each message, queries Dynamics 365 for relevant data, and returns recommendations to the representative as adaptive cards in the productivity pane. Unlike a customer-facing agent, a smart assist agent doesn't send messages to the customer. It operates silently alongside the representative and surfaces suggestions only in the smart assist panel.

The following diagram shows the data flow at a high level:

1. A customer sends a message through a channel (chat, voice, or messaging).
2. Dynamics 365 Contact Center routes a copy of each message to the smart assist agent through the Omnichannel middleware.
3. The agent processes the message, optionally calls LUIS to determine intent, and queries Dataverse for knowledge articles or similar cases.
4. The agent returns one or more adaptive cards to the representative's productivity pane as suggestions.
5. The representative can act on the suggestion (for example, open a case or send a knowledge article to the customer) or dismiss it.

### Solution structure

The [sample solution](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot) is a C# .NET Core project built on the Bot Framework SDK v4. The key files and their roles are as follows:

| File | Purpose |
| --- | --- |
| `Bots/SmartAssistBot.cs` | The main bot class. Receives each activity (message) from Omnichannel and orchestrates the response. |
| `SmartAssist/DynamicsDataAccessLayer.cs` | Authenticates to Dataverse and executes API calls, including the `FullTextSearchKnowledgeArticle` action and the `GetSimilarRecords` function. |
| `SmartAssist/Operations/KBSearchOperation.cs` | Builds the knowledge article search query and constructs adaptive cards from the results. |
| `SmartAssist/Operations/SimilarCaseOperation.cs` | Queries for similar cases using similarity rules and constructs adaptive cards from the results. |
| `Dialogs/MainDialog.cs` | Manages the waterfall dialog flow. Uses LUIS to determine user intent and routes to the appropriate operation. |
| `appsettings.json` | Stores configuration for the Bot Framework app ID, LUIS endpoint, and Dataverse connection settings. |

### Message handling in SmartAssistBot.cs

The `SmartAssistBot` class extends `ActivityHandler` from the Bot Framework SDK. When Dynamics 365 Contact Center forwards a customer message to the agent, the `OnMessageActivityAsync` method fires. This is the entry point where all recommendation logic begins.

```csharp
protected override async Task OnMessageActivityAsync(
    ITurnContext<IMessageActivity> turnContext,
    CancellationToken cancellationToken)
{
    // Each customer message arrives here as a turn context.
    // The agent checks for a special flag ("omnichannelfoobar") to identify
    // that it is operating in the Omnichannel smart assist context,
    // then delegates to the main dialog for intent detection and processing.
    await _dialog.RunAsync(
        turnContext,
        _conversationState.CreateProperty<DialogState>("DialogState"),
        cancellationToken);
}
```

The key behavior to understand is that this method is called for every message in the conversation, including both customer and representative messages. The agent inspects `turnContext.Activity.Text` to determine the content and then passes it to the dialog layer.

> [!NOTE]
> When testing the agent in the Azure portal's **Test in Web Chat** feature, type `omnichannelfoobar` as the first message. This sets an internal flag that tells the sample code to operate in Omnichannel mode. This keyword isn't needed in production because the Omnichannel middleware sets the flag automatically.

### Intent detection with LUIS

The `MainDialog` class uses a waterfall dialog pattern to process each incoming message. The first step calls LUIS to classify the customer's message into an intent.

```csharp
private async Task<DialogTurnResult> IntroStepAsync(
    WaterfallStepContext stepContext,
    CancellationToken cancellationToken)
{
    if (_luisRecognizer.IsConfigured)
    {
        // Call LUIS to classify the customer message into an intent.
        var luisResult = await _luisRecognizer.RecognizeAsync<SmartAssistModel>(
            stepContext.Context, cancellationToken);

        // Route to the appropriate operation based on the top-scoring intent.
        switch (luisResult.TopIntent().intent)
        {
            case SmartAssistModel.Intent.PrinterNoise:
                // Fetch similar cases for this intent.
                await SimilarCaseOperation.GetSimilarCases(stepContext, cancellationToken);
                break;
            default:
                // Fall back to knowledge article search.
                await KBSearchOperation.SearchKnowledgeArticles(stepContext, cancellationToken);
                break;
        }
    }
    else
    {
        // LUIS is not configured. Fall back to keyword-based KB search.
        await KBSearchOperation.SearchKnowledgeArticles(stepContext, cancellationToken);
    }

    return await stepContext.NextAsync(null, cancellationToken);
}
```

If LUIS isn't configured (the `LuisAppId` and `LuisAPIKey` values are empty in `appsettings.json`), the agent falls back to a keyword-based knowledge article search. This means you can use the sample without LUIS for a basic knowledge article recommendation scenario.

### Querying Dataverse for knowledge articles

The `DynamicsDataAccessLayer` class handles authentication and API calls to Dataverse. It uses client credential authentication with the app registration you created in Microsoft Entra ID.

```csharp
// Authenticate to Dataverse using the app registration credentials
// from appsettings.json (ClientId and ClientSecret).
var authenticationContext = new AuthenticationContext(authority);
var clientcred = new ClientCredential(clientId, clientSecret);
var authenticationResult =
    await authenticationContext.AcquireTokenAsync(organizationUrl, clientcred);
return authenticationResult.AccessToken;
```

Once authenticated, the agent calls the `FullTextSearchKnowledgeArticle` action to find relevant articles based on the customer's message text.

```csharp
// Call the FullTextSearchKnowledgeArticle unbound action in Dataverse.
var fullTextKBSearchUrl =
    organizationUrl + "/api/data/v9.1/FullTextSearchKnowledgeArticle";

var requestBody = new
{
    SearchText = searchText,
    UseInflection = true,
    RemoveDuplicates = true,
    StateCode = 3, // Published articles only
    QueryExpression = new
    {
        ColumnSet = new
        {
            Columns = new[] { "title", "isinternal", "description",
                              "articlepublicnumber", "modifiedon",
                              "statecode", "keywords" }
        }
    }
};
```

The `StateCode = 3` filter ensures only published knowledge articles are returned. The response is a collection of knowledge article records that the agent then formats as adaptive cards.

### Building adaptive cards for recommendations

The agent constructs adaptive cards to display each recommendation in the representative's smart assist pane. Each card typically includes a title, description, and one or more action buttons. The Dynamics 365 Contact Center client renders these cards natively in the productivity pane.

The following example shows the structure of an adaptive card for a knowledge article recommendation. The card includes two built-in custom actions: `OpenForm` to open the article record and `SendKB` to send the article link to the customer.

```json
{
  "type": "AdaptiveCard",
  "version": "1.0",
  "body": [
    {
      "type": "TextBlock",
      "text": "KB: Printer produces loud noise during startup",
      "weight": "Bolder"
    },
    {
      "type": "TextBlock",
      "text": "Article KA-01045 | Modified: 2025-01-15",
      "isSubtle": true,
      "spacing": "None"
    }
  ],
  "actions": [
    {
      "type": "Action.Submit",
      "title": "Open",
      "data": {
        "CustomAction": "OpenForm",
        "CustomParameters": {
          "entityName": "knowledgearticle",
          "entityId": "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
          "data": {}
        }
      }
    },
    {
      "type": "Action.Submit",
      "title": "Send to customer",
      "data": {
        "CustomAction": "SendKB",
        "CustomParameters": {
          "kbLink": "https://yourportal.powerappsportals.com/knowledgebase/article/KA-01045/en-us"
        }
      }
    }
  ]
}
```

The `CustomAction` and `CustomParameters` properties are processed by the Dynamics 365 Contact Center client. `OpenForm` opens the specified entity record in a new session tab. `SendKB` sends the knowledge article link directly to the customer in the active conversation.

> [!TIP]
> You can define custom actions beyond `OpenForm` and `SendKB` by creating web resources and uploading them to the **Active Conversation** form. Learn more in [Implement a custom scenario for smart assist agent](smart-assist-scenario).

### Configuration in appsettings.json

The `appsettings.json` file contains the settings the agent needs to connect to Azure Bot Service, LUIS, and Dataverse. The following table describes each setting group.

| Setting | Description |
| --- | --- |
| `MicrosoftAppId` | The application (client) ID from your Azure Bot resource registration. |
| `MicrosoftAppPassword` | The client secret generated for your Azure Bot resource. |
| `LuisAppId` | The LUIS app ID. Leave blank if you aren't using intent detection. |
| `LuisAPIKey` | The LUIS authoring or prediction key. |
| `LuisAPIHostName` | The LUIS endpoint hostname (for example, `westus.api.cognitive.microsoft.com`). |
| `ClientId` | The application (client) ID of the Microsoft Entra app registration used to authenticate to Dataverse. |
| `ClientSecret` | The client secret for the Entra app registration. |
| `OrganizationUrl` | The URL of your Dynamics 365 environment (for example, `https://yourorg.crm.dynamics.com`). |
| `TenantId` | Your Microsoft Entra tenant ID. |

> [!IMPORTANT]
> The Entra app registration used for `ClientId` must have the appropriate Dataverse application user and security role configured to read knowledge articles and case records. Learn more in [Create an application user](/en-us/power-platform/admin/manage-application-users).

## Sample agent that displays knowledge article recommendations

For setting up a sample for smart assist agent for displaying knowledge article recommendations to the representative, please see the instructions mentioned in the sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file. 

For information on how to create a knowledge article using template, see [Create a knowledge article using a template](create-knowledge-article-using-template.md).

## Sample agent that displays similar case recommendations

After setting up a sample agent using above steps, you can configure your agent to show similar case recommendations for "printer noise" using the instructions mentioned in the topic [Implement a custom scenario](smart-assist-scenario.md).

> [!IMPORTANT]
> See this administrator guide topic on how to enable smart assist: [Smart assist for representatives](../administer/smart-assist.md). It provides instructions on how to create an agent user, how to add a smart assist agent to a workstream and how to enable a productivity pane.

> [!div class="nextstepaction"]
> [See Next: Implement a custom scenario for smart assist agent](smart-assist-scenario.md)

## Related information

[Sample code: Build a smart assist agent](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot)<br />
[Smart assist for representatives](../administer/smart-assist.md)<br />
[Create an agent with Azure bot service](/azure/bot-service/abs-quickstart)<br />
[Automate tasks with macros](../administer/macros.md)<br />
[Integrate an Azure agent](../configure-bot.md)<br />
[Create knowledge article template](../use/create-templates-knowledge-article.md)<br />
[Client API reference for model driven apps](/powerapps/developer/model-driven-apps/clientapi/reference)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
