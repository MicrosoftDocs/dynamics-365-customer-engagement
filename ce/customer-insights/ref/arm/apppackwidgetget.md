---
title: Get Widget Type (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Gets the specified Widget type.
keywords: Customer Insights; ARM API; application packaging; widget; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920002
---

Get Widget Type (ARM)
======================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Widget type](../types/widgettype.md) definition for a Hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/widgetTypes/<widgetTypeName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|widgetTypeName|Yes|Name of the widget to be retrieved|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

### Status Code  
  
* 200 (OK) - The request completed successfully.  

### Response Body  

The requested Widget information, including a [WidgetType](../types/widgettype.md) type definition, of the form: 

```{json}
{
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/widgetTypes/<widgetTypeName>',
     'name':'<hubName>/<widgetTypeName>,
     'type':'Microsoft.CustomerInsights/hubs/widgetTypes',
     'properties' : <WidgetType-Definition>
  }
```
