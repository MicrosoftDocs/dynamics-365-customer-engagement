---
title: "Intent Core Evaluation Job (msdyn_intentcoreevaluationjob) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Intent Core Evaluation Job (msdyn_intentcoreevaluationjob) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Intent Core Evaluation Job (msdyn_intentcoreevaluationjob) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Intent Core Evaluation Job (msdyn_intentcoreevaluationjob) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_intentcoreevaluationjobs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_intentcoreevaluationjobs(*msdyn_intentcoreevaluationjobid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_intentcoreevaluationjobs(*msdyn_intentcoreevaluationjobid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_intentcoreevaluationjobs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_intentcoreevaluationjobs(*msdyn_intentcoreevaluationjobid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_intentcoreevaluationjobs(*msdyn_intentcoreevaluationjobid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_intentcoreevaluationjobs(*msdyn_intentcoreevaluationjobid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Intent Core Evaluation Job (msdyn_intentcoreevaluationjob) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Intent Core Evaluation Job** |
| **DisplayCollectionName** | **Intent Core Evaluation Jobs** |
| **SchemaName** | `msdyn_intentcoreevaluationjob` |
| **CollectionSchemaName** | `msdyn_intentcoreevaluationjobs` |
| **EntitySetName** | `msdyn_intentcoreevaluationjobs`|
| **LogicalName** | `msdyn_intentcoreevaluationjob` |
| **LogicalCollectionName** | `msdyn_intentcoreevaluationjobs` |
| **PrimaryIdAttribute** | `msdyn_intentcoreevaluationjobid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentservicecontext](#BKMK_msdyn_agentservicecontext)
- [msdyn_bjsjobid](#BKMK_msdyn_bjsjobid)
- [msdyn_filecontent_Name](#BKMK_msdyn_filecontent_Name)
- [msdyn_filecontentid](#BKMK_msdyn_filecontentid)
- [msdyn_insights](#BKMK_msdyn_insights)
- [msdyn_intentcoreevaluationjobId](#BKMK_msdyn_intentcoreevaluationjobId)
- [msdyn_jobresultfile_Name](#BKMK_msdyn_jobresultfile_Name)
- [msdyn_jobstatus](#BKMK_msdyn_jobstatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_organizationid](#BKMK_msdyn_organizationid)
- [msdyn_rowanalysis](#BKMK_msdyn_rowanalysis)
- [msdyn_runid](#BKMK_msdyn_runid)
- [msdyn_totalpass_group](#BKMK_msdyn_totalpass_group)
- [msdyn_totalpass_intent](#BKMK_msdyn_totalpass_intent)
- [msdyn_totalpass_negative_group](#BKMK_msdyn_totalpass_negative_group)
- [msdyn_totalpass_negative_intent](#BKMK_msdyn_totalpass_negative_intent)
- [msdyn_totalpass_positive_group](#BKMK_msdyn_totalpass_positive_group)
- [msdyn_totalpass_positive_intent](#BKMK_msdyn_totalpass_positive_intent)
- [msdyn_totalrows](#BKMK_msdyn_totalrows)
- [msdyn_totalrows_positive_group](#BKMK_msdyn_totalrows_positive_group)
- [msdyn_totalrows_positive_intent](#BKMK_msdyn_totalrows_positive_intent)
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

### <a name="BKMK_msdyn_agentservicecontext"></a> msdyn_agentservicecontext

|Property|Value|
|---|---|
|Description|**Agent service context stored so Core Services can read it from Dataverse directly**|
|DisplayName|**Agent Service Context**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentservicecontext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_bjsjobid"></a> msdyn_bjsjobid

|Property|Value|
|---|---|
|Description|**BJS job ID of the initial chunk scheduled by Core Services**|
|DisplayName|**BJS Job Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bjsjobid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_filecontent_Name"></a> msdyn_filecontent_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_filecontent_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_filecontentid"></a> msdyn_filecontentid

|Property|Value|
|---|---|
|Description|**Dataverse fileContentId returned by Core Services after first run — used for re-runs to skip re-upload**|
|DisplayName|**File Content Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_filecontentid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_insights"></a> msdyn_insights

|Property|Value|
|---|---|
|Description|**Top-level recommendation text written by Core Services**|
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_insights`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_intentcoreevaluationjobId"></a> msdyn_intentcoreevaluationjobId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Intent Core Evaluation Job**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentcoreevaluationjobid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_jobresultfile_Name"></a> msdyn_jobresultfile_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_jobresultfile_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_jobstatus"></a> msdyn_jobstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Job Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobstatus`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**User-provided evaluation name**|
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
|MaxLength|100|

### <a name="BKMK_msdyn_organizationid"></a> msdyn_organizationid

|Property|Value|
|---|---|
|Description|**Organization ID**|
|DisplayName|**Organization Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_organizationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_rowanalysis"></a> msdyn_rowanalysis

|Property|Value|
|---|---|
|Description|**Full per-row breakdown JSON**|
|DisplayName|**Row Analysis**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rowanalysis`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_runid"></a> msdyn_runid

|Property|Value|
|---|---|
|Description|**Run identifier for this evaluation execution**|
|DisplayName|**Run Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_totalpass_group"></a> msdyn_totalpass_group

|Property|Value|
|---|---|
|Description|**Total rows that passed (expected\_group == matched\_group)**|
|DisplayName|**Total Pass Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalpass_group`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_totalpass_intent"></a> msdyn_totalpass_intent

|Property|Value|
|---|---|
|Description|**Total rows that passed (expected\_intent == matched\_intent && expected\_group == matched\_group)**|
|DisplayName|**Total Pass Intent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalpass_intent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_totalpass_negative_group"></a> msdyn_totalpass_negative_group

|Property|Value|
|---|---|
|Description|**Total rows that passed for negative groups (expected\_group and matched\_group are both null or empty)**|
|DisplayName|**Total Pass Negative Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalpass_negative_group`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_totalpass_negative_intent"></a> msdyn_totalpass_negative_intent

|Property|Value|
|---|---|
|Description|**Total rows that passed for negative intents (expected\_intent and matched\_intent are both null or empty)**|
|DisplayName|**Total Pass Negative Intent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalpass_negative_intent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_totalpass_positive_group"></a> msdyn_totalpass_positive_group

|Property|Value|
|---|---|
|Description|**Total rows that passed for positive groups (expected\_group == matched\_group && expected\_group not null or empty)**|
|DisplayName|**Total Pass Positive Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalpass_positive_group`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_totalpass_positive_intent"></a> msdyn_totalpass_positive_intent

|Property|Value|
|---|---|
|Description|**Total rows that passed for positive intents (expected\_intent == matched\_intent && expected\_intent not null or empty)**|
|DisplayName|**Total Pass Positive Intent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalpass_positive_intent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_totalrows"></a> msdyn_totalrows

|Property|Value|
|---|---|
|Description|**Total conversations processed**|
|DisplayName|**Total Rows**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalrows`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_totalrows_positive_group"></a> msdyn_totalrows_positive_group

|Property|Value|
|---|---|
|Description|**Total conversations processed for positive groups (expected\_group is not null or empty)**|
|DisplayName|**Total Rows Positive Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalrows_positive_group`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_totalrows_positive_intent"></a> msdyn_totalrows_positive_intent

|Property|Value|
|---|---|
|Description|**Total conversations processed for positive intents (expected\_intent is not null or empty)**|
|DisplayName|**Total Rows Positive Intent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalrows_positive_intent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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
|Description|**Status of the msdyn\_intentcoreevaluationjob**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentcoreevaluationjob_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the msdyn\_intentcoreevaluationjob**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentcoreevaluationjob_statuscode`|

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
- [msdyn_filecontent](#BKMK_msdyn_filecontent)
- [msdyn_jobresultfile](#BKMK_msdyn_jobresultfile)
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

### <a name="BKMK_msdyn_filecontent"></a> msdyn_filecontent

|Property|Value|
|---|---|
|Description|**CSV file uploaded by UX — read by Core Services at execution time**|
|DisplayName|**File Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_filecontent`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|32768|

### <a name="BKMK_msdyn_jobresultfile"></a> msdyn_jobresultfile

|Property|Value|
|---|---|
|Description|**Result output file written by Core Services after processing**|
|DisplayName|**Job Result File**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobresultfile`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|32768|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
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

- [FileAttachment_msdyn_intentcoreevaluationjob_msdyn_filecontent](#BKMK_FileAttachment_msdyn_intentcoreevaluationjob_msdyn_filecontent)
- [FileAttachment_msdyn_intentcoreevaluationjob_msdyn_jobresultfile](#BKMK_FileAttachment_msdyn_intentcoreevaluationjob_msdyn_jobresultfile)
- [lk_msdyn_intentcoreevaluationjob_createdby](#BKMK_lk_msdyn_intentcoreevaluationjob_createdby)
- [lk_msdyn_intentcoreevaluationjob_createdonbehalfby](#BKMK_lk_msdyn_intentcoreevaluationjob_createdonbehalfby)
- [lk_msdyn_intentcoreevaluationjob_modifiedby](#BKMK_lk_msdyn_intentcoreevaluationjob_modifiedby)
- [lk_msdyn_intentcoreevaluationjob_modifiedonbehalfby](#BKMK_lk_msdyn_intentcoreevaluationjob_modifiedonbehalfby)
- [organization_msdyn_intentcoreevaluationjob](#BKMK_organization_msdyn_intentcoreevaluationjob)

### <a name="BKMK_FileAttachment_msdyn_intentcoreevaluationjob_msdyn_filecontent"></a> FileAttachment_msdyn_intentcoreevaluationjob_msdyn_filecontent

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_intentcoreevaluationjob_msdyn_filecontent](fileattachment.md#BKMK_FileAttachment_msdyn_intentcoreevaluationjob_msdyn_filecontent)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_filecontent`|
|ReferencingEntityNavigationPropertyName|`msdyn_filecontent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_intentcoreevaluationjob_msdyn_jobresultfile"></a> FileAttachment_msdyn_intentcoreevaluationjob_msdyn_jobresultfile

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_intentcoreevaluationjob_msdyn_jobresultfile](fileattachment.md#BKMK_FileAttachment_msdyn_intentcoreevaluationjob_msdyn_jobresultfile)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_jobresultfile`|
|ReferencingEntityNavigationPropertyName|`msdyn_jobresultfile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentcoreevaluationjob_createdby"></a> lk_msdyn_intentcoreevaluationjob_createdby

One-To-Many Relationship: [systemuser lk_msdyn_intentcoreevaluationjob_createdby](systemuser.md#BKMK_lk_msdyn_intentcoreevaluationjob_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentcoreevaluationjob_createdonbehalfby"></a> lk_msdyn_intentcoreevaluationjob_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentcoreevaluationjob_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_intentcoreevaluationjob_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentcoreevaluationjob_modifiedby"></a> lk_msdyn_intentcoreevaluationjob_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_intentcoreevaluationjob_modifiedby](systemuser.md#BKMK_lk_msdyn_intentcoreevaluationjob_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentcoreevaluationjob_modifiedonbehalfby"></a> lk_msdyn_intentcoreevaluationjob_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentcoreevaluationjob_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_intentcoreevaluationjob_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_intentcoreevaluationjob"></a> organization_msdyn_intentcoreevaluationjob

One-To-Many Relationship: [organization organization_msdyn_intentcoreevaluationjob](organization.md#BKMK_organization_msdyn_intentcoreevaluationjob)

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

- [msdyn_evaluationrunconfig_jobid_msdyn_intentcoreevaluationjob](#BKMK_msdyn_evaluationrunconfig_jobid_msdyn_intentcoreevaluationjob)
- [msdyn_intentcoreevaluationjob_AsyncOperations](#BKMK_msdyn_intentcoreevaluationjob_AsyncOperations)
- [msdyn_intentcoreevaluationjob_BulkDeleteFailures](#BKMK_msdyn_intentcoreevaluationjob_BulkDeleteFailures)
- [msdyn_intentcoreevaluationjob_FileAttachments](#BKMK_msdyn_intentcoreevaluationjob_FileAttachments)
- [msdyn_intentcoreevaluationjob_MailboxTrackingFolders](#BKMK_msdyn_intentcoreevaluationjob_MailboxTrackingFolders)
- [msdyn_intentcoreevaluationjob_PrincipalObjectAttributeAccesses](#BKMK_msdyn_intentcoreevaluationjob_PrincipalObjectAttributeAccesses)
- [msdyn_intentcoreevaluationjob_ProcessSession](#BKMK_msdyn_intentcoreevaluationjob_ProcessSession)
- [msdyn_intentcoreevaluationjob_SyncErrors](#BKMK_msdyn_intentcoreevaluationjob_SyncErrors)

### <a name="BKMK_msdyn_evaluationrunconfig_jobid_msdyn_intentcoreevaluationjob"></a> msdyn_evaluationrunconfig_jobid_msdyn_intentcoreevaluationjob

Many-To-One Relationship: [msdyn_evaluationrunconfig msdyn_evaluationrunconfig_jobid_msdyn_intentcoreevaluationjob](msdyn_evaluationrunconfig.md#BKMK_msdyn_evaluationrunconfig_jobid_msdyn_intentcoreevaluationjob)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationrunconfig`|
|ReferencingAttribute|`msdyn_jobid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationrunconfig_jobid_msdyn_intentcoreevaluationjob`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentcoreevaluationjob_AsyncOperations"></a> msdyn_intentcoreevaluationjob_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_intentcoreevaluationjob_AsyncOperations](asyncoperation.md#BKMK_msdyn_intentcoreevaluationjob_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentcoreevaluationjob_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentcoreevaluationjob_BulkDeleteFailures"></a> msdyn_intentcoreevaluationjob_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_intentcoreevaluationjob_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_intentcoreevaluationjob_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentcoreevaluationjob_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentcoreevaluationjob_FileAttachments"></a> msdyn_intentcoreevaluationjob_FileAttachments

Many-To-One Relationship: [fileattachment msdyn_intentcoreevaluationjob_FileAttachments](fileattachment.md#BKMK_msdyn_intentcoreevaluationjob_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentcoreevaluationjob_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentcoreevaluationjob_MailboxTrackingFolders"></a> msdyn_intentcoreevaluationjob_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_intentcoreevaluationjob_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_intentcoreevaluationjob_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentcoreevaluationjob_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentcoreevaluationjob_PrincipalObjectAttributeAccesses"></a> msdyn_intentcoreevaluationjob_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_intentcoreevaluationjob_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_intentcoreevaluationjob_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentcoreevaluationjob_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentcoreevaluationjob_ProcessSession"></a> msdyn_intentcoreevaluationjob_ProcessSession

Many-To-One Relationship: [processsession msdyn_intentcoreevaluationjob_ProcessSession](processsession.md#BKMK_msdyn_intentcoreevaluationjob_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentcoreevaluationjob_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentcoreevaluationjob_SyncErrors"></a> msdyn_intentcoreevaluationjob_SyncErrors

Many-To-One Relationship: [syncerror msdyn_intentcoreevaluationjob_SyncErrors](syncerror.md#BKMK_msdyn_intentcoreevaluationjob_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentcoreevaluationjob_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

