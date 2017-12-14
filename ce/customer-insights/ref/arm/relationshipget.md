---
title: Get a Relationship (ARM)
description: Gets the specified Relationship.
keywords: Customer Insights; ARM API; relationship; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/22/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fc18f392054
---

Get a Relationship (ARM)
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Relationship](../types/relationship.md) type definition for the specified hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationships/<relationshipName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|relationshipName|Yes|The name of the relationship to retrieve|  
| | | |

<br>

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested information, containing a [Relationship](../types/relationship.md) type definition, of the form: 

```{json}
{
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationships/<relationshipName>'
     'name':'<hubName>/<relationshipName>,
     'type':'Microsoft.CustomerInsights/hubs/relationships',
     'properties' : <Relationship-Definition>
}
```
