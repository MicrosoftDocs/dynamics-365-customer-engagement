---
title: "TextAnalyticsEntityMapping Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TextAnalyticsEntityMapping entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# TextAnalyticsEntityMapping Entity Reference




## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/textanalyticsentitymappings<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/textanalyticsentitymappings(*textanalyticsentitymappingid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/textanalyticsentitymappings(*textanalyticsentitymappingid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/textanalyticsentitymappings<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/textanalyticsentitymappings(*textanalyticsentitymappingid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|TextAnalyticsEntityMappings|
|DisplayCollectionName|Text Analytics Entity Mappings|
|DisplayName|Text Analytics Entity Mapping|
|EntitySetName|textanalyticsentitymappings|
|IsBPFEntity|False|
|LogicalCollectionName|textanalyticsentitymapping|
|LogicalName|textanalyticsentitymapping|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|textanalyticsentitymappingid|
|PrimaryNameAttribute||
|SchemaName|TextAnalyticsEntityMapping|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AdvancedSimilarityRuleId](#BKMK_AdvancedSimilarityRuleId)
- [Entity](#BKMK_Entity)
- [EntityDisplayName](#BKMK_EntityDisplayName)
- [EntityPickList](#BKMK_EntityPickList)
- [Field](#BKMK_Field)
- [FieldDisplayName](#BKMK_FieldDisplayName)
- [FieldPickList](#BKMK_FieldPickList)
- [IsTextMatchMapping](#BKMK_IsTextMatchMapping)
- [KnowledgeSearchModelId](#BKMK_KnowledgeSearchModelId)
- [ModelType](#BKMK_ModelType)
- [RelationshipName](#BKMK_RelationshipName)
- [SimilarityRuleId](#BKMK_SimilarityRuleId)
- [TextAnalyticsEntityMappingId](#BKMK_TextAnalyticsEntityMappingId)
- [TopicModelConfigurationId](#BKMK_TopicModelConfigurationId)


### <a name="BKMK_AdvancedSimilarityRuleId"></a> AdvancedSimilarityRuleId

|Property|Value|
|--------|-----|
|Description|Advanced Similarity RuleId associated with entity mapping.|
|DisplayName|Advanced Similarity RuleId|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|advancedsimilarityruleid|
|RequiredLevel|ApplicationRequired|
|Targets|incident|
|Type|Lookup|


### <a name="BKMK_Entity"></a> Entity

|Property|Value|
|--------|-----|
|Description|Entity|
|DisplayName|Entity|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|entity|
|MaxLength|50|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_EntityDisplayName"></a> EntityDisplayName

|Property|Value|
|--------|-----|
|Description|Entity Display Name|
|DisplayName|Entity Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|entitydisplayname|
|MaxLength|50|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_EntityPickList"></a> EntityPickList

|Property|Value|
|--------|-----|
|Description|Select Entity|
|DisplayName|Entity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|entitypicklist|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_Field"></a> Field

|Property|Value|
|--------|-----|
|Description|Field|
|DisplayName|Field|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|field|
|MaxLength|50|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_FieldDisplayName"></a> FieldDisplayName

|Property|Value|
|--------|-----|
|Description|Field Display Name|
|DisplayName|Field Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|fielddisplayname|
|MaxLength|50|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_FieldPickList"></a> FieldPickList

|Property|Value|
|--------|-----|
|Description|Select Field|
|DisplayName|Field|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fieldpicklist|
|RequiredLevel|None|
|Type|Picklist|

#### FieldPickList Options

|Value|Label|
|-----|-----|
|1|No|
|2|Yes|



### <a name="BKMK_IsTextMatchMapping"></a> IsTextMatchMapping

|Property|Value|
|--------|-----|
|Description|Specify if the mapping is for text match or exact match|
|DisplayName|Criteria|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|istextmatchmapping|
|RequiredLevel|None|
|Type|Boolean|

#### IsTextMatchMapping Options

|Value|Label|
|-----|-----|
|1|Text Match|
|0|Exact Match|

**DefaultValue**: True



### <a name="BKMK_KnowledgeSearchModelId"></a> KnowledgeSearchModelId

|Property|Value|
|--------|-----|
|Description|Knowledge Search Model associated with entity mapping.|
|DisplayName|Knowledge Search Model Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|knowledgesearchmodelid|
|RequiredLevel|ApplicationRequired|
|Targets|incident|
|Type|Lookup|


### <a name="BKMK_ModelType"></a> ModelType

|Property|Value|
|--------|-----|
|Description|Model Type.|
|DisplayName|Model Type|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modeltype|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_RelationshipName"></a> RelationshipName

|Property|Value|
|--------|-----|
|Description|Relationship Name|
|DisplayName|Relationship Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|relationshipname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SimilarityRuleId"></a> SimilarityRuleId

|Property|Value|
|--------|-----|
|Description|Similarity Rule associated with entity mapping.|
|DisplayName|Similarity Rule Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|similarityruleid|
|RequiredLevel|ApplicationRequired|
|Targets|similarityrule|
|Type|Lookup|


### <a name="BKMK_TextAnalyticsEntityMappingId"></a> TextAnalyticsEntityMappingId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Text Analytics Entity Mapping|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|textanalyticsentitymappingid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_TopicModelConfigurationId"></a> TopicModelConfigurationId

|Property|Value|
|--------|-----|
|Description|Topic Model Configuration associated with entity mapping.|
|DisplayName|Topic Model Configuration Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|topicmodelconfigurationid|
|RequiredLevel|ApplicationRequired|
|Targets|topicmodelconfiguration|
|Type|Lookup|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AdvancedSimilarityRuleIdName](#BKMK_AdvancedSimilarityRuleIdName)
- [ComponentState](#BKMK_ComponentState)
- [IsManaged](#BKMK_IsManaged)
- [KnowledgeSearchModelIdName](#BKMK_KnowledgeSearchModelIdName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OverwriteTime](#BKMK_OverwriteTime)
- [SimilarityRuleIdName](#BKMK_SimilarityRuleIdName)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [TextAnalyticsEntityMappingIdUnique](#BKMK_TextAnalyticsEntityMappingIdUnique)
- [TopicModelConfigurationIdName](#BKMK_TopicModelConfigurationIdName)


### <a name="BKMK_AdvancedSimilarityRuleIdName"></a> AdvancedSimilarityRuleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|advancedsimilarityruleidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Component State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|componentstate|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ComponentState Options

|Value|Label|
|-----|-----|
|0|Published|
|1|Unpublished|
|2|Deleted|
|3|Deleted Unpublished|



### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|Is Manageed|
|DisplayName|State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismanaged|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsManaged Options

|Value|Label|
|-----|-----|
|1|Managed|
|0|Unmanaged|

**DefaultValue**: False



### <a name="BKMK_KnowledgeSearchModelIdName"></a> KnowledgeSearchModelIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|knowledgesearchmodelidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the Text Analytics Entity Mapping.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|overwritetime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_SimilarityRuleIdName"></a> SimilarityRuleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|similarityruleidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated solution.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|solutionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|supportingsolutionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_TextAnalyticsEntityMappingIdUnique"></a> TextAnalyticsEntityMappingIdUnique

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Text Analytics Entity Mapping|
|DisplayName|Text Analytics Entity Mapping Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|textanalyticsentitymappingidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_TopicModelConfigurationIdName"></a> TopicModelConfigurationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|topicmodelconfigurationidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [topicmodelconfiguration_textanalyticsentitymapping](#BKMK_topicmodelconfiguration_textanalyticsentitymapping)
- [advancedsimilarityrule_textanalyticsentitymapping](#BKMK_advancedsimilarityrule_textanalyticsentitymapping)
- [organization_textanalyticsentitymapping](#BKMK_organization_textanalyticsentitymapping)
- [knowledgesearchmodel_textanalyticsentitymapping](#BKMK_knowledgesearchmodel_textanalyticsentitymapping)


### <a name="BKMK_topicmodelconfiguration_textanalyticsentitymapping"></a> topicmodelconfiguration_textanalyticsentitymapping

See topicmodelconfiguration Entity [topicmodelconfiguration_textanalyticsentitymapping](topicmodelconfiguration.md#BKMK_topicmodelconfiguration_textanalyticsentitymapping) One-To-Many relationship.

### <a name="BKMK_advancedsimilarityrule_textanalyticsentitymapping"></a> advancedsimilarityrule_textanalyticsentitymapping

See advancedsimilarityrule Entity [advancedsimilarityrule_textanalyticsentitymapping](advancedsimilarityrule.md#BKMK_advancedsimilarityrule_textanalyticsentitymapping) One-To-Many relationship.

### <a name="BKMK_organization_textanalyticsentitymapping"></a> organization_textanalyticsentitymapping

See organization Entity [organization_textanalyticsentitymapping](organization.md#BKMK_organization_textanalyticsentitymapping) One-To-Many relationship.

### <a name="BKMK_knowledgesearchmodel_textanalyticsentitymapping"></a> knowledgesearchmodel_textanalyticsentitymapping

See knowledgesearchmodel Entity [knowledgesearchmodel_textanalyticsentitymapping](knowledgesearchmodel.md#BKMK_knowledgesearchmodel_textanalyticsentitymapping) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.textanalyticsentitymapping?text=textanalyticsentitymapping EntityType" />