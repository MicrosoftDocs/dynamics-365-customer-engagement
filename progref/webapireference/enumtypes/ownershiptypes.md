---
title: "OwnershipTypes EnumType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f1a1e510-4c8c-4d28-a9c4-074bee80000a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OwnershipTypes EnumType
[!INCLUDE[./descriptions/ownershiptypes.md](./descriptions/ownershiptypes.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|None|0|The entity does not have an owner. For internal use only. | 
|UserOwned|1|The entity is owned by a system user. | 
|TeamOwned|2|The entity is owned by a team. For internal use only.| 
|BusinessOwned|4|The entity is owned by a business unit. For internal use only.  | 
|OrganizationOwned|8|The entity is owned by an organization.  | 
|BusinessParented|16|The entity is parented by a business unit. For internal use only.  | 

## Used by
The following use the OwnershipTypes enum type.
|Name|How used|Description|
|---|---|---|
|[EntityMetadata EntityType](../metadataentitytypes/entitymetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/entitymetadata.md](../metadataentitytypes/descriptions/entitymetadata.md)]|
|[ComplexEntityMetadata ComplexType](../complextypes/complexentitymetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexentitymetadata.md](../complextypes/descriptions/complexentitymetadata.md)]|

[!INCLUDE[./remarks/ownershiptypes.md](./remarks/ownershiptypes.md)]

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