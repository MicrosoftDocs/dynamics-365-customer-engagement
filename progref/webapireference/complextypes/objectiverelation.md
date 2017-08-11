---
title: "ObjectiveRelation ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b5272367-1be3-4f53-b975-5384a8bd7c11
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ObjectiveRelation ComplexType
[!INCLUDE[./descriptions/objectiverelation.md](./descriptions/objectiverelation.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ResourceSpecId|Edm.Guid|true|true|The ID of the resource specification. | 
|ObjectiveExpression|Edm.String|true|false|The search strategy to use in the appointment request for the SearchRequest message. | 

## Used by
The following use the ObjectiveRelation ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[AppointmentRequest ComplexType](../complextypes/appointmentrequest.md)|Property|[!INCLUDE[../complextypes/descriptions/appointmentrequest.md](../complextypes/descriptions/appointmentrequest.md)]|

[!INCLUDE[./remarks/objectiverelation.md](./remarks/objectiverelation.md)]

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