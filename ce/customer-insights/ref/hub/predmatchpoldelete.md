---
title: Delete Predictive Match Policy (Hub)
description: Deletes a predictive match policy.  
keywords: Customer Insights; Hub API; predictive match policy; delete
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/15/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 5c6ac718-9758-43e8-b5f7-d8c21bbb1008
---

Delete Predictive Match Policy (Hub)
==================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes the specified [Predictive Match Policy](../types/predictivematchpolicy.md).  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`<hub-endpoint>/manage/model/predictiveMatchPolicies/<policyName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|policyName|Yes|The name of the policy type to delete|  
| | | |

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
* 200 (OK) - Delete succeeded.
* 204 (No Content) - Policy was not found.
