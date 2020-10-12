---
title: "linkToConversation (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: 
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 10/05/2020
ms.topic: article
---
# linkToConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be used to link account, contact, or incident records to a conversation. The linked record will be reflected in the customer summary page for the current conversation as soon as it has been linked. Only one account or contact and one case can be linked to a conversation at a time. If a new customer or case record is linked, it will override the previous record link for the conversation. 

## Syntax

`Microsoft.Omnichannel.linkToConversation(entityLogicalName, recordId);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| entityLogicalName | String | Logical name of the entity (i.e., account, contact, or incident) | 
| recordId | String | Unique identifier for the entity record to be linked |

## Return Value

ISuccessObject.

ISuccessObject can be defined as:

```
export interface ISuccessObject {
        entityLogicalName: string,
        recordId: string,
        liveWorkItemId: string,
        message: string,
        status: string,
        additionalDetails: any,
        currentReqId: string,
    }
```

## Example

```
Microsoft.Omnichannel.linkToConversation("incident", "6e8a786f-59e0-ea11-a813-000d3a8b1f3b").then((response)=>{
    console.log(response);
}, (error)=>{
    console.log(error);
});
```

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
