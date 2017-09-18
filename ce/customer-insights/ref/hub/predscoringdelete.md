---
title: Delete Prediction (Hub)
description: Deletes a Prediction.  
keywords: Customer Insights; ARHubM API; prediction; delete
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/29/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-f158f3920807
---

Delete Prediction (ARM)
====================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes the specified [Prediction](../types/prediction.md).  

## Request  
 The request is constructed as follows:  

|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`<Hub-endpoint>/manage/model/predictions/<predictionTypeName>?api-version=2017-04-26`|  

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|predictionTypeName|Yes|The name of the Prediction definition to delete|

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
* 200 (OK) - Delete succeeded.
* 202 (Accepted) - Delete operation was accepted and is being processed.
