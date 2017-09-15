---
title: Field Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: The Field type defines custom properties in other types, thereby providing extensibility.
keywords: Customer Insights; type; field
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/06/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: adfd4b33-068f-4c68-b516-dae92e291908
---

Field Type Definition
=======================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

The Field type is used to define custom properties in other types, thereby providing some data extensibility. For example, it is used for this purpose in the [Profile](./profile.md) 
and [Interaction](./interaction.md) types. 

>[!NOTE]
>By the public release, the `Field` entity type may be renamed to `Property`.

## Properties

Property names appended with asterisks* are required.

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|fieldName*|string|Name of the custom property|
|fieldType*|string|Type of the property: [edm.boolean \| edm.datetimeoffset \| edm.decimal \| edm.guid \| edm.int16 \| edm.int32 \| edm.int64 \| edm.string]|
|isArray|boolean|True if the property is an array; otherwise represents a single instance|
|isEnum|boolean|True if the property is an enumeration|
|isFlagEnum|boolean|*Reserved for future use* - Specifies if the property is a flag enumeration|
|isImage|boolean|Specifies whether the property is an image. In case of images, the other Image property values will have the relative paths of the image. Actual Images should uploaded using Image Management APIs.|
|isLocalizedString|boolean|True if the property represents a localized string; otherwise false.|
|isName|boolean|True if the property is an entire or partial name; otherwise false.|
|isRequired|boolean|True if the value for the field is required when type instances are ingested; otherwise false.|
|propertyId|string|Identifier associated with the property|
|schemaItemPropLink|string|URL encoded schema.org item link for the property|
|maxLength|integer|If fieldType is string, specifies the maximum allowed length|
|isAvailableInGraph|boolean|True if property is available in graph; otherwise false.|
| | | |

