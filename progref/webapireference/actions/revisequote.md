---
title: "ReviseQuote Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 3f49bce2-1223-4d4a-b48e-e6bf1f1adae9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ReviseQuote Action
[!INCLUDE[./descriptions/revisequote.md](./descriptions/revisequote.md)]

The ReviseQuote action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|QuoteId|Edm.Guid|false|true|The ID of the original quote.  |
|ColumnSet|[ColumnSet ComplexType](../complextypes/ColumnSet.md)|true|true|Collection of attributes to retrieve in the revised quote. |

## Return Type
The ReviseQuote action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[quote EntityType](../entitytypes/quote.md)|false|Contains the response from ReviseQuote Action. |

## Entities
Use the ReviseQuote action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[quote Entitytype](../entitytypes/quote.md)|[!INCLUDE[../entitytypes/descriptions/quote.md](../entitytypes/descriptions/quote.md)]|

[!INCLUDE[./remarks/revisequote.md](./remarks/revisequote.md)]

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