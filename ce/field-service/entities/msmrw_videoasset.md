---
title: "Video (msmrw_videoasset) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Video (msmrw_videoasset) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Video (msmrw_videoasset) table/entity reference

Stores a video file and information associated with that video file.

## Messages

The following table lists the messages for the Video (msmrw_videoasset) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msmrw_videoassets(*msmrw_videoassetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msmrw_videoassets<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msmrw_videoassets(*msmrw_videoassetid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msmrw_BatchConvertVideoSchema`<br />Event: False |**msmrw_BatchConvertVideoSchema action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `msmrw_Upgradevideoschema`<br />Event: False |**msmrw_Upgradevideoschema action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msmrw_videoassets(*msmrw_videoassetid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msmrw_videoassets<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msmrw_videoassets(*msmrw_videoassetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msmrw_videoassets(*msmrw_videoassetid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msmrw_videoassets(*msmrw_videoassetid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Video (msmrw_videoasset) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Video (msmrw_videoasset) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Video** |
| **DisplayCollectionName** | **Videos** |
| **SchemaName** | `msmrw_videoasset` |
| **CollectionSchemaName** | `msmrw_videoassets` |
| **EntitySetName** | `msmrw_videoassets`|
| **LogicalName** | `msmrw_videoasset` |
| **LogicalCollectionName** | `msmrw_videoassets` |
| **PrimaryIdAttribute** | `msmrw_videoassetid` |
| **PrimaryNameAttribute** |`msmrw_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ParentFolderId](#BKMK_msdyn_ParentFolderId)
- [msmrw_FileFormat](#BKMK_msmrw_FileFormat)
- [msmrw_name](#BKMK_msmrw_name)
- [msmrw_SchemaVersion](#BKMK_msmrw_SchemaVersion)
- [msmrw_videoassetId](#BKMK_msmrw_videoassetId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Thumbnail**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|True|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|30720|
|MaxWidth|144|

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

### <a name="BKMK_msdyn_ParentFolderId"></a> msdyn_ParentFolderId

|Property|Value|
|---|---|
|Description|**Reference to the parent folder for this video asset.**|
|DisplayName|**Parent Folder**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentfolderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_mrfolder|

### <a name="BKMK_msmrw_FileFormat"></a> msmrw_FileFormat

|Property|Value|
|---|---|
|Description|**Specifies the file format of the video (Can be set to: .mp4, .mov, .wmv).**|
|DisplayName|**File Format**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_fileformat`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msmrw_videoasset_msmrw_fileformat`|

#### msmrw_FileFormat Choices/Options

|Value|Label|
|---|---|
|4|**wmv**|
|6|**mp4**|
|7|**mov**|

### <a name="BKMK_msmrw_name"></a> msmrw_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_SchemaVersion"></a> msmrw_SchemaVersion

|Property|Value|
|---|---|
|Description|**The schema version for this record.**|
|DisplayName|**Schema Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_schemaversion`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msmrw_videoassetId"></a> msmrw_videoassetId

|Property|Value|
|---|---|
|Description|**Unique identifier for the video.**|
|DisplayName|**Video**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_videoassetid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Video**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_videoasset_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Video**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_videoasset_statuscode`|

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
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msmrw_File](#BKMK_msmrw_File)
- [msmrw_File_Name](#BKMK_msmrw_File_Name)
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

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msmrw_File"></a> msmrw_File

|Property|Value|
|---|---|
|Description|**The video file.**|
|DisplayName|**File**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_file`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_msmrw_File_Name"></a> msmrw_File_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_file_name`|
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

- [business_unit_msmrw_videoasset](#BKMK_business_unit_msmrw_videoasset)
- [FileAttachment_msmrw_videoasset_msmrw_File](#BKMK_FileAttachment_msmrw_videoasset_msmrw_File)
- [lk_msmrw_videoasset_createdby](#BKMK_lk_msmrw_videoasset_createdby)
- [lk_msmrw_videoasset_createdonbehalfby](#BKMK_lk_msmrw_videoasset_createdonbehalfby)
- [lk_msmrw_videoasset_modifiedby](#BKMK_lk_msmrw_videoasset_modifiedby)
- [lk_msmrw_videoasset_modifiedonbehalfby](#BKMK_lk_msmrw_videoasset_modifiedonbehalfby)
- [msdyn_msmrw_videoasset_parentfolderid_msdyn_mrf](#BKMK_msdyn_msmrw_videoasset_parentfolderid_msdyn_mrf)
- [owner_msmrw_videoasset](#BKMK_owner_msmrw_videoasset)
- [team_msmrw_videoasset](#BKMK_team_msmrw_videoasset)
- [user_msmrw_videoasset](#BKMK_user_msmrw_videoasset)

### <a name="BKMK_business_unit_msmrw_videoasset"></a> business_unit_msmrw_videoasset

One-To-Many Relationship: [businessunit business_unit_msmrw_videoasset](businessunit.md#BKMK_business_unit_msmrw_videoasset)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msmrw_videoasset_msmrw_File"></a> FileAttachment_msmrw_videoasset_msmrw_File

One-To-Many Relationship: [fileattachment FileAttachment_msmrw_videoasset_msmrw_File](fileattachment.md#BKMK_FileAttachment_msmrw_videoasset_msmrw_File)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msmrw_file`|
|ReferencingEntityNavigationPropertyName|`msmrw_file`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_videoasset_createdby"></a> lk_msmrw_videoasset_createdby

One-To-Many Relationship: [systemuser lk_msmrw_videoasset_createdby](systemuser.md#BKMK_lk_msmrw_videoasset_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_videoasset_createdonbehalfby"></a> lk_msmrw_videoasset_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_videoasset_createdonbehalfby](systemuser.md#BKMK_lk_msmrw_videoasset_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_videoasset_modifiedby"></a> lk_msmrw_videoasset_modifiedby

One-To-Many Relationship: [systemuser lk_msmrw_videoasset_modifiedby](systemuser.md#BKMK_lk_msmrw_videoasset_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_videoasset_modifiedonbehalfby"></a> lk_msmrw_videoasset_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_videoasset_modifiedonbehalfby](systemuser.md#BKMK_lk_msmrw_videoasset_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msmrw_videoasset_parentfolderid_msdyn_mrf"></a> msdyn_msmrw_videoasset_parentfolderid_msdyn_mrf

One-To-Many Relationship: [msdyn_mrfolder msdyn_msmrw_videoasset_parentfolderid_msdyn_mrf](msdyn_mrfolder.md#BKMK_msdyn_msmrw_videoasset_parentfolderid_msdyn_mrf)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mrfolder`|
|ReferencedAttribute|`msdyn_mrfolderid`|
|ReferencingAttribute|`msdyn_parentfolderid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentFolderId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msmrw_videoasset"></a> owner_msmrw_videoasset

One-To-Many Relationship: [owner owner_msmrw_videoasset](owner.md#BKMK_owner_msmrw_videoasset)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msmrw_videoasset"></a> team_msmrw_videoasset

One-To-Many Relationship: [team team_msmrw_videoasset](team.md#BKMK_team_msmrw_videoasset)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msmrw_videoasset"></a> user_msmrw_videoasset

One-To-Many Relationship: [systemuser user_msmrw_videoasset](systemuser.md#BKMK_user_msmrw_videoasset)

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

- [msmrw_GuideStep_Video_msmrw_videoasset](#BKMK_msmrw_GuideStep_Video_msmrw_videoasset)
- [msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo](#BKMK_msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo)
- [msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo](#BKMK_msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo)
- [msmrw_videoasset_Annotations](#BKMK_msmrw_videoasset_Annotations)
- [msmrw_videoasset_AsyncOperations](#BKMK_msmrw_videoasset_AsyncOperations)
- [msmrw_videoasset_BulkDeleteFailures](#BKMK_msmrw_videoasset_BulkDeleteFailures)
- [msmrw_videoasset_DuplicateBaseRecord](#BKMK_msmrw_videoasset_DuplicateBaseRecord)
- [msmrw_videoasset_DuplicateMatchingRecord](#BKMK_msmrw_videoasset_DuplicateMatchingRecord)
- [msmrw_videoasset_FileAttachments](#BKMK_msmrw_videoasset_FileAttachments)
- [msmrw_videoasset_MailboxTrackingFolders](#BKMK_msmrw_videoasset_MailboxTrackingFolders)
- [msmrw_videoasset_msmrw_videoasset_localized](#BKMK_msmrw_videoasset_msmrw_videoasset_localized)
- [msmrw_videoasset_PrincipalObjectAttributeAccesses](#BKMK_msmrw_videoasset_PrincipalObjectAttributeAccesses)
- [msmrw_videoasset_ProcessSession](#BKMK_msmrw_videoasset_ProcessSession)
- [msmrw_videoasset_SyncErrors](#BKMK_msmrw_videoasset_SyncErrors)

### <a name="BKMK_msmrw_GuideStep_Video_msmrw_videoasset"></a> msmrw_GuideStep_Video_msmrw_videoasset

Many-To-One Relationship: [msmrw_guidestep msmrw_GuideStep_Video_msmrw_videoasset](msmrw_guidestep.md#BKMK_msmrw_GuideStep_Video_msmrw_videoasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestep`|
|ReferencingAttribute|`msmrw_video`|
|ReferencedEntityNavigationPropertyName|`msmrw_GuideStep_Video_msmrw_videoasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo"></a> msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo

Many-To-One Relationship: [msmrw_guide msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo](msmrw_guide.md#BKMK_msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guide`|
|ReferencingAttribute|`msmrw_anchorstepvideo`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo"></a> msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo

Many-To-One Relationship: [msmrw_guide msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo](msmrw_guide.md#BKMK_msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guide`|
|ReferencingAttribute|`msmrw_completionvideo`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_Annotations"></a> msmrw_videoasset_Annotations

Many-To-One Relationship: [annotation msmrw_videoasset_Annotations](annotation.md#BKMK_msmrw_videoasset_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_AsyncOperations"></a> msmrw_videoasset_AsyncOperations

Many-To-One Relationship: [asyncoperation msmrw_videoasset_AsyncOperations](asyncoperation.md#BKMK_msmrw_videoasset_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_BulkDeleteFailures"></a> msmrw_videoasset_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msmrw_videoasset_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msmrw_videoasset_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_DuplicateBaseRecord"></a> msmrw_videoasset_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msmrw_videoasset_DuplicateBaseRecord](duplicaterecord.md#BKMK_msmrw_videoasset_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_DuplicateMatchingRecord"></a> msmrw_videoasset_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msmrw_videoasset_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msmrw_videoasset_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_FileAttachments"></a> msmrw_videoasset_FileAttachments

Many-To-One Relationship: [fileattachment msmrw_videoasset_FileAttachments](fileattachment.md#BKMK_msmrw_videoasset_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_MailboxTrackingFolders"></a> msmrw_videoasset_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msmrw_videoasset_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msmrw_videoasset_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_msmrw_videoasset_localized"></a> msmrw_videoasset_msmrw_videoasset_localized

Many-To-One Relationship: [msmrw_videoasset_localized msmrw_videoasset_msmrw_videoasset_localized](msmrw_videoasset_localized.md#BKMK_msmrw_videoasset_msmrw_videoasset_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_videoasset_localized`|
|ReferencingAttribute|`msmrw_parent_video_asset_id`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_msmrw_videoasset_localized`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_PrincipalObjectAttributeAccesses"></a> msmrw_videoasset_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msmrw_videoasset_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msmrw_videoasset_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_ProcessSession"></a> msmrw_videoasset_ProcessSession

Many-To-One Relationship: [processsession msmrw_videoasset_ProcessSession](processsession.md#BKMK_msmrw_videoasset_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_videoasset_SyncErrors"></a> msmrw_videoasset_SyncErrors

Many-To-One Relationship: [syncerror msmrw_videoasset_SyncErrors](syncerror.md#BKMK_msmrw_videoasset_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_videoasset_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

