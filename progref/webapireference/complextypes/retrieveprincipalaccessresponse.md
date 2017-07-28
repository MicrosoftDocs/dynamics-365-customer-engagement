---
title: "RetrievePrincipalAccessResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2071a2cf-17e0-4929-966a-07e9a07c7c01
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrievePrincipalAccessResponse ComplexType
[!INCLUDE[./descriptions/retrieveprincipalaccessresponse.md](./descriptions/retrieveprincipalaccessresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AccessRights|[AccessRights EnumType](../enumtypes/AccessRights.md)|true|true|The access rights that the security principal (team or user) has to the specified record. | 

## Used by
The following use the RetrievePrincipalAccessResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|

[!INCLUDE[./remarks/retrieveprincipalaccessresponse.md](./remarks/retrieveprincipalaccessresponse.md)]

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