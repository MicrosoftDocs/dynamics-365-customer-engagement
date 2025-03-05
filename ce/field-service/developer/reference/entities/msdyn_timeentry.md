---
title: "Time Entry (msdyn_timeentry) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Time Entry (msdyn_timeentry) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Time Entry (msdyn_timeentry) table/entity reference (Microsoft Dynamics 365 Field Service)

Entity used for time entry.

## Messages

The following table lists the messages for the Time Entry (msdyn_timeentry) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_timeentries(*msdyn_timeentryid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_timeentries<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_timeentries(*msdyn_timeentryid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_timeentries(*msdyn_timeentryid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_timeentries<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_timeentries(*msdyn_timeentryid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_timeentries(*msdyn_timeentryid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_timeentries(*msdyn_timeentryid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Time Entry (msdyn_timeentry) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Time Entry** |
| **DisplayCollectionName** | **Time Entries** |
| **SchemaName** | `msdyn_timeentry` |
| **CollectionSchemaName** | `msdyn_timeentries` |
| **EntitySetName** | `msdyn_timeentries`|
| **LogicalName** | `msdyn_timeentry` |
| **LogicalCollectionName** | `msdyn_timeentries` |
| **PrimaryIdAttribute** | `msdyn_timeentryid` |
| **PrimaryNameAttribute** |`msdyn_description` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_bookableresource](#BKMK_msdyn_bookableresource)
- [msdyn_BookableResourceBooking](#BKMK_msdyn_BookableResourceBooking)
- [msdyn_BookingStatus](#BKMK_msdyn_BookingStatus)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_duration](#BKMK_msdyn_duration)
- [msdyn_end](#BKMK_msdyn_end)
- [msdyn_entryStatus](#BKMK_msdyn_entryStatus)
- [msdyn_externalDescription](#BKMK_msdyn_externalDescription)
- [msdyn_internalflags](#BKMK_msdyn_internalflags)
- [msdyn_start](#BKMK_msdyn_start)
- [msdyn_timeentryId](#BKMK_msdyn_timeentryId)
- [msdyn_timeentrysettingId](#BKMK_msdyn_timeentrysettingId)
- [msdyn_timeoffrequest](#BKMK_msdyn_timeoffrequest)
- [msdyn_type](#BKMK_msdyn_type)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [traversedpath](#BKMK_traversedpath)
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

### <a name="BKMK_msdyn_bookableresource"></a> msdyn_bookableresource

|Property|Value|
|---|---|
|Description|**Shows the bookable resource.**|
|DisplayName|**Bookable Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookableresource`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_BookableResourceBooking"></a> msdyn_BookableResourceBooking

|Property|Value|
|---|---|
|Description|**Unique identifier for Resource Booking associated with Time Entry.**|
|DisplayName|**Bookable Resource Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookableresourcebooking`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresourcebooking|

### <a name="BKMK_msdyn_BookingStatus"></a> msdyn_BookingStatus

|Property|Value|
|---|---|
|Description|**Booking Status**|
|DisplayName|**Booking Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingstatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookingstatus|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Type the description of the time entry.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_duration"></a> msdyn_duration

|Property|Value|
|---|---|
|Description|**Shows the time spent.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duration`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_end"></a> msdyn_end

|Property|Value|
|---|---|
|Description|**The end time of the time entry.**|
|DisplayName|**End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_end`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_entryStatus"></a> msdyn_entryStatus

|Property|Value|
|---|---|
|Description|**Select the entry status.**|
|DisplayName|**Entry Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entrystatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_timeentrystatus`|

#### msdyn_entryStatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Draft**|
|192350001|**Returned**|
|192350002|**Approved**|
|192350003|**Submitted**|
|192354320|**Cancelled**|

### <a name="BKMK_msdyn_externalDescription"></a> msdyn_externalDescription

|Property|Value|
|---|---|
|Description|**Type the external description of the time entry.**|
|DisplayName|**External Comments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_externaldescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_internalflags"></a> msdyn_internalflags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_start"></a> msdyn_start

|Property|Value|
|---|---|
|Description|**The start time of the time entry.**|
|DisplayName|**Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_start`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_timeentryId"></a> msdyn_timeentryId

|Property|Value|
|---|---|
|Description|**The unique identifier for a time entry.**|
|DisplayName|**Time Entry**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_timeentryid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_timeentrysettingId"></a> msdyn_timeentrysettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for Time Source associated with Time Entry.**|
|DisplayName|**Time Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timeentrysettingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_timeentrysetting|

### <a name="BKMK_msdyn_timeoffrequest"></a> msdyn_timeoffrequest

|Property|Value|
|---|---|
|Description|**Unique identifier for Time Off Request associated with Time Entry. This field is auto-populated when a Time Entry is auto-created from a Time Off Request.**|
|DisplayName|**Time Off Request**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timeoffrequest`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_timeoffrequest|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description|**Select the time entry type.**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_timeentrytype`|

#### msdyn_type Choices/Options

|Value|Label|
|---|---|
|192350000|**Work**|
|192350001|**Absence**|
|192350002|**Vacation**|
|192354320|**Overtime**|
|192355000|**On Break**|
|192355001|**Travel**|

### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Orders associated with Time Entry.**|
|DisplayName|**Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorder`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorder|

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

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**(Deprecated) Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Time Entry**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_timeentry_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Time Entry**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_timeentry_statuscode`|

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

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**(Deprecated) Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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

- [msdyn_bookableresource_msdyn_timeentry_bookableresource](#BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource)
- [msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking)
- [msdyn_bookingstatus_msdyn_timeentry_BookingStatus](#BKMK_msdyn_bookingstatus_msdyn_timeentry_BookingStatus)
- [msdyn_msdyn_timeentrysetting_msdyn_timeentry](#BKMK_msdyn_msdyn_timeentrysetting_msdyn_timeentry)
- [msdyn_msdyn_timeoffrequest_msdyn_timeentry](#BKMK_msdyn_msdyn_timeoffrequest_msdyn_timeentry)
- [msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder)

### <a name="BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource"></a> msdyn_bookableresource_msdyn_timeentry_bookableresource

One-To-Many Relationship: [bookableresource msdyn_bookableresource_msdyn_timeentry_bookableresource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_bookableresource`|
|ReferencingEntityNavigationPropertyName|`msdyn_bookableresource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking"></a> msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking

One-To-Many Relationship: [bookableresourcebooking msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`msdyn_bookableresourcebooking`|
|ReferencingEntityNavigationPropertyName|`msdyn_BookableResourceBooking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_timeentry_BookingStatus"></a> msdyn_bookingstatus_msdyn_timeentry_BookingStatus

One-To-Many Relationship: [bookingstatus msdyn_bookingstatus_msdyn_timeentry_BookingStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_timeentry_BookingStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`bookingstatus`|
|ReferencedAttribute|`bookingstatusid`|
|ReferencingAttribute|`msdyn_bookingstatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_BookingStatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_timeentrysetting_msdyn_timeentry"></a> msdyn_msdyn_timeentrysetting_msdyn_timeentry

One-To-Many Relationship: [msdyn_timeentrysetting msdyn_msdyn_timeentrysetting_msdyn_timeentry](msdyn_timeentrysetting.md#BKMK_msdyn_msdyn_timeentrysetting_msdyn_timeentry)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentrysetting`|
|ReferencedAttribute|`msdyn_timeentrysettingid`|
|ReferencingAttribute|`msdyn_timeentrysettingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_timeentrysettingId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_timeoffrequest_msdyn_timeentry"></a> msdyn_msdyn_timeoffrequest_msdyn_timeentry

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_msdyn_timeoffrequest_msdyn_timeentry](msdyn_timeoffrequest.md#BKMK_msdyn_msdyn_timeoffrequest_msdyn_timeentry)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`msdyn_timeoffrequest`|
|ReferencingEntityNavigationPropertyName|`msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_WorkOrder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

