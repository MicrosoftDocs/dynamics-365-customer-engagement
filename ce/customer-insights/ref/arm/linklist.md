---
title: List Link Types for a Hub (ARM)
description: Lists the Link type definitions for a Hub.
keywords: Customer Insights; ARM API; Link; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: a1986c28-da82-42e6-86d4-fcc8f3920006
---

List Link Types for a Hub (ARM)
============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Link](../types/link.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/links?api-version=2017-04-26`|

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

A collection of [Link](../types/link.md) definitions in the following format:

```{json}  
{
   'value':'[
    {
        'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/links/<linkName>'
        'name':'<hubName>/<linkName>,
        'type':'Microsoft.CustomerInsights/hubs/links',
        'properties' : <Link-Definition>
    }, 
    {
        'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/links/<linkName>'
        'name':'<hubName>/<linkName>,
        'type':'Microsoft.CustomerInsights/hubs/links',
        'properties' : <Link-Definition>
    }  ]',
   'nextLink':'NextLink'
}
```  
