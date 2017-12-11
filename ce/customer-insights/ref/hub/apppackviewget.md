---
title: Get App View (Hub) 
description: Gets the specified Application View type.
keywords: Customer Insights; Hub API; application packaging; App View; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920007
---

Get App View (Hub)
===================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]


Gets the specified [Application View](../types/view.md) type for a Hub.


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/views/<viewName>?api-version=2017-04-26&userId=<userId>`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|viewName|Yes|Name of the app view to be retrieved|
|userId|No|The ID of the user utilizing the view|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  


The requested App [View](../types/view.md) type definition.


