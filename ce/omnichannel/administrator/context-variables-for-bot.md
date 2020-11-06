---
title: "Context variables for a bot | MicrosoftDocs"
description: "Context variables to use when configuring a bot in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 11/06/2020 
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Context variables for a bot

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic lists the context variables that you can configure for a bot in Power Virtual Agents or Azure to use in Omnichannel for Customer Service.

## Context variables

The following table contains the list of variables in Omnichannel for Customer Service that can help you configure some of the context variables. When you are configuring the context variable in Power Virtual Agents bot or Azure bot, use the information on the [data type mapping for each variable](#data-type-mappings-for-context-variables) for creating the correct mappings.

> [!IMPORTANT]
> Make sure of the following:
> - Names are not changed and used as is when you author flows in Power Virtual Agents or Azure bots.
> - The value that will be passed to the context variable shouldn't exceed 4,000 characters so that the conversation can be successfully escalated to the agent.

| Context variable type | Context variable | Description | Data type |
|-----|-----|-------|-------|
| [Pre-conversation survey](configure-pre-chat-survey.md) | Use the variables that you create in Omnichannel for Customer Service. | The context variables for pre-conversation answers store the customer answers for questions in the pre-conversation survey. |String |
| [Custom Context](../developer/how-to/send-context-starting-chat.md) | Use the custom variable that you create in Omnichannel for Customer Service. | These are custom context variables that can be created and passed through the Livechat SDK. | String |
| Conversation | msdyn_liveworkitemid | Use the context variable that contains the conversation ID for the ongoing conversation and can fetch and perform operations on the record in Common Data Service. | String |
|[Related customer](record-identification-rule.md) |msdyn_contact_msdyn_ocliveworkitem_Customer (JSON)| Use this context variable that contains the record ID for the customer (contact or account) record that is linked to the conversation. When you set this variable, the customer will be linked to the conversation post flush.| String |
| Related case | msdyn_incident_msdyn_ocliveworkitem | Use this context variable that contains the record ID for the case record linked to the conversation. When you set this variable, the case will be linked to the conversation post flush.| String |
|||||

### Data type mappings for context variables

When you are configuring mappings for context variables in Power Virtual Agents or Azure bot to be able to retrieve data from Omnichannel for Customer Service, make sure that the following settings are matched for the question and variable.

| Data type of incoming value for context variable | Data type in Power Virtual Agents or Azure bot |
|-------|-----------|
| String | User’s entire response |
| Single line | User’s entire response |
| Multiple lines | User’s entire response |
| Option set | User’s entire response |
| User Consent | Boolean |
| Number, Floating number | Number |
|||

### See also

[Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Integrate an Azure bot](configure-bot.md)  
