---
title: "getConversationId (Omnichannel JavaScript API reference) | MicrosoftDocs"
description: "Includes reference information about getConversationId method, syntax, and parameters in Omnichannel JavaScript API reference."
ms.date: 02/18/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.reviewer: nenellim
---
# getConversationId

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be called to fetch the unique GUID of the current ongoing conversation in a session. The conversation ID remains the same after the conversation is closed. The identifier can be used to fetch the conversation record programmatically.

## Syntax

`Microsoft.Omnichannel.getConversationId();`

## Parameters

None

## Return value

Returns a promise resolved with currently ongoing conversation ID.

## Example

`Microsoft.Omnichannel.getConversationId();`

### See also

[Live chat SDK reference](../../omnichannel-reference.md)  
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)  
[getConversations](getConversations.md)  
[linkToConversation](linkToConversation.md)  
[unlinkFromConversation](unlinkFromConversation.md)  
[openConversation](openConversation.md)  
[sendMessageToConversation](sendMessageToConversation.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
