---
title: "AddListMembersList Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 617c59e9-67d4-4e2e-8982-b9e9aa459b0b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AddListMembersList Action
[!INCLUDE[./descriptions/addlistmemberslist.md](./descriptions/addlistmemberslist.md)]

The AddListMembersList action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|List|[list EntityType](../entitytypes/list.md)|false|true|The list to add the members to. |
|Members|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|true|The members to be added to the list. |



## Entities
Use the AddListMembersList action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[list Entitytype](../entitytypes/list.md)|[!INCLUDE[../entitytypes/descriptions/list.md](../entitytypes/descriptions/list.md)]|

[!INCLUDE[./remarks/addlistmemberslist.md](./remarks/addlistmemberslist.md)]

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