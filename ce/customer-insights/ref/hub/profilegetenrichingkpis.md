---
title: Get enriching KPIs for a Profile (Hub)
description: Gets the specified Profile.
keywords: Customer Insights; Hub API; Profile; get enriching KPIs
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/09/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fc18f392a007
---

Get enriching KPIs for a Profile (Hub)
=====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Profile](../types/profile.md) type for the specified hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<Hub-endpoint>/manage/model/profiles/<profileName>/getEnrichingKpis?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

An array of enriching [KPIs](../types/kpi.md) for the specified profile.  This array will be empty if the profile has no enriching KPIs.

### Status Code  
* 200 (OK) - Retrieval succeeded.
* 404 (Not Found) - Specified Profile could not recognized.

