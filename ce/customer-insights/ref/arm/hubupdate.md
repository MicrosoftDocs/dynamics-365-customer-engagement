---
title: Update Hub (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Updates an existing Hub.  
keywords: Customer Insights; ARM API; Hub; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/06/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da81-42e6-86d4-fcc8f392ef66
---

Update Hub (ARM)
=================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Updates an existing Customer Insights [Hub](../types/hub.md).  


## Request  
The update hub request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PATCH|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|The name of the hub to create or update. Customer Insights Hub names must be globally unique.|  
| | | |


### Request Body  
The [Hub](../types/hub.md) value to create/update, for example:  

```{json}  
{
    "id": "testHub2839",
    "location": "East US",
    "name": "TestHub2839",
    "type": "Microsoft.CustomerInsights/hubs",
    "tags": {
    },
    "properties": {
        "apiEndpoint": "https://testHub2839.api.azurecustomerinsights.com",
        "webEndpoint": "https://testHub2839.apps.azurecustomerinsights.com",
        "provisioningState": "Creating",
        "hubBillingInfo": {
            "skuName": "B0",
            "minUnits": 1,
            "maxUnits": 5
        },
        "tenantFeatures": 0
    }
}
```

## Response  
 The response includes an HTTP status code, a set of response headers, and a response body.  
  
### Response Body 
The format of the response body is as follows:  
  
```{json}  
{ 
    'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>' 
    'name':'testHub2839', 
    'type':'Microsoft.CustomerInsights/hubs', 
    'location':'East US', 
    'tags': ' 
        { 
            ['key1':'value1'], 
            ['key2':'value2'],
            ... 
        }', 
        'properties' : 
        { 
            'provisioningState':'Created', 
            'apiEndpoint':'testHub2839.api.azurecustomerinsights.com', 
            'webEndpoint':'testHub2839.apps.azurecustomerinsights.com' 
            "hubBillingInfo": {
                "skuName": "B0",
                "minUnits": 1,
                "maxUnits": 5
            },
            "tenantFeatures": 0,
        } 
}
```

### Status Code  
  
-   200 (OK) - if the update request completed successfully.  
-   201 (Created) - if the create request completed successfully.  
-   409 (Conflict) - if a hub with the supplied name already exists.  

