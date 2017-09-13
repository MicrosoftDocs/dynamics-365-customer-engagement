---
title: "RelationshipMetadataBase EntityType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e88dd69e-8f74-4346-85b5-ed8c26511de3
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RelationshipMetadataBase EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/relationshipmetadatabase.md](./descriptions/relationshipmetadatabase.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[MetadataBase EntityType](metadatabase.md)</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]RelationshipDefinitions</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET,PUT,DELETE</td></tr>
</table>
 
 The RelationshipMetadataBase EntityType:
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.
* Is not explicitly used by any operations but may be referenced using [MetadataBase EntityType](metadatabase.md).

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|IntroducedVersion|Edm.String|A string identifying the solution version that the solution component was added in.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity relationship is customizable.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsCustomRelationship|Edm.Boolean|Whether the relationship is a custom relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsManaged|Edm.Boolean|Whether the entity relationship is part of a managed solution.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsValidForAdvancedFind|Edm.Boolean|Whether the entity relationship should be shown in Advanced Find.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|RelationshipType|[RelationshipType EnumType](../enumtypes/RelationshipType.md)|The type of relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|SchemaName|Edm.String|The schema name for the entity relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|SecurityTypes|[SecurityTypes EnumType](../enumtypes/SecurityTypes.md)|The security type for the relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|

## Derived Types
The following entity types inherit from the RelationshipMetadataBase entity type.


|Name|Description| 
|----|----|  
|[ManyToManyRelationshipMetadata](manytomanyrelationshipmetadata.md)|[!INCLUDE[./descriptions/manytomanyrelationshipmetadata.md](./descriptions/manytomanyrelationshipmetadata.md)]|
|[OneToManyRelationshipMetadata](onetomanyrelationshipmetadata.md)|[!INCLUDE[./descriptions/onetomanyrelationshipmetadata.md](./descriptions/onetomanyrelationshipmetadata.md)]|

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />