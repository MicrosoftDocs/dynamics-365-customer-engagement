---
title: "ConstraintRelation ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 93899a15-7f43-48cb-ad09-5d276992011e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ConstraintRelation ComplexType
[!INCLUDE[./descriptions/constraintrelation.md](./descriptions/constraintrelation.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ObjectId|Edm.Guid|true|true|The ID of the calendar rule to which the constraint is applied. | 
|ConstraintType|Edm.String|true|false|The type of constraints. | 
|Constraints|Edm.String|true|false|The set of additional constraints. | 

## Used by
The following use the ConstraintRelation ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[AppointmentRequest ComplexType](../complextypes/appointmentrequest.md)|Property|[!INCLUDE[../complextypes/descriptions/appointmentrequest.md](../complextypes/descriptions/appointmentrequest.md)]|

[!INCLUDE[./remarks/constraintrelation.md](./remarks/constraintrelation.md)]

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