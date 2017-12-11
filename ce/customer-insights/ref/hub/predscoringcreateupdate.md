---
title: Create or Update Prediction Type (Hub)
description: Creates a new or updates an existing Prediction.
keywords: Customer Insights; Hub API; prediction; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/29/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-f158f3920803
---

Create or Update Prediction Type (Hub)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Either creates a new [Prediction](../types/prediction.md) type or updates the type if it already exists. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|PUT|`<Hub-endpoint>/manage/model/predictions/<predictionName>?api-version=2017-04-26&locale=<locale-code>`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|predictionName|Yes|Name of the prediction to update/create|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |


### Request Body  
 A JSON object describing a [Prediction](../types/prediction.md) type.


## Response  
 The response includes an HTTP status code and a set of response headers. Upon success, the body will contain information about the newly created prediction in the following form:

```{json}
{ 
    "id": <predictionUrl>, 
    "name": <predictionName>, 
    "type": "Microsoft.CustomerInsights/hubs/predictions"
}
```

### Status Code  
  
* 200 (OK) - Update request completed successfully. 
* 202 (Accepted) - Create request was accepted.  

Type provisioning is typically a long running operation. The initial request will come back with HTTP Accepted (202) with a location header to GET the 
status of the operation. The properties in the response body will have a field called *provisioningState*. Eventually performing a GET for the prediction will 
return a response where *provisioningState* is set to Succeeded, indicating success. 

