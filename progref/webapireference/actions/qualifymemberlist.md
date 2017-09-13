---
title: "QualifyMemberList Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 59f8dc49-77d5-4a23-ae6a-183099173a63
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# QualifyMemberList Action
[!INCLUDE[./descriptions/qualifymemberlist.md](./descriptions/qualifymemberlist.md)]

The QualifyMemberList action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[list Entitytype](../entitytypes/list.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ListMember|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|true|List members to override or remove.|
|OverrideorRemove|Edm.Boolean|false|true|Indicates whether to override or remove the members from the list. |





[!INCLUDE[./remarks/qualifymemberlist.md](./remarks/qualifymemberlist.md)]

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