---
title: "CloseQuote Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 6e7b4bec-d94d-456e-8f8d-5b7c5d089ac2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CloseQuote Action
[!INCLUDE[./descriptions/closequote.md](./descriptions/closequote.md)]

The CloseQuote action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|QuoteClose|[quoteclose EntityType](../entitytypes/quoteclose.md)|false|true|A quote to be closed.|
|Status|Edm.Int32|false|true|Status of the quote. |



## Entities
Use the CloseQuote action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[incident Entitytype](../entitytypes/incident.md)|[!INCLUDE[../entitytypes/descriptions/incident.md](../entitytypes/descriptions/incident.md)]|
|[quote Entitytype](../entitytypes/quote.md)|[!INCLUDE[../entitytypes/descriptions/quote.md](../entitytypes/descriptions/quote.md)]|

[!INCLUDE[./remarks/closequote.md](./remarks/closequote.md)]

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