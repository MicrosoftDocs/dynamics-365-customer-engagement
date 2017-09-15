---
title: Get Hub (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Gets a Customer Insights Hub. 
keywords: Customer Insights; ARM API; Hub; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/01/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: acb6ba5b-6a3b-4aaf-861a-1682364b2785
---

Get Hub (ARM)
=============

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets a Customer Insights [Hub](../types/hub.md).  
  
## Request  
 The read hub request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>?api-version=2017-04-26`|| | |  
  
### URI Parameters  
  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|The name of the hub to create or update. Customer Insights Hub names must be globally unique.|  
| | | |
 
  
## Response  
 The response includes an HTTP status code, a set of response headers, and a response body.  
  
### Response Body 
The requested [Hub](../types/hub.md) information, for example:
 
```{json}
{ 
    'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/TestHub1' 
    'name':'TestHub1, 
    'type':'Microsoft.CustomerInsights/hubs',  
    'location':'East US2', 
    'tags': ' 
        { 
            ['key1':'value1'], 
            ['key2':'value2'],
            ... 
        }', 
        'properties' : 
        { 
            'provisioningState':'Succeeded', 
            'apiEndpoint':'TestHub1.api.azurecustomerinsights.com', 
            'webEndpoint':'TestHub1.apps.azurecustomerinsights.com' 
        } 
}
```  

### Status Code  
  
* 200 (OK) - The request completed successfully.  
