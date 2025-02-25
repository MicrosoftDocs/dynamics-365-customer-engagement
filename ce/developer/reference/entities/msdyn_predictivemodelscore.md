---
title: "Predictive Model Score (msdyn_predictivemodelscore) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Predictive Model Score (msdyn_predictivemodelscore) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Predictive Model Score (msdyn_predictivemodelscore) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Predictive Model Score (msdyn_predictivemodelscore) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_predictivemodelscores<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_predictivemodelscores(*msdyn_predictivemodelscoreid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_predictivemodelscores(*msdyn_predictivemodelscoreid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_predictivemodelscores<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_predictivemodelscores(*msdyn_predictivemodelscoreid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_predictivemodelscores(*msdyn_predictivemodelscoreid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_predictivemodelscores(*msdyn_predictivemodelscoreid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Predictive Model Score (msdyn_predictivemodelscore) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Predictive Model Score** |
| **DisplayCollectionName** | **Predictive Model Score** |
| **SchemaName** | `msdyn_predictivemodelscore` |
| **CollectionSchemaName** | `msdyn_predictivemodelscores` |
| **EntitySetName** | `msdyn_predictivemodelscores`|
| **LogicalName** | `msdyn_predictivemodelscore` |
| **LogicalCollectionName** | `msdyn_predictivemodelscores` |
| **PrimaryIdAttribute** | `msdyn_predictivemodelscoreid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_EntityId](#BKMK_msdyn_EntityId)
- [msdyn_EntityType](#BKMK_msdyn_EntityType)
- [msdyn_Grade](#BKMK_msdyn_Grade)
- [msdyn_ModelName](#BKMK_msdyn_ModelName)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PredictionID](#BKMK_msdyn_PredictionID)
- [msdyn_predictivemodelscoreId](#BKMK_msdyn_predictivemodelscoreId)
- [msdyn_PredictiveScoreId](#BKMK_msdyn_PredictiveScoreId)
- [msdyn_Score](#BKMK_msdyn_Score)
- [msdyn_ScoredOn](#BKMK_msdyn_ScoredOn)
- [msdyn_ScoreHistory](#BKMK_msdyn_ScoreHistory)
- [msdyn_ScoreReasons](#BKMK_msdyn_ScoreReasons)
- [msdyn_ScoreTrend](#BKMK_msdyn_ScoreTrend)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_EntityId"></a> msdyn_EntityId

|Property|Value|
|---|---|
|Description|**Entity ID of primary entity.**|
|DisplayName|**Entity ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_EntityType"></a> msdyn_EntityType

|Property|Value|
|---|---|
|Description|**Entity type of primary entity.**|
|DisplayName|**Entity type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitytype`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_Grade"></a> msdyn_Grade

|Property|Value|
|---|---|
|Description|**Grade of prediction score.**|
|DisplayName|**Grade**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_grade`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_predictivescoringgrade`|

#### msdyn_Grade Choices/Options

|Value|Label|
|---|---|
|0|**Grade A**|
|1|**Grade B**|
|2|**Grade C**|
|3|**Grade D**|

### <a name="BKMK_msdyn_ModelName"></a> msdyn_ModelName

|Property|Value|
|---|---|
|Description|**Prediction model name.**|
|DisplayName|**Model name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modelname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_PredictionID"></a> msdyn_PredictionID

|Property|Value|
|---|---|
|Description|**Prediction model definition ID.**|
|DisplayName|**Prediction ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictionid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_predictivemodelscoreId"></a> msdyn_predictivemodelscoreId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Predictive model score**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_predictivemodelscoreid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_PredictiveScoreId"></a> msdyn_PredictiveScoreId

|Property|Value|
|---|---|
|Description|**Unique identifier for Predictive Score associated with Predictive Model Score.**|
|DisplayName|**Predictive score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictivescoreid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_predictivescore|

### <a name="BKMK_msdyn_Score"></a> msdyn_Score

|Property|Value|
|---|---|
|Description|**Prediction score.**|
|DisplayName|**Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_score`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ScoredOn"></a> msdyn_ScoredOn

|Property|Value|
|---|---|
|Description|**Scored on.**|
|DisplayName|**Scored on**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_scoredon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ScoreHistory"></a> msdyn_ScoreHistory

|Property|Value|
|---|---|
|Description|**Score history.**|
|DisplayName|**Score history**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scorehistory`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ScoreReasons"></a> msdyn_ScoreReasons

|Property|Value|
|---|---|
|Description|**Score reasons.**|
|DisplayName|**Score reasons**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scorereasons`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_ScoreTrend"></a> msdyn_ScoreTrend

|Property|Value|
|---|---|
|Description|**Score trend.**|
|DisplayName|**Score trend**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scoretrend`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_predictivescoretrend`|

#### msdyn_ScoreTrend Choices/Options

|Value|Label|
|---|---|
|0|**Improving**|
|1|**Steady**|
|2|**Declining**|
|3|**Not enough info**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Predictive Model Score.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_predictivemodelscore_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Predictive Model Score.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_predictivemodelscore_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization.**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [lk_msdyn_predictivemodelscore_createdby](#BKMK_lk_msdyn_predictivemodelscore_createdby)
- [lk_msdyn_predictivemodelscore_createdonbehalfby](#BKMK_lk_msdyn_predictivemodelscore_createdonbehalfby)
- [lk_msdyn_predictivemodelscore_modifiedby](#BKMK_lk_msdyn_predictivemodelscore_modifiedby)
- [lk_msdyn_predictivemodelscore_modifiedonbehalfby](#BKMK_lk_msdyn_predictivemodelscore_modifiedonbehalfby)
- [msdyn_PS_PMS](#BKMK_msdyn_PS_PMS)
- [organization_msdyn_predictivemodelscore](#BKMK_organization_msdyn_predictivemodelscore)

### <a name="BKMK_lk_msdyn_predictivemodelscore_createdby"></a> lk_msdyn_predictivemodelscore_createdby

One-To-Many Relationship: [systemuser lk_msdyn_predictivemodelscore_createdby](systemuser.md#BKMK_lk_msdyn_predictivemodelscore_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictivemodelscore_createdonbehalfby"></a> lk_msdyn_predictivemodelscore_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_predictivemodelscore_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_predictivemodelscore_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictivemodelscore_modifiedby"></a> lk_msdyn_predictivemodelscore_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_predictivemodelscore_modifiedby](systemuser.md#BKMK_lk_msdyn_predictivemodelscore_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictivemodelscore_modifiedonbehalfby"></a> lk_msdyn_predictivemodelscore_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_predictivemodelscore_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_predictivemodelscore_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_PS_PMS"></a> msdyn_PS_PMS

One-To-Many Relationship: [msdyn_predictivescore msdyn_PS_PMS](msdyn_predictivescore.md#BKMK_msdyn_PS_PMS)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_predictivescore`|
|ReferencedAttribute|`msdyn_predictivescoreid`|
|ReferencingAttribute|`msdyn_predictivescoreid`|
|ReferencingEntityNavigationPropertyName|`msdyn_PredictiveScoreId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_predictivemodelscore"></a> organization_msdyn_predictivemodelscore

One-To-Many Relationship: [organization organization_msdyn_predictivemodelscore](organization.md#BKMK_organization_msdyn_predictivemodelscore)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_predictivemodelscore_AsyncOperations](#BKMK_msdyn_predictivemodelscore_AsyncOperations)
- [msdyn_predictivemodelscore_BulkDeleteFailures](#BKMK_msdyn_predictivemodelscore_BulkDeleteFailures)
- [msdyn_predictivemodelscore_DuplicateBaseRecord](#BKMK_msdyn_predictivemodelscore_DuplicateBaseRecord)
- [msdyn_predictivemodelscore_DuplicateMatchingRecord](#BKMK_msdyn_predictivemodelscore_DuplicateMatchingRecord)
- [msdyn_predictivemodelscore_MailboxTrackingFolders](#BKMK_msdyn_predictivemodelscore_MailboxTrackingFolders)
- [msdyn_predictivemodelscore_PrincipalObjectAttributeAccesses](#BKMK_msdyn_predictivemodelscore_PrincipalObjectAttributeAccesses)
- [msdyn_predictivemodelscore_ProcessSession](#BKMK_msdyn_predictivemodelscore_ProcessSession)
- [msdyn_predictivemodelscore_SyncErrors](#BKMK_msdyn_predictivemodelscore_SyncErrors)

### <a name="BKMK_msdyn_predictivemodelscore_AsyncOperations"></a> msdyn_predictivemodelscore_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_predictivemodelscore_AsyncOperations](asyncoperation.md#BKMK_msdyn_predictivemodelscore_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictivemodelscore_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictivemodelscore_BulkDeleteFailures"></a> msdyn_predictivemodelscore_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_predictivemodelscore_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_predictivemodelscore_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictivemodelscore_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictivemodelscore_DuplicateBaseRecord"></a> msdyn_predictivemodelscore_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_predictivemodelscore_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_predictivemodelscore_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictivemodelscore_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictivemodelscore_DuplicateMatchingRecord"></a> msdyn_predictivemodelscore_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_predictivemodelscore_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_predictivemodelscore_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictivemodelscore_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictivemodelscore_MailboxTrackingFolders"></a> msdyn_predictivemodelscore_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_predictivemodelscore_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_predictivemodelscore_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictivemodelscore_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictivemodelscore_PrincipalObjectAttributeAccesses"></a> msdyn_predictivemodelscore_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_predictivemodelscore_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_predictivemodelscore_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictivemodelscore_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictivemodelscore_ProcessSession"></a> msdyn_predictivemodelscore_ProcessSession

Many-To-One Relationship: [processsession msdyn_predictivemodelscore_ProcessSession](processsession.md#BKMK_msdyn_predictivemodelscore_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictivemodelscore_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictivemodelscore_SyncErrors"></a> msdyn_predictivemodelscore_SyncErrors

Many-To-One Relationship: [syncerror msdyn_predictivemodelscore_SyncErrors](syncerror.md#BKMK_msdyn_predictivemodelscore_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictivemodelscore_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

