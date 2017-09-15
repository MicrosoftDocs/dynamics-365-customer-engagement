---
title: Get a Predictive Match Policy Type (Hub)
description: Gets the specified Predictive Match Policy.
keywords: Customer Insights; Hub API; Predictive Match Policy; get
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/14/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 5c6ac718-9758-43e8-b5f7-d8c21bbb1004
---

Get a Predictive Match Policy Type (ARM)
======================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Predictive Match Policy](../types/predictivematchpolicy.md) type.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/model/predictiveMatchPolicies/<policyName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|policyName|Yes|The name of the predictive match policy to retrieve|  
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested [Predictive Match Policy](../types/predictivematchpolicy.md) type definition.
