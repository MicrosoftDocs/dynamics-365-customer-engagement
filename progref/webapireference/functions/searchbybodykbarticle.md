---
title: "SearchByBodyKbArticle Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8e8546b0-d52d-417f-a296-03ffb1ead6b7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SearchByBodyKbArticle Function
[!INCLUDE[./descriptions/searchbybodykbarticle.md](./descriptions/searchbybodykbarticle.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[kbarticle Entitytype](../entitytypes/kbarticle.md)|collection|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SearchText|Edm.String|false|false|Text contained in the body of the article. |
|Subject|[subject EntityType](../entitytypes/subject.md)|false|true|Subject of the specified body text.|
|UseInflection|Edm.Boolean|false|true|Whether to use inflectional stem matching when searching for knowledge base articles with a specified body text.|

## Return Type
The SearchByBodyKbArticle function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([kbarticle EntityType](../entitytypes/kbarticle.md))|false|Contains the response from the SearchByBodyKbArticle function.|



[!INCLUDE[./remarks/searchbybodykbarticle.md](./remarks/searchbybodykbarticle.md)]

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