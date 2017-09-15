---
title: Create or Update SAS Policy (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Creates a new or updates an existing SAS Policy.
keywords: Customer Insights; ARM API; SAS Policy; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/08/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920032
---

Create or Update SAS Policy (ARM)
=================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Authentication Policy](../types/authzpolicy.md) for a resource in a Customer Insights Hub.  
  
## Request  
 The create/update SAS Policy request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/AuthorizationPolicies/<policyName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|policyName|Yes|The name of the SAS policy to create or update.|  
| | | |
 

### Request Body  
The format of the request body is as follows:  
  
```{json}  
{
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/AuthorizationPolicies/<policyName>',
     'name':'<hubName>/<policyName>,
     'type':'Microsoft.CustomerInsights/hubs/AuthorizationPolicies',
     'properties' : 
     {
        "Permissions":["Read" | "Write" | "Manage"], 
        "PrimaryKey":"adfafadaffnbvwurvnwo", 
        "SecondaryKey":"adfnadfabvwurvnwo", 
     }
  }

```  
Where the `properties` property contains a [SasPolicy](../types/authzpolicy.md) definition that optionally repeats the policy name. 

  
## Response  
 The response includes an HTTP status code and a standard set of response headers.  Upon success, the body will contain information about the newly created policy in the following form:

```{json}
{ 
    "id": <policyUrl>, 
    "name": <policyName>, 
    "type": "Microsoft.CustomerInsights/hubs/AuthorizationPolicies", 
    "properties": { <policyProperties> }
}
```
  
### Status Code  
  
- 200 (OK) - if the update request completed successfully.  
- 201 (Created) - if the create request completed successfully.  
- 401 (Unauthorized) - if the sender does not have write access to policies. 
