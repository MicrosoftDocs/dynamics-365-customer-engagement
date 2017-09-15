---
title: Get Training Model Results (ARM)
description: Gets the training model results of the specified prediction.
keywords: Customer Insights; ARM API; prediction; training results; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/30/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid:  98986c28-da82-42e6-86d4-f158f3920814
---

Get Prediction Model Status Type (ARM)
======================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the [Training Model Results](../types/predictiontrainingresults.md) associated with the specified [Prediction](../types/prediction.md).


## Request 
This _POST_ request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/predictions/<predictionName>/getTrainingResults?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|predictionName|Yes|Name of the Prediction associated with the training results to retrieve|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [Training Model Results](../types/predictiontrainingresults.md), of the form: 

```{json}
{
  "tenantId": "string",
  "scoreName": "string",
  "predictionDistribution": {
    "totalPositives": 0,
    "totalNegatives": 0,
    "distributions": [
      {
        "scoreThreshold": 0,
        "positives": 0,
        "negatives": 0,
        "positivesAboveThreshold": 0,
        "negativesAboveThreshold": 0
      }
    ]
  },
  "canonicalProfiles": [
    {
      "CanonicalProfileId": "string",
      "properties": [
        {
          "profileName": "string",
          "profilePropertyName": "string",
          "rank": 0,
          "type": "Numeric",
          "value": "string"
        }
      ]
    }
  ],
  "primaryProfileInstanceCount": 0
}
```

### Status Code  
  
* 200 (OK) - Retrieval request completed successfully. 
