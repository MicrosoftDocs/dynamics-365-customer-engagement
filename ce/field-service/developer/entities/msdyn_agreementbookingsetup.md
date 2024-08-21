---
title: "Agreement Booking Setup (msdyn_agreementbookingsetup) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Agreement Booking Setup (msdyn_agreementbookingsetup) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Agreement Booking Setup (msdyn_agreementbookingsetup) table/entity reference

Specify the maintenance bookings for the agreement.

## Messages

The following table lists the messages for the Agreement Booking Setup (msdyn_agreementbookingsetup) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_agreementbookingsetups<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_agreementbookingsetups<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Agreement Booking Setup (msdyn_agreementbookingsetup) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agreement Booking Setup (msdyn_agreementbookingsetup) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agreement Booking Setup** |
| **DisplayCollectionName** | **Agreement Booking Setups** |
| **SchemaName** | `msdyn_agreementbookingsetup` |
| **CollectionSchemaName** | `msdyn_agreementbookingsetups` |
| **EntitySetName** | `msdyn_agreementbookingsetups`|
| **LogicalName** | `msdyn_agreementbookingsetup` |
| **LogicalCollectionName** | `msdyn_agreementbookingsetups` |
| **PrimaryIdAttribute** | `msdyn_agreementbookingsetupid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_agreementbookingsetupId](#BKMK_msdyn_agreementbookingsetupId)
- [msdyn_AutoGenerateBooking](#BKMK_msdyn_AutoGenerateBooking)
- [msdyn_AutoGenerateWO](#BKMK_msdyn_AutoGenerateWO)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EstimatedDuration](#BKMK_msdyn_EstimatedDuration)
- [msdyn_GenerateWODaysInAdvance](#BKMK_msdyn_GenerateWODaysInAdvance)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PostBookingFlexibility](#BKMK_msdyn_PostBookingFlexibility)
- [msdyn_PostponeGenerationUntil](#BKMK_msdyn_PostponeGenerationUntil)
- [msdyn_PreBookingFlexibility](#BKMK_msdyn_PreBookingFlexibility)
- [msdyn_PreferredResource](#BKMK_msdyn_PreferredResource)
- [msdyn_PreferredStartTime](#BKMK_msdyn_PreferredStartTime)
- [msdyn_Priority](#BKMK_msdyn_Priority)
- [msdyn_ProcessStartedOn](#BKMK_msdyn_ProcessStartedOn)
- [msdyn_RecurrenceSettings](#BKMK_msdyn_RecurrenceSettings)
- [msdyn_Revision](#BKMK_msdyn_Revision)
- [msdyn_TimeWindowEnd](#BKMK_msdyn_TimeWindowEnd)
- [msdyn_TimeWindowStart](#BKMK_msdyn_TimeWindowStart)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)
- [msdyn_WorkOrderSummary](#BKMK_msdyn_WorkOrderSummary)
- [msdyn_WorkOrderType](#BKMK_msdyn_WorkOrderType)
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
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

|Property|Value|
|---|---|
|Description|**Agreement this Booking Setup relates to**|
|DisplayName|**Agreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreement`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_agreement|

### <a name="BKMK_msdyn_agreementbookingsetupId"></a> msdyn_agreementbookingsetupId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Agreement Booking Setup**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementbookingsetupid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_AutoGenerateBooking"></a> msdyn_AutoGenerateBooking

|Property|Value|
|---|---|
|Description|**Enable if the system should automatically generate Order Bookings for the Booking Dates of this Booking Setup**|
|DisplayName|**Auto Generate Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autogeneratebooking`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agreementbookingsetup_msdyn_autogeneratebooking`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_AutoGenerateWO"></a> msdyn_AutoGenerateWO

|Property|Value|
|---|---|
|Description|**Enable if the system should automatically generate Work Orders for the Booking Dates of this Booking Setup**|
|DisplayName|**Auto Generate Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autogeneratewo`|
|RequiredLevel|Recommended|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agreementbookingsetup_msdyn_autogeneratewo`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**Type a description of this booking setup.**|
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
|MaxLength|200|

### <a name="BKMK_msdyn_EstimatedDuration"></a> msdyn_EstimatedDuration

|Property|Value|
|---|---|
|Description|**Shows the duration of the booking.**|
|DisplayName|**Estimated Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_GenerateWODaysInAdvance"></a> msdyn_GenerateWODaysInAdvance

|Property|Value|
|---|---|
|Description|**Specify how many days in advance of the Booking Date the system should automatically generate a Work Order**|
|DisplayName|**Generate Work Order Days In Advance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generatewodaysinadvance`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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

### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|---|---|
|Description|**Only used when Work Location is a Facility. Latitude is used when trying to locate nearby facilities.**|
|DisplayName|**Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|---|---|
|Description|**Only used when Work Location is a Facility. Longitude is used when trying to locate nearby facilities.**|
|DisplayName|**Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

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

### <a name="BKMK_msdyn_PostBookingFlexibility"></a> msdyn_PostBookingFlexibility

|Property|Value|
|---|---|
|Description|**Shows the flexibility of days after the booking date.**|
|DisplayName|**Post Booking Flexibility**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postbookingflexibility`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_PostponeGenerationUntil"></a> msdyn_PostponeGenerationUntil

|Property|Value|
|---|---|
|Description|**Intended for internal use. Manipulating values in this field is not supported and can lead to unexpected system behavior.**|
|DisplayName|**Postpone Generation Until**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postponegenerationuntil`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_PreBookingFlexibility"></a> msdyn_PreBookingFlexibility

|Property|Value|
|---|---|
|Description|**Shows the flexibility of days prior to the booking date.**|
|DisplayName|**Pre Booking Flexibility**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prebookingflexibility`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_PreferredResource"></a> msdyn_PreferredResource

|Property|Value|
|---|---|
|Description|**Preferred Resource to booked**|
|DisplayName|**Preferred Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preferredresource`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_PreferredStartTime"></a> msdyn_PreferredStartTime

|Property|Value|
|---|---|
|Description|**Shows the preferred time to booking.**|
|DisplayName|**Preferred Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preferredstarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Priority"></a> msdyn_Priority

|Property|Value|
|---|---|
|Description|**Booking Priority**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_priority`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_priority|

### <a name="BKMK_msdyn_ProcessStartedOn"></a> msdyn_ProcessStartedOn

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Process Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_processstartedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_RecurrenceSettings"></a> msdyn_RecurrenceSettings

|Property|Value|
|---|---|
|Description|**Stores the booking recurrence settings.**|
|DisplayName|**Recurrence Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrencesettings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_Revision"></a> msdyn_Revision

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Revision**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_revision`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_TimeWindowEnd"></a> msdyn_TimeWindowEnd

|Property|Value|
|---|---|
|Description|**Shows the time window up until when this can be booked.**|
|DisplayName|**Time Window End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timewindowend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TimeWindowStart"></a> msdyn_TimeWindowStart

|Property|Value|
|---|---|
|Description|**Shows the time window from when this can be booked.**|
|DisplayName|**Time Window Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timewindowstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_WorkLocation"></a> msdyn_WorkLocation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Work Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_worklocation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_worklocation`|

#### msdyn_WorkLocation Choices/Options

|Value|Label|
|---|---|
|690970000|**Onsite**|
|690970001|**Facility**|
|690970002|**Location Agnostic**|

### <a name="BKMK_msdyn_WorkOrderSummary"></a> msdyn_WorkOrderSummary

|Property|Value|
|---|---|
|Description|**Shows the work order summary to be set on the work orders generated.**|
|DisplayName|**Work Order Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workordersummary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_WorkOrderType"></a> msdyn_WorkOrderType

|Property|Value|
|---|---|
|Description|**Work Order Type to be used on generated Work Orders**|
|DisplayName|**Work Order Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workordertype`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_workordertype|

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

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Contains the ID of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Contains the ID of the stage where the entity is located.**|
|DisplayName|**Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Agreement Booking Setup**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agreementbookingsetup_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Agreement Booking Setup**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agreementbookingsetup_statuscode`|

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
|Description|**Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.**|
|DisplayName|**Traversed Path**|
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

- [business_unit_msdyn_agreementbookingsetup](#BKMK_business_unit_msdyn_agreementbookingsetup)
- [lk_msdyn_agreementbookingsetup_createdby](#BKMK_lk_msdyn_agreementbookingsetup_createdby)
- [lk_msdyn_agreementbookingsetup_createdonbehalfby](#BKMK_lk_msdyn_agreementbookingsetup_createdonbehalfby)
- [lk_msdyn_agreementbookingsetup_modifiedby](#BKMK_lk_msdyn_agreementbookingsetup_modifiedby)
- [lk_msdyn_agreementbookingsetup_modifiedonbehalfby](#BKMK_lk_msdyn_agreementbookingsetup_modifiedonbehalfby)
- [msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource)
- [msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement)
- [msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority](#BKMK_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority)
- [msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType)
- [owner_msdyn_agreementbookingsetup](#BKMK_owner_msdyn_agreementbookingsetup)
- [processstage_msdyn_agreementbookingsetup](#BKMK_processstage_msdyn_agreementbookingsetup)
- [team_msdyn_agreementbookingsetup](#BKMK_team_msdyn_agreementbookingsetup)
- [user_msdyn_agreementbookingsetup](#BKMK_user_msdyn_agreementbookingsetup)

### <a name="BKMK_business_unit_msdyn_agreementbookingsetup"></a> business_unit_msdyn_agreementbookingsetup

One-To-Many Relationship: [businessunit business_unit_msdyn_agreementbookingsetup](businessunit.md#BKMK_business_unit_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementbookingsetup_createdby"></a> lk_msdyn_agreementbookingsetup_createdby

One-To-Many Relationship: [systemuser lk_msdyn_agreementbookingsetup_createdby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementbookingsetup_createdonbehalfby"></a> lk_msdyn_agreementbookingsetup_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agreementbookingsetup_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementbookingsetup_modifiedby"></a> lk_msdyn_agreementbookingsetup_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_agreementbookingsetup_modifiedby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementbookingsetup_modifiedonbehalfby"></a> lk_msdyn_agreementbookingsetup_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agreementbookingsetup_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource"></a> msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource

One-To-Many Relationship: [bookableresource msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_preferredresource`|
|ReferencingEntityNavigationPropertyName|`msdyn_preferredresource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement

One-To-Many Relationship: [msdyn_agreement msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority"></a> msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority

One-To-Many Relationship: [msdyn_priority msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority](msdyn_priority.md#BKMK_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`msdyn_priority`|
|ReferencingEntityNavigationPropertyName|`msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType

One-To-Many Relationship: [msdyn_workordertype msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`msdyn_workordertype`|
|ReferencingEntityNavigationPropertyName|`msdyn_workordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_agreementbookingsetup"></a> owner_msdyn_agreementbookingsetup

One-To-Many Relationship: [owner owner_msdyn_agreementbookingsetup](owner.md#BKMK_owner_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_msdyn_agreementbookingsetup"></a> processstage_msdyn_agreementbookingsetup

One-To-Many Relationship: [processstage processstage_msdyn_agreementbookingsetup](processstage.md#BKMK_processstage_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_agreementbookingsetup"></a> team_msdyn_agreementbookingsetup

One-To-Many Relationship: [team team_msdyn_agreementbookingsetup](team.md#BKMK_team_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_agreementbookingsetup"></a> user_msdyn_agreementbookingsetup

One-To-Many Relationship: [systemuser user_msdyn_agreementbookingsetup](systemuser.md#BKMK_user_msdyn_agreementbookingsetup)

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

- [bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [msdyn_agreementbookingsetup_ActivityPointers](#BKMK_msdyn_agreementbookingsetup_ActivityPointers)
- [msdyn_agreementbookingsetup_adx_inviteredemptions](#BKMK_msdyn_agreementbookingsetup_adx_inviteredemptions)
- [msdyn_agreementbookingsetup_adx_portalcomments](#BKMK_msdyn_agreementbookingsetup_adx_portalcomments)
- [msdyn_agreementbookingsetup_Annotations](#BKMK_msdyn_agreementbookingsetup_Annotations)
- [msdyn_agreementbookingsetup_Appointments](#BKMK_msdyn_agreementbookingsetup_Appointments)
- [msdyn_agreementbookingsetup_AsyncOperations](#BKMK_msdyn_agreementbookingsetup_AsyncOperations)
- [msdyn_agreementbookingsetup_BulkDeleteFailures](#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures)
- [msdyn_agreementbookingsetup_chats](#BKMK_msdyn_agreementbookingsetup_chats)
- [msdyn_agreementbookingsetup_connections1](#BKMK_msdyn_agreementbookingsetup_connections1)
- [msdyn_agreementbookingsetup_connections2](#BKMK_msdyn_agreementbookingsetup_connections2)
- [msdyn_agreementbookingsetup_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord)
- [msdyn_agreementbookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord)
- [msdyn_agreementbookingsetup_Emails](#BKMK_msdyn_agreementbookingsetup_Emails)
- [msdyn_agreementbookingsetup_Faxes](#BKMK_msdyn_agreementbookingsetup_Faxes)
- [msdyn_agreementbookingsetup_Letters](#BKMK_msdyn_agreementbookingsetup_Letters)
- [msdyn_agreementbookingsetup_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders)
- [msdyn_agreementbookingsetup_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts)
- [msdyn_agreementbookingsetup_msdyn_copilottranscripts](#BKMK_msdyn_agreementbookingsetup_msdyn_copilottranscripts)
- [msdyn_agreementbookingsetup_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingsetup_msdyn_ocliveworkitems)
- [msdyn_agreementbookingsetup_msdyn_ocsessions](#BKMK_msdyn_agreementbookingsetup_msdyn_ocsessions)
- [msdyn_agreementbookingsetup_msfp_alerts](#BKMK_msdyn_agreementbookingsetup_msfp_alerts)
- [msdyn_agreementbookingsetup_msfp_surveyinvites](#BKMK_msdyn_agreementbookingsetup_msfp_surveyinvites)
- [msdyn_agreementbookingsetup_msfp_surveyresponses](#BKMK_msdyn_agreementbookingsetup_msfp_surveyresponses)
- [msdyn_agreementbookingsetup_PhoneCalls](#BKMK_msdyn_agreementbookingsetup_PhoneCalls)
- [msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingsetup_ProcessSession](#BKMK_msdyn_agreementbookingsetup_ProcessSession)
- [msdyn_agreementbookingsetup_QueueItems](#BKMK_msdyn_agreementbookingsetup_QueueItems)
- [msdyn_agreementbookingsetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters)
- [msdyn_agreementbookingsetup_ServiceAppointments](#BKMK_msdyn_agreementbookingsetup_ServiceAppointments)
- [msdyn_agreementbookingsetup_SharePointDocumentLocations](#BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations)
- [msdyn_agreementbookingsetup_SocialActivities](#BKMK_msdyn_agreementbookingsetup_SocialActivities)
- [msdyn_agreementbookingsetup_SyncErrors](#BKMK_msdyn_agreementbookingsetup_SyncErrors)
- [msdyn_agreementbookingsetup_Tasks](#BKMK_msdyn_agreementbookingsetup_Tasks)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup)

### <a name="BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

Many-To-One Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencingAttribute|`bpf_msdyn_agreementbookingsetupid`|
|ReferencedEntityNavigationPropertyName|`bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: msdyn_agreementbookingsetup<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_ActivityPointers"></a> msdyn_agreementbookingsetup_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_agreementbookingsetup_ActivityPointers](activitypointer.md#BKMK_msdyn_agreementbookingsetup_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_adx_inviteredemptions"></a> msdyn_agreementbookingsetup_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_agreementbookingsetup_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_agreementbookingsetup_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_adx_portalcomments"></a> msdyn_agreementbookingsetup_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_agreementbookingsetup_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_agreementbookingsetup_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_Annotations"></a> msdyn_agreementbookingsetup_Annotations

Many-To-One Relationship: [annotation msdyn_agreementbookingsetup_Annotations](annotation.md#BKMK_msdyn_agreementbookingsetup_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_Appointments"></a> msdyn_agreementbookingsetup_Appointments

Many-To-One Relationship: [appointment msdyn_agreementbookingsetup_Appointments](appointment.md#BKMK_msdyn_agreementbookingsetup_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_AsyncOperations"></a> msdyn_agreementbookingsetup_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_agreementbookingsetup_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreementbookingsetup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures"></a> msdyn_agreementbookingsetup_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_agreementbookingsetup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_chats"></a> msdyn_agreementbookingsetup_chats

Many-To-One Relationship: [chat msdyn_agreementbookingsetup_chats](chat.md#BKMK_msdyn_agreementbookingsetup_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_connections1"></a> msdyn_agreementbookingsetup_connections1

Many-To-One Relationship: [connection msdyn_agreementbookingsetup_connections1](connection.md#BKMK_msdyn_agreementbookingsetup_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_connections2"></a> msdyn_agreementbookingsetup_connections2

Many-To-One Relationship: [connection msdyn_agreementbookingsetup_connections2](connection.md#BKMK_msdyn_agreementbookingsetup_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord"></a> msdyn_agreementbookingsetup_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_agreementbookingsetup_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord"></a> msdyn_agreementbookingsetup_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_agreementbookingsetup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_Emails"></a> msdyn_agreementbookingsetup_Emails

Many-To-One Relationship: [email msdyn_agreementbookingsetup_Emails](email.md#BKMK_msdyn_agreementbookingsetup_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_Faxes"></a> msdyn_agreementbookingsetup_Faxes

Many-To-One Relationship: [fax msdyn_agreementbookingsetup_Faxes](fax.md#BKMK_msdyn_agreementbookingsetup_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_Letters"></a> msdyn_agreementbookingsetup_Letters

Many-To-One Relationship: [letter msdyn_agreementbookingsetup_Letters](letter.md#BKMK_msdyn_agreementbookingsetup_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders"></a> msdyn_agreementbookingsetup_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_agreementbookingsetup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts"></a> msdyn_agreementbookingsetup_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_agreementbookingsetup_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_copilottranscripts"></a> msdyn_agreementbookingsetup_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_agreementbookingsetup_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_agreementbookingsetup_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_ocliveworkitems"></a> msdyn_agreementbookingsetup_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_agreementbookingsetup_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_agreementbookingsetup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_ocsessions"></a> msdyn_agreementbookingsetup_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_agreementbookingsetup_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_agreementbookingsetup_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_msfp_alerts"></a> msdyn_agreementbookingsetup_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_agreementbookingsetup_msfp_alerts](msfp_alert.md#BKMK_msdyn_agreementbookingsetup_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_msfp_surveyinvites"></a> msdyn_agreementbookingsetup_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_agreementbookingsetup_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_agreementbookingsetup_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_msfp_surveyresponses"></a> msdyn_agreementbookingsetup_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_agreementbookingsetup_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_agreementbookingsetup_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_PhoneCalls"></a> msdyn_agreementbookingsetup_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_agreementbookingsetup_PhoneCalls](phonecall.md#BKMK_msdyn_agreementbookingsetup_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_ProcessSession"></a> msdyn_agreementbookingsetup_ProcessSession

Many-To-One Relationship: [processsession msdyn_agreementbookingsetup_ProcessSession](processsession.md#BKMK_msdyn_agreementbookingsetup_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_QueueItems"></a> msdyn_agreementbookingsetup_QueueItems

Many-To-One Relationship: [queueitem msdyn_agreementbookingsetup_QueueItems](queueitem.md#BKMK_msdyn_agreementbookingsetup_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters"></a> msdyn_agreementbookingsetup_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_agreementbookingsetup_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_ServiceAppointments"></a> msdyn_agreementbookingsetup_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_agreementbookingsetup_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreementbookingsetup_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations"></a> msdyn_agreementbookingsetup_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_agreementbookingsetup_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_SocialActivities"></a> msdyn_agreementbookingsetup_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_agreementbookingsetup_SocialActivities](socialactivity.md#BKMK_msdyn_agreementbookingsetup_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_SyncErrors"></a> msdyn_agreementbookingsetup_SyncErrors

Many-To-One Relationship: [syncerror msdyn_agreementbookingsetup_SyncErrors](syncerror.md#BKMK_msdyn_agreementbookingsetup_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingsetup_Tasks"></a> msdyn_agreementbookingsetup_Tasks

Many-To-One Relationship: [task msdyn_agreementbookingsetup_Tasks](task.md#BKMK_msdyn_agreementbookingsetup_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingsetup_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup

Many-To-One Relationship: [msdyn_agreementbookingdate msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingdate`|
|ReferencingAttribute|`msdyn_bookingsetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Booking Dates<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup

Many-To-One Relationship: [msdyn_agreementbookingincident msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`msdyn_agreementbookingsetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Incidents<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup

Many-To-One Relationship: [msdyn_agreementbookingproduct msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`msdyn_agreementbookingsetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Products<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup

Many-To-One Relationship: [msdyn_agreementbookingservice msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`msdyn_agreementbookingsetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Services<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup

Many-To-One Relationship: [msdyn_agreementbookingservicetask msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservicetask`|
|ReferencingAttribute|`msdyn_agreementbookingsetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Service Tasks<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

