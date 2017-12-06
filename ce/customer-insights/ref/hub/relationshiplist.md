---
title: Lists Relationships (Hub)
description: Lists the Relationship type definitions for a Hub.
keywords: Customer Insights; Hub API; relationships; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/23/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fc18f392056
---

List Relationships (Hub)
========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Relationship](../types/relationship.md) type definitions for the current Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/relationships?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | | |

<br>

## Response 
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A linked collection of [Relationship](../types/relationship.md) identifiers of the form:

```{json}  
{
  "value": [
    {
      "id": "string",
      "name": "string",
      "type": "string"
    }
  ],
  "nextLink": "url"
}
```  
