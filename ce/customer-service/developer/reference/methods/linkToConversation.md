---
title: "linkToConversation (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: "Includes information about linkToConversation method, syntax, and parameters in Omnichannel for Customer Service Session API reference."
ms.date: 10/20/2020
ms.topic: article
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.reviewer: nenellim
---
# linkToConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be used to link account, contact, or incident records to the conversation in the focused session. The function will only link the records in the database. The link is reflected after the page is refreshed. The caller is responsible for the UI refresh. Only one account or contact and one case can be linked to a conversation at a time. If a new customer or case record is linked, it will override the previous record link for the conversation. Omnichannel for Customer Service supports linking only to active conversations. 

## Syntax

`Microsoft.Omnichannel.linkToConversation(entityLogicalName, recordId);`

## Parameters

| Parameter         | Type    | Description |
| ----------------- | ------- | ----------- |
| entityLogicalName | String  | Logical name of the entity (such as account, contact, or incident) | 
| recordId          | String  | Unique identifier for the entity record to be linked |

## Return Value

Returns a resolved or rejected promise based on the outcome of the operation. 

## Example

```javascript
//Linking an incident record with the current conversation 
Microsoft.Omnichannel.linkToConversation("incident", "6b726d86-d37c-43b8-b3a4-c4056ddd2e07").then((response) => { 
    // Refreshing the tab UI  
    Microsoft.Apm.refreshTab("tab-id-3"); 
}, (error) => { 
    console.log(error); 
}); 
```

### See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
