---
title: "WinOpportunity Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: d024550b-e862-448b-a3b4-66de09fca3db
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# WinOpportunity Action
[!INCLUDE[./descriptions/winopportunity.md](./descriptions/winopportunity.md)]

The WinOpportunity action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OpportunityClose|[opportunityclose EntityType](../entitytypes/opportunityclose.md)|false|true|The opportunity close activity associated with this state change. |
|Status|Edm.Int32|false|true|Status of the opportunity. |



## Entities
Use the WinOpportunity action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[opportunity Entitytype](../entitytypes/opportunity.md)|[!INCLUDE[../entitytypes/descriptions/opportunity.md](../entitytypes/descriptions/opportunity.md)]|
|[quote Entitytype](../entitytypes/quote.md)|[!INCLUDE[../entitytypes/descriptions/quote.md](../entitytypes/descriptions/quote.md)]|

[!INCLUDE[./remarks/winopportunity.md](./remarks/winopportunity.md)]

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