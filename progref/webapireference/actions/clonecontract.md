---
title: "CloneContract Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: b602ab4d-e486-463e-a34e-d962d6860ec1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CloneContract Action
[!INCLUDE[./descriptions/clonecontract.md](./descriptions/clonecontract.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[contract Entitytype](../entitytypes/contract.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|IncludeCanceledLines|Edm.Boolean|false|true|Indicates whether the canceled line items of the originating contract are to be included in the copy.  |

## Return Type
The CloneContract action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[contract EntityType](../entitytypes/contract.md)|false|Contains the response from CloneContract action. |



[!INCLUDE[./remarks/clonecontract.md](./remarks/clonecontract.md)]

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