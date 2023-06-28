---
title: "openConversation (Omnichannel JavaScript API reference) | MicrosoftDocs"
description: "Includes reference information about openConversation method, syntax, and parameters in Omnichannel JavaScript API reference."
ms.date: 07/12/2021
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: nenellim
---
# openConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be used to open a conversation as a session programmatically.

## Syntax

`Microsoft.Omnichannel.openConversation(conversationId, lastsessionId, liveworkstreamId);`

## Parameters

| Parameter        | Type   | Description |
| -----------------| -----  | ----------- |
| conversationId   | String | Unique identifier for the conversation to open. Also reffered to as liveworkitemId. |
| lastsessionId    | String | Optional. Unique identifier for the last session ID in which conversation was opened.   |
| liveworkstreamId | String | Optional. Unique identifier for the live workstream to which the conversation belongs. |

## Return value

Returns a resolved or rejected promise based on the outcome of the operation. 

## Example
The following code snippet opens a specified conversation for a given last session ID and live workstream ID.
```javascript
Microsoft.Omnichannel.openConversation("051a340d-c821-42be-8c43-dfb42c4da821", "63e6b672-c1cc-4ba9-86d5-aea818e73092", "9e20ced1-7c81-eb11-a812-000d3a9c25eb").then(result => { 
  console.log(result); 
}, error => { 
    console.log(error);
});
```
 
### See also

[Live chat SDK reference](../../omnichannel-reference.md)
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)
[getConversationId](getConversationId.md)  
[linkToConversation](linkToConversation.md)  
[unlinkFromConversation](unlinkFromConversation.md)  
[getConversations](getConversations.md)  
[sendMessageToConversation](sendMessageToConversation.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
