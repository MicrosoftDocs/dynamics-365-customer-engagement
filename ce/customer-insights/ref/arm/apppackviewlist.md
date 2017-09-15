---
title: List App View Types for a Hub (ARM) 
description: Lists the Application View type definitions for a Hub.
keywords: Customer Insights; ARM API; application packaging; View; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/16/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920008
---

Get App View Types for a Hub (ARM)
=================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the Application [View](../types/view.md) type definitions for the specified Hub.


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/views?api-version=2017-04-26`|

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

A linked collection of [View](../types/view.md) type definitions of the form:

```{json}
{
   'value':'[
    {
       'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/views/<viewName>'
       'name':'<hubName>/<viewName>,
       'type':'Microsoft.CustomerInsights/hubs/views',
       'properties' : <View-Definition>
    },
    {
       'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/views/<viewName>'
       'name':'<hubName>/<viewName>,
       'type':'Microsoft.CustomerInsights/hubs/views',
       'properties' : <View-Definition>
    } ]',
   'nextLink':'NextLink'
}
```
