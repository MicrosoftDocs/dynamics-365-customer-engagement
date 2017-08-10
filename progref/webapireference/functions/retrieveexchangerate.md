---
title: "RetrieveExchangeRate Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8f0b857b-7568-472f-bee1-f6e34b2766ac
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveExchangeRate Function
[!INCLUDE[./descriptions/retrieveexchangerate.md](./descriptions/retrieveexchangerate.md)]

The RetrieveExchangeRate function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|TransactionCurrencyId|Edm.Guid|false|true|The ID of the currency |

## Return Type
The RetrieveExchangeRate function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RetrieveExchangeRateResponse ComplexType](../complextypes/RetrieveExchangeRateResponse.md)|false|Contains the response from RetrieveExchangeRate function.|

## Entities
Use the RetrieveExchangeRate function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[transactioncurrency Entitytype](../entitytypes/transactioncurrency.md)|[!INCLUDE[../entitytypes/descriptions/transactioncurrency.md](../entitytypes/descriptions/transactioncurrency.md)]|

[!INCLUDE[./remarks/retrieveexchangerate.md](./remarks/retrieveexchangerate.md)]

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