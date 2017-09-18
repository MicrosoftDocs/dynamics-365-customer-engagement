---
title: Create or Update Prediction Model Status Type (ARM)
description: Creates a new or updates an existing status of a prediction model.
keywords: Customer Insights; ARM API; prediction model status; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/30/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid:  98986c28-da82-42e6-86d4-f158f3920810
---

Create or Update Prediction Model Status Type (ARM)
=================================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Either creates a new [Prediction Model Status](../types/predictionmodelstatus.md) type or updates the type if it already exists. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/predictions/<predictionName>/modelStatus?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
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
 The response includes an HTTP status code and a set of response headers. 


### Status Code  
  
* 200 (OK) - Creation/update request completed successfully. 

