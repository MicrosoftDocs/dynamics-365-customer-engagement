---
title: Create or Update App View (ARM)
description: Creates a new or updates an existing Application View.
keywords: Customer Insights; ARM API; View; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/08/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920010
---

Create or Update App View (ARM)
===============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing App [View](../types/view.md) type for a Customer Insights Hub.  

## Request  
 The request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/views/<viewName>?api-version=2017-04-26`|  

### URI Parameters  

|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|viewName|Yes|The name of the app view to create or update.|  
| | | |


### Request Body  
A JSON object describing a [View](../types/view.md), for example:  
  
```{json}  
{
    "userId": "testUser",
    "displayName": {
        "en": "some name"
    },
    "definition": "{\\\"isProfileType\\\":false,\\\"profileTypes\\\":[],\\\"widgets\\\":[],\\\"style\\\":[]}"
}
```  

## Response  
 The response includes an HTTP status code and a standard set of response headers. Upon success, the body will contain information about the newly created view in the following form:

```{json}
{ 
    "id": <viewUrl>, 
    "name": <viewName>, 
    "type": "Microsoft.CustomerInsights/hubs/views", 
    "properties": { <viewProperties> }
}
```

### Status Code  

* 200 (OK) - if the update request completed successfully.
* 201 (Created) - if the create request completed successfully.
* 401 (Unauthorized) - if the sender does not have write access to this resource.
