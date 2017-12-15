---
title: Get KPI Type (Hub)
description: Gets the specified KPI.
keywords: Customer Insights; Hub API; KPI; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 4b986c28-da82-42e6-86d4-fcc8f3920005
---

Get a KPI Type (Hub)
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [KPI](../types/kpi.md) type.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/kpi/<kpiName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|KpiName|Yes|Name of the KPI to retrieve|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [KPI](../types/kpi.md) type definition.


