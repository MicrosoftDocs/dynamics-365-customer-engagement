---
title: Evaluate Static Segment Query (Hub Data)
description: Evaluates a query for static segment member candidates.
keywords: Customer Insights; Hub API; segment; evaluate
author: Milar1
ms.author: v-larmic
manager: jdaly
ms.date: 05/19/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43e8-b5f7-b8c27baf1240
---

Evaluate Static Segment Query (Hub Data)
======================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Evaluates the supplied query for static [Segment](../types/segment.md) member candidates. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<Hub-endpoint>/data/segments/evaluation`|

### Request Body  
The request body must contain a JSON object that contains the filter query and target member type, for example:

```{json}  
{ 
   "query":"PROFILE(Customer).FILTER(FirstName!='Sally')",
   "targetProfileTypeName":"Customer"
}
```
### Filtering and Ordering 
The following OData query parameters can be used to control the output: **top**, **skip**, **orderby** and **select**, for example:

&emsp; `POST /data/segments/evaluation?$top=200&$skip=5&$orderBy=LastName asc&select=LastName,ProfileId` 

Where the **$top** and **$skip** parameters support pagination; their default values are 30 and 0, respectively.

<br>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body  
The body contains an array of [Profile](../types/profile.md) instances, potentially filtered by the specified **select** expression.


### Status Code  
  
* 200 (OK) - the request succeeded.  
* 400 (Bad Request) - invalid URI parameters, often an unrecognized continuation token.
* 404 (Not Found) - the named segment was not found.  
