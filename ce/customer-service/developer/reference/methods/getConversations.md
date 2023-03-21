---
title: "getConversations (Omnichannel JavaScript API reference) | MicrosoftDocs"
description: "Includes reference information about getConversations method, syntax, and parameters in Omnichannel JavaScript API reference."
ms.date: 07/12/2021
ms.topic: reference
author: gandhamm
ms.author: mgandham
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
| input      | String | JSON input. It has the following format: <br>{`attributes, agentID, status, orderBy, createdBeforeDays`}  </br> where: <ul><li> `attributes`is an array of strings containing entity attribute names</li><li>`agentId` is a string containing unique identifier for the agent</li><li>`status` is an array of strings with comma-separated values</li><li>`orderBy` is an array of objects in the format: <br> [{ `attributeName`: "<Attribute_Name>" `descending`:\<Boolean>}]</br></li><li>`createdBeforeDays`is the number of days since the conversation was created</li></ul> <br> The `agentId` is the only required input variable and the rest are optional.</br>| 
| correlationId | String | Optional. Unique identifier for telemetry logging.  |


## Return value

Returns a resolved or rejected promise based on the outcome of the operation. 

> [!Note] 
> Even if the caller doesn't pass any attributes in the input, the function returns the records with the following default attributes: 
>   - msdyn_ocliveworkitemid
>   - msdyn_liveworkstreamid 
>   - msdyn_lastsessionid 
>   - StatusCode 
>   - CreatedOn 

## Example

The following code snippet fetches the currently waiting conversation for the given agent ID.

```javascript
var input = { 
    "attributes": [
        "msdyn_title",
        "msdyn_channel"
        ],
    "agentId": "2b330c52-6844-4d36-8e05-03c78c9681dc",
    "status": [3], 
    "orderBy": [
        { 
            "attributeName": "createdon",
            "descending": true
        }
    ]
};
Microsoft.Omnichannel.getConversations(input).then(result => {
    console.log("result is as:", result); 
    }, (error) => {
        console.log("error is as:", error); 
    }
);
```
 
### See also

[Live chat SDK reference](../../omnichannel-reference.md)  
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)  
[getConversationId](getConversationId.md)  
[linkToConversation](linkToConversation.md)  
[unlinkFromConversation](unlinkFromConversation.md)  
[openConversation](openConversation.md)   
[sendMessageToConversation](sendMessageToConversation.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
