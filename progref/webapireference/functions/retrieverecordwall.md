---
title: "RetrieveRecordWall Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c854c5bb-31c3-436f-a6e9-077873d13021
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveRecordWall Function
[!INCLUDE[./descriptions/retrieverecordwall.md](./descriptions/retrieverecordwall.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[post Entitytype](../entitytypes/post.md)|collection|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Entity|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The record for which to retrieve the wall.|
|PageNumber|Edm.Int32|false|true|A specific page of posts that is designated by its page number. |
|PageSize|Edm.Int32|false|true|Number of posts per page|
|CommentsPerPost|Edm.Int32|false|true|Number of comments per post. |
|StartDate|Edm.DateTimeOffset|true|true|Start date and time of the posts that you want to retrieve. |
|EndDate|Edm.DateTimeOffset|true|true|End date and time of the posts that you want to retrieve.|
|Type|Edm.Int32|true|true|Reserved for future use.|
|Source|Edm.Int32|true|true|Source of the post.|
|SortDirection|Edm.Boolean|true|true|TODO: Add description for RetrieveRecordWall SortDirection parameter.|

## Return Type
The RetrieveRecordWall function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([post EntityType](../entitytypes/post.md))|false|Contains the results from the RetrieveRecordWall function.|



[!INCLUDE[./remarks/retrieverecordwall.md](./remarks/retrieverecordwall.md)]

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