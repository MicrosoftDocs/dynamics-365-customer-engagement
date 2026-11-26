---
title: "Screen Recording (msdyn_ScreenRecording) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Screen Recording (msdyn_ScreenRecording) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Screen Recording (msdyn_ScreenRecording) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Screen Recording (msdyn_ScreenRecording) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_screenrecordings(*msdyn_screenrecordingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_screenrecordings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_screenrecordings(*msdyn_screenrecordingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_screenrecordings(*msdyn_screenrecordingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_screenrecordings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_screenrecordings(*msdyn_screenrecordingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_screenrecordings(*msdyn_screenrecordingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_screenrecordings(*msdyn_screenrecordingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Screen Recording (msdyn_ScreenRecording) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Screen Recording** |
| **DisplayCollectionName** | **Screen Recordings** |
| **SchemaName** | `msdyn_ScreenRecording` |
| **CollectionSchemaName** | `msdyn_ScreenRecordings` |
| **EntitySetName** | `msdyn_screenrecordings`|
| **LogicalName** | `msdyn_screenrecording` |
| **LogicalCollectionName** | `msdyn_screenrecordings` |
| **PrimaryIdAttribute** | `msdyn_screenrecordingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_ScreenRecordedAgent](#BKMK_msdyn_ScreenRecordedAgent)
- [msdyn_ScreenRecordingDurationInMinutes](#BKMK_msdyn_ScreenRecordingDurationInMinutes)
- [msdyn_ScreenRecordingEndTime](#BKMK_msdyn_ScreenRecordingEndTime)
- [msdyn_ScreenRecordingId](#BKMK_msdyn_ScreenRecordingId)
- [msdyn_ScreenRecordingMetadata](#BKMK_msdyn_ScreenRecordingMetadata)
- [msdyn_ScreenRecordingSessionType](#BKMK_msdyn_ScreenRecordingSessionType)
- [msdyn_ScreenRecordingStartTime](#BKMK_msdyn_ScreenRecordingStartTime)
- [msdyn_ScreenRecordingUploadStatus](#BKMK_msdyn_ScreenRecordingUploadStatus)
- [msdyn_UploadDiagnosticMessage](#BKMK_msdyn_UploadDiagnosticMessage)
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

### <a name="BKMK_msdyn_ScreenRecordedAgent"></a> msdyn_ScreenRecordedAgent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordedagent`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_ScreenRecordingDurationInMinutes"></a> msdyn_ScreenRecordingDurationInMinutes

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recording Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordingdurationinminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ScreenRecordingEndTime"></a> msdyn_ScreenRecordingEndTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**ScreenRecordingEndTime**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordingendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ScreenRecordingId"></a> msdyn_ScreenRecordingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ScreenRecording**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ScreenRecordingMetadata"></a> msdyn_ScreenRecordingMetadata

|Property|Value|
|---|---|
|Description||
|DisplayName|**ScreenRecordingMetadata**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordingmetadata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_ScreenRecordingSessionType"></a> msdyn_ScreenRecordingSessionType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Session type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordingsessiontype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_screenrecordingsessiontype`|

#### msdyn_ScreenRecordingSessionType Choices/Options

|Value|Label|
|---|---|
|100000000|**Manual**|
|100000001|**Automatic**|

### <a name="BKMK_msdyn_ScreenRecordingStartTime"></a> msdyn_ScreenRecordingStartTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recording start time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordingstarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ScreenRecordingUploadStatus"></a> msdyn_ScreenRecordingUploadStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**ScreenRecordingUploadStatus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordinguploadstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_screenrecordinguploadstatus`|

#### msdyn_ScreenRecordingUploadStatus Choices/Options

|Value|Label|
|---|---|
|100000000|**Success**|
|100000001|**Failed**|
|100000002|**In-Progress**|

### <a name="BKMK_msdyn_UploadDiagnosticMessage"></a> msdyn_UploadDiagnosticMessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**UploadDiagnosticMessage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_uploaddiagnosticmessage`|
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
|Description|**Status of the ScreenRecording**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_screenrecording_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ScreenRecording**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_screenrecording_statuscode`|

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
- [msdyn_ScreenRecordingFile](#BKMK_msdyn_ScreenRecordingFile)
- [msdyn_ScreenRecordingFile_Name](#BKMK_msdyn_ScreenRecordingFile_Name)
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

### <a name="BKMK_msdyn_ScreenRecordingFile"></a> msdyn_ScreenRecordingFile

|Property|Value|
|---|---|
|Description||
|DisplayName|**ScreenRecordingFile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordingfile`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|10485760|

### <a name="BKMK_msdyn_ScreenRecordingFile_Name"></a> msdyn_ScreenRecordingFile_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_screenrecordingfile_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

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

- [business_unit_msdyn_screenrecording](#BKMK_business_unit_msdyn_screenrecording)
- [FileAttachment_msdyn_ScreenRecording_msdyn_ScreenRecordingFile](#BKMK_FileAttachment_msdyn_ScreenRecording_msdyn_ScreenRecordingFile)
- [lk_msdyn_screenrecording_createdby](#BKMK_lk_msdyn_screenrecording_createdby)
- [lk_msdyn_screenrecording_createdonbehalfby](#BKMK_lk_msdyn_screenrecording_createdonbehalfby)
- [lk_msdyn_screenrecording_modifiedby](#BKMK_lk_msdyn_screenrecording_modifiedby)
- [lk_msdyn_screenrecording_modifiedonbehalfby](#BKMK_lk_msdyn_screenrecording_modifiedonbehalfby)
- [msdyn_screenrecording_ScreenRecordedAgent_systemuser](#BKMK_msdyn_screenrecording_ScreenRecordedAgent_systemuser)
- [owner_msdyn_screenrecording](#BKMK_owner_msdyn_screenrecording)
- [team_msdyn_screenrecording](#BKMK_team_msdyn_screenrecording)
- [user_msdyn_screenrecording](#BKMK_user_msdyn_screenrecording)

### <a name="BKMK_business_unit_msdyn_screenrecording"></a> business_unit_msdyn_screenrecording

One-To-Many Relationship: [businessunit business_unit_msdyn_screenrecording](businessunit.md#BKMK_business_unit_msdyn_screenrecording)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_ScreenRecording_msdyn_ScreenRecordingFile"></a> FileAttachment_msdyn_ScreenRecording_msdyn_ScreenRecordingFile

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_ScreenRecording_msdyn_ScreenRecordingFile](fileattachment.md#BKMK_FileAttachment_msdyn_ScreenRecording_msdyn_ScreenRecordingFile)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_screenrecordingfile`|
|ReferencingEntityNavigationPropertyName|`msdyn_screenrecordingfile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_screenrecording_createdby"></a> lk_msdyn_screenrecording_createdby

One-To-Many Relationship: [systemuser lk_msdyn_screenrecording_createdby](systemuser.md#BKMK_lk_msdyn_screenrecording_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_screenrecording_createdonbehalfby"></a> lk_msdyn_screenrecording_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_screenrecording_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_screenrecording_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_screenrecording_modifiedby"></a> lk_msdyn_screenrecording_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_screenrecording_modifiedby](systemuser.md#BKMK_lk_msdyn_screenrecording_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_screenrecording_modifiedonbehalfby"></a> lk_msdyn_screenrecording_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_screenrecording_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_screenrecording_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_screenrecording_ScreenRecordedAgent_systemuser"></a> msdyn_screenrecording_ScreenRecordedAgent_systemuser

One-To-Many Relationship: [systemuser msdyn_screenrecording_ScreenRecordedAgent_systemuser](systemuser.md#BKMK_msdyn_screenrecording_ScreenRecordedAgent_systemuser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_screenrecordedagent`|
|ReferencingEntityNavigationPropertyName|`msdyn_ScreenRecordedAgent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_screenrecording"></a> owner_msdyn_screenrecording

One-To-Many Relationship: [owner owner_msdyn_screenrecording](owner.md#BKMK_owner_msdyn_screenrecording)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_screenrecording"></a> team_msdyn_screenrecording

One-To-Many Relationship: [team team_msdyn_screenrecording](team.md#BKMK_team_msdyn_screenrecording)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_screenrecording"></a> user_msdyn_screenrecording

One-To-Many Relationship: [systemuser user_msdyn_screenrecording](systemuser.md#BKMK_user_msdyn_screenrecording)

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

- [msdyn_screenrecording_AsyncOperations](#BKMK_msdyn_screenrecording_AsyncOperations)
- [msdyn_screenrecording_BulkDeleteFailures](#BKMK_msdyn_screenrecording_BulkDeleteFailures)
- [msdyn_screenrecording_DuplicateBaseRecord](#BKMK_msdyn_screenrecording_DuplicateBaseRecord)
- [msdyn_screenrecording_DuplicateMatchingRecord](#BKMK_msdyn_screenrecording_DuplicateMatchingRecord)
- [msdyn_screenrecording_FileAttachments](#BKMK_msdyn_screenrecording_FileAttachments)
- [msdyn_screenrecording_MailboxTrackingFolders](#BKMK_msdyn_screenrecording_MailboxTrackingFolders)
- [msdyn_screenrecording_PrincipalObjectAttributeAccesses](#BKMK_msdyn_screenrecording_PrincipalObjectAttributeAccesses)
- [msdyn_screenrecording_ProcessSession](#BKMK_msdyn_screenrecording_ProcessSession)
- [msdyn_screenrecording_SyncErrors](#BKMK_msdyn_screenrecording_SyncErrors)
- [msdyn_screenrecordinglink_ScreenRecording_msdyn_screenrecording](#BKMK_msdyn_screenrecordinglink_ScreenRecording_msdyn_screenrecording)

### <a name="BKMK_msdyn_screenrecording_AsyncOperations"></a> msdyn_screenrecording_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_screenrecording_AsyncOperations](asyncoperation.md#BKMK_msdyn_screenrecording_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecording_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_screenrecording_BulkDeleteFailures"></a> msdyn_screenrecording_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_screenrecording_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_screenrecording_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecording_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_screenrecording_DuplicateBaseRecord"></a> msdyn_screenrecording_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_screenrecording_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_screenrecording_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecording_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_screenrecording_DuplicateMatchingRecord"></a> msdyn_screenrecording_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_screenrecording_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_screenrecording_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecording_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_screenrecording_FileAttachments"></a> msdyn_screenrecording_FileAttachments

Many-To-One Relationship: [fileattachment msdyn_screenrecording_FileAttachments](fileattachment.md#BKMK_msdyn_screenrecording_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecording_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_screenrecording_MailboxTrackingFolders"></a> msdyn_screenrecording_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_screenrecording_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_screenrecording_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecording_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_screenrecording_PrincipalObjectAttributeAccesses"></a> msdyn_screenrecording_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_screenrecording_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_screenrecording_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecording_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_screenrecording_ProcessSession"></a> msdyn_screenrecording_ProcessSession

Many-To-One Relationship: [processsession msdyn_screenrecording_ProcessSession](processsession.md#BKMK_msdyn_screenrecording_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecording_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_screenrecording_SyncErrors"></a> msdyn_screenrecording_SyncErrors

Many-To-One Relationship: [syncerror msdyn_screenrecording_SyncErrors](syncerror.md#BKMK_msdyn_screenrecording_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecording_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_screenrecordinglink_ScreenRecording_msdyn_screenrecording"></a> msdyn_screenrecordinglink_ScreenRecording_msdyn_screenrecording

Many-To-One Relationship: [msdyn_screenrecordinglink msdyn_screenrecordinglink_ScreenRecording_msdyn_screenrecording](msdyn_screenrecordinglink.md#BKMK_msdyn_screenrecordinglink_ScreenRecording_msdyn_screenrecording)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_screenrecordinglink`|
|ReferencingAttribute|`msdyn_screenrecording`|
|ReferencedEntityNavigationPropertyName|`msdyn_screenrecordinglink_ScreenRecording_msdyn_screenrecording`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

