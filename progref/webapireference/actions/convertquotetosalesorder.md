---
title: "ConvertQuoteToSalesOrder Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: a3124f49-ec30-4578-83ee-d262c62ecb99
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ConvertQuoteToSalesOrder Action
[!INCLUDE[./descriptions/convertquotetosalesorder.md](./descriptions/convertquotetosalesorder.md)]

The ConvertQuoteToSalesOrder action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|QuoteId|Edm.Guid|false|true|The ID of the quote to convert|
|ColumnSet|[ColumnSet ComplexType](../complextypes/ColumnSet.md)|true|true|Collection of attributes to retrieve in the resulting sales order  |
|QuoteCloseDate|Edm.DateTimeOffset|true|true|The date when the quote is close. |
|QuoteCloseStatus|Edm.Int32|true|true|The status of the closed quote. |
|QuoteCloseSubject|Edm.String|true|false|The subject associated with the closed quote.|
|QuoteCloseDescription|Edm.String|true|false|The description for closing the quote. |
|ProcessInstanceId|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true|TODO: Add description for ConvertQuoteToSalesOrder ProcessInstanceId parameter.|

## Return Type
The ConvertQuoteToSalesOrder action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[salesorder EntityType](../entitytypes/salesorder.md)|false|Contains the response from ConvertQuoteToSalesOrder action. |

## Entities
Use the ConvertQuoteToSalesOrder action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[quote Entitytype](../entitytypes/quote.md)|[!INCLUDE[../entitytypes/descriptions/quote.md](../entitytypes/descriptions/quote.md)]|

[!INCLUDE[./remarks/convertquotetosalesorder.md](./remarks/convertquotetosalesorder.md)]

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