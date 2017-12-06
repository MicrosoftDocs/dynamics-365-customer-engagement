---
title: Create or Update Relationship (Hub)
description: Creates a new or updates an existing relationship.
keywords: Customer Insights; Hub API; relationship; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/22/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fc18f392051
---

Create or Update Relationship (Hub)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Relationship](../types/relationship.md) in the specified Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/model/relationships/<relationshipName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|relationshipName|Yes|The name of the relationship to create or update|  
| | | |
 

### Request Body  
The body must supply the required properties of the [Relationship](../types/relationship.md) type, for example:
  
```{json}  
{
    "cardinality": "OneToOne",
    "displayName": {
    "en-us": "Relationship DisplayName"
    },
    "description": {
    	"en-us": "Relationship Description"
    },
    "fields": [<customProperties>],
    "profileType": "CurrentProfile",
    "relatedProfileType": "AssociatedProfile"
}
```  

<br>

## Response  
 The response includes an HTTP status code and a standard set of response headers.  
  
### Status Code  
  
-  200 (OK) - the update request completed successfully. The body will contain the **name**, **id**, and **type** of the new Relationship type.
-  202 (Accepted) - the request was accepted and is pending.
-  400 (Bad Request) - Validation fails or invalid JSON.
  
