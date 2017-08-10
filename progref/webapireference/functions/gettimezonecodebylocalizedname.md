---
title: "GetTimeZoneCodeByLocalizedName Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 62925e6c-86ee-49af-8391-e1bf54e98a82
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GetTimeZoneCodeByLocalizedName Function
[!INCLUDE[./descriptions/gettimezonecodebylocalizedname.md](./descriptions/gettimezonecodebylocalizedname.md)]

The GetTimeZoneCodeByLocalizedName function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|LocalizedStandardName|Edm.String|false|false|The localized name to search for. |
|LocaleId|Edm.Int32|false|true|The locale ID. |

## Return Type
The GetTimeZoneCodeByLocalizedName function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[GetTimeZoneCodeByLocalizedNameResponse ComplexType](../complextypes/GetTimeZoneCodeByLocalizedNameResponse.md)|false|Contains the response from the GetTimeZoneCodeByLocalizedName function. |

## Entities
Use the GetTimeZoneCodeByLocalizedName function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[timezonedefinition Entitytype](../entitytypes/timezonedefinition.md)|[!INCLUDE[../entitytypes/descriptions/timezonedefinition.md](../entitytypes/descriptions/timezonedefinition.md)]|

[!INCLUDE[./remarks/gettimezonecodebylocalizedname.md](./remarks/gettimezonecodebylocalizedname.md)]

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