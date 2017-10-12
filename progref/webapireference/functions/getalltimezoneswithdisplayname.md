---
title: "GetAllTimeZonesWithDisplayName Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 080a605d-64b4-4914-89d3-10b785925b76
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GetAllTimeZonesWithDisplayName Function
[!INCLUDE[./descriptions/getalltimezoneswithdisplayname.md](./descriptions/getalltimezoneswithdisplayname.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[timezonedefinition Entitytype](../entitytypes/timezonedefinition.md)|collection|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|LocaleId|Edm.Int32|false|true|The locale ID |

## Return Type
The GetAllTimeZonesWithDisplayName function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|Contains the results from the GetAllTimeZonesWithDisplayName function. |



[!INCLUDE[./remarks/getalltimezoneswithdisplayname.md](./remarks/getalltimezoneswithdisplayname.md)]

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