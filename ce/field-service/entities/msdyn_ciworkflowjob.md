---
title: "CIWorkflowJob (msdyn_ciworkflowjob) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the CIWorkflowJob (msdyn_ciworkflowjob) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# CIWorkflowJob (msdyn_ciworkflowjob) table/entity reference



## Messages

The following table lists the messages for the CIWorkflowJob (msdyn_ciworkflowjob) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_ciworkflowjobs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /msdyn_ciworkflowjobs(*msdyn_ciworkflowjobid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ciworkflowjobs(*msdyn_ciworkflowjobid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ciworkflowjobs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdyn_ciworkflowjobs(*msdyn_ciworkflowjobid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ciworkflowjobs(*msdyn_ciworkflowjobid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|


## Events

The following table lists the events for the CIWorkflowJob (msdyn_ciworkflowjob) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the CIWorkflowJob (msdyn_ciworkflowjob) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **CIWorkflowJob** |
| **DisplayCollectionName** | **CIWorkflowJobs** |
| **SchemaName** | `msdyn_ciworkflowjob` |
| **CollectionSchemaName** | `msdyn_ciworkflowjobs` |
| **EntitySetName** | `msdyn_ciworkflowjobs`|
| **LogicalName** | `msdyn_ciworkflowjob` |
| **LogicalCollectionName** | `msdyn_ciworkflowjobs` |
| **PrimaryIdAttribute** | `msdyn_ciworkflowjobid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_cancelledby](#BKMK_msdyn_cancelledby)
- [msdyn_ciworkflowjobId](#BKMK_msdyn_ciworkflowjobId)
- [msdyn_endtimestamp](#BKMK_msdyn_endtimestamp)
- [msdyn_forcerunrequested](#BKMK_msdyn_forcerunrequested)
- [msdyn_graphname](#BKMK_msdyn_graphname)
- [msdyn_graphversion](#BKMK_msdyn_graphversion)
- [msdyn_idlistserialized](#BKMK_msdyn_idlistserialized)
- [msdyn_inputrefreshmode](#BKMK_msdyn_inputrefreshmode)
- [msdyn_jobid](#BKMK_msdyn_jobid)
- [msdyn_jobstatus](#BKMK_msdyn_jobstatus)
- [msdyn_jobsubmissionkind](#BKMK_msdyn_jobsubmissionkind)
- [msdyn_jobtype](#BKMK_msdyn_jobtype)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_operationtype](#BKMK_msdyn_operationtype)
- [msdyn_optionsserialized](#BKMK_msdyn_optionsserialized)
- [msdyn_starttimestamp](#BKMK_msdyn_starttimestamp)
- [msdyn_submittedby](#BKMK_msdyn_submittedby)
- [msdyn_subtype](#BKMK_msdyn_subtype)
- [msdyn_taskidsserialized](#BKMK_msdyn_taskidsserialized)
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

### <a name="BKMK_msdyn_cancelledby"></a> msdyn_cancelledby

|Property|Value|
|---|---|
|Description||
|DisplayName|**CancelledBy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cancelledby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ciworkflowjobId"></a> msdyn_ciworkflowjobId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**CIWorkflowJob**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ciworkflowjobid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_endtimestamp"></a> msdyn_endtimestamp

|Property|Value|
|---|---|
|Description||
|DisplayName|**EndTimestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endtimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_forcerunrequested"></a> msdyn_forcerunrequested

|Property|Value|
|---|---|
|Description||
|DisplayName|**ForceRunRequested**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forcerunrequested`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_graphname"></a> msdyn_graphname

|Property|Value|
|---|---|
|Description||
|DisplayName|**GraphName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_graphname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_graphversion"></a> msdyn_graphversion

|Property|Value|
|---|---|
|Description||
|DisplayName|**GraphVersion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_graphversion`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_idlistserialized"></a> msdyn_idlistserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**IdListSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_idlistserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_inputrefreshmode"></a> msdyn_inputrefreshmode

|Property|Value|
|---|---|
|Description||
|DisplayName|**InputRefreshMode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inputrefreshmode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_jobid"></a> msdyn_jobid

|Property|Value|
|---|---|
|Description||
|DisplayName|**JobId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_jobstatus"></a> msdyn_jobstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**JobStatus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_jobsubmissionkind"></a> msdyn_jobsubmissionkind

|Property|Value|
|---|---|
|Description||
|DisplayName|**JobSubmissionKind**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobsubmissionkind`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_jobtype"></a> msdyn_jobtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**JobType**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|MaxLength|100|

### <a name="BKMK_msdyn_operationtype"></a> msdyn_operationtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**OperationType**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operationtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_optionsserialized"></a> msdyn_optionsserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**OptionsSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optionsserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_starttimestamp"></a> msdyn_starttimestamp

|Property|Value|
|---|---|
|Description||
|DisplayName|**StartTimestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_starttimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_submittedby"></a> msdyn_submittedby

|Property|Value|
|---|---|
|Description||
|DisplayName|**SubmittedBy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_submittedby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_subtype"></a> msdyn_subtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**SubType**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_taskidsserialized"></a> msdyn_taskidsserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**TaskIdsSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taskidsserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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
|Description|**Status of the ciworkflowjob**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ciworkflowjob_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ciworkflowjob**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ciworkflowjob_statuscode`|

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
|Targets||

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
|Targets||

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
|Targets||

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
|Targets||



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

