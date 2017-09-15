---
title: Get a SAS Policy (Hub)
description: Gets a Shared Access Signature (SAS) policy.  
keywords: Customer Insights; Hub API; SAS Policy; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920035
---

Get a SAS Policy (Hub)
=======================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets a [Authentication Policy](../types/authzpolicy.md) for a resource in the specified hub. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/sas/Policies/<policyName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|policyName|Yes|Name of the policy to be retrieved|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [SasPolicy](../types/authzpolicy.md) type definition.

### Status Code  
-   200 (OK) - if the policy retrieved successfully.  
-   401 (Access denied) - not authorized to read resource.
-   404 (Not Found) - requested policy not found.  

