---
title: "Context variables for a bot | MicrosoftDocs"
description: "Context variables to use when configuring a bot in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 11/04/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Context variables for a bot

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic lists the context variables that you can configure for a bot in Power Virtual Agents or Azure to use in Omnichannel for Customer Service.

## Context variables

The following table contains the names that can help you configure the context variables.

> [!IMPORTANT]
> Make sure the names are not changed and used as is when you are authoring flows in Power Virtual Agents or Azure bots.

| Context variable type | Context variable name | Description | Data type |
|-----|-----|-------|-------|
| [Pre-conversation survey](configure-pre-chat-survey.md) | Customer creates the variable. | The context variables for pre-conversation answers store the customer answers for questions in the pre-conversation survey.<br> **IMPORTANT:** When you're mapping the questions to the context variables in Power Virtual Agents, make sure that the data type is matched. |String |
| [Custom Context – (Livechat SDK set context provider)](../developer/how-to/send-context-starting-chat.md) | Customer creates the variable. | These are custom context variables that can be created and passed through the Livechat SDK. | String |
| Liveworkitem ID |msdyn_liveworkitemid|This context variable contains the conversation ID for the ongoing conversation and can be used to fetch and perform operations on the record in common data service.|String|
|[Automatically identify customers](record-identification-rule.md|msdyn_contact_msdyn_ocliveworkitem_Customer|This context variable contains the record ID for the customer (contact or account) record that is linked to the conversation. If this variable is set, the customer will be linked to the conversation post flush.|String|
|Record identification for case|msdyn_incident_msdyn_ocliveworkitem| This context variable contains the record ID for the case record that is linked to the conversation. If this variable is set, the case will be linked to the conversation post flush.|String|
|||||

> [!NOTE]
> Make sure that the value that will be passed to the context variable doesn't exceed 4,000 characters so that the conversation can be successfully escalated to the agent.

### Pre-conversation survey context variables mapping for Power Virtual Agents

When you configure mappings in Power Virtual Agents for pre-conversation survey context variables, make sure that the following settings are matched.

|Pre-conversation question type|Power Virtual Agents type|
|-------|-----------|
|Single line|User’s entire response|
|Multiple Lines|User’s entire response|
|Option Set |User’s entire response|
|User Consent|Boolean|
|||

### See also

[Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Integrate an Azure bot](configure-bot.md)  
