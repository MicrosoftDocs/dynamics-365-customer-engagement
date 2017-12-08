---
title: "AdvancedSimilarityRule Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the AdvancedSimilarityRule entity."
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
# AdvancedSimilarityRule Entity Reference

A text match rule identifies similar records using keywords and key phrases determined with text analytics


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/advancedsimilarityrules<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/advancedsimilarityrules(*advancedsimilarityruleid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/advancedsimilarityrules(*advancedsimilarityruleid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/advancedsimilarityrules<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/advancedsimilarityrules(*advancedsimilarityruleid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/advancedsimilarityrules(*advancedsimilarityruleid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|AdvancedSimilarityRules|
|DisplayCollectionName|Advanced Similarity Rules|
|DisplayName|Advanced Similarity Rule|
|EntitySetName|advancedsimilarityrules|
|IsBPFEntity|False|
|LogicalCollectionName|advancedsimilarityrules|
|LogicalName|advancedsimilarityrule|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|advancedsimilarityruleid|
|PrimaryNameAttribute|name|
|SchemaName|AdvancedSimilarityRule|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AdvancedSimilarityRuleId](#BKMK_AdvancedSimilarityRuleId)
- [AzureServiceConnectionId](#BKMK_AzureServiceConnectionId)
- [Description](#BKMK_Description)
- [Entity](#BKMK_Entity)
- [ExactMatchList](#BKMK_ExactMatchList)
- [FetchXmlList](#BKMK_FetchXmlList)
- [FilterResultByStatus](#BKMK_FilterResultByStatus)
- [FilterResultByStatusDisplayName](#BKMK_FilterResultByStatusDisplayName)
- [IsAzureMLRequired](#BKMK_IsAzureMLRequired)
- [MaxNumberKeyphrases](#BKMK_MaxNumberKeyphrases)
- [name](#BKMK_name)
- [NgramSize](#BKMK_NgramSize)
- [SourceEntity](#BKMK_SourceEntity)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)


### <a name="BKMK_AdvancedSimilarityRuleId"></a> AdvancedSimilarityRuleId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Advanced Similarity Rule|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|advancedsimilarityruleid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_AzureServiceConnectionId"></a> AzureServiceConnectionId

|Property|Value|
|--------|-----|
|Description|Unique identifier for AzureServiceConnection associated with AdvancedSimilarityRule.|
|DisplayName|Connection|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|azureserviceconnectionid|
|RequiredLevel|ApplicationRequired|
|Targets|azureserviceconnection|
|Type|Lookup|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Enter a description for the Advanced Similarity Rule|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Entity"></a> Entity

|Property|Value|
|--------|-----|
|Description|entity|
|DisplayName|Target Entity|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|entity|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_ExactMatchList"></a> ExactMatchList

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|For internal use only.|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|exactmatchlist|
|MaxLength|500000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_FetchXmlList"></a> FetchXmlList

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|For internal use only.|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fetchxmllist|
|MaxLength|500000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_FilterResultByStatus"></a> FilterResultByStatus

|Property|Value|
|--------|-----|
|Description|Filter Result By Status|
|DisplayName|Filter Result By Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|filterresultbystatus|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_FilterResultByStatusDisplayName"></a> FilterResultByStatusDisplayName

|Property|Value|
|--------|-----|
|Description|Filter Result By Status|
|DisplayName|Filter Result By Status|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|filterresultbystatusdisplayname|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsAzureMLRequired"></a> IsAzureMLRequired

|Property|Value|
|--------|-----|
|Description|Use Text Analytics for Target Match|
|DisplayName|Use Text Analytics for Target Match|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isazuremlrequired|
|RequiredLevel|None|
|Type|Boolean|

#### IsAzureMLRequired Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_MaxNumberKeyphrases"></a> MaxNumberKeyphrases

|Property|Value|
|--------|-----|
|Description|Enter the maximum number of keywords and key phrases to use with text analytics.|
|DisplayName|Maximum Number of Key Phrases|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|maxnumberkeyphrases|
|MaxValue|1000|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_name"></a> name

|Property|Value|
|--------|-----|
|Description|Type a logical name for the similarity configuration|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_NgramSize"></a> NgramSize

|Property|Value|
|--------|-----|
|Description|Enter the maximum number of words in a key phrase to use with text analytics.|
|DisplayName|Maximum Key Phrase Words|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ngramsize|
|MaxValue|3|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_SourceEntity"></a> SourceEntity

|Property|Value|
|--------|-----|
|Description|Enter an entity that similar records will be suggested for|
|DisplayName|Source Entity|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sourceentity|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the advanced similarity rules|
|DisplayName|Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the advanced similarity rules|
|DisplayName|Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|


<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AdvancedSimilarityRuleIdUnique](#BKMK_AdvancedSimilarityRuleIdUnique)
- [AzureServiceConnectionIdName](#BKMK_AzureServiceConnectionIdName)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OverwriteTime](#BKMK_OverwriteTime)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)


### <a name="BKMK_AdvancedSimilarityRuleIdUnique"></a> AdvancedSimilarityRuleIdUnique

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Advanced Similarity Rule used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook|
|DisplayName|Advanced Similarity Rule Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|advancedsimilarityruleidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_AzureServiceConnectionIdName"></a> AzureServiceConnectionIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|azureserviceconnectionidname|
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



### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the Advanced Similarity Rules.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the Advanced Similarity Rules.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the advanced similarity rules.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the advanced similarity rules|
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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_advancedsimilarityrule_textanalyticsentitymapping"></a> advancedsimilarityrule_textanalyticsentitymapping

Same as textanalyticsentitymapping entity [advancedsimilarityrule_textanalyticsentitymapping](textanalyticsentitymapping.md#BKMK_advancedsimilarityrule_textanalyticsentitymapping) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|textanalyticsentitymapping|
|ReferencingAttribute|advancedsimilarityruleid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|advancedsimilarityrule_textanalyticsentitymapping|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 1000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [azureserviceconnection_advancedsimilarityrule](#BKMK_azureserviceconnection_advancedsimilarityrule)
- [organization_advancedsimilarityrule](#BKMK_organization_advancedsimilarityrule)
- [lk_advancedsimilarityrule_modifiedby](#BKMK_lk_advancedsimilarityrule_modifiedby)
- [lk_advancedsimilarityrule_createdonbehalfby](#BKMK_lk_advancedsimilarityrule_createdonbehalfby)
- [lk_advancedsimilarityrule_modifiedonbehalfby](#BKMK_lk_advancedsimilarityrule_modifiedonbehalfby)
- [lk_advancedsimilarityrule_createdby](#BKMK_lk_advancedsimilarityrule_createdby)


### <a name="BKMK_azureserviceconnection_advancedsimilarityrule"></a> azureserviceconnection_advancedsimilarityrule

See azureserviceconnection Entity [azureserviceconnection_advancedsimilarityrule](azureserviceconnection.md#BKMK_azureserviceconnection_advancedsimilarityrule) One-To-Many relationship.

### <a name="BKMK_organization_advancedsimilarityrule"></a> organization_advancedsimilarityrule

See organization Entity [organization_advancedsimilarityrule](organization.md#BKMK_organization_advancedsimilarityrule) One-To-Many relationship.

### <a name="BKMK_lk_advancedsimilarityrule_modifiedby"></a> lk_advancedsimilarityrule_modifiedby

See systemuser Entity [lk_advancedsimilarityrule_modifiedby](systemuser.md#BKMK_lk_advancedsimilarityrule_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_advancedsimilarityrule_createdonbehalfby"></a> lk_advancedsimilarityrule_createdonbehalfby

See systemuser Entity [lk_advancedsimilarityrule_createdonbehalfby](systemuser.md#BKMK_lk_advancedsimilarityrule_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_advancedsimilarityrule_modifiedonbehalfby"></a> lk_advancedsimilarityrule_modifiedonbehalfby

See systemuser Entity [lk_advancedsimilarityrule_modifiedonbehalfby](systemuser.md#BKMK_lk_advancedsimilarityrule_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_advancedsimilarityrule_createdby"></a> lk_advancedsimilarityrule_createdby

See systemuser Entity [lk_advancedsimilarityrule_createdby](systemuser.md#BKMK_lk_advancedsimilarityrule_createdby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.advancedsimilarityrule?text=advancedsimilarityrule EntityType" />