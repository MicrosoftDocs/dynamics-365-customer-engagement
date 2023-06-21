---
title: "Configure Azure bots to escalate and end conversations | MicrosoftDocs"
description: "Use this article to understand how to program Azure bots to route conversations to human agents and also end conversations in Omnichannel for Customer Service."
ms.date: 07/29/2022
ms.topic: reference
author: neeranelli
ms.author: nenellim
---
# Configure Azure bots to escalate and end conversations

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article explains how you can program an Azure bot to route a conversation to a human agent in Omnichannel for Customer Service. It also describes how to program the bot to end the conversation.

> [!IMPORTANT]
> - Bots can receive conversations only if they're added to push-based workstreams.
> - Bot agents are not supported in consult mode.

## Prerequisites

- You must have an Azure bot that's configured and integrated with Omnichannel for Customer Service. More information: [Integrate an Azure bot](configure-bot-azure.md)
- Skill-based routing should be enabled.

## Escalate a conversation to a human agent

In Omnichannel for Customer Service, a bot can escalate the current conversation to a human agent. The routing of the conversation depends on the routing rule that's configured for the workstream.

When the conversation is transferred from the bot to a human agent, the customer and case details are [automatically identified](record-identification-rule.md) when the agent accepts the escalation request. The bot routes conversations by using the Omnichannel for Customer Service context variables that are associated with the conversation. The bot can send a list of context variables and associated values to Omnichannel for Customer Service, together with the escalation request. The bot can also set context items that can be used by skill finder models to identify new skills and append them to the existing skills list for the conversation. Omnichannel for Customer Service will then update the context variables with the specified values, and run the routing engine again. This ensures that the escalated conversation is routed to the right queue. For information on the context items and variable names, see [Link customer and case to conversations when bot escalates or ends conversations](record-identification-rule.md#link-customer-and-case-to-conversations-when-bot-escalates-or-ends-conversations).

After the agent accepts the escalation request, the transcript of the bot's conversation with the customer is visible on the agent’s conversation widget. The agent can then continue the conversation with the customer.

> [!NOTE]
> The conversation summary won't be visible to the customer.

## End a conversation

The Azure bot can choose to end the conversation if it determines that the customer’s questions have been answered, or if the customer is no longer responding. The bot can send an `EndConversation` request to Omnichannel for Customer Service.

## Sample code

This section includes code samples that you can use to configure an Azure bot to escalate and end conversations.

1. Implement a command class to model tasks related to escalating and ending conversations.

The sample code is as follows.

```csharp
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EchoBot.OmniChannel
{
    /// <summary>
    /// Command types that bot can send to Omnichannel
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
        /// Type of action that bot can send to Omnichannel
        /// </summary>
        [DataMember(Name = "type")]
        public CommandType Type { get; set; }

        /// <summary>
        /// Dictionary of Workstream Context variable and value pairs to be sent to Omnichannel for Customer Service
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
        /// <param name="contextVars">Omnichannel for Customer Service workstream context variable value pairs</param>
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
        /// Adds Omnichannel end conversation context to the bot's reply activity.
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
   
   Change the `Escalate` and `EndConversation` command criteria based on your requirements.
   
   Add the code statement `OmnichannelBotClient.BridgeBotMessage(turnContext.Activity);` in your bot code to send messages to Omnichannel for Customer Service. This method must be called for every Activity message that's sent to the customer.

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
                if (turnContext.Activity.Text.Equals("escalate", StringComparison.InvariantCultureIgnoreCase))
                {
                    Dictionary<string, object> contextVars = new Dictionary<string, object>() { { "Bo-tHandoffTopic", "CreditCard" } };
                    OmnichannelBotClient.AddEscalationContext(replyActivity, contextVars);
                }
                // Replace with your own condition for bot end conversation
                else if (turnContext.Activity.Text.Equals("endconversation", StringComparison.InvariantCultureIgnoreCase))
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

The dictionary `contextVars` contains all the Omnichannel for Customer Service context variable name value pairs that you want to update as part of the escalation request. Here `BotHandoffTopic` is the context variable name and **CreditCard** is the context variable value. If there's an agent queue with the rule **BotHandoffTopic** equals **CreditCar**, then this escalated chat will be routed to that queue.

The context variable name is of type String. The context variable value must be of type Integer or String, and should be passed as Dictionary<string, object> during escalation. The sample code is as follows.

```csharp
Dictionary<string, Object> keyValues = new Dictionary<string, object>() {
{ "BotHandoffTopic", "CreditCard" },
{ "IDNumber", 101}
}
```

The bot can also send an escalation summary that'll be visible only to the agent after the escalated chat request is accepted. To send the summary, set the activity text appropriately in the escalation Activity message.

### See also

[Integrate an Azure bot](configure-bot-azure.md)  
[Add context variables](manage-context-variables.md#add-context-variables)  
[Azure Bot Service](/azure/bot-service/?view=azure-bot-service-4.0&preserve-view=true)  
[Connect a bot to channels](/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0&preserve-view=true)  
[Bring your own custom messaging channel: Direct Line Bot](bring-your-own-channel.md)  
[Best practices for configuring Azure and Power Virtual Agents bots](configure-bot-best-practices.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
