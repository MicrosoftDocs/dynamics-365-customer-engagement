---
title: "Search Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e46ccf0a-e367-43ec-b102-9a32d54f04ab
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Search Function
[!INCLUDE[./descriptions/search.md](./descriptions/search.md)]

The Search function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|AppointmentRequest|[AppointmentRequest ComplexType](../complextypes/AppointmentRequest.md)|true|true|The appointment request. |

## Return Type
The Search function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[SearchResponse ComplexType](../complextypes/SearchResponse.md)|false|Contains the results from the Search function. |



[!INCLUDE[./remarks/search.md](./remarks/search.md)]

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