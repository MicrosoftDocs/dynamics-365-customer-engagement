---
title: "Link customer, case to conversation when bot escalates or ends conversations | MicrosoftDocs"
description: "Use this topic to understand how to link customer and case to conversation when bot escalates to human agent."
ms.date: 10/25/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# Link customer and case to conversations when bot escalates or ends conversations

When a bot ends a conversation with a customer, the bot can link the case number to the conversation. The bot can create a new case number or obtain an existing one from the customer based on the customer name, email address, or telephone number. 

If a bot conversation needs to be escalated to a human agent, the bot can link the customer and case number to the conversation so that when the human agent accepts the escalation request, all relevant customer and case information is available to the agent in the customer summary section. The escalation summary gives the human agent the necessary background information about the escalation; this enables quicker resolution of the customer issue.

To link the customer or case, set the values for the associated attributes, such as the name and phone number. These attributes will be searched for in Dynamics 365 in the corresponding entities, such as customer and case, and the result will be linked to the conversation if a single record is found to be matched. The bot will need to set context parameters for the following that are also set [when the customer is automatically identified](record-identification-rule.md).

| Entity to be linked | Variable name to be set by bot | Attribute for Dynamics 365 entity to match with corresponding variable name in bot |
|------------|----------------|----------------------|
|Account|<ul><li> Name</li><li> Email </li><li> Phone</li></ul> |<ul><li> name</li><li>emailaddress1</li><li>telephone1</li></ul> |
|Contact|<ul><li> Name</li><li> Email </li><li> Phone</li></ul>|<ul><li> name</li><li>emailaddress1</li><li>telephone1</li></ul>|
|Case|CaseNumber|ticketnumber|
||||

To create context variables for Azure and Power Virtual Agents bots, see [Configure context variables for the bot](configure-bot-virtual-agent.md#configure-context-variables-for-the-bot).



### See also

[Configure a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Configure Azure bot](configure-bot.md)  
[Context variables for bots](context-variables-for-bot.md)  
[Identify customers automatically](record-identification-rule.md)
