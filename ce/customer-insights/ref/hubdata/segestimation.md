---
title: Estimate Segment Result Count (Hub Data)
description: Lists all the segment entity types.
keywords: Customer Insights; Hub API; segment; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/29/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-97a8-43e8-b5f7-b8c27b2f1234
---

Estimate Segment Result Count (Hub Data)
=======================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Returns the estimated result count for the specified query, useful for query result comparisons and data transfer preparation before an actual call to the [Evaluate Static Segment Query](./segqueryeval.md) operation.


## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<Hub-endpoint>/data/segments/estimation?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | | |

#### Request Body  

Must contain a JSON object that contains the filter query and target member type, for example:

```{json}  
{  
  "query":"PROFILE(Customer).FILTER(LastName != 'John')", 
  "targetProfileTypeName":"Customer" 
} 
```

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

Upon success, an estimated count of the form:

```{json}  
{ 
  "estimatedCount": <int> 
} 
```

### Status Code 
  
* 200 (OK) - Query result count was returned successfully.
* 400 (Bad Request) - Missing or invalid query 
* 408 (Request timeout) - Query processing exceeded maximum time limit.
