---
title: "ExportMappingsImportMap Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 16dc5f9a-ddd5-4648-9917-6a7978c3c64e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ExportMappingsImportMap Action
[!INCLUDE[./descriptions/exportmappingsimportmap.md](./descriptions/exportmappingsimportmap.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[importmap Entitytype](../entitytypes/importmap.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ExportIds|Edm.Boolean|true|true|Whether to export the entity record IDs contained in the data map. Required. |

## Return Type
The ExportMappingsImportMap action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[ExportMappingsImportMapResponse ComplexType](../complextypes/ExportMappingsImportMapResponse.md)|false|The XML representation of the exported data map.  |



[!INCLUDE[./remarks/exportmappingsimportmap.md](./remarks/exportmappingsimportmap.md)]

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