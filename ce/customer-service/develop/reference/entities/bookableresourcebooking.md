---
title: "Bookable Resource Booking (BookableResourceBooking) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Bookable Resource Booking (BookableResourceBooking) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Bookable Resource Booking (BookableResourceBooking) table/entity reference (Microsoft Dynamics 365 Customer Service)

Represents the line details of a resource booking.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Bookable Resource Booking (BookableResourceBooking) table extends the [Microsoft Dynamics 365 Bookable Resource Booking (BookableResourceBooking) table](/dynamics365/developer/reference/entities/bookableresourcebooking).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_AcceptCascadeCrewChanges](#BKMK_msdyn_AcceptCascadeCrewChanges)
- [msdyn_ActualArrivalTime](#BKMK_msdyn_ActualArrivalTime)
- [msdyn_ActualTravelDuration](#BKMK_msdyn_ActualTravelDuration)
- [msdyn_AllowOverlapping](#BKMK_msdyn_AllowOverlapping)
- [msdyn_AppointmentBookingId](#BKMK_msdyn_AppointmentBookingId)
- [msdyn_BaseTravelDuration](#BKMK_msdyn_BaseTravelDuration)
- [msdyn_BookingMethod](#BKMK_msdyn_BookingMethod)
- [msdyn_BookingSetupMetadataId](#BKMK_msdyn_BookingSetupMetadataId)
- [msdyn_CascadeCrewChanges](#BKMK_msdyn_CascadeCrewChanges)
- [msdyn_effort](#BKMK_msdyn_effort)
- [msdyn_EstimatedArrivalTime](#BKMK_msdyn_EstimatedArrivalTime)
- [msdyn_EstimatedTravelDuration](#BKMK_msdyn_EstimatedTravelDuration)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_MilesTraveled](#BKMK_msdyn_MilesTraveled)
- [msdyn_requirementgroupid](#BKMK_msdyn_requirementgroupid)
- [msdyn_requirementgroupset](#BKMK_msdyn_requirementgroupset)
- [msdyn_ResourceGroup](#BKMK_msdyn_ResourceGroup)
- [msdyn_ResourceRequirement](#BKMK_msdyn_ResourceRequirement)
- [msdyn_serviceappointment](#BKMK_msdyn_serviceappointment)
- [msdyn_TimeGroupDetailSelected](#BKMK_msdyn_TimeGroupDetailSelected)
- [msdyn_TravelTimeCalculationType](#BKMK_msdyn_TravelTimeCalculationType)
- [msdyn_URSInternalFlags](#BKMK_msdyn_URSInternalFlags)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)

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


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_appointment_bookableresourcebooking](#BKMK_msdyn_appointment_bookableresourcebooking)
- [msdyn_bookableresource_bookableresourcebooking_ResourceGroup](#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup)
- [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking)
- [msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected](#BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected)
- [msdyn_requirementgroup_bookableresourcebooking_requirementgroupid](#BKMK_msdyn_requirementgroup_bookableresourcebooking_requirementgroupid)
- [msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement](#BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement)
- [msdyn_serviceappointment_bookableresourcebooking_serviceappointment](#BKMK_msdyn_serviceappointment_bookableresourcebooking_serviceappointment)

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


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_bookableresourcebooking_msdyn_bookingalerts"></a> bookableresourcebooking_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert bookableresourcebooking_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_bookableresourcebooking_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebooking_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

