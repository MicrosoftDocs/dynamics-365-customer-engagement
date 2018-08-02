---
title: "PriceLevel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the PriceLevel entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# PriceLevel Entity Reference

Entity that defines pricing levels.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/pricelevels<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/pricelevels(*pricelevelid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/pricelevels(*pricelevelid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/pricelevels<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/pricelevels(*pricelevelid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/pricelevels(*pricelevelid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|PriceLevels|
|DisplayCollectionName|Price Lists|
|DisplayName|Price List|
|EntitySetName|pricelevels|
|IsBPFEntity|False|
|LogicalCollectionName|pricelevels|
|LogicalName|pricelevel|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|pricelevelid|
|PrimaryNameAttribute|name|
|SchemaName|PriceLevel|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BeginDate](#BKMK_BeginDate)
- [Description](#BKMK_Description)
- [EndDate](#BKMK_EndDate)
- [FreightTermsCode](#BKMK_FreightTermsCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BreakHoursBillable](#BKMK_msdyn_BreakHoursBillable)
- [msdyn_CopiedFromPriceLevel](#BKMK_msdyn_CopiedFromPriceLevel)
- [msdyn_Entity](#BKMK_msdyn_Entity)
- [msdyn_Module](#BKMK_msdyn_Module)
- [msdyn_TimeUnit](#BKMK_msdyn_TimeUnit)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [PaymentMethodCode](#BKMK_PaymentMethodCode)
- [PriceLevelId](#BKMK_PriceLevelId)
- [ShippingMethodCode](#BKMK_ShippingMethodCode)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BeginDate"></a> BeginDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date on which the price list becomes effective.|
|DisplayName|Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|begindate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the price list.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EndDate"></a> EndDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date that is the last day the price list is valid.|
|DisplayName|End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|enddate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_FreightTermsCode"></a> FreightTermsCode

|Property|Value|
|--------|-----|
|Description|Freight terms for the price list.|
|DisplayName|Freight Terms|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|freighttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### FreightTermsCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



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


### <a name="BKMK_msdyn_BreakHoursBillable"></a> msdyn_BreakHoursBillable

**Added by**: Field Service Solution<br />

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Break Hours Billable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_breakhoursbillable|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_BreakHoursBillable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_CopiedFromPriceLevel"></a> msdyn_CopiedFromPriceLevel

**Added by**: Project Service Automation Solution<br />

|Property|Value|
|--------|-----|
|Description|Shows the price level that this price level was copied from.|
|DisplayName|Copied From|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_copiedfrompricelevel|
|RequiredLevel|None|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_msdyn_Entity"></a> msdyn_Entity

**Added by**: Project Service Automation Solution<br />

|Property|Value|
|--------|-----|
|Description|Select the entity for this price level.|
|DisplayName|Entity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entity|
|RequiredLevel|Recommended|
|Type|Picklist|

#### msdyn_Entity Options

|Value|Label|
|-----|-----|
|192350000|Organization|
|192350001|Customer|
|192350002|Sales document|
|192350003|Project|



### <a name="BKMK_msdyn_Module"></a> msdyn_Module

**Added by**: Project Service Automation Solution<br />

|Property|Value|
|--------|-----|
|Description|Select the context for this price level i.e whether it is sales prices, cost prices or purchase prices|
|DisplayName|Context|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_module|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_Module Options

|Value|Label|
|-----|-----|
|192350000|Cost|
|192350001|Purchase|
|192350002|Sales|



### <a name="BKMK_msdyn_TimeUnit"></a> msdyn_TimeUnit

**Added by**: Project Service Automation Solution<br />

|Property|Value|
|--------|-----|
|Description|Select the default unit of role based time on this price list|
|DisplayName|Time Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timeunit|
|RequiredLevel|None|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the price list.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
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


### <a name="BKMK_PaymentMethodCode"></a> PaymentMethodCode

|Property|Value|
|--------|-----|
|Description|Payment terms to use with the price list.|
|DisplayName|Payment Method |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|paymentmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### PaymentMethodCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the price list.|
|DisplayName|Price List|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|pricelevelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Method of shipment for products in the price list.|
|DisplayName|Shipping Method|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### ShippingMethodCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the price list.|
|DisplayName|Status |
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|100001|Active|
|1|Inactive|100002|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the price list.|
|DisplayName|Status Reason|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|100001|Active|0|
|100002|Inactive|1|



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
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the price level.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|transactioncurrencyid|
|RequiredLevel|ApplicationRequired|
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
|MinValue|-2147483648|
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
- [msdyn_CopiedFromPriceLevelName](#BKMK_msdyn_CopiedFromPriceLevelName)
- [msdyn_TimeUnitName](#BKMK_msdyn_TimeUnitName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


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
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the pricelevel.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
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
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the pricelevel.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
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


### <a name="BKMK_msdyn_CopiedFromPriceLevelName"></a> msdyn_CopiedFromPriceLevelName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_copiedfrompricelevelname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TimeUnitName"></a> msdyn_TimeUnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_timeunitname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Added by**: Project Service Automation Solution<br />

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

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

- [PriceLevel_SyncErrors](#BKMK_PriceLevel_SyncErrors)
- [PriceLevel_AsyncOperations](#BKMK_PriceLevel_AsyncOperations)
- [pricelevel_MailboxTrackingFolders](#BKMK_pricelevel_MailboxTrackingFolders)
- [userentityinstancedata_pricelevel](#BKMK_userentityinstancedata_pricelevel)
- [PriceLevel_ProcessSessions](#BKMK_PriceLevel_ProcessSessions)
- [PriceLevel_BulkDeleteFailures](#BKMK_PriceLevel_BulkDeleteFailures)
- [pricelevel_principalobjectattributeaccess](#BKMK_pricelevel_principalobjectattributeaccess)
- [pricelevel_connections1](#BKMK_pricelevel_connections1)
- [pricelevel_connections2](#BKMK_pricelevel_connections2)
- [price_level_product_price_levels](#BKMK_price_level_product_price_levels)
- [price_level_accounts](#BKMK_price_level_accounts)
- [price_level_contacts](#BKMK_price_level_contacts)
- [price_level_products](#BKMK_price_level_products)
- [PriceList_Campaigns](#BKMK_PriceList_Campaigns)
- [price_level_invoices](#BKMK_price_level_invoices)
- [price_level_opportunties](#BKMK_price_level_opportunties)
- [price_level_orders](#BKMK_price_level_orders)
- [price_level_quotes](#BKMK_price_level_quotes)
- [msdyn_pricelevel_msdyn_actual_PriceList](#BKMK_msdyn_pricelevel_msdyn_actual_PriceList)
- [msdyn_pricelevel_msdyn_accountpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_accountpricelist_PriceList)
- [msdyn_pricelevel_msdyn_contactpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_contactpricelist_PriceList)
- [msdyn_pricelevel_msdyn_estimateline_PriceList](#BKMK_msdyn_pricelevel_msdyn_estimateline_PriceList)
- [msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList](#BKMK_msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList)
- [msdyn_pricelevel_msdyn_journalline_PriceList](#BKMK_msdyn_pricelevel_msdyn_journalline_PriceList)
- [msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList](#BKMK_msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList)
- [msdyn_pricelevel_msdyn_opportunitypricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_opportunitypricelist_PriceList)
- [msdyn_pricelevel_msdyn_orderlinetransaction_PriceList](#BKMK_msdyn_pricelevel_msdyn_orderlinetransaction_PriceList)
- [msdyn_pricelevel_msdyn_orderpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_orderpricelist_PriceList)
- [msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList)
- [msdyn_pricelevel_msdyn_projectpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_projectpricelist_PriceList)
- [msdyn_pricelevel_msdyn_quotelinetransaction_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotelinetransaction_PriceList)
- [msdyn_pricelevel_msdyn_quotepricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotepricelist_PriceList)
- [msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList](#BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList)
- [msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList](#BKMK_msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList)
- [msdyn_pricelevel_pricelevel_CopiedFromPriceLevel](#BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel)
- [msdyn_pricelevel_msdyn_agreement_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreement_PriceList)
- [msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList)
- [msdyn_pricelevel_msdyn_agreementbookingservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList)
- [msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList)
- [msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList)
- [msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList)
- [msdyn_pricelevel_msdyn_quotebookingservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList)
- [msdyn_pricelevel_msdyn_rma_PriceList](#BKMK_msdyn_pricelevel_msdyn_rma_PriceList)
- [msdyn_pricelevel_msdyn_rmaproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList)
- [msdyn_pricelevel_msdyn_workorder_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorder_PriceList)
- [msdyn_pricelevel_msdyn_workorderproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList)
- [msdyn_pricelevel_msdyn_workorderservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList)
- [msdyn_pricelevel_msdyn_workordertype_PriceList](#BKMK_msdyn_pricelevel_msdyn_workordertype_PriceList)
- [msdyn_pricelevel_opportunityproduct_PriceList](#BKMK_msdyn_pricelevel_opportunityproduct_PriceList)
- [msdyn_pricelevel_quotedetail_PriceList](#BKMK_msdyn_pricelevel_quotedetail_PriceList)


### <a name="BKMK_PriceLevel_SyncErrors"></a> PriceLevel_SyncErrors

Same as syncerror entity [PriceLevel_SyncErrors](syncerror.md#BKMK_PriceLevel_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|PriceLevel_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_PriceLevel_AsyncOperations"></a> PriceLevel_AsyncOperations

Same as asyncoperation entity [PriceLevel_AsyncOperations](asyncoperation.md#BKMK_PriceLevel_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|PriceLevel_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_pricelevel_MailboxTrackingFolders"></a> pricelevel_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [pricelevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_pricelevel_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|pricelevel_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_userentityinstancedata_pricelevel"></a> userentityinstancedata_pricelevel

Same as userentityinstancedata entity [userentityinstancedata_pricelevel](userentityinstancedata.md#BKMK_userentityinstancedata_pricelevel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_pricelevel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_PriceLevel_ProcessSessions"></a> PriceLevel_ProcessSessions

Same as processsession entity [PriceLevel_ProcessSessions](processsession.md#BKMK_PriceLevel_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|PriceLevel_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_PriceLevel_BulkDeleteFailures"></a> PriceLevel_BulkDeleteFailures

Same as bulkdeletefailure entity [PriceLevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_PriceLevel_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|PriceLevel_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_pricelevel_principalobjectattributeaccess"></a> pricelevel_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [pricelevel_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_pricelevel_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|pricelevel_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_pricelevel_connections1"></a> pricelevel_connections1

Same as connection entity [pricelevel_connections1](connection.md#BKMK_pricelevel_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|pricelevel_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_pricelevel_connections2"></a> pricelevel_connections2

Same as connection entity [pricelevel_connections2](connection.md#BKMK_pricelevel_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|pricelevel_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_product_price_levels"></a> price_level_product_price_levels

Same as productpricelevel entity [price_level_product_price_levels](productpricelevel.md#BKMK_price_level_product_price_levels) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productpricelevel|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|price_level_product_price_levels|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_accounts"></a> price_level_accounts

Same as account entity [price_level_accounts](account.md#BKMK_price_level_accounts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|defaultpricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_accounts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_contacts"></a> price_level_contacts

Same as contact entity [price_level_contacts](contact.md#BKMK_price_level_contacts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|defaultpricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_contacts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_products"></a> price_level_products

Same as product entity [price_level_products](product.md#BKMK_price_level_products) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_products|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_PriceList_Campaigns"></a> PriceList_Campaigns

Same as campaign entity [PriceList_Campaigns](campaign.md#BKMK_PriceList_Campaigns) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaign|
|ReferencingAttribute|pricelistid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|PriceList_Campaigns|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_invoices"></a> price_level_invoices

Same as invoice entity [price_level_invoices](invoice.md#BKMK_price_level_invoices) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_invoices|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_opportunties"></a> price_level_opportunties

Same as opportunity entity [price_level_opportunties](opportunity.md#BKMK_price_level_opportunties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_opportunties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_orders"></a> price_level_orders

Same as salesorder entity [price_level_orders](salesorder.md#BKMK_price_level_orders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_orders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_quotes"></a> price_level_quotes

Same as quote entity [price_level_quotes](quote.md#BKMK_price_level_quotes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_quotes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_actual_PriceList"></a> msdyn_pricelevel_msdyn_actual_PriceList

Same as msdyn_actual entity [msdyn_pricelevel_msdyn_actual_PriceList](msdyn_actual.md#BKMK_msdyn_pricelevel_msdyn_actual_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_actual_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_accountpricelist_PriceList"></a> msdyn_pricelevel_msdyn_accountpricelist_PriceList

Same as msdyn_accountpricelist entity [msdyn_pricelevel_msdyn_accountpricelist_PriceList](msdyn_accountpricelist.md#BKMK_msdyn_pricelevel_msdyn_accountpricelist_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_accountpricelist|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_accountpricelist_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_contactpricelist_PriceList"></a> msdyn_pricelevel_msdyn_contactpricelist_PriceList

Same as msdyn_contactpricelist entity [msdyn_pricelevel_msdyn_contactpricelist_PriceList](msdyn_contactpricelist.md#BKMK_msdyn_pricelevel_msdyn_contactpricelist_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_contactpricelist|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_contactpricelist_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_estimateline_PriceList"></a> msdyn_pricelevel_msdyn_estimateline_PriceList

Same as msdyn_estimateline entity [msdyn_pricelevel_msdyn_estimateline_PriceList](msdyn_estimateline.md#BKMK_msdyn_pricelevel_msdyn_estimateline_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_estimateline_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList"></a> msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList

Same as msdyn_invoicelinetransaction entity [msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList](msdyn_invoicelinetransaction.md#BKMK_msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_journalline_PriceList"></a> msdyn_pricelevel_msdyn_journalline_PriceList

Same as msdyn_journalline entity [msdyn_pricelevel_msdyn_journalline_PriceList](msdyn_journalline.md#BKMK_msdyn_pricelevel_msdyn_journalline_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_journalline_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList"></a> msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList

Same as msdyn_opportunitylinetransaction entity [msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList](msdyn_opportunitylinetransaction.md#BKMK_msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_opportunitypricelist_PriceList"></a> msdyn_pricelevel_msdyn_opportunitypricelist_PriceList

Same as msdyn_opportunitypricelist entity [msdyn_pricelevel_msdyn_opportunitypricelist_PriceList](msdyn_opportunitypricelist.md#BKMK_msdyn_pricelevel_msdyn_opportunitypricelist_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitypricelist|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_opportunitypricelist_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_orderlinetransaction_PriceList"></a> msdyn_pricelevel_msdyn_orderlinetransaction_PriceList

Same as msdyn_orderlinetransaction entity [msdyn_pricelevel_msdyn_orderlinetransaction_PriceList](msdyn_orderlinetransaction.md#BKMK_msdyn_pricelevel_msdyn_orderlinetransaction_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_orderlinetransaction_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_orderpricelist_PriceList"></a> msdyn_pricelevel_msdyn_orderpricelist_PriceList

Same as msdyn_orderpricelist entity [msdyn_pricelevel_msdyn_orderpricelist_PriceList](msdyn_orderpricelist.md#BKMK_msdyn_pricelevel_msdyn_orderpricelist_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderpricelist|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_orderpricelist_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList"></a> msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList

Same as msdyn_projectparameterpricelist entity [msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList](msdyn_projectparameterpricelist.md#BKMK_msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectparameterpricelist|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_projectpricelist_PriceList"></a> msdyn_pricelevel_msdyn_projectpricelist_PriceList

Same as msdyn_projectpricelist entity [msdyn_pricelevel_msdyn_projectpricelist_PriceList](msdyn_projectpricelist.md#BKMK_msdyn_pricelevel_msdyn_projectpricelist_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectpricelist|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_projectpricelist_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: Projects<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_quotelinetransaction_PriceList"></a> msdyn_pricelevel_msdyn_quotelinetransaction_PriceList

Same as msdyn_quotelinetransaction entity [msdyn_pricelevel_msdyn_quotelinetransaction_PriceList](msdyn_quotelinetransaction.md#BKMK_msdyn_pricelevel_msdyn_quotelinetransaction_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_quotelinetransaction_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_quotepricelist_PriceList"></a> msdyn_pricelevel_msdyn_quotepricelist_PriceList

Same as msdyn_quotepricelist entity [msdyn_pricelevel_msdyn_quotepricelist_PriceList](msdyn_quotepricelist.md#BKMK_msdyn_pricelevel_msdyn_quotepricelist_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotepricelist|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_quotepricelist_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList"></a> msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList

Same as msdyn_resourcecategorypricelevel entity [msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorypricelevel|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList"></a> msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList

Same as msdyn_transactioncategorypricelevel entity [msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategorypricelevel|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel"></a> msdyn_pricelevel_pricelevel_CopiedFromPriceLevel

Same as pricelevel entity [msdyn_pricelevel_pricelevel_CopiedFromPriceLevel](pricelevel.md#BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|pricelevel|
|ReferencingAttribute|msdyn_copiedfrompricelevel|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_pricelevel_CopiedFromPriceLevel|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_agreement_PriceList"></a> msdyn_pricelevel_msdyn_agreement_PriceList

Same as msdyn_agreement entity [msdyn_pricelevel_msdyn_agreement_PriceList](msdyn_agreement.md#BKMK_msdyn_pricelevel_msdyn_agreement_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreement|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_agreement_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList"></a> msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList

Same as msdyn_agreementbookingproduct entity [msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList](msdyn_agreementbookingproduct.md#BKMK_msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingproduct|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Price List<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList"></a> msdyn_pricelevel_msdyn_agreementbookingservice_PriceList

Same as msdyn_agreementbookingservice entity [msdyn_pricelevel_msdyn_agreementbookingservice_PriceList](msdyn_agreementbookingservice.md#BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservice|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_agreementbookingservice_PriceList|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Price List<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList"></a> msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList

Same as msdyn_agreementinvoiceproduct entity [msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoiceproduct|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList"></a> msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList

Same as msdyn_fieldservicepricelistitem entity [msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicepricelistitem|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList"></a> msdyn_pricelevel_msdyn_quotebookingproduct_PriceList

Same as msdyn_quotebookingproduct entity [msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](msdyn_quotebookingproduct.md#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingproduct|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_quotebookingproduct_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList"></a> msdyn_pricelevel_msdyn_quotebookingservice_PriceList

Same as msdyn_quotebookingservice entity [msdyn_pricelevel_msdyn_quotebookingservice_PriceList](msdyn_quotebookingservice.md#BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservice|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_quotebookingservice_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_rma_PriceList"></a> msdyn_pricelevel_msdyn_rma_PriceList

Same as msdyn_rma entity [msdyn_pricelevel_msdyn_rma_PriceList](msdyn_rma.md#BKMK_msdyn_pricelevel_msdyn_rma_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rma|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_rma_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList"></a> msdyn_pricelevel_msdyn_rmaproduct_PriceList

Same as msdyn_rmaproduct entity [msdyn_pricelevel_msdyn_rmaproduct_PriceList](msdyn_rmaproduct.md#BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmaproduct|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_rmaproduct_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_workorder_PriceList"></a> msdyn_pricelevel_msdyn_workorder_PriceList

Same as msdyn_workorder entity [msdyn_pricelevel_msdyn_workorder_PriceList](msdyn_workorder.md#BKMK_msdyn_pricelevel_msdyn_workorder_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorder|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_workorder_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList"></a> msdyn_pricelevel_msdyn_workorderproduct_PriceList

Same as msdyn_workorderproduct entity [msdyn_pricelevel_msdyn_workorderproduct_PriceList](msdyn_workorderproduct.md#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_workorderproduct_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList"></a> msdyn_pricelevel_msdyn_workorderservice_PriceList

Same as msdyn_workorderservice entity [msdyn_pricelevel_msdyn_workorderservice_PriceList](msdyn_workorderservice.md#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_workorderservice_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_msdyn_workordertype_PriceList"></a> msdyn_pricelevel_msdyn_workordertype_PriceList

Same as msdyn_workordertype entity [msdyn_pricelevel_msdyn_workordertype_PriceList](msdyn_workordertype.md#BKMK_msdyn_pricelevel_msdyn_workordertype_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordertype|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_msdyn_workordertype_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_opportunityproduct_PriceList"></a> msdyn_pricelevel_opportunityproduct_PriceList

Same as opportunityproduct entity [msdyn_pricelevel_opportunityproduct_PriceList](opportunityproduct.md#BKMK_msdyn_pricelevel_opportunityproduct_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityproduct|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_opportunityproduct_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_pricelevel_quotedetail_PriceList"></a> msdyn_pricelevel_quotedetail_PriceList

Same as quotedetail entity [msdyn_pricelevel_quotedetail_PriceList](quotedetail.md#BKMK_msdyn_pricelevel_quotedetail_PriceList) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|msdyn_pricelist|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_pricelevel_quotedetail_PriceList|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_pricelevelbase_createdby](#BKMK_lk_pricelevelbase_createdby)
- [lk_pricelevel_createdonbehalfby](#BKMK_lk_pricelevel_createdonbehalfby)
- [lk_pricelevelbase_modifiedby](#BKMK_lk_pricelevelbase_modifiedby)
- [lk_pricelevel_modifiedonbehalfby](#BKMK_lk_pricelevel_modifiedonbehalfby)
- [organization_price_levels](#BKMK_organization_price_levels)
- [transactioncurrency_pricelevel](#BKMK_transactioncurrency_pricelevel)
- [msdyn_pricelevel_pricelevel_CopiedFromPriceLevel](#BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel)
- [msdyn_uom_pricelevel_TimeUnit](#BKMK_msdyn_uom_pricelevel_TimeUnit)


### <a name="BKMK_lk_pricelevelbase_createdby"></a> lk_pricelevelbase_createdby

See systemuser Entity [lk_pricelevelbase_createdby](systemuser.md#BKMK_lk_pricelevelbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_pricelevel_createdonbehalfby"></a> lk_pricelevel_createdonbehalfby

See systemuser Entity [lk_pricelevel_createdonbehalfby](systemuser.md#BKMK_lk_pricelevel_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_pricelevelbase_modifiedby"></a> lk_pricelevelbase_modifiedby

See systemuser Entity [lk_pricelevelbase_modifiedby](systemuser.md#BKMK_lk_pricelevelbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_pricelevel_modifiedonbehalfby"></a> lk_pricelevel_modifiedonbehalfby

See systemuser Entity [lk_pricelevel_modifiedonbehalfby](systemuser.md#BKMK_lk_pricelevel_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_price_levels"></a> organization_price_levels

See organization Entity [organization_price_levels](organization.md#BKMK_organization_price_levels) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_pricelevel"></a> transactioncurrency_pricelevel

See transactioncurrency Entity [transactioncurrency_pricelevel](transactioncurrency.md#BKMK_transactioncurrency_pricelevel) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel"></a> msdyn_pricelevel_pricelevel_CopiedFromPriceLevel

See pricelevel Entity [msdyn_pricelevel_pricelevel_CopiedFromPriceLevel](pricelevel.md#BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_pricelevel_TimeUnit"></a> msdyn_uom_pricelevel_TimeUnit

See uom Entity [msdyn_uom_pricelevel_TimeUnit](uom.md#BKMK_msdyn_uom_pricelevel_TimeUnit) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the PriceLevel entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_organizationalunit_pricelevel"></a> msdyn_organizationalunit_pricelevel

See msdyn_organizationalunit Entity [msdyn_organizationalunit_pricelevel](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_pricelevel) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.pricelevel?text=pricelevel EntityType" />