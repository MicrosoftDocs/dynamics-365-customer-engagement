---
title: "ComponentDetail ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a0b95edb-e616-4bb6-82d0-c363fe29193a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ComponentDetail ComplexType
[!INCLUDE[./descriptions/componentdetail.md](./descriptions/componentdetail.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Type|Edm.Int32|true|true|The component type of the solution component.| 
|SchemaName|Edm.String|true|false|The schema name of the solution component. | 
|DisplayName|Edm.String|true|false|The display name of the solution component. | 
|Id|Edm.Guid|true|true|The ID of the solution component| 
|ParentSchemaName|Edm.String|true|false|The schema name of the parent solution component. | 
|ParentDisplayName|Edm.String|true|false|The display name of the parent solution component. | 
|ParentId|Edm.Guid|true|true|The ID of the parent solution component. | 
|Solution|Edm.String|true|false|The name of the solution. | 

## Used by
The following use the ComponentDetail ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[MissingComponent ComplexType](../complextypes/missingcomponent.md)|Property|[!INCLUDE[../complextypes/descriptions/missingcomponent.md](../complextypes/descriptions/missingcomponent.md)]|

[!INCLUDE[./remarks/componentdetail.md](./remarks/componentdetail.md)]

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