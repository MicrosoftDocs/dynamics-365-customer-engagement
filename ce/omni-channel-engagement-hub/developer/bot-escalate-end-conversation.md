---
title: "Enable a bot to escalate and end conversation| Microsoft Docs"
description: "Read how a bot in Omni-channel Engagement Hub can be used to escalate a conversation to a human agent."
keywords: ""
ms.date: 04/30/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: 1b4a3d99-9d2c-4277-9dc8-1c5f12a77f95
author: susikka
ms.author: susikka
manager: shujoshi
---
# Enable a bot with Omni-channel Engagement Hub

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The topic illustrates how you can integrate a bot that can start a conversation with a customer and then shift the conversation to a human agent as required, with Omni-channel Engagement Hub.

## Prerequisites

You must ensure the following conditions are met to onboard a bot to Omni-channel Engagement Hub as an agent.

-	The bot must be developed using [Microsoft Bot Framework](https://dev.botframework.com).
-	The bot must be registered with [Azure Bot Service](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0).
-	The bot must be configured to [have Microsoft Teams as a supported channel](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0).

## Escalating a conversation to a human agent

In Omni-channel Engagement Hub, a bot can escalate the current conversation to a human agent. The routing to the new agent depends on the routing rule that is configured for the work stream. The primary way a bot can dictate how the conversation will be routed is by using Omni-channel Engagement Hub context variables that are associated with the chat. A bot can send out a list of context variables and the values to which they need to be updated along with the escalation request. Omni-channel Engagement Hub service will update the context variables to the specified values and then rerun the routing engine. This will ensure that an escalated chat will be routed to the proper queue. Once the agent accepts the invitation, the chat transcript with the bot will be visible on the agent’s conversation widget. The agent can then continue the chat with the customer.

## End a conversation

An Omni-channel Engagement Hub bot can choose to end the conversation if it determines that the customer’s queries have been answered or if the customer is no longer responding. The bot can do so by sending an `endconversation` request to Omni-channel Engagement Hub.

### Sample code for escalation management

Follow the procedure given below to configure a bot that is capable of escalating a conversation to a human agent.

1.	Implement a command class to model escalate and endconversation. The sample code is given below.

```csharp
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EchoBot.OmniChannel
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CommandType
    {
        [EnumMember(Value = "Escalate")]
        Escalate = 0,
        [EnumMember(Value = "EndConversation")]
        EndConversation = 1,
    }
    /// <summary>
    /// Action
    /// </summary>
    [DataContract]
    public class Command
    {
        /// <summary>
        /// Type of action
        /// </summary>
        [DataMember(Name = "type")]
        public CommandType Type { get; set; }

        /// <summary>
        /// Dictionary of context items
        /// </summary>
        [DataMember(Name = "context")]
        public Dictionary<string, object> Context { get; set; }
    }
}
```

2. Implement an Omni-Channel Engagement Hub client class to set the command context. The sample code is given below.

```csharp
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace EchoBot.OmniChannel
{
    /// <summary>
    /// Extension class for middleware imlpementation management
    /// </summary>
    public static class OmnichannelBotClient
    {
        private const string DeliveryMode = "deliveryMode";
        private const string Bridged = "bridged";
        private const string Tags = "tags";

        /// <summary>
        /// Stores context variables in turn state for escalate scenario
        /// </summary>
        /// <param name="turnContext">User turn context</param>
        /// <param name="contextVars">context variables</param>
        public static void AddEscalationContext(IActivity activity, Dictionary<string, object> contextVars)
        {
            Command command = new Command
            {
                Type = CommandType.Escalate,
                Context = contextVars
            };
            string serializedString = JsonConvert.SerializeObject(command);
            if (activity.ChannelData != null)
            {
                (activity as IActivity).ChannelData[Tags] = serializedString;
            }
            else
            {
                activity.ChannelData = new Dictionary<string, object>() { { Tags, serializedString } };
            }
        }

        /// <summary>
        /// Stores context variables in turn state for end conversation scenario
        /// </summary>
        /// <param name="turnContext"></param>
        /// <param name="turnContext">User turn context</param>
        /// <param name="contextVars">context variables</param>
        public static void AddEndConversationContext(IActivity activity, Dictionary<string, object> contextVars)
        {
            Command command = new Command
            {
                Type = CommandType.EndConversation,
                Context = contextVars
            };
            string serializedString = JsonConvert.SerializeObject(command);
            if (activity.ChannelData != null)
            {
                (activity as IActivity).ChannelData[Tags] = serializedString;
            }
            else
            {
                activity.ChannelData = new Dictionary<string, object>() { { Tags, serializedString } };
            }
        }

        /// <summary>
        /// Sets delivery mode for bot as bridged so that Customer can see bot messages
        /// </summary>
        /// <param name="ITurnContext">User turn context</param>
        public static void BridgeBotMessage(IActivity activity)
        {
            if (activity.ChannelData != null)
            {
                (activity as IActivity).ChannelData[DeliveryMode] = Bridged;
            }
            else
            {
                activity.ChannelData = new Dictionary<string, object>() { { DeliveryMode, Bridged } };
            }
        }
    }
}

```

3. In the Bot ActivityHandler class, call the appropriate client method. The sample code is given below. Change the `escalate` and `endconversation` command criteria to something that suits your requirements.

```csharp
protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
{
if (turnContext.Activity.Type == ActivityTypes.Message)
       {
       	IActivity replyActivity = MessageFactory.Text($"Echo: {turnContext.Activity.Text}");
if (turnContext.Activity.Text.Equals("escalate", StringComparison.InvariantCultureIgnoreCase))
                {
                    Dictionary<string, object> contextVars = new Dictionary<string, object>() { { "BotHandoffTopic", "CreditCard" } };
                    OmnichannelBotClient.AddEscalationContext(replyActivity, contextVars);
                }
                else if (turnContext.Activity.Text.Equals("endconversation", StringComparison.InvariantCultureIgnoreCase))
                {
                    Dictionary<string, object> contextVars = new Dictionary<string, object>();
                    OmnichannelBotClient.AddEndConversationContext(replyActivity, contextVars);
                }
                else
                {
                    OmnichannelBotClient.BridgeBotMessage(replyActivity);
                }
                await turnContext.SendActivityAsync(replyActivity, cancellationToken);
            }
        }

```
The dictionary `contextVars` contains all the Omni-channel Engagement Hub context variable name value pairs that you want to update as part of the escalation request. Here `BotHandoffTopic` is the context variable name and the “CreditCard” is the context variable value. If there is an agent queue with the rule “BotHandoffTopic equals to “CreditCard”, then this escalated chat will be routed to that queue. The bot can also send an escalation summary which will be visible to the agent once he/she accepts the escalated chat request. To send the summary, set the activity text appropriately in the escalation Activity message. This will only be visible to the human agent and not to the customer.

> [!NOTE]
> Note the method call to `OmnichannelBotClient.BridgeBotMessage` in the sample code above. This needs to be called for every Activity message that is sent to the customer.

## Best practices for bot configuration

You should consider the following points when modeling the bot agent in Omni-channel Engagement Hub:

-	In a queue, if there are both bots and human agents, set the bot’s capacity higher than all agents. A bot’s capacity is not reduced even after a work item is assigned to it. This ensures that any chat routed to the queue will be picked up by the bot first.     

-	In case of bot escalation, make sure that context variables that the bot is updating and the corresponding routing rules are correctly matched.     

-	If a chat that is escalated by the bot comes to the same queue due to incorrect configurations or due to failure in updating context variables, the bot will not be assigned the same chat again. This is to ensure that the chat does not end up in an infinite loop. Therefore, some human agents should be configured as backup in the bot queue to handle such chats.     

-	Bot agents are not supported in consult mode in the current release.     

-	Unlike other Omni-channel Engagement Hub agents, bots are not added to a `default` queue at the outset. But, they can be added from the Administration hub, if required.

## See also

[Work with bots](../administrator/configure-bot.md)<br />
[Azure Bot Service](https://docs.microsoft.com/en-us/azure/bot-service/?view=azure-bot-service-4.0)<br />
[Connect a bot to channels](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0)