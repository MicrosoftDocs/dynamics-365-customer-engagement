---
title: List Roles for a Hub (ARM)
description: Lists the Role type definitions for a Hub.
keywords: Customer Insights; ARM API; role assignments; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fcc8f392010
---

List Roles for a Hub (ARM)
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Role](../types/role.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/roles?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of role information, including [Role](../types/role.md) type definitions, in the following format:

```{json}  
{ 
   'value':'[ 
    { 
        'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/Roles/<roleName>' 
        'name':'<hubName>/<roleName>, 
        'type':'Microsoft.CustomerInsights/hubs/Roles', 
        'properties': <Role-Definition>
    }, 
    { 
        'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/Roles/<roleName>' 
        'name':'<hubName>/<roleName>, 
        'type':'Microsoft.CustomerInsights/hubs/Roles', 
        'properties': <Role-Definition>
    }  ]', 
   'nextLink':'<url>' 
} 
```  
