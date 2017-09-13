---
title: "InsertOptionValue Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 62aa8236-cf75-445e-80c3-2035d693d420
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# InsertOptionValue Action
[!INCLUDE[./descriptions/insertoptionvalue.md](./descriptions/insertoptionvalue.md)]

The InsertOptionValue action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OptionSetName|Edm.String|true|false|Reserved for future use.|
|AttributeLogicalName|Edm.String|true|false|The logical name of the status attribute.  |
|EntityLogicalName|Edm.String|true|false|Logical name of the entity. |
|Value|Edm.Int32|true|true|Value for the new status.|
|Label|[Label ComplexType](../complextypes/Label.md)|true|true|Label for the new status. |
|Description|[Label ComplexType](../complextypes/Label.md)|true|true|Description for the option. |
|ParentValues|Collection(Edm.Int32)||true|TODO: Add description for InsertOptionValue ParentValues parameter.|
|SolutionUniqueName|Edm.String|true|false|Unique name of the solution. |

## Return Type
The InsertOptionValue action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[InsertOptionValueResponse ComplexType](../complextypes/InsertOptionValueResponse.md)|false|Contains the response from InsertOptionValue Action.|



[!INCLUDE[./remarks/insertoptionvalue.md](./remarks/insertoptionvalue.md)]

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