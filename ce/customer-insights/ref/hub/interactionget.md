---
title: Get a Interaction Type (Hub)
description: Gets the specified Interaction.
keywords: Customer Insights; Hub API; Interaction; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f392000d
---

Get a Interaction Type (Hub)
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Interaction](../types/interaction.md) type definition.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/interactions/<interactionTypeName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|interactionTypeName|Yes|The name of the Interaction definition to retrieve|
| | | | 


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [Interaction](../types/interaction.md) type definition.

