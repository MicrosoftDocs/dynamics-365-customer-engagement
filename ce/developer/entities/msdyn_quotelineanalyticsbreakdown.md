---
title: "msdyn_quotelineanalyticsbreakdown Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotelineanalyticsbreakdown entity."
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
# msdyn_quotelineanalyticsbreakdown Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Reporting entity that is used to show quoted sales and estimated cost amounts by various dimensions.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Quote Line Analytics Breakdown<br />
**DisplayCollectionName**: Quote Line Analytics Breakdown<br />
**SchemaName**: msdyn_quotelineanalyticsbreakdown<br />
**CollectionSchemaName**: msdyn_quotelineanalyticsbreakdowns<br />
**LogicalName**: msdyn_quotelineanalyticsbreakdown<br />
**LogicalCollectionName**: msdyn_quotelineanalyticsbreakdowns<br />
**EntitySetName**: msdyn_quotelineanalyticsbreakdowns<br />
**PrimaryIdAttribute**: msdyn_quotelineanalyticsbreakdownid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Amount](#BKMK_msdyn_Amount)
- [msdyn_BillingType](#BKMK_msdyn_BillingType)
- [msdyn_EndDateTime](#BKMK_msdyn_EndDateTime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Price](#BKMK_msdyn_Price)
- [msdyn_Quote](#BKMK_msdyn_Quote)
- [msdyn_quotelineanalyticsbreakdownId](#BKMK_msdyn_quotelineanalyticsbreakdownId)
- [msdyn_QuoteLineDetail](#BKMK_msdyn_QuoteLineDetail)
- [msdyn_QuoteLineScheduleOfValue](#BKMK_msdyn_QuoteLineScheduleOfValue)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_StartDateTime](#BKMK_msdyn_StartDateTime)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [msdyn_TransactionTypeCode](#BKMK_msdyn_TransactionTypeCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
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


### <a name="BKMK_msdyn_Amount"></a> msdyn_Amount

**Description**: Enter the amount on the quote line estimate.<br />
**DisplayName**: Amount<br />
**LogicalName**: msdyn_amount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_BillingType"></a> msdyn_BillingType

**Description**: Select whether the quote line estimate will be charged to the customer. Valid values are Chargeable, Non-chargeable and Complimentary. Only chargeable transactions will affect the invoice totals.<br />
**DisplayName**: Billing Type<br />
**LogicalName**: msdyn_billingtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Non Chargeable
- **Value**: 192350001 **Label**: Chargeable
- **Value**: 192350002 **Label**: Complimentary
- **Value**: 192350003 **Label**: Not Available



### <a name="BKMK_msdyn_EndDateTime"></a> msdyn_EndDateTime

**Description**: Enter the estimated end date of the quote line estimate.<br />
**DisplayName**: End Date Time<br />
**LogicalName**: msdyn_enddatetime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Type a description of the entity breakdown.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Price"></a> msdyn_Price

**Description**: Enter the unit price on the quote line estimate.<br />
**DisplayName**: Price<br />
**LogicalName**: msdyn_price<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_Quote"></a> msdyn_Quote

**Description**: Select the quote that this quote line estimate belongs to.<br />
**DisplayName**: Quote<br />
**LogicalName**: msdyn_quote<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: quote


### <a name="BKMK_msdyn_quotelineanalyticsbreakdownId"></a> msdyn_quotelineanalyticsbreakdownId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Quote Line Analytics Breakdown<br />
**LogicalName**: msdyn_quotelineanalyticsbreakdownid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_QuoteLineDetail"></a> msdyn_QuoteLineDetail

**Description**: Select the quote line estimate.<br />
**DisplayName**: Quote Line Detail<br />
**LogicalName**: msdyn_quotelinedetail<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_quotelinetransaction


### <a name="BKMK_msdyn_QuoteLineScheduleOfValue"></a> msdyn_QuoteLineScheduleOfValue

**Description**: Shows the billing milestone for the quote line.<br />
**DisplayName**: QuoteLineScheduleOfValue<br />
**LogicalName**: msdyn_quotelinescheduleofvalue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_quotelinescheduleofvalue


### <a name="BKMK_msdyn_ResourceCategory"></a> msdyn_ResourceCategory

**Description**: Select the role that is estimated on the quote line.<br />
**DisplayName**: Role<br />
**LogicalName**: msdyn_resourcecategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecategory


### <a name="BKMK_msdyn_StartDateTime"></a> msdyn_StartDateTime

**Description**: Enter the estimated start date of the quote line estimate.<br />
**DisplayName**: Start Date Time<br />
**LogicalName**: msdyn_startdatetime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

**Description**: Select the category identified on the quote line estimate.<br />
**DisplayName**: Transaction Category<br />
**LogicalName**: msdyn_transactioncategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_transactioncategory


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

**Description**: Transaction classification of  Project quote analytics<br />
**DisplayName**: Transaction Class<br />
**LogicalName**: msdyn_transactionclassification<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
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



### <a name="BKMK_msdyn_TransactionTypeCode"></a> msdyn_TransactionTypeCode

**Description**: Transaction type of the Project quote analytics<br />
**DisplayName**: Transaction Type<br />
**LogicalName**: msdyn_transactiontypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Cost
- **Value**: 192350004 **Label**: Project Contract
- **Value**: 192350005 **Label**: Unbilled Sales
- **Value**: 192350006 **Label**: Billed Sales
- **Value**: 192350007 **Label**: Resourcing Unit Cost
- **Value**: 192350008 **Label**: Inter-Organizational Sales



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

**Description**: Status of the Quote Line Analytics Breakdown<br />
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

**Description**: Reason for the status of the Quote Line Analytics Breakdown<br />
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

**Description**: Shows the currency associated with the entity.<br />
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
- [msdyn_amount_Base](#BKMK_msdyn_amount_Base)
- [msdyn_price_Base](#BKMK_msdyn_price_Base)
- [msdyn_QuoteLineDetailName](#BKMK_msdyn_QuoteLineDetailName)
- [msdyn_QuoteLineScheduleOfValueName](#BKMK_msdyn_QuoteLineScheduleOfValueName)
- [msdyn_QuoteName](#BKMK_msdyn_QuoteName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
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

**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />
**DisplayName**: Exchange Rate<br />
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


### <a name="BKMK_msdyn_amount_Base"></a> msdyn_amount_Base

**Description**: Value of the Amount in base currency.<br />
**DisplayName**: Amount (Base)<br />
**LogicalName**: msdyn_amount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_price_Base"></a> msdyn_price_Base

**Description**: Value of the Price in base currency.<br />
**DisplayName**: Price (Base)<br />
**LogicalName**: msdyn_price_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_QuoteLineDetailName"></a> msdyn_QuoteLineDetailName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotelinedetailname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_QuoteLineScheduleOfValueName"></a> msdyn_QuoteLineScheduleOfValueName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotelinescheduleofvaluename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_QuoteName"></a> msdyn_QuoteName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


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

- [msdyn_quotelineanalyticsbreakdown_SyncErrors](#BKMK_msdyn_quotelineanalyticsbreakdown_SyncErrors)
- [msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord](#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord)
- [msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord](#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord)
- [msdyn_quotelineanalyticsbreakdown_AsyncOperations](#BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations)
- [msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders](#BKMK_msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders)
- [msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas](#BKMK_msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas)
- [msdyn_quotelineanalyticsbreakdown_ProcessSession](#BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession)
- [msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures](#BKMK_msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures)
- [msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_SyncErrors"></a> msdyn_quotelineanalyticsbreakdown_SyncErrors

Same as syncerror entity [msdyn_quotelineanalyticsbreakdown_SyncErrors](syncerror.md#BKMK_msdyn_quotelineanalyticsbreakdown_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineanalyticsbreakdown_SyncErrors<br />
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


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord"></a> msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord"></a> msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations"></a> msdyn_quotelineanalyticsbreakdown_AsyncOperations

Same as asyncoperation entity [msdyn_quotelineanalyticsbreakdown_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineanalyticsbreakdown_AsyncOperations<br />
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


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders"></a> msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas"></a> msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession"></a> msdyn_quotelineanalyticsbreakdown_ProcessSession

Same as processsession entity [msdyn_quotelineanalyticsbreakdown_ProcessSession](processsession.md#BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineanalyticsbreakdown_ProcessSession<br />
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


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures"></a> msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses"></a> msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_quotelineanalyticsbreakdown_createdby](#BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdby)
- [lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby](#BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby)
- [lk_msdyn_quotelineanalyticsbreakdown_modifiedby](#BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedby)
- [lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby](#BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby)
- [user_msdyn_quotelineanalyticsbreakdown](#BKMK_user_msdyn_quotelineanalyticsbreakdown)
- [team_msdyn_quotelineanalyticsbreakdown](#BKMK_team_msdyn_quotelineanalyticsbreakdown)
- [business_unit_msdyn_quotelineanalyticsbreakdown](#BKMK_business_unit_msdyn_quotelineanalyticsbreakdown)
- [TransactionCurrency_msdyn_quotelineanalyticsbreakdown](#BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown)
- [msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory)
- [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue](#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue)
- [msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail](#BKMK_msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail)
- [msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory)
- [msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote](#BKMK_msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote)


### <a name="BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdby"></a> lk_msdyn_quotelineanalyticsbreakdown_createdby

See systemuser Entity [lk_msdyn_quotelineanalyticsbreakdown_createdby](systemuser.md#BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby"></a> lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby

See systemuser Entity [lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedby"></a> lk_msdyn_quotelineanalyticsbreakdown_modifiedby

See systemuser Entity [lk_msdyn_quotelineanalyticsbreakdown_modifiedby](systemuser.md#BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby"></a> lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby

See systemuser Entity [lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotelineanalyticsbreakdown"></a> user_msdyn_quotelineanalyticsbreakdown

See systemuser Entity [user_msdyn_quotelineanalyticsbreakdown](systemuser.md#BKMK_user_msdyn_quotelineanalyticsbreakdown) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotelineanalyticsbreakdown"></a> team_msdyn_quotelineanalyticsbreakdown

See team Entity [team_msdyn_quotelineanalyticsbreakdown](team.md#BKMK_team_msdyn_quotelineanalyticsbreakdown) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotelineanalyticsbreakdown"></a> business_unit_msdyn_quotelineanalyticsbreakdown

See businessunit Entity [business_unit_msdyn_quotelineanalyticsbreakdown](businessunit.md#BKMK_business_unit_msdyn_quotelineanalyticsbreakdown) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown"></a> TransactionCurrency_msdyn_quotelineanalyticsbreakdown

See transactioncurrency Entity [TransactionCurrency_msdyn_quotelineanalyticsbreakdown](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue"></a> msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue

See msdyn_quotelinescheduleofvalue Entity [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail"></a> msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail

See msdyn_quotelinetransaction Entity [msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail](msdyn_quotelinetransaction.md#BKMK_msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote"></a> msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote

See quote Entity [msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotelineanalyticsbreakdown?text=msdyn_quotelineanalyticsbreakdown EntityType" />