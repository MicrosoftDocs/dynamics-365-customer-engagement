---
title: "ImportMappingsImportMap Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 88ad50ba-a74f-478e-90d5-6368b7bd1166
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ImportMappingsImportMap Action
[!INCLUDE[./descriptions/importmappingsimportmap.md](./descriptions/importmappingsimportmap.md)]

The ImportMappingsImportMap action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|MappingsXml|Edm.String|false|false|XML representation of the data map. |
|ReplaceIds|Edm.Boolean|false|true|Indicates whether to import the entity record IDs contained in the XML representation of the data map. |

## Return Type
The ImportMappingsImportMap action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[importmap EntityType](../entitytypes/importmap.md)|false|Contains the response from ImportMappingsImportMap Action. |

## Entities
Use the ImportMappingsImportMap action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[importmap Entitytype](../entitytypes/importmap.md)|[!INCLUDE[../entitytypes/descriptions/importmap.md](../entitytypes/descriptions/importmap.md)]|

[!INCLUDE[./remarks/importmappingsimportmap.md](./remarks/importmappingsimportmap.md)]

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