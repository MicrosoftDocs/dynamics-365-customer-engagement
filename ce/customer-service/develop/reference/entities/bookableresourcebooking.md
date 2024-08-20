---
title: BookableResourceBooking table (Microsoft Dataverse)| MicrosoftDocs
description: Includes schema information and supported messages for the BookableResourceBooking table.
ms.date: 01/20/2024
ms.topic: "reference"
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# BookableResourceBooking table

Represents the line details of a resource booking.

**Added by**: Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/bookableresourcebookings<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref href="Microsoft.Dynamics.CRM.CreateMultiple?text=CreateMultiple Action" />|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|DELETE [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bookableresourcebookings<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref href="Microsoft.Dynamics.CRM.UpdateMultiple?text=UpdateMultiple Action" />|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|BookableResourceBooking|
|DisplayCollectionName|Bookable Resource Bookings|
|DisplayName|Bookable Resource Booking|
|EntitySetName|bookableresourcebookings|
|IsBPFEntity|False|
|LogicalCollectionName|bookableresourcebookings|
|LogicalName|bookableresourcebooking|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|bookableresourcebookingid|
|PrimaryNameAttribute|name|
|SchemaName|BookableResourceBooking|

<a name="writable-attributes"></a>

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
- [msdyn_AllowOverlapping](#BKMK_msdyn_AllowOverlapping)
- [msdyn_AppointmentBookingId](#BKMK_msdyn_AppointmentBookingId)
- [msdyn_BaseTravelDuration](#BKMK_msdyn_BaseTravelDuration)
- [msdyn_BookingMethod](#BKMK_msdyn_BookingMethod)
- [msdyn_BookingSetupMetadataId](#BKMK_msdyn_BookingSetupMetadataId)
- [msdyn_CalendarId](#BKMK_msdyn_CalendarId)
- [msdyn_CascadeCrewChanges](#BKMK_msdyn_CascadeCrewChanges)
- [msdyn_effort](#BKMK_msdyn_effort)
- [msdyn_EstimatedArrivalTime](#BKMK_msdyn_EstimatedArrivalTime)
- [msdyn_EstimatedTravelDuration](#BKMK_msdyn_EstimatedTravelDuration)
- [msdyn_ExternalBookingId](#BKMK_msdyn_ExternalBookingId)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_MilesTraveled](#BKMK_msdyn_MilesTraveled)
- [msdyn_requirementgroupid](#BKMK_msdyn_requirementgroupid)
- [msdyn_requirementgroupset](#BKMK_msdyn_requirementgroupset)
- [msdyn_ResourceGroup](#BKMK_msdyn_ResourceGroup)
- [msdyn_ResourceRequirement](#BKMK_msdyn_ResourceRequirement)
- [msdyn_serviceappointment](#BKMK_msdyn_serviceappointment)
- [msdyn_shiftactivitytype](#BKMK_msdyn_shiftactivitytype)
- [msdyn_shiftplan](#BKMK_msdyn_shiftplan)
- [msdyn_TimeGroupDetailSelected](#BKMK_msdyn_TimeGroupDetailSelected)
- [msdyn_TravelTimeCalculationType](#BKMK_msdyn_TravelTimeCalculationType)
- [msdyn_URSInternalFlags](#BKMK_msdyn_URSInternalFlags)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)
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
|--------|-----|
|Description|Unique identifier of the resource booking.|
|DisplayName|Bookable Resource Booking|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|bookableresourcebookingid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_BookingStatus"></a> BookingStatus

|Property|Value|
|--------|-----|
|Description|Select the status of the booking.|
|DisplayName|Booking Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bookingstatus|
|RequiredLevel|SystemRequired|
|Targets|bookingstatus|
|Type|Lookup|


### <a name="BKMK_BookingType"></a> BookingType

|Property|Value|
|--------|-----|
|Description|Select whether the booking is solid or liquid. Solid bookings are firm and cannot be changed whereas liquid bookings can be changed.|
|DisplayName|Booking Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bookingtype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### BookingType Choices/Options

|Value|Label|
|-----|-----|
|1|Solid|
|2|Liquid|



### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|--------|-----|
|Description|Enter the duration of the booking.|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_EndTime"></a> EndTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the end date and time of the booking.|
|DisplayName|End Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|endtime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_Header"></a> Header

|Property|Value|
|--------|-----|
|Description|Shows the reference to the booking header record that represents the summary of bookings.|
|DisplayName|Header|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|header|
|RequiredLevel|None|
|Targets|bookableresourcebookingheader|
|Type|Lookup|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_AcceptCascadeCrewChanges"></a> msdyn_AcceptCascadeCrewChanges

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Defines whether this booking accepts changes propagated as cascading changes|
|DisplayName|Accept Cascade Crew Changes|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_acceptcascadecrewchanges|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_AcceptCascadeCrewChanges Choices/Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_ActualArrivalTime"></a> msdyn_ActualArrivalTime

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the time that work started.|
|DisplayName|Actual Arrival Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actualarrivaltime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_ActualTravelDuration"></a> msdyn_ActualTravelDuration

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Shows the total travel duration. Calculated based on the difference between the Bookable Resource Booking's start time and actual arrival time.|
|DisplayName|Actual Travel Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actualtravelduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_AllowOverlapping"></a> msdyn_AllowOverlapping

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Allow the time of this booking to be displayed on the schedule assistant as available.|
|DisplayName|Allow Overlapping|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_allowoverlapping|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_AllowOverlapping Choices/Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_AppointmentBookingId"></a> msdyn_AppointmentBookingId

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Appointment associated with Bookable Resource Booking.|
|DisplayName|Appointment Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_appointmentbookingid|
|RequiredLevel|None|
|Targets|appointment|
|Type|Lookup|


### <a name="BKMK_msdyn_BaseTravelDuration"></a> msdyn_BaseTravelDuration

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|The Base travel duration indicates the travel time without traffic|
|DisplayName|Base Travel Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_basetravelduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_BookingMethod"></a> msdyn_BookingMethod

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Shows the method used to create this booking.|
|DisplayName|Booking Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookingmethod|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_BookingMethod Choices/Options

|Value|Label|
|-----|-----|
|192350000|Resource Scheduling Optimization|
|690970001|Schedule Board|
|690970002|Mobile|
|690970003|Manual|
|690970004|Schedule Assistant|



### <a name="BKMK_msdyn_BookingSetupMetadataId"></a> msdyn_BookingSetupMetadataId

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|A unique identifier for the booking setup metadata that is associated with a bookable resource booking.|
|DisplayName|Booking Setup Metadata|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookingsetupmetadataid|
|RequiredLevel|None|
|Targets|msdyn_bookingsetupmetadata|
|Type|Lookup|


### <a name="BKMK_msdyn_CalendarId"></a> msdyn_CalendarId

**Added by**: Workforce Engagement Management for Customer Service Solution

|Property|Value|
|--------|-----|
|Description|For internal use. The inner calendar id and the calendar rule id to which the shift booking has been synced to. This will be blank if the booking has not yet been synced.|
|DisplayName|Calendar Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_calendarid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CascadeCrewChanges"></a> msdyn_CascadeCrewChanges

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Defines whether changing any of the following fields (Start Time, End Time, Status) should cascade the changes to other bookings on this requirement that have the same start and end time.|
|DisplayName|Cascade Crew Changes|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_cascadecrewchanges|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_CascadeCrewChanges Choices/Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_effort"></a> msdyn_effort

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Capacity that needs to take from resource capacity|
|DisplayName|Capacity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_effort|
|MaxValue|1000000000|
|MinValue|0.0001|
|Precision|4|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_EstimatedArrivalTime"></a> msdyn_EstimatedArrivalTime

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Estimated Arrival Time|
|DisplayName|Estimated Arrival Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedarrivaltime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_EstimatedTravelDuration"></a> msdyn_EstimatedTravelDuration

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Estimated Travel Duration|
|DisplayName|Estimated Travel Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedtravelduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_ExternalBookingId"></a> msdyn_ExternalBookingId

**Added by**: Workforce Engagement Management for Customer Service Solution

|Property|Value|
|--------|-----|
|Description|A tracking id from external system where this this booking was imported from.|
|DisplayName|External Booking Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_externalbookingid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_MilesTraveled"></a> msdyn_MilesTraveled

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|In this field you can enter the total miles the resource drove to the job site|
|DisplayName|Miles Traveled|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_milestraveled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_requirementgroupid"></a> msdyn_requirementgroupid

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Requirement Group|
|DisplayName|Requirement Group|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requirementgroupid|
|RequiredLevel|None|
|Targets|msdyn_requirementgroup|
|Type|Lookup|


### <a name="BKMK_msdyn_requirementgroupset"></a> msdyn_requirementgroupset

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Requirement Group Set|
|DisplayName|Requirement Group Set|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requirementgroupset|
|MaxLength|40|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ResourceGroup"></a> msdyn_ResourceGroup

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Resource associated with Resource Booking|
|DisplayName|Resource Group|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcegroup|
|RequiredLevel|None|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_msdyn_ResourceRequirement"></a> msdyn_ResourceRequirement

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Resource Requirement|
|DisplayName|Resource Requirement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcerequirement|
|RequiredLevel|None|
|Targets|msdyn_resourcerequirement|
|Type|Lookup|


### <a name="BKMK_msdyn_serviceappointment"></a> msdyn_serviceappointment

**Added by**: Core Service Scheduling - Base Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Service Appointment associated with Resource Booking.|
|DisplayName|Service Activity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_serviceappointment|
|RequiredLevel|None|
|Targets|serviceappointment|
|Type|Lookup|


### <a name="BKMK_msdyn_shiftactivitytype"></a> msdyn_shiftactivitytype

**Added by**: Workforce Engagement Management for Customer Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Shift Activity Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_shiftactivitytype|
|RequiredLevel|None|
|Targets|msdyn_shiftactivitytype|
|Type|Lookup|


### <a name="BKMK_msdyn_shiftplan"></a> msdyn_shiftplan

**Added by**: Workforce Engagement Management for Customer Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Shift Plan|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_shiftplan|
|RequiredLevel|None|
|Targets|msdyn_shiftplan|
|Type|Lookup|


### <a name="BKMK_msdyn_TimeGroupDetailSelected"></a> msdyn_TimeGroupDetailSelected

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Time Group Detail Selected|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timegroupdetailselected|
|RequiredLevel|None|
|Targets|msdyn_timegroupdetail|
|Type|Lookup|


### <a name="BKMK_msdyn_TravelTimeCalculationType"></a> msdyn_TravelTimeCalculationType

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|Travel Time Calculation|
|DisplayName|Travel Time Calculation|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_traveltimecalculationtype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_TravelTimeCalculationType Choices/Options

|Value|Label|
|-----|-----|
|192350000|Bing Maps without historical traffic|
|192350001|Bing Maps with historical traffic|
|192350002|Custom Map Provider|
|192350003|Approximate|



### <a name="BKMK_msdyn_URSInternalFlags"></a> msdyn_URSInternalFlags

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Internal Flags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ursinternalflags|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_WorkLocation"></a> msdyn_WorkLocation

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Work Location|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_worklocation|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_WorkLocation Choices/Options

|Value|Label|
|-----|-----|
|690970000|Onsite|
|690970001|Facility|
|690970002|Location Agnostic|



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a name for the booking.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Contains the id of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Resource"></a> Resource

|Property|Value|
|--------|-----|
|Description|Shows the resource that is booked.|
|DisplayName|Resource|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resource|
|RequiredLevel|SystemRequired|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|(Deprecated) Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StartTime"></a> StartTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the start date and time of the booking.|
|DisplayName|Start Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|starttime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the Bookable Resource Booking|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Bookable Resource Booking|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the BookableResourceBooking with respect to the base currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
|DisplayName|(Deprecated) Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

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
- [msdyn_AppointmentBookingIdName](#BKMK_msdyn_AppointmentBookingIdName)
- [msdyn_BookingSetupMetadataIdName](#BKMK_msdyn_BookingSetupMetadataIdName)
- [msdyn_requirementgroupidName](#BKMK_msdyn_requirementgroupidName)
- [msdyn_ResourceGroupName](#BKMK_msdyn_ResourceGroupName)
- [msdyn_ResourceRequirementName](#BKMK_msdyn_ResourceRequirementName)
- [msdyn_serviceappointmentName](#BKMK_msdyn_serviceappointmentName)
- [msdyn_shiftactivitytypeName](#BKMK_msdyn_shiftactivitytypeName)
- [msdyn_shiftplanName](#BKMK_msdyn_shiftplanName)
- [msdyn_TimeGroupDetailSelectedName](#BKMK_msdyn_TimeGroupDetailSelectedName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ResourceName](#BKMK_ResourceName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BookingStatusName"></a> BookingStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bookingstatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the bookableresourcebooking with respect to the base currency.|
|DisplayName|ExchangeRate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.000000000001|
|Precision|12|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_HeaderName"></a> HeaderName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|headername|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_AppointmentBookingIdName"></a> msdyn_AppointmentBookingIdName

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_appointmentbookingidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_BookingSetupMetadataIdName"></a> msdyn_BookingSetupMetadataIdName

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_bookingsetupmetadataidname|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_requirementgroupidName"></a> msdyn_requirementgroupidName

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_requirementgroupidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ResourceGroupName"></a> msdyn_ResourceGroupName

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcegroupname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ResourceRequirementName"></a> msdyn_ResourceRequirementName

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcerequirementname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_serviceappointmentName"></a> msdyn_serviceappointmentName

**Added by**: Core Service Scheduling - Base Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceappointmentname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_shiftactivitytypeName"></a> msdyn_shiftactivitytypeName

**Added by**: Workforce Engagement Management for Customer Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_shiftactivitytypename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_shiftplanName"></a> msdyn_shiftplanName

**Added by**: Workforce Engagement Management for Customer Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_shiftplanname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TimeGroupDetailSelectedName"></a> msdyn_TimeGroupDetailSelectedName

**Added by**: Universal Resource Scheduling Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_timegroupdetailselectedname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ResourceName"></a> ResourceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|resourcename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|



### Related information

[Omnichannel for Customer Service entity reference](../entities/overview-entity-ref.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
