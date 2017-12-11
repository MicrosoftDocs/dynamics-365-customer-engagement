---
title: Create Profile Instance (Hub Data)
description: Creates a new Profile instance. 
keywords: Customer Insights; Hub Data API;  Profile instance; create
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 6ccb25f4-1078-4980-96d6-7b8aec0f0201
---

Create Profile Instance (Hub Data)
==================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new instance of an existing custom [Profile](../types/profile.md) type within the specified Hub. If the instance already exists, it is updated. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<hub-endpoint>/data/<profileType>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|profileType|Yes|The custom Profile (entity set) type|
| | | |

### Example
`POST myapp.api.azurecustomerinsights.com/data/Contacts?api-version=2017-04-26` 

### Request Body  
 A JSON object describing the custom [Profile](../types/profile.md) type instance, for example:

```{json}  
{
    'Id':'SomeId',
    'FirstName': 'John',
    'LastName' : 'Doe',
    'Phone': '934-634-3771'
}
```    

<br/>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body  
The body contains the custom Profile instance along with the assigned Profile ID, for example:

```{json}  
{
     'ProfileId' : 'SomeId',
     'Id':'SomeId',
     'FirstName': 'Cri',
     'LastName' : 'Xus',
     'Phone': '934-634-3771'
}
```    


### Status Code  
  
-   202 (Accepted) - if the request was accepted and the instance creation is in process.  


