---
title: "CreateInstance Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: eb552a6c-5174-4f70-ac68-87c7b9591aa4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CreateInstance Action
[!INCLUDE[./descriptions/createinstance.md](./descriptions/createinstance.md)]

The CreateInstance action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The target appointment instance to create. |
|Count|Edm.Int32|false|true|The number of instances to be created. |

## Return Type
The CreateInstance action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[CreateInstanceResponse ComplexType](../complextypes/CreateInstanceResponse.md)|false|Contains the response from the CreateInstance action.|

## Entities
Use the CreateInstance action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[recurringappointmentmaster Entitytype](../entitytypes/recurringappointmentmaster.md)|[!INCLUDE[../entitytypes/descriptions/recurringappointmentmaster.md](../entitytypes/descriptions/recurringappointmentmaster.md)]|

[!INCLUDE[./remarks/createinstance.md](./remarks/createinstance.md)]

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