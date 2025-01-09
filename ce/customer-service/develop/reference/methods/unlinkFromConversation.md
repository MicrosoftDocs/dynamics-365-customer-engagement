---
title: "unlinkFromConversation (Omnichannel JavaScript API reference) | MicrosoftDocs"
description: "Includes reference information about unlinkFromConversation method, syntax, and parameters in Omnichannel JavaScript API reference."
ms.date: 02/24/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# unlinkFromConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be used to unlink an already linked entity record of type customer (account or contact) or case from a conversation. 

## Syntax

`Microsoft.Omnichannel.unlinkFromConversation(entityLogicalName, recordId, conversationId);`

## Parameters

| Parameter         | Type       | Description |
| ----------------- | -----------| ----------- |
| entityLogicalName | String     | Logical name of the entity (such as account, contact, or incident) | 
| recordId          | String     | Unique identifier for the entity record to be unlinked |
| `*`conversationId    | String  | Unique identifier for the conversation to unlink. Also reffered to as liveworkitemId. Without providing this parameter, the entity will unlink from the focused conversation by default. |

`*` Indicates optional parameter.

## Return value

Returns a resolved or rejected promise based on the outcome of the operation. 

## Example

```javascript
//Unlinking an already linked incident record from the current conversation 
Microsoft.Omnichannel.unlinkFromConversation("incident", "6b726d86-d37c-43b8-b3a4-c4056ddd2e07", "b7397aae-ecf8-43a6-aeb0-07d294efb494").then((response) => { 
    // Refreshing the tab UI  
    Microsoft.Apm.refreshTab("tab-id-3"); 
}, (error) => { 
    console.log(error); 
}); 
```

### Related information

[Live chat SDK reference](../../omnichannel-reference.md)  
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)  
[getConversations](getConversations.md)  
[getConversationId](getConversationId.md)  
[linkToConversation](linkToConversation.md)  
[openConversation](openConversation.md)  
[sendMessageToConversation](sendMessageToConversation.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
