---
title: "msdyn_agreementbookingsetup Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_agreementbookingsetup entity."
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
# msdyn_agreementbookingsetup Entity Reference

Specify the maintenance bookings for the agreement.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_agreementbookingsetups|
|DisplayCollectionName|Agreement Booking Setups|
|DisplayName|Agreement Booking Setup|
|EntitySetName|msdyn_agreementbookingsetups|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_agreementbookingsetups|
|LogicalName|msdyn_agreementbookingsetup|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_agreementbookingsetupid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_agreementbookingsetup|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|--------|-----|
|Description|Shows the sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

|Property|Value|
|--------|-----|
|Description|Agreement this Booking Setup relates to|
|DisplayName|Agreement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreement|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_agreement|
|Type|Lookup|


### <a name="BKMK_msdyn_agreementbookingsetupId"></a> msdyn_agreementbookingsetupId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Agreement Booking Setup|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_agreementbookingsetupid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_AutoGenerateBooking"></a> msdyn_AutoGenerateBooking

|Property|Value|
|--------|-----|
|Description|Enable if the system should automatically generate Order Bookings for the Booking Dates of this Booking Setup|
|DisplayName|Auto Generate Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_autogeneratebooking|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_AutoGenerateBooking Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_AutoGenerateWO"></a> msdyn_AutoGenerateWO

|Property|Value|
|--------|-----|
|Description|Enable if the system should automatically generate Work Orders for the Booking Dates of this Booking Setup|
|DisplayName|Auto Generate Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_autogeneratewo|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_AutoGenerateWO Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|--------|-----|
|Description|Type a description of this booking setup.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_EstimatedDuration"></a> msdyn_EstimatedDuration

|Property|Value|
|--------|-----|
|Description|Shows the duration of the booking.|
|DisplayName|Estimated Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_GenerateWODaysInAdvance"></a> msdyn_GenerateWODaysInAdvance

|Property|Value|
|--------|-----|
|Description|Specify how many days in advance of the Booking Date the system should automatically generate a Work Order|
|DisplayName|Generate Work Order Days In Advance|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_generatewodaysinadvance|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

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

|Property|Value|
|--------|-----|
|Description|Only used when Work Location is a Facility. Latitude is used when trying to locate nearby facilities.|
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

|Property|Value|
|--------|-----|
|Description|Only used when Work Location is a Facility. Longitude is used when trying to locate nearby facilities.|
|DisplayName|Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_PostBookingFlexibility"></a> msdyn_PostBookingFlexibility

|Property|Value|
|--------|-----|
|Description|Shows the flexibility of days after the booking date.|
|DisplayName|Post Booking Flexibility|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postbookingflexibility|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_PostponeGenerationUntil"></a> msdyn_PostponeGenerationUntil

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description||
|DisplayName|Postpone Generation Until|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postponegenerationuntil|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_PreBookingFlexibility"></a> msdyn_PreBookingFlexibility

|Property|Value|
|--------|-----|
|Description|Shows the flexibility of days prior to the booking date.|
|DisplayName|Pre Booking Flexibility|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_prebookingflexibility|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_PreferredResource"></a> msdyn_PreferredResource

|Property|Value|
|--------|-----|
|Description|Preferred Resource to booked|
|DisplayName|Preferred Resource|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_preferredresource|
|RequiredLevel|None|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_msdyn_PreferredStartTime"></a> msdyn_PreferredStartTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the preferred time to booking.|
|DisplayName|Preferred Start Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_preferredstarttime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_Priority"></a> msdyn_Priority

|Property|Value|
|--------|-----|
|Description|Booking Priority|
|DisplayName|Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_priority|
|RequiredLevel|None|
|Targets|msdyn_priority|
|Type|Lookup|


### <a name="BKMK_msdyn_RecurrenceSettings"></a> msdyn_RecurrenceSettings

|Property|Value|
|--------|-----|
|Description|Stores the booking recurrence settings.|
|DisplayName|Recurrence Settings|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_recurrencesettings|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_Revision"></a> msdyn_Revision

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Revision|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_revision|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_TimeWindowEnd"></a> msdyn_TimeWindowEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the time window up until when this can be booked.|
|DisplayName|Time Window End|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timewindowend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_TimeWindowStart"></a> msdyn_TimeWindowStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the time window from when this can be booked.|
|DisplayName|Time Window Start|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timewindowstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_WorkLocation"></a> msdyn_WorkLocation

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



### <a name="BKMK_msdyn_WorkOrderSummary"></a> msdyn_WorkOrderSummary

|Property|Value|
|--------|-----|
|Description|Shows the work order summary to be set on the work orders generated.|
|DisplayName|Work Order Summary|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workordersummary|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_WorkOrderType"></a> msdyn_WorkOrderType

|Property|Value|
|--------|-----|
|Description|Work Order Type to be used on generated Work Orders|
|DisplayName|Work Order Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workordertype|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_workordertype|
|Type|Lookup|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

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


### <a name="BKMK_processid"></a> processid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Contains the ID of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_stageid"></a> stageid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Contains the ID of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Agreement Booking Setup|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Agreement Booking Setup|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

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


### <a name="BKMK_traversedpath"></a> traversedpath

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.|
|DisplayName|Traversed Path|
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
|Description|Shows the time zone code that was in use when the record was created.|
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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_AgreementName](#BKMK_msdyn_AgreementName)
- [msdyn_PreferredResourceName](#BKMK_msdyn_PreferredResourceName)
- [msdyn_PriorityName](#BKMK_msdyn_PriorityName)
- [msdyn_WorkOrderTypeName](#BKMK_msdyn_WorkOrderTypeName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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


### <a name="BKMK_msdyn_AgreementName"></a> msdyn_AgreementName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PreferredResourceName"></a> msdyn_PreferredResourceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_preferredresourcename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PriorityName"></a> msdyn_PriorityName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_priorityname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderTypeName"></a> msdyn_WorkOrderTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workordertypename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

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

- [msdyn_agreementbookingsetup_ActivityPointers](#BKMK_msdyn_agreementbookingsetup_ActivityPointers)
- [msdyn_agreementbookingsetup_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts)
- [msdyn_agreementbookingsetup_msdyn_approvals](#BKMK_msdyn_agreementbookingsetup_msdyn_approvals)
- [msdyn_agreementbookingsetup_SyncErrors](#BKMK_msdyn_agreementbookingsetup_SyncErrors)
- [msdyn_agreementbookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord)
- [msdyn_agreementbookingsetup_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord)
- [msdyn_agreementbookingsetup_SharePointDocumentLocations](#BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations)
- [msdyn_agreementbookingsetup_AsyncOperations](#BKMK_msdyn_agreementbookingsetup_AsyncOperations)
- [msdyn_agreementbookingsetup_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders)
- [msdyn_agreementbookingsetup_ProcessSession](#BKMK_msdyn_agreementbookingsetup_ProcessSession)
- [msdyn_agreementbookingsetup_BulkDeleteFailures](#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures)
- [msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingsetup_Appointments](#BKMK_msdyn_agreementbookingsetup_Appointments)
- [msdyn_agreementbookingsetup_Emails](#BKMK_msdyn_agreementbookingsetup_Emails)
- [msdyn_agreementbookingsetup_Faxes](#BKMK_msdyn_agreementbookingsetup_Faxes)
- [msdyn_agreementbookingsetup_Letters](#BKMK_msdyn_agreementbookingsetup_Letters)
- [msdyn_agreementbookingsetup_PhoneCalls](#BKMK_msdyn_agreementbookingsetup_PhoneCalls)
- [msdyn_agreementbookingsetup_Tasks](#BKMK_msdyn_agreementbookingsetup_Tasks)
- [msdyn_agreementbookingsetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters)
- [msdyn_agreementbookingsetup_SocialActivities](#BKMK_msdyn_agreementbookingsetup_SocialActivities)
- [msdyn_agreementbookingsetup_connections1](#BKMK_msdyn_agreementbookingsetup_connections1)
- [msdyn_agreementbookingsetup_connections2](#BKMK_msdyn_agreementbookingsetup_connections2)
- [msdyn_agreementbookingsetup_QueueItems](#BKMK_msdyn_agreementbookingsetup_QueueItems)
- [msdyn_agreementbookingsetup_Annotations](#BKMK_msdyn_agreementbookingsetup_Annotations)
- [msdyn_agreementbookingsetup_ServiceAppointments](#BKMK_msdyn_agreementbookingsetup_ServiceAppointments)
- [bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup)


### <a name="BKMK_msdyn_agreementbookingsetup_ActivityPointers"></a> msdyn_agreementbookingsetup_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_agreementbookingsetup_ActivityPointers](activitypointer.md#BKMK_msdyn_agreementbookingsetup_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts"></a> msdyn_agreementbookingsetup_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_agreementbookingsetup_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_approvals"></a> msdyn_agreementbookingsetup_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_agreementbookingsetup_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_agreementbookingsetup_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_SyncErrors"></a> msdyn_agreementbookingsetup_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_agreementbookingsetup_SyncErrors](syncerror.md#BKMK_msdyn_agreementbookingsetup_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord"></a> msdyn_agreementbookingsetup_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_agreementbookingsetup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord"></a> msdyn_agreementbookingsetup_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_agreementbookingsetup_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations"></a> msdyn_agreementbookingsetup_SharePointDocumentLocations

**Added by**: System Solution Solution

Same as sharepointdocumentlocation entity [msdyn_agreementbookingsetup_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_AsyncOperations"></a> msdyn_agreementbookingsetup_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_agreementbookingsetup_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreementbookingsetup_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders"></a> msdyn_agreementbookingsetup_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_agreementbookingsetup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_ProcessSession"></a> msdyn_agreementbookingsetup_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_agreementbookingsetup_ProcessSession](processsession.md#BKMK_msdyn_agreementbookingsetup_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures"></a> msdyn_agreementbookingsetup_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_agreementbookingsetup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_Appointments"></a> msdyn_agreementbookingsetup_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_agreementbookingsetup_Appointments](appointment.md#BKMK_msdyn_agreementbookingsetup_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_Emails"></a> msdyn_agreementbookingsetup_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_agreementbookingsetup_Emails](email.md#BKMK_msdyn_agreementbookingsetup_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_Faxes"></a> msdyn_agreementbookingsetup_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_agreementbookingsetup_Faxes](fax.md#BKMK_msdyn_agreementbookingsetup_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_Letters"></a> msdyn_agreementbookingsetup_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_agreementbookingsetup_Letters](letter.md#BKMK_msdyn_agreementbookingsetup_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_PhoneCalls"></a> msdyn_agreementbookingsetup_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_agreementbookingsetup_PhoneCalls](phonecall.md#BKMK_msdyn_agreementbookingsetup_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_Tasks"></a> msdyn_agreementbookingsetup_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_agreementbookingsetup_Tasks](task.md#BKMK_msdyn_agreementbookingsetup_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters"></a> msdyn_agreementbookingsetup_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_agreementbookingsetup_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_SocialActivities"></a> msdyn_agreementbookingsetup_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_agreementbookingsetup_SocialActivities](socialactivity.md#BKMK_msdyn_agreementbookingsetup_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_connections1"></a> msdyn_agreementbookingsetup_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_agreementbookingsetup_connections1](connection.md#BKMK_msdyn_agreementbookingsetup_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_connections2"></a> msdyn_agreementbookingsetup_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_agreementbookingsetup_connections2](connection.md#BKMK_msdyn_agreementbookingsetup_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_QueueItems"></a> msdyn_agreementbookingsetup_QueueItems

**Added by**: System Solution Solution

Same as queueitem entity [msdyn_agreementbookingsetup_QueueItems](queueitem.md#BKMK_msdyn_agreementbookingsetup_QueueItems) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_QueueItems|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreementbookingsetup_Annotations"></a> msdyn_agreementbookingsetup_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_agreementbookingsetup_Annotations](annotation.md#BKMK_msdyn_agreementbookingsetup_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreementbookingsetup_ServiceAppointments"></a> msdyn_agreementbookingsetup_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_agreementbookingsetup_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreementbookingsetup_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreementbookingsetup_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

Same as msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 entity [bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3|
|ReferencingAttribute|bpf_msdyn_agreementbookingsetupid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: msdyn_agreementbookingsetup<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup

Same as msdyn_agreementbookingdate entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingdate|
|ReferencingAttribute|msdyn_bookingsetup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Booking Dates<br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup

Same as msdyn_agreementbookingincident entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingincident|
|ReferencingAttribute|msdyn_agreementbookingsetup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Incidents<br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup

Same as msdyn_agreementbookingproduct entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingproduct|
|ReferencingAttribute|msdyn_agreementbookingsetup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Products<br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup

Same as msdyn_agreementbookingservice entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservice|
|ReferencingAttribute|msdyn_agreementbookingsetup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Services<br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup

Same as msdyn_agreementbookingservicetask entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservicetask|
|ReferencingAttribute|msdyn_agreementbookingsetup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Service Tasks<br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_agreementbookingsetup_createdby](#BKMK_lk_msdyn_agreementbookingsetup_createdby)
- [lk_msdyn_agreementbookingsetup_createdonbehalfby](#BKMK_lk_msdyn_agreementbookingsetup_createdonbehalfby)
- [lk_msdyn_agreementbookingsetup_modifiedby](#BKMK_lk_msdyn_agreementbookingsetup_modifiedby)
- [lk_msdyn_agreementbookingsetup_modifiedonbehalfby](#BKMK_lk_msdyn_agreementbookingsetup_modifiedonbehalfby)
- [user_msdyn_agreementbookingsetup](#BKMK_user_msdyn_agreementbookingsetup)
- [team_msdyn_agreementbookingsetup](#BKMK_team_msdyn_agreementbookingsetup)
- [business_unit_msdyn_agreementbookingsetup](#BKMK_business_unit_msdyn_agreementbookingsetup)
- [processstage_msdyn_agreementbookingsetup](#BKMK_processstage_msdyn_agreementbookingsetup)
- [msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource)
- [msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement)
- [msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority](#BKMK_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority)
- [msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType)


### <a name="BKMK_lk_msdyn_agreementbookingsetup_createdby"></a> lk_msdyn_agreementbookingsetup_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_agreementbookingsetup_createdby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementbookingsetup_createdonbehalfby"></a> lk_msdyn_agreementbookingsetup_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_agreementbookingsetup_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementbookingsetup_modifiedby"></a> lk_msdyn_agreementbookingsetup_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_agreementbookingsetup_modifiedby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementbookingsetup_modifiedonbehalfby"></a> lk_msdyn_agreementbookingsetup_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_agreementbookingsetup_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_agreementbookingsetup"></a> user_msdyn_agreementbookingsetup

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_agreementbookingsetup](systemuser.md#BKMK_user_msdyn_agreementbookingsetup) One-To-Many relationship.

### <a name="BKMK_team_msdyn_agreementbookingsetup"></a> team_msdyn_agreementbookingsetup

**Added by**: System Solution Solution

See team Entity [team_msdyn_agreementbookingsetup](team.md#BKMK_team_msdyn_agreementbookingsetup) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_agreementbookingsetup"></a> business_unit_msdyn_agreementbookingsetup

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_agreementbookingsetup](businessunit.md#BKMK_business_unit_msdyn_agreementbookingsetup) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_agreementbookingsetup"></a> processstage_msdyn_agreementbookingsetup

**Added by**: System Solution Solution

See processstage Entity [processstage_msdyn_agreementbookingsetup](processstage.md#BKMK_processstage_msdyn_agreementbookingsetup) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource"></a> msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource

**Added by**: Scheduling Solution

See bookableresource Entity [msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority"></a> msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority

**Added by**: Universal Resource Scheduling Solution

See msdyn_priority Entity [msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority](msdyn_priority.md#BKMK_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType

See msdyn_workordertype Entity [msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_agreementbookingsetup?text=msdyn_agreementbookingsetup EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]