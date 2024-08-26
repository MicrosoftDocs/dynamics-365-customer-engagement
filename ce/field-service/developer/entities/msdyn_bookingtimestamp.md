---
title: "Booking Timestamp (msdyn_bookingtimestamp) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Booking Timestamp (msdyn_bookingtimestamp) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Booking Timestamp (msdyn_bookingtimestamp) table/entity reference

Tracks status changes of bookings and timestamps the change of the status

## Messages

The following table lists the messages for the Booking Timestamp (msdyn_bookingtimestamp) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_bookingtimestamps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_bookingtimestamps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Booking Timestamp (msdyn_bookingtimestamp) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Booking Timestamp (msdyn_bookingtimestamp) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Booking Timestamp** |
| **DisplayCollectionName** | **Booking Timestamps** |
| **SchemaName** | `msdyn_bookingtimestamp` |
| **CollectionSchemaName** | `msdyn_bookingtimestamps` |
| **EntitySetName** | `msdyn_bookingtimestamps`|
| **LogicalName** | `msdyn_bookingtimestamp` |
| **LogicalCollectionName** | `msdyn_bookingtimestamps` |
| **PrimaryIdAttribute** | `msdyn_bookingtimestampid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_BookingStatus](#BKMK_msdyn_BookingStatus)
- [msdyn_bookingtimestampId](#BKMK_msdyn_bookingtimestampId)
- [msdyn_GenerateJournals](#BKMK_msdyn_GenerateJournals)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_TimestampSource](#BKMK_msdyn_TimestampSource)
- [msdyn_TimestampTime](#BKMK_msdyn_TimestampTime)
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
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|---|---|
|Description|**Unique identifier for Resource Booking associated with Booking Timestamp.**|
|DisplayName|**Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_booking`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|bookableresourcebooking|

### <a name="BKMK_msdyn_BookingStatus"></a> msdyn_BookingStatus

|Property|Value|
|---|---|
|Description|**Booking Status of the booking**|
|DisplayName|**Booking Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingstatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookingstatus|

### <a name="BKMK_msdyn_bookingtimestampId"></a> msdyn_bookingtimestampId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Booking Timestamp**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingtimestampid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_GenerateJournals"></a> msdyn_GenerateJournals

|Property|Value|
|---|---|
|Description|**System internal field. Indicates that journals must be generated after saving timestamp from mobile.**|
|DisplayName|**Generate Journals**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generatejournals`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookingtimestamp_msdyn_generatejournals`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
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

### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**System Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_systemstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_bookingsystemstatus`|

#### msdyn_SystemStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Scheduled**|
|690970001|**Traveling**|
|690970002|**On Break**|
|690970003|**In Progress**|
|690970004|**Completed**|
|690970005|**Canceled**|

### <a name="BKMK_msdyn_TimestampSource"></a> msdyn_TimestampSource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Timestamp Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timestampsource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_changesource`|

#### msdyn_TimestampSource Choices/Options

|Value|Label|
|---|---|
|690970000|**Desktop**|
|690970001|**Mobile**|

### <a name="BKMK_msdyn_TimestampTime"></a> msdyn_TimestampTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Timestamp Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timestamptime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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
|Description|**Status of the Booking Timestamp**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_bookingtimestamp_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Booking Timestamp**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_bookingtimestamp_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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

- [business_unit_msdyn_bookingtimestamp](#BKMK_business_unit_msdyn_bookingtimestamp)
- [lk_msdyn_bookingtimestamp_createdby](#BKMK_lk_msdyn_bookingtimestamp_createdby)
- [lk_msdyn_bookingtimestamp_createdonbehalfby](#BKMK_lk_msdyn_bookingtimestamp_createdonbehalfby)
- [lk_msdyn_bookingtimestamp_modifiedby](#BKMK_lk_msdyn_bookingtimestamp_modifiedby)
- [lk_msdyn_bookingtimestamp_modifiedonbehalfby](#BKMK_lk_msdyn_bookingtimestamp_modifiedonbehalfby)
- [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking)
- [msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus)
- [owner_msdyn_bookingtimestamp](#BKMK_owner_msdyn_bookingtimestamp)
- [team_msdyn_bookingtimestamp](#BKMK_team_msdyn_bookingtimestamp)
- [user_msdyn_bookingtimestamp](#BKMK_user_msdyn_bookingtimestamp)

### <a name="BKMK_business_unit_msdyn_bookingtimestamp"></a> business_unit_msdyn_bookingtimestamp

One-To-Many Relationship: [businessunit business_unit_msdyn_bookingtimestamp](businessunit.md#BKMK_business_unit_msdyn_bookingtimestamp)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookingtimestamp_createdby"></a> lk_msdyn_bookingtimestamp_createdby

One-To-Many Relationship: [systemuser lk_msdyn_bookingtimestamp_createdby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookingtimestamp_createdonbehalfby"></a> lk_msdyn_bookingtimestamp_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_bookingtimestamp_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookingtimestamp_modifiedby"></a> lk_msdyn_bookingtimestamp_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_bookingtimestamp_modifiedby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookingtimestamp_modifiedonbehalfby"></a> lk_msdyn_bookingtimestamp_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_bookingtimestamp_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking"></a> msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking

One-To-Many Relationship: [bookableresourcebooking msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencingEntityNavigationPropertyName|`msdyn_booking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus"></a> msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus

One-To-Many Relationship: [bookingstatus msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`bookingstatus`|
|ReferencedAttribute|`bookingstatusid`|
|ReferencingAttribute|`msdyn_bookingstatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_BookingStatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_bookingtimestamp"></a> owner_msdyn_bookingtimestamp

One-To-Many Relationship: [owner owner_msdyn_bookingtimestamp](owner.md#BKMK_owner_msdyn_bookingtimestamp)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_bookingtimestamp"></a> team_msdyn_bookingtimestamp

One-To-Many Relationship: [team team_msdyn_bookingtimestamp](team.md#BKMK_team_msdyn_bookingtimestamp)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_bookingtimestamp"></a> user_msdyn_bookingtimestamp

One-To-Many Relationship: [systemuser user_msdyn_bookingtimestamp](systemuser.md#BKMK_user_msdyn_bookingtimestamp)

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

- [msdyn_bookingtimestamp_ActivityPointers](#BKMK_msdyn_bookingtimestamp_ActivityPointers)
- [msdyn_bookingtimestamp_adx_inviteredemptions](#BKMK_msdyn_bookingtimestamp_adx_inviteredemptions)
- [msdyn_bookingtimestamp_adx_portalcomments](#BKMK_msdyn_bookingtimestamp_adx_portalcomments)
- [msdyn_bookingtimestamp_Annotations](#BKMK_msdyn_bookingtimestamp_Annotations)
- [msdyn_bookingtimestamp_Appointments](#BKMK_msdyn_bookingtimestamp_Appointments)
- [msdyn_bookingtimestamp_AsyncOperations](#BKMK_msdyn_bookingtimestamp_AsyncOperations)
- [msdyn_bookingtimestamp_BulkDeleteFailures](#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures)
- [msdyn_bookingtimestamp_chats](#BKMK_msdyn_bookingtimestamp_chats)
- [msdyn_bookingtimestamp_connections1](#BKMK_msdyn_bookingtimestamp_connections1)
- [msdyn_bookingtimestamp_connections2](#BKMK_msdyn_bookingtimestamp_connections2)
- [msdyn_bookingtimestamp_DuplicateBaseRecord](#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord)
- [msdyn_bookingtimestamp_DuplicateMatchingRecord](#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord)
- [msdyn_bookingtimestamp_Emails](#BKMK_msdyn_bookingtimestamp_Emails)
- [msdyn_bookingtimestamp_Faxes](#BKMK_msdyn_bookingtimestamp_Faxes)
- [msdyn_bookingtimestamp_Letters](#BKMK_msdyn_bookingtimestamp_Letters)
- [msdyn_bookingtimestamp_MailboxTrackingFolders](#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders)
- [msdyn_bookingtimestamp_msdyn_bookingalerts](#BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts)
- [msdyn_bookingtimestamp_msdyn_copilottranscripts](#BKMK_msdyn_bookingtimestamp_msdyn_copilottranscripts)
- [msdyn_bookingtimestamp_msdyn_ocliveworkitems](#BKMK_msdyn_bookingtimestamp_msdyn_ocliveworkitems)
- [msdyn_bookingtimestamp_msdyn_ocsessions](#BKMK_msdyn_bookingtimestamp_msdyn_ocsessions)
- [msdyn_bookingtimestamp_msfp_alerts](#BKMK_msdyn_bookingtimestamp_msfp_alerts)
- [msdyn_bookingtimestamp_msfp_surveyinvites](#BKMK_msdyn_bookingtimestamp_msfp_surveyinvites)
- [msdyn_bookingtimestamp_msfp_surveyresponses](#BKMK_msdyn_bookingtimestamp_msfp_surveyresponses)
- [msdyn_bookingtimestamp_PhoneCalls](#BKMK_msdyn_bookingtimestamp_PhoneCalls)
- [msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses)
- [msdyn_bookingtimestamp_ProcessSession](#BKMK_msdyn_bookingtimestamp_ProcessSession)
- [msdyn_bookingtimestamp_RecurringAppointmentMasters](#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters)
- [msdyn_bookingtimestamp_ServiceAppointments](#BKMK_msdyn_bookingtimestamp_ServiceAppointments)
- [msdyn_bookingtimestamp_SharePointDocumentLocations](#BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations)
- [msdyn_bookingtimestamp_SocialActivities](#BKMK_msdyn_bookingtimestamp_SocialActivities)
- [msdyn_bookingtimestamp_SyncErrors](#BKMK_msdyn_bookingtimestamp_SyncErrors)
- [msdyn_bookingtimestamp_Tasks](#BKMK_msdyn_bookingtimestamp_Tasks)

### <a name="BKMK_msdyn_bookingtimestamp_ActivityPointers"></a> msdyn_bookingtimestamp_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_bookingtimestamp_ActivityPointers](activitypointer.md#BKMK_msdyn_bookingtimestamp_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_adx_inviteredemptions"></a> msdyn_bookingtimestamp_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_bookingtimestamp_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_bookingtimestamp_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_adx_portalcomments"></a> msdyn_bookingtimestamp_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_bookingtimestamp_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_bookingtimestamp_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_Annotations"></a> msdyn_bookingtimestamp_Annotations

Many-To-One Relationship: [annotation msdyn_bookingtimestamp_Annotations](annotation.md#BKMK_msdyn_bookingtimestamp_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_Appointments"></a> msdyn_bookingtimestamp_Appointments

Many-To-One Relationship: [appointment msdyn_bookingtimestamp_Appointments](appointment.md#BKMK_msdyn_bookingtimestamp_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_AsyncOperations"></a> msdyn_bookingtimestamp_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_bookingtimestamp_AsyncOperations](asyncoperation.md#BKMK_msdyn_bookingtimestamp_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_BulkDeleteFailures"></a> msdyn_bookingtimestamp_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_bookingtimestamp_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_chats"></a> msdyn_bookingtimestamp_chats

Many-To-One Relationship: [chat msdyn_bookingtimestamp_chats](chat.md#BKMK_msdyn_bookingtimestamp_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_connections1"></a> msdyn_bookingtimestamp_connections1

Many-To-One Relationship: [connection msdyn_bookingtimestamp_connections1](connection.md#BKMK_msdyn_bookingtimestamp_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_connections2"></a> msdyn_bookingtimestamp_connections2

Many-To-One Relationship: [connection msdyn_bookingtimestamp_connections2](connection.md#BKMK_msdyn_bookingtimestamp_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord"></a> msdyn_bookingtimestamp_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_bookingtimestamp_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord"></a> msdyn_bookingtimestamp_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_bookingtimestamp_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_Emails"></a> msdyn_bookingtimestamp_Emails

Many-To-One Relationship: [email msdyn_bookingtimestamp_Emails](email.md#BKMK_msdyn_bookingtimestamp_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_Faxes"></a> msdyn_bookingtimestamp_Faxes

Many-To-One Relationship: [fax msdyn_bookingtimestamp_Faxes](fax.md#BKMK_msdyn_bookingtimestamp_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_Letters"></a> msdyn_bookingtimestamp_Letters

Many-To-One Relationship: [letter msdyn_bookingtimestamp_Letters](letter.md#BKMK_msdyn_bookingtimestamp_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders"></a> msdyn_bookingtimestamp_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_bookingtimestamp_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts"></a> msdyn_bookingtimestamp_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingtimestamp_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_copilottranscripts"></a> msdyn_bookingtimestamp_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_bookingtimestamp_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_bookingtimestamp_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_ocliveworkitems"></a> msdyn_bookingtimestamp_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_bookingtimestamp_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_bookingtimestamp_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_ocsessions"></a> msdyn_bookingtimestamp_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_bookingtimestamp_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_bookingtimestamp_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_msfp_alerts"></a> msdyn_bookingtimestamp_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_bookingtimestamp_msfp_alerts](msfp_alert.md#BKMK_msdyn_bookingtimestamp_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_msfp_surveyinvites"></a> msdyn_bookingtimestamp_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_bookingtimestamp_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_bookingtimestamp_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_msfp_surveyresponses"></a> msdyn_bookingtimestamp_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_bookingtimestamp_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_bookingtimestamp_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_PhoneCalls"></a> msdyn_bookingtimestamp_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_bookingtimestamp_PhoneCalls](phonecall.md#BKMK_msdyn_bookingtimestamp_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses"></a> msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_ProcessSession"></a> msdyn_bookingtimestamp_ProcessSession

Many-To-One Relationship: [processsession msdyn_bookingtimestamp_ProcessSession](processsession.md#BKMK_msdyn_bookingtimestamp_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters"></a> msdyn_bookingtimestamp_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_bookingtimestamp_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_ServiceAppointments"></a> msdyn_bookingtimestamp_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_bookingtimestamp_ServiceAppointments](serviceappointment.md#BKMK_msdyn_bookingtimestamp_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations"></a> msdyn_bookingtimestamp_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_bookingtimestamp_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_SocialActivities"></a> msdyn_bookingtimestamp_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_bookingtimestamp_SocialActivities](socialactivity.md#BKMK_msdyn_bookingtimestamp_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_SyncErrors"></a> msdyn_bookingtimestamp_SyncErrors

Many-To-One Relationship: [syncerror msdyn_bookingtimestamp_SyncErrors](syncerror.md#BKMK_msdyn_bookingtimestamp_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingtimestamp_Tasks"></a> msdyn_bookingtimestamp_Tasks

Many-To-One Relationship: [task msdyn_bookingtimestamp_Tasks](task.md#BKMK_msdyn_bookingtimestamp_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingtimestamp_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

