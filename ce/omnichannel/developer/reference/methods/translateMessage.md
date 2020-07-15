---
title: "translateMessage (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 07/15/2019
ms.topic: article
---

# Preview: translateMessage

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

This method is called for every conversation message exchanged between the customer and the agent.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.translateMessage(conversationId, translationConfig)`

## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|`conversationId`|String|Yes| Unique identifier of the conversation.|
|translationConfig|JSON object|Yes| |

## Return Value

Returns the translated message, the source language and the destination language.

## Example

```javascript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
        // Initialize the translation provider for the incoming conversation
        Microsoft.Omnichannel.LiveChatWidget.SDK.initializeNewConversation(convId, translationConfig);
});
```

### See also

[Add a web resource for real time translation](../../how-to/add-web-resource-real-time-translation.md)