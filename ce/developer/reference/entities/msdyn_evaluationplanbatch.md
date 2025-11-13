---
title: "Evaluation Plan Batch (msdyn_EvaluationPlanBatch) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Evaluation Plan Batch (msdyn_EvaluationPlanBatch) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Evaluation Plan Batch (msdyn_EvaluationPlanBatch) table/entity reference (Microsoft Dynamics 365)

Contains a batch of records to create Evaluations in Bulk for an Evaluation Plan

## Messages

The following table lists the messages for the Evaluation Plan Batch (msdyn_EvaluationPlanBatch) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_evaluationplanbatchs(*msdyn_evaluationplanbatchid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_evaluationplanbatchs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_evaluationplanbatchs(*msdyn_evaluationplanbatchid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_evaluationplanbatchs(*msdyn_evaluationplanbatchid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_evaluationplanbatchs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_evaluationplanbatchs(*msdyn_evaluationplanbatchid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_evaluationplanbatchs(*msdyn_evaluationplanbatchid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_evaluationplanbatchs(*msdyn_evaluationplanbatchid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Evaluation Plan Batch (msdyn_EvaluationPlanBatch) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Evaluation Plan Batch** |
| **DisplayCollectionName** | **Evaluation Plan Batches** |
| **SchemaName** | `msdyn_EvaluationPlanBatch` |
| **CollectionSchemaName** | `msdyn_EvaluationPlanBatchs` |
| **EntitySetName** | `msdyn_evaluationplanbatchs`|
| **LogicalName** | `msdyn_evaluationplanbatch` |
| **LogicalCollectionName** | `msdyn_evaluationplanbatchs` |
| **PrimaryIdAttribute** | `msdyn_evaluationplanbatchid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BatchProcessingCompletedOn](#BKMK_msdyn_BatchProcessingCompletedOn)
- [msdyn_BatchProcessingStartedOn](#BKMK_msdyn_BatchProcessingStartedOn)
- [msdyn_BatchSize](#BKMK_msdyn_BatchSize)
- [msdyn_CriteriaJson](#BKMK_msdyn_CriteriaJson)
- [msdyn_EvaluationPlanBatchId](#BKMK_msdyn_EvaluationPlanBatchId)
- [msdyn_evaluationplanbatchids](#BKMK_msdyn_evaluationplanbatchids)
- [msdyn_EvaluationPlanRun](#BKMK_msdyn_EvaluationPlanRun)
- [msdyn_EvaluationsCreated](#BKMK_msdyn_EvaluationsCreated)
- [msdyn_Name](#BKMK_msdyn_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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

### <a name="BKMK_msdyn_BatchProcessingCompletedOn"></a> msdyn_BatchProcessingCompletedOn

|Property|Value|
|---|---|
|Description|**Date time when batch processing is completed**|
|DisplayName|**Batch Processing Completed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_batchprocessingcompletedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_BatchProcessingStartedOn"></a> msdyn_BatchProcessingStartedOn

|Property|Value|
|---|---|
|Description|**Date and time when batch processing is started**|
|DisplayName|**Batch Processing Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_batchprocessingstartedon`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_BatchSize"></a> msdyn_BatchSize

|Property|Value|
|---|---|
|Description|**Total count of number of records in current batch**|
|DisplayName|**Batch size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_batchsize`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_CriteriaJson"></a> msdyn_CriteriaJson

|Property|Value|
|---|---|
|Description|**Evaluation Criteria JSON**|
|DisplayName|**Evaluation Criteria JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_criteriajson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_EvaluationPlanBatchId"></a> msdyn_EvaluationPlanBatchId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Evaluation Plan Batch**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationplanbatchid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_evaluationplanbatchids"></a> msdyn_evaluationplanbatchids

|Property|Value|
|---|---|
|Description|**Comma separated values of evaluation record IDs**|
|DisplayName|**Batch Ids**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationplanbatchids`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_EvaluationPlanRun"></a> msdyn_EvaluationPlanRun

|Property|Value|
|---|---|
|Description|**Lookup field for Evaluation Plan Run**|
|DisplayName|**Evaluation Plan Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationplanrun`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_evaluationplanrun|

### <a name="BKMK_msdyn_EvaluationsCreated"></a> msdyn_EvaluationsCreated

|Property|Value|
|---|---|
|Description|**Total count of number of evaluations created**|
|DisplayName|**Evaluations created**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationscreated`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|850|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Evaluation Plan Batch**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationplanbatch_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Created**<br />DefaultStatus: 1<br />InvariantName: `Created`|
|1|Label: **Completed**<br />DefaultStatus: 2<br />InvariantName: `Completed`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Evaluation Plan Batch**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationplanbatch_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Success**<br />State:1<br />TransitionData: None|
|3|Label: **Failed**<br />State:1<br />TransitionData: None|

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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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
|Description|**Unique identifier of the delegate user who created the record.**|
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

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

- [business_unit_msdyn_evaluationplanbatch](#BKMK_business_unit_msdyn_evaluationplanbatch)
- [lk_msdyn_evaluationplanbatch_createdby](#BKMK_lk_msdyn_evaluationplanbatch_createdby)
- [lk_msdyn_evaluationplanbatch_createdonbehalfby](#BKMK_lk_msdyn_evaluationplanbatch_createdonbehalfby)
- [lk_msdyn_evaluationplanbatch_modifiedby](#BKMK_lk_msdyn_evaluationplanbatch_modifiedby)
- [lk_msdyn_evaluationplanbatch_modifiedonbehalfby](#BKMK_lk_msdyn_evaluationplanbatch_modifiedonbehalfby)
- [msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun](#BKMK_msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun)
- [owner_msdyn_evaluationplanbatch](#BKMK_owner_msdyn_evaluationplanbatch)
- [team_msdyn_evaluationplanbatch](#BKMK_team_msdyn_evaluationplanbatch)
- [user_msdyn_evaluationplanbatch](#BKMK_user_msdyn_evaluationplanbatch)

### <a name="BKMK_business_unit_msdyn_evaluationplanbatch"></a> business_unit_msdyn_evaluationplanbatch

One-To-Many Relationship: [businessunit business_unit_msdyn_evaluationplanbatch](businessunit.md#BKMK_business_unit_msdyn_evaluationplanbatch)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplanbatch_createdby"></a> lk_msdyn_evaluationplanbatch_createdby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplanbatch_createdby](systemuser.md#BKMK_lk_msdyn_evaluationplanbatch_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplanbatch_createdonbehalfby"></a> lk_msdyn_evaluationplanbatch_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplanbatch_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationplanbatch_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplanbatch_modifiedby"></a> lk_msdyn_evaluationplanbatch_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplanbatch_modifiedby](systemuser.md#BKMK_lk_msdyn_evaluationplanbatch_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplanbatch_modifiedonbehalfby"></a> lk_msdyn_evaluationplanbatch_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplanbatch_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationplanbatch_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun"></a> msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun

One-To-Many Relationship: [msdyn_evaluationplanrun msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun](msdyn_evaluationplanrun.md#BKMK_msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationplanrun`|
|ReferencedAttribute|`msdyn_evaluationplanrunid`|
|ReferencingAttribute|`msdyn_evaluationplanrun`|
|ReferencingEntityNavigationPropertyName|`msdyn_EvaluationPlanRun`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_evaluationplanbatch"></a> owner_msdyn_evaluationplanbatch

One-To-Many Relationship: [owner owner_msdyn_evaluationplanbatch](owner.md#BKMK_owner_msdyn_evaluationplanbatch)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_evaluationplanbatch"></a> team_msdyn_evaluationplanbatch

One-To-Many Relationship: [team team_msdyn_evaluationplanbatch](team.md#BKMK_team_msdyn_evaluationplanbatch)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_evaluationplanbatch"></a> user_msdyn_evaluationplanbatch

One-To-Many Relationship: [systemuser user_msdyn_evaluationplanbatch](systemuser.md#BKMK_user_msdyn_evaluationplanbatch)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_evaluationplanbatch_AsyncOperations](#BKMK_msdyn_evaluationplanbatch_AsyncOperations)
- [msdyn_evaluationplanbatch_BulkDeleteFailures](#BKMK_msdyn_evaluationplanbatch_BulkDeleteFailures)
- [msdyn_evaluationplanbatch_DuplicateBaseRecord](#BKMK_msdyn_evaluationplanbatch_DuplicateBaseRecord)
- [msdyn_evaluationplanbatch_DuplicateMatchingRecord](#BKMK_msdyn_evaluationplanbatch_DuplicateMatchingRecord)
- [msdyn_evaluationplanbatch_MailboxTrackingFolders](#BKMK_msdyn_evaluationplanbatch_MailboxTrackingFolders)
- [msdyn_evaluationplanbatch_PrincipalObjectAttributeAccesses](#BKMK_msdyn_evaluationplanbatch_PrincipalObjectAttributeAccesses)
- [msdyn_evaluationplanbatch_ProcessSession](#BKMK_msdyn_evaluationplanbatch_ProcessSession)
- [msdyn_evaluationplanbatch_SyncErrors](#BKMK_msdyn_evaluationplanbatch_SyncErrors)

### <a name="BKMK_msdyn_evaluationplanbatch_AsyncOperations"></a> msdyn_evaluationplanbatch_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_evaluationplanbatch_AsyncOperations](asyncoperation.md#BKMK_msdyn_evaluationplanbatch_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanbatch_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanbatch_BulkDeleteFailures"></a> msdyn_evaluationplanbatch_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_evaluationplanbatch_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_evaluationplanbatch_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanbatch_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanbatch_DuplicateBaseRecord"></a> msdyn_evaluationplanbatch_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_evaluationplanbatch_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_evaluationplanbatch_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanbatch_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanbatch_DuplicateMatchingRecord"></a> msdyn_evaluationplanbatch_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_evaluationplanbatch_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_evaluationplanbatch_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanbatch_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanbatch_MailboxTrackingFolders"></a> msdyn_evaluationplanbatch_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_evaluationplanbatch_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_evaluationplanbatch_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanbatch_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanbatch_PrincipalObjectAttributeAccesses"></a> msdyn_evaluationplanbatch_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_evaluationplanbatch_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_evaluationplanbatch_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanbatch_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanbatch_ProcessSession"></a> msdyn_evaluationplanbatch_ProcessSession

Many-To-One Relationship: [processsession msdyn_evaluationplanbatch_ProcessSession](processsession.md#BKMK_msdyn_evaluationplanbatch_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanbatch_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanbatch_SyncErrors"></a> msdyn_evaluationplanbatch_SyncErrors

Many-To-One Relationship: [syncerror msdyn_evaluationplanbatch_SyncErrors](syncerror.md#BKMK_msdyn_evaluationplanbatch_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanbatch_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

