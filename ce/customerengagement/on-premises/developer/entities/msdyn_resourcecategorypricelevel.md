---
title: "msdyn_resourcecategorypricelevel Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_resourcecategorypricelevel entity."
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
# msdyn_resourcecategorypricelevel Entity Reference

List of prices by role on a price list.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels(*msdyn_resourcecategorypricelevelid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels(*msdyn_resourcecategorypricelevelid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels(*msdyn_resourcecategorypricelevelid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels(*msdyn_resourcecategorypricelevelid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_resourcecategorypricelevels|
|DisplayCollectionName|Role Prices|
|DisplayName|Role Price|
|EntitySetName|msdyn_resourcecategorypricelevels|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_resourcecategorypricelevels|
|LogicalName|msdyn_resourcecategorypricelevel|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_resourcecategorypricelevelid|
|PrimaryNameAttribute|msdyn_description|
|SchemaName|msdyn_resourcecategorypricelevel|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_bookableresource](#BKMK_msdyn_bookableresource)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_organizationalunit](#BKMK_msdyn_organizationalunit)
- [msdyn_percent](#BKMK_msdyn_percent)
- [msdyn_Price](#BKMK_msdyn_Price)
- [msdyn_PriceInPrimaryUnit](#BKMK_msdyn_PriceInPrimaryUnit)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_PrimaryUnit](#BKMK_msdyn_PrimaryUnit)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_resourcecategorypricelevelId](#BKMK_msdyn_resourcecategorypricelevelId)
- [msdyn_transactioncategory](#BKMK_msdyn_transactioncategory)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitSchedule](#BKMK_msdyn_UnitSchedule)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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


### <a name="BKMK_msdyn_bookableresource"></a> msdyn_bookableresource

|Property|Value|
|--------|-----|
|Description|Select the bookable resource that the price is being set for.|
|DisplayName|Resource|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookableresource|
|RequiredLevel|None|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|--------|-----|
|Description|Type the name of the custom entity.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_organizationalunit"></a> msdyn_organizationalunit

|Property|Value|
|--------|-----|
|Description|Select the organizational unit of the resource performing the work.|
|DisplayName|Resourcing Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_organizationalunit|
|RequiredLevel|None|
|Targets|msdyn_organizationalunit|
|Type|Lookup|


### <a name="BKMK_msdyn_percent"></a> msdyn_percent

|Property|Value|
|--------|-----|
|Description|Enter the markup percent over cost. This field is relevant only when the price calculation method selected is "Markup over cost."|
|DisplayName|Percent|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_percent|
|MaxValue|100000000000|
|MinValue|-100|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_Price"></a> msdyn_Price

|Property|Value|
|--------|-----|
|Description|Enter the price in time units of the role.|
|DisplayName|Price|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_price|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_PriceInPrimaryUnit"></a> msdyn_PriceInPrimaryUnit

|Property|Value|
|--------|-----|
|Description|Value of the price in primary unit of the unit group|
|DisplayName|Price In Primary Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_priceinprimaryunit|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|--------|-----|
|Description|Select the price list to which this price list item is being added.|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricelist|
|RequiredLevel|ApplicationRequired|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_msdyn_PrimaryUnit"></a> msdyn_PrimaryUnit

|Property|Value|
|--------|-----|
|Description|Select the primary unit of the unit schedule selected.|
|DisplayName|Primary Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_primaryunit|
|RequiredLevel|None|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_msdyn_ResourceCategory"></a> msdyn_ResourceCategory

|Property|Value|
|--------|-----|
|Description|Select the role that the price is being set for.|
|DisplayName|Role|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategory|
|RequiredLevel|None|
|Targets|bookableresourcecategory|
|Type|Lookup|


### <a name="BKMK_msdyn_resourcecategorypricelevelId"></a> msdyn_resourcecategorypricelevelId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Resource Category Price|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_resourcecategorypricelevelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_transactioncategory"></a> msdyn_transactioncategory

|Property|Value|
|--------|-----|
|Description|Select the transaction category that the price is being set for.|
|DisplayName|Transaction Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategory|
|RequiredLevel|None|
|Targets|msdyn_transactioncategory|
|Type|Lookup|


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|--------|-----|
|Description|Select the units of time in which role is being priced.|
|DisplayName|Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unit|
|RequiredLevel|None|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_msdyn_UnitSchedule"></a> msdyn_UnitSchedule

|Property|Value|
|--------|-----|
|Description|Select the unit schedule of the time unit selected.|
|DisplayName|Unit Schedule|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitschedule|
|RequiredLevel|None|
|Targets|uomschedule|
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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Resource Category Price|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Resource Category Price|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the currency associated with the entity.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_bookableresourceName](#BKMK_msdyn_bookableresourceName)
- [msdyn_organizationalunitName](#BKMK_msdyn_organizationalunitName)
- [msdyn_price_Base](#BKMK_msdyn_price_Base)
- [msdyn_pricecalculation](#BKMK_msdyn_pricecalculation)
- [msdyn_priceinprimaryunit_Base](#BKMK_msdyn_priceinprimaryunit_Base)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_PrimaryUnitName](#BKMK_msdyn_PrimaryUnitName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
- [msdyn_transactioncategoryName](#BKMK_msdyn_transactioncategoryName)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_UnitScheduleName](#BKMK_msdyn_UnitScheduleName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the entity with respect to the base currency.|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_bookableresourceName"></a> msdyn_bookableresourceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_bookableresourcename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_organizationalunitName"></a> msdyn_organizationalunitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_organizationalunitname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_price_Base"></a> msdyn_price_Base

|Property|Value|
|--------|-----|
|Description|Value of the Price in base currency.|
|DisplayName|Price (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_price_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_pricecalculation"></a> msdyn_pricecalculation

|Property|Value|
|--------|-----|
|Description|Select the price calculation method to determine the price as a function of cost. This field is only relevant for expense categories.|
|DisplayName|Price Calculation|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricecalculation|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_pricecalculation Options

|Value|Label|
|-----|-----|
|192350000|Price per unit|
|192350001|At cost|
|192350002|Markup percentage|



### <a name="BKMK_msdyn_priceinprimaryunit_Base"></a> msdyn_priceinprimaryunit_Base

|Property|Value|
|--------|-----|
|Description|Value of the Price In Primary Unit in base currency.|
|DisplayName|Price In Primary Unit (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_priceinprimaryunit_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_PriceListName"></a> msdyn_PriceListName

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


### <a name="BKMK_msdyn_PrimaryUnitName"></a> msdyn_PrimaryUnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_primaryunitname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ResourceCategoryName"></a> msdyn_ResourceCategoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategoryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_transactioncategoryName"></a> msdyn_transactioncategoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategoryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_UnitName"></a> msdyn_UnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_unitname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_UnitScheduleName"></a> msdyn_UnitScheduleName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_unitschedulename|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|None|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Added by**: Active Solution Solution

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


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

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

- [msdyn_resourcecategorypricelevel_SyncErrors](#BKMK_msdyn_resourcecategorypricelevel_SyncErrors)
- [msdyn_resourcecategorypricelevel_DuplicateMatchingRecord](#BKMK_msdyn_resourcecategorypricelevel_DuplicateMatchingRecord)
- [msdyn_resourcecategorypricelevel_DuplicateBaseRecord](#BKMK_msdyn_resourcecategorypricelevel_DuplicateBaseRecord)
- [msdyn_resourcecategorypricelevel_AsyncOperations](#BKMK_msdyn_resourcecategorypricelevel_AsyncOperations)
- [msdyn_resourcecategorypricelevel_MailboxTrackingFolders](#BKMK_msdyn_resourcecategorypricelevel_MailboxTrackingFolders)
- [msdyn_resourcecategorypricelevel_ProcessSession](#BKMK_msdyn_resourcecategorypricelevel_ProcessSession)
- [msdyn_resourcecategorypricelevel_BulkDeleteFailures](#BKMK_msdyn_resourcecategorypricelevel_BulkDeleteFailures)
- [msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses)
- [msdyn_resourcecategorypricelevel_Annotations](#BKMK_msdyn_resourcecategorypricelevel_Annotations)


### <a name="BKMK_msdyn_resourcecategorypricelevel_SyncErrors"></a> msdyn_resourcecategorypricelevel_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_resourcecategorypricelevel_SyncErrors](syncerror.md#BKMK_msdyn_resourcecategorypricelevel_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcecategorypricelevel_DuplicateMatchingRecord"></a> msdyn_resourcecategorypricelevel_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_resourcecategorypricelevel_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_resourcecategorypricelevel_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcecategorypricelevel_DuplicateBaseRecord"></a> msdyn_resourcecategorypricelevel_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_resourcecategorypricelevel_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_resourcecategorypricelevel_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcecategorypricelevel_AsyncOperations"></a> msdyn_resourcecategorypricelevel_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_resourcecategorypricelevel_AsyncOperations](asyncoperation.md#BKMK_msdyn_resourcecategorypricelevel_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcecategorypricelevel_MailboxTrackingFolders"></a> msdyn_resourcecategorypricelevel_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_resourcecategorypricelevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_resourcecategorypricelevel_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcecategorypricelevel_ProcessSession"></a> msdyn_resourcecategorypricelevel_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_resourcecategorypricelevel_ProcessSession](processsession.md#BKMK_msdyn_resourcecategorypricelevel_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcecategorypricelevel_BulkDeleteFailures"></a> msdyn_resourcecategorypricelevel_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_resourcecategorypricelevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_resourcecategorypricelevel_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses"></a> msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcecategorypricelevel_Annotations"></a> msdyn_resourcecategorypricelevel_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_resourcecategorypricelevel_Annotations](annotation.md#BKMK_msdyn_resourcecategorypricelevel_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_resourcecategorypricelevel_createdby](#BKMK_lk_msdyn_resourcecategorypricelevel_createdby)
- [lk_msdyn_resourcecategorypricelevel_createdonbehalfby](#BKMK_lk_msdyn_resourcecategorypricelevel_createdonbehalfby)
- [lk_msdyn_resourcecategorypricelevel_modifiedby](#BKMK_lk_msdyn_resourcecategorypricelevel_modifiedby)
- [lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby](#BKMK_lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby)
- [organization_msdyn_resourcecategorypricelevel](#BKMK_organization_msdyn_resourcecategorypricelevel)
- [TransactionCurrency_msdyn_resourcecategorypricelevel](#BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel)
- [msdyn_bookableresource_msdyn_resourcecategorypricelevel_bookableresource](#BKMK_msdyn_bookableresource_msdyn_resourcecategorypricelevel_bookableresource)
- [msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory)
- [msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory)
- [msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList](#BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList)
- [msdyn_resourcecategorypricelevel_organizationalunit](#BKMK_msdyn_resourcecategorypricelevel_organizationalunit)
- [msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit](#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit)
- [msdyn_uom_msdyn_resourcecategorypricelevel_Unit](#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit)
- [msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule)


### <a name="BKMK_lk_msdyn_resourcecategorypricelevel_createdby"></a> lk_msdyn_resourcecategorypricelevel_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_resourcecategorypricelevel_createdby](systemuser.md#BKMK_lk_msdyn_resourcecategorypricelevel_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcecategorypricelevel_createdonbehalfby"></a> lk_msdyn_resourcecategorypricelevel_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_resourcecategorypricelevel_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcecategorypricelevel_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcecategorypricelevel_modifiedby"></a> lk_msdyn_resourcecategorypricelevel_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_resourcecategorypricelevel_modifiedby](systemuser.md#BKMK_lk_msdyn_resourcecategorypricelevel_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby"></a> lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_resourcecategorypricelevel"></a> organization_msdyn_resourcecategorypricelevel

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_resourcecategorypricelevel](organization.md#BKMK_organization_msdyn_resourcecategorypricelevel) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel"></a> TransactionCurrency_msdyn_resourcecategorypricelevel

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_resourcecategorypricelevel](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_resourcecategorypricelevel_bookableresource"></a> msdyn_bookableresource_msdyn_resourcecategorypricelevel_bookableresource

**Added by**: Scheduling Solution

See bookableresource Entity [msdyn_bookableresource_msdyn_resourcecategorypricelevel_bookableresource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_resourcecategorypricelevel_bookableresource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory

**Added by**: Scheduling Solution

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList"></a> msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList

**Added by**: Product Management Solution

See pricelevel Entity [msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_organizationalunit"></a> msdyn_resourcecategorypricelevel_organizationalunit

**Added by**: Universal Resource Scheduling Solution

See msdyn_organizationalunit Entity [msdyn_resourcecategorypricelevel_organizationalunit](msdyn_organizationalunit.md#BKMK_msdyn_resourcecategorypricelevel_organizationalunit) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit"></a> msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit

**Added by**: Product Management Solution

See uom Entity [msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit](uom.md#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit"></a> msdyn_uom_msdyn_resourcecategorypricelevel_Unit

**Added by**: Product Management Solution

See uom Entity [msdyn_uom_msdyn_resourcecategorypricelevel_Unit](uom.md#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit) One-To-Many relationship.

### <a name="BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule"></a> msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule

**Added by**: Product Management Solution

See uomschedule Entity [msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule](uomschedule.md#BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_resourcecategorypricelevel?text=msdyn_resourcecategorypricelevel EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]