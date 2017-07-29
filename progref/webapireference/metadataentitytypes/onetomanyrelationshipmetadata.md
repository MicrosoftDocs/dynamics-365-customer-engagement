---
title: "OneToManyRelationshipMetadata EntityType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2211e593-a0b6-471d-94d4-36da512903b6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OneToManyRelationshipMetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/onetomanyrelationshipmetadata.md](./descriptions/onetomanyrelationshipmetadata.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[RelationshipMetadataBase EntityType](relationshipmetadatabase.md)</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
</table>
 
 The OneToManyRelationshipMetadata entitytype has no collection-valued navigation properties.

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|AssociatedMenuConfiguration|[AssociatedMenuConfiguration ComplexType](../complextypes/AssociatedMenuConfiguration.md)|The associated menu configuration.|
|CascadeConfiguration|[CascadeConfiguration ComplexType](../complextypes/CascadeConfiguration.md)|The cascading behaviors for the entity relationship.|
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|IntroducedVersion|Edm.String|A string identifying the solution version that the solution component was added in.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity relationship is customizable.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsCustomRelationship|Edm.Boolean|Whether the relationship is a custom relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsHierarchical|Edm.Boolean|Whether this relationship is the designated hierarchical self-referential relationship for this entity.|
|IsManaged|Edm.Boolean|Whether the entity relationship is part of a managed solution.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|IsValidForAdvancedFind|Edm.Boolean|Whether the entity relationship should be shown in Advanced Find.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|ReferencedAttribute|Edm.String|The name of primary attribute for the referenced entity.|
|ReferencedEntity|Edm.String|The name of the referenced entity.|
|ReferencedEntityNavigationPropertyName|Edm.String|The collection-valued navigation property used by this relationship.|
|ReferencingAttribute|Edm.String|The name of the referencing attribute.|
|ReferencingEntity|Edm.String|The name of the referencing entity.|
|ReferencingEntityNavigationPropertyName|Edm.String|The single-valued navigation property used by this relationship.|
|RelationshipType|[RelationshipType EnumType](../enumtypes/RelationshipType.md)|The type of relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|SchemaName|Edm.String|The schema name for the entity relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|
|SecurityTypes|[SecurityTypes EnumType](../enumtypes/SecurityTypes.md)|The security type for the relationship.<br />Inherited from [RelationshipMetadataBase EntityType](relationshipmetadatabase.md).|

## Single-valued navigation properties
These properties refer to data stored in a different entity.


|Name|Type|  
|----|----|  
|Lookup|[LookupAttributeMetadata EntityType](lookupattributemetadata.md)|

## Used by
The following operations use the OneToManyRelationshipMetadata entity type.


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