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

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

This method is called for every conversation message exchanged between the customer and the agent.

## Syntax

`Microsoft.Omnichannel.TranslationFramework.translateMessage(conversationId, translationConfig)`

## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|`translationConfig`|JSON object|Yes| Consists of `conversationId`, `messagePayload` and `translateToC1orC2` key-value pairs.|

Here is the structure of `translationConfig` parameter.

```json
interface translationConfig { 
        conversationId: string;   //Unique Id for live work item in Omnichannel for Customer Service
        messagePayload: MessagePayload;  //Payload for the message to be translated
        translateToC1orC2: TranslateTo;   //Represents for whom the message has to be translated 
 } 

interface MessagePayload { 
        content: string;                 //Contains the content to be translated
        contentType: MessageContentType;  //Contains the type of content
        sender: Sender; // Represents the sender of the message
} 
     
interface Sender { 
        userType: UserType;  //Represents the type of user who is sending this message
} 

export class UserType { 
        public static readonly C1 = "Agent"; 
        public static readonly C2 = "Customer"; 
        public static readonly CONSULT = "CONSULT"; 
} 
 
export class TranslateTo { 
        public static readonly C1 = "Agent"; 
        public static readonly C2 = "Customer"; 
} 
 
export class MessageContentType { 
        public static readonly Text = "Text"; 
} 

```
Given below is a sample of the `conversationConfig` parameter.

```json
translationConfig = {
  "conversationId": "2b330c52-6844-4d36-8e05-03c78c9681dc",
  "uiSessionId": null,
  "messagePayload": {
    "content": "Hello",
    "contentType": "Text",
    "sender": {
      "userType": "Agent"
    }
  },
  "translateToC1orC2": "Customer"
}
```

## Return Value

Returns the translated message, the source language, and the destination language.

## Example

```javascript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
        // Initialize the translation provider for the incoming conversation
        Microsoft.Omnichannel.TranslationFramework.initializeNewConversation(convId, translationConfig);
});
```

### See also

[Add a web resource for real-time translation](../../how-to/add-web-resource-real-time-translation.md)
