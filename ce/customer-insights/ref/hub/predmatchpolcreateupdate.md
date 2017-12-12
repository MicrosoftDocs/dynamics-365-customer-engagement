---
title: Create or Update Predictive Match Policy (Hub)
description: Creates a new or updates an existing  Predictive Match Policy.
keywords: Customer Insights; Hub API; predictive match policy; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/12/2017
ms.topic: reference
ms.service: customer-insights
ms.assetid: 5c6ac718-9758-43e8-b5f7-d8c21bbb1002
---

Create or Update Predictive Match Policy (Hub)
==============================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Predictive Match Policy ](../types/predictivematchpolicy.md) in a Customer Insights Hub. Changes to an existing policy are not guaranteed to take effect until the next scheduled run of the Predictive Match Service.

## Request  
 The request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/model/predictiveMatchPolicies/<policyName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
|linkName|Yes|The name of the link to create or update.|  
| | | |


### Request Body  
A JSON object that contains a [Predictive Match Policy ](../types/predictivematchpolicy.md) definition.

## Response  
 The response includes an HTTP status code and a standard set of response headers. 

### Status Code  
  
* 200 (OK) - Update request completed successfully. 
* 202 (accepted) - Creation request accepted and is being processed.
* 400 (Bad Request) – Policy definition validation failed.
