---
title: "Order Product (SalesOrderDetail)  table/entity reference (Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Order Product (SalesOrderDetail)  table/entity."
ms.date: 02/17/2023
ms.service: dynamics-365-sales
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "udaykirang"
ms.author: "udag"
manager: "shujoshi"
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---

# Order Product (SalesOrderDetail)  table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Line item in a sales order.

**Added by**: Sales Solution


## Messages

|Message|SDK Assembly|
|-|-|
|CalculatePrice|<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SalesOrderDetails|
|DisplayCollectionName|Order Products|
|DisplayName|Order Product|
|EntitySetName|salesorderdetails|
|IsBPFEntity|False|
|LogicalCollectionName|salesorderdetails|
|LogicalName|salesorderdetail|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|salesorderdetailid|
|PrimaryNameAttribute|salesorderdetailname|
|SchemaName|SalesOrderDetail|

<a name="writable-attributes"></a>

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BaseAmount](#BKMK_BaseAmount)
- [Description](#BKMK_Description)
- [ExtendedAmount](#BKMK_ExtendedAmount)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCopied](#BKMK_IsCopied)
- [IsPriceOverridden](#BKMK_IsPriceOverridden)
- [IsProductOverridden](#BKMK_IsProductOverridden)
- [LineItemNumber](#BKMK_LineItemNumber)
- [ManualDiscountAmount](#BKMK_ManualDiscountAmount)
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
- [QuoteDetailId](#BKMK_QuoteDetailId)
- [RequestDeliveryBy](#BKMK_RequestDeliveryBy)
- [SalesOrderDetailId](#BKMK_SalesOrderDetailId)
- [SalesOrderDetailName](#BKMK_SalesOrderDetailName)
- [SalesOrderId](#BKMK_SalesOrderId)
- [SalesRepId](#BKMK_SalesRepId)
- [SequenceNumber](#BKMK_SequenceNumber)
- [ShipTo_AddressId](#BKMK_ShipTo_AddressId)
- [ShipTo_City](#BKMK_ShipTo_City)
- [ShipTo_ContactName](#BKMK_ShipTo_ContactName)
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


### <a name="BKMK_BaseAmount"></a> BaseAmount

|Property|Value|
|--------|-----|
|Description|Shows the total price of the order product, based on the price per unit, volume discount, and quantity.|
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
|Description|Type additional information to describe the order product, such as manufacturing details or acceptable substitutions.|
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
|Description|Shows the total amount due for the order product, based on the sum of the unit price, quantity, discounts, and tax.|
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


### <a name="BKMK_IsCopied"></a> IsCopied

|Property|Value|
|--------|-----|
|Description|Select whether the invoice line item is copied from another item or data source.|
|DisplayName|Copied|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|iscopied|
|RequiredLevel|None|
|Type|Boolean|

#### IsCopied Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_IsPriceOverridden"></a> IsPriceOverridden

|Property|Value|
|--------|-----|
|Description|Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the order product.|
|DisplayName|Pricing|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ispriceoverridden|
|RequiredLevel|None|
|Type|Boolean|

#### IsPriceOverridden Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Override Price||
|0|Use Default||

**DefaultValue**: 0



### <a name="BKMK_IsProductOverridden"></a> IsProductOverridden

|Property|Value|
|--------|-----|
|Description|Select whether the product exists in the Microsoft Dynamics 365 product catalog or is a write-in product specific to the order.|
|DisplayName|Select Product|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|isproductoverridden|
|RequiredLevel|None|
|Type|Boolean|

#### IsProductOverridden Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Write In||
|0|Existing||

**DefaultValue**: 0



### <a name="BKMK_LineItemNumber"></a> LineItemNumber

|Property|Value|
|--------|-----|
|Description|Type the line item number for the order product to easily identify the product in the order and make sure it's listed in the correct sequence.|
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
|Description|Type the manual discount amount for the order product to deduct any negotiated or other savings from the product total on the order.|
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
|Targets|salesorderdetail|
|Type|Lookup|


### <a name="BKMK_PricePerUnit"></a> PricePerUnit

|Property|Value|
|--------|-----|
|Description|Type the price per unit of the order product. The default is the value in the price list specified on the order for existing products.|
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
|Description|Select the type of pricing error, such as a missing or invalid product, or missing quantity.|
|DisplayName|Pricing Error |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricingerrorcode|
|RequiredLevel|None|
|Type|Picklist|

#### PricingErrorCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|None||
|1|Detail Error||
|2|Missing Price Level||
|3|Inactive Price Level||
|4|Missing Quantity||
|5|Missing Unit Price||
|6|Missing Product||
|7|Invalid Product||
|8|Missing Pricing Code||
|9|Invalid Pricing Code||
|10|Missing UOM||
|11|Product Not In Price Level||
|12|Missing Price Level Amount||
|13|Missing Price Level Percentage||
|14|Missing Price||
|15|Missing Current Cost||
|16|Missing Standard Cost||
|17|Invalid Price Level Amount||
|18|Invalid Price Level Percentage||
|19|Invalid Price||
|20|Invalid Current Cost||
|21|Invalid Standard Cost||
|22|Invalid Rounding Policy||
|23|Invalid Rounding Option||
|24|Invalid Rounding Amount||
|25|Price Calculation Error||
|26|Invalid Discount Type||
|27|Discount Type Invalid State||
|28|Invalid Discount||
|29|Invalid Quantity||
|30|Invalid Pricing Precision||
|31|Missing Product Default UOM||
|32|Missing Product UOM Schedule ||
|33|Inactive Discount Type||
|34|Invalid Price Level Currency||
|35|Price Attribute Out Of Range||
|36|Base Currency Attribute Overflow||
|37|Base Currency Attribute Underflow||
|38|Transaction currency is not set for the product price list item||



### <a name="BKMK_ProductAssociationId"></a> ProductAssociationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the product line item association with bundle in the sales order|
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
|Description|Type a name or description to identify the type of write-in product included in the order.|
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
|Description|Choose the product to include on the order to link the product's pricing and other information to the parent order.|
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
|IsValidForForm|True|
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

#### ProductTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Product||
|2|Bundle||
|3|Required Bundle Product||
|4|Optional Bundle Product||
|5|Project-based Service||



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

#### PropertyConfigurationStatus Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Edit||
|1|Rectify||
|2|Not Configured||



### <a name="BKMK_Quantity"></a> Quantity

|Property|Value|
|--------|-----|
|Description|Type the amount or quantity of the product ordered by the customer.|
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
|Description|Type the amount or quantity of the product that is back ordered for the order.|
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
|Description|Type the amount or quantity of the product that was canceled.|
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
|Description|Type the amount or quantity of the product that was shipped for the order.|
|DisplayName|Quantity Shipped|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quantityshipped|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|5|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_QuoteDetailId"></a> QuoteDetailId

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Quote Line associated with Order Line.|
|DisplayName|Quote Product Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quotedetailid|
|RequiredLevel|None|
|Targets|quotedetail|
|Type|Lookup|


### <a name="BKMK_RequestDeliveryBy"></a> RequestDeliveryBy

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the delivery date requested by the customer for the order product.|
|DisplayName|Requested Delivery Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requestdeliveryby|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SalesOrderDetailId"></a> SalesOrderDetailId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the product specified in the order.|
|DisplayName|Order Product|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|salesorderdetailid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SalesOrderDetailName"></a> SalesOrderDetailName

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Sales Order Detail Name. Added for 1:n referential relationship (internal purposes only)|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salesorderdetailname|
|MaxLength|500|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_SalesOrderId"></a> SalesOrderId

|Property|Value|
|--------|-----|
|Description|Shows the order for the product. The ID is used to link product pricing and other details to the total amounts and other information on the order.|
|DisplayName|Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salesorderid|
|RequiredLevel|SystemRequired|
|Targets|salesorder|
|Type|Lookup|


### <a name="BKMK_SalesRepId"></a> SalesRepId

|Property|Value|
|--------|-----|
|Description|Choose the user responsible for the sale of the order product.|
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


### <a name="BKMK_ShipTo_AddressId"></a> ShipTo_AddressId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the shipping address.|
|DisplayName|Ship To Address ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|shipto_addressid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


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


### <a name="BKMK_ShipTo_ContactName"></a> ShipTo_ContactName

|Property|Value|
|--------|-----|
|Description|Type the primary contact name at the customer's shipping address.|
|DisplayName|Ship To Contact Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_contactname|
|MaxLength|150|
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

#### ShipTo_FreightTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|FOB||
|2|No Charge||



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
|Description|Skip the price calculation|
|DisplayName|Skip Price Calculation|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|skippricecalculation|
|RequiredLevel|None|
|Type|Picklist|

#### SkipPriceCalculation Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|DoPriceCalcAlways||
|1|SkipPriceCalcOnCreate||
|2|SkipPriceCalcOnUpdate||
|3|SkipPriceCalcOnUpSert||



### <a name="BKMK_Tax"></a> Tax

|Property|Value|
|--------|-----|
|Description|Type the tax amount for the order product.|
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
|Description|Select whether the order product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.|
|DisplayName|Ship To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|willcall|
|RequiredLevel|None|
|Type|Boolean|

#### WillCall Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Will Call||
|0|Address||

**DefaultValue**: 0


<a name="read-only-attributes"></a>

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

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
- [ManualDiscountAmount_Base](#BKMK_ManualDiscountAmount_Base)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PricePerUnit_Base](#BKMK_PricePerUnit_Base)
- [ProductIdName](#BKMK_ProductIdName)
- [ProductNumber](#BKMK_ProductNumber)
- [QuoteDetailIdName](#BKMK_QuoteDetailIdName)
- [SalesOrderIdName](#BKMK_SalesOrderIdName)
- [SalesOrderIsPriceLocked](#BKMK_SalesOrderIsPriceLocked)
- [SalesOrderStateCode](#BKMK_SalesOrderStateCode)
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
|MinValue|0.000000000001|
|Precision|12|
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


### <a name="BKMK_ProductNumber"></a> ProductNumber

**Added by**: Sales Patch Version 3 Solution

|Property|Value|
|--------|-----|
|Description|User-defined product ID.|
|DisplayName|Product Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|productnumber|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_QuoteDetailIdName"></a> QuoteDetailIdName

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|quotedetailidname|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SalesOrderIdName"></a> SalesOrderIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|salesorderidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SalesOrderIsPriceLocked"></a> SalesOrderIsPriceLocked

|Property|Value|
|--------|-----|
|Description|Tells whether product pricing is locked for the order.|
|DisplayName|Order Is Price Locked|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|salesorderispricelocked|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### SalesOrderIsPriceLocked Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_SalesOrderStateCode"></a> SalesOrderStateCode

|Property|Value|
|--------|-----|
|Description|Shows the status of the order that the order detail is associated with.|
|DisplayName|Order Status|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|salesorderstatecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### SalesOrderStateCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|




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

- [SalesOrderDetail_Dynamicpropertyinstance](#BKMK_SalesOrderDetail_Dynamicpropertyinstance)
- [salesorderdetail_parent_salesorderdetail](#BKMK_salesorderdetail_parent_salesorderdetail)
- [msdyn_salesorderdetail_invoicedetail](#BKMK_msdyn_salesorderdetail_invoicedetail)
- [salesorderdetail_parentref_salesorderdetail](#BKMK_salesorderdetail_parentref_salesorderdetail)


### <a name="BKMK_SalesOrderDetail_Dynamicpropertyinstance"></a> SalesOrderDetail_Dynamicpropertyinstance

Same as the [SalesOrderDetail_Dynamicpropertyinstance](dynamicpropertyinstance.md#BKMK_SalesOrderDetail_Dynamicpropertyinstance) many-to-one relationship for the [dynamicpropertyinstance](dynamicpropertyinstance.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyinstance|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|SalesOrderDetail_Dynamicpropertyinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: Cascade<br />Unshare: NoCascade|


### <a name="BKMK_salesorderdetail_parent_salesorderdetail"></a> salesorderdetail_parent_salesorderdetail

Same as the [salesorderdetail_parent_salesorderdetail](salesorderdetail.md#BKMK_salesorderdetail_parent_salesorderdetail) many-to-one relationship for the [salesorderdetail](salesorderdetail.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|parentbundleid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|salesorderdetail_parent_salesorderdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_salesorderdetail_invoicedetail"></a> msdyn_salesorderdetail_invoicedetail

**Added by**: Sales Patch Solution

Same as the [msdyn_salesorderdetail_invoicedetail](invoicedetail.md#BKMK_msdyn_salesorderdetail_invoicedetail) many-to-one relationship for the [invoicedetail](invoicedetail.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|salesorderdetailid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|msdyn_salesorderdetail_invoicedetail|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_salesorderdetail_parentref_salesorderdetail"></a> salesorderdetail_parentref_salesorderdetail

**Added by**: Sales Patch Solution

Same as the [salesorderdetail_parentref_salesorderdetail](salesorderdetail.md#BKMK_salesorderdetail_parentref_salesorderdetail) many-to-one relationship for the [salesorderdetail](salesorderdetail.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|parentbundleidref|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|salesorderdetail_parentref_salesorderdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [product_order_details](#BKMK_product_order_details)
- [order_details](#BKMK_order_details)
- [salesorderdetail_parent_salesorderdetail](#BKMK_salesorderdetail_parent_salesorderdetail)
- [unit_of_measurement_order_details](#BKMK_unit_of_measurement_order_details)
- [productAssociation_salesorder_details](#BKMK_productAssociation_salesorder_details)
- [msdyn_quotedetail_salesorderdetail](#BKMK_msdyn_quotedetail_salesorderdetail)
- [salesorderdetail_parentref_salesorderdetail](#BKMK_salesorderdetail_parentref_salesorderdetail)


### <a name="BKMK_product_order_details"></a> product_order_details

**Added by**: Product Management Solution

See the [product_order_details](product.md#BKMK_product_order_details) one-to-many relationship for the [product](product.md) table/entity.

### <a name="BKMK_order_details"></a> order_details

See the [order_details](salesorder.md#BKMK_order_details) one-to-many relationship for the [salesorder](salesorder.md) table/entity.

### <a name="BKMK_salesorderdetail_parent_salesorderdetail"></a> salesorderdetail_parent_salesorderdetail

See the [salesorderdetail_parent_salesorderdetail](salesorderdetail.md#BKMK_salesorderdetail_parent_salesorderdetail) one-to-many relationship for the [salesorderdetail](salesorderdetail.md) table/entity.

### <a name="BKMK_unit_of_measurement_order_details"></a> unit_of_measurement_order_details

**Added by**: Product Management Solution

See the [unit_of_measurement_order_details](uom.md#BKMK_unit_of_measurement_order_details) one-to-many relationship for the [uom](uom.md) table/entity.

### <a name="BKMK_productAssociation_salesorder_details"></a> productAssociation_salesorder_details

**Added by**: Product Management Solution

See the [productAssociation_salesorder_details](productassociation.md#BKMK_productAssociation_salesorder_details) one-to-many relationship for the [productassociation](productassociation.md) table/entity.

### <a name="BKMK_msdyn_quotedetail_salesorderdetail"></a> msdyn_quotedetail_salesorderdetail

See the [msdyn_quotedetail_salesorderdetail](quotedetail.md#BKMK_msdyn_quotedetail_salesorderdetail) one-to-many relationship for the [quotedetail](quotedetail.md) table/entity.

### <a name="BKMK_salesorderdetail_parentref_salesorderdetail"></a> salesorderdetail_parentref_salesorderdetail

See the [salesorderdetail_parentref_salesorderdetail](salesorderdetail.md#BKMK_salesorderdetail_parentref_salesorderdetail) one-to-many relationship for the [salesorderdetail](salesorderdetail.md) table/entity.

### See also

[About the table reference](../about-entity-reference.md)<br />
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)<br />