---
title: "PrincipalAccess ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9f83724f-396d-4d41-80a7-2057ab0b4ebf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# PrincipalAccess ComplexType
[!INCLUDE[./descriptions/principalaccess.md](./descriptions/principalaccess.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AccessMask|[AccessRights EnumType](../enumtypes/AccessRights.md)|true|true|TODO: Add description for PrincipalAccess.AccessMask property.| 

## Navigation Properties
The navigation properties of a complex type contain references to an entity type or a collection of entity types.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Principal|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|TODO: Add description for PrincipalAccess.Principal navigation property.| 

## Used by
The following use the PrincipalAccess ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[GrantAccess Action](../actions/grantaccess.md)|Parameter|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|
|[ModifyAccess Action](../actions/modifyaccess.md)|Parameter|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|
|[RetrieveSharedPrincipalsAndAccessResponse ComplexType](../complextypes/retrievesharedprincipalsandaccessresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrievesharedprincipalsandaccessresponse.md](../complextypes/descriptions/retrievesharedprincipalsandaccessresponse.md)]|

[!INCLUDE[./remarks/principalaccess.md](./remarks/principalaccess.md)]

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