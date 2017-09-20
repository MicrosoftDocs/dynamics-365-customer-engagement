---
title: Get a Prediction Type (ARM)
description: Gets the specified prediction.
keywords: Customer Insights; ARM API; prediction; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/29/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-f158f3920804
---

Get a Prediction Type (ARM)
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Prediction](../types/prediction.md) type.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/predictions/<predictionName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|predictionName|Yes|Name of the prediction to be retrieved|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [Prediction](../types/prediction.md) type definition, of the form: 

```{json}
  {
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/predictions/<predictionName>',
     'name':'<hubName>/<predictionName>',
     'type':'Microsoft.CustomerInsights/hubs/predictions',
     'properties' : <prediction-Type>
  }
```

### Status Code  
  
* 200 (OK) - Retrieval request completed successfully. 
