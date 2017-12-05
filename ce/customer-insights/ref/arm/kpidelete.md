---
title: Delete KPI (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Deletes a KPI.  
keywords: Customer Insights; ARM API; KPI; delete
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/02/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 4b986c28-da82-42e6-86d4-fcc8f3920008
---

Delete KPI (ARM)
===============

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes the specified [KPI](../types/kpi.md) type.  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/kpi/<KpiName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|KpiName|Yes|The name of the KPI to delete|  
| | | |

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
- 200 (OK) - delete succeeded.
- 204 (No Content) - KPI was not found.
