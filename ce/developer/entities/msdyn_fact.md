---
title: "msdyn_fact Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_fact entity."
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
# msdyn_fact Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Aggregated fact entity for actual transactions.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_facts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_facts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Fact<br />
**DisplayCollectionName**: Facts<br />
**SchemaName**: msdyn_fact<br />
**CollectionSchemaName**: msdyn_facts<br />
**LogicalName**: msdyn_fact<br />
**LogicalCollectionName**: msdyn_facts<br />
**EntitySetName**: msdyn_facts<br />
**PrimaryIdAttribute**: msdyn_factid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AccountCustomer](#BKMK_msdyn_AccountCustomer)
- [msdyn_AccountVendor](#BKMK_msdyn_AccountVendor)
- [msdyn_ActChargeableBilledSalesAmount](#BKMK_msdyn_ActChargeableBilledSalesAmount)
- [msdyn_ActChargeableBilledSalesQuantity](#BKMK_msdyn_ActChargeableBilledSalesQuantity)
- [msdyn_ActChargeableCostAmount](#BKMK_msdyn_ActChargeableCostAmount)
- [msdyn_ActChargeableCostQuantity](#BKMK_msdyn_ActChargeableCostQuantity)
- [msdyn_ActChargeableUnbilledSalesAmount](#BKMK_msdyn_ActChargeableUnbilledSalesAmount)
- [msdyn_ActChargeableUnbilledSalesQuantity](#BKMK_msdyn_ActChargeableUnbilledSalesQuantity)
- [msdyn_ActNoChargeBilledSalesAmount](#BKMK_msdyn_ActNoChargeBilledSalesAmount)
- [msdyn_ActNoChargeBilledSalesQuantity](#BKMK_msdyn_ActNoChargeBilledSalesQuantity)
- [msdyn_ActNoChargeCostAmount](#BKMK_msdyn_ActNoChargeCostAmount)
- [msdyn_ActNoChargeCostQuantity](#BKMK_msdyn_ActNoChargeCostQuantity)
- [msdyn_ActNoChargeUnbilledSalesAmount](#BKMK_msdyn_ActNoChargeUnbilledSalesAmount)
- [msdyn_ActNoChargeUnbilledSalesQuantity](#BKMK_msdyn_ActNoChargeUnbilledSalesQuantity)
- [msdyn_ActNonChargeableCostAmount](#BKMK_msdyn_ActNonChargeableCostAmount)
- [msdyn_ActNonChargeableCostQuantity](#BKMK_msdyn_ActNonChargeableCostQuantity)
- [msdyn_ActNonChargeableUnbilledSalesAmount](#BKMK_msdyn_ActNonChargeableUnbilledSalesAmount)
- [msdyn_ActNonChargeableUnbilledSalesQuantity](#BKMK_msdyn_ActNonChargeableUnbilledSalesQuantity)
- [msdyn_bookableresource](#BKMK_msdyn_bookableresource)
- [msdyn_ContactCustomer](#BKMK_msdyn_ContactCustomer)
- [msdyn_ContactVendor](#BKMK_msdyn_ContactVendor)
- [msdyn_CustomerType](#BKMK_msdyn_CustomerType)
- [msdyn_DocumentDate](#BKMK_msdyn_DocumentDate)
- [msdyn_EndDate](#BKMK_msdyn_EndDate)
- [msdyn_EstChargeableBilledSalesAmount](#BKMK_msdyn_EstChargeableBilledSalesAmount)
- [msdyn_EstChargeableBilledSalesQuantity](#BKMK_msdyn_EstChargeableBilledSalesQuantity)
- [msdyn_EstChargeableCostAmount](#BKMK_msdyn_EstChargeableCostAmount)
- [msdyn_EstChargeableCostQuantity](#BKMK_msdyn_EstChargeableCostQuantity)
- [msdyn_EstChargeableUnbilledSalesAmount](#BKMK_msdyn_EstChargeableUnbilledSalesAmount)
- [msdyn_EstChargeableUnbilledSalesQuantity](#BKMK_msdyn_EstChargeableUnbilledSalesQuantity)
- [msdyn_Estimate](#BKMK_msdyn_Estimate)
- [msdyn_estimatelineid](#BKMK_msdyn_estimatelineid)
- [msdyn_EstNoChargeBilledSalesAmount](#BKMK_msdyn_EstNoChargeBilledSalesAmount)
- [msdyn_EstNoChargeBilledSalesQuantity](#BKMK_msdyn_EstNoChargeBilledSalesQuantity)
- [msdyn_EstNoChargeCostAmount](#BKMK_msdyn_EstNoChargeCostAmount)
- [msdyn_EstNoChargeCostQuantity](#BKMK_msdyn_EstNoChargeCostQuantity)
- [msdyn_EstNoChargeUnbilledSalesAmount](#BKMK_msdyn_EstNoChargeUnbilledSalesAmount)
- [msdyn_EstNoChargeUnbilledSalesQuantity](#BKMK_msdyn_EstNoChargeUnbilledSalesQuantity)
- [msdyn_EstNonChargeableCostAmount](#BKMK_msdyn_EstNonChargeableCostAmount)
- [msdyn_EstNonChargeableCostQuantity](#BKMK_msdyn_EstNonChargeableCostQuantity)
- [msdyn_EstNonChargeableUnbilledSalesAmount](#BKMK_msdyn_EstNonChargeableUnbilledSalesAmount)
- [msdyn_EstNonChargeableUnbilledSalesQuantity](#BKMK_msdyn_EstNonChargeableUnbilledSalesQuantity)
- [msdyn_factId](#BKMK_msdyn_factId)
- [msdyn_FactType](#BKMK_msdyn_FactType)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_Project](#BKMK_msdyn_Project)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_SalesContract](#BKMK_msdyn_SalesContract)
- [msdyn_SalesContractLine](#BKMK_msdyn_SalesContractLine)
- [msdyn_StartDate](#BKMK_msdyn_StartDate)
- [msdyn_Task](#BKMK_msdyn_Task)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
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

**Description**: <br />
**DisplayName**: Customer<br />
**LogicalName**: msdyn_accountcustomer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_AccountVendor"></a> msdyn_AccountVendor

**Description**: <br />
**DisplayName**: Vendor<br />
**LogicalName**: msdyn_accountvendor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_ActChargeableBilledSalesAmount"></a> msdyn_ActChargeableBilledSalesAmount

**Description**: <br />
**DisplayName**: Actual Chargeable Billed Sales Amount<br />
**LogicalName**: msdyn_actchargeablebilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_ActChargeableBilledSalesQuantity"></a> msdyn_ActChargeableBilledSalesQuantity

**Description**: <br />
**DisplayName**: Actual Chargeable Billed Sales Quantity<br />
**LogicalName**: msdyn_actchargeablebilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_ActChargeableCostAmount"></a> msdyn_ActChargeableCostAmount

**Description**: <br />
**DisplayName**: Actual Chargeable Cost Amount<br />
**LogicalName**: msdyn_actchargeablecostamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_ActChargeableCostQuantity"></a> msdyn_ActChargeableCostQuantity

**Description**: <br />
**DisplayName**: Actual Chargeable Cost Quantity<br />
**LogicalName**: msdyn_actchargeablecostquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_ActChargeableUnbilledSalesAmount"></a> msdyn_ActChargeableUnbilledSalesAmount

**Description**: <br />
**DisplayName**: Actual Chargeable Unbilled Sales Amount<br />
**LogicalName**: msdyn_actchargeableunbilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_ActChargeableUnbilledSalesQuantity"></a> msdyn_ActChargeableUnbilledSalesQuantity

**Description**: <br />
**DisplayName**: Actual Chargeable Unbilled Sales Quantity<br />
**LogicalName**: msdyn_actchargeableunbilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_ActNoChargeBilledSalesAmount"></a> msdyn_ActNoChargeBilledSalesAmount

**Description**: <br />
**DisplayName**: Actual No Charge Billed Sales Amount<br />
**LogicalName**: msdyn_actnochargebilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_ActNoChargeBilledSalesQuantity"></a> msdyn_ActNoChargeBilledSalesQuantity

**Description**: <br />
**DisplayName**: Actual No Charge Billed Sales Quantity<br />
**LogicalName**: msdyn_actnochargebilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_ActNoChargeCostAmount"></a> msdyn_ActNoChargeCostAmount

**Description**: <br />
**DisplayName**: Actual No Charge Cost Amount<br />
**LogicalName**: msdyn_actnochargecostamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_ActNoChargeCostQuantity"></a> msdyn_ActNoChargeCostQuantity

**Description**: <br />
**DisplayName**: Actual No Charge Cost Quantity<br />
**LogicalName**: msdyn_actnochargecostquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_ActNoChargeUnbilledSalesAmount"></a> msdyn_ActNoChargeUnbilledSalesAmount

**Description**: <br />
**DisplayName**: Actual No Charge Unbilled Sales Amount<br />
**LogicalName**: msdyn_actnochargeunbilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_ActNoChargeUnbilledSalesQuantity"></a> msdyn_ActNoChargeUnbilledSalesQuantity

**Description**: <br />
**DisplayName**: Actual No Charge Unbilled Sales Quantity<br />
**LogicalName**: msdyn_actnochargeunbilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_ActNonChargeableCostAmount"></a> msdyn_ActNonChargeableCostAmount

**Description**: <br />
**DisplayName**: Actual Non Chargeable Cost Amount<br />
**LogicalName**: msdyn_actnonchargeablecostamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_ActNonChargeableCostQuantity"></a> msdyn_ActNonChargeableCostQuantity

**Description**: <br />
**DisplayName**: Actual Non Chargeable Cost Quantity<br />
**LogicalName**: msdyn_actnonchargeablecostquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_ActNonChargeableUnbilledSalesAmount"></a> msdyn_ActNonChargeableUnbilledSalesAmount

**Description**: <br />
**DisplayName**: Actual Non Chargeable Unbilled Sales Amount<br />
**LogicalName**: msdyn_actnonchargeableunbilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_ActNonChargeableUnbilledSalesQuantity"></a> msdyn_ActNonChargeableUnbilledSalesQuantity

**Description**: <br />
**DisplayName**: Actual Non Chargeable Unbilled Sales Quantity<br />
**LogicalName**: msdyn_actnonchargeableunbilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_bookableresource"></a> msdyn_bookableresource

**Description**: <br />
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


### <a name="BKMK_msdyn_CustomerType"></a> msdyn_CustomerType

**Description**: <br />
**DisplayName**: Customer Type<br />
**LogicalName**: msdyn_customertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350001 **Label**: Account
- **Value**: 192350002 **Label**: Contact



### <a name="BKMK_msdyn_DocumentDate"></a> msdyn_DocumentDate

**Description**: Enter the transaction date of the business event.<br />
**DisplayName**: Document Date<br />
**LogicalName**: msdyn_documentdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_EndDate"></a> msdyn_EndDate

**Description**: Enter the end date for this transaction.<br />
**DisplayName**: End Date<br />
**LogicalName**: msdyn_enddate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_EstChargeableBilledSalesAmount"></a> msdyn_EstChargeableBilledSalesAmount

**Description**: <br />
**DisplayName**: Estimated Chargeable Billed Sales Amount<br />
**LogicalName**: msdyn_estchargeablebilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstChargeableBilledSalesQuantity"></a> msdyn_EstChargeableBilledSalesQuantity

**Description**: <br />
**DisplayName**: Estimated Chargeable Billed Sales Quantity<br />
**LogicalName**: msdyn_estchargeablebilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstChargeableCostAmount"></a> msdyn_EstChargeableCostAmount

**Description**: <br />
**DisplayName**: Estimated Chargeable Cost Amount<br />
**LogicalName**: msdyn_estchargeablecostamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstChargeableCostQuantity"></a> msdyn_EstChargeableCostQuantity

**Description**: <br />
**DisplayName**: Estimated Chargeable Cost Quantity<br />
**LogicalName**: msdyn_estchargeablecostquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstChargeableUnbilledSalesAmount"></a> msdyn_EstChargeableUnbilledSalesAmount

**Description**: <br />
**DisplayName**: Estimated Chargeable Unbilled Sales Amount<br />
**LogicalName**: msdyn_estchargeableunbilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstChargeableUnbilledSalesQuantity"></a> msdyn_EstChargeableUnbilledSalesQuantity

**Description**: <br />
**DisplayName**: Estimated Chargeable Unbilled Sales Quantity<br />
**LogicalName**: msdyn_estchargeableunbilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_Estimate"></a> msdyn_Estimate

**Description**: <br />
**DisplayName**: Estimate<br />
**LogicalName**: msdyn_estimate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_estimate


### <a name="BKMK_msdyn_estimatelineid"></a> msdyn_estimatelineid

**Description**: <br />
**DisplayName**: Estimate Line<br />
**LogicalName**: msdyn_estimatelineid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_estimateline


### <a name="BKMK_msdyn_EstNoChargeBilledSalesAmount"></a> msdyn_EstNoChargeBilledSalesAmount

**Description**: <br />
**DisplayName**: Estimated No Charge Billed Sales Amount<br />
**LogicalName**: msdyn_estnochargebilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstNoChargeBilledSalesQuantity"></a> msdyn_EstNoChargeBilledSalesQuantity

**Description**: <br />
**DisplayName**: Estimated No Charge Billed Sales Quantity<br />
**LogicalName**: msdyn_estnochargebilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstNoChargeCostAmount"></a> msdyn_EstNoChargeCostAmount

**Description**: <br />
**DisplayName**: Estimated No Charge Cost Amount<br />
**LogicalName**: msdyn_estnochargecostamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstNoChargeCostQuantity"></a> msdyn_EstNoChargeCostQuantity

**Description**: <br />
**DisplayName**: Estimated No Charge Cost Quantity<br />
**LogicalName**: msdyn_estnochargecostquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstNoChargeUnbilledSalesAmount"></a> msdyn_EstNoChargeUnbilledSalesAmount

**Description**: <br />
**DisplayName**: Estimated No Charge Unbilled Sales Amount<br />
**LogicalName**: msdyn_estnochargeunbilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstNoChargeUnbilledSalesQuantity"></a> msdyn_EstNoChargeUnbilledSalesQuantity

**Description**: <br />
**DisplayName**: Estimated No Charge Unbilled Sales Quantity<br />
**LogicalName**: msdyn_estnochargeunbilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstNonChargeableCostAmount"></a> msdyn_EstNonChargeableCostAmount

**Description**: <br />
**DisplayName**: Estimated Non Chargeable Cost Amount<br />
**LogicalName**: msdyn_estnonchargeablecostamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstNonChargeableCostQuantity"></a> msdyn_EstNonChargeableCostQuantity

**Description**: <br />
**DisplayName**: Estimated Non Chargeable Cost Quantity<br />
**LogicalName**: msdyn_estnonchargeablecostquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstNonChargeableUnbilledSalesAmount"></a> msdyn_EstNonChargeableUnbilledSalesAmount

**Description**: <br />
**DisplayName**: Estimated Non Chargeable Unbilled Sales Amount<br />
**LogicalName**: msdyn_estnonchargeableunbilledsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstNonChargeableUnbilledSalesQuantity"></a> msdyn_EstNonChargeableUnbilledSalesQuantity

**Description**: <br />
**DisplayName**: Estimated Non Chargeable Unbilled Sales Quantity<br />
**LogicalName**: msdyn_estnonchargeableunbilledsalesquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_factId"></a> msdyn_factId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Fact<br />
**LogicalName**: msdyn_factid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_FactType"></a> msdyn_FactType

**Description**: <br />
**DisplayName**: Fact Type<br />
**LogicalName**: msdyn_facttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Actual
- **Value**: 192350001 **Label**: Estimate



### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: The name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: <br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_Project"></a> msdyn_Project

**Description**: <br />
**DisplayName**: Project<br />
**LogicalName**: msdyn_project<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_project


### <a name="BKMK_msdyn_ResourceCategory"></a> msdyn_ResourceCategory

**Description**: <br />
**DisplayName**: Role<br />
**LogicalName**: msdyn_resourcecategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecategory


### <a name="BKMK_msdyn_SalesContract"></a> msdyn_SalesContract

**Description**: <br />
**DisplayName**: Project Contract<br />
**LogicalName**: msdyn_salescontract<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: salesorder


### <a name="BKMK_msdyn_SalesContractLine"></a> msdyn_SalesContractLine

**Description**: <br />
**DisplayName**: Project Contract Line<br />
**LogicalName**: msdyn_salescontractline<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_StartDate"></a> msdyn_StartDate

**Description**: Enter the start date.<br />
**DisplayName**: Start Date<br />
**LogicalName**: msdyn_startdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_Task"></a> msdyn_Task

**Description**: <br />
**DisplayName**: Task<br />
**LogicalName**: msdyn_task<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_projecttask


### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

**Description**: <br />
**DisplayName**: Transaction Category<br />
**LogicalName**: msdyn_transactioncategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_transactioncategory


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

**Description**: <br />
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

**Description**: Status of the Fact<br />
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

**Description**: Reason for the status of the Fact<br />
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
- [msdyn_actchargeablebilledsalesamount_Base](#BKMK_msdyn_actchargeablebilledsalesamount_Base)
- [msdyn_actchargeablecostamount_Base](#BKMK_msdyn_actchargeablecostamount_Base)
- [msdyn_actchargeableunbilledsalesamount_Base](#BKMK_msdyn_actchargeableunbilledsalesamount_Base)
- [msdyn_actnochargebilledsalesamount_Base](#BKMK_msdyn_actnochargebilledsalesamount_Base)
- [msdyn_actnochargecostamount_Base](#BKMK_msdyn_actnochargecostamount_Base)
- [msdyn_actnochargeunbilledsalesamount_Base](#BKMK_msdyn_actnochargeunbilledsalesamount_Base)
- [msdyn_actnonchargeablecostamount_Base](#BKMK_msdyn_actnonchargeablecostamount_Base)
- [msdyn_actnonchargeableunbilledsalesamount_Base](#BKMK_msdyn_actnonchargeableunbilledsalesamount_Base)
- [msdyn_bookableresourceName](#BKMK_msdyn_bookableresourceName)
- [msdyn_ContactCustomerName](#BKMK_msdyn_ContactCustomerName)
- [msdyn_ContactCustomerYomiName](#BKMK_msdyn_ContactCustomerYomiName)
- [msdyn_ContactVendorName](#BKMK_msdyn_ContactVendorName)
- [msdyn_ContactVendorYomiName](#BKMK_msdyn_ContactVendorYomiName)
- [msdyn_earnedrevenue](#BKMK_msdyn_earnedrevenue)
- [msdyn_earnedrevenue_Base](#BKMK_msdyn_earnedrevenue_Base)
- [msdyn_estchargeablebilledsalesamount_Base](#BKMK_msdyn_estchargeablebilledsalesamount_Base)
- [msdyn_estchargeablecostamount_Base](#BKMK_msdyn_estchargeablecostamount_Base)
- [msdyn_estchargeableunbilledsalesamount_Base](#BKMK_msdyn_estchargeableunbilledsalesamount_Base)
- [msdyn_estimatelineidName](#BKMK_msdyn_estimatelineidName)
- [msdyn_EstimateName](#BKMK_msdyn_EstimateName)
- [msdyn_estnochargebilledsalesamount_Base](#BKMK_msdyn_estnochargebilledsalesamount_Base)
- [msdyn_estnochargecostamount_Base](#BKMK_msdyn_estnochargecostamount_Base)
- [msdyn_estnochargeunbilledsalesamount_Base](#BKMK_msdyn_estnochargeunbilledsalesamount_Base)
- [msdyn_estnonchargeablecostamount_Base](#BKMK_msdyn_estnonchargeablecostamount_Base)
- [msdyn_estnonchargeableunbilledsalesamount_Base](#BKMK_msdyn_estnonchargeableunbilledsalesamount_Base)
- [msdyn_grossmargin](#BKMK_msdyn_grossmargin)
- [msdyn_grossmargin_Base](#BKMK_msdyn_grossmargin_Base)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_ProjectName](#BKMK_msdyn_ProjectName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
- [msdyn_SalesContractName](#BKMK_msdyn_SalesContractName)
- [msdyn_TaskName](#BKMK_msdyn_TaskName)
- [msdyn_totalcost](#BKMK_msdyn_totalcost)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_totalhours](#BKMK_msdyn_totalhours)
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


### <a name="BKMK_msdyn_actchargeablebilledsalesamount_Base"></a> msdyn_actchargeablebilledsalesamount_Base

**Description**: Value of the Actual Chargeable Billed Sales Amount in base currency.<br />
**DisplayName**: Actual Chargeable Billed Sales Amount (Base)<br />
**LogicalName**: msdyn_actchargeablebilledsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_actchargeablecostamount_Base"></a> msdyn_actchargeablecostamount_Base

**Description**: Value of the Actual Chargeable Cost Amount in base currency.<br />
**DisplayName**: Actual Chargeable Cost Amount (Base)<br />
**LogicalName**: msdyn_actchargeablecostamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_actchargeableunbilledsalesamount_Base"></a> msdyn_actchargeableunbilledsalesamount_Base

**Description**: Value of the Actual Chargeable Unbilled Sales Amount in base currency.<br />
**DisplayName**: Actual Chargeable Unbilled Sales Amount (Base)<br />
**LogicalName**: msdyn_actchargeableunbilledsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_actnochargebilledsalesamount_Base"></a> msdyn_actnochargebilledsalesamount_Base

**Description**: Value of the Actual No Charge Billed Sales Amount in base currency.<br />
**DisplayName**: Actual No Charge Billed Sales Amount (Base)<br />
**LogicalName**: msdyn_actnochargebilledsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_actnochargecostamount_Base"></a> msdyn_actnochargecostamount_Base

**Description**: Value of the Actual No Charge Cost Amount in base currency.<br />
**DisplayName**: Actual No Charge Cost Amount (Base)<br />
**LogicalName**: msdyn_actnochargecostamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_actnochargeunbilledsalesamount_Base"></a> msdyn_actnochargeunbilledsalesamount_Base

**Description**: Value of the Actual No Charge Unbilled Sales Amount in base currency.<br />
**DisplayName**: Actual No Charge Unbilled Sales Amount (Base)<br />
**LogicalName**: msdyn_actnochargeunbilledsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_actnonchargeablecostamount_Base"></a> msdyn_actnonchargeablecostamount_Base

**Description**: Value of the Actual Non Chargeable Cost Amount in base currency.<br />
**DisplayName**: Actual Non Chargeable Cost Amount (Base)<br />
**LogicalName**: msdyn_actnonchargeablecostamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_actnonchargeableunbilledsalesamount_Base"></a> msdyn_actnonchargeableunbilledsalesamount_Base

**Description**: Value of the Actual Non Chargeable Unbilled Sales Amount in base currency.<br />
**DisplayName**: Actual Non Chargeable Unbilled Sales Amount (Base)<br />
**LogicalName**: msdyn_actnonchargeableunbilledsalesamount_base<br />
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


### <a name="BKMK_msdyn_earnedrevenue"></a> msdyn_earnedrevenue

**Description**: <br />
**DisplayName**: Earned Revenue<br />
**LogicalName**: msdyn_earnedrevenue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_earnedrevenue_Base"></a> msdyn_earnedrevenue_Base

**Description**: Value of the Earned Revenue in base currency.<br />
**DisplayName**: Earned Revenue (Base)<br />
**LogicalName**: msdyn_earnedrevenue_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estchargeablebilledsalesamount_Base"></a> msdyn_estchargeablebilledsalesamount_Base

**Description**: Value of the Estimated Chargeable Billed Sales Amount in base currency.<br />
**DisplayName**: Estimated Chargeable Billed Sales Amount (Base)<br />
**LogicalName**: msdyn_estchargeablebilledsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estchargeablecostamount_Base"></a> msdyn_estchargeablecostamount_Base

**Description**: Value of the Estimated Chargeable Cost Amount in base currency.<br />
**DisplayName**: Estimated Chargeable Cost Amount (Base)<br />
**LogicalName**: msdyn_estchargeablecostamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estchargeableunbilledsalesamount_Base"></a> msdyn_estchargeableunbilledsalesamount_Base

**Description**: Value of the Estimated Chargeable Unbilled Sales Amount in base currency.<br />
**DisplayName**: Estimated Chargeable Unbilled Sales Amount (Base)<br />
**LogicalName**: msdyn_estchargeableunbilledsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estimatelineidName"></a> msdyn_estimatelineidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_estimatelineidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_EstimateName"></a> msdyn_EstimateName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_estimatename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_estnochargebilledsalesamount_Base"></a> msdyn_estnochargebilledsalesamount_Base

**Description**: Value of the Estimated No Charge Billed Sales Amount in base currency.<br />
**DisplayName**: Estimated No Charge Billed Sales Amount (Base)<br />
**LogicalName**: msdyn_estnochargebilledsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estnochargecostamount_Base"></a> msdyn_estnochargecostamount_Base

**Description**: Value of the Estimated No Charge Cost Amount in base currency.<br />
**DisplayName**: Estimated No Charge Cost Amount (Base)<br />
**LogicalName**: msdyn_estnochargecostamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estnochargeunbilledsalesamount_Base"></a> msdyn_estnochargeunbilledsalesamount_Base

**Description**: Value of the Estimated No Charge Unbilled Sales Amount in base currency.<br />
**DisplayName**: Estimated No Charge Unbilled Sales Amount (Base)<br />
**LogicalName**: msdyn_estnochargeunbilledsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estnonchargeablecostamount_Base"></a> msdyn_estnonchargeablecostamount_Base

**Description**: Value of the Estimated Non Chargeable Cost Amount in base currency.<br />
**DisplayName**: Estimated Non Chargeable Cost Amount (Base)<br />
**LogicalName**: msdyn_estnonchargeablecostamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estnonchargeableunbilledsalesamount_Base"></a> msdyn_estnonchargeableunbilledsalesamount_Base

**Description**: Value of the Estimated Non Chargeable Unbilled Sales Amount in base currency.<br />
**DisplayName**: Estimated Non Chargeable Unbilled Sales Amount (Base)<br />
**LogicalName**: msdyn_estnonchargeableunbilledsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_grossmargin"></a> msdyn_grossmargin

**Description**: <br />
**DisplayName**: Gross Margin<br />
**LogicalName**: msdyn_grossmargin<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_grossmargin_Base"></a> msdyn_grossmargin_Base

**Description**: Value of the Gross Margin in base currency.<br />
**DisplayName**: Gross Margin (Base)<br />
**LogicalName**: msdyn_grossmargin_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


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


### <a name="BKMK_msdyn_totalcost"></a> msdyn_totalcost

**Description**: <br />
**DisplayName**: Total Cost<br />
**LogicalName**: msdyn_totalcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

**Description**: Value of the Total Cost in base currency.<br />
**DisplayName**: Total Cost (Base)<br />
**LogicalName**: msdyn_totalcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_totalhours"></a> msdyn_totalhours

**Description**: <br />
**DisplayName**: Total Hours<br />
**LogicalName**: msdyn_totalhours<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


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

- [msdyn_fact_SyncErrors](#BKMK_msdyn_fact_SyncErrors)
- [msdyn_fact_DuplicateMatchingRecord](#BKMK_msdyn_fact_DuplicateMatchingRecord)
- [msdyn_fact_DuplicateBaseRecord](#BKMK_msdyn_fact_DuplicateBaseRecord)
- [msdyn_fact_AsyncOperations](#BKMK_msdyn_fact_AsyncOperations)
- [msdyn_fact_MailboxTrackingFolders](#BKMK_msdyn_fact_MailboxTrackingFolders)
- [msdyn_fact_UserEntityInstanceDatas](#BKMK_msdyn_fact_UserEntityInstanceDatas)
- [msdyn_fact_ProcessSession](#BKMK_msdyn_fact_ProcessSession)
- [msdyn_fact_BulkDeleteFailures](#BKMK_msdyn_fact_BulkDeleteFailures)
- [msdyn_fact_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fact_PrincipalObjectAttributeAccesses)
- [msdyn_fact_Annotations](#BKMK_msdyn_fact_Annotations)


### <a name="BKMK_msdyn_fact_SyncErrors"></a> msdyn_fact_SyncErrors

Same as syncerror entity [msdyn_fact_SyncErrors](syncerror.md#BKMK_msdyn_fact_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_SyncErrors<br />
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


### <a name="BKMK_msdyn_fact_DuplicateMatchingRecord"></a> msdyn_fact_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_fact_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_fact_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_fact_DuplicateBaseRecord"></a> msdyn_fact_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_fact_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_fact_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_fact_AsyncOperations"></a> msdyn_fact_AsyncOperations

Same as asyncoperation entity [msdyn_fact_AsyncOperations](asyncoperation.md#BKMK_msdyn_fact_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_AsyncOperations<br />
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


### <a name="BKMK_msdyn_fact_MailboxTrackingFolders"></a> msdyn_fact_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_fact_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fact_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_fact_UserEntityInstanceDatas"></a> msdyn_fact_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_fact_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_fact_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_fact_ProcessSession"></a> msdyn_fact_ProcessSession

Same as processsession entity [msdyn_fact_ProcessSession](processsession.md#BKMK_msdyn_fact_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_ProcessSession<br />
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


### <a name="BKMK_msdyn_fact_BulkDeleteFailures"></a> msdyn_fact_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_fact_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fact_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_fact_PrincipalObjectAttributeAccesses"></a> msdyn_fact_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_fact_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fact_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_fact_Annotations"></a> msdyn_fact_Annotations

Same as annotation entity [msdyn_fact_Annotations](annotation.md#BKMK_msdyn_fact_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fact_Annotations<br />
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

- [lk_msdyn_fact_createdby](#BKMK_lk_msdyn_fact_createdby)
- [lk_msdyn_fact_createdonbehalfby](#BKMK_lk_msdyn_fact_createdonbehalfby)
- [lk_msdyn_fact_modifiedby](#BKMK_lk_msdyn_fact_modifiedby)
- [lk_msdyn_fact_modifiedonbehalfby](#BKMK_lk_msdyn_fact_modifiedonbehalfby)
- [user_msdyn_fact](#BKMK_user_msdyn_fact)
- [team_msdyn_fact](#BKMK_team_msdyn_fact)
- [business_unit_msdyn_fact](#BKMK_business_unit_msdyn_fact)
- [TransactionCurrency_msdyn_fact](#BKMK_TransactionCurrency_msdyn_fact)
- [msdyn_account_msdyn_fact_AccountCustomer](#BKMK_msdyn_account_msdyn_fact_AccountCustomer)
- [msdyn_account_msdyn_fact_AccountVendor](#BKMK_msdyn_account_msdyn_fact_AccountVendor)
- [msdyn_bookableresource_msdyn_fact_bookableresource](#BKMK_msdyn_bookableresource_msdyn_fact_bookableresource)
- [msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory)
- [msdyn_contact_msdyn_fact_ContactCustomer](#BKMK_msdyn_contact_msdyn_fact_ContactCustomer)
- [msdyn_contact_msdyn_fact_ContactVendor](#BKMK_msdyn_contact_msdyn_fact_ContactVendor)
- [msdyn_msdyn_estimate_msdyn_fact_Estimate](#BKMK_msdyn_msdyn_estimate_msdyn_fact_Estimate)
- [msdyn_msdyn_estimateline_msdyn_fact_estimatelineid](#BKMK_msdyn_msdyn_estimateline_msdyn_fact_estimatelineid)
- [msdyn_msdyn_project_msdyn_fact_Project](#BKMK_msdyn_msdyn_project_msdyn_fact_Project)
- [msdyn_msdyn_projecttask_msdyn_fact_Task](#BKMK_msdyn_msdyn_projecttask_msdyn_fact_Task)
- [msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory)
- [msdyn_product_msdyn_fact_Product](#BKMK_msdyn_product_msdyn_fact_Product)
- [msdyn_salesorder_msdyn_fact_SalesContract](#BKMK_msdyn_salesorder_msdyn_fact_SalesContract)


### <a name="BKMK_lk_msdyn_fact_createdby"></a> lk_msdyn_fact_createdby

See systemuser Entity [lk_msdyn_fact_createdby](systemuser.md#BKMK_lk_msdyn_fact_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fact_createdonbehalfby"></a> lk_msdyn_fact_createdonbehalfby

See systemuser Entity [lk_msdyn_fact_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fact_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fact_modifiedby"></a> lk_msdyn_fact_modifiedby

See systemuser Entity [lk_msdyn_fact_modifiedby](systemuser.md#BKMK_lk_msdyn_fact_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fact_modifiedonbehalfby"></a> lk_msdyn_fact_modifiedonbehalfby

See systemuser Entity [lk_msdyn_fact_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fact_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_fact"></a> user_msdyn_fact

See systemuser Entity [user_msdyn_fact](systemuser.md#BKMK_user_msdyn_fact) One-To-Many relationship.

### <a name="BKMK_team_msdyn_fact"></a> team_msdyn_fact

See team Entity [team_msdyn_fact](team.md#BKMK_team_msdyn_fact) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_fact"></a> business_unit_msdyn_fact

See businessunit Entity [business_unit_msdyn_fact](businessunit.md#BKMK_business_unit_msdyn_fact) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_fact"></a> TransactionCurrency_msdyn_fact

See transactioncurrency Entity [TransactionCurrency_msdyn_fact](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_fact) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_fact_AccountCustomer"></a> msdyn_account_msdyn_fact_AccountCustomer

See account Entity [msdyn_account_msdyn_fact_AccountCustomer](account.md#BKMK_msdyn_account_msdyn_fact_AccountCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_fact_AccountVendor"></a> msdyn_account_msdyn_fact_AccountVendor

See account Entity [msdyn_account_msdyn_fact_AccountVendor](account.md#BKMK_msdyn_account_msdyn_fact_AccountVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_fact_bookableresource"></a> msdyn_bookableresource_msdyn_fact_bookableresource

See bookableresource Entity [msdyn_bookableresource_msdyn_fact_bookableresource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_fact_bookableresource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_fact_ContactCustomer"></a> msdyn_contact_msdyn_fact_ContactCustomer

See contact Entity [msdyn_contact_msdyn_fact_ContactCustomer](contact.md#BKMK_msdyn_contact_msdyn_fact_ContactCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_fact_ContactVendor"></a> msdyn_contact_msdyn_fact_ContactVendor

See contact Entity [msdyn_contact_msdyn_fact_ContactVendor](contact.md#BKMK_msdyn_contact_msdyn_fact_ContactVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_estimate_msdyn_fact_Estimate"></a> msdyn_msdyn_estimate_msdyn_fact_Estimate

See msdyn_estimate Entity [msdyn_msdyn_estimate_msdyn_fact_Estimate](msdyn_estimate.md#BKMK_msdyn_msdyn_estimate_msdyn_fact_Estimate) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_estimateline_msdyn_fact_estimatelineid"></a> msdyn_msdyn_estimateline_msdyn_fact_estimatelineid

See msdyn_estimateline Entity [msdyn_msdyn_estimateline_msdyn_fact_estimatelineid](msdyn_estimateline.md#BKMK_msdyn_msdyn_estimateline_msdyn_fact_estimatelineid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_msdyn_fact_Project"></a> msdyn_msdyn_project_msdyn_fact_Project

See msdyn_project Entity [msdyn_msdyn_project_msdyn_fact_Project](msdyn_project.md#BKMK_msdyn_msdyn_project_msdyn_fact_Project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_fact_Task"></a> msdyn_msdyn_projecttask_msdyn_fact_Task

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_fact_Task](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_fact_Task) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_fact_Product"></a> msdyn_product_msdyn_fact_Product

See product Entity [msdyn_product_msdyn_fact_Product](product.md#BKMK_msdyn_product_msdyn_fact_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorder_msdyn_fact_SalesContract"></a> msdyn_salesorder_msdyn_fact_SalesContract

See salesorder Entity [msdyn_salesorder_msdyn_fact_SalesContract](salesorder.md#BKMK_msdyn_salesorder_msdyn_fact_SalesContract) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_fact?text=msdyn_fact EntityType" />