---
title: Get a Profile Type (ARM)
description: Gets the specified Profile.
keywords: Customer Insights; ARM API; Profile; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920016
---

Get a Profile Type (ARM)
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Profile](../types/profile.md) type.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/profiles/<profileName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|profileName|Yes|Name of the profile to be retrieved|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [Profile](../types/profile.md) type definition, of the form: 

```{json}
  {
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/profiles/<profileName>',
     'name':'<hubName>/<profileName>',
     'type':'Microsoft.CustomerInsights/hubs/profiles',
     'properties' : <Profile-Type>
  }
```