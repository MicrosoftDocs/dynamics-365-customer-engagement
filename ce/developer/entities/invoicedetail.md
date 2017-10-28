---
title: "InvoiceDetail Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the InvoiceDetail entity."
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
# InvoiceDetail Entity Reference

Line item in an invoice containing detailed billing information for a product.

**Added by**: Sales Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|CalculatePrice|<xref href="Microsoft.Dynamics.CRM.CalculatePrice?text=CalculatePrice Action" />|<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|
|Create|POST [*org URI*]/api/data/v9.0/invoicedetails<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/invoicedetails(*invoicedetailid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/invoicedetails(*invoicedetailid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/invoicedetails<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/invoicedetails(*invoicedetailid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Invoice Line<br />
**DisplayCollectionName**: Invoice Lines<br />
**SchemaName**: InvoiceDetail<br />
**CollectionSchemaName**: InvoiceDetails<br />
**LogicalName**: invoicedetail<br />
**LogicalCollectionName**: invoicedetails<br />
**EntitySetName**: invoicedetails<br />
**PrimaryIdAttribute**: invoicedetailid<br />
**PrimaryNameAttribute**: productidname<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActualDeliveryOn](#BKMK_ActualDeliveryOn)
- [BaseAmount](#BKMK_BaseAmount)
- [Description](#BKMK_Description)
- [ExtendedAmount](#BKMK_ExtendedAmount)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InvoiceDetailId](#BKMK_InvoiceDetailId)
- [InvoiceId](#BKMK_InvoiceId)
- [IsCopied](#BKMK_IsCopied)
- [IsPriceOverridden](#BKMK_IsPriceOverridden)
- [IsProductOverridden](#BKMK_IsProductOverridden)
- [LineItemNumber](#BKMK_LineItemNumber)
- [ManualDiscountAmount](#BKMK_ManualDiscountAmount)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_AgreementInvoiceProduct](#BKMK_msdyn_AgreementInvoiceProduct)
- [msdyn_BillingMethod](#BKMK_msdyn_BillingMethod)
- [msdyn_chargeableamount](#BKMK_msdyn_chargeableamount)
- [msdyn_complimentaryamount](#BKMK_msdyn_complimentaryamount)
- [msdyn_ContractLine](#BKMK_msdyn_ContractLine)
- [msdyn_contractlineamount](#BKMK_msdyn_contractlineamount)
- [msdyn_Currency](#BKMK_msdyn_Currency)
- [msdyn_invoicedtilldate](#BKMK_msdyn_invoicedtilldate)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_LineType](#BKMK_msdyn_LineType)
- [msdyn_nonchargeableamount](#BKMK_msdyn_nonchargeableamount)
- [msdyn_OrderInvoicingProduct](#BKMK_msdyn_OrderInvoicingProduct)
- [msdyn_Project](#BKMK_msdyn_Project)
- [msdyn_WorkOrderId](#BKMK_msdyn_WorkOrderId)
- [msdyn_WorkOrderProductId](#BKMK_msdyn_WorkOrderProductId)
- [msdyn_WorkOrderServiceId](#BKMK_msdyn_WorkOrderServiceId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ParentBundleId](#BKMK_ParentBundleId)
- [PricePerUnit](#BKMK_PricePerUnit)
- [PricingErrorCode](#BKMK_PricingErrorCode)
- [ProductAssociationId](#BKMK_ProductAssociationId)
- [ProductDescription](#BKMK_ProductDescription)
- [ProductId](#BKMK_ProductId)
- [ProductName](#BKMK_ProductName)
- [ProductTypeCode](#BKMK_ProductTypeCode)
- [PropertyConfigurationStatus](#BKMK_PropertyConfigurationStatus)
- [Quantity](#BKMK_Quantity)
- [QuantityBackordered](#BKMK_QuantityBackordered)
- [QuantityCancelled](#BKMK_QuantityCancelled)
- [QuantityShipped](#BKMK_QuantityShipped)
- [SalesRepId](#BKMK_SalesRepId)
- [SequenceNumber](#BKMK_SequenceNumber)
- [ShippingTrackingNumber](#BKMK_ShippingTrackingNumber)
- [ShipTo_City](#BKMK_ShipTo_City)
- [ShipTo_Country](#BKMK_ShipTo_Country)
- [ShipTo_Fax](#BKMK_ShipTo_Fax)
- [ShipTo_FreightTermsCode](#BKMK_ShipTo_FreightTermsCode)
- [ShipTo_Line1](#BKMK_ShipTo_Line1)
- [ShipTo_Line2](#BKMK_ShipTo_Line2)
- [ShipTo_Line3](#BKMK_ShipTo_Line3)
- [ShipTo_Name](#BKMK_ShipTo_Name)
- [ShipTo_PostalCode](#BKMK_ShipTo_PostalCode)
- [ShipTo_StateOrProvince](#BKMK_ShipTo_StateOrProvince)
- [ShipTo_Telephone](#BKMK_ShipTo_Telephone)
- [Tax](#BKMK_Tax)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UoMId](#BKMK_UoMId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WillCall](#BKMK_WillCall)


### <a name="BKMK_ActualDeliveryOn"></a> ActualDeliveryOn

**Description**: Enter the date when the invoiced product was delivered to the customer.<br />
**DisplayName**: Delivered On<br />
**LogicalName**: actualdeliveryon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_BaseAmount"></a> BaseAmount

**Description**: Shows the total price of the invoice product, based on the price per unit, volume discount, and quantity.<br />
**DisplayName**: Amount<br />
**LogicalName**: baseamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the product line item of the invoice.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_ExtendedAmount"></a> ExtendedAmount

**Description**: Shows the total amount due for the invoice product, based on the sum of the unit price, quantity, discounts, and tax.<br />
**DisplayName**: Extended Amount<br />
**LogicalName**: extendedamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


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


### <a name="BKMK_InvoiceDetailId"></a> InvoiceDetailId

**Description**: Unique identifier of the invoice product line item.<br />
**DisplayName**: Invoice Product<br />
**LogicalName**: invoicedetailid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_InvoiceId"></a> InvoiceId

**Description**: Unique identifier of the invoice associated with the invoice product line item.<br />
**DisplayName**: Invoice ID<br />
**LogicalName**: invoiceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: invoice


### <a name="BKMK_IsCopied"></a> IsCopied

**Description**: Select whether the invoice product is copied from another item or data source.<br />
**DisplayName**: Copied<br />
**LogicalName**: iscopied<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsPriceOverridden"></a> IsPriceOverridden

**Description**: Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the invoice product.<br />
**DisplayName**: Pricing<br />
**LogicalName**: ispriceoverridden<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Override Price
- **FalseOption Value**: 0 **Label**: Use Default

**DefaultValue**: False


### <a name="BKMK_IsProductOverridden"></a> IsProductOverridden

**Description**: Select whether the product exists in the Microsoft Dynamics 365 product catalog or is a write-in product specific to the parent invoice.<br />
**DisplayName**: Select Product<br />
**LogicalName**: isproductoverridden<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Write In
- **FalseOption Value**: 0 **Label**: Existing

**DefaultValue**: False


### <a name="BKMK_LineItemNumber"></a> LineItemNumber

**Description**: Type the line item number for the invoice product to easily identify the product in the invoice and make sure it's listed in the correct order.<br />
**DisplayName**: Line Item Number<br />
**LogicalName**: lineitemnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_ManualDiscountAmount"></a> ManualDiscountAmount

**Description**: Type the manual discount amount for the invoice product to deduct any negotiated or other savings from the product total.<br />
**DisplayName**: Manual Discount<br />
**LogicalName**: manualdiscountamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Agreement associated with Invoice Product.<br />
**DisplayName**: Agreement<br />
**LogicalName**: msdyn_agreement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreement


### <a name="BKMK_msdyn_AgreementInvoiceProduct"></a> msdyn_AgreementInvoiceProduct

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Agreement Invoice Product associated with Invoice Product.<br />
**DisplayName**: Agreement Invoice Product<br />
**LogicalName**: msdyn_agreementinvoiceproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementinvoiceproduct


### <a name="BKMK_msdyn_BillingMethod"></a> msdyn_BillingMethod

**Added by**: Project Service Automation Solution<br />
**Description**: Billing method for the project invoice line. Valid values are Time and Material and Fixed Price<br />
**DisplayName**: Billing Method<br />
**LogicalName**: msdyn_billingmethod<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Time and Material
- **Value**: 192350001 **Label**: Fixed Price



### <a name="BKMK_msdyn_chargeableamount"></a> msdyn_chargeableamount

**Added by**: Project Service Automation Solution<br />
**Description**: The amount from included line details that is chargeable.<br />
**DisplayName**: Chargeable Amount<br />
**LogicalName**: msdyn_chargeableamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_complimentaryamount"></a> msdyn_complimentaryamount

**Added by**: Project Service Automation Solution<br />
**Description**: The amount from included line details that is complimentary and won't be charged.<br />
**DisplayName**: Complimentary Amount<br />
**LogicalName**: msdyn_complimentaryamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_ContractLine"></a> msdyn_ContractLine

**Added by**: Project Service Automation Solution<br />
**Description**: Shows the project contract line for this invoice line.<br />
**DisplayName**: Project Contract Line<br />
**LogicalName**: msdyn_contractline<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_contractlineamount"></a> msdyn_contractlineamount

**Added by**: Project Service Automation Solution<br />
**Description**: Amount from the related project contract line if present.<br />
**DisplayName**: Contract Line Amount<br />
**LogicalName**: msdyn_contractlineamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_Currency"></a> msdyn_Currency

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Currency associated with Invoice Product.<br />
**DisplayName**: Currency<br />
**LogicalName**: msdyn_currency<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_msdyn_invoicedtilldate"></a> msdyn_invoicedtilldate

**Added by**: Project Service Automation Solution<br />
**Description**: Amount already invoiced to customer for the same project contract line.<br />
**DisplayName**: Amount Previously Invoiced<br />
**LogicalName**: msdyn_invoicedtilldate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

**Added by**: Field Service Solution<br />
**Description**: Shows the order of this invoice product within the invoice.<br />
**DisplayName**: Line Order<br />
**LogicalName**: msdyn_lineorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_LineType"></a> msdyn_LineType

**Added by**: Field Service Solution<br />
**Description**: The field to distinguish the Invoice lines to be of project service or field service<br />
**DisplayName**: Line Type<br />
**LogicalName**: msdyn_linetype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Project Service Line
- **Value**: 690970001 **Label**: Field Service Line



### <a name="BKMK_msdyn_nonchargeableamount"></a> msdyn_nonchargeableamount

**Added by**: Project Service Automation Solution<br />
**Description**: The amount from included line details that is non-chargeable.<br />
**DisplayName**: Non Chargeable Amount<br />
**LogicalName**: msdyn_nonchargeableamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_OrderInvoicingProduct"></a> msdyn_OrderInvoicingProduct

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Order Invoicing Product associated with Invoice Product.<br />
**DisplayName**: Order Invoicing Product<br />
**LogicalName**: msdyn_orderinvoicingproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_orderinvoicingproduct


### <a name="BKMK_msdyn_Project"></a> msdyn_Project

**Added by**: Project Service Automation Solution<br />
**Description**: Shows the project for this invoice line.<br />
**DisplayName**: Project<br />
**LogicalName**: msdyn_project<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_project


### <a name="BKMK_msdyn_WorkOrderId"></a> msdyn_WorkOrderId

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Work Order associated with Invoice Product.<br />
**DisplayName**: Work Order<br />
**LogicalName**: msdyn_workorderid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_msdyn_WorkOrderProductId"></a> msdyn_WorkOrderProductId

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Work Order Product associated with Invoice Product.<br />
**DisplayName**: Work Order Product<br />
**LogicalName**: msdyn_workorderproductid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorderproduct


### <a name="BKMK_msdyn_WorkOrderServiceId"></a> msdyn_WorkOrderServiceId

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Work Order Service associated with Invoice Product.<br />
**DisplayName**: Work Order Service<br />
**LogicalName**: msdyn_workorderserviceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorderservice


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


### <a name="BKMK_ParentBundleId"></a> ParentBundleId

**Description**: Choose the parent bundle associated with this product<br />
**DisplayName**: Parent Bundle<br />
**LogicalName**: parentbundleid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_PricePerUnit"></a> PricePerUnit

**Description**: Type the price per unit of the invoice product. The default is the value in the price list specified on the parent invoice for existing products.<br />
**DisplayName**: Price Per Unit<br />
**LogicalName**: priceperunit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_PricingErrorCode"></a> PricingErrorCode

**Description**: Pricing error for the invoice product line item.<br />
**DisplayName**: Pricing Error <br />
**LogicalName**: pricingerrorcode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: None
- **Value**: 1 **Label**: Detail Error
- **Value**: 2 **Label**: Missing Price Level
- **Value**: 3 **Label**: Inactive Price Level
- **Value**: 4 **Label**: Missing Quantity
- **Value**: 5 **Label**: Missing Unit Price
- **Value**: 6 **Label**: Missing Product
- **Value**: 7 **Label**: Invalid Product
- **Value**: 8 **Label**: Missing Pricing Code
- **Value**: 9 **Label**: Invalid Pricing Code
- **Value**: 10 **Label**: Missing UOM
- **Value**: 11 **Label**: Product Not In Price Level
- **Value**: 12 **Label**: Missing Price Level Amount
- **Value**: 13 **Label**: Missing Price Level Percentage
- **Value**: 14 **Label**: Missing Price
- **Value**: 15 **Label**: Missing Current Cost
- **Value**: 16 **Label**: Missing Standard Cost
- **Value**: 17 **Label**: Invalid Price Level Amount
- **Value**: 18 **Label**: Invalid Price Level Percentage
- **Value**: 19 **Label**: Invalid Price
- **Value**: 20 **Label**: Invalid Current Cost
- **Value**: 21 **Label**: Invalid Standard Cost
- **Value**: 22 **Label**: Invalid Rounding Policy
- **Value**: 23 **Label**: Invalid Rounding Option
- **Value**: 24 **Label**: Invalid Rounding Amount
- **Value**: 25 **Label**: Price Calculation Error
- **Value**: 26 **Label**: Invalid Discount Type
- **Value**: 27 **Label**: Discount Type Invalid State
- **Value**: 28 **Label**: Invalid Discount
- **Value**: 29 **Label**: Invalid Quantity
- **Value**: 30 **Label**: Invalid Pricing Precision
- **Value**: 31 **Label**: Missing Product Default UOM
- **Value**: 32 **Label**: Missing Product UOM Schedule 
- **Value**: 33 **Label**: Inactive Discount Type
- **Value**: 34 **Label**: Invalid Price Level Currency
- **Value**: 35 **Label**: Price Attribute Out Of Range
- **Value**: 36 **Label**: Base Currency Attribute Overflow
- **Value**: 37 **Label**: Base Currency Attribute Underflow



### <a name="BKMK_ProductAssociationId"></a> ProductAssociationId

**Description**: Unique identifier of the product line item association with bundle in the invoice<br />
**DisplayName**: Bundle Item Association<br />
**LogicalName**: productassociationid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProductDescription"></a> ProductDescription

**Description**: Type a name or description to identify the type of write-in product included in the invoice.<br />
**DisplayName**: Write-In Product<br />
**LogicalName**: productdescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 500


### <a name="BKMK_ProductId"></a> ProductId

**Description**: Choose the product to include on the invoice.<br />
**DisplayName**: Existing Product<br />
**LogicalName**: productid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_ProductName"></a> ProductName

**Description**: Calculated field that will be populated by name and description of the product.<br />
**DisplayName**: Product Name<br />
**LogicalName**: productname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 500


### <a name="BKMK_ProductTypeCode"></a> ProductTypeCode

**Description**: Product Type<br />
**DisplayName**: Product type<br />
**LogicalName**: producttypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Product
- **Value**: 2 **Label**: Bundle
- **Value**: 3 **Label**: Required Bundle Product
- **Value**: 4 **Label**: Optional Bundle Product
- **Value**: 5 **Label**: Project-based Service



### <a name="BKMK_PropertyConfigurationStatus"></a> PropertyConfigurationStatus

**Description**: Status of the property configuration.<br />
**DisplayName**: Property Configuration<br />
**LogicalName**: propertyconfigurationstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Edit
- **Value**: 1 **Label**: Rectify
- **Value**: 2 **Label**: Not Configured



### <a name="BKMK_Quantity"></a> Quantity

**Description**: Type the amount or quantity of the product included in the invoice's total amount due.<br />
**DisplayName**: Quantity<br />
**LogicalName**: quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 5


### <a name="BKMK_QuantityBackordered"></a> QuantityBackordered

**Description**: Type the amount or quantity of the product that is back ordered for the invoice.<br />
**DisplayName**: Quantity Back Ordered<br />
**LogicalName**: quantitybackordered<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 5


### <a name="BKMK_QuantityCancelled"></a> QuantityCancelled

**Description**: Type the amount or quantity of the product that was canceled for the invoice line item.<br />
**DisplayName**: Quantity Canceled<br />
**LogicalName**: quantitycancelled<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 5


### <a name="BKMK_QuantityShipped"></a> QuantityShipped

**Description**: Type the amount or quantity of the product that was shipped.<br />
**DisplayName**: Quantity Shipped<br />
**LogicalName**: quantityshipped<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 5


### <a name="BKMK_SalesRepId"></a> SalesRepId

**Description**: Choose the user responsible for the sale of the invoice product.<br />
**DisplayName**: Salesperson<br />
**LogicalName**: salesrepid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_SequenceNumber"></a> SequenceNumber

**Description**: Shows the ID of the data that maintains the sequence.<br />
**DisplayName**: Sequence Number<br />
**LogicalName**: sequencenumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_ShippingTrackingNumber"></a> ShippingTrackingNumber

**Description**: Type a tracking number for shipment of the invoiced product.<br />
**DisplayName**: Shipment Tracking Number<br />
**LogicalName**: shippingtrackingnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ShipTo_City"></a> ShipTo_City

**Description**: Type the city for the customer's shipping address.<br />
**DisplayName**: Ship To City<br />
**LogicalName**: shipto_city<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_ShipTo_Country"></a> ShipTo_Country

**Description**: Type the country or region for the customer's shipping address.<br />
**DisplayName**: Ship To Country/Region<br />
**LogicalName**: shipto_country<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_ShipTo_Fax"></a> ShipTo_Fax

**Description**: Type the fax number for the customer's shipping address.<br />
**DisplayName**: Ship To Fax<br />
**LogicalName**: shipto_fax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_ShipTo_FreightTermsCode"></a> ShipTo_FreightTermsCode

**Description**: Select the freight terms to make sure shipping orders are processed correctly.<br />
**DisplayName**: Freight Terms<br />
**LogicalName**: shipto_freighttermscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: FOB
- **Value**: 2 **Label**: No Charge



### <a name="BKMK_ShipTo_Line1"></a> ShipTo_Line1

**Description**: Type the first line of the customer's shipping address.<br />
**DisplayName**: Ship To Street 1<br />
**LogicalName**: shipto_line1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_ShipTo_Line2"></a> ShipTo_Line2

**Description**: Type the second line of the customer's shipping address.<br />
**DisplayName**: Ship To Street 2<br />
**LogicalName**: shipto_line2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_ShipTo_Line3"></a> ShipTo_Line3

**Description**: Type the third line of the shipping address.<br />
**DisplayName**: Ship To Street 3<br />
**LogicalName**: shipto_line3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_ShipTo_Name"></a> ShipTo_Name

**Description**: Type a name for the customer's shipping address, such as "Headquarters" or "Field office",  to identify the address.<br />
**DisplayName**: Ship To Name<br />
**LogicalName**: shipto_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ShipTo_PostalCode"></a> ShipTo_PostalCode

**Description**: Type the ZIP Code or postal code for the shipping address.<br />
**DisplayName**: Ship To ZIP/Postal Code<br />
**LogicalName**: shipto_postalcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_ShipTo_StateOrProvince"></a> ShipTo_StateOrProvince

**Description**: Type the state or province for the shipping address.<br />
**DisplayName**: Ship To State/Province<br />
**LogicalName**: shipto_stateorprovince<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_ShipTo_Telephone"></a> ShipTo_Telephone

**Description**: Type the phone number for the customer's shipping address.<br />
**DisplayName**: Ship To Phone<br />
**LogicalName**: shipto_telephone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Tax"></a> Tax

**Description**: Type the tax amount for the invoice product.<br />
**DisplayName**: Tax<br />
**LogicalName**: tax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: -1000000000000<br />
**Precision**: 2<br />
**PrecisionSource**: 2


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
**MinValue**: -2147483648


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_UoMId"></a> UoMId

**Description**: Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.<br />
**DisplayName**: Unit<br />
**LogicalName**: uomid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uom


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
**MinValue**: -2147483648


### <a name="BKMK_WillCall"></a> WillCall

**Description**: Select whether the invoice product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.<br />
**DisplayName**: Ship To<br />
**LogicalName**: willcall<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Will Call
- **FalseOption Value**: 0 **Label**: Address

**DefaultValue**: False

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [BaseAmount_Base](#BKMK_BaseAmount_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ExtendedAmount_Base](#BKMK_ExtendedAmount_Base)
- [InvoiceIdName](#BKMK_InvoiceIdName)
- [InvoiceIsPriceLocked](#BKMK_InvoiceIsPriceLocked)
- [InvoiceStateCode](#BKMK_InvoiceStateCode)
- [ManualDiscountAmount_Base](#BKMK_ManualDiscountAmount_Base)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_AgreementInvoiceProductName](#BKMK_msdyn_AgreementInvoiceProductName)
- [msdyn_AgreementName](#BKMK_msdyn_AgreementName)
- [msdyn_chargeableamount_Base](#BKMK_msdyn_chargeableamount_Base)
- [msdyn_complimentaryamount_Base](#BKMK_msdyn_complimentaryamount_Base)
- [msdyn_contractlineamount_Base](#BKMK_msdyn_contractlineamount_Base)
- [msdyn_CurrencyName](#BKMK_msdyn_CurrencyName)
- [msdyn_invoicedtilldate_Base](#BKMK_msdyn_invoicedtilldate_Base)
- [msdyn_nonchargeableamount_Base](#BKMK_msdyn_nonchargeableamount_Base)
- [msdyn_OrderInvoicingProductName](#BKMK_msdyn_OrderInvoicingProductName)
- [msdyn_ProjectName](#BKMK_msdyn_ProjectName)
- [msdyn_WorkOrderIdName](#BKMK_msdyn_WorkOrderIdName)
- [msdyn_WorkOrderProductIdName](#BKMK_msdyn_WorkOrderProductIdName)
- [msdyn_WorkOrderServiceIdName](#BKMK_msdyn_WorkOrderServiceIdName)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PricePerUnit_Base](#BKMK_PricePerUnit_Base)
- [ProductIdName](#BKMK_ProductIdName)
- [SalesRepIdName](#BKMK_SalesRepIdName)
- [SalesRepIdYomiName](#BKMK_SalesRepIdYomiName)
- [Tax_Base](#BKMK_Tax_Base)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [UoMIdName](#BKMK_UoMIdName)
- [VersionNumber](#BKMK_VersionNumber)
- [VolumeDiscountAmount](#BKMK_VolumeDiscountAmount)
- [VolumeDiscountAmount_Base](#BKMK_VolumeDiscountAmount_Base)


### <a name="BKMK_BaseAmount_Base"></a> BaseAmount_Base

**Description**: Value of the Amount in base currency.<br />
**DisplayName**: Amount (Base)<br />
**LogicalName**: baseamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
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
**RequiredLevel**: None<br />
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
**Format**: DateOnly


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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ExtendedAmount_Base"></a> ExtendedAmount_Base

**Description**: Value of the Extended Amount in base currency.<br />
**DisplayName**: Extended Amount (Base)<br />
**LogicalName**: extendedamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_InvoiceIdName"></a> InvoiceIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: invoiceidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_InvoiceIsPriceLocked"></a> InvoiceIsPriceLocked

**Description**: Information about whether invoice product pricing is locked.<br />
**DisplayName**: Invoice Is Price Locked<br />
**LogicalName**: invoiceispricelocked<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_InvoiceStateCode"></a> InvoiceStateCode

**Description**: Status of the invoice product.<br />
**DisplayName**: Invoice Status<br />
**LogicalName**: invoicestatecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:




### <a name="BKMK_ManualDiscountAmount_Base"></a> ManualDiscountAmount_Base

**Description**: Value of the Manual Discount in base currency.<br />
**DisplayName**: Manual Discount (Base)<br />
**LogicalName**: manualdiscountamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
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
**RequiredLevel**: None<br />
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
**Format**: DateOnly


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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AgreementInvoiceProductName"></a> msdyn_AgreementInvoiceProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementinvoiceproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_msdyn_chargeableamount_Base"></a> msdyn_chargeableamount_Base

**Added by**: Project Service Automation Solution<br />
**Description**: Value of the Chargeable Amount in base currency.<br />
**DisplayName**: Chargeable Amount (Base)<br />
**LogicalName**: msdyn_chargeableamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_complimentaryamount_Base"></a> msdyn_complimentaryamount_Base

**Added by**: Project Service Automation Solution<br />
**Description**: Value of the Complimentary Amount in base currency.<br />
**DisplayName**: Complimentary Amount (Base)<br />
**LogicalName**: msdyn_complimentaryamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_contractlineamount_Base"></a> msdyn_contractlineamount_Base

**Added by**: Project Service Automation Solution<br />
**Description**: Value of the project contract line amount in base currency.<br />
**DisplayName**: Contract Line Amount (Base)<br />
**LogicalName**: msdyn_contractlineamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_CurrencyName"></a> msdyn_CurrencyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_currencyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_invoicedtilldate_Base"></a> msdyn_invoicedtilldate_Base

**Added by**: Project Service Automation Solution<br />
**Description**: Value of the Amount Previously Invoiced in base currency.<br />
**DisplayName**: Amount Previously Invoiced (Base)<br />
**LogicalName**: msdyn_invoicedtilldate_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_nonchargeableamount_Base"></a> msdyn_nonchargeableamount_Base

**Added by**: Project Service Automation Solution<br />
**Description**: Value of the Non Chargeable Amount in base currency.<br />
**DisplayName**: Non Chargeable Amount (Base)<br />
**LogicalName**: msdyn_nonchargeableamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_OrderInvoicingProductName"></a> msdyn_OrderInvoicingProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_orderinvoicingproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_msdyn_WorkOrderIdName"></a> msdyn_WorkOrderIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workorderidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderProductIdName"></a> msdyn_WorkOrderProductIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workorderproductidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_WorkOrderServiceIdName"></a> msdyn_WorkOrderServiceIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workorderserviceidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


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


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


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
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: 


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
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: 


### <a name="BKMK_PricePerUnit_Base"></a> PricePerUnit_Base

**Description**: Value of the Price Per Unit in base currency.<br />
**DisplayName**: Price Per Unit (Base)<br />
**LogicalName**: priceperunit_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 1


### <a name="BKMK_ProductIdName"></a> ProductIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: productidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SalesRepIdName"></a> SalesRepIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: salesrepidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SalesRepIdYomiName"></a> SalesRepIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: salesrepidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Tax_Base"></a> Tax_Base

**Description**: Value of the Tax in base currency.<br />
**DisplayName**: Tax (Base)<br />
**LogicalName**: tax_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


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


### <a name="BKMK_UoMIdName"></a> UoMIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: uomidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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


### <a name="BKMK_VolumeDiscountAmount"></a> VolumeDiscountAmount

**Description**: Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.<br />
**DisplayName**: Volume Discount<br />
**LogicalName**: volumediscountamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_VolumeDiscountAmount_Base"></a> VolumeDiscountAmount_Base

**Description**: Value of the Volume Discount in base currency.<br />
**DisplayName**: Volume Discount (Base)<br />
**LogicalName**: volumediscountamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [InvoiceDetail_SyncErrors](#BKMK_InvoiceDetail_SyncErrors)
- [InvoiceDetail_AsyncOperations](#BKMK_InvoiceDetail_AsyncOperations)
- [invoicedetail_MailboxTrackingFolders](#BKMK_invoicedetail_MailboxTrackingFolders)
- [userentityinstancedata_invoicedetail](#BKMK_userentityinstancedata_invoicedetail)
- [InvoiceDetail_ProcessSessions](#BKMK_InvoiceDetail_ProcessSessions)
- [InvoiceDetail_BulkDeleteFailures](#BKMK_InvoiceDetail_BulkDeleteFailures)
- [invoicedetail_principalobjectattributeaccess](#BKMK_invoicedetail_principalobjectattributeaccess)
- [InvoiceDetail_Dynamicpropertyinstance](#BKMK_InvoiceDetail_Dynamicpropertyinstance)
- [invoicedetail_parent_invoicedetail](#BKMK_invoicedetail_parent_invoicedetail)


### <a name="BKMK_InvoiceDetail_SyncErrors"></a> InvoiceDetail_SyncErrors

Same as syncerror entity [InvoiceDetail_SyncErrors](syncerror.md#BKMK_InvoiceDetail_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: InvoiceDetail_SyncErrors<br />
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


### <a name="BKMK_InvoiceDetail_AsyncOperations"></a> InvoiceDetail_AsyncOperations

Same as asyncoperation entity [InvoiceDetail_AsyncOperations](asyncoperation.md#BKMK_InvoiceDetail_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: InvoiceDetail_AsyncOperations<br />
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


### <a name="BKMK_invoicedetail_MailboxTrackingFolders"></a> invoicedetail_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [invoicedetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_invoicedetail_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: invoicedetail_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_invoicedetail"></a> userentityinstancedata_invoicedetail

Same as userentityinstancedata entity [userentityinstancedata_invoicedetail](userentityinstancedata.md#BKMK_userentityinstancedata_invoicedetail) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_invoicedetail<br />
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


### <a name="BKMK_InvoiceDetail_ProcessSessions"></a> InvoiceDetail_ProcessSessions

Same as processsession entity [InvoiceDetail_ProcessSessions](processsession.md#BKMK_InvoiceDetail_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: InvoiceDetail_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_InvoiceDetail_BulkDeleteFailures"></a> InvoiceDetail_BulkDeleteFailures

Same as bulkdeletefailure entity [InvoiceDetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_InvoiceDetail_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: InvoiceDetail_BulkDeleteFailures<br />
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


### <a name="BKMK_invoicedetail_principalobjectattributeaccess"></a> invoicedetail_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [invoicedetail_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_invoicedetail_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: invoicedetail_principalobjectattributeaccess<br />
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


### <a name="BKMK_InvoiceDetail_Dynamicpropertyinstance"></a> InvoiceDetail_Dynamicpropertyinstance

Same as dynamicpropertyinstance entity [InvoiceDetail_Dynamicpropertyinstance](dynamicpropertyinstance.md#BKMK_InvoiceDetail_Dynamicpropertyinstance) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyinstance<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: InvoiceDetail_Dynamicpropertyinstance<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: Cascade
- **Unshare**: NoCascade


### <a name="BKMK_invoicedetail_parent_invoicedetail"></a> invoicedetail_parent_invoicedetail

Same as invoicedetail entity [invoicedetail_parent_invoicedetail](invoicedetail.md#BKMK_invoicedetail_parent_invoicedetail) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: parentbundleid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: invoicedetail_parent_invoicedetail<br />
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

- [lk_invoicedetailbase_createdby](#BKMK_lk_invoicedetailbase_createdby)
- [lk_invoicedetail_createdonbehalfby](#BKMK_lk_invoicedetail_createdonbehalfby)
- [lk_invoicedetailbase_modifiedby](#BKMK_lk_invoicedetailbase_modifiedby)
- [lk_invoicedetail_modifiedonbehalfby](#BKMK_lk_invoicedetail_modifiedonbehalfby)
- [user_invoicedetail](#BKMK_user_invoicedetail)
- [team_invoicedetail](#BKMK_team_invoicedetail)
- [transactioncurrency_invoicedetail](#BKMK_transactioncurrency_invoicedetail)
- [invoice_details](#BKMK_invoice_details)
- [invoicedetail_parent_invoicedetail](#BKMK_invoicedetail_parent_invoicedetail)
- [product_invoice_details](#BKMK_product_invoice_details)
- [system_user_invoicedetail](#BKMK_system_user_invoicedetail)
- [unit_of_measurement_invoice_details](#BKMK_unit_of_measurement_invoice_details)
- [productAssociation_invoice_details](#BKMK_productAssociation_invoice_details)
- [msdyn_msdyn_project_invoicedetail_Project](#BKMK_msdyn_msdyn_project_invoicedetail_Project)
- [msdyn_msdyn_agreement_invoicedetail_Agreement](#BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement)
- [msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct](#BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct)
- [msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct](#BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct)
- [msdyn_msdyn_workorder_invoicedetail](#BKMK_msdyn_msdyn_workorder_invoicedetail)
- [msdyn_msdyn_workorderproduct_invoicedetail](#BKMK_msdyn_msdyn_workorderproduct_invoicedetail)
- [msdyn_msdyn_workorderservice_invoicedetail](#BKMK_msdyn_msdyn_workorderservice_invoicedetail)
- [msdyn_transactioncurrency_invoicedetail_Currency](#BKMK_msdyn_transactioncurrency_invoicedetail_Currency)


### <a name="BKMK_lk_invoicedetailbase_createdby"></a> lk_invoicedetailbase_createdby

See systemuser Entity [lk_invoicedetailbase_createdby](systemuser.md#BKMK_lk_invoicedetailbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_invoicedetail_createdonbehalfby"></a> lk_invoicedetail_createdonbehalfby

See systemuser Entity [lk_invoicedetail_createdonbehalfby](systemuser.md#BKMK_lk_invoicedetail_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_invoicedetailbase_modifiedby"></a> lk_invoicedetailbase_modifiedby

See systemuser Entity [lk_invoicedetailbase_modifiedby](systemuser.md#BKMK_lk_invoicedetailbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_invoicedetail_modifiedonbehalfby"></a> lk_invoicedetail_modifiedonbehalfby

See systemuser Entity [lk_invoicedetail_modifiedonbehalfby](systemuser.md#BKMK_lk_invoicedetail_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_invoicedetail"></a> user_invoicedetail

See systemuser Entity [user_invoicedetail](systemuser.md#BKMK_user_invoicedetail) One-To-Many relationship.

### <a name="BKMK_team_invoicedetail"></a> team_invoicedetail

See team Entity [team_invoicedetail](team.md#BKMK_team_invoicedetail) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_invoicedetail"></a> transactioncurrency_invoicedetail

See transactioncurrency Entity [transactioncurrency_invoicedetail](transactioncurrency.md#BKMK_transactioncurrency_invoicedetail) One-To-Many relationship.

### <a name="BKMK_invoice_details"></a> invoice_details

See invoice Entity [invoice_details](invoice.md#BKMK_invoice_details) One-To-Many relationship.

### <a name="BKMK_invoicedetail_parent_invoicedetail"></a> invoicedetail_parent_invoicedetail

See invoicedetail Entity [invoicedetail_parent_invoicedetail](invoicedetail.md#BKMK_invoicedetail_parent_invoicedetail) One-To-Many relationship.

### <a name="BKMK_product_invoice_details"></a> product_invoice_details

See product Entity [product_invoice_details](product.md#BKMK_product_invoice_details) One-To-Many relationship.

### <a name="BKMK_system_user_invoicedetail"></a> system_user_invoicedetail

See systemuser Entity [system_user_invoicedetail](systemuser.md#BKMK_system_user_invoicedetail) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_invoice_details"></a> unit_of_measurement_invoice_details

See uom Entity [unit_of_measurement_invoice_details](uom.md#BKMK_unit_of_measurement_invoice_details) One-To-Many relationship.

### <a name="BKMK_productAssociation_invoice_details"></a> productAssociation_invoice_details

See productassociation Entity [productAssociation_invoice_details](productassociation.md#BKMK_productAssociation_invoice_details) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_invoicedetail_Project"></a> msdyn_msdyn_project_invoicedetail_Project

See msdyn_project Entity [msdyn_msdyn_project_invoicedetail_Project](msdyn_project.md#BKMK_msdyn_msdyn_project_invoicedetail_Project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement"></a> msdyn_msdyn_agreement_invoicedetail_Agreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_invoicedetail_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct"></a> msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct

See msdyn_agreementinvoiceproduct Entity [msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct"></a> msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct

See msdyn_orderinvoicingproduct Entity [msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct](msdyn_orderinvoicingproduct.md#BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_invoicedetail"></a> msdyn_msdyn_workorder_invoicedetail

See msdyn_workorder Entity [msdyn_msdyn_workorder_invoicedetail](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_invoicedetail) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderproduct_invoicedetail"></a> msdyn_msdyn_workorderproduct_invoicedetail

See msdyn_workorderproduct Entity [msdyn_msdyn_workorderproduct_invoicedetail](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_invoicedetail) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderservice_invoicedetail"></a> msdyn_msdyn_workorderservice_invoicedetail

See msdyn_workorderservice Entity [msdyn_msdyn_workorderservice_invoicedetail](msdyn_workorderservice.md#BKMK_msdyn_msdyn_workorderservice_invoicedetail) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncurrency_invoicedetail_Currency"></a> msdyn_transactioncurrency_invoicedetail_Currency

See transactioncurrency Entity [msdyn_transactioncurrency_invoicedetail_Currency](transactioncurrency.md#BKMK_msdyn_transactioncurrency_invoicedetail_Currency) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.invoicedetail?text=invoicedetail EntityType" />