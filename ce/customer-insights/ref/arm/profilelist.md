---
title: List Profile Types for a Hub (ARM)
description: Lists the Profile type definitions for a Hub.
keywords: Customer Insights; ARM API; Profile; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920018
---

List Profile Types for a Hub (ARM)
================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Profile](../types/profile.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/profiles?api-version=2017-04-26`|

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

A collection of [Profile](../types/profile.md) type definitions in the following format:

```{json}  
{
   'value':'[
    {
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/profiles/<profileName>'
     'name':'<hubName>/<profileName>,
     'type':'Microsoft.CustomerInsights/hubs/profiles',
     'properties' : <Profile-Type>
    },
    {
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/profiles/<profileName>'
     'name':'<hubName>/<profileName>,
     'type':'Microsoft.CustomerInsights/hubs/profiles',
     'properties' :  <Profile-Type>
    } ]',
   'nextLink':'NextLink'
  }

```  
