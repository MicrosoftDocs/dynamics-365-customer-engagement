---
title: Get a Prediction Type (Hub)
description: Gets the specified Prediction.
keywords: Customer Insights; Hub API; prediction; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-f158f3920805
---

Get a Prediction Type (Hub)
========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Prediction](../types/prediction.md) type for the specified hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<Hub-endpoint>/manage/model/predictions/<predictionTypeName>?api-version=2017-04-26&locale=<locale-code>`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|predictionTypeName|Yes|The name of the Prediction definition to retrieve|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

Contains the requested [Prediction](../types/prediction.md) type definition. 

### Status Code  
  
* 200 (OK) - Retrieval request completed successfully. 
