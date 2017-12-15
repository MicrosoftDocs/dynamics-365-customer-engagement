---
title: List Data Connectors for a Hub (Hub)
description: Gets the Data Connector type definitions for a Hub.
keywords: Customer Insights; Hub API;  Data Connectors; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920009
---

List Data Connectors for a Hub (Hub)
===================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Data Connector](../types/connector.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/connectors?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

An array of [Connector](../types/connector.md) definitions.


### Status Code  
-   200 (OK) - if the policy retrieved successfully.  
-   401 (Access denied) - not authorized to read resource.


