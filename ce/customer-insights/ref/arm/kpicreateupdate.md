---
title: Create or Update KPI (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Creates a new or updates an existing KPI.
keywords: Customer Insights; ARM API; KPI; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/08/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 4b986c28-da82-42e6-86d4-fcc8f3920002
---

Create or Update KPI (ARM)
============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [KPI](../types/kpi.md) in a Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/kpi/<KpiName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|KpiName|Yes|The name of the KPI to create or update.|  
| | | |

### Request Body
A JSON object describing a [KPI](../types/kpi.md), for example:   
  
```{json}  
{
    "entityType": "Profile",
    "entityTypeName": "testProfile2327128",
    "displayName": {
        "en-us": "Kpi DisplayName"
    },
    "description": {
        "en-us": "Kpi Description"
    },
    "calculationWindow": "Day",
    "function": "Sum",
    "expression": "SavingAccountBalance",
    "unit": "unit",
    "groupBy": ["SavingAccountBalance"],
    "thresHolds": {
        "lowerLimit": 5.0,
        "upperLimit": 50.0,
        "increasingKpi": true
    },
    "aliases": [{
        "aliasName": "alias",
        "expression": "Id+4"
    }]
}
```  


## Response  
 The response includes an HTTP status code and a standard set of response headers. Upon success, the body will contain information about the newly created KPI in the following form:

```{json}
{ 
    "id": <kpiUrl>, 
    "name": <kpiName>, 
    "type": "Microsoft.CustomerInsights/hubs/kpi", 
    "properties": { <kpiProperties> }
}
```
  
### Status Code  
  
- 200 (OK) - the update request completed successfully. The *provisioningState* property in the response body is set to 'Succeeded' when the provisioning finishes.
- 400 (Bad Request) - The display name or definition contains invalid JSON.   
  
