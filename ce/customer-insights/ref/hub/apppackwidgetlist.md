---
title: List Widget Types for a Hub (Hub) 
description: Lists the Widget type definitions for a Hub.
keywords: Customer Insights; Hub API; application packaging; widget; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/12/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920005
---

List Widget Types for a Hub (Hub)
===============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Widget type](../types/widgettype.md) definitions for the specified Hub.


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/widgetTypes?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.| 
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

An array of the requested [WidgetType](../types/widgettype.md) type definitions of the form: 

```{json}
{
   'value': [
    {
        'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/widgetTypes/<widgetTypeName>'
        'name':'<hubName>/<widgetTypeName>,
        'type':'Microsoft.CustomerInsights/hubs/widgetTypes',
        'properties' : <WidgetType-Definition>
    }],
   'nextLink': '<url>'
}
``` 

