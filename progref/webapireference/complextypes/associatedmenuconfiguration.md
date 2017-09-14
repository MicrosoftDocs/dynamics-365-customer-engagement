---
title: "AssociatedMenuConfiguration ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f177bddc-93eb-4473-b5ef-61af5041568f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AssociatedMenuConfiguration ComplexType
[!INCLUDE[./descriptions/associatedmenuconfiguration.md](./descriptions/associatedmenuconfiguration.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Behavior|[AssociatedMenuBehavior EnumType](../enumtypes/AssociatedMenuBehavior.md)|true|true|The behavior of the associated menu for an entity relationship. | 
|Group|[AssociatedMenuGroup EnumType](../enumtypes/AssociatedMenuGroup.md)|true|true|The structure that contains extra data.| 
|Label|[Label ComplexType](../complextypes/Label.md)|true|true|The labelfor the associated menu.| 
|Order|Edm.Int32|true|true|The order for the associated menu.| 
|IsCustomizable|Edm.Boolean|true|true|TODO: Add description for AssociatedMenuConfiguration.IsCustomizable property.| 
|Icon|Edm.String|true|false|TODO: Add description for AssociatedMenuConfiguration.Icon property.| 
|ViewId|Edm.Guid|true|true|TODO: Add description for AssociatedMenuConfiguration.ViewId property.| 
|AvailableOffline|Edm.Boolean|true|true|TODO: Add description for AssociatedMenuConfiguration.AvailableOffline property.| 
|MenuId|Edm.String|true|false|TODO: Add description for AssociatedMenuConfiguration.MenuId property.| 
|QueryApi|Edm.String|true|false|TODO: Add description for AssociatedMenuConfiguration.QueryApi property.| 

## Used by
The following use the AssociatedMenuConfiguration ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[ManyToManyRelationshipMetadata EntityType](../metadataentitytypes/manytomanyrelationshipmetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/manytomanyrelationshipmetadata.md](../metadataentitytypes/descriptions/manytomanyrelationshipmetadata.md)]|
|[OneToManyRelationshipMetadata EntityType](../metadataentitytypes/onetomanyrelationshipmetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/onetomanyrelationshipmetadata.md](../metadataentitytypes/descriptions/onetomanyrelationshipmetadata.md)]|
|[ComplexManyToManyRelationshipMetadata ComplexType](../complextypes/complexmanytomanyrelationshipmetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexmanytomanyrelationshipmetadata.md](../complextypes/descriptions/complexmanytomanyrelationshipmetadata.md)]|
|[ComplexOneToManyRelationshipMetadata ComplexType](../complextypes/complexonetomanyrelationshipmetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexonetomanyrelationshipmetadata.md](../complextypes/descriptions/complexonetomanyrelationshipmetadata.md)]|

[!INCLUDE[./remarks/associatedmenuconfiguration.md](./remarks/associatedmenuconfiguration.md)]

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