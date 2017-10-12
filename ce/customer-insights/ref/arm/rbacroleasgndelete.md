---
title: Delete Role Assignment (ARM)
description: Deletes a Role Assignment type.  
keywords: Customer Insights; ARM API; Role Assignment; delete
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/03/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fcc8f392008
---

Delete Role Assignment (ARM)
==========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes a [Role Assignment](../types/roleassignment.md) type.  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/roleAssignments/<assignmentName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|assignmentName|Yes|The name of the Role Assignment to delete|  
| | | |

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
- 200 (OK) - operation succeeded.
- 204 (No Content) - Role Assignment was not found.
