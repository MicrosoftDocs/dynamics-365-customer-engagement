---
title: Create or Update SAS Policy (Hub)
description: Creates a new or updates an existing SAS Policy.
keywords: Customer Insights; Hub API; SAS Policy; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920033
---

Create or Update SAS Policy (Hub)
=================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Authentication Policy](../types/authzpolicy.md) for a resource in a Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/sas/Policies/<policyName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|policyName|Yes|The name of the SAS policy to create or update|  
| | | |
 

### Request Body  
The request body must contain a [SasPolicy](../types/authzpolicy.md) definition that optionally repeats the policy name.  
  
```{json}  
{
    "Permissions":["Read" | "Write" | "Manage"], 
    "PrimaryKey":"adfafadaffnbvwurvnwo", 
    "SecondaryKey":"adfnadfabvwurvnwo", 
     
}

```  
  
 The following table describes the elements of the request body.  
  
## Response  
 The response includes an HTTP status code and a standard set of response headers.  
  
### Status Code  
  
-   200 (OK) - if the update request completed successfully.  
  
-   201 (Created) - if the create request completed successfully.  
  
-   401 (Unauthorized) - if the sender does not have write access to policies. 

