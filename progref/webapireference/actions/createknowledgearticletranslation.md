---
title: "CreateKnowledgeArticleTranslation Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 5b6f34e1-0e48-4945-bda1-65572aef39d6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CreateKnowledgeArticleTranslation Action
[!INCLUDE[./descriptions/createknowledgearticletranslation.md](./descriptions/createknowledgearticletranslation.md)]

The CreateKnowledgeArticleTranslation action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Source|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The knowledge article instance to be translated.|
|Language|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The language to which the knowledge article instance is translated to.|
|IsMajor|Edm.Boolean|true|true|Specifies whether to create a major or minor version of the knowledge article instance.|

## Return Type
The CreateKnowledgeArticleTranslation action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|Contains the response from the CreateKnowledgeArticleTranslation action.|

## Entities
Use the CreateKnowledgeArticleTranslation action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[knowledgearticle Entitytype](../entitytypes/knowledgearticle.md)|[!INCLUDE[../entitytypes/descriptions/knowledgearticle.md](../entitytypes/descriptions/knowledgearticle.md)]|

[!INCLUDE[./remarks/createknowledgearticletranslation.md](./remarks/createknowledgearticletranslation.md)]

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