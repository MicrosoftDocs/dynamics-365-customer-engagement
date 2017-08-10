---
title: "RetrieveParsedDataImportFile Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 51bd73d3-592d-4409-84f3-7fb844ca9c2f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveParsedDataImportFile Function
[!INCLUDE[./descriptions/retrieveparseddataimportfile.md](./descriptions/retrieveparseddataimportfile.md)]

The RetrieveParsedDataImportFile function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ImportFileId|Edm.Guid|false|true|ID of the import file that is associated with the parse table. |
|PagingInfo|[PagingInfo ComplexType](../complextypes/PagingInfo.md)|true|true|The paging information for the retrieved data. |

## Return Type
The RetrieveParsedDataImportFile function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RetrieveParsedDataImportFileResponse ComplexType](../complextypes/RetrieveParsedDataImportFileResponse.md)|false|Contains the results from the RetrieveParsedDataImportFile function. |

## Entities
Use the RetrieveParsedDataImportFile function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[importfile Entitytype](../entitytypes/importfile.md)|[!INCLUDE[../entitytypes/descriptions/importfile.md](../entitytypes/descriptions/importfile.md)]|

[!INCLUDE[./remarks/retrieveparseddataimportfile.md](./remarks/retrieveparseddataimportfile.md)]

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