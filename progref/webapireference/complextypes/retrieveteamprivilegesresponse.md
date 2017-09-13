---
title: "RetrieveTeamPrivilegesResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a4fc0b72-3bc6-43d8-9383-c8c30c71e814
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveTeamPrivilegesResponse ComplexType
[!INCLUDE[./descriptions/retrieveteamprivilegesresponse.md](./descriptions/retrieveteamprivilegesresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|RolePrivileges|Collection([RolePrivilege ComplexType](../complextypes/RolePrivilege.md))||true|The list of privileges that the team holds for a record.| 

## Used by
The following use the RetrieveTeamPrivilegesResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveTeamPrivileges Function](../functions/retrieveteamprivileges.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrieveteamprivileges.md](../functions/descriptions/retrieveteamprivileges.md)]|

[!INCLUDE[./remarks/retrieveteamprivilegesresponse.md](./remarks/retrieveteamprivilegesresponse.md)]

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