---
title: "CreateKnowledgeArticleVersion Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 9c14a300-5aa4-4f6b-8e70-dad30f8b8bac
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CreateKnowledgeArticleVersion Action
[!INCLUDE[./descriptions/createknowledgearticleversion.md](./descriptions/createknowledgearticleversion.md)]

The CreateKnowledgeArticleVersion action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Source|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The knowledge article instance for which you want to create a version.|
|IsMajor|Edm.Boolean|false|true|Specifies whether to create a major or minor version of the knowledge article instance.|

## Return Type
The CreateKnowledgeArticleVersion action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|Contains the response from the CreateKnowledgeArticleTranslation action.|

## Entities
Use the CreateKnowledgeArticleVersion action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[knowledgearticle Entitytype](../entitytypes/knowledgearticle.md)|[!INCLUDE[../entitytypes/descriptions/knowledgearticle.md](../entitytypes/descriptions/knowledgearticle.md)]|

[!INCLUDE[./remarks/createknowledgearticleversion.md](./remarks/createknowledgearticleversion.md)]

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