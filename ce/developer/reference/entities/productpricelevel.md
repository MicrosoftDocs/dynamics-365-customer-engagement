---
title: "Price List Item (ProductPriceLevel) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Price List Item (ProductPriceLevel) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Price List Item (ProductPriceLevel) table/entity reference (Microsoft Dynamics 365)

Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.

## Messages

The following table lists the messages for the Price List Item (ProductPriceLevel) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /productpricelevels<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /productpricelevels(*productpricelevelid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /productpricelevels(*productpricelevelid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /productpricelevels<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /productpricelevels(*productpricelevelid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /productpricelevels(*productpricelevelid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|

## Properties

The following table lists selected properties for the Price List Item (ProductPriceLevel) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Price List Item** |
| **DisplayCollectionName** | **Price List Items** |
| **SchemaName** | `ProductPriceLevel` |
| **CollectionSchemaName** | `ProductPriceLevels` |
| **EntitySetName** | `productpricelevels`|
| **LogicalName** | `productpricelevel` |
| **LogicalCollectionName** | `productpricelevels` |
| **PrimaryIdAttribute** | `productpricelevelid` |
| **PrimaryNameAttribute** |`productidname` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

|Property|Value|
|---|---|
|Description|**Monetary amount for the price list.**|
|DisplayName|**Amount**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`amount`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_DiscountTypeId"></a> DiscountTypeId

|Property|Value|
|---|---|
|Description|**Unique identifier of the discount list associated with the price list.**|
|DisplayName|**Discount List**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`discounttypeid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|discounttype|

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

### <a name="BKMK_Percentage"></a> Percentage

|Property|Value|
|---|---|
|Description|**Percentage for the price list.**|
|DisplayName|**Percentage**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`percentage`|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|---|---|
|Description|**Unique identifier of the price level associated with this price list.**|
|DisplayName|**Price List**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`pricelevelid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_PricingMethodCode"></a> PricingMethodCode

|Property|Value|
|---|---|
|Description|**Pricing method applied to the price list.**|
|DisplayName|**Pricing Method**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`pricingmethodcode`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`productpricelevel_pricingmethodcode`|

#### PricingMethodCode Choices/Options

|Value|Label|
|---|---|
|1|**Currency Amount**|
|2|**Percent of List**|
|3|**Percent Markup - Current Cost**|
|4|**Percent Margin - Current Cost**|
|5|**Percent Markup - Standard Cost**|
|6|**Percent Margin - Standard Cost**|

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|---|---|
|Description|**Product associated with the price list.**|
|DisplayName|**Product**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`productid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_ProductPriceLevelId"></a> ProductPriceLevelId

|Property|Value|
|---|---|
|Description|**Unique identifier of the price list.**|
|DisplayName|**Product Price List**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`productpricelevelid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_QuantitySellingCode"></a> QuantitySellingCode

|Property|Value|
|---|---|
|Description|**Quantity of the product that must be sold for a given price level.**|
|DisplayName|**Quantity Selling Option**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`quantitysellingcode`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`productpricelevel_quantitysellingcode`|

#### QuantitySellingCode Choices/Options

|Value|Label|
|---|---|
|1|**No Control**|
|2|**Whole**|
|3|**Whole and Fractional**|

### <a name="BKMK_RoundingOptionAmount"></a> RoundingOptionAmount

|Property|Value|
|---|---|
|Description|**Rounding option amount for the price list.**|
|DisplayName|**Rounding Amount**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`roundingoptionamount`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|100000000000000|
|MinValue|-100000000000000|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_RoundingOptionCode"></a> RoundingOptionCode

|Property|Value|
|---|---|
|Description|**Option for rounding the price list.**|
|DisplayName|**Rounding Option**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`roundingoptioncode`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`productpricelevel_roundingoptioncode`|

#### RoundingOptionCode Choices/Options

|Value|Label|
|---|---|
|1|**Ends in**|
|2|**Multiple of**|

### <a name="BKMK_RoundingPolicyCode"></a> RoundingPolicyCode

|Property|Value|
|---|---|
|Description|**Policy for rounding the price list.**|
|DisplayName|**Rounding Policy**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`roundingpolicycode`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`productpricelevel_roundingpolicycode`|

#### RoundingPolicyCode Choices/Options

|Value|Label|
|---|---|
|1|**None**|
|2|**Up**|
|3|**Down**|
|4|**To Nearest**|

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**(Deprecated) Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**(Deprecated) Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_UoMId"></a> UoMId

|Property|Value|
|---|---|
|Description|**Unique identifier of the unit for the price list.**|
|DisplayName|**Unit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`uomid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

|Property|Value|
|---|---|
|Description|**Unique identifier of the unit schedule for the price list.**|
|DisplayName|**Unit Schedule ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`uomscheduleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|uomschedule|

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


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [Amount_Base](#BKMK_Amount_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [ProductNumber](#BKMK_ProductNumber)
- [RoundingOptionAmount_Base](#BKMK_RoundingOptionAmount_Base)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_Amount_Base"></a> Amount_Base

|Property|Value|
|---|---|
|Description|**Value of the Amount in base currency.**|
|DisplayName|**Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`amount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the price list.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the price list was created.**|
|DisplayName|**Created On**|
|IsValidForForm|False|
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

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the price list.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the price list was last modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|False|
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier of the organization associated with the price list.**|
|DisplayName|**Organization**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ProductNumber"></a> ProductNumber

|Property|Value|
|---|---|
|Description|**User-defined product number.**|
|DisplayName|**Product ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productnumber`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_RoundingOptionAmount_Base"></a> RoundingOptionAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Rounding Amount in base currency.**|
|DisplayName|**Rounding Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`roundingoptionamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

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

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [discount_type_product_price_levels](#BKMK_discount_type_product_price_levels)
- [lk_productpricelevel_createdonbehalfby](#BKMK_lk_productpricelevel_createdonbehalfby)
- [lk_productpricelevel_modifiedonbehalfby](#BKMK_lk_productpricelevel_modifiedonbehalfby)
- [lk_productpricelevelbase_createdby](#BKMK_lk_productpricelevelbase_createdby)
- [lk_productpricelevelbase_modifiedby](#BKMK_lk_productpricelevelbase_modifiedby)
- [price_level_product_price_levels](#BKMK_price_level_product_price_levels)
- [processstage_productpricelevels](#BKMK_processstage_productpricelevels)
- [product_price_levels](#BKMK_product_price_levels)
- [transactioncurrency_productpricelevel](#BKMK_transactioncurrency_productpricelevel)
- [unit_of_measure_schedule_product_price_level](#BKMK_unit_of_measure_schedule_product_price_level)
- [unit_of_measurement_product_price_levels](#BKMK_unit_of_measurement_product_price_levels)

### <a name="BKMK_discount_type_product_price_levels"></a> discount_type_product_price_levels

One-To-Many Relationship: [discounttype discount_type_product_price_levels](discounttype.md#BKMK_discount_type_product_price_levels)

|Property|Value|
|---|---|
|ReferencedEntity|`discounttype`|
|ReferencedAttribute|`discounttypeid`|
|ReferencingAttribute|`discounttypeid`|
|ReferencingEntityNavigationPropertyName|`discounttypeid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_productpricelevel_createdonbehalfby"></a> lk_productpricelevel_createdonbehalfby

One-To-Many Relationship: [systemuser lk_productpricelevel_createdonbehalfby](systemuser.md#BKMK_lk_productpricelevel_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_productpricelevel_modifiedonbehalfby"></a> lk_productpricelevel_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_productpricelevel_modifiedonbehalfby](systemuser.md#BKMK_lk_productpricelevel_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_productpricelevelbase_createdby"></a> lk_productpricelevelbase_createdby

One-To-Many Relationship: [systemuser lk_productpricelevelbase_createdby](systemuser.md#BKMK_lk_productpricelevelbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_productpricelevelbase_modifiedby"></a> lk_productpricelevelbase_modifiedby

One-To-Many Relationship: [systemuser lk_productpricelevelbase_modifiedby](systemuser.md#BKMK_lk_productpricelevelbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_price_level_product_price_levels"></a> price_level_product_price_levels

One-To-Many Relationship: [pricelevel price_level_product_price_levels](pricelevel.md#BKMK_price_level_product_price_levels)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`pricelevelid`|
|ReferencingEntityNavigationPropertyName|`pricelevelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_productpricelevels"></a> processstage_productpricelevels

One-To-Many Relationship: [processstage processstage_productpricelevels](processstage.md#BKMK_processstage_productpricelevels)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_product_price_levels"></a> product_price_levels

One-To-Many Relationship: [product product_price_levels](product.md#BKMK_product_price_levels)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`productid`|
|ReferencingEntityNavigationPropertyName|`productid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_productpricelevel"></a> transactioncurrency_productpricelevel

One-To-Many Relationship: [transactioncurrency transactioncurrency_productpricelevel](transactioncurrency.md#BKMK_transactioncurrency_productpricelevel)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_unit_of_measure_schedule_product_price_level"></a> unit_of_measure_schedule_product_price_level

One-To-Many Relationship: [uomschedule unit_of_measure_schedule_product_price_level](uomschedule.md#BKMK_unit_of_measure_schedule_product_price_level)

|Property|Value|
|---|---|
|ReferencedEntity|`uomschedule`|
|ReferencedAttribute|`uomscheduleid`|
|ReferencingAttribute|`uomscheduleid`|
|ReferencingEntityNavigationPropertyName|`uomscheduleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_unit_of_measurement_product_price_levels"></a> unit_of_measurement_product_price_levels

One-To-Many Relationship: [uom unit_of_measurement_product_price_levels](uom.md#BKMK_unit_of_measurement_product_price_levels)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`uomid`|
|ReferencingEntityNavigationPropertyName|`uomid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [ProductPriceLevel_AsyncOperations](#BKMK_ProductPriceLevel_AsyncOperations)
- [ProductPriceLevel_BulkDeleteFailures](#BKMK_ProductPriceLevel_BulkDeleteFailures)
- [productpricelevel_MailboxTrackingFolders](#BKMK_productpricelevel_MailboxTrackingFolders)
- [productpricelevel_PrincipalObjectAttributeAccesses](#BKMK_productpricelevel_PrincipalObjectAttributeAccesses)
- [ProductPriceLevel_ProcessSessions](#BKMK_ProductPriceLevel_ProcessSessions)
- [ProductPriceLevel_SyncErrors](#BKMK_ProductPriceLevel_SyncErrors)

### <a name="BKMK_ProductPriceLevel_AsyncOperations"></a> ProductPriceLevel_AsyncOperations

Many-To-One Relationship: [asyncoperation ProductPriceLevel_AsyncOperations](asyncoperation.md#BKMK_ProductPriceLevel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ProductPriceLevel_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ProductPriceLevel_BulkDeleteFailures"></a> ProductPriceLevel_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure ProductPriceLevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ProductPriceLevel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ProductPriceLevel_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_productpricelevel_MailboxTrackingFolders"></a> productpricelevel_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder productpricelevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_productpricelevel_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`productpricelevel_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_productpricelevel_PrincipalObjectAttributeAccesses"></a> productpricelevel_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess productpricelevel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_productpricelevel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`productpricelevel_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ProductPriceLevel_ProcessSessions"></a> ProductPriceLevel_ProcessSessions

Many-To-One Relationship: [processsession ProductPriceLevel_ProcessSessions](processsession.md#BKMK_ProductPriceLevel_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ProductPriceLevel_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ProductPriceLevel_SyncErrors"></a> ProductPriceLevel_SyncErrors

Many-To-One Relationship: [syncerror ProductPriceLevel_SyncErrors](syncerror.md#BKMK_ProductPriceLevel_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ProductPriceLevel_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

