---
title: "SearchByTitleKbArticle Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b44579e4-4209-478b-b347-ea644baf7ed9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SearchByTitleKbArticle Function
[!INCLUDE[./descriptions/searchbytitlekbarticle.md](./descriptions/searchbytitlekbarticle.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[kbarticle Entitytype](../entitytypes/kbarticle.md)|collection|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SearchText|Edm.String|false|false|Title in the articles.|
|Subject|[subject EntityType](../entitytypes/subject.md)|false|true|Subject for the knowledge base article. |
|UseInflection|Edm.Boolean|false|true|Whether to use inflectional stem matching when you search for knowledge base articles by a specific title.|

## Return Type
The SearchByTitleKbArticle function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([kbarticle EntityType](../entitytypes/kbarticle.md))|false|Contains the response from the SearchByTitleKbArticle function.|



[!INCLUDE[./remarks/searchbytitlekbarticle.md](./remarks/searchbytitlekbarticle.md)]

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