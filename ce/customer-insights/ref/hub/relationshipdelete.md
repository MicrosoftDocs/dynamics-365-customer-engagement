---
title: Delete Relationship (Hub)
description: Deletes a Relationship type.  
keywords: Customer Insights; Hub API; Relationship; delete
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/22/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fc18f392053
---

Delete Relationship (Hub)
==========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes a [Relationship](../types/relationship.md) type.  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`<hub-endpoint>/manage/model/relationships/<relationshipName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|relationshipName|Yes|The name of the Relationship to delete|  
| | | |

<br>
  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
- 200 (OK) - operation succeeded.
- 202 (Accepted) - Request was accepted and is pending.
- 204 (No Content) - Specified relationship was not found.
