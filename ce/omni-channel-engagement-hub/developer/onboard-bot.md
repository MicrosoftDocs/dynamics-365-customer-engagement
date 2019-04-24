---
title: "Onboard a bot to Omni-channel Engagement Hub| Microsoft Docs"
description: "Read how you can integrate a bot with Omni-channel Engagement Hub"
keywords: ""
ms.date: 04/24/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: 1b4a3d99-9d2c-4277-9dc8-1c5f12a77f95
author: susikka
ms.author: susikka
manager: shujoshi
---
# Onboard a bot to Omni-channel Engagement Hub

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The topic illustrates how you can integrate a bot that can start a conversation with a customer then shift the conversation to a human agent as required, with Omni-channel Engagement Hub.

## Prerequisites for a bot to be onboarded to Omni-Channel

Following conditions need to be met for a bot to be onboarded to Omni-Channel as an agent
1.	The bot must be developed using Microsoft Bot Framework
2.	The bot must be registered with Azure bot service
3.	The bot must be configured to have  Teams channel

## How to create your bot’s reply activity 

Bot’s reply activity is sent on Teams channel. Make sure that the channel is enabled on your bot. To create a reply activity, set the required information by following the sample below
 
```csharp
private IActivity CreateOmniChannelReplyActivity(ITurnContext context, string replyText)
{
var incomingMessage = context.Activity;
IActivity replyActivity = Activity.CreateMessageActivity();
       (replyActivity as Activity).Locale = incomingMessage.Locale;
       (replyActivity as Activity).Text = replyText;
ChannelAccount botAccount = new ChannelAccount(incomingMessage.Recipient.Id, incomingMessage.Recipient.Name);
       ChannelAccount userAccount = new ChannelAccount(incomingMessage.From.Id, incomingMessage.From.Name);
       replyActivity.ServiceUrl = incomingMessage.ServiceUrl;
       replyActivity.ChannelId = incomingMessage.ChannelId;
       replyActivity.From = botAccount;
       replyActivity.Recipient = userAccount;
replyActivity.Conversation = new ConversationAccount(id: incomingMessage.Conversation.Id);
return replyActivity;
}
```

## How to send bot’s response to your customer’s end

Every message that the bot sends, will be received by Omni-Channel services by default. To make the bot’s response also visible on the customer’s chat widget, you must set deliveryMode to bridged on the reply activity’s ChannelData. Sample code given below.

```csharp
private IActivity CreateBridgedReplyActivity(ITurnContext context, string replyText)
{
IActivity activity = CreateOmniChannelReplyActivity(context, replyText);
Dictionary<string, object> channelinfo = new Dictionary<string, object>();
       channelinfo.Add("deliveryMode", "bridged");
       activity.ChannelData = channelinfo;
       return activity;
}

```
 
## How Escalation Works

In Omni-Channel a bot can escalate the current conversation to a human agent. The routing to the new agent depends on the routing rule that is configured for the work stream. The primary way a bot can dictate how the conversation will be routed is by using Omni-channel context variables associated to the chat work s. A bot can send out a list of Omni-channel Context variables and the values it needs to be updated to along with the escalate request. Omni-Channel service will update the context variables to the specified values and the rerun the routing engine. This will ensure that escalated chat will be routed to the proper queue. Once the agent accepts the invite, the chat transcript with the bot will be visible on the agent’s conversation widget. The agent can then continue the chat with the customer.

### Sample Code for Escalation

Create a data class called TagModel to represent the bot context

```csharp
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BasicBot.Models
{
    [DataContract]
    public class TagModel
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "context")]
        public Dictionary<string, object> Context { get; set; }
    }
}
```

To Create an escalate activity, set the TagModel type to “Escalate”. Set the Omni-Channel Workstream context variables and values pair in the TagModel context. Once Omni-channel receives the request, it will update the context variables to the specified values and rerun routing rules. Make sure the routing rules are setup correctly to handle the escalation scenarios.

```csharp
private IActivity CreateEscalationReplyActivity(ITurnContext context, string escalationSummary, Dictionary<string, object> contextVarPairs)
{
IActivity activity = CreateOmniChannelReplyActivity(context, escalationSummary);
       TagModel tag = new TagModel
       {
       	Type = "Escalate",
              Context = new Dictionary<string, object>(),
};
tag.Context = contextVarPairs;
Dictionary<string, object> channelinfo = new Dictionary<string, object>();
       channelinfo.Add("tags", JsonConvert.SerializeObject(tag));
activity.ChannelData = channelinfo;
return activity;
}
```
 
The dictionary contextVarPairs contains all the Omni-channel context variable name value pairs that you want to update as part of the escalation request. The bot can also send an escalation summary which will be visible to the agent once he/she accepts the escalated chat request. Here “BotHandoffTopic” is the context variable name and the “CreditCard” is the context variable value. If there is an agent queue with the rule “BotHandoffTopic equals to “CreditCard”, then this escalated chat will be routed to that queue. Sample code to call the escalate method.

```csharp
var contextVarPairs = new Dictionary<string, object>();
contextVarPairs.Add($"BotHandoffTopic", "CreditCard");
IActivity activitiy = CreateEscalationReplyActivity(context, "Conversation Summary: Customer wants to increase credit limit.", contextVarPairs);
``` 
## How End Conversation Works

An Omni-Channel bot can choose to end the conversation if it determines that the customer’s queries have been answered or if the customer is no longer responding. Bot can do so by sending an endconversation request to Omni-Channel.

### Sample Code for Escalation and EndConversation

```csharp
private IActivity CreateEndConversationReplyActivity(ITurnContext context, string endConversationSummary)
{
IActivity activity = CreateOmniChannelReplyActivity(context, endConversationSummary);
       TagModel tag = new TagModel
       {
       	Type = "EndConversation",
              Context = new Dictionary<string, object>(),
};
       Dictionary<string, object> channelinfo = new Dictionary<string, object>();
       channelinfo.Add("tags", JsonConvert.SerializeObject(tag));
       activity.ChannelData = channelinfo;
       return activity;
}
```
 
### Sample code to call the end conversation method.

```csharp
IActivity activity = CreateEndConversationReplyActivity(context, "Customer ended chat");
```
## Guidelines for Modelling Bot configuration

Following points should be kept in mind while modelling the bot agent in Omni-Channel

1.	In a queue, if both bots and human agents are there, set the bot’s capacity higher than any agent. Bot’s capacity is not reduced even after a work item is assigned to it. This will ensure that any chat routed to the queue will be picked by the bot first.
2.	In case of bot escalation, make sure that context variables that bot is updating and routing rules are correctly matched.
3.	In the event a bot escalated chat comes to the same queue due to incorrect configurations or failure to update context variables, the bot will not be assigned the same chat again. This is to ensure that the chat doesn’t end up in an infinite loop. So, it is ideal to have few human agents configured as backup in the bot queue to handle such chats.
4.	Bot agents are not supported in consult mode in current release.
5.	Unlike other Omni-Channel agents, bots are not added to default queue by default. But, they can be added from Omni-Channel Administration hub if required.

## See also

[Work with bots](../administrator/configure-bot.md)