---
title: List the SAS Policies for a Hub (Hub)
description: Lists the SAS Policy type definitions for a Hub.
keywords: Customer Insights; Hub API; SAS Policies; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f392003b
---

List the SAS Policies for a Hub (Hub)
===================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Authentication Policy](../types/authzpolicy.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/sas/Policies?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of linked [SAS Policy](../types/authzpolicy.md) definitions, in the following form:

```{json}  
{
   ‘value’ : [SASPolicy-Definition],
   ‘nextLink’: ‘the next link’
}

```  

### Status Code  
-   200 (OK) - if the policy retrieved successfully.  
-   401 (Access denied) - not authorized to read resource.


