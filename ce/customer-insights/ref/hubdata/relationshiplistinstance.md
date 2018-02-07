---
title: List Relationship Instances (Hub Data)
description: List instances of a custom Relationship type. 
keywords: Customer Insights; Hub Data API; Relationship instance; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/20/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 16dda12b-bac6-423d-948f-8faa921466e2
---

List Relationship Instances (Hub Data)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

List instances of a custom [Relationship](../types/relationship.md) type within the specified Hub, using various criteria.

## Request

There are several different formulations of this request.


### List All Relationship Instances

Lists all the relationship instances for the specified hub.

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/Relationships?api-version=2017-04-26`|
| | |

<br>

### List Relationship Instances By Type

Lists all the relationship instances of the specified custom type for the specified hub.

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/Relationships?$filter=RelationshipType eq '<typeName>'&api-version=2017-04-26`|
| | |

<br>

### Get Relationships Of a Profile by Profile ID

This operation is an extension of the [Get Profile Instance by ID](./profilegetinstanceid.md) operation, and has the form:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/<profileTypes>('<ProfileId>')/Relationships?api-version=2017-04-26`|
| | |


### Get Relationships Of a Profile by StrongId

This operation is an extension of the [Get Profile Instance by ID](./profilegetinstanceid.md) operation using strong IDs, and has one of the following forms, depending on how many properties are used to form the key of the strong ID:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/<profileTypes>(KeyProperty='<kpValue>')/Relationships?api-version=2017-04-26`|
|GET|`<hub-endpoint>/data/<profileTypes>(KeyProperty1='<kp1Value>', KeyProperty2='<kp2Value>')/Relationships?api-version=2017-04-26`|
| | |



## URI Parameters

The parameters for the various formulations are as follows:

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|


<br/>

## Response 
The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body

A collection of custom [Relationship](../types/relationship.md) instances, of the form: 

```{json}
{
    "value": [<array-of-relationship-instances>]
    "nextLink": "<nextURL>"
}
```
The maximum number of instances per response is 30, with the _nextURL_ string containing a pointer to the next "page" of results.

### Status Code

* 200 (OK) - The request completed successfully.  
