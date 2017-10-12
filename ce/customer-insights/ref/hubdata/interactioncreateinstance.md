---
title: Create Interaction Instance (Hub Data)
description: Creates a new Interaction instance. 
keywords: Customer Insights; Hub Data API;  Interaction instance; create
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/03/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 6ccb25f4-1078-4980-96d6-7b8aec0f0211
---

Create Interaction Instance (Hub Data)
==============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new [Interaction](../types/interaction.md) instance within the specified Hub. If the instance already exists, it is updated.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<hub-endpoint>/data/Interactions?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.|


### Request Body  
 A JSON object describing a [Interaction](../types/interaction.md) instance, for example:

```{json}  
{
    'InteractionType':'EmailSent',
    ... <etc.>
  }
```    

<br/>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body  
The body contains the Interaction instance along with the assigned Interaction ID and timestamp (in UTC), for example:

```{json}  
{
     'InteractionId': '<SomeId>',
     'InteractionType':'EmailSent',
    ... <etc.>
     'TimeStamp': '<DateTime-Offset>'
  }
```    


### Status Code  
  
-   202 (Accepted) - if the request was accepted and the instance creation is in process.  


