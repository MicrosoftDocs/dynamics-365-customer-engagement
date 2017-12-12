---
title: List App View Types for a Hub (Hub) 
description: Lists the Application View type definitions for a Hub.
keywords: Customer Insights; Hub API; application packaging; View; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920009
---

Get App View Types for a Hub (Hub)
=================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the App [View](../types/view.md) type definitions for the specified Hub.


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/views?api-version=2017-04-26&userId=<userId>`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|userId|No|The ID of the user utilizing the Views|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

An array of [View](../types/view.md) type definitions.
