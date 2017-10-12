---
title: "GenerateSalesOrderFromOpportunity Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 68735a48-108a-4837-9566-28ffb1635945
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GenerateSalesOrderFromOpportunity Action
[!INCLUDE[./descriptions/generatesalesorderfromopportunity.md](./descriptions/generatesalesorderfromopportunity.md)]

The GenerateSalesOrderFromOpportunity action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OpportunityId|Edm.Guid|false|true|ID of the opportunity to be used as the basis for the new sales order. |
|ColumnSet|[ColumnSet ComplexType](../complextypes/ColumnSet.md)|true|true|Collection of attributes to retrieve from the resulting sales order.|

## Return Type
The GenerateSalesOrderFromOpportunity action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|Contains the response from GenerateSalesOrderFromOpportunity Action. |

## Entities
Use the GenerateSalesOrderFromOpportunity action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[salesorder Entitytype](../entitytypes/salesorder.md)|[!INCLUDE[../entitytypes/descriptions/salesorder.md](../entitytypes/descriptions/salesorder.md)]|

[!INCLUDE[./remarks/generatesalesorderfromopportunity.md](./remarks/generatesalesorderfromopportunity.md)]

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