---
title: "InsertStatusValue Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: a20460ab-6e8e-44f9-84bf-f625139d543c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# InsertStatusValue Action
[!INCLUDE[./descriptions/insertstatusvalue.md](./descriptions/insertstatusvalue.md)]

The InsertStatusValue action is not bound to any entity types.



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
|StateCode|Edm.Int32|false|true|State code for the new status.|
|SolutionUniqueName|Edm.String|true|false|Unique name of the solution. |

## Return Type
The InsertStatusValue action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[InsertStatusValueResponse ComplexType](../complextypes/InsertStatusValueResponse.md)|false|Contains the InsertStatusValue Action.|



[!INCLUDE[./remarks/insertstatusvalue.md](./remarks/insertstatusvalue.md)]

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