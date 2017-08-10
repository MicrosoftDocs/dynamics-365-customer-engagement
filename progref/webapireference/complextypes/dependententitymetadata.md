---
title: "DependentEntityMetadata ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 425ff7b3-6bcf-49ac-b646-e1d527d90b32
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# DependentEntityMetadata ComplexType
[!INCLUDE[./descriptions/dependententitymetadata.md](./descriptions/dependententitymetadata.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|EntityId|Edm.String|true|false|TODO: Add description for DependentEntityMetadata.EntityId property.| 
|LogicalName|Edm.String|true|false|TODO: Add description for DependentEntityMetadata.LogicalName property.| 
|LogicalCollectionName|Edm.String|true|false|TODO: Add description for DependentEntityMetadata.LogicalCollectionName property.| 
|ObjectTypeCode|Edm.Int32|true|true|TODO: Add description for DependentEntityMetadata.ObjectTypeCode property.| 
|DisplayName|Edm.String|true|false|TODO: Add description for DependentEntityMetadata.DisplayName property.| 
|PrimaryNameAttribute|Edm.String|true|false|TODO: Add description for DependentEntityMetadata.PrimaryNameAttribute property.| 
|PrimaryIdAttribute|Edm.String|true|false|TODO: Add description for DependentEntityMetadata.PrimaryIdAttribute property.| 
|Attributes|[DependentAttributeMetadataCollection ComplexType](../complextypes/DependentAttributeMetadataCollection.md)|true|true|TODO: Add description for DependentEntityMetadata.Attributes property.| 
|Relationships|[DependentRelationshipCollection ComplexType](../complextypes/DependentRelationshipCollection.md)|true|true|TODO: Add description for DependentEntityMetadata.Relationships property.| 

## Used by
The following use the DependentEntityMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[DependentEntityMetadataCollection ComplexType](../complextypes/dependententitymetadatacollection.md)|Property|[!INCLUDE[../complextypes/descriptions/dependententitymetadatacollection.md](../complextypes/descriptions/dependententitymetadatacollection.md)]|

[!INCLUDE[./remarks/dependententitymetadata.md](./remarks/dependententitymetadata.md)]

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