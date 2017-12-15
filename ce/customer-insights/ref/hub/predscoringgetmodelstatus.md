---
title: Get Prediction Model Status Type (Hub)
description: Gets the model status of the specified prediction.
keywords: Customer Insights; Hub API; prediction model status; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/30/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid:  98986c28-da82-42e6-86d4-f158f3920813
---

Get Prediction Model Status Type (Hub)
=================================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the [Model Status](../types/predictionmodelstatus.md) associated with the specified [Prediction](../types/prediction.md).

## Request 
This _POST_ request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<Hub-endpoint>/manage/model/predictions/<predictionName>/getModelStatus?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|predictionName|Yes|Name of the Prediction associated with the model status to retrieve|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [Prediction Model Status](../types/predictionmodelstatus.md) type definition, of the form: 

```{json}
{
    "tenantId": "string",
    "predictionName": "string",
    "predictionGuidId": "string",
    "status": "New | Provisioning | ...",
    "message": "string",
    "trainingSetCount": "string",
    "testSetCount": "string",
    "validationSetCount": "string",
    "trainingAccuracy": "string",
    "signalsUsed": "string",
    "modelVersion": "string"
}
```

### Status Code  
  
* 200 (OK) - Retrieval request completed successfully. 
