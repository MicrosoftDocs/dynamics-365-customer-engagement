---
title: Get a SAS Policy (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Gets a Shared Access Signature (SAS) policy.
keywords: Customer Insights; ARM API; SAS Policy; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920034
---

Get a SAS Policy (ARM)
=======================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Authentication Policy](../types/authzpolicy.md) type for resources in the specified hub.


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/AuthorizationPolicies/<policyName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|policyName|Yes|Name of the policy to be retrieved|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

### Status Code  

* 200 (OK) - Policy was retrieved successfully.  
* 401 (Access denied) - not authorized to read resource.
* 404 (Not Found) - requested policy not found.

### Response Body  

The requested policy information, including a [SasPolicy](../types/authzpolicy.md) type definition, of the form: 

```{json}
{
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/AuthorizationPolicies/<policyName>',
     'name':'<hubName>/<policyName>,
     'type':'Microsoft.CustomerInsights/hubs/AuthorizationPolicies',
     'properties' : <SasPolicy-Definition>
}
  
```

