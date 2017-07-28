---
title: "GetDefaultPriceLevel Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fb196081-485d-4d36-8d0c-2ed6001865cc
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GetDefaultPriceLevel Function
[!INCLUDE[./descriptions/getdefaultpricelevel.md](./descriptions/getdefaultpricelevel.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[pricelevel Entitytype](../entitytypes/pricelevel.md)|collection|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityName|Edm.String|false|false|For internal use only. |

## Return Type
The GetDefaultPriceLevel function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([pricelevel EntityType](../entitytypes/pricelevel.md))|false|Contains the response from the GetDefaultPriceLevel function. |



[!INCLUDE[./remarks/getdefaultpricelevel.md](./remarks/getdefaultpricelevel.md)]

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