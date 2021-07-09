---
title: "getConversations (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: "Omnichannel for Customer Service Session API reference"
ms.date: 07/12/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---
# getConversations 

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be used to fetch a list of conversation (`msdyn_ocliveworkitem`) records for an agent. 

## Syntax

`Microsoft.Omnichannel.getConversations(input, correlationId);`

## Parameters

| Parameter               | Type   | Description           |
| -------------           | -------| --------------------- |
| input (Required)        | String | JSON input in the following format: <br>{`attributes, agentID, status, orderBy, createdBeforeDays`}  </br> <br> The `agentId` is the only required input variable and the rest are optional.</br>| 
| correlationId (Optional)| String | Unique identifier for telemetry logging.   |

`attributes`: String[] containing entity attribute names

`agentId`: String containing unique identifier for the agent

`status`: String[] containing statuscode values

`orderBy`: Array of objects in the format: [{ `attributeName`: "<Attribute_Name>" `descending`:\<boolean>}]

`createdBeforeDays`: Number of days



## Return Value

A resolved or reject promise on the basis of the outcome of the operation. 

> [!Note] 
> Even if the caller doesn't pass any attributes in the input, the function returns the records with the following default attributes: 
>   - msdyn_ocliveworkitemid 
>   - msdyn_liveworkstreamid 
>   - msdyn_lastsessionid 
>   - statuscode 
>   - createdon 

## Example

The following code snippet fetches the currently waiting conversation for the given agent ID: 

```javascript
var input = { 
            "attributes": ["msdyn_title", "msdyn_channel"], "orderBy": [{ "attributeName": "createdon", "descending": true }], 
"agentId": "<<AgentId>>", "status": [3], }; 
Microsoft.Omnichannel.getConversations(input).then(result => { 
console.log("result is as:", result); 
}, (error)=>{ 
    console.log("error is as:", error); 
}); 
```
 
### See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
