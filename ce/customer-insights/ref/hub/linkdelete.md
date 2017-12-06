---
title: Delete Link (Hub)
description: Deletes a Link.  
keywords: Customer Insights; Hub API; Link; delete
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/02/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: a1986c28-da82-42e6-86d4-fcc8f3920009
---

Delete Link (Hub)
===============

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes a [Link](../types/link.md).  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`<hub-endpoint>/manage/model/links/<linkName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|linkName|Yes|The name of the link type to delete|  
| | | |

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
- 200 (OK) - delete succeeded.
- 204 (No Content) - link was not found.
