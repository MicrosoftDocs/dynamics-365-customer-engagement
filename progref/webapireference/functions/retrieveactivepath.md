---
title: "RetrieveActivePath Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5502e57f-f7f8-4b24-a3eb-b29f1622fe03
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveActivePath Function
[!INCLUDE[./descriptions/retrieveactivepath.md](./descriptions/retrieveactivepath.md)]

The RetrieveActivePath function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ProcessInstanceId|Edm.Guid|false|true|ID of the business process flow instance record to retrieve a collection of stages currently in the active path. |

## Return Type
The RetrieveActivePath function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([processstage EntityType](../entitytypes/processstage.md))|false|Contains the response from the RetrieveActivePath Function.|

## Entities
Use the RetrieveActivePath function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[processstage Entitytype](../entitytypes/processstage.md)|[!INCLUDE[../entitytypes/descriptions/processstage.md](../entitytypes/descriptions/processstage.md)]|

[!INCLUDE[./remarks/retrieveactivepath.md](./remarks/retrieveactivepath.md)]

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