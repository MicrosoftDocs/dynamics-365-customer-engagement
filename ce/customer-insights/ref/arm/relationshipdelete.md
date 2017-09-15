---
title: Delete Relationship (ARM)
description: Deletes a Relationship type.  
keywords: Customer Insights; ARM API; Relationship; delete
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/22/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fc18f392052
---

Delete Relationship (ARM)
==========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes a [Relationship](../types/relationship.md) type.  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationships/<relationshipName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|relationshipName|Yes|The name of the Relationship to delete|  
| | | |

<br>
  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
- 200 (OK) - operation succeeded.
- 202 (Accepted) - request was accepted is is pending.
