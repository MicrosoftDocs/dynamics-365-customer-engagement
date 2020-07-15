---
title: "initializeNewConversation (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 07/15/2019
ms.topic: article
---

# Preview: initializeNewConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

This method is called as soon as a new chat invite is receieved for every incoming conversation. It will help you define which translation provider you wan to use for a particular conversation. You can even choose to switch off or on the translation of the conversation messages. For example, you can decide whether you want to translate the conversation messages based on the channel of incoming conversation or based on the pre-chat response.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.initializeNewConversation(conversationConfig)`

## Parameters

|Name|Required|Description|
|----|----|----|
|`initializeNewConversation`|Yes| |

## Return Value

Returns the `InitializedConversationResponse` object which contains the boolean value for `keepTranslationOn` parameter.

## Example

```javascript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
        // Initialize the translation provider for the incoming conversation
        Microsoft.Omnichannel.LiveChatWidget.SDK.initializeNewConversation(convConfig);
});
```

### See also

[Add a web resource for real time translation](../../how-to/add-web-resource-real-time-translation.md)