---
title: Get Image Upload URL for Instance Data (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Gets an image association to a specific data instance.  
keywords: Customer Insights; ARM API; image; upload
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/16/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920004
---

Get Image Upload URL for Instance Data (ARM)
===========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates an image association to a specific [Profile](../types/profile.md) or [Interaction](../types/interaction.md) instance and returns a SAS-based URL that enables you to subsequently upload the associated image.

## Request  
 The request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|POST|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/media/GetDataImageUploadUrl?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|The name of the Customer Insights Hub|  
| | | |


### Request Body  
The body contains a [GetImageUploadUrlRequest](../types/images.md) that specifies the instance to which an image will be associated.  
 
<br/>

## Response  
The response includes a response body, an HTTP status code and a set of standard response headers.

### Response Body  
An [ImageDefintion](../types/images.md) that describes the associated image, including a SAS-based access URL.

  
### Status Code  
  
- 200 (OK) - if the synchronous request completed successfully.  
- 400 (Bad request) - if the input does not have the required fields or if the relative path is invalid.  
