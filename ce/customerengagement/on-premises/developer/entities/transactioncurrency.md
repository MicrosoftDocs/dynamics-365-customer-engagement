---
title: "TransactionCurrency Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TransactionCurrency entity."
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
# TransactionCurrency Entity Reference

Currency in which a financial transaction is carried out.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/transactioncurrencies<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/transactioncurrencies(*transactioncurrencyid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/transactioncurrencies(*transactioncurrencyid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveExchangeRate|<xref href="Microsoft.Dynamics.CRM.RetrieveExchangeRate?text=RetrieveExchangeRate Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveExchangeRateRequest>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/transactioncurrencies<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/transactioncurrencies(*transactioncurrencyid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/transactioncurrencies(*transactioncurrencyid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|TransactionCurrencies|
|DisplayCollectionName|Currencies|
|DisplayName|Currency|
|EntitySetName|transactioncurrencies|
|IsBPFEntity|False|
|LogicalCollectionName|transactioncurrencies|
|LogicalName|transactioncurrency|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|transactioncurrencyid|
|PrimaryNameAttribute|currencyname|
|SchemaName|TransactionCurrency|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CurrencyName](#BKMK_CurrencyName)
- [CurrencyPrecision](#BKMK_CurrencyPrecision)
- [CurrencySymbol](#BKMK_CurrencySymbol)
- [EntityImage](#BKMK_EntityImage)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [ISOCurrencyCode](#BKMK_ISOCurrencyCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)


### <a name="BKMK_CurrencyName"></a> CurrencyName

|Property|Value|
|--------|-----|
|Description|Name of the transaction currency.|
|DisplayName|Currency Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|currencyname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CurrencyPrecision"></a> CurrencyPrecision

|Property|Value|
|--------|-----|
|Description|Number of decimal places that can be used for currency.|
|DisplayName|Currency Precision|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|currencyprecision|
|MaxValue|4|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_CurrencySymbol"></a> CurrencySymbol

|Property|Value|
|--------|-----|
|Description|Symbol for the transaction currency.|
|DisplayName|Currency Symbol|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|currencysymbol|
|MaxLength|10|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_EntityImage"></a> EntityImage

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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate between the transaction currency and the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|SystemRequired|
|Type|Decimal|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
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


### <a name="BKMK_ISOCurrencyCode"></a> ISOCurrencyCode

|Property|Value|
|--------|-----|
|Description|ISO currency code for the transaction currency.|
|DisplayName|Currency Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|isocurrencycode|
|MaxLength|5|
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


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the transaction currency.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the transaction currency.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the transaction currency.|
|DisplayName|Transaction Currency|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|transactioncurrencyid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [UniqueDscId](#BKMK_UniqueDscId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the transaction currency.|
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
|Description|Date and time when the transaction currency was created.|
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
|Description|Unique identifier of the delegate user who created the transactioncurrency.|
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
|Description|For internal use only.|
|DisplayName|Entity Image Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the transaction currency.|
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
|Description|Date and time when the transaction currency was last modified.|
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
|Description|Unique identifier of the delegate user who last modified the transactioncurrency.|
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
|Description|Unique identifier of the organization associated with the transaction currency.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_UniqueDscId"></a> UniqueDscId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|UniqueDscId|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|uniquedscid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the transaction currency.|
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

- [TransactionCurrency_Territory](#BKMK_TransactionCurrency_Territory)
- [transactioncurrency_lead](#BKMK_transactioncurrency_lead)
- [TransactionCurrency_LeadAddress](#BKMK_TransactionCurrency_LeadAddress)
- [transactioncurrency_product](#BKMK_transactioncurrency_product)
- [transactioncurrency_productpricelevel](#BKMK_transactioncurrency_productpricelevel)
- [DynamicPropertyAssociation_TransactionCurrency](#BKMK_DynamicPropertyAssociation_TransactionCurrency)
- [TransactionCurrency_Dynamicpropertyinsatance](#BKMK_TransactionCurrency_Dynamicpropertyinsatance)
- [DynamicPropertyOptionSetItem_TransactionCurrency](#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency)
- [transactioncurrency_ProductAssociation](#BKMK_transactioncurrency_ProductAssociation)
- [transactioncurrency_ProductSubstitute](#BKMK_transactioncurrency_ProductSubstitute)
- [transactioncurrency_pricelevel](#BKMK_transactioncurrency_pricelevel)
- [TransactionCurrency_bookableresource](#BKMK_TransactionCurrency_bookableresource)
- [TransactionCurrency_bookableresourcebooking](#BKMK_TransactionCurrency_bookableresourcebooking)
- [TransactionCurrency_bookableresourcebookingheader](#BKMK_TransactionCurrency_bookableresourcebookingheader)
- [TransactionCurrency_bookableresourcecategory](#BKMK_TransactionCurrency_bookableresourcecategory)
- [TransactionCurrency_bookableresourcecategoryassn](#BKMK_TransactionCurrency_bookableresourcecategoryassn)
- [TransactionCurrency_bookableresourcecharacteristic](#BKMK_TransactionCurrency_bookableresourcecharacteristic)
- [TransactionCurrency_bookableresourcegroup](#BKMK_TransactionCurrency_bookableresourcegroup)
- [TransactionCurrency_bookingstatus](#BKMK_TransactionCurrency_bookingstatus)
- [TransactionCurrency_characteristic](#BKMK_TransactionCurrency_characteristic)
- [TransactionCurrency_ratingmodel](#BKMK_TransactionCurrency_ratingmodel)
- [TransactionCurrency_ratingvalue](#BKMK_TransactionCurrency_ratingvalue)
- [bulkoperation_transactioncurrency_transactioncurrencyid](#BKMK_bulkoperation_transactioncurrency_transactioncurrencyid)
- [transactioncurrency_campaign](#BKMK_transactioncurrency_campaign)
- [transactioncurrency_campaignactivity](#BKMK_transactioncurrency_campaignactivity)
- [TransactionCurrency_CampaignResponse](#BKMK_TransactionCurrency_CampaignResponse)
- [transactioncurrency_list](#BKMK_transactioncurrency_list)
- [transactioncurrency_contract](#BKMK_transactioncurrency_contract)
- [transactioncurrency_contractdetail](#BKMK_transactioncurrency_contractdetail)
- [incidentresolution_transactioncurrency_transactioncurrencyid](#BKMK_incidentresolution_transactioncurrency_transactioncurrencyid)
- [TransactionCurrency_ServiceAppointment](#BKMK_TransactionCurrency_ServiceAppointment)
- [transactioncurrency_phonetocaseprocess](#BKMK_transactioncurrency_phonetocaseprocess)
- [TransactionCurrency_Equipment](#BKMK_TransactionCurrency_Equipment)
- [TransactionCurrency_Incident](#BKMK_TransactionCurrency_Incident)
- [TransactionCurrency_entitlementtemplatechannel](#BKMK_TransactionCurrency_entitlementtemplatechannel)
- [TransactionCurrency_Entitlement](#BKMK_TransactionCurrency_Entitlement)
- [TransactionCurrency_entitlementtemplate](#BKMK_TransactionCurrency_entitlementtemplate)
- [TransactionCurrency_entitlementchannel](#BKMK_TransactionCurrency_entitlementchannel)
- [transactioncurrency_knowledgearticleincident](#BKMK_transactioncurrency_knowledgearticleincident)
- [transactioncurrency_discount](#BKMK_transactioncurrency_discount)
- [transactioncurrency_invoice](#BKMK_transactioncurrency_invoice)
- [transactioncurrency_invoicedetail](#BKMK_transactioncurrency_invoicedetail)
- [transactioncurrency_opportunity](#BKMK_transactioncurrency_opportunity)
- [transactioncurrency_opportunityclose](#BKMK_transactioncurrency_opportunityclose)
- [transactioncurrency_opportunityproduct](#BKMK_transactioncurrency_opportunityproduct)
- [orderclose_transactioncurrency_transactioncurrencyid](#BKMK_orderclose_transactioncurrency_transactioncurrencyid)
- [transactioncurrency_quote](#BKMK_transactioncurrency_quote)
- [quoteclose_transactioncurrency_transactioncurrencyid](#BKMK_quoteclose_transactioncurrency_transactioncurrencyid)
- [transactioncurrency_quotedetail](#BKMK_transactioncurrency_quotedetail)
- [transactioncurrency_salesorder](#BKMK_transactioncurrency_salesorder)
- [transactioncurrency_salesorderdetail](#BKMK_transactioncurrency_salesorderdetail)
- [transactioncurrency_competitor](#BKMK_transactioncurrency_competitor)
- [transactioncurrency_discounttype](#BKMK_transactioncurrency_discounttype)
- [TransactionCurrency_SalesLiterature](#BKMK_TransactionCurrency_SalesLiterature)
- [transactioncurrency_leadtoopportunitysalesprocess](#BKMK_transactioncurrency_leadtoopportunitysalesprocess)
- [transactioncurrency_opportunitysalesprocess](#BKMK_transactioncurrency_opportunitysalesprocess)
- [TransactionCurrency_msdyn_forecastinstance](#BKMK_TransactionCurrency_msdyn_forecastinstance)
- [TransactionCurrency_msdyn_actual](#BKMK_TransactionCurrency_msdyn_actual)
- [msdyn_bookingalert_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid)
- [msdyn_approval_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_approval_transactioncurrency_transactioncurrencyid)
- [TransactionCurrency_msdyn_contractlinescheduleofvalue](#BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue)
- [TransactionCurrency_msdyn_estimateline](#BKMK_TransactionCurrency_msdyn_estimateline)
- [TransactionCurrency_msdyn_expense](#BKMK_TransactionCurrency_msdyn_expense)
- [TransactionCurrency_msdyn_fact](#BKMK_TransactionCurrency_msdyn_fact)
- [TransactionCurrency_msdyn_invoicelinetransaction](#BKMK_TransactionCurrency_msdyn_invoicelinetransaction)
- [TransactionCurrency_msdyn_journalline](#BKMK_TransactionCurrency_msdyn_journalline)
- [TransactionCurrency_msdyn_opportunitylinetransaction](#BKMK_TransactionCurrency_msdyn_opportunitylinetransaction)
- [TransactionCurrency_msdyn_orderlinetransaction](#BKMK_TransactionCurrency_msdyn_orderlinetransaction)
- [TransactionCurrency_msdyn_project](#BKMK_TransactionCurrency_msdyn_project)
- [TransactionCurrency_msdyn_projectapproval](#BKMK_TransactionCurrency_msdyn_projectapproval)
- [TransactionCurrency_msdyn_projecttask](#BKMK_TransactionCurrency_msdyn_projecttask)
- [TransactionCurrency_msdyn_quotelineanalyticsbreakdown](#BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown)
- [TransactionCurrency_msdyn_quotelinescheduleofvalue](#BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue)
- [TransactionCurrency_msdyn_quotelinetransaction](#BKMK_TransactionCurrency_msdyn_quotelinetransaction)
- [TransactionCurrency_msdyn_resourceassignment](#BKMK_TransactionCurrency_msdyn_resourceassignment)
- [TransactionCurrency_msdyn_resourcecategorypricelevel](#BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel)
- [TransactionCurrency_msdyn_resourcerequirement](#BKMK_TransactionCurrency_msdyn_resourcerequirement)
- [TransactionCurrency_msdyn_transactioncategorypricelevel](#BKMK_TransactionCurrency_msdyn_transactioncategorypricelevel)
- [msdyn_organizationalunit_currency](#BKMK_msdyn_organizationalunit_currency)
- [TransactionCurrency_msdyn_agreementbookingproduct](#BKMK_TransactionCurrency_msdyn_agreementbookingproduct)
- [TransactionCurrency_msdyn_agreementbookingservice](#BKMK_TransactionCurrency_msdyn_agreementbookingservice)
- [TransactionCurrency_msdyn_agreementinvoiceproduct](#BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct)
- [TransactionCurrency_msdyn_bookingjournal](#BKMK_TransactionCurrency_msdyn_bookingjournal)
- [TransactionCurrency_msdyn_fieldservicepricelistitem](#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem)
- [TransactionCurrency_msdyn_orderinvoicingproduct](#BKMK_TransactionCurrency_msdyn_orderinvoicingproduct)
- [TransactionCurrency_msdyn_payment](#BKMK_TransactionCurrency_msdyn_payment)
- [TransactionCurrency_msdyn_paymentdetail](#BKMK_TransactionCurrency_msdyn_paymentdetail)
- [TransactionCurrency_msdyn_purchaseorder](#BKMK_TransactionCurrency_msdyn_purchaseorder)
- [TransactionCurrency_msdyn_purchaseorderbill](#BKMK_TransactionCurrency_msdyn_purchaseorderbill)
- [TransactionCurrency_msdyn_purchaseorderproduct](#BKMK_TransactionCurrency_msdyn_purchaseorderproduct)
- [TransactionCurrency_msdyn_purchaseorderreceiptproduct](#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct)
- [TransactionCurrency_msdyn_quotebookingproduct](#BKMK_TransactionCurrency_msdyn_quotebookingproduct)
- [TransactionCurrency_msdyn_quotebookingservice](#BKMK_TransactionCurrency_msdyn_quotebookingservice)
- [TransactionCurrency_msdyn_quotebookingsetup](#BKMK_TransactionCurrency_msdyn_quotebookingsetup)
- [TransactionCurrency_msdyn_quoteinvoicingproduct](#BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct)
- [TransactionCurrency_msdyn_quoteinvoicingsetup](#BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup)
- [TransactionCurrency_msdyn_rma](#BKMK_TransactionCurrency_msdyn_rma)
- [TransactionCurrency_msdyn_rmaproduct](#BKMK_TransactionCurrency_msdyn_rmaproduct)
- [TransactionCurrency_msdyn_rtv](#BKMK_TransactionCurrency_msdyn_rtv)
- [TransactionCurrency_msdyn_rtvproduct](#BKMK_TransactionCurrency_msdyn_rtvproduct)
- [TransactionCurrency_msdyn_workorder](#BKMK_TransactionCurrency_msdyn_workorder)
- [TransactionCurrency_msdyn_workorderproduct](#BKMK_TransactionCurrency_msdyn_workorderproduct)
- [TransactionCurrency_msdyn_workorderservice](#BKMK_TransactionCurrency_msdyn_workorderservice)
- [msdyn_transactioncurrency_invoicedetail_Currency](#BKMK_msdyn_transactioncurrency_invoicedetail_Currency)
- [TransactionCurrency_Goal](#BKMK_TransactionCurrency_Goal)
- [TransactionCurrency_SharePointSite](#BKMK_TransactionCurrency_SharePointSite)
- [TransactionCurrency_QueueItem](#BKMK_TransactionCurrency_QueueItem)
- [transactioncurrency_actioncard](#BKMK_transactioncurrency_actioncard)
- [TransactionCurrency_officegraphdocument](#BKMK_TransactionCurrency_officegraphdocument)
- [TransactionCurrency_KnowledgeBaseRecord](#BKMK_TransactionCurrency_KnowledgeBaseRecord)
- [TransactionCurrency_ActionCardUserState](#BKMK_TransactionCurrency_ActionCardUserState)
- [TransactionCurrency_SharePointDocumentLocation](#BKMK_TransactionCurrency_SharePointDocumentLocation)
- [TransactionCurrency_SLAItem](#BKMK_TransactionCurrency_SLAItem)
- [transactioncurrency_expiredprocess](#BKMK_transactioncurrency_expiredprocess)
- [TransactionCurrency_ProcessSessions](#BKMK_TransactionCurrency_ProcessSessions)
- [TransactionCurrency_SyncErrors](#BKMK_TransactionCurrency_SyncErrors)
- [transactioncurrency_socialactivity](#BKMK_transactioncurrency_socialactivity)
- [TransactionCurrency_MailMergeTemplate](#BKMK_TransactionCurrency_MailMergeTemplate)
- [TransactionCurrency_UserMapping](#BKMK_TransactionCurrency_UserMapping)
- [transactioncurrency_fixedmonthlyfiscalcalendar](#BKMK_transactioncurrency_fixedmonthlyfiscalcalendar)
- [transactioncurrency_semiannualfiscalcalendar](#BKMK_transactioncurrency_semiannualfiscalcalendar)
- [TransactionCurrency_PhoneCall](#BKMK_TransactionCurrency_PhoneCall)
- [TransactionCurrency_Fax](#BKMK_TransactionCurrency_Fax)
- [transactioncurrency_usersettings](#BKMK_transactioncurrency_usersettings)
- [TransactionCurrency_ActivityPointer](#BKMK_TransactionCurrency_ActivityPointer)
- [transactioncurrency_category](#BKMK_transactioncurrency_category)
- [transactioncurrency_position](#BKMK_transactioncurrency_position)
- [TransactionCurrency_Task](#BKMK_TransactionCurrency_Task)
- [TransactionCurrency_SLA](#BKMK_TransactionCurrency_SLA)
- [basecurrency_organization](#BKMK_basecurrency_organization)
- [TransactionCurrency_Letter](#BKMK_TransactionCurrency_Letter)
- [TransactionCurrency_SystemUser](#BKMK_TransactionCurrency_SystemUser)
- [TransactionCurrency_Team](#BKMK_TransactionCurrency_Team)
- [TransactionCurrency_Email](#BKMK_TransactionCurrency_Email)
- [TransactionCurrency_BusinessUnit](#BKMK_TransactionCurrency_BusinessUnit)
- [transactioncurrency_SocialProfile](#BKMK_transactioncurrency_SocialProfile)
- [TransactionCurrency_Queue](#BKMK_TransactionCurrency_Queue)
- [TransactionCurrency_DuplicateMatchingRecord](#BKMK_TransactionCurrency_DuplicateMatchingRecord)
- [TransactionCurrency_Appointment](#BKMK_TransactionCurrency_Appointment)
- [transactioncurrency_quarterlyfiscalcalendar](#BKMK_transactioncurrency_quarterlyfiscalcalendar)
- [TransactionCurrency_KbArticle](#BKMK_TransactionCurrency_KbArticle)
- [transactioncurrency_monthlyfiscalcalendar](#BKMK_transactioncurrency_monthlyfiscalcalendar)
- [TransactionCurrency_CustomerAddress](#BKMK_TransactionCurrency_CustomerAddress)
- [transactioncurrency_annualfiscalcalendar](#BKMK_transactioncurrency_annualfiscalcalendar)
- [TransactionCurrency_Connection](#BKMK_TransactionCurrency_Connection)
- [transactioncurrency_translationprocess](#BKMK_transactioncurrency_translationprocess)
- [transactioncurrency_feedback](#BKMK_transactioncurrency_feedback)
- [transactioncurrency_contact](#BKMK_transactioncurrency_contact)
- [TransactionCurrency_ReportCategory](#BKMK_TransactionCurrency_ReportCategory)
- [TransactionCurrency_InteractionForEmail](#BKMK_TransactionCurrency_InteractionForEmail)
- [TransactionCurrency_slakpiinstance](#BKMK_TransactionCurrency_slakpiinstance)
- [TransactionCurrency_DuplicateBaseRecord](#BKMK_TransactionCurrency_DuplicateBaseRecord)
- [TransactionCurrency_AsyncOperations](#BKMK_TransactionCurrency_AsyncOperations)
- [transactioncurrency_knowledgearticleviews](#BKMK_transactioncurrency_knowledgearticleviews)
- [TransactionCurrency_Theme](#BKMK_TransactionCurrency_Theme)
- [transactioncurrency_newprocess](#BKMK_transactioncurrency_newprocess)
- [TransactionCurrency_knowledgearticle](#BKMK_TransactionCurrency_knowledgearticle)
- [TransactionCurrency_RecurringAppointmentMaster](#BKMK_TransactionCurrency_RecurringAppointmentMaster)
- [transactioncurrency_account](#BKMK_transactioncurrency_account)
- [TransactionCurrency_recommendeddocument](#BKMK_TransactionCurrency_recommendeddocument)


### <a name="BKMK_TransactionCurrency_Territory"></a> TransactionCurrency_Territory

**Added by**: Application Common Solution

Same as territory entity [TransactionCurrency_Territory](territory.md#BKMK_TransactionCurrency_Territory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|territory|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Territory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_lead"></a> transactioncurrency_lead

**Added by**: Lead Management Solution

Same as lead entity [transactioncurrency_lead](lead.md#BKMK_transactioncurrency_lead) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_LeadAddress"></a> TransactionCurrency_LeadAddress

**Added by**: Lead Management Solution

Same as leadaddress entity [TransactionCurrency_LeadAddress](leadaddress.md#BKMK_TransactionCurrency_LeadAddress) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|leadaddress|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_LeadAddress|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_product"></a> transactioncurrency_product

**Added by**: Product Management Solution

Same as product entity [transactioncurrency_product](product.md#BKMK_transactioncurrency_product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_productpricelevel"></a> transactioncurrency_productpricelevel

**Added by**: Product Management Solution

Same as productpricelevel entity [transactioncurrency_productpricelevel](productpricelevel.md#BKMK_transactioncurrency_productpricelevel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productpricelevel|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_productpricelevel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_DynamicPropertyAssociation_TransactionCurrency"></a> DynamicPropertyAssociation_TransactionCurrency

**Added by**: Product Management Solution

Same as dynamicpropertyassociation entity [DynamicPropertyAssociation_TransactionCurrency](dynamicpropertyassociation.md#BKMK_DynamicPropertyAssociation_TransactionCurrency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyassociation|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|DynamicPropertyAssociation_TransactionCurrency|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Dynamicpropertyinsatance"></a> TransactionCurrency_Dynamicpropertyinsatance

**Added by**: Product Management Solution

Same as dynamicpropertyinstance entity [TransactionCurrency_Dynamicpropertyinsatance](dynamicpropertyinstance.md#BKMK_TransactionCurrency_Dynamicpropertyinsatance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyinstance|
|ReferencingAttribute|dynamicpropertyinstanceid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Dynamicpropertyinsatance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_DynamicPropertyOptionSetItem_TransactionCurrency"></a> DynamicPropertyOptionSetItem_TransactionCurrency

**Added by**: Product Management Solution

Same as dynamicpropertyoptionsetitem entity [DynamicPropertyOptionSetItem_TransactionCurrency](dynamicpropertyoptionsetitem.md#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyoptionsetitem|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|DynamicPropertyOptionSetItem_TransactionCurrency|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_ProductAssociation"></a> transactioncurrency_ProductAssociation

**Added by**: Product Management Solution

Same as productassociation entity [transactioncurrency_ProductAssociation](productassociation.md#BKMK_transactioncurrency_ProductAssociation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productassociation|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_ProductAssociation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_ProductSubstitute"></a> transactioncurrency_ProductSubstitute

**Added by**: Product Management Solution

Same as productsubstitute entity [transactioncurrency_ProductSubstitute](productsubstitute.md#BKMK_transactioncurrency_ProductSubstitute) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productsubstitute|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_ProductSubstitute|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_pricelevel"></a> transactioncurrency_pricelevel

**Added by**: Product Management Solution

Same as pricelevel entity [transactioncurrency_pricelevel](pricelevel.md#BKMK_transactioncurrency_pricelevel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|pricelevel|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_pricelevel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_bookableresource"></a> TransactionCurrency_bookableresource

**Added by**: Scheduling Solution

Same as bookableresource entity [TransactionCurrency_bookableresource](bookableresource.md#BKMK_TransactionCurrency_bookableresource) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresource|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_bookableresource|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_bookableresourcebooking"></a> TransactionCurrency_bookableresourcebooking

**Added by**: Scheduling Solution

Same as bookableresourcebooking entity [TransactionCurrency_bookableresourcebooking](bookableresourcebooking.md#BKMK_TransactionCurrency_bookableresourcebooking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebooking|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_bookableresourcebooking|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_bookableresourcebookingheader"></a> TransactionCurrency_bookableresourcebookingheader

**Added by**: Scheduling Solution

Same as bookableresourcebookingheader entity [TransactionCurrency_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_TransactionCurrency_bookableresourcebookingheader) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebookingheader|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_bookableresourcebookingheader|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_bookableresourcecategory"></a> TransactionCurrency_bookableresourcecategory

**Added by**: Scheduling Solution

Same as bookableresourcecategory entity [TransactionCurrency_bookableresourcecategory](bookableresourcecategory.md#BKMK_TransactionCurrency_bookableresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecategory|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_bookableresourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_bookableresourcecategoryassn"></a> TransactionCurrency_bookableresourcecategoryassn

**Added by**: Scheduling Solution

Same as bookableresourcecategoryassn entity [TransactionCurrency_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_TransactionCurrency_bookableresourcecategoryassn) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecategoryassn|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_bookableresourcecategoryassn|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_bookableresourcecharacteristic"></a> TransactionCurrency_bookableresourcecharacteristic

**Added by**: Scheduling Solution

Same as bookableresourcecharacteristic entity [TransactionCurrency_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_TransactionCurrency_bookableresourcecharacteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecharacteristic|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_bookableresourcecharacteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_bookableresourcegroup"></a> TransactionCurrency_bookableresourcegroup

**Added by**: Scheduling Solution

Same as bookableresourcegroup entity [TransactionCurrency_bookableresourcegroup](bookableresourcegroup.md#BKMK_TransactionCurrency_bookableresourcegroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcegroup|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_bookableresourcegroup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_bookingstatus"></a> TransactionCurrency_bookingstatus

**Added by**: Scheduling Solution

Same as bookingstatus entity [TransactionCurrency_bookingstatus](bookingstatus.md#BKMK_TransactionCurrency_bookingstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookingstatus|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_bookingstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_characteristic"></a> TransactionCurrency_characteristic

**Added by**: Scheduling Solution

Same as characteristic entity [TransactionCurrency_characteristic](characteristic.md#BKMK_TransactionCurrency_characteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|characteristic|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_characteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_ratingmodel"></a> TransactionCurrency_ratingmodel

**Added by**: Scheduling Solution

Same as ratingmodel entity [TransactionCurrency_ratingmodel](ratingmodel.md#BKMK_TransactionCurrency_ratingmodel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|ratingmodel|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_ratingmodel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_ratingvalue"></a> TransactionCurrency_ratingvalue

**Added by**: Scheduling Solution

Same as ratingvalue entity [TransactionCurrency_ratingvalue](ratingvalue.md#BKMK_TransactionCurrency_ratingvalue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|ratingvalue|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_ratingvalue|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bulkoperation_transactioncurrency_transactioncurrencyid"></a> bulkoperation_transactioncurrency_transactioncurrencyid

**Added by**: Marketing Solution

Same as bulkoperation entity [bulkoperation_transactioncurrency_transactioncurrencyid](bulkoperation.md#BKMK_bulkoperation_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bulkoperation_transactioncurrency_transactioncurrencyid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_campaign"></a> transactioncurrency_campaign

**Added by**: Marketing Solution

Same as campaign entity [transactioncurrency_campaign](campaign.md#BKMK_transactioncurrency_campaign) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaign|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_campaign|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_campaignactivity"></a> transactioncurrency_campaignactivity

**Added by**: Marketing Solution

Same as campaignactivity entity [transactioncurrency_campaignactivity](campaignactivity.md#BKMK_transactioncurrency_campaignactivity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_campaignactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_CampaignResponse"></a> TransactionCurrency_CampaignResponse

**Added by**: Marketing Solution

Same as campaignresponse entity [TransactionCurrency_CampaignResponse](campaignresponse.md#BKMK_TransactionCurrency_CampaignResponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_CampaignResponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_list"></a> transactioncurrency_list

**Added by**: Marketing Solution

Same as list entity [transactioncurrency_list](list.md#BKMK_transactioncurrency_list) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|list|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_list|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_contract"></a> transactioncurrency_contract

**Added by**: Service Solution

Same as contract entity [transactioncurrency_contract](contract.md#BKMK_transactioncurrency_contract) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contract|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_contract|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_contractdetail"></a> transactioncurrency_contractdetail

**Added by**: Service Solution

Same as contractdetail entity [transactioncurrency_contractdetail](contractdetail.md#BKMK_transactioncurrency_contractdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contractdetail|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_contractdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_incidentresolution_transactioncurrency_transactioncurrencyid"></a> incidentresolution_transactioncurrency_transactioncurrencyid

**Added by**: Service Solution

Same as incidentresolution entity [incidentresolution_transactioncurrency_transactioncurrencyid](incidentresolution.md#BKMK_incidentresolution_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incidentresolution_transactioncurrency_transactioncurrencyid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_ServiceAppointment"></a> TransactionCurrency_ServiceAppointment

**Added by**: Service Solution

Same as serviceappointment entity [TransactionCurrency_ServiceAppointment](serviceappointment.md#BKMK_TransactionCurrency_ServiceAppointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_ServiceAppointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_phonetocaseprocess"></a> transactioncurrency_phonetocaseprocess

**Added by**: Service Solution

Same as phonetocaseprocess entity [transactioncurrency_phonetocaseprocess](phonetocaseprocess.md#BKMK_transactioncurrency_phonetocaseprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonetocaseprocess|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_phonetocaseprocess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Equipment"></a> TransactionCurrency_Equipment

**Added by**: Service Solution

Same as equipment entity [TransactionCurrency_Equipment](equipment.md#BKMK_TransactionCurrency_Equipment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|equipment|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Equipment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Incident"></a> TransactionCurrency_Incident

**Added by**: Service Solution

Same as incident entity [TransactionCurrency_Incident](incident.md#BKMK_TransactionCurrency_Incident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Incident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_entitlementtemplatechannel"></a> TransactionCurrency_entitlementtemplatechannel

**Added by**: Service Solution

Same as entitlementtemplatechannel entity [TransactionCurrency_entitlementtemplatechannel](entitlementtemplatechannel.md#BKMK_TransactionCurrency_entitlementtemplatechannel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementtemplatechannel|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_entitlementtemplatechannel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Entitlement"></a> TransactionCurrency_Entitlement

**Added by**: Service Solution

Same as entitlement entity [TransactionCurrency_Entitlement](entitlement.md#BKMK_TransactionCurrency_Entitlement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlement|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Entitlement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_entitlementtemplate"></a> TransactionCurrency_entitlementtemplate

**Added by**: Service Solution

Same as entitlementtemplate entity [TransactionCurrency_entitlementtemplate](entitlementtemplate.md#BKMK_TransactionCurrency_entitlementtemplate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementtemplate|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_entitlementtemplate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_entitlementchannel"></a> TransactionCurrency_entitlementchannel

**Added by**: Service Solution

Same as entitlementchannel entity [TransactionCurrency_entitlementchannel](entitlementchannel.md#BKMK_TransactionCurrency_entitlementchannel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementchannel|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_entitlementchannel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_knowledgearticleincident"></a> transactioncurrency_knowledgearticleincident

**Added by**: Service Solution

Same as knowledgearticleincident entity [transactioncurrency_knowledgearticleincident](knowledgearticleincident.md#BKMK_transactioncurrency_knowledgearticleincident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticleincident|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_knowledgearticleincident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_discount"></a> transactioncurrency_discount

**Added by**: Sales Solution

Same as discount entity [transactioncurrency_discount](discount.md#BKMK_transactioncurrency_discount) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|discount|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_discount|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_invoice"></a> transactioncurrency_invoice

**Added by**: Sales Solution

Same as invoice entity [transactioncurrency_invoice](invoice.md#BKMK_transactioncurrency_invoice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_invoice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_invoicedetail"></a> transactioncurrency_invoicedetail

**Added by**: Sales Solution

Same as invoicedetail entity [transactioncurrency_invoicedetail](invoicedetail.md#BKMK_transactioncurrency_invoicedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_invoicedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_opportunity"></a> transactioncurrency_opportunity

**Added by**: Sales Solution

Same as opportunity entity [transactioncurrency_opportunity](opportunity.md#BKMK_transactioncurrency_opportunity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_opportunity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_opportunityclose"></a> transactioncurrency_opportunityclose

**Added by**: Sales Solution

Same as opportunityclose entity [transactioncurrency_opportunityclose](opportunityclose.md#BKMK_transactioncurrency_opportunityclose) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_opportunityclose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_opportunityproduct"></a> transactioncurrency_opportunityproduct

**Added by**: Sales Solution

Same as opportunityproduct entity [transactioncurrency_opportunityproduct](opportunityproduct.md#BKMK_transactioncurrency_opportunityproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_opportunityproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_orderclose_transactioncurrency_transactioncurrencyid"></a> orderclose_transactioncurrency_transactioncurrencyid

**Added by**: Sales Solution

Same as orderclose entity [orderclose_transactioncurrency_transactioncurrencyid](orderclose.md#BKMK_orderclose_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|orderclose_transactioncurrency_transactioncurrencyid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_quote"></a> transactioncurrency_quote

**Added by**: Sales Solution

Same as quote entity [transactioncurrency_quote](quote.md#BKMK_transactioncurrency_quote) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_quote|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_quoteclose_transactioncurrency_transactioncurrencyid"></a> quoteclose_transactioncurrency_transactioncurrencyid

**Added by**: Sales Solution

Same as quoteclose entity [quoteclose_transactioncurrency_transactioncurrencyid](quoteclose.md#BKMK_quoteclose_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quoteclose_transactioncurrency_transactioncurrencyid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_quotedetail"></a> transactioncurrency_quotedetail

**Added by**: Sales Solution

Same as quotedetail entity [transactioncurrency_quotedetail](quotedetail.md#BKMK_transactioncurrency_quotedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_quotedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_salesorder"></a> transactioncurrency_salesorder

**Added by**: Sales Solution

Same as salesorder entity [transactioncurrency_salesorder](salesorder.md#BKMK_transactioncurrency_salesorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_salesorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_salesorderdetail"></a> transactioncurrency_salesorderdetail

**Added by**: Sales Solution

Same as salesorderdetail entity [transactioncurrency_salesorderdetail](salesorderdetail.md#BKMK_transactioncurrency_salesorderdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_salesorderdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_competitor"></a> transactioncurrency_competitor

**Added by**: Sales Solution

Same as competitor entity [transactioncurrency_competitor](competitor.md#BKMK_transactioncurrency_competitor) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|competitor|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_competitor|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_discounttype"></a> transactioncurrency_discounttype

**Added by**: Sales Solution

Same as discounttype entity [transactioncurrency_discounttype](discounttype.md#BKMK_transactioncurrency_discounttype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|discounttype|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_discounttype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_SalesLiterature"></a> TransactionCurrency_SalesLiterature

**Added by**: Sales Solution

Same as salesliterature entity [TransactionCurrency_SalesLiterature](salesliterature.md#BKMK_TransactionCurrency_SalesLiterature) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesliterature|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_SalesLiterature|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_leadtoopportunitysalesprocess"></a> transactioncurrency_leadtoopportunitysalesprocess

**Added by**: Sales Solution

Same as leadtoopportunitysalesprocess entity [transactioncurrency_leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md#BKMK_transactioncurrency_leadtoopportunitysalesprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|leadtoopportunitysalesprocess|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_leadtoopportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_opportunitysalesprocess"></a> transactioncurrency_opportunitysalesprocess

**Added by**: Sales Solution

Same as opportunitysalesprocess entity [transactioncurrency_opportunitysalesprocess](opportunitysalesprocess.md#BKMK_transactioncurrency_opportunitysalesprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunitysalesprocess|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_opportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_forecastinstance"></a> TransactionCurrency_msdyn_forecastinstance

**Added by**: Active Solution Solution

Same as msdyn_forecastinstance entity [TransactionCurrency_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_TransactionCurrency_msdyn_forecastinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_forecastinstance|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_forecastinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_actual"></a> TransactionCurrency_msdyn_actual

**Added by**: Active Solution Solution

Same as msdyn_actual entity [TransactionCurrency_msdyn_actual](msdyn_actual.md#BKMK_TransactionCurrency_msdyn_actual) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_actual|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid"></a> msdyn_bookingalert_transactioncurrency_transactioncurrencyid

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_bookingalert_transactioncurrency_transactioncurrencyid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_transactioncurrency_transactioncurrencyid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_approval_transactioncurrency_transactioncurrencyid"></a> msdyn_approval_transactioncurrency_transactioncurrencyid

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_approval_transactioncurrency_transactioncurrencyid](msdyn_approval.md#BKMK_msdyn_approval_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_approval_transactioncurrency_transactioncurrencyid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue"></a> TransactionCurrency_msdyn_contractlinescheduleofvalue

**Added by**: Active Solution Solution

Same as msdyn_contractlinescheduleofvalue entity [TransactionCurrency_msdyn_contractlinescheduleofvalue](msdyn_contractlinescheduleofvalue.md#BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_contractlinescheduleofvalue|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_contractlinescheduleofvalue|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_estimateline"></a> TransactionCurrency_msdyn_estimateline

**Added by**: Active Solution Solution

Same as msdyn_estimateline entity [TransactionCurrency_msdyn_estimateline](msdyn_estimateline.md#BKMK_TransactionCurrency_msdyn_estimateline) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_estimateline|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_expense"></a> TransactionCurrency_msdyn_expense

**Added by**: Active Solution Solution

Same as msdyn_expense entity [TransactionCurrency_msdyn_expense](msdyn_expense.md#BKMK_TransactionCurrency_msdyn_expense) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expense|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_expense|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_fact"></a> TransactionCurrency_msdyn_fact

**Added by**: Active Solution Solution

Same as msdyn_fact entity [TransactionCurrency_msdyn_fact](msdyn_fact.md#BKMK_TransactionCurrency_msdyn_fact) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fact|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_fact|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_invoicelinetransaction"></a> TransactionCurrency_msdyn_invoicelinetransaction

**Added by**: Active Solution Solution

Same as msdyn_invoicelinetransaction entity [TransactionCurrency_msdyn_invoicelinetransaction](msdyn_invoicelinetransaction.md#BKMK_TransactionCurrency_msdyn_invoicelinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_invoicelinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_journalline"></a> TransactionCurrency_msdyn_journalline

**Added by**: Active Solution Solution

Same as msdyn_journalline entity [TransactionCurrency_msdyn_journalline](msdyn_journalline.md#BKMK_TransactionCurrency_msdyn_journalline) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_journalline|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_opportunitylinetransaction"></a> TransactionCurrency_msdyn_opportunitylinetransaction

**Added by**: Active Solution Solution

Same as msdyn_opportunitylinetransaction entity [TransactionCurrency_msdyn_opportunitylinetransaction](msdyn_opportunitylinetransaction.md#BKMK_TransactionCurrency_msdyn_opportunitylinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_opportunitylinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_orderlinetransaction"></a> TransactionCurrency_msdyn_orderlinetransaction

**Added by**: Active Solution Solution

Same as msdyn_orderlinetransaction entity [TransactionCurrency_msdyn_orderlinetransaction](msdyn_orderlinetransaction.md#BKMK_TransactionCurrency_msdyn_orderlinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_orderlinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_project"></a> TransactionCurrency_msdyn_project

**Added by**: Active Solution Solution

Same as msdyn_project entity [TransactionCurrency_msdyn_project](msdyn_project.md#BKMK_TransactionCurrency_msdyn_project) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_project|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_project|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_projectapproval"></a> TransactionCurrency_msdyn_projectapproval

**Added by**: Active Solution Solution

Same as msdyn_projectapproval entity [TransactionCurrency_msdyn_projectapproval](msdyn_projectapproval.md#BKMK_TransactionCurrency_msdyn_projectapproval) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectapproval|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_projectapproval|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_projecttask"></a> TransactionCurrency_msdyn_projecttask

**Added by**: Active Solution Solution

Same as msdyn_projecttask entity [TransactionCurrency_msdyn_projecttask](msdyn_projecttask.md#BKMK_TransactionCurrency_msdyn_projecttask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttask|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_projecttask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown"></a> TransactionCurrency_msdyn_quotelineanalyticsbreakdown

**Added by**: Active Solution Solution

Same as msdyn_quotelineanalyticsbreakdown entity [TransactionCurrency_msdyn_quotelineanalyticsbreakdown](msdyn_quotelineanalyticsbreakdown.md#BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineanalyticsbreakdown|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_quotelineanalyticsbreakdown|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue"></a> TransactionCurrency_msdyn_quotelinescheduleofvalue

**Added by**: Active Solution Solution

Same as msdyn_quotelinescheduleofvalue entity [TransactionCurrency_msdyn_quotelinescheduleofvalue](msdyn_quotelinescheduleofvalue.md#BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinescheduleofvalue|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_quotelinescheduleofvalue|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_quotelinetransaction"></a> TransactionCurrency_msdyn_quotelinetransaction

**Added by**: Active Solution Solution

Same as msdyn_quotelinetransaction entity [TransactionCurrency_msdyn_quotelinetransaction](msdyn_quotelinetransaction.md#BKMK_TransactionCurrency_msdyn_quotelinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_quotelinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_resourceassignment"></a> TransactionCurrency_msdyn_resourceassignment

**Added by**: Active Solution Solution

Same as msdyn_resourceassignment entity [TransactionCurrency_msdyn_resourceassignment](msdyn_resourceassignment.md#BKMK_TransactionCurrency_msdyn_resourceassignment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourceassignment|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_resourceassignment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel"></a> TransactionCurrency_msdyn_resourcecategorypricelevel

**Added by**: Active Solution Solution

Same as msdyn_resourcecategorypricelevel entity [TransactionCurrency_msdyn_resourcecategorypricelevel](msdyn_resourcecategorypricelevel.md#BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorypricelevel|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_resourcecategorypricelevel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_resourcerequirement"></a> TransactionCurrency_msdyn_resourcerequirement

**Added by**: Active Solution Solution

Same as msdyn_resourcerequirement entity [TransactionCurrency_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_TransactionCurrency_msdyn_resourcerequirement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirement|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_resourcerequirement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_transactioncategorypricelevel"></a> TransactionCurrency_msdyn_transactioncategorypricelevel

**Added by**: Active Solution Solution

Same as msdyn_transactioncategorypricelevel entity [TransactionCurrency_msdyn_transactioncategorypricelevel](msdyn_transactioncategorypricelevel.md#BKMK_TransactionCurrency_msdyn_transactioncategorypricelevel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategorypricelevel|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_transactioncategorypricelevel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_currency"></a> msdyn_organizationalunit_currency

**Added by**: Project Service Automation Solution

Same as msdyn_organizationalunit entity [msdyn_organizationalunit_currency](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_currency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_organizationalunit|
|ReferencingAttribute|msdyn_currency|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_currency|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_agreementbookingproduct"></a> TransactionCurrency_msdyn_agreementbookingproduct

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingproduct entity [TransactionCurrency_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_TransactionCurrency_msdyn_agreementbookingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_agreementbookingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_agreementbookingservice"></a> TransactionCurrency_msdyn_agreementbookingservice

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingservice entity [TransactionCurrency_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_TransactionCurrency_msdyn_agreementbookingservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservice|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_agreementbookingservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct"></a> TransactionCurrency_msdyn_agreementinvoiceproduct

**Added by**: Active Solution Solution

Same as msdyn_agreementinvoiceproduct entity [TransactionCurrency_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoiceproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_agreementinvoiceproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_bookingjournal"></a> TransactionCurrency_msdyn_bookingjournal

**Added by**: Active Solution Solution

Same as msdyn_bookingjournal entity [TransactionCurrency_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_TransactionCurrency_msdyn_bookingjournal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingjournal|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_bookingjournal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem"></a> TransactionCurrency_msdyn_fieldservicepricelistitem

**Added by**: Active Solution Solution

Same as msdyn_fieldservicepricelistitem entity [TransactionCurrency_msdyn_fieldservicepricelistitem](msdyn_fieldservicepricelistitem.md#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicepricelistitem|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_fieldservicepricelistitem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_orderinvoicingproduct"></a> TransactionCurrency_msdyn_orderinvoicingproduct

**Added by**: Active Solution Solution

Same as msdyn_orderinvoicingproduct entity [TransactionCurrency_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_TransactionCurrency_msdyn_orderinvoicingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_orderinvoicingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_payment"></a> TransactionCurrency_msdyn_payment

**Added by**: Active Solution Solution

Same as msdyn_payment entity [TransactionCurrency_msdyn_payment](msdyn_payment.md#BKMK_TransactionCurrency_msdyn_payment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_payment|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_payment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_paymentdetail"></a> TransactionCurrency_msdyn_paymentdetail

**Added by**: Active Solution Solution

Same as msdyn_paymentdetail entity [TransactionCurrency_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_TransactionCurrency_msdyn_paymentdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_paymentdetail|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_paymentdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_purchaseorder"></a> TransactionCurrency_msdyn_purchaseorder

**Added by**: Active Solution Solution

Same as msdyn_purchaseorder entity [TransactionCurrency_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_TransactionCurrency_msdyn_purchaseorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorder|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_purchaseorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderbill"></a> TransactionCurrency_msdyn_purchaseorderbill

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderbill entity [TransactionCurrency_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_TransactionCurrency_msdyn_purchaseorderbill) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderbill|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_purchaseorderbill|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderproduct"></a> TransactionCurrency_msdyn_purchaseorderproduct

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderproduct entity [TransactionCurrency_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_TransactionCurrency_msdyn_purchaseorderproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_purchaseorderproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct"></a> TransactionCurrency_msdyn_purchaseorderreceiptproduct

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderreceiptproduct entity [TransactionCurrency_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceiptproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_purchaseorderreceiptproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_quotebookingproduct"></a> TransactionCurrency_msdyn_quotebookingproduct

**Added by**: Active Solution Solution

Same as msdyn_quotebookingproduct entity [TransactionCurrency_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_TransactionCurrency_msdyn_quotebookingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_quotebookingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_quotebookingservice"></a> TransactionCurrency_msdyn_quotebookingservice

**Added by**: Active Solution Solution

Same as msdyn_quotebookingservice entity [TransactionCurrency_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_TransactionCurrency_msdyn_quotebookingservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservice|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_quotebookingservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_quotebookingsetup"></a> TransactionCurrency_msdyn_quotebookingsetup

**Added by**: Active Solution Solution

Same as msdyn_quotebookingsetup entity [TransactionCurrency_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_TransactionCurrency_msdyn_quotebookingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingsetup|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_quotebookingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct"></a> TransactionCurrency_msdyn_quoteinvoicingproduct

**Added by**: Active Solution Solution

Same as msdyn_quoteinvoicingproduct entity [TransactionCurrency_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quoteinvoicingproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_quoteinvoicingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup"></a> TransactionCurrency_msdyn_quoteinvoicingsetup

**Added by**: Active Solution Solution

Same as msdyn_quoteinvoicingsetup entity [TransactionCurrency_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quoteinvoicingsetup|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_quoteinvoicingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_rma"></a> TransactionCurrency_msdyn_rma

**Added by**: Active Solution Solution

Same as msdyn_rma entity [TransactionCurrency_msdyn_rma](msdyn_rma.md#BKMK_TransactionCurrency_msdyn_rma) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rma|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_rma|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_rmaproduct"></a> TransactionCurrency_msdyn_rmaproduct

**Added by**: Active Solution Solution

Same as msdyn_rmaproduct entity [TransactionCurrency_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_TransactionCurrency_msdyn_rmaproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmaproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_rmaproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_rtv"></a> TransactionCurrency_msdyn_rtv

**Added by**: Active Solution Solution

Same as msdyn_rtv entity [TransactionCurrency_msdyn_rtv](msdyn_rtv.md#BKMK_TransactionCurrency_msdyn_rtv) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtv|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_rtv|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_rtvproduct"></a> TransactionCurrency_msdyn_rtvproduct

**Added by**: Active Solution Solution

Same as msdyn_rtvproduct entity [TransactionCurrency_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_TransactionCurrency_msdyn_rtvproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_rtvproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_workorder"></a> TransactionCurrency_msdyn_workorder

**Added by**: Active Solution Solution

Same as msdyn_workorder entity [TransactionCurrency_msdyn_workorder](msdyn_workorder.md#BKMK_TransactionCurrency_msdyn_workorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorder|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_workorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_workorderproduct"></a> TransactionCurrency_msdyn_workorderproduct

**Added by**: Active Solution Solution

Same as msdyn_workorderproduct entity [TransactionCurrency_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_TransactionCurrency_msdyn_workorderproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_workorderproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_msdyn_workorderservice"></a> TransactionCurrency_msdyn_workorderservice

**Added by**: Active Solution Solution

Same as msdyn_workorderservice entity [TransactionCurrency_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_TransactionCurrency_msdyn_workorderservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_msdyn_workorderservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncurrency_invoicedetail_Currency"></a> msdyn_transactioncurrency_invoicedetail_Currency

**Added by**: Field Service Solution

Same as invoicedetail entity [msdyn_transactioncurrency_invoicedetail_Currency](invoicedetail.md#BKMK_msdyn_transactioncurrency_invoicedetail_Currency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|msdyn_currency|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncurrency_invoicedetail_Currency|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Goal"></a> TransactionCurrency_Goal

Same as goal entity [TransactionCurrency_Goal](goal.md#BKMK_TransactionCurrency_Goal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|goal|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Goal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_SharePointSite"></a> TransactionCurrency_SharePointSite

Same as sharepointsite entity [TransactionCurrency_SharePointSite](sharepointsite.md#BKMK_TransactionCurrency_SharePointSite) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointsite|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_SharePointSite|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_QueueItem"></a> TransactionCurrency_QueueItem

Same as queueitem entity [TransactionCurrency_QueueItem](queueitem.md#BKMK_TransactionCurrency_QueueItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_actioncard"></a> transactioncurrency_actioncard

Same as actioncard entity [transactioncurrency_actioncard](actioncard.md#BKMK_transactioncurrency_actioncard) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_officegraphdocument"></a> TransactionCurrency_officegraphdocument

Same as officegraphdocument entity [TransactionCurrency_officegraphdocument](officegraphdocument.md#BKMK_TransactionCurrency_officegraphdocument) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|officegraphdocument|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_officegraphdocument|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_KnowledgeBaseRecord"></a> TransactionCurrency_KnowledgeBaseRecord

Same as knowledgebaserecord entity [TransactionCurrency_KnowledgeBaseRecord](knowledgebaserecord.md#BKMK_TransactionCurrency_KnowledgeBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgebaserecord|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_KnowledgeBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_ActionCardUserState"></a> TransactionCurrency_ActionCardUserState

Same as actioncarduserstate entity [TransactionCurrency_ActionCardUserState](actioncarduserstate.md#BKMK_TransactionCurrency_ActionCardUserState) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncarduserstate|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_ActionCardUserState|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_SharePointDocumentLocation"></a> TransactionCurrency_SharePointDocumentLocation

Same as sharepointdocumentlocation entity [TransactionCurrency_SharePointDocumentLocation](sharepointdocumentlocation.md#BKMK_TransactionCurrency_SharePointDocumentLocation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_SharePointDocumentLocation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_SLAItem"></a> TransactionCurrency_SLAItem

Same as slaitem entity [TransactionCurrency_SLAItem](slaitem.md#BKMK_TransactionCurrency_SLAItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slaitem|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_SLAItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_expiredprocess"></a> transactioncurrency_expiredprocess

Same as expiredprocess entity [transactioncurrency_expiredprocess](expiredprocess.md#BKMK_transactioncurrency_expiredprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|expiredprocess|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_expiredprocess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_ProcessSessions"></a> TransactionCurrency_ProcessSessions

Same as processsession entity [TransactionCurrency_ProcessSessions](processsession.md#BKMK_TransactionCurrency_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_SyncErrors"></a> TransactionCurrency_SyncErrors

Same as syncerror entity [TransactionCurrency_SyncErrors](syncerror.md#BKMK_TransactionCurrency_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_transactioncurrency_socialactivity"></a> transactioncurrency_socialactivity

Same as socialactivity entity [transactioncurrency_socialactivity](socialactivity.md#BKMK_transactioncurrency_socialactivity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_socialactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_MailMergeTemplate"></a> TransactionCurrency_MailMergeTemplate

Same as mailmergetemplate entity [TransactionCurrency_MailMergeTemplate](mailmergetemplate.md#BKMK_TransactionCurrency_MailMergeTemplate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailmergetemplate|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_MailMergeTemplate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_UserMapping"></a> TransactionCurrency_UserMapping

Same as usermapping entity [TransactionCurrency_UserMapping](usermapping.md#BKMK_TransactionCurrency_UserMapping) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|usermapping|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_UserMapping|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_fixedmonthlyfiscalcalendar"></a> transactioncurrency_fixedmonthlyfiscalcalendar

Same as fixedmonthlyfiscalcalendar entity [transactioncurrency_fixedmonthlyfiscalcalendar](fixedmonthlyfiscalcalendar.md#BKMK_transactioncurrency_fixedmonthlyfiscalcalendar) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fixedmonthlyfiscalcalendar|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_fixedmonthlyfiscalcalendar|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_semiannualfiscalcalendar"></a> transactioncurrency_semiannualfiscalcalendar

Same as semiannualfiscalcalendar entity [transactioncurrency_semiannualfiscalcalendar](semiannualfiscalcalendar.md#BKMK_transactioncurrency_semiannualfiscalcalendar) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|semiannualfiscalcalendar|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_semiannualfiscalcalendar|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_PhoneCall"></a> TransactionCurrency_PhoneCall

Same as phonecall entity [TransactionCurrency_PhoneCall](phonecall.md#BKMK_TransactionCurrency_PhoneCall) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_PhoneCall|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Fax"></a> TransactionCurrency_Fax

Same as fax entity [TransactionCurrency_Fax](fax.md#BKMK_TransactionCurrency_Fax) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Fax|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_usersettings"></a> transactioncurrency_usersettings

Same as usersettings entity [transactioncurrency_usersettings](usersettings.md#BKMK_transactioncurrency_usersettings) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|usersettings|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_usersettings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_ActivityPointer"></a> TransactionCurrency_ActivityPointer

Same as activitypointer entity [TransactionCurrency_ActivityPointer](activitypointer.md#BKMK_TransactionCurrency_ActivityPointer) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_ActivityPointer|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_category"></a> transactioncurrency_category

Same as category entity [transactioncurrency_category](category.md#BKMK_transactioncurrency_category) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|category|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_category|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_position"></a> transactioncurrency_position

Same as position entity [transactioncurrency_position](position.md#BKMK_transactioncurrency_position) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|position|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_position|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Task"></a> TransactionCurrency_Task

Same as task entity [TransactionCurrency_Task](task.md#BKMK_TransactionCurrency_Task) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Task|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_SLA"></a> TransactionCurrency_SLA

Same as sla entity [TransactionCurrency_SLA](sla.md#BKMK_TransactionCurrency_SLA) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sla|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_SLA|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_basecurrency_organization"></a> basecurrency_organization

Same as organization entity [basecurrency_organization](organization.md#BKMK_basecurrency_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|organization|
|ReferencingAttribute|basecurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|basecurrency_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Letter"></a> TransactionCurrency_Letter

Same as letter entity [TransactionCurrency_Letter](letter.md#BKMK_TransactionCurrency_Letter) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Letter|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_SystemUser"></a> TransactionCurrency_SystemUser

Same as systemuser entity [TransactionCurrency_SystemUser](systemuser.md#BKMK_TransactionCurrency_SystemUser) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|systemuser|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_SystemUser|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Team"></a> TransactionCurrency_Team

Same as team entity [TransactionCurrency_Team](team.md#BKMK_TransactionCurrency_Team) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|team|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Team|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Email"></a> TransactionCurrency_Email

Same as email entity [TransactionCurrency_Email](email.md#BKMK_TransactionCurrency_Email) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Email|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_BusinessUnit"></a> TransactionCurrency_BusinessUnit

Same as businessunit entity [TransactionCurrency_BusinessUnit](businessunit.md#BKMK_TransactionCurrency_BusinessUnit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|businessunit|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_BusinessUnit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_SocialProfile"></a> transactioncurrency_SocialProfile

Same as socialprofile entity [transactioncurrency_SocialProfile](socialprofile.md#BKMK_transactioncurrency_SocialProfile) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialprofile|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_SocialProfile|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Queue"></a> TransactionCurrency_Queue

Same as queue entity [TransactionCurrency_Queue](queue.md#BKMK_TransactionCurrency_Queue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queue|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Queue|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_DuplicateMatchingRecord"></a> TransactionCurrency_DuplicateMatchingRecord

Same as duplicaterecord entity [TransactionCurrency_DuplicateMatchingRecord](duplicaterecord.md#BKMK_TransactionCurrency_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Appointment"></a> TransactionCurrency_Appointment

Same as appointment entity [TransactionCurrency_Appointment](appointment.md#BKMK_TransactionCurrency_Appointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Appointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_quarterlyfiscalcalendar"></a> transactioncurrency_quarterlyfiscalcalendar

Same as quarterlyfiscalcalendar entity [transactioncurrency_quarterlyfiscalcalendar](quarterlyfiscalcalendar.md#BKMK_transactioncurrency_quarterlyfiscalcalendar) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quarterlyfiscalcalendar|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_quarterlyfiscalcalendar|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_KbArticle"></a> TransactionCurrency_KbArticle

Same as kbarticle entity [TransactionCurrency_KbArticle](kbarticle.md#BKMK_TransactionCurrency_KbArticle) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|kbarticle|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_KbArticle|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_monthlyfiscalcalendar"></a> transactioncurrency_monthlyfiscalcalendar

Same as monthlyfiscalcalendar entity [transactioncurrency_monthlyfiscalcalendar](monthlyfiscalcalendar.md#BKMK_transactioncurrency_monthlyfiscalcalendar) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|monthlyfiscalcalendar|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_monthlyfiscalcalendar|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_CustomerAddress"></a> TransactionCurrency_CustomerAddress

Same as customeraddress entity [TransactionCurrency_CustomerAddress](customeraddress.md#BKMK_TransactionCurrency_CustomerAddress) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|customeraddress|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_CustomerAddress|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_annualfiscalcalendar"></a> transactioncurrency_annualfiscalcalendar

Same as annualfiscalcalendar entity [transactioncurrency_annualfiscalcalendar](annualfiscalcalendar.md#BKMK_transactioncurrency_annualfiscalcalendar) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annualfiscalcalendar|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_annualfiscalcalendar|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Connection"></a> TransactionCurrency_Connection

Same as connection entity [TransactionCurrency_Connection](connection.md#BKMK_TransactionCurrency_Connection) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Connection|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_translationprocess"></a> transactioncurrency_translationprocess

Same as translationprocess entity [transactioncurrency_translationprocess](translationprocess.md#BKMK_transactioncurrency_translationprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|translationprocess|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_translationprocess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_feedback"></a> transactioncurrency_feedback

Same as feedback entity [transactioncurrency_feedback](feedback.md#BKMK_transactioncurrency_feedback) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|feedback|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_feedback|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_contact"></a> transactioncurrency_contact

Same as contact entity [transactioncurrency_contact](contact.md#BKMK_transactioncurrency_contact) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_contact|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_ReportCategory"></a> TransactionCurrency_ReportCategory

Same as reportcategory entity [TransactionCurrency_ReportCategory](reportcategory.md#BKMK_TransactionCurrency_ReportCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|reportcategory|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_ReportCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_InteractionForEmail"></a> TransactionCurrency_InteractionForEmail

Same as interactionforemail entity [TransactionCurrency_InteractionForEmail](interactionforemail.md#BKMK_TransactionCurrency_InteractionForEmail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|interactionforemail|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_InteractionForEmail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_slakpiinstance"></a> TransactionCurrency_slakpiinstance

Same as slakpiinstance entity [TransactionCurrency_slakpiinstance](slakpiinstance.md#BKMK_TransactionCurrency_slakpiinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_slakpiinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_DuplicateBaseRecord"></a> TransactionCurrency_DuplicateBaseRecord

Same as duplicaterecord entity [TransactionCurrency_DuplicateBaseRecord](duplicaterecord.md#BKMK_TransactionCurrency_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_AsyncOperations"></a> TransactionCurrency_AsyncOperations

Same as asyncoperation entity [TransactionCurrency_AsyncOperations](asyncoperation.md#BKMK_TransactionCurrency_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_knowledgearticleviews"></a> transactioncurrency_knowledgearticleviews

Same as knowledgearticleviews entity [transactioncurrency_knowledgearticleviews](knowledgearticleviews.md#BKMK_transactioncurrency_knowledgearticleviews) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticleviews|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_knowledgearticleviews|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_Theme"></a> TransactionCurrency_Theme

Same as theme entity [TransactionCurrency_Theme](theme.md#BKMK_TransactionCurrency_Theme) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|theme|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_Theme|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_newprocess"></a> transactioncurrency_newprocess

Same as newprocess entity [transactioncurrency_newprocess](newprocess.md#BKMK_transactioncurrency_newprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|newprocess|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_newprocess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_knowledgearticle"></a> TransactionCurrency_knowledgearticle

Same as knowledgearticle entity [TransactionCurrency_knowledgearticle](knowledgearticle.md#BKMK_TransactionCurrency_knowledgearticle) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticle|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_knowledgearticle|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_RecurringAppointmentMaster"></a> TransactionCurrency_RecurringAppointmentMaster

Same as recurringappointmentmaster entity [TransactionCurrency_RecurringAppointmentMaster](recurringappointmentmaster.md#BKMK_TransactionCurrency_RecurringAppointmentMaster) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_RecurringAppointmentMaster|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_transactioncurrency_account"></a> transactioncurrency_account

Same as account entity [transactioncurrency_account](account.md#BKMK_transactioncurrency_account) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|transactioncurrency_account|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_TransactionCurrency_recommendeddocument"></a> TransactionCurrency_recommendeddocument

Same as recommendeddocument entity [TransactionCurrency_recommendeddocument](recommendeddocument.md#BKMK_TransactionCurrency_recommendeddocument) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recommendeddocument|
|ReferencingAttribute|transactioncurrencyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransactionCurrency_recommendeddocument|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_transactioncurrencybase_createdby](#BKMK_lk_transactioncurrencybase_createdby)
- [lk_transactioncurrencybase_modifiedby](#BKMK_lk_transactioncurrencybase_modifiedby)
- [lk_transactioncurrency_modifiedonbehalfby](#BKMK_lk_transactioncurrency_modifiedonbehalfby)
- [organization_transactioncurrencies](#BKMK_organization_transactioncurrencies)
- [lk_transactioncurrency_createdonbehalfby](#BKMK_lk_transactioncurrency_createdonbehalfby)


### <a name="BKMK_lk_transactioncurrencybase_createdby"></a> lk_transactioncurrencybase_createdby

See systemuser Entity [lk_transactioncurrencybase_createdby](systemuser.md#BKMK_lk_transactioncurrencybase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_transactioncurrencybase_modifiedby"></a> lk_transactioncurrencybase_modifiedby

See systemuser Entity [lk_transactioncurrencybase_modifiedby](systemuser.md#BKMK_lk_transactioncurrencybase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_transactioncurrency_modifiedonbehalfby"></a> lk_transactioncurrency_modifiedonbehalfby

See systemuser Entity [lk_transactioncurrency_modifiedonbehalfby](systemuser.md#BKMK_lk_transactioncurrency_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_transactioncurrencies"></a> organization_transactioncurrencies

See organization Entity [organization_transactioncurrencies](organization.md#BKMK_organization_transactioncurrencies) One-To-Many relationship.

### <a name="BKMK_lk_transactioncurrency_createdonbehalfby"></a> lk_transactioncurrency_createdonbehalfby

See systemuser Entity [lk_transactioncurrency_createdonbehalfby](systemuser.md#BKMK_lk_transactioncurrency_createdonbehalfby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.transactioncurrency?text=transactioncurrency EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]