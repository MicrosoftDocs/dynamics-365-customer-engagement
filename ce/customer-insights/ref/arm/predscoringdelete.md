---
title: Delete Prediction (ARM)
description: Deletes a Prediction.  
keywords: Customer Insights; ARM API; prediction; delete
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/29/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-f158f3920806
---

Delete Prediction (ARM)
====================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes the specified [Prediction](../types/prediction.md).  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/predictions/<predictionName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|predictionName|Yes|The name of the prediction type to delete|  
| | | |


## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
* 200 (OK) - Delete succeeded.
* 202 (Accepted) - Delete operation was accepted and is being processed.
