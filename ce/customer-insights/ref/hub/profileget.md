---
title: Get a Profile Type (Hub)
description: Gets the specified Profile.
keywords: Customer Insights; Hub API; Profile; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2ef4544f-5f9c-47a2-abbf-5418451148e7
---

Get a Profile Type (Hub)
========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Profile](../types/profile.md) type for the specified hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<Hub-endpoint>/manage/model/Profiles/<profileTypeName>?api-version=2017-04-26&locale=<locale-code>`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|profileTypeName|Yes|The name of the Profile definition to retrieve|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

### Response Body  

Contains the requested [Profile](../types/profile.md) type definition. 

### Status Code  
  
* 200 (OK) - Retrieval request completed successfully. 
