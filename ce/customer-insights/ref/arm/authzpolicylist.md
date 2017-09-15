---
title: List SAS Policies for a Hub (ARM)
description: Lists the SAS Policy type definitions for a Hub.
keywords: Customer Insights; ARM API; SAS Policies; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f392003a
---

List SAS Policies for a Hub (ARM)
===============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Authentication Policy](../types/authzpolicy.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/AuthorizationPolicies?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of policy information that includes [SAS Policy](../types/authzpolicy.md) definitions, in the following form:

```{json}  
{
   'value':'[
            {
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/AuthorizationPolicies/<policyName>'
     'name':'<hubName>/<policyName>,
     'type':'Microsoft.CustomerInsights/hubs/AuthorizationPolicies',
     'properties' : <SASPolicy-Definition>
            },
            {
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/AuthorizationPolicies/<policyName>'
     'name':'<hubName>/<policyName>,
     'type':'Microsoft.CustomerInsights/hubs/AuthorizationPolicies',
     'properties' : <SASPolicy-Definition>
            }
            ]',
   'nextLink':'NextLink'
  }

```  

### Status Code  
-   200 (OK) - the policy was retrieved successfully.  

-   401 (Access denied) - not authorized to read resource.

