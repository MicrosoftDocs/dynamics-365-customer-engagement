---
title: List Profile Types for a Hub (Hub)
description: Lists the Profile type definitions for a Hub.
keywords: Customer Insights; Hub API; Profile; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: c856af9c-4e70-4d00-a1ef-d90a7126cde2
---

List Profile Types for a Hub (Hub)
================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Profile](../types/profile.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<Hub-endpoint>/manage/model/Profiles?api-version=2017-04-26&locale=<locale-code>`|
| | |

### URI Parameters


|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |

## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of [Profile](../types/profile.md) type definitions in the following format:

```{json}  
{ 
    'value' : <Profile-Definition>,  
    . . .
    'nextLink':'Next-Link'
}
  
```    
