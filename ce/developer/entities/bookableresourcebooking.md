---
title: "BookableResourceBooking Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BookableResourceBooking entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# BookableResourceBooking Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Represents the line details of a resource booking.

**Added by**: Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/bookableresourcebookings<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bookableresourcebookings<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Bookable Resource Booking<br />
**DisplayCollectionName**: Bookable Resource Bookings<br />
**SchemaName**: BookableResourceBooking<br />
**CollectionSchemaName**: BookableResourceBooking<br />
**LogicalName**: bookableresourcebooking<br />
**LogicalCollectionName**: bookableresourcebookings<br />
**EntitySetName**: bookableresourcebookings<br />
**PrimaryIdAttribute**: bookableresourcebookingid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceBookingId](#BKMK_BookableResourceBookingId)
- [BookingStatus](#BKMK_BookingStatus)
- [BookingType](#BKMK_BookingType)
- [Duration](#BKMK_Duration)
- [EndTime](#BKMK_EndTime)
- [Header](#BKMK_Header)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ActualArrivalTime](#BKMK_msdyn_ActualArrivalTime)
- [msdyn_ActualTravelDuration](#BKMK_msdyn_ActualTravelDuration)
- [msdyn_AgreementBookingDate](#BKMK_msdyn_AgreementBookingDate)
- [msdyn_AllowOverlapping](#BKMK_msdyn_AllowOverlapping)
- [msdyn_BookingMethod](#BKMK_msdyn_BookingMethod)
- [msdyn_BookingSetupMetadataId](#BKMK_msdyn_BookingSetupMetadataId)
- [msdyn_CascadeCrewChanges](#BKMK_msdyn_CascadeCrewChanges)
- [msdyn_EstimatedArrivalTime](#BKMK_msdyn_EstimatedArrivalTime)
- [msdyn_EstimatedTravelDuration](#BKMK_msdyn_EstimatedTravelDuration)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_MilesTraveled](#BKMK_msdyn_MilesTraveled)
- [msdyn_OfflineTimestamp](#BKMK_msdyn_OfflineTimestamp)
- [msdyn_PreventTimestampCreation](#BKMK_msdyn_PreventTimestampCreation)
- [msdyn_projectid](#BKMK_msdyn_projectid)
- [msdyn_projectteamid](#BKMK_msdyn_projectteamid)
- [msdyn_resourcecategoryid](#BKMK_msdyn_resourcecategoryid)
- [msdyn_ResourceGroup](#BKMK_msdyn_ResourceGroup)
- [msdyn_ResourceRequirement](#BKMK_msdyn_ResourceRequirement)
- [msdyn_Signature](#BKMK_msdyn_Signature)
- [msdyn_SlotText](#BKMK_msdyn_SlotText)
- [msdyn_TimeGroupDetailSelected](#BKMK_msdyn_TimeGroupDetailSelected)
- [msdyn_TotalBillableDuration](#BKMK_msdyn_TotalBillableDuration)
- [msdyn_TotalBreakDuration](#BKMK_msdyn_TotalBreakDuration)
- [msdyn_TotalCost](#BKMK_msdyn_TotalCost)
- [msdyn_TotalDurationInProgress](#BKMK_msdyn_TotalDurationInProgress)
- [msdyn_TravelTimeRescheduling](#BKMK_msdyn_TravelTimeRescheduling)
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

**Description**: Unique identifier of the resource booking.<br />
**DisplayName**: Bookable Resource Booking<br />
**LogicalName**: bookableresourcebookingid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_BookingStatus"></a> BookingStatus

**Description**: Select the status of the booking.<br />
**DisplayName**: Booking Status<br />
**LogicalName**: bookingstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: bookingstatus


### <a name="BKMK_BookingType"></a> BookingType

**Description**: Select whether the booking is solid or liquid. Solid bookings are firm and cannot be changed whereas liquid bookings can be changed.<br />
**DisplayName**: Booking Type<br />
**LogicalName**: bookingtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Solid
- **Value**: 2 **Label**: Liquid



### <a name="BKMK_Duration"></a> Duration

**Description**: Enter the duration of the booking.<br />
**DisplayName**: Duration<br />
**LogicalName**: duration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_EndTime"></a> EndTime

**Description**: Enter the end date and time of the booking.<br />
**DisplayName**: End Time<br />
**LogicalName**: endtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_Header"></a> Header

**Description**: Shows the reference to the booking header record that represents the summary of bookings.<br />
**DisplayName**: Header<br />
**LogicalName**: header<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcebookingheader


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_ActualArrivalTime"></a> msdyn_ActualArrivalTime

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Shows the time that work started.<br />
**DisplayName**: Actual Arrival Time<br />
**LogicalName**: msdyn_actualarrivaltime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_ActualTravelDuration"></a> msdyn_ActualTravelDuration

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Shows the total travel duration. If you leave this field blank the system automatically determines the travel duration by calculating the resource journal details.<br />
**DisplayName**: Actual Travel Duration<br />
**LogicalName**: msdyn_actualtravelduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_AgreementBookingDate"></a> msdyn_AgreementBookingDate

**Added by**: Field Service Solution<br />
**Description**: Agreement Booking Date from where this Booking was generated<br />
**DisplayName**: Agreement Booking Date<br />
**LogicalName**: msdyn_agreementbookingdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementbookingdate


### <a name="BKMK_msdyn_AllowOverlapping"></a> msdyn_AllowOverlapping

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Allow the time of this booking to be displayed on the schedule assistant as available.<br />
**DisplayName**: Allow Overlapping<br />
**LogicalName**: msdyn_allowoverlapping<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_BookingMethod"></a> msdyn_BookingMethod

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Shows the method used to create this booking.<br />
**DisplayName**: Booking Method<br />
**LogicalName**: msdyn_bookingmethod<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970001 **Label**: Schedule Board
- **Value**: 690970002 **Label**: Mobile
- **Value**: 690970003 **Label**: Manual
- **Value**: 690970004 **Label**: Schedule Assistant
- **Value**: 690970005 **Label**: System - Agreement Schedule



### <a name="BKMK_msdyn_BookingSetupMetadataId"></a> msdyn_BookingSetupMetadataId

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: A unique identifier for the booking setup metadata that is associated with a bookable resource booking.<br />
**DisplayName**: Booking Setup Metadata<br />
**LogicalName**: msdyn_bookingsetupmetadataid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_bookingsetupmetadata


### <a name="BKMK_msdyn_CascadeCrewChanges"></a> msdyn_CascadeCrewChanges

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Defines whether changing any of the following fields (Start Time, End Time, Status) should cascade the changes to other bookings on this requirement that have the same start and end time.<br />
**DisplayName**: Cascade Crew Changes<br />
**LogicalName**: msdyn_cascadecrewchanges<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_EstimatedArrivalTime"></a> msdyn_EstimatedArrivalTime

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Estimated Arrival Time<br />
**DisplayName**: Estimated Arrival Time<br />
**LogicalName**: msdyn_estimatedarrivaltime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_EstimatedTravelDuration"></a> msdyn_EstimatedTravelDuration

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Estimated Travel Duration<br />
**DisplayName**: Estimated Travel Duration<br />
**LogicalName**: msdyn_estimatedtravelduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

**Added by**: Field Service Solution<br />
**Description**: For internal use only.<br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: <br />
**DisplayName**: Latitude<br />
**LogicalName**: msdyn_latitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 90<br />
**MinValue**: -90<br />
**Precision**: 5


### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: <br />
**DisplayName**: Longitude<br />
**LogicalName**: msdyn_longitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 180<br />
**MinValue**: -180<br />
**Precision**: 5


### <a name="BKMK_msdyn_MilesTraveled"></a> msdyn_MilesTraveled

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: In this field you can enter the total miles the resource drove to the job site<br />
**DisplayName**: Miles Traveled<br />
**LogicalName**: msdyn_milestraveled<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_OfflineTimestamp"></a> msdyn_OfflineTimestamp

**Added by**: Field Service Solution<br />
**Description**: Internal Use. This field is used to capture the time when the Booking was updated on mobile offline.<br />
**DisplayName**: Offline Timestamp<br />
**LogicalName**: msdyn_offlinetimestamp<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_PreventTimestampCreation"></a> msdyn_PreventTimestampCreation

**Added by**: Field Service Solution<br />
**Description**: Prevents time stamp creation if the time stamp was already created on a mobile device.<br />
**DisplayName**: Prevent Timestamp Creation<br />
**LogicalName**: msdyn_preventtimestampcreation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_projectid"></a> msdyn_projectid

**Added by**: Project Service Automation Solution<br />
**Description**: Project of booking detail record<br />
**DisplayName**: Project<br />
**LogicalName**: msdyn_projectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_project


### <a name="BKMK_msdyn_projectteamid"></a> msdyn_projectteamid

**Added by**: Project Service Automation Solution<br />
**Description**: Project team member of booking detail record<br />
**DisplayName**: Project Team Member<br />
**LogicalName**: msdyn_projectteamid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_projectteam


### <a name="BKMK_msdyn_resourcecategoryid"></a> msdyn_resourcecategoryid

**Added by**: Project Service Automation Solution<br />
**Description**: Resource Category<br />
**DisplayName**: Resource Category<br />
**LogicalName**: msdyn_resourcecategoryid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecategory


### <a name="BKMK_msdyn_ResourceGroup"></a> msdyn_ResourceGroup

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Unique identifier for Resource associated with Resource Booking<br />
**DisplayName**: Resource Group<br />
**LogicalName**: msdyn_resourcegroup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_ResourceRequirement"></a> msdyn_ResourceRequirement

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Resource Requirement<br />
**DisplayName**: Resource Requirement<br />
**LogicalName**: msdyn_resourcerequirement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_resourcerequirement


### <a name="BKMK_msdyn_Signature"></a> msdyn_Signature

**Added by**: Field Service Solution<br />
**Description**: This field is used for capturing signature on MoCa (using the Pen Control)<br />
**DisplayName**: Signature<br />
**LogicalName**: msdyn_signature<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 15000


### <a name="BKMK_msdyn_SlotText"></a> msdyn_SlotText

**Added by**: Field Service Solution<br />
**Description**: Shows the automatically generated text of the time slot on the schedule board.<br />
**DisplayName**: Slot Text<br />
**LogicalName**: msdyn_slottext<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_TimeGroupDetailSelected"></a> msdyn_TimeGroupDetailSelected

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: <br />
**DisplayName**: Time Group Detail Selected<br />
**LogicalName**: msdyn_timegroupdetailselected<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_timegroupdetail


### <a name="BKMK_msdyn_TotalBillableDuration"></a> msdyn_TotalBillableDuration

**Added by**: Field Service Solution<br />
**Description**: Shows the total billable duration. If you leave this field blank the system automatically determines the billable duration by calculating the resource journal details.<br />
**DisplayName**: Total Billable Duration<br />
**LogicalName**: msdyn_totalbillableduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_TotalBreakDuration"></a> msdyn_TotalBreakDuration

**Added by**: Field Service Solution<br />
**Description**: Shows the total break duration. If you leave this field blank the system automatically determines the break duration by calculating the resource journal details.<br />
**DisplayName**: Total Break Duration<br />
**LogicalName**: msdyn_totalbreakduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_TotalCost"></a> msdyn_TotalCost

**Added by**: Field Service Solution<br />
**Description**: Shows the total cost for this booking.<br />
**DisplayName**: Total Cost<br />
**LogicalName**: msdyn_totalcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_TotalDurationInProgress"></a> msdyn_TotalDurationInProgress

**Added by**: Field Service Solution<br />
**Description**: Shows the total duration that this booking was in progress.<br />
**DisplayName**: Total Duration In Progress<br />
**LogicalName**: msdyn_totaldurationinprogress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_TravelTimeRescheduling"></a> msdyn_TravelTimeRescheduling

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Travel Time Rescheduling (Deprecated)<br />
**LogicalName**: msdyn_traveltimerescheduling<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Work Order associated with Resource Booking.<br />
**DisplayName**: Work Order<br />
**LogicalName**: msdyn_workorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_Name"></a> Name

**Description**: Type a name for the booking.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Contains the id of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Resource"></a> Resource

**Description**: Shows the resource that is booked.<br />
**DisplayName**: Resource<br />
**LogicalName**: resource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_StageId"></a> StageId

**Description**: Contains the id of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StartTime"></a> StartTime

**Description**: Enter the start date and time of the booking.<br />
**DisplayName**: Start Time<br />
**LogicalName**: starttime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the Bookable Resource Booking<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the Bookable Resource Booking<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Exchange rate for the currency associated with the BookableResourceBooking with respect to the base currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [BookingStatusName](#BKMK_BookingStatusName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [HeaderName](#BKMK_HeaderName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_AgreementBookingDateName](#BKMK_msdyn_AgreementBookingDateName)
- [msdyn_BookingSetupMetadataIdName](#BKMK_msdyn_BookingSetupMetadataIdName)
- [msdyn_projectidName](#BKMK_msdyn_projectidName)
- [msdyn_projectteamidName](#BKMK_msdyn_projectteamidName)
- [msdyn_resourcecategoryidName](#BKMK_msdyn_resourcecategoryidName)
- [msdyn_ResourceGroupName](#BKMK_msdyn_ResourceGroupName)
- [msdyn_ResourceRequirementName](#BKMK_msdyn_ResourceRequirementName)
- [msdyn_TimeGroupDetailSelectedName](#BKMK_msdyn_TimeGroupDetailSelectedName)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ResourceName](#BKMK_ResourceName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BookingStatusName"></a> BookingStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: bookingstatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the record.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Exchange rate for the currency associated with the bookableresourcebooking with respect to the base currency.<br />
**DisplayName**: ExchangeRate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_HeaderName"></a> HeaderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: headername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the record.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AgreementBookingDateName"></a> msdyn_AgreementBookingDateName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementbookingdatename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_BookingSetupMetadataIdName"></a> msdyn_BookingSetupMetadataIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_bookingsetupmetadataidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_projectidName"></a> msdyn_projectidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_projectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_projectteamidName"></a> msdyn_projectteamidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_projectteamidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_resourcecategoryidName"></a> msdyn_resourcecategoryidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcecategoryidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ResourceGroupName"></a> msdyn_ResourceGroupName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcegroupname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ResourceRequirementName"></a> msdyn_ResourceRequirementName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcerequirementname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_TimeGroupDetailSelectedName"></a> msdyn_TimeGroupDetailSelectedName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_timegroupdetailselectedname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

**Added by**: Field Service Solution<br />
**Description**: Value of the Total Cost in base currency.<br />
**DisplayName**: Total Cost (Base)<br />
**LogicalName**: msdyn_totalcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ResourceName"></a> ResourceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: resourcename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [bookableresourcebooking_ActivityPointers](#BKMK_bookableresourcebooking_ActivityPointers)
- [BookableResourceBooking_SyncErrors](#BKMK_BookableResourceBooking_SyncErrors)
- [bookableresourcebooking_DuplicateMatchingRecord](#BKMK_bookableresourcebooking_DuplicateMatchingRecord)
- [bookableresourcebooking_DuplicateBaseRecord](#BKMK_bookableresourcebooking_DuplicateBaseRecord)
- [bookableresourcebooking_AsyncOperations](#BKMK_bookableresourcebooking_AsyncOperations)
- [bookableresourcebooking_MailboxTrackingFolders](#BKMK_bookableresourcebooking_MailboxTrackingFolders)
- [bookableresourcebooking_UserEntityInstanceDatas](#BKMK_bookableresourcebooking_UserEntityInstanceDatas)
- [bookableresourcebooking_ProcessSession](#BKMK_bookableresourcebooking_ProcessSession)
- [bookableresourcebooking_BulkDeleteFailures](#BKMK_bookableresourcebooking_BulkDeleteFailures)
- [bookableresourcebooking_PrincipalObjectAttributeAccess](#BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess)
- [bookableresourcebooking_Appointments](#BKMK_bookableresourcebooking_Appointments)
- [bookableresourcebooking_Emails](#BKMK_bookableresourcebooking_Emails)
- [bookableresourcebooking_Faxes](#BKMK_bookableresourcebooking_Faxes)
- [bookableresourcebooking_Letters](#BKMK_bookableresourcebooking_Letters)
- [bookableresourcebooking_PhoneCalls](#BKMK_bookableresourcebooking_PhoneCalls)
- [bookableresourcebooking_Tasks](#BKMK_bookableresourcebooking_Tasks)
- [bookableresourcebooking_RecurringAppointmentMasters](#BKMK_bookableresourcebooking_RecurringAppointmentMasters)
- [bookableresourcebooking_SocialActivities](#BKMK_bookableresourcebooking_SocialActivities)
- [bookableresourcebooking_Annotations](#BKMK_bookableresourcebooking_Annotations)
- [bookableresourcebooking_BulkOperations](#BKMK_bookableresourcebooking_BulkOperations)
- [bookableresourcebooking_CampaignActivities](#BKMK_bookableresourcebooking_CampaignActivities)
- [bookableresourcebooking_CampaignResponses](#BKMK_bookableresourcebooking_CampaignResponses)
- [bookableresourcebooking_IncidentResolutions](#BKMK_bookableresourcebooking_IncidentResolutions)
- [bookableresourcebooking_ServiceAppointments](#BKMK_bookableresourcebooking_ServiceAppointments)
- [bookableresourcebooking_OpportunityCloses](#BKMK_bookableresourcebooking_OpportunityCloses)
- [bookableresourcebooking_OrderCloses](#BKMK_bookableresourcebooking_OrderCloses)
- [bookableresourcebooking_QuoteCloses](#BKMK_bookableresourcebooking_QuoteCloses)
- [bookableresourcebooking_msdyn_bookingalerts](#BKMK_bookableresourcebooking_msdyn_bookingalerts)
- [bookableresourcebooking_msdyn_approvals](#BKMK_bookableresourcebooking_msdyn_approvals)
- [msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking)
- [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking)
- [msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking)
- [msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking)
- [msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking)
- [msdyn_bookableresourcebooking_msdyn_rtv_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking)
- [msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking)
- [msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking)
- [msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking)


### <a name="BKMK_bookableresourcebooking_ActivityPointers"></a> bookableresourcebooking_ActivityPointers

Same as activitypointer entity [bookableresourcebooking_ActivityPointers](activitypointer.md#BKMK_bookableresourcebooking_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BookableResourceBooking_SyncErrors"></a> BookableResourceBooking_SyncErrors

Same as syncerror entity [BookableResourceBooking_SyncErrors](syncerror.md#BKMK_BookableResourceBooking_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BookableResourceBooking_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_DuplicateMatchingRecord"></a> bookableresourcebooking_DuplicateMatchingRecord

Same as duplicaterecord entity [bookableresourcebooking_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcebooking_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bookableresourcebooking_DuplicateBaseRecord"></a> bookableresourcebooking_DuplicateBaseRecord

Same as duplicaterecord entity [bookableresourcebooking_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcebooking_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bookableresourcebooking_AsyncOperations"></a> bookableresourcebooking_AsyncOperations

Same as asyncoperation entity [bookableresourcebooking_AsyncOperations](asyncoperation.md#BKMK_bookableresourcebooking_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bookableresourcebooking_MailboxTrackingFolders"></a> bookableresourcebooking_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [bookableresourcebooking_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcebooking_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_UserEntityInstanceDatas"></a> bookableresourcebooking_UserEntityInstanceDatas

Same as userentityinstancedata entity [bookableresourcebooking_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_bookableresourcebooking_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bookableresourcebooking_ProcessSession"></a> bookableresourcebooking_ProcessSession

Same as processsession entity [bookableresourcebooking_ProcessSession](processsession.md#BKMK_bookableresourcebooking_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bookableresourcebooking_BulkDeleteFailures"></a> bookableresourcebooking_BulkDeleteFailures

Same as bulkdeletefailure entity [bookableresourcebooking_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcebooking_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess"></a> bookableresourcebooking_PrincipalObjectAttributeAccess

Same as principalobjectattributeaccess entity [bookableresourcebooking_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bookableresourcebooking_Appointments"></a> bookableresourcebooking_Appointments

Same as appointment entity [bookableresourcebooking_Appointments](appointment.md#BKMK_bookableresourcebooking_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_Emails"></a> bookableresourcebooking_Emails

Same as email entity [bookableresourcebooking_Emails](email.md#BKMK_bookableresourcebooking_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_Faxes"></a> bookableresourcebooking_Faxes

Same as fax entity [bookableresourcebooking_Faxes](fax.md#BKMK_bookableresourcebooking_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_Letters"></a> bookableresourcebooking_Letters

Same as letter entity [bookableresourcebooking_Letters](letter.md#BKMK_bookableresourcebooking_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_PhoneCalls"></a> bookableresourcebooking_PhoneCalls

Same as phonecall entity [bookableresourcebooking_PhoneCalls](phonecall.md#BKMK_bookableresourcebooking_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_PhoneCalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_Tasks"></a> bookableresourcebooking_Tasks

Same as task entity [bookableresourcebooking_Tasks](task.md#BKMK_bookableresourcebooking_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_RecurringAppointmentMasters"></a> bookableresourcebooking_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [bookableresourcebooking_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_bookableresourcebooking_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_SocialActivities"></a> bookableresourcebooking_SocialActivities

Same as socialactivity entity [bookableresourcebooking_SocialActivities](socialactivity.md#BKMK_bookableresourcebooking_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_Annotations"></a> bookableresourcebooking_Annotations

Same as annotation entity [bookableresourcebooking_Annotations](annotation.md#BKMK_bookableresourcebooking_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_Annotations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_BulkOperations"></a> bookableresourcebooking_BulkOperations

Same as bulkoperation entity [bookableresourcebooking_BulkOperations](bulkoperation.md#BKMK_bookableresourcebooking_BulkOperations) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_BulkOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_CampaignActivities"></a> bookableresourcebooking_CampaignActivities

Same as campaignactivity entity [bookableresourcebooking_CampaignActivities](campaignactivity.md#BKMK_bookableresourcebooking_CampaignActivities) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_CampaignActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_CampaignResponses"></a> bookableresourcebooking_CampaignResponses

Same as campaignresponse entity [bookableresourcebooking_CampaignResponses](campaignresponse.md#BKMK_bookableresourcebooking_CampaignResponses) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_CampaignResponses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_IncidentResolutions"></a> bookableresourcebooking_IncidentResolutions

Same as incidentresolution entity [bookableresourcebooking_IncidentResolutions](incidentresolution.md#BKMK_bookableresourcebooking_IncidentResolutions) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_IncidentResolutions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_ServiceAppointments"></a> bookableresourcebooking_ServiceAppointments

Same as serviceappointment entity [bookableresourcebooking_ServiceAppointments](serviceappointment.md#BKMK_bookableresourcebooking_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_OpportunityCloses"></a> bookableresourcebooking_OpportunityCloses

Same as opportunityclose entity [bookableresourcebooking_OpportunityCloses](opportunityclose.md#BKMK_bookableresourcebooking_OpportunityCloses) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_OpportunityCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_OrderCloses"></a> bookableresourcebooking_OrderCloses

Same as orderclose entity [bookableresourcebooking_OrderCloses](orderclose.md#BKMK_bookableresourcebooking_OrderCloses) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_OrderCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_QuoteCloses"></a> bookableresourcebooking_QuoteCloses

Same as quoteclose entity [bookableresourcebooking_QuoteCloses](quoteclose.md#BKMK_bookableresourcebooking_QuoteCloses) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_QuoteCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_msdyn_bookingalerts"></a> bookableresourcebooking_msdyn_bookingalerts

Same as msdyn_bookingalert entity [bookableresourcebooking_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_bookableresourcebooking_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_msdyn_bookingalerts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebooking_msdyn_approvals"></a> bookableresourcebooking_msdyn_approvals

Same as msdyn_approval entity [bookableresourcebooking_msdyn_approvals](msdyn_approval.md#BKMK_bookableresourcebooking_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebooking_msdyn_approvals<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking"></a> msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking

Same as msdyn_bookingjournal entity [msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking](msdyn_bookingjournal.md#BKMK_msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingjournal<br />
**ReferencingAttribute**: msdyn_booking<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking"></a> msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking

Same as msdyn_bookingtimestamp entity [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](msdyn_bookingtimestamp.md#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingtimestamp<br />
**ReferencingAttribute**: msdyn_booking<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking

Same as msdyn_purchaseorder entity [msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking](msdyn_purchaseorder.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorder<br />
**ReferencingAttribute**: msdyn_booking<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking

Same as msdyn_purchaseorderproduct entity [msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking](msdyn_purchaseorderproduct.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderproduct<br />
**ReferencingAttribute**: msdyn_associatetobooking<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceiptproduct<br />
**ReferencingAttribute**: msdyn_associatetobooking<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking"></a> msdyn_bookableresourcebooking_msdyn_rtv_Booking

Same as msdyn_rtv entity [msdyn_bookableresourcebooking_msdyn_rtv_Booking](msdyn_rtv.md#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: msdyn_booking<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcebooking_msdyn_rtv_Booking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking

Same as msdyn_workorderproduct entity [msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](msdyn_workorderproduct.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: msdyn_booking<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservice_Booking

Same as msdyn_workorderservice entity [msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](msdyn_workorderservice.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: msdyn_booking<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcebooking_msdyn_workorderservice_Booking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking

Same as msdyn_workorderservicetask entity [msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](msdyn_workorderservicetask.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservicetask<br />
**ReferencingAttribute**: msdyn_booking<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_bookableresourcebooking_createdby](#BKMK_lk_bookableresourcebooking_createdby)
- [lk_bookableresourcebooking_createdonbehalfby](#BKMK_lk_bookableresourcebooking_createdonbehalfby)
- [lk_bookableresourcebooking_modifiedby](#BKMK_lk_bookableresourcebooking_modifiedby)
- [lk_bookableresourcebooking_modifiedonbehalfby](#BKMK_lk_bookableresourcebooking_modifiedonbehalfby)
- [user_bookableresourcebooking](#BKMK_user_bookableresourcebooking)
- [team_bookableresourcebooking](#BKMK_team_bookableresourcebooking)
- [business_unit_bookableresourcebooking](#BKMK_business_unit_bookableresourcebooking)
- [processstage_BookableResourceBooking](#BKMK_processstage_BookableResourceBooking)
- [bookableresource_bookableresourcebooking_Resource](#BKMK_bookableresource_bookableresourcebooking_Resource)
- [bookableresourcebookingheader_bookableresourcebooking_Header](#BKMK_bookableresourcebookingheader_bookableresourcebooking_Header)
- [bookingstatus_bookableresourcebooking_BookingStatus](#BKMK_bookingstatus_bookableresourcebooking_BookingStatus)
- [TransactionCurrency_bookableresourcebooking](#BKMK_TransactionCurrency_bookableresourcebooking)
- [msdyn_bookableresource_bookableresourcebooking_ResourceGroup](#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup)
- [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking)
- [msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected](#BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected)
- [msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement](#BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement)
- [msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid](#BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid)
- [msdyn_msdyn_project_bookableresourcebooking_projectid](#BKMK_msdyn_msdyn_project_bookableresourcebooking_projectid)
- [msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid](#BKMK_msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid)
- [msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate](#BKMK_msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate)
- [msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder)


### <a name="BKMK_lk_bookableresourcebooking_createdby"></a> lk_bookableresourcebooking_createdby

See systemuser Entity [lk_bookableresourcebooking_createdby](systemuser.md#BKMK_lk_bookableresourcebooking_createdby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebooking_createdonbehalfby"></a> lk_bookableresourcebooking_createdonbehalfby

See systemuser Entity [lk_bookableresourcebooking_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcebooking_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebooking_modifiedby"></a> lk_bookableresourcebooking_modifiedby

See systemuser Entity [lk_bookableresourcebooking_modifiedby](systemuser.md#BKMK_lk_bookableresourcebooking_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebooking_modifiedonbehalfby"></a> lk_bookableresourcebooking_modifiedonbehalfby

See systemuser Entity [lk_bookableresourcebooking_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcebooking_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_bookableresourcebooking"></a> user_bookableresourcebooking

See systemuser Entity [user_bookableresourcebooking](systemuser.md#BKMK_user_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_team_bookableresourcebooking"></a> team_bookableresourcebooking

See team Entity [team_bookableresourcebooking](team.md#BKMK_team_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_business_unit_bookableresourcebooking"></a> business_unit_bookableresourcebooking

See businessunit Entity [business_unit_bookableresourcebooking](businessunit.md#BKMK_business_unit_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_processstage_BookableResourceBooking"></a> processstage_BookableResourceBooking

See processstage Entity [processstage_BookableResourceBooking](processstage.md#BKMK_processstage_BookableResourceBooking) One-To-Many relationship.

### <a name="BKMK_bookableresource_bookableresourcebooking_Resource"></a> bookableresource_bookableresourcebooking_Resource

See bookableresource Entity [bookableresource_bookableresourcebooking_Resource](bookableresource.md#BKMK_bookableresource_bookableresourcebooking_Resource) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_bookableresourcebooking_Header"></a> bookableresourcebookingheader_bookableresourcebooking_Header

See bookableresourcebookingheader Entity [bookableresourcebookingheader_bookableresourcebooking_Header](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_bookableresourcebooking_Header) One-To-Many relationship.

### <a name="BKMK_bookingstatus_bookableresourcebooking_BookingStatus"></a> bookingstatus_bookableresourcebooking_BookingStatus

See bookingstatus Entity [bookingstatus_bookableresourcebooking_BookingStatus](bookingstatus.md#BKMK_bookingstatus_bookableresourcebooking_BookingStatus) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_bookableresourcebooking"></a> TransactionCurrency_bookableresourcebooking

See transactioncurrency Entity [TransactionCurrency_bookableresourcebooking](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup"></a> msdyn_bookableresource_bookableresourcebooking_ResourceGroup

See bookableresource Entity [msdyn_bookableresource_bookableresourcebooking_ResourceGroup](bookableresource.md#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking"></a> msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking

See msdyn_bookingsetupmetadata Entity [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](msdyn_bookingsetupmetadata.md#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected"></a> msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected

See msdyn_timegroupdetail Entity [msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected](msdyn_timegroupdetail.md#BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement"></a> msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid"></a> msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_bookableresourcebooking_projectid"></a> msdyn_msdyn_project_bookableresourcebooking_projectid

See msdyn_project Entity [msdyn_msdyn_project_bookableresourcebooking_projectid](msdyn_project.md#BKMK_msdyn_msdyn_project_bookableresourcebooking_projectid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid"></a> msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid

See msdyn_projectteam Entity [msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid](msdyn_projectteam.md#BKMK_msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate"></a> msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate

See msdyn_agreementbookingdate Entity [msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder"></a> msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bookableresourcebooking?text=bookableresourcebooking EntityType" />