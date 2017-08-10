---
title: "Merge Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 6acc5dd1-0570-4550-82be-db15d6992068
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Merge Action
[!INCLUDE[./descriptions/merge.md](./descriptions/merge.md)]

The Merge action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The target of the merge operation. |
|Subordinate|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The entity record from which to merge data.  |
|UpdateContent|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|Additional entity attributes to be set during the merge operation.|
|PerformParentingChecks|Edm.Boolean|false|true|Indicates whether to check if the parent information is different for the two entity records. |



## Entities
Use the Merge action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[account Entitytype](../entitytypes/account.md)|[!INCLUDE[../entitytypes/descriptions/account.md](../entitytypes/descriptions/account.md)]|
|[contact Entitytype](../entitytypes/contact.md)|[!INCLUDE[../entitytypes/descriptions/contact.md](../entitytypes/descriptions/contact.md)]|
|[incident Entitytype](../entitytypes/incident.md)|[!INCLUDE[../entitytypes/descriptions/incident.md](../entitytypes/descriptions/incident.md)]|
|[lead Entitytype](../entitytypes/lead.md)|[!INCLUDE[../entitytypes/descriptions/lead.md](../entitytypes/descriptions/lead.md)]|

[!INCLUDE[./remarks/merge.md](./remarks/merge.md)]

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