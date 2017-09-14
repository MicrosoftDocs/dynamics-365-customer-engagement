---
title: "Rollup Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 73e29e35-9f12-4e0a-ab1b-cd318311e024
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Rollup Function
[!INCLUDE[./descriptions/rollup.md](./descriptions/rollup.md)]

The Rollup function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The target record for the rollup operation.|
|Query|[QueryBase ComplexType](../complextypes/QueryBase.md)|true|true|The query criteria for the rollup operation. |
|RollupType|[RollupType EnumType](../enumtypes/RollupType.md)|false|true|The rollup type.|

## Return Type
The Rollup function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|Contains the response from the Rollup Function.|

## Entities
Use the Rollup function with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[account Entitytype](../entitytypes/account.md)|[!INCLUDE[../entitytypes/descriptions/account.md](../entitytypes/descriptions/account.md)]|
|[activitypointer Entitytype](../entitytypes/activitypointer.md)|[!INCLUDE[../entitytypes/descriptions/activitypointer.md](../entitytypes/descriptions/activitypointer.md)]|
|[annotation Entitytype](../entitytypes/annotation.md)|[!INCLUDE[../entitytypes/descriptions/annotation.md](../entitytypes/descriptions/annotation.md)]|
|[contact Entitytype](../entitytypes/contact.md)|[!INCLUDE[../entitytypes/descriptions/contact.md](../entitytypes/descriptions/contact.md)]|
|[contract Entitytype](../entitytypes/contract.md)|[!INCLUDE[../entitytypes/descriptions/contract.md](../entitytypes/descriptions/contract.md)]|
|[incident Entitytype](../entitytypes/incident.md)|[!INCLUDE[../entitytypes/descriptions/incident.md](../entitytypes/descriptions/incident.md)]|
|[invoice Entitytype](../entitytypes/invoice.md)|[!INCLUDE[../entitytypes/descriptions/invoice.md](../entitytypes/descriptions/invoice.md)]|
|[opportunity Entitytype](../entitytypes/opportunity.md)|[!INCLUDE[../entitytypes/descriptions/opportunity.md](../entitytypes/descriptions/opportunity.md)]|
|[quote Entitytype](../entitytypes/quote.md)|[!INCLUDE[../entitytypes/descriptions/quote.md](../entitytypes/descriptions/quote.md)]|
|[salesorder Entitytype](../entitytypes/salesorder.md)|[!INCLUDE[../entitytypes/descriptions/salesorder.md](../entitytypes/descriptions/salesorder.md)]|

[!INCLUDE[./remarks/rollup.md](./remarks/rollup.md)]

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