---
title: Delete Hub (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Deletes a Customer Insights Hub.  
keywords: Customer Insights; ARM API; Hub; delete
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/07/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: bf707397-fe14-438b-baf7-06bb3c984811
---

Delete Hub (ARM)
===============

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes a Customer Insights [Hub](../types/hub.md).  

## Request  
 The delete hub request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|The name of the hub to delete|  
| | | |

  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
  
- 200 (OK) - if the synchronous request completed successfully.  
- 202 (Accepted) - if the asynchronous request was accepted.  
- 409 (Conflict) - if an operation is already being performed on the hub.  
