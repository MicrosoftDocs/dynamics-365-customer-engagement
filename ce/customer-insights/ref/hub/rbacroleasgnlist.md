---
title: List Role Assignments for a Hub (Hub)
description: Lists the KPI type definitions for a Hub.
keywords: Customer Insights; Hub API; role assignments; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fcc8f392007
---

List Role Assignments for a Hub (Hub)
==================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Role Assignment](../types/roleassignment.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/rbac/roleAssignments?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | | |

<br>

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A linked collection of [Role Assignment](../types/roleassignment.md) identifiers of the form:

```{json}  
{
  "value": [
    {
      "id": "string",
      "name": "string",
      "type": "string"
    }
  ],
  "nextLink": "url"
}

```  
