---
title: Lists Relationships for a Hub (ARM)
description: Lists the Relationship type definitions for a Hub.
keywords: Customer Insights; ARM API; relationships; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/23/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fc18f392055
---

List Relationships for a Hub (ARM)
==================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Relationship](../types/relationship.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationships?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
| | | |

<br>

## Response 
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A linked collection of [Relationship](../types/relationship.md) identifiers of the form:

```{json}  
{
   'value':'[
    {
        'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationships/<relationshipName>'
        'name':'<hubName>/<relationshipName>,
        'type':'Microsoft.CustomerInsights/hubs/relationships',
        'properties' : <Relationship-Definition>
    }, 
    {
        'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationships/<relationshipName>'
        'name':'<hubName>/<relationshipName>,
        'type':'Microsoft.CustomerInsights/hubs/relationships',
        'properties' : <Relationship-Definition>
    }  ]',
   'nextLink':'NextLink'
}
```  
