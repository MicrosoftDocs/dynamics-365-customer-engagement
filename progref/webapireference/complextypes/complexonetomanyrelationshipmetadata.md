---
title: "ComplexOneToManyRelationshipMetadata ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 67182399-9e94-473f-af0a-7037a35bebbc
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ComplexOneToManyRelationshipMetadata ComplexType
[!INCLUDE[./descriptions/complexonetomanyrelationshipmetadata.md](./descriptions/complexonetomanyrelationshipmetadata.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AssociatedMenuConfiguration|[AssociatedMenuConfiguration ComplexType](../complextypes/AssociatedMenuConfiguration.md)|true|true|Specifies the associated menu configuration.| 
|CascadeConfiguration|[CascadeConfiguration ComplexType](../complextypes/CascadeConfiguration.md)|true|true|The cascading behaviors for the entity relationship.| 
|ReferencedAttribute|Edm.String|true|false|The name of primary attribute for the referenced entity.| 
|ReferencedEntity|Edm.String|true|false|The name of the referenced entity.| 
|ReferencingAttribute|Edm.String|true|false|The name of the referencing attribute.| 
|ReferencingEntity|Edm.String|true|false|The name of the referencing entity.| 
|IsHierarchical|Edm.Boolean|true|true|Whether this relationship is the designated hierarchical self-referential relationship for this entity.| 
|ReferencedEntityNavigationPropertyName|Edm.String|true|false|The collection-valued navigation property used by this relationship.| 
|ReferencingEntityNavigationPropertyName|Edm.String|true|false|The single-valued navigation property used by this relationship.| 
|IsCustomRelationship|Edm.Boolean|true|true|Whether the relationship is a custom relationship.| 
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the entity relationship is customizable.| 
|IsValidForAdvancedFind|Edm.Boolean|true|true|Whether the entity relationship should be shown in Advanced Find.| 
|SchemaName|Edm.String|true|false|The schema name for the entity relationship.| 
|SecurityTypes|[SecurityTypes EnumType](../enumtypes/SecurityTypes.md)|true|true|The security type for the relationship.| 
|IsManaged|Edm.Boolean|true|true|Whether the entity relationship is part of a managed solution.| 
|RelationshipType|[RelationshipType EnumType](../enumtypes/RelationshipType.md)|true|true|The type of relationship.| 
|IntroducedVersion|Edm.String|true|false|A string identifying the solution version that the solution component was added in.| 
|MetadataId|Edm.Guid|true|true|A unique identifier for the metadata item.| 
|HasChanged|Edm.Boolean|true|true|Whether the item of metadata has changed.| 

## Used by
The following use the ComplexOneToManyRelationshipMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[CreateCustomerRelationships Action](../actions/createcustomerrelationships.md)|Parameter|[!INCLUDE[../actions/descriptions/createcustomerrelationships.md](../actions/descriptions/createcustomerrelationships.md)]|
|[ComplexEntityMetadata ComplexType](../complextypes/complexentitymetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexentitymetadata.md](../complextypes/descriptions/complexentitymetadata.md)]|

[!INCLUDE[./remarks/complexonetomanyrelationshipmetadata.md](./remarks/complexonetomanyrelationshipmetadata.md)]

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