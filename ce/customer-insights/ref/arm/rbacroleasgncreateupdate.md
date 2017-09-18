---
title: Create or Update Role Assignment (ARM)
description: Creates a new or updates an existing Role Assignment.
keywords: Customer Insights; ARM API; role assignment; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/12/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fcc8f392002
---

Create or Update Role Assignment (ARM)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Role Assignment](../types/roleassignment.md) in a Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/roleAssignments/<assignmentName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|assignmentName|Yes|The name of the Role Assignment to create or update|  
| | | |

### Request Body  
 A JSON object describing a [Role Assignment](../types/roleassignment.md) type, for example:

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
 The response includes an HTTP status code and a standard set of response headers. Upon success, the body will contain information about the newly created role in the following form:

```{json}
{ 
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/RoleAssignments/<assignmentName>' 
     'name':'<hubName>/<assignmentName>, 
     'type':'Microsoft.CustomerInsights/hubs/RoleAssignments', 
     'properties': <RoleAssignment-Definition>
 } 
```

Where *properties* contains a [Role Assignment](../types/roleassignment.md) type definition. 

  
### Status Code  
  
* 200 (OK) - Update request completed successfully. 
* 202 (Accepted) - Update request accepted and is being processed. 
* 400 (Bad Request) - Validation fails or invalid JSON.

