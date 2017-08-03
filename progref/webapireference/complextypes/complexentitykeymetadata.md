---
title: "ComplexEntityKeyMetadata ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2e210427-af82-4d14-909d-5c8fe60f69bf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ComplexEntityKeyMetadata ComplexType
[!INCLUDE[./descriptions/complexentitykeymetadata.md](./descriptions/complexentitykeymetadata.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|DisplayName|[Label ComplexType](../complextypes/Label.md)|true|true|A label containing the display name for the key.| 
|LogicalName|Edm.String|true|false|The entity logical name.| 
|SchemaName|Edm.String|true|false|The schema name.| 
|EntityLogicalName|Edm.String|true|false|The entity logical name.| 
|KeyAttributes|Collection(Edm.String)||false|The key attributes.| 
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the entity key metadata is customizable.| 
|IsManaged|Edm.Boolean|true|true|Whether entity key metadata is managed or not.| 
|IntroducedVersion|Edm.String|true|false|A string identifying the solution version that the solution component was added in.| 
|EntityKeyIndexStatus|[EntityKeyIndexStatus EnumType](../enumtypes/EntityKeyIndexStatus.md)|true|true|The entity key index status.| 
|MetadataId|Edm.Guid|true|true|A unique identifier for the metadata item.| 
|HasChanged|Edm.Boolean|true|true|Indicates whether the item of metadata has changed.| 

## Used by
The following use the ComplexEntityKeyMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[ComplexEntityMetadata ComplexType](../complextypes/complexentitymetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexentitymetadata.md](../complextypes/descriptions/complexentitymetadata.md)]|

[!INCLUDE[./remarks/complexentitykeymetadata.md](./remarks/complexentitykeymetadata.md)]

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