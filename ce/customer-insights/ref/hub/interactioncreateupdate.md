---
title: Create or Update Interaction Type (Hub)
description: Creates or updates an Interaction type.
keywords: Customer Insights; Hub API; Interaction; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f392000b
---

Create Or Update a Interaction Type (Hub)
=========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Either creates a new Interaction type or updates the type if it already exists. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|PUT|`<hub-endpoint>/manage/model/interactions/<interactionTypeName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|interactionTypeName|Yes|The name of the Interaction definition to retrieve|
| | | | 


### Request Body  
 A JSON object describing an [Interaction](../types/interaction.md) type.

## Response  
 The response includes an HTTP status code and a set of response headers.  
  
### Status Code  
  
-   200 (OK) - if the request completed successfully.  
  
-   201 (Created) - if the request was accepted.  
  
-   202 (Accepted) - if the request was accepted.  

Type provisioning is typically a long running operation. The initial request will come back with HTTP Accepted (202) and a location header with a URL of the form:  
&nbsp; &nbsp; &nbsp; &nbsp; `<hub-endpoint>/manage/model/operations/<operation-id>`  
The status of the operation can be queried on the URL above. It will return 202, until the operation finishes, at which time it will send back a 201 or 200.

