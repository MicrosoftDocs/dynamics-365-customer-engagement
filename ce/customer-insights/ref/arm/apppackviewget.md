---
title: Get App View (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Gets the specified Application View type.
keywords: Customer Insights; ARM API; application packaging; App View; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920006
---

Get App View (ARM)
===================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Application View](../types/view.md) type definition for a Hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/views/<viewName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|viewName|Yes|Name of the app view to be retrieved|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

### Status Code  
  
* 200 (OK) - The request completed successfully.  


### Response Body  

The requested view information, including a [View](../types/view.md) type definition, of the form: 

```{json}
{
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/views/<viewName>',
     'name':'<hubName>/<viewName>,
     'type':'Microsoft.CustomerInsights/hubs/views',
     'properties' : <View-Definition>
}
```
