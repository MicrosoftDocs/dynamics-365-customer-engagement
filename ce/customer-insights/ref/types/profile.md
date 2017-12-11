---
title: Profile Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: A Profile contains a set of properties that describe an entity in a specific context.
keywords: Customer Insights; type; profile
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/09/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2d28b8d4-c768-49b2-9602-8fab0133eff1
---

Profile Type Definition
=======================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A Profile contains a set of properties that describe an entity (often a person, but can be an organization or other noun) in a particular context. (Semantically a Profile is equivalent to a ["Thing"](http://schema.org/Thing).) A Profile may contain demographic, geographic, and behavioral information about a person or organization, including his timeline (history of changes), interactions over time, and associations (specified or inferred relationships). An individual may have different Profiles depending on the context. Customer Insights provides the ability to model, enrich and interact with Profiles in real time.  It also gives the ability to model and derive insights across the profiles in the store. The profiles are progressively adapted in response to ingestion events.

Profiles can be programmatically managed through either the [ARM Type Modeling APIs](../arm/typemodeling.md) or the [Hub Type Modeling APIs](../hub/typemodeling.md). 

## Properties

The supported fundamental data types for properties for the Profile type are **bool**, **byte**, **datetimeoffset**, **decimal**, **double**, **guid**, **int**, 
**long**, **short** and **string**. Keys for a Profile enable the lookup of a specific profile instance. Keys can consist of a single property, or a tuple 
of properties. The key value(s) have to be unique for each profile instance of that type. The primary key for every type is a system generated property called *ProfileId*. 

### ProfilTypeDefinition properties:
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|strongIds*|List StrongId (see below)|Among the properties defined for types, one or more can be designated as ID types (defining sort of the primary key for the type). Each strongId represents a key or a composite Key. You can have multiple composite keys, which are exposed as [OData alternate keys](https://github.com/OData/vocabularies/blob/master/OData.Community.Keys.V1.md).|  
|apiEntitySetName|string|(Required) Unique collection name for the Profile type, used as the name of the entity set for the type in the resulting OData data endpoint. For a hub, the ApiEntitySetName should be different for each type (across Profile and Interaction types).|
|schemaItemTypeLink|string|URL-encoded schema.org type link for the Profile type. This helps the system build semantic intelligence about the profile.|
|smallImage|string|Relative path of the 'small' size image associated with the Profile type. Actual image must be uploaded using Image Management APIs.|
|mediumImage|string|Relative path of the 'medium' size image associated with the Profile type. Actual image must be uploaded using Image Management APIs.|
|largeImage|string|Relative path of the 'large' size image associated with the Profile type. Actual image must be uploaded using Image Management APIs.|
|displayName|Dictionary\<string, string\>|Localized display names for the type|
|description|Dictionary\<string, string\>|Localized descriptions for the type|
|localizedAttributes|Dictionary\<string, Dictionary\<string, string\>\>|Any custom localized attributes for the type|
|attributes|Dictionary\<string, string[]\>|Any custom attributes for the type|
|fields|[Field](./field.md)[ ]|The custom properties (fields) of this type|
| | | |


### StrongId properties:  
The StrongId type provides values for creating keys. 

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|keyPropertyNames*|string|The fields which make up the unique Id|
|strongIdName*|string|Name of the Strong ID|
|displayName|Dictionary\<string,string\>|The localized display names|
|descriptions|Dictionary\<string,string\>|The localized descriptions|
| | | |


## JSON example

~~~{json}
{
    "strongIds": [{
        "keyPropertyNames": ["Id",
            "savingAccountBalance"],
        "strongIdName": "Id"
    },
    {
        "keyPropertyNames": ["ProfileId",
            "LastName"],
        "strongIdName": "ProfileId"
    },
    {
        "keyPropertyNames": ["ProfileId"],
        "strongIdName": "ProfileId"
    }],
    "apiEntitySetName": "TestProfileType396",
    "entityType": "Profile",
    "instancesCount": 0,
    "provisioningState": "Provisioning",
    "schemaItemTypeLink": "SchemaItemTypeLink",
    "tenantId": "sdktesthub",
    "typeName": "TestProfileType39",
    "largeImage": "\\\\Images\\\\TestProfile3.jpg",
    "smallImage": "\\\\Images\\\\TestProfile1.jpg"
    "fields": [{
        "fieldName": "Id",
        "fieldType": "Edm.String",
        "isArray": false,
        "isEnum": false,
        "isFlagEnum": false,
        "isImage": false,
        "isLocalizedString": false,
        "isName": false,
        "isRequired": true,
        "propertyId": "id1"
    },
    {
        "fieldName": "ProfileId",
        "fieldType": "Edm.String",
        "isArray": false,
        "isEnum": false,
        "isFlagEnum": false,
        "isImage": false,
        "isLocalizedString": false,
        "isName": false,
        "isRequired": true,
        "propertyId": "id1"
    },
    {
        "fieldName": "LastName",
        "fieldType": "Edm.String",
        "isArray": false,
        "isEnum": false,
        "isFlagEnum": false,
        "isImage": false,
        "isLocalizedString": false,
        "isName": false,
        "isRequired": true,
        "propertyId": "id1"
    },
    {
        "fieldName": "SavingAccountBalance",
        "fieldType": "Edm.Int32",
        "isArray": false,
        "isEnum": false,
        "isFlagEnum": false,
        "isImage": false,
        "isLocalizedString": false,
        "isName": false,
        "isRequired": true,
        "propertyId": "id1"
    }]
}
~~~

