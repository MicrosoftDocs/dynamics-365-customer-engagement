---
title: "RolePrivilege ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d9487317-ed6d-4569-8d65-6732db95a86c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RolePrivilege ComplexType
[!INCLUDE[./descriptions/roleprivilege.md](./descriptions/roleprivilege.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Depth|[PrivilegeDepth EnumType](../enumtypes/PrivilegeDepth.md)|true|true|The depth of the privilege. | 
|PrivilegeId|Edm.Guid|true|true|The ID of the privilege. | 
|BusinessUnitId|Edm.Guid|true|true| The ID of the business unit.| 

## Used by
The following use the RolePrivilege ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[AddPrivilegesRole Action](../actions/addprivilegesrole.md)|Parameter|[!INCLUDE[../actions/descriptions/addprivilegesrole.md](../actions/descriptions/addprivilegesrole.md)]|
|[ReplacePrivilegesRole Action](../actions/replaceprivilegesrole.md)|Parameter|[!INCLUDE[../actions/descriptions/replaceprivilegesrole.md](../actions/descriptions/replaceprivilegesrole.md)]|
|[RetrieveRolePrivilegesRoleResponse ComplexType](../complextypes/retrieveroleprivilegesroleresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveroleprivilegesroleresponse.md](../complextypes/descriptions/retrieveroleprivilegesroleresponse.md)]|
|[RetrieveTeamPrivilegesResponse ComplexType](../complextypes/retrieveteamprivilegesresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveteamprivilegesresponse.md](../complextypes/descriptions/retrieveteamprivilegesresponse.md)]|
|[RetrieveUserPrivilegesResponse ComplexType](../complextypes/retrieveuserprivilegesresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveuserprivilegesresponse.md](../complextypes/descriptions/retrieveuserprivilegesresponse.md)]|

[!INCLUDE[./remarks/roleprivilege.md](./remarks/roleprivilege.md)]

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