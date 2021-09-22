---
title: "Enable an Azure bot to escalate and end conversations | MicrosoftDocs"
description: "Use this topic to understand how to program an Azure bot to route a conversation to a human agent in Omnichannel for Customer Service."
ms.date: 09/23/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# Enable an Azure bot to escalate and end conversations

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic describes how to program an Azure bot in Omnichannel for Customer Service to route a conversation to a human agent. It also describes how to program the bot to end a conversation.

> [!NOTE]
> Bot agents are not supported in consult mode.

## Prerequisites

You must ensure the following conditions are met to onboard an Azure bot to Omnichannel for Customer Service as an agent.

- The bot must be developed using [Microsoft Bot Framework](https://dev.botframework.com).
- The bot must be registered with [Azure Bot Service](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0).
- The bot must be configured to [have Microsoft Teams as a supported channel](/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0).

<a name="bkmk_EngageBot"></a>

## Engage an Azure bot

To send messages to Omnichannel for Customer Service, add the following code statement to the bot code.

```csharp
OmnichannelBotClient.BridgeBotMessage(turnContext.Activity);
```

## Escalate a conversation to a human agent

In Omnichannel for Customer Service, an Azure bot can escalate the current conversation to a human agent. The routing of the conversation to the new agent depends on the routing rule that is configured for the workstream. During the transfer of the conversation from the bot to the human agent, the bot can set context items that can be used by skill identification rules to identify new skills, and append them to the existing skills list for the conversation.

> [!Note]
> Skill-based routing should be enabled.

The primary way a bot can dictate how the conversation will be routed is by using the Omnichannel for Customer Service context variables that are associated with the chat. The bot can send out a list of context variables and the values to which they need to be updated along with the escalation request. Omnichannel for Customer Service will then update the context variables to the specified values and rerun the routing engine. This ensures that an escalated chat is routed to the right queue. 

After the agent accepts the request, the chat transcript of the bot's conversation with the customer is visible on the agent’s conversation widget. The agent can then continue the chat with the customer.

## End a conversation

The Azure bot can choose to end the conversation if it determines that the customer’s queries have been answered or if the customer is no longer responding. The bot can send an `EndConversation` request to Omnichannel for Customer Service.

When the bot ends the conversation with the customer, it can link the case number with the conversation, so that the next time a conversation is started up with the customer, the agent can view all case history using the case number that's already linked with the conversation. This saves valuable time for the customer and the agent.

> [!Note]
> The bot can create the case number or obtain it from the customer. When the conversation ends, the case number is attached to the conversation based on the customer name, email address, and telephone number.

## Sample code for escalating and ending conversations

Perform the following steps to configure an Azure bot that is capable of escalating a conversation to a human agent.

1. Implement a command class to model escalate and end conversation tasks.

The sample code is as follows.

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

2. Implement an Omnichannel for Customer Service client class to set the command context. 

The sample code is as follows.

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

3. Call the appropriate client method in the Bot ActivityHandler class.
   
   Change the `escalate` and `endconversation` command criteria based on your requirements. 
   
   Add the code statement `OmnichannelBotClient.BridgeBotMessage(turnContext.Activity);` in your bot code to send messages to Omnichannel for Customer Service. More information: [Engage a bot](#bkmk_EngageBot)

The sample code is as follows.

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
> [!NOTE]
> The method `OmnichannelBotClient.BridgeBotMessage` in the preceding sample code must be called for every Activity message that's sent to the customer.

The dictionary `contextVars` contains all the Omnichannel for Customer Service context variable name value pairs that you want to update as part of the escalation request. Here `BotHandoffTopic` is the context variable name and the **CreditCard** is the context variable value. If there is an agent queue with the rule **BotHandoffTopic** equals to **CreditCar**, then this escalated chat will be routed to that queue.

The context variable name is a string. The context variable value must be of type Integer or String, and should be passed as Dictionary<string, object> during escalation. The sample code is as follows.

```csharp
Dictionary<string, Object> keyValues = new Dictionary<string, object>() {
{ "BotHandoffTopic", "CreditCard" },
{ "IDNumber", 101}
}
```

The bot can also send an escalation summary that'll be visible to the agent after they accept the escalated chat request. To send the summary, set the activity text appropriately in the escalation Activity message. Note that this will only be visible to the human agent and not to the customer.

## Best practices for Azure bot configuration

You should consider the following points when you configure the Azure bot agent in Omnichannel for Customer Service:

- In a queue, if both bots and human agents are available, set the bot’s capacity higher than all agents. A bot’s capacity is not reduced even after a work item is assigned to it. This ensures that any chat routed to the queue will be picked up by the bot first.

- In case of bot escalation, make sure that context variables that the bot is updating and the corresponding routing rules are correctly matched.

- If a chat that's escalated by the bot comes to the same queue due to incorrect configurations or due to failure in updating context variables, the bot will not be assigned the same chat again. This is to ensure that the chat does not end up in an infinite loop. Therefore, some human agents should be configured as backup in the bot queue to handle such chats.

- Unlike other Omnichannel for Customer Service agents, bots are not added to a `default` queue at the outset. They are added from the Omnichannel Administration app.

## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, please refer to the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### See also

[Integrate a bot](configure-bot.md)  
[Create context variables](create-workstreams.md#configure-context-variables)  
[Azure Bot Service](/azure/bot-service/?view=azure-bot-service-4.0)  
[Connect a bot to channels](/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0)  
[Bring your own custom messaging channel: Direct Line Bot](bring-your-own-channel.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
