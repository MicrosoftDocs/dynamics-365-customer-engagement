---
title: "sendMessageToConversation (Omnichannel JavaScript API reference) | MicrosoftDocs"
description: "Includes reference information about sendMessageToConversation method, syntax, and parameters in Omnichannel JavaScript API reference."
ms.date: 10/03/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.reviewer: nenellim
---
# sendMessageToConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Use this method to send messages to a conversation.  

> [!Note]
> - The conversation must be assigned to the agent that's logged in.
> - Only string literals and valid rich object JSON are currently supported. More information: [Retrieve and format rich messages](message-object.md) 

## Syntax

`Microsoft.Omnichannel.sendMessageToConversation(message, toSendBox, conversationId);`

## Parameters

| Parameter         | Type    | Description |
| ----------------- | ------- | ----------- |
| message           | String or [MessageObject](message-object.md)   | Indicates the message to be sent to a conversation. | 
| `*`toSendBox         | Boolean  | Determines if the message is sent to sendBox or directly to the conversation. Without providing this parameter, the message will be sent to sendbox by default. |
| `*`conversationId    | String  | Unique identifier of the conversation to which the message is to be sent. Also reffered to as liveworkitemId. Without providing this parameter, the message will send to the focused conversation by default. |

`*` Indicates optional parameter.

## Return value

Returns a resolved or rejected promise based on the outcome of the operation. 

## Example

```javascript
// Sending message directly to the chat of conversation with provided conversationId
Microsoft.Omnichannel.sendMessageToConversation("Test message",  false, "00000000-0000-0000-0000-000000000000");
```

```javascript
// Sending valid rich object to conversation
let validRichObjJSON = {
  "survey": {
    "Answers": {
      "Section": [
        {
          "Listitems": [
            {
              "OptionTitle": "Xbox Controller multi color",
              "OptionDescription": "Xbox Controller multi color",
              "OptionImageURL": "https://img-prod-cms-rt-microsoft-com.akamaized.net/cms/api/am/imageFileData/RWwBPt?ver=d74f&w=270&h=222&q=90&m=6&p=48&b=%23FFFFFFFF&f=png&o=f&aim=true"
            }
          ],
          "SectionTitle": "XBox Controllers",
          "Multiselect": true
        }
      ],
      "Title": "Microsoft Xbox Controllers",
      "subtitle": "Choose a controller you like",
      "ImageURL": "https://img-prod-cms-rt-microsoft-com.akamaized.net/cms/api/am/imageFileData/RE2XP73?ver=7371&w=270&h=222&q=90&m=6&p=48&b=%23FFFFFFFF&f=png&o=f&aim=true",
      "ResponseMessage": "Thanks for choosing."
    }
  },
  "richObjectId": "00000000-0000-0000-0000-000000000000",
  "richObjectType": 192350002,
  "richObjectName": "Test with 0 guid",
  "tabKey": ""
}

Microsoft.Omnichannel.sendMessageToConversation(validRichObjJSON,  false);
```

### See also

[Live chat SDK reference](../../omnichannel-reference.md)  
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)  
[openConversation](openConversation.md)  
[getConversationId](getConversationId.md)  
[linkToConversation](linkToConversation.md)  
[unlinkFromConversation](unlinkFromConversation.md)  
[getConversations](getConversations.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
