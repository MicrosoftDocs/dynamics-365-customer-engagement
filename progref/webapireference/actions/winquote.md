---
title: "WinQuote Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 7729d76a-baad-4df0-a64c-7e5d86fa1d9d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# WinQuote Action
[!INCLUDE[./descriptions/winquote.md](./descriptions/winquote.md)]

The WinQuote action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|QuoteClose|[quoteclose EntityType](../entitytypes/quoteclose.md)|false|true|The quote close activity associated with this state change. |
|Status|Edm.Int32|false|true|Status of the quote. |



## Entities
Use the WinQuote action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[opportunity Entitytype](../entitytypes/opportunity.md)|[!INCLUDE[../entitytypes/descriptions/opportunity.md](../entitytypes/descriptions/opportunity.md)]|
|[quote Entitytype](../entitytypes/quote.md)|[!INCLUDE[../entitytypes/descriptions/quote.md](../entitytypes/descriptions/quote.md)]|

[!INCLUDE[./remarks/winquote.md](./remarks/winquote.md)]

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