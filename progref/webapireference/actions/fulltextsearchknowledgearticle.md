---
title: "FullTextSearchKnowledgeArticle Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 22e4afc2-8067-4b62-b7d5-763eafcf7f25
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# FullTextSearchKnowledgeArticle Action
[!INCLUDE[./descriptions/fulltextsearchknowledgearticle.md](./descriptions/fulltextsearchknowledgearticle.md)]

The FullTextSearchKnowledgeArticle action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SearchText|Edm.String|false|false|The text to search for in knowledge articles.|
|UseInflection|Edm.Boolean|false|true|Indicates whether to use inflectional stem matching when searching for knowledge articles. |
|RemoveDuplicates|Edm.Boolean|false|true|Indicates whether to remove multiple versions of the same knowledge article in search resultss |
|StateCode|Edm.Int32|false|true|The state of the knowledge articles to filter the search results|
|QueryExpression|[QueryBase ComplexType](../complextypes/QueryBase.md)|true|true|The query criteria to find knowledge articles with specified text.|

## Return Type
The FullTextSearchKnowledgeArticle action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|Contains the response from the FullTextSearchKnowledgeArticle Action|

## Entities
Use the FullTextSearchKnowledgeArticle action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[knowledgearticle Entitytype](../entitytypes/knowledgearticle.md)|[!INCLUDE[../entitytypes/descriptions/knowledgearticle.md](../entitytypes/descriptions/knowledgearticle.md)]|

[!INCLUDE[./remarks/fulltextsearchknowledgearticle.md](./remarks/fulltextsearchknowledgearticle.md)]

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