---
title: Delete Relationship Link (ARM)
description: Deletes a Relationship Link type.  
keywords: Customer Insights; ARM API; relationship link; delete
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/09/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-bc18f393142
---

Delete Relationship Link (ARM)
==============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes a [RelationshipLink](../types/relationshiplink.md) type.  

## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|DELETE|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationshipLinks/<relationshipLinkName>?api-version=2017-04-26`|  
| | |

### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|relationshipLinkName|Yes|The name of the RelationshipLink to delete|  
| | | |

<br>
  
## Response  
 The response includes an HTTP status code and a set of standard response headers.  
  
### Status Code  
- 200 (OK) - operation succeeded.
- 202 (Accepted) - request was accepted and is pending.
