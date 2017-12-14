---
title: Reprocess KPI (Hub)
description: Reprocesses a KPI value
keywords: Customer Insights; Hub API; KPI; reprocess; recalculate
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/07/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 4b986c28-da82-42e6-8bd4-fcc8f3923013
---

Reprocess KPI (ARM)
=================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Reprocesses (recalculates) the value of the specified [KPI](../types/kpi.md). KPIs are automatically recalculated every 15 minutes, but this operation will force an "immediate" recalculation.


## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|POST|`<hub-endpoint>/manage/kpi/<KpiName>/reprocess?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|KpiName|Yes|The name of the KPI to create or update.|  
| | | |

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
- 202 (Accepted) - Values accepted and reprocessing is queued.
