---
title: "RetrievePrincipalAttributePrivilegesResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b15a6426-348f-4029-97cb-f1840487f44c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrievePrincipalAttributePrivilegesResponse ComplexType
[!INCLUDE[./descriptions/retrieveprincipalattributeprivilegesresponse.md](./descriptions/retrieveprincipalattributeprivilegesresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AttributePrivileges|Collection([AttributePrivilege ComplexType](../complextypes/AttributePrivilege.md))||true|The collection of attribute privileges for the security principal (user or team). | 

## Used by
The following use the RetrievePrincipalAttributePrivilegesResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrievePrincipalAttributePrivileges Function](../functions/retrieveprincipalattributeprivileges.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrieveprincipalattributeprivileges.md](../functions/descriptions/retrieveprincipalattributeprivileges.md)]|

[!INCLUDE[./remarks/retrieveprincipalattributeprivilegesresponse.md](./remarks/retrieveprincipalattributeprivilegesresponse.md)]

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