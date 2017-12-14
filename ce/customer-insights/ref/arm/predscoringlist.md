---
title: List Prediction Types for a Hub (ARM)
description: Lists the Prediction type definitions for a Hub.
keywords: Customer Insights; ARM API; prediction; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/30/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-f158f3920808
---

List Prediction Types for a Hub (ARM)
================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Prediction](../types/prediction.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/predictions?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of [Prediction](../types/prediction.md) type definitions in the following format:

```{json}  
{
   'value':'[
    {
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/predictions/<predictionName>'
     'name':'<hubName>/<predictionName>,
     'type':'Microsoft.CustomerInsights/hubs/predictions',
     'properties' : <Prediction-Type>
    },
    . . . 
     ]',
   'nextLink':'NextLink'
  }

```  

