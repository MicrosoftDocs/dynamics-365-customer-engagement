---
title: "RetrieveEntityChanges Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a69ae2c7-88cf-4561-a796-45a9d1a2787c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveEntityChanges Function
[!INCLUDE[./descriptions/retrieveentitychanges.md](./descriptions/retrieveentitychanges.md)]

The RetrieveEntityChanges function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityName|Edm.String|false|false|The entity name.|
|DataVersion|Edm.String|true|false|The data version.|
|PageInfo|[PagingInfo ComplexType](../complextypes/PagingInfo.md)|true|true|The paging information.|
|Columns|[ColumnSet ComplexType](../complextypes/ColumnSet.md)|true|true|The columns to retrieve.|

## Return Type
The RetrieveEntityChanges function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RetrieveEntityChangesResponse ComplexType](../complextypes/RetrieveEntityChangesResponse.md)|false|Contains the response from the RetrieveByResourcesService Function.|



[!INCLUDE[./remarks/retrieveentitychanges.md](./remarks/retrieveentitychanges.md)]

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