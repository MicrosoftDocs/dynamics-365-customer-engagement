---
title: "unlinkFromConversation (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: 
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 10/05/2020
ms.topic: article
---
# unlinkFromConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Provides the functionality to unlink the already linked entity record from the ongoing conversation. Supported entities:

- Contact
- Account
- Incident/Case

## Syntax

`Microsoft.Omnichannel.unlinkFromConversation(entityLogicalName, recordId);`

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

```javascript
Microsoft.Omnichannel.unlinkFromConversation("incident", "6e8a786f-59e0-ea11a813-000d3a8b1f3b").then((response)=>{
    console.log(response);
}, (error)=>{
    console.log(error);
});
```

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
