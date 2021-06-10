---
title: "BookableResourceBooking Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BookableResourceBooking entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# BookableResourceBooking Entity Reference

Represents the line details of a resource booking.

**Added by**: Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookings(*bookableresourcebookingid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/bookableresourcebookings<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
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

## Entity Properties

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

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
- [msdyn_BookingMethod](#BKMK_msdyn_BookingMethod)
- [msdyn_BookingSetupMetadataId](#BKMK_msdyn_BookingSetupMetadataId)
- [msdyn_CascadeCrewChanges](#BKMK_msdyn_CascadeCrewChanges)
- [msdyn_effort](#BKMK_msdyn_effort)
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
- [msdyn_requirementgroupid](#BKMK_msdyn_requirementgroupid)
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

#### BookingType Options

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

#### msdyn_AcceptCascadeCrewChanges Options

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
|Description|Shows the total travel duration. If you leave this field blank the system automatically determines the travel duration by calculating the resource journal details.|
|DisplayName|Actual Travel Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actualtravelduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_AgreementBookingDate"></a> msdyn_AgreementBookingDate

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Agreement Booking Date from where this Booking was generated|
|DisplayName|Agreement Booking Date|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingdate|
|RequiredLevel|None|
|Targets|msdyn_agreementbookingdate|
|Type|Lookup|


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

#### msdyn_AllowOverlapping Options

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

#### msdyn_BookingMethod Options

|Value|Label|
|-----|-----|
|690970001|Schedule Board|
|690970002|Mobile|
|690970003|Manual|
|690970004|Schedule Assistant|
|690970005|System - Agreement Schedule|



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

#### msdyn_CascadeCrewChanges Options

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


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Internal Flags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_internalflags|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_msdyn_OfflineTimestamp"></a> msdyn_OfflineTimestamp

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Internal Use. This field is used to capture the time when the Booking was updated on mobile offline.|
|DisplayName|Offline Timestamp|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_offlinetimestamp|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_PreventTimestampCreation"></a> msdyn_PreventTimestampCreation

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Prevents time stamp creation if the time stamp was already created on a mobile device.|
|DisplayName|Prevent Timestamp Creation|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_preventtimestampcreation|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_PreventTimestampCreation Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_projectid"></a> msdyn_projectid

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Project of booking detail record|
|DisplayName|Project|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_projectid|
|RequiredLevel|None|
|Targets|msdyn_project|
|Type|Lookup|


### <a name="BKMK_msdyn_projectteamid"></a> msdyn_projectteamid

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Project team member of booking detail record|
|DisplayName|Project Team Member|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_projectteamid|
|RequiredLevel|None|
|Targets|msdyn_projectteam|
|Type|Lookup|


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


### <a name="BKMK_msdyn_resourcecategoryid"></a> msdyn_resourcecategoryid

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Resource Category|
|DisplayName|Resource Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategoryid|
|RequiredLevel|None|
|Targets|bookableresourcecategory|
|Type|Lookup|


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


### <a name="BKMK_msdyn_Signature"></a> msdyn_Signature

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|This field is used for capturing signature on Mobile (using the Pen Control)|
|DisplayName|Signature|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_signature|
|MaxLength|15000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_SlotText"></a> msdyn_SlotText

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Shows the automatically generated text of the time slot on the schedule board.|
|DisplayName|Slot Text|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_slottext|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_msdyn_TotalBillableDuration"></a> msdyn_TotalBillableDuration

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Shows the total billable duration. If you leave this field blank the system automatically determines the billable duration by calculating the resource journal details.|
|DisplayName|Total Billable Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalbillableduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_TotalBreakDuration"></a> msdyn_TotalBreakDuration

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Shows the total break duration. If you leave this field blank the system automatically determines the break duration by calculating the resource journal details.|
|DisplayName|Total Break Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalbreakduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_TotalCost"></a> msdyn_TotalCost

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Shows the total cost for this booking.|
|DisplayName|Total Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalcost|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_TotalDurationInProgress"></a> msdyn_TotalDurationInProgress

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Shows the total duration that this booking was in progress.|
|DisplayName|Total Duration In Progress|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totaldurationinprogress|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_TravelTimeRescheduling"></a> msdyn_TravelTimeRescheduling

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Travel Time Rescheduling (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_traveltimerescheduling|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_TravelTimeRescheduling Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



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

#### msdyn_WorkLocation Options

|Value|Label|
|-----|-----|
|690970000|Onsite|
|690970001|Facility|
|690970002|Location Agnostic|



### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order associated with Resource Booking.|
|DisplayName|Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorder|
|RequiredLevel|None|
|Targets|msdyn_workorder|
|Type|Lookup|


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

#### StateCode Options

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

#### StatusCode Options

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
- [msdyn_AppointmentBookingIdName](#BKMK_msdyn_AppointmentBookingIdName)
- [msdyn_BookingSetupMetadataIdName](#BKMK_msdyn_BookingSetupMetadataIdName)
- [msdyn_projectidName](#BKMK_msdyn_projectidName)
- [msdyn_projectteamidName](#BKMK_msdyn_projectteamidName)
- [msdyn_requirementgroupidName](#BKMK_msdyn_requirementgroupidName)
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
|MinValue|0.0000000001|
|Precision|10|
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


### <a name="BKMK_msdyn_AgreementBookingDateName"></a> msdyn_AgreementBookingDateName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingdatename|
|MaxLength|100|
|RequiredLevel|None|
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


### <a name="BKMK_msdyn_projectidName"></a> msdyn_projectidName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_projectidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_projectteamidName"></a> msdyn_projectteamidName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_projectteamidname|
|MaxLength|100|
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


### <a name="BKMK_msdyn_resourcecategoryidName"></a> msdyn_resourcecategoryidName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategoryidname|
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


### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Value of the Total Cost in base currency.|
|DisplayName|Total Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workordername|
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
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [bookableresourcebooking_ActivityPointers](#BKMK_bookableresourcebooking_ActivityPointers)
- [BookableResourceBooking_SyncErrors](#BKMK_BookableResourceBooking_SyncErrors)
- [bookableresourcebooking_DuplicateMatchingRecord](#BKMK_bookableresourcebooking_DuplicateMatchingRecord)
- [bookableresourcebooking_DuplicateBaseRecord](#BKMK_bookableresourcebooking_DuplicateBaseRecord)
- [bookableresourcebooking_AsyncOperations](#BKMK_bookableresourcebooking_AsyncOperations)
- [bookableresourcebooking_MailboxTrackingFolders](#BKMK_bookableresourcebooking_MailboxTrackingFolders)
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
- [msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid](#BKMK_msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid)


### <a name="BKMK_bookableresourcebooking_ActivityPointers"></a> bookableresourcebooking_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [bookableresourcebooking_ActivityPointers](activitypointer.md#BKMK_bookableresourcebooking_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BookableResourceBooking_SyncErrors"></a> BookableResourceBooking_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [BookableResourceBooking_SyncErrors](syncerror.md#BKMK_BookableResourceBooking_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|BookableResourceBooking_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_DuplicateMatchingRecord"></a> bookableresourcebooking_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [bookableresourcebooking_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcebooking_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebooking_DuplicateBaseRecord"></a> bookableresourcebooking_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [bookableresourcebooking_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcebooking_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebooking_AsyncOperations"></a> bookableresourcebooking_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [bookableresourcebooking_AsyncOperations](asyncoperation.md#BKMK_bookableresourcebooking_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebooking_MailboxTrackingFolders"></a> bookableresourcebooking_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [bookableresourcebooking_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcebooking_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_ProcessSession"></a> bookableresourcebooking_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [bookableresourcebooking_ProcessSession](processsession.md#BKMK_bookableresourcebooking_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_ProcessSession|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebooking_BulkDeleteFailures"></a> bookableresourcebooking_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [bookableresourcebooking_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcebooking_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess"></a> bookableresourcebooking_PrincipalObjectAttributeAccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [bookableresourcebooking_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebooking_Appointments"></a> bookableresourcebooking_Appointments

**Added by**: System Solution Solution

Same as appointment entity [bookableresourcebooking_Appointments](appointment.md#BKMK_bookableresourcebooking_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_Appointments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_Emails"></a> bookableresourcebooking_Emails

**Added by**: System Solution Solution

Same as email entity [bookableresourcebooking_Emails](email.md#BKMK_bookableresourcebooking_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_Emails|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_Faxes"></a> bookableresourcebooking_Faxes

**Added by**: System Solution Solution

Same as fax entity [bookableresourcebooking_Faxes](fax.md#BKMK_bookableresourcebooking_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_Faxes|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_Letters"></a> bookableresourcebooking_Letters

**Added by**: System Solution Solution

Same as letter entity [bookableresourcebooking_Letters](letter.md#BKMK_bookableresourcebooking_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_Letters|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_PhoneCalls"></a> bookableresourcebooking_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [bookableresourcebooking_PhoneCalls](phonecall.md#BKMK_bookableresourcebooking_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_Tasks"></a> bookableresourcebooking_Tasks

**Added by**: System Solution Solution

Same as task entity [bookableresourcebooking_Tasks](task.md#BKMK_bookableresourcebooking_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_Tasks|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_RecurringAppointmentMasters"></a> bookableresourcebooking_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [bookableresourcebooking_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_bookableresourcebooking_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_SocialActivities"></a> bookableresourcebooking_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [bookableresourcebooking_SocialActivities](socialactivity.md#BKMK_bookableresourcebooking_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_SocialActivities|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_Annotations"></a> bookableresourcebooking_Annotations

**Added by**: System Solution Solution

Same as annotation entity [bookableresourcebooking_Annotations](annotation.md#BKMK_bookableresourcebooking_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_Annotations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_BulkOperations"></a> bookableresourcebooking_BulkOperations

**Added by**: Marketing Solution

Same as bulkoperation entity [bookableresourcebooking_BulkOperations](bulkoperation.md#BKMK_bookableresourcebooking_BulkOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_BulkOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_CampaignActivities"></a> bookableresourcebooking_CampaignActivities

**Added by**: Marketing Solution

Same as campaignactivity entity [bookableresourcebooking_CampaignActivities](campaignactivity.md#BKMK_bookableresourcebooking_CampaignActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_CampaignActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_CampaignResponses"></a> bookableresourcebooking_CampaignResponses

**Added by**: Marketing Solution

Same as campaignresponse entity [bookableresourcebooking_CampaignResponses](campaignresponse.md#BKMK_bookableresourcebooking_CampaignResponses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_CampaignResponses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_IncidentResolutions"></a> bookableresourcebooking_IncidentResolutions

**Added by**: Service Solution

Same as incidentresolution entity [bookableresourcebooking_IncidentResolutions](incidentresolution.md#BKMK_bookableresourcebooking_IncidentResolutions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_IncidentResolutions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_ServiceAppointments"></a> bookableresourcebooking_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [bookableresourcebooking_ServiceAppointments](serviceappointment.md#BKMK_bookableresourcebooking_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_OpportunityCloses"></a> bookableresourcebooking_OpportunityCloses

**Added by**: Sales Solution

Same as opportunityclose entity [bookableresourcebooking_OpportunityCloses](opportunityclose.md#BKMK_bookableresourcebooking_OpportunityCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_OrderCloses"></a> bookableresourcebooking_OrderCloses

**Added by**: Sales Solution

Same as orderclose entity [bookableresourcebooking_OrderCloses](orderclose.md#BKMK_bookableresourcebooking_OrderCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_QuoteCloses"></a> bookableresourcebooking_QuoteCloses

**Added by**: Sales Solution

Same as quoteclose entity [bookableresourcebooking_QuoteCloses](quoteclose.md#BKMK_bookableresourcebooking_QuoteCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_msdyn_bookingalerts"></a> bookableresourcebooking_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [bookableresourcebooking_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_bookableresourcebooking_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebooking_msdyn_approvals"></a> bookableresourcebooking_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [bookableresourcebooking_msdyn_approvals](msdyn_approval.md#BKMK_bookableresourcebooking_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking"></a> msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking

**Added by**: Field Service Solution

Same as msdyn_bookingjournal entity [msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking](msdyn_bookingjournal.md#BKMK_msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingjournal|
|ReferencingAttribute|msdyn_booking|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking"></a> msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking

**Added by**: Field Service Solution

Same as msdyn_bookingtimestamp entity [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](msdyn_bookingtimestamp.md#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingtimestamp|
|ReferencingAttribute|msdyn_booking|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking

**Added by**: Field Service Solution

Same as msdyn_purchaseorder entity [msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking](msdyn_purchaseorder.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorder|
|ReferencingAttribute|msdyn_booking|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking

**Added by**: Field Service Solution

Same as msdyn_purchaseorderproduct entity [msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking](msdyn_purchaseorderproduct.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderproduct|
|ReferencingAttribute|msdyn_associatetobooking|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking

**Added by**: Field Service Solution

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceiptproduct|
|ReferencingAttribute|msdyn_associatetobooking|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking"></a> msdyn_bookableresourcebooking_msdyn_rtv_Booking

**Added by**: Field Service Solution

Same as msdyn_rtv entity [msdyn_bookableresourcebooking_msdyn_rtv_Booking](msdyn_rtv.md#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtv|
|ReferencingAttribute|msdyn_booking|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_rtv_Booking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking

**Added by**: Field Service Solution

Same as msdyn_workorderproduct entity [msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](msdyn_workorderproduct.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|msdyn_booking|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservice_Booking

**Added by**: Field Service Solution

Same as msdyn_workorderservice entity [msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](msdyn_workorderservice.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|msdyn_booking|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_workorderservice_Booking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking

**Added by**: Field Service Solution

Same as msdyn_workorderservicetask entity [msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](msdyn_workorderservicetask.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservicetask|
|ReferencingAttribute|msdyn_booking|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid"></a> msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid

**Added by**: Geofencing for Field Service Solution

Same as msdyn_geofence entity [msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid](msdyn_geofence.md#BKMK_msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_geofence|
|ReferencingAttribute|msdyn_bookableresourcebookingid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcebooking_msdyn_geofence_bookableresourcebookingid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: Geofence to Bookable Resource Booking relationship<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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
- [msdyn_requirementgroup_bookableresourcebooking_requirementgroupid](#BKMK_msdyn_requirementgroup_bookableresourcebooking_requirementgroupid)
- [msdyn_appointment_bookableresourcebooking](#BKMK_msdyn_appointment_bookableresourcebooking)
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

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcebooking_createdby](systemuser.md#BKMK_lk_bookableresourcebooking_createdby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebooking_createdonbehalfby"></a> lk_bookableresourcebooking_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcebooking_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcebooking_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebooking_modifiedby"></a> lk_bookableresourcebooking_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcebooking_modifiedby](systemuser.md#BKMK_lk_bookableresourcebooking_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebooking_modifiedonbehalfby"></a> lk_bookableresourcebooking_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcebooking_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcebooking_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_bookableresourcebooking"></a> user_bookableresourcebooking

**Added by**: System Solution Solution

See systemuser Entity [user_bookableresourcebooking](systemuser.md#BKMK_user_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_team_bookableresourcebooking"></a> team_bookableresourcebooking

**Added by**: System Solution Solution

See team Entity [team_bookableresourcebooking](team.md#BKMK_team_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_business_unit_bookableresourcebooking"></a> business_unit_bookableresourcebooking

**Added by**: System Solution Solution

See businessunit Entity [business_unit_bookableresourcebooking](businessunit.md#BKMK_business_unit_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_processstage_BookableResourceBooking"></a> processstage_BookableResourceBooking

**Added by**: System Solution Solution

See processstage Entity [processstage_BookableResourceBooking](processstage.md#BKMK_processstage_BookableResourceBooking) One-To-Many relationship.

### <a name="BKMK_bookableresource_bookableresourcebooking_Resource"></a> bookableresource_bookableresourcebooking_Resource

See bookableresource Entity [bookableresource_bookableresourcebooking_Resource](bookableresource.md#BKMK_bookableresource_bookableresourcebooking_Resource) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_bookableresourcebooking_Header"></a> bookableresourcebookingheader_bookableresourcebooking_Header

See bookableresourcebookingheader Entity [bookableresourcebookingheader_bookableresourcebooking_Header](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_bookableresourcebooking_Header) One-To-Many relationship.

### <a name="BKMK_bookingstatus_bookableresourcebooking_BookingStatus"></a> bookingstatus_bookableresourcebooking_BookingStatus

See bookingstatus Entity [bookingstatus_bookableresourcebooking_BookingStatus](bookingstatus.md#BKMK_bookingstatus_bookableresourcebooking_BookingStatus) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_bookableresourcebooking"></a> TransactionCurrency_bookableresourcebooking

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_bookableresourcebooking](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementgroup_bookableresourcebooking_requirementgroupid"></a> msdyn_requirementgroup_bookableresourcebooking_requirementgroupid

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementgroup Entity [msdyn_requirementgroup_bookableresourcebooking_requirementgroupid](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_bookableresourcebooking_requirementgroupid) One-To-Many relationship.

### <a name="BKMK_msdyn_appointment_bookableresourcebooking"></a> msdyn_appointment_bookableresourcebooking

**Added by**: System Solution Solution

See appointment Entity [msdyn_appointment_bookableresourcebooking](appointment.md#BKMK_msdyn_appointment_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup"></a> msdyn_bookableresource_bookableresourcebooking_ResourceGroup

See bookableresource Entity [msdyn_bookableresource_bookableresourcebooking_ResourceGroup](bookableresource.md#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking"></a> msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingsetupmetadata Entity [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](msdyn_bookingsetupmetadata.md#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected"></a> msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected](msdyn_timegroupdetail.md#BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement"></a> msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid"></a> msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_bookableresourcebooking_projectid"></a> msdyn_msdyn_project_bookableresourcebooking_projectid

**Added by**: Project Service Automation Solution

See msdyn_project Entity [msdyn_msdyn_project_bookableresourcebooking_projectid](msdyn_project.md#BKMK_msdyn_msdyn_project_bookableresourcebooking_projectid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid"></a> msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid](msdyn_projectteam.md#BKMK_msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate"></a> msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder"></a> msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bookableresourcebooking?text=bookableresourcebooking EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]