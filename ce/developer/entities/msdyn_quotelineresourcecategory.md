---
title: "msdyn_quotelineresourcecategory Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotelineresourcecategory entity."
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
# msdyn_quotelineresourcecategory Entity Reference

List of roles that will be considered as costs when understanding the profit of a quote line.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineresourcecategories(*msdyn_quotelineresourcecategoryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotelineresourcecategories<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotelineresourcecategories(*msdyn_quotelineresourcecategoryid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotelineresourcecategories(*msdyn_quotelineresourcecategoryid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotelineresourcecategories<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineresourcecategories(*msdyn_quotelineresourcecategoryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineresourcecategories(*msdyn_quotelineresourcecategoryid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Quote Line Resource Category<br />
**DisplayCollectionName**: Quote Line Resource Categories<br />
**SchemaName**: msdyn_quotelineresourcecategory<br />
**CollectionSchemaName**: msdyn_quotelineresourcecategories<br />
**LogicalName**: msdyn_quotelineresourcecategory<br />
**LogicalCollectionName**: msdyn_quotelineresourcecategories<br />
**EntitySetName**: msdyn_quotelineresourcecategories<br />
**PrimaryIdAttribute**: msdyn_quotelineresourcecategoryid<br />
**PrimaryNameAttribute**: msdyn_description<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BillingType](#BKMK_msdyn_BillingType)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_QuoteLine](#BKMK_msdyn_QuoteLine)
- [msdyn_quotelineresourcecategoryId](#BKMK_msdyn_quotelineresourcecategoryId)
- [msdyn_QuoteLineTransactionClassification](#BKMK_msdyn_QuoteLineTransactionClassification)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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


### <a name="BKMK_msdyn_BillingType"></a> msdyn_BillingType

**Description**: Select whether this role costs are going to  be billed to the customer or not. Valid values are Chargeable, Non-chargeable and Complimentary. Only chargeable transactions will affect invoice totals<br />
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



### <a name="BKMK_msdyn_description"></a> msdyn_description

**Description**: Type the name of the custom entity.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_QuoteLine"></a> msdyn_QuoteLine

**Description**: Quote line corresponding to this record<br />
**DisplayName**: Quote Line<br />
**LogicalName**: msdyn_quoteline<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_quotelineresourcecategoryId"></a> msdyn_quotelineresourcecategoryId

**Description**: Shows the entity instances.<br />
**DisplayName**: Quote Line Resource Category<br />
**LogicalName**: msdyn_quotelineresourcecategoryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_QuoteLineTransactionClassification"></a> msdyn_QuoteLineTransactionClassification

**Description**: Select the transaction classification that is mapped to the quote line.<br />
**DisplayName**: Quote Line Transaction Classification<br />
**LogicalName**: msdyn_quotelinetransactionclassification<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_quotelinetransactionclassification


### <a name="BKMK_msdyn_ResourceCategory"></a> msdyn_ResourceCategory

**Description**: Select the role that is being quoted on this quote line.<br />
**DisplayName**: Role<br />
**LogicalName**: msdyn_resourcecategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecategory


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

**Description**: Transaction type corresponding to this record<br />
**DisplayName**: Transaction Classification<br />
**LogicalName**: msdyn_transactionclassification<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Time
- **Value**: 192350001 **Label**: Expense
- **Value**: 192350002 **Label**: Material
- **Value**: 192350003 **Label**: Milestone
- **Value**: 192350004 **Label**: Fee
- **Value**: 690970000 **Label**: Commission
- **Value**: 690970001 **Label**: Additional
- **Value**: 690970002 **Label**: Tax



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


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Quote Line Resource Category<br />
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



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Quote Line Resource Category<br />
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
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_QuoteLineTransactionClassificationName](#BKMK_msdyn_QuoteLineTransactionClassificationName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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


### <a name="BKMK_msdyn_QuoteLineTransactionClassificationName"></a> msdyn_QuoteLineTransactionClassificationName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotelinetransactionclassificationname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ResourceCategoryName"></a> msdyn_ResourceCategoryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcecategoryname<br />
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

- [msdyn_quotelineresourcecategory_SyncErrors](#BKMK_msdyn_quotelineresourcecategory_SyncErrors)
- [msdyn_quotelineresourcecategory_DuplicateMatchingRecord](#BKMK_msdyn_quotelineresourcecategory_DuplicateMatchingRecord)
- [msdyn_quotelineresourcecategory_DuplicateBaseRecord](#BKMK_msdyn_quotelineresourcecategory_DuplicateBaseRecord)
- [msdyn_quotelineresourcecategory_AsyncOperations](#BKMK_msdyn_quotelineresourcecategory_AsyncOperations)
- [msdyn_quotelineresourcecategory_MailboxTrackingFolders](#BKMK_msdyn_quotelineresourcecategory_MailboxTrackingFolders)
- [msdyn_quotelineresourcecategory_UserEntityInstanceDatas](#BKMK_msdyn_quotelineresourcecategory_UserEntityInstanceDatas)
- [msdyn_quotelineresourcecategory_ProcessSession](#BKMK_msdyn_quotelineresourcecategory_ProcessSession)
- [msdyn_quotelineresourcecategory_BulkDeleteFailures](#BKMK_msdyn_quotelineresourcecategory_BulkDeleteFailures)
- [msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses)
- [msdyn_quotelineresourcecategory_Annotations](#BKMK_msdyn_quotelineresourcecategory_Annotations)


### <a name="BKMK_msdyn_quotelineresourcecategory_SyncErrors"></a> msdyn_quotelineresourcecategory_SyncErrors

Same as syncerror entity [msdyn_quotelineresourcecategory_SyncErrors](syncerror.md#BKMK_msdyn_quotelineresourcecategory_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_SyncErrors<br />
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


### <a name="BKMK_msdyn_quotelineresourcecategory_DuplicateMatchingRecord"></a> msdyn_quotelineresourcecategory_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_quotelineresourcecategory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotelineresourcecategory_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_quotelineresourcecategory_DuplicateBaseRecord"></a> msdyn_quotelineresourcecategory_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_quotelineresourcecategory_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotelineresourcecategory_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_quotelineresourcecategory_AsyncOperations"></a> msdyn_quotelineresourcecategory_AsyncOperations

Same as asyncoperation entity [msdyn_quotelineresourcecategory_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotelineresourcecategory_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_quotelineresourcecategory_MailboxTrackingFolders"></a> msdyn_quotelineresourcecategory_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_quotelineresourcecategory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotelineresourcecategory_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_quotelineresourcecategory_UserEntityInstanceDatas"></a> msdyn_quotelineresourcecategory_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_quotelineresourcecategory_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_quotelineresourcecategory_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_quotelineresourcecategory_ProcessSession"></a> msdyn_quotelineresourcecategory_ProcessSession

Same as processsession entity [msdyn_quotelineresourcecategory_ProcessSession](processsession.md#BKMK_msdyn_quotelineresourcecategory_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_quotelineresourcecategory_BulkDeleteFailures"></a> msdyn_quotelineresourcecategory_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_quotelineresourcecategory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotelineresourcecategory_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses"></a> msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_quotelineresourcecategory_Annotations"></a> msdyn_quotelineresourcecategory_Annotations

Same as annotation entity [msdyn_quotelineresourcecategory_Annotations](annotation.md#BKMK_msdyn_quotelineresourcecategory_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineresourcecategory_Annotations<br />
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

- [lk_msdyn_quotelineresourcecategory_createdby](#BKMK_lk_msdyn_quotelineresourcecategory_createdby)
- [lk_msdyn_quotelineresourcecategory_createdonbehalfby](#BKMK_lk_msdyn_quotelineresourcecategory_createdonbehalfby)
- [lk_msdyn_quotelineresourcecategory_modifiedby](#BKMK_lk_msdyn_quotelineresourcecategory_modifiedby)
- [lk_msdyn_quotelineresourcecategory_modifiedonbehalfby](#BKMK_lk_msdyn_quotelineresourcecategory_modifiedonbehalfby)
- [user_msdyn_quotelineresourcecategory](#BKMK_user_msdyn_quotelineresourcecategory)
- [team_msdyn_quotelineresourcecategory](#BKMK_team_msdyn_quotelineresourcecategory)
- [business_unit_msdyn_quotelineresourcecategory](#BKMK_business_unit_msdyn_quotelineresourcecategory)
- [msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory)
- [msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass](#BKMK_msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass)


### <a name="BKMK_lk_msdyn_quotelineresourcecategory_createdby"></a> lk_msdyn_quotelineresourcecategory_createdby

See systemuser Entity [lk_msdyn_quotelineresourcecategory_createdby](systemuser.md#BKMK_lk_msdyn_quotelineresourcecategory_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineresourcecategory_createdonbehalfby"></a> lk_msdyn_quotelineresourcecategory_createdonbehalfby

See systemuser Entity [lk_msdyn_quotelineresourcecategory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelineresourcecategory_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineresourcecategory_modifiedby"></a> lk_msdyn_quotelineresourcecategory_modifiedby

See systemuser Entity [lk_msdyn_quotelineresourcecategory_modifiedby](systemuser.md#BKMK_lk_msdyn_quotelineresourcecategory_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineresourcecategory_modifiedonbehalfby"></a> lk_msdyn_quotelineresourcecategory_modifiedonbehalfby

See systemuser Entity [lk_msdyn_quotelineresourcecategory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelineresourcecategory_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotelineresourcecategory"></a> user_msdyn_quotelineresourcecategory

See systemuser Entity [user_msdyn_quotelineresourcecategory](systemuser.md#BKMK_user_msdyn_quotelineresourcecategory) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotelineresourcecategory"></a> team_msdyn_quotelineresourcecategory

See team Entity [team_msdyn_quotelineresourcecategory](team.md#BKMK_team_msdyn_quotelineresourcecategory) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotelineresourcecategory"></a> business_unit_msdyn_quotelineresourcecategory

See businessunit Entity [business_unit_msdyn_quotelineresourcecategory](businessunit.md#BKMK_business_unit_msdyn_quotelineresourcecategory) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass"></a> msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotelineresourcecategory?text=msdyn_quotelineresourcecategory EntityType" />