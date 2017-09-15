---
title: Suggest Relationships for Interaction Type (Hub)
description: Suggests relationships to create relationship links for the specified Interaction type.
keywords: Customer Insights; Hub API; Interaction; suggest relationship
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/22/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3a200ad
---

Suggest Relationships for Interaction Type (Hub)
==============================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Suggests [Relationships](../types/relationship.md) for the specified [Interaction](../types/interaction.md) type. These suggestions can be subsequently used to create [RelationshipLinks](../types/relationshiplink.md).  Relationships are inferred through property and existing relationship analysis.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<hub-endpoint>/manage/model/interactions/<interactionName>/suggestRelationshipLinks?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|interactionName|Yes|Name of the interaction to process|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.


#### Response Body  

The returned value contains the interaction name and an array of suggested relationships, of the form: 

```{json}
{
  "interactionName": "string",
  "suggestedRelationships": [
    {
      "profileName": "string",
      "profilePropertyReferences": [
        {
          "interactionPropertyName": "string",
          "profilePropertyName": "string"
        }
      ],
      "relatedProfileName": "string",
      "relatedProfilePropertyReferences": [
        {
          "interactionPropertyName": "string",
          "profilePropertyName": "string"
        }
      ],
      "existingRelationshipName": "string"
    }
  ]
}
  
```
