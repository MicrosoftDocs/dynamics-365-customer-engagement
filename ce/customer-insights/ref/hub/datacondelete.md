---
title: Delete Data Connector (Hub)
description: Deletes the specified Data Connector.
keywords: Customer Insights; Hub API; Data Connector; delete
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920015
---

Delete Data Connector (Hub)
==========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes the specified Data [Connector](../types/connector.md).

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|DELETE|`<hub-endpoint>/manage/connectors/<connectorName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|connectorName|Yes|Name of the data connector to be deleted|
| | | |

## Response  
 The response includes a standard HTTP status code and a set of standard response headers.


### Status Code  
  
-   200 (OK) - delete succeeded




