---
title: Configure Azure agents to escalate and end conversations
description: Learn how to program agents in Azure to route conversations to representatives and also end conversations in Dynamics 365 Contact Center.
ms.date: 12/08/2025
ms.update-cycle: 180-days
ms.topic: reference
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection: bap-ai-copilot
---
# Configure Azure agents to escalate and end conversations

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article explains how you can program an AI agent(agent) in Azure to route a conversation to a customer service representative (service representative or representative) in Dynamics 365 Contact Center. It also describes how to program the agent to end the conversation.

> [!IMPORTANT]
> - Agents can receive conversations only if they're added to push-based workstreams.
> - AI agents aren't supported in consult mode.

## Prerequisites

- You must have an agent in Azure that's configured and integrated with Dynamics 365 Contact Center. Learn more in [Integrate an Azure agent](../administer/configure-bot-azure.md)
- Skill-based routing should be enabled.

## Escalate a conversation to a representative

In Dynamics 365 Contact Center, an agent can escalate the current conversation to a representative. The routing of the conversation depends on the routing rule that's configured for the workstream.

When the representative accepts the escalation request and the conversation is transferred from the AI agent, the customer and case details are [automatically identified](../administer/record-identification-rule.md). The agent routes conversations by using the Dynamics 365 Contact Center context variables associated with the conversation. The agent can send a list of context variables and associated values to Dynamics 365 Contact Center, together with the escalation request. The agent can also set context items that can be used by skill finder models to identify new skills and append them to the existing skills list for the conversation. Dynamics 365 Contact Center then updates the context variables with the specified values, and runs the routing engine again. The system makes sure that the escalated conversation is routed to the right queue. Learn more about the context items and variable names in [Link customer and case to conversations when agent escalates or ends conversations](../administer/record-identification-rule.md#link-customer-and-case-to-conversations-when-agent-escalates-or-ends-conversations).

After the representative accepts the escalation request, the transcript of the agent's conversation with the customer is visible on the representative’s conversation widget. The representative can then continue the conversation with the customer.

> [!NOTE]
> The conversation summary isn't visible to the customer.

## End a conversation

The Azure agent can choose to end the conversation if it determines that the customer’s questions have been answered, or if the customer is no longer responding. The agent can send an `EndConversation` request to Dynamics 365 Contact Center.

## Sample code

This section includes code samples that you can use to configure an Azure bot to escalate and end conversations.

1. Implement a command class to model tasks related to escalating and ending conversations.

1. Implement an Omnichannel client class to set the command context.

    The sample code is as follows.

    ```csharp
    /// <summary>
    /// Send end of conversation context to user and agent.
    /// </summary>
    public static async Task EndConversationAsync(ITurnContext turnContext, CancellationToken cancellationToken)
    {
        IActivity customerFacingActivity = Activity.CreateMessageActivity();
        customerFacingActivity.Text = "Thanks for talking with me. Have a good day. Bye.";
        BridgeBotMessage(customerFacingActivity);

        IActivity agentFacingActivity = Activity.CreateMessageActivity();
        agentFacingActivity.Text = "Ending the conversation as per customer request.";
        AddContext(CommandType.EndConversation, agentFacingActivity);

        List<IActivity> messageActivities = new List<IActivity>
        {
            customerFacingActivity,
            agentFacingActivity
        };

        await turnContext.SendActivitiesAsync(messageActivities.ToArray(), cancellationToken);
    }

    /// <summary>
    /// Send escalation context to user and agent.
    /// </summary>
    public static async Task EscalateConversationAsync(ITurnContext turnContext, IContextManager contextManager, CancellationToken cancellationToken)
    {
        IActivity customerFacingActivity = Activity.CreateMessageActivity();
        customerFacingActivity.Text = "Perfect I’ll transfer you now";
        BridgeBotMessage(customerFacingActivity);

        IActivity agentFacingActivity = Activity.CreateMessageActivity();
        agentFacingActivity.Text = GetEscalationSummary(turnContext, contextManager);
        AddContext(CommandType.Escalate, agentFacingActivity, contextManager.GetContext(turnContext.Activity.Conversation.Id));

        List<IActivity> messageActivities = new List<IActivity>
        {
            customerFacingActivity,
            agentFacingActivity
        };

        await turnContext.SendActivitiesAsync(messageActivities.ToArray(), cancellationToken);
    }
    ```

1. Call the appropriate client method in the Bot ActivityHandler class.

1. Change the `Escalate` and `EndConversation` command criteria based on your requirements.

1. Add the code statement `OmnichannelBotClient.BridgeBotMessage(turnContext.Activity);` in your bot code to send messages to Dynamics 365 Contact Center. This method must be called for every Activity message that's sent to the customer.

    The sample code is as follows.

    ```csharp
    protected async Task OnMessageActivityAsync(ITurnContext turnContext, ITurnState turnState, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(turnContext);
        var text = turnContext.Activity.Text?.ToLower(CultureInfo.InvariantCulture);
        var responseActivity = Activity.CreateMessageActivity();
        Responses.BuildCustomerFileAttachmentResponse(turnContext, responseActivity);

        if (string.IsNullOrEmpty(text))
        {
            if (turnContext.Activity.Value is JsonElement jsonElement)
            {
                var activityResponseValue = turnContext.Activity.Value;
                responseActivity.Text = $"You replied with value: {Environment.NewLine}{activityResponseValue}";
            }
        }
        else if (text.StartsWith("echo:", StringComparison.OrdinalIgnoreCase))
        {
            responseActivity.Text = text.Replace("echo:", "", StringComparison.OrdinalIgnoreCase);
        }
        else if (text.Contains("ac ", StringComparison.OrdinalIgnoreCase))
        {
            Responses.BuildAdaptiveCardResponse(responseActivity, text);
        }
        else
        {
            switch (text)
            {
                case Commands.Agent:
                    await OmnichannelAgentClient.EscalateConversationAsync(turnContext, _contextManager, cancellationToken);
                    return;
                case Commands.AnimationCard:
                case Commands.AudioCard:
                case Commands.FaultySigninCard:
                case Commands.HeroCard:
                case Commands.HeroCardIMBack:
                case Commands.HtmlList:
                case Commands.Markdown:
                case Commands.ReceiptCard:
                case Commands.SigninCard:
                case Commands.ThumbnailCard:
                case Commands.VideoCard:
                    Responses.BuildStructuredCardResponse(responseActivity, text);
                    break;
                case Commands.AttachmentFromC2:
                    responseActivity.Text = $"Attachment type has been identified";
                    break;
                case Commands.Debug:
                    Responses.BuildDebugContextResponseText(_contextManager, turnContext, responseActivity);
                    break;
                case Commands.EndChat:
                    await OmnichannelAgentClient.EndConversationAsync(turnContext, cancellationToken);
                    break;

                case Commands.Help:
                    Responses.BuildHelpResponse(responseActivity);
                    break;
                default:
                    Responses.BuildDidNotUnderstandResponse(responseActivity, text);
                    break;
            }
        }
        await OmnichannelAgentClient.BridgeAndSendActivityAsync(turnContext, responseActivity, cancellationToken);
    }
    ```

    The dictionary `contextVars` contains all the context variable name value pairs that you want to update as part of the escalation request. Here `BotHandoffTopic` is the context variable name and **CreditCard** is the context variable value. If there's a representative queue with the rule **BotHandoffTopic** equals **CreditCar**, then this escalated chat is routed to that queue.

    The context variable name is of type String. The context variable value must be of type Integer or String, and should be passed as Dictionary<string, object> during escalation. The sample code is as follows.

    ```csharp
    Dictionary<string, Object> keyValues = new Dictionary<string, object>()
    {
        { "BotHandoffTopic", "CreditCard" },
        { "IDNumber", 101}
    }
    ```

The agent can also send an escalation summary that's visible to the representative only after they accept the escalated chat request. To send the summary, set the activity text in the escalation message.

### Related information

[Integrate an Azure agent](../administer/configure-bot-azure.md)  
[Add context variables](../administer/manage-context-variables.md#add-context-variables)  
[Azure Bot Service](/azure/bot-service/?view=azure-bot-service-4.0&preserve-view=true)  
[Connect an agent to channels](/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0&preserve-view=true)  
[Integrate your own custom channel using Direct Line](bring-your-own-channel.md)  
[Best practices for configuring Azure and Copilot Studio agents](../administer/configure-bot-best-practices.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
