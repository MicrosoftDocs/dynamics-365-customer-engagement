---
title: Delete Role Assignment (Hub)
description: Deletes a Role Assignment type.  
keywords: Customer Insights; Hub API; Role Assignment; delete
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/03/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fcc8f392009
---

Delete Role Assignment (Hub)
==========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes the specified [Role Assignment](../types/roleassignment.md) type.  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`<hub-endpoint>/manage/rbac/roleAssignments/<assignmentName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|assignmentName|Yes|The name of the Role Assignment to delete|  
| | | |

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
- 200 (OK) - Operation succeeded.
- 204 (No Content) - Role Assignment was not found.
