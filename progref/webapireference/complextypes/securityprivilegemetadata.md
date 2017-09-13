---
title: "SecurityPrivilegeMetadata ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 68b0cc49-55fa-446d-8648-0c3625c340f7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SecurityPrivilegeMetadata ComplexType
[!INCLUDE[./descriptions/securityprivilegemetadata.md](./descriptions/securityprivilegemetadata.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|CanBeBasic|Edm.Boolean|true|true|Whether the privilege can be basic access level.| 
|CanBeDeep|Edm.Boolean|true|true|Whether the privilege can be deep access level.| 
|CanBeGlobal|Edm.Boolean|true|true|Whether the privilege can be global access level.| 
|CanBeLocal|Edm.Boolean|true|true|Whether the privilege can be local access level.| 
|CanBeEntityReference|Edm.Boolean|true|true|Whether the privilege for an external party can be basic access level.| 
|CanBeParentEntityReference|Edm.Boolean|true|true|Whether the privilege for an external party can be parent access level.| 
|Name|Edm.String|true|false|The name of the privilege.| 
|PrivilegeId|Edm.Guid|true|true|The ID of the privilege.| 
|PrivilegeType|[PrivilegeType EnumType](../enumtypes/PrivilegeType.md)|true|true|The type of the privilege.| 

## Used by
The following use the SecurityPrivilegeMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[EntityMetadata EntityType](../metadataentitytypes/entitymetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/entitymetadata.md](../metadataentitytypes/descriptions/entitymetadata.md)]|
|[ComplexEntityMetadata ComplexType](../complextypes/complexentitymetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexentitymetadata.md](../complextypes/descriptions/complexentitymetadata.md)]|

[!INCLUDE[./remarks/securityprivilegemetadata.md](./remarks/securityprivilegemetadata.md)]

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