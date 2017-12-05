---
title: Get enriching KPIs for a Profile (ARM)
description: Gets the specified Profile.
keywords: Customer Insights; ARM API; Profile; get enriching KPIs
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/09/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fc18f392a006
---

Get enriching KPIs for a Profile (ARM)
=====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the enriching [KPIs](../types/kpi.md) for the specified profile.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/profiles/<profileName>/getEnrichingKpis?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|profileName|Yes|Name of the profile to retrieve associated enriching KPIs|
| | | |


## Response  
The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

An array of enriching [KPIs](../types/kpi.md) for the specified profile.  This array will be empty if the profile has no enriching KPIs.

### Status Code  
* 200 (OK) - Retrieval succeeded.
* 404 (Not Found) - Specified Profile could not recognized.

