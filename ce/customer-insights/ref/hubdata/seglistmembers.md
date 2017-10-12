---
title: List Segment Members (Hub Data)
description: Lists the members in the specified segment.
keywords: Customer Insights; Hub API; segment; list
author: Milar1
ms.author: v-larmic
manager: jdaly
ms.date: 05/16/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43e8-b5f7-b8c27baf1239
---

List Segment Members (Hub Data)
==============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the members in the specified [Segment](../types/segment.md).  

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/segments/<segmentName>/members?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|segmentName|Yes|The name of the segment to custom Profile (entity set) type|

### Filtering and Ordering 
The following OData query parameters can be used to control the output: **top**, **skip**, **orderby** and **select**, for example:
&emsp; `GET /data/segments/TestSegment/members?$top=20&$skip=10&orderBy=LastName asc&select=LastName,ProfileId`

<br/>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body  
The body contains a **members** array containing the requested instance data. 

### Status Code  
  
* 200 (OK) - the request succeeded.  
* 400 (Bad Request) - invalid URI parameters  
* 404 (Not Found) - an instance matching the specified name could not be found. 
