---
title: "Quote Product (QuoteDetail)  table/entity reference"
description: "Includes schema information and supported messages for the Quote Product (QuoteDetail)  table/entity."
ms.date: 01/29/2024
ms.service: "dynamics-365-sales"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "lavanyakr01"
ms.author: "lavanyakr"
search.audienceType: 
  - developer
---

# Quote Product (QuoteDetail)  table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Product line item in a quote. The details include such information as product ID, description, quantity, and cost.

**Added by**: Sales Solution


## Messages

|Message|Web API Operation|SDK class or method|
|-|-|-|
|CalculatePrice|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Create|POST /quotedetails<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|DELETE /quotedetails(*quotedetailid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Restore||Use <xref:Microsoft.Xrm.Sdk.OrganizationRequest><br/>where <xref:Microsoft.Xrm.Sdk.OrganizationRequest.RequestName> = Restore|
|Retrieve|GET /quotedetails(*quotedetailid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET /quotedetails<br />See [Query Data](/powerapps/developer/data-platform/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH /quotedetails(*quotedetailid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|QuoteDetails|
|DisplayCollectionName|Quote Products|
|DisplayName|Quote Product|
|EntitySetName|quotedetails|
|IsBPFEntity|False|
|LogicalCollectionName|quotedetails|
|LogicalName|quotedetail|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|quotedetailid|
|PrimaryNameAttribute|quotedetailname|
|SchemaName|QuoteDetail|

<a name="writable-attributes"></a>

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
- [msdyn_allowedoverdeliverypercentage](#BKMK_msdyn_allowedoverdeliverypercentage)
- [msdyn_allowedunderdeliverypercentage](#BKMK_msdyn_allowedunderdeliverypercentage)
- [msdyn_company](#BKMK_msdyn_company)
- [msdyn_deliveryaddresscountyid](#BKMK_msdyn_deliveryaddresscountyid)
- [msdyn_deliveryaddressdescription](#BKMK_msdyn_deliveryaddressdescription)
- [msdyn_deliveryaddressdistrictname](#BKMK_msdyn_deliveryaddressdistrictname)
- [msdyn_deliveryaddressdunsnumber](#BKMK_msdyn_deliveryaddressdunsnumber)
- [msdyn_deliveryaddresslatitude](#BKMK_msdyn_deliveryaddresslatitude)
- [msdyn_deliveryaddresslocationid](#BKMK_msdyn_deliveryaddresslocationid)
- [msdyn_deliveryaddresslongitude](#BKMK_msdyn_deliveryaddresslongitude)
- [msdyn_deliveryaddressname](#BKMK_msdyn_deliveryaddressname)
- [msdyn_deliveryaddresspostbox](#BKMK_msdyn_deliveryaddresspostbox)
- [msdyn_deliverybuildingcompliment](#BKMK_msdyn_deliverybuildingcompliment)
- [msdyn_externalitemnumber](#BKMK_msdyn_externalitemnumber)
- [msdyn_fixedpricecharges](#BKMK_msdyn_fixedpricecharges)
- [msdyn_formatteddeliveryaddress](#BKMK_msdyn_formatteddeliveryaddress)
- [msdyn_isdeliveryaddressprivate](#BKMK_msdyn_isdeliveryaddressprivate)
- [msdyn_isdeliveryaddressspecific](#BKMK_msdyn_isdeliveryaddressspecific)
- [msdyn_linedescription2](#BKMK_msdyn_linedescription2)
- [msdyn_linediscountamount](#BKMK_msdyn_linediscountamount)
- [msdyn_linediscountpercentage](#BKMK_msdyn_linediscountpercentage)
- [msdyn_multilinediscountamount](#BKMK_msdyn_multilinediscountamount)
- [msdyn_multilinediscountpercentage](#BKMK_msdyn_multilinediscountpercentage)
- [msdyn_OpportunityProductID](#BKMK_msdyn_OpportunityProductID)
- [msdyn_requestedreceiptdate](#BKMK_msdyn_requestedreceiptdate)
- [msdyn_salespricequantity](#BKMK_msdyn_salespricequantity)
- [msdyn_salesproductcategory](#BKMK_msdyn_salesproductcategory)
- [msdyn_salesquotationpromisingmethod](#BKMK_msdyn_salesquotationpromisingmethod)
- [msdyn_salesquotationstatus](#BKMK_msdyn_salesquotationstatus)
- [msdyn_shippingsite](#BKMK_msdyn_shippingsite)
- [msdyn_shippingwarehouse](#BKMK_msdyn_shippingwarehouse)
- [msdyn_totalchargesamount](#BKMK_msdyn_totalchargesamount)
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
|--------|-----|
|Description|Shows the total price of the quote product, based on the price per unit, volume discount, and quantity.|
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
|Description|Type additional information to describe the quote product, such as manufacturing details or acceptable substitutions.|
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
|Description|Shows the total amount due for the quote product, based on the sum of the unit price, quantity, discounts ,and tax.|
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


### <a name="BKMK_IsPriceOverridden"></a> IsPriceOverridden

|Property|Value|
|--------|-----|
|Description|Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the quote product.|
|DisplayName|Price Overridden|
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

**DefaultValue**: 1



### <a name="BKMK_IsProductOverridden"></a> IsProductOverridden

|Property|Value|
|--------|-----|
|Description|Select whether the product exists in the Microsoft Dynamics 365 product catalog or is a write-in product specific to the quote.|
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
|Description|Type the line item number for the quote product to easily identify the product in the quote and make sure it's listed in the correct order.|
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
|Description|Type the manual discount amount for the quote product to deduct any negotiated or other savings from the product total on the quote. When the feature 'Make Supply Chain Management price master when integrated with Dynamics 365 Sales' is enabled then this field is being locked and represents the calculated line discount total amount. The field value is calculated in Finance and Operations and takes into account all the line discount fields including multiline discount multiplied by line quantity.|
|DisplayName|Manual Discount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|manualdiscountamount|
|MaxValue|1000000000000|
|MinValue|-1000000000000|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_allowedoverdeliverypercentage"></a> msdyn_allowedoverdeliverypercentage

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Allowed Overdelivery Percentage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_allowedoverdeliverypercentage|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_allowedunderdeliverypercentage"></a> msdyn_allowedunderdeliverypercentage

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Allowed Underdelivery Percentage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_allowedunderdeliverypercentage|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_company"></a> msdyn_company

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Company|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_company|
|RequiredLevel|None|
|Targets|cdm_company|
|Type|Lookup|


### <a name="BKMK_msdyn_deliveryaddresscountyid"></a> msdyn_deliveryaddresscountyid

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address County Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresscountyid|
|MaxLength|30|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliveryaddressdescription"></a> msdyn_deliveryaddressdescription

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddressdescription|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliveryaddressdistrictname"></a> msdyn_deliveryaddressdistrictname

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address District Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddressdistrictname|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliveryaddressdunsnumber"></a> msdyn_deliveryaddressdunsnumber

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address DUNS Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddressdunsnumber|
|MaxLength|9|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliveryaddresslatitude"></a> msdyn_deliveryaddresslatitude

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresslatitude|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_deliveryaddresslocationid"></a> msdyn_deliveryaddresslocationid

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Location Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresslocationid|
|MaxLength|30|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliveryaddresslongitude"></a> msdyn_deliveryaddresslongitude

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresslongitude|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_deliveryaddressname"></a> msdyn_deliveryaddressname

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddressname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliveryaddresspostbox"></a> msdyn_deliveryaddresspostbox

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address PostBox|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresspostbox|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliverybuildingcompliment"></a> msdyn_deliverybuildingcompliment

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Building Compliment|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliverybuildingcompliment|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_externalitemnumber"></a> msdyn_externalitemnumber

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|External Item Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_externalitemnumber|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_fixedpricecharges"></a> msdyn_fixedpricecharges

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Fixed Price Charges|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_fixedpricecharges|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_formatteddeliveryaddress"></a> msdyn_formatteddeliveryaddress

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Formatted Delivery Address|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_formatteddeliveryaddress|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_isdeliveryaddressprivate"></a> msdyn_isdeliveryaddressprivate

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Delivery Address Private|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isdeliveryaddressprivate|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_isdeliveryaddressprivate Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_isdeliveryaddressspecific"></a> msdyn_isdeliveryaddressspecific

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Delivery Address Specific|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isdeliveryaddressspecific|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_isdeliveryaddressspecific Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_linedescription2"></a> msdyn_linedescription2

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Line Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_linedescription2|
|MaxLength|1000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_linediscountamount"></a> msdyn_linediscountamount

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description|Enter or update the line discount amount for each quantity of the line. If the line discount amount is 10, the quantity is 2, then this will result in a line discount amount of 20 (10x2) for the line. This field can also be found under the Integration tab.|
|DisplayName|Line Discount Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_linediscountamount|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_linediscountpercentage"></a> msdyn_linediscountpercentage

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Line Discount Percentage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_linediscountpercentage|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_multilinediscountamount"></a> msdyn_multilinediscountamount

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Multiline Discount Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_multilinediscountamount|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_multilinediscountpercentage"></a> msdyn_multilinediscountpercentage

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Multiline Discount Percentage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_multilinediscountpercentage|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_OpportunityProductID"></a> msdyn_OpportunityProductID

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Opportunity Product ID|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_opportunityproductid|
|RequiredLevel|None|
|Targets|opportunityproduct|
|Type|Lookup|


### <a name="BKMK_msdyn_requestedreceiptdate"></a> msdyn_requestedreceiptdate

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description||
|DisplayName|Requested Receipt Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requestedreceiptdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_salespricequantity"></a> msdyn_salespricequantity

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Sales Price Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salespricequantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_salesproductcategory"></a> msdyn_salesproductcategory

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Sales Product Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salesproductcategory|
|RequiredLevel|None|
|Targets|msdyn_productcategory|
|Type|Lookup|


### <a name="BKMK_msdyn_salesquotationpromisingmethod"></a> msdyn_salesquotationpromisingmethod

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Sales Quotation Promising Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salesquotationpromisingmethod|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_salesquotationpromisingmethod Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|192350000|None||
|192350001|Sales Lead Time||
|192350002|ATP||
|192350003|ATP + Issue Margin||
|192350004|CTP||



### <a name="BKMK_msdyn_salesquotationstatus"></a> msdyn_salesquotationstatus

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Sales Quotation Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salesquotationstatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_salesquotationstatus Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|192350000|Created||
|192350001|Sent||
|192350002|Confirmed||
|192350003|Lost||
|192350004|Cancelled||
|192350005|Reset||
|192350006|Modified||
|192350007|Submitted||
|192350008|Approved||
|192350009|Revised||



### <a name="BKMK_msdyn_shippingsite"></a> msdyn_shippingsite

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Shipping Site|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_shippingsite|
|RequiredLevel|None|
|Targets|msdyn_operationalsite|
|Type|Lookup|


### <a name="BKMK_msdyn_shippingwarehouse"></a> msdyn_shippingwarehouse

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Shipping Warehouse|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_shippingwarehouse|
|RequiredLevel|None|
|Targets|msdyn_warehouse|
|Type|Lookup|


### <a name="BKMK_msdyn_totalchargesamount"></a> msdyn_totalchargesamount

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Total Charges Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalchargesamount|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


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
|Targets|quotedetail|
|Type|Lookup|


### <a name="BKMK_PricePerUnit"></a> PricePerUnit

|Property|Value|
|--------|-----|
|Description|Type the price per unit of the quote product. The default is to the value in the price list specified on the quote for existing products.|
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
|Description|Unique identifier of the product line item association with bundle in the quote|
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
|Description|Type a name or description to identify the type of write-in product included in the quote.|
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
|Description|Choose the product to include on the quote to link the product's pricing and other information to the quote.|
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
|Description|Type the amount or quantity of the product requested by the customer.|
|DisplayName|Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|


### <a name="BKMK_QuoteCreationMethod"></a> QuoteCreationMethod

**Added by**: Sales Patch Version 3 Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Creation Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quotecreationmethod|
|RequiredLevel|None|
|Type|Picklist|

#### QuoteCreationMethod Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|776160000|Unknown||
|776160001|Revision||



### <a name="BKMK_QuoteDetailId"></a> QuoteDetailId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the product line item in the quote.|
|DisplayName|Quote Product|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|quotedetailid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_QuoteDetailName"></a> QuoteDetailName

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Quote Detail Name. Added for 1:n referential relationship (internal purposes only)|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quotedetailname|
|MaxLength|500|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_QuoteId"></a> QuoteId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the quote for the quote product.|
|DisplayName|Quote|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quoteid|
|RequiredLevel|SystemRequired|
|Targets|quote|
|Type|Lookup|


### <a name="BKMK_RequestDeliveryBy"></a> RequestDeliveryBy

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the delivery date requested by the customer for the quote product.|
|DisplayName|Requested Delivery Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requestdeliveryby|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SalesRepId"></a> SalesRepId

|Property|Value|
|--------|-----|
|Description|Choose the user responsible for the sale of the quote product.|
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
|Description|Unique identifier of the data that maintains the sequence.|
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
|Description|Skip the price|
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
|Description|Type the tax amount for the quote product.|
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
|Description|Select whether the quote product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.|
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
- [msdyn_companyName](#BKMK_msdyn_companyName)
- [msdyn_OpportunityProductIDName](#BKMK_msdyn_OpportunityProductIDName)
- [msdyn_salesproductcategoryName](#BKMK_msdyn_salesproductcategoryName)
- [msdyn_shippingsiteName](#BKMK_msdyn_shippingsiteName)
- [msdyn_shippingwarehouseName](#BKMK_msdyn_shippingwarehouseName)
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
- [QuoteIdName](#BKMK_QuoteIdName)
- [QuoteStateCode](#BKMK_QuoteStateCode)
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

**Added by**: Sales Patch Version 3 Solution

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money columns in the row from the local currency to the system's default currency.|
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


### <a name="BKMK_msdyn_companyName"></a> msdyn_companyName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_companyname|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_OpportunityProductIDName"></a> msdyn_OpportunityProductIDName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_opportunityproductidname|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_salesproductcategoryName"></a> msdyn_salesproductcategoryName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_salesproductcategoryname|
|MaxLength|254|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_shippingsiteName"></a> msdyn_shippingsiteName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_shippingsitename|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_shippingwarehouseName"></a> msdyn_shippingwarehouseName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_shippingwarehousename|
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


### <a name="BKMK_QuoteIdName"></a> QuoteIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|quoteidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_QuoteStateCode"></a> QuoteStateCode

|Property|Value|
|--------|-----|
|Description|Status of the quote product.|
|DisplayName|Quote Status|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|quotestatecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### QuoteStateCode Choices/Options

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

- [QuoteDetail_Dynamicpropertyinstance](#BKMK_QuoteDetail_Dynamicpropertyinstance)
- [quotedetail_parent_quotedetail](#BKMK_quotedetail_parent_quotedetail)
- [msdyn_quotedetail_salesorderdetail](#BKMK_msdyn_quotedetail_salesorderdetail)
- [quotedetail_parentref_quotedetail](#BKMK_quotedetail_parentref_quotedetail)


### <a name="BKMK_QuoteDetail_Dynamicpropertyinstance"></a> QuoteDetail_Dynamicpropertyinstance

Same as the [QuoteDetail_Dynamicpropertyinstance](dynamicpropertyinstance.md#BKMK_QuoteDetail_Dynamicpropertyinstance) many-to-one relationship for the [dynamicpropertyinstance](dynamicpropertyinstance.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyinstance|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|QuoteDetail_Dynamicpropertyinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: Cascade<br />Unshare: NoCascade|


### <a name="BKMK_quotedetail_parent_quotedetail"></a> quotedetail_parent_quotedetail

Same as the [quotedetail_parent_quotedetail](quotedetail.md#BKMK_quotedetail_parent_quotedetail) many-to-one relationship for the [quotedetail](quotedetail.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|parentbundleid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quotedetail_parent_quotedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotedetail_salesorderdetail"></a> msdyn_quotedetail_salesorderdetail

**Added by**: Sales Patch Solution

Same as the [msdyn_quotedetail_salesorderdetail](salesorderdetail.md#BKMK_msdyn_quotedetail_salesorderdetail) many-to-one relationship for the [salesorderdetail](salesorderdetail.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|quotedetailid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|msdyn_quotedetail_salesorderdetail|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_quotedetail_parentref_quotedetail"></a> quotedetail_parentref_quotedetail

**Added by**: Sales Patch Solution

Same as the [quotedetail_parentref_quotedetail](quotedetail.md#BKMK_quotedetail_parentref_quotedetail) many-to-one relationship for the [quotedetail](quotedetail.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|parentbundleidref|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quotedetail_parentref_quotedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [product_quote_details](#BKMK_product_quote_details)
- [productAssociation_quote_details](#BKMK_productAssociation_quote_details)
- [quotedetail_parent_quotedetail](#BKMK_quotedetail_parent_quotedetail)
- [unit_of_measurement_quote_details](#BKMK_unit_of_measurement_quote_details)
- [quotedetail_parentref_quotedetail](#BKMK_quotedetail_parentref_quotedetail)
- [msdyn_opportunityproduct_quotedetail_OpportunityProductID](#BKMK_msdyn_opportunityproduct_quotedetail_OpportunityProductID)
- [quote_details](#BKMK_quote_details)


### <a name="BKMK_product_quote_details"></a> product_quote_details

**Added by**: Product Management Solution

See the [product_quote_details](product.md#BKMK_product_quote_details) one-to-many relationship for the [product](product.md) table/entity.

### <a name="BKMK_productAssociation_quote_details"></a> productAssociation_quote_details

**Added by**: Product Management Solution

See the [productAssociation_quote_details](productassociation.md#BKMK_productAssociation_quote_details) one-to-many relationship for the [productassociation](productassociation.md) table/entity.

### <a name="BKMK_quotedetail_parent_quotedetail"></a> quotedetail_parent_quotedetail

See the [quotedetail_parent_quotedetail](quotedetail.md#BKMK_quotedetail_parent_quotedetail) one-to-many relationship for the [quotedetail](quotedetail.md) table/entity.

### <a name="BKMK_unit_of_measurement_quote_details"></a> unit_of_measurement_quote_details

**Added by**: Product Management Solution

See the [unit_of_measurement_quote_details](uom.md#BKMK_unit_of_measurement_quote_details) one-to-many relationship for the [uom](uom.md) table/entity.

### <a name="BKMK_quotedetail_parentref_quotedetail"></a> quotedetail_parentref_quotedetail

See the [quotedetail_parentref_quotedetail](quotedetail.md#BKMK_quotedetail_parentref_quotedetail) one-to-many relationship for the [quotedetail](quotedetail.md) table/entity.

### <a name="BKMK_msdyn_opportunityproduct_quotedetail_OpportunityProductID"></a> msdyn_opportunityproduct_quotedetail_OpportunityProductID

See the [msdyn_opportunityproduct_quotedetail_OpportunityProductID](opportunityproduct.md#BKMK_msdyn_opportunityproduct_quotedetail_OpportunityProductID) one-to-many relationship for the [opportunityproduct](opportunityproduct.md) table/entity.

### <a name="BKMK_quote_details"></a> quote_details

See the [quote_details](quote.md#BKMK_quote_details) one-to-many relationship for the [quote](quote.md) table/entity.

### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)