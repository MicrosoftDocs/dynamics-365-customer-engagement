---
title: "Recording (msdyn_ocrecording) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Recording (msdyn_ocrecording) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Recording (msdyn_ocrecording) table/entity reference (Microsoft Dynamics 365)

Records the audio/video session

## Messages

The following table lists the messages for the Recording (msdyn_ocrecording) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocrecordings(*msdyn_ocrecordingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocrecordings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocrecordings(*msdyn_ocrecordingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocrecordings(*msdyn_ocrecordingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocrecordings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocrecordings(*msdyn_ocrecordingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocrecordings(*msdyn_ocrecordingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocrecordings(*msdyn_ocrecordingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Recording (msdyn_ocrecording) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Recording** |
| **DisplayCollectionName** | **Recordings** |
| **SchemaName** | `msdyn_ocrecording` |
| **CollectionSchemaName** | `msdyn_ocrecordings` |
| **EntitySetName** | `msdyn_ocrecordings`|
| **LogicalName** | `msdyn_ocrecording` |
| **LogicalCollectionName** | `msdyn_ocrecordings` |
| **PrimaryIdAttribute** | `msdyn_ocrecordingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_applicationid](#BKMK_msdyn_applicationid)
- [msdyn_liveworkitemid](#BKMK_msdyn_liveworkitemid)
- [msdyn_mediauri](#BKMK_msdyn_mediauri)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocrecordingId](#BKMK_msdyn_ocrecordingId)
- [msdyn_recordingtarget](#BKMK_msdyn_recordingtarget)
- [msdyn_recordingtargetIdType](#BKMK_msdyn_recordingtargetIdType)
- [msdyn_sourcelanguage](#BKMK_msdyn_sourcelanguage)
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

### <a name="BKMK_msdyn_applicationid"></a> msdyn_applicationid

|Property|Value|
|---|---|
|Description|**Unique identifier of the app that created the entity**|
|DisplayName|**Application Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_applicationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_liveworkitemid"></a> msdyn_liveworkitemid

|Property|Value|
|---|---|
|Description|**Unique Identifier of Conversation associated to the recording**|
|DisplayName|**Conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_mediauri"></a> msdyn_mediauri

|Property|Value|
|---|---|
|Description|**Media URI associated to the recording**|
|DisplayName|**Media URI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mediauri`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_ocrecordingId"></a> msdyn_ocrecordingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Recording**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocrecordingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_recordingtarget"></a> msdyn_recordingtarget

|Property|Value|
|---|---|
|Description|**Unique identifier for the target object associated with the Recording**|
|DisplayName|**Recording target entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordingtarget`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|appointment, msdyn_ocliveworkitem, phonecall|

### <a name="BKMK_msdyn_recordingtargetIdType"></a> msdyn_recordingtargetIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_recordingtargetidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_sourcelanguage"></a> msdyn_sourcelanguage

|Property|Value|
|---|---|
|Description|**Language of recording source**|
|DisplayName|**Source Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourcelanguage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_oclanguage|

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
|Description|**Status of the Recording**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocrecording_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Recording**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocrecording_statuscode`|

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
- [msdyn_recording](#BKMK_msdyn_recording)
- [msdyn_recording_Name](#BKMK_msdyn_recording_Name)
- [msdyn_recordingmetadata](#BKMK_msdyn_recordingmetadata)
- [msdyn_recordingmetadata_Name](#BKMK_msdyn_recordingmetadata_Name)
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

### <a name="BKMK_msdyn_recording"></a> msdyn_recording

|Property|Value|
|---|---|
|Description|**Recording file**|
|DisplayName|**Recording**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recording`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|524288|

### <a name="BKMK_msdyn_recording_Name"></a> msdyn_recording_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_recording_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_recordingmetadata"></a> msdyn_recordingmetadata

|Property|Value|
|---|---|
|Description|**Meta data associated to the recording**|
|DisplayName|**Recording Meta Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordingmetadata`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|16384|

### <a name="BKMK_msdyn_recordingmetadata_Name"></a> msdyn_recordingmetadata_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_recordingmetadata_name`|
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

- [business_unit_msdyn_ocrecording](#BKMK_business_unit_msdyn_ocrecording)
- [FileAttachment_msdyn_ocrecording_msdyn_recording](#BKMK_FileAttachment_msdyn_ocrecording_msdyn_recording)
- [FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata](#BKMK_FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata)
- [lk_msdyn_ocrecording_createdby](#BKMK_lk_msdyn_ocrecording_createdby)
- [lk_msdyn_ocrecording_createdonbehalfby](#BKMK_lk_msdyn_ocrecording_createdonbehalfby)
- [lk_msdyn_ocrecording_modifiedby](#BKMK_lk_msdyn_ocrecording_modifiedby)
- [lk_msdyn_ocrecording_modifiedonbehalfby](#BKMK_lk_msdyn_ocrecording_modifiedonbehalfby)
- [msdyn_appointment_msdyn_ocrecording_recordingtarget](#BKMK_msdyn_appointment_msdyn_ocrecording_recordingtarget)
- [msdyn_msdyn_oclanguage_msdyn_ocrecording_sourcelanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocrecording_sourcelanguage)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget)
- [msdyn_phonecall_msdyn_ocrecording_recordingtarget](#BKMK_msdyn_phonecall_msdyn_ocrecording_recordingtarget)
- [owner_msdyn_ocrecording](#BKMK_owner_msdyn_ocrecording)
- [team_msdyn_ocrecording](#BKMK_team_msdyn_ocrecording)
- [user_msdyn_ocrecording](#BKMK_user_msdyn_ocrecording)

### <a name="BKMK_business_unit_msdyn_ocrecording"></a> business_unit_msdyn_ocrecording

One-To-Many Relationship: [businessunit business_unit_msdyn_ocrecording](businessunit.md#BKMK_business_unit_msdyn_ocrecording)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_ocrecording_msdyn_recording"></a> FileAttachment_msdyn_ocrecording_msdyn_recording

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_ocrecording_msdyn_recording](fileattachment.md#BKMK_FileAttachment_msdyn_ocrecording_msdyn_recording)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_recording`|
|ReferencingEntityNavigationPropertyName|`msdyn_recording`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata"></a> FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata](fileattachment.md#BKMK_FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_recordingmetadata`|
|ReferencingEntityNavigationPropertyName|`msdyn_recordingmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocrecording_createdby"></a> lk_msdyn_ocrecording_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocrecording_createdby](systemuser.md#BKMK_lk_msdyn_ocrecording_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocrecording_createdonbehalfby"></a> lk_msdyn_ocrecording_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocrecording_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocrecording_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocrecording_modifiedby"></a> lk_msdyn_ocrecording_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocrecording_modifiedby](systemuser.md#BKMK_lk_msdyn_ocrecording_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocrecording_modifiedonbehalfby"></a> lk_msdyn_ocrecording_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocrecording_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocrecording_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_appointment_msdyn_ocrecording_recordingtarget"></a> msdyn_appointment_msdyn_ocrecording_recordingtarget

One-To-Many Relationship: [appointment msdyn_appointment_msdyn_ocrecording_recordingtarget](appointment.md#BKMK_msdyn_appointment_msdyn_ocrecording_recordingtarget)

|Property|Value|
|---|---|
|ReferencedEntity|`appointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_recordingtarget`|
|ReferencingEntityNavigationPropertyName|`msdyn_recordingtarget_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocrecording_sourcelanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocrecording_sourcelanguage

One-To-Many Relationship: [msdyn_oclanguage msdyn_msdyn_oclanguage_msdyn_ocrecording_sourcelanguage](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocrecording_sourcelanguage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_sourcelanguage`|
|ReferencingEntityNavigationPropertyName|`msdyn_sourcelanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkitemid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_recordingtarget`|
|ReferencingEntityNavigationPropertyName|`msdyn_recordingtarget_msdyn_liveworkitemid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_phonecall_msdyn_ocrecording_recordingtarget"></a> msdyn_phonecall_msdyn_ocrecording_recordingtarget

One-To-Many Relationship: [phonecall msdyn_phonecall_msdyn_ocrecording_recordingtarget](phonecall.md#BKMK_msdyn_phonecall_msdyn_ocrecording_recordingtarget)

|Property|Value|
|---|---|
|ReferencedEntity|`phonecall`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_recordingtarget`|
|ReferencingEntityNavigationPropertyName|`msdyn_recordingtarget_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocrecording"></a> owner_msdyn_ocrecording

One-To-Many Relationship: [owner owner_msdyn_ocrecording](owner.md#BKMK_owner_msdyn_ocrecording)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocrecording"></a> team_msdyn_ocrecording

One-To-Many Relationship: [team team_msdyn_ocrecording](team.md#BKMK_team_msdyn_ocrecording)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocrecording"></a> user_msdyn_ocrecording

One-To-Many Relationship: [systemuser user_msdyn_ocrecording](systemuser.md#BKMK_user_msdyn_ocrecording)

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

- [msdyn_msdyn_sciconversation_OCRecording_msdyn_o](#BKMK_msdyn_msdyn_sciconversation_OCRecording_msdyn_o)
- [msdyn_ocrecording_AsyncOperations](#BKMK_msdyn_ocrecording_AsyncOperations)
- [msdyn_ocrecording_BulkDeleteFailures](#BKMK_msdyn_ocrecording_BulkDeleteFailures)
- [msdyn_ocrecording_DuplicateBaseRecord](#BKMK_msdyn_ocrecording_DuplicateBaseRecord)
- [msdyn_ocrecording_DuplicateMatchingRecord](#BKMK_msdyn_ocrecording_DuplicateMatchingRecord)
- [msdyn_ocrecording_FileAttachments](#BKMK_msdyn_ocrecording_FileAttachments)
- [msdyn_ocrecording_MailboxTrackingFolders](#BKMK_msdyn_ocrecording_MailboxTrackingFolders)
- [msdyn_ocrecording_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocrecording_PrincipalObjectAttributeAccesses)
- [msdyn_ocrecording_ProcessSession](#BKMK_msdyn_ocrecording_ProcessSession)
- [msdyn_ocrecording_SyncErrors](#BKMK_msdyn_ocrecording_SyncErrors)

### <a name="BKMK_msdyn_msdyn_sciconversation_OCRecording_msdyn_o"></a> msdyn_msdyn_sciconversation_OCRecording_msdyn_o

Many-To-One Relationship: [msdyn_sciconversation msdyn_msdyn_sciconversation_OCRecording_msdyn_o](msdyn_sciconversation.md#BKMK_msdyn_msdyn_sciconversation_OCRecording_msdyn_o)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciconversation`|
|ReferencingAttribute|`msdyn_ocrecording`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_sciconversation_ocrecording_msdyn_o`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrecording_AsyncOperations"></a> msdyn_ocrecording_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocrecording_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocrecording_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrecording_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrecording_BulkDeleteFailures"></a> msdyn_ocrecording_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocrecording_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocrecording_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrecording_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrecording_DuplicateBaseRecord"></a> msdyn_ocrecording_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocrecording_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocrecording_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrecording_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrecording_DuplicateMatchingRecord"></a> msdyn_ocrecording_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocrecording_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocrecording_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrecording_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrecording_FileAttachments"></a> msdyn_ocrecording_FileAttachments

Many-To-One Relationship: [fileattachment msdyn_ocrecording_FileAttachments](fileattachment.md#BKMK_msdyn_ocrecording_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrecording_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrecording_MailboxTrackingFolders"></a> msdyn_ocrecording_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocrecording_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocrecording_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrecording_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrecording_PrincipalObjectAttributeAccesses"></a> msdyn_ocrecording_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocrecording_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocrecording_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrecording_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrecording_ProcessSession"></a> msdyn_ocrecording_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocrecording_ProcessSession](processsession.md#BKMK_msdyn_ocrecording_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrecording_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrecording_SyncErrors"></a> msdyn_ocrecording_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocrecording_SyncErrors](syncerror.md#BKMK_msdyn_ocrecording_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrecording_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

