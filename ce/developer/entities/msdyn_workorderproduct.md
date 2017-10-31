---
title: "msdyn_workorderproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorderproduct entity."
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
# msdyn_workorderproduct Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In this entity you record all the products proposed and used for a work order

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorderproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorderproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Work Order Product<br />
**DisplayCollectionName**: Work Order Products<br />
**SchemaName**: msdyn_workorderproduct<br />
**CollectionSchemaName**: msdyn_workorderproducts<br />
**LogicalName**: msdyn_workorderproduct<br />
**LogicalCollectionName**: msdyn_workorderproducts<br />
**EntitySetName**: msdyn_workorderproducts<br />
**PrimaryIdAttribute**: msdyn_workorderproductid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdditionalCost](#BKMK_msdyn_AdditionalCost)
- [msdyn_AgreementBookingProduct](#BKMK_msdyn_AgreementBookingProduct)
- [msdyn_Allocated](#BKMK_msdyn_Allocated)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_CommissionCosts](#BKMK_msdyn_CommissionCosts)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_DiscountAmount](#BKMK_msdyn_DiscountAmount)
- [msdyn_DiscountPercent](#BKMK_msdyn_DiscountPercent)
- [msdyn_EstimateDiscountAmount](#BKMK_msdyn_EstimateDiscountAmount)
- [msdyn_EstimateDiscountPercent](#BKMK_msdyn_EstimateDiscountPercent)
- [msdyn_EstimateQuantity](#BKMK_msdyn_EstimateQuantity)
- [msdyn_EstimateSubtotal](#BKMK_msdyn_EstimateSubtotal)
- [msdyn_EstimateTotalAmount](#BKMK_msdyn_EstimateTotalAmount)
- [msdyn_EstimateTotalCost](#BKMK_msdyn_EstimateTotalCost)
- [msdyn_EstimateUnitAmount](#BKMK_msdyn_EstimateUnitAmount)
- [msdyn_EstimateUnitCost](#BKMK_msdyn_EstimateUnitCost)
- [msdyn_InternalDescription](#BKMK_msdyn_InternalDescription)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_LineStatus](#BKMK_msdyn_LineStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_PurchaseOrderReceiptProduct](#BKMK_msdyn_PurchaseOrderReceiptProduct)
- [msdyn_QtyToBill](#BKMK_msdyn_QtyToBill)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_Subtotal](#BKMK_msdyn_Subtotal)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_TotalCost](#BKMK_msdyn_TotalCost)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitAmount](#BKMK_msdyn_UnitAmount)
- [msdyn_UnitCost](#BKMK_msdyn_UnitCost)
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_WorkOrderIncident](#BKMK_msdyn_WorkOrderIncident)
- [msdyn_workorderproductId](#BKMK_msdyn_workorderproductId)
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


### <a name="BKMK_msdyn_AdditionalCost"></a> msdyn_AdditionalCost

**Description**: Enter any additional costs associated with this product. The values are manually entered. Note: additional cost is not unit dependent.<br />
**DisplayName**: Additional Cost<br />
**LogicalName**: msdyn_additionalcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_AgreementBookingProduct"></a> msdyn_AgreementBookingProduct

**Description**: Agreement Booking Product linked to this Work Order Product<br />
**DisplayName**: Agreement Booking Product<br />
**LogicalName**: msdyn_agreementbookingproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementbookingproduct


### <a name="BKMK_msdyn_Allocated"></a> msdyn_Allocated

**Description**: <br />
**DisplayName**: Allocated<br />
**LogicalName**: msdyn_allocated<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

**Description**: The booking where this product was added<br />
**DisplayName**: Booking<br />
**LogicalName**: msdyn_booking<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcebooking


### <a name="BKMK_msdyn_CommissionCosts"></a> msdyn_CommissionCosts

**Description**: Enter the commission costs associated with this product. The value is manually specified and isn't automatically calculated.<br />
**DisplayName**: Commission Costs<br />
**LogicalName**: msdyn_commissioncosts<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

**Description**: Unique identifier for Customer Asset associated with Work Order Product.<br />
**DisplayName**: Customer Asset<br />
**LogicalName**: msdyn_customerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

**Description**: Enter the description of the product as presented to the customer. The value defaults to the description defined on the product.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_DiscountAmount"></a> msdyn_DiscountAmount

**Description**: Specify any discount amount on this product. Note: If you enter a discount amount you cannot enter a discount %<br />
**DisplayName**: Discount Amount<br />
**LogicalName**: msdyn_discountamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_DiscountPercent"></a> msdyn_DiscountPercent

**Description**: Specify any discount % on this product. Note: If you enter a discount % it will overwrite the discount $<br />
**DisplayName**: Discount %<br />
**LogicalName**: msdyn_discountpercent<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 100<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstimateDiscountAmount"></a> msdyn_EstimateDiscountAmount

**Description**: Enter a discount amount on the subtotal amount. Note: If you enter a discount amount you cannot enter a discount %<br />
**DisplayName**: Estimate Discount Amount<br />
**LogicalName**: msdyn_estimatediscountamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_EstimateDiscountPercent"></a> msdyn_EstimateDiscountPercent

**Description**: Enter a discount % on the subtotal amount. Note: If you enter a discount % it will overwrite the discount $<br />
**DisplayName**: Estimate Discount %<br />
**LogicalName**: msdyn_estimatediscountpercent<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 100<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstimateQuantity"></a> msdyn_EstimateQuantity

**Description**: Enter the estimated required quantity of this product.<br />
**DisplayName**: Estimate Quantity<br />
**LogicalName**: msdyn_estimatequantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstimateSubtotal"></a> msdyn_EstimateSubtotal

**Description**: Shows the total amount for this product, excluding discounts.<br />
**DisplayName**: Estimate Subtotal<br />
**LogicalName**: msdyn_estimatesubtotal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_EstimateTotalAmount"></a> msdyn_EstimateTotalAmount

**Description**: Shows the estimated total amount of this product, including discounts.<br />
**DisplayName**: Estimate Total Amount<br />
**LogicalName**: msdyn_estimatetotalamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_EstimateTotalCost"></a> msdyn_EstimateTotalCost

**Description**: Shows the estimated total cost of this product.<br />
**DisplayName**: Estimate Total Cost<br />
**LogicalName**: msdyn_estimatetotalcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_EstimateUnitAmount"></a> msdyn_EstimateUnitAmount

**Description**: Shows the estimated sale amount per unit.<br />
**DisplayName**: Estimate Unit Amount<br />
**LogicalName**: msdyn_estimateunitamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_EstimateUnitCost"></a> msdyn_EstimateUnitCost

**Description**: Shows the estimated cost amount per unit.<br />
**DisplayName**: Estimate Unit Cost<br />
**LogicalName**: msdyn_estimateunitcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_InternalDescription"></a> msdyn_InternalDescription

**Description**: Enter any internal notes you want to track on this product.<br />
**DisplayName**: Internal Description<br />
**LogicalName**: msdyn_internaldescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

**Description**: For internal use only.<br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

**Description**: <br />
**DisplayName**: Line Order<br />
**LogicalName**: msdyn_lineorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_LineStatus"></a> msdyn_LineStatus

**Description**: Enter the current status of the line, estimate or used.<br />
**DisplayName**: Line Status<br />
**LogicalName**: msdyn_linestatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Estimated
- **Value**: 690970001 **Label**: Used



### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

**Description**: Price List that determines the pricing for this product<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: Product to use<br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_PurchaseOrderReceiptProduct"></a> msdyn_PurchaseOrderReceiptProduct

**Description**: Purchase Order Receipt Product linked to this Work Order Product<br />
**DisplayName**: Purchase Order Receipt Product<br />
**LogicalName**: msdyn_purchaseorderreceiptproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorderreceiptproduct


### <a name="BKMK_msdyn_QtyToBill"></a> msdyn_QtyToBill

**Description**: Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity."<br />
**DisplayName**: Quantity To Bill<br />
**LogicalName**: msdyn_qtytobill<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

**Description**: Shows the actual quantity of the product.<br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_Subtotal"></a> msdyn_Subtotal

**Description**: Enter the total amount excluding discounts.<br />
**DisplayName**: Subtotal<br />
**LogicalName**: msdyn_subtotal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

**Description**: Specify if product is taxable. If you do not wish to charge tax set this field to No.<br />
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

**Description**: Enter the total amount charged to the customer.<br />
**DisplayName**: Total Amount<br />
**LogicalName**: msdyn_totalamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_TotalCost"></a> msdyn_TotalCost

**Description**: Shows the total cost of this product. This is calculated by (Unit Cost * Units) + Additional Cost + Commission Costs.<br />
**DisplayName**: Total Cost<br />
**LogicalName**: msdyn_totalcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

**Description**: The unit that determines the pricing and final quantity for this product<br />
**DisplayName**: Unit<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_UnitAmount"></a> msdyn_UnitAmount

**Description**: Enter the amount you want to charge the customer per unit. By default, this is calculated based on the selected price list. The amount can be changed.<br />
**DisplayName**: Unit Amount<br />
**LogicalName**: msdyn_unitamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_UnitCost"></a> msdyn_UnitCost

**Description**: Shows the actual cost per unit.<br />
**DisplayName**: Unit Cost<br />
**LogicalName**: msdyn_unitcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

**Description**: Warehouse this product is being retrieved from<br />
**DisplayName**: Warehouse<br />
**LogicalName**: msdyn_warehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Description**: Unique identifier for Work Order associated with Work Order Product.<br />
**DisplayName**: Work Order<br />
**LogicalName**: msdyn_workorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_msdyn_WorkOrderIncident"></a> msdyn_WorkOrderIncident

**Description**: The Incident related to this product<br />
**DisplayName**: Work Order Incident<br />
**LogicalName**: msdyn_workorderincident<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorderincident


### <a name="BKMK_msdyn_workorderproductId"></a> msdyn_workorderproductId

**Description**: Shows the entity instances.<br />
**DisplayName**: Work Order Product<br />
**LogicalName**: msdyn_workorderproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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

**Description**: Status of the Work Order Product<br />
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

**Description**: Reason for the status of the Work Order Product<br />
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
- [msdyn_additionalcost_Base](#BKMK_msdyn_additionalcost_Base)
- [msdyn_AgreementBookingProductName](#BKMK_msdyn_AgreementBookingProductName)
- [msdyn_BookingName](#BKMK_msdyn_BookingName)
- [msdyn_commissioncosts_Base](#BKMK_msdyn_commissioncosts_Base)
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
- [msdyn_discountamount_Base](#BKMK_msdyn_discountamount_Base)
- [msdyn_estimatediscountamount_Base](#BKMK_msdyn_estimatediscountamount_Base)
- [msdyn_estimatesubtotal_Base](#BKMK_msdyn_estimatesubtotal_Base)
- [msdyn_estimatetotalamount_Base](#BKMK_msdyn_estimatetotalamount_Base)
- [msdyn_estimatetotalcost_Base](#BKMK_msdyn_estimatetotalcost_Base)
- [msdyn_estimateunitamount_Base](#BKMK_msdyn_estimateunitamount_Base)
- [msdyn_estimateunitcost_Base](#BKMK_msdyn_estimateunitcost_Base)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_PurchaseOrderReceiptProductName](#BKMK_msdyn_PurchaseOrderReceiptProductName)
- [msdyn_subtotal_Base](#BKMK_msdyn_subtotal_Base)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
- [msdyn_unitcost_Base](#BKMK_msdyn_unitcost_Base)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_WarehouseName](#BKMK_msdyn_WarehouseName)
- [msdyn_WorkOrderIncidentName](#BKMK_msdyn_WorkOrderIncidentName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
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


### <a name="BKMK_msdyn_additionalcost_Base"></a> msdyn_additionalcost_Base

**Description**: Shows the value of the additional cost in the base currency.<br />
**DisplayName**: Additional Cost (Base)<br />
**LogicalName**: msdyn_additionalcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_AgreementBookingProductName"></a> msdyn_AgreementBookingProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementbookingproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_BookingName"></a> msdyn_BookingName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_bookingname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_commissioncosts_Base"></a> msdyn_commissioncosts_Base

**Description**: Shows the value of the commission costs in the base currency.<br />
**DisplayName**: Commission Costs (Base)<br />
**LogicalName**: msdyn_commissioncosts_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


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


### <a name="BKMK_msdyn_discountamount_Base"></a> msdyn_discountamount_Base

**Description**: Shows the value of the discount amount in the base currency.<br />
**DisplayName**: Discount Amount (Base)<br />
**LogicalName**: msdyn_discountamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_estimatediscountamount_Base"></a> msdyn_estimatediscountamount_Base

**Description**: Shows the value of the estimate discount amount in the base currency.<br />
**DisplayName**: Estimate Discount Amount (Base)<br />
**LogicalName**: msdyn_estimatediscountamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_estimatesubtotal_Base"></a> msdyn_estimatesubtotal_Base

**Description**: Shows the value of the estimate subtotal in the base currency.<br />
**DisplayName**: Estimate Subtotal (Base)<br />
**LogicalName**: msdyn_estimatesubtotal_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_estimatetotalamount_Base"></a> msdyn_estimatetotalamount_Base

**Description**: Shows the value of the estimate total amount in the base currency.<br />
**DisplayName**: Estimate Total Amount (Base)<br />
**LogicalName**: msdyn_estimatetotalamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_estimatetotalcost_Base"></a> msdyn_estimatetotalcost_Base

**Description**: Shows the value of the estimate total cost in the base currency.<br />
**DisplayName**: Estimate Total Cost (Base)<br />
**LogicalName**: msdyn_estimatetotalcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_estimateunitamount_Base"></a> msdyn_estimateunitamount_Base

**Description**: Shows the value of the estimate unit amount in the base currency.<br />
**DisplayName**: Estimate Unit Amount (Base)<br />
**LogicalName**: msdyn_estimateunitamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_estimateunitcost_Base"></a> msdyn_estimateunitcost_Base

**Description**: Shows the value of the estimate unit cost in the base currency.<br />
**DisplayName**: Estimate Unit Cost (Base)<br />
**LogicalName**: msdyn_estimateunitcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


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


### <a name="BKMK_msdyn_PurchaseOrderReceiptProductName"></a> msdyn_PurchaseOrderReceiptProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_purchaseorderreceiptproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_subtotal_Base"></a> msdyn_subtotal_Base

**Description**: Shows the value of the subtotal in the base currency.<br />
**DisplayName**: Subtotal (Base)<br />
**LogicalName**: msdyn_subtotal_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


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
**PrecisionSource**: 1


### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

**Description**: Shows the value of the total cost in the base currency.<br />
**DisplayName**: Total Cost (Base)<br />
**LogicalName**: msdyn_totalcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


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
**PrecisionSource**: 1


### <a name="BKMK_msdyn_unitcost_Base"></a> msdyn_unitcost_Base

**Description**: Shows the value of the unit cost in the base currency.<br />
**DisplayName**: Unit Cost (Base)<br />
**LogicalName**: msdyn_unitcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


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


### <a name="BKMK_msdyn_WorkOrderIncidentName"></a> msdyn_WorkOrderIncidentName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workorderincidentname<br />
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

- [msdyn_workorderproduct_ActivityPointers](#BKMK_msdyn_workorderproduct_ActivityPointers)
- [msdyn_workorderproduct_msdyn_approvals](#BKMK_msdyn_workorderproduct_msdyn_approvals)
- [msdyn_workorderproduct_msdyn_bookingalerts](#BKMK_msdyn_workorderproduct_msdyn_bookingalerts)
- [msdyn_workorderproduct_SyncErrors](#BKMK_msdyn_workorderproduct_SyncErrors)
- [msdyn_workorderproduct_SharePointDocumentLocations](#BKMK_msdyn_workorderproduct_SharePointDocumentLocations)
- [msdyn_workorderproduct_SharePointDocuments](#BKMK_msdyn_workorderproduct_SharePointDocuments)
- [msdyn_workorderproduct_AsyncOperations](#BKMK_msdyn_workorderproduct_AsyncOperations)
- [msdyn_workorderproduct_MailboxTrackingFolders](#BKMK_msdyn_workorderproduct_MailboxTrackingFolders)
- [msdyn_workorderproduct_UserEntityInstanceDatas](#BKMK_msdyn_workorderproduct_UserEntityInstanceDatas)
- [msdyn_workorderproduct_ProcessSession](#BKMK_msdyn_workorderproduct_ProcessSession)
- [msdyn_workorderproduct_BulkDeleteFailures](#BKMK_msdyn_workorderproduct_BulkDeleteFailures)
- [msdyn_workorderproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses)
- [msdyn_workorderproduct_Appointments](#BKMK_msdyn_workorderproduct_Appointments)
- [msdyn_workorderproduct_Emails](#BKMK_msdyn_workorderproduct_Emails)
- [msdyn_workorderproduct_Faxes](#BKMK_msdyn_workorderproduct_Faxes)
- [msdyn_workorderproduct_Letters](#BKMK_msdyn_workorderproduct_Letters)
- [msdyn_workorderproduct_PhoneCalls](#BKMK_msdyn_workorderproduct_PhoneCalls)
- [msdyn_workorderproduct_Tasks](#BKMK_msdyn_workorderproduct_Tasks)
- [msdyn_workorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters)
- [msdyn_workorderproduct_SocialActivities](#BKMK_msdyn_workorderproduct_SocialActivities)
- [msdyn_workorderproduct_connections1](#BKMK_msdyn_workorderproduct_connections1)
- [msdyn_workorderproduct_connections2](#BKMK_msdyn_workorderproduct_connections2)
- [msdyn_workorderproduct_Annotations](#BKMK_msdyn_workorderproduct_Annotations)
- [msdyn_workorderproduct_ServiceAppointments](#BKMK_msdyn_workorderproduct_ServiceAppointments)
- [msdyn_msdyn_workorderproduct_invoicedetail](#BKMK_msdyn_msdyn_workorderproduct_invoicedetail)
- [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct)
- [msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct)
- [msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct)
- [msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct)


### <a name="BKMK_msdyn_workorderproduct_ActivityPointers"></a> msdyn_workorderproduct_ActivityPointers

Same as activitypointer entity [msdyn_workorderproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderproduct_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_ActivityPointers<br />
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


### <a name="BKMK_msdyn_workorderproduct_msdyn_approvals"></a> msdyn_workorderproduct_msdyn_approvals

Same as msdyn_approval entity [msdyn_workorderproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_workorderproduct_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_workorderproduct_msdyn_bookingalerts"></a> msdyn_workorderproduct_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_workorderproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderproduct_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_workorderproduct_SyncErrors"></a> msdyn_workorderproduct_SyncErrors

Same as syncerror entity [msdyn_workorderproduct_SyncErrors](syncerror.md#BKMK_msdyn_workorderproduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_SyncErrors<br />
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


### <a name="BKMK_msdyn_workorderproduct_SharePointDocumentLocations"></a> msdyn_workorderproduct_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_workorderproduct_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorderproduct_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_workorderproduct_SharePointDocuments"></a> msdyn_workorderproduct_SharePointDocuments

Same as sharepointdocument entity [msdyn_workorderproduct_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_workorderproduct_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_SharePointDocuments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 60

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderproduct_AsyncOperations"></a> msdyn_workorderproduct_AsyncOperations

Same as asyncoperation entity [msdyn_workorderproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderproduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_AsyncOperations<br />
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


### <a name="BKMK_msdyn_workorderproduct_MailboxTrackingFolders"></a> msdyn_workorderproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_workorderproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_workorderproduct_UserEntityInstanceDatas"></a> msdyn_workorderproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_workorderproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_workorderproduct_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_workorderproduct_ProcessSession"></a> msdyn_workorderproduct_ProcessSession

Same as processsession entity [msdyn_workorderproduct_ProcessSession](processsession.md#BKMK_msdyn_workorderproduct_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_ProcessSession<br />
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


### <a name="BKMK_msdyn_workorderproduct_BulkDeleteFailures"></a> msdyn_workorderproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_workorderproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderproduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses"></a> msdyn_workorderproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_workorderproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_workorderproduct_Appointments"></a> msdyn_workorderproduct_Appointments

Same as appointment entity [msdyn_workorderproduct_Appointments](appointment.md#BKMK_msdyn_workorderproduct_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_Appointments<br />
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


### <a name="BKMK_msdyn_workorderproduct_Emails"></a> msdyn_workorderproduct_Emails

Same as email entity [msdyn_workorderproduct_Emails](email.md#BKMK_msdyn_workorderproduct_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_Emails<br />
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


### <a name="BKMK_msdyn_workorderproduct_Faxes"></a> msdyn_workorderproduct_Faxes

Same as fax entity [msdyn_workorderproduct_Faxes](fax.md#BKMK_msdyn_workorderproduct_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_Faxes<br />
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


### <a name="BKMK_msdyn_workorderproduct_Letters"></a> msdyn_workorderproduct_Letters

Same as letter entity [msdyn_workorderproduct_Letters](letter.md#BKMK_msdyn_workorderproduct_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_Letters<br />
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


### <a name="BKMK_msdyn_workorderproduct_PhoneCalls"></a> msdyn_workorderproduct_PhoneCalls

Same as phonecall entity [msdyn_workorderproduct_PhoneCalls](phonecall.md#BKMK_msdyn_workorderproduct_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_PhoneCalls<br />
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


### <a name="BKMK_msdyn_workorderproduct_Tasks"></a> msdyn_workorderproduct_Tasks

Same as task entity [msdyn_workorderproduct_Tasks](task.md#BKMK_msdyn_workorderproduct_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_Tasks<br />
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


### <a name="BKMK_msdyn_workorderproduct_RecurringAppointmentMasters"></a> msdyn_workorderproduct_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_workorderproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_workorderproduct_SocialActivities"></a> msdyn_workorderproduct_SocialActivities

Same as socialactivity entity [msdyn_workorderproduct_SocialActivities](socialactivity.md#BKMK_msdyn_workorderproduct_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_SocialActivities<br />
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


### <a name="BKMK_msdyn_workorderproduct_connections1"></a> msdyn_workorderproduct_connections1

Same as connection entity [msdyn_workorderproduct_connections1](connection.md#BKMK_msdyn_workorderproduct_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_connections1<br />
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


### <a name="BKMK_msdyn_workorderproduct_connections2"></a> msdyn_workorderproduct_connections2

Same as connection entity [msdyn_workorderproduct_connections2](connection.md#BKMK_msdyn_workorderproduct_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_connections2<br />
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


### <a name="BKMK_msdyn_workorderproduct_Annotations"></a> msdyn_workorderproduct_Annotations

Same as annotation entity [msdyn_workorderproduct_Annotations](annotation.md#BKMK_msdyn_workorderproduct_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_Annotations<br />
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


### <a name="BKMK_msdyn_workorderproduct_ServiceAppointments"></a> msdyn_workorderproduct_ServiceAppointments

Same as serviceappointment entity [msdyn_workorderproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderproduct_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderproduct_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_workorderproduct_invoicedetail"></a> msdyn_msdyn_workorderproduct_invoicedetail

Same as invoicedetail entity [msdyn_msdyn_workorderproduct_invoicedetail](invoicedetail.md#BKMK_msdyn_msdyn_workorderproduct_invoicedetail) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: msdyn_workorderproductid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderproduct_invoicedetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Sales
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct

Same as msdyn_customerasset entity [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](msdyn_customerasset.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_customerasset<br />
**ReferencingAttribute**: msdyn_workorderproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct<br />
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


### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct

Same as msdyn_inventoryjournal entity [msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: msdyn_workorderproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct<br />
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


### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct"></a> msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct

Same as msdyn_rmaproduct entity [msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: msdyn_woproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct<br />
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


### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct

Same as msdyn_rtvproduct entity [msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: msdyn_workorderproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct<br />
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

- [lk_msdyn_workorderproduct_createdby](#BKMK_lk_msdyn_workorderproduct_createdby)
- [lk_msdyn_workorderproduct_createdonbehalfby](#BKMK_lk_msdyn_workorderproduct_createdonbehalfby)
- [lk_msdyn_workorderproduct_modifiedby](#BKMK_lk_msdyn_workorderproduct_modifiedby)
- [lk_msdyn_workorderproduct_modifiedonbehalfby](#BKMK_lk_msdyn_workorderproduct_modifiedonbehalfby)
- [user_msdyn_workorderproduct](#BKMK_user_msdyn_workorderproduct)
- [team_msdyn_workorderproduct](#BKMK_team_msdyn_workorderproduct)
- [business_unit_msdyn_workorderproduct](#BKMK_business_unit_msdyn_workorderproduct)
- [TransactionCurrency_msdyn_workorderproduct](#BKMK_TransactionCurrency_msdyn_workorderproduct)
- [msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking)
- [msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct](#BKMK_msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct)
- [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset)
- [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct](#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct)
- [msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse)
- [msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder)
- [msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident)
- [msdyn_pricelevel_msdyn_workorderproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList)
- [msdyn_product_msdyn_workorderproduct_Product](#BKMK_msdyn_product_msdyn_workorderproduct_Product)
- [msdyn_uom_msdyn_workorderproduct_Unit](#BKMK_msdyn_uom_msdyn_workorderproduct_Unit)


### <a name="BKMK_lk_msdyn_workorderproduct_createdby"></a> lk_msdyn_workorderproduct_createdby

See systemuser Entity [lk_msdyn_workorderproduct_createdby](systemuser.md#BKMK_lk_msdyn_workorderproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderproduct_createdonbehalfby"></a> lk_msdyn_workorderproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_workorderproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderproduct_modifiedby"></a> lk_msdyn_workorderproduct_modifiedby

See systemuser Entity [lk_msdyn_workorderproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderproduct_modifiedonbehalfby"></a> lk_msdyn_workorderproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_workorderproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_workorderproduct"></a> user_msdyn_workorderproduct

See systemuser Entity [user_msdyn_workorderproduct](systemuser.md#BKMK_user_msdyn_workorderproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_workorderproduct"></a> team_msdyn_workorderproduct

See team Entity [team_msdyn_workorderproduct](team.md#BKMK_team_msdyn_workorderproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_workorderproduct"></a> business_unit_msdyn_workorderproduct

See businessunit Entity [business_unit_msdyn_workorderproduct](businessunit.md#BKMK_business_unit_msdyn_workorderproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_workorderproduct"></a> TransactionCurrency_msdyn_workorderproduct

See transactioncurrency Entity [TransactionCurrency_msdyn_workorderproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_workorderproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct"></a> msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct

See msdyn_agreementbookingproduct Entity [msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct"></a> msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct

See msdyn_purchaseorderreceiptproduct Entity [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident

See msdyn_workorderincident Entity [msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList"></a> msdyn_pricelevel_msdyn_workorderproduct_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_workorderproduct_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_workorderproduct_Product"></a> msdyn_product_msdyn_workorderproduct_Product

See product Entity [msdyn_product_msdyn_workorderproduct_Product](product.md#BKMK_msdyn_product_msdyn_workorderproduct_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_workorderproduct_Unit"></a> msdyn_uom_msdyn_workorderproduct_Unit

See uom Entity [msdyn_uom_msdyn_workorderproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_workorderproduct_Unit) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorderproduct?text=msdyn_workorderproduct EntityType" />