---
title: Get a Relationship (Hub)
description: Gets the specified Relationship.
keywords: Customer Insights; Hub API; relationship; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/23/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fc18f392055
---

Get a Relationship (Hub)
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Relationship](../types/relationship.md) type definition for the specified hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/relationships/<relationshipName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|relationshipName|Yes|The name of the relationship to retrieve|  
| | | |

<br>

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [Relationship](../types/relationship.md) type definition. 

