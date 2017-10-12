---
title: Get a Relationship Link (Hub)
description: Gets the specified Relationship Link.
keywords: Customer Insights; Hub API; relationship link; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/12/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-bc18f393145
---

Get a Relationship Link (Hub)
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [RelationshipLink](../types/relationshiplink.md) type definition for the specified hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/relationshipLinks/<relationshipLinkName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|relationshipLinkName|Yes|The name of the relationship link to retrieve|  
| | | |

<br>

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [RelationshipLink](../types/relationshiplink.md) type definition.

