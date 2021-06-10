---
title: "ProductPriceLevel Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ProductPriceLevel entity."
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
# ProductPriceLevel Entity Reference

Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.

**Added by**: Product Management Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/productpricelevels<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/productpricelevels(*productpricelevelid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/productpricelevels(*productpricelevelid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/productpricelevels<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/productpricelevels(*productpricelevelid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ProductPriceLevels|
|DisplayCollectionName|Price List Items|
|DisplayName|Price List Item|
|EntitySetName|productpricelevels|
|IsBPFEntity|False|
|LogicalCollectionName|productpricelevels|
|LogicalName|productpricelevel|
|OwnershipType|None|
|PrimaryIdAttribute|productpricelevelid|
|PrimaryNameAttribute|productidname|
|SchemaName|ProductPriceLevel|

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

|Property|Value|
|--------|-----|
|Description|Monetary amount for the price list.|
|DisplayName|Amount|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|amount|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|ApplicationRequired|
|Type|Money|


### <a name="BKMK_DiscountTypeId"></a> DiscountTypeId

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the discount list associated with the price list.|
|DisplayName|Discount List|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|discounttypeid|
|RequiredLevel|None|
|Targets|discounttype|
|Type|Lookup|


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


### <a name="BKMK_Percentage"></a> Percentage

|Property|Value|
|--------|-----|
|Description|Percentage for the price list.|
|DisplayName|Percentage|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|percentage|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|


### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the price level associated with this price list.|
|DisplayName|Price List|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|pricelevelid|
|RequiredLevel|SystemRequired|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_PricingMethodCode"></a> PricingMethodCode

|Property|Value|
|--------|-----|
|Description|Pricing method applied to the price list.|
|DisplayName|Pricing Method|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricingmethodcode|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### PricingMethodCode Options

|Value|Label|
|-----|-----|
|1|Currency Amount|
|2|Percent of List|
|3|Percent Markup - Current Cost|
|4|Percent Margin - Current Cost|
|5|Percent Markup - Standard Cost|
|6|Percent Margin - Standard Cost|



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


### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|--------|-----|
|Description|Product associated with the price list.|
|DisplayName|Product|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|productid|
|RequiredLevel|SystemRequired|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_ProductPriceLevelId"></a> ProductPriceLevelId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the price list.|
|DisplayName|Product Price List|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|productpricelevelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_QuantitySellingCode"></a> QuantitySellingCode

|Property|Value|
|--------|-----|
|Description|Quantity of the product that must be sold for a given price level.|
|DisplayName|Quantity Selling Option|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|quantitysellingcode|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### QuantitySellingCode Options

|Value|Label|
|-----|-----|
|1|No Control|
|2|Whole|
|3|Whole and Fractional|



### <a name="BKMK_RoundingOptionAmount"></a> RoundingOptionAmount

|Property|Value|
|--------|-----|
|Description|Rounding option amount for the price list.|
|DisplayName|Rounding Amount|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|roundingoptionamount|
|MaxValue|100000000000000|
|MinValue|-100000000000000|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|ApplicationRequired|
|Type|Money|


### <a name="BKMK_RoundingOptionCode"></a> RoundingOptionCode

|Property|Value|
|--------|-----|
|Description|Option for rounding the price list.|
|DisplayName|Rounding Option|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|roundingoptioncode|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### RoundingOptionCode Options

|Value|Label|
|-----|-----|
|1|Ends in|
|2|Multiple of|



### <a name="BKMK_RoundingPolicyCode"></a> RoundingPolicyCode

|Property|Value|
|--------|-----|
|Description|Policy for rounding the price list.|
|DisplayName|Rounding Policy|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|roundingpolicycode|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### RoundingPolicyCode Options

|Value|Label|
|-----|-----|
|1|None|
|2|Up|
|3|Down|
|4|To Nearest|



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
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
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


### <a name="BKMK_UoMId"></a> UoMId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the unit for the price list.|
|DisplayName|Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uomid|
|RequiredLevel|ApplicationRequired|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the unit schedule for the price list.|
|DisplayName|Unit Schedule ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uomscheduleid|
|RequiredLevel|None|
|Targets|uomschedule|
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

|Property|Value|
|--------|-----|
|Description|Value of the Amount in base currency.|
|DisplayName|Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|amount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the price list.|
|DisplayName|Created By|
|IsValidForForm|False|
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
|Description|Date and time when the price list was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
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


### <a name="BKMK_DiscountTypeIdName"></a> DiscountTypeIdName

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|discounttypeidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
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


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the price list.|
|DisplayName|Modified By|
|IsValidForForm|False|
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
|Description|Date and time when the price list was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
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


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the price list.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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

|Property|Value|
|--------|-----|
|Description|User-defined product number.|
|DisplayName|Product ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|productnumber|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_RoundingOptionAmount_Base"></a> RoundingOptionAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Rounding Amount in base currency.|
|DisplayName|Rounding Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|roundingoptionamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1|
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


### <a name="BKMK_UoMScheduleIdName"></a> UoMScheduleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uomscheduleidname|
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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [ProductPriceLevel_SyncErrors](#BKMK_ProductPriceLevel_SyncErrors)
- [ProductPriceLevel_AsyncOperations](#BKMK_ProductPriceLevel_AsyncOperations)
- [productpricelevel_MailboxTrackingFolders](#BKMK_productpricelevel_MailboxTrackingFolders)
- [ProductPriceLevel_ProcessSessions](#BKMK_ProductPriceLevel_ProcessSessions)
- [ProductPriceLevel_BulkDeleteFailures](#BKMK_ProductPriceLevel_BulkDeleteFailures)
- [productpricelevel_PrincipalObjectAttributeAccesses](#BKMK_productpricelevel_PrincipalObjectAttributeAccesses)


### <a name="BKMK_ProductPriceLevel_SyncErrors"></a> ProductPriceLevel_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [ProductPriceLevel_SyncErrors](syncerror.md#BKMK_ProductPriceLevel_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ProductPriceLevel_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ProductPriceLevel_AsyncOperations"></a> ProductPriceLevel_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [ProductPriceLevel_AsyncOperations](asyncoperation.md#BKMK_ProductPriceLevel_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ProductPriceLevel_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_productpricelevel_MailboxTrackingFolders"></a> productpricelevel_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [productpricelevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_productpricelevel_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|productpricelevel_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ProductPriceLevel_ProcessSessions"></a> ProductPriceLevel_ProcessSessions

**Added by**: System Solution Solution

Same as processsession entity [ProductPriceLevel_ProcessSessions](processsession.md#BKMK_ProductPriceLevel_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ProductPriceLevel_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ProductPriceLevel_BulkDeleteFailures"></a> ProductPriceLevel_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [ProductPriceLevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ProductPriceLevel_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ProductPriceLevel_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_productpricelevel_PrincipalObjectAttributeAccesses"></a> productpricelevel_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [productpricelevel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_productpricelevel_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|productpricelevel_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

**Added by**: System Solution Solution

See systemuser Entity [lk_productpricelevelbase_createdby](systemuser.md#BKMK_lk_productpricelevelbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_productpricelevel_createdonbehalfby"></a> lk_productpricelevel_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_productpricelevel_createdonbehalfby](systemuser.md#BKMK_lk_productpricelevel_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_productpricelevelbase_modifiedby"></a> lk_productpricelevelbase_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_productpricelevelbase_modifiedby](systemuser.md#BKMK_lk_productpricelevelbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_productpricelevel_modifiedonbehalfby"></a> lk_productpricelevel_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_productpricelevel_modifiedonbehalfby](systemuser.md#BKMK_lk_productpricelevel_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_processstage_productpricelevels"></a> processstage_productpricelevels

**Added by**: System Solution Solution

See processstage Entity [processstage_productpricelevels](processstage.md#BKMK_processstage_productpricelevels) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_productpricelevel"></a> transactioncurrency_productpricelevel

**Added by**: System Solution Solution

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

**Added by**: Sales Solution

See discounttype Entity [discount_type_product_price_levels](discounttype.md#BKMK_discount_type_product_price_levels) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.productpricelevel?text=productpricelevel EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]