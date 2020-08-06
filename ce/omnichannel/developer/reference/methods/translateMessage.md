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

> [!IMPORTANT]
> See this [sample web resource](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/real-time-translation) for more information on how to implement the `translateMessage` API.

## Syntax

`Microsoft.Omnichannel.TranslationFramework.translateMessage(conversationId, translationConfig)`

## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|`translationConfig`|JSON object|Yes| Consists of `conversationId`, `messagePayload` and `translateToC1orC2` key-value pairs.|

Given below are the key-value pairs that we need to provide in the `translationConfig` object.

|Name|Type|Description|
|----|----|----|
|`ConversationId`|String|Unique ID for live work item in Omnichannel for Customer Service|
|`messagePayload`|JSON object|Payload for the message to be translated|
|`translateToC1orC2`|JSON object|Represents for whom the message has to be translated|

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

**Interface object**

```
export interface TranslatedMessageResponse { 
translatedMessage: string;  // contains the translated message
sourceLanguage: string;       //represents the language locale of the original content 
destinationLanguage: string;  // represents the language locale of the translated content
errorObject?: ErrorObject;  //represents the error object for any error scenarios
} 
 export interface ErrorObject{ 
isError: boolean;               // represents yes for error and no otherwise.
errorCode: ErrorCodes;   //represents the type of error based on errorCode
} 
 
                                enum ErrorCodes { 
        MESSAGE_TOO_LONG = 100,   //Error code for very long message which the translation service cannot translate
        LANGUAGE_NOT_SUPPORTED = 101,  //Error Code for language not supported by the translation service
        MESSAGE_NOT_TRANSLATED = 102,   // Error Code for message not translated by the translation service
        TRANSLATION_SERVICE_LIMIT_EXCEEDED = 103,  //Error code if the quota limit exceeded for the translation service
        TRANSLATION_FAILED = 104,             //Error Code if the translation service failed to translate a message
        UNRECOGNIZED_TEXT = 105,             //Error Code if the text is not recognized by the translation service
        UNRECOGNIZED_ERROR = 200,         // Error Code if there is any error other than the listed one.
    }
```

**Sample response**

```json
{
  "translatedMessage": "Hola",
  "destinationLanguage": "3082",
  "errorObject": {
    "isError": false,                             
    "errorCode": null
  },
  "sourceLanguage": "3082"
}
```

### See also

[Add a web resource for real-time translation](../../how-to/add-web-resource-real-time-translation.md)
