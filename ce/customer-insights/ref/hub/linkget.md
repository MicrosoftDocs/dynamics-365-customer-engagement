---
title: Get a Link Type (Hub)
description: Gets the specified Link.
keywords: Customer Insights; Hub API; Link; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: a1986c28-da82-42e6-86d4-fcc8f3920005
---

Get a Link Type (ARM)
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Link](../types/link.md) type.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/links/<linkName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|linkName|Yes|The name of the link to retrieve|  
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [Link](../types/link.md) type definition.
