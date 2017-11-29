---
title: "BookableResourceBookingHeader Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BookableResourceBookingHeader entity."
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
# BookableResourceBookingHeader Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Shows the reservation table where the summary of resource bookings are persisted.

**Added by**: Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookingheaders(*bookableresourcebookingheaderid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/bookableresourcebookingheaders<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/bookableresourcebookingheaders(*bookableresourcebookingheaderid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bookableresourcebookingheaders(*bookableresourcebookingheaderid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bookableresourcebookingheaders<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookingheaders(*bookableresourcebookingheaderid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookingheaders(*bookableresourcebookingheaderid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Bookable Resource Booking Header<br />
**DisplayCollectionName**: Bookable Resource Booking Headers<br />
**SchemaName**: BookableResourceBookingHeader<br />
**CollectionSchemaName**: BookableResourceBookingHeader<br />
**LogicalName**: bookableresourcebookingheader<br />
**LogicalCollectionName**: bookableresourcebookingheaders<br />
**EntitySetName**: bookableresourcebookingheaders<br />
**PrimaryIdAttribute**: bookableresourcebookingheaderid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceBookingHeaderId](#BKMK_BookableResourceBookingHeaderId)
- [Duration](#BKMK_Duration)
- [EndTime](#BKMK_EndTime)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_bookableresourceid](#BKMK_msdyn_bookableresourceid)
- [msdyn_bookingstatusid](#BKMK_msdyn_bookingstatusid)
- [msdyn_BookingType](#BKMK_msdyn_BookingType)
- [msdyn_projectid](#BKMK_msdyn_projectid)
- [msdyn_projectteamid](#BKMK_msdyn_projectteamid)
- [msdyn_resourcecategoryid](#BKMK_msdyn_resourcecategoryid)
- [msdyn_ResourceRequirement](#BKMK_msdyn_ResourceRequirement)
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

**Description**: Unique identifier of the resource booking header.<br />
**DisplayName**: Bookable Resource Booking Header<br />
**LogicalName**: bookableresourcebookingheaderid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Duration"></a> Duration

**Description**: Shows the aggregate duration of the linked bookings.<br />
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

**Description**: Shows the end date and time of the booking summary.<br />
**DisplayName**: End Time<br />
**LogicalName**: endtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


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


### <a name="BKMK_msdyn_bookableresourceid"></a> msdyn_bookableresourceid

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Shows the resource.<br />
**DisplayName**: Bookable Resource<br />
**LogicalName**: msdyn_bookableresourceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_bookingstatusid"></a> msdyn_bookingstatusid

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Booking Status<br />
**DisplayName**: Booking Status<br />
**LogicalName**: msdyn_bookingstatusid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookingstatus


### <a name="BKMK_msdyn_BookingType"></a> msdyn_BookingType

**Added by**: Unified Resource Scheduling Solution<br />
**Description**: Select whether the booking is solid or liquid. Solid bookings are firm and cannot be changed whereas liquid bookings can be changed.<br />
**DisplayName**: Booking Type<br />
**LogicalName**: msdyn_bookingtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Solid
- **Value**: 2 **Label**: Liquid



### <a name="BKMK_msdyn_projectid"></a> msdyn_projectid

**Added by**: Project Service Automation Solution<br />
**Description**: Project<br />
**DisplayName**: Project<br />
**LogicalName**: msdyn_projectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_project


### <a name="BKMK_msdyn_projectteamid"></a> msdyn_projectteamid

**Added by**: Project Service Automation Solution<br />
**Description**: Project Team<br />
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


### <a name="BKMK_Name"></a> Name

**Description**: The name of the booking summary.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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


### <a name="BKMK_StageId"></a> StageId

**Description**: Contains the id of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StartTime"></a> StartTime

**Description**: Shows the start date and time of the booking summary.<br />
**DisplayName**: Start Time<br />
**LogicalName**: starttime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the Bookable Resource Booking Header<br />
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

**Description**: Reason for the status of the Bookable Resource Booking Header<br />
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

**Description**: Exchange rate for the currency associated with the BookableResourceBookingHeader with respect to the base currency.<br />
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
- [msdyn_bookableresourceidName](#BKMK_msdyn_bookableresourceidName)
- [msdyn_bookingstatusidName](#BKMK_msdyn_bookingstatusidName)
- [msdyn_projectidName](#BKMK_msdyn_projectidName)
- [msdyn_projectteamidName](#BKMK_msdyn_projectteamidName)
- [msdyn_resourcecategoryidName](#BKMK_msdyn_resourcecategoryidName)
- [msdyn_ResourceRequirementName](#BKMK_msdyn_ResourceRequirementName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


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

**Description**: Exchange rate for the currency associated with the bookableresourcebookingheader with respect to the base currency.<br />
**DisplayName**: ExchangeRate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


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


### <a name="BKMK_msdyn_bookableresourceidName"></a> msdyn_bookableresourceidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_bookableresourceidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_bookingstatusidName"></a> msdyn_bookingstatusidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_bookingstatusidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [bookableresourcebookingheader_ActivityPointers](#BKMK_bookableresourcebookingheader_ActivityPointers)
- [BookableResourceBookingHeader_SyncErrors](#BKMK_BookableResourceBookingHeader_SyncErrors)
- [bookableresourcebookingheader_DuplicateMatchingRecord](#BKMK_bookableresourcebookingheader_DuplicateMatchingRecord)
- [bookableresourcebookingheader_DuplicateBaseRecord](#BKMK_bookableresourcebookingheader_DuplicateBaseRecord)
- [bookableresourcebookingheader_AsyncOperations](#BKMK_bookableresourcebookingheader_AsyncOperations)
- [bookableresourcebookingheader_MailboxTrackingFolders](#BKMK_bookableresourcebookingheader_MailboxTrackingFolders)
- [bookableresourcebookingheader_UserEntityInstanceDatas](#BKMK_bookableresourcebookingheader_UserEntityInstanceDatas)
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
- [bookableresourcebookingheader_msdyn_bookingalerts](#BKMK_bookableresourcebookingheader_msdyn_bookingalerts)
- [bookableresourcebookingheader_msdyn_approvals](#BKMK_bookableresourcebookingheader_msdyn_approvals)


### <a name="BKMK_bookableresourcebookingheader_ActivityPointers"></a> bookableresourcebookingheader_ActivityPointers

Same as activitypointer entity [bookableresourcebookingheader_ActivityPointers](activitypointer.md#BKMK_bookableresourcebookingheader_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 20

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BookableResourceBookingHeader_SyncErrors"></a> BookableResourceBookingHeader_SyncErrors

Same as syncerror entity [BookableResourceBookingHeader_SyncErrors](syncerror.md#BKMK_BookableResourceBookingHeader_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BookableResourceBookingHeader_SyncErrors<br />
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


### <a name="BKMK_bookableresourcebookingheader_DuplicateMatchingRecord"></a> bookableresourcebookingheader_DuplicateMatchingRecord

Same as duplicaterecord entity [bookableresourcebookingheader_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcebookingheader_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_DuplicateMatchingRecord<br />
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


### <a name="BKMK_bookableresourcebookingheader_DuplicateBaseRecord"></a> bookableresourcebookingheader_DuplicateBaseRecord

Same as duplicaterecord entity [bookableresourcebookingheader_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcebookingheader_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_DuplicateBaseRecord<br />
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


### <a name="BKMK_bookableresourcebookingheader_AsyncOperations"></a> bookableresourcebookingheader_AsyncOperations

Same as asyncoperation entity [bookableresourcebookingheader_AsyncOperations](asyncoperation.md#BKMK_bookableresourcebookingheader_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_AsyncOperations<br />
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


### <a name="BKMK_bookableresourcebookingheader_MailboxTrackingFolders"></a> bookableresourcebookingheader_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [bookableresourcebookingheader_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcebookingheader_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_MailboxTrackingFolders<br />
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


### <a name="BKMK_bookableresourcebookingheader_UserEntityInstanceDatas"></a> bookableresourcebookingheader_UserEntityInstanceDatas

Same as userentityinstancedata entity [bookableresourcebookingheader_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_bookableresourcebookingheader_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_UserEntityInstanceDatas<br />
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


### <a name="BKMK_bookableresourcebookingheader_ProcessSession"></a> bookableresourcebookingheader_ProcessSession

Same as processsession entity [bookableresourcebookingheader_ProcessSession](processsession.md#BKMK_bookableresourcebookingheader_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_ProcessSession<br />
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


### <a name="BKMK_bookableresourcebookingheader_BulkDeleteFailures"></a> bookableresourcebookingheader_BulkDeleteFailures

Same as bulkdeletefailure entity [bookableresourcebookingheader_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcebookingheader_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_BulkDeleteFailures<br />
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


### <a name="BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess"></a> bookableresourcebookingheader_PrincipalObjectAttributeAccess

Same as principalobjectattributeaccess entity [bookableresourcebookingheader_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_bookableresourcebookingheader_Appointments"></a> bookableresourcebookingheader_Appointments

Same as appointment entity [bookableresourcebookingheader_Appointments](appointment.md#BKMK_bookableresourcebookingheader_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_Appointments<br />
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


### <a name="BKMK_bookableresourcebookingheader_Emails"></a> bookableresourcebookingheader_Emails

Same as email entity [bookableresourcebookingheader_Emails](email.md#BKMK_bookableresourcebookingheader_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_Emails<br />
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


### <a name="BKMK_bookableresourcebookingheader_Faxes"></a> bookableresourcebookingheader_Faxes

Same as fax entity [bookableresourcebookingheader_Faxes](fax.md#BKMK_bookableresourcebookingheader_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_Faxes<br />
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


### <a name="BKMK_bookableresourcebookingheader_Letters"></a> bookableresourcebookingheader_Letters

Same as letter entity [bookableresourcebookingheader_Letters](letter.md#BKMK_bookableresourcebookingheader_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_Letters<br />
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


### <a name="BKMK_bookableresourcebookingheader_PhoneCalls"></a> bookableresourcebookingheader_PhoneCalls

Same as phonecall entity [bookableresourcebookingheader_PhoneCalls](phonecall.md#BKMK_bookableresourcebookingheader_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_PhoneCalls<br />
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


### <a name="BKMK_bookableresourcebookingheader_Tasks"></a> bookableresourcebookingheader_Tasks

Same as task entity [bookableresourcebookingheader_Tasks](task.md#BKMK_bookableresourcebookingheader_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_Tasks<br />
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


### <a name="BKMK_bookableresourcebookingheader_RecurringAppointmentMasters"></a> bookableresourcebookingheader_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [bookableresourcebookingheader_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_bookableresourcebookingheader_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_RecurringAppointmentMasters<br />
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


### <a name="BKMK_bookableresourcebookingheader_SocialActivities"></a> bookableresourcebookingheader_SocialActivities

Same as socialactivity entity [bookableresourcebookingheader_SocialActivities](socialactivity.md#BKMK_bookableresourcebookingheader_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_SocialActivities<br />
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


### <a name="BKMK_bookableresourcebookingheader_Annotations"></a> bookableresourcebookingheader_Annotations

Same as annotation entity [bookableresourcebookingheader_Annotations](annotation.md#BKMK_bookableresourcebookingheader_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_Annotations<br />
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


### <a name="BKMK_bookableresourcebookingheader_bookableresourcebooking_Header"></a> bookableresourcebookingheader_bookableresourcebooking_Header

Same as bookableresourcebooking entity [bookableresourcebookingheader_bookableresourcebooking_Header](bookableresourcebooking.md#BKMK_bookableresourcebookingheader_bookableresourcebooking_Header) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebooking<br />
**ReferencingAttribute**: header<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_bookableresourcebooking_Header<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bookableresourcebookingheader_BulkOperations"></a> bookableresourcebookingheader_BulkOperations

Same as bulkoperation entity [bookableresourcebookingheader_BulkOperations](bulkoperation.md#BKMK_bookableresourcebookingheader_BulkOperations) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_BulkOperations<br />
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


### <a name="BKMK_bookableresourcebookingheader_CampaignActivities"></a> bookableresourcebookingheader_CampaignActivities

Same as campaignactivity entity [bookableresourcebookingheader_CampaignActivities](campaignactivity.md#BKMK_bookableresourcebookingheader_CampaignActivities) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_CampaignActivities<br />
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


### <a name="BKMK_bookableresourcebookingheader_CampaignResponses"></a> bookableresourcebookingheader_CampaignResponses

Same as campaignresponse entity [bookableresourcebookingheader_CampaignResponses](campaignresponse.md#BKMK_bookableresourcebookingheader_CampaignResponses) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_CampaignResponses<br />
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


### <a name="BKMK_bookableresourcebookingheader_IncidentResolutions"></a> bookableresourcebookingheader_IncidentResolutions

Same as incidentresolution entity [bookableresourcebookingheader_IncidentResolutions](incidentresolution.md#BKMK_bookableresourcebookingheader_IncidentResolutions) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_IncidentResolutions<br />
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


### <a name="BKMK_bookableresourcebookingheader_ServiceAppointments"></a> bookableresourcebookingheader_ServiceAppointments

Same as serviceappointment entity [bookableresourcebookingheader_ServiceAppointments](serviceappointment.md#BKMK_bookableresourcebookingheader_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_ServiceAppointments<br />
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


### <a name="BKMK_bookableresourcebookingheader_OpportunityCloses"></a> bookableresourcebookingheader_OpportunityCloses

Same as opportunityclose entity [bookableresourcebookingheader_OpportunityCloses](opportunityclose.md#BKMK_bookableresourcebookingheader_OpportunityCloses) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_OpportunityCloses<br />
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


### <a name="BKMK_bookableresourcebookingheader_OrderCloses"></a> bookableresourcebookingheader_OrderCloses

Same as orderclose entity [bookableresourcebookingheader_OrderCloses](orderclose.md#BKMK_bookableresourcebookingheader_OrderCloses) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_OrderCloses<br />
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


### <a name="BKMK_bookableresourcebookingheader_QuoteCloses"></a> bookableresourcebookingheader_QuoteCloses

Same as quoteclose entity [bookableresourcebookingheader_QuoteCloses](quoteclose.md#BKMK_bookableresourcebookingheader_QuoteCloses) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_QuoteCloses<br />
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


### <a name="BKMK_bookableresourcebookingheader_msdyn_bookingalerts"></a> bookableresourcebookingheader_msdyn_bookingalerts

Same as msdyn_bookingalert entity [bookableresourcebookingheader_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_bookableresourcebookingheader_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_msdyn_bookingalerts<br />
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


### <a name="BKMK_bookableresourcebookingheader_msdyn_approvals"></a> bookableresourcebookingheader_msdyn_approvals

Same as msdyn_approval entity [bookableresourcebookingheader_msdyn_approvals](msdyn_approval.md#BKMK_bookableresourcebookingheader_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingheader_msdyn_approvals<br />
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
- [msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid](#BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid)
- [msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid](#BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid)
- [msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement](#BKMK_msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement)
- [msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid](#BKMK_msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid)
- [msdyn_msdyn_project_bookableresourcebookingheader_projectid](#BKMK_msdyn_msdyn_project_bookableresourcebookingheader_projectid)
- [msdyn_msdyn_projectteam_bookableresourcebookingheader_projectteamid](#BKMK_msdyn_msdyn_projectteam_bookableresourcebookingheader_projectteamid)


### <a name="BKMK_lk_bookableresourcebookingheader_createdby"></a> lk_bookableresourcebookingheader_createdby

See systemuser Entity [lk_bookableresourcebookingheader_createdby](systemuser.md#BKMK_lk_bookableresourcebookingheader_createdby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebookingheader_createdonbehalfby"></a> lk_bookableresourcebookingheader_createdonbehalfby

See systemuser Entity [lk_bookableresourcebookingheader_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcebookingheader_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebookingheader_modifiedby"></a> lk_bookableresourcebookingheader_modifiedby

See systemuser Entity [lk_bookableresourcebookingheader_modifiedby](systemuser.md#BKMK_lk_bookableresourcebookingheader_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebookingheader_modifiedonbehalfby"></a> lk_bookableresourcebookingheader_modifiedonbehalfby

See systemuser Entity [lk_bookableresourcebookingheader_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcebookingheader_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_bookableresourcebookingheader"></a> user_bookableresourcebookingheader

See systemuser Entity [user_bookableresourcebookingheader](systemuser.md#BKMK_user_bookableresourcebookingheader) One-To-Many relationship.

### <a name="BKMK_team_bookableresourcebookingheader"></a> team_bookableresourcebookingheader

See team Entity [team_bookableresourcebookingheader](team.md#BKMK_team_bookableresourcebookingheader) One-To-Many relationship.

### <a name="BKMK_business_unit_bookableresourcebookingheader"></a> business_unit_bookableresourcebookingheader

See businessunit Entity [business_unit_bookableresourcebookingheader](businessunit.md#BKMK_business_unit_bookableresourcebookingheader) One-To-Many relationship.

### <a name="BKMK_processstage_BookableResourceBookingHeader"></a> processstage_BookableResourceBookingHeader

See processstage Entity [processstage_BookableResourceBookingHeader](processstage.md#BKMK_processstage_BookableResourceBookingHeader) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_bookableresourcebookingheader"></a> TransactionCurrency_bookableresourcebookingheader

See transactioncurrency Entity [TransactionCurrency_bookableresourcebookingheader](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcebookingheader) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid"></a> msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid

See bookableresource Entity [msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid](bookableresource.md#BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid"></a> msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid

See bookingstatus Entity [msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid](bookingstatus.md#BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement"></a> msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid"></a> msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_bookableresourcebookingheader_projectid"></a> msdyn_msdyn_project_bookableresourcebookingheader_projectid

See msdyn_project Entity [msdyn_msdyn_project_bookableresourcebookingheader_projectid](msdyn_project.md#BKMK_msdyn_msdyn_project_bookableresourcebookingheader_projectid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projectteam_bookableresourcebookingheader_projectteamid"></a> msdyn_msdyn_projectteam_bookableresourcebookingheader_projectteamid

See msdyn_projectteam Entity [msdyn_msdyn_projectteam_bookableresourcebookingheader_projectteamid](msdyn_projectteam.md#BKMK_msdyn_msdyn_projectteam_bookableresourcebookingheader_projectteamid) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the BookableResourceBookingHeader entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_resourcerequirement_bookingheader"></a> msdyn_resourcerequirement_bookingheader

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_bookingheader](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_bookingheader) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bookableresourcebookingheader?text=bookableresourcebookingheader EntityType" />