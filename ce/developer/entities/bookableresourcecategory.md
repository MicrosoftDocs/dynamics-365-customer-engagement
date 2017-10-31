---
title: "BookableResourceCategory Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BookableResourceCategory entity."
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
# BookableResourceCategory Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Resource category master used to categorize people and equipment.

**Added by**: Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/bookableresourcecategories<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bookableresourcecategories<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Bookable Resource Category<br />
**DisplayCollectionName**: Bookable Resource Categories<br />
**SchemaName**: BookableResourceCategory<br />
**CollectionSchemaName**: BookableResourceCategory<br />
**LogicalName**: bookableresourcecategory<br />
**LogicalCollectionName**: bookableresourcecategories<br />
**EntitySetName**: bookableresourcecategories<br />
**PrimaryIdAttribute**: bookableresourcecategoryid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceCategoryId](#BKMK_BookableResourceCategoryId)
- [Description](#BKMK_Description)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_billingtype](#BKMK_msdyn_billingtype)
- [msdyn_targetutilization](#BKMK_msdyn_targetutilization)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BookableResourceCategoryId"></a> BookableResourceCategoryId

**Description**: Unique identifier of the resource category.<br />
**DisplayName**: Resource Category<br />
**LogicalName**: bookableresourcecategoryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Description"></a> Description

**Description**: Type a detailed description of what the categorization is about.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_msdyn_billingtype"></a> msdyn_billingtype

**Added by**: Project Service Automation Solution<br />
**Description**: Select the billing type for this resource role.<br />
**DisplayName**: Billing Type<br />
**LogicalName**: msdyn_billingtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Non Chargeable
- **Value**: 192350001 **Label**: Chargeable
- **Value**: 192350002 **Label**: Complimentary
- **Value**: 192350003 **Label**: Not Available



### <a name="BKMK_msdyn_targetutilization"></a> msdyn_targetutilization

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the target usage rate for this resource role.<br />
**DisplayName**: Target Utilization<br />
**LogicalName**: msdyn_targetutilization<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 100<br />
**MinValue**: 1


### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the default transaction category for this resource role.<br />
**DisplayName**: Transaction Category<br />
**LogicalName**: msdyn_transactioncategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_transactioncategory


### <a name="BKMK_Name"></a> Name

**Description**: Type the name of the resource category.<br />
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


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the Resource Category<br />
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

**Description**: Reason for the status of the Resource Category<br />
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

**Description**: Exchange rate for the currency associated with the BookableResourceCategory with respect to the base currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


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
- [msdyn_TransactionCategoryName](#BKMK_msdyn_TransactionCategoryName)
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

**Description**: Exchange rate for the currency associated with the bookableresourcecategory with respect to the base currency.<br />
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


### <a name="BKMK_msdyn_TransactionCategoryName"></a> msdyn_TransactionCategoryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_transactioncategoryname<br />
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

- [BookableResourceCategory_SyncErrors](#BKMK_BookableResourceCategory_SyncErrors)
- [bookableresourcecategory_DuplicateMatchingRecord](#BKMK_bookableresourcecategory_DuplicateMatchingRecord)
- [bookableresourcecategory_DuplicateBaseRecord](#BKMK_bookableresourcecategory_DuplicateBaseRecord)
- [bookableresourcecategory_AsyncOperations](#BKMK_bookableresourcecategory_AsyncOperations)
- [bookableresourcecategory_MailboxTrackingFolders](#BKMK_bookableresourcecategory_MailboxTrackingFolders)
- [bookableresourcecategory_UserEntityInstanceDatas](#BKMK_bookableresourcecategory_UserEntityInstanceDatas)
- [bookableresourcecategory_ProcessSession](#BKMK_bookableresourcecategory_ProcessSession)
- [bookableresourcecategory_BulkDeleteFailures](#BKMK_bookableresourcecategory_BulkDeleteFailures)
- [bookableresourcecategory_PrincipalObjectAttributeAccess](#BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess)
- [bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory](#BKMK_bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory)
- [msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory)
- [msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid](#BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid)
- [msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid](#BKMK_msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid)
- [msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole](#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole)
- [msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole](#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole)
- [msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory](#BKMK_msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory)
- [msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory](#BKMK_msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory)
- [msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid](#BKMK_msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid)
- [msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory](#BKMK_msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory)
- [msdyn_bookableresourcecategory_msdyn_roleutilization_role](#BKMK_msdyn_bookableresourcecategory_msdyn_roleutilization_role)
- [msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory)
- [msdyn_bookableresourcecategory_resourcerequirement](#BKMK_msdyn_bookableresourcecategory_resourcerequirement)


### <a name="BKMK_BookableResourceCategory_SyncErrors"></a> BookableResourceCategory_SyncErrors

Same as syncerror entity [BookableResourceCategory_SyncErrors](syncerror.md#BKMK_BookableResourceCategory_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BookableResourceCategory_SyncErrors<br />
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


### <a name="BKMK_bookableresourcecategory_DuplicateMatchingRecord"></a> bookableresourcecategory_DuplicateMatchingRecord

Same as duplicaterecord entity [bookableresourcecategory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcecategory_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecategory_DuplicateMatchingRecord<br />
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


### <a name="BKMK_bookableresourcecategory_DuplicateBaseRecord"></a> bookableresourcecategory_DuplicateBaseRecord

Same as duplicaterecord entity [bookableresourcecategory_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcecategory_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecategory_DuplicateBaseRecord<br />
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


### <a name="BKMK_bookableresourcecategory_AsyncOperations"></a> bookableresourcecategory_AsyncOperations

Same as asyncoperation entity [bookableresourcecategory_AsyncOperations](asyncoperation.md#BKMK_bookableresourcecategory_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecategory_AsyncOperations<br />
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


### <a name="BKMK_bookableresourcecategory_MailboxTrackingFolders"></a> bookableresourcecategory_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [bookableresourcecategory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcecategory_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecategory_MailboxTrackingFolders<br />
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


### <a name="BKMK_bookableresourcecategory_UserEntityInstanceDatas"></a> bookableresourcecategory_UserEntityInstanceDatas

Same as userentityinstancedata entity [bookableresourcecategory_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_bookableresourcecategory_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecategory_UserEntityInstanceDatas<br />
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


### <a name="BKMK_bookableresourcecategory_ProcessSession"></a> bookableresourcecategory_ProcessSession

Same as processsession entity [bookableresourcecategory_ProcessSession](processsession.md#BKMK_bookableresourcecategory_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecategory_ProcessSession<br />
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


### <a name="BKMK_bookableresourcecategory_BulkDeleteFailures"></a> bookableresourcecategory_BulkDeleteFailures

Same as bulkdeletefailure entity [bookableresourcecategory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcecategory_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecategory_BulkDeleteFailures<br />
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


### <a name="BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess"></a> bookableresourcecategory_PrincipalObjectAttributeAccess

Same as principalobjectattributeaccess entity [bookableresourcecategory_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecategory_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory"></a> bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory

Same as bookableresourcecategoryassn entity [bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory](bookableresourcecategoryassn.md#BKMK_bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecategoryassn<br />
**ReferencingAttribute**: resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory

Same as msdyn_requirementresourcecategory entity [msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory](msdyn_requirementresourcecategory.md#BKMK_msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementresourcecategory<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory<br />
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


### <a name="BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid"></a> msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid

Same as bookableresourcebooking entity [msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid](bookableresourcebooking.md#BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebooking<br />
**ReferencingAttribute**: msdyn_resourcecategoryid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid<br />
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


### <a name="BKMK_msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid"></a> msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid

Same as bookableresourcebookingheader entity [msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid](bookableresourcebookingheader.md#BKMK_msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebookingheader<br />
**ReferencingAttribute**: msdyn_resourcecategoryid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid<br />
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


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory

Same as msdyn_actual entity [msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory](msdyn_actual.md#BKMK_msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory

Same as msdyn_estimateline entity [msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory](msdyn_estimateline.md#BKMK_msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory

Same as msdyn_fact entity [msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory](msdyn_fact.md#BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory

Same as msdyn_invoicelinetransaction entity [msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory](msdyn_invoicelinetransaction.md#BKMK_msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory

Same as msdyn_journalline entity [msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory](msdyn_journalline.md#BKMK_msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory

Same as msdyn_opportunitylineresourcecategory entity [msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylineresourcecategory<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory

Same as msdyn_opportunitylinetransaction entity [msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory](msdyn_opportunitylinetransaction.md#BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory

Same as msdyn_orderlineresourcecategory entity [msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory](msdyn_orderlineresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlineresourcecategory<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory

Same as msdyn_orderlinetransaction entity [msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory](msdyn_orderlinetransaction.md#BKMK_msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory

Same as msdyn_projectapproval entity [msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory](msdyn_projectapproval.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectapproval<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory<br />
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


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole"></a> msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole

Same as msdyn_projectparameter entity [msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole](msdyn_projectparameter.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectparameter<br />
**ReferencingAttribute**: msdyn_projectmanagerrole<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole"></a> msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole

Same as msdyn_projectparameter entity [msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole](msdyn_projectparameter.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectparameter<br />
**ReferencingAttribute**: msdyn_teammemberrole<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory"></a> msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory

Same as msdyn_projecttask entity [msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory](msdyn_projecttask.md#BKMK_msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttask<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory"></a> msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory

Same as msdyn_projectteam entity [msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory](msdyn_projectteam.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectteam<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory

Same as msdyn_quotelineanalyticsbreakdown entity [msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineanalyticsbreakdown<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory<br />
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


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory

Same as msdyn_quotelineresourcecategory entity [msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory](msdyn_quotelineresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineresourcecategory<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory

Same as msdyn_quotelinetransaction entity [msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory](msdyn_quotelinetransaction.md#BKMK_msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory

Same as msdyn_resourcecategorypricelevel entity [msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcecategorypricelevel<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid"></a> msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid

Same as msdyn_resourcerequest entity [msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid](msdyn_resourcerequest.md#BKMK_msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequest<br />
**ReferencingAttribute**: msdyn_roleid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid<br />
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


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory"></a> msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory

Same as msdyn_rolecompetencyrequirement entity [msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_rolecompetencyrequirement<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_roleutilization_role"></a> msdyn_bookableresourcecategory_msdyn_roleutilization_role

Same as msdyn_roleutilization entity [msdyn_bookableresourcecategory_msdyn_roleutilization_role](msdyn_roleutilization.md#BKMK_msdyn_bookableresourcecategory_msdyn_roleutilization_role) Many-To-One relationship.

**ReferencingEntity**: msdyn_roleutilization<br />
**ReferencingAttribute**: msdyn_role<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_roleutilization_role<br />
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


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory"></a> msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory

Same as msdyn_timeentry entity [msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory](msdyn_timeentry.md#BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_timeentry<br />
**ReferencingAttribute**: msdyn_resourcecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookableresourcecategory_resourcerequirement"></a> msdyn_bookableresourcecategory_resourcerequirement

Same as msdyn_resourcerequirement entity [msdyn_bookableresourcecategory_resourcerequirement](msdyn_resourcerequirement.md#BKMK_msdyn_bookableresourcecategory_resourcerequirement) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequirement<br />
**ReferencingAttribute**: msdyn_roleid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookableresourcecategory_resourcerequirement<br />
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

- [lk_bookableresourcecategory_createdby](#BKMK_lk_bookableresourcecategory_createdby)
- [lk_bookableresourcecategory_createdonbehalfby](#BKMK_lk_bookableresourcecategory_createdonbehalfby)
- [lk_bookableresourcecategory_modifiedby](#BKMK_lk_bookableresourcecategory_modifiedby)
- [lk_bookableresourcecategory_modifiedonbehalfby](#BKMK_lk_bookableresourcecategory_modifiedonbehalfby)
- [user_bookableresourcecategory](#BKMK_user_bookableresourcecategory)
- [team_bookableresourcecategory](#BKMK_team_bookableresourcecategory)
- [business_unit_bookableresourcecategory](#BKMK_business_unit_bookableresourcecategory)
- [TransactionCurrency_bookableresourcecategory](#BKMK_TransactionCurrency_bookableresourcecategory)
- [msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory)


### <a name="BKMK_lk_bookableresourcecategory_createdby"></a> lk_bookableresourcecategory_createdby

See systemuser Entity [lk_bookableresourcecategory_createdby](systemuser.md#BKMK_lk_bookableresourcecategory_createdby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecategory_createdonbehalfby"></a> lk_bookableresourcecategory_createdonbehalfby

See systemuser Entity [lk_bookableresourcecategory_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcecategory_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecategory_modifiedby"></a> lk_bookableresourcecategory_modifiedby

See systemuser Entity [lk_bookableresourcecategory_modifiedby](systemuser.md#BKMK_lk_bookableresourcecategory_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecategory_modifiedonbehalfby"></a> lk_bookableresourcecategory_modifiedonbehalfby

See systemuser Entity [lk_bookableresourcecategory_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcecategory_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_bookableresourcecategory"></a> user_bookableresourcecategory

See systemuser Entity [user_bookableresourcecategory](systemuser.md#BKMK_user_bookableresourcecategory) One-To-Many relationship.

### <a name="BKMK_team_bookableresourcecategory"></a> team_bookableresourcecategory

See team Entity [team_bookableresourcecategory](team.md#BKMK_team_bookableresourcecategory) One-To-Many relationship.

### <a name="BKMK_business_unit_bookableresourcecategory"></a> business_unit_bookableresourcecategory

See businessunit Entity [business_unit_bookableresourcecategory](businessunit.md#BKMK_business_unit_bookableresourcecategory) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_bookableresourcecategory"></a> TransactionCurrency_bookableresourcecategory

See transactioncurrency Entity [TransactionCurrency_bookableresourcecategory](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcecategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bookableresourcecategory?text=bookableresourcecategory EntityType" />