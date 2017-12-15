---
title: Create or Update Link (Hub)
description: Creates a new or updates an existing SAS Policy.
keywords: Customer Insights; Hub API; Link; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/02/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: a1986c28-da82-42e6-86d4-fcc8f3920003
---

Create or Update Link (Hub)
============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Link](../types/link.md) in a Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/model/links/<linkName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
|linkName|Yes|The name of the link to create or update.|  
| | | |
 

### Request Body  
A JSON object that contains a [Link](../types/link.md) definition. 

  
## Response  
 The response includes an HTTP status code and a standard set of response headers.  
  
### Status Code  
  
-   200 (OK) - the update request completed successfully. The *provisioningState* property in the response body is set to 'Succeeded' when the link provisioning finishes.
  
-   400 (Bad Request) – link definition validation fails.
