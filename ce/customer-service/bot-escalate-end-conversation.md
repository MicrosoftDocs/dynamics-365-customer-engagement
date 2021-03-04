---
title: "Enable a bot to escalate and end conversation| Microsoft Docs"
description: "How a bot in Omnichannel for Customer Service can be used to escalate a conversation to a human agent."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 03/04/2021
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# Enable a bot to escalate and end conversation

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic describes how to program a bot in Omnichannel for Customer Service to route a conversation to a human agent. It also describes how to program the bot to end a conversation.

> [!NOTE]
> Bot agents are not supported in consult mode in the current release.

## Prerequisites

You must ensure the following conditions are met to onboard a bot to Omnichannel for Customer Service as an agent.

- The bot must be developed using [Microsoft Bot Framework](https://dev.botframework.com).
- The bot must be registered with [Azure Bot Service](https://docs.microsoft.com/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0).
- The bot must be configured to [have Microsoft Teams as a supported channel](https://docs.microsoft.com/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0).

<a name="bkmk_EngageBot"></a>

## Engage a bot

To send messages to Omnichannel for Customer Service, you need to add the following code statement to the bot code.

```csharp
OmnichannelBotClient.BridgeBotMessage(turnContext.Activity);
```

## Escalate a conversation to a human agent

In Omnichannel for Customer Service, a bot can escalate the current conversation to a human agent. The routing to the new agent depends on the routing rule that is configured for the work stream. During the transfer of the conversation from the bot to human agent, the bot can set context items that can be used by skill identification rules to identify new skills and append them to the existing skills list for the conversation.

> [!Note]
> Skill-based routing should be enabled.

The primary way a bot can dictate how the conversation will be routed is by using Omnichannel for Customer Service context variables that are associated with the chat. A bot can send out a list of context variables and the values to which they need to be updated along with the escalation request. Omnichannel for Customer Service will update the context variables to the specified values and then rerun the routing engine. This ensures that an escalated chat is routed to the right queue. After the agent accepts the request, the chat transcript with the bot is visible on the agent’s conversation widget. The agent can then continue the chat with the customer.

## End a conversation

An Omnichannel for Customer Service bot can choose to end the conversation if it determines that the customer’s queries have been answered or if the customer is no longer responding. The bot can send an `EndConversation` request to Omnichannel for Customer Service.

## Sample code for escalation management and ending conversation

Perform the following steps to configure a bot that is capable of escalating a conversation to a human agent.

1. Implement a command class to model escalate and end conversation. The sample code is as follows.

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

2. Implement an Omnichannel for Customer Service client class to set the command context. The sample code is as follows.

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
        /// Adds Omnichannel for Customer Service escalation context to the bot's reply activity.
        /// </summary>
        /// <param name="activity">Bot's reply activity</param>
        /// <param name="contextVars">Omnichannel for Customer Service Workstream context variable value pairs</param>
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

3. In the Bot ActivityHandler class, call the appropriate client method. The sample code is as follows.

Change the `escalate` and `endconversation` command criteria to something that suits your requirements. Add code `OmnichannelBotClient.BridgeBotMessage(turnContext.Activity);` in your bot code to send messages to Omnichannel for Customer Service. More information: [Engage a bot](#bkmk_EngageBot)

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
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
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
The dictionary `contextVars` contains all the Omnichannel for Customer Service context variable name value pairs that you want to update as part of the escalation request. Here `BotHandoffTopic` is the context variable name and the “CreditCard” is the context variable value. If there is an agent queue with the rule “BotHandoffTopic equals to “CreditCard”, then this escalated chat will be routed to that queue. The bot can also send an escalation summary that will be visible to the agent after they accept the escalated chat request. To send the summary, set the activity text appropriately in the escalation Activity message. This will only be visible to the human agent and not to the customer.

> [!NOTE]
> Note the method call to `OmnichannelBotClient.BridgeBotMessage` in the sample code above. This needs to be called for every Activity message that is sent to the customer.

## Best practices for bot configuration

You should consider the following points when modeling the bot agent in Omnichannel for Customer Service:

- In a queue, if there are both bots and human agents, set the bot’s capacity higher than all agents. A bot’s capacity is not reduced even after a work item is assigned to it. This ensures that any chat routed to the queue will be picked up by the bot first.

- In case of bot escalation, make sure that context variables that the bot is updating and the corresponding routing rules are correctly matched.

- If a chat that is escalated by the bot comes to the same queue due to incorrect configurations or due to failure in updating context variables, the bot will not be assigned the same chat again. This is to ensure that the chat does not end up in an infinite loop. Therefore, some human agents should be configured as backup in the bot queue to handle such chats.

- Unlike other Omnichannel for Customer Service agents, bots are not added to a `default` queue at the outset. They are added from the Omnichannel Administration app.

## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, please refer to the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### See also

[Integrate a bot](configure-bot.md)  
[Create context variables](work-streams-introduction.md)  
[Azure Bot Service](https://docs.microsoft.com/azure/bot-service/?view=azure-bot-service-4.0)  
[Connect a bot to channels](https://docs.microsoft.com/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
