---
title: Create Relationship Instance (Hub Data)
description: Creates a new Relationship instance. 
keywords: Customer Insights; Hub Data API; Relationship instance; create
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/20/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 16dda12b-bac6-423d-948f-8faa921466e0
---

Create Relationship Instance (Hub Data)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new instance of an existing custom [Relationship](../types/relationship.md) type within the specified Hub. If the instance already exists, it is updated. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<hub-endpoint>/data/Relationships?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
| | |

### Request Body  
 A JSON object describing the custom [Relationship](../types/relationship.md) type instance, of the form:

```{json}  
{
    "ProfileStrongIdFieldMappings" :[
    {
        "FieldName": "<Field in the relationshipDefinition that refers to strongId Key property of Profile>", 
        "StrongIdKeyProperty": "<Specifies the strongId Key Property of Profile>"
    } ],
    "RelatedProfileStrongIdFieldMappings" :[
    {
        "FieldName": "<Field in the relationshipDefinition that refers to strongId Key property of Related Profile>", 
        "StrongIdKeyProperty": "<Specifies the strongId Key Property of Profile>"
    } ],
    "RelationshipType" :"<Relationship TypeName for which we are posting the instance>",

    <Fields in RelationshipDefinition>
}
``` 

<br/>

## Response 
The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body
The body contains the custom Relationship instance along with the assigned Profile ID.

### Status Code

* 202 (Accepted) - if the request was accepted and the instance creation is in process.  
