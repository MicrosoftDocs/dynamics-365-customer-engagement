---
title: "ProductPriceLevel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ProductPriceLevel entity."
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
# ProductPriceLevel Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/productpricelevels<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/productpricelevels(*productpricelevelid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/productpricelevels(*productpricelevelid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/productpricelevels<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/productpricelevels(*productpricelevelid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Price List Item<br />
**DisplayCollectionName**: Price List Items<br />
**SchemaName**: ProductPriceLevel<br />
**CollectionSchemaName**: ProductPriceLevels<br />
**LogicalName**: productpricelevel<br />
**LogicalCollectionName**: productpricelevels<br />
**EntitySetName**: productpricelevels<br />
**PrimaryIdAttribute**: productpricelevelid<br />
**PrimaryNameAttribute**: productidname<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Amount](#BKMK_Amount)
- [DiscountTypeId](#BKMK_DiscountTypeId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [Percentage](#BKMK_Percentage)
- [PriceLevelId](#BKMK_PriceLevelId)
- [PricingMethodCode](#BKMK_PricingMethodCode)
- [ProcessId](#BKMK_ProcessId)
- [ProductId](#BKMK_ProductId)
- [ProductPriceLevelId](#BKMK_ProductPriceLevelId)
- [QuantitySellingCode](#BKMK_QuantitySellingCode)
- [RoundingOptionAmount](#BKMK_RoundingOptionAmount)
- [RoundingOptionCode](#BKMK_RoundingOptionCode)
- [RoundingPolicyCode](#BKMK_RoundingPolicyCode)
- [StageId](#BKMK_StageId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UoMId](#BKMK_UoMId)
- [UoMScheduleId](#BKMK_UoMScheduleId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_Amount"></a> Amount

**Description**: Monetary amount for the price list.<br />
**DisplayName**: Amount<br />
**LogicalName**: amount<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_DiscountTypeId"></a> DiscountTypeId

**Description**: Unique identifier of the discount list associated with the price list.<br />
**DisplayName**: Discount List<br />
**LogicalName**: discounttypeid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: discounttype


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


### <a name="BKMK_Percentage"></a> Percentage

**Description**: Percentage for the price list.<br />
**DisplayName**: Percentage<br />
**LogicalName**: percentage<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_PriceLevelId"></a> PriceLevelId

**Description**: Unique identifier of the price level associated with this price list.<br />
**DisplayName**: Price List<br />
**LogicalName**: pricelevelid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_PricingMethodCode"></a> PricingMethodCode

**Description**: Pricing method applied to the price list.<br />
**DisplayName**: Pricing Method<br />
**LogicalName**: pricingmethodcode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Currency Amount
- **Value**: 2 **Label**: Percent of List
- **Value**: 3 **Label**: Percent Markup - Current Cost
- **Value**: 4 **Label**: Percent Margin - Current Cost
- **Value**: 5 **Label**: Percent Markup - Standard Cost
- **Value**: 6 **Label**: Percent Margin - Standard Cost



### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Contains the id of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProductId"></a> ProductId

**Description**: Product associated with the price list.<br />
**DisplayName**: Product<br />
**LogicalName**: productid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_ProductPriceLevelId"></a> ProductPriceLevelId

**Description**: Unique identifier of the price list.<br />
**DisplayName**: Product Price List<br />
**LogicalName**: productpricelevelid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_QuantitySellingCode"></a> QuantitySellingCode

**Description**: Quantity of the product that must be sold for a given price level.<br />
**DisplayName**: Quantity Selling Option<br />
**LogicalName**: quantitysellingcode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: No Control
- **Value**: 2 **Label**: Whole
- **Value**: 3 **Label**: Whole and Fractional



### <a name="BKMK_RoundingOptionAmount"></a> RoundingOptionAmount

**Description**: Rounding option amount for the price list.<br />
**DisplayName**: Rounding Amount<br />
**LogicalName**: roundingoptionamount<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: -100000000000000<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_RoundingOptionCode"></a> RoundingOptionCode

**Description**: Option for rounding the price list.<br />
**DisplayName**: Rounding Option<br />
**LogicalName**: roundingoptioncode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Ends in
- **Value**: 2 **Label**: Multiple of



### <a name="BKMK_RoundingPolicyCode"></a> RoundingPolicyCode

**Description**: Policy for rounding the price list.<br />
**DisplayName**: Rounding Policy<br />
**LogicalName**: roundingpolicycode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: None
- **Value**: 2 **Label**: Up
- **Value**: 3 **Label**: Down
- **Value**: 4 **Label**: To Nearest



### <a name="BKMK_StageId"></a> StageId

**Description**: Contains the id of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


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

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_UoMId"></a> UoMId

**Description**: Unique identifier of the unit for the price list.<br />
**DisplayName**: Unit<br />
**LogicalName**: uomid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

**Description**: Unique identifier of the unit schedule for the price list.<br />
**DisplayName**: Unit Schedule ID<br />
**LogicalName**: uomscheduleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uomschedule


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

- [Amount_Base](#BKMK_Amount_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [DiscountTypeIdName](#BKMK_DiscountTypeIdName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [PriceLevelIdName](#BKMK_PriceLevelIdName)
- [ProductIdName](#BKMK_ProductIdName)
- [ProductNumber](#BKMK_ProductNumber)
- [RoundingOptionAmount_Base](#BKMK_RoundingOptionAmount_Base)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [UoMIdName](#BKMK_UoMIdName)
- [UoMScheduleIdName](#BKMK_UoMScheduleIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_Amount_Base"></a> Amount_Base

**Description**: Value of the Amount in base currency.<br />
**DisplayName**: Amount (Base)<br />
**LogicalName**: amount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 1


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the price list.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: False<br />
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

**Description**: Date and time when the price list was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: False<br />
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


### <a name="BKMK_DiscountTypeIdName"></a> DiscountTypeIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: discounttypeidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the price list.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: False<br />
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

**Description**: Date and time when the price list was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: False<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization associated with the price list.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_PriceLevelIdName"></a> PriceLevelIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: pricelevelidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_ProductNumber"></a> ProductNumber

**Description**: User-defined product number.<br />
**DisplayName**: Product ID<br />
**LogicalName**: productnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_RoundingOptionAmount_Base"></a> RoundingOptionAmount_Base

**Description**: Value of the Rounding Amount in base currency.<br />
**DisplayName**: Rounding Amount (Base)<br />
**LogicalName**: roundingoptionamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 1


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


### <a name="BKMK_UoMScheduleIdName"></a> UoMScheduleIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: uomscheduleidname<br />
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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [ProductPriceLevel_SyncErrors](#BKMK_ProductPriceLevel_SyncErrors)
- [ProductPriceLevel_AsyncOperations](#BKMK_ProductPriceLevel_AsyncOperations)
- [productpricelevel_MailboxTrackingFolders](#BKMK_productpricelevel_MailboxTrackingFolders)
- [userentityinstancedata_productpricelevel](#BKMK_userentityinstancedata_productpricelevel)
- [ProductPriceLevel_ProcessSessions](#BKMK_ProductPriceLevel_ProcessSessions)
- [ProductPriceLevel_BulkDeleteFailures](#BKMK_ProductPriceLevel_BulkDeleteFailures)
- [productpricelevel_PrincipalObjectAttributeAccesses](#BKMK_productpricelevel_PrincipalObjectAttributeAccesses)


### <a name="BKMK_ProductPriceLevel_SyncErrors"></a> ProductPriceLevel_SyncErrors

Same as syncerror entity [ProductPriceLevel_SyncErrors](syncerror.md#BKMK_ProductPriceLevel_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ProductPriceLevel_SyncErrors<br />
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


### <a name="BKMK_ProductPriceLevel_AsyncOperations"></a> ProductPriceLevel_AsyncOperations

Same as asyncoperation entity [ProductPriceLevel_AsyncOperations](asyncoperation.md#BKMK_ProductPriceLevel_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ProductPriceLevel_AsyncOperations<br />
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


### <a name="BKMK_productpricelevel_MailboxTrackingFolders"></a> productpricelevel_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [productpricelevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_productpricelevel_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: productpricelevel_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_productpricelevel"></a> userentityinstancedata_productpricelevel

Same as userentityinstancedata entity [userentityinstancedata_productpricelevel](userentityinstancedata.md#BKMK_userentityinstancedata_productpricelevel) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_productpricelevel<br />
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


### <a name="BKMK_ProductPriceLevel_ProcessSessions"></a> ProductPriceLevel_ProcessSessions

Same as processsession entity [ProductPriceLevel_ProcessSessions](processsession.md#BKMK_ProductPriceLevel_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ProductPriceLevel_ProcessSessions<br />
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


### <a name="BKMK_ProductPriceLevel_BulkDeleteFailures"></a> ProductPriceLevel_BulkDeleteFailures

Same as bulkdeletefailure entity [ProductPriceLevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ProductPriceLevel_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ProductPriceLevel_BulkDeleteFailures<br />
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


### <a name="BKMK_productpricelevel_PrincipalObjectAttributeAccesses"></a> productpricelevel_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [productpricelevel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_productpricelevel_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: productpricelevel_PrincipalObjectAttributeAccesses<br />
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

- [lk_productpricelevelbase_createdby](#BKMK_lk_productpricelevelbase_createdby)
- [lk_productpricelevel_createdonbehalfby](#BKMK_lk_productpricelevel_createdonbehalfby)
- [lk_productpricelevelbase_modifiedby](#BKMK_lk_productpricelevelbase_modifiedby)
- [lk_productpricelevel_modifiedonbehalfby](#BKMK_lk_productpricelevel_modifiedonbehalfby)
- [processstage_productpricelevels](#BKMK_processstage_productpricelevels)
- [transactioncurrency_productpricelevel](#BKMK_transactioncurrency_productpricelevel)
- [price_level_product_price_levels](#BKMK_price_level_product_price_levels)
- [product_price_levels](#BKMK_product_price_levels)
- [unit_of_measurement_product_price_levels](#BKMK_unit_of_measurement_product_price_levels)
- [unit_of_measure_schedule_product_price_level](#BKMK_unit_of_measure_schedule_product_price_level)
- [discount_type_product_price_levels](#BKMK_discount_type_product_price_levels)


### <a name="BKMK_lk_productpricelevelbase_createdby"></a> lk_productpricelevelbase_createdby

See systemuser Entity [lk_productpricelevelbase_createdby](systemuser.md#BKMK_lk_productpricelevelbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_productpricelevel_createdonbehalfby"></a> lk_productpricelevel_createdonbehalfby

See systemuser Entity [lk_productpricelevel_createdonbehalfby](systemuser.md#BKMK_lk_productpricelevel_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_productpricelevelbase_modifiedby"></a> lk_productpricelevelbase_modifiedby

See systemuser Entity [lk_productpricelevelbase_modifiedby](systemuser.md#BKMK_lk_productpricelevelbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_productpricelevel_modifiedonbehalfby"></a> lk_productpricelevel_modifiedonbehalfby

See systemuser Entity [lk_productpricelevel_modifiedonbehalfby](systemuser.md#BKMK_lk_productpricelevel_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_processstage_productpricelevels"></a> processstage_productpricelevels

See processstage Entity [processstage_productpricelevels](processstage.md#BKMK_processstage_productpricelevels) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_productpricelevel"></a> transactioncurrency_productpricelevel

See transactioncurrency Entity [transactioncurrency_productpricelevel](transactioncurrency.md#BKMK_transactioncurrency_productpricelevel) One-To-Many relationship.

### <a name="BKMK_price_level_product_price_levels"></a> price_level_product_price_levels

See pricelevel Entity [price_level_product_price_levels](pricelevel.md#BKMK_price_level_product_price_levels) One-To-Many relationship.

### <a name="BKMK_product_price_levels"></a> product_price_levels

See product Entity [product_price_levels](product.md#BKMK_product_price_levels) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_product_price_levels"></a> unit_of_measurement_product_price_levels

See uom Entity [unit_of_measurement_product_price_levels](uom.md#BKMK_unit_of_measurement_product_price_levels) One-To-Many relationship.

### <a name="BKMK_unit_of_measure_schedule_product_price_level"></a> unit_of_measure_schedule_product_price_level

See uomschedule Entity [unit_of_measure_schedule_product_price_level](uomschedule.md#BKMK_unit_of_measure_schedule_product_price_level) One-To-Many relationship.

### <a name="BKMK_discount_type_product_price_levels"></a> discount_type_product_price_levels

See discounttype Entity [discount_type_product_price_levels](discounttype.md#BKMK_discount_type_product_price_levels) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.productpricelevel?text=productpricelevel EntityType" />