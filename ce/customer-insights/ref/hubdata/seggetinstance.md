---
title: Get the Specified Segment (Hub Data)
description: Gets the specified segment instance.
keywords: Customer Insights; Hub API; segment; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/16/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43e8-b5f7-b8c27baf1237
---

Get the Specified Segment Instance (Hub Data)
==========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Segment](../types/segment.md) instance.   

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/segments('Name=<segmentName>')?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|segmentName|Yes|The name of the segment to custom Profile (entity set) type|

<br/>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body  
The body contains the named [Segment](../types/segment.md) instance. 

### Status Code  
  
-   200 (OK) - the request succeeded.  
-   404 (Not found) - an instance matching the specified name could not be found.  

  
