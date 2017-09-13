---
title: "MissingComponent ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 113a431c-0b04-47cd-8b40-104cb50ef4a4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# MissingComponent ComplexType
[!INCLUDE[./descriptions/missingcomponent.md](./descriptions/missingcomponent.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|RequiredComponent|[ComponentDetail ComplexType](../complextypes/ComponentDetail.md)|true|true|Information about the required solution component that is missing. | 
|DependentComponent|[ComponentDetail ComplexType](../complextypes/ComponentDetail.md)|true|true|Information about the solution component in the solution file that is dependent on a missing solution component| 

## Used by
The following use the MissingComponent ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveMissingComponentsResponse ComplexType](../complextypes/retrievemissingcomponentsresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrievemissingcomponentsresponse.md](../complextypes/descriptions/retrievemissingcomponentsresponse.md)]|

[!INCLUDE[./remarks/missingcomponent.md](./remarks/missingcomponent.md)]

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