---
title: "msdyn_quotelineanalyticsbreakdown Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotelineanalyticsbreakdown entity."
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
# msdyn_quotelineanalyticsbreakdown Entity Reference

Reporting entity that is used to show quoted sales and estimated cost amounts by various dimensions.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineanalyticsbreakdowns(*msdyn_quotelineanalyticsbreakdownid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_quotelineanalyticsbreakdowns|
|DisplayCollectionName|Quote Line Analytics Breakdown|
|DisplayName|Quote Line Analytics Breakdown|
|EntitySetName|msdyn_quotelineanalyticsbreakdowns|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_quotelineanalyticsbreakdowns|
|LogicalName|msdyn_quotelineanalyticsbreakdown|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_quotelineanalyticsbreakdownid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_quotelineanalyticsbreakdown|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Amount](#BKMK_msdyn_Amount)
- [msdyn_BillingType](#BKMK_msdyn_BillingType)
- [msdyn_EndDateTime](#BKMK_msdyn_EndDateTime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Price](#BKMK_msdyn_Price)
- [msdyn_Quote](#BKMK_msdyn_Quote)
- [msdyn_quotelineanalyticsbreakdownId](#BKMK_msdyn_quotelineanalyticsbreakdownId)
- [msdyn_QuoteLineDetail](#BKMK_msdyn_QuoteLineDetail)
- [msdyn_QuoteLineScheduleOfValue](#BKMK_msdyn_QuoteLineScheduleOfValue)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_StartDateTime](#BKMK_msdyn_StartDateTime)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [msdyn_TransactionTypeCode](#BKMK_msdyn_TransactionTypeCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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


### <a name="BKMK_msdyn_Amount"></a> msdyn_Amount

|Property|Value|
|--------|-----|
|Description|Enter the amount on the quote line estimate.|
|DisplayName|Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_BillingType"></a> msdyn_BillingType

|Property|Value|
|--------|-----|
|Description|Select whether the quote line estimate will be charged to the customer. Valid values are Chargeable, Non-chargeable and Complimentary. Only chargeable transactions will affect the invoice totals.|
|DisplayName|Billing Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billingtype|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_BillingType Options

|Value|Label|
|-----|-----|
|192350000|Non Chargeable|
|192350001|Chargeable|
|192350002|Complimentary|
|192350003|Not Available|



### <a name="BKMK_msdyn_EndDateTime"></a> msdyn_EndDateTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the estimated end date of the quote line estimate.|
|DisplayName|End Date Time|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enddatetime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Type a description of the entity breakdown.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Price"></a> msdyn_Price

|Property|Value|
|--------|-----|
|Description|Enter the unit price on the quote line estimate.|
|DisplayName|Price|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_price|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_Quote"></a> msdyn_Quote

|Property|Value|
|--------|-----|
|Description|Select the quote that this quote line estimate belongs to.|
|DisplayName|Quote|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quote|
|RequiredLevel|ApplicationRequired|
|Targets|quote|
|Type|Lookup|


### <a name="BKMK_msdyn_quotelineanalyticsbreakdownId"></a> msdyn_quotelineanalyticsbreakdownId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Quote Line Analytics Breakdown|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_quotelineanalyticsbreakdownid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_QuoteLineDetail"></a> msdyn_QuoteLineDetail

|Property|Value|
|--------|-----|
|Description|Select the quote line estimate.|
|DisplayName|Quote Line Detail|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quotelinedetail|
|RequiredLevel|None|
|Targets|msdyn_quotelinetransaction|
|Type|Lookup|


### <a name="BKMK_msdyn_QuoteLineScheduleOfValue"></a> msdyn_QuoteLineScheduleOfValue

|Property|Value|
|--------|-----|
|Description|Shows the billing milestone for the quote line.|
|DisplayName|QuoteLineScheduleOfValue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quotelinescheduleofvalue|
|RequiredLevel|None|
|Targets|msdyn_quotelinescheduleofvalue|
|Type|Lookup|


### <a name="BKMK_msdyn_ResourceCategory"></a> msdyn_ResourceCategory

|Property|Value|
|--------|-----|
|Description|Select the role that is estimated on the quote line.|
|DisplayName|Role|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategory|
|RequiredLevel|None|
|Targets|bookableresourcecategory|
|Type|Lookup|


### <a name="BKMK_msdyn_StartDateTime"></a> msdyn_StartDateTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the estimated start date of the quote line estimate.|
|DisplayName|Start Date Time|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startdatetime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

|Property|Value|
|--------|-----|
|Description|Select the category identified on the quote line estimate.|
|DisplayName|Transaction Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategory|
|RequiredLevel|None|
|Targets|msdyn_transactioncategory|
|Type|Lookup|


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

|Property|Value|
|--------|-----|
|Description|Transaction classification of  Project quote analytics|
|DisplayName|Transaction Class|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactionclassification|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_TransactionClassification Options

|Value|Label|
|-----|-----|
|192350000|Time|
|192350001|Expense|
|192350002|Material|
|192350003|Milestone|
|192350004|Fee|
|690970000|Commission|
|690970001|Additional|
|690970002|Tax|



### <a name="BKMK_msdyn_TransactionTypeCode"></a> msdyn_TransactionTypeCode

|Property|Value|
|--------|-----|
|Description|Transaction type of the Project quote analytics|
|DisplayName|Transaction Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactiontypecode|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_TransactionTypeCode Options

|Value|Label|
|-----|-----|
|192350000|Cost|
|192350004|Project Contract|
|192350005|Unbilled Sales|
|192350006|Billed Sales|
|192350007|Resourcing Unit Cost|
|192350008|Inter-Organizational Sales|



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

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Quote Line Analytics Breakdown|
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
|Description|Reason for the status of the Quote Line Analytics Breakdown|
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
- [msdyn_amount_Base](#BKMK_msdyn_amount_Base)
- [msdyn_price_Base](#BKMK_msdyn_price_Base)
- [msdyn_QuoteLineDetailName](#BKMK_msdyn_QuoteLineDetailName)
- [msdyn_QuoteLineScheduleOfValueName](#BKMK_msdyn_QuoteLineScheduleOfValueName)
- [msdyn_QuoteName](#BKMK_msdyn_QuoteName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
- [msdyn_TransactionCategoryName](#BKMK_msdyn_TransactionCategoryName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_amount_Base"></a> msdyn_amount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Amount in base currency.|
|DisplayName|Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_msdyn_QuoteLineDetailName"></a> msdyn_QuoteLineDetailName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_quotelinedetailname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_QuoteLineScheduleOfValueName"></a> msdyn_QuoteLineScheduleOfValueName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_quotelinescheduleofvaluename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_QuoteName"></a> msdyn_QuoteName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_quotename|
|MaxLength|300|
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


### <a name="BKMK_msdyn_TransactionCategoryName"></a> msdyn_TransactionCategoryName

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
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
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
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


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

- [msdyn_quotelineanalyticsbreakdown_SyncErrors](#BKMK_msdyn_quotelineanalyticsbreakdown_SyncErrors)
- [msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord](#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord)
- [msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord](#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord)
- [msdyn_quotelineanalyticsbreakdown_AsyncOperations](#BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations)
- [msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders](#BKMK_msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders)
- [msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas](#BKMK_msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas)
- [msdyn_quotelineanalyticsbreakdown_ProcessSession](#BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession)
- [msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures](#BKMK_msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures)
- [msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_SyncErrors"></a> msdyn_quotelineanalyticsbreakdown_SyncErrors

Same as syncerror entity [msdyn_quotelineanalyticsbreakdown_SyncErrors](syncerror.md#BKMK_msdyn_quotelineanalyticsbreakdown_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelineanalyticsbreakdown_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord"></a> msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord"></a> msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations"></a> msdyn_quotelineanalyticsbreakdown_AsyncOperations

Same as asyncoperation entity [msdyn_quotelineanalyticsbreakdown_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelineanalyticsbreakdown_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders"></a> msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas"></a> msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelineanalyticsbreakdown_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession"></a> msdyn_quotelineanalyticsbreakdown_ProcessSession

Same as processsession entity [msdyn_quotelineanalyticsbreakdown_ProcessSession](processsession.md#BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelineanalyticsbreakdown_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures"></a> msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses"></a> msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_quotelineanalyticsbreakdown_createdby](#BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdby)
- [lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby](#BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby)
- [lk_msdyn_quotelineanalyticsbreakdown_modifiedby](#BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedby)
- [lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby](#BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby)
- [user_msdyn_quotelineanalyticsbreakdown](#BKMK_user_msdyn_quotelineanalyticsbreakdown)
- [team_msdyn_quotelineanalyticsbreakdown](#BKMK_team_msdyn_quotelineanalyticsbreakdown)
- [business_unit_msdyn_quotelineanalyticsbreakdown](#BKMK_business_unit_msdyn_quotelineanalyticsbreakdown)
- [TransactionCurrency_msdyn_quotelineanalyticsbreakdown](#BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown)
- [msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory)
- [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue](#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue)
- [msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail](#BKMK_msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail)
- [msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory)
- [msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote](#BKMK_msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote)


### <a name="BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdby"></a> lk_msdyn_quotelineanalyticsbreakdown_createdby

See systemuser Entity [lk_msdyn_quotelineanalyticsbreakdown_createdby](systemuser.md#BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby"></a> lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby

See systemuser Entity [lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedby"></a> lk_msdyn_quotelineanalyticsbreakdown_modifiedby

See systemuser Entity [lk_msdyn_quotelineanalyticsbreakdown_modifiedby](systemuser.md#BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby"></a> lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby

See systemuser Entity [lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotelineanalyticsbreakdown"></a> user_msdyn_quotelineanalyticsbreakdown

See systemuser Entity [user_msdyn_quotelineanalyticsbreakdown](systemuser.md#BKMK_user_msdyn_quotelineanalyticsbreakdown) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotelineanalyticsbreakdown"></a> team_msdyn_quotelineanalyticsbreakdown

See team Entity [team_msdyn_quotelineanalyticsbreakdown](team.md#BKMK_team_msdyn_quotelineanalyticsbreakdown) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotelineanalyticsbreakdown"></a> business_unit_msdyn_quotelineanalyticsbreakdown

See businessunit Entity [business_unit_msdyn_quotelineanalyticsbreakdown](businessunit.md#BKMK_business_unit_msdyn_quotelineanalyticsbreakdown) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown"></a> TransactionCurrency_msdyn_quotelineanalyticsbreakdown

See transactioncurrency Entity [TransactionCurrency_msdyn_quotelineanalyticsbreakdown](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotelineanalyticsbreakdown) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue"></a> msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue

See msdyn_quotelinescheduleofvalue Entity [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail"></a> msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail

See msdyn_quotelinetransaction Entity [msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail](msdyn_quotelinetransaction.md#BKMK_msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote"></a> msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote

See quote Entity [msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotelineanalyticsbreakdown?text=msdyn_quotelineanalyticsbreakdown EntityType" />