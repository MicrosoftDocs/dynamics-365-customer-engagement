---
title: Get a Role Assignment (ARM)
description: Gets the specified Role Assignment.
keywords: Customer Insights; ARM API; role assignment; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fcc8f392004
---

Get a Role Assignment (ARM)
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Role Assignment](../types/roleassignment.md) type definition for the specified hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/roleAssignments/<assignmentName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|assignmentName|Yes|The name of the Role Assignment to create or update|  
| | | |

<br>

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested information, containing a [Role Assignment](../types/roleassignment.md) type definition, of the form: 

```{json}
{ 
     'id':'string' 
     'name':'string', 
     'type':'string', 
     'properties’: <RoleAssignment-Definition>
} 
```
