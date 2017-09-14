---
title: "RetrievePersonalWall Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5b30266b-f20a-4e06-8111-27e1e8573d15
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrievePersonalWall Function
[!INCLUDE[./descriptions/retrievepersonalwall.md](./descriptions/retrievepersonalwall.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[post Entitytype](../entitytypes/post.md)|collection|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|PageNumber|Edm.Int32|false|true|A specific page of posts that is designated by its page number |
|PageSize|Edm.Int32|false|true|The number of posts per page |
|CommentsPerPost|Edm.Int32|false|true|The number of comments per post.  |
|StartDate|Edm.DateTimeOffset|true|true|The start date and time of the posts that you want to retrieve. |
|EndDate|Edm.DateTimeOffset|true|true|The end date and time of the posts that you want to retrieve |
|Type|Edm.Int32|true|true|Reserved for future use. |
|Source|Edm.Int32|true|true|The source of the post. |
|SortDirection|Edm.Boolean|true|true|TODO: Add description for RetrievePersonalWall SortDirection parameter.|

## Return Type
The RetrievePersonalWall function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([post EntityType](../entitytypes/post.md))|false|Contains the results from the RetrievePersonalWall function. |



[!INCLUDE[./remarks/retrievepersonalwall.md](./remarks/retrievepersonalwall.md)]

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