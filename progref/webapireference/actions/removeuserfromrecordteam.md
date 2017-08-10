---
title: "RemoveUserFromRecordTeam Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 7ec60ff1-bc59-478a-8495-a6beb102af32
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RemoveUserFromRecordTeam Action
[!INCLUDE[./descriptions/removeuserfromrecordteam.md](./descriptions/removeuserfromrecordteam.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[systemuser Entitytype](../entitytypes/systemuser.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Record|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The record for which the access team is auto created. |
|TeamTemplate|[teamtemplate EntityType](../entitytypes/teamtemplate.md)|false|true|The team template which is used to create the access team.|

## Return Type
The RemoveUserFromRecordTeam action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RemoveUserFromRecordTeamResponse ComplexType](../complextypes/RemoveUserFromRecordTeamResponse.md)|false|Contains the response from the RemoveUserFromRecordTeam Action. |

## Entities
Use the RemoveUserFromRecordTeam action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[teamtemplate Entitytype](../entitytypes/teamtemplate.md)|[!INCLUDE[../entitytypes/descriptions/teamtemplate.md](../entitytypes/descriptions/teamtemplate.md)]|

[!INCLUDE[./remarks/removeuserfromrecordteam.md](./remarks/removeuserfromrecordteam.md)]

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