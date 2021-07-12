---
title: "unlinkFromConversation (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: "Omnichannel for Customer Service Session API reference"
ms.date: 10/20/2020
ms.topic: article
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.reviewer: nenellim
---
# unlinkFromConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be used to unlink an already linked entity record of type customer (account or contact) or case from a conversation. 

## Syntax

`Microsoft.Omnichannel.unlinkFromConversation(entityLogicalName, recordId);`

## Parameters

| Parameter         | Type       | Description |
| ----------------- | -----------| ----------- |
| entityLogicalName | String     | Logical name of the entity (such as account, contact, or incident) | 
| recordId          | String     | Unique identifier for the entity record to be linked |

## Return Value

Returns a resolved or rejected promise based on the outcome of the operation. 

## Example

```javascript
//Unlinking an already linked incident record from the current conversation 
Microsoft.Omnichannel.unlinkFromConversation("incident", "6b726d86-d37c-43b8-b3a4-c4056ddd2e07").then((response) => { 
    // Refreshing the tab UI  
    Microsoft.Apm.refreshTab("tab-id-3"); 
}, (error) => { 
    console.log(error); 
}); 
```

### See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
