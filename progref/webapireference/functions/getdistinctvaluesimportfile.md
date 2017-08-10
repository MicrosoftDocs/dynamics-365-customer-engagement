---
title: "GetDistinctValuesImportFile Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5f60e8ad-b47a-49fc-87a4-ba001c881078
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GetDistinctValuesImportFile Function
[!INCLUDE[./descriptions/getdistinctvaluesimportfile.md](./descriptions/getdistinctvaluesimportfile.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[importfile Entitytype](../entitytypes/importfile.md)|entity|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|columnNumber|Edm.Int32|false|true|A column number in the CSV, XML Spreadsheet 2003 (.xml), or text source file for which the distinct values are returned. Required. |
|pageNumber|Edm.Int32|false|true|The page number in the source file. Required. |
|recordsPerPage|Edm.Int32|false|true|The number of data records per page in the source file. Required.  |

## Return Type
The GetDistinctValuesImportFile function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[GetDistinctValuesImportFileResponse ComplexType](../complextypes/GetDistinctValuesImportFileResponse.md)|false|The response from this function.|



[!INCLUDE[./remarks/getdistinctvaluesimportfile.md](./remarks/getdistinctvaluesimportfile.md)]

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