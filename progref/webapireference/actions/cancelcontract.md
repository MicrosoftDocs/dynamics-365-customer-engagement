---
title: "CancelContract Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 558f0df0-4ba0-4e10-b466-b153377284d8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CancelContract Action
[!INCLUDE[./descriptions/cancelcontract.md](./descriptions/cancelcontract.md)]

The CancelContract action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[contract Entitytype](../entitytypes/contract.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|CancelDate|Edm.DateTimeOffset|false|true|The date the contract was cancelled. |
|Status|Edm.Int32|false|true|Status of the contract.|



## Entities
Use the CancelContract action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[salesorder Entitytype](../entitytypes/salesorder.md)|[!INCLUDE[../entitytypes/descriptions/salesorder.md](../entitytypes/descriptions/salesorder.md)]|

[!INCLUDE[./remarks/cancelcontract.md](./remarks/cancelcontract.md)]

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