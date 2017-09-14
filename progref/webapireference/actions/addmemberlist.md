---
title: "AddMemberList Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 2f72c4a8-7f7d-40a4-89b4-5c6fbd758733
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AddMemberList Action
[!INCLUDE[./descriptions/addmemberlist.md](./descriptions/addmemberlist.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[list Entitytype](../entitytypes/list.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityId|Edm.Guid|false|true|ID of the entity to be added to the list. |

## Return Type
The AddMemberList action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[AddMemberListResponse ComplexType](../complextypes/AddMemberListResponse.md)|false|Contains the response from AddMemberList action. |



[!INCLUDE[./remarks/addmemberlist.md](./remarks/addmemberlist.md)]

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