---
title: Discover Salesforce Connector Tables (Hub)
description: Gets the specified Data Connector Mapping.
keywords: Customer Insights; Hub API; Salesforce Connector; tables; read
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920327
---

Discover Salesforce Connector Tables (Hub)
===============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Retrieves the Salesforce tables for the Salesforce [Connector](../types/connector.md) for a Hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/manage/salesforcemetadata/discovertables?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

The requested array of Salesforce tables:
```{json}
{
    "value": [
    {
        "isProfile" : [true|false],
        "tableCategory": "<Table category>",
        "tableName": "<Table name>",
        "tableRemarks": "<Table remarks>",
        "tableSchema": "<Table schema>"
    }]
}

```

For more information, see [Connector](../types/connector.md) type definition.  

