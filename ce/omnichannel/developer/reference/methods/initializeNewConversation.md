---
title: "initializeNewConversation (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 08/06/2020
ms.topic: article
---

# Preview: initializeNewConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

This method is required to be implemented as soon as a new chat invitation is received for any and every incoming conversation. It helps you define which translation provider you want to use for a particular conversation. You can even choose to switch off or on the translation of conversation messages; for example, you can decide whether you want to translate conversation messages based on the channel of the incoming conversation or based on the pre-chat response.

> [!IMPORTANT]
> See this [sample web resource](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/real-time-translation) for more information on how to implement the `initializeNewConversation` API.

## Syntax

`Microsoft.Omnichannel.TranslationFramework.initializeNewConversation(conversationConfig)`

## Parameters

|Name|Required|Type|Description|
|----|----|----|----|
|`conversationConfig`|Yes| JSON object| Provide details about which translation provider to use based on factors such as `C1Language` and `InviteLocale`. Because some translation providers give better translations for certain languages, you can choose the appropriate translation provider at runtime. <br />Based on these parameters, you can also decide to turn on or off the translation feature at the start of a new conversation.|

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
  "c1Language": "1033",
  "inviteParams": {
    "inviteLocale": "3082",
    "channelType": "lcw"
  }
}
```
In the above JSON example, the `inviteLocale` parameter is Locale ID. More information: [Locale ID](https://docs.microsoft.com/openspecs/office_standards/ms-oe376/6c085406-a698-4e12-9d4d-c3b0ee3dbc4a).

## Return Value

Returns the `InitializedConversationResponse` object, which contains the Boolean value for the `keepTranslationOn` parameter.

**Interface object**

```
InitializedConversationResponse  {
        keepTranslationOn: Boolean;
}
```

**Sample expected response**

```json
InitializedConversationResponse = 
{
  "keepTranslationOn": true
}
```

On exception in this method, invalid return values; OC will keep translation off for the conversation. You will need to do minimal processing in this function, as it make the UI wait before rendering.


![initializeNewConversation error message](../../media/initializenewconversation-api-error.png "initializeNewConversation error message")

### See also

[Add a web resource for real-time translation](../../how-to/add-web-resource-real-time-translation.md)
