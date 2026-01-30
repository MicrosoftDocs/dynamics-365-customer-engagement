---
title: Parse event activity JSON to get agent context
description: Use this article to understand how you can parse the activity JSON to extract agent context in Dynamics 365 Contact Center.
ms.date: 12/08/2025
ms.update-cycle: 180-days
ms.topic: reference
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection: bap-ai-copilot
---
# Parse event activity JSON to get agent context

The context messages in Dynamics 365 Contact Center are sent as event activity to AI agents. Context information such as customer info, live work item, or conversation ID, is sent to the agent as part of an activity JSON. The JSON can be of type **startConversation** for most channels and **ConversationUpdate** for voice conversations. 

## Fetch and use context for agents in your agent code

 To process these context messages, use activity handlers and override them in your agent code. For information on how to use activity handlers, see [Event-driven conversations using an activity handler](/azure/bot-service/bot-activity-handler-concept?view=azure-bot-service-4.0&tabs=csharp&preserve-view=true).

In the following example, when the event activity is received, the `OnEventActivityAsync` method is called to fetch and use the context.

```CSharp
namespace Microsoft.CCaaS.MessagingRuntime.TestAgent.Agents;

public class TestAgentApplication : AgentApplication
{
    private readonly IContextManager _contextManager;

    public TestAgentApplication(AgentApplicationOptions options, IContextManager contextManager) : base(options)
    {
        _contextManager = contextManager ?? throw new ArgumentNullException(nameof(contextManager));
        OnConversationUpdate(ConversationUpdateEvents.MembersAdded, OnMembersAddedAsync);
        OnEvent(ActivityTypes.Event, OnEventActivityAsync);
        OnActivity(ActivityTypes.Message, OnMessageActivityAsync, rank: RouteRank.Last);
    }

    protected async Task OnMessageActivityAsync(ITurnContext turnContext, ITurnState turnState, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(turnContext);
        var text = turnContext.Activity.Text?.ToLower(CultureInfo.InvariantCulture);
        var responseActivity = Activity.CreateMessageActivity();
        Responses.BuildCustomerFileAttachmentResponse(turnContext, responseActivity);
    }
}
```

## Next steps

[Code samples for parsing activity JSON](bot-context-json-samples.md)  

### Related information

[setContextProvider](reference/methods/setContextProvider.md)  
[Integrate an Azure agent](../administer/configure-bot-azure.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
