---
title: Create Or Update a Profile Type (Hub)
description: Either creates a new Profile type or updates the type if it already exists. 
keywords: Customer Insights; Hub API;  Profile; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/03/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 929b25f4-1078-4980-96d6-7b8aec0f0270
---

Create Or Update a Profile Type (Hub)
===================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Either creates a new [Profile](../types/profile.md) type or updates the type if it already exists. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|PUT|`<Hub-endpoint>/manage/model/profiles/<profileTypeName>?api-version=2017-04-26&locale=<locale-code>`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|profileTypeName|Yes|The name of the Profile definition to retrieve|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |

### Request Body  
 A JSON object describing a [Profile](../types/profile.md) type.

## Response  
 The response includes an HTTP status code and a set of response headers.  
  
### Status Code  
  
* 200 (OK) - if the request completed successfully.  
* 201 (Created) - if the request was accepted.  
* 202 (Accepted) - if the request was accepted.  

Type provisioning is typically a long running operation. The initial request will come back with HTTP Accepted (202) and a location header with a URL of the form:  
&nbsp; &nbsp; &nbsp; &nbsp; `<hub-endpoint>/manage/model/operations/<operation-id>`  
The status of the operation can be queried on the URL above. It will return status 202 until the operation finishes, at which time it will send back a 201 or 200.

