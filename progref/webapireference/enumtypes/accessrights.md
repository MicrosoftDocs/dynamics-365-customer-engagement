---
title: "AccessRights EnumType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fa89ce9c-fd73-4504-b938-afac5fc39546
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AccessRights EnumType
[!INCLUDE[./descriptions/accessrights.md](./descriptions/accessrights.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|None|0|No access. | 
|ReadAccess|1|The right to read the specified type of record. | 
|WriteAccess|2|The right to update the specified record. | 
|AppendAccess|4|The right to append the specified record to another object. | 
|AppendToAccess|16|The right to append another record to the specified object. | 
|CreateAccess|32|The right to create a record. | 
|DeleteAccess|65536|The right to delete the specified record. | 
|ShareAccess|262144|The right to share the specified record. | 
|AssignAccess|524288|The right to assign the specified record to another user or team. | 

## Used by
The following use the AccessRights enum type.
|Name|How used|Description|
|---|---|---|
|[RetrievePrincipalAccessResponse ComplexType](../complextypes/retrieveprincipalaccessresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveprincipalaccessresponse.md](../complextypes/descriptions/retrieveprincipalaccessresponse.md)]|
|[PrincipalAccess ComplexType](../complextypes/principalaccess.md)|Property|[!INCLUDE[../complextypes/descriptions/principalaccess.md](../complextypes/descriptions/principalaccess.md)]|

[!INCLUDE[./remarks/accessrights.md](./remarks/accessrights.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)   
 [Web API EntityType Reference](../entitytypereference.md)   
 [Web API Action Reference](../actionreference.md)   
 [Web API Function Reference](../functionreference.md)   
 [Web API Query Function Reference](../queryfunctionreference.md)   
 [Web API EnumType Reference](../enumtypereference.md)   
 [Web API ComplexType Reference](../complextypereference.md)   
 [Web API Metadata EntityType Reference](../entitytypereference.md)   
 [Web API Solutions Reference](../solutionreference.md)