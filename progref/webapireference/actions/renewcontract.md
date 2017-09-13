---
title: "RenewContract Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 232285b2-4bb1-4866-8ec5-853451e45063
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RenewContract Action
[!INCLUDE[./descriptions/renewcontract.md](./descriptions/renewcontract.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[contract Entitytype](../entitytypes/contract.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Status|Edm.Int32|false|true|The status of the contract.|
|IncludeCanceledLines|Edm.Boolean|false|true|Indicates whether the canceled line items of the original contract should be included in the renewed contract. |

## Return Type
The RenewContract action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[contract EntityType](../entitytypes/contract.md)|false|Contains the response from the RenewContract Action. |



[!INCLUDE[./remarks/renewcontract.md](./remarks/renewcontract.md)]

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