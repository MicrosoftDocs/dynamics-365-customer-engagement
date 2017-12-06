---
title: List Prediction Types for a Hub (Hub)
description: Lists the Prediction type definitions for a Hub.
keywords: Customer Insights; Hub API; prediction; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/30/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-f158f3920809
---

List Prediction Types for a Hub (Hub)
==================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Prediction](../types/prediction.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<Hub-endpoint>/manage/model/predictions?api-version=2017-04-26&locale=<locale-code>`|
| | |

### URI Parameters


|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of [Prediction](../types/prediction.md) type definitions in the following format:

```{json}  
{ 
    'value' : <prediction-Definition>, 
    . . . 
    'nextLink':'Next-Link'
}
  
```    
