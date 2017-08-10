---
title: "AttributeRequiredLevelManagedProperty ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6ad3a123-511e-4c4e-bad4-8a5cc0007f12
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AttributeRequiredLevelManagedProperty ComplexType
[!INCLUDE[./descriptions/attributerequiredlevelmanagedproperty.md](./descriptions/attributerequiredlevelmanagedproperty.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Value|[AttributeRequiredLevel EnumType](../enumtypes/AttributeRequiredLevel.md)|true|true|The value of the managed property.  | 
|CanBeChanged|Edm.Boolean|true|true|Whether the managed property value can be changed. | 
|ManagedPropertyLogicalName|Edm.String|true|false| Logical name for the managed property. | 

## Used by
The following use the AttributeRequiredLevelManagedProperty ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[AttributeMetadata EntityType](../metadataentitytypes/attributemetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/attributemetadata.md](../metadataentitytypes/descriptions/attributemetadata.md)]|
|[ComplexAttributeMetadata ComplexType](../complextypes/complexattributemetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexattributemetadata.md](../complextypes/descriptions/complexattributemetadata.md)]|

[!INCLUDE[./remarks/attributerequiredlevelmanagedproperty.md](./remarks/attributerequiredlevelmanagedproperty.md)]

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