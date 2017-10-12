---
title: "CopySystemForm Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: e68e815f-3129-4844-84f5-f4f116adaf4c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CopySystemForm Action
[!INCLUDE[./descriptions/copysystemform.md](./descriptions/copysystemform.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[systemform Entitytype](../entitytypes/systemform.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[systemform EntityType](../entitytypes/systemform.md)|true|true|The SystemForm that the original system form should be copied to. |

## Return Type
The CopySystemForm action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[systemform EntityType](../entitytypes/systemform.md)|false|Contains the response from CopySystemForm action.|



[!INCLUDE[./remarks/copysystemform.md](./remarks/copysystemform.md)]

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