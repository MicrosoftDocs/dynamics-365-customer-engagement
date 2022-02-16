---
title: "getConversationId (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: "Includes information about getConversationId method, syntax, and parameters in Omnichannel for Customer Service Session API reference."
ms.date: 02/18/2022
ms.topic: article
author: mh-jaya
ms.author: v-jmh
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

## Return Value

Returns a promise resolved with currently ongoing conversation ID.

## Example

`Microsoft.Omnichannel.getConversationId();`

### See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)  
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)  
[getConversations](reference/methods/getConversations.md)  
[linkToConversation](reference/methods/linkToConversation.md)  
[unlinkFromConversation](reference/methods/unlinkFromConversation.md)  
[openConversation](reference/methods/openConversation.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
