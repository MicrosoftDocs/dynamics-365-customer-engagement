---
title: Read a KPI Type (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Gets the specified KPI type.
keywords: Customer Insights; ARM API; KPI; read
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/02/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 4b986c28-da82-42e6-86d4-fcc8f3920004
---

Read a KPI Type (ARM)
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Reads the specified [KPI](../types/kpi.md) type for a hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/kpi/<KpiName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|KpiName|Yes|Name of the KPI to retrieve|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

### Status Code  
  
* 200 (OK) - The request completed successfully.  


### Response Body  

The requested link information, containing a [KPI](../types/kpi.md) type definition, of the form: 

```{json}
{
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/kpi/<kpiName>'
     'name':'<hubName>/<kpiName>,
     'type':'Microsoft.CustomerInsights/hubs/kpi',
     'properties' : <KPI-Definition>
  }
```
