---
title: "Booking Status (BookingStatus) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Booking Status (BookingStatus) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Booking Status (BookingStatus) table/entity reference

Allows creation of multiple sub statuses mapped to a booking status option.

## Messages

The following table lists the messages for the Booking Status (BookingStatus) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /bookingstatuses(*bookingstatusid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /bookingstatuses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /bookingstatuses(*bookingstatusid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /bookingstatuses(*bookingstatusid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /bookingstatuses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /bookingstatuses(*bookingstatusid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /bookingstatuses(*bookingstatusid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /bookingstatuses(*bookingstatusid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Booking Status (BookingStatus) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Booking Status** |
| **DisplayCollectionName** | **Booking Statuses** |
| **SchemaName** | `BookingStatus` |
| **CollectionSchemaName** | `BookingStatus` |
| **EntitySetName** | `bookingstatuses`|
| **LogicalName** | `bookingstatus` |
| **LogicalCollectionName** | `bookingstatuses` |
| **PrimaryIdAttribute** | `bookingstatusid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookingStatusId](#BKMK_BookingStatusId)
- [Description](#BKMK_Description)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_FieldServiceStatus](#BKMK_msdyn_FieldServiceStatus)
- [msdyn_IconName](#BKMK_msdyn_IconName)
- [msdyn_ImageUrl](#BKMK_msdyn_ImageUrl)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_SchedulingMethod](#BKMK_msdyn_SchedulingMethod)
- [msdyn_ServiceAppointmentStatus](#BKMK_msdyn_ServiceAppointmentStatus)
- [msdyn_StatusColor](#BKMK_msdyn_StatusColor)
- [msdyn_statuscompletesworkorder](#BKMK_msdyn_statuscompletesworkorder)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [StateCode](#BKMK_StateCode)
- [Status](#BKMK_Status)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_BookingStatusId"></a> BookingStatusId

|Property|Value|
|---|---|
|Description|**Unique identifier of the booking status.**|
|DisplayName|**Booking Status**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`bookingstatusid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type a detailed description for the booking status.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyn_FieldServiceStatus"></a> msdyn_FieldServiceStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Field Service Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldservicestatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_bookingsystemstatus`|

#### msdyn_FieldServiceStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Scheduled**|
|690970001|**Traveling**|
|690970002|**On Break**|
|690970003|**In Progress**|
|690970004|**Completed**|
|690970005|**Canceled**|

### <a name="BKMK_msdyn_IconName"></a> msdyn_IconName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Icon Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iconname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ImageUrl"></a> msdyn_ImageUrl

|Property|Value|
|---|---|
|Description|**The URL for a web resource image.**|
|DisplayName|**Image Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_imageurl`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

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

### <a name="BKMK_msdyn_SchedulingMethod"></a> msdyn_SchedulingMethod

|Property|Value|
|---|---|
|Description|**Whether bookings with this status should be included in the routing optimization or not.**|
|DisplayName|**Scheduling Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulingmethod`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msdyn_bookingstatusschedulingmethod`|

#### msdyn_SchedulingMethod Choices/Options

|Value|Label|
|---|---|
|192350000|**Optimize**|
|192350001|**Do Not Move**|
|192350002|**Ignore**|

### <a name="BKMK_msdyn_ServiceAppointmentStatus"></a> msdyn_ServiceAppointmentStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**ServiceAppointment Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceappointmentstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_serviceappointmentstatus`|

#### msdyn_ServiceAppointmentStatus Choices/Options

|Value|Label|
|---|---|
|3|**Pending**|
|4|**Reserved**|
|6|**In Progress**|
|7|**Arrived**|
|8|**Completed**|
|9|**Canceled**|
|10|**No Show**|

### <a name="BKMK_msdyn_StatusColor"></a> msdyn_StatusColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Status Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statuscolor`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_statuscompletesworkorder"></a> msdyn_statuscompletesworkorder

|Property|Value|
|---|---|
|Description|**Booking assigned this booking status will be included in determining if the work order system status should be set to "completed"**|
|DisplayName|**Status Completes Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statuscompletesworkorder`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_statuscompletesworkorder`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type the name of the booking status.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
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

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Status of the Booking Status**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`bookingstatus_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_Status"></a> Status

|Property|Value|
|---|---|
|Description|**Select whether the booking status should be proposed, committed or canceled.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`status`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`bookingstatus_status`|

#### Status Choices/Options

|Value|Label|
|---|---|
|1|**Proposed**|
|2|**Committed**|
|3|**Canceled**|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Booking Status**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`bookingstatus_statuscode`|

#### StatusCode Choices/Options

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the BookingStatus with respect to the base currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

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
- [ExchangeRate](#BKMK_ExchangeRate)
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

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the bookingstatus with respect to the base currency.**|
|DisplayName|**ExchangeRate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

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
|RequiredLevel|SystemRequired|
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

- [business_unit_bookingstatus](#BKMK_business_unit_bookingstatus)
- [lk_bookingstatus_createdby](#BKMK_lk_bookingstatus_createdby)
- [lk_bookingstatus_createdonbehalfby](#BKMK_lk_bookingstatus_createdonbehalfby)
- [lk_bookingstatus_modifiedby](#BKMK_lk_bookingstatus_modifiedby)
- [lk_bookingstatus_modifiedonbehalfby](#BKMK_lk_bookingstatus_modifiedonbehalfby)
- [owner_bookingstatus](#BKMK_owner_bookingstatus)
- [team_bookingstatus](#BKMK_team_bookingstatus)
- [TransactionCurrency_bookingstatus](#BKMK_TransactionCurrency_bookingstatus)
- [user_bookingstatus](#BKMK_user_bookingstatus)

### <a name="BKMK_business_unit_bookingstatus"></a> business_unit_bookingstatus

One-To-Many Relationship: [businessunit business_unit_bookingstatus](businessunit.md#BKMK_business_unit_bookingstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookingstatus_createdby"></a> lk_bookingstatus_createdby

One-To-Many Relationship: [systemuser lk_bookingstatus_createdby](systemuser.md#BKMK_lk_bookingstatus_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookingstatus_createdonbehalfby"></a> lk_bookingstatus_createdonbehalfby

One-To-Many Relationship: [systemuser lk_bookingstatus_createdonbehalfby](systemuser.md#BKMK_lk_bookingstatus_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookingstatus_modifiedby"></a> lk_bookingstatus_modifiedby

One-To-Many Relationship: [systemuser lk_bookingstatus_modifiedby](systemuser.md#BKMK_lk_bookingstatus_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookingstatus_modifiedonbehalfby"></a> lk_bookingstatus_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_bookingstatus_modifiedonbehalfby](systemuser.md#BKMK_lk_bookingstatus_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_bookingstatus"></a> owner_bookingstatus

One-To-Many Relationship: [owner owner_bookingstatus](owner.md#BKMK_owner_bookingstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_bookingstatus"></a> team_bookingstatus

One-To-Many Relationship: [team team_bookingstatus](team.md#BKMK_team_bookingstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_bookingstatus"></a> TransactionCurrency_bookingstatus

One-To-Many Relationship: [transactioncurrency TransactionCurrency_bookingstatus](transactioncurrency.md#BKMK_TransactionCurrency_bookingstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_bookingstatus"></a> user_bookingstatus

One-To-Many Relationship: [systemuser user_bookingstatus](systemuser.md#BKMK_user_bookingstatus)

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

- [bookingstatus_AsyncOperations](#BKMK_bookingstatus_AsyncOperations)
- [bookingstatus_bookableresourcebooking_BookingStatus](#BKMK_bookingstatus_bookableresourcebooking_BookingStatus)
- [bookingstatus_BulkDeleteFailures](#BKMK_bookingstatus_BulkDeleteFailures)
- [bookingstatus_DuplicateBaseRecord](#BKMK_bookingstatus_DuplicateBaseRecord)
- [bookingstatus_DuplicateMatchingRecord](#BKMK_bookingstatus_DuplicateMatchingRecord)
- [bookingstatus_MailboxTrackingFolders](#BKMK_bookingstatus_MailboxTrackingFolders)
- [bookingstatus_PrincipalObjectAttributeAccess](#BKMK_bookingstatus_PrincipalObjectAttributeAccess)
- [bookingstatus_ProcessSession](#BKMK_bookingstatus_ProcessSession)
- [BookingStatus_SyncErrors](#BKMK_BookingStatus_SyncErrors)
- [msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid](#BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus)
- [msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus)
- [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus](#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus)
- [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus](#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus)
- [msdyn_bookingstatus_msdyn_timeentry_BookingStatus](#BKMK_msdyn_bookingstatus_msdyn_timeentry_BookingStatus)

### <a name="BKMK_bookingstatus_AsyncOperations"></a> bookingstatus_AsyncOperations

Many-To-One Relationship: [asyncoperation bookingstatus_AsyncOperations](asyncoperation.md#BKMK_bookingstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookingstatus_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookingstatus_bookableresourcebooking_BookingStatus"></a> bookingstatus_bookableresourcebooking_BookingStatus

Many-To-One Relationship: [bookableresourcebooking bookingstatus_bookableresourcebooking_BookingStatus](bookableresourcebooking.md#BKMK_bookingstatus_bookableresourcebooking_BookingStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`bookingstatus`|
|ReferencedEntityNavigationPropertyName|`bookingstatus_bookableresourcebooking_BookingStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: null<br />ViewId: `9b2c044a-2553-43f0-a816-9ffe35475f85`|

### <a name="BKMK_bookingstatus_BulkDeleteFailures"></a> bookingstatus_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure bookingstatus_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookingstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookingstatus_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookingstatus_DuplicateBaseRecord"></a> bookingstatus_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord bookingstatus_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookingstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`bookingstatus_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookingstatus_DuplicateMatchingRecord"></a> bookingstatus_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord bookingstatus_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookingstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`bookingstatus_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookingstatus_MailboxTrackingFolders"></a> bookingstatus_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder bookingstatus_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookingstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookingstatus_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookingstatus_PrincipalObjectAttributeAccess"></a> bookingstatus_PrincipalObjectAttributeAccess

Many-To-One Relationship: [principalobjectattributeaccess bookingstatus_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookingstatus_PrincipalObjectAttributeAccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`bookingstatus_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookingstatus_ProcessSession"></a> bookingstatus_ProcessSession

Many-To-One Relationship: [processsession bookingstatus_ProcessSession](processsession.md#BKMK_bookingstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookingstatus_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_BookingStatus_SyncErrors"></a> BookingStatus_SyncErrors

Many-To-One Relationship: [syncerror BookingStatus_SyncErrors](syncerror.md#BKMK_BookingStatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`BookingStatus_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid"></a> msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid

Many-To-One Relationship: [bookableresourcebookingheader msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid](bookableresourcebookingheader.md#BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebookingheader`|
|ReferencingAttribute|`msdyn_bookingstatusid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus

Many-To-One Relationship: [msdyn_bookingsetupmetadata msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`msdyn_defaultbookingcanceledstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus

Many-To-One Relationship: [msdyn_bookingsetupmetadata msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`msdyn_defaultbookingcommittedstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus"></a> msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus

Many-To-One Relationship: [msdyn_bookingtimestamp msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingtimestamp`|
|ReferencingAttribute|`msdyn_bookingstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus](msdyn_fieldservicesetting.md#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_defaultcanceledbookingstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus](msdyn_fieldservicesetting.md#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_defaultscheduledbookingstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_timeentry_BookingStatus"></a> msdyn_bookingstatus_msdyn_timeentry_BookingStatus

Many-To-One Relationship: [msdyn_timeentry msdyn_bookingstatus_msdyn_timeentry_BookingStatus](msdyn_timeentry.md#BKMK_msdyn_bookingstatus_msdyn_timeentry_BookingStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`msdyn_bookingstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_timeentry_BookingStatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

