---
title: Get a Data Connector Type (Hub) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Gets the specified Data Connector.
keywords: Customer Insights; Hub API; Data Connector; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights
ms.assetid: 98986c28-da82-4246-86d4-fcc8f3920207
---

Get a Data Connector Type (Hub)
==============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Data Connector](../types/connector.md) definition for the specified hub.


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/connectors/<connectorName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|connectorName|Yes|The name of the data connector type to retrieve|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested connector information, including a [Connector](../types/connector.md) type definition.

