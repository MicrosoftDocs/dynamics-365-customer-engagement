---
title: "IncrementKnowledgeArticleViewCount Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 43442e0e-c9a7-4cb4-9134-3f59849bbc16
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# IncrementKnowledgeArticleViewCount Function
[!INCLUDE[./descriptions/incrementknowledgearticleviewcount.md](./descriptions/incrementknowledgearticleviewcount.md)]

The IncrementKnowledgeArticleViewCount function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Source|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The knowledge article record for incrementing the view count.|
|ViewDate|Edm.DateTimeOffset|false|true|The date for which the view count has to be incremented.|
|Location|Edm.Int32|false|true|The location where the knowledge article record was used.|
|Count|Edm.Int32|false|true|The view count of a knowledge article record.|

## Return Type
The IncrementKnowledgeArticleViewCount function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|Contains the response from the IncrementKnowledgeArticleViewCount function.|

## Entities
Use the IncrementKnowledgeArticleViewCount function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[knowledgearticleviews Entitytype](../entitytypes/knowledgearticleviews.md)|[!INCLUDE[../entitytypes/descriptions/knowledgearticleviews.md](../entitytypes/descriptions/knowledgearticleviews.md)]|

[!INCLUDE[./remarks/incrementknowledgearticleviewcount.md](./remarks/incrementknowledgearticleviewcount.md)]

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