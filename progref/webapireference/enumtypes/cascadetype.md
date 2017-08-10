---
title: "CascadeType EnumType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 642d8106-e117-44c7-ac88-d8103e2122a3
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CascadeType EnumType
[!INCLUDE[./descriptions/cascadetype.md](./descriptions/cascadetype.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|NoCascade|0|Do nothing. | 
|Cascade|1|Perform the action on all referencing entity records associated with the referenced entity record. | 
|Active|2|Perform the action on all active referencing entity records associated with the referenced entity record. | 
|UserOwned|3|Perform the action on all referencing entity records owned by the same user as the referenced entity record. | 
|RemoveLink|4|Remove the value of the referencing attribute for all referencing entity records associated with the referenced entity record. | 
|Restrict|5|Prevent the Referenced entity record from being deleted when referencing entities exist. | 

## Used by
The following use the CascadeType enum type.
|Name|How used|Description|
|---|---|---|
|[CascadeConfiguration ComplexType](../complextypes/cascadeconfiguration.md)|Property|[!INCLUDE[../complextypes/descriptions/cascadeconfiguration.md](../complextypes/descriptions/cascadeconfiguration.md)]|

[!INCLUDE[./remarks/cascadetype.md](./remarks/cascadetype.md)]

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