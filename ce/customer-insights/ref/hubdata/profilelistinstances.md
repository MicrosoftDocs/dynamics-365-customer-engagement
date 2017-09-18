---
title: List Profile Instances (Hub Data)
description: Lists all instances of the specified custom Profile type. 
keywords: Customer Insights; Hub Data API;  Profile instance; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 6ccb25f4-1078-4980-96d6-7b8aec0f0204
---

List Profile Instances (Hub Data)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists instances of the specified custom [Profile](../types/profile.md) type.  Results are returned as a set of pages.  Optionally, a filter query expression can be used to limit the result set.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/<profileType>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
|profileType|Yes|The custom Profile (entity set) type|

### Example
`GET myapp.api.azurecustomerinsights.com/data/Contacts?api-version=2017-04-26` 

### Filtering Results

A filter expression can be supplied to limit the results. The supported filter expressions include **eq**, **endswith()**, **startswith()**, **contains()**, 
and **LastModifiedTimestamp**.  Expressions can be joined with logical **and** and **or** operators. A filtering request would have the following form:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/<profileType>?api-version=2017-04-26&$filter=<filter-exp>`|

The following are examples of this operation:

```{http}  
GET <hub-endpoint>/data/Contacts?api-version=2017-04-26&$filter=FirstName eq 'Karen'
GET <hub-endpoint>/data/Contacts?api-version=2017-04-26&$filter=endswith(FirstName,'en')
GET <hub-endpoint>/data/Contacts?api-version=2017-04-26&$filter=startswith(FirstName,'Ka')
GET <hub-endpoint>/data/Contacts?api-version=2017-04-26&$filter=contains(FirstName,'are')
GET <hub-endpoint>/data/Contacts?api-version=2017-04-26&$filter=LastModifiedTimestamp gt cast('2016-03-30T21:46:24.000Z', Edm.DateTimeOffset)
```    

<br/>


## Response  
The response includes an HTTP status code, a response body and a set of response headers.  
Results are returned as a set of pages. The existance of the server-side paging token (OData $skiptoken) enables the retrieval of the next page of results. 
The results are ordered by modification timestamp, with the most recently changed entities appearing first.  


### Response Body  

A collection of custom [Profile](../types/profile.md) instances. 


### Status Code  
  
-   200 (OK) - the request succeeded.  
  

