---
title: "Text Analytics Entity Mapping (TextAnalyticsEntityMapping) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Text Analytics Entity Mapping (TextAnalyticsEntityMapping) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Text Analytics Entity Mapping (TextAnalyticsEntityMapping) table/entity reference (Microsoft Dynamics 365)



> [!NOTE]
> The Microsoft Dynamics 365 Text Analytics Entity Mapping (TextAnalyticsEntityMapping) table extends the [Microsoft Dataverse Text Analytics Entity Mapping (TextAnalyticsEntityMapping) table](/power-apps/developer/data-platform/reference/entities/textanalyticsentitymapping).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_TopicModelConfigurationId"></a> TopicModelConfigurationId

|Property|Value|
|---|---|
|Description|**Topic Model Configuration associated with entity mapping.**|
|DisplayName|**Topic Model Configuration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`topicmodelconfigurationid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|topicmodelconfiguration|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [AdvancedSimilarityRuleId](#BKMK_AdvancedSimilarityRuleId)
- [KnowledgeSearchModelId](#BKMK_KnowledgeSearchModelId)

### <a name="BKMK_AdvancedSimilarityRuleId"></a> AdvancedSimilarityRuleId

Changes from [AdvancedSimilarityRuleId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/textanalyticsentitymapping#BKMK_AdvancedSimilarityRuleId)

|Property|Value|
|---|---|
|Targets|incident|


### <a name="BKMK_KnowledgeSearchModelId"></a> KnowledgeSearchModelId

Changes from [KnowledgeSearchModelId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/textanalyticsentitymapping#BKMK_KnowledgeSearchModelId)

|Property|Value|
|---|---|
|Targets|incident|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.textanalyticsentitymapping?displayProperty=fullName>
