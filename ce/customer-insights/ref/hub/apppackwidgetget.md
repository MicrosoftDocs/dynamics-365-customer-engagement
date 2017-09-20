---
title: Get Widget Type (Hub) 
description: Gets the specified Widget type.
keywords: Customer Insights; Hub API; application packaging; widget; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/18/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920003
---

Get Widget Type (Hub)
======================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Widget type](../types/widgettype.md) definition for a Hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/widgetTypes/<widgetTypeName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|widgetTypeName|Yes|Name of the widget to be retrieved|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [WidgetType](../types/widgettype.md) type definition.  


