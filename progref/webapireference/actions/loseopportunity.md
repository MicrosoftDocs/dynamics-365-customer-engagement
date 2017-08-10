---
title: "LoseOpportunity Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 5a5c4943-8472-4f39-a511-a718b66bc511
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# LoseOpportunity Action
[!INCLUDE[./descriptions/loseopportunity.md](./descriptions/loseopportunity.md)]

The LoseOpportunity action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OpportunityClose|[opportunityclose EntityType](../entitytypes/opportunityclose.md)|false|true|The opportunity close activity. |
|Status|Edm.Int32|false|true|Status of the lost opportunity.|



## Entities
Use the LoseOpportunity action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[opportunity Entitytype](../entitytypes/opportunity.md)|[!INCLUDE[../entitytypes/descriptions/opportunity.md](../entitytypes/descriptions/opportunity.md)]|

[!INCLUDE[./remarks/loseopportunity.md](./remarks/loseopportunity.md)]

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