---
title: "IsComponentCustomizable Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5547b4f0-a88f-4413-99b5-0e91a90f6248
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# IsComponentCustomizable Function
[!INCLUDE[./descriptions/iscomponentcustomizable.md](./descriptions/iscomponentcustomizable.md)]

The IsComponentCustomizable function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ComponentId|Edm.Guid|false|true|The ID of the solution component. |
|ComponentType|Edm.Int32|false|true|The value that represents the solution component.  |

## Return Type
The IsComponentCustomizable function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[IsComponentCustomizableResponse ComplexType](../complextypes/IsComponentCustomizableResponse.md)|false|Whether a solution component is customizable.|

## Entities
Use the IsComponentCustomizable function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[solutioncomponent Entitytype](../entitytypes/solutioncomponent.md)|[!INCLUDE[../entitytypes/descriptions/solutioncomponent.md](../entitytypes/descriptions/solutioncomponent.md)]|

[!INCLUDE[./remarks/iscomponentcustomizable.md](./remarks/iscomponentcustomizable.md)]

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