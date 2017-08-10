---
title: "AddUserToRecordTeam Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: c99d5329-481e-466a-99c5-116df1c7ee4a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AddUserToRecordTeam Action
[!INCLUDE[./descriptions/addusertorecordteam.md](./descriptions/addusertorecordteam.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[systemuser Entitytype](../entitytypes/systemuser.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Record|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|Record for which the access team is auto created. |
|TeamTemplate|[teamtemplate EntityType](../entitytypes/teamtemplate.md)|false|true|Team template that is used to create the access team.|

## Return Type
The AddUserToRecordTeam action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[AddUserToRecordTeamResponse ComplexType](../complextypes/AddUserToRecordTeamResponse.md)|false|Contains the response from AddUserToRecordTeam action. |

## Entities
Use the AddUserToRecordTeam action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[teamtemplate Entitytype](../entitytypes/teamtemplate.md)|[!INCLUDE[../entitytypes/descriptions/teamtemplate.md](../entitytypes/descriptions/teamtemplate.md)]|

[!INCLUDE[./remarks/addusertorecordteam.md](./remarks/addusertorecordteam.md)]

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