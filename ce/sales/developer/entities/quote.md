---
title: "Quote table/entity reference (Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Quote table/entity."
ms.date: 02/17/2023
ms.service: dynamics-365-sales
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "udaykirang"
ms.author: "udag"
search.audienceType: 
  - developer
---

# Quote table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer.

**Added by**: Sales Solution


## Messages

|Message|SDK Assembly|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Associate|<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>|
|CalculatePrice|<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|
|CloseIncident|<xref:Microsoft.Crm.Sdk.Messages.CloseIncidentRequest>|
|CloseQuote|<xref:Microsoft.Crm.Sdk.Messages.CloseQuoteRequest>|
|ConvertQuoteToSalesOrder|<xref:Microsoft.Crm.Sdk.Messages.ConvertQuoteToSalesOrderRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Disassociate|<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*>|
|GenerateQuoteFromOpportunity|<xref:Microsoft.Crm.Sdk.Messages.GenerateQuoteFromOpportunityRequest>|
|GetQuantityDecimal|<xref:Microsoft.Crm.Sdk.Messages.GetQuantityDecimalRequest>|
|GetQuoteProductsFromOpportunity|<xref:Microsoft.Crm.Sdk.Messages.GetQuoteProductsFromOpportunityRequest>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|ReviseQuote|<xref:Microsoft.Crm.Sdk.Messages.ReviseQuoteRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|WinOpportunity|<xref:Microsoft.Crm.Sdk.Messages.WinOpportunityRequest>|
|WinQuote|<xref:Microsoft.Crm.Sdk.Messages.WinQuoteRequest>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Quotes|
|DisplayCollectionName|Quotes|
|DisplayName|Quote|
|EntitySetName|quotes|
|IsBPFEntity|False|
|LogicalCollectionName|quotes|
|LogicalName|quote|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|quoteid|
|PrimaryNameAttribute|name|
|SchemaName|Quote|

<a name="writable-attributes"></a>

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BillTo_AddressId](#BKMK_BillTo_AddressId)
- [BillTo_City](#BKMK_BillTo_City)
- [BillTo_ContactName](#BKMK_BillTo_ContactName)
- [BillTo_Country](#BKMK_BillTo_Country)
- [BillTo_Fax](#BKMK_BillTo_Fax)
- [BillTo_Line1](#BKMK_BillTo_Line1)
- [BillTo_Line2](#BKMK_BillTo_Line2)
- [BillTo_Line3](#BKMK_BillTo_Line3)
- [BillTo_Name](#BKMK_BillTo_Name)
- [BillTo_PostalCode](#BKMK_BillTo_PostalCode)
- [BillTo_StateOrProvince](#BKMK_BillTo_StateOrProvince)
- [BillTo_Telephone](#BKMK_BillTo_Telephone)
- [CampaignId](#BKMK_CampaignId)
- [ClosedOn](#BKMK_ClosedOn)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [Description](#BKMK_Description)
- [DiscountAmount](#BKMK_DiscountAmount)
- [DiscountPercentage](#BKMK_DiscountPercentage)
- [EffectiveFrom](#BKMK_EffectiveFrom)
- [EffectiveTo](#BKMK_EffectiveTo)
- [EmailAddress](#BKMK_EmailAddress)
- [ExpiresOn](#BKMK_ExpiresOn)
- [FreightAmount](#BKMK_FreightAmount)
- [FreightTermsCode](#BKMK_FreightTermsCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [Name](#BKMK_Name)
- [OpportunityId](#BKMK_OpportunityId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PaymentTermsCode](#BKMK_PaymentTermsCode)
- [PriceLevelId](#BKMK_PriceLevelId)
- [PricingErrorCode](#BKMK_PricingErrorCode)
- [ProcessId](#BKMK_ProcessId)
- [QuoteId](#BKMK_QuoteId)
- [QuoteNumber](#BKMK_QuoteNumber)
- [RequestDeliveryBy](#BKMK_RequestDeliveryBy)
- [ShippingMethodCode](#BKMK_ShippingMethodCode)
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
- [SLAId](#BKMK_SLAId)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalAmount](#BKMK_TotalAmount)
- [TotalAmountLessFreight](#BKMK_TotalAmountLessFreight)
- [TotalDiscountAmount](#BKMK_TotalDiscountAmount)
- [TotalLineItemAmount](#BKMK_TotalLineItemAmount)
- [TotalLineItemDiscountAmount](#BKMK_TotalLineItemDiscountAmount)
- [TotalTax](#BKMK_TotalTax)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WillCall](#BKMK_WillCall)


### <a name="BKMK_BillTo_AddressId"></a> BillTo_AddressId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the billing address.|
|DisplayName|Bill To Address ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billto_addressid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_BillTo_City"></a> BillTo_City

|Property|Value|
|--------|-----|
|Description|Type the city for the customer's billing address.|
|DisplayName|Bill To City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_ContactName"></a> BillTo_ContactName

|Property|Value|
|--------|-----|
|Description|Type the primary contact name at the customer's billing address.|
|DisplayName|Bill To Contact Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_contactname|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Country"></a> BillTo_Country

|Property|Value|
|--------|-----|
|Description|Type the country or region for the customer's billing address.|
|DisplayName|Bill To Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Fax"></a> BillTo_Fax

|Property|Value|
|--------|-----|
|Description|Type the fax number for the customer's billing address.|
|DisplayName|Bill To Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Line1"></a> BillTo_Line1

|Property|Value|
|--------|-----|
|Description|Type the first line of the customer's billing address.|
|DisplayName|Bill To Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_line1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Line2"></a> BillTo_Line2

|Property|Value|
|--------|-----|
|Description|Type the second line of the customer's billing address.|
|DisplayName|Bill To Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_line2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Line3"></a> BillTo_Line3

|Property|Value|
|--------|-----|
|Description|Type the third line of the billing address.|
|DisplayName|Bill To Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_line3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Name"></a> BillTo_Name

|Property|Value|
|--------|-----|
|Description|Type a name for the customer's billing address, such as "Headquarters" or "Field office", to identify the address.|
|DisplayName|Bill To Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_name|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_PostalCode"></a> BillTo_PostalCode

|Property|Value|
|--------|-----|
|Description|Type the ZIP Code or postal code for the billing address.|
|DisplayName|Bill To ZIP/Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_StateOrProvince"></a> BillTo_StateOrProvince

|Property|Value|
|--------|-----|
|Description|Type the state or province for the billing address.|
|DisplayName|Bill To State/Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Telephone"></a> BillTo_Telephone

|Property|Value|
|--------|-----|
|Description|Type the phone number for the customer's billing address.|
|DisplayName|Bill To Phone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_telephone|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CampaignId"></a> CampaignId

**Added by**: Marketing Sales Solution

|Property|Value|
|--------|-----|
|Description|Shows the campaign that the order was created from.|
|DisplayName|Source Campaign|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|campaignid|
|RequiredLevel|None|
|Targets|campaign|
|Type|Lookup|


### <a name="BKMK_ClosedOn"></a> ClosedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Enter the date when the quote was closed to indicate the expiration, revision, or cancellation date.|
|DisplayName|Closed On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|closedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|--------|-----|
|Description|Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.|
|DisplayName|Potential Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerid|
|RequiredLevel|ApplicationRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Potential Customer Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the quote, such as the products or services offered or details about the customer's product preferences.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DiscountAmount"></a> DiscountAmount

|Property|Value|
|--------|-----|
|Description|Type the discount amount for the quote if the customer is eligible for special savings.|
|DisplayName|Quote Discount Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountamount|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_DiscountPercentage"></a> DiscountPercentage

|Property|Value|
|--------|-----|
|Description|Type the discount rate that should be applied to the Detail Amount field to include additional savings for the customer in the quote.|
|DisplayName|Quote Discount (%)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountpercentage|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_EffectiveFrom"></a> EffectiveFrom

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the quote pricing is effective or was first communicated to the customer.|
|DisplayName|Effective From|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|effectivefrom|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EffectiveTo"></a> EffectiveTo

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expiration date or last day the quote pricing is effective for the customer.|
|DisplayName|Effective To|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|effectiveto|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|--------|-----|
|Description|The primary email address for the entity.|
|DisplayName|Email Address|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExpiresOn"></a> ExpiresOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Enter the date a decision or order is due from the customer to indicate the expiration date of the quote.|
|DisplayName|Due By|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|expireson|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_FreightAmount"></a> FreightAmount

|Property|Value|
|--------|-----|
|Description|Type the cost of freight or shipping for the products included in the quote for use in calculating the Total Amount field.|
|DisplayName|Freight Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|freightamount|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_FreightTermsCode"></a> FreightTermsCode

|Property|Value|
|--------|-----|
|Description|Select the freight terms to make sure shipping charges are processed correctly.|
|DisplayName|Freight Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|freighttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### FreightTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|FOB||
|2|No Charge||



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


### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Contains the date time stamp of the last on hold time.|
|DisplayName|Last On Hold Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastonholdtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive name for the quote.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|300|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OpportunityId"></a> OpportunityId

|Property|Value|
|--------|-----|
|Description|Choose the opportunity that the quote is related to for reporting and analytics.|
|DisplayName|Opportunity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|opportunityid|
|RequiredLevel|None|
|Targets|opportunity|
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


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PaymentTermsCode"></a> PaymentTermsCode

|Property|Value|
|--------|-----|
|Description|Select the payment terms to indicate when the customer needs to pay the total amount.|
|DisplayName|Payment Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|paymenttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### PaymentTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Net 30||
|2|2% 10, Net 30||
|3|Net 45||
|4|Net 60||



### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|--------|-----|
|Description|Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|pricelevelid|
|RequiredLevel|ApplicationRequired|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_PricingErrorCode"></a> PricingErrorCode

|Property|Value|
|--------|-----|
|Description|Pricing error for the quote.|
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



### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Contains the id of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_QuoteId"></a> QuoteId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the quote.|
|DisplayName|Quote|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|quoteid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_QuoteNumber"></a> QuoteNumber

|Property|Value|
|--------|-----|
|Description|Shows the quote number for customer reference and searching capabilities. The number cannot be modified.|
|DisplayName|Quote ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|quotenumber|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_RequestDeliveryBy"></a> RequestDeliveryBy

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the delivery date requested by the customer for all products in the quote.|
|DisplayName|Requested Delivery Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requestdeliveryby|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Select a shipping method for deliveries sent to this address.|
|DisplayName|Shipping Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### ShippingMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Airborne||
|2|DHL||
|3|FedEx||
|4|UPS||
|5|Postal Mail||
|6|Full Load||
|7|Will Call||



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
|DisplayName|Ship To Freight Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_freighttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### ShipTo_FreightTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



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
|Description|Skip Price Calculation (For Internal use)|
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
|1|SkipPriceCalcOnRetrieve||



### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) that you want to apply to the quote record.|
|DisplayName|SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|slaid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|(Deprecated) Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the quote is draft, active, won, or closed. Only draft quotes can be edited.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Draft|1|Draft|
|1|Active|2|Active|
|2|Won|4|Won|
|3|Closed|7|Closed|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the quote's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|In Progress|0|
|2|In Progress|1|
|3|Open|1|
|4|Won|2|
|5|Lost|3|
|6|Canceled|3|
|7|Revised|3|



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


### <a name="BKMK_TotalAmount"></a> TotalAmount

|Property|Value|
|--------|-----|
|Description|Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the quote.|
|DisplayName|Total Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalAmountLessFreight"></a> TotalAmountLessFreight

|Property|Value|
|--------|-----|
|Description|Shows the total product amount for the quote, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the quote.|
|DisplayName|Total Pre-Freight Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamountlessfreight|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalDiscountAmount"></a> TotalDiscountAmount

|Property|Value|
|--------|-----|
|Description|Shows the total discount amount, based on the discount price and rate entered on the quote.|
|DisplayName|Total Discount Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaldiscountamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemAmount"></a> TotalLineItemAmount

|Property|Value|
|--------|-----|
|Description|Shows the sum of all existing and write-in products included on the quote, based on the specified price list and quantities.|
|DisplayName|Total Detail Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemDiscountAmount"></a> TotalLineItemDiscountAmount

|Property|Value|
|--------|-----|
|Description|Shows the total of the Manual Discount amounts specified on all products included in the quote. This value is reflected in the Detail Amount field on the quote and is added to any discount amount or rate specified on the quote|
|DisplayName|Total Line Item Discount Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemdiscountamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalTax"></a> TotalTax

|Property|Value|
|--------|-----|
|Description|Shows the total of the Tax amounts specified on all products included in the quote, included in the Total Amount due calculation for the quote.|
|DisplayName|Total Tax|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaltax|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|ApplicationRequired|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
|DisplayName|(Deprecated) Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


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
|Description|Select whether the products included in the quote should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.|
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

- [AccountId](#BKMK_AccountId)
- [AccountIdName](#BKMK_AccountIdName)
- [AccountIdYomiName](#BKMK_AccountIdYomiName)
- [BillTo_Composite](#BKMK_BillTo_Composite)
- [CampaignIdName](#BKMK_CampaignIdName)
- [ContactId](#BKMK_ContactId)
- [ContactIdName](#BKMK_ContactIdName)
- [ContactIdYomiName](#BKMK_ContactIdYomiName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [DiscountAmount_Base](#BKMK_DiscountAmount_Base)
- [ExchangeRate](#BKMK_ExchangeRate)
- [FreightAmount_Base](#BKMK_FreightAmount_Base)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OpportunityIdName](#BKMK_OpportunityIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PriceLevelIdName](#BKMK_PriceLevelIdName)
- [RevisionNumber](#BKMK_RevisionNumber)
- [ShipTo_Composite](#BKMK_ShipTo_Composite)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TotalAmount_Base](#BKMK_TotalAmount_Base)
- [TotalAmountLessFreight_Base](#BKMK_TotalAmountLessFreight_Base)
- [TotalDiscountAmount_Base](#BKMK_TotalDiscountAmount_Base)
- [TotalLineItemAmount_Base](#BKMK_TotalLineItemAmount_Base)
- [TotalLineItemDiscountAmount_Base](#BKMK_TotalLineItemDiscountAmount_Base)
- [TotalTax_Base](#BKMK_TotalTax_Base)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [UniqueDscId](#BKMK_UniqueDscId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the account with which the quote is associated.|
|DisplayName|Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_AccountIdName"></a> AccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Composite"></a> BillTo_Composite

|Property|Value|
|--------|-----|
|Description|Shows the complete Bill To address.|
|DisplayName|Bill To Address|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_composite|
|MaxLength|1000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_CampaignIdName"></a> CampaignIdName

**Added by**: Marketing Sales Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the contact associated with the quote.|
|DisplayName|Contact|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ContactIdName"></a> ContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactIdYomiName"></a> ContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridname|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridyominame|
|MaxLength|450|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_DiscountAmount_Base"></a> DiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Quote Discount Amount in base currency.|
|DisplayName|Quote Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_FreightAmount_Base"></a> FreightAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Freight Amount in base currency.|
|DisplayName|Freight Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|freightamount_base|
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


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|--------|-----|
|Description|Shows the duration in minutes for which the quote was on hold.|
|DisplayName|On Hold Time (Minutes)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|onholdtime|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OpportunityIdName"></a> OpportunityIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|opportunityidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_PriceLevelIdName"></a> PriceLevelIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricelevelidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_RevisionNumber"></a> RevisionNumber

|Property|Value|
|--------|-----|
|Description|Shows the version number of the quote for revision history tracking.|
|DisplayName|Revision ID|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|revisionnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_ShipTo_Composite"></a> ShipTo_Composite

|Property|Value|
|--------|-----|
|Description|Shows the complete Ship To address.|
|DisplayName|Ship To Address|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_composite|
|MaxLength|1000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|--------|-----|
|Description|Last SLA that was applied to this quote. This field is for internal use only.|
|DisplayName|Last SLA applied|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAName"></a> SLAName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TotalAmount_Base"></a> TotalAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Amount in base currency.|
|DisplayName|Total Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalAmountLessFreight_Base"></a> TotalAmountLessFreight_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Pre-Freight Amount in base currency.|
|DisplayName|Total Pre-Freight Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamountlessfreight_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalDiscountAmount_Base"></a> TotalDiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Discount Amount in base currency.|
|DisplayName|Total Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaldiscountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemAmount_Base"></a> TotalLineItemAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Detail Amount in base currency.|
|DisplayName|Total Detail Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemDiscountAmount_Base"></a> TotalLineItemDiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Line Item Discount Amount in base currency.|
|DisplayName|Total Line Item Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemdiscountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalTax_Base"></a> TotalTax_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Tax in base currency.|
|DisplayName|Total Tax (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaltax_base|
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


### <a name="BKMK_UniqueDscId"></a> UniqueDscId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Unique Dsc ID|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|uniquedscid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [quote_QuoteCloses](#BKMK_quote_QuoteCloses)
- [lk_opportunitysalesprocess_quoteid](#BKMK_lk_opportunitysalesprocess_quoteid)
- [quote_details](#BKMK_quote_details)
- [quote_orders](#BKMK_quote_orders)
- [Quote_QuoteClose](#BKMK_Quote_QuoteClose)
- [msdyn_playbookinstance_quote](#BKMK_msdyn_playbookinstance_quote)


### <a name="BKMK_quote_QuoteCloses"></a> quote_QuoteCloses

Same as the [quote_QuoteCloses](quoteclose.md#BKMK_quote_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quote_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lk_opportunitysalesprocess_quoteid"></a> lk_opportunitysalesprocess_quoteid

Same as the [lk_opportunitysalesprocess_quoteid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_quoteid) many-to-one relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunitysalesprocess|
|ReferencingAttribute|quoteid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quote_opportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_quote_details"></a> quote_details

Same as the [quote_details](quotedetail.md#BKMK_quote_details) many-to-one relationship for the [quotedetail](quotedetail.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|quoteid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quote_details|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_quote_orders"></a> quote_orders

Same as the [quote_orders](salesorder.md#BKMK_quote_orders) many-to-one relationship for the [salesorder](salesorder.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|quoteid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quote_orders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Quote_QuoteClose"></a> Quote_QuoteClose

Same as the [Quote_QuoteClose](quoteclose.md#BKMK_Quote_QuoteClose) many-to-one relationship for the [quoteclose](quoteclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|quoteid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Quote_QuoteClose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_quote"></a> msdyn_playbookinstance_quote

**Added by**: Playbook Solution

Same as the [msdyn_playbookinstance_quote](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_quote) many-to-one relationship for the [msdyn_playbookinstance](msdyn_playbookinstance.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_quote|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [quote_customer_accounts](#BKMK_quote_customer_accounts)
- [quote_customer_contacts](#BKMK_quote_customer_contacts)
- [opportunity_quotes](#BKMK_opportunity_quotes)
- [price_level_quotes](#BKMK_price_level_quotes)
- [campaign_quotes](#BKMK_campaign_quotes)


### <a name="BKMK_quote_customer_accounts"></a> quote_customer_accounts

**Added by**: System Solution Solution

See the [quote_customer_accounts](account.md#BKMK_quote_customer_accounts) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_quote_customer_contacts"></a> quote_customer_contacts

**Added by**: System Solution Solution

See the [quote_customer_contacts](contact.md#BKMK_quote_customer_contacts) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_opportunity_quotes"></a> opportunity_quotes

See the [opportunity_quotes](opportunity.md#BKMK_opportunity_quotes) one-to-many relationship for the [opportunity](opportunity.md) table/entity.

### <a name="BKMK_price_level_quotes"></a> price_level_quotes

**Added by**: Product Management Solution

See the [price_level_quotes](pricelevel.md#BKMK_price_level_quotes) one-to-many relationship for the [pricelevel](pricelevel.md) table/entity.

### <a name="BKMK_campaign_quotes"></a> campaign_quotes

**Added by**: Marketing Solution

See the [campaign_quotes](campaign.md#BKMK_campaign_quotes) one-to-many relationship for the [campaign](campaign.md) table/entity.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Quote table is the first table in the relationship. Listed by **SchemaName**.


### <a name="BKMK_contactquotes_association"></a> contactquotes_association

IntersectEntityName: contactquotes<br />
#### Table 1

|Property|Value|
|--------|-----|
|IntersectAttribute|quoteid|
|IsCustomizable|False|
|LogicalName|quote|
|NavigationPropertyName|contactquotes_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Table 2

|Property|Value|
|--------|-----|
|LogicalName|contact|
|IntersectAttribute|contactid|
|NavigationPropertyName|contactquotes_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### See also

[About the table reference](../about-entity-reference.md)<br />
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)<br />
