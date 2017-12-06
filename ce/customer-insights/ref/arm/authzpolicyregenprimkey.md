---
title: Regenerate Primary Key of a SAS Policy (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Regenerates the primary key of the storage account associated with a SAS Policy.
keywords: Customer Insights; ARM API; SAS Policy; regenerate key
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920036
---

Regenerate Primary Key of a SAS Policy (ARM)
===========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Regenerates the primary key of the storage account associated with a [Authentication Policy](../types/authzpolicy.md). 

## Request  
 The request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|POST|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/AuthorizationPolicies/<policyName>/regenerateprimarykey?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|policyName|Yes|The name of SAS Policy associated with the key|  
| | | |

<br/>

## Response  
The response includes a response body, an HTTP status code and a set of standard response headers.

### Response Body  
A [SasPolicy](../types/authzpolicy.md) type definition containing the new key.

  
### Status Code  
  
- 200 (OK) - if the request completed successfully.  
- 401 (Access denied) - not authorized to perform regen operation.
