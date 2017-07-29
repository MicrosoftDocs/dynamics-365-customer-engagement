---
title: "RetrieveDuplicates Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 38eaf839-54af-4bcb-b416-6edc624b5f32
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveDuplicates Function
[!INCLUDE[./descriptions/retrieveduplicates.md](./descriptions/retrieveduplicates.md)]

The RetrieveDuplicates function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|BusinessEntity|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|Record for which the duplicates are retrieved.|
|MatchingEntityName|Edm.String|false|false|A name of the matching entity type.|
|PagingInfo|[PagingInfo ComplexType](../complextypes/PagingInfo.md)|true|true|A paging information for the retrieved duplicates.|

## Return Type
The RetrieveDuplicates function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|Contains the results from the RetrieveDuplicates function.|



[!INCLUDE[./remarks/retrieveduplicates.md](./remarks/retrieveduplicates.md)]

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