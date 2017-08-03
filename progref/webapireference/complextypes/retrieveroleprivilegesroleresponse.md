---
title: "RetrieveRolePrivilegesRoleResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 24de3b79-1069-447f-8043-54dc45a15c81
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveRolePrivilegesRoleResponse ComplexType
[!INCLUDE[./descriptions/retrieveroleprivilegesroleresponse.md](./descriptions/retrieveroleprivilegesroleresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|RolePrivileges|Collection([RolePrivilege ComplexType](../complextypes/RolePrivilege.md))||true|An array of the IDs and depths of the privileges that are held by the specified role.| 

## Used by
The following use the RetrieveRolePrivilegesRoleResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveRolePrivilegesRole Function](../functions/retrieveroleprivilegesrole.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrieveroleprivilegesrole.md](../functions/descriptions/retrieveroleprivilegesrole.md)]|

[!INCLUDE[./remarks/retrieveroleprivilegesroleresponse.md](./remarks/retrieveroleprivilegesroleresponse.md)]

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