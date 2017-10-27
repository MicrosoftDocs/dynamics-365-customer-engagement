---
title: "TransactionCurrency Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TransactionCurrency entity."
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
# TransactionCurrency Entity Reference

Currency in which a financial transaction is carried out.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/transactioncurrencies<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/transactioncurrencies(*transactioncurrencyid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/transactioncurrencies(*transactioncurrencyid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveExchangeRate|<xref href="Microsoft.Dynamics.CRM.RetrieveExchangeRate?text=RetrieveExchangeRate Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveExchangeRateRequest>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/transactioncurrencies<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/transactioncurrencies(*transactioncurrencyid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/transactioncurrencies(*transactioncurrencyid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Currency<br />
**DisplayCollectionName**: Currencies<br />
**SchemaName**: TransactionCurrency<br />
**CollectionSchemaName**: TransactionCurrencies<br />
**LogicalName**: transactioncurrency<br />
**LogicalCollectionName**: transactioncurrencies<br />
**EntitySetName**: transactioncurrencies<br />
**PrimaryIdAttribute**: transactioncurrencyid<br />
**PrimaryNameAttribute**: currencyname<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Name of the transaction currency.<br />
**DisplayName**: Currency Name<br />
**LogicalName**: currencyname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CurrencyPrecision"></a> CurrencyPrecision

**Description**: Number of decimal places that can be used for currency.<br />
**DisplayName**: Currency Precision<br />
**LogicalName**: currencyprecision<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 4<br />
**MinValue**: 0


### <a name="BKMK_CurrencySymbol"></a> CurrencySymbol

**Description**: Symbol for the transaction currency.<br />
**DisplayName**: Currency Symbol<br />
**LogicalName**: currencysymbol<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 10


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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Exchange rate between the transaction currency and the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Unique identifier of the data import or data migration that created this record.<br />
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


### <a name="BKMK_ISOCurrencyCode"></a> ISOCurrencyCode

**Description**: ISO currency code for the transaction currency.<br />
**DisplayName**: Currency Code<br />
**LogicalName**: isocurrencycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 5


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


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the transaction currency.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the transaction currency.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the transaction currency.<br />
**DisplayName**: Transaction Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />

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

**Description**: Unique identifier of the user who created the transaction currency.<br />
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

**Description**: Date and time when the transaction currency was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the transactioncurrency.<br />
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

**Description**: For internal use only.<br />
**DisplayName**: Entity Image Id<br />
**LogicalName**: entityimageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the transaction currency.<br />
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

**Description**: Date and time when the transaction currency was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the transactioncurrency.<br />
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

**Description**: Unique identifier of the organization associated with the transaction currency.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_UniqueDscId"></a> UniqueDscId

**Description**: For internal use only.<br />
**DisplayName**: UniqueDscId<br />
**LogicalName**: uniquedscid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the transaction currency.<br />
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
- [TransactionCurrency_SharePointDocument](#BKMK_TransactionCurrency_SharePointDocument)
- [TransactionCurrency_delveactionhub](#BKMK_TransactionCurrency_delveactionhub)
- [TransactionCurrency_ActionCardUserState](#BKMK_TransactionCurrency_ActionCardUserState)
- [TransactionCurrency_SharePointDocumentLocation](#BKMK_TransactionCurrency_SharePointDocumentLocation)
- [TransactionCurrency_SLAItem](#BKMK_TransactionCurrency_SLAItem)
- [transactioncurrency_expiredprocess](#BKMK_transactioncurrency_expiredprocess)
- [TransactionCurrency_externalpartyitem](#BKMK_TransactionCurrency_externalpartyitem)
- [TransactionCurrency_profileruleitem](#BKMK_TransactionCurrency_profileruleitem)
- [TransactionCurrency_ProcessSessions](#BKMK_TransactionCurrency_ProcessSessions)
- [TransactionCurrency_profilerule](#BKMK_TransactionCurrency_profilerule)
- [TransactionCurrency_SyncErrors](#BKMK_TransactionCurrency_SyncErrors)
- [transactioncurrency_socialactivity](#BKMK_transactioncurrency_socialactivity)
- [TransactionCurrency_MailMergeTemplate](#BKMK_TransactionCurrency_MailMergeTemplate)
- [TransactionCurrency_UserMapping](#BKMK_TransactionCurrency_UserMapping)
- [transactioncurrency_fixedmonthlyfiscalcalendar](#BKMK_transactioncurrency_fixedmonthlyfiscalcalendar)
- [transactioncurrency_semiannualfiscalcalendar](#BKMK_transactioncurrency_semiannualfiscalcalendar)
- [TransactionCurrency_PhoneCall](#BKMK_TransactionCurrency_PhoneCall)
- [TransactionCurrency_Fax](#BKMK_TransactionCurrency_Fax)
- [transactioncurrency_usersettings](#BKMK_transactioncurrency_usersettings)
- [userentityinstancedata_transactioncurrency](#BKMK_userentityinstancedata_transactioncurrency)
- [TransactionCurrency_ActivityPointer](#BKMK_TransactionCurrency_ActivityPointer)
- [transactioncurrency_category](#BKMK_transactioncurrency_category)
- [TransactionCurrency_ConvertRule](#BKMK_TransactionCurrency_ConvertRule)
- [transactioncurrency_position](#BKMK_transactioncurrency_position)
- [TransactionCurrency_Task](#BKMK_TransactionCurrency_Task)
- [TransactionCurrency_SLA](#BKMK_TransactionCurrency_SLA)
- [basecurrency_organization](#BKMK_basecurrency_organization)
- [TransactionCurrency_Letter](#BKMK_TransactionCurrency_Letter)
- [transactioncurrency_convertruleitem](#BKMK_transactioncurrency_convertruleitem)
- [TransactionCurrency_routingruleitem](#BKMK_TransactionCurrency_routingruleitem)
- [transactioncurrency_cardtype](#BKMK_transactioncurrency_cardtype)
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
- [TransactionCurrency_ExternalParty](#BKMK_TransactionCurrency_ExternalParty)
- [transactioncurrency_feedback](#BKMK_transactioncurrency_feedback)
- [transactioncurrency_contact](#BKMK_transactioncurrency_contact)
- [TransactionCurrency_ReportCategory](#BKMK_TransactionCurrency_ReportCategory)
- [TransactionCurrency_InteractionForEmail](#BKMK_TransactionCurrency_InteractionForEmail)
- [TransactionCurrency_suggestioncardtemplate](#BKMK_TransactionCurrency_suggestioncardtemplate)
- [TransactionCurrency_slakpiinstance](#BKMK_TransactionCurrency_slakpiinstance)
- [TransactionCurrency_DuplicateBaseRecord](#BKMK_TransactionCurrency_DuplicateBaseRecord)
- [TransactionCurrency_AsyncOperations](#BKMK_TransactionCurrency_AsyncOperations)
- [transactioncurrency_knowledgearticleviews](#BKMK_transactioncurrency_knowledgearticleviews)
- [TransactionCurrency_Theme](#BKMK_TransactionCurrency_Theme)
- [TransactionCurrency_ChannelAccessProfile](#BKMK_TransactionCurrency_ChannelAccessProfile)
- [transactioncurrency_newprocess](#BKMK_transactioncurrency_newprocess)
- [TransactionCurrency_knowledgearticle](#BKMK_TransactionCurrency_knowledgearticle)
- [TransactionCurrency_RecurringAppointmentMaster](#BKMK_TransactionCurrency_RecurringAppointmentMaster)
- [transactioncurrency_account](#BKMK_transactioncurrency_account)
- [TransactionCurrency_recommendeddocument](#BKMK_TransactionCurrency_recommendeddocument)
- [TransactionCurrency_Routingrule](#BKMK_TransactionCurrency_Routingrule)


### <a name="BKMK_TransactionCurrency_Territory"></a> TransactionCurrency_Territory

Same as territory entity [TransactionCurrency_Territory](territory.md#BKMK_TransactionCurrency_Territory) Many-To-One relationship.

**ReferencingEntity**: territory<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Territory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_lead"></a> transactioncurrency_lead

Same as lead entity [transactioncurrency_lead](lead.md#BKMK_transactioncurrency_lead) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_lead<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_LeadAddress"></a> TransactionCurrency_LeadAddress

Same as leadaddress entity [TransactionCurrency_LeadAddress](leadaddress.md#BKMK_TransactionCurrency_LeadAddress) Many-To-One relationship.

**ReferencingEntity**: leadaddress<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_LeadAddress<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_product"></a> transactioncurrency_product

Same as product entity [transactioncurrency_product](product.md#BKMK_transactioncurrency_product) Many-To-One relationship.

**ReferencingEntity**: product<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_productpricelevel"></a> transactioncurrency_productpricelevel

Same as productpricelevel entity [transactioncurrency_productpricelevel](productpricelevel.md#BKMK_transactioncurrency_productpricelevel) Many-To-One relationship.

**ReferencingEntity**: productpricelevel<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_productpricelevel<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_DynamicPropertyAssociation_TransactionCurrency"></a> DynamicPropertyAssociation_TransactionCurrency

Same as dynamicpropertyassociation entity [DynamicPropertyAssociation_TransactionCurrency](dynamicpropertyassociation.md#BKMK_DynamicPropertyAssociation_TransactionCurrency) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyassociation<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: DynamicPropertyAssociation_TransactionCurrency<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Dynamicpropertyinsatance"></a> TransactionCurrency_Dynamicpropertyinsatance

Same as dynamicpropertyinstance entity [TransactionCurrency_Dynamicpropertyinsatance](dynamicpropertyinstance.md#BKMK_TransactionCurrency_Dynamicpropertyinsatance) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyinstance<br />
**ReferencingAttribute**: dynamicpropertyinstanceid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Dynamicpropertyinsatance<br />
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


### <a name="BKMK_DynamicPropertyOptionSetItem_TransactionCurrency"></a> DynamicPropertyOptionSetItem_TransactionCurrency

Same as dynamicpropertyoptionsetitem entity [DynamicPropertyOptionSetItem_TransactionCurrency](dynamicpropertyoptionsetitem.md#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyoptionsetitem<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: DynamicPropertyOptionSetItem_TransactionCurrency<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_ProductAssociation"></a> transactioncurrency_ProductAssociation

Same as productassociation entity [transactioncurrency_ProductAssociation](productassociation.md#BKMK_transactioncurrency_ProductAssociation) Many-To-One relationship.

**ReferencingEntity**: productassociation<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_ProductAssociation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_ProductSubstitute"></a> transactioncurrency_ProductSubstitute

Same as productsubstitute entity [transactioncurrency_ProductSubstitute](productsubstitute.md#BKMK_transactioncurrency_ProductSubstitute) Many-To-One relationship.

**ReferencingEntity**: productsubstitute<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_ProductSubstitute<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_pricelevel"></a> transactioncurrency_pricelevel

Same as pricelevel entity [transactioncurrency_pricelevel](pricelevel.md#BKMK_transactioncurrency_pricelevel) Many-To-One relationship.

**ReferencingEntity**: pricelevel<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_pricelevel<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_bookableresource"></a> TransactionCurrency_bookableresource

Same as bookableresource entity [TransactionCurrency_bookableresource](bookableresource.md#BKMK_TransactionCurrency_bookableresource) Many-To-One relationship.

**ReferencingEntity**: bookableresource<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_bookableresource<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_bookableresourcebooking"></a> TransactionCurrency_bookableresourcebooking

Same as bookableresourcebooking entity [TransactionCurrency_bookableresourcebooking](bookableresourcebooking.md#BKMK_TransactionCurrency_bookableresourcebooking) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebooking<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_bookableresourcebooking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_bookableresourcebookingheader"></a> TransactionCurrency_bookableresourcebookingheader

Same as bookableresourcebookingheader entity [TransactionCurrency_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_TransactionCurrency_bookableresourcebookingheader) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebookingheader<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_bookableresourcebookingheader<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_bookableresourcecategory"></a> TransactionCurrency_bookableresourcecategory

Same as bookableresourcecategory entity [TransactionCurrency_bookableresourcecategory](bookableresourcecategory.md#BKMK_TransactionCurrency_bookableresourcecategory) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecategory<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_bookableresourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_bookableresourcecategoryassn"></a> TransactionCurrency_bookableresourcecategoryassn

Same as bookableresourcecategoryassn entity [TransactionCurrency_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_TransactionCurrency_bookableresourcecategoryassn) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecategoryassn<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_bookableresourcecategoryassn<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_bookableresourcecharacteristic"></a> TransactionCurrency_bookableresourcecharacteristic

Same as bookableresourcecharacteristic entity [TransactionCurrency_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_TransactionCurrency_bookableresourcecharacteristic) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecharacteristic<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_bookableresourcecharacteristic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_bookableresourcegroup"></a> TransactionCurrency_bookableresourcegroup

Same as bookableresourcegroup entity [TransactionCurrency_bookableresourcegroup](bookableresourcegroup.md#BKMK_TransactionCurrency_bookableresourcegroup) Many-To-One relationship.

**ReferencingEntity**: bookableresourcegroup<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_bookableresourcegroup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_bookingstatus"></a> TransactionCurrency_bookingstatus

Same as bookingstatus entity [TransactionCurrency_bookingstatus](bookingstatus.md#BKMK_TransactionCurrency_bookingstatus) Many-To-One relationship.

**ReferencingEntity**: bookingstatus<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_bookingstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_characteristic"></a> TransactionCurrency_characteristic

Same as characteristic entity [TransactionCurrency_characteristic](characteristic.md#BKMK_TransactionCurrency_characteristic) Many-To-One relationship.

**ReferencingEntity**: characteristic<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_characteristic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_ratingmodel"></a> TransactionCurrency_ratingmodel

Same as ratingmodel entity [TransactionCurrency_ratingmodel](ratingmodel.md#BKMK_TransactionCurrency_ratingmodel) Many-To-One relationship.

**ReferencingEntity**: ratingmodel<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_ratingmodel<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_ratingvalue"></a> TransactionCurrency_ratingvalue

Same as ratingvalue entity [TransactionCurrency_ratingvalue](ratingvalue.md#BKMK_TransactionCurrency_ratingvalue) Many-To-One relationship.

**ReferencingEntity**: ratingvalue<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_ratingvalue<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bulkoperation_transactioncurrency_transactioncurrencyid"></a> bulkoperation_transactioncurrency_transactioncurrencyid

Same as bulkoperation entity [bulkoperation_transactioncurrency_transactioncurrencyid](bulkoperation.md#BKMK_bulkoperation_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_transactioncurrency_transactioncurrencyid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_campaign"></a> transactioncurrency_campaign

Same as campaign entity [transactioncurrency_campaign](campaign.md#BKMK_transactioncurrency_campaign) Many-To-One relationship.

**ReferencingEntity**: campaign<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_campaign<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_campaignactivity"></a> transactioncurrency_campaignactivity

Same as campaignactivity entity [transactioncurrency_campaignactivity](campaignactivity.md#BKMK_transactioncurrency_campaignactivity) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_campaignactivity<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_CampaignResponse"></a> TransactionCurrency_CampaignResponse

Same as campaignresponse entity [TransactionCurrency_CampaignResponse](campaignresponse.md#BKMK_TransactionCurrency_CampaignResponse) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_CampaignResponse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_list"></a> transactioncurrency_list

Same as list entity [transactioncurrency_list](list.md#BKMK_transactioncurrency_list) Many-To-One relationship.

**ReferencingEntity**: list<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_list<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_contract"></a> transactioncurrency_contract

Same as contract entity [transactioncurrency_contract](contract.md#BKMK_transactioncurrency_contract) Many-To-One relationship.

**ReferencingEntity**: contract<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_contract<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_contractdetail"></a> transactioncurrency_contractdetail

Same as contractdetail entity [transactioncurrency_contractdetail](contractdetail.md#BKMK_transactioncurrency_contractdetail) Many-To-One relationship.

**ReferencingEntity**: contractdetail<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_contractdetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incidentresolution_transactioncurrency_transactioncurrencyid"></a> incidentresolution_transactioncurrency_transactioncurrencyid

Same as incidentresolution entity [incidentresolution_transactioncurrency_transactioncurrencyid](incidentresolution.md#BKMK_incidentresolution_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incidentresolution_transactioncurrency_transactioncurrencyid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_ServiceAppointment"></a> TransactionCurrency_ServiceAppointment

Same as serviceappointment entity [TransactionCurrency_ServiceAppointment](serviceappointment.md#BKMK_TransactionCurrency_ServiceAppointment) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_ServiceAppointment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_phonetocaseprocess"></a> transactioncurrency_phonetocaseprocess

Same as phonetocaseprocess entity [transactioncurrency_phonetocaseprocess](phonetocaseprocess.md#BKMK_transactioncurrency_phonetocaseprocess) Many-To-One relationship.

**ReferencingEntity**: phonetocaseprocess<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_phonetocaseprocess<br />
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


### <a name="BKMK_TransactionCurrency_Equipment"></a> TransactionCurrency_Equipment

Same as equipment entity [TransactionCurrency_Equipment](equipment.md#BKMK_TransactionCurrency_Equipment) Many-To-One relationship.

**ReferencingEntity**: equipment<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Equipment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Incident"></a> TransactionCurrency_Incident

Same as incident entity [TransactionCurrency_Incident](incident.md#BKMK_TransactionCurrency_Incident) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Incident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_entitlementtemplatechannel"></a> TransactionCurrency_entitlementtemplatechannel

Same as entitlementtemplatechannel entity [TransactionCurrency_entitlementtemplatechannel](entitlementtemplatechannel.md#BKMK_TransactionCurrency_entitlementtemplatechannel) Many-To-One relationship.

**ReferencingEntity**: entitlementtemplatechannel<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_entitlementtemplatechannel<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Entitlement"></a> TransactionCurrency_Entitlement

Same as entitlement entity [TransactionCurrency_Entitlement](entitlement.md#BKMK_TransactionCurrency_Entitlement) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Entitlement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_entitlementtemplate"></a> TransactionCurrency_entitlementtemplate

Same as entitlementtemplate entity [TransactionCurrency_entitlementtemplate](entitlementtemplate.md#BKMK_TransactionCurrency_entitlementtemplate) Many-To-One relationship.

**ReferencingEntity**: entitlementtemplate<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_entitlementtemplate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_entitlementchannel"></a> TransactionCurrency_entitlementchannel

Same as entitlementchannel entity [TransactionCurrency_entitlementchannel](entitlementchannel.md#BKMK_TransactionCurrency_entitlementchannel) Many-To-One relationship.

**ReferencingEntity**: entitlementchannel<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_entitlementchannel<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_knowledgearticleincident"></a> transactioncurrency_knowledgearticleincident

Same as knowledgearticleincident entity [transactioncurrency_knowledgearticleincident](knowledgearticleincident.md#BKMK_transactioncurrency_knowledgearticleincident) Many-To-One relationship.

**ReferencingEntity**: knowledgearticleincident<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_knowledgearticleincident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_discount"></a> transactioncurrency_discount

Same as discount entity [transactioncurrency_discount](discount.md#BKMK_transactioncurrency_discount) Many-To-One relationship.

**ReferencingEntity**: discount<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_discount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_invoice"></a> transactioncurrency_invoice

Same as invoice entity [transactioncurrency_invoice](invoice.md#BKMK_transactioncurrency_invoice) Many-To-One relationship.

**ReferencingEntity**: invoice<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_invoice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_invoicedetail"></a> transactioncurrency_invoicedetail

Same as invoicedetail entity [transactioncurrency_invoicedetail](invoicedetail.md#BKMK_transactioncurrency_invoicedetail) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_invoicedetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_opportunity"></a> transactioncurrency_opportunity

Same as opportunity entity [transactioncurrency_opportunity](opportunity.md#BKMK_transactioncurrency_opportunity) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_opportunity<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_opportunityclose"></a> transactioncurrency_opportunityclose

Same as opportunityclose entity [transactioncurrency_opportunityclose](opportunityclose.md#BKMK_transactioncurrency_opportunityclose) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_opportunityclose<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_opportunityproduct"></a> transactioncurrency_opportunityproduct

Same as opportunityproduct entity [transactioncurrency_opportunityproduct](opportunityproduct.md#BKMK_transactioncurrency_opportunityproduct) Many-To-One relationship.

**ReferencingEntity**: opportunityproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_opportunityproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_orderclose_transactioncurrency_transactioncurrencyid"></a> orderclose_transactioncurrency_transactioncurrencyid

Same as orderclose entity [orderclose_transactioncurrency_transactioncurrencyid](orderclose.md#BKMK_orderclose_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: orderclose_transactioncurrency_transactioncurrencyid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_quote"></a> transactioncurrency_quote

Same as quote entity [transactioncurrency_quote](quote.md#BKMK_transactioncurrency_quote) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_quote<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_quoteclose_transactioncurrency_transactioncurrencyid"></a> quoteclose_transactioncurrency_transactioncurrencyid

Same as quoteclose entity [quoteclose_transactioncurrency_transactioncurrencyid](quoteclose.md#BKMK_quoteclose_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: quoteclose_transactioncurrency_transactioncurrencyid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_quotedetail"></a> transactioncurrency_quotedetail

Same as quotedetail entity [transactioncurrency_quotedetail](quotedetail.md#BKMK_transactioncurrency_quotedetail) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_quotedetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_salesorder"></a> transactioncurrency_salesorder

Same as salesorder entity [transactioncurrency_salesorder](salesorder.md#BKMK_transactioncurrency_salesorder) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_salesorder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_salesorderdetail"></a> transactioncurrency_salesorderdetail

Same as salesorderdetail entity [transactioncurrency_salesorderdetail](salesorderdetail.md#BKMK_transactioncurrency_salesorderdetail) Many-To-One relationship.

**ReferencingEntity**: salesorderdetail<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_salesorderdetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_competitor"></a> transactioncurrency_competitor

Same as competitor entity [transactioncurrency_competitor](competitor.md#BKMK_transactioncurrency_competitor) Many-To-One relationship.

**ReferencingEntity**: competitor<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_competitor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_discounttype"></a> transactioncurrency_discounttype

Same as discounttype entity [transactioncurrency_discounttype](discounttype.md#BKMK_transactioncurrency_discounttype) Many-To-One relationship.

**ReferencingEntity**: discounttype<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_discounttype<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_SalesLiterature"></a> TransactionCurrency_SalesLiterature

Same as salesliterature entity [TransactionCurrency_SalesLiterature](salesliterature.md#BKMK_TransactionCurrency_SalesLiterature) Many-To-One relationship.

**ReferencingEntity**: salesliterature<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_SalesLiterature<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_leadtoopportunitysalesprocess"></a> transactioncurrency_leadtoopportunitysalesprocess

Same as leadtoopportunitysalesprocess entity [transactioncurrency_leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md#BKMK_transactioncurrency_leadtoopportunitysalesprocess) Many-To-One relationship.

**ReferencingEntity**: leadtoopportunitysalesprocess<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_leadtoopportunitysalesprocess<br />
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


### <a name="BKMK_transactioncurrency_opportunitysalesprocess"></a> transactioncurrency_opportunitysalesprocess

Same as opportunitysalesprocess entity [transactioncurrency_opportunitysalesprocess](opportunitysalesprocess.md#BKMK_transactioncurrency_opportunitysalesprocess) Many-To-One relationship.

**ReferencingEntity**: opportunitysalesprocess<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_opportunitysalesprocess<br />
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


### <a name="BKMK_TransactionCurrency_msdyn_actual"></a> TransactionCurrency_msdyn_actual

Same as msdyn_actual entity [TransactionCurrency_msdyn_actual](msdyn_actual.md#BKMK_TransactionCurrency_msdyn_actual) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_actual<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid"></a> msdyn_bookingalert_transactioncurrency_transactioncurrencyid

Same as msdyn_bookingalert entity [msdyn_bookingalert_transactioncurrency_transactioncurrencyid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingalert_transactioncurrency_transactioncurrencyid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_approval_transactioncurrency_transactioncurrencyid"></a> msdyn_approval_transactioncurrency_transactioncurrencyid

Same as msdyn_approval entity [msdyn_approval_transactioncurrency_transactioncurrencyid](msdyn_approval.md#BKMK_msdyn_approval_transactioncurrency_transactioncurrencyid) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_transactioncurrency_transactioncurrencyid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue"></a> TransactionCurrency_msdyn_contractlinescheduleofvalue

Same as msdyn_contractlinescheduleofvalue entity [TransactionCurrency_msdyn_contractlinescheduleofvalue](msdyn_contractlinescheduleofvalue.md#BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue) Many-To-One relationship.

**ReferencingEntity**: msdyn_contractlinescheduleofvalue<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_contractlinescheduleofvalue<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_estimateline"></a> TransactionCurrency_msdyn_estimateline

Same as msdyn_estimateline entity [TransactionCurrency_msdyn_estimateline](msdyn_estimateline.md#BKMK_TransactionCurrency_msdyn_estimateline) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_estimateline<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_expense"></a> TransactionCurrency_msdyn_expense

Same as msdyn_expense entity [TransactionCurrency_msdyn_expense](msdyn_expense.md#BKMK_TransactionCurrency_msdyn_expense) Many-To-One relationship.

**ReferencingEntity**: msdyn_expense<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_expense<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_fact"></a> TransactionCurrency_msdyn_fact

Same as msdyn_fact entity [TransactionCurrency_msdyn_fact](msdyn_fact.md#BKMK_TransactionCurrency_msdyn_fact) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_fact<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_invoicelinetransaction"></a> TransactionCurrency_msdyn_invoicelinetransaction

Same as msdyn_invoicelinetransaction entity [TransactionCurrency_msdyn_invoicelinetransaction](msdyn_invoicelinetransaction.md#BKMK_TransactionCurrency_msdyn_invoicelinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_invoicelinetransaction<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_journalline"></a> TransactionCurrency_msdyn_journalline

Same as msdyn_journalline entity [TransactionCurrency_msdyn_journalline](msdyn_journalline.md#BKMK_TransactionCurrency_msdyn_journalline) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_journalline<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_opportunitylinetransaction"></a> TransactionCurrency_msdyn_opportunitylinetransaction

Same as msdyn_opportunitylinetransaction entity [TransactionCurrency_msdyn_opportunitylinetransaction](msdyn_opportunitylinetransaction.md#BKMK_TransactionCurrency_msdyn_opportunitylinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_opportunitylinetransaction<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_orderlinetransaction"></a> TransactionCurrency_msdyn_orderlinetransaction

Same as msdyn_orderlinetransaction entity [TransactionCurrency_msdyn_orderlinetransaction](msdyn_orderlinetransaction.md#BKMK_TransactionCurrency_msdyn_orderlinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_orderlinetransaction<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_project"></a> TransactionCurrency_msdyn_project

Same as msdyn_project entity [TransactionCurrency_msdyn_project](msdyn_project.md#BKMK_TransactionCurrency_msdyn_project) Many-To-One relationship.

**ReferencingEntity**: msdyn_project<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_project<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_projectapproval"></a> TransactionCurrency_msdyn_projectapproval

Same as msdyn_projectapproval entity [TransactionCurrency_msdyn_projectapproval](msdyn_projectapproval.md#BKMK_TransactionCurrency_msdyn_projectapproval) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectapproval<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_projectapproval<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_projecttask"></a> TransactionCurrency_msdyn_projecttask

Same as msdyn_projecttask entity [TransactionCurrency_msdyn_projecttask](msdyn_projecttask.md#BKMK_TransactionCurrency_msdyn_projecttask) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttask<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_projecttask<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown"></a> TransactionCurrency_msdyn_quotelineanalyticsbreakdown

Same as msdyn_quotelineanalyticsbreakdown entity [TransactionCurrency_msdyn_quotelineanalyticsbreakdown](msdyn_quotelineanalyticsbreakdown.md#BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineanalyticsbreakdown<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_quotelineanalyticsbreakdown<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue"></a> TransactionCurrency_msdyn_quotelinescheduleofvalue

Same as msdyn_quotelinescheduleofvalue entity [TransactionCurrency_msdyn_quotelinescheduleofvalue](msdyn_quotelinescheduleofvalue.md#BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinescheduleofvalue<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_quotelinescheduleofvalue<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_quotelinetransaction"></a> TransactionCurrency_msdyn_quotelinetransaction

Same as msdyn_quotelinetransaction entity [TransactionCurrency_msdyn_quotelinetransaction](msdyn_quotelinetransaction.md#BKMK_TransactionCurrency_msdyn_quotelinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_quotelinetransaction<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel"></a> TransactionCurrency_msdyn_resourcecategorypricelevel

Same as msdyn_resourcecategorypricelevel entity [TransactionCurrency_msdyn_resourcecategorypricelevel](msdyn_resourcecategorypricelevel.md#BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcecategorypricelevel<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_resourcecategorypricelevel<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_resourcerequirement"></a> TransactionCurrency_msdyn_resourcerequirement

Same as msdyn_resourcerequirement entity [TransactionCurrency_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_TransactionCurrency_msdyn_resourcerequirement) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequirement<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_resourcerequirement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_transactioncategorypricelevel"></a> TransactionCurrency_msdyn_transactioncategorypricelevel

Same as msdyn_transactioncategorypricelevel entity [TransactionCurrency_msdyn_transactioncategorypricelevel](msdyn_transactioncategorypricelevel.md#BKMK_TransactionCurrency_msdyn_transactioncategorypricelevel) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategorypricelevel<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_transactioncategorypricelevel<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_organizationalunit_currency"></a> msdyn_organizationalunit_currency

Same as msdyn_organizationalunit entity [msdyn_organizationalunit_currency](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_currency) Many-To-One relationship.

**ReferencingEntity**: msdyn_organizationalunit<br />
**ReferencingAttribute**: msdyn_currency<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_organizationalunit_currency<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_agreementbookingproduct"></a> TransactionCurrency_msdyn_agreementbookingproduct

Same as msdyn_agreementbookingproduct entity [TransactionCurrency_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_TransactionCurrency_msdyn_agreementbookingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_agreementbookingproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_agreementbookingservice"></a> TransactionCurrency_msdyn_agreementbookingservice

Same as msdyn_agreementbookingservice entity [TransactionCurrency_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_TransactionCurrency_msdyn_agreementbookingservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservice<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_agreementbookingservice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct"></a> TransactionCurrency_msdyn_agreementinvoiceproduct

Same as msdyn_agreementinvoiceproduct entity [TransactionCurrency_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoiceproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_agreementinvoiceproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_bookingjournal"></a> TransactionCurrency_msdyn_bookingjournal

Same as msdyn_bookingjournal entity [TransactionCurrency_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_TransactionCurrency_msdyn_bookingjournal) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingjournal<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_bookingjournal<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem"></a> TransactionCurrency_msdyn_fieldservicepricelistitem

Same as msdyn_fieldservicepricelistitem entity [TransactionCurrency_msdyn_fieldservicepricelistitem](msdyn_fieldservicepricelistitem.md#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldservicepricelistitem<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_fieldservicepricelistitem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_orderinvoicingproduct"></a> TransactionCurrency_msdyn_orderinvoicingproduct

Same as msdyn_orderinvoicingproduct entity [TransactionCurrency_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_TransactionCurrency_msdyn_orderinvoicingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_orderinvoicingproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_payment"></a> TransactionCurrency_msdyn_payment

Same as msdyn_payment entity [TransactionCurrency_msdyn_payment](msdyn_payment.md#BKMK_TransactionCurrency_msdyn_payment) Many-To-One relationship.

**ReferencingEntity**: msdyn_payment<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_payment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_paymentdetail"></a> TransactionCurrency_msdyn_paymentdetail

Same as msdyn_paymentdetail entity [TransactionCurrency_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_TransactionCurrency_msdyn_paymentdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_paymentdetail<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_paymentdetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_purchaseorder"></a> TransactionCurrency_msdyn_purchaseorder

Same as msdyn_purchaseorder entity [TransactionCurrency_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_TransactionCurrency_msdyn_purchaseorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorder<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_purchaseorder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderbill"></a> TransactionCurrency_msdyn_purchaseorderbill

Same as msdyn_purchaseorderbill entity [TransactionCurrency_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_TransactionCurrency_msdyn_purchaseorderbill) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderbill<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_purchaseorderbill<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderproduct"></a> TransactionCurrency_msdyn_purchaseorderproduct

Same as msdyn_purchaseorderproduct entity [TransactionCurrency_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_TransactionCurrency_msdyn_purchaseorderproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_purchaseorderproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct"></a> TransactionCurrency_msdyn_purchaseorderreceiptproduct

Same as msdyn_purchaseorderreceiptproduct entity [TransactionCurrency_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceiptproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_purchaseorderreceiptproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_quotebookingproduct"></a> TransactionCurrency_msdyn_quotebookingproduct

Same as msdyn_quotebookingproduct entity [TransactionCurrency_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_TransactionCurrency_msdyn_quotebookingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_quotebookingproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_quotebookingservice"></a> TransactionCurrency_msdyn_quotebookingservice

Same as msdyn_quotebookingservice entity [TransactionCurrency_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_TransactionCurrency_msdyn_quotebookingservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservice<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_quotebookingservice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_quotebookingsetup"></a> TransactionCurrency_msdyn_quotebookingsetup

Same as msdyn_quotebookingsetup entity [TransactionCurrency_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_TransactionCurrency_msdyn_quotebookingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingsetup<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_quotebookingsetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct"></a> TransactionCurrency_msdyn_quoteinvoicingproduct

Same as msdyn_quoteinvoicingproduct entity [TransactionCurrency_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_quoteinvoicingproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_quoteinvoicingproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup"></a> TransactionCurrency_msdyn_quoteinvoicingsetup

Same as msdyn_quoteinvoicingsetup entity [TransactionCurrency_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quoteinvoicingsetup<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_quoteinvoicingsetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_rma"></a> TransactionCurrency_msdyn_rma

Same as msdyn_rma entity [TransactionCurrency_msdyn_rma](msdyn_rma.md#BKMK_TransactionCurrency_msdyn_rma) Many-To-One relationship.

**ReferencingEntity**: msdyn_rma<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_rma<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_rmaproduct"></a> TransactionCurrency_msdyn_rmaproduct

Same as msdyn_rmaproduct entity [TransactionCurrency_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_TransactionCurrency_msdyn_rmaproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_rmaproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_rtv"></a> TransactionCurrency_msdyn_rtv

Same as msdyn_rtv entity [TransactionCurrency_msdyn_rtv](msdyn_rtv.md#BKMK_TransactionCurrency_msdyn_rtv) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_rtv<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_rtvproduct"></a> TransactionCurrency_msdyn_rtvproduct

Same as msdyn_rtvproduct entity [TransactionCurrency_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_TransactionCurrency_msdyn_rtvproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_rtvproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_workorder"></a> TransactionCurrency_msdyn_workorder

Same as msdyn_workorder entity [TransactionCurrency_msdyn_workorder](msdyn_workorder.md#BKMK_TransactionCurrency_msdyn_workorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_workorder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_workorderproduct"></a> TransactionCurrency_msdyn_workorderproduct

Same as msdyn_workorderproduct entity [TransactionCurrency_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_TransactionCurrency_msdyn_workorderproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_workorderproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_msdyn_workorderservice"></a> TransactionCurrency_msdyn_workorderservice

Same as msdyn_workorderservice entity [TransactionCurrency_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_TransactionCurrency_msdyn_workorderservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_msdyn_workorderservice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_transactioncurrency_invoicedetail_Currency"></a> msdyn_transactioncurrency_invoicedetail_Currency

Same as invoicedetail entity [msdyn_transactioncurrency_invoicedetail_Currency](invoicedetail.md#BKMK_msdyn_transactioncurrency_invoicedetail_Currency) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: msdyn_currency<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncurrency_invoicedetail_Currency<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Goal"></a> TransactionCurrency_Goal

Same as goal entity [TransactionCurrency_Goal](goal.md#BKMK_TransactionCurrency_Goal) Many-To-One relationship.

**ReferencingEntity**: goal<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Goal<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_SharePointSite"></a> TransactionCurrency_SharePointSite

Same as sharepointsite entity [TransactionCurrency_SharePointSite](sharepointsite.md#BKMK_TransactionCurrency_SharePointSite) Many-To-One relationship.

**ReferencingEntity**: sharepointsite<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_SharePointSite<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_QueueItem"></a> TransactionCurrency_QueueItem

Same as queueitem entity [TransactionCurrency_QueueItem](queueitem.md#BKMK_TransactionCurrency_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_QueueItem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_actioncard"></a> transactioncurrency_actioncard

Same as actioncard entity [transactioncurrency_actioncard](actioncard.md#BKMK_transactioncurrency_actioncard) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_actioncard<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_officegraphdocument"></a> TransactionCurrency_officegraphdocument

Same as officegraphdocument entity [TransactionCurrency_officegraphdocument](officegraphdocument.md#BKMK_TransactionCurrency_officegraphdocument) Many-To-One relationship.

**ReferencingEntity**: officegraphdocument<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_officegraphdocument<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_KnowledgeBaseRecord"></a> TransactionCurrency_KnowledgeBaseRecord

Same as knowledgebaserecord entity [TransactionCurrency_KnowledgeBaseRecord](knowledgebaserecord.md#BKMK_TransactionCurrency_KnowledgeBaseRecord) Many-To-One relationship.

**ReferencingEntity**: knowledgebaserecord<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_KnowledgeBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_SharePointDocument"></a> TransactionCurrency_SharePointDocument

Same as sharepointdocument entity [TransactionCurrency_SharePointDocument](sharepointdocument.md#BKMK_TransactionCurrency_SharePointDocument) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_SharePointDocument<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_delveactionhub"></a> TransactionCurrency_delveactionhub

Same as delveactionhub entity [TransactionCurrency_delveactionhub](delveactionhub.md#BKMK_TransactionCurrency_delveactionhub) Many-To-One relationship.

**ReferencingEntity**: delveactionhub<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_delveactionhub<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_ActionCardUserState"></a> TransactionCurrency_ActionCardUserState

Same as actioncarduserstate entity [TransactionCurrency_ActionCardUserState](actioncarduserstate.md#BKMK_TransactionCurrency_ActionCardUserState) Many-To-One relationship.

**ReferencingEntity**: actioncarduserstate<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_ActionCardUserState<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_SharePointDocumentLocation"></a> TransactionCurrency_SharePointDocumentLocation

Same as sharepointdocumentlocation entity [TransactionCurrency_SharePointDocumentLocation](sharepointdocumentlocation.md#BKMK_TransactionCurrency_SharePointDocumentLocation) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_SharePointDocumentLocation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_SLAItem"></a> TransactionCurrency_SLAItem

Same as slaitem entity [TransactionCurrency_SLAItem](slaitem.md#BKMK_TransactionCurrency_SLAItem) Many-To-One relationship.

**ReferencingEntity**: slaitem<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_SLAItem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_expiredprocess"></a> transactioncurrency_expiredprocess

Same as expiredprocess entity [transactioncurrency_expiredprocess](expiredprocess.md#BKMK_transactioncurrency_expiredprocess) Many-To-One relationship.

**ReferencingEntity**: expiredprocess<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_expiredprocess<br />
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


### <a name="BKMK_TransactionCurrency_externalpartyitem"></a> TransactionCurrency_externalpartyitem

Same as externalpartyitem entity [TransactionCurrency_externalpartyitem](externalpartyitem.md#BKMK_TransactionCurrency_externalpartyitem) Many-To-One relationship.

**ReferencingEntity**: externalpartyitem<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_externalpartyitem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_profileruleitem"></a> TransactionCurrency_profileruleitem

Same as channelaccessprofileruleitem entity [TransactionCurrency_profileruleitem](channelaccessprofileruleitem.md#BKMK_TransactionCurrency_profileruleitem) Many-To-One relationship.

**ReferencingEntity**: channelaccessprofileruleitem<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_profileruleitem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_ProcessSessions"></a> TransactionCurrency_ProcessSessions

Same as processsession entity [TransactionCurrency_ProcessSessions](processsession.md#BKMK_TransactionCurrency_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_ProcessSessions<br />
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


### <a name="BKMK_TransactionCurrency_profilerule"></a> TransactionCurrency_profilerule

Same as channelaccessprofilerule entity [TransactionCurrency_profilerule](channelaccessprofilerule.md#BKMK_TransactionCurrency_profilerule) Many-To-One relationship.

**ReferencingEntity**: channelaccessprofilerule<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_profilerule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_SyncErrors"></a> TransactionCurrency_SyncErrors

Same as syncerror entity [TransactionCurrency_SyncErrors](syncerror.md#BKMK_TransactionCurrency_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_SyncErrors<br />
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


### <a name="BKMK_transactioncurrency_socialactivity"></a> transactioncurrency_socialactivity

Same as socialactivity entity [transactioncurrency_socialactivity](socialactivity.md#BKMK_transactioncurrency_socialactivity) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_socialactivity<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_MailMergeTemplate"></a> TransactionCurrency_MailMergeTemplate

Same as mailmergetemplate entity [TransactionCurrency_MailMergeTemplate](mailmergetemplate.md#BKMK_TransactionCurrency_MailMergeTemplate) Many-To-One relationship.

**ReferencingEntity**: mailmergetemplate<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_MailMergeTemplate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_UserMapping"></a> TransactionCurrency_UserMapping

Same as usermapping entity [TransactionCurrency_UserMapping](usermapping.md#BKMK_TransactionCurrency_UserMapping) Many-To-One relationship.

**ReferencingEntity**: usermapping<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_UserMapping<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_fixedmonthlyfiscalcalendar"></a> transactioncurrency_fixedmonthlyfiscalcalendar

Same as fixedmonthlyfiscalcalendar entity [transactioncurrency_fixedmonthlyfiscalcalendar](fixedmonthlyfiscalcalendar.md#BKMK_transactioncurrency_fixedmonthlyfiscalcalendar) Many-To-One relationship.

**ReferencingEntity**: fixedmonthlyfiscalcalendar<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_fixedmonthlyfiscalcalendar<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_semiannualfiscalcalendar"></a> transactioncurrency_semiannualfiscalcalendar

Same as semiannualfiscalcalendar entity [transactioncurrency_semiannualfiscalcalendar](semiannualfiscalcalendar.md#BKMK_transactioncurrency_semiannualfiscalcalendar) Many-To-One relationship.

**ReferencingEntity**: semiannualfiscalcalendar<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_semiannualfiscalcalendar<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_PhoneCall"></a> TransactionCurrency_PhoneCall

Same as phonecall entity [TransactionCurrency_PhoneCall](phonecall.md#BKMK_TransactionCurrency_PhoneCall) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_PhoneCall<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Fax"></a> TransactionCurrency_Fax

Same as fax entity [TransactionCurrency_Fax](fax.md#BKMK_TransactionCurrency_Fax) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Fax<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_usersettings"></a> transactioncurrency_usersettings

Same as usersettings entity [transactioncurrency_usersettings](usersettings.md#BKMK_transactioncurrency_usersettings) Many-To-One relationship.

**ReferencingEntity**: usersettings<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_usersettings<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_userentityinstancedata_transactioncurrency"></a> userentityinstancedata_transactioncurrency

Same as userentityinstancedata entity [userentityinstancedata_transactioncurrency](userentityinstancedata.md#BKMK_userentityinstancedata_transactioncurrency) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_transactioncurrency<br />
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


### <a name="BKMK_TransactionCurrency_ActivityPointer"></a> TransactionCurrency_ActivityPointer

Same as activitypointer entity [TransactionCurrency_ActivityPointer](activitypointer.md#BKMK_TransactionCurrency_ActivityPointer) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_ActivityPointer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_category"></a> transactioncurrency_category

Same as category entity [transactioncurrency_category](category.md#BKMK_transactioncurrency_category) Many-To-One relationship.

**ReferencingEntity**: category<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_category<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_ConvertRule"></a> TransactionCurrency_ConvertRule

Same as convertrule entity [TransactionCurrency_ConvertRule](convertrule.md#BKMK_TransactionCurrency_ConvertRule) Many-To-One relationship.

**ReferencingEntity**: convertrule<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_ConvertRule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_position"></a> transactioncurrency_position

Same as position entity [transactioncurrency_position](position.md#BKMK_transactioncurrency_position) Many-To-One relationship.

**ReferencingEntity**: position<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_position<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Task"></a> TransactionCurrency_Task

Same as task entity [TransactionCurrency_Task](task.md#BKMK_TransactionCurrency_Task) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Task<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_SLA"></a> TransactionCurrency_SLA

Same as sla entity [TransactionCurrency_SLA](sla.md#BKMK_TransactionCurrency_SLA) Many-To-One relationship.

**ReferencingEntity**: sla<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_SLA<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_basecurrency_organization"></a> basecurrency_organization

Same as organization entity [basecurrency_organization](organization.md#BKMK_basecurrency_organization) Many-To-One relationship.

**ReferencingEntity**: organization<br />
**ReferencingAttribute**: basecurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: basecurrency_organization<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Letter"></a> TransactionCurrency_Letter

Same as letter entity [TransactionCurrency_Letter](letter.md#BKMK_TransactionCurrency_Letter) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Letter<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_convertruleitem"></a> transactioncurrency_convertruleitem

Same as convertruleitem entity [transactioncurrency_convertruleitem](convertruleitem.md#BKMK_transactioncurrency_convertruleitem) Many-To-One relationship.

**ReferencingEntity**: convertruleitem<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_convertruleitem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_routingruleitem"></a> TransactionCurrency_routingruleitem

Same as routingruleitem entity [TransactionCurrency_routingruleitem](routingruleitem.md#BKMK_TransactionCurrency_routingruleitem) Many-To-One relationship.

**ReferencingEntity**: routingruleitem<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_routingruleitem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_cardtype"></a> transactioncurrency_cardtype

Same as cardtype entity [transactioncurrency_cardtype](cardtype.md#BKMK_transactioncurrency_cardtype) Many-To-One relationship.

**ReferencingEntity**: cardtype<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_cardtype<br />
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


### <a name="BKMK_TransactionCurrency_SystemUser"></a> TransactionCurrency_SystemUser

Same as systemuser entity [TransactionCurrency_SystemUser](systemuser.md#BKMK_TransactionCurrency_SystemUser) Many-To-One relationship.

**ReferencingEntity**: systemuser<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_SystemUser<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Team"></a> TransactionCurrency_Team

Same as team entity [TransactionCurrency_Team](team.md#BKMK_TransactionCurrency_Team) Many-To-One relationship.

**ReferencingEntity**: team<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Team<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Email"></a> TransactionCurrency_Email

Same as email entity [TransactionCurrency_Email](email.md#BKMK_TransactionCurrency_Email) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Email<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_BusinessUnit"></a> TransactionCurrency_BusinessUnit

Same as businessunit entity [TransactionCurrency_BusinessUnit](businessunit.md#BKMK_TransactionCurrency_BusinessUnit) Many-To-One relationship.

**ReferencingEntity**: businessunit<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_BusinessUnit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_SocialProfile"></a> transactioncurrency_SocialProfile

Same as socialprofile entity [transactioncurrency_SocialProfile](socialprofile.md#BKMK_transactioncurrency_SocialProfile) Many-To-One relationship.

**ReferencingEntity**: socialprofile<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_SocialProfile<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Queue"></a> TransactionCurrency_Queue

Same as queue entity [TransactionCurrency_Queue](queue.md#BKMK_TransactionCurrency_Queue) Many-To-One relationship.

**ReferencingEntity**: queue<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Queue<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_DuplicateMatchingRecord"></a> TransactionCurrency_DuplicateMatchingRecord

Same as duplicaterecord entity [TransactionCurrency_DuplicateMatchingRecord](duplicaterecord.md#BKMK_TransactionCurrency_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_DuplicateMatchingRecord<br />
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


### <a name="BKMK_TransactionCurrency_Appointment"></a> TransactionCurrency_Appointment

Same as appointment entity [TransactionCurrency_Appointment](appointment.md#BKMK_TransactionCurrency_Appointment) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Appointment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_quarterlyfiscalcalendar"></a> transactioncurrency_quarterlyfiscalcalendar

Same as quarterlyfiscalcalendar entity [transactioncurrency_quarterlyfiscalcalendar](quarterlyfiscalcalendar.md#BKMK_transactioncurrency_quarterlyfiscalcalendar) Many-To-One relationship.

**ReferencingEntity**: quarterlyfiscalcalendar<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_quarterlyfiscalcalendar<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_KbArticle"></a> TransactionCurrency_KbArticle

Same as kbarticle entity [TransactionCurrency_KbArticle](kbarticle.md#BKMK_TransactionCurrency_KbArticle) Many-To-One relationship.

**ReferencingEntity**: kbarticle<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_KbArticle<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_monthlyfiscalcalendar"></a> transactioncurrency_monthlyfiscalcalendar

Same as monthlyfiscalcalendar entity [transactioncurrency_monthlyfiscalcalendar](monthlyfiscalcalendar.md#BKMK_transactioncurrency_monthlyfiscalcalendar) Many-To-One relationship.

**ReferencingEntity**: monthlyfiscalcalendar<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_monthlyfiscalcalendar<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_CustomerAddress"></a> TransactionCurrency_CustomerAddress

Same as customeraddress entity [TransactionCurrency_CustomerAddress](customeraddress.md#BKMK_TransactionCurrency_CustomerAddress) Many-To-One relationship.

**ReferencingEntity**: customeraddress<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_CustomerAddress<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_annualfiscalcalendar"></a> transactioncurrency_annualfiscalcalendar

Same as annualfiscalcalendar entity [transactioncurrency_annualfiscalcalendar](annualfiscalcalendar.md#BKMK_transactioncurrency_annualfiscalcalendar) Many-To-One relationship.

**ReferencingEntity**: annualfiscalcalendar<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_annualfiscalcalendar<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Connection"></a> TransactionCurrency_Connection

Same as connection entity [TransactionCurrency_Connection](connection.md#BKMK_TransactionCurrency_Connection) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Connection<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_translationprocess"></a> transactioncurrency_translationprocess

Same as translationprocess entity [transactioncurrency_translationprocess](translationprocess.md#BKMK_transactioncurrency_translationprocess) Many-To-One relationship.

**ReferencingEntity**: translationprocess<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_translationprocess<br />
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


### <a name="BKMK_TransactionCurrency_ExternalParty"></a> TransactionCurrency_ExternalParty

Same as externalparty entity [TransactionCurrency_ExternalParty](externalparty.md#BKMK_TransactionCurrency_ExternalParty) Many-To-One relationship.

**ReferencingEntity**: externalparty<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_externalparty<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_feedback"></a> transactioncurrency_feedback

Same as feedback entity [transactioncurrency_feedback](feedback.md#BKMK_transactioncurrency_feedback) Many-To-One relationship.

**ReferencingEntity**: feedback<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_feedback<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_contact"></a> transactioncurrency_contact

Same as contact entity [transactioncurrency_contact](contact.md#BKMK_transactioncurrency_contact) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_contact<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_ReportCategory"></a> TransactionCurrency_ReportCategory

Same as reportcategory entity [TransactionCurrency_ReportCategory](reportcategory.md#BKMK_TransactionCurrency_ReportCategory) Many-To-One relationship.

**ReferencingEntity**: reportcategory<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_ReportCategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_InteractionForEmail"></a> TransactionCurrency_InteractionForEmail

Same as interactionforemail entity [TransactionCurrency_InteractionForEmail](interactionforemail.md#BKMK_TransactionCurrency_InteractionForEmail) Many-To-One relationship.

**ReferencingEntity**: interactionforemail<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_InteractionForEmail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_suggestioncardtemplate"></a> TransactionCurrency_suggestioncardtemplate

Same as suggestioncardtemplate entity [TransactionCurrency_suggestioncardtemplate](suggestioncardtemplate.md#BKMK_TransactionCurrency_suggestioncardtemplate) Many-To-One relationship.

**ReferencingEntity**: suggestioncardtemplate<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_suggestioncardtemplate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_slakpiinstance"></a> TransactionCurrency_slakpiinstance

Same as slakpiinstance entity [TransactionCurrency_slakpiinstance](slakpiinstance.md#BKMK_TransactionCurrency_slakpiinstance) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_slakpiinstance<br />
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


### <a name="BKMK_TransactionCurrency_DuplicateBaseRecord"></a> TransactionCurrency_DuplicateBaseRecord

Same as duplicaterecord entity [TransactionCurrency_DuplicateBaseRecord](duplicaterecord.md#BKMK_TransactionCurrency_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_DuplicateBaseRecord<br />
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


### <a name="BKMK_TransactionCurrency_AsyncOperations"></a> TransactionCurrency_AsyncOperations

Same as asyncoperation entity [TransactionCurrency_AsyncOperations](asyncoperation.md#BKMK_TransactionCurrency_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_AsyncOperations<br />
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


### <a name="BKMK_transactioncurrency_knowledgearticleviews"></a> transactioncurrency_knowledgearticleviews

Same as knowledgearticleviews entity [transactioncurrency_knowledgearticleviews](knowledgearticleviews.md#BKMK_transactioncurrency_knowledgearticleviews) Many-To-One relationship.

**ReferencingEntity**: knowledgearticleviews<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_knowledgearticleviews<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Theme"></a> TransactionCurrency_Theme

Same as theme entity [TransactionCurrency_Theme](theme.md#BKMK_TransactionCurrency_Theme) Many-To-One relationship.

**ReferencingEntity**: theme<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Theme<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_ChannelAccessProfile"></a> TransactionCurrency_ChannelAccessProfile

Same as channelaccessprofile entity [TransactionCurrency_ChannelAccessProfile](channelaccessprofile.md#BKMK_TransactionCurrency_ChannelAccessProfile) Many-To-One relationship.

**ReferencingEntity**: channelaccessprofile<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_channelaccessprofile<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_newprocess"></a> transactioncurrency_newprocess

Same as newprocess entity [transactioncurrency_newprocess](newprocess.md#BKMK_transactioncurrency_newprocess) Many-To-One relationship.

**ReferencingEntity**: newprocess<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_newprocess<br />
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


### <a name="BKMK_TransactionCurrency_knowledgearticle"></a> TransactionCurrency_knowledgearticle

Same as knowledgearticle entity [TransactionCurrency_knowledgearticle](knowledgearticle.md#BKMK_TransactionCurrency_knowledgearticle) Many-To-One relationship.

**ReferencingEntity**: knowledgearticle<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_knowledgearticle<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_RecurringAppointmentMaster"></a> TransactionCurrency_RecurringAppointmentMaster

Same as recurringappointmentmaster entity [TransactionCurrency_RecurringAppointmentMaster](recurringappointmentmaster.md#BKMK_TransactionCurrency_RecurringAppointmentMaster) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_RecurringAppointmentMaster<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_transactioncurrency_account"></a> transactioncurrency_account

Same as account entity [transactioncurrency_account](account.md#BKMK_transactioncurrency_account) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: transactioncurrency_account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_recommendeddocument"></a> TransactionCurrency_recommendeddocument

Same as recommendeddocument entity [TransactionCurrency_recommendeddocument](recommendeddocument.md#BKMK_TransactionCurrency_recommendeddocument) Many-To-One relationship.

**ReferencingEntity**: recommendeddocument<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_recommendeddocument<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_TransactionCurrency_Routingrule"></a> TransactionCurrency_Routingrule

Same as routingrule entity [TransactionCurrency_Routingrule](routingrule.md#BKMK_TransactionCurrency_Routingrule) Many-To-One relationship.

**ReferencingEntity**: routingrule<br />
**ReferencingAttribute**: transactioncurrencyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: TransactionCurrency_Routingrule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

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

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.transactioncurrency?text=transactioncurrency EntityType" />