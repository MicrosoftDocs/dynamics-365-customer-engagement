---
title: Delete App View (Hub)
description: Deletes the specified Application View.
keywords: Customer Insights; Hub API; View; delete
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920015
---


Delete App View Connector (Hub)

==============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes the specified Application [View](../types/view.md) type definition.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|DELETE|`<hub-endpoint>/manage/views/<viewName>?api-version=2017-04-26&userId=<userId>`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|viewName|Yes|Name of the app view to delete|
|userId|No|The ID of the user utilizing the view|
| | | |

## Response  
 The response includes a standard HTTP status code and a set of standard response headers.


### Status Code  
  
-   200 (OK) - delete succeeded

