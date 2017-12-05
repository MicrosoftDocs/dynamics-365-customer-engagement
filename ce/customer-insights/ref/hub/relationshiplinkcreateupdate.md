---
title: Create or Update Relationship Link (Hub)
description: Creates a new or updates an existing relationship link.
keywords: Customer Insights; Hub API; relationship link; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/12/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-bc18f393141
---

Create or Update Relationship Link (Hub)
=======================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [RelationshipLink](../types/relationshiplink.md) in the specified Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/model/relationshipLinks/<relationshipLinkName>?api-version=2017-04-26`|
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|relationshipLinkName|Yes|The name of the relationship link to create or update|  
| | | |


### Request Body  
The body must supply the required properties of the [RelationshipLink](../types/relationshiplink.md) type, for example:
  
```{json}  
{
    "description": {
    	"en-us": "Link Description"
    },
    "displayName": {
    	"en-us": "Link DisplayName"
    },
    "interactionType": "testInteraction4332",
    "linkName": "testlink002",
    "profilePropertyReferences": [{
        "interactionPropertyName": "profile1",
        "profilePropertyName": "ProfileId"
    }],
    "provisioningState": "Provisioning",
    "relatedProfilePropertyReferences": [{
        "interactionPropertyName": "profile1",
        "profilePropertyName": "ProfileId"
    }],
    "relationshipName": "testProfile2326994",
    "tenantId": "sdktesthub"
}
```

<br>

## Response  
 The response includes an HTTP status code and a standard set of response headers. 

### Status Code  
  
-  200 (OK) - the update request completed successfully. The body will contain the **name**, **id**, and **type** of the new Relationship type.
-  202 (Accepted) - the request was accepted and is pending.
-  400 (Bad Request) - Validation fails or invalid JSON.
  
