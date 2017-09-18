---
title: List Hub Interaction Types (Hub)
description: Lists the Interaction type definitions for a Hub.
keywords: Customer Insights; Hub API; Interaction; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f392000f
---

List Hub Interaction Types (Hub)
===============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Interaction](../types/interaction.md) type definitions for the specified Hub.


## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/interactions?api-version=2017-04-26`|

### URI Parameters


|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | | | 


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of [Interaction](../types/interaction.md) type definitions in the following format:

```{json}  
  
{ 
    'value' : <Interaction-Type>,  
    'nextLink':'<next-link>' 
}
  
```    
