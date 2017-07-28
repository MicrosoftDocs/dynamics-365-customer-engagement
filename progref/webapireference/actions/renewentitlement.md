---
title: "RenewEntitlement Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: b4dc54d0-fbda-45b7-be29-a332bcc717a7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RenewEntitlement Action
[!INCLUDE[./descriptions/renewentitlement.md](./descriptions/renewentitlement.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[entitlement Entitytype](../entitytypes/entitlement.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Status|Edm.Int32|false|true|The StatusCode value for the renewed Entitlement |

## Return Type
The RenewEntitlement action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[entitlement EntityType](../entitytypes/entitlement.md)|false|Contains the response from RenewEntitlement Action. |



[!INCLUDE[./remarks/renewentitlement.md](./remarks/renewentitlement.md)]

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