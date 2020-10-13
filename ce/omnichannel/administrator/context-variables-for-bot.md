---
title: "Context variables for a bot | MicrosoftDocs"
description: "Context variables to use when configuring a bot in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.service: 
  "dynamics-365-customerservice"
ms.topic: article
---

# Context variables for a bot

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic lists the context variables that you can configure for a bot in Power Virtual Agents or Azure to use in Omnichannel for Customer Service.

## Context variables

The following table contains the keys that can help configure the context variables. Make sure the key names are used as is when authoring flows in Power Virtual Agents or Azure bots.

|Scenarios|Keys|Description|Data type|
|-----|-----|-------|-------|
|Prechat |Customer creates the variable. Admin needs to use the same name as the variable created while authoring flows in  Power Virtual Agents or Azure bots.|The context variables for pre-conversation answers store the customer answers for questions in the pre-conversation survey. |String|
|Custom Context – (Livechat SDK set context provider) |Customer creates the variable.|These are custom context variables that can be created and passed through the Livechat SDK. | String|
|Liveworkitem ID |msdyn_liveworkitemid|This context variable contains the conversation ID for the ongoing conversation and can be used to fetch and perform operations on the record in common data service.|String|
|Authenticated chat Record identification – Contact|msdyn_contact_msdyn_ocliveworkitem_Customer|This context variable contains the record ID for the customer (contact or account) record that is linked to the conversation. If this variable is set, the customer will be linked to the conversation post flush.|String|
|Record identification – Case|msdyn_incident_msdyn_ocliveworkitem| This context variable contains the record ID for the case record that is linked to the conversation. If this variable is set, the case will be linked to the conversation post flush.|String|
|Engagement Context |msdyn_msdyn_ocliveworkitem_<br>msdyn_livechatengagementctx_liveworkitemid|These context variables contain information, such as the browser type and language that is passed when the conversation is initiated. |String|
|||||

### See also

[Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Integrate an Azure bot](configure-bot.md)  