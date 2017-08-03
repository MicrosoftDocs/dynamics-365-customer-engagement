---
title: "DependentAttributeMetadata ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5d53a1d7-1a74-4e15-9c75-6d2e04db914a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# DependentAttributeMetadata ComplexType
[!INCLUDE[./descriptions/dependentattributemetadata.md](./descriptions/dependentattributemetadata.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AttributeId|Edm.String|true|false|TODO: Add description for DependentAttributeMetadata.AttributeId property.| 
|LogicalName|Edm.String|true|false|TODO: Add description for DependentAttributeMetadata.LogicalName property.| 
|DisplayName|Edm.String|true|false|TODO: Add description for DependentAttributeMetadata.DisplayName property.| 
|AttributeType|Edm.String|true|false|TODO: Add description for DependentAttributeMetadata.AttributeType property.| 
|AttributeFormatType|Edm.String|true|false|TODO: Add description for DependentAttributeMetadata.AttributeFormatType property.| 
|EntityName|Edm.String|true|false|TODO: Add description for DependentAttributeMetadata.EntityName property.| 
|IsCustomAttribute|Edm.Boolean|true|true|TODO: Add description for DependentAttributeMetadata.IsCustomAttribute property.| 
|IsValidForAdvancedFind|Edm.Boolean|true|true|TODO: Add description for DependentAttributeMetadata.IsValidForAdvancedFind property.| 
|IsValidForGrid|Edm.Boolean|true|true|TODO: Add description for DependentAttributeMetadata.IsValidForGrid property.| 
|YomiOf|Edm.String|true|false|TODO: Add description for DependentAttributeMetadata.YomiOf property.| 
|AttributeOf|Edm.String|true|false|TODO: Add description for DependentAttributeMetadata.AttributeOf property.| 
|OptionSet|[DependentOptionSetMetadata ComplexType](../complextypes/DependentOptionSetMetadata.md)|true|true|TODO: Add description for DependentAttributeMetadata.OptionSet property.| 
|Targets|Collection(Edm.String)||false|TODO: Add description for DependentAttributeMetadata.Targets property.| 

## Used by
The following use the DependentAttributeMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[DependentAttributeMetadataCollection ComplexType](../complextypes/dependentattributemetadatacollection.md)|Property|[!INCLUDE[../complextypes/descriptions/dependentattributemetadatacollection.md](../complextypes/descriptions/dependentattributemetadatacollection.md)]|

[!INCLUDE[./remarks/dependentattributemetadata.md](./remarks/dependentattributemetadata.md)]

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