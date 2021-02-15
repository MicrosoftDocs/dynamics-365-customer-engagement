---
title: "Contract Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Contract entity."
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
# Contract Entity Reference

Agreement to provide customer service during a specified amount of time or number of cases.

**Added by**: Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CancelContract|<xref href="Microsoft.Dynamics.CRM.CancelContract?text=CancelContract Action" />|<xref:Microsoft.Crm.Sdk.Messages.CancelContractRequest>|
|CancelSalesOrder|<xref href="Microsoft.Dynamics.CRM.CancelSalesOrder?text=CancelSalesOrder Action" />|<xref:Microsoft.Crm.Sdk.Messages.CancelSalesOrderRequest>|
|CloneContract|<xref href="Microsoft.Dynamics.CRM.CloneContract?text=CloneContract Action" />|<xref:Microsoft.Crm.Sdk.Messages.CloneContractRequest>|
|Create|POST [*org URI*]/api/data/v9.0/contracts<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|RenewContract|<xref href="Microsoft.Dynamics.CRM.RenewContract?text=RenewContract Action" />|<xref:Microsoft.Crm.Sdk.Messages.RenewContractRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/contracts<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref href="Microsoft.Dynamics.CRM.Rollup?text=Rollup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Contracts|
|DisplayCollectionName|Contracts|
|DisplayName|Contract|
|EntitySetName|contracts|
|IsBPFEntity|False|
|LogicalCollectionName|contracts|
|LogicalName|contract|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|contractid|
|PrimaryNameAttribute|title|
|SchemaName|Contract|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActiveOn](#BKMK_ActiveOn)
- [AllotmentTypeCode](#BKMK_AllotmentTypeCode)
- [BillingCustomerId](#BKMK_BillingCustomerId)
- [BillingCustomerIdType](#BKMK_BillingCustomerIdType)
- [BillingEndOn](#BKMK_BillingEndOn)
- [BillingFrequencyCode](#BKMK_BillingFrequencyCode)
- [BillingStartOn](#BKMK_BillingStartOn)
- [BillToAddress](#BKMK_BillToAddress)
- [ContractId](#BKMK_ContractId)
- [ContractLanguage](#BKMK_ContractLanguage)
- [ContractNumber](#BKMK_ContractNumber)
- [ContractServiceLevelCode](#BKMK_ContractServiceLevelCode)
- [ContractTemplateId](#BKMK_ContractTemplateId)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [EffectivityCalendar](#BKMK_EffectivityCalendar)
- [EmailAddress](#BKMK_EmailAddress)
- [EntityImage](#BKMK_EntityImage)
- [ExpiresOn](#BKMK_ExpiresOn)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OriginatingContract](#BKMK_OriginatingContract)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ServiceAddress](#BKMK_ServiceAddress)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [Title](#BKMK_Title)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UseDiscountAsPercentage](#BKMK_UseDiscountAsPercentage)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActiveOn"></a> ActiveOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the contract becomes active.|
|DisplayName|Contract Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activeon|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_AllotmentTypeCode"></a> AllotmentTypeCode

|Property|Value|
|--------|-----|
|Description|Type of allotment that the contract supports.|
|DisplayName|Allotment Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allotmenttypecode|
|RequiredLevel|None|
|Type|Picklist|

#### AllotmentTypeCode Options

|Value|Label|
|-----|-----|
|1|Number of Cases|
|2|Time|
|3|Coverage Dates|



### <a name="BKMK_BillingCustomerId"></a> BillingCustomerId

|Property|Value|
|--------|-----|
|Description|Select the customer account or contact to which the contract should be billed to provide a quick link to address and other customer details.|
|DisplayName|Bill To Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billingcustomerid|
|RequiredLevel|SystemRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_BillingCustomerIdType"></a> BillingCustomerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Bill To Customer Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billingcustomeridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_BillingEndOn"></a> BillingEndOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the end date for the contract's billing period to indicate the period for which the customer must pay for a service.|
|DisplayName|Billing End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billingendon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_BillingFrequencyCode"></a> BillingFrequencyCode

|Property|Value|
|--------|-----|
|Description|Select the billing schedule of the contract to indicate how often the customer should be invoiced.|
|DisplayName|Billing Frequency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billingfrequencycode|
|RequiredLevel|None|
|Type|Picklist|

#### BillingFrequencyCode Options

|Value|Label|
|-----|-----|
|1|Monthly|
|2|Bimonthly|
|3|Quarterly|
|4|Semiannually|
|5|Annually|



### <a name="BKMK_BillingStartOn"></a> BillingStartOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the start date for the contract's billing period to indicate the period for which the customer must pay for a service. This defaults to the same date that is selected in the Contract Start Date field.|
|DisplayName|Billing Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billingstarton|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_BillToAddress"></a> BillToAddress

|Property|Value|
|--------|-----|
|Description|Choose which address to send the invoice to.|
|DisplayName|Bill To Address|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billtoaddress|
|RequiredLevel|None|
|Targets|customeraddress|
|Type|Lookup|


### <a name="BKMK_ContractId"></a> ContractId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the contract.|
|DisplayName|Contract|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|contractid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ContractLanguage"></a> ContractLanguage

|Property|Value|
|--------|-----|
|Description|Type additional information about the contract, such as the products or services provided to the customer.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|contractlanguage|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ContractNumber"></a> ContractNumber

|Property|Value|
|--------|-----|
|Description|Shows the number for the contract for customer reference and searching capabilities. You cannot modify this number.|
|DisplayName|Contract ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|contractnumber|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContractServiceLevelCode"></a> ContractServiceLevelCode

|Property|Value|
|--------|-----|
|Description|Select the level of service that should be provided for the contract based on your company's definition of bronze, silver, or gold.|
|DisplayName|Service Level|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|contractservicelevelcode|
|RequiredLevel|None|
|Type|Picklist|

#### ContractServiceLevelCode Options

|Value|Label|
|-----|-----|
|1|Gold|
|2|Silver|
|3|Bronze|



### <a name="BKMK_ContractTemplateId"></a> ContractTemplateId

|Property|Value|
|--------|-----|
|Description|Choose the contract template that should be used to determine the terms of the contract, such as allotment type, available hours, and billing frequency.|
|DisplayName|Contract Template|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|contracttemplateid|
|RequiredLevel|SystemRequired|
|Targets|contracttemplate|
|Type|Lookup|


### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|--------|-----|
|Description|Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.|
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerid|
|RequiredLevel|SystemRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customer Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_EffectivityCalendar"></a> EffectivityCalendar

|Property|Value|
|--------|-----|
|Description|Days of the week and times during which customer service support is available for the duration of the contract.|
|DisplayName|Support Calendar|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|effectivitycalendar|
|MaxLength|168|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|--------|-----|
|Description|The primary email address for the entity.|
|DisplayName|Email Address|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_ExpiresOn"></a> ExpiresOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the contract expires.|
|DisplayName|Contract End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|expireson|
|RequiredLevel|SystemRequired|
|Type|DateTime|


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


### <a name="BKMK_OriginatingContract"></a> OriginatingContract

|Property|Value|
|--------|-----|
|Description|Choose the original contract that this contract was created from. This information is used to track renewal history.|
|DisplayName|Originating Contract|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|originatingcontract|
|RequiredLevel|None|
|Targets|contract|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_ServiceAddress"></a> ServiceAddress

|Property|Value|
|--------|-----|
|Description|Choose the address for the customer account or contact where the services are provided.|
|DisplayName|Contract Address|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|serviceaddress|
|RequiredLevel|None|
|Targets|customeraddress|
|Type|Lookup|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the contract is in draft, invoiced, active, on hold, canceled, or expired. You can edit only the contracts that are in draft status.|
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
|0|Draft|1|Draft|
|1|Invoiced|2|Invoiced|
|2|Active|3|Active|
|3|On Hold|4|On Hold|
|4|Canceled|5|Canceled|
|5|Expired|6|Expired|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the contract's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Draft|0|
|2|Invoiced|1|
|3|Active|2|
|4|On Hold|3|
|5|Canceled|4|
|6|Expired|5|



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


### <a name="BKMK_Title"></a> Title

|Property|Value|
|--------|-----|
|Description|Type a title or name for the contract that indicates the purpose of the contract.|
|DisplayName|Contract Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|title|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|transactioncurrencyid|
|RequiredLevel|ApplicationRequired|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_UseDiscountAsPercentage"></a> UseDiscountAsPercentage

|Property|Value|
|--------|-----|
|Description|Select whether the discounts entered on contract lines for this contract should be entered as a percentage or a fixed dollar value.|
|DisplayName|Discount|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|usediscountaspercentage|
|RequiredLevel|None|
|Type|Boolean|

#### UseDiscountAsPercentage Options

|Value|Label|
|-----|-----|
|1|Percentage|
|0|Amount|

**DefaultValue**: False



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

- [AccountId](#BKMK_AccountId)
- [AccountIdName](#BKMK_AccountIdName)
- [AccountIdYomiName](#BKMK_AccountIdYomiName)
- [BillingAccountId](#BKMK_BillingAccountId)
- [BillingAccountIdName](#BKMK_BillingAccountIdName)
- [BillingAccountIdYomiName](#BKMK_BillingAccountIdYomiName)
- [BillingContactId](#BKMK_BillingContactId)
- [BillingContactIdName](#BKMK_BillingContactIdName)
- [BillingContactIdYomiName](#BKMK_BillingContactIdYomiName)
- [BillingCustomerIdName](#BKMK_BillingCustomerIdName)
- [BillingCustomerIdYomiName](#BKMK_BillingCustomerIdYomiName)
- [BillToAddressName](#BKMK_BillToAddressName)
- [CancelOn](#BKMK_CancelOn)
- [ContactId](#BKMK_ContactId)
- [ContactIdName](#BKMK_ContactIdName)
- [ContactIdYomiName](#BKMK_ContactIdYomiName)
- [ContractTemplateAbbreviation](#BKMK_ContractTemplateAbbreviation)
- [ContractTemplateIdName](#BKMK_ContractTemplateIdName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [Duration](#BKMK_Duration)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [NetPrice](#BKMK_NetPrice)
- [NetPrice_Base](#BKMK_NetPrice_Base)
- [OriginatingContractName](#BKMK_OriginatingContractName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ServiceAddressName](#BKMK_ServiceAddressName)
- [TotalDiscount](#BKMK_TotalDiscount)
- [TotalDiscount_Base](#BKMK_TotalDiscount_Base)
- [TotalPrice](#BKMK_TotalPrice)
- [TotalPrice_Base](#BKMK_TotalPrice_Base)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the account with which the contract is associated.|
|DisplayName|Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_AccountIdName"></a> AccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillingAccountId"></a> BillingAccountId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the account to which the contract is to be billed.|
|DisplayName|Billing Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billingaccountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_BillingAccountIdName"></a> BillingAccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billingaccountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillingAccountIdYomiName"></a> BillingAccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billingaccountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillingContactId"></a> BillingContactId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the contact to whom the contract is to be billed.|
|DisplayName|Billing Contact|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billingcontactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_BillingContactIdName"></a> BillingContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billingcontactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillingContactIdYomiName"></a> BillingContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billingcontactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillingCustomerIdName"></a> BillingCustomerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billingcustomeridname|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_BillingCustomerIdYomiName"></a> BillingCustomerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billingcustomeridyominame|
|MaxLength|450|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_BillToAddressName"></a> BillToAddressName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billtoaddressname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CancelOn"></a> CancelOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the contract was canceled.|
|DisplayName|Cancellation Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cancelon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the contact specified for the contract.|
|DisplayName|Contact|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ContactIdName"></a> ContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactIdYomiName"></a> ContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContractTemplateAbbreviation"></a> ContractTemplateAbbreviation

|Property|Value|
|--------|-----|
|Description|Shows the abbreviation of the contract template selected when the contract is created.|
|DisplayName|Template Abbreviation|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|contracttemplateabbreviation|
|MaxLength|20|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ContractTemplateIdName"></a> ContractTemplateIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contracttemplateidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridname|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridyominame|
|MaxLength|450|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|--------|-----|
|Description|Shows for the duration of the contract, in days, based on the contract start and end dates.|
|DisplayName|Duration|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


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


### <a name="BKMK_NetPrice"></a> NetPrice

|Property|Value|
|--------|-----|
|Description|Shows the total charge to the customer for the service contract, calculated as the sum of values in the Net field for each existing contract line related to the contract.|
|DisplayName|Net Price|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|netprice|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_NetPrice_Base"></a> NetPrice_Base

|Property|Value|
|--------|-----|
|Description|Value of the Net Price in base currency.|
|DisplayName|Net Price (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|netprice_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_OriginatingContractName"></a> OriginatingContractName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingcontractname|
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


### <a name="BKMK_ServiceAddressName"></a> ServiceAddressName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|serviceaddressname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TotalDiscount"></a> TotalDiscount

|Property|Value|
|--------|-----|
|Description|Shows the total discount applied to the contract's service charges, calculated as the sum of values in the Discount fields for each existing contract line related to the contract.|
|DisplayName|Total Discount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaldiscount|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalDiscount_Base"></a> TotalDiscount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Discount in base currency.|
|DisplayName|Total Discount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaldiscount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalPrice"></a> TotalPrice

|Property|Value|
|--------|-----|
|Description|Shows the total service charge for the contract, before any discounts are credited. This is calculated as the sum of values in the Total Price field for each existing contract line related to the contract.|
|DisplayName|Total Price|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalprice|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalPrice_Base"></a> TotalPrice_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Price in base currency.|
|DisplayName|Total Price (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalprice_base|
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

- [Contract_ActivityPointers](#BKMK_Contract_ActivityPointers)
- [Contract_SyncErrors](#BKMK_Contract_SyncErrors)
- [contract_activity_parties](#BKMK_contract_activity_parties)
- [Contract_DuplicateMatchingRecord](#BKMK_Contract_DuplicateMatchingRecord)
- [Contract_DuplicateBaseRecord](#BKMK_Contract_DuplicateBaseRecord)
- [Contract_AsyncOperations](#BKMK_Contract_AsyncOperations)
- [Contract_MailboxTrackingFolder](#BKMK_Contract_MailboxTrackingFolder)
- [Contract_ProcessSessions](#BKMK_Contract_ProcessSessions)
- [Contract_BulkDeleteFailures](#BKMK_Contract_BulkDeleteFailures)
- [contract_principalobjectattributeaccess](#BKMK_contract_principalobjectattributeaccess)
- [Contract_Appointments](#BKMK_Contract_Appointments)
- [Contract_Emails](#BKMK_Contract_Emails)
- [Contract_Faxes](#BKMK_Contract_Faxes)
- [Contract_Letters](#BKMK_Contract_Letters)
- [Contract_Phonecalls](#BKMK_Contract_Phonecalls)
- [Contract_Tasks](#BKMK_Contract_Tasks)
- [Contract_RecurringAppointmentMasters](#BKMK_Contract_RecurringAppointmentMasters)
- [Contract_SocialActivities](#BKMK_Contract_SocialActivities)
- [contract_connections1](#BKMK_contract_connections1)
- [contract_connections2](#BKMK_contract_connections2)
- [Contract_Annotation](#BKMK_Contract_Annotation)
- [Contract_ServiceAppointments](#BKMK_Contract_ServiceAppointments)
- [contract_cases](#BKMK_contract_cases)
- [contract_line_items](#BKMK_contract_line_items)
- [contract_originating_contract](#BKMK_contract_originating_contract)
- [contract_msdyn_bookingalerts](#BKMK_contract_msdyn_bookingalerts)
- [contract_msdyn_approvals](#BKMK_contract_msdyn_approvals)


### <a name="BKMK_Contract_ActivityPointers"></a> Contract_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [Contract_ActivityPointers](activitypointer.md#BKMK_Contract_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Contract_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Contract_SyncErrors"></a> Contract_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [Contract_SyncErrors](syncerror.md#BKMK_Contract_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_contract_activity_parties"></a> contract_activity_parties

**Added by**: System Solution Solution

Same as activityparty entity [contract_activity_parties](activityparty.md#BKMK_contract_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|partyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|contract_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Contract_DuplicateMatchingRecord"></a> Contract_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [Contract_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Contract_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Contract_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Contract_DuplicateBaseRecord"></a> Contract_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [Contract_DuplicateBaseRecord](duplicaterecord.md#BKMK_Contract_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Contract_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Contract_AsyncOperations"></a> Contract_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [Contract_AsyncOperations](asyncoperation.md#BKMK_Contract_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Contract_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Contract_MailboxTrackingFolder"></a> Contract_MailboxTrackingFolder

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [Contract_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Contract_MailboxTrackingFolder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_MailboxTrackingFolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Contract_ProcessSessions"></a> Contract_ProcessSessions

**Added by**: System Solution Solution

Same as processsession entity [Contract_ProcessSessions](processsession.md#BKMK_Contract_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Contract_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Contract_BulkDeleteFailures"></a> Contract_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [Contract_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Contract_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Contract_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_contract_principalobjectattributeaccess"></a> contract_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [contract_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_contract_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|contract_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Contract_Appointments"></a> Contract_Appointments

**Added by**: System Solution Solution

Same as appointment entity [Contract_Appointments](appointment.md#BKMK_Contract_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Contract_Emails"></a> Contract_Emails

**Added by**: System Solution Solution

Same as email entity [Contract_Emails](email.md#BKMK_Contract_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Contract_Faxes"></a> Contract_Faxes

**Added by**: System Solution Solution

Same as fax entity [Contract_Faxes](fax.md#BKMK_Contract_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Contract_Letters"></a> Contract_Letters

**Added by**: System Solution Solution

Same as letter entity [Contract_Letters](letter.md#BKMK_Contract_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Contract_Phonecalls"></a> Contract_Phonecalls

**Added by**: System Solution Solution

Same as phonecall entity [Contract_Phonecalls](phonecall.md#BKMK_Contract_Phonecalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_Phonecalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Contract_Tasks"></a> Contract_Tasks

**Added by**: System Solution Solution

Same as task entity [Contract_Tasks](task.md#BKMK_Contract_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Contract_RecurringAppointmentMasters"></a> Contract_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [Contract_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Contract_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Contract_SocialActivities"></a> Contract_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [Contract_SocialActivities](socialactivity.md#BKMK_Contract_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_contract_connections1"></a> contract_connections1

**Added by**: System Solution Solution

Same as connection entity [contract_connections1](connection.md#BKMK_contract_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contract_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_contract_connections2"></a> contract_connections2

**Added by**: System Solution Solution

Same as connection entity [contract_connections2](connection.md#BKMK_contract_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contract_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Contract_Annotation"></a> Contract_Annotation

**Added by**: System Solution Solution

Same as annotation entity [Contract_Annotation](annotation.md#BKMK_Contract_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Contract_ServiceAppointments"></a> Contract_ServiceAppointments

Same as serviceappointment entity [Contract_ServiceAppointments](serviceappointment.md#BKMK_Contract_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Contract_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_contract_cases"></a> contract_cases

Same as incident entity [contract_cases](incident.md#BKMK_contract_cases) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|contractid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contract_cases|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_contract_line_items"></a> contract_line_items

Same as contractdetail entity [contract_line_items](contractdetail.md#BKMK_contract_line_items) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contractdetail|
|ReferencingAttribute|contractid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contract_line_items|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_contract_originating_contract"></a> contract_originating_contract

Same as contract entity [contract_originating_contract](contract.md#BKMK_contract_originating_contract) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contract|
|ReferencingAttribute|originatingcontract|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contract_originating_contract|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_contract_msdyn_bookingalerts"></a> contract_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [contract_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_contract_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contract_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_contract_msdyn_approvals"></a> contract_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [contract_msdyn_approvals](msdyn_approval.md#BKMK_contract_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contract_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_contractbase_createdby](#BKMK_lk_contractbase_createdby)
- [lk_contract_createdonbehalfby](#BKMK_lk_contract_createdonbehalfby)
- [lk_contractbase_modifiedby](#BKMK_lk_contractbase_modifiedby)
- [lk_contract_modifiedonbehalfby](#BKMK_lk_contract_modifiedonbehalfby)
- [system_user_service_contracts](#BKMK_system_user_service_contracts)
- [team_service_contracts](#BKMK_team_service_contracts)
- [business_unit_service_contracts](#BKMK_business_unit_service_contracts)
- [transactioncurrency_contract](#BKMK_transactioncurrency_contract)
- [contract_billingcustomer_accounts](#BKMK_contract_billingcustomer_accounts)
- [contract_customer_accounts](#BKMK_contract_customer_accounts)
- [contract_billingcustomer_contacts](#BKMK_contract_billingcustomer_contacts)
- [contract_customer_contacts](#BKMK_contract_customer_contacts)
- [contract_originating_contract](#BKMK_contract_originating_contract)
- [contract_template_contracts](#BKMK_contract_template_contracts)
- [customer_address_contracts_as_billing_address](#BKMK_customer_address_contracts_as_billing_address)
- [customer_address_contracts_as_service_address](#BKMK_customer_address_contracts_as_service_address)


### <a name="BKMK_lk_contractbase_createdby"></a> lk_contractbase_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_contractbase_createdby](systemuser.md#BKMK_lk_contractbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_contract_createdonbehalfby"></a> lk_contract_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_contract_createdonbehalfby](systemuser.md#BKMK_lk_contract_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_contractbase_modifiedby"></a> lk_contractbase_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_contractbase_modifiedby](systemuser.md#BKMK_lk_contractbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_contract_modifiedonbehalfby"></a> lk_contract_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_contract_modifiedonbehalfby](systemuser.md#BKMK_lk_contract_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_system_user_service_contracts"></a> system_user_service_contracts

**Added by**: System Solution Solution

See systemuser Entity [system_user_service_contracts](systemuser.md#BKMK_system_user_service_contracts) One-To-Many relationship.

### <a name="BKMK_team_service_contracts"></a> team_service_contracts

**Added by**: System Solution Solution

See team Entity [team_service_contracts](team.md#BKMK_team_service_contracts) One-To-Many relationship.

### <a name="BKMK_business_unit_service_contracts"></a> business_unit_service_contracts

**Added by**: System Solution Solution

See businessunit Entity [business_unit_service_contracts](businessunit.md#BKMK_business_unit_service_contracts) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_contract"></a> transactioncurrency_contract

**Added by**: System Solution Solution

See transactioncurrency Entity [transactioncurrency_contract](transactioncurrency.md#BKMK_transactioncurrency_contract) One-To-Many relationship.

### <a name="BKMK_contract_billingcustomer_accounts"></a> contract_billingcustomer_accounts

**Added by**: System Solution Solution

See account Entity [contract_billingcustomer_accounts](account.md#BKMK_contract_billingcustomer_accounts) One-To-Many relationship.

### <a name="BKMK_contract_customer_accounts"></a> contract_customer_accounts

**Added by**: System Solution Solution

See account Entity [contract_customer_accounts](account.md#BKMK_contract_customer_accounts) One-To-Many relationship.

### <a name="BKMK_contract_billingcustomer_contacts"></a> contract_billingcustomer_contacts

**Added by**: System Solution Solution

See contact Entity [contract_billingcustomer_contacts](contact.md#BKMK_contract_billingcustomer_contacts) One-To-Many relationship.

### <a name="BKMK_contract_customer_contacts"></a> contract_customer_contacts

**Added by**: System Solution Solution

See contact Entity [contract_customer_contacts](contact.md#BKMK_contract_customer_contacts) One-To-Many relationship.

### <a name="BKMK_contract_originating_contract"></a> contract_originating_contract

See contract Entity [contract_originating_contract](contract.md#BKMK_contract_originating_contract) One-To-Many relationship.

### <a name="BKMK_contract_template_contracts"></a> contract_template_contracts

See contracttemplate Entity [contract_template_contracts](contracttemplate.md#BKMK_contract_template_contracts) One-To-Many relationship.

### <a name="BKMK_customer_address_contracts_as_billing_address"></a> customer_address_contracts_as_billing_address

**Added by**: System Solution Solution

See customeraddress Entity [customer_address_contracts_as_billing_address](customeraddress.md#BKMK_customer_address_contracts_as_billing_address) One-To-Many relationship.

### <a name="BKMK_customer_address_contracts_as_service_address"></a> customer_address_contracts_as_service_address

**Added by**: System Solution Solution

See customeraddress Entity [customer_address_contracts_as_service_address](customeraddress.md#BKMK_customer_address_contracts_as_service_address) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Contract entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_servicecontractcontacts_association"></a> servicecontractcontacts_association

See contact Entity [servicecontractcontacts_association](contact.md#BKMK_servicecontractcontacts_association) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.contract?text=contract EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]