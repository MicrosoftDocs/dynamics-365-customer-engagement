---
title: "CIWorkflowTask (msdyn_ciworkflowtask) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the CIWorkflowTask (msdyn_ciworkflowtask) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# CIWorkflowTask (msdyn_ciworkflowtask) table/entity reference



## Messages

The following table lists the messages for the CIWorkflowTask (msdyn_ciworkflowtask) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_ciworkflowtasks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /msdyn_ciworkflowtasks(*msdyn_ciworkflowtaskid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ciworkflowtasks(*msdyn_ciworkflowtaskid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ciworkflowtasks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdyn_ciworkflowtasks(*msdyn_ciworkflowtaskid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ciworkflowtasks(*msdyn_ciworkflowtaskid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|


## Events

The following table lists the events for the CIWorkflowTask (msdyn_ciworkflowtask) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the CIWorkflowTask (msdyn_ciworkflowtask) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **CIWorkflowTask** |
| **DisplayCollectionName** | **CIWorkflowTasks** |
| **SchemaName** | `msdyn_ciworkflowtask` |
| **CollectionSchemaName** | `msdyn_ciworkflowtasks` |
| **EntitySetName** | `msdyn_ciworkflowtasks`|
| **LogicalName** | `msdyn_ciworkflowtask` |
| **LogicalCollectionName** | `msdyn_ciworkflowtasks` |
| **PrimaryIdAttribute** | `msdyn_ciworkflowtaskid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_additionalinfosserialized](#BKMK_msdyn_additionalinfosserialized)
- [msdyn_cierrorserialized](#BKMK_msdyn_cierrorserialized)
- [msdyn_cierrorsserialized](#BKMK_msdyn_cierrorsserialized)
- [msdyn_ciworkflowtaskId](#BKMK_msdyn_ciworkflowtaskId)
- [msdyn_endtimestamp](#BKMK_msdyn_endtimestamp)
- [msdyn_friendlyname](#BKMK_msdyn_friendlyname)
- [msdyn_graphname](#BKMK_msdyn_graphname)
- [msdyn_graphversion](#BKMK_msdyn_graphversion)
- [msdyn_identifier](#BKMK_msdyn_identifier)
- [msdyn_inputdataserialized](#BKMK_msdyn_inputdataserialized)
- [msdyn_jobidsserialized](#BKMK_msdyn_jobidsserialized)
- [msdyn_jobtype](#BKMK_msdyn_jobtype)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_nodename](#BKMK_msdyn_nodename)
- [msdyn_nodeversion](#BKMK_msdyn_nodeversion)
- [msdyn_operationtype](#BKMK_msdyn_operationtype)
- [msdyn_outputdataserialized](#BKMK_msdyn_outputdataserialized)
- [msdyn_selectionreasoncode](#BKMK_msdyn_selectionreasoncode)
- [msdyn_selectionreasondetails](#BKMK_msdyn_selectionreasondetails)
- [msdyn_starttimestamp](#BKMK_msdyn_starttimestamp)
- [msdyn_submittedtimestamp](#BKMK_msdyn_submittedtimestamp)
- [msdyn_subtype](#BKMK_msdyn_subtype)
- [msdyn_taskid](#BKMK_msdyn_taskid)
- [msdyn_taskstatus](#BKMK_msdyn_taskstatus)
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

### <a name="BKMK_msdyn_additionalinfosserialized"></a> msdyn_additionalinfosserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**AdditionalInfosSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_additionalinfosserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_cierrorserialized"></a> msdyn_cierrorserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**CIErrorSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cierrorserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_cierrorsserialized"></a> msdyn_cierrorsserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**CIErrorsSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cierrorsserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_ciworkflowtaskId"></a> msdyn_ciworkflowtaskId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**CIWorkflowTask**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ciworkflowtaskid`|
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

### <a name="BKMK_msdyn_friendlyname"></a> msdyn_friendlyname

|Property|Value|
|---|---|
|Description||
|DisplayName|**FriendlyName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_friendlyname`|
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

### <a name="BKMK_msdyn_identifier"></a> msdyn_identifier

|Property|Value|
|---|---|
|Description||
|DisplayName|**Identifier**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_identifier`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_inputdataserialized"></a> msdyn_inputdataserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**InputDataSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inputdataserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_jobidsserialized"></a> msdyn_jobidsserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**JobIdsSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobidsserialized`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_msdyn_nodename"></a> msdyn_nodename

|Property|Value|
|---|---|
|Description||
|DisplayName|**NodeName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nodename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_nodeversion"></a> msdyn_nodeversion

|Property|Value|
|---|---|
|Description||
|DisplayName|**NodeVersion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nodeversion`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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

### <a name="BKMK_msdyn_outputdataserialized"></a> msdyn_outputdataserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**OutputDataSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outputdataserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_selectionreasoncode"></a> msdyn_selectionreasoncode

|Property|Value|
|---|---|
|Description||
|DisplayName|**SelectionReasonCode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_selectionreasoncode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_selectionreasondetails"></a> msdyn_selectionreasondetails

|Property|Value|
|---|---|
|Description||
|DisplayName|**SelectionReasonDetails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_selectionreasondetails`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_msdyn_submittedtimestamp"></a> msdyn_submittedtimestamp

|Property|Value|
|---|---|
|Description||
|DisplayName|**SubmittedTimestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_submittedtimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_taskid"></a> msdyn_taskid

|Property|Value|
|---|---|
|Description||
|DisplayName|**TaskId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taskid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_taskstatus"></a> msdyn_taskstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**TaskStatus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taskstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the ciworkflowtask**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ciworkflowtask_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ciworkflowtask**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ciworkflowtask_statuscode`|

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

