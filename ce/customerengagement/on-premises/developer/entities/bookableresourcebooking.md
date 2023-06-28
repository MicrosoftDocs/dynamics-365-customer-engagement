---
title: "BookableResourceBooking entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the BookableResourceBooking entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# BookableResourceBooking entity reference

Represents the line details of a resource booking.

**Added by**: Scheduling Solution


## Messages

|Message|SDK class or method|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

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

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceBookingId](#BKMK_BookableResourceBookingId)
- [BookingStatus](#BKMK_BookingStatus)
- [BookingType](#BKMK_BookingType)
- [Duration](#BKMK_Duration)
- [EndTime](#BKMK_EndTime)
- [Header](#BKMK_Header)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
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

|Value|Label|Description|
|-----|-----|--------|
|1|Solid||
|2|Liquid||



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
|DisplayName|Stage Id|
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


### <a name="BKMK_bookableresourcebooking_ActivityPointers"></a> bookableresourcebooking_ActivityPointers

**Added by**: System Solution Solution

Same as the [bookableresourcebooking_ActivityPointers](activitypointer.md#BKMK_bookableresourcebooking_ActivityPointers) many-to-one relationship for the [activitypointer](activitypointer.md) entity.

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

Same as the [BookableResourceBooking_SyncErrors](syncerror.md#BKMK_BookableResourceBooking_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

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

Same as the [bookableresourcebooking_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcebooking_DuplicateMatchingRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

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

Same as the [bookableresourcebooking_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcebooking_DuplicateBaseRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

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

Same as the [bookableresourcebooking_AsyncOperations](asyncoperation.md#BKMK_bookableresourcebooking_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

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

Same as the [bookableresourcebooking_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcebooking_MailboxTrackingFolders) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

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

Same as the [bookableresourcebooking_ProcessSession](processsession.md#BKMK_bookableresourcebooking_ProcessSession) many-to-one relationship for the [processsession](processsession.md) entity.

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

Same as the [bookableresourcebooking_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcebooking_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

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

Same as the [bookableresourcebooking_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

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

Same as the [bookableresourcebooking_Appointments](appointment.md#BKMK_bookableresourcebooking_Appointments) many-to-one relationship for the [appointment](appointment.md) entity.

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

Same as the [bookableresourcebooking_Emails](email.md#BKMK_bookableresourcebooking_Emails) many-to-one relationship for the [email](email.md) entity.

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

Same as the [bookableresourcebooking_Faxes](fax.md#BKMK_bookableresourcebooking_Faxes) many-to-one relationship for the [fax](fax.md) entity.

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

Same as the [bookableresourcebooking_Letters](letter.md#BKMK_bookableresourcebooking_Letters) many-to-one relationship for the [letter](letter.md) entity.

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

Same as the [bookableresourcebooking_PhoneCalls](phonecall.md#BKMK_bookableresourcebooking_PhoneCalls) many-to-one relationship for the [phonecall](phonecall.md) entity.

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

Same as the [bookableresourcebooking_Tasks](task.md#BKMK_bookableresourcebooking_Tasks) many-to-one relationship for the [task](task.md) entity.

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

Same as the [bookableresourcebooking_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_bookableresourcebooking_RecurringAppointmentMasters) many-to-one relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

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

Same as the [bookableresourcebooking_SocialActivities](socialactivity.md#BKMK_bookableresourcebooking_SocialActivities) many-to-one relationship for the [socialactivity](socialactivity.md) entity.

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

Same as the [bookableresourcebooking_Annotations](annotation.md#BKMK_bookableresourcebooking_Annotations) many-to-one relationship for the [annotation](annotation.md) entity.

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

Same as the [bookableresourcebooking_BulkOperations](bulkoperation.md#BKMK_bookableresourcebooking_BulkOperations) many-to-one relationship for the [bulkoperation](bulkoperation.md) entity.

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

Same as the [bookableresourcebooking_CampaignActivities](campaignactivity.md#BKMK_bookableresourcebooking_CampaignActivities) many-to-one relationship for the [campaignactivity](campaignactivity.md) entity.

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

Same as the [bookableresourcebooking_CampaignResponses](campaignresponse.md#BKMK_bookableresourcebooking_CampaignResponses) many-to-one relationship for the [campaignresponse](campaignresponse.md) entity.

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

Same as the [bookableresourcebooking_IncidentResolutions](incidentresolution.md#BKMK_bookableresourcebooking_IncidentResolutions) many-to-one relationship for the [incidentresolution](incidentresolution.md) entity.

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

Same as the [bookableresourcebooking_ServiceAppointments](serviceappointment.md#BKMK_bookableresourcebooking_ServiceAppointments) many-to-one relationship for the [serviceappointment](serviceappointment.md) entity.

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

Same as the [bookableresourcebooking_OpportunityCloses](opportunityclose.md#BKMK_bookableresourcebooking_OpportunityCloses) many-to-one relationship for the [opportunityclose](opportunityclose.md) entity.

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

Same as the [bookableresourcebooking_OrderCloses](orderclose.md#BKMK_bookableresourcebooking_OrderCloses) many-to-one relationship for the [orderclose](orderclose.md) entity.

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

Same as the [bookableresourcebooking_QuoteCloses](quoteclose.md#BKMK_bookableresourcebooking_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebooking_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

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


### <a name="BKMK_lk_bookableresourcebooking_createdby"></a> lk_bookableresourcebooking_createdby

**Added by**: System Solution Solution

See the [lk_bookableresourcebooking_createdby](systemuser.md#BKMK_lk_bookableresourcebooking_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_bookableresourcebooking_createdonbehalfby"></a> lk_bookableresourcebooking_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_bookableresourcebooking_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcebooking_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_bookableresourcebooking_modifiedby"></a> lk_bookableresourcebooking_modifiedby

**Added by**: System Solution Solution

See the [lk_bookableresourcebooking_modifiedby](systemuser.md#BKMK_lk_bookableresourcebooking_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_bookableresourcebooking_modifiedonbehalfby"></a> lk_bookableresourcebooking_modifiedonbehalfby

**Added by**: System Solution Solution

See the [lk_bookableresourcebooking_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcebooking_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_user_bookableresourcebooking"></a> user_bookableresourcebooking

**Added by**: System Solution Solution

See the [user_bookableresourcebooking](systemuser.md#BKMK_user_bookableresourcebooking) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_team_bookableresourcebooking"></a> team_bookableresourcebooking

**Added by**: System Solution Solution

See the [team_bookableresourcebooking](team.md#BKMK_team_bookableresourcebooking) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_business_unit_bookableresourcebooking"></a> business_unit_bookableresourcebooking

**Added by**: System Solution Solution

See the [business_unit_bookableresourcebooking](businessunit.md#BKMK_business_unit_bookableresourcebooking) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_processstage_BookableResourceBooking"></a> processstage_BookableResourceBooking

**Added by**: System Solution Solution

See the [processstage_BookableResourceBooking](processstage.md#BKMK_processstage_BookableResourceBooking) one-to-many relationship for the [processstage](processstage.md) entity.

### <a name="BKMK_bookableresource_bookableresourcebooking_Resource"></a> bookableresource_bookableresourcebooking_Resource

See the [bookableresource_bookableresourcebooking_Resource](bookableresource.md#BKMK_bookableresource_bookableresourcebooking_Resource) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_bookableresourcebookingheader_bookableresourcebooking_Header"></a> bookableresourcebookingheader_bookableresourcebooking_Header

See the [bookableresourcebookingheader_bookableresourcebooking_Header](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_bookableresourcebooking_Header) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_bookingstatus_bookableresourcebooking_BookingStatus"></a> bookingstatus_bookableresourcebooking_BookingStatus

See the [bookingstatus_bookableresourcebooking_BookingStatus](bookingstatus.md#BKMK_bookingstatus_bookableresourcebooking_BookingStatus) one-to-many relationship for the [bookingstatus](bookingstatus.md) entity.

### <a name="BKMK_TransactionCurrency_bookableresourcebooking"></a> TransactionCurrency_bookableresourcebooking

**Added by**: System Solution Solution

See the [TransactionCurrency_bookableresourcebooking](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcebooking) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
