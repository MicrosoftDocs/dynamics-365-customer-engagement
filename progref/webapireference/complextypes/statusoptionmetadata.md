---
title: "StatusOptionMetadata ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e3a1ccb3-32d2-451a-b470-2a9ac998d92c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# StatusOptionMetadata ComplexType
[!INCLUDE[./descriptions/statusoptionmetadata.md](./descriptions/statusoptionmetadata.md)]

This Web API complex type inherits from [OptionMetadata ComplexType](../complextypes/OptionMetadata.md).

## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|State|Edm.Int32|true|true| The state that the status is associated with. | 
|TransitionData|Edm.String|true|false|The status transitions allowed for this status | 

## Used by
The following use the StatusOptionMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    


[!INCLUDE[./remarks/statusoptionmetadata.md](./remarks/statusoptionmetadata.md)]

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