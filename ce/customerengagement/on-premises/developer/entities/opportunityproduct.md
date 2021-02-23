---
title: "OpportunityProduct Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the OpportunityProduct entity."
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
# OpportunityProduct Entity Reference

Association between an opportunity and a product.

**Added by**: Sales Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|CalculatePrice|<xref href="Microsoft.Dynamics.CRM.CalculatePrice?text=CalculatePrice Action" />|<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|
|Create|POST [*org URI*]/api/data/v9.0/opportunityproducts<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/opportunityproducts(*opportunityproductid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/opportunityproducts(*opportunityproductid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/opportunityproducts<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/opportunityproducts(*opportunityproductid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|OpportunityProducts|
|DisplayCollectionName|Opportunity Lines|
|DisplayName|Opportunity Line|
|EntitySetName|opportunityproducts|
|IsBPFEntity|False|
|LogicalCollectionName|opportunityproducts|
|LogicalName|opportunityproduct|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|opportunityproductid|
|PrimaryNameAttribute|opportunityproductname|
|SchemaName|OpportunityProduct|

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
- [OpportunityProductName](#BKMK_OpportunityProductName)
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
- [SequenceNumber](#BKMK_SequenceNumber)
- [SkipPriceCalculation](#BKMK_SkipPriceCalculation)
- [Tax](#BKMK_Tax)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UoMId](#BKMK_UoMId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BaseAmount"></a> BaseAmount

|Property|Value|
|--------|-----|
|Description|Shows the total price of the opportunity product, based on the price per unit, volume discount, and quantity.|
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
|Description|Type additional information to describe the opportunity product, such as manufacturing details.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EntityImage"></a> EntityImage

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|The default image for the entity.|
|DisplayName|Entity Image|
|IsPrimaryImage|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


### <a name="BKMK_ExtendedAmount"></a> ExtendedAmount

|Property|Value|
|--------|-----|
|Description|Shows the total amount due for the opportunity product, calculated on the Amount value minus the Manual Discount amount.|
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
|Description|Select whether the pricing on the opportunity product reflects an override of the product catalog pricing.|
|DisplayName|Price Overridden|
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
|Description|For system use only.|
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
|1|Write-In|
|0|Existing|

**DefaultValue**: False



### <a name="BKMK_LineItemNumber"></a> LineItemNumber

|Property|Value|
|--------|-----|
|Description|Type the line item number for the opportunity product to easily identify the product in the opportunity documents and make sure it's listed in the correct order.|
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
|Description|Type the manual discount amount for the opportunity product to deduct any negotiated or other savings from the product total.|
|DisplayName|Manual Discount Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|manualdiscountamount|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_BillingMethod"></a> msdyn_BillingMethod

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Billing method for the project opportunity line. Valid values are Time and Material and Fixed Price|
|DisplayName|Billing Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billingmethod|
|RequiredLevel|Recommended|
|Type|Picklist|

#### msdyn_BillingMethod Options

|Value|Label|
|-----|-----|
|192350000|Time and Material|
|192350001|Fixed Price|



### <a name="BKMK_msdyn_BudgetAmount"></a> msdyn_BudgetAmount

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Enter the customer budget amount for this opportunity line.|
|DisplayName|Budget Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_budgetamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_CostAmount"></a> msdyn_CostAmount

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Shows the total cost price of the product based on the cost price per unit and quantity.|
|DisplayName|Cost Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_costamount|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_CostPricePerUnit"></a> msdyn_CostPricePerUnit

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Cost price per unit of the product. The default is the cost price of the product.|
|DisplayName|Cost Price Per Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_costpriceperunit|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Enter the duration of the agreement|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_enddate"></a> msdyn_enddate

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the end date of the agreement|
|DisplayName|End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enddate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_LineType"></a> msdyn_LineType

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|The field to distinguish the order lines to be of project service or field service|
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



### <a name="BKMK_msdyn_pricelist"></a> msdyn_pricelist

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Select a price list for the opportunity line|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricelist|
|RequiredLevel|None|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_msdyn_Project"></a> msdyn_Project

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Select the project for this opportunity line.|
|DisplayName|Project|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_project|
|RequiredLevel|None|
|Targets|msdyn_project|
|Type|Lookup|


### <a name="BKMK_msdyn_serviceaccount"></a> msdyn_serviceaccount

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Select the service account for the opportunity line|
|DisplayName|Service Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccount|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_startdate"></a> msdyn_startdate

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Start date of the Agreement|
|DisplayName|Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OpportunityId"></a> OpportunityId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the opportunity with which the opportunity product is associated.|
|DisplayName|Opportunity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|opportunityid|
|RequiredLevel|SystemRequired|
|Targets|opportunity|
|Type|Lookup|


### <a name="BKMK_OpportunityProductId"></a> OpportunityProductId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the opportunity product.|
|DisplayName|Opportunity Product|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|opportunityproductid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_OpportunityProductName"></a> OpportunityProductName

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Opportunity Product Name. Added for 1:n Referential relationship|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|opportunityproductname|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


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
|Targets|opportunityproduct|
|Type|Lookup|


### <a name="BKMK_PricePerUnit"></a> PricePerUnit

|Property|Value|
|--------|-----|
|Description|Shows the price per unit of the opportunity product, based on the price list specified on the parent opportunity.|
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
|Description|Select the pricing error for the opportunity product.|
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
|Description|Unique identifier of the product line item association with bundle in the opportunity|
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
|Description|Type a detailed product description or additional notes about the opportunity product, such as talking points or product updates, that will assist the sales team when they discuss the product with the customer.|
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
|Description|Choose the product to include on the opportunity to link the product's pricing and other information to the opportunity.|
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
|Description|Type the amount or quantity of the product the customer would like to purchase.|
|DisplayName|Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|


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


### <a name="BKMK_SkipPriceCalculation"></a> SkipPriceCalculation

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Skip price calculation. Used with bulk update and bulk insert operations.|
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
|Description|Type the tax amount to be applied on the opportunity product.|
|DisplayName|Tax|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|tax|
|MaxValue|100000000000000|
|MinValue|-100000000000000|
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


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_timestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_url|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


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


### <a name="BKMK_ManualDiscountAmount_Base"></a> ManualDiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Manual Discount Amount in base currency.|
|DisplayName|Manual Discount Amount (Base)|
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
|Description|Unique identifier of the delegate user who last modified the opportunityproduct.|
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


### <a name="BKMK_msdyn_budgetamount_Base"></a> msdyn_budgetamount_Base

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Value of the Budget Amount in base currency.|
|DisplayName|Budget Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_budgetamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_costamount_Base"></a> msdyn_costamount_Base

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Value of the Cost Amount in base currency.|
|DisplayName|Cost Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_costamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_costpriceperunit_Base"></a> msdyn_costpriceperunit_Base

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Value of the Cost Price Per Unit in base currency.|
|DisplayName|Cost Price Per Unit (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_costpriceperunit_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_pricelistName"></a> msdyn_pricelistName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_pricelistname|
|MaxLength|100|
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


### <a name="BKMK_msdyn_serviceaccountName"></a> msdyn_serviceaccountName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccountname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_serviceaccountYomiName"></a> msdyn_serviceaccountYomiName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccountyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_OpportunityStateCode"></a> OpportunityStateCode

|Property|Value|
|--------|-----|
|Description|Select the status of the opportunity product.|
|DisplayName|Opportunity Status|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|opportunitystatecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### OpportunityStateCode Options

|Value|Label|
|-----|-----|




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

- [OpportunityProduct_SyncErrors](#BKMK_OpportunityProduct_SyncErrors)
- [OpportunityProduct_AsyncOperations](#BKMK_OpportunityProduct_AsyncOperations)
- [opportunityproduct_MailboxTrackingFolders](#BKMK_opportunityproduct_MailboxTrackingFolders)
- [OpportunityProduct_ProcessSessions](#BKMK_OpportunityProduct_ProcessSessions)
- [OpportunityProduct_BulkDeleteFailures](#BKMK_OpportunityProduct_BulkDeleteFailures)
- [opportunityproduct_principalobjectattributeaccess](#BKMK_opportunityproduct_principalobjectattributeaccess)
- [opportunityproduct_parent_opportunityproduct](#BKMK_opportunityproduct_parent_opportunityproduct)
- [OpportunityProduct_Dynamicpropertyinstance](#BKMK_OpportunityProduct_Dynamicpropertyinstance)
- [opportunityproduct_parentref_opportunityproduct](#BKMK_opportunityproduct_parentref_opportunityproduct)


### <a name="BKMK_OpportunityProduct_SyncErrors"></a> OpportunityProduct_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [OpportunityProduct_SyncErrors](syncerror.md#BKMK_OpportunityProduct_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|OpportunityProduct_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_OpportunityProduct_AsyncOperations"></a> OpportunityProduct_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [OpportunityProduct_AsyncOperations](asyncoperation.md#BKMK_OpportunityProduct_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|OpportunityProduct_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunityproduct_MailboxTrackingFolders"></a> opportunityproduct_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [opportunityproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_opportunityproduct_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunityproduct_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_OpportunityProduct_ProcessSessions"></a> OpportunityProduct_ProcessSessions

**Added by**: System Solution Solution

Same as processsession entity [OpportunityProduct_ProcessSessions](processsession.md#BKMK_OpportunityProduct_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|OpportunityProduct_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_OpportunityProduct_BulkDeleteFailures"></a> OpportunityProduct_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [OpportunityProduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_OpportunityProduct_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|OpportunityProduct_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunityproduct_principalobjectattributeaccess"></a> opportunityproduct_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [opportunityproduct_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_opportunityproduct_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|opportunityproduct_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunityproduct_parent_opportunityproduct"></a> opportunityproduct_parent_opportunityproduct

Same as opportunityproduct entity [opportunityproduct_parent_opportunityproduct](opportunityproduct.md#BKMK_opportunityproduct_parent_opportunityproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityproduct|
|ReferencingAttribute|parentbundleid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunityproduct_parent_opportunityproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_OpportunityProduct_Dynamicpropertyinstance"></a> OpportunityProduct_Dynamicpropertyinstance

Same as dynamicpropertyinstance entity [OpportunityProduct_Dynamicpropertyinstance](dynamicpropertyinstance.md#BKMK_OpportunityProduct_Dynamicpropertyinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyinstance|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|OpportunityProduct_Dynamicpropertyinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: Cascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunityproduct_parentref_opportunityproduct"></a> opportunityproduct_parentref_opportunityproduct

**Added by**: Sales Patch Solution

Same as opportunityproduct entity [opportunityproduct_parentref_opportunityproduct](opportunityproduct.md#BKMK_opportunityproduct_parentref_opportunityproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityproduct|
|ReferencingAttribute|parentbundleidref|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunityproduct_parentref_opportunityproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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
- [opportunityproduct_parentref_opportunityproduct](#BKMK_opportunityproduct_parentref_opportunityproduct)
- [msdyn_msdyn_project_opportunityproduct_Project](#BKMK_msdyn_msdyn_project_opportunityproduct_Project)
- [msdyn_account_opportunityproduct_ServiceAccount](#BKMK_msdyn_account_opportunityproduct_ServiceAccount)
- [msdyn_pricelevel_opportunityproduct_PriceList](#BKMK_msdyn_pricelevel_opportunityproduct_PriceList)


### <a name="BKMK_lk_opportunityproductbase_createdby"></a> lk_opportunityproductbase_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_opportunityproductbase_createdby](systemuser.md#BKMK_lk_opportunityproductbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_opportunityproduct_createdonbehalfby"></a> lk_opportunityproduct_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_opportunityproduct_createdonbehalfby](systemuser.md#BKMK_lk_opportunityproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_opportunityproductbase_modifiedby"></a> lk_opportunityproductbase_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_opportunityproductbase_modifiedby](systemuser.md#BKMK_lk_opportunityproductbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_opportunityproduct_modifiedonbehalfby"></a> lk_opportunityproduct_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_opportunityproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_opportunityproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_opportunityproduct"></a> user_opportunityproduct

**Added by**: System Solution Solution

See systemuser Entity [user_opportunityproduct](systemuser.md#BKMK_user_opportunityproduct) One-To-Many relationship.

### <a name="BKMK_team_opportunityproduct"></a> team_opportunityproduct

**Added by**: System Solution Solution

See team Entity [team_opportunityproduct](team.md#BKMK_team_opportunityproduct) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_opportunityproduct"></a> transactioncurrency_opportunityproduct

**Added by**: System Solution Solution

See transactioncurrency Entity [transactioncurrency_opportunityproduct](transactioncurrency.md#BKMK_transactioncurrency_opportunityproduct) One-To-Many relationship.

### <a name="BKMK_product_opportunities"></a> product_opportunities

See opportunity Entity [product_opportunities](opportunity.md#BKMK_product_opportunities) One-To-Many relationship.

### <a name="BKMK_opportunityproduct_parent_opportunityproduct"></a> opportunityproduct_parent_opportunityproduct

See opportunityproduct Entity [opportunityproduct_parent_opportunityproduct](opportunityproduct.md#BKMK_opportunityproduct_parent_opportunityproduct) One-To-Many relationship.

### <a name="BKMK_opportunity_products"></a> opportunity_products

**Added by**: Product Management Solution

See product Entity [opportunity_products](product.md#BKMK_opportunity_products) One-To-Many relationship.

### <a name="BKMK_productAssociation_opportunity_product"></a> productAssociation_opportunity_product

**Added by**: Product Management Solution

See productassociation Entity [productAssociation_opportunity_product](productassociation.md#BKMK_productAssociation_opportunity_product) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_opportunity_products"></a> unit_of_measurement_opportunity_products

**Added by**: Product Management Solution

See uom Entity [unit_of_measurement_opportunity_products](uom.md#BKMK_unit_of_measurement_opportunity_products) One-To-Many relationship.

### <a name="BKMK_opportunityproduct_parentref_opportunityproduct"></a> opportunityproduct_parentref_opportunityproduct

See opportunityproduct Entity [opportunityproduct_parentref_opportunityproduct](opportunityproduct.md#BKMK_opportunityproduct_parentref_opportunityproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_opportunityproduct_Project"></a> msdyn_msdyn_project_opportunityproduct_Project

**Added by**: Project Service Automation Solution

See msdyn_project Entity [msdyn_msdyn_project_opportunityproduct_Project](msdyn_project.md#BKMK_msdyn_msdyn_project_opportunityproduct_Project) One-To-Many relationship.

### <a name="BKMK_msdyn_account_opportunityproduct_ServiceAccount"></a> msdyn_account_opportunityproduct_ServiceAccount

**Added by**: System Solution Solution

See account Entity [msdyn_account_opportunityproduct_ServiceAccount](account.md#BKMK_msdyn_account_opportunityproduct_ServiceAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_opportunityproduct_PriceList"></a> msdyn_pricelevel_opportunityproduct_PriceList

**Added by**: Product Management Solution

See pricelevel Entity [msdyn_pricelevel_opportunityproduct_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_opportunityproduct_PriceList) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.opportunityproduct?text=opportunityproduct EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]