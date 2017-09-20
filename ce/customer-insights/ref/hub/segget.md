---
title: Get a Segment Type (Hub)
description: Gets the specified segment entity type.
keywords: Customer Insights; Hub API; segment; get
author: Milar1
ms.author: v-larmic
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43e8-b5f7-b8c27baf1235
---

Get a Segment Type (Hub)
========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Segment](../types/segment.md) type definition. 


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<Hub-endpoint>/manage/model/segments/<segmentName>?api-version=2017-04-26&&locale=<locale-code>`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|segmentName|Yes|The name of the Segment definition to retrieve|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |

## Response
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

### Response Body

Upon success, contains the requested [Segment](../types/segment.md) type definition.  

### Status Code 
  
* 200 (OK) - Segment was returned successfully.
* 403 (Forbidden) - Operation was blocked, usually because the Segmentation feature flag is disabled.
* 404 (Not Found) - Specified segment name was not found.
