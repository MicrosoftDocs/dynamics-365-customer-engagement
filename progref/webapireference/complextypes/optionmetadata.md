---
title: "OptionMetadata ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b9af4ea3-6e65-4100-8a99-4a3edf92158f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OptionMetadata ComplexType
[!INCLUDE[./descriptions/optionmetadata.md](./descriptions/optionmetadata.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Value|Edm.Int32|true|true|The value of the option. | 
|Label|[Label ComplexType](../complextypes/Label.md)|true|true|The label containing the text for the option. | 
|Description|[Label ComplexType](../complextypes/Label.md)|true|true|The label containing the description for the option. | 
|Color|Edm.String|true|false|The Hex color assigned to the option| 
|IsManaged|Edm.Boolean|true|true|Whether the option is part of a managed solution.| 
|ExternalName|Edm.String|true|false|TODO: Add description for OptionMetadata.ExternalName property.| 
|MetadataId|Edm.Guid|true|true|A unique identifier for the metadata item | 
|HasChanged|Edm.Boolean|true|true|Gets whether the item of metadata has changed. | 

## Used by
The following use the OptionMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[BooleanOptionSetMetadata EntityType](../metadataentitytypes/booleanoptionsetmetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/booleanoptionsetmetadata.md](../metadataentitytypes/descriptions/booleanoptionsetmetadata.md)]|
|[OptionSetMetadata EntityType](../metadataentitytypes/optionsetmetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/optionsetmetadata.md](../metadataentitytypes/descriptions/optionsetmetadata.md)]|

[!INCLUDE[./remarks/optionmetadata.md](./remarks/optionmetadata.md)]

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