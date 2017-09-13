---
title: "RetrieveEntityRibbon Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 73aeae1c-32bc-42ce-a191-7b078499b35c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveEntityRibbon Function
[!INCLUDE[./descriptions/retrieveentityribbon.md](./descriptions/retrieveentityribbon.md)]

The RetrieveEntityRibbon function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityName|Edm.String|false|false|The name of the specified entity. |
|RibbonLocationFilter|[RibbonLocationFilters EnumType](../enumtypes/RibbonLocationFilters.md)|false|true|A filter to retrieve a specific set of ribbon definitions for an entity. |

## Return Type
The RetrieveEntityRibbon function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RetrieveEntityRibbonResponse ComplexType](../complextypes/RetrieveEntityRibbonResponse.md)|false|Contains the results from RetrieveEntityRibbon function. |



[!INCLUDE[./remarks/retrieveentityribbon.md](./remarks/retrieveentityribbon.md)]

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