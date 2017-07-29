---
title: "ComplexLookupAttributeMetadata ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: babddd42-65b3-44d8-8a32-45e7c6680e41
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ComplexLookupAttributeMetadata ComplexType
[!INCLUDE[./descriptions/complexlookupattributemetadata.md](./descriptions/complexlookupattributemetadata.md)]

This Web API complex type inherits from [ComplexAttributeMetadata ComplexType](../complextypes/ComplexAttributeMetadata.md).

## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Targets|Collection(Edm.String)||false|The target entity types for the lookup.| 
|Format|[LookupFormat EnumType](../enumtypes/LookupFormat.md)|true|true|TODO: Add description for ComplexLookupAttributeMetadata.Format property.| 

## Used by
The following use the ComplexLookupAttributeMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[CreateCustomerRelationships Action](../actions/createcustomerrelationships.md)|Parameter|[!INCLUDE[../actions/descriptions/createcustomerrelationships.md](../actions/descriptions/createcustomerrelationships.md)]|

[!INCLUDE[./remarks/complexlookupattributemetadata.md](./remarks/complexlookupattributemetadata.md)]

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