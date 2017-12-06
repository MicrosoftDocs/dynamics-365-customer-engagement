---
title: Delete Profile (ARM)
description: Deletes a Profile.  
keywords: Customer Insights; ARM API; Profile; delete
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/09/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fc18f392a004
---

Delete Profile (ARM)
====================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes the specified [Profile](../types/profile.md).  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/profiles/<profileName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|profileName|Yes|The name of the profile to delete|  
| | | |

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
* 200 (OK) - Delete succeeded.
* 202 (Accepted) - Delete operation was accepted and is being processed.
* 204 (No Content) - Successfully requested delete operation, but the response is intentionally empty.
