---
title: List Segment Members after Continuation (Hub Data)
description: Lists the segment members added after the specified continuation token.
keywords: Customer Insights; Hub API; segment; list; continuation
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/19/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43e8-b5f7-b8c27baf1236
---

List Segment Members after Continuation (Hub Data)
===============================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Segment](../types/segment.md) members added after the specified continuation token.  

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<Hub-endpoint>/data/segments/<segmentName>/addedMembersDelta?continuationToken=<continuationToken>&batchSize=<batchSize>&api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|segmentName|Yes|The name of the segment to custom Profile (entity set) type|
|continuationToken|No|The continuation token that marks the start of the member set|
|batchSize|No|The size of the returned resultset.|

Notes:
* The **continuationToken** parameter marks the last member processed in the current segment.  If not provided, the segment membership will be read from the start.
* Every response contains a continuation token that can be used in the next request to return the next batch of members. If **addedMembers** collection is empty, the segment processing has completed.  Additional members may be returned after the next dynamic segment evaluation.
* The **batchSize** specifies the maximum number of members returned to the client; if not provided, it’s value is set to 1000.

<br/>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body  
The body contains a JSON object with two members: a continuation token and the membership **ProfileID** array, for example:

```{json}  
{
   "continuationToken": "456",
   "members": [{"ProfileId":"cust004"},{"ProfileId":"cust018"}]
}
```

### Status Code  
  
-   200 (OK) - the request succeeded.  
-   400 (Bad Request) - invalid URI parameters, often an unrecognized continuation token.
-   404 (Not Found) - the named segment was not found.  

  