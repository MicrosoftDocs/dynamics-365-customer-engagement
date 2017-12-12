---
title: Get a Interaction Type (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Gets the specified Interaction.
keywords: Customer Insights; ARM API; Interaction; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f392000c
---

Get a Interaction Type (ARM)
============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Interaction](../types/interaction.md) type definition for the specified hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/interactions/<interactionName>?api-version=2017-04-26 `|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|interactionName|Yes|Name of the interaction to be retrieved|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

### Status Code  
  
* 200 (OK) - The request completed successfully.  


#### Response Body  

The requested [Interaction](../types/interaction.md) type definition. 
