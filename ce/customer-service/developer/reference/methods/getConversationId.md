---
title: "getConversationId (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: 
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 10/15/2020
ms.topic: article
ms.reviewer: nenellim
---
# getConversationId

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be called to fetch the unique GUID of the current ongoing conversation in a session. The conversation id stays the same post conversation close as well. This id can be used to fetch the conversation record programmatically.

## Syntax

`Microsoft.Omnichannel.getConversationId();`

## Parameters

None

## Return Value

A promise resolved with currently ongoing conversation id.

## Example

`Microsoft.Omnichannel.getConversationId();`

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
