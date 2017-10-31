---
title: "msdyn_journalline Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_journalline entity."
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
# msdyn_journalline Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Unposted business transaction line details.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_journallines(*msdyn_journallineid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_journallines<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_journallines(*msdyn_journallineid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_journallines(*msdyn_journallineid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_journallines<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_journallines(*msdyn_journallineid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_journallines(*msdyn_journallineid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Journal Line<br />
**DisplayCollectionName**: Journal Lines<br />
**SchemaName**: msdyn_journalline<br />
**CollectionSchemaName**: msdyn_journallines<br />
**LogicalName**: msdyn_journalline<br />
**LogicalCollectionName**: msdyn_journallines<br />
**EntitySetName**: msdyn_journallines<br />
**PrimaryIdAttribute**: msdyn_journallineid<br />
**PrimaryNameAttribute**: msdyn_description<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AccountCustomer](#BKMK_msdyn_AccountCustomer)
- [msdyn_AccountingDate](#BKMK_msdyn_AccountingDate)
- [msdyn_AccountVendor](#BKMK_msdyn_AccountVendor)
- [msdyn_Amount](#BKMK_msdyn_Amount)
- [msdyn_AmountMethod](#BKMK_msdyn_AmountMethod)
- [msdyn_BasisAmount](#BKMK_msdyn_BasisAmount)
- [msdyn_BasisPrice](#BKMK_msdyn_BasisPrice)
- [msdyn_BasisQuantity](#BKMK_msdyn_BasisQuantity)
- [msdyn_BillingStatus](#BKMK_msdyn_BillingStatus)
- [msdyn_BillingType](#BKMK_msdyn_BillingType)
- [msdyn_bookableresource](#BKMK_msdyn_bookableresource)
- [msdyn_ContactCustomer](#BKMK_msdyn_ContactCustomer)
- [msdyn_ContactVendor](#BKMK_msdyn_ContactVendor)
- [msdyn_contractorganizationalunitid](#BKMK_msdyn_contractorganizationalunitid)
- [msdyn_CustomerType](#BKMK_msdyn_CustomerType)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_DocumentDate](#BKMK_msdyn_DocumentDate)
- [msdyn_EndDateTime](#BKMK_msdyn_EndDateTime)
- [msdyn_ExchangeRateDate](#BKMK_msdyn_ExchangeRateDate)
- [msdyn_externaldescription](#BKMK_msdyn_externaldescription)
- [msdyn_IsPosted](#BKMK_msdyn_IsPosted)
- [msdyn_Journal](#BKMK_msdyn_Journal)
- [msdyn_journallineId](#BKMK_msdyn_journallineId)
- [msdyn_Percent](#BKMK_msdyn_Percent)
- [msdyn_Price](#BKMK_msdyn_Price)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_Project](#BKMK_msdyn_Project)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_ResourceOrganizationalUnitId](#BKMK_msdyn_ResourceOrganizationalUnitId)
- [msdyn_SalesContract](#BKMK_msdyn_SalesContract)
- [msdyn_SalesContractLine](#BKMK_msdyn_SalesContractLine)
- [msdyn_StartDateTime](#BKMK_msdyn_StartDateTime)
- [msdyn_Task](#BKMK_msdyn_Task)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [msdyn_TransactionTypeCode](#BKMK_msdyn_TransactionTypeCode)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitSchedule](#BKMK_msdyn_UnitSchedule)
- [msdyn_VendorType](#BKMK_msdyn_VendorType)
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


### <a name="BKMK_msdyn_AccountCustomer"></a> msdyn_AccountCustomer

**Description**: Shows the customer for the journal line.<br />
**DisplayName**: Customer<br />
**LogicalName**: msdyn_accountcustomer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_AccountingDate"></a> msdyn_AccountingDate

**Description**: <br />
**DisplayName**: Accounting Date<br />
**LogicalName**: msdyn_accountingdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_AccountVendor"></a> msdyn_AccountVendor

**Description**: <br />
**DisplayName**: Vendor<br />
**LogicalName**: msdyn_accountvendor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_Amount"></a> msdyn_Amount

**Description**: Shows the amount of the journal line.<br />
**DisplayName**: Amount<br />
**LogicalName**: msdyn_amount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_AmountMethod"></a> msdyn_AmountMethod

**Description**: Select the calculation method for the amount.<br />
**DisplayName**: Amount Method<br />
**LogicalName**: msdyn_amountmethod<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Multiply Quantity By Price
- **Value**: 192350001 **Label**: Fixed Price
- **Value**: 192350002 **Label**: Multiply Basis Quantity By Price
- **Value**: 192350003 **Label**: Multiply Basis Amount By Percent
- **Value**: 690970000 **Label**: Tax Calculation



### <a name="BKMK_msdyn_BasisAmount"></a> msdyn_BasisAmount

**Description**: Enter the basis amount of the journal line.<br />
**DisplayName**: Basis Amount<br />
**LogicalName**: msdyn_basisamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_BasisPrice"></a> msdyn_BasisPrice

**Description**: Enter the basis price of the journal line.<br />
**DisplayName**: Basis Price<br />
**LogicalName**: msdyn_basisprice<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_BasisQuantity"></a> msdyn_BasisQuantity

**Description**: Enter the basis quantity of the journal line.<br />
**DisplayName**: Basis Quantity<br />
**LogicalName**: msdyn_basisquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_BillingStatus"></a> msdyn_BillingStatus

**Description**: <br />
**DisplayName**: Billing Status<br />
**LogicalName**: msdyn_billingstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Unbilled Sales Created
- **Value**: 192350001 **Label**: Customer Invoice Created
- **Value**: 192350002 **Label**: Customer Invoice Posted
- **Value**: 192350003 **Label**: Canceled
- **Value**: 690970000 **Label**: Work order closed - posted



### <a name="BKMK_msdyn_BillingType"></a> msdyn_BillingType

**Description**: Select the billing type for the journal line.<br />
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



### <a name="BKMK_msdyn_bookableresource"></a> msdyn_bookableresource

**Description**: Shows the resource.<br />
**DisplayName**: Bookable Resource<br />
**LogicalName**: msdyn_bookableresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_ContactCustomer"></a> msdyn_ContactCustomer

**Description**: <br />
**DisplayName**: Customer<br />
**LogicalName**: msdyn_contactcustomer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_msdyn_ContactVendor"></a> msdyn_ContactVendor

**Description**: <br />
**DisplayName**: Vendor<br />
**LogicalName**: msdyn_contactvendor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_msdyn_contractorganizationalunitid"></a> msdyn_contractorganizationalunitid

**Description**: Unique identifier for Organizational Unit associated with Journal Line.<br />
**DisplayName**: Contracting Unit<br />
**LogicalName**: msdyn_contractorganizationalunitid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Lookup<br />
**Targets**: msdyn_organizationalunit


### <a name="BKMK_msdyn_CustomerType"></a> msdyn_CustomerType

**Description**: Shows the type of customer.<br />
**DisplayName**: Customer Type<br />
**LogicalName**: msdyn_customertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350001 **Label**: Account
- **Value**: 192350002 **Label**: Contact



### <a name="BKMK_msdyn_description"></a> msdyn_description

**Description**: The name of the custom entity.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DocumentDate"></a> msdyn_DocumentDate

**Description**: Enter the transaction date of the journal line.<br />
**DisplayName**: Document Date<br />
**LogicalName**: msdyn_documentdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_EndDateTime"></a> msdyn_EndDateTime

**Description**: Enter the end date and time.<br />
**DisplayName**: End Date/Time<br />
**LogicalName**: msdyn_enddatetime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_ExchangeRateDate"></a> msdyn_ExchangeRateDate

**Description**: <br />
**DisplayName**: Exchange Rate Date<br />
**LogicalName**: msdyn_exchangeratedate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_externaldescription"></a> msdyn_externaldescription

**Description**: The external description of the journal line.<br />
**DisplayName**: External Description<br />
**LogicalName**: msdyn_externaldescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_IsPosted"></a> msdyn_IsPosted

**Description**: Shows whether the journal has been submitted.<br />
**DisplayName**: Is Posted<br />
**LogicalName**: msdyn_isposted<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_Journal"></a> msdyn_Journal

**Description**: Shows the name of the journal.<br />
**DisplayName**: Journal<br />
**LogicalName**: msdyn_journal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_journal


### <a name="BKMK_msdyn_journallineId"></a> msdyn_journallineId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Journal Line<br />
**LogicalName**: msdyn_journallineid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_Percent"></a> msdyn_Percent

**Description**: Enter the percent.<br />
**DisplayName**: Percent<br />
**LogicalName**: msdyn_percent<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_Price"></a> msdyn_Price

**Description**: Enter the price.<br />
**DisplayName**: Price<br />
**LogicalName**: msdyn_price<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

**Description**: Shows the price list used for the journal line.<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: Select the product.<br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_Project"></a> msdyn_Project

**Description**: Select the project.<br />
**DisplayName**: Project<br />
**LogicalName**: msdyn_project<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_project


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

**Description**: Enter the quantity.<br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_ResourceCategory"></a> msdyn_ResourceCategory

**Description**: Select the resource role.<br />
**DisplayName**: Role<br />
**LogicalName**: msdyn_resourcecategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecategory


### <a name="BKMK_msdyn_ResourceOrganizationalUnitId"></a> msdyn_ResourceOrganizationalUnitId

**Description**: Organizational unit at the time the entry was registered of the resource who performed the work.<br />
**DisplayName**: Resourcing Unit<br />
**LogicalName**: msdyn_resourceorganizationalunitid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Lookup<br />
**Targets**: msdyn_organizationalunit


### <a name="BKMK_msdyn_SalesContract"></a> msdyn_SalesContract

**Description**: Shows the project contract.<br />
**DisplayName**: Project Contract<br />
**LogicalName**: msdyn_salescontract<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: salesorder


### <a name="BKMK_msdyn_SalesContractLine"></a> msdyn_SalesContractLine

**Description**: Shows the project contract line.<br />
**DisplayName**: Project Contract Line<br />
**LogicalName**: msdyn_salescontractline<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_StartDateTime"></a> msdyn_StartDateTime

**Description**: Enter the start date and time.<br />
**DisplayName**: Start Date/Time<br />
**LogicalName**: msdyn_startdatetime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_Task"></a> msdyn_Task

**Description**: Select the project task.<br />
**DisplayName**: Task<br />
**LogicalName**: msdyn_task<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_projecttask


### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

**Description**: Select the transaction category.<br />
**DisplayName**: Transaction Category<br />
**LogicalName**: msdyn_transactioncategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_transactioncategory


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

**Description**: Select the transaction class.<br />
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

**Description**: <br />
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



### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

**Description**: Shows the unit of measurement.<br />
**DisplayName**: Unit<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_UnitSchedule"></a> msdyn_UnitSchedule

**Description**: Shows the unit schedule.<br />
**DisplayName**: Unit Schedule<br />
**LogicalName**: msdyn_unitschedule<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uomschedule


### <a name="BKMK_msdyn_VendorType"></a> msdyn_VendorType

**Description**: <br />
**DisplayName**: Vendor Type<br />
**LogicalName**: msdyn_vendortype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350001 **Label**: Account
- **Value**: 192350002 **Label**: Contact



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

**Description**: Status of the Journal Line<br />
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

**Description**: Reason for the status of the Journal Line<br />
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
- [msdyn_AccountCustomerName](#BKMK_msdyn_AccountCustomerName)
- [msdyn_AccountCustomerYomiName](#BKMK_msdyn_AccountCustomerYomiName)
- [msdyn_AccountVendorName](#BKMK_msdyn_AccountVendorName)
- [msdyn_AccountVendorYomiName](#BKMK_msdyn_AccountVendorYomiName)
- [msdyn_amount_Base](#BKMK_msdyn_amount_Base)
- [msdyn_basisamount_Base](#BKMK_msdyn_basisamount_Base)
- [msdyn_basisprice_Base](#BKMK_msdyn_basisprice_Base)
- [msdyn_bookableresourceName](#BKMK_msdyn_bookableresourceName)
- [msdyn_ContactCustomerName](#BKMK_msdyn_ContactCustomerName)
- [msdyn_ContactCustomerYomiName](#BKMK_msdyn_ContactCustomerYomiName)
- [msdyn_ContactVendorName](#BKMK_msdyn_ContactVendorName)
- [msdyn_ContactVendorYomiName](#BKMK_msdyn_ContactVendorYomiName)
- [msdyn_contractorganizationalunitidName](#BKMK_msdyn_contractorganizationalunitidName)
- [msdyn_JournalName](#BKMK_msdyn_JournalName)
- [msdyn_price_Base](#BKMK_msdyn_price_Base)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_ProjectName](#BKMK_msdyn_ProjectName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
- [msdyn_ResourceOrganizationalUnitIdName](#BKMK_msdyn_ResourceOrganizationalUnitIdName)
- [msdyn_SalesContractName](#BKMK_msdyn_SalesContractName)
- [msdyn_TaskName](#BKMK_msdyn_TaskName)
- [msdyn_TransactionCategoryName](#BKMK_msdyn_TransactionCategoryName)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_UnitScheduleName](#BKMK_msdyn_UnitScheduleName)
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


### <a name="BKMK_msdyn_AccountCustomerName"></a> msdyn_AccountCustomerName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_accountcustomername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_AccountCustomerYomiName"></a> msdyn_AccountCustomerYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_accountcustomeryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_AccountVendorName"></a> msdyn_AccountVendorName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_accountvendorname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_AccountVendorYomiName"></a> msdyn_AccountVendorYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_accountvendoryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


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


### <a name="BKMK_msdyn_basisamount_Base"></a> msdyn_basisamount_Base

**Description**: Value of the Basis Amount in base currency.<br />
**DisplayName**: Basis Amount (Base)<br />
**LogicalName**: msdyn_basisamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_basisprice_Base"></a> msdyn_basisprice_Base

**Description**: Value of the Basis Price in base currency.<br />
**DisplayName**: Basis Price (Base)<br />
**LogicalName**: msdyn_basisprice_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_bookableresourceName"></a> msdyn_bookableresourceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_bookableresourcename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ContactCustomerName"></a> msdyn_ContactCustomerName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_contactcustomername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ContactCustomerYomiName"></a> msdyn_ContactCustomerYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_contactcustomeryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_ContactVendorName"></a> msdyn_ContactVendorName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_contactvendorname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ContactVendorYomiName"></a> msdyn_ContactVendorYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_contactvendoryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_contractorganizationalunitidName"></a> msdyn_contractorganizationalunitidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_contractorganizationalunitidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_JournalName"></a> msdyn_JournalName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_journalname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_msdyn_PriceListName"></a> msdyn_PriceListName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_pricelistname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ProductName"></a> msdyn_ProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_productname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ProjectName"></a> msdyn_ProjectName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_projectname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_msdyn_ResourceOrganizationalUnitIdName"></a> msdyn_ResourceOrganizationalUnitIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourceorganizationalunitidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SalesContractName"></a> msdyn_SalesContractName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_salescontractname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_msdyn_TaskName"></a> msdyn_TaskName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_taskname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


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


### <a name="BKMK_msdyn_UnitName"></a> msdyn_UnitName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_unitname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_UnitScheduleName"></a> msdyn_UnitScheduleName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_unitschedulename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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

- [msdyn_journalline_SyncErrors](#BKMK_msdyn_journalline_SyncErrors)
- [msdyn_journalline_DuplicateMatchingRecord](#BKMK_msdyn_journalline_DuplicateMatchingRecord)
- [msdyn_journalline_DuplicateBaseRecord](#BKMK_msdyn_journalline_DuplicateBaseRecord)
- [msdyn_journalline_AsyncOperations](#BKMK_msdyn_journalline_AsyncOperations)
- [msdyn_journalline_MailboxTrackingFolders](#BKMK_msdyn_journalline_MailboxTrackingFolders)
- [msdyn_journalline_UserEntityInstanceDatas](#BKMK_msdyn_journalline_UserEntityInstanceDatas)
- [msdyn_journalline_ProcessSession](#BKMK_msdyn_journalline_ProcessSession)
- [msdyn_journalline_BulkDeleteFailures](#BKMK_msdyn_journalline_BulkDeleteFailures)
- [msdyn_journalline_PrincipalObjectAttributeAccesses](#BKMK_msdyn_journalline_PrincipalObjectAttributeAccesses)
- [msdyn_journalline_Annotations](#BKMK_msdyn_journalline_Annotations)
- [msdyn_msdyn_journalline_msdyn_projectapproval_referencejournalline](#BKMK_msdyn_msdyn_journalline_msdyn_projectapproval_referencejournalline)


### <a name="BKMK_msdyn_journalline_SyncErrors"></a> msdyn_journalline_SyncErrors

Same as syncerror entity [msdyn_journalline_SyncErrors](syncerror.md#BKMK_msdyn_journalline_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_SyncErrors<br />
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


### <a name="BKMK_msdyn_journalline_DuplicateMatchingRecord"></a> msdyn_journalline_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_journalline_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_journalline_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_journalline_DuplicateBaseRecord"></a> msdyn_journalline_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_journalline_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_journalline_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_journalline_AsyncOperations"></a> msdyn_journalline_AsyncOperations

Same as asyncoperation entity [msdyn_journalline_AsyncOperations](asyncoperation.md#BKMK_msdyn_journalline_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_AsyncOperations<br />
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


### <a name="BKMK_msdyn_journalline_MailboxTrackingFolders"></a> msdyn_journalline_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_journalline_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_journalline_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_journalline_UserEntityInstanceDatas"></a> msdyn_journalline_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_journalline_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_journalline_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_journalline_ProcessSession"></a> msdyn_journalline_ProcessSession

Same as processsession entity [msdyn_journalline_ProcessSession](processsession.md#BKMK_msdyn_journalline_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_ProcessSession<br />
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


### <a name="BKMK_msdyn_journalline_BulkDeleteFailures"></a> msdyn_journalline_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_journalline_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_journalline_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_journalline_PrincipalObjectAttributeAccesses"></a> msdyn_journalline_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_journalline_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_journalline_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_journalline_Annotations"></a> msdyn_journalline_Annotations

Same as annotation entity [msdyn_journalline_Annotations](annotation.md#BKMK_msdyn_journalline_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_journalline_Annotations<br />
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


### <a name="BKMK_msdyn_msdyn_journalline_msdyn_projectapproval_referencejournalline"></a> msdyn_msdyn_journalline_msdyn_projectapproval_referencejournalline

Same as msdyn_projectapproval entity [msdyn_msdyn_journalline_msdyn_projectapproval_referencejournalline](msdyn_projectapproval.md#BKMK_msdyn_msdyn_journalline_msdyn_projectapproval_referencejournalline) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectapproval<br />
**ReferencingAttribute**: msdyn_referencejournalline<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_journalline_msdyn_projectapproval_referencejournalline<br />
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

- [lk_msdyn_journalline_createdby](#BKMK_lk_msdyn_journalline_createdby)
- [lk_msdyn_journalline_createdonbehalfby](#BKMK_lk_msdyn_journalline_createdonbehalfby)
- [lk_msdyn_journalline_modifiedby](#BKMK_lk_msdyn_journalline_modifiedby)
- [lk_msdyn_journalline_modifiedonbehalfby](#BKMK_lk_msdyn_journalline_modifiedonbehalfby)
- [user_msdyn_journalline](#BKMK_user_msdyn_journalline)
- [team_msdyn_journalline](#BKMK_team_msdyn_journalline)
- [business_unit_msdyn_journalline](#BKMK_business_unit_msdyn_journalline)
- [TransactionCurrency_msdyn_journalline](#BKMK_TransactionCurrency_msdyn_journalline)
- [msdyn_account_msdyn_journalline_AccountCustomer](#BKMK_msdyn_account_msdyn_journalline_AccountCustomer)
- [msdyn_account_msdyn_journalline_AccountVendor](#BKMK_msdyn_account_msdyn_journalline_AccountVendor)
- [msdyn_bookableresource_msdyn_journalline_bookableresource](#BKMK_msdyn_bookableresource_msdyn_journalline_bookableresource)
- [msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory)
- [msdyn_contact_msdyn_journalline_ContactCustomer](#BKMK_msdyn_contact_msdyn_journalline_ContactCustomer)
- [msdyn_contact_msdyn_journalline_ContactVendor](#BKMK_msdyn_contact_msdyn_journalline_ContactVendor)
- [msdyn_msdyn_journal_msdyn_journalline_Journal](#BKMK_msdyn_msdyn_journal_msdyn_journalline_Journal)
- [msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId](#BKMK_msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId)
- [msdyn_msdyn_project_msdyn_journalline_Project](#BKMK_msdyn_msdyn_project_msdyn_journalline_Project)
- [msdyn_msdyn_projecttask_msdyn_journalline_Task](#BKMK_msdyn_msdyn_projecttask_msdyn_journalline_Task)
- [msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory)
- [msdyn_organizationalunit_journalline](#BKMK_msdyn_organizationalunit_journalline)
- [msdyn_pricelevel_msdyn_journalline_PriceList](#BKMK_msdyn_pricelevel_msdyn_journalline_PriceList)
- [msdyn_product_msdyn_journalline_Product](#BKMK_msdyn_product_msdyn_journalline_Product)
- [msdyn_salesorder_msdyn_journalline_SalesContract](#BKMK_msdyn_salesorder_msdyn_journalline_SalesContract)
- [msdyn_uom_msdyn_journalline_Unit](#BKMK_msdyn_uom_msdyn_journalline_Unit)
- [msdyn_uomschedule_msdyn_journalline_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_journalline_UnitSchedule)


### <a name="BKMK_lk_msdyn_journalline_createdby"></a> lk_msdyn_journalline_createdby

See systemuser Entity [lk_msdyn_journalline_createdby](systemuser.md#BKMK_lk_msdyn_journalline_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_journalline_createdonbehalfby"></a> lk_msdyn_journalline_createdonbehalfby

See systemuser Entity [lk_msdyn_journalline_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_journalline_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_journalline_modifiedby"></a> lk_msdyn_journalline_modifiedby

See systemuser Entity [lk_msdyn_journalline_modifiedby](systemuser.md#BKMK_lk_msdyn_journalline_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_journalline_modifiedonbehalfby"></a> lk_msdyn_journalline_modifiedonbehalfby

See systemuser Entity [lk_msdyn_journalline_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_journalline_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_journalline"></a> user_msdyn_journalline

See systemuser Entity [user_msdyn_journalline](systemuser.md#BKMK_user_msdyn_journalline) One-To-Many relationship.

### <a name="BKMK_team_msdyn_journalline"></a> team_msdyn_journalline

See team Entity [team_msdyn_journalline](team.md#BKMK_team_msdyn_journalline) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_journalline"></a> business_unit_msdyn_journalline

See businessunit Entity [business_unit_msdyn_journalline](businessunit.md#BKMK_business_unit_msdyn_journalline) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_journalline"></a> TransactionCurrency_msdyn_journalline

See transactioncurrency Entity [TransactionCurrency_msdyn_journalline](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_journalline) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_journalline_AccountCustomer"></a> msdyn_account_msdyn_journalline_AccountCustomer

See account Entity [msdyn_account_msdyn_journalline_AccountCustomer](account.md#BKMK_msdyn_account_msdyn_journalline_AccountCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_journalline_AccountVendor"></a> msdyn_account_msdyn_journalline_AccountVendor

See account Entity [msdyn_account_msdyn_journalline_AccountVendor](account.md#BKMK_msdyn_account_msdyn_journalline_AccountVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_journalline_bookableresource"></a> msdyn_bookableresource_msdyn_journalline_bookableresource

See bookableresource Entity [msdyn_bookableresource_msdyn_journalline_bookableresource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_journalline_bookableresource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_journalline_ContactCustomer"></a> msdyn_contact_msdyn_journalline_ContactCustomer

See contact Entity [msdyn_contact_msdyn_journalline_ContactCustomer](contact.md#BKMK_msdyn_contact_msdyn_journalline_ContactCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_journalline_ContactVendor"></a> msdyn_contact_msdyn_journalline_ContactVendor

See contact Entity [msdyn_contact_msdyn_journalline_ContactVendor](contact.md#BKMK_msdyn_contact_msdyn_journalline_ContactVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_journal_msdyn_journalline_Journal"></a> msdyn_msdyn_journal_msdyn_journalline_Journal

See msdyn_journal Entity [msdyn_msdyn_journal_msdyn_journalline_Journal](msdyn_journal.md#BKMK_msdyn_msdyn_journal_msdyn_journalline_Journal) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId"></a> msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId

See msdyn_organizationalunit Entity [msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId](msdyn_organizationalunit.md#BKMK_msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_msdyn_journalline_Project"></a> msdyn_msdyn_project_msdyn_journalline_Project

See msdyn_project Entity [msdyn_msdyn_project_msdyn_journalline_Project](msdyn_project.md#BKMK_msdyn_msdyn_project_msdyn_journalline_Project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_journalline_Task"></a> msdyn_msdyn_projecttask_msdyn_journalline_Task

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_journalline_Task](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_journalline_Task) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_journalline"></a> msdyn_organizationalunit_journalline

See msdyn_organizationalunit Entity [msdyn_organizationalunit_journalline](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_journalline) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_journalline_PriceList"></a> msdyn_pricelevel_msdyn_journalline_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_journalline_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_journalline_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_journalline_Product"></a> msdyn_product_msdyn_journalline_Product

See product Entity [msdyn_product_msdyn_journalline_Product](product.md#BKMK_msdyn_product_msdyn_journalline_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorder_msdyn_journalline_SalesContract"></a> msdyn_salesorder_msdyn_journalline_SalesContract

See salesorder Entity [msdyn_salesorder_msdyn_journalline_SalesContract](salesorder.md#BKMK_msdyn_salesorder_msdyn_journalline_SalesContract) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_journalline_Unit"></a> msdyn_uom_msdyn_journalline_Unit

See uom Entity [msdyn_uom_msdyn_journalline_Unit](uom.md#BKMK_msdyn_uom_msdyn_journalline_Unit) One-To-Many relationship.

### <a name="BKMK_msdyn_uomschedule_msdyn_journalline_UnitSchedule"></a> msdyn_uomschedule_msdyn_journalline_UnitSchedule

See uomschedule Entity [msdyn_uomschedule_msdyn_journalline_UnitSchedule](uomschedule.md#BKMK_msdyn_uomschedule_msdyn_journalline_UnitSchedule) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_journalline?text=msdyn_journalline EntityType" />