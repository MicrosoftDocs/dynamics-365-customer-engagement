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

This method is called as soon as a new chat invitation is received for every incoming conversation. It helps you define which translation provider you want to use for a particular conversation. You can even choose to switch off or on the translation of conversation messages; for example, you can decide whether you want to translate conversation messages based on the channel of the incoming conversation or based on the pre-chat response.

## Syntax

`Microsoft.Omnichannel.TranslationFramework.initializeNewConversation(conversationConfig)`

## Parameters

|Name|Required|Description|
|----|----|----|
|`conversationConfig`|Yes| Provide details about which translation provider to use based on factors such as `C1Language` and `InviteLocale`. Because some translation providers give better translations for certain languages, you can choose the appropriate translation provider at runtime. <br />Based on these parameters, you can also decide to turn on or off the translation feature at the start of a new conversation.|

Here is the structure of `conversationConfig` parameter.

```json
interface conversationConfig { 
        conversationId: string,  //Unique Id for live work item in Omnichannel for Customer Service
        c1Language: string;      // Language of the agent
        inviteParams: InviteParams;  //Parameters received on invitation to the chat 
        interface InviteParams
                { 
                        inviteLocale: string;  //Language locale of the channel received during the chat invitation 
                        channelType: string;   //The type of the channel 
                } 
}
```
Given below is a sample of the `conversationConfig` parameter.

```json
conversationConfig = {
  "conversationId": "2f67af9e-c05a-4784-aaea-916d6938fcea",
  "c1Language": 1033,
  "inviteParams": {
    "inviteLocale": "3082",
    "channelType": "lcw"
  }
}
```

## Return Value

Returns the `InitializedConversationResponse` object, which contains the Boolean value for the `keepTranslationOn` parameter.

## Example

```javascript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
        // Initialize the translation provider for the incoming conversation
        Microsoft.Omnichannel.TranslationFramework.initializeNewConversation(convConfig);
});
```

### See also

[Add a web resource for real-time translation](../../how-to/add-web-resource-real-time-translation.md)
