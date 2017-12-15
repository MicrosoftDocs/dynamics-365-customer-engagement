---
title: List Link Types for a Hub (Hub)
description: Lists the Link type definitions for a Hub.
keywords: Customer Insights; Hub API; Link; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: a1986c28-da82-42e6-86d4-fcc8f3920007
---

List Link Types for a Hub (Hub)
============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Link](../types/link.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/links?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

Returns a linked collection of [Link](../types/link.md) type definitions, of the form: 

```{json}  
{
   'value': <Link-Definition>,
   'nextLink' : 'the next link'
}

```  
