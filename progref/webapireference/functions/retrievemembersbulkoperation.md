---
title: "RetrieveMembersBulkOperation Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 352c0d1c-76d5-4278-bd0d-8b3d38c070b9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveMembersBulkOperation Function
[!INCLUDE[./descriptions/retrievemembersbulkoperation.md](./descriptions/retrievemembersbulkoperation.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[bulkoperation Entitytype](../entitytypes/bulkoperation.md)|entity|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|BulkOperationSource|Edm.Int32|false|true|The source for a bulk operation. Required. |
|EntitySource|Edm.Int32|false|true|Which members of a bulk operation to retrieve.|

## Return Type
The RetrieveMembersBulkOperation function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|The members of a bulk operation. |



[!INCLUDE[./remarks/retrievemembersbulkoperation.md](./remarks/retrievemembersbulkoperation.md)]

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