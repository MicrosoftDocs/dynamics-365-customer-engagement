---
title: "Enable a bot to escalate and end conversation| Microsoft Docs"
description: "Read how a bot in Omni-channel Engagement Hub can be used to escalate a conversation to a human agent."
keywords: ""
ms.date: 05/03/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: 1b4a3d99-9d2c-4277-9dc8-1c5f12a77f95
author: susikka
ms.author: susikka
manager: shujoshi
---
# Enable a bot to escalate and end conversation

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The topic illustrates how you can program a bot in Omni-channel Engagement Hub to shift a conversation to a human agent and if required, to end a conversation.

> [!NOTE]
> Bot agents are not supported in consult mode in the current release.     

## Prerequisites

You must ensure the following conditions are met to onboard a bot to Omni-channel Engagement Hub as an agent.

-	The bot must be developed using [Microsoft Bot Framework](https://dev.botframework.com).
-	The bot must be registered with [Azure Bot Service](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0).
-	The bot must be configured to [have Microsoft Teams as a supported channel](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0).

## Escalate a conversation to a human agent

In Omni-channel Engagement Hub, a bot can escalate the current conversation to a human agent. The routing to the new agent depends on the routing rule that is configured for the work stream. The primary way a bot can dictate how the conversation will be routed is by using Omni-channel Engagement Hub context variables that are associated with the chat. A bot can send out a list of context variables and the values to which they need to be updated along with the escalation request. Omni-channel Engagement Hub service will update the context variables to the specified values and then rerun the routing engine. This will ensure that an escalated chat will be routed to the proper queue. Once the agent accepts the invitation, the chat transcript with the bot will be visible on the agent’s conversation widget. The agent can then continue the chat with the customer.

## End a conversation

An Omni-channel Engagement Hub bot can choose to end the conversation if it determines that the customer’s queries have been answered or if the customer is no longer responding. The bot can do so by sending an `EndConversation` request to Omni-channel Engagement Hub.

## Sample code for escalation management and ending conversation

Follow the procedure given below to configure a bot that is capable of escalating a conversation to a human agent.

1.	Implement a command class to model escalate and endconversation. The sample code is given below.

```csharp
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EchoBot.OmniChannel
{
    /// <summary>
    /// Command types that bot can send to Omni-Channel
    /// </summary>
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
        /// Type of action that bot can send to Omni-Channel
        /// </summary>
        [DataMember(Name = "type")]
        public CommandType Type { get; set; }

        /// <summary>
        /// Dictionary of Workstream Context variable and value pairs to be sent to Omni-Channel 
        /// </summary>
        [DataMember(Name = "context")]
        public Dictionary<string, object> Context { get; set; }
    }
}
```

2. Implement an Omni-Channel Engagement Hub client class to set the command context. The sample code is given below.

```csharp
using Microsoft.Bot.Schema;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EchoBot.OmniChannel
{
    /// <summary>
    /// Extension class for middleware implementation management
    /// </summary>
    public static class OmnichannelBotClient
    {
        /// <summary>
        /// Delivery mode of bot's reply activity
        /// </summary>
        private const string DeliveryMode = "deliveryMode";
        /// <summary>
        /// Delivery Mode value bridged
        /// </summary>
        private const string Bridged = "bridged";
        /// <summary>
        /// Custom data tag
        /// </summary>
        private const string Tags = "tags";

        /// <summary>
        /// Adds Omni-channel Engagement Hub escalation context to the bot's reply activity.
        /// </summary>
        /// <param name="activity">Bot's reply activity</param>
        /// <param name="contextVars">Omni-Channel Engagement Hub Workstream context variable value pairs</param>
        public static void AddEscalationContext(IActivity activity, Dictionary<string, object> con-textVars)
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
        /// Adds Omni-channel end conversation context to the bot's reply activity.
        /// </summary>
        /// <param name="activity">Bot's reply activity</param>
        public static void AddEndConversationContext(IActivity activity)
        {
            Command command = new Command
            {
                Type = CommandType.EndConversation,
                Context = new Dictionary<string, object>()
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
        /// <param name="activity">Bot's reply activity</param>
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

3. In the Bot ActivityHandler class, call the appropriate client method. The sample code is given below.

Change the `escalate` and `endconversation` command criteria to something that suits your requirements.

```csharp
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EchoBot.OmniChannel;
using Microsoft.Bot.Schema;

namespace Microsoft.Bot.Builder.EchoBot
{
    public class EchoBot : ActivityHandler
    {
        /// <summary>
        /// This method is called when the bot receives a message.
        /// </summary>
        /// <param name="turnContext">Turn Context object</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns></returns>
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnCon-text, CancellationToken cancellationToken)
        {
            if (turnContext.Activity.Type == ActivityTypes.Message)
            {
                // Replace with your own message
                IActivity replyActivity = MessageFactory.Text($"Echo: {turnContext.Activity.Text}");

                // Replace with your own condition for bot escalation
                if (turnContext.Activity.Text.Equals("escalate", StringCompari-son.InvariantCultureIgnoreCase))
                {
                    Dictionary<string, object> contextVars = new Dictionary<string, object>() { { "Bo-tHandoffTopic", "CreditCard" } };
                    OmnichannelBotClient.AddEscalationContext(replyActivity, contextVars);
                }
                // Replace with your own condition for bot end conversation
                else if (turnContext.Activity.Text.Equals("endconversation", StringCompari-son.InvariantCultureIgnoreCase))
                {
                    OmnichannelBotClient.AddEndConversationContext(replyActivity);
                }
                // Call method BridgeBotMessage for every response that needs to be delivered to the customer.
                else
                {
                    OmnichannelBotClient.BridgeBotMessage(replyActivity);
                }

                await turnContext.SendActivityAsync(replyActivity, cancellationToken);
            }
        }

        /// <summary>
        /// This method is called when there is a participant added to the chat.
        /// </summary>
        /// <param name="membersAdded">Member being added to the chat</param>
        /// <param name="turnContext">TurnContext</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns></returns>
        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurn-Context<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    //Set the bridge mode for every message that needs to be delivered to customer
                    OmnichannelBotClient.BridgeBotMessage(turnContext.Activity); 
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Welcome to Echo Bot."), cancellationToken);
                }
            }
        }
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

-	Unlike other Omni-channel Engagement Hub agents, bots are not added to a `default` queue at the outset. They are added from the Administration hub.

## See also

[Integrate a bot](../administrator/configure-bot.md)<br />
[Azure Bot Service](https://docs.microsoft.com/en-us/azure/bot-service/?view=azure-bot-service-4.0)<br />
[Connect a bot to channels](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0)