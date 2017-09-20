---
title: Delete Relationship Instance (Hub Data)
description: Deletes an existing Relationship instance. 
keywords: Customer Insights; Hub Data API; Relationship instance; delete
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/20/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 16dda12b-bac6-423d-948f-8faa921466e1
---

Delete Relationship Instance (Hub Data)
======================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Deletes an existing instance of an custom [Relationship](../types/relationship.md) type within the specified Hub.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<hub-endpoint>/data/Relationships?api-version=2017-04-26`|

And must include the following [custom HTTP request header](https://msdn.microsoft.com/en-us/library/dd541471.aspx): `X-HTTP-Method: DELETE`


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

### Status Code

* 200 (OK) - Instance deleted successfully.
