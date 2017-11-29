---
title: "msdyn_rmaproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_rmaproduct entity."
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
# msdyn_rmaproduct Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Records products to be returned on an RMA

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_rmaproducts(*msdyn_rmaproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_rmaproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_rmaproducts(*msdyn_rmaproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_rmaproducts(*msdyn_rmaproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_rmaproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_rmaproducts(*msdyn_rmaproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_rmaproducts(*msdyn_rmaproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: RMA Product<br />
**DisplayCollectionName**: RMA Products<br />
**SchemaName**: msdyn_rmaproduct<br />
**CollectionSchemaName**: msdyn_rmaproducts<br />
**LogicalName**: msdyn_rmaproduct<br />
**LogicalCollectionName**: msdyn_rmaproducts<br />
**EntitySetName**: msdyn_rmaproducts<br />
**PrimaryIdAttribute**: msdyn_rmaproductid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Changeownership](#BKMK_msdyn_Changeownership)
- [msdyn_CredittoAccount](#BKMK_msdyn_CredittoAccount)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_ItemStatus](#BKMK_msdyn_ItemStatus)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_ProcessingAction](#BKMK_msdyn_ProcessingAction)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_QtyProcessed](#BKMK_msdyn_QtyProcessed)
- [msdyn_QtyReceived](#BKMK_msdyn_QtyReceived)
- [msdyn_Quantitytoreturn](#BKMK_msdyn_Quantitytoreturn)
- [msdyn_ReturntoVendor](#BKMK_msdyn_ReturntoVendor)
- [msdyn_ReturntoWarehouse](#BKMK_msdyn_ReturntoWarehouse)
- [msdyn_RMA](#BKMK_msdyn_RMA)
- [msdyn_rmaproductId](#BKMK_msdyn_rmaproductId)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitAmount](#BKMK_msdyn_UnitAmount)
- [msdyn_WOProduct](#BKMK_msdyn_WOProduct)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Shows the sequence number of the import that created this record.<br />
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


### <a name="BKMK_msdyn_Changeownership"></a> msdyn_Changeownership

**Description**: Account where ownership of associated asset should be transferred to (if Product Action is Change Asset Ownership)<br />
**DisplayName**: Change ownership<br />
**LogicalName**: msdyn_changeownership<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_CredittoAccount"></a> msdyn_CredittoAccount

**Description**: Specify if credit invoice should be generated for this product when returned<br />
**DisplayName**: Credit to Account<br />
**LogicalName**: msdyn_credittoaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

**Description**: Asset this line item relates to<br />
**DisplayName**: Customer Asset<br />
**LogicalName**: msdyn_customerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

**Description**: Type a description of the product.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

**Description**: <br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_ItemStatus"></a> msdyn_ItemStatus

**Description**: Enter the current status of this product.<br />
**DisplayName**: Item Status<br />
**LogicalName**: msdyn_itemstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Pending
- **Value**: 690970001 **Label**: Received
- **Value**: 690970002 **Label**: Canceled



### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

**Description**: Shows the order of this product within the RMA.<br />
**DisplayName**: Line Order<br />
**LogicalName**: msdyn_lineorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

**Description**: Price List that determines the pricing for this product<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_ProcessingAction"></a> msdyn_ProcessingAction

**Description**: Shows the action to be performed by the system once the product is received (either create RTV, return to warehouse, or change asset ownership).<br />
**DisplayName**: Processing Action<br />
**LogicalName**: msdyn_processingaction<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Create RTV
- **Value**: 690970001 **Label**: Return to Warehouse
- **Value**: 690970002 **Label**: Change Asset Ownership



### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: Product to return<br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_QtyProcessed"></a> msdyn_QtyProcessed

**Description**: Shows the quantity processed as per the processing action.<br />
**DisplayName**: Quantity Processed<br />
**LogicalName**: msdyn_qtyprocessed<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_QtyReceived"></a> msdyn_QtyReceived

**Description**: Enter the quantity currently received.<br />
**DisplayName**: Quantity Received<br />
**LogicalName**: msdyn_qtyreceived<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_Quantitytoreturn"></a> msdyn_Quantitytoreturn

**Description**: Enter the quantity to return.<br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantitytoreturn<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0.01<br />
**Precision**: 2


### <a name="BKMK_msdyn_ReturntoVendor"></a> msdyn_ReturntoVendor

**Description**: Vendor to where this product should be returned (if Product Action is RTV)<br />
**DisplayName**: Return to Vendor<br />
**LogicalName**: msdyn_returntovendor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_ReturntoWarehouse"></a> msdyn_ReturntoWarehouse

**Description**: Warehouse to which this product should be returned to (if Product Action is Warehouse)<br />
**DisplayName**: Return to Warehouse<br />
**LogicalName**: msdyn_returntowarehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_RMA"></a> msdyn_RMA

**Description**: RMA this line item relates to<br />
**DisplayName**: RMA<br />
**LogicalName**: msdyn_rma<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_rma


### <a name="BKMK_msdyn_rmaproductId"></a> msdyn_rmaproductId

**Description**: Shows the entity instances.<br />
**DisplayName**: RMA Product<br />
**LogicalName**: msdyn_rmaproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

**Description**: Specify if product is taxable<br />
**DisplayName**: Taxable<br />
**LogicalName**: msdyn_taxable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

**Description**: <br />
**DisplayName**: Total Amount<br />
**LogicalName**: msdyn_totalamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 0


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

**Description**: Unit for this product<br />
**DisplayName**: Unit<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_UnitAmount"></a> msdyn_UnitAmount

**Description**: Shows the unit amount to be credited to the customer<br />
**DisplayName**: Unit Amount<br />
**LogicalName**: msdyn_unitamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 0


### <a name="BKMK_msdyn_WOProduct"></a> msdyn_WOProduct

**Description**: Work Order Product to be returned<br />
**DisplayName**: WO Product<br />
**LogicalName**: msdyn_woproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorderproduct


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
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

**Description**: Status of the RMA Product<br />
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

**Description**: Reason for the status of the RMA Product<br />
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

**Description**: Unique identifier of the currency associated with the entity.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Shows the time zone code that was in use when the record was created.<br />
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
- [msdyn_ChangeownershipName](#BKMK_msdyn_ChangeownershipName)
- [msdyn_ChangeownershipYomiName](#BKMK_msdyn_ChangeownershipYomiName)
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_ReturntoVendorName](#BKMK_msdyn_ReturntoVendorName)
- [msdyn_ReturntoVendorYomiName](#BKMK_msdyn_ReturntoVendorYomiName)
- [msdyn_ReturntoWarehouseName](#BKMK_msdyn_ReturntoWarehouseName)
- [msdyn_RMAName](#BKMK_msdyn_RMAName)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_WOProductName](#BKMK_msdyn_WOProductName)
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

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
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

**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />
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

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
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


### <a name="BKMK_msdyn_ChangeownershipName"></a> msdyn_ChangeownershipName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_changeownershipname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ChangeownershipYomiName"></a> msdyn_ChangeownershipYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_changeownershipyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_CustomerAssetName"></a> msdyn_CustomerAssetName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_customerassetname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_msdyn_ReturntoVendorName"></a> msdyn_ReturntoVendorName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_returntovendorname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ReturntoVendorYomiName"></a> msdyn_ReturntoVendorYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_returntovendoryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ReturntoWarehouseName"></a> msdyn_ReturntoWarehouseName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_returntowarehousename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RMAName"></a> msdyn_RMAName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rmaname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

**Description**: Shows the value of the total amount in the base currency.<br />
**DisplayName**: Total Amount (Base)<br />
**LogicalName**: msdyn_totalamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 0


### <a name="BKMK_msdyn_unitamount_Base"></a> msdyn_unitamount_Base

**Description**: Shows the value of the unit amount in the base currency.<br />
**DisplayName**: Unit Amount (Base)<br />
**LogicalName**: msdyn_unitamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 0


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


### <a name="BKMK_msdyn_WOProductName"></a> msdyn_WOProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_woproductname<br />
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

- [msdyn_rmaproduct_ActivityPointers](#BKMK_msdyn_rmaproduct_ActivityPointers)
- [msdyn_rmaproduct_msdyn_approvals](#BKMK_msdyn_rmaproduct_msdyn_approvals)
- [msdyn_rmaproduct_msdyn_bookingalerts](#BKMK_msdyn_rmaproduct_msdyn_bookingalerts)
- [msdyn_rmaproduct_SyncErrors](#BKMK_msdyn_rmaproduct_SyncErrors)
- [msdyn_rmaproduct_AsyncOperations](#BKMK_msdyn_rmaproduct_AsyncOperations)
- [msdyn_rmaproduct_MailboxTrackingFolders](#BKMK_msdyn_rmaproduct_MailboxTrackingFolders)
- [msdyn_rmaproduct_UserEntityInstanceDatas](#BKMK_msdyn_rmaproduct_UserEntityInstanceDatas)
- [msdyn_rmaproduct_ProcessSession](#BKMK_msdyn_rmaproduct_ProcessSession)
- [msdyn_rmaproduct_BulkDeleteFailures](#BKMK_msdyn_rmaproduct_BulkDeleteFailures)
- [msdyn_rmaproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmaproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rmaproduct_Appointments](#BKMK_msdyn_rmaproduct_Appointments)
- [msdyn_rmaproduct_Emails](#BKMK_msdyn_rmaproduct_Emails)
- [msdyn_rmaproduct_Faxes](#BKMK_msdyn_rmaproduct_Faxes)
- [msdyn_rmaproduct_Letters](#BKMK_msdyn_rmaproduct_Letters)
- [msdyn_rmaproduct_PhoneCalls](#BKMK_msdyn_rmaproduct_PhoneCalls)
- [msdyn_rmaproduct_Tasks](#BKMK_msdyn_rmaproduct_Tasks)
- [msdyn_rmaproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmaproduct_RecurringAppointmentMasters)
- [msdyn_rmaproduct_SocialActivities](#BKMK_msdyn_rmaproduct_SocialActivities)
- [msdyn_rmaproduct_connections1](#BKMK_msdyn_rmaproduct_connections1)
- [msdyn_rmaproduct_connections2](#BKMK_msdyn_rmaproduct_connections2)
- [msdyn_rmaproduct_Annotations](#BKMK_msdyn_rmaproduct_Annotations)
- [msdyn_rmaproduct_ServiceAppointments](#BKMK_msdyn_rmaproduct_ServiceAppointments)
- [msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct](#BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct)
- [msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct](#BKMK_msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct)


### <a name="BKMK_msdyn_rmaproduct_ActivityPointers"></a> msdyn_rmaproduct_ActivityPointers

Same as activitypointer entity [msdyn_rmaproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_rmaproduct_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_rmaproduct_msdyn_approvals"></a> msdyn_rmaproduct_msdyn_approvals

Same as msdyn_approval entity [msdyn_rmaproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_rmaproduct_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_rmaproduct_msdyn_bookingalerts"></a> msdyn_rmaproduct_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_rmaproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rmaproduct_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_rmaproduct_SyncErrors"></a> msdyn_rmaproduct_SyncErrors

Same as syncerror entity [msdyn_rmaproduct_SyncErrors](syncerror.md#BKMK_msdyn_rmaproduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_SyncErrors<br />
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


### <a name="BKMK_msdyn_rmaproduct_AsyncOperations"></a> msdyn_rmaproduct_AsyncOperations

Same as asyncoperation entity [msdyn_rmaproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_rmaproduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_AsyncOperations<br />
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


### <a name="BKMK_msdyn_rmaproduct_MailboxTrackingFolders"></a> msdyn_rmaproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_rmaproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rmaproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_rmaproduct_UserEntityInstanceDatas"></a> msdyn_rmaproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_rmaproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_rmaproduct_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_rmaproduct_ProcessSession"></a> msdyn_rmaproduct_ProcessSession

Same as processsession entity [msdyn_rmaproduct_ProcessSession](processsession.md#BKMK_msdyn_rmaproduct_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_ProcessSession<br />
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


### <a name="BKMK_msdyn_rmaproduct_BulkDeleteFailures"></a> msdyn_rmaproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_rmaproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rmaproduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_rmaproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rmaproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_rmaproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rmaproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_rmaproduct_Appointments"></a> msdyn_rmaproduct_Appointments

Same as appointment entity [msdyn_rmaproduct_Appointments](appointment.md#BKMK_msdyn_rmaproduct_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_Appointments<br />
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


### <a name="BKMK_msdyn_rmaproduct_Emails"></a> msdyn_rmaproduct_Emails

Same as email entity [msdyn_rmaproduct_Emails](email.md#BKMK_msdyn_rmaproduct_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_Emails<br />
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


### <a name="BKMK_msdyn_rmaproduct_Faxes"></a> msdyn_rmaproduct_Faxes

Same as fax entity [msdyn_rmaproduct_Faxes](fax.md#BKMK_msdyn_rmaproduct_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_Faxes<br />
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


### <a name="BKMK_msdyn_rmaproduct_Letters"></a> msdyn_rmaproduct_Letters

Same as letter entity [msdyn_rmaproduct_Letters](letter.md#BKMK_msdyn_rmaproduct_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_Letters<br />
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


### <a name="BKMK_msdyn_rmaproduct_PhoneCalls"></a> msdyn_rmaproduct_PhoneCalls

Same as phonecall entity [msdyn_rmaproduct_PhoneCalls](phonecall.md#BKMK_msdyn_rmaproduct_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_PhoneCalls<br />
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


### <a name="BKMK_msdyn_rmaproduct_Tasks"></a> msdyn_rmaproduct_Tasks

Same as task entity [msdyn_rmaproduct_Tasks](task.md#BKMK_msdyn_rmaproduct_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_Tasks<br />
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


### <a name="BKMK_msdyn_rmaproduct_RecurringAppointmentMasters"></a> msdyn_rmaproduct_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_rmaproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rmaproduct_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_rmaproduct_SocialActivities"></a> msdyn_rmaproduct_SocialActivities

Same as socialactivity entity [msdyn_rmaproduct_SocialActivities](socialactivity.md#BKMK_msdyn_rmaproduct_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_SocialActivities<br />
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


### <a name="BKMK_msdyn_rmaproduct_connections1"></a> msdyn_rmaproduct_connections1

Same as connection entity [msdyn_rmaproduct_connections1](connection.md#BKMK_msdyn_rmaproduct_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_rmaproduct_connections2"></a> msdyn_rmaproduct_connections2

Same as connection entity [msdyn_rmaproduct_connections2](connection.md#BKMK_msdyn_rmaproduct_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_connections2<br />
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


### <a name="BKMK_msdyn_rmaproduct_Annotations"></a> msdyn_rmaproduct_Annotations

Same as annotation entity [msdyn_rmaproduct_Annotations](annotation.md#BKMK_msdyn_rmaproduct_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_Annotations<br />
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


### <a name="BKMK_msdyn_rmaproduct_ServiceAppointments"></a> msdyn_rmaproduct_ServiceAppointments

Same as serviceappointment entity [msdyn_rmaproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rmaproduct_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmaproduct_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct"></a> msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct

Same as msdyn_rmareceiptproduct entity [msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct](msdyn_rmareceiptproduct.md#BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmareceiptproduct<br />
**ReferencingAttribute**: msdyn_rmaproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct<br />
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


### <a name="BKMK_msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct"></a> msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct

Same as msdyn_rtvproduct entity [msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: msdyn_rmaproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct<br />
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

- [lk_msdyn_rmaproduct_createdby](#BKMK_lk_msdyn_rmaproduct_createdby)
- [lk_msdyn_rmaproduct_createdonbehalfby](#BKMK_lk_msdyn_rmaproduct_createdonbehalfby)
- [lk_msdyn_rmaproduct_modifiedby](#BKMK_lk_msdyn_rmaproduct_modifiedby)
- [lk_msdyn_rmaproduct_modifiedonbehalfby](#BKMK_lk_msdyn_rmaproduct_modifiedonbehalfby)
- [user_msdyn_rmaproduct](#BKMK_user_msdyn_rmaproduct)
- [team_msdyn_rmaproduct](#BKMK_team_msdyn_rmaproduct)
- [business_unit_msdyn_rmaproduct](#BKMK_business_unit_msdyn_rmaproduct)
- [TransactionCurrency_msdyn_rmaproduct](#BKMK_TransactionCurrency_msdyn_rmaproduct)
- [msdyn_account_msdyn_rmaproduct_Changeownership](#BKMK_msdyn_account_msdyn_rmaproduct_Changeownership)
- [msdyn_account_msdyn_rmaproduct_ReturntoVendor](#BKMK_msdyn_account_msdyn_rmaproduct_ReturntoVendor)
- [msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset)
- [msdyn_msdyn_rma_msdyn_rmaproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmaproduct_RMA)
- [msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse)
- [msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct)
- [msdyn_pricelevel_msdyn_rmaproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList)
- [msdyn_product_msdyn_rmaproduct_Product](#BKMK_msdyn_product_msdyn_rmaproduct_Product)
- [msdyn_uom_msdyn_rmaproduct_Unit](#BKMK_msdyn_uom_msdyn_rmaproduct_Unit)


### <a name="BKMK_lk_msdyn_rmaproduct_createdby"></a> lk_msdyn_rmaproduct_createdby

See systemuser Entity [lk_msdyn_rmaproduct_createdby](systemuser.md#BKMK_lk_msdyn_rmaproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rmaproduct_createdonbehalfby"></a> lk_msdyn_rmaproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_rmaproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rmaproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rmaproduct_modifiedby"></a> lk_msdyn_rmaproduct_modifiedby

See systemuser Entity [lk_msdyn_rmaproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_rmaproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rmaproduct_modifiedonbehalfby"></a> lk_msdyn_rmaproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_rmaproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rmaproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_rmaproduct"></a> user_msdyn_rmaproduct

See systemuser Entity [user_msdyn_rmaproduct](systemuser.md#BKMK_user_msdyn_rmaproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_rmaproduct"></a> team_msdyn_rmaproduct

See team Entity [team_msdyn_rmaproduct](team.md#BKMK_team_msdyn_rmaproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_rmaproduct"></a> business_unit_msdyn_rmaproduct

See businessunit Entity [business_unit_msdyn_rmaproduct](businessunit.md#BKMK_business_unit_msdyn_rmaproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_rmaproduct"></a> TransactionCurrency_msdyn_rmaproduct

See transactioncurrency Entity [TransactionCurrency_msdyn_rmaproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_rmaproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_rmaproduct_Changeownership"></a> msdyn_account_msdyn_rmaproduct_Changeownership

See account Entity [msdyn_account_msdyn_rmaproduct_Changeownership](account.md#BKMK_msdyn_account_msdyn_rmaproduct_Changeownership) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_rmaproduct_ReturntoVendor"></a> msdyn_account_msdyn_rmaproduct_ReturntoVendor

See account Entity [msdyn_account_msdyn_rmaproduct_ReturntoVendor](account.md#BKMK_msdyn_account_msdyn_rmaproduct_ReturntoVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmaproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rmaproduct_RMA

See msdyn_rma Entity [msdyn_msdyn_rma_msdyn_rmaproduct_RMA](msdyn_rma.md#BKMK_msdyn_msdyn_rma_msdyn_rmaproduct_RMA) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse"></a> msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct"></a> msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct

See msdyn_workorderproduct Entity [msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList"></a> msdyn_pricelevel_msdyn_rmaproduct_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_rmaproduct_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_rmaproduct_Product"></a> msdyn_product_msdyn_rmaproduct_Product

See product Entity [msdyn_product_msdyn_rmaproduct_Product](product.md#BKMK_msdyn_product_msdyn_rmaproduct_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_rmaproduct_Unit"></a> msdyn_uom_msdyn_rmaproduct_Unit

See uom Entity [msdyn_uom_msdyn_rmaproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_rmaproduct_Unit) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_rmaproduct?text=msdyn_rmaproduct EntityType" />