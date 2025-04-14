---
title: "Quote Product (QuoteDetail) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Quote Product (QuoteDetail) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Quote Product (QuoteDetail) table/entity reference (Microsoft Dynamics 365)

Product line item in a quote. The details include such information as product ID, description, quantity, and cost.

## Messages

The following table lists the messages for the Quote Product (QuoteDetail) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /quotedetails<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /quotedetails(*quotedetailid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /quotedetails(*quotedetailid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /quotedetails<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /quotedetails(*quotedetailid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /quotedetails(*quotedetailid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Quote Product (QuoteDetail) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `CalculatePrice`|<xref:Microsoft.Dynamics.CRM.CalculatePrice?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|

## Properties

The following table lists selected properties for the Quote Product (QuoteDetail) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Quote Product** |
| **DisplayCollectionName** | **Quote Products** |
| **SchemaName** | `QuoteDetail` |
| **CollectionSchemaName** | `QuoteDetails` |
| **EntitySetName** | `quotedetails`|
| **LogicalName** | `quotedetail` |
| **LogicalCollectionName** | `quotedetails` |
| **PrimaryIdAttribute** | `quotedetailid` |
| **PrimaryNameAttribute** |`quotedetailname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BaseAmount](#BKMK_BaseAmount)
- [Description](#BKMK_Description)
- [ExtendedAmount](#BKMK_ExtendedAmount)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
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
- [QuoteCreationMethod](#BKMK_QuoteCreationMethod)
- [QuoteDetailId](#BKMK_QuoteDetailId)
- [QuoteDetailName](#BKMK_QuoteDetailName)
- [QuoteId](#BKMK_QuoteId)
- [RequestDeliveryBy](#BKMK_RequestDeliveryBy)
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
|---|---|
|Description|**Shows the total price of the quote product, based on the price per unit, volume discount, and quantity.**|
|DisplayName|**Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`baseamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the quote product, such as manufacturing details or acceptable substitutions.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_ExtendedAmount"></a> ExtendedAmount

|Property|Value|
|---|---|
|Description|**Shows the total amount due for the quote product, based on the sum of the unit price, quantity, discounts ,and tax.**|
|DisplayName|**Extended Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`extendedamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_IsPriceOverridden"></a> IsPriceOverridden

|Property|Value|
|---|---|
|Description|**Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the quote product.**|
|DisplayName|**Price Overridden**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ispriceoverridden`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`quotedetail_ispriceoverridden`|
|DefaultValue|False|
|True Label|Override Price|
|False Label|Use Default|

### <a name="BKMK_IsProductOverridden"></a> IsProductOverridden

|Property|Value|
|---|---|
|Description|**Select whether the product exists in the Microsoft Dynamics 365 product catalog or is a write-in product specific to the quote.**|
|DisplayName|**Select Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isproductoverridden`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`quotedetail_isproductoverridden`|
|DefaultValue|False|
|True Label|Write In|
|False Label|Existing|

### <a name="BKMK_LineItemNumber"></a> LineItemNumber

|Property|Value|
|---|---|
|Description|**Type the line item number for the quote product to easily identify the product in the quote and make sure it's listed in the correct order.**|
|DisplayName|**Line Item Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lineitemnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_ManualDiscountAmount"></a> ManualDiscountAmount

|Property|Value|
|---|---|
|Description|**Type the manual discount amount for the quote product to deduct any negotiated or other savings from the product total on the quote.**|
|DisplayName|**Manual Discount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`manualdiscountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ParentBundleId"></a> ParentBundleId

|Property|Value|
|---|---|
|Description|**Choose the parent bundle associated with this product**|
|DisplayName|**Parent Bundle**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`parentbundleid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ParentBundleIdRef"></a> ParentBundleIdRef

|Property|Value|
|---|---|
|Description|**Choose the parent bundle associated with this product**|
|DisplayName|**Parent bundle product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`parentbundleidref`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|quotedetail|

### <a name="BKMK_PricePerUnit"></a> PricePerUnit

|Property|Value|
|---|---|
|Description|**Type the price per unit of the quote product. The default is to the value in the price list specified on the quote for existing products.**|
|DisplayName|**Price Per Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`priceperunit`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_PricingErrorCode"></a> PricingErrorCode

|Property|Value|
|---|---|
|Description|**Select the type of pricing error, such as a missing or invalid product, or missing quantity.**|
|DisplayName|**Pricing Error**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`pricingerrorcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`qooi_pricingerrorcode`|

#### PricingErrorCode Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**Detail Error**|
|2|**Missing Price Level**|
|3|**Inactive Price Level**|
|4|**Missing Quantity**|
|5|**Missing Unit Price**|
|6|**Missing Product**|
|7|**Invalid Product**|
|8|**Missing Pricing Code**|
|9|**Invalid Pricing Code**|
|10|**Missing UOM**|
|11|**Product Not In Price Level**|
|12|**Missing Price Level Amount**|
|13|**Missing Price Level Percentage**|
|14|**Missing Price**|
|15|**Missing Current Cost**|
|16|**Missing Standard Cost**|
|17|**Invalid Price Level Amount**|
|18|**Invalid Price Level Percentage**|
|19|**Invalid Price**|
|20|**Invalid Current Cost**|
|21|**Invalid Standard Cost**|
|22|**Invalid Rounding Policy**|
|23|**Invalid Rounding Option**|
|24|**Invalid Rounding Amount**|
|25|**Price Calculation Error**|
|26|**Invalid Discount Type**|
|27|**Discount Type Invalid State**|
|28|**Invalid Discount**|
|29|**Invalid Quantity**|
|30|**Invalid Pricing Precision**|
|31|**Missing Product Default UOM**|
|32|**Missing Product UOM Schedule**|
|33|**Inactive Discount Type**|
|34|**Invalid Price Level Currency**|
|35|**Price Attribute Out Of Range**|
|36|**Base Currency Attribute Overflow**|
|37|**Base Currency Attribute Underflow**|
|38|**Transaction currency is not set for the product price list item**|

### <a name="BKMK_ProductAssociationId"></a> ProductAssociationId

|Property|Value|
|---|---|
|Description|**Unique identifier of the product line item association with bundle in the quote**|
|DisplayName|**Bundle Item Association**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productassociationid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ProductDescription"></a> ProductDescription

|Property|Value|
|---|---|
|Description|**Type a name or description to identify the type of write-in product included in the quote.**|
|DisplayName|**Write-In Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productdescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|---|---|
|Description|**Choose the product to include on the quote to link the product's pricing and other information to the quote.**|
|DisplayName|**Existing Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_ProductName"></a> ProductName

|Property|Value|
|---|---|
|Description|**Calculated field that will be populated by name and description of the product.**|
|DisplayName|**Product Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_ProductTypeCode"></a> ProductTypeCode

|Property|Value|
|---|---|
|Description|**Product Type**|
|DisplayName|**Product type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`producttypecode`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`qooiproduct_producttype`|

#### ProductTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Product**|
|2|**Bundle**|
|3|**Required Bundle Product**|
|4|**Optional Bundle Product**|
|5|**Project-based Service**|

### <a name="BKMK_PropertyConfigurationStatus"></a> PropertyConfigurationStatus

|Property|Value|
|---|---|
|Description|**Status of the property configuration.**|
|DisplayName|**Property Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`propertyconfigurationstatus`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|2|
|GlobalChoiceName|`qooiproduct_propertiesconfigurationstatus`|

#### PropertyConfigurationStatus Choices/Options

|Value|Label|
|---|---|
|0|**Edit**|
|1|**Rectify**|
|2|**Not Configured**|

### <a name="BKMK_Quantity"></a> Quantity

|Property|Value|
|---|---|
|Description|**Type the amount or quantity of the product requested by the customer.**|
|DisplayName|**Quantity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`quantity`|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|SourceTypeMask|0|

### <a name="BKMK_QuoteCreationMethod"></a> QuoteCreationMethod

|Property|Value|
|---|---|
|Description||
|DisplayName|**Creation Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`quotecreationmethod`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|776160000|
|GlobalChoiceName|`quotecreationmethod`|

#### QuoteCreationMethod Choices/Options

|Value|Label|
|---|---|
|776160000|**Unknown**|
|776160001|**Revision**|

### <a name="BKMK_QuoteDetailId"></a> QuoteDetailId

|Property|Value|
|---|---|
|Description|**Unique identifier of the product line item in the quote.**|
|DisplayName|**Quote Product**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`quotedetailid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_QuoteDetailName"></a> QuoteDetailName

|Property|Value|
|---|---|
|Description|**Quote Detail Name. Added for 1:n referential relationship (internal purposes only)**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`quotedetailname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_QuoteId"></a> QuoteId

|Property|Value|
|---|---|
|Description|**Unique identifier of the quote for the quote product.**|
|DisplayName|**Quote**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`quoteid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|quote|

### <a name="BKMK_RequestDeliveryBy"></a> RequestDeliveryBy

|Property|Value|
|---|---|
|Description|**Enter the delivery date requested by the customer for the quote product.**|
|DisplayName|**Requested Delivery Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`requestdeliveryby`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SalesRepId"></a> SalesRepId

|Property|Value|
|---|---|
|Description|**Choose the user responsible for the sale of the quote product.**|
|DisplayName|**Salesperson**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesrepid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_SequenceNumber"></a> SequenceNumber

|Property|Value|
|---|---|
|Description|**Unique identifier of the data that maintains the sequence.**|
|DisplayName|**Sequence Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_ShipTo_AddressId"></a> ShipTo_AddressId

|Property|Value|
|---|---|
|Description|**Unique identifier of the shipping address.**|
|DisplayName|**Ship To Address ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`shipto_addressid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ShipTo_City"></a> ShipTo_City

|Property|Value|
|---|---|
|Description|**Type the city for the customer's shipping address.**|
|DisplayName|**Ship To City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_ShipTo_ContactName"></a> ShipTo_ContactName

|Property|Value|
|---|---|
|Description|**Type the primary contact name at the customer's shipping address.**|
|DisplayName|**Ship To Contact Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_contactname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_ShipTo_Country"></a> ShipTo_Country

|Property|Value|
|---|---|
|Description|**Type the country or region for the customer's shipping address.**|
|DisplayName|**Ship To Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_ShipTo_Fax"></a> ShipTo_Fax

|Property|Value|
|---|---|
|Description|**Type the fax number for the customer's shipping address.**|
|DisplayName|**Ship To Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_ShipTo_FreightTermsCode"></a> ShipTo_FreightTermsCode

|Property|Value|
|---|---|
|Description|**Select the freight terms to make sure shipping orders are processed correctly.**|
|DisplayName|**Freight Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_freighttermscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`quotedetail_shipto_freighttermscode`|

#### ShipTo_FreightTermsCode Choices/Options

|Value|Label|
|---|---|
|1|**FOB**|
|2|**No Charge**|

### <a name="BKMK_ShipTo_Line1"></a> ShipTo_Line1

|Property|Value|
|---|---|
|Description|**Type the first line of the customer's shipping address.**|
|DisplayName|**Ship To Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_line1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_ShipTo_Line2"></a> ShipTo_Line2

|Property|Value|
|---|---|
|Description|**Type the second line of the customer's shipping address.**|
|DisplayName|**Ship To Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_line2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_ShipTo_Line3"></a> ShipTo_Line3

|Property|Value|
|---|---|
|Description|**Type the third line of the shipping address.**|
|DisplayName|**Ship To Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_line3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_ShipTo_Name"></a> ShipTo_Name

|Property|Value|
|---|---|
|Description|**Type a name for the customer's shipping address, such as "Headquarters" or "Field office",  to identify the address.**|
|DisplayName|**Ship To Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_ShipTo_PostalCode"></a> ShipTo_PostalCode

|Property|Value|
|---|---|
|Description|**Type the ZIP Code or postal code for the shipping address.**|
|DisplayName|**Ship To ZIP/Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_ShipTo_StateOrProvince"></a> ShipTo_StateOrProvince

|Property|Value|
|---|---|
|Description|**Type the state or province for the shipping address.**|
|DisplayName|**Ship To State/Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_ShipTo_Telephone"></a> ShipTo_Telephone

|Property|Value|
|---|---|
|Description|**Type the phone number for the customer's shipping address.**|
|DisplayName|**Ship To Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_telephone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_SkipPriceCalculation"></a> SkipPriceCalculation

|Property|Value|
|---|---|
|Description|**Skip the price**|
|DisplayName|**Skip Price Calculation**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`skippricecalculation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`qooidetail_skippricecalculation`|

#### SkipPriceCalculation Choices/Options

|Value|Label|
|---|---|
|0|**DoPriceCalcAlways**|
|1|**SkipPriceCalcOnCreate**|
|2|**SkipPriceCalcOnUpdate**|
|3|**SkipPriceCalcOnUpSert**|

### <a name="BKMK_Tax"></a> Tax

|Property|Value|
|---|---|
|Description|**Type the tax amount for the quote product.**|
|DisplayName|**Tax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`tax`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|-1000000000000|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_UoMId"></a> UoMId

|Property|Value|
|---|---|
|Description|**Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.**|
|DisplayName|**Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`uomid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_WillCall"></a> WillCall

|Property|Value|
|---|---|
|Description|**Select whether the quote product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.**|
|DisplayName|**Ship To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`willcall`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`quotedetail_willcall`|
|DefaultValue|False|
|True Label|Will Call|
|False Label|Address|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [BaseAmount_Base](#BKMK_BaseAmount_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ExtendedAmount_Base](#BKMK_ExtendedAmount_Base)
- [ManualDiscountAmount_Base](#BKMK_ManualDiscountAmount_Base)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PricePerUnit_Base](#BKMK_PricePerUnit_Base)
- [ProductNumber](#BKMK_ProductNumber)
- [QuoteStateCode](#BKMK_QuoteStateCode)
- [Tax_Base](#BKMK_Tax_Base)
- [VersionNumber](#BKMK_VersionNumber)
- [VolumeDiscountAmount](#BKMK_VolumeDiscountAmount)
- [VolumeDiscountAmount_Base](#BKMK_VolumeDiscountAmount_Base)

### <a name="BKMK_BaseAmount_Base"></a> BaseAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Amount in base currency.**|
|DisplayName|**Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`baseamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Shows who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Shows who created the record on behalf of another user.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_ExtendedAmount_Base"></a> ExtendedAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Extended Amount in base currency.**|
|DisplayName|**Extended Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`extendedamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_ManualDiscountAmount_Base"></a> ManualDiscountAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Manual Discount in base currency.**|
|DisplayName|**Manual Discount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`manualdiscountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Shows who last updated the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|ApplicationRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets||

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets||

### <a name="BKMK_PricePerUnit_Base"></a> PricePerUnit_Base

|Property|Value|
|---|---|
|Description|**Value of the Price Per Unit in base currency.**|
|DisplayName|**Price Per Unit (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`priceperunit_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_ProductNumber"></a> ProductNumber

|Property|Value|
|---|---|
|Description|**User-defined product ID.**|
|DisplayName|**Product Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`productnumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_QuoteStateCode"></a> QuoteStateCode

|Property|Value|
|---|---|
|Description|**Status of the quote product.**|
|DisplayName|**Quote Status**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`quotestatecode`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`quotedetail_quotestatecode`|

#### QuoteStateCode Choices/Options

|Value|Label|
|---|---|

### <a name="BKMK_Tax_Base"></a> Tax_Base

|Property|Value|
|---|---|
|Description|**Value of the Tax in base currency.**|
|DisplayName|**Tax (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`tax_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_VolumeDiscountAmount"></a> VolumeDiscountAmount

|Property|Value|
|---|---|
|Description|**Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.**|
|DisplayName|**Volume Discount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`volumediscountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_VolumeDiscountAmount_Base"></a> VolumeDiscountAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Volume Discount in base currency.**|
|DisplayName|**Volume Discount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`volumediscountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [lk_quotedetail_createdonbehalfby](#BKMK_lk_quotedetail_createdonbehalfby)
- [lk_quotedetail_modifiedonbehalfby](#BKMK_lk_quotedetail_modifiedonbehalfby)
- [lk_quotedetailbase_createdby](#BKMK_lk_quotedetailbase_createdby)
- [lk_quotedetailbase_modifiedby](#BKMK_lk_quotedetailbase_modifiedby)
- [product_quote_details](#BKMK_product_quote_details)
- [productAssociation_quote_details](#BKMK_productAssociation_quote_details)
- [quote_details](#BKMK_quote_details)
- [quotedetail_parent_quotedetail](#BKMK_quotedetail_parent_quotedetail-many-to-one)
- [quotedetail_parentref_quotedetail](#BKMK_quotedetail_parentref_quotedetail-many-to-one)
- [system_user_quotedetail](#BKMK_system_user_quotedetail)
- [team_quotedetail](#BKMK_team_quotedetail)
- [transactioncurrency_quotedetail](#BKMK_transactioncurrency_quotedetail)
- [unit_of_measurement_quote_details](#BKMK_unit_of_measurement_quote_details)
- [user_quotedetail](#BKMK_user_quotedetail)

### <a name="BKMK_lk_quotedetail_createdonbehalfby"></a> lk_quotedetail_createdonbehalfby

One-To-Many Relationship: [systemuser lk_quotedetail_createdonbehalfby](systemuser.md#BKMK_lk_quotedetail_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_quotedetail_modifiedonbehalfby"></a> lk_quotedetail_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_quotedetail_modifiedonbehalfby](systemuser.md#BKMK_lk_quotedetail_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_quotedetailbase_createdby"></a> lk_quotedetailbase_createdby

One-To-Many Relationship: [systemuser lk_quotedetailbase_createdby](systemuser.md#BKMK_lk_quotedetailbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_quotedetailbase_modifiedby"></a> lk_quotedetailbase_modifiedby

One-To-Many Relationship: [systemuser lk_quotedetailbase_modifiedby](systemuser.md#BKMK_lk_quotedetailbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_product_quote_details"></a> product_quote_details

One-To-Many Relationship: [product product_quote_details](product.md#BKMK_product_quote_details)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`productid`|
|ReferencingEntityNavigationPropertyName|`productid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_productAssociation_quote_details"></a> productAssociation_quote_details

One-To-Many Relationship: [productassociation productAssociation_quote_details](productassociation.md#BKMK_productAssociation_quote_details)

|Property|Value|
|---|---|
|ReferencedEntity|`productassociation`|
|ReferencedAttribute|`productassociationid`|
|ReferencingAttribute|`productassociationid`|
|ReferencingEntityNavigationPropertyName|`productassociationid_productassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quote_details"></a> quote_details

One-To-Many Relationship: [quote quote_details](quote.md#BKMK_quote_details)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`quoteid`|
|ReferencingEntityNavigationPropertyName|`quoteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quotedetail_parent_quotedetail-many-to-one"></a> quotedetail_parent_quotedetail

One-To-Many Relationship: [quotedetail quotedetail_parent_quotedetail](#BKMK_quotedetail_parent_quotedetail-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`quotedetail`|
|ReferencedAttribute|`quotedetailid`|
|ReferencingAttribute|`parentbundleid`|
|ReferencingEntityNavigationPropertyName|`parentbundleid_quotedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quotedetail_parentref_quotedetail-many-to-one"></a> quotedetail_parentref_quotedetail

One-To-Many Relationship: [quotedetail quotedetail_parentref_quotedetail](#BKMK_quotedetail_parentref_quotedetail-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`quotedetail`|
|ReferencedAttribute|`quotedetailid`|
|ReferencingAttribute|`parentbundleidref`|
|ReferencingEntityNavigationPropertyName|`parentbundleidref_quotedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_system_user_quotedetail"></a> system_user_quotedetail

One-To-Many Relationship: [systemuser system_user_quotedetail](systemuser.md#BKMK_system_user_quotedetail)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`salesrepid`|
|ReferencingEntityNavigationPropertyName|`salesrepid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_quotedetail"></a> team_quotedetail

One-To-Many Relationship: [team team_quotedetail](team.md#BKMK_team_quotedetail)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_quotedetail"></a> transactioncurrency_quotedetail

One-To-Many Relationship: [transactioncurrency transactioncurrency_quotedetail](transactioncurrency.md#BKMK_transactioncurrency_quotedetail)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_unit_of_measurement_quote_details"></a> unit_of_measurement_quote_details

One-To-Many Relationship: [uom unit_of_measurement_quote_details](uom.md#BKMK_unit_of_measurement_quote_details)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`uomid`|
|ReferencingEntityNavigationPropertyName|`uomid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_quotedetail"></a> user_quotedetail

One-To-Many Relationship: [systemuser user_quotedetail](systemuser.md#BKMK_user_quotedetail)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_quotedetail_salesorderdetail](#BKMK_msdyn_quotedetail_salesorderdetail)
- [QuoteDetail_AsyncOperations](#BKMK_QuoteDetail_AsyncOperations)
- [QuoteDetail_BulkDeleteFailures](#BKMK_QuoteDetail_BulkDeleteFailures)
- [QuoteDetail_Dynamicpropertyinstance](#BKMK_QuoteDetail_Dynamicpropertyinstance)
- [quotedetail_MailboxTrackingFolders](#BKMK_quotedetail_MailboxTrackingFolders)
- [quotedetail_parent_quotedetail](#BKMK_quotedetail_parent_quotedetail-one-to-many)
- [quotedetail_parentref_quotedetail](#BKMK_quotedetail_parentref_quotedetail-one-to-many)
- [quotedetail_principalobjectattributeaccess](#BKMK_quotedetail_principalobjectattributeaccess)
- [QuoteDetail_ProcessSessions](#BKMK_QuoteDetail_ProcessSessions)
- [QuoteDetail_SyncErrors](#BKMK_QuoteDetail_SyncErrors)

### <a name="BKMK_msdyn_quotedetail_salesorderdetail"></a> msdyn_quotedetail_salesorderdetail

Many-To-One Relationship: [salesorderdetail msdyn_quotedetail_salesorderdetail](salesorderdetail.md#BKMK_msdyn_quotedetail_salesorderdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorderdetail`|
|ReferencingAttribute|`quotedetailid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotedetail_salesorderdetail`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_QuoteDetail_AsyncOperations"></a> QuoteDetail_AsyncOperations

Many-To-One Relationship: [asyncoperation QuoteDetail_AsyncOperations](asyncoperation.md#BKMK_QuoteDetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`QuoteDetail_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_QuoteDetail_BulkDeleteFailures"></a> QuoteDetail_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure QuoteDetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_QuoteDetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`QuoteDetail_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_QuoteDetail_Dynamicpropertyinstance"></a> QuoteDetail_Dynamicpropertyinstance

Many-To-One Relationship: [dynamicpropertyinstance QuoteDetail_Dynamicpropertyinstance](dynamicpropertyinstance.md#BKMK_QuoteDetail_Dynamicpropertyinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyinstance`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`QuoteDetail_Dynamicpropertyinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quotedetail_MailboxTrackingFolders"></a> quotedetail_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder quotedetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_quotedetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`quotedetail_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quotedetail_parent_quotedetail-one-to-many"></a> quotedetail_parent_quotedetail

Many-To-One Relationship: [quotedetail quotedetail_parent_quotedetail](#BKMK_quotedetail_parent_quotedetail-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`quotedetail`|
|ReferencingAttribute|`parentbundleid`|
|ReferencedEntityNavigationPropertyName|`quotedetail_parent_quotedetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quotedetail_parentref_quotedetail-one-to-many"></a> quotedetail_parentref_quotedetail

Many-To-One Relationship: [quotedetail quotedetail_parentref_quotedetail](#BKMK_quotedetail_parentref_quotedetail-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`quotedetail`|
|ReferencingAttribute|`parentbundleidref`|
|ReferencedEntityNavigationPropertyName|`quotedetail_parentref_quotedetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quotedetail_principalobjectattributeaccess"></a> quotedetail_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess quotedetail_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_quotedetail_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`quotedetail_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_QuoteDetail_ProcessSessions"></a> QuoteDetail_ProcessSessions

Many-To-One Relationship: [processsession QuoteDetail_ProcessSessions](processsession.md#BKMK_QuoteDetail_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`QuoteDetail_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_QuoteDetail_SyncErrors"></a> QuoteDetail_SyncErrors

Many-To-One Relationship: [syncerror QuoteDetail_SyncErrors](syncerror.md#BKMK_QuoteDetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`QuoteDetail_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

