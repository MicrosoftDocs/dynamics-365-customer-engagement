---
title: "linkToConversation (Omnichannel JavaScript API reference) | MicrosoftDocs"
description: "Includes reference information about linkToConversation method, syntax, and parameters in Omnichannel JavaScript API reference."
ms.date: 02/18/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.reviewer: nenellim
---
# linkToConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be used to link account, contact, or incident records to the conversation in the focused session. The function will only link the records in the database. The link is reflected after the page is refreshed. The caller is responsible for the UI refresh. Only one account or contact, and one case can be linked to a conversation at a time. If a new customer or case record is linked, it will override the previous record link for the conversation. 

> [!Note]
> Omnichannel for Customer Service supports linking only to active conversations. 

## Syntax

`Microsoft.Omnichannel.linkToConversation(entityLogicalName, recordId, conversationId);`

## Parameters

| Parameter         | Type    | Description |
| ----------------- | ------- | ----------- |
| entityLogicalName | String  | Logical name of the entity (such as account, contact, or incident) | 
| recordId          | String  | Unique identifier for the entity record to be linked |
| `*`conversationId    | String  | Unique identifier for the conversation to link. Also reffered to as liveworkitemId. Without providing this parameter, the entity will link to the focused conversation by default. |

`*` Indicates optional parameter.

## Return value

Returns a resolved or rejected promise based on the outcome of the operation. 

## Example

```javascript
//Linking an incident record with the current conversation 
Microsoft.Omnichannel.linkToConversation("incident", "6b726d86-d37c-43b8-b3a4-c4056ddd2e07", "b7397aae-ecf8-43a6-aeb0-07d294efb494").then((response) => { 
    // Refreshing the tab UI  
    Microsoft.Apm.refreshTab("tab-id-3"); 
}, (error) => { 
    console.log(error); 
}); 
```

### See also

[Live chat SDK reference](../../omnichannel-reference.md)  
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)  
[getConversations](getConversations.md)  
[getConversationId](getConversationId.md)  
[unlinkFromConversation](unlinkFromConversation.md)  
[openConversation](openConversation.md)  
[sendMessageToConversation](sendMessageToConversation.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
