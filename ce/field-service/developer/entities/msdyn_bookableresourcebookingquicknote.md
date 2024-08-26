---
title: "Bookable Resource Booking Quick Note (msdyn_bookableresourcebookingquicknote) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bookable Resource Booking Quick Note (msdyn_bookableresourcebookingquicknote) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bookable Resource Booking Quick Note (msdyn_bookableresourcebookingquicknote) table/entity reference



## Messages

The following table lists the messages for the Bookable Resource Booking Quick Note (msdyn_bookableresourcebookingquicknote) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_bookableresourcebookingquicknotes(*msdyn_bookableresourcebookingquicknoteid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_bookableresourcebookingquicknotes<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_bookableresourcebookingquicknotes(*msdyn_bookableresourcebookingquicknoteid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_bookableresourcebookingquicknotes(*msdyn_bookableresourcebookingquicknoteid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_bookableresourcebookingquicknotes<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_bookableresourcebookingquicknotes(*msdyn_bookableresourcebookingquicknoteid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_bookableresourcebookingquicknotes(*msdyn_bookableresourcebookingquicknoteid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_bookableresourcebookingquicknotes(*msdyn_bookableresourcebookingquicknoteid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Bookable Resource Booking Quick Note (msdyn_bookableresourcebookingquicknote) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Bookable Resource Booking Quick Note (msdyn_bookableresourcebookingquicknote) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Bookable Resource Booking Quick Note** |
| **DisplayCollectionName** | **Bookable Resource Booking Quick Notes** |
| **SchemaName** | `msdyn_bookableresourcebookingquicknote` |
| **CollectionSchemaName** | `msdyn_bookableresourcebookingquicknotes` |
| **EntitySetName** | `msdyn_bookableresourcebookingquicknotes`|
| **LogicalName** | `msdyn_bookableresourcebookingquicknote` |
| **LogicalCollectionName** | `msdyn_bookableresourcebookingquicknotes` |
| **PrimaryIdAttribute** | `msdyn_bookableresourcebookingquicknoteid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_bookableresourcebookingquicknoteId](#BKMK_msdyn_bookableresourcebookingquicknoteId)
- [msdyn_image](#BKMK_msdyn_image)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_order](#BKMK_msdyn_order)
- [msdyn_quicknote_lookup_entity](#BKMK_msdyn_quicknote_lookup_entity)
- [msdyn_text](#BKMK_msdyn_text)
- [msdyn_type](#BKMK_msdyn_type)
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

### <a name="BKMK_msdyn_bookableresourcebookingquicknoteId"></a> msdyn_bookableresourcebookingquicknoteId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Bookable Resource Booking Quick Note**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_bookableresourcebookingquicknoteid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_image"></a> msdyn_image

|Property|Value|
|---|---|
|Description|**Image stored as part of the note**|
|DisplayName|**image**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_image`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|True|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

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
|MaxLength|100|

### <a name="BKMK_msdyn_order"></a> msdyn_order

|Property|Value|
|---|---|
|Description|**Order to display note in control**|
|DisplayName|**order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_order`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_quicknote_lookup_entity"></a> msdyn_quicknote_lookup_entity

|Property|Value|
|---|---|
|Description|**Entity for storing notes related to Bookable Resource Bookings**|
|DisplayName|**Bookable Resource Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quicknote_lookup_entity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresourcebooking|

### <a name="BKMK_msdyn_text"></a> msdyn_text

|Property|Value|
|---|---|
|Description|**Text stored as part of the note**|
|DisplayName|**text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_text`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description|**Internal For Quick note pcf control actions**|
|DisplayName|**Quick note actions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_quicknote_type`|

#### msdyn_type Choices/Options

|Value|Label|
|---|---|
|100000000|**none**|
|100000001|**text**|
|100000002|**photo**|
|100000003|**video**|
|100000004|**audio**|
|100000005|**file**|

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
|Description|**Status of the Bookable Resource Booking Quick Note**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_bookableresourcebookingquicknote_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Bookable Resource Booking Quick Note**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_bookableresourcebookingquicknote_statuscode`|

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
- [msdyn_file](#BKMK_msdyn_file)
- [msdyn_file_Name](#BKMK_msdyn_file_Name)
- [msdyn_image_Timestamp](#BKMK_msdyn_image_Timestamp)
- [msdyn_image_URL](#BKMK_msdyn_image_URL)
- [msdyn_imageId](#BKMK_msdyn_imageId)
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

### <a name="BKMK_msdyn_file"></a> msdyn_file

|Property|Value|
|---|---|
|Description|**File stored as part of the note**|
|DisplayName|**file**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_file`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|32768|

### <a name="BKMK_msdyn_file_Name"></a> msdyn_file_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_file_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_image_Timestamp"></a> msdyn_image_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_image_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdyn_image_URL"></a> msdyn_image_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_image_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_imageId"></a> msdyn_imageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_imageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdyn_bookableresourcebookingquicknote](#BKMK_business_unit_msdyn_bookableresourcebookingquicknote)
- [FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file](#BKMK_FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file)
- [lk_msdyn_bookableresourcebookingquicknote_createdby](#BKMK_lk_msdyn_bookableresourcebookingquicknote_createdby)
- [lk_msdyn_bookableresourcebookingquicknote_createdonbehalfby](#BKMK_lk_msdyn_bookableresourcebookingquicknote_createdonbehalfby)
- [lk_msdyn_bookableresourcebookingquicknote_modifiedby](#BKMK_lk_msdyn_bookableresourcebookingquicknote_modifiedby)
- [lk_msdyn_bookableresourcebookingquicknote_modifiedonbehalfby](#BKMK_lk_msdyn_bookableresourcebookingquicknote_modifiedonbehalfby)
- [msdyn_bookableresourcebookingquicknote_bookableresourcebooking](#BKMK_msdyn_bookableresourcebookingquicknote_bookableresourcebooking)
- [owner_msdyn_bookableresourcebookingquicknote](#BKMK_owner_msdyn_bookableresourcebookingquicknote)
- [team_msdyn_bookableresourcebookingquicknote](#BKMK_team_msdyn_bookableresourcebookingquicknote)
- [user_msdyn_bookableresourcebookingquicknote](#BKMK_user_msdyn_bookableresourcebookingquicknote)

### <a name="BKMK_business_unit_msdyn_bookableresourcebookingquicknote"></a> business_unit_msdyn_bookableresourcebookingquicknote

One-To-Many Relationship: [businessunit business_unit_msdyn_bookableresourcebookingquicknote](businessunit.md#BKMK_business_unit_msdyn_bookableresourcebookingquicknote)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file"></a> FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file](fileattachment.md#BKMK_FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_file`|
|ReferencingEntityNavigationPropertyName|`msdyn_file`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookableresourcebookingquicknote_createdby"></a> lk_msdyn_bookableresourcebookingquicknote_createdby

One-To-Many Relationship: [systemuser lk_msdyn_bookableresourcebookingquicknote_createdby](systemuser.md#BKMK_lk_msdyn_bookableresourcebookingquicknote_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookableresourcebookingquicknote_createdonbehalfby"></a> lk_msdyn_bookableresourcebookingquicknote_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_bookableresourcebookingquicknote_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_bookableresourcebookingquicknote_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookableresourcebookingquicknote_modifiedby"></a> lk_msdyn_bookableresourcebookingquicknote_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_bookableresourcebookingquicknote_modifiedby](systemuser.md#BKMK_lk_msdyn_bookableresourcebookingquicknote_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookableresourcebookingquicknote_modifiedonbehalfby"></a> lk_msdyn_bookableresourcebookingquicknote_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_bookableresourcebookingquicknote_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_bookableresourcebookingquicknote_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_bookableresourcebooking"></a> msdyn_bookableresourcebookingquicknote_bookableresourcebooking

One-To-Many Relationship: [bookableresourcebooking msdyn_bookableresourcebookingquicknote_bookableresourcebooking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebookingquicknote_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`msdyn_quicknote_lookup_entity`|
|ReferencingEntityNavigationPropertyName|`msdyn_quicknote_lookup_entity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_bookableresourcebookingquicknote"></a> owner_msdyn_bookableresourcebookingquicknote

One-To-Many Relationship: [owner owner_msdyn_bookableresourcebookingquicknote](owner.md#BKMK_owner_msdyn_bookableresourcebookingquicknote)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_bookableresourcebookingquicknote"></a> team_msdyn_bookableresourcebookingquicknote

One-To-Many Relationship: [team team_msdyn_bookableresourcebookingquicknote](team.md#BKMK_team_msdyn_bookableresourcebookingquicknote)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_bookableresourcebookingquicknote"></a> user_msdyn_bookableresourcebookingquicknote

One-To-Many Relationship: [systemuser user_msdyn_bookableresourcebookingquicknote](systemuser.md#BKMK_user_msdyn_bookableresourcebookingquicknote)

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

- [msdyn_bookableresourcebookingquicknote_AsyncOperations](#BKMK_msdyn_bookableresourcebookingquicknote_AsyncOperations)
- [msdyn_bookableresourcebookingquicknote_BulkDeleteFailures](#BKMK_msdyn_bookableresourcebookingquicknote_BulkDeleteFailures)
- [msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord](#BKMK_msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord)
- [msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord](#BKMK_msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord)
- [msdyn_bookableresourcebookingquicknote_FileAttachments](#BKMK_msdyn_bookableresourcebookingquicknote_FileAttachments)
- [msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders](#BKMK_msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders)
- [msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses)
- [msdyn_bookableresourcebookingquicknote_ProcessSession](#BKMK_msdyn_bookableresourcebookingquicknote_ProcessSession)
- [msdyn_bookableresourcebookingquicknote_SyncErrors](#BKMK_msdyn_bookableresourcebookingquicknote_SyncErrors)

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_AsyncOperations"></a> msdyn_bookableresourcebookingquicknote_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_bookableresourcebookingquicknote_AsyncOperations](asyncoperation.md#BKMK_msdyn_bookableresourcebookingquicknote_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_BulkDeleteFailures"></a> msdyn_bookableresourcebookingquicknote_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_bookableresourcebookingquicknote_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bookableresourcebookingquicknote_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord"></a> msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord"></a> msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_FileAttachments"></a> msdyn_bookableresourcebookingquicknote_FileAttachments

Many-To-One Relationship: [fileattachment msdyn_bookableresourcebookingquicknote_FileAttachments](fileattachment.md#BKMK_msdyn_bookableresourcebookingquicknote_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders"></a> msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses"></a> msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_ProcessSession"></a> msdyn_bookableresourcebookingquicknote_ProcessSession

Many-To-One Relationship: [processsession msdyn_bookableresourcebookingquicknote_ProcessSession](processsession.md#BKMK_msdyn_bookableresourcebookingquicknote_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_SyncErrors"></a> msdyn_bookableresourcebookingquicknote_SyncErrors

Many-To-One Relationship: [syncerror msdyn_bookableresourcebookingquicknote_SyncErrors](syncerror.md#BKMK_msdyn_bookableresourcebookingquicknote_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

