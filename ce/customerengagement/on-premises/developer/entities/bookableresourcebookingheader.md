---
title: "BookableResourceBookingHeader entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the BookableResourceBookingHeader entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# BookableResourceBookingHeader entity reference

Reservation entity representing the summary of the associated resource bookings.

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
|CollectionSchemaName|BookableResourceBookingHeader|
|DisplayCollectionName|Bookable Resource Booking Headers|
|DisplayName|Bookable Resource Booking Header|
|EntitySetName|bookableresourcebookingheaders|
|IsBPFEntity|False|
|LogicalCollectionName|bookableresourcebookingheaders|
|LogicalName|bookableresourcebookingheader|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|bookableresourcebookingheaderid|
|PrimaryNameAttribute|name|
|SchemaName|BookableResourceBookingHeader|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceBookingHeaderId](#BKMK_BookableResourceBookingHeaderId)
- [Duration](#BKMK_Duration)
- [EndTime](#BKMK_EndTime)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ProcessId](#BKMK_ProcessId)
- [StageId](#BKMK_StageId)
- [StartTime](#BKMK_StartTime)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BookableResourceBookingHeaderId"></a> BookableResourceBookingHeaderId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the resource booking header.|
|DisplayName|Bookable Resource Booking Header|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|bookableresourcebookingheaderid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|--------|-----|
|Description|Shows the aggregate duration of the linked bookings.|
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
|Description|Shows the end date and time of the booking summary.|
|DisplayName|End Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|endtime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


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
|Description|The name of the booking summary.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
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
|Description|Shows the start date and time of the booking summary.|
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
|Description|Status of the Bookable Resource Booking Header|
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
|Description|Reason for the status of the Bookable Resource Booking Header|
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
|Description|Exchange rate for the currency associated with the BookableResourceBookingHeader with respect to the base currency.|
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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
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
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


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
|Description|Exchange rate for the currency associated with the bookableresourcebookingheader with respect to the base currency.|
|DisplayName|ExchangeRate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


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

- [bookableresourcebookingheader_ActivityPointers](#BKMK_bookableresourcebookingheader_ActivityPointers)
- [BookableResourceBookingHeader_SyncErrors](#BKMK_BookableResourceBookingHeader_SyncErrors)
- [bookableresourcebookingheader_DuplicateMatchingRecord](#BKMK_bookableresourcebookingheader_DuplicateMatchingRecord)
- [bookableresourcebookingheader_DuplicateBaseRecord](#BKMK_bookableresourcebookingheader_DuplicateBaseRecord)
- [bookableresourcebookingheader_AsyncOperations](#BKMK_bookableresourcebookingheader_AsyncOperations)
- [bookableresourcebookingheader_MailboxTrackingFolders](#BKMK_bookableresourcebookingheader_MailboxTrackingFolders)
- [bookableresourcebookingheader_ProcessSession](#BKMK_bookableresourcebookingheader_ProcessSession)
- [bookableresourcebookingheader_BulkDeleteFailures](#BKMK_bookableresourcebookingheader_BulkDeleteFailures)
- [bookableresourcebookingheader_PrincipalObjectAttributeAccess](#BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess)
- [bookableresourcebookingheader_Appointments](#BKMK_bookableresourcebookingheader_Appointments)
- [bookableresourcebookingheader_Emails](#BKMK_bookableresourcebookingheader_Emails)
- [bookableresourcebookingheader_Faxes](#BKMK_bookableresourcebookingheader_Faxes)
- [bookableresourcebookingheader_Letters](#BKMK_bookableresourcebookingheader_Letters)
- [bookableresourcebookingheader_PhoneCalls](#BKMK_bookableresourcebookingheader_PhoneCalls)
- [bookableresourcebookingheader_Tasks](#BKMK_bookableresourcebookingheader_Tasks)
- [bookableresourcebookingheader_RecurringAppointmentMasters](#BKMK_bookableresourcebookingheader_RecurringAppointmentMasters)
- [bookableresourcebookingheader_SocialActivities](#BKMK_bookableresourcebookingheader_SocialActivities)
- [bookableresourcebookingheader_Annotations](#BKMK_bookableresourcebookingheader_Annotations)
- [bookableresourcebookingheader_bookableresourcebooking_Header](#BKMK_bookableresourcebookingheader_bookableresourcebooking_Header)
- [bookableresourcebookingheader_BulkOperations](#BKMK_bookableresourcebookingheader_BulkOperations)
- [bookableresourcebookingheader_CampaignActivities](#BKMK_bookableresourcebookingheader_CampaignActivities)
- [bookableresourcebookingheader_CampaignResponses](#BKMK_bookableresourcebookingheader_CampaignResponses)
- [bookableresourcebookingheader_IncidentResolutions](#BKMK_bookableresourcebookingheader_IncidentResolutions)
- [bookableresourcebookingheader_ServiceAppointments](#BKMK_bookableresourcebookingheader_ServiceAppointments)
- [bookableresourcebookingheader_OpportunityCloses](#BKMK_bookableresourcebookingheader_OpportunityCloses)
- [bookableresourcebookingheader_OrderCloses](#BKMK_bookableresourcebookingheader_OrderCloses)
- [bookableresourcebookingheader_QuoteCloses](#BKMK_bookableresourcebookingheader_QuoteCloses)


### <a name="BKMK_bookableresourcebookingheader_ActivityPointers"></a> bookableresourcebookingheader_ActivityPointers

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_ActivityPointers](activitypointer.md#BKMK_bookableresourcebookingheader_ActivityPointers) many-to-one relationship for the [activitypointer](activitypointer.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 20|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BookableResourceBookingHeader_SyncErrors"></a> BookableResourceBookingHeader_SyncErrors

**Added by**: System Solution Solution

Same as the [BookableResourceBookingHeader_SyncErrors](syncerror.md#BKMK_BookableResourceBookingHeader_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|BookableResourceBookingHeader_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_DuplicateMatchingRecord"></a> bookableresourcebookingheader_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcebookingheader_DuplicateMatchingRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebookingheader_DuplicateBaseRecord"></a> bookableresourcebookingheader_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcebookingheader_DuplicateBaseRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebookingheader_AsyncOperations"></a> bookableresourcebookingheader_AsyncOperations

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_AsyncOperations](asyncoperation.md#BKMK_bookableresourcebookingheader_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebookingheader_MailboxTrackingFolders"></a> bookableresourcebookingheader_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcebookingheader_MailboxTrackingFolders) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_ProcessSession"></a> bookableresourcebookingheader_ProcessSession

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_ProcessSession](processsession.md#BKMK_bookableresourcebookingheader_ProcessSession) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_ProcessSession|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebookingheader_BulkDeleteFailures"></a> bookableresourcebookingheader_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcebookingheader_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess"></a> bookableresourcebookingheader_PrincipalObjectAttributeAccess

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcebookingheader_Appointments"></a> bookableresourcebookingheader_Appointments

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_Appointments](appointment.md#BKMK_bookableresourcebookingheader_Appointments) many-to-one relationship for the [appointment](appointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_Appointments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_Emails"></a> bookableresourcebookingheader_Emails

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_Emails](email.md#BKMK_bookableresourcebookingheader_Emails) many-to-one relationship for the [email](email.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_Emails|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_Faxes"></a> bookableresourcebookingheader_Faxes

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_Faxes](fax.md#BKMK_bookableresourcebookingheader_Faxes) many-to-one relationship for the [fax](fax.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_Faxes|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_Letters"></a> bookableresourcebookingheader_Letters

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_Letters](letter.md#BKMK_bookableresourcebookingheader_Letters) many-to-one relationship for the [letter](letter.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_Letters|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_PhoneCalls"></a> bookableresourcebookingheader_PhoneCalls

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_PhoneCalls](phonecall.md#BKMK_bookableresourcebookingheader_PhoneCalls) many-to-one relationship for the [phonecall](phonecall.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_Tasks"></a> bookableresourcebookingheader_Tasks

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_Tasks](task.md#BKMK_bookableresourcebookingheader_Tasks) many-to-one relationship for the [task](task.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_Tasks|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_RecurringAppointmentMasters"></a> bookableresourcebookingheader_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_bookableresourcebookingheader_RecurringAppointmentMasters) many-to-one relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_SocialActivities"></a> bookableresourcebookingheader_SocialActivities

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_SocialActivities](socialactivity.md#BKMK_bookableresourcebookingheader_SocialActivities) many-to-one relationship for the [socialactivity](socialactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_SocialActivities|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_Annotations"></a> bookableresourcebookingheader_Annotations

**Added by**: System Solution Solution

Same as the [bookableresourcebookingheader_Annotations](annotation.md#BKMK_bookableresourcebookingheader_Annotations) many-to-one relationship for the [annotation](annotation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_Annotations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_bookableresourcebooking_Header"></a> bookableresourcebookingheader_bookableresourcebooking_Header

Same as the [bookableresourcebookingheader_bookableresourcebooking_Header](bookableresourcebooking.md#BKMK_bookableresourcebookingheader_bookableresourcebooking_Header) many-to-one relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebooking|
|ReferencingAttribute|header|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_bookableresourcebooking_Header|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_BulkOperations"></a> bookableresourcebookingheader_BulkOperations

**Added by**: Marketing Solution

Same as the [bookableresourcebookingheader_BulkOperations](bulkoperation.md#BKMK_bookableresourcebookingheader_BulkOperations) many-to-one relationship for the [bulkoperation](bulkoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_BulkOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_CampaignActivities"></a> bookableresourcebookingheader_CampaignActivities

**Added by**: Marketing Solution

Same as the [bookableresourcebookingheader_CampaignActivities](campaignactivity.md#BKMK_bookableresourcebookingheader_CampaignActivities) many-to-one relationship for the [campaignactivity](campaignactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_CampaignActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_CampaignResponses"></a> bookableresourcebookingheader_CampaignResponses

**Added by**: Marketing Solution

Same as the [bookableresourcebookingheader_CampaignResponses](campaignresponse.md#BKMK_bookableresourcebookingheader_CampaignResponses) many-to-one relationship for the [campaignresponse](campaignresponse.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_CampaignResponses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_IncidentResolutions"></a> bookableresourcebookingheader_IncidentResolutions

**Added by**: Service Solution

Same as the [bookableresourcebookingheader_IncidentResolutions](incidentresolution.md#BKMK_bookableresourcebookingheader_IncidentResolutions) many-to-one relationship for the [incidentresolution](incidentresolution.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_IncidentResolutions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_ServiceAppointments"></a> bookableresourcebookingheader_ServiceAppointments

**Added by**: Service Solution

Same as the [bookableresourcebookingheader_ServiceAppointments](serviceappointment.md#BKMK_bookableresourcebookingheader_ServiceAppointments) many-to-one relationship for the [serviceappointment](serviceappointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_OpportunityCloses"></a> bookableresourcebookingheader_OpportunityCloses

**Added by**: Sales Solution

Same as the [bookableresourcebookingheader_OpportunityCloses](opportunityclose.md#BKMK_bookableresourcebookingheader_OpportunityCloses) many-to-one relationship for the [opportunityclose](opportunityclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_OrderCloses"></a> bookableresourcebookingheader_OrderCloses

**Added by**: Sales Solution

Same as the [bookableresourcebookingheader_OrderCloses](orderclose.md#BKMK_bookableresourcebookingheader_OrderCloses) many-to-one relationship for the [orderclose](orderclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcebookingheader_QuoteCloses"></a> bookableresourcebookingheader_QuoteCloses

**Added by**: Sales Solution

Same as the [bookableresourcebookingheader_QuoteCloses](quoteclose.md#BKMK_bookableresourcebookingheader_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcebookingheader_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_bookableresourcebookingheader_createdby](#BKMK_lk_bookableresourcebookingheader_createdby)
- [lk_bookableresourcebookingheader_createdonbehalfby](#BKMK_lk_bookableresourcebookingheader_createdonbehalfby)
- [lk_bookableresourcebookingheader_modifiedby](#BKMK_lk_bookableresourcebookingheader_modifiedby)
- [lk_bookableresourcebookingheader_modifiedonbehalfby](#BKMK_lk_bookableresourcebookingheader_modifiedonbehalfby)
- [user_bookableresourcebookingheader](#BKMK_user_bookableresourcebookingheader)
- [team_bookableresourcebookingheader](#BKMK_team_bookableresourcebookingheader)
- [business_unit_bookableresourcebookingheader](#BKMK_business_unit_bookableresourcebookingheader)
- [processstage_BookableResourceBookingHeader](#BKMK_processstage_BookableResourceBookingHeader)
- [TransactionCurrency_bookableresourcebookingheader](#BKMK_TransactionCurrency_bookableresourcebookingheader)


### <a name="BKMK_lk_bookableresourcebookingheader_createdby"></a> lk_bookableresourcebookingheader_createdby

**Added by**: System Solution Solution

See the [lk_bookableresourcebookingheader_createdby](systemuser.md#BKMK_lk_bookableresourcebookingheader_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_bookableresourcebookingheader_createdonbehalfby"></a> lk_bookableresourcebookingheader_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_bookableresourcebookingheader_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcebookingheader_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_bookableresourcebookingheader_modifiedby"></a> lk_bookableresourcebookingheader_modifiedby

**Added by**: System Solution Solution

See the [lk_bookableresourcebookingheader_modifiedby](systemuser.md#BKMK_lk_bookableresourcebookingheader_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_bookableresourcebookingheader_modifiedonbehalfby"></a> lk_bookableresourcebookingheader_modifiedonbehalfby

**Added by**: System Solution Solution

See the [lk_bookableresourcebookingheader_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcebookingheader_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_user_bookableresourcebookingheader"></a> user_bookableresourcebookingheader

**Added by**: System Solution Solution

See the [user_bookableresourcebookingheader](systemuser.md#BKMK_user_bookableresourcebookingheader) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_team_bookableresourcebookingheader"></a> team_bookableresourcebookingheader

**Added by**: System Solution Solution

See the [team_bookableresourcebookingheader](team.md#BKMK_team_bookableresourcebookingheader) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_business_unit_bookableresourcebookingheader"></a> business_unit_bookableresourcebookingheader

**Added by**: System Solution Solution

See the [business_unit_bookableresourcebookingheader](businessunit.md#BKMK_business_unit_bookableresourcebookingheader) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_processstage_BookableResourceBookingHeader"></a> processstage_BookableResourceBookingHeader

**Added by**: System Solution Solution

See the [processstage_BookableResourceBookingHeader](processstage.md#BKMK_processstage_BookableResourceBookingHeader) one-to-many relationship for the [processstage](processstage.md) entity.

### <a name="BKMK_TransactionCurrency_bookableresourcebookingheader"></a> TransactionCurrency_bookableresourcebookingheader

**Added by**: System Solution Solution

See the [TransactionCurrency_bookableresourcebookingheader](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcebookingheader) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
