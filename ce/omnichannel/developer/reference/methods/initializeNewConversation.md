---
title: "initializeNewConversation (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 08/06/2020
ms.topic: article
---

# initializeNewConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

This method is required to be implemented in web resource. It is called once, as soon as a new conversation invitation is accepted or existing conversation is opened from Agent Dashboard. 

1. You can choose to turn off or turn on the translation for a particular conversation using certain conditions; for example, you would like to turn the translation on if the agent and customer's languages are different. 
2. You can also override the agent's(C1) language to be used in translation for the conversation. 
3. It provides you information about the conversation to take certain decisions, e.g. which translation API engine should be used for a given conversation. 

> [!IMPORTANT]
> See this [sample web resource](TODO add a link) for more information on how to implement the `initializeNewConversation` API.

## Syntax

`Microsoft.Omnichannel.TranslationFramework.initializeNewConversation(conversationConfig)`

## Parameters

|Name|Required|Type|Description|
|----|----|----|----|
|`conversationConfig`|Yes| Javascript object| Provides details about conversation. Such as conversation id, default agent input language (From Realtime translation administrator configuration) etc. <br />Please find more details in next paragraphs.|

Here is the structure of `conversationConfig` parameter.

```json
interface InviteParams {// Parameters received on a conversation invite 
        inviteLocale: string;  //Language locale of the channel from where conversation is received. This contains locale id, example- "1033" for english.
        channelType: string;   //The type of the channel, example- "lcw" for chat widget, "facebook" for facebook.
} 


interface conversationConfig { 
        conversationId: string,  // Unique Id for conversation in Omnichannel for Customer Service
        c1Language: string;      // Default agent input language (From Realtime translation administrator configuration)
        inviteParams: InviteParams;  // Parameters received on a conversation invite  
}
```
The `inviteLocale` parameter in `InviteParams` interface represents a Locale ID. More information: [Locale ID](https://docs.microsoft.com/openspecs/office_standards/ms-oe376/6c085406-a698-4e12-9d4d-c3b0ee3dbc4a).

The `channelType` parameter in `InviteParams` interface represents a supported channel in Omnichannel for Customer Service. List of channels are:
|Name|Description|
|----|----|
|`"lcw"`|For live chat widget channel| 


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


## Return Value

Returns a promise which resolves to a following Javascript object.

```
{
        keepTranslationOn: boolean;// mandatory field, if true the translation would be turn on for the given conversation and vice-versa
        c1Language?: string;// optional field, return the agent's language if input param conversationConfig.c1Language needs to be overriden for the conversation
}
```
The `c1Language` parameter in resolved Javascript object represents a Locale ID only from the following list.

|Locale Id|Language|
|----|----|
|`"1033"`|English| 

**Sample expected response**

```json
{
  "keepTranslationOn": true,
  "c1Language": "1033"
}
```

## Additional Information
1. On exception in this method or invalid return values, Omnichannel for Customer Service will keep translation off for the conversation. For example: if resolved Javascript object from the returned promise does not contains `keepTranslationOn` field or contains a value of `c1Language` which is not from above list of Locale ids the conversation will start with translation turned off.

![initializeNewConversation error message](../../../media/initializeconversation-api-error.png "initializeNewConversation error message")

2. Please do minimal processing in this function, as it makes the UI wait before rendering. If the execution time of this function exceeds 30 sec, the conversation will start with translation turned off, irrespective of the values of returned promise.


### See also

[Add a web resource for real-time translation](../../how-to/add-web-resource-real-time-translation.md)
