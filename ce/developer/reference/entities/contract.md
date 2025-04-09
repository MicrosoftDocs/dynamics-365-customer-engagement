---
title: "Contract table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Contract table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Contract table/entity reference (Microsoft Dynamics 365)

Agreement to provide customer service during a specified amount of time or number of cases.

## Messages

The following table lists the messages for the Contract table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /contracts(*contractid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `CancelContract`<br />Event: True |**CancelContract action** |<xref:Microsoft.Crm.Sdk.Messages.CancelContractRequest>|
| `CancelSalesOrder`<br />Event: True |**CancelSalesOrder action** |<xref:Microsoft.Crm.Sdk.Messages.CancelSalesOrderRequest>|
| `CloneContract`<br />Event: True |**CloneContract action** |<xref:Microsoft.Crm.Sdk.Messages.CloneContractRequest>|
| `Create`<br />Event: True |`POST` /contracts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /contracts(*contractid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `RenewContract`<br />Event: False |**RenewContract action** |<xref:Microsoft.Crm.Sdk.Messages.RenewContractRequest>|
| `Retrieve`<br />Event: True |`GET` /contracts(*contractid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /contracts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `Rollup`<br />Event: False |<xref:Microsoft.Dynamics.CRM.Rollup?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
| `SetState`<br />Event: True |`PATCH` /contracts(*contractid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /contracts(*contractid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /contracts(*contractid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Contract table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Contract** |
| **DisplayCollectionName** | **Contracts** |
| **SchemaName** | `Contract` |
| **CollectionSchemaName** | `Contracts` |
| **EntitySetName** | `contracts`|
| **LogicalName** | `contract` |
| **LogicalCollectionName** | `contracts` |
| **PrimaryIdAttribute** | `contractid` |
| **PrimaryNameAttribute** |`title` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|---|---|
|Description|**Enter the date when the contract becomes active.**|
|DisplayName|**Contract Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`activeon`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_AllotmentTypeCode"></a> AllotmentTypeCode

|Property|Value|
|---|---|
|Description|**Type of allotment that the contract supports.**|
|DisplayName|**Allotment Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`allotmenttypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`contract_allotmenttypecode`|

#### AllotmentTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Number of Cases**|
|2|**Time**|
|3|**Coverage Dates**|

### <a name="BKMK_BillingCustomerId"></a> BillingCustomerId

|Property|Value|
|---|---|
|Description|**Select the customer account or contact to which the contract should be billed to provide a quick link to address and other customer details.**|
|DisplayName|**Bill To Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billingcustomerid`|
|RequiredLevel|SystemRequired|
|Type|Customer|
|Targets|account, contact|

### <a name="BKMK_BillingCustomerIdType"></a> BillingCustomerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Bill To Customer Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`billingcustomeridtype`|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|

### <a name="BKMK_BillingEndOn"></a> BillingEndOn

|Property|Value|
|---|---|
|Description|**Enter the end date for the contract's billing period to indicate the period for which the customer must pay for a service.**|
|DisplayName|**Billing End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billingendon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_BillingFrequencyCode"></a> BillingFrequencyCode

|Property|Value|
|---|---|
|Description|**Select the billing schedule of the contract to indicate how often the customer should be invoiced.**|
|DisplayName|**Billing Frequency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billingfrequencycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`contract_billingfrequencycode`|

#### BillingFrequencyCode Choices/Options

|Value|Label|
|---|---|
|1|**Monthly**|
|2|**Bimonthly**|
|3|**Quarterly**|
|4|**Semiannually**|
|5|**Annually**|

### <a name="BKMK_BillingStartOn"></a> BillingStartOn

|Property|Value|
|---|---|
|Description|**Enter the start date for the contract's billing period to indicate the period for which the customer must pay for a service. This defaults to the same date that is selected in the Contract Start Date field.**|
|DisplayName|**Billing Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billingstarton`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_BillToAddress"></a> BillToAddress

|Property|Value|
|---|---|
|Description|**Choose which address to send the invoice to.**|
|DisplayName|**Bill To Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billtoaddress`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|customeraddress|

### <a name="BKMK_ContractId"></a> ContractId

|Property|Value|
|---|---|
|Description|**Unique identifier of the contract.**|
|DisplayName|**Contract**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contractid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ContractLanguage"></a> ContractLanguage

|Property|Value|
|---|---|
|Description|**Type additional information about the contract, such as the products or services provided to the customer.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contractlanguage`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_ContractNumber"></a> ContractNumber

|Property|Value|
|---|---|
|Description|**Shows the number for the contract for customer reference and searching capabilities. You cannot modify this number.**|
|DisplayName|**Contract ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contractnumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ContractServiceLevelCode"></a> ContractServiceLevelCode

|Property|Value|
|---|---|
|Description|**Select the level of service that should be provided for the contract based on your company's definition of bronze, silver, or gold.**|
|DisplayName|**Service Level**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contractservicelevelcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`contract_contractservicelevelcode`|

#### ContractServiceLevelCode Choices/Options

|Value|Label|
|---|---|
|1|**Gold**|
|2|**Silver**|
|3|**Bronze**|

### <a name="BKMK_ContractTemplateId"></a> ContractTemplateId

|Property|Value|
|---|---|
|Description|**Choose the contract template that should be used to determine the terms of the contract, such as allotment type, available hours, and billing frequency.**|
|DisplayName|**Contract Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contracttemplateid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|contracttemplate|

### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|---|---|
|Description|**Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.**|
|DisplayName|**Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customerid`|
|RequiredLevel|SystemRequired|
|Type|Customer|
|Targets|account, contact|

### <a name="BKMK_CustomerIdType"></a> CustomerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Customer Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridtype`|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|

### <a name="BKMK_EffectivityCalendar"></a> EffectivityCalendar

|Property|Value|
|---|---|
|Description|**Days of the week and times during which customer service support is available for the duration of the contract.**|
|DisplayName|**Support Calendar**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`effectivitycalendar`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|168|

### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|---|---|
|Description|**The primary email address for the entity.**|
|DisplayName|**Email Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description|**The default image for the entity.**|
|DisplayName|**Entity Image**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_ExpiresOn"></a> ExpiresOn

|Property|Value|
|---|---|
|Description|**Enter the date when the contract expires.**|
|DisplayName|**Contract End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`expireson`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

### <a name="BKMK_OriginatingContract"></a> OriginatingContract

|Property|Value|
|---|---|
|Description|**Choose the original contract that this contract was created from. This information is used to track renewal history.**|
|DisplayName|**Originating Contract**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`originatingcontract`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contract|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_ServiceAddress"></a> ServiceAddress

|Property|Value|
|---|---|
|Description|**Choose the address for the customer account or contact where the services are provided.**|
|DisplayName|**Contract Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`serviceaddress`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|customeraddress|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Shows whether the contract is in draft, invoiced, active, on hold, canceled, or expired. You can edit only the contracts that are in draft status.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`contract_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Draft**<br />DefaultStatus: 1<br />InvariantName: `Draft`|
|1|Label: **Invoiced**<br />DefaultStatus: 2<br />InvariantName: `Invoiced`|
|2|Label: **Active**<br />DefaultStatus: 3<br />InvariantName: `Active`|
|3|Label: **On Hold**<br />DefaultStatus: 4<br />InvariantName: `On Hold`|
|4|Label: **Canceled**<br />DefaultStatus: 5<br />InvariantName: `Canceled`|
|5|Label: **Expired**<br />DefaultStatus: 6<br />InvariantName: `Expired`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the contract's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`contract_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **Invoiced**<br />State:1<br />TransitionData: None|
|3|Label: **Active**<br />State:2<br />TransitionData: None|
|4|Label: **On Hold**<br />State:3<br />TransitionData: None|
|5|Label: **Canceled**<br />State:4<br />TransitionData: None|
|6|Label: **Expired**<br />State:5<br />TransitionData: None|

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

### <a name="BKMK_Title"></a> Title

|Property|Value|
|---|---|
|Description|**Type a title or name for the contract that indicates the purpose of the contract.**|
|DisplayName|**Contract Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`title`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_UseDiscountAsPercentage"></a> UseDiscountAsPercentage

|Property|Value|
|---|---|
|Description|**Select whether the discounts entered on contract lines for this contract should be entered as a percentage or a fixed dollar value.**|
|DisplayName|**Discount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`usediscountaspercentage`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`contract_usediscountaspercentage`|
|DefaultValue|False|
|True Label|Percentage|
|False Label|Amount|

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

- [AccountId](#BKMK_AccountId)
- [BillingAccountId](#BKMK_BillingAccountId)
- [BillingContactId](#BKMK_BillingContactId)
- [BillingCustomerIdName](#BKMK_BillingCustomerIdName)
- [BillingCustomerIdYomiName](#BKMK_BillingCustomerIdYomiName)
- [CancelOn](#BKMK_CancelOn)
- [ContactId](#BKMK_ContactId)
- [ContractTemplateAbbreviation](#BKMK_ContractTemplateAbbreviation)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [Duration](#BKMK_Duration)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [NetPrice](#BKMK_NetPrice)
- [NetPrice_Base](#BKMK_NetPrice_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TotalDiscount](#BKMK_TotalDiscount)
- [TotalDiscount_Base](#BKMK_TotalDiscount_Base)
- [TotalPrice](#BKMK_TotalPrice)
- [TotalPrice_Base](#BKMK_TotalPrice_Base)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|---|---|
|Description|**Unique identifier of the account with which the contract is associated.**|
|DisplayName|**Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_BillingAccountId"></a> BillingAccountId

|Property|Value|
|---|---|
|Description|**Unique identifier of the account to which the contract is to be billed.**|
|DisplayName|**Billing Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`billingaccountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_BillingContactId"></a> BillingContactId

|Property|Value|
|---|---|
|Description|**Unique identifier of the contact to whom the contract is to be billed.**|
|DisplayName|**Billing Contact**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`billingcontactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_BillingCustomerIdName"></a> BillingCustomerIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`billingcustomeridname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_BillingCustomerIdYomiName"></a> BillingCustomerIdYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`billingcustomeridyominame`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_CancelOn"></a> CancelOn

|Property|Value|
|---|---|
|Description|**Shows the date and time when the contract was canceled.**|
|DisplayName|**Cancellation Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`cancelon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|---|---|
|Description|**Unique identifier of the contact specified for the contract.**|
|DisplayName|**Contact**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_ContractTemplateAbbreviation"></a> ContractTemplateAbbreviation

|Property|Value|
|---|---|
|Description|**Shows the abbreviation of the contract template selected when the contract is created.**|
|DisplayName|**Template Abbreviation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contracttemplateabbreviation`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Shows who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
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

### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridyominame`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|---|---|
|Description|**Shows for the duration of the contract, in days, based on the contract start and end dates.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`duration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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
|Description|**Shows who last updated the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
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

### <a name="BKMK_NetPrice"></a> NetPrice

|Property|Value|
|---|---|
|Description|**Shows the total charge to the customer for the service contract, calculated as the sum of values in the Net field for each existing contract line related to the contract.**|
|DisplayName|**Net Price**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`netprice`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_NetPrice_Base"></a> NetPrice_Base

|Property|Value|
|---|---|
|Description|**Value of the Net Price in base currency.**|
|DisplayName|**Net Price (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`netprice_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_TotalDiscount"></a> TotalDiscount

|Property|Value|
|---|---|
|Description|**Shows the total discount applied to the contract's service charges, calculated as the sum of values in the Discount fields for each existing contract line related to the contract.**|
|DisplayName|**Total Discount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaldiscount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalDiscount_Base"></a> TotalDiscount_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Discount in base currency.**|
|DisplayName|**Total Discount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaldiscount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalPrice"></a> TotalPrice

|Property|Value|
|---|---|
|Description|**Shows the total service charge for the contract, before any discounts are credited. This is calculated as the sum of values in the Total Price field for each existing contract line related to the contract.**|
|DisplayName|**Total Price**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalprice`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalPrice_Base"></a> TotalPrice_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Price in base currency.**|
|DisplayName|**Total Price (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalprice_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

- [business_unit_service_contracts](#BKMK_business_unit_service_contracts)
- [contract_billingcustomer_accounts](#BKMK_contract_billingcustomer_accounts)
- [contract_billingcustomer_contacts](#BKMK_contract_billingcustomer_contacts)
- [contract_customer_accounts](#BKMK_contract_customer_accounts)
- [contract_customer_contacts](#BKMK_contract_customer_contacts)
- [contract_originating_contract](#BKMK_contract_originating_contract-many-to-one)
- [contract_template_contracts](#BKMK_contract_template_contracts)
- [customer_address_contracts_as_billing_address](#BKMK_customer_address_contracts_as_billing_address)
- [customer_address_contracts_as_service_address](#BKMK_customer_address_contracts_as_service_address)
- [lk_contract_createdonbehalfby](#BKMK_lk_contract_createdonbehalfby)
- [lk_contract_modifiedonbehalfby](#BKMK_lk_contract_modifiedonbehalfby)
- [lk_contractbase_createdby](#BKMK_lk_contractbase_createdby)
- [lk_contractbase_modifiedby](#BKMK_lk_contractbase_modifiedby)
- [owner_contracts](#BKMK_owner_contracts)
- [system_user_service_contracts](#BKMK_system_user_service_contracts)
- [team_service_contracts](#BKMK_team_service_contracts)
- [transactioncurrency_contract](#BKMK_transactioncurrency_contract)

### <a name="BKMK_business_unit_service_contracts"></a> business_unit_service_contracts

One-To-Many Relationship: [businessunit business_unit_service_contracts](businessunit.md#BKMK_business_unit_service_contracts)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_billingcustomer_accounts"></a> contract_billingcustomer_accounts

One-To-Many Relationship: [account contract_billingcustomer_accounts](account.md#BKMK_contract_billingcustomer_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`billingcustomerid`|
|ReferencingEntityNavigationPropertyName|`billingcustomerid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_billingcustomer_contacts"></a> contract_billingcustomer_contacts

One-To-Many Relationship: [contact contract_billingcustomer_contacts](contact.md#BKMK_contract_billingcustomer_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`billingcustomerid`|
|ReferencingEntityNavigationPropertyName|`billingcustomerid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_customer_accounts"></a> contract_customer_accounts

One-To-Many Relationship: [account contract_customer_accounts](account.md#BKMK_contract_customer_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contract_customer_contacts"></a> contract_customer_contacts

One-To-Many Relationship: [contact contract_customer_contacts](contact.md#BKMK_contract_customer_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contract_originating_contract-many-to-one"></a> contract_originating_contract

One-To-Many Relationship: [contract contract_originating_contract](#BKMK_contract_originating_contract-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`originatingcontract`|
|ReferencingEntityNavigationPropertyName|`originatingcontract`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_template_contracts"></a> contract_template_contracts

One-To-Many Relationship: [contracttemplate contract_template_contracts](contracttemplate.md#BKMK_contract_template_contracts)

|Property|Value|
|---|---|
|ReferencedEntity|`contracttemplate`|
|ReferencedAttribute|`contracttemplateid`|
|ReferencingAttribute|`contracttemplateid`|
|ReferencingEntityNavigationPropertyName|`contracttemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_customer_address_contracts_as_billing_address"></a> customer_address_contracts_as_billing_address

One-To-Many Relationship: [customeraddress customer_address_contracts_as_billing_address](customeraddress.md#BKMK_customer_address_contracts_as_billing_address)

|Property|Value|
|---|---|
|ReferencedEntity|`customeraddress`|
|ReferencedAttribute|`customeraddressid`|
|ReferencingAttribute|`billtoaddress`|
|ReferencingEntityNavigationPropertyName|`billtoaddress`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_customer_address_contracts_as_service_address"></a> customer_address_contracts_as_service_address

One-To-Many Relationship: [customeraddress customer_address_contracts_as_service_address](customeraddress.md#BKMK_customer_address_contracts_as_service_address)

|Property|Value|
|---|---|
|ReferencedEntity|`customeraddress`|
|ReferencedAttribute|`customeraddressid`|
|ReferencingAttribute|`serviceaddress`|
|ReferencingEntityNavigationPropertyName|`serviceaddress`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_contract_createdonbehalfby"></a> lk_contract_createdonbehalfby

One-To-Many Relationship: [systemuser lk_contract_createdonbehalfby](systemuser.md#BKMK_lk_contract_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_contract_modifiedonbehalfby"></a> lk_contract_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_contract_modifiedonbehalfby](systemuser.md#BKMK_lk_contract_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_contractbase_createdby"></a> lk_contractbase_createdby

One-To-Many Relationship: [systemuser lk_contractbase_createdby](systemuser.md#BKMK_lk_contractbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_contractbase_modifiedby"></a> lk_contractbase_modifiedby

One-To-Many Relationship: [systemuser lk_contractbase_modifiedby](systemuser.md#BKMK_lk_contractbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_contracts"></a> owner_contracts

One-To-Many Relationship: [owner owner_contracts](owner.md#BKMK_owner_contracts)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_system_user_service_contracts"></a> system_user_service_contracts

One-To-Many Relationship: [systemuser system_user_service_contracts](systemuser.md#BKMK_system_user_service_contracts)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_service_contracts"></a> team_service_contracts

One-To-Many Relationship: [team team_service_contracts](team.md#BKMK_team_service_contracts)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_contract"></a> transactioncurrency_contract

One-To-Many Relationship: [transactioncurrency transactioncurrency_contract](transactioncurrency.md#BKMK_transactioncurrency_contract)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [contract_activity_parties](#BKMK_contract_activity_parties)
- [Contract_ActivityPointers](#BKMK_Contract_ActivityPointers)
- [contract_adx_inviteredemptions](#BKMK_contract_adx_inviteredemptions)
- [contract_adx_portalcomments](#BKMK_contract_adx_portalcomments)
- [Contract_Annotation](#BKMK_Contract_Annotation)
- [Contract_Appointments](#BKMK_Contract_Appointments)
- [Contract_AsyncOperations](#BKMK_Contract_AsyncOperations)
- [Contract_BulkDeleteFailures](#BKMK_Contract_BulkDeleteFailures)
- [contract_cases](#BKMK_contract_cases)
- [contract_chats](#BKMK_contract_chats)
- [contract_connections1](#BKMK_contract_connections1)
- [contract_connections2](#BKMK_contract_connections2)
- [Contract_DuplicateBaseRecord](#BKMK_Contract_DuplicateBaseRecord)
- [Contract_DuplicateMatchingRecord](#BKMK_Contract_DuplicateMatchingRecord)
- [Contract_Emails](#BKMK_Contract_Emails)
- [Contract_Faxes](#BKMK_Contract_Faxes)
- [Contract_Letters](#BKMK_Contract_Letters)
- [contract_line_items](#BKMK_contract_line_items)
- [Contract_MailboxTrackingFolder](#BKMK_Contract_MailboxTrackingFolder)
- [contract_msdyn_copilottranscripts](#BKMK_contract_msdyn_copilottranscripts)
- [contract_msdyn_ocliveworkitems](#BKMK_contract_msdyn_ocliveworkitems)
- [contract_msdyn_ocsessions](#BKMK_contract_msdyn_ocsessions)
- [contract_msfp_alerts](#BKMK_contract_msfp_alerts)
- [contract_msfp_surveyinvites](#BKMK_contract_msfp_surveyinvites)
- [contract_msfp_surveyresponses](#BKMK_contract_msfp_surveyresponses)
- [contract_originating_contract](#BKMK_contract_originating_contract-one-to-many)
- [Contract_Phonecalls](#BKMK_Contract_Phonecalls)
- [contract_principalobjectattributeaccess](#BKMK_contract_principalobjectattributeaccess)
- [Contract_ProcessSessions](#BKMK_Contract_ProcessSessions)
- [Contract_RecurringAppointmentMasters](#BKMK_Contract_RecurringAppointmentMasters)
- [Contract_ServiceAppointments](#BKMK_Contract_ServiceAppointments)
- [Contract_SocialActivities](#BKMK_Contract_SocialActivities)
- [Contract_SyncErrors](#BKMK_Contract_SyncErrors)
- [Contract_Tasks](#BKMK_Contract_Tasks)

### <a name="BKMK_contract_activity_parties"></a> contract_activity_parties

Many-To-One Relationship: [activityparty contract_activity_parties](activityparty.md#BKMK_contract_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`contract_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_ActivityPointers"></a> Contract_ActivityPointers

Many-To-One Relationship: [activitypointer Contract_ActivityPointers](activitypointer.md#BKMK_Contract_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_ActivityPointers`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_adx_inviteredemptions"></a> contract_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption contract_adx_inviteredemptions](adx_inviteredemption.md#BKMK_contract_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contract_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_adx_portalcomments"></a> contract_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment contract_adx_portalcomments](adx_portalcomment.md#BKMK_contract_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contract_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_Annotation"></a> Contract_Annotation

Many-To-One Relationship: [annotation Contract_Annotation](annotation.md#BKMK_Contract_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Contract_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_Appointments"></a> Contract_Appointments

Many-To-One Relationship: [appointment Contract_Appointments](appointment.md#BKMK_Contract_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_AsyncOperations"></a> Contract_AsyncOperations

Many-To-One Relationship: [asyncoperation Contract_AsyncOperations](asyncoperation.md#BKMK_Contract_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_BulkDeleteFailures"></a> Contract_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Contract_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Contract_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_cases"></a> contract_cases

Many-To-One Relationship: [incident contract_cases](incident.md#BKMK_contract_cases)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`contractid`|
|ReferencedEntityNavigationPropertyName|`contract_cases`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMIncident.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010003501`|

### <a name="BKMK_contract_chats"></a> contract_chats

Many-To-One Relationship: [chat contract_chats](chat.md#BKMK_contract_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contract_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_connections1"></a> contract_connections1

Many-To-One Relationship: [connection contract_connections1](connection.md#BKMK_contract_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`contract_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_connections2"></a> contract_connections2

Many-To-One Relationship: [connection contract_connections2](connection.md#BKMK_contract_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`contract_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_DuplicateBaseRecord"></a> Contract_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord Contract_DuplicateBaseRecord](duplicaterecord.md#BKMK_Contract_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`Contract_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_DuplicateMatchingRecord"></a> Contract_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord Contract_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Contract_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`Contract_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_Emails"></a> Contract_Emails

Many-To-One Relationship: [email Contract_Emails](email.md#BKMK_Contract_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_Faxes"></a> Contract_Faxes

Many-To-One Relationship: [fax Contract_Faxes](fax.md#BKMK_Contract_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_Letters"></a> Contract_Letters

Many-To-One Relationship: [letter Contract_Letters](letter.md#BKMK_Contract_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_line_items"></a> contract_line_items

Many-To-One Relationship: [contractdetail contract_line_items](contractdetail.md#BKMK_contract_line_items)

|Property|Value|
|---|---|
|ReferencingEntity|`contractdetail`|
|ReferencingAttribute|`contractid`|
|ReferencedEntityNavigationPropertyName|`contract_line_items`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMContractDetail.RetrieveByContract`<br />ViewId: `2922b6fe-7578-4002-b4e1-b5189c28a37a`|

### <a name="BKMK_Contract_MailboxTrackingFolder"></a> Contract_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder Contract_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Contract_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_msdyn_copilottranscripts"></a> contract_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript contract_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_contract_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contract_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_msdyn_ocliveworkitems"></a> contract_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem contract_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_contract_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contract_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_msdyn_ocsessions"></a> contract_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession contract_msdyn_ocsessions](msdyn_ocsession.md#BKMK_contract_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contract_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_msfp_alerts"></a> contract_msfp_alerts

Many-To-One Relationship: [msfp_alert contract_msfp_alerts](msfp_alert.md#BKMK_contract_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contract_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_msfp_surveyinvites"></a> contract_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite contract_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_contract_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contract_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_msfp_surveyresponses"></a> contract_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse contract_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_contract_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contract_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_originating_contract-one-to-many"></a> contract_originating_contract

Many-To-One Relationship: [contract contract_originating_contract](#BKMK_contract_originating_contract-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`originatingcontract`|
|ReferencedEntityNavigationPropertyName|`contract_originating_contract`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_Phonecalls"></a> Contract_Phonecalls

Many-To-One Relationship: [phonecall Contract_Phonecalls](phonecall.md#BKMK_Contract_Phonecalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_Phonecalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_principalobjectattributeaccess"></a> contract_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess contract_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_contract_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`contract_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_ProcessSessions"></a> Contract_ProcessSessions

Many-To-One Relationship: [processsession Contract_ProcessSessions](processsession.md#BKMK_Contract_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_RecurringAppointmentMasters"></a> Contract_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster Contract_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Contract_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_ServiceAppointments"></a> Contract_ServiceAppointments

Many-To-One Relationship: [serviceappointment Contract_ServiceAppointments](serviceappointment.md#BKMK_Contract_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_SocialActivities"></a> Contract_SocialActivities

Many-To-One Relationship: [socialactivity Contract_SocialActivities](socialactivity.md#BKMK_Contract_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_SyncErrors"></a> Contract_SyncErrors

Many-To-One Relationship: [syncerror Contract_SyncErrors](syncerror.md#BKMK_Contract_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contract_Tasks"></a> Contract_Tasks

Many-To-One Relationship: [task Contract_Tasks](task.md#BKMK_Contract_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contract_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_servicecontractcontacts_association"></a> servicecontractcontacts_association

See [contact servicecontractcontacts_association Many-To-Many Relationship](contact.md#BKMK_servicecontractcontacts_association)

|Property|Value|
|---|---|
|IntersectEntityName|`servicecontractcontacts`|
|IsCustomizable|False|
|SchemaName|`servicecontractcontacts_association`|
|IntersectAttribute|`contractid`|
|NavigationPropertyName|`servicecontractcontacts_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

