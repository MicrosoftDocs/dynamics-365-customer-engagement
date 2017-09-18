---
title: Create KPI (Hub)
description: Creates a new KPI.
keywords: Customer Insights; Hub API; KPI; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/02/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 4b986c28-da82-42e6-86d4-fcc8f3920003
---

Create or Update KPI (Hub)
============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [KPI](../types/kpi.md) in a Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/model/kpi/<kpiName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|KpiName|Yes|The name of the KPI to create or update.|  
| | | |
 

### Request Body  

A JSON object that contains a [KPI](../types/kpi.md) definition. 

  
## Response  
 The response includes an HTTP status code and a standard set of response headers.  
  
### Status Code  
  
-   200 (OK) - the update request completed successfully. The *provisioningState* property in the response body is set to 'Succeeded' when the provisioning finishes.
-   400 (Bad Request) - The display name or definition contains invalid JSON.   
