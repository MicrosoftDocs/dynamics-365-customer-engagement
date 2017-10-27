---
title: "BookableResourceCharacteristic Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BookableResourceCharacteristic entity."
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
# BookableResourceCharacteristic Entity Reference

Associates resources with their characteristics and specifies the proficiency level of a resource for that characteristic.

**Added by**: Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/bookableresourcecharacteristics<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bookableresourcecharacteristics<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Bookable Resource Characteristic<br />
**DisplayCollectionName**: Bookable Resource Characteristics<br />
**SchemaName**: BookableResourceCharacteristic<br />
**CollectionSchemaName**: BookableResourceCharacteristic<br />
**LogicalName**: bookableresourcecharacteristic<br />
**LogicalCollectionName**: bookableresourcecharacteristics<br />
**EntitySetName**: bookableresourcecharacteristics<br />
**PrimaryIdAttribute**: bookableresourcecharacteristicid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceCharacteristicId](#BKMK_BookableResourceCharacteristicId)
- [Characteristic](#BKMK_Characteristic)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_approvalstatus](#BKMK_msdyn_approvalstatus)
- [msdyn_supportingrecord](#BKMK_msdyn_supportingrecord)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ProcessId](#BKMK_ProcessId)
- [RatingValue](#BKMK_RatingValue)
- [Resource](#BKMK_Resource)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BookableResourceCharacteristicId"></a> BookableResourceCharacteristicId

**Description**: Unique identifier of the resource characteristic.<br />
**DisplayName**: Bookable Resource Characteristic<br />
**LogicalName**: bookableresourcecharacteristicid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Characteristic"></a> Characteristic

**Description**: Choose the characteristic to associate with the resource.<br />
**DisplayName**: Characteristic<br />
**LogicalName**: characteristic<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: characteristic


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


### <a name="BKMK_msdyn_approvalstatus"></a> msdyn_approvalstatus

**Added by**: Project Service Automation Solution<br />
**Description**: <br />
**DisplayName**: Approval status<br />
**LogicalName**: msdyn_approvalstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Saved
- **Value**: 192350001 **Label**: Pending Approval
- **Value**: 192350002 **Label**: Rejected
- **Value**: 192350003 **Label**: Approved
- **Value**: 192350004 **Label**: Recalled



### <a name="BKMK_msdyn_supportingrecord"></a> msdyn_supportingrecord

**Added by**: Project Service Automation Solution<br />
**Description**: <br />
**DisplayName**: Supporting Record<br />
**LogicalName**: msdyn_supportingrecord<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecharacteristic


### <a name="BKMK_Name"></a> Name

**Description**: Type the name of the association between the resource and characteristic.<br />
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


### <a name="BKMK_RatingValue"></a> RatingValue

**Description**: Select a rating value that represents the evaluation of a characteristic for a particular resource.<br />
**DisplayName**: Rating Value<br />
**LogicalName**: ratingvalue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: ratingvalue


### <a name="BKMK_Resource"></a> Resource

**Description**: Shows the resource associated with the characteristic.<br />
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


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the Bookable Resource Characteristic<br />
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

**Description**: Reason for the status of the Bookable Resource Characteristic<br />
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

**Description**: Exchange rate for the currency associated with the BookableResourceCharacteristic with respect to the base currency.<br />
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

- [CharacteristicName](#BKMK_CharacteristicName)
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
- [msdyn_supportingrecordName](#BKMK_msdyn_supportingrecordName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RatingValueName](#BKMK_RatingValueName)
- [ResourceName](#BKMK_ResourceName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CharacteristicName"></a> CharacteristicName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: characteristicname<br />
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

**Description**: Exchange rate for the currency associated with the bookableresourcecharacteristic with respect to the base currency.<br />
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


### <a name="BKMK_msdyn_supportingrecordName"></a> msdyn_supportingrecordName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_supportingrecordname<br />
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


### <a name="BKMK_RatingValueName"></a> RatingValueName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: ratingvaluename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [BookableResourceCharacteristic_SyncErrors](#BKMK_BookableResourceCharacteristic_SyncErrors)
- [bookableresourcecharacteristic_DuplicateMatchingRecord](#BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord)
- [bookableresourcecharacteristic_DuplicateBaseRecord](#BKMK_bookableresourcecharacteristic_DuplicateBaseRecord)
- [bookableresourcecharacteristic_AsyncOperations](#BKMK_bookableresourcecharacteristic_AsyncOperations)
- [bookableresourcecharacteristic_MailboxTrackingFolders](#BKMK_bookableresourcecharacteristic_MailboxTrackingFolders)
- [bookableresourcecharacteristic_UserEntityInstanceDatas](#BKMK_bookableresourcecharacteristic_UserEntityInstanceDatas)
- [bookableresourcecharacteristic_ProcessSession](#BKMK_bookableresourcecharacteristic_ProcessSession)
- [bookableresourcecharacteristic_BulkDeleteFailures](#BKMK_bookableresourcecharacteristic_BulkDeleteFailures)
- [bookableresourcecharacteristic_PrincipalObjectAttributeAccess](#BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess)
- [bookableresourcecharacteristic_Annotations](#BKMK_bookableresourcecharacteristic_Annotations)
- [msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord](#BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord)
- [msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic](#BKMK_msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic)


### <a name="BKMK_BookableResourceCharacteristic_SyncErrors"></a> BookableResourceCharacteristic_SyncErrors

Same as syncerror entity [BookableResourceCharacteristic_SyncErrors](syncerror.md#BKMK_BookableResourceCharacteristic_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BookableResourceCharacteristic_SyncErrors<br />
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


### <a name="BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord"></a> bookableresourcecharacteristic_DuplicateMatchingRecord

Same as duplicaterecord entity [bookableresourcecharacteristic_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecharacteristic_DuplicateMatchingRecord<br />
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


### <a name="BKMK_bookableresourcecharacteristic_DuplicateBaseRecord"></a> bookableresourcecharacteristic_DuplicateBaseRecord

Same as duplicaterecord entity [bookableresourcecharacteristic_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcecharacteristic_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecharacteristic_DuplicateBaseRecord<br />
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


### <a name="BKMK_bookableresourcecharacteristic_AsyncOperations"></a> bookableresourcecharacteristic_AsyncOperations

Same as asyncoperation entity [bookableresourcecharacteristic_AsyncOperations](asyncoperation.md#BKMK_bookableresourcecharacteristic_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecharacteristic_AsyncOperations<br />
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


### <a name="BKMK_bookableresourcecharacteristic_MailboxTrackingFolders"></a> bookableresourcecharacteristic_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [bookableresourcecharacteristic_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcecharacteristic_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecharacteristic_MailboxTrackingFolders<br />
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


### <a name="BKMK_bookableresourcecharacteristic_UserEntityInstanceDatas"></a> bookableresourcecharacteristic_UserEntityInstanceDatas

Same as userentityinstancedata entity [bookableresourcecharacteristic_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_bookableresourcecharacteristic_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecharacteristic_UserEntityInstanceDatas<br />
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


### <a name="BKMK_bookableresourcecharacteristic_ProcessSession"></a> bookableresourcecharacteristic_ProcessSession

Same as processsession entity [bookableresourcecharacteristic_ProcessSession](processsession.md#BKMK_bookableresourcecharacteristic_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecharacteristic_ProcessSession<br />
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


### <a name="BKMK_bookableresourcecharacteristic_BulkDeleteFailures"></a> bookableresourcecharacteristic_BulkDeleteFailures

Same as bulkdeletefailure entity [bookableresourcecharacteristic_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcecharacteristic_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecharacteristic_BulkDeleteFailures<br />
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


### <a name="BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess"></a> bookableresourcecharacteristic_PrincipalObjectAttributeAccess

Same as principalobjectattributeaccess entity [bookableresourcecharacteristic_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecharacteristic_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_bookableresourcecharacteristic_Annotations"></a> bookableresourcecharacteristic_Annotations

Same as annotation entity [bookableresourcecharacteristic_Annotations](annotation.md#BKMK_bookableresourcecharacteristic_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecharacteristic_Annotations<br />
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


### <a name="BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord"></a> msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord

Same as bookableresourcecharacteristic entity [msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord](bookableresourcecharacteristic.md#BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecharacteristic<br />
**ReferencingAttribute**: msdyn_supportingrecord<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord<br />
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


### <a name="BKMK_msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic"></a> msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic

Same as msdyn_approval entity [msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic](msdyn_approval.md#BKMK_msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: msdyn_characteristic<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic<br />
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

- [lk_bookableresourcecharacteristic_createdby](#BKMK_lk_bookableresourcecharacteristic_createdby)
- [lk_bookableresourcecharacteristic_createdonbehalfby](#BKMK_lk_bookableresourcecharacteristic_createdonbehalfby)
- [lk_bookableresourcecharacteristic_modifiedby](#BKMK_lk_bookableresourcecharacteristic_modifiedby)
- [lk_bookableresourcecharacteristic_modifiedonbehalfby](#BKMK_lk_bookableresourcecharacteristic_modifiedonbehalfby)
- [user_bookableresourcecharacteristic](#BKMK_user_bookableresourcecharacteristic)
- [team_bookableresourcecharacteristic](#BKMK_team_bookableresourcecharacteristic)
- [business_unit_bookableresourcecharacteristic](#BKMK_business_unit_bookableresourcecharacteristic)
- [processstage_BookableResourceCharacteristic](#BKMK_processstage_BookableResourceCharacteristic)
- [bookableresource_bookableresourcecharacteristic_Resource](#BKMK_bookableresource_bookableresourcecharacteristic_Resource)
- [characteristic_bookableresourcecharacteristic_Characteristic](#BKMK_characteristic_bookableresourcecharacteristic_Characteristic)
- [ratingvalue_bookableresourcecharacteristic_RatingValue](#BKMK_ratingvalue_bookableresourcecharacteristic_RatingValue)
- [TransactionCurrency_bookableresourcecharacteristic](#BKMK_TransactionCurrency_bookableresourcecharacteristic)
- [msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord](#BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord)


### <a name="BKMK_lk_bookableresourcecharacteristic_createdby"></a> lk_bookableresourcecharacteristic_createdby

See systemuser Entity [lk_bookableresourcecharacteristic_createdby](systemuser.md#BKMK_lk_bookableresourcecharacteristic_createdby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecharacteristic_createdonbehalfby"></a> lk_bookableresourcecharacteristic_createdonbehalfby

See systemuser Entity [lk_bookableresourcecharacteristic_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcecharacteristic_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecharacteristic_modifiedby"></a> lk_bookableresourcecharacteristic_modifiedby

See systemuser Entity [lk_bookableresourcecharacteristic_modifiedby](systemuser.md#BKMK_lk_bookableresourcecharacteristic_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecharacteristic_modifiedonbehalfby"></a> lk_bookableresourcecharacteristic_modifiedonbehalfby

See systemuser Entity [lk_bookableresourcecharacteristic_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcecharacteristic_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_bookableresourcecharacteristic"></a> user_bookableresourcecharacteristic

See systemuser Entity [user_bookableresourcecharacteristic](systemuser.md#BKMK_user_bookableresourcecharacteristic) One-To-Many relationship.

### <a name="BKMK_team_bookableresourcecharacteristic"></a> team_bookableresourcecharacteristic

See team Entity [team_bookableresourcecharacteristic](team.md#BKMK_team_bookableresourcecharacteristic) One-To-Many relationship.

### <a name="BKMK_business_unit_bookableresourcecharacteristic"></a> business_unit_bookableresourcecharacteristic

See businessunit Entity [business_unit_bookableresourcecharacteristic](businessunit.md#BKMK_business_unit_bookableresourcecharacteristic) One-To-Many relationship.

### <a name="BKMK_processstage_BookableResourceCharacteristic"></a> processstage_BookableResourceCharacteristic

See processstage Entity [processstage_BookableResourceCharacteristic](processstage.md#BKMK_processstage_BookableResourceCharacteristic) One-To-Many relationship.

### <a name="BKMK_bookableresource_bookableresourcecharacteristic_Resource"></a> bookableresource_bookableresourcecharacteristic_Resource

See bookableresource Entity [bookableresource_bookableresourcecharacteristic_Resource](bookableresource.md#BKMK_bookableresource_bookableresourcecharacteristic_Resource) One-To-Many relationship.

### <a name="BKMK_characteristic_bookableresourcecharacteristic_Characteristic"></a> characteristic_bookableresourcecharacteristic_Characteristic

See characteristic Entity [characteristic_bookableresourcecharacteristic_Characteristic](characteristic.md#BKMK_characteristic_bookableresourcecharacteristic_Characteristic) One-To-Many relationship.

### <a name="BKMK_ratingvalue_bookableresourcecharacteristic_RatingValue"></a> ratingvalue_bookableresourcecharacteristic_RatingValue

See ratingvalue Entity [ratingvalue_bookableresourcecharacteristic_RatingValue](ratingvalue.md#BKMK_ratingvalue_bookableresourcecharacteristic_RatingValue) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_bookableresourcecharacteristic"></a> TransactionCurrency_bookableresourcecharacteristic

See transactioncurrency Entity [TransactionCurrency_bookableresourcecharacteristic](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcecharacteristic) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord"></a> msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord

See bookableresourcecharacteristic Entity [msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord](bookableresourcecharacteristic.md#BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bookableresourcecharacteristic?text=bookableresourcecharacteristic EntityType" />