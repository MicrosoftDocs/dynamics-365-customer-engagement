---
title: "SearchByKeywordsKbArticle Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 06de14d2-0195-40e8-9c9b-fcb00796a517
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SearchByKeywordsKbArticle Function
[!INCLUDE[./descriptions/searchbykeywordskbarticle.md](./descriptions/searchbykeywordskbarticle.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[kbarticle Entitytype](../entitytypes/kbarticle.md)|collection|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SearchText|Edm.String|false|false|Keywords in the article.|
|Subject|[subject EntityType](../entitytypes/subject.md)|false|true|Knowledge base article subject.|
|UseInflection|Edm.Boolean|false|true|Whether to use inflectional stem matching when searching for knowledge base articles with the specified keywords.|

## Return Type
The SearchByKeywordsKbArticle function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([kbarticle EntityType](../entitytypes/kbarticle.md))|false|Contains the response from the SearchByKeywordsKbArticle function.|



[!INCLUDE[./remarks/searchbykeywordskbarticle.md](./remarks/searchbykeywordskbarticle.md)]

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