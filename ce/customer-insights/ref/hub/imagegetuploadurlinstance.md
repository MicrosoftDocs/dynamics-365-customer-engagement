---
title: Get Image Upload URL for Instance Data (Hub)
description: Creates an image association to a specific data instance.
keywords: Customer Insights; Hub API; image; 
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920005
---

Get Image Upload URL for Instance Data (Hub)
===========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates an image association to a specific [Profile](../types/profile.md) or [Interaction](../types/interaction.md) instance and returns a SAS-based URL that enables you to 
subsequently upload the associated image.

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|POST|`<hub-endpoint>/manage/model/media/GetDataImageUploadUrl?api-version=2017-04-26&locale=<locale-code>`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | | 
  

### Request Body  
The body contains a [GetImageUploadUrlRequest](../types/images.md) that specifies the instance to which an image will be associated.  
 
<br/>

## Response  
The response includes a response body, an HTTP status code and a set of standard response headers.

### Response Body  
An [ImageDefintion](../types/images.md) that describes the associated image, including a SAS-based access URL.

  
### Status Code  
  
-   200 (OK) - if the synchronous request completed successfully.  
  
-   400 (Bad request) - if the input does not have the required fields or if the relative path is invalid.  

