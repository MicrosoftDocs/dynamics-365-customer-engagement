---
title: Get a Relationship Link (ARM)
description: Gets the specified Relationship Link.
keywords: Customer Insights; ARM API; relationship link; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/09/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-bc18f393144
---

Get a Relationship Link (ARM)
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [RelationshipLink](../types/relationshiplink.md) type definition for the specified hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationshipLinks/<relationshipLinkName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|relationshipLinkName|Yes|The name of the relationship link to retrieve|  
| | | |

<br>

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested information, containing a [RelationshipLink](../types/relationshiplink.md) type definition, of the form: 

```{json}
{
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationshipLinks/<relationshipLinkName>'
     'name':'<hubName>/<relationshipLinkName>,
     'type':'Microsoft.CustomerInsights/hubs/relationshipLinks',
     'properties' : <RelationshipLink-Definition>
} 
```
