---
title: "Bookable Resource Booking (BookableResourceBooking) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bookable Resource Booking (BookableResourceBooking) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bookable Resource Booking (BookableResourceBooking) table/entity reference (Microsoft Dynamics 365 Field Service)

Represents the line details of a resource booking.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Bookable Resource Booking (BookableResourceBooking) table extends the [Microsoft Dynamics 365 Bookable Resource Booking (BookableResourceBooking) table](/dynamics365/developer/reference/entities/bookableresourcebooking).


## Messages

The following table lists the messages for the Bookable Resource Booking (BookableResourceBooking) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `msdyn_FieldServiceBookableResourceBookingAssociateAction`<br />Event: False |**msdyn_FieldServiceBookableResourceBookingAssociateAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
- [msdyn_Signature](#BKMK_msdyn_Signature)
- [msdyn_SlotText](#BKMK_msdyn_SlotText)
- [msdyn_TimeGroupDetailSelected](#BKMK_msdyn_TimeGroupDetailSelected)
- [msdyn_TotalBillableDuration](#BKMK_msdyn_TotalBillableDuration)
- [msdyn_TotalBreakDuration](#BKMK_msdyn_TotalBreakDuration)
- [msdyn_TotalCost](#BKMK_msdyn_TotalCost)
- [msdyn_TotalDurationInProgress](#BKMK_msdyn_TotalDurationInProgress)
- [msdyn_TravelTimeCalculationType](#BKMK_msdyn_TravelTimeCalculationType)
- [msdyn_TravelTimeRescheduling](#BKMK_msdyn_TravelTimeRescheduling)
- [msdyn_URSInternalFlags](#BKMK_msdyn_URSInternalFlags)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)

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
|192350000|**Optimization**|
|690970001|**Schedule Board**|
|690970002|**Mobile**|
|690970003|**Manual**|
|690970004|**Schedule Assistant**|
|690970005|**System \- Agreement Schedule**|

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


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

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

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookableresource_bookableresourcebooking_Crew](#BKMK_msdyn_bookableresource_bookableresourcebooking_Crew)
- [msdyn_bookableresource_bookableresourcebooking_ResourceGroup](#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup)
- [msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate](#BKMK_msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate)
- [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking)
- [msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected](#BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected)
- [msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder)
- [msdyn_requirementgroup_bookableresourcebooking_requirementgroupid](#BKMK_msdyn_requirementgroup_bookableresourcebooking_requirementgroupid)
- [msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement](#BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement)

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


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [bookableresourcebooking_msdyn_bookingalerts](#BKMK_bookableresourcebooking_msdyn_bookingalerts)
- [msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking)
- [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking)
- [msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid](#BKMK_msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid)
- [msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking)
- [msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking)
- [msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking)
- [msdyn_bookableresourcebooking_msdyn_rtv_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking)
- [msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_timeentry_BookableResourceBooking)
- [msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking)
- [msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking)
- [msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking)

### <a name="BKMK_bookableresourcebooking_msdyn_bookingalerts"></a> bookableresourcebooking_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert bookableresourcebooking_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_bookableresourcebooking_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

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



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

