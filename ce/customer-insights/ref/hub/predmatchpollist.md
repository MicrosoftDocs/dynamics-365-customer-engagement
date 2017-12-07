---
title: List Predictive Match Policy Types for a Hub (Hub)
description: Lists the Predictive Match Policy type definitions for a Hub.
keywords: Customer Insights; Hub API; predictive match policy; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/15/2017
ms.topic: reference
ms.service: customer-insights
ms.assetid: 5c6ac718-9758-43e8-b5f7-d8c21bbb1006
---

List Predictive Match Policy Types for a Hub (Hub)
================================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Predictive Match Policy](../types/predictivematchpolicy.md) type definitions for the specified Hub.

## Request
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/predictiveMatchPolicies?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

Returns a linked collection of [Predictive Match Policy](../types/predictivematchpolicy.md) type definitions, of the form: 

```{json}  
{
   'value': <Policy-Definition>,
   'nextLink' : '<url>'
}

```  
