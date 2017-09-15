---
title: Get KPI data for a Profile ID (Hub Data)
description: Gets KPI data associated with specified Profile instance.
keywords: Customer Insights; Hub Data API; Interaction instance; get; 
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/07/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 6ccb25f4-1078-4980-96d6-7b8aec0f0214
---

Get KPI data for a Profile ID (Hub Data)
=====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets data for the specified [KPI](../types/kpi.md) that is associated with specified [Profile](../types/profile.md) instance, with optional filtering.


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/Contacts('<contactId>')/KPIs(KpiName='<kpiName>',WindowType='<period>')/Values?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
|contactId|Yes|Strong ID of the profile. This should also be included in the group by of the KPI|
|kpiName|Yes|Name of the KPI type to retrieve data for|
|period|Yes|Standard time period for KPI calculation|

Comlpex filter expressions can also be applied to this operation as demonstrated in the following request.

```{http}  
GET <hub-endpoint>/data/Contacts('4')/KPIs(KpiName='EmailSentCount',WindowType='Day')/Values?
        $filter=Timestamp gt cast('2014-01-01T23:59:59.999Z', Edm.DateTimeOffset)&api-version=2017-04-26
```    
All the filter operations mentioned in [Kpi Query Data](./kpiquerydata.md) can be applied here as well.

<br/>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  


### Response Body  

A collection of custom data for the specified [KPI](../types/kpi.md). 


### Status Code  
  
-   200 (OK) - the request succeeded.  
  
