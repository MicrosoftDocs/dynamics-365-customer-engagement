---
title: "Contract Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Contract entity."
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
# Contract Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Agreement to provide customer service during a specified amount of time or number of cases.

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CancelContract|<xref href="Microsoft.Dynamics.CRM.CancelContract?text=CancelContract Action" />|<xref:Microsoft.Crm.Sdk.Messages.CancelContractRequest>|
|CancelSalesOrder|<xref href="Microsoft.Dynamics.CRM.CancelSalesOrder?text=CancelSalesOrder Action" />|<xref:Microsoft.Crm.Sdk.Messages.CancelSalesOrderRequest>|
|CloneContract|<xref href="Microsoft.Dynamics.CRM.CloneContract?text=CloneContract Action" />|<xref:Microsoft.Crm.Sdk.Messages.CloneContractRequest>|
|Create|POST [*org URI*]/api/data/v9.0/contracts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|RenewContract|<xref href="Microsoft.Dynamics.CRM.RenewContract?text=RenewContract Action" />|<xref:Microsoft.Crm.Sdk.Messages.RenewContractRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/contracts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref href="Microsoft.Dynamics.CRM.Rollup?text=Rollup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/contracts(*contractid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Contract<br />
**DisplayCollectionName**: Contracts<br />
**SchemaName**: Contract<br />
**CollectionSchemaName**: Contracts<br />
**LogicalName**: contract<br />
**LogicalCollectionName**: contracts<br />
**EntitySetName**: contracts<br />
**PrimaryIdAttribute**: contractid<br />
**PrimaryNameAttribute**: title<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Enter the date when the contract becomes active.<br />
**DisplayName**: Contract Start Date<br />
**LogicalName**: activeon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_AllotmentTypeCode"></a> AllotmentTypeCode

**Description**: Type of allotment that the contract supports.<br />
**DisplayName**: Allotment Type<br />
**LogicalName**: allotmenttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Number of Cases
- **Value**: 2 **Label**: Time
- **Value**: 3 **Label**: Coverage Dates



### <a name="BKMK_BillingCustomerId"></a> BillingCustomerId

**Description**: Select the customer account or contact to which the contract should be billed to provide a quick link to address and other customer details.<br />
**DisplayName**: Bill To Customer<br />
**LogicalName**: billingcustomerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Customer<br />
**Targets**: account,contact


### <a name="BKMK_BillingCustomerIdType"></a> BillingCustomerIdType

**Description**: <br />
**DisplayName**: Bill To Customer Type<br />
**LogicalName**: billingcustomeridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_BillingEndOn"></a> BillingEndOn

**Description**: Enter the end date for the contract's billing period to indicate the period for which the customer must pay for a service.<br />
**DisplayName**: Billing End Date<br />
**LogicalName**: billingendon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_BillingFrequencyCode"></a> BillingFrequencyCode

**Description**: Select the billing schedule of the contract to indicate how often the customer should be invoiced.<br />
**DisplayName**: Billing Frequency<br />
**LogicalName**: billingfrequencycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Monthly
- **Value**: 2 **Label**: Bimonthly
- **Value**: 3 **Label**: Quarterly
- **Value**: 4 **Label**: Semiannually
- **Value**: 5 **Label**: Annually



### <a name="BKMK_BillingStartOn"></a> BillingStartOn

**Description**: Enter the start date for the contract's billing period to indicate the period for which the customer must pay for a service. This defaults to the same date that is selected in the Contract Start Date field.<br />
**DisplayName**: Billing Start Date<br />
**LogicalName**: billingstarton<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_BillToAddress"></a> BillToAddress

**Description**: Choose which address to send the invoice to.<br />
**DisplayName**: Bill To Address<br />
**LogicalName**: billtoaddress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: customeraddress


### <a name="BKMK_ContractId"></a> ContractId

**Description**: Unique identifier of the contract.<br />
**DisplayName**: Contract<br />
**LogicalName**: contractid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ContractLanguage"></a> ContractLanguage

**Description**: Type additional information about the contract, such as the products or services provided to the customer.<br />
**DisplayName**: Description<br />
**LogicalName**: contractlanguage<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_ContractNumber"></a> ContractNumber

**Description**: Shows the number for the contract for customer reference and searching capabilities. You cannot modify this number.<br />
**DisplayName**: Contract ID<br />
**LogicalName**: contractnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ContractServiceLevelCode"></a> ContractServiceLevelCode

**Description**: Select the level of service that should be provided for the contract based on your company's definition of bronze, silver, or gold.<br />
**DisplayName**: Service Level<br />
**LogicalName**: contractservicelevelcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Gold
- **Value**: 2 **Label**: Silver
- **Value**: 3 **Label**: Bronze



### <a name="BKMK_ContractTemplateId"></a> ContractTemplateId

**Description**: Choose the contract template that should be used to determine the terms of the contract, such as allotment type, available hours, and billing frequency.<br />
**DisplayName**: Contract Template<br />
**LogicalName**: contracttemplateid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: contracttemplate


### <a name="BKMK_CustomerId"></a> CustomerId

**Description**: Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.<br />
**DisplayName**: Customer<br />
**LogicalName**: customerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Customer<br />
**Targets**: account,contact


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Description**: <br />
**DisplayName**: Customer Type<br />
**LogicalName**: customeridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_EffectivityCalendar"></a> EffectivityCalendar

**Description**: Days of the week and times during which customer service support is available for the duration of the contract.<br />
**DisplayName**: Support Calendar<br />
**LogicalName**: effectivitycalendar<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 168


### <a name="BKMK_EmailAddress"></a> EmailAddress

**Description**: The primary email address for the entity.<br />
**DisplayName**: Email Address<br />
**LogicalName**: emailaddress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_ExpiresOn"></a> ExpiresOn

**Description**: Enter the date when the contract expires.<br />
**DisplayName**: Contract End Date<br />
**LogicalName**: expireson<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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


### <a name="BKMK_OriginatingContract"></a> OriginatingContract

**Description**: Choose the original contract that this contract was created from. This information is used to track renewal history.<br />
**DisplayName**: Originating Contract<br />
**LogicalName**: originatingcontract<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: contract


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


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_ServiceAddress"></a> ServiceAddress

**Description**: Choose the address for the customer account or contact where the services are provided.<br />
**DisplayName**: Contract Address<br />
**LogicalName**: serviceaddress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: customeraddress


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the contract is in draft, invoiced, active, on hold, canceled, or expired. You can edit only the contracts that are in draft status.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Draft **DefaultStatus**: 1 **InvariantName**: Draft
- **Value**: 1 **Label**: Invoiced **DefaultStatus**: 2 **InvariantName**: Invoiced
- **Value**: 2 **Label**: Active **DefaultStatus**: 3 **InvariantName**: Active
- **Value**: 3 **Label**: On Hold **DefaultStatus**: 4 **InvariantName**: On Hold
- **Value**: 4 **Label**: Canceled **DefaultStatus**: 5 **InvariantName**: Canceled
- **Value**: 5 **Label**: Expired **DefaultStatus**: 6 **InvariantName**: Expired



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the contract's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Draft **State**: 0
- **Value**: 2 **Label**: Invoiced **State**: 1
- **Value**: 3 **Label**: Active **State**: 2
- **Value**: 4 **Label**: On Hold **State**: 3
- **Value**: 5 **Label**: Canceled **State**: 4
- **Value**: 6 **Label**: Expired **State**: 5



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
**MinValue**: -2147483648


### <a name="BKMK_Title"></a> Title

**Description**: Type a title or name for the contract that indicates the purpose of the contract.<br />
**DisplayName**: Contract Name<br />
**LogicalName**: title<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_UseDiscountAsPercentage"></a> UseDiscountAsPercentage

**Description**: Select whether the discounts entered on contract lines for this contract should be entered as a percentage or a fixed dollar value.<br />
**DisplayName**: Discount<br />
**LogicalName**: usediscountaspercentage<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Percentage
- **FalseOption Value**: 0 **Label**: Amount

**DefaultValue**: False


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
**MinValue**: -2147483648

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

**Description**: Unique identifier of the account with which the contract is associated.<br />
**DisplayName**: Account<br />
**LogicalName**: accountid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_AccountIdName"></a> AccountIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: accountidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: accountidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_BillingAccountId"></a> BillingAccountId

**Description**: Unique identifier of the account to which the contract is to be billed.<br />
**DisplayName**: Billing Account<br />
**LogicalName**: billingaccountid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_BillingAccountIdName"></a> BillingAccountIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: billingaccountidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_BillingAccountIdYomiName"></a> BillingAccountIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: billingaccountidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_BillingContactId"></a> BillingContactId

**Description**: Unique identifier of the contact to whom the contract is to be billed.<br />
**DisplayName**: Billing Contact<br />
**LogicalName**: billingcontactid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_BillingContactIdName"></a> BillingContactIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: billingcontactidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_BillingContactIdYomiName"></a> BillingContactIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: billingcontactidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_BillingCustomerIdName"></a> BillingCustomerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: billingcustomeridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_BillingCustomerIdYomiName"></a> BillingCustomerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: billingcustomeridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_BillToAddressName"></a> BillToAddressName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: billtoaddressname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CancelOn"></a> CancelOn

**Description**: Shows the date and time when the contract was canceled.<br />
**DisplayName**: Cancellation Date<br />
**LogicalName**: cancelon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ContactId"></a> ContactId

**Description**: Unique identifier of the contact specified for the contract.<br />
**DisplayName**: Contact<br />
**LogicalName**: contactid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_ContactIdName"></a> ContactIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: contactidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ContactIdYomiName"></a> ContactIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: contactidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ContractTemplateAbbreviation"></a> ContractTemplateAbbreviation

**Description**: Shows the abbreviation of the contract template selected when the contract is created.<br />
**DisplayName**: Template Abbreviation<br />
**LogicalName**: contracttemplateabbreviation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_ContractTemplateIdName"></a> ContractTemplateIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: contracttemplateidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
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

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
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


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: customeridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: customeridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_Duration"></a> Duration

**Description**: Shows for the duration of the contract, in days, based on the contract start and end dates.<br />
**DisplayName**: Duration<br />
**LogicalName**: duration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


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

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


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

**Description**: Shows who last updated the record.<br />
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

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
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


### <a name="BKMK_NetPrice"></a> NetPrice

**Description**: Shows the total charge to the customer for the service contract, calculated as the sum of values in the Net field for each existing contract line related to the contract.<br />
**DisplayName**: Net Price<br />
**LogicalName**: netprice<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_NetPrice_Base"></a> NetPrice_Base

**Description**: Value of the Net Price in base currency.<br />
**DisplayName**: Net Price (Base)<br />
**LogicalName**: netprice_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_OriginatingContractName"></a> OriginatingContractName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: originatingcontractname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ServiceAddressName"></a> ServiceAddressName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: serviceaddressname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TotalDiscount"></a> TotalDiscount

**Description**: Shows the total discount applied to the contract's service charges, calculated as the sum of values in the Discount fields for each existing contract line related to the contract.<br />
**DisplayName**: Total Discount<br />
**LogicalName**: totaldiscount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_TotalDiscount_Base"></a> TotalDiscount_Base

**Description**: Value of the Total Discount in base currency.<br />
**DisplayName**: Total Discount (Base)<br />
**LogicalName**: totaldiscount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_TotalPrice"></a> TotalPrice

**Description**: Shows the total service charge for the contract, before any discounts are credited. This is calculated as the sum of values in the Total Price field for each existing contract line related to the contract.<br />
**DisplayName**: Total Price<br />
**LogicalName**: totalprice<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_TotalPrice_Base"></a> TotalPrice_Base

**Description**: Value of the Total Price in base currency.<br />
**DisplayName**: Total Price (Base)<br />
**LogicalName**: totalprice_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


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

- [Contract_ActivityPointers](#BKMK_Contract_ActivityPointers)
- [Contract_SyncErrors](#BKMK_Contract_SyncErrors)
- [contract_activity_parties](#BKMK_contract_activity_parties)
- [Contract_DuplicateMatchingRecord](#BKMK_Contract_DuplicateMatchingRecord)
- [Contract_DuplicateBaseRecord](#BKMK_Contract_DuplicateBaseRecord)
- [Contract_AsyncOperations](#BKMK_Contract_AsyncOperations)
- [Contract_MailboxTrackingFolder](#BKMK_Contract_MailboxTrackingFolder)
- [userentityinstancedata_contract](#BKMK_userentityinstancedata_contract)
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

Same as activitypointer entity [Contract_ActivityPointers](activitypointer.md#BKMK_Contract_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contract_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Contract_SyncErrors"></a> Contract_SyncErrors

Same as syncerror entity [Contract_SyncErrors](syncerror.md#BKMK_Contract_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_SyncErrors<br />
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


### <a name="BKMK_contract_activity_parties"></a> contract_activity_parties

Same as activityparty entity [contract_activity_parties](activityparty.md#BKMK_contract_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: partyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contract_activity_parties<br />
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


### <a name="BKMK_Contract_DuplicateMatchingRecord"></a> Contract_DuplicateMatchingRecord

Same as duplicaterecord entity [Contract_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Contract_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contract_DuplicateMatchingRecord<br />
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


### <a name="BKMK_Contract_DuplicateBaseRecord"></a> Contract_DuplicateBaseRecord

Same as duplicaterecord entity [Contract_DuplicateBaseRecord](duplicaterecord.md#BKMK_Contract_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contract_DuplicateBaseRecord<br />
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


### <a name="BKMK_Contract_AsyncOperations"></a> Contract_AsyncOperations

Same as asyncoperation entity [Contract_AsyncOperations](asyncoperation.md#BKMK_Contract_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contract_AsyncOperations<br />
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


### <a name="BKMK_Contract_MailboxTrackingFolder"></a> Contract_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [Contract_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Contract_MailboxTrackingFolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_MailboxTrackingFolder<br />
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


### <a name="BKMK_userentityinstancedata_contract"></a> userentityinstancedata_contract

Same as userentityinstancedata entity [userentityinstancedata_contract](userentityinstancedata.md#BKMK_userentityinstancedata_contract) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_contract<br />
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


### <a name="BKMK_Contract_ProcessSessions"></a> Contract_ProcessSessions

Same as processsession entity [Contract_ProcessSessions](processsession.md#BKMK_Contract_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contract_ProcessSessions<br />
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


### <a name="BKMK_Contract_BulkDeleteFailures"></a> Contract_BulkDeleteFailures

Same as bulkdeletefailure entity [Contract_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Contract_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contract_BulkDeleteFailures<br />
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


### <a name="BKMK_contract_principalobjectattributeaccess"></a> contract_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [contract_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_contract_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contract_principalobjectattributeaccess<br />
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


### <a name="BKMK_Contract_Appointments"></a> Contract_Appointments

Same as appointment entity [Contract_Appointments](appointment.md#BKMK_Contract_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_Appointments<br />
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


### <a name="BKMK_Contract_Emails"></a> Contract_Emails

Same as email entity [Contract_Emails](email.md#BKMK_Contract_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_Emails<br />
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


### <a name="BKMK_Contract_Faxes"></a> Contract_Faxes

Same as fax entity [Contract_Faxes](fax.md#BKMK_Contract_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_Faxes<br />
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


### <a name="BKMK_Contract_Letters"></a> Contract_Letters

Same as letter entity [Contract_Letters](letter.md#BKMK_Contract_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_Letters<br />
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


### <a name="BKMK_Contract_Phonecalls"></a> Contract_Phonecalls

Same as phonecall entity [Contract_Phonecalls](phonecall.md#BKMK_Contract_Phonecalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_Phonecalls<br />
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


### <a name="BKMK_Contract_Tasks"></a> Contract_Tasks

Same as task entity [Contract_Tasks](task.md#BKMK_Contract_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_Tasks<br />
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


### <a name="BKMK_Contract_RecurringAppointmentMasters"></a> Contract_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [Contract_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Contract_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_RecurringAppointmentMasters<br />
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


### <a name="BKMK_Contract_SocialActivities"></a> Contract_SocialActivities

Same as socialactivity entity [Contract_SocialActivities](socialactivity.md#BKMK_Contract_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_SocialActivities<br />
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


### <a name="BKMK_contract_connections1"></a> contract_connections1

Same as connection entity [contract_connections1](connection.md#BKMK_contract_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_contract_connections2"></a> contract_connections2

Same as connection entity [contract_connections2](connection.md#BKMK_contract_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Contract_Annotation"></a> Contract_Annotation

Same as annotation entity [Contract_Annotation](annotation.md#BKMK_Contract_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_Annotation<br />
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


### <a name="BKMK_Contract_ServiceAppointments"></a> Contract_ServiceAppointments

Same as serviceappointment entity [Contract_ServiceAppointments](serviceappointment.md#BKMK_Contract_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contract_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_contract_cases"></a> contract_cases

Same as incident entity [contract_cases](incident.md#BKMK_contract_cases) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: contractid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_cases<br />
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


### <a name="BKMK_contract_line_items"></a> contract_line_items

Same as contractdetail entity [contract_line_items](contractdetail.md#BKMK_contract_line_items) Many-To-One relationship.

**ReferencingEntity**: contractdetail<br />
**ReferencingAttribute**: contractid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_line_items<br />
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


### <a name="BKMK_contract_originating_contract"></a> contract_originating_contract

Same as contract entity [contract_originating_contract](contract.md#BKMK_contract_originating_contract) Many-To-One relationship.

**ReferencingEntity**: contract<br />
**ReferencingAttribute**: originatingcontract<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_originating_contract<br />
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


### <a name="BKMK_contract_msdyn_bookingalerts"></a> contract_msdyn_bookingalerts

Same as msdyn_bookingalert entity [contract_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_contract_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_msdyn_bookingalerts<br />
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


### <a name="BKMK_contract_msdyn_approvals"></a> contract_msdyn_approvals

Same as msdyn_approval entity [contract_msdyn_approvals](msdyn_approval.md#BKMK_contract_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_msdyn_approvals<br />
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

See systemuser Entity [lk_contractbase_createdby](systemuser.md#BKMK_lk_contractbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_contract_createdonbehalfby"></a> lk_contract_createdonbehalfby

See systemuser Entity [lk_contract_createdonbehalfby](systemuser.md#BKMK_lk_contract_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_contractbase_modifiedby"></a> lk_contractbase_modifiedby

See systemuser Entity [lk_contractbase_modifiedby](systemuser.md#BKMK_lk_contractbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_contract_modifiedonbehalfby"></a> lk_contract_modifiedonbehalfby

See systemuser Entity [lk_contract_modifiedonbehalfby](systemuser.md#BKMK_lk_contract_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_system_user_service_contracts"></a> system_user_service_contracts

See systemuser Entity [system_user_service_contracts](systemuser.md#BKMK_system_user_service_contracts) One-To-Many relationship.

### <a name="BKMK_team_service_contracts"></a> team_service_contracts

See team Entity [team_service_contracts](team.md#BKMK_team_service_contracts) One-To-Many relationship.

### <a name="BKMK_business_unit_service_contracts"></a> business_unit_service_contracts

See businessunit Entity [business_unit_service_contracts](businessunit.md#BKMK_business_unit_service_contracts) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_contract"></a> transactioncurrency_contract

See transactioncurrency Entity [transactioncurrency_contract](transactioncurrency.md#BKMK_transactioncurrency_contract) One-To-Many relationship.

### <a name="BKMK_contract_billingcustomer_accounts"></a> contract_billingcustomer_accounts

See account Entity [contract_billingcustomer_accounts](account.md#BKMK_contract_billingcustomer_accounts) One-To-Many relationship.

### <a name="BKMK_contract_customer_accounts"></a> contract_customer_accounts

See account Entity [contract_customer_accounts](account.md#BKMK_contract_customer_accounts) One-To-Many relationship.

### <a name="BKMK_contract_billingcustomer_contacts"></a> contract_billingcustomer_contacts

See contact Entity [contract_billingcustomer_contacts](contact.md#BKMK_contract_billingcustomer_contacts) One-To-Many relationship.

### <a name="BKMK_contract_customer_contacts"></a> contract_customer_contacts

See contact Entity [contract_customer_contacts](contact.md#BKMK_contract_customer_contacts) One-To-Many relationship.

### <a name="BKMK_contract_originating_contract"></a> contract_originating_contract

See contract Entity [contract_originating_contract](contract.md#BKMK_contract_originating_contract) One-To-Many relationship.

### <a name="BKMK_contract_template_contracts"></a> contract_template_contracts

See contracttemplate Entity [contract_template_contracts](contracttemplate.md#BKMK_contract_template_contracts) One-To-Many relationship.

### <a name="BKMK_customer_address_contracts_as_billing_address"></a> customer_address_contracts_as_billing_address

See customeraddress Entity [customer_address_contracts_as_billing_address](customeraddress.md#BKMK_customer_address_contracts_as_billing_address) One-To-Many relationship.

### <a name="BKMK_customer_address_contracts_as_service_address"></a> customer_address_contracts_as_service_address

See customeraddress Entity [customer_address_contracts_as_service_address](customeraddress.md#BKMK_customer_address_contracts_as_service_address) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Contract entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_servicecontractcontacts_association"></a> servicecontractcontacts_association

See contact Entity [servicecontractcontacts_association](contact.md#BKMK_servicecontractcontacts_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.contract?text=contract EntityType" />