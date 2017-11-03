---
title: "OpportunityProduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the OpportunityProduct entity."
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
# OpportunityProduct Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Association between an opportunity and a product.

**Added by**: Sales Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|CalculatePrice|<xref href="Microsoft.Dynamics.CRM.CalculatePrice?text=CalculatePrice Action" />|<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|
|Create|POST [*org URI*]/api/data/v9.0/opportunityproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/opportunityproducts(*opportunityproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/opportunityproducts(*opportunityproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/opportunityproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/opportunityproducts(*opportunityproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Opportunity Line<br />
**DisplayCollectionName**: Opportunity Lines<br />
**SchemaName**: OpportunityProduct<br />
**CollectionSchemaName**: OpportunityProducts<br />
**LogicalName**: opportunityproduct<br />
**LogicalCollectionName**: opportunityproducts<br />
**EntitySetName**: opportunityproducts<br />
**PrimaryIdAttribute**: opportunityproductid<br />
**PrimaryNameAttribute**: productidname<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BaseAmount](#BKMK_BaseAmount)
- [Description](#BKMK_Description)
- [EntityImage](#BKMK_EntityImage)
- [ExtendedAmount](#BKMK_ExtendedAmount)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsPriceOverridden](#BKMK_IsPriceOverridden)
- [IsProductOverridden](#BKMK_IsProductOverridden)
- [LineItemNumber](#BKMK_LineItemNumber)
- [ManualDiscountAmount](#BKMK_ManualDiscountAmount)
- [msdyn_BillingMethod](#BKMK_msdyn_BillingMethod)
- [msdyn_BudgetAmount](#BKMK_msdyn_BudgetAmount)
- [msdyn_CostAmount](#BKMK_msdyn_CostAmount)
- [msdyn_CostPricePerUnit](#BKMK_msdyn_CostPricePerUnit)
- [msdyn_Duration](#BKMK_msdyn_Duration)
- [msdyn_enddate](#BKMK_msdyn_enddate)
- [msdyn_LineType](#BKMK_msdyn_LineType)
- [msdyn_pricelist](#BKMK_msdyn_pricelist)
- [msdyn_Project](#BKMK_msdyn_Project)
- [msdyn_serviceaccount](#BKMK_msdyn_serviceaccount)
- [msdyn_startdate](#BKMK_msdyn_startdate)
- [OpportunityId](#BKMK_OpportunityId)
- [OpportunityProductId](#BKMK_OpportunityProductId)
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
- [SequenceNumber](#BKMK_SequenceNumber)
- [Tax](#BKMK_Tax)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UoMId](#BKMK_UoMId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BaseAmount"></a> BaseAmount

**Description**: Shows the total price of the opportunity product, based on the price per unit, volume discount, and quantity.<br />
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

**Description**: Type additional information to describe the opportunity product, such as manufacturing details.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EntityImage"></a> EntityImage

**Description**: The default image for the entity.<br />
**DisplayName**: Entity Image<br />
**LogicalName**: entityimage<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Image<br />
**IsPrimaryImage**: False<br />
**MaxHeight**: 144<br />
**MaxWidth**: 144


### <a name="BKMK_ExtendedAmount"></a> ExtendedAmount

**Description**: Shows the total amount due for the opportunity product, calculated on the Amount value minus the Manual Discount amount.<br />
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


### <a name="BKMK_IsPriceOverridden"></a> IsPriceOverridden

**Description**: Select whether the pricing on the opportunity product reflects an override of the product catalog pricing.<br />
**DisplayName**: Price Overridden<br />
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

**Description**: For system use only.<br />
**DisplayName**: Select Product<br />
**LogicalName**: isproductoverridden<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Write-In
- **FalseOption Value**: 0 **Label**: Existing

**DefaultValue**: False


### <a name="BKMK_LineItemNumber"></a> LineItemNumber

**Description**: Type the line item number for the opportunity product to easily identify the product in the opportunity documents and make sure it's listed in the correct order.<br />
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

**Description**: Type the manual discount amount for the opportunity product to deduct any negotiated or other savings from the product total.<br />
**DisplayName**: Manual Discount Amount<br />
**LogicalName**: manualdiscountamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_BillingMethod"></a> msdyn_BillingMethod

**Added by**: Project Service Automation Solution<br />
**Description**: Billing method for the project opportunity line. Valid values are Time and Material and Fixed Price<br />
**DisplayName**: Billing Method<br />
**LogicalName**: msdyn_billingmethod<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Time and Material
- **Value**: 192350001 **Label**: Fixed Price



### <a name="BKMK_msdyn_BudgetAmount"></a> msdyn_BudgetAmount

**Added by**: Project Service Automation Solution<br />
**Description**: Enter the customer budget amount for this opportunity line.<br />
**DisplayName**: Budget Amount<br />
**LogicalName**: msdyn_budgetamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_CostAmount"></a> msdyn_CostAmount

**Added by**: Project Service Automation Solution<br />
**Description**: Shows the total cost price of the product based on the cost price per unit and quantity.<br />
**DisplayName**: Cost Amount<br />
**LogicalName**: msdyn_costamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_CostPricePerUnit"></a> msdyn_CostPricePerUnit

**Added by**: Project Service Automation Solution<br />
**Description**: Cost price per unit of the product. The default is the cost price of the product.<br />
**DisplayName**: Cost Price Per Unit<br />
**LogicalName**: msdyn_costpriceperunit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

**Added by**: Field Service Solution<br />
**Description**: Enter the duration of the agreement<br />
**DisplayName**: Duration<br />
**LogicalName**: msdyn_duration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_enddate"></a> msdyn_enddate

**Added by**: Field Service Solution<br />
**Description**: Enter the end date of the agreement<br />
**DisplayName**: End Date<br />
**LogicalName**: msdyn_enddate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_LineType"></a> msdyn_LineType

**Added by**: Project Service Automation Solution<br />
**Description**: The field to distinguish the order lines to be of project service or field service<br />
**DisplayName**: Line Type<br />
**LogicalName**: msdyn_linetype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Project Service Line
- **Value**: 690970001 **Label**: Field Service Line



### <a name="BKMK_msdyn_pricelist"></a> msdyn_pricelist

**Added by**: Field Service Solution<br />
**Description**: Select a price list for the opportunity line<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_Project"></a> msdyn_Project

**Added by**: Project Service Automation Solution<br />
**Description**: Select the project for this opportunity line.<br />
**DisplayName**: Project<br />
**LogicalName**: msdyn_project<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_project


### <a name="BKMK_msdyn_serviceaccount"></a> msdyn_serviceaccount

**Added by**: Field Service Solution<br />
**Description**: Select the service account for the opportunity line<br />
**DisplayName**: Service Account<br />
**LogicalName**: msdyn_serviceaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_startdate"></a> msdyn_startdate

**Added by**: Field Service Solution<br />
**Description**: Start date of the Agreement<br />
**DisplayName**: Start Date<br />
**LogicalName**: msdyn_startdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OpportunityId"></a> OpportunityId

**Description**: Unique identifier of the opportunity with which the opportunity product is associated.<br />
**DisplayName**: Opportunity<br />
**LogicalName**: opportunityid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: opportunity


### <a name="BKMK_OpportunityProductId"></a> OpportunityProductId

**Description**: Unique identifier of the opportunity product.<br />
**DisplayName**: Opportunity Product<br />
**LogicalName**: opportunityproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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

**Description**: Shows the price per unit of the opportunity product, based on the price list specified on the parent opportunity.<br />
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

**Description**: Select the pricing error for the opportunity product.<br />
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

**Description**: Unique identifier of the product line item association with bundle in the opportunity<br />
**DisplayName**: Bundle Item Association<br />
**LogicalName**: productassociationid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProductDescription"></a> ProductDescription

**Description**: Type a detailed product description or additional notes about the opportunity product, such as talking points or product updates, that will assist the sales team when they discuss the product with the customer.<br />
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

**Description**: Choose the product to include on the opportunity to link the product's pricing and other information to the opportunity.<br />
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

**Description**: Type the amount or quantity of the product the customer would like to purchase.<br />
**DisplayName**: Quantity<br />
**LogicalName**: quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 5


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


### <a name="BKMK_Tax"></a> Tax

**Description**: Type the tax amount to be applied on the opportunity product.<br />
**DisplayName**: Tax<br />
**LogicalName**: tax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: -100000000000000<br />
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
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
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
- [msdyn_budgetamount_Base](#BKMK_msdyn_budgetamount_Base)
- [msdyn_costamount_Base](#BKMK_msdyn_costamount_Base)
- [msdyn_costpriceperunit_Base](#BKMK_msdyn_costpriceperunit_Base)
- [msdyn_pricelistName](#BKMK_msdyn_pricelistName)
- [msdyn_ProjectName](#BKMK_msdyn_ProjectName)
- [msdyn_serviceaccountName](#BKMK_msdyn_serviceaccountName)
- [msdyn_serviceaccountYomiName](#BKMK_msdyn_serviceaccountYomiName)
- [OpportunityIdName](#BKMK_OpportunityIdName)
- [OpportunityStateCode](#BKMK_OpportunityStateCode)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PricePerUnit_Base](#BKMK_PricePerUnit_Base)
- [ProductIdName](#BKMK_ProductIdName)
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_timestamp<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_url<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_EntityImageId"></a> EntityImageId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


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


### <a name="BKMK_ManualDiscountAmount_Base"></a> ManualDiscountAmount_Base

**Description**: Value of the Manual Discount Amount in base currency.<br />
**DisplayName**: Manual Discount Amount (Base)<br />
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
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the opportunityproduct.<br />
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


### <a name="BKMK_msdyn_budgetamount_Base"></a> msdyn_budgetamount_Base

**Added by**: Project Service Automation Solution<br />
**Description**: Value of the Budget Amount in base currency.<br />
**DisplayName**: Budget Amount (Base)<br />
**LogicalName**: msdyn_budgetamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_costamount_Base"></a> msdyn_costamount_Base

**Added by**: Project Service Automation Solution<br />
**Description**: Value of the Cost Amount in base currency.<br />
**DisplayName**: Cost Amount (Base)<br />
**LogicalName**: msdyn_costamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_costpriceperunit_Base"></a> msdyn_costpriceperunit_Base

**Added by**: Project Service Automation Solution<br />
**Description**: Value of the Cost Price Per Unit in base currency.<br />
**DisplayName**: Cost Price Per Unit (Base)<br />
**LogicalName**: msdyn_costpriceperunit_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_pricelistName"></a> msdyn_pricelistName

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


### <a name="BKMK_msdyn_serviceaccountName"></a> msdyn_serviceaccountName

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


### <a name="BKMK_msdyn_serviceaccountYomiName"></a> msdyn_serviceaccountYomiName

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


### <a name="BKMK_OpportunityIdName"></a> OpportunityIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: opportunityidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OpportunityStateCode"></a> OpportunityStateCode

**Description**: Select the status of the opportunity product.<br />
**DisplayName**: Opportunity Status<br />
**LogicalName**: opportunitystatecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:




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

- [OpportunityProduct_SyncErrors](#BKMK_OpportunityProduct_SyncErrors)
- [OpportunityProduct_AsyncOperations](#BKMK_OpportunityProduct_AsyncOperations)
- [opportunityproduct_MailboxTrackingFolders](#BKMK_opportunityproduct_MailboxTrackingFolders)
- [userentityinstancedata_opportunityproduct](#BKMK_userentityinstancedata_opportunityproduct)
- [OpportunityProduct_ProcessSessions](#BKMK_OpportunityProduct_ProcessSessions)
- [OpportunityProduct_BulkDeleteFailures](#BKMK_OpportunityProduct_BulkDeleteFailures)
- [opportunityproduct_principalobjectattributeaccess](#BKMK_opportunityproduct_principalobjectattributeaccess)
- [opportunityproduct_parent_opportunityproduct](#BKMK_opportunityproduct_parent_opportunityproduct)
- [OpportunityProduct_Dynamicpropertyinstance](#BKMK_OpportunityProduct_Dynamicpropertyinstance)


### <a name="BKMK_OpportunityProduct_SyncErrors"></a> OpportunityProduct_SyncErrors

Same as syncerror entity [OpportunityProduct_SyncErrors](syncerror.md#BKMK_OpportunityProduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: OpportunityProduct_SyncErrors<br />
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


### <a name="BKMK_OpportunityProduct_AsyncOperations"></a> OpportunityProduct_AsyncOperations

Same as asyncoperation entity [OpportunityProduct_AsyncOperations](asyncoperation.md#BKMK_OpportunityProduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: OpportunityProduct_AsyncOperations<br />
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


### <a name="BKMK_opportunityproduct_MailboxTrackingFolders"></a> opportunityproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [opportunityproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_opportunityproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunityproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_opportunityproduct"></a> userentityinstancedata_opportunityproduct

Same as userentityinstancedata entity [userentityinstancedata_opportunityproduct](userentityinstancedata.md#BKMK_userentityinstancedata_opportunityproduct) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_opportunityproduct<br />
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


### <a name="BKMK_OpportunityProduct_ProcessSessions"></a> OpportunityProduct_ProcessSessions

Same as processsession entity [OpportunityProduct_ProcessSessions](processsession.md#BKMK_OpportunityProduct_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: OpportunityProduct_ProcessSessions<br />
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


### <a name="BKMK_OpportunityProduct_BulkDeleteFailures"></a> OpportunityProduct_BulkDeleteFailures

Same as bulkdeletefailure entity [OpportunityProduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_OpportunityProduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: OpportunityProduct_BulkDeleteFailures<br />
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


### <a name="BKMK_opportunityproduct_principalobjectattributeaccess"></a> opportunityproduct_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [opportunityproduct_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_opportunityproduct_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: opportunityproduct_principalobjectattributeaccess<br />
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


### <a name="BKMK_opportunityproduct_parent_opportunityproduct"></a> opportunityproduct_parent_opportunityproduct

Same as opportunityproduct entity [opportunityproduct_parent_opportunityproduct](opportunityproduct.md#BKMK_opportunityproduct_parent_opportunityproduct) Many-To-One relationship.

**ReferencingEntity**: opportunityproduct<br />
**ReferencingAttribute**: parentbundleid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunityproduct_parent_opportunityproduct<br />
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


### <a name="BKMK_OpportunityProduct_Dynamicpropertyinstance"></a> OpportunityProduct_Dynamicpropertyinstance

Same as dynamicpropertyinstance entity [OpportunityProduct_Dynamicpropertyinstance](dynamicpropertyinstance.md#BKMK_OpportunityProduct_Dynamicpropertyinstance) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyinstance<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: OpportunityProduct_Dynamicpropertyinstance<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_opportunityproductbase_createdby](#BKMK_lk_opportunityproductbase_createdby)
- [lk_opportunityproduct_createdonbehalfby](#BKMK_lk_opportunityproduct_createdonbehalfby)
- [lk_opportunityproductbase_modifiedby](#BKMK_lk_opportunityproductbase_modifiedby)
- [lk_opportunityproduct_modifiedonbehalfby](#BKMK_lk_opportunityproduct_modifiedonbehalfby)
- [user_opportunityproduct](#BKMK_user_opportunityproduct)
- [team_opportunityproduct](#BKMK_team_opportunityproduct)
- [transactioncurrency_opportunityproduct](#BKMK_transactioncurrency_opportunityproduct)
- [product_opportunities](#BKMK_product_opportunities)
- [opportunityproduct_parent_opportunityproduct](#BKMK_opportunityproduct_parent_opportunityproduct)
- [opportunity_products](#BKMK_opportunity_products)
- [productAssociation_opportunity_product](#BKMK_productAssociation_opportunity_product)
- [unit_of_measurement_opportunity_products](#BKMK_unit_of_measurement_opportunity_products)
- [msdyn_msdyn_project_opportunityproduct_Project](#BKMK_msdyn_msdyn_project_opportunityproduct_Project)
- [msdyn_account_opportunityproduct_ServiceAccount](#BKMK_msdyn_account_opportunityproduct_ServiceAccount)
- [msdyn_pricelevel_opportunityproduct_PriceList](#BKMK_msdyn_pricelevel_opportunityproduct_PriceList)


### <a name="BKMK_lk_opportunityproductbase_createdby"></a> lk_opportunityproductbase_createdby

See systemuser Entity [lk_opportunityproductbase_createdby](systemuser.md#BKMK_lk_opportunityproductbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_opportunityproduct_createdonbehalfby"></a> lk_opportunityproduct_createdonbehalfby

See systemuser Entity [lk_opportunityproduct_createdonbehalfby](systemuser.md#BKMK_lk_opportunityproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_opportunityproductbase_modifiedby"></a> lk_opportunityproductbase_modifiedby

See systemuser Entity [lk_opportunityproductbase_modifiedby](systemuser.md#BKMK_lk_opportunityproductbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_opportunityproduct_modifiedonbehalfby"></a> lk_opportunityproduct_modifiedonbehalfby

See systemuser Entity [lk_opportunityproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_opportunityproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_opportunityproduct"></a> user_opportunityproduct

See systemuser Entity [user_opportunityproduct](systemuser.md#BKMK_user_opportunityproduct) One-To-Many relationship.

### <a name="BKMK_team_opportunityproduct"></a> team_opportunityproduct

See team Entity [team_opportunityproduct](team.md#BKMK_team_opportunityproduct) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_opportunityproduct"></a> transactioncurrency_opportunityproduct

See transactioncurrency Entity [transactioncurrency_opportunityproduct](transactioncurrency.md#BKMK_transactioncurrency_opportunityproduct) One-To-Many relationship.

### <a name="BKMK_product_opportunities"></a> product_opportunities

See opportunity Entity [product_opportunities](opportunity.md#BKMK_product_opportunities) One-To-Many relationship.

### <a name="BKMK_opportunityproduct_parent_opportunityproduct"></a> opportunityproduct_parent_opportunityproduct

See opportunityproduct Entity [opportunityproduct_parent_opportunityproduct](opportunityproduct.md#BKMK_opportunityproduct_parent_opportunityproduct) One-To-Many relationship.

### <a name="BKMK_opportunity_products"></a> opportunity_products

See product Entity [opportunity_products](product.md#BKMK_opportunity_products) One-To-Many relationship.

### <a name="BKMK_productAssociation_opportunity_product"></a> productAssociation_opportunity_product

See productassociation Entity [productAssociation_opportunity_product](productassociation.md#BKMK_productAssociation_opportunity_product) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_opportunity_products"></a> unit_of_measurement_opportunity_products

See uom Entity [unit_of_measurement_opportunity_products](uom.md#BKMK_unit_of_measurement_opportunity_products) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_opportunityproduct_Project"></a> msdyn_msdyn_project_opportunityproduct_Project

See msdyn_project Entity [msdyn_msdyn_project_opportunityproduct_Project](msdyn_project.md#BKMK_msdyn_msdyn_project_opportunityproduct_Project) One-To-Many relationship.

### <a name="BKMK_msdyn_account_opportunityproduct_ServiceAccount"></a> msdyn_account_opportunityproduct_ServiceAccount

See account Entity [msdyn_account_opportunityproduct_ServiceAccount](account.md#BKMK_msdyn_account_opportunityproduct_ServiceAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_opportunityproduct_PriceList"></a> msdyn_pricelevel_opportunityproduct_PriceList

See pricelevel Entity [msdyn_pricelevel_opportunityproduct_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_opportunityproduct_PriceList) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.opportunityproduct?text=opportunityproduct EntityType" />