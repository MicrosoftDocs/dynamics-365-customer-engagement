---
title: "openConversation (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: "Omnichannel for Customer Service Session API reference"
ms.date: 07/12/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---
# openConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be used to open a conversation as a session programmatically. 

## Syntax

`Microsoft.Omnichannel.openConversation(liveworkitemId, lastsessionId, liveworkstreamId);`

## Parameters

| Parameter                  | Type   | Description |
| ---------------------------| -----  | ----------- |
| liveworkitemId (Required)  | String | Unique identifier for the conversation to open.   | 
| lastsessionId (Optional)   | String | Unique identifier for the last sessionId in which conversation was opened.    |
| liveworkstreamId (Optional)| String | Unique identifier for the live workstream to which the conversation belong.   |

## Return Value

A resolved or reject promise on the basis of the outcome of the operation. 

## Example

```javascript
    Microsoft.Omnichannel.openConversation("051a340d-c821-42be-8c43-dfb42c4da821", "63e6b672-c1cc-4ba9-86d5-aea818e73092", "9e20ced1-7c81-eb11-a812-000d3a9c25eb").then(result=>
        { 
            console.log(result) 
         } 
        , error=>{ 
            console.log(error) 
                } 
    );
```
 
### See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
