---
title: "GenerateQuoteFromOpportunity Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 50f363be-72e2-4752-9470-715218244332
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GenerateQuoteFromOpportunity Action
[!INCLUDE[./descriptions/generatequotefromopportunity.md](./descriptions/generatequotefromopportunity.md)]

The GenerateQuoteFromOpportunity action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OpportunityId|Edm.Guid|false|true|ID of the opportunity to be used as the basis for the new quote. |
|ColumnSet|[ColumnSet ComplexType](../complextypes/ColumnSet.md)|true|true|Collection of attributes to retrieve in the resulting quote.|
|ProcessInstanceId|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true|TODO: Add description for GenerateQuoteFromOpportunity ProcessInstanceId parameter.|

## Return Type
The GenerateQuoteFromOpportunity action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|Contains the response from GenerateQuoteFromOpportunity Action. |

## Entities
Use the GenerateQuoteFromOpportunity action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[quote Entitytype](../entitytypes/quote.md)|[!INCLUDE[../entitytypes/descriptions/quote.md](../entitytypes/descriptions/quote.md)]|

[!INCLUDE[./remarks/generatequotefromopportunity.md](./remarks/generatequotefromopportunity.md)]

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