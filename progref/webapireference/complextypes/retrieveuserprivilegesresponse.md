---
title: "RetrieveUserPrivilegesResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f5a2115a-b34b-48b3-9beb-c0c24685314d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveUserPrivilegesResponse ComplexType
[!INCLUDE[./descriptions/retrieveuserprivilegesresponse.md](./descriptions/retrieveuserprivilegesresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|RolePrivileges|Collection([RolePrivilege ComplexType](../complextypes/RolePrivilege.md))||true|An array of privileges that the user holds. | 

## Used by
The following use the RetrieveUserPrivilegesResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveUserPrivileges Function](../functions/retrieveuserprivileges.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrieveuserprivileges.md](../functions/descriptions/retrieveuserprivileges.md)]|

[!INCLUDE[./remarks/retrieveuserprivilegesresponse.md](./remarks/retrieveuserprivilegesresponse.md)]

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