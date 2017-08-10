---
title: "ManyToManyRelationshipMetadata EntityType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b30b1bce-8103-4cee-b6fc-e0ce19b02a5f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ManyToManyRelationshipMetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/manytomanyrelationshipmetadata.md](./descriptions/manytomanyrelationshipmetadata.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[RelationshipMetadataBase EntityType](relationshipmetadatabase.md)</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
</table>
 
 The ManyToManyRelationshipMetadata EntityType:
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|Entity1AssociatedMenuConfiguration|[AssociatedMenuConfiguration ComplexType](../complextypes/AssociatedMenuConfiguration.md)|The associated menu configuration for the first entity.|
|Entity1IntersectAttribute|Edm.String|The attribute that defines the relationship in the first entity.|
|Entity1LogicalName|Edm.String|The logical name of the first entity in the relationship.|
|Entity1NavigationPropertyName|Edm.String|TODO: Add description for Entity1NavigationPropertyName|
|Entity2AssociatedMenuConfiguration|[AssociatedMenuConfiguration ComplexType](../complextypes/AssociatedMenuConfiguration.md)|The associated menu configuration for the second entity.|
|Entity2IntersectAttribute|Edm.String|The attribute that defines the relationship in the second entity.|
|Entity2LogicalName|Edm.String|The logical name of the second entity in the relationship.|
|Entity2NavigationPropertyName|Edm.String|TODO: Add description for Entity2NavigationPropertyName|
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|IntersectEntityName|Edm.String|The name of the intersect entity for the relationship.|
|IntroducedVersion|Edm.String|A string identifying the solution version that the solution component was added in.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity relationship is customizable.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsCustomRelationship|Edm.Boolean|Whether the relationship is a custom relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsManaged|Edm.Boolean|Whether the entity relationship is part of a managed solution.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsValidForAdvancedFind|Edm.Boolean|Whether the entity relationship should be shown in Advanced Find.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|RelationshipType|[RelationshipType EnumType](../enumtypes/RelationshipType.md)|The type of relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|SchemaName|Edm.String|The schema name for the entity relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|SecurityTypes|[SecurityTypes EnumType](../enumtypes/SecurityTypes.md)|The security type for the relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|

## Used by
The following operations use the ManyToManyRelationshipMetadata entity type.


|Name|How used |Description |  
|----|---------|------------|  
|[EntityMetadata EntityType](../metadataentitytypes/entitymetadata.md)|NavigationProperty|[!INCLUDE[../metadataentitytypes/descriptions/entitymetadata.md](../metadataentitytypes/descriptions/entitymetadata.md)]|

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