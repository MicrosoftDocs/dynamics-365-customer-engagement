---
title: Create or Update Role Assignment (Hub)
description: Creates a new or updates an existing Role Assignment.
keywords: Customer Insights; Hub API; role assignment; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/02/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fcc8f392003
---

Create or Update Role Assignment (Hub)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Role Assignment](../types/roleassignment.md) in a Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/rbac/roleAssignments/<assignmentName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
|assignmentName|Yes|The name of the Role Assignment to create or update|  
| | | |
 
### Request Body  
A JSON object that contains a [Role Assignment](../types/roleassignment.md) type definition,
for example:

```{json}
{
    "role": "Admin",
    "principals": [{
        "principalId": "4c54c38ffa9b416ba5a6d6c8a20cbe7e",
        "principalType": "User"
    },
    {
        "principalId": "93061d15a5054f2b9948ae25724cf9d5",
        "principalType": "User"
    }]
}
``` 

  
## Response  
 The response includes an HTTP status code and a standard set of response headers.  
  
### Status Code  
  
* 200 (OK) - Update request completed successfully. 
* 202 (Accepted) - Update request accepted and is being processed.
* 400 (Bad Request) - Validation fails or invalid JSON.   
  
