---
title: Query KPI Data (Hub Data)
description: Gets all data for the specified KPI with optional filtering.
keywords: Customer Insights; Hub Data API; Interaction instance; get; 
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/07/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 6ccb25f4-1078-4980-96d6-7b8aec0f0215
---

Query KPI Data (Hub Data)
=======================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets all data for the specified [KPI](../types/kpi.md) with optional filtering.


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|**Comments**|
|-------------|---------------|---------------|
|GET|`<hub-endpoint>/data/KPIs(KpiName='<kpiName>',WindowType='<period>')/Values?api-version=2017-04-26`|Gets all Kpi Values|
|GET|`<hub-endpoint>/data/KPIs(KpiName='<kpiName>',WindowType='<period>')?api-version=2017-04-26`|Get latest Kpi values|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
|kpiName|Yes|Name of the KPI type to retrieve data for|
|period|Yes|Standard time period for KPI calculation|

Complex filter expressions can also be applied to the GroupBy properties of the KPIs as demonstrated in the following request.

```{http}  
<hub-endpoint>/data/KPIs(KpiName='EmailsSentCount',WindowType='Day')/Values?$filter=Timestamp gt cast('2014-01-01T23:59:59.999Z', Edm.DateTimeOffset)&api-version=2017-04-26
<hub-endpoint>/data/KPIs(KpiName=‘EmailsSentCount’,WindowType='Day')/Values?$top=1&api-version=2017-04-26
<hub-endpoint>/data/KPIs(KpiName=‘EmailsSentCount’,WindowType='Day')/Values?$filter=ToContacts eq 'Tom'&FromContact='Will'&api-version=2017-04-26
<hub-endpoint>/data/KPIs(KpiName=‘EmailsSentCount’,WindowType='Day')/Values?$filter=ToContacts eq 'Tom'&FromContact='*'& api-version=2017-04-26
```    

The “apply” operator can be used to get a list of several functions like Percentile, Rank, Sum etc., across one of the “group by” columns defined for that KPI.  
Supported Functions: SUM(), MIN(), MAX(), AVG(), VAR(), Median(), P10(), P90(), P50() {Same as Median()}, Rank(), Percentile(), Count() 

```{http}
<hub-endpoint>/data/KPIs(KpiName=‘EmailsSentCount’,WindowType='Day')/Values?$apply=aggregateWithPivot(ContactId, rank()) 
``` 
The above query gives the KPIValue and along with it, for each city, the rank of the ContactId when compared across other ContactIds.  

<br/>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  


### Response Body  

A collection of custom data for the specified [KPI](../types/kpi.md). 

{
    "value":[
      {
       "Timestamp": "2015-01-01T00:00:00Z",
       "Value": 15,
       "ToContacts": "Tom",
       "CalculationTime": "2017-06-15T21:00:00Z"
       },
       ...
      ]
    "@odata.nextLink":"<hub-endpoint>/data/KPIs(KpiName=‘EmailsSentCount’,WindowType='Day')/Values?$filter=ToContacts eq 'Tom'&FromContact='*'&$skiptoken=100"
}

### Pagination
The Maximum instances returned is 100. So if the results contains more than 100, there will be a new Url (nextlink) at the bottom of the previous response. To get all results, we need to keep calling GET on this url until it is null.

### Status Code  
  
*  200 (OK) - the request succeeded.  
  
