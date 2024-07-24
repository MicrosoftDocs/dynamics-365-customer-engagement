---
title: "Bookable Resource Booking (BookableResourceBooking) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bookable Resource Booking (BookableResourceBooking) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bookable Resource Booking (BookableResourceBooking) table/entity reference

Represents the line details of a resource booking.

## Messages

The following table lists the messages for the Bookable Resource Booking (BookableResourceBooking) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /bookableresourcebookings(*bookableresourcebookingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /bookableresourcebookings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /bookableresourcebookings(*bookableresourcebookingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyn_FieldServiceBookableResourceBookingAssociateAction`<br />Event: False |**msdyn_FieldServiceBookableResourceBookingAssociateAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /bookableresourcebookings(*bookableresourcebookingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /bookableresourcebookings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /bookableresourcebookings(*bookableresourcebookingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /bookableresourcebookings(*bookableresourcebookingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /bookableresourcebookings(*bookableresourcebookingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Bookable Resource Booking (BookableResourceBooking) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Bookable Resource Booking** |
| **DisplayCollectionName** | **Bookable Resource Bookings** |
| **SchemaName** | `BookableResourceBooking` |
| **CollectionSchemaName** | `BookableResourceBooking` |
| **EntitySetName** | `bookableresourcebookings`|
| **LogicalName** | `bookableresourcebooking` |
| **LogicalCollectionName** | `bookableresourcebookings` |
| **PrimaryIdAttribute** | `bookableresourcebookingid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceBookingId](#BKMK_BookableResourceBookingId)
- [BookingStatus](#BKMK_BookingStatus)
- [BookingType](#BKMK_BookingType)
- [Duration](#BKMK_Duration)
- [EndTime](#BKMK_EndTime)
- [Header](#BKMK_Header)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AcceptCascadeCrewChanges](#BKMK_msdyn_AcceptCascadeCrewChanges)
- [msdyn_ActualArrivalTime](#BKMK_msdyn_ActualArrivalTime)
- [msdyn_ActualTravelDuration](#BKMK_msdyn_ActualTravelDuration)
- [msdyn_AgreementBookingDate](#BKMK_msdyn_AgreementBookingDate)
- [msdyn_AllowOverlapping](#BKMK_msdyn_AllowOverlapping)
- [msdyn_AppointmentBookingId](#BKMK_msdyn_AppointmentBookingId)
- [msdyn_BaseTravelDuration](#BKMK_msdyn_BaseTravelDuration)
- [msdyn_BookingMethod](#BKMK_msdyn_BookingMethod)
- [msdyn_BookingSetupMetadataId](#BKMK_msdyn_BookingSetupMetadataId)
- [msdyn_CascadeCrewChanges](#BKMK_msdyn_CascadeCrewChanges)
- [msdyn_Crew](#BKMK_msdyn_Crew)
- [msdyn_CrewMemberType](#BKMK_msdyn_CrewMemberType)
- [msdyn_DateWindowEnd](#BKMK_msdyn_DateWindowEnd)
- [msdyn_DateWindowStart](#BKMK_msdyn_DateWindowStart)
- [msdyn_effort](#BKMK_msdyn_effort)
- [msdyn_EstimatedArrivalTime](#BKMK_msdyn_EstimatedArrivalTime)
- [msdyn_EstimatedTravelDuration](#BKMK_msdyn_EstimatedTravelDuration)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_MilesTraveled](#BKMK_msdyn_MilesTraveled)
- [msdyn_OfflineTimestamp](#BKMK_msdyn_OfflineTimestamp)
- [msdyn_PreventTimestampCreation](#BKMK_msdyn_PreventTimestampCreation)
- [msdyn_quickNoteAction](#BKMK_msdyn_quickNoteAction)
- [msdyn_requirementgroupid](#BKMK_msdyn_requirementgroupid)
- [msdyn_requirementgroupset](#BKMK_msdyn_requirementgroupset)
- [msdyn_ResourceGroup](#BKMK_msdyn_ResourceGroup)
- [msdyn_ResourceRequirement](#BKMK_msdyn_ResourceRequirement)
- [msdyn_SchedulingLockOptions](#BKMK_msdyn_SchedulingLockOptions)
- [msdyn_SchedulingSnapshot](#BKMK_msdyn_SchedulingSnapshot)
- [msdyn_serviceappointment](#BKMK_msdyn_serviceappointment)
- [msdyn_Signature](#BKMK_msdyn_Signature)
- [msdyn_SimulationReference](#BKMK_msdyn_SimulationReference)
- [msdyn_SlotText](#BKMK_msdyn_SlotText)
- [msdyn_TimeFromPromised](#BKMK_msdyn_TimeFromPromised)
- [msdyn_TimeGroupDetailSelected](#BKMK_msdyn_TimeGroupDetailSelected)
- [msdyn_TimeToPromised](#BKMK_msdyn_TimeToPromised)
- [msdyn_TimeWindowEnd](#BKMK_msdyn_TimeWindowEnd)
- [msdyn_TimeWindowStart](#BKMK_msdyn_TimeWindowStart)
- [msdyn_TotalBillableDuration](#BKMK_msdyn_TotalBillableDuration)
- [msdyn_TotalBreakDuration](#BKMK_msdyn_TotalBreakDuration)
- [msdyn_TotalCost](#BKMK_msdyn_TotalCost)
- [msdyn_TotalDurationInProgress](#BKMK_msdyn_TotalDurationInProgress)
- [msdyn_TravelTimeCalculationType](#BKMK_msdyn_TravelTimeCalculationType)
- [msdyn_TravelTimeRescheduling](#BKMK_msdyn_TravelTimeRescheduling)
- [msdyn_URSInternalFlags](#BKMK_msdyn_URSInternalFlags)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ProcessId](#BKMK_ProcessId)
- [Resource](#BKMK_Resource)
- [StageId](#BKMK_StageId)
- [StartTime](#BKMK_StartTime)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_BookableResourceBookingId"></a> BookableResourceBookingId

|Property|Value|
|---|---|
|Description|**Unique identifier of the resource booking.**|
|DisplayName|**Bookable Resource Booking**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`bookableresourcebookingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_BookingStatus"></a> BookingStatus

|Property|Value|
|---|---|
|Description|**Select the status of the booking.**|
|DisplayName|**Booking Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`bookingstatus`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|bookingstatus|

### <a name="BKMK_BookingType"></a> BookingType

|Property|Value|
|---|---|
|Description|**Select whether the booking is solid or liquid. Solid bookings are firm and cannot be changed whereas liquid bookings can be changed.**|
|DisplayName|**Booking Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`bookingtype`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`bookableresourcebooking_bookingtype`|

#### BookingType Choices/Options

|Value|Label|
|---|---|
|1|**Solid**|
|2|**Liquid**|

### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|---|---|
|Description|**Enter the duration of the booking.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`duration`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_EndTime"></a> EndTime

|Property|Value|
|---|---|
|Description|**Enter the end date and time of the booking.**|
|DisplayName|**End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`endtime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_Header"></a> Header

|Property|Value|
|---|---|
|Description|**Shows the reference to the booking header record that represents the summary of bookings.**|
|DisplayName|**Header**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`header`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresourcebookingheader|

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

### <a name="BKMK_msdyn_AcceptCascadeCrewChanges"></a> msdyn_AcceptCascadeCrewChanges

|Property|Value|
|---|---|
|Description|**Defines whether this booking accepts changes propagated as cascading changes**|
|DisplayName|**Accept Cascade Crew Changes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_acceptcascadecrewchanges`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresourcebooking_msdyn_acceptcascadecrewchanges`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_ActualArrivalTime"></a> msdyn_ActualArrivalTime

|Property|Value|
|---|---|
|Description|**Shows the time that work started.**|
|DisplayName|**Actual Arrival Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actualarrivaltime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ActualTravelDuration"></a> msdyn_ActualTravelDuration

|Property|Value|
|---|---|
|Description|**Shows the total travel duration. Calculated based on the difference between the Bookable Resource Booking's start time and actual arrival time.**|
|DisplayName|**Actual Travel Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actualtravelduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_AgreementBookingDate"></a> msdyn_AgreementBookingDate

|Property|Value|
|---|---|
|Description|**Agreement Booking Date from where this Booking was generated**|
|DisplayName|**Agreement Booking Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementbookingdate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreementbookingdate|

### <a name="BKMK_msdyn_AllowOverlapping"></a> msdyn_AllowOverlapping

|Property|Value|
|---|---|
|Description|**Allow the time of this booking to be displayed on the schedule assistant as available.**|
|DisplayName|**Allow Overlapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allowoverlapping`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresourcebooking_msdyn_allowoverlapping`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_AppointmentBookingId"></a> msdyn_AppointmentBookingId

|Property|Value|
|---|---|
|Description|**Unique identifier for Appointment associated with Bookable Resource Booking.**|
|DisplayName|**Appointment Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_appointmentbookingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|appointment|

### <a name="BKMK_msdyn_BaseTravelDuration"></a> msdyn_BaseTravelDuration

|Property|Value|
|---|---|
|Description|**The Base travel duration indicates the travel time without traffic**|
|DisplayName|**Base Travel Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_basetravelduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_BookingMethod"></a> msdyn_BookingMethod

|Property|Value|
|---|---|
|Description|**Shows the method used to create this booking.**|
|DisplayName|**Booking Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingmethod`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970003|
|GlobalChoiceName|`msdyn_resourceschedulesource`|

#### msdyn_BookingMethod Choices/Options

|Value|Label|
|---|---|
|192350000|**Resource Scheduling Optimization**|
|690970001|**Schedule Board**|
|690970002|**Mobile**|
|690970003|**Manual**|
|690970004|**Schedule Assistant**|
|690970005|**System - Agreement Schedule**|

### <a name="BKMK_msdyn_BookingSetupMetadataId"></a> msdyn_BookingSetupMetadataId

|Property|Value|
|---|---|
|Description|**A unique identifier for the booking setup metadata that is associated with a bookable resource booking.**|
|DisplayName|**Booking Setup Metadata**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingsetupmetadataid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_bookingsetupmetadata|

### <a name="BKMK_msdyn_CascadeCrewChanges"></a> msdyn_CascadeCrewChanges

|Property|Value|
|---|---|
|Description|**Defines whether changing any of the following fields (Start Time, End Time, Status) should cascade the changes to other bookings on this requirement that have the same start and end time.**|
|DisplayName|**Cascade Crew Changes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cascadecrewchanges`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresourcebooking_msdyn_cascadecrewchanges`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Crew"></a> msdyn_Crew

|Property|Value|
|---|---|
|Description|**This field is populated by the Field Service solution to define to which crew a booking is connected.**|
|DisplayName|**Crew**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_crew`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_CrewMemberType"></a> msdyn_CrewMemberType

|Property|Value|
|---|---|
|Description|**Crew Member Type**|
|DisplayName|**Crew Member Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_crewmembertype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_crewmembertype`|

#### msdyn_CrewMemberType Choices/Options

|Value|Label|
|---|---|
|192350000|**Leader**|
|192350001|**Member**|
|192350002|**None**|

### <a name="BKMK_msdyn_DateWindowEnd"></a> msdyn_DateWindowEnd

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date Window End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datewindowend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_DateWindowStart"></a> msdyn_DateWindowStart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date Window Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datewindowstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_effort"></a> msdyn_effort

|Property|Value|
|---|---|
|Description|**Capacity that needs to take from resource capacity**|
|DisplayName|**Capacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_effort`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0.0001|
|Precision|4|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EstimatedArrivalTime"></a> msdyn_EstimatedArrivalTime

|Property|Value|
|---|---|
|Description|**Estimated Arrival Time**|
|DisplayName|**Estimated Arrival Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedarrivaltime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EstimatedTravelDuration"></a> msdyn_EstimatedTravelDuration

|Property|Value|
|---|---|
|Description|**Estimated Travel Duration**|
|DisplayName|**Estimated Travel Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedtravelduration`|
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
|Description||
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
|Description||
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

### <a name="BKMK_msdyn_MilesTraveled"></a> msdyn_MilesTraveled

|Property|Value|
|---|---|
|Description|**In this field you can enter the total miles the resource drove to the job site**|
|DisplayName|**Miles Traveled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_milestraveled`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_OfflineTimestamp"></a> msdyn_OfflineTimestamp

|Property|Value|
|---|---|
|Description|**Internal Use. This field is used to capture the time when the Booking was updated on mobile offline.**|
|DisplayName|**Offline Timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_offlinetimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_PreventTimestampCreation"></a> msdyn_PreventTimestampCreation

|Property|Value|
|---|---|
|Description|**Prevents time stamp creation if the time stamp was already created on a mobile device.**|
|DisplayName|**Prevent Timestamp Creation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preventtimestampcreation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresourcebooking_msdyn_preventtimestampcreation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_quickNoteAction"></a> msdyn_quickNoteAction

|Property|Value|
|---|---|
|Description|**Internal For Quick note pcf control actions**|
|DisplayName|**Quick note actions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quickNoteAction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_quicknote_type`|

#### msdyn_quickNoteAction Choices/Options

|Value|Label|
|---|---|
|100000000|**none**|
|100000001|**text**|
|100000002|**photo**|
|100000003|**video**|
|100000004|**audio**|
|100000005|**file**|

### <a name="BKMK_msdyn_requirementgroupid"></a> msdyn_requirementgroupid

|Property|Value|
|---|---|
|Description|**Requirement Group**|
|DisplayName|**Requirement Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requirementgroupid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_requirementgroup|

### <a name="BKMK_msdyn_requirementgroupset"></a> msdyn_requirementgroupset

|Property|Value|
|---|---|
|Description|**Requirement Group Set**|
|DisplayName|**Requirement Group Set**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requirementgroupset`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msdyn_ResourceGroup"></a> msdyn_ResourceGroup

|Property|Value|
|---|---|
|Description|**Unique identifier for Resource associated with Resource Booking**|
|DisplayName|**Resource Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcegroup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_ResourceRequirement"></a> msdyn_ResourceRequirement

|Property|Value|
|---|---|
|Description|**Resource Requirement**|
|DisplayName|**Resource Requirement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcerequirement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_resourcerequirement|

### <a name="BKMK_msdyn_SchedulingLockOptions"></a> msdyn_SchedulingLockOptions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduling Lock Options**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulinglockoptions`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_schedulinglockoptions`|

#### msdyn_SchedulingLockOptions Choices/Options

|Value|Label|
|---|---|
|192350000|**Time Range**|
|192350001|**Resource**|
|192350002|**Time**|
|192350003|**Resource + Time**|

### <a name="BKMK_msdyn_SchedulingSnapshot"></a> msdyn_SchedulingSnapshot

|Property|Value|
|---|---|
|Description|**A snapshot of scheduling information when resource scheduling optimization started.**|
|DisplayName|**Scheduling Snapshot**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulingsnapshot`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|600|

### <a name="BKMK_msdyn_serviceappointment"></a> msdyn_serviceappointment

|Property|Value|
|---|---|
|Description|**Unique identifier for Service Appointment associated with Resource Booking.**|
|DisplayName|**Service Activity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceappointment`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|serviceappointment|

### <a name="BKMK_msdyn_Signature"></a> msdyn_Signature

|Property|Value|
|---|---|
|Description|**This field is used for capturing signature on Mobile (using the Pen Control)**|
|DisplayName|**Signature**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_signature`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|15000|

### <a name="BKMK_msdyn_SimulationReference"></a> msdyn_SimulationReference

|Property|Value|
|---|---|
|Description||
|DisplayName|**SimulationReference**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationreference`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresourcebooking|

### <a name="BKMK_msdyn_SlotText"></a> msdyn_SlotText

|Property|Value|
|---|---|
|Description|**Shows the automatically generated text of the time slot on the schedule board.**|
|DisplayName|**Slot Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_slottext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_TimeFromPromised"></a> msdyn_TimeFromPromised

|Property|Value|
|---|---|
|Description||
|DisplayName|**Time From Promised**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timefrompromised`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TimeGroupDetailSelected"></a> msdyn_TimeGroupDetailSelected

|Property|Value|
|---|---|
|Description||
|DisplayName|**Time Group Detail Selected**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timegroupdetailselected`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_timegroupdetail|

### <a name="BKMK_msdyn_TimeToPromised"></a> msdyn_TimeToPromised

|Property|Value|
|---|---|
|Description||
|DisplayName|**Time To Promised**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timetopromised`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TimeWindowEnd"></a> msdyn_TimeWindowEnd

|Property|Value|
|---|---|
|Description||
|DisplayName|**Time Window End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timewindowend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TimeWindowStart"></a> msdyn_TimeWindowStart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Time Window Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timewindowstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TotalBillableDuration"></a> msdyn_TotalBillableDuration

|Property|Value|
|---|---|
|Description|**Shows the total billable duration. If you leave this field blank the system automatically determines the billable duration by calculating the resource journal details.**|
|DisplayName|**Total Billable Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalbillableduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_TotalBreakDuration"></a> msdyn_TotalBreakDuration

|Property|Value|
|---|---|
|Description|**Shows the total break duration. If you leave this field blank the system automatically determines the break duration by calculating the resource journal details.**|
|DisplayName|**Total Break Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalbreakduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_TotalCost"></a> msdyn_TotalCost

|Property|Value|
|---|---|
|Description|**Shows the total cost for this booking.**|
|DisplayName|**Total Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_TotalDurationInProgress"></a> msdyn_TotalDurationInProgress

|Property|Value|
|---|---|
|Description|**Shows the total duration that this booking was in progress.**|
|DisplayName|**Total Duration In Progress**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totaldurationinprogress`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_TravelTimeCalculationType"></a> msdyn_TravelTimeCalculationType

|Property|Value|
|---|---|
|Description|**Travel Time Calculation**|
|DisplayName|**Travel Time Calculation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_traveltimecalculationtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_traveltimetype`|

#### msdyn_TravelTimeCalculationType Choices/Options

|Value|Label|
|---|---|
|192350000|**Bing Maps without historical traffic**|
|192350001|**Bing Maps with historical traffic**|
|192350002|**Custom Map Provider**|
|192350003|**Approximate**|

### <a name="BKMK_msdyn_TravelTimeRescheduling"></a> msdyn_TravelTimeRescheduling

|Property|Value|
|---|---|
|Description||
|DisplayName|**Travel Time Rescheduling (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_traveltimerescheduling`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresourcebooking_msdyn_traveltimerescheduling`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_URSInternalFlags"></a> msdyn_URSInternalFlags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ursinternalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_worklocation`|

#### msdyn_WorkLocation Choices/Options

|Value|Label|
|---|---|
|690970000|**Onsite**|
|690970001|**Facility**|
|690970002|**Location Agnostic**|

### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order associated with Resource Booking.**|
|DisplayName|**Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorder`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorder|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type a name for the booking.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
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

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_Resource"></a> Resource

|Property|Value|
|---|---|
|Description|**Shows the resource that is booked.**|
|DisplayName|**Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resource`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**(Deprecated) Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StartTime"></a> StartTime

|Property|Value|
|---|---|
|Description|**Enter the start date and time of the booking.**|
|DisplayName|**Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`starttime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Status of the Bookable Resource Booking**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`bookableresourcebooking_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Bookable Resource Booking**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`bookableresourcebooking_statuscode`|

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
|Description|**Exchange rate for the currency associated with the BookableResourceBooking with respect to the base currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_TraversedPath"></a> TraversedPath

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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
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
|Description|**Exchange rate for the currency associated with the bookableresourcebooking with respect to the base currency.**|
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

### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Cost in base currency.**|
|DisplayName|**Total Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

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

- [bookableresource_bookableresourcebooking_Resource](#BKMK_bookableresource_bookableresourcebooking_Resource)
- [bookableresourcebookingheader_bookableresourcebooking_Header](#BKMK_bookableresourcebookingheader_bookableresourcebooking_Header)
- [bookingstatus_bookableresourcebooking_BookingStatus](#BKMK_bookingstatus_bookableresourcebooking_BookingStatus)
- [business_unit_bookableresourcebooking](#BKMK_business_unit_bookableresourcebooking)
- [lk_bookableresourcebooking_createdby](#BKMK_lk_bookableresourcebooking_createdby)
- [lk_bookableresourcebooking_createdonbehalfby](#BKMK_lk_bookableresourcebooking_createdonbehalfby)
- [lk_bookableresourcebooking_modifiedby](#BKMK_lk_bookableresourcebooking_modifiedby)
- [lk_bookableresourcebooking_modifiedonbehalfby](#BKMK_lk_bookableresourcebooking_modifiedonbehalfby)
- [msdyn_appointment_bookableresourcebooking](#BKMK_msdyn_appointment_bookableresourcebooking)
- [msdyn_bookableresource_bookableresourcebooking_Crew](#BKMK_msdyn_bookableresource_bookableresourcebooking_Crew)
- [msdyn_bookableresource_bookableresourcebooking_ResourceGroup](#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup)
- [msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference](#BKMK_msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference-many-to-one)
- [msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate](#BKMK_msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate)
- [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking)
- [msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected](#BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected)
- [msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder)
- [msdyn_requirementgroup_bookableresourcebooking_requirementgroupid](#BKMK_msdyn_requirementgroup_bookableresourcebooking_requirementgroupid)
- [msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement](#BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement)
- [msdyn_serviceappointment_bookableresourcebooking_serviceappointment](#BKMK_msdyn_serviceappointment_bookableresourcebooking_serviceappointment)
- [owner_bookableresourcebooking](#BKMK_owner_bookableresourcebooking)
- [processstage_BookableResourceBooking](#BKMK_processstage_BookableResourceBooking)
- [team_bookableresourcebooking](#BKMK_team_bookableresourcebooking)
- [TransactionCurrency_bookableresourcebooking](#BKMK_TransactionCurrency_bookableresourcebooking)
- [user_bookableresourcebooking](#BKMK_user_bookableresourcebooking)

### <a name="BKMK_bookableresource_bookableresourcebooking_Resource"></a> bookableresource_bookableresourcebooking_Resource

One-To-Many Relationship: [bookableresource bookableresource_bookableresourcebooking_Resource](bookableresource.md#BKMK_bookableresource_bookableresourcebooking_Resource)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`resource`|
|ReferencingEntityNavigationPropertyName|`Resource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_bookableresourcebookingheader_bookableresourcebooking_Header"></a> bookableresourcebookingheader_bookableresourcebooking_Header

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_bookableresourcebooking_Header](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_bookableresourcebooking_Header)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`header`|
|ReferencingEntityNavigationPropertyName|`Header`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookingstatus_bookableresourcebooking_BookingStatus"></a> bookingstatus_bookableresourcebooking_BookingStatus

One-To-Many Relationship: [bookingstatus bookingstatus_bookableresourcebooking_BookingStatus](bookingstatus.md#BKMK_bookingstatus_bookableresourcebooking_BookingStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`bookingstatus`|
|ReferencedAttribute|`bookingstatusid`|
|ReferencingAttribute|`bookingstatus`|
|ReferencingEntityNavigationPropertyName|`BookingStatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_bookableresourcebooking"></a> business_unit_bookableresourcebooking

One-To-Many Relationship: [businessunit business_unit_bookableresourcebooking](businessunit.md#BKMK_business_unit_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookableresourcebooking_createdby"></a> lk_bookableresourcebooking_createdby

One-To-Many Relationship: [systemuser lk_bookableresourcebooking_createdby](systemuser.md#BKMK_lk_bookableresourcebooking_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookableresourcebooking_createdonbehalfby"></a> lk_bookableresourcebooking_createdonbehalfby

One-To-Many Relationship: [systemuser lk_bookableresourcebooking_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcebooking_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookableresourcebooking_modifiedby"></a> lk_bookableresourcebooking_modifiedby

One-To-Many Relationship: [systemuser lk_bookableresourcebooking_modifiedby](systemuser.md#BKMK_lk_bookableresourcebooking_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookableresourcebooking_modifiedonbehalfby"></a> lk_bookableresourcebooking_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_bookableresourcebooking_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcebooking_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_appointment_bookableresourcebooking"></a> msdyn_appointment_bookableresourcebooking

One-To-Many Relationship: [appointment msdyn_appointment_bookableresourcebooking](appointment.md#BKMK_msdyn_appointment_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencedEntity|`appointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_appointmentbookingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_AppointmentBookingId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_bookableresourcebooking_Crew"></a> msdyn_bookableresource_bookableresourcebooking_Crew

One-To-Many Relationship: [bookableresource msdyn_bookableresource_bookableresourcebooking_Crew](bookableresource.md#BKMK_msdyn_bookableresource_bookableresourcebooking_Crew)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_crew`|
|ReferencingEntityNavigationPropertyName|`msdyn_Crew`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup"></a> msdyn_bookableresource_bookableresourcebooking_ResourceGroup

One-To-Many Relationship: [bookableresource msdyn_bookableresource_bookableresourcebooking_ResourceGroup](bookableresource.md#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_resourcegroup`|
|ReferencingEntityNavigationPropertyName|`msdyn_resourcegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference-many-to-one"></a> msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference

One-To-Many Relationship: [bookableresourcebooking msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference](#BKMK_msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`msdyn_simulationreference`|
|ReferencingEntityNavigationPropertyName|`msdyn_SimulationReference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate"></a> msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`msdyn_agreementbookingdate`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking"></a> msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](msdyn_bookingsetupmetadata.md#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingEntityNavigationPropertyName|`msdyn_BookingSetupMetadataId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected"></a> msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected](msdyn_timegroupdetail.md#BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`msdyn_timegroupdetailselected`|
|ReferencingEntityNavigationPropertyName|`msdyn_timegroupdetailselected`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder"></a> msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_bookableresourcebooking_requirementgroupid"></a> msdyn_requirementgroup_bookableresourcebooking_requirementgroupid

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_bookableresourcebooking_requirementgroupid](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_bookableresourcebooking_requirementgroupid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`msdyn_requirementgroupid`|
|ReferencingEntityNavigationPropertyName|`msdyn_requirementgroupid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement"></a> msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`msdyn_resourcerequirement`|
|ReferencingEntityNavigationPropertyName|`msdyn_ResourceRequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_serviceappointment_bookableresourcebooking_serviceappointment"></a> msdyn_serviceappointment_bookableresourcebooking_serviceappointment

One-To-Many Relationship: [serviceappointment msdyn_serviceappointment_bookableresourcebooking_serviceappointment](serviceappointment.md#BKMK_msdyn_serviceappointment_bookableresourcebooking_serviceappointment)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_serviceappointment`|
|ReferencingEntityNavigationPropertyName|`msdyn_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_bookableresourcebooking"></a> owner_bookableresourcebooking

One-To-Many Relationship: [owner owner_bookableresourcebooking](owner.md#BKMK_owner_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_BookableResourceBooking"></a> processstage_BookableResourceBooking

One-To-Many Relationship: [processstage processstage_BookableResourceBooking](processstage.md#BKMK_processstage_BookableResourceBooking)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_bookableresourcebooking"></a> team_bookableresourcebooking

One-To-Many Relationship: [team team_bookableresourcebooking](team.md#BKMK_team_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_bookableresourcebooking"></a> TransactionCurrency_bookableresourcebooking

One-To-Many Relationship: [transactioncurrency TransactionCurrency_bookableresourcebooking](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_bookableresourcebooking"></a> user_bookableresourcebooking

One-To-Many Relationship: [systemuser user_bookableresourcebooking](systemuser.md#BKMK_user_bookableresourcebooking)

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

- [bookableresourcebooking_ActivityPointers](#BKMK_bookableresourcebooking_ActivityPointers)
- [bookableresourcebooking_adx_alertsubscriptions](#BKMK_bookableresourcebooking_adx_alertsubscriptions)
- [bookableresourcebooking_adx_inviteredemptions](#BKMK_bookableresourcebooking_adx_inviteredemptions)
- [bookableresourcebooking_adx_portalcomments](#BKMK_bookableresourcebooking_adx_portalcomments)
- [bookableresourcebooking_Annotations](#BKMK_bookableresourcebooking_Annotations)
- [bookableresourcebooking_Appointments](#BKMK_bookableresourcebooking_Appointments)
- [bookableresourcebooking_AsyncOperations](#BKMK_bookableresourcebooking_AsyncOperations)
- [bookableresourcebooking_BulkDeleteFailures](#BKMK_bookableresourcebooking_BulkDeleteFailures)
- [bookableresourcebooking_BulkOperations](#BKMK_bookableresourcebooking_BulkOperations)
- [bookableresourcebooking_CampaignActivities](#BKMK_bookableresourcebooking_CampaignActivities)
- [bookableresourcebooking_CampaignResponses](#BKMK_bookableresourcebooking_CampaignResponses)
- [bookableresourcebooking_chats](#BKMK_bookableresourcebooking_chats)
- [bookableresourcebooking_DuplicateBaseRecord](#BKMK_bookableresourcebooking_DuplicateBaseRecord)
- [bookableresourcebooking_DuplicateMatchingRecord](#BKMK_bookableresourcebooking_DuplicateMatchingRecord)
- [bookableresourcebooking_Emails](#BKMK_bookableresourcebooking_Emails)
- [bookableresourcebooking_Faxes](#BKMK_bookableresourcebooking_Faxes)
- [bookableresourcebooking_IncidentResolutions](#BKMK_bookableresourcebooking_IncidentResolutions)
- [bookableresourcebooking_Letters](#BKMK_bookableresourcebooking_Letters)
- [bookableresourcebooking_li_inmails](#BKMK_bookableresourcebooking_li_inmails)
- [bookableresourcebooking_li_messages](#BKMK_bookableresourcebooking_li_messages)
- [bookableresourcebooking_li_pointdrivepresentationvieweds](#BKMK_bookableresourcebooking_li_pointdrivepresentationvieweds)
- [bookableresourcebooking_MailboxTrackingFolders](#BKMK_bookableresourcebooking_MailboxTrackingFolders)
- [bookableresourcebooking_msdyn_bookingalerts](#BKMK_bookableresourcebooking_msdyn_bookingalerts)
- [bookableresourcebooking_msdyn_copilottranscripts](#BKMK_bookableresourcebooking_msdyn_copilottranscripts)
- [bookableresourcebooking_msdyn_ocliveworkitems](#BKMK_bookableresourcebooking_msdyn_ocliveworkitems)
- [bookableresourcebooking_msdyn_ocoutboundmessages](#BKMK_bookableresourcebooking_msdyn_ocoutboundmessages)
- [bookableresourcebooking_msdyn_ocsessions](#BKMK_bookableresourcebooking_msdyn_ocsessions)
- [bookableresourcebooking_msdyn_ocvoicemails](#BKMK_bookableresourcebooking_msdyn_ocvoicemails)
- [bookableresourcebooking_msfp_alerts](#BKMK_bookableresourcebooking_msfp_alerts)
- [bookableresourcebooking_msfp_surveyinvites](#BKMK_bookableresourcebooking_msfp_surveyinvites)
- [bookableresourcebooking_msfp_surveyresponses](#BKMK_bookableresourcebooking_msfp_surveyresponses)
- [bookableresourcebooking_OpportunityCloses](#BKMK_bookableresourcebooking_OpportunityCloses)
- [bookableresourcebooking_OrderCloses](#BKMK_bookableresourcebooking_OrderCloses)
- [bookableresourcebooking_PhoneCalls](#BKMK_bookableresourcebooking_PhoneCalls)
- [bookableresourcebooking_PrincipalObjectAttributeAccess](#BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess)
- [bookableresourcebooking_ProcessSession](#BKMK_bookableresourcebooking_ProcessSession)
- [bookableresourcebooking_QuoteCloses](#BKMK_bookableresourcebooking_QuoteCloses)
- [bookableresourcebooking_RecurringAppointmentMasters](#BKMK_bookableresourcebooking_RecurringAppointmentMasters)
- [bookableresourcebooking_ServiceAppointments](#BKMK_bookableresourcebooking_ServiceAppointments)
- [bookableresourcebooking_SocialActivities](#BKMK_bookableresourcebooking_SocialActivities)
- [BookableResourceBooking_SyncErrors](#BKMK_BookableResourceBooking_SyncErrors)
- [bookableresourcebooking_Tasks](#BKMK_bookableresourcebooking_Tasks)
- [msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference](#BKMK_msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference-one-to-many)
- [msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking)
- [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking)
- [msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid](#BKMK_msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid)
- [msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking)
- [msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking)
- [msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking)
- [msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking)
- [msdyn_bookableresourcebooking_msdyn_rtv_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking)
- [msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking)
- [msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking)
- [msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking)
- [msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking)
- [msdyn_bookableresourcebookingquicknote_bookableresourcebooking](#BKMK_msdyn_bookableresourcebookingquicknote_bookableresourcebooking)

### <a name="BKMK_bookableresourcebooking_ActivityPointers"></a> bookableresourcebooking_ActivityPointers

Many-To-One Relationship: [activitypointer bookableresourcebooking_ActivityPointers](activitypointer.md#BKMK_bookableresourcebooking_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_adx_alertsubscriptions"></a> bookableresourcebooking_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription bookableresourcebooking_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_bookableresourcebooking_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_adx_inviteredemptions"></a> bookableresourcebooking_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption bookableresourcebooking_adx_inviteredemptions](adx_inviteredemption.md#BKMK_bookableresourcebooking_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_adx_portalcomments"></a> bookableresourcebooking_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment bookableresourcebooking_adx_portalcomments](adx_portalcomment.md#BKMK_bookableresourcebooking_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_Annotations"></a> bookableresourcebooking_Annotations

Many-To-One Relationship: [annotation bookableresourcebooking_Annotations](annotation.md#BKMK_bookableresourcebooking_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_Appointments"></a> bookableresourcebooking_Appointments

Many-To-One Relationship: [appointment bookableresourcebooking_Appointments](appointment.md#BKMK_bookableresourcebooking_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_AsyncOperations"></a> bookableresourcebooking_AsyncOperations

Many-To-One Relationship: [asyncoperation bookableresourcebooking_AsyncOperations](asyncoperation.md#BKMK_bookableresourcebooking_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_BulkDeleteFailures"></a> bookableresourcebooking_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure bookableresourcebooking_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcebooking_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_BulkOperations"></a> bookableresourcebooking_BulkOperations

Many-To-One Relationship: [bulkoperation bookableresourcebooking_BulkOperations](bulkoperation.md#BKMK_bookableresourcebooking_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_CampaignActivities"></a> bookableresourcebooking_CampaignActivities

Many-To-One Relationship: [campaignactivity bookableresourcebooking_CampaignActivities](campaignactivity.md#BKMK_bookableresourcebooking_CampaignActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_CampaignActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_CampaignResponses"></a> bookableresourcebooking_CampaignResponses

Many-To-One Relationship: [campaignresponse bookableresourcebooking_CampaignResponses](campaignresponse.md#BKMK_bookableresourcebooking_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_chats"></a> bookableresourcebooking_chats

Many-To-One Relationship: [chat bookableresourcebooking_chats](chat.md#BKMK_bookableresourcebooking_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_DuplicateBaseRecord"></a> bookableresourcebooking_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord bookableresourcebooking_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcebooking_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_DuplicateMatchingRecord"></a> bookableresourcebooking_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord bookableresourcebooking_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcebooking_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_Emails"></a> bookableresourcebooking_Emails

Many-To-One Relationship: [email bookableresourcebooking_Emails](email.md#BKMK_bookableresourcebooking_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_Faxes"></a> bookableresourcebooking_Faxes

Many-To-One Relationship: [fax bookableresourcebooking_Faxes](fax.md#BKMK_bookableresourcebooking_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_IncidentResolutions"></a> bookableresourcebooking_IncidentResolutions

Many-To-One Relationship: [incidentresolution bookableresourcebooking_IncidentResolutions](incidentresolution.md#BKMK_bookableresourcebooking_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_Letters"></a> bookableresourcebooking_Letters

Many-To-One Relationship: [letter bookableresourcebooking_Letters](letter.md#BKMK_bookableresourcebooking_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_li_inmails"></a> bookableresourcebooking_li_inmails

Many-To-One Relationship: [li_inmail bookableresourcebooking_li_inmails](li_inmail.md#BKMK_bookableresourcebooking_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_li_messages"></a> bookableresourcebooking_li_messages

Many-To-One Relationship: [li_message bookableresourcebooking_li_messages](li_message.md#BKMK_bookableresourcebooking_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_li_pointdrivepresentationvieweds"></a> bookableresourcebooking_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed bookableresourcebooking_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_bookableresourcebooking_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_MailboxTrackingFolders"></a> bookableresourcebooking_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder bookableresourcebooking_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcebooking_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_msdyn_bookingalerts"></a> bookableresourcebooking_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert bookableresourcebooking_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_bookableresourcebooking_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_msdyn_copilottranscripts"></a> bookableresourcebooking_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript bookableresourcebooking_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_bookableresourcebooking_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_msdyn_ocliveworkitems"></a> bookableresourcebooking_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem bookableresourcebooking_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_bookableresourcebooking_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_msdyn_ocoutboundmessages"></a> bookableresourcebooking_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage bookableresourcebooking_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_bookableresourcebooking_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_msdyn_ocsessions"></a> bookableresourcebooking_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession bookableresourcebooking_msdyn_ocsessions](msdyn_ocsession.md#BKMK_bookableresourcebooking_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_msdyn_ocvoicemails"></a> bookableresourcebooking_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail bookableresourcebooking_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_bookableresourcebooking_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_msfp_alerts"></a> bookableresourcebooking_msfp_alerts

Many-To-One Relationship: [msfp_alert bookableresourcebooking_msfp_alerts](msfp_alert.md#BKMK_bookableresourcebooking_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_msfp_surveyinvites"></a> bookableresourcebooking_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite bookableresourcebooking_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_bookableresourcebooking_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_msfp_surveyresponses"></a> bookableresourcebooking_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse bookableresourcebooking_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_bookableresourcebooking_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_OpportunityCloses"></a> bookableresourcebooking_OpportunityCloses

Many-To-One Relationship: [opportunityclose bookableresourcebooking_OpportunityCloses](opportunityclose.md#BKMK_bookableresourcebooking_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_OrderCloses"></a> bookableresourcebooking_OrderCloses

Many-To-One Relationship: [orderclose bookableresourcebooking_OrderCloses](orderclose.md#BKMK_bookableresourcebooking_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_PhoneCalls"></a> bookableresourcebooking_PhoneCalls

Many-To-One Relationship: [phonecall bookableresourcebooking_PhoneCalls](phonecall.md#BKMK_bookableresourcebooking_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess"></a> bookableresourcebooking_PrincipalObjectAttributeAccess

Many-To-One Relationship: [principalobjectattributeaccess bookableresourcebooking_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_ProcessSession"></a> bookableresourcebooking_ProcessSession

Many-To-One Relationship: [processsession bookableresourcebooking_ProcessSession](processsession.md#BKMK_bookableresourcebooking_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_QuoteCloses"></a> bookableresourcebooking_QuoteCloses

Many-To-One Relationship: [quoteclose bookableresourcebooking_QuoteCloses](quoteclose.md#BKMK_bookableresourcebooking_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_RecurringAppointmentMasters"></a> bookableresourcebooking_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster bookableresourcebooking_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_bookableresourcebooking_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_ServiceAppointments"></a> bookableresourcebooking_ServiceAppointments

Many-To-One Relationship: [serviceappointment bookableresourcebooking_ServiceAppointments](serviceappointment.md#BKMK_bookableresourcebooking_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bookableresourcebooking_SocialActivities"></a> bookableresourcebooking_SocialActivities

Many-To-One Relationship: [socialactivity bookableresourcebooking_SocialActivities](socialactivity.md#BKMK_bookableresourcebooking_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_BookableResourceBooking_SyncErrors"></a> BookableResourceBooking_SyncErrors

Many-To-One Relationship: [syncerror BookableResourceBooking_SyncErrors](syncerror.md#BKMK_BookableResourceBooking_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`BookableResourceBooking_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresourcebooking_Tasks"></a> bookableresourcebooking_Tasks

Many-To-One Relationship: [task bookableresourcebooking_Tasks](task.md#BKMK_bookableresourcebooking_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference-one-to-many"></a> msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference

Many-To-One Relationship: [bookableresourcebooking msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference](#BKMK_msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`msdyn_simulationreference`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_bookableresourcebooking_SimulationReference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking"></a> msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking

Many-To-One Relationship: [msdyn_bookingjournal msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking](msdyn_bookingjournal.md#BKMK_msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingjournal`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking"></a> msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking

Many-To-One Relationship: [msdyn_bookingtimestamp msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](msdyn_bookingtimestamp.md#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingtimestamp`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid"></a> msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid

Many-To-One Relationship: [msdyn_geofence msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid](msdyn_geofence.md#BKMK_msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofence`|
|ReferencingAttribute|`msdyn_bookableresourcebookingid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: Geofence to Bookable Resource Booking relationship<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking"></a> msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking

Many-To-One Relationship: [msdyn_optimizationrequestbooking msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking](msdyn_optimizationrequestbooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequestbooking`|
|ReferencingAttribute|`msdyn_bookableresourcebooking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking

Many-To-One Relationship: [msdyn_purchaseorder msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking](msdyn_purchaseorder.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking

Many-To-One Relationship: [msdyn_purchaseorderproduct msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking](msdyn_purchaseorderproduct.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`msdyn_associatetobooking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`msdyn_associatetobooking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking"></a> msdyn_bookableresourcebooking_msdyn_rtv_Booking

Many-To-One Relationship: [msdyn_rtv msdyn_bookableresourcebooking_msdyn_rtv_Booking](msdyn_rtv.md#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_rtv_Booking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking"></a> msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking

Many-To-One Relationship: [msdyn_timeentry msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking](msdyn_timeentry.md#BKMK_msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`msdyn_bookableresourcebooking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking

Many-To-One Relationship: [msdyn_workorderproduct msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](msdyn_workorderproduct.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservice_Booking

Many-To-One Relationship: [msdyn_workorderservice msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](msdyn_workorderservice.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_workorderservice_Booking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking

Many-To-One Relationship: [msdyn_workorderservicetask msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](msdyn_workorderservicetask.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_bookableresourcebooking"></a> msdyn_bookableresourcebookingquicknote_bookableresourcebooking

Many-To-One Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_bookableresourcebooking](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencingAttribute|`msdyn_quicknote_lookup_entity`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcebookingquicknote_bookableresourcebooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

