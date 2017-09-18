---
title: Delete a Segment Type (Hub)
description: Deletes a segment entity type.
keywords: Customer Insights; Hub API; segment; delete
author: Milar1
ms.author: v-larmic
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43e8-b5f7-b8c27baf1233
---

Delete a Segment Type (Hub)
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes an existing [Segment](../types/segment.md) type. 

## Request  
 The request is constructed as follows:  

|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`<hub-endpoint>/manage/model/segments/<segmentName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|segmentName|Yes|The name of the segment type to delete|  
| | | |

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
* 200 (OK) - Delete succeeded
* 202 (Accepted) - Delete being processed
- 403 (Forbidden) - Operation was blocked, perhaps because the Segmentation feature flag is disabled.
- 404 (Not Found) - Specified segment was not found
- 409 (Conflict) - Segment is in an intermediate provisioning state
