---
title: Create or Update Prediction Model Status Type (Hub)
description: Creates a new or updates an existing status of a prediction model.
keywords: Customer Insights; Hub API; prediction model status; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/30/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid:  98986c28-da82-42e6-86d4-f158f3920811
---

Create or Update Prediction Model Status Type (Hub)
=================================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Either creates a new [Prediction Model Status](../types/predictionmodelstatus.md) type or updates the type if it already exists. 

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<Hub-endpoint>/manage/model/predictions/<predictionName>/modelStatus?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|predictionName|Yes|Name of the prediction containing the status to create or update|
| | | |

### Request Body 
 A JSON object describing a [Prediction Model Status](../types/predictionmodelstatus.md) type, for example:

```{json}
{
  "status": "New"
}
```

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

### Status Code  
  
* 200 (OK) - Creation/update request completed successfully. 

