---
title: "AttributePrivilege ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7b3155c9-8fae-42c6-b0b5-0375d3291c63
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AttributePrivilege ComplexType
[!INCLUDE[./descriptions/attributeprivilege.md](./descriptions/attributeprivilege.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AttributeId|Edm.Guid|true|true|The ID of the attribute. | 
|CanCreate|Edm.Int32|true|true|Whether create of the attribute value is allowed. | 
|CanRead|Edm.Int32|true|true|Whether read of the attribute value is allowed. | 
|CanUpdate|Edm.Int32|true|true|Whether update of the attribute value is allowed. | 

## Used by
The following use the AttributePrivilege ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrievePrincipalAttributePrivilegesResponse ComplexType](../complextypes/retrieveprincipalattributeprivilegesresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveprincipalattributeprivilegesresponse.md](../complextypes/descriptions/retrieveprincipalattributeprivilegesresponse.md)]|

[!INCLUDE[./remarks/attributeprivilege.md](./remarks/attributeprivilege.md)]

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