---
title: "msdyn_actual Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_actual entity."
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
# msdyn_actual Entity Reference



**Added by**: Unified Resource Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_actuals(*msdyn_actualid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_actuals<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_actuals(*msdyn_actualid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_actuals(*msdyn_actualid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_actuals<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_actuals(*msdyn_actualid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_actuals(*msdyn_actualid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Actual<br />
**DisplayCollectionName**: Actuals<br />
**SchemaName**: msdyn_actual<br />
**CollectionSchemaName**: msdyn_actuals<br />
**LogicalName**: msdyn_actual<br />
**LogicalCollectionName**: msdyn_actuals<br />
**EntitySetName**: msdyn_actuals<br />
**PrimaryIdAttribute**: msdyn_actualid<br />
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
- [msdyn_actualId](#BKMK_msdyn_actualId)
- [msdyn_AdjustmentStatus](#BKMK_msdyn_AdjustmentStatus)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
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
- [msdyn_ExternalReferenceDate](#BKMK_msdyn_ExternalReferenceDate)
- [msdyn_ExternalReferenceID](#BKMK_msdyn_ExternalReferenceID)
- [msdyn_IncidentType](#BKMK_msdyn_IncidentType)
- [msdyn_Invoice](#BKMK_msdyn_Invoice)
- [msdyn_IsJournalized](#BKMK_msdyn_IsJournalized)
- [msdyn_JournalType](#BKMK_msdyn_JournalType)
- [msdyn_Percent](#BKMK_msdyn_Percent)
- [msdyn_Price](#BKMK_msdyn_Price)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_ProductType](#BKMK_msdyn_ProductType)
- [msdyn_Project](#BKMK_msdyn_Project)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_ResourceOrganizationalUnitId](#BKMK_msdyn_ResourceOrganizationalUnitId)
- [msdyn_SalesContract](#BKMK_msdyn_SalesContract)
- [msdyn_SalesContractLine](#BKMK_msdyn_SalesContractLine)
- [msdyn_ServiceAccount](#BKMK_msdyn_ServiceAccount)
- [msdyn_ServiceTerritory](#BKMK_msdyn_ServiceTerritory)
- [msdyn_StartDateTime](#BKMK_msdyn_StartDateTime)
- [msdyn_Task](#BKMK_msdyn_Task)
- [msdyn_TaxCode](#BKMK_msdyn_TaxCode)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [msdyn_TransactionTypeCode](#BKMK_msdyn_TransactionTypeCode)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitSchedule](#BKMK_msdyn_UnitSchedule)
- [msdyn_VendorType](#BKMK_msdyn_VendorType)
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_WorkOrderType](#BKMK_msdyn_WorkOrderType)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Select the customer.<br />
**DisplayName**: Customer ID<br />
**LogicalName**: msdyn_accountcustomer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_AccountingDate"></a> msdyn_AccountingDate

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: <br />
**DisplayName**: Vendor<br />
**LogicalName**: msdyn_accountvendor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_actualId"></a> msdyn_actualId

**Added by**: Project Service Automation Solution<br />
**Description**: Unique identifier for entity instances<br />
**DisplayName**: Actual<br />
**LogicalName**: msdyn_actualid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_AdjustmentStatus"></a> msdyn_AdjustmentStatus

**Added by**: Project Service Automation Solution<br />
**Description**: Shows the adjustment status ID of the transaction.<br />
**DisplayName**: Adjustment Status ID<br />
**LogicalName**: msdyn_adjustmentstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: In Process
- **Value**: 192350001 **Label**: Adjusted
- **Value**: 192350002 **Label**: Unadjustable



### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Agreement<br />
**LogicalName**: msdyn_agreement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreement


### <a name="BKMK_msdyn_Amount"></a> msdyn_Amount

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the amount in transaction currency.<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Select the method by which the amount was computed.<br />
**DisplayName**: Amount Method ID<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the cost amount of the sales transaction in the transaction currency.<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the cost price of the sales transaction in transaction currency.<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the cost quantity of the sales transaction in the base (organization) currency.<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Select the billing status ID.<br />
**DisplayName**: Billing status ID<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Select the billing type ID.<br />
**DisplayName**: Billing type ID<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Shows the bookable resource for which the actual is recorded.<br />
**DisplayName**: Bookable Resource<br />
**LogicalName**: msdyn_bookableresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_ContactCustomer"></a> msdyn_ContactCustomer

**Added by**: Project Service Automation Solution<br />
**Description**: Select the customer contact.<br />
**DisplayName**: Customer contact ID<br />
**LogicalName**: msdyn_contactcustomer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_msdyn_ContactVendor"></a> msdyn_ContactVendor

**Added by**: Project Service Automation Solution<br />
**Description**: <br />
**DisplayName**: Vendor<br />
**LogicalName**: msdyn_contactvendor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_msdyn_contractorganizationalunitid"></a> msdyn_contractorganizationalunitid

**Added by**: Project Service Automation Solution<br />
**Description**: Select the organizational unit ID for the contract.<br />
**DisplayName**: Contracting Unit<br />
**LogicalName**: msdyn_contractorganizationalunitid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_organizationalunit


### <a name="BKMK_msdyn_CustomerType"></a> msdyn_CustomerType

**Added by**: Project Service Automation Solution<br />
**Description**: Select the customer type ID.<br />
**DisplayName**: Customer type ID<br />
**LogicalName**: msdyn_customertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350001 **Label**: Account
- **Value**: 192350002 **Label**: Contact



### <a name="BKMK_msdyn_description"></a> msdyn_description

**Added by**: Project Service Automation Solution<br />
**Description**: Type the record description.<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the transaction date of the business event.<br />
**DisplayName**: Document Date<br />
**LogicalName**: msdyn_documentdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_EndDateTime"></a> msdyn_EndDateTime

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the end date and time for this transaction.<br />
**DisplayName**: End Date/Time<br />
**LogicalName**: msdyn_enddatetime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_ExchangeRateDate"></a> msdyn_ExchangeRateDate

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the date of the exchange rate used for this transaction.<br />
**DisplayName**: Exchange Rate Date<br />
**LogicalName**: msdyn_exchangeratedate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_externaldescription"></a> msdyn_externaldescription

**Added by**: Project Service Automation Solution<br />
**Description**: The external description of the business transaction.<br />
**DisplayName**: External Description<br />
**LogicalName**: msdyn_externaldescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ExternalReferenceDate"></a> msdyn_ExternalReferenceDate

**Description**: Stores a date from an external system, such as a journal entry voucher date from an ERP system<br />
**DisplayName**: External Reference Date<br />
**LogicalName**: msdyn_externalreferencedate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_ExternalReferenceID"></a> msdyn_ExternalReferenceID

**Description**: Stores an ID from an external system, such as the journal entry voucher number from an ERP system.<br />
**DisplayName**: External Reference ID<br />
**LogicalName**: msdyn_externalreferenceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_IncidentType"></a> msdyn_IncidentType

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Incident Type<br />
**LogicalName**: msdyn_incidenttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_incidenttype


### <a name="BKMK_msdyn_Invoice"></a> msdyn_Invoice

**Description**: The unique identifier of an invoice.<br />
**DisplayName**: Invoice<br />
**LogicalName**: msdyn_invoice<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: invoice


### <a name="BKMK_msdyn_IsJournalized"></a> msdyn_IsJournalized

**Added by**: Project Service Automation Solution<br />
**Description**: <br />
**DisplayName**: Is Journalized<br />
**LogicalName**: msdyn_isjournalized<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_JournalType"></a> msdyn_JournalType

**Added by**: Field Service Solution<br />
**Description**: Type of journal for resource cost.<br />
**DisplayName**: Journal Type<br />
**LogicalName**: msdyn_journaltype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Working Hours
- **Value**: 690970001 **Label**: Break
- **Value**: 690970002 **Label**: Travel
- **Value**: 690970003 **Label**: Overtime
- **Value**: 690970004 **Label**: Business Closure



### <a name="BKMK_msdyn_Percent"></a> msdyn_Percent

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the price in the transaction currency.<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Select the price list.<br />
**DisplayName**: Price list ID<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Added by**: Project Service Automation Solution<br />
**Description**: Select the product ID.<br />
**DisplayName**: Product ID<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_ProductType"></a> msdyn_ProductType

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Product Type<br />
**LogicalName**: msdyn_producttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Inventory
- **Value**: 690970001 **Label**: Non-Inventory
- **Value**: 690970002 **Label**: Service



### <a name="BKMK_msdyn_Project"></a> msdyn_Project

**Added by**: Project Service Automation Solution<br />
**Description**: Select the project ID.<br />
**DisplayName**: Project ID<br />
**LogicalName**: msdyn_project<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_project


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Select the role ID of the resource performing the work.<br />
**DisplayName**: Resource role ID<br />
**LogicalName**: msdyn_resourcecategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecategory


### <a name="BKMK_msdyn_ResourceOrganizationalUnitId"></a> msdyn_ResourceOrganizationalUnitId

**Added by**: Project Service Automation Solution<br />
**Description**: Organizational unit at the time the actual was registered of the resource who performed the work.<br />
**DisplayName**: Resourcing Unit<br />
**LogicalName**: msdyn_resourceorganizationalunitid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Lookup<br />
**Targets**: msdyn_organizationalunit


### <a name="BKMK_msdyn_SalesContract"></a> msdyn_SalesContract

**Added by**: Project Service Automation Solution<br />
**Description**: Select the project contract.<br />
**DisplayName**: Project Contract ID<br />
**LogicalName**: msdyn_salescontract<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: salesorder


### <a name="BKMK_msdyn_SalesContractLine"></a> msdyn_SalesContractLine

**Added by**: Project Service Automation Solution<br />
**Description**: Type the project contract line.<br />
**DisplayName**: Project Contract Line<br />
**LogicalName**: msdyn_salescontractline<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ServiceAccount"></a> msdyn_ServiceAccount

**Added by**: Field Service Solution<br />
**Description**: Account that was serviced<br />
**DisplayName**: Service Account<br />
**LogicalName**: msdyn_serviceaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Service Territory<br />
**LogicalName**: msdyn_serviceterritory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: territory


### <a name="BKMK_msdyn_StartDateTime"></a> msdyn_StartDateTime

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Select the task.<br />
**DisplayName**: Task ID<br />
**LogicalName**: msdyn_task<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_projecttask


### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Tax Code<br />
**LogicalName**: msdyn_taxcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_taxcode


### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

**Added by**: Project Service Automation Solution<br />
**Description**: Select the transaction category.<br />
**DisplayName**: Transaction category ID<br />
**LogicalName**: msdyn_transactioncategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_transactioncategory


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

**Added by**: Project Service Automation Solution<br />
**Description**: Shows the transaction classification of this transaction.<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Shows the transaction type of this transaction.<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Select the unit of measure.<br />
**DisplayName**: Unit of measure<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_UnitSchedule"></a> msdyn_UnitSchedule

**Added by**: Project Service Automation Solution<br />
**Description**: Select the unit schedule.<br />
**DisplayName**: Unit Schedule<br />
**LogicalName**: msdyn_unitschedule<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uomschedule


### <a name="BKMK_msdyn_VendorType"></a> msdyn_VendorType

**Added by**: Project Service Automation Solution<br />
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



### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Warehouse<br />
**LogicalName**: msdyn_warehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_WorkLocation"></a> msdyn_WorkLocation

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Work Location<br />
**LogicalName**: msdyn_worklocation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Onsite
- **Value**: 690970001 **Label**: Depot
- **Value**: 690970002 **Label**: Location Agnostic



### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Work Order<br />
**LogicalName**: msdyn_workorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_msdyn_WorkOrderType"></a> msdyn_WorkOrderType

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Work Order Type<br />
**LogicalName**: msdyn_workordertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workordertype


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Status of the Actual<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Reason for the status of the Actual<br />
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

**Added by**: Project Service Automation Solution<br />
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
- [msdyn_AgreementName](#BKMK_msdyn_AgreementName)
- [msdyn_amount_Base](#BKMK_msdyn_amount_Base)
- [msdyn_basisamount_Base](#BKMK_msdyn_basisamount_Base)
- [msdyn_basisprice_Base](#BKMK_msdyn_basisprice_Base)
- [msdyn_bookableresourceName](#BKMK_msdyn_bookableresourceName)
- [msdyn_ContactCustomerName](#BKMK_msdyn_ContactCustomerName)
- [msdyn_ContactCustomerYomiName](#BKMK_msdyn_ContactCustomerYomiName)
- [msdyn_ContactVendorName](#BKMK_msdyn_ContactVendorName)
- [msdyn_ContactVendorYomiName](#BKMK_msdyn_ContactVendorYomiName)
- [msdyn_contractorganizationalunitidName](#BKMK_msdyn_contractorganizationalunitidName)
- [msdyn_IncidentTypeName](#BKMK_msdyn_IncidentTypeName)
- [msdyn_InvoiceName](#BKMK_msdyn_InvoiceName)
- [msdyn_price_Base](#BKMK_msdyn_price_Base)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_ProjectName](#BKMK_msdyn_ProjectName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
- [msdyn_ResourceOrganizationalUnitIdName](#BKMK_msdyn_ResourceOrganizationalUnitIdName)
- [msdyn_SalesContractName](#BKMK_msdyn_SalesContractName)
- [msdyn_ServiceAccountName](#BKMK_msdyn_ServiceAccountName)
- [msdyn_ServiceAccountYomiName](#BKMK_msdyn_ServiceAccountYomiName)
- [msdyn_ServiceTerritoryName](#BKMK_msdyn_ServiceTerritoryName)
- [msdyn_TaskName](#BKMK_msdyn_TaskName)
- [msdyn_TaxCodeName](#BKMK_msdyn_TaxCodeName)
- [msdyn_TransactionCategoryName](#BKMK_msdyn_TransactionCategoryName)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_UnitScheduleName](#BKMK_msdyn_UnitScheduleName)
- [msdyn_WarehouseName](#BKMK_msdyn_WarehouseName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
- [msdyn_WorkOrderTypeName](#BKMK_msdyn_WorkOrderTypeName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
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

**Added by**: Project Service Automation Solution<br />
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


### <a name="BKMK_msdyn_AgreementName"></a> msdyn_AgreementName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_amount_Base"></a> msdyn_amount_Base

**Description**: Enter the value of the amount in the base (organization) currency.<br />
**DisplayName**: Amount (Base currency)<br />
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

**Description**: Enter the cost amount of the sales transaction in the base (organization) currency.<br />
**DisplayName**: Basis Amount (Base currency)<br />
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

**Description**: Enter the cost price of the sales transaction in base (organization) currency.<br />
**DisplayName**: Basis Price (Base currency)<br />
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


### <a name="BKMK_msdyn_IncidentTypeName"></a> msdyn_IncidentTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_incidenttypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_InvoiceName"></a> msdyn_InvoiceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_invoicename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_msdyn_price_Base"></a> msdyn_price_Base

**Description**: Enter the price in the base (organization) currency.<br />
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


### <a name="BKMK_msdyn_ServiceAccountName"></a> msdyn_ServiceAccountName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceaccountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ServiceAccountYomiName"></a> msdyn_ServiceAccountYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceaccountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ServiceTerritoryName"></a> msdyn_ServiceTerritoryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceterritoryname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_msdyn_TaxCodeName"></a> msdyn_TaxCodeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_taxcodename<br />
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


### <a name="BKMK_msdyn_WarehouseName"></a> msdyn_WarehouseName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_warehousename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderTypeName"></a> msdyn_WorkOrderTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workordertypename<br />
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

**Added by**: Project Service Automation Solution<br />
**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Project Service Automation Solution<br />
**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Project Service Automation Solution<br />
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

- [msdyn_actual_SyncErrors](#BKMK_msdyn_actual_SyncErrors)
- [msdyn_actual_DuplicateMatchingRecord](#BKMK_msdyn_actual_DuplicateMatchingRecord)
- [msdyn_actual_DuplicateBaseRecord](#BKMK_msdyn_actual_DuplicateBaseRecord)
- [msdyn_actual_AsyncOperations](#BKMK_msdyn_actual_AsyncOperations)
- [msdyn_actual_MailboxTrackingFolders](#BKMK_msdyn_actual_MailboxTrackingFolders)
- [msdyn_actual_UserEntityInstanceDatas](#BKMK_msdyn_actual_UserEntityInstanceDatas)
- [msdyn_actual_ProcessSession](#BKMK_msdyn_actual_ProcessSession)
- [msdyn_actual_BulkDeleteFailures](#BKMK_msdyn_actual_BulkDeleteFailures)
- [msdyn_actual_PrincipalObjectAttributeAccesses](#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses)
- [msdyn_actual_Annotations](#BKMK_msdyn_actual_Annotations)


### <a name="BKMK_msdyn_actual_SyncErrors"></a> msdyn_actual_SyncErrors

Same as syncerror entity [msdyn_actual_SyncErrors](syncerror.md#BKMK_msdyn_actual_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_SyncErrors<br />
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


### <a name="BKMK_msdyn_actual_DuplicateMatchingRecord"></a> msdyn_actual_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_actual_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_actual_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_actual_DuplicateBaseRecord"></a> msdyn_actual_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_actual_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_actual_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_actual_AsyncOperations"></a> msdyn_actual_AsyncOperations

Same as asyncoperation entity [msdyn_actual_AsyncOperations](asyncoperation.md#BKMK_msdyn_actual_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_AsyncOperations<br />
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


### <a name="BKMK_msdyn_actual_MailboxTrackingFolders"></a> msdyn_actual_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_actual_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_actual_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_actual_UserEntityInstanceDatas"></a> msdyn_actual_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_actual_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_actual_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_actual_ProcessSession"></a> msdyn_actual_ProcessSession

Same as processsession entity [msdyn_actual_ProcessSession](processsession.md#BKMK_msdyn_actual_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_ProcessSession<br />
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


### <a name="BKMK_msdyn_actual_BulkDeleteFailures"></a> msdyn_actual_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_actual_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_actual_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_actual_PrincipalObjectAttributeAccesses"></a> msdyn_actual_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_actual_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_actual_Annotations"></a> msdyn_actual_Annotations

Same as annotation entity [msdyn_actual_Annotations](annotation.md#BKMK_msdyn_actual_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_actual_Annotations<br />
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

- [lk_msdyn_actual_createdby](#BKMK_lk_msdyn_actual_createdby)
- [lk_msdyn_actual_createdonbehalfby](#BKMK_lk_msdyn_actual_createdonbehalfby)
- [lk_msdyn_actual_modifiedby](#BKMK_lk_msdyn_actual_modifiedby)
- [lk_msdyn_actual_modifiedonbehalfby](#BKMK_lk_msdyn_actual_modifiedonbehalfby)
- [user_msdyn_actual](#BKMK_user_msdyn_actual)
- [team_msdyn_actual](#BKMK_team_msdyn_actual)
- [business_unit_msdyn_actual](#BKMK_business_unit_msdyn_actual)
- [TransactionCurrency_msdyn_actual](#BKMK_TransactionCurrency_msdyn_actual)
- [msdyn_account_msdyn_actual_AccountCustomer](#BKMK_msdyn_account_msdyn_actual_AccountCustomer)
- [msdyn_account_msdyn_actual_AccountVendor](#BKMK_msdyn_account_msdyn_actual_AccountVendor)
- [msdyn_bookableresource_msdyn_actual_bookableresource](#BKMK_msdyn_bookableresource_msdyn_actual_bookableresource)
- [msdyn_contact_msdyn_actual_ContactCustomer](#BKMK_msdyn_contact_msdyn_actual_ContactCustomer)
- [msdyn_contact_msdyn_actual_ContactVendor](#BKMK_msdyn_contact_msdyn_actual_ContactVendor)
- [msdyn_invoice_msdyn_actual_Invoice](#BKMK_msdyn_invoice_msdyn_actual_Invoice)
- [msdyn_pricelevel_msdyn_actual_PriceList](#BKMK_msdyn_pricelevel_msdyn_actual_PriceList)
- [msdyn_product_msdyn_actual_Product](#BKMK_msdyn_product_msdyn_actual_Product)
- [msdyn_salesorder_msdyn_actual_SalesContract](#BKMK_msdyn_salesorder_msdyn_actual_SalesContract)
- [msdyn_uom_msdyn_actual_Unit](#BKMK_msdyn_uom_msdyn_actual_Unit)
- [msdyn_uomschedule_msdyn_actual_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule)
- [msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory)
- [msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId](#BKMK_msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId)
- [msdyn_msdyn_project_msdyn_actual_Project](#BKMK_msdyn_msdyn_project_msdyn_actual_Project)
- [msdyn_msdyn_projecttask_msdyn_actual_Task](#BKMK_msdyn_msdyn_projecttask_msdyn_actual_Task)
- [msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory)
- [msdyn_organizationalunit_actual](#BKMK_msdyn_organizationalunit_actual)
- [msdyn_account_msdyn_actual_ServiceAccount](#BKMK_msdyn_account_msdyn_actual_ServiceAccount)
- [msdyn_msdyn_agreement_msdyn_actual_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement)
- [msdyn_msdyn_incidenttype_msdyn_actual_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_actual_IncidentType)
- [msdyn_msdyn_taxcode_msdyn_actual_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_actual_TaxCode)
- [msdyn_msdyn_warehouse_msdyn_actual_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_actual_Warehouse)
- [msdyn_msdyn_workorder_msdyn_actual_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder)
- [msdyn_msdyn_workordertype_msdyn_actual_WorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_actual_WorkOrderType)
- [msdyn_territory_msdyn_actual_ServiceTerritory](#BKMK_msdyn_territory_msdyn_actual_ServiceTerritory)


### <a name="BKMK_lk_msdyn_actual_createdby"></a> lk_msdyn_actual_createdby

See systemuser Entity [lk_msdyn_actual_createdby](systemuser.md#BKMK_lk_msdyn_actual_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_actual_createdonbehalfby"></a> lk_msdyn_actual_createdonbehalfby

See systemuser Entity [lk_msdyn_actual_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_actual_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_actual_modifiedby"></a> lk_msdyn_actual_modifiedby

See systemuser Entity [lk_msdyn_actual_modifiedby](systemuser.md#BKMK_lk_msdyn_actual_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_actual_modifiedonbehalfby"></a> lk_msdyn_actual_modifiedonbehalfby

See systemuser Entity [lk_msdyn_actual_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_actual_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_actual"></a> user_msdyn_actual

See systemuser Entity [user_msdyn_actual](systemuser.md#BKMK_user_msdyn_actual) One-To-Many relationship.

### <a name="BKMK_team_msdyn_actual"></a> team_msdyn_actual

See team Entity [team_msdyn_actual](team.md#BKMK_team_msdyn_actual) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_actual"></a> business_unit_msdyn_actual

See businessunit Entity [business_unit_msdyn_actual](businessunit.md#BKMK_business_unit_msdyn_actual) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_actual"></a> TransactionCurrency_msdyn_actual

See transactioncurrency Entity [TransactionCurrency_msdyn_actual](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_actual) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_actual_AccountCustomer"></a> msdyn_account_msdyn_actual_AccountCustomer

See account Entity [msdyn_account_msdyn_actual_AccountCustomer](account.md#BKMK_msdyn_account_msdyn_actual_AccountCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_actual_AccountVendor"></a> msdyn_account_msdyn_actual_AccountVendor

See account Entity [msdyn_account_msdyn_actual_AccountVendor](account.md#BKMK_msdyn_account_msdyn_actual_AccountVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_actual_bookableresource"></a> msdyn_bookableresource_msdyn_actual_bookableresource

See bookableresource Entity [msdyn_bookableresource_msdyn_actual_bookableresource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_actual_bookableresource) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_actual_ContactCustomer"></a> msdyn_contact_msdyn_actual_ContactCustomer

See contact Entity [msdyn_contact_msdyn_actual_ContactCustomer](contact.md#BKMK_msdyn_contact_msdyn_actual_ContactCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_actual_ContactVendor"></a> msdyn_contact_msdyn_actual_ContactVendor

See contact Entity [msdyn_contact_msdyn_actual_ContactVendor](contact.md#BKMK_msdyn_contact_msdyn_actual_ContactVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_invoice_msdyn_actual_Invoice"></a> msdyn_invoice_msdyn_actual_Invoice

See invoice Entity [msdyn_invoice_msdyn_actual_Invoice](invoice.md#BKMK_msdyn_invoice_msdyn_actual_Invoice) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_actual_PriceList"></a> msdyn_pricelevel_msdyn_actual_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_actual_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_actual_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_actual_Product"></a> msdyn_product_msdyn_actual_Product

See product Entity [msdyn_product_msdyn_actual_Product](product.md#BKMK_msdyn_product_msdyn_actual_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorder_msdyn_actual_SalesContract"></a> msdyn_salesorder_msdyn_actual_SalesContract

See salesorder Entity [msdyn_salesorder_msdyn_actual_SalesContract](salesorder.md#BKMK_msdyn_salesorder_msdyn_actual_SalesContract) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_actual_Unit"></a> msdyn_uom_msdyn_actual_Unit

See uom Entity [msdyn_uom_msdyn_actual_Unit](uom.md#BKMK_msdyn_uom_msdyn_actual_Unit) One-To-Many relationship.

### <a name="BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule"></a> msdyn_uomschedule_msdyn_actual_UnitSchedule

See uomschedule Entity [msdyn_uomschedule_msdyn_actual_UnitSchedule](uomschedule.md#BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId"></a> msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId

See msdyn_organizationalunit Entity [msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId](msdyn_organizationalunit.md#BKMK_msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_msdyn_actual_Project"></a> msdyn_msdyn_project_msdyn_actual_Project

See msdyn_project Entity [msdyn_msdyn_project_msdyn_actual_Project](msdyn_project.md#BKMK_msdyn_msdyn_project_msdyn_actual_Project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_actual_Task"></a> msdyn_msdyn_projecttask_msdyn_actual_Task

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_actual_Task](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_actual_Task) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_actual"></a> msdyn_organizationalunit_actual

See msdyn_organizationalunit Entity [msdyn_organizationalunit_actual](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_actual) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_actual_ServiceAccount"></a> msdyn_account_msdyn_actual_ServiceAccount

See account Entity [msdyn_account_msdyn_actual_ServiceAccount](account.md#BKMK_msdyn_account_msdyn_actual_ServiceAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement"></a> msdyn_msdyn_agreement_msdyn_actual_Agreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_actual_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_actual_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_actual_IncidentType

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_msdyn_actual_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_actual_IncidentType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_actual_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_actual_TaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_actual_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_actual_TaxCode) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_actual_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_actual_Warehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_actual_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_actual_Warehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_actual_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_actual_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_actual_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_actual_WorkOrderType

See msdyn_workordertype Entity [msdyn_msdyn_workordertype_msdyn_actual_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_actual_WorkOrderType) One-To-Many relationship.

### <a name="BKMK_msdyn_territory_msdyn_actual_ServiceTerritory"></a> msdyn_territory_msdyn_actual_ServiceTerritory

See territory Entity [msdyn_territory_msdyn_actual_ServiceTerritory](territory.md#BKMK_msdyn_territory_msdyn_actual_ServiceTerritory) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_actual?text=msdyn_actual EntityType" />