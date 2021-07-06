---
title: "getConversations (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: "Omnichannel for Customer Service Session API reference"
ms.date: 07/06/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---
# getConversations

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This method can be used to fetch a list of conversation (`msdyn_ocliveworkitem`) records for an agent. 

## Syntax

`Microsoft.Omnichannel.getConversations(input, correlationId);`

## Parameters

| Parameter     | Type   | Description           |
| ------------- | ------ | --------------------- |
| input         | String | JSON input (required) | 
| correlationId | String | Unique identifier for telemetry logging. (Optional)  |

## Return Value

A resolved promise with `msdyn_ocliveworkitem` entity records in the following format:

In case of success: 

```javascript 
    { 
    result: { 
    values: [{...}] //Array of objects, each object is a msdyn_ocliveworkitem record 
    }, 
    status: Boolean 
    } 
``` 

In case of failure: 

```javascript
{ 
error: {..}, // Error object 
status: Boolean 
} 
```

> [!Note] 
> Even if the caller doesn't pass any attributes in the input, the function returns the records with the following default attributes: 
>   - msdyn_ocliveworkitemid 
>   - msdyn_liveworkstreamid 
>   - msdyn_lastsessionid 
>   - statuscode 
>   - createdon 

## Example

The following code snippet fetches the currently waiting conversation for the given agent ID: 

```
var input = { 

    "attributes": ["msdyn_title", "msdyn_channel"], 

    "orderBy": [{ 

        "attributeName": "createdon", 

        "descending": true 

    }], 

    "agentId": "<<AgentId>>", 

    "status": [3], 

}; 


Microsoft.Omnichannel.getConversations(input).then(result=>{ 

    console.log("result is as:", result); 

} 

, (error)=>{ 

    console.log("error is as:", error); 

}); 
```
 
### See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
