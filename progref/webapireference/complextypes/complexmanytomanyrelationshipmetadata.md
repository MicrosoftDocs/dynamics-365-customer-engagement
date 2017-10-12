---
title: "ComplexManyToManyRelationshipMetadata ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6a99d02b-32bd-441f-9b71-c43be47dda81
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ComplexManyToManyRelationshipMetadata ComplexType
[!INCLUDE[./descriptions/complexmanytomanyrelationshipmetadata.md](./descriptions/complexmanytomanyrelationshipmetadata.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Entity1AssociatedMenuConfiguration|[AssociatedMenuConfiguration ComplexType](../complextypes/AssociatedMenuConfiguration.md)|true|true|The associated menu configuration for the first entity.| 
|Entity2AssociatedMenuConfiguration|[AssociatedMenuConfiguration ComplexType](../complextypes/AssociatedMenuConfiguration.md)|true|true|The associated menu configuration for the second entity.| 
|Entity1LogicalName|Edm.String|true|false|The logical name of the first entity in the relationship.| 
|Entity2LogicalName|Edm.String|true|false|The logical name of the second entity in the relationship.| 
|IntersectEntityName|Edm.String|true|false|The name of the intersect entity for the relationship.| 
|Entity1IntersectAttribute|Edm.String|true|false|The attribute that defines the relationship in the first entity.| 
|Entity2IntersectAttribute|Edm.String|true|false|The attribute that defines the relationship in the second entity.| 
|Entity1NavigationPropertyName|Edm.String|true|false|The navigation property name for the first entity.| 
|Entity2NavigationPropertyName|Edm.String|true|false|The navigation property name for the second entity.| 
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
The following use the ComplexManyToManyRelationshipMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[ComplexEntityMetadata ComplexType](../complextypes/complexentitymetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexentitymetadata.md](../complextypes/descriptions/complexentitymetadata.md)]|

[!INCLUDE[./remarks/complexmanytomanyrelationshipmetadata.md](./remarks/complexmanytomanyrelationshipmetadata.md)]

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