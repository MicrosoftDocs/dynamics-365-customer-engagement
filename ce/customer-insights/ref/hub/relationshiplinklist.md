---
title: Lists Relationship Links for a Hub (Hub)
description: Lists the Relationship Link type definitions for a Hub.
keywords: Customer Insights; Hub API; relationship links; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/12/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-bc18f393147
---

List Relationship Links for a Hub (Hub)
=====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [RelationshipLink](../types/relationshiplink.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/relationshipLinks?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | | |

<br>

## Response 
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A linked collection of [RelationshipLink](../types/relationshiplink.md) type definitions of the form:

```{json}  
{
  "value": [
    {
      "id": "string",
      "name": "string",
      "type": "Microsoft.CustomerInsights/hubs/relationshipLinks"
      "properties": { <relationshipLink-properties> }
    }
  ],
  "nextLink": "url"
}
```  
