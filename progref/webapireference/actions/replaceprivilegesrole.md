---
title: "ReplacePrivilegesRole Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 8306ba92-b6c0-4fe9-90dd-5ab4b93372e9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ReplacePrivilegesRole Action
[!INCLUDE[./descriptions/replaceprivilegesrole.md](./descriptions/replaceprivilegesrole.md)]

The ReplacePrivilegesRole action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[role Entitytype](../entitytypes/role.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Privileges|Collection([RolePrivilege ComplexType](../complextypes/RolePrivilege.md))||true|An array that contains the IDs and depths of the privileges that replace the existing privileges.|





[!INCLUDE[./remarks/replaceprivilegesrole.md](./remarks/replaceprivilegesrole.md)]

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