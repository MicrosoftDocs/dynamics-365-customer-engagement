---
title: "RetrieveRolePrivilegesRole Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d8e7052d-3fec-4b2b-a967-a647f9caf322
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveRolePrivilegesRole Function
[!INCLUDE[./descriptions/retrieveroleprivilegesrole.md](./descriptions/retrieveroleprivilegesrole.md)]

The RetrieveRolePrivilegesRole function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|RoleId|Edm.Guid|false|true|The specified role to retrieve the privileges for.|

## Return Type
The RetrieveRolePrivilegesRole function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RetrieveRolePrivilegesRoleResponse ComplexType](../complextypes/RetrieveRolePrivilegesRoleResponse.md)|false|Contains the results from the RetrieveRolePrivilegesRole function. |

## Entities
Use the RetrieveRolePrivilegesRole function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[role Entitytype](../entitytypes/role.md)|[!INCLUDE[../entitytypes/descriptions/role.md](../entitytypes/descriptions/role.md)]|

[!INCLUDE[./remarks/retrieveroleprivilegesrole.md](./remarks/retrieveroleprivilegesrole.md)]

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