---
title: "InvoiceDetail Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the InvoiceDetail entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# InvoiceDetail Entity Reference

Line item in an invoice containing detailed billing information for a product.

**Added by**: Sales Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|CalculatePrice|<xref href="Microsoft.Dynamics.CRM.CalculatePrice?text=CalculatePrice Action" />|<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|
|Create|POST [*org URI*]/api/data/v9.0/invoicedetails<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/invoicedetails(*invoicedetailid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/invoicedetails(*invoicedetailid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/invoicedetails<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/invoicedetails(*invoicedetailid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|InvoiceDetails|
|DisplayCollectionName|Invoice Lines|
|DisplayName|Invoice Line|
|EntitySetName|invoicedetails|
|IsBPFEntity|False|
|LogicalCollectionName|invoicedetails|
|LogicalName|invoicedetail|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|invoicedetailid|
|PrimaryNameAttribute|invoicedetailname|
|SchemaName|InvoiceDetail|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActualDeliveryOn](#BKMK_ActualDeliveryOn)
- [BaseAmount](#BKMK_BaseAmount)
- [Description](#BKMK_Description)
- [ExtendedAmount](#BKMK_ExtendedAmount)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InvoiceDetailId](#BKMK_InvoiceDetailId)
- [InvoiceDetailName](#BKMK_InvoiceDetailName)
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
- [ParentBundleIdRef](#BKMK_ParentBundleIdRef)
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
- [SalesOrderDetailId](#BKMK_SalesOrderDetailId)
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
- [SkipPriceCalculation](#BKMK_SkipPriceCalculation)
- [Tax](#BKMK_Tax)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UoMId](#BKMK_UoMId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WillCall](#BKMK_WillCall)


### <a name="BKMK_ActualDeliveryOn"></a> ActualDeliveryOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the invoiced product was delivered to the customer.|
|DisplayName|Delivered On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualdeliveryon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_BaseAmount"></a> BaseAmount

|Property|Value|
|--------|-----|
|Description|Shows the total price of the invoice product, based on the price per unit, volume discount, and quantity.|
|DisplayName|Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|baseamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the product line item of the invoice.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ExtendedAmount"></a> ExtendedAmount

|Property|Value|
|--------|-----|
|Description|Shows the total amount due for the invoice product, based on the sum of the unit price, quantity, discounts, and tax.|
|DisplayName|Extended Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|extendedamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_InvoiceDetailId"></a> InvoiceDetailId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the invoice product line item.|
|DisplayName|Invoice Product|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|invoicedetailid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_InvoiceDetailName"></a> InvoiceDetailName

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Invoice Detail Name. Added for 1:n Referential relationship|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|invoicedetailname|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_InvoiceId"></a> InvoiceId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the invoice associated with the invoice product line item.|
|DisplayName|Invoice ID|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|invoiceid|
|RequiredLevel|SystemRequired|
|Targets|invoice|
|Type|Lookup|


### <a name="BKMK_IsCopied"></a> IsCopied

|Property|Value|
|--------|-----|
|Description|Select whether the invoice product is copied from another item or data source.|
|DisplayName|Copied|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|iscopied|
|RequiredLevel|None|
|Type|Boolean|

#### IsCopied Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsPriceOverridden"></a> IsPriceOverridden

|Property|Value|
|--------|-----|
|Description|Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the invoice product.|
|DisplayName|Pricing|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ispriceoverridden|
|RequiredLevel|None|
|Type|Boolean|

#### IsPriceOverridden Options

|Value|Label|
|-----|-----|
|1|Override Price|
|0|Use Default|

**DefaultValue**: False



### <a name="BKMK_IsProductOverridden"></a> IsProductOverridden

|Property|Value|
|--------|-----|
|Description|Select whether the product exists in the Microsoft Dynamics 365 product catalog or is a write-in product specific to the parent invoice.|
|DisplayName|Select Product|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|isproductoverridden|
|RequiredLevel|None|
|Type|Boolean|

#### IsProductOverridden Options

|Value|Label|
|-----|-----|
|1|Write In|
|0|Existing|

**DefaultValue**: False



### <a name="BKMK_LineItemNumber"></a> LineItemNumber

|Property|Value|
|--------|-----|
|Description|Type the line item number for the invoice product to easily identify the product in the invoice and make sure it's listed in the correct order.|
|DisplayName|Line Item Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lineitemnumber|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ManualDiscountAmount"></a> ManualDiscountAmount

|Property|Value|
|--------|-----|
|Description|Type the manual discount amount for the invoice product to deduct any negotiated or other savings from the product total.|
|DisplayName|Manual Discount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|manualdiscountamount|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Agreement associated with Invoice Product.|
|DisplayName|Agreement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreement|
|RequiredLevel|None|
|Targets|msdyn_agreement|
|Type|Lookup|


### <a name="BKMK_msdyn_AgreementInvoiceProduct"></a> msdyn_AgreementInvoiceProduct

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Agreement Invoice Product associated with Invoice Product.|
|DisplayName|Agreement Invoice Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementinvoiceproduct|
|RequiredLevel|None|
|Targets|msdyn_agreementinvoiceproduct|
|Type|Lookup|


### <a name="BKMK_msdyn_BillingMethod"></a> msdyn_BillingMethod

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Billing method for the project invoice line. Valid values are Time and Material and Fixed Price|
|DisplayName|Billing Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billingmethod|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_BillingMethod Options

|Value|Label|
|-----|-----|
|192350000|Time and Material|
|192350001|Fixed Price|



### <a name="BKMK_msdyn_chargeableamount"></a> msdyn_chargeableamount

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|The amount from included line details that is chargeable.|
|DisplayName|Chargeable Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_chargeableamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_complimentaryamount"></a> msdyn_complimentaryamount

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|The amount from included line details that is complimentary and won't be charged.|
|DisplayName|Complimentary Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_complimentaryamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ContractLine"></a> msdyn_ContractLine

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|(Deprecated) Shows the project contract line for this invoice line.|
|DisplayName|(Deprecated) Project Contract Line|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contractline|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_contractlineamount"></a> msdyn_contractlineamount

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Amount from the related project contract line if present.|
|DisplayName|Contract Line Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contractlineamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_Currency"></a> msdyn_Currency

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Currency associated with Invoice Product.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_currency|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_msdyn_invoicedtilldate"></a> msdyn_invoicedtilldate

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Amount already invoiced to customer for the same project contract line.|
|DisplayName|Amount Previously Invoiced|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicedtilldate|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Shows the order of this invoice product within the invoice.|
|DisplayName|Line Order|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lineorder|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_LineType"></a> msdyn_LineType

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|The field to distinguish the Invoice lines to be of project service or field service|
|DisplayName|Line Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_linetype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_LineType Options

|Value|Label|
|-----|-----|
|690970000|Project Service Line|
|690970001|Field Service Line|



### <a name="BKMK_msdyn_nonchargeableamount"></a> msdyn_nonchargeableamount

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|The amount from included line details that is non-chargeable.|
|DisplayName|Non Chargeable Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_nonchargeableamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_OrderInvoicingProduct"></a> msdyn_OrderInvoicingProduct

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Order Invoicing Product associated with Invoice Product.|
|DisplayName|Order Invoicing Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_orderinvoicingproduct|
|RequiredLevel|None|
|Targets|msdyn_orderinvoicingproduct|
|Type|Lookup|


### <a name="BKMK_msdyn_Project"></a> msdyn_Project

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Shows the project for this invoice line.|
|DisplayName|Project|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_project|
|RequiredLevel|None|
|Targets|msdyn_project|
|Type|Lookup|


### <a name="BKMK_msdyn_WorkOrderId"></a> msdyn_WorkOrderId

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order associated with Invoice Product.|
|DisplayName|Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderid|
|RequiredLevel|None|
|Targets|msdyn_workorder|
|Type|Lookup|


### <a name="BKMK_msdyn_WorkOrderProductId"></a> msdyn_WorkOrderProductId

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order Product associated with Invoice Product.|
|DisplayName|Work Order Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderproductid|
|RequiredLevel|None|
|Targets|msdyn_workorderproduct|
|Type|Lookup|


### <a name="BKMK_msdyn_WorkOrderServiceId"></a> msdyn_WorkOrderServiceId

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order Service associated with Invoice Product.|
|DisplayName|Work Order Service|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderserviceid|
|RequiredLevel|None|
|Targets|msdyn_workorderservice|
|Type|Lookup|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ParentBundleId"></a> ParentBundleId

|Property|Value|
|--------|-----|
|Description|Choose the parent bundle associated with this product|
|DisplayName|Parent Bundle|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|parentbundleid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ParentBundleIdRef"></a> ParentBundleIdRef

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Choose the parent bundle associated with this product|
|DisplayName|Parent bundle product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parentbundleidref|
|RequiredLevel|None|
|Targets|invoicedetail|
|Type|Lookup|


### <a name="BKMK_PricePerUnit"></a> PricePerUnit

|Property|Value|
|--------|-----|
|Description|Type the price per unit of the invoice product. The default is the value in the price list specified on the parent invoice for existing products.|
|DisplayName|Price Per Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|priceperunit|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_PricingErrorCode"></a> PricingErrorCode

|Property|Value|
|--------|-----|
|Description|Pricing error for the invoice product line item.|
|DisplayName|Pricing Error |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricingerrorcode|
|RequiredLevel|None|
|Type|Picklist|

#### PricingErrorCode Options

|Value|Label|
|-----|-----|
|0|None|
|1|Detail Error|
|2|Missing Price Level|
|3|Inactive Price Level|
|4|Missing Quantity|
|5|Missing Unit Price|
|6|Missing Product|
|7|Invalid Product|
|8|Missing Pricing Code|
|9|Invalid Pricing Code|
|10|Missing UOM|
|11|Product Not In Price Level|
|12|Missing Price Level Amount|
|13|Missing Price Level Percentage|
|14|Missing Price|
|15|Missing Current Cost|
|16|Missing Standard Cost|
|17|Invalid Price Level Amount|
|18|Invalid Price Level Percentage|
|19|Invalid Price|
|20|Invalid Current Cost|
|21|Invalid Standard Cost|
|22|Invalid Rounding Policy|
|23|Invalid Rounding Option|
|24|Invalid Rounding Amount|
|25|Price Calculation Error|
|26|Invalid Discount Type|
|27|Discount Type Invalid State|
|28|Invalid Discount|
|29|Invalid Quantity|
|30|Invalid Pricing Precision|
|31|Missing Product Default UOM|
|32|Missing Product UOM Schedule |
|33|Inactive Discount Type|
|34|Invalid Price Level Currency|
|35|Price Attribute Out Of Range|
|36|Base Currency Attribute Overflow|
|37|Base Currency Attribute Underflow|
|38|Transaction currency is not set for the product price list item|



### <a name="BKMK_ProductAssociationId"></a> ProductAssociationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the product line item association with bundle in the invoice|
|DisplayName|Bundle Item Association|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|productassociationid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ProductDescription"></a> ProductDescription

|Property|Value|
|--------|-----|
|Description|Type a name or description to identify the type of write-in product included in the invoice.|
|DisplayName|Write-In Product|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|productdescription|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|--------|-----|
|Description|Choose the product to include on the invoice.|
|DisplayName|Existing Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|productid|
|RequiredLevel|None|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_ProductName"></a> ProductName

|Property|Value|
|--------|-----|
|Description|Calculated field that will be populated by name and description of the product.|
|DisplayName|Product Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|productname|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProductTypeCode"></a> ProductTypeCode

|Property|Value|
|--------|-----|
|Description|Product Type|
|DisplayName|Product type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|producttypecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ProductTypeCode Options

|Value|Label|
|-----|-----|
|1|Product|
|2|Bundle|
|3|Required Bundle Product|
|4|Optional Bundle Product|
|5|Project-based Service|



### <a name="BKMK_PropertyConfigurationStatus"></a> PropertyConfigurationStatus

|Property|Value|
|--------|-----|
|Description|Status of the property configuration.|
|DisplayName|Property Configuration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|propertyconfigurationstatus|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### PropertyConfigurationStatus Options

|Value|Label|
|-----|-----|
|0|Edit|
|1|Rectify|
|2|Not Configured|



### <a name="BKMK_Quantity"></a> Quantity

|Property|Value|
|--------|-----|
|Description|Type the amount or quantity of the product included in the invoice's total amount due.|
|DisplayName|Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|


### <a name="BKMK_QuantityBackordered"></a> QuantityBackordered

|Property|Value|
|--------|-----|
|Description|Type the amount or quantity of the product that is back ordered for the invoice.|
|DisplayName|Quantity Back Ordered|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quantitybackordered|
|MaxValue|1000000000|
|MinValue|0|
|Precision|5|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_QuantityCancelled"></a> QuantityCancelled

|Property|Value|
|--------|-----|
|Description|Type the amount or quantity of the product that was canceled for the invoice line item.|
|DisplayName|Quantity Canceled|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quantitycancelled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|5|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_QuantityShipped"></a> QuantityShipped

|Property|Value|
|--------|-----|
|Description|Type the amount or quantity of the product that was shipped.|
|DisplayName|Quantity Shipped|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quantityshipped|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|5|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_SalesOrderDetailId"></a> SalesOrderDetailId

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Order Line associated with Invoice Line.|
|DisplayName|Order Product Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salesorderdetailid|
|RequiredLevel|None|
|Targets|salesorderdetail|
|Type|Lookup|


### <a name="BKMK_SalesRepId"></a> SalesRepId

|Property|Value|
|--------|-----|
|Description|Choose the user responsible for the sale of the invoice product.|
|DisplayName|Salesperson|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salesrepid|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_SequenceNumber"></a> SequenceNumber

|Property|Value|
|--------|-----|
|Description|Shows the ID of the data that maintains the sequence.|
|DisplayName|Sequence Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|sequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ShippingTrackingNumber"></a> ShippingTrackingNumber

|Property|Value|
|--------|-----|
|Description|Type a tracking number for shipment of the invoiced product.|
|DisplayName|Shipment Tracking Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shippingtrackingnumber|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_City"></a> ShipTo_City

|Property|Value|
|--------|-----|
|Description|Type the city for the customer's shipping address.|
|DisplayName|Ship To City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Country"></a> ShipTo_Country

|Property|Value|
|--------|-----|
|Description|Type the country or region for the customer's shipping address.|
|DisplayName|Ship To Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Fax"></a> ShipTo_Fax

|Property|Value|
|--------|-----|
|Description|Type the fax number for the customer's shipping address.|
|DisplayName|Ship To Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_FreightTermsCode"></a> ShipTo_FreightTermsCode

|Property|Value|
|--------|-----|
|Description|Select the freight terms to make sure shipping orders are processed correctly.|
|DisplayName|Freight Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_freighttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### ShipTo_FreightTermsCode Options

|Value|Label|
|-----|-----|
|1|FOB|
|2|No Charge|



### <a name="BKMK_ShipTo_Line1"></a> ShipTo_Line1

|Property|Value|
|--------|-----|
|Description|Type the first line of the customer's shipping address.|
|DisplayName|Ship To Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_line1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Line2"></a> ShipTo_Line2

|Property|Value|
|--------|-----|
|Description|Type the second line of the customer's shipping address.|
|DisplayName|Ship To Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_line2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Line3"></a> ShipTo_Line3

|Property|Value|
|--------|-----|
|Description|Type the third line of the shipping address.|
|DisplayName|Ship To Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_line3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Name"></a> ShipTo_Name

|Property|Value|
|--------|-----|
|Description|Type a name for the customer's shipping address, such as "Headquarters" or "Field office",  to identify the address.|
|DisplayName|Ship To Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_name|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_PostalCode"></a> ShipTo_PostalCode

|Property|Value|
|--------|-----|
|Description|Type the ZIP Code or postal code for the shipping address.|
|DisplayName|Ship To ZIP/Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_StateOrProvince"></a> ShipTo_StateOrProvince

|Property|Value|
|--------|-----|
|Description|Type the state or province for the shipping address.|
|DisplayName|Ship To State/Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Telephone"></a> ShipTo_Telephone

|Property|Value|
|--------|-----|
|Description|Type the phone number for the customer's shipping address.|
|DisplayName|Ship To Phone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_telephone|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SkipPriceCalculation"></a> SkipPriceCalculation

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Skip Price Calculation. Used with bulk update and bulk insert operations.|
|DisplayName|Skip Price Calculation|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|skippricecalculation|
|RequiredLevel|None|
|Type|Picklist|

#### SkipPriceCalculation Options

|Value|Label|
|-----|-----|
|0|DoPriceCalcAlways|
|1|SkipPriceCalcOnCreate|
|2|SkipPriceCalcOnUpdate|



### <a name="BKMK_Tax"></a> Tax

|Property|Value|
|--------|-----|
|Description|Type the tax amount for the invoice product.|
|DisplayName|Tax|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|tax|
|MaxValue|1000000000000|
|MinValue|-1000000000000|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_UoMId"></a> UoMId

|Property|Value|
|--------|-----|
|Description|Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.|
|DisplayName|Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|uomid|
|RequiredLevel|None|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_WillCall"></a> WillCall

|Property|Value|
|--------|-----|
|Description|Select whether the invoice product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.|
|DisplayName|Ship To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|willcall|
|RequiredLevel|None|
|Type|Boolean|

#### WillCall Options

|Value|Label|
|-----|-----|
|1|Will Call|
|0|Address|

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
- [SalesOrderDetailIdName](#BKMK_SalesOrderDetailIdName)
- [SalesRepIdName](#BKMK_SalesRepIdName)
- [SalesRepIdYomiName](#BKMK_SalesRepIdYomiName)
- [Tax_Base](#BKMK_Tax_Base)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [UoMIdName](#BKMK_UoMIdName)
- [VersionNumber](#BKMK_VersionNumber)
- [VolumeDiscountAmount](#BKMK_VolumeDiscountAmount)
- [VolumeDiscountAmount_Base](#BKMK_VolumeDiscountAmount_Base)


### <a name="BKMK_BaseAmount_Base"></a> BaseAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Amount in base currency.|
|DisplayName|Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|baseamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ExtendedAmount_Base"></a> ExtendedAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Extended Amount in base currency.|
|DisplayName|Extended Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|extendedamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_InvoiceIdName"></a> InvoiceIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|invoiceidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_InvoiceIsPriceLocked"></a> InvoiceIsPriceLocked

|Property|Value|
|--------|-----|
|Description|Information about whether invoice product pricing is locked.|
|DisplayName|Invoice Is Price Locked|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|invoiceispricelocked|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### InvoiceIsPriceLocked Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_InvoiceStateCode"></a> InvoiceStateCode

|Property|Value|
|--------|-----|
|Description|Status of the invoice product.|
|DisplayName|Invoice Status|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|invoicestatecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### InvoiceStateCode Options

|Value|Label|
|-----|-----|




### <a name="BKMK_ManualDiscountAmount_Base"></a> ManualDiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Manual Discount in base currency.|
|DisplayName|Manual Discount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|manualdiscountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AgreementInvoiceProductName"></a> msdyn_AgreementInvoiceProductName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementinvoiceproductname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AgreementName"></a> msdyn_AgreementName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_chargeableamount_Base"></a> msdyn_chargeableamount_Base

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Value of the Chargeable Amount in base currency.|
|DisplayName|Chargeable Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_chargeableamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_complimentaryamount_Base"></a> msdyn_complimentaryamount_Base

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Value of the Complimentary Amount in base currency.|
|DisplayName|Complimentary Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_complimentaryamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_contractlineamount_Base"></a> msdyn_contractlineamount_Base

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Value of the project contract line amount in base currency.|
|DisplayName|Contract Line Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contractlineamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_CurrencyName"></a> msdyn_CurrencyName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_currencyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_invoicedtilldate_Base"></a> msdyn_invoicedtilldate_Base

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Value of the Amount Previously Invoiced in base currency.|
|DisplayName|Amount Previously Invoiced (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicedtilldate_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_nonchargeableamount_Base"></a> msdyn_nonchargeableamount_Base

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Value of the Non Chargeable Amount in base currency.|
|DisplayName|Non Chargeable Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_nonchargeableamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_OrderInvoicingProductName"></a> msdyn_OrderInvoicingProductName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_orderinvoicingproductname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ProjectName"></a> msdyn_ProjectName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_projectname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderIdName"></a> msdyn_WorkOrderIdName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workorderidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderProductIdName"></a> msdyn_WorkOrderProductIdName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workorderproductidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderServiceIdName"></a> msdyn_WorkOrderServiceIdName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workorderserviceidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|ApplicationRequired|
|Targets||
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|ApplicationRequired|
|Targets||
|Type|Lookup|


### <a name="BKMK_PricePerUnit_Base"></a> PricePerUnit_Base

|Property|Value|
|--------|-----|
|Description|Value of the Price Per Unit in base currency.|
|DisplayName|Price Per Unit (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|priceperunit_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_ProductIdName"></a> ProductIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|productidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SalesOrderDetailIdName"></a> SalesOrderDetailIdName

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|salesorderdetailidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SalesRepIdName"></a> SalesRepIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|salesrepidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SalesRepIdYomiName"></a> SalesRepIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|salesrepidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Tax_Base"></a> Tax_Base

|Property|Value|
|--------|-----|
|Description|Value of the Tax in base currency.|
|DisplayName|Tax (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|tax_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UoMIdName"></a> UoMIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uomidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_VolumeDiscountAmount"></a> VolumeDiscountAmount

|Property|Value|
|--------|-----|
|Description|Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.|
|DisplayName|Volume Discount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|volumediscountamount|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_VolumeDiscountAmount_Base"></a> VolumeDiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Volume Discount in base currency.|
|DisplayName|Volume Discount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|volumediscountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [InvoiceDetail_SyncErrors](#BKMK_InvoiceDetail_SyncErrors)
- [InvoiceDetail_AsyncOperations](#BKMK_InvoiceDetail_AsyncOperations)
- [invoicedetail_MailboxTrackingFolders](#BKMK_invoicedetail_MailboxTrackingFolders)
- [InvoiceDetail_ProcessSessions](#BKMK_InvoiceDetail_ProcessSessions)
- [InvoiceDetail_BulkDeleteFailures](#BKMK_InvoiceDetail_BulkDeleteFailures)
- [invoicedetail_principalobjectattributeaccess](#BKMK_invoicedetail_principalobjectattributeaccess)
- [InvoiceDetail_Dynamicpropertyinstance](#BKMK_InvoiceDetail_Dynamicpropertyinstance)
- [invoicedetail_parent_invoicedetail](#BKMK_invoicedetail_parent_invoicedetail)
- [invoicedetail_parentref_invoicedetail](#BKMK_invoicedetail_parentref_invoicedetail)
- [msdyn_invoicedetail_msdyn_invoicelinetransactio](#BKMK_msdyn_invoicedetail_msdyn_invoicelinetransactio)


### <a name="BKMK_InvoiceDetail_SyncErrors"></a> InvoiceDetail_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [InvoiceDetail_SyncErrors](syncerror.md#BKMK_InvoiceDetail_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|InvoiceDetail_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_InvoiceDetail_AsyncOperations"></a> InvoiceDetail_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [InvoiceDetail_AsyncOperations](asyncoperation.md#BKMK_InvoiceDetail_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|InvoiceDetail_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_invoicedetail_MailboxTrackingFolders"></a> invoicedetail_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [invoicedetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_invoicedetail_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|invoicedetail_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_InvoiceDetail_ProcessSessions"></a> InvoiceDetail_ProcessSessions

**Added by**: System Solution Solution

Same as processsession entity [InvoiceDetail_ProcessSessions](processsession.md#BKMK_InvoiceDetail_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|InvoiceDetail_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_InvoiceDetail_BulkDeleteFailures"></a> InvoiceDetail_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [InvoiceDetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_InvoiceDetail_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|InvoiceDetail_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_invoicedetail_principalobjectattributeaccess"></a> invoicedetail_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [invoicedetail_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_invoicedetail_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|invoicedetail_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_InvoiceDetail_Dynamicpropertyinstance"></a> InvoiceDetail_Dynamicpropertyinstance

Same as dynamicpropertyinstance entity [InvoiceDetail_Dynamicpropertyinstance](dynamicpropertyinstance.md#BKMK_InvoiceDetail_Dynamicpropertyinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyinstance|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|InvoiceDetail_Dynamicpropertyinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: Cascade<br />Unshare: NoCascade|


### <a name="BKMK_invoicedetail_parent_invoicedetail"></a> invoicedetail_parent_invoicedetail

Same as invoicedetail entity [invoicedetail_parent_invoicedetail](invoicedetail.md#BKMK_invoicedetail_parent_invoicedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|parentbundleid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|invoicedetail_parent_invoicedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_invoicedetail_parentref_invoicedetail"></a> invoicedetail_parentref_invoicedetail

**Added by**: Sales Patch Solution

Same as invoicedetail entity [invoicedetail_parentref_invoicedetail](invoicedetail.md#BKMK_invoicedetail_parentref_invoicedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|parentbundleidref|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|invoicedetail_parentref_invoicedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicedetail_msdyn_invoicelinetransactio"></a> msdyn_invoicedetail_msdyn_invoicelinetransactio

**Added by**: Project Service Automation Solution

Same as msdyn_invoicelinetransaction entity [msdyn_invoicedetail_msdyn_invoicelinetransactio](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicedetail_msdyn_invoicelinetransactio) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|msdyn_invoicelineid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicedetail_msdyn_invoicelinetransactio|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

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
- [msdyn_salesorderdetail_invoicedetail](#BKMK_msdyn_salesorderdetail_invoicedetail)
- [invoicedetail_parentref_invoicedetail](#BKMK_invoicedetail_parentref_invoicedetail)
- [msdyn_msdyn_project_invoicedetail_Project](#BKMK_msdyn_msdyn_project_invoicedetail_Project)
- [msdyn_msdyn_agreement_invoicedetail_Agreement](#BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement)
- [msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct](#BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct)
- [msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct](#BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct)
- [msdyn_msdyn_workorder_invoicedetail](#BKMK_msdyn_msdyn_workorder_invoicedetail)
- [msdyn_msdyn_workorderproduct_invoicedetail](#BKMK_msdyn_msdyn_workorderproduct_invoicedetail)
- [msdyn_msdyn_workorderservice_invoicedetail](#BKMK_msdyn_msdyn_workorderservice_invoicedetail)
- [msdyn_transactioncurrency_invoicedetail_Currency](#BKMK_msdyn_transactioncurrency_invoicedetail_Currency)


### <a name="BKMK_lk_invoicedetailbase_createdby"></a> lk_invoicedetailbase_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_invoicedetailbase_createdby](systemuser.md#BKMK_lk_invoicedetailbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_invoicedetail_createdonbehalfby"></a> lk_invoicedetail_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_invoicedetail_createdonbehalfby](systemuser.md#BKMK_lk_invoicedetail_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_invoicedetailbase_modifiedby"></a> lk_invoicedetailbase_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_invoicedetailbase_modifiedby](systemuser.md#BKMK_lk_invoicedetailbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_invoicedetail_modifiedonbehalfby"></a> lk_invoicedetail_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_invoicedetail_modifiedonbehalfby](systemuser.md#BKMK_lk_invoicedetail_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_invoicedetail"></a> user_invoicedetail

**Added by**: System Solution Solution

See systemuser Entity [user_invoicedetail](systemuser.md#BKMK_user_invoicedetail) One-To-Many relationship.

### <a name="BKMK_team_invoicedetail"></a> team_invoicedetail

**Added by**: System Solution Solution

See team Entity [team_invoicedetail](team.md#BKMK_team_invoicedetail) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_invoicedetail"></a> transactioncurrency_invoicedetail

**Added by**: System Solution Solution

See transactioncurrency Entity [transactioncurrency_invoicedetail](transactioncurrency.md#BKMK_transactioncurrency_invoicedetail) One-To-Many relationship.

### <a name="BKMK_invoice_details"></a> invoice_details

See invoice Entity [invoice_details](invoice.md#BKMK_invoice_details) One-To-Many relationship.

### <a name="BKMK_invoicedetail_parent_invoicedetail"></a> invoicedetail_parent_invoicedetail

See invoicedetail Entity [invoicedetail_parent_invoicedetail](invoicedetail.md#BKMK_invoicedetail_parent_invoicedetail) One-To-Many relationship.

### <a name="BKMK_product_invoice_details"></a> product_invoice_details

**Added by**: Product Management Solution

See product Entity [product_invoice_details](product.md#BKMK_product_invoice_details) One-To-Many relationship.

### <a name="BKMK_system_user_invoicedetail"></a> system_user_invoicedetail

**Added by**: System Solution Solution

See systemuser Entity [system_user_invoicedetail](systemuser.md#BKMK_system_user_invoicedetail) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_invoice_details"></a> unit_of_measurement_invoice_details

**Added by**: Product Management Solution

See uom Entity [unit_of_measurement_invoice_details](uom.md#BKMK_unit_of_measurement_invoice_details) One-To-Many relationship.

### <a name="BKMK_productAssociation_invoice_details"></a> productAssociation_invoice_details

**Added by**: Product Management Solution

See productassociation Entity [productAssociation_invoice_details](productassociation.md#BKMK_productAssociation_invoice_details) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorderdetail_invoicedetail"></a> msdyn_salesorderdetail_invoicedetail

See salesorderdetail Entity [msdyn_salesorderdetail_invoicedetail](salesorderdetail.md#BKMK_msdyn_salesorderdetail_invoicedetail) One-To-Many relationship.

### <a name="BKMK_invoicedetail_parentref_invoicedetail"></a> invoicedetail_parentref_invoicedetail

See invoicedetail Entity [invoicedetail_parentref_invoicedetail](invoicedetail.md#BKMK_invoicedetail_parentref_invoicedetail) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_invoicedetail_Project"></a> msdyn_msdyn_project_invoicedetail_Project

**Added by**: Project Service Automation Solution

See msdyn_project Entity [msdyn_msdyn_project_invoicedetail_Project](msdyn_project.md#BKMK_msdyn_msdyn_project_invoicedetail_Project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement"></a> msdyn_msdyn_agreement_invoicedetail_Agreement

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_msdyn_agreement_invoicedetail_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct"></a> msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct"></a> msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct

**Added by**: Field Service Solution

See msdyn_orderinvoicingproduct Entity [msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct](msdyn_orderinvoicingproduct.md#BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_invoicedetail"></a> msdyn_msdyn_workorder_invoicedetail

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_msdyn_workorder_invoicedetail](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_invoicedetail) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderproduct_invoicedetail"></a> msdyn_msdyn_workorderproduct_invoicedetail

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_msdyn_workorderproduct_invoicedetail](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_invoicedetail) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderservice_invoicedetail"></a> msdyn_msdyn_workorderservice_invoicedetail

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_msdyn_workorderservice_invoicedetail](msdyn_workorderservice.md#BKMK_msdyn_msdyn_workorderservice_invoicedetail) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncurrency_invoicedetail_Currency"></a> msdyn_transactioncurrency_invoicedetail_Currency

**Added by**: System Solution Solution

See transactioncurrency Entity [msdyn_transactioncurrency_invoicedetail_Currency](transactioncurrency.md#BKMK_msdyn_transactioncurrency_invoicedetail_Currency) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.invoicedetail?text=invoicedetail EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]