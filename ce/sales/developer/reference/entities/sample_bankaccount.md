---
title: "Bank Account (sample_BankAccount) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Bank Account (sample_BankAccount) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/19/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Bank Account (sample_BankAccount) table/entity reference

Contains information about customer bank accounts

## Messages

The following table lists the messages for the Bank Account (sample_BankAccount) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /sample_bankaccounts(*sample_bankaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /sample_bankaccounts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /sample_bankaccounts(*sample_bankaccountid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /sample_bankaccounts(*sample_bankaccountid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /sample_bankaccounts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Retrieve multiple records](/power-apps/developer/data-platform/org-service/query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /sample_bankaccounts(*sample_bankaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /sample_bankaccounts(*sample_bankaccountid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /sample_bankaccounts(*sample_bankaccountid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Bank Account (sample_BankAccount) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |Type generated by Power Platform CLI [pac modelbuilder build](/power-platform/developer/cli/reference/modelbuilder#pac-modelbuilder-build) command or use <xref:Microsoft.Xrm.Sdk.OrganizationRequest> setting the required parameters for the message.|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |Type generated by Power Platform CLI [pac modelbuilder build](/power-platform/developer/cli/reference/modelbuilder#pac-modelbuilder-build) command or use <xref:Microsoft.Xrm.Sdk.OrganizationRequest> setting the required parameters for the message.|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |Type generated by Power Platform CLI [pac modelbuilder build](/power-platform/developer/cli/reference/modelbuilder#pac-modelbuilder-build) command or use <xref:Microsoft.Xrm.Sdk.OrganizationRequest> setting the required parameters for the message.|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |Type generated by Power Platform CLI [pac modelbuilder build](/power-platform/developer/cli/reference/modelbuilder#pac-modelbuilder-build) command or use <xref:Microsoft.Xrm.Sdk.OrganizationRequest> setting the required parameters for the message.|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |Type generated by Power Platform CLI [pac modelbuilder build](/power-platform/developer/cli/reference/modelbuilder#pac-modelbuilder-build) command or use <xref:Microsoft.Xrm.Sdk.OrganizationRequest> setting the required parameters for the message.|

## Properties

The following table lists selected properties for the Bank Account (sample_BankAccount) table.

| Property | Value |
| --- | --- |
| **DisplayName** | **Bank Account** |
| **DisplayCollectionName** | **Bank Accounts** |
| **SchemaName** | `sample_BankAccount` |
| **CollectionSchemaName** | `sample_BankAccounts` |
| **EntitySetName** | `sample_bankaccounts`|
| **LogicalName** | `sample_bankaccount` |
| **LogicalCollectionName** | `sample_bankaccounts` |
| **PrimaryIdAttribute** | `sample_bankaccountid` |
| **PrimaryNameAttribute** |`sample_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [sample_BankAccountId](#BKMK_sample_BankAccountId)
- [sample_BigInt](#BKMK_sample_BigInt)
- [sample_Boolean](#BKMK_sample_Boolean)
- [sample_Colors](#BKMK_sample_Colors)
- [sample_CustomerId](#BKMK_sample_CustomerId)
- [sample_CustomerIdType](#BKMK_sample_CustomerIdType)
- [sample_DateTime](#BKMK_sample_DateTime)
- [sample_Decimal](#BKMK_sample_Decimal)
- [sample_Integer](#BKMK_sample_Integer)
- [sample_Memo](#BKMK_sample_Memo)
- [sample_Money](#BKMK_sample_Money)
- [sample_MultiSelectChoice](#BKMK_sample_MultiSelectChoice)
- [sample_Name](#BKMK_sample_Name)
- [sample_Picklist](#BKMK_sample_Picklist)
- [sample_RelatedAccountId](#BKMK_sample_RelatedAccountId)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

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

### <a name="BKMK_sample_BankAccountId"></a> sample_BankAccountId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Bank Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sample_bankaccountid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_sample_BigInt"></a> sample_BigInt

|Property|Value|
|---|---|
|Description|**Sample BigInt column description**|
|DisplayName|**Sample BigInt**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sample_bigint`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_sample_Boolean"></a> sample_Boolean

|Property|Value|
|---|---|
|Description|**Sample Boolean column description updated**|
|DisplayName|**Sample Boolean Column Updated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_boolean`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`sample_bankaccount_sample_boolean`|
|DefaultValue|False|
|True Label|Up|
|False Label|Down|

### <a name="BKMK_sample_Colors"></a> sample_Colors

|Property|Value|
|---|---|
|Description|**Sample Colors Choice column description**|
|DisplayName|**Sample Colors Choice**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_colors`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`sample_colors`|

#### sample_Colors Choices/Options

|Value|Label|
|---|---|
|727000000|**Red**|
|727000001|**Yellow**|
|727000002|**Green**|

### <a name="BKMK_sample_CustomerId"></a> sample_CustomerId

|Property|Value|
|---|---|
|Description|**The owner of the bank account**|
|DisplayName|**Sample Bank Account owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_customerid`|
|RequiredLevel|None|
|Type|Customer|
|Targets|account, contact|

### <a name="BKMK_sample_CustomerIdType"></a> sample_CustomerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sample_customeridtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_sample_DateTime"></a> sample_DateTime

|Property|Value|
|---|---|
|Description|**Sample DateTime column description**|
|DisplayName|**Sample DateTime**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_datetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Disabled|
|SourceTypeMask|0|

### <a name="BKMK_sample_Decimal"></a> sample_Decimal

|Property|Value|
|---|---|
|Description|**Sample Decimal column description**|
|DisplayName|**Sample Decimal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_decimal`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100|
|MinValue|0|
|Precision|1|
|SourceTypeMask|0|

### <a name="BKMK_sample_Integer"></a> sample_Integer

|Property|Value|
|---|---|
|Description|**Sample Integer column description**|
|DisplayName|**Sample Integer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_integer`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_sample_Memo"></a> sample_Memo

|Property|Value|
|---|---|
|Description|**Sample Memo column description**|
|DisplayName|**Sample Memo**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_memo`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_sample_Money"></a> sample_Money

|Property|Value|
|---|---|
|Description|**Sample Money column description**|
|DisplayName|**Sample Money**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_money`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000|
|MinValue|0|
|Precision|1|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_sample_MultiSelectChoice"></a> sample_MultiSelectChoice

|Property|Value|
|---|---|
|Description|**Sample MultiSelect Choice column description**|
|DisplayName|**Sample MultiSelect Choice**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_multiselectchoice`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`sample_bankaccount_sample_multiselectchoice`|

#### sample_MultiSelectChoice Choices/Options

|Value|Label|
|---|---|
|727000000|**Appetizer**|
|727000001|**Entree**|
|727000002|**Dessert**|

### <a name="BKMK_sample_Name"></a> sample_Name

|Property|Value|
|---|---|
|Description|**The name of the bank account**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_sample_Picklist"></a> sample_Picklist

|Property|Value|
|---|---|
|Description|**Sample Choice column description**|
|DisplayName|**Sample Choice**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_picklist`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`sample_bankaccount_sample_picklist`|

#### sample_Picklist Choices/Options

|Value|Label|
|---|---|
|727000000|**Bravo**|
|727000001|**Delta**|
|727000002|**Alpha**|
|727000003|**Charlie**|
|727000005|**Echo**|

### <a name="BKMK_sample_RelatedAccountId"></a> sample_RelatedAccountId

|Property|Value|
|---|---|
|Description|**An Account related to the bank account.**|
|DisplayName|**Related Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_relatedaccountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Bank Account**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`sample_bankaccount_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Bank Account**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`sample_bankaccount_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|727000000|Label: **Frozen**<br />State:1<br />TransitionData: None|

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [sample_CustomerIdName](#BKMK_sample_CustomerIdName)
- [sample_CustomerIdYomiName](#BKMK_sample_CustomerIdYomiName)
- [sample_money_Base](#BKMK_sample_money_Base)
- [sample_RelatedAccountIdName](#BKMK_sample_RelatedAccountIdName)
- [sample_RelatedAccountIdYomiName](#BKMK_sample_RelatedAccountIdYomiName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdbyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdbyyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfbyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfbyyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the entity with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-10|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedbyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedbyyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfbyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfbyyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningbusinessunitname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_sample_CustomerIdName"></a> sample_CustomerIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sample_customeridname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_sample_CustomerIdYomiName"></a> sample_CustomerIdYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sample_customeridyominame`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_sample_money_Base"></a> sample_money_Base

|Property|Value|
|---|---|
|Description|**Value of the Sample Money in base currency.**|
|DisplayName|**Sample Money (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_money_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|1|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_sample_RelatedAccountIdName"></a> sample_RelatedAccountIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sample_relatedaccountidname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_sample_RelatedAccountIdYomiName"></a> sample_RelatedAccountIdYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sample_relatedaccountidyominame`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyidname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

- [business_unit_sample_bankaccount](#BKMK_business_unit_sample_bankaccount)
- [lk_sample_bankaccount_createdby](#BKMK_lk_sample_bankaccount_createdby)
- [lk_sample_bankaccount_createdonbehalfby](#BKMK_lk_sample_bankaccount_createdonbehalfby)
- [lk_sample_bankaccount_modifiedby](#BKMK_lk_sample_bankaccount_modifiedby)
- [lk_sample_bankaccount_modifiedonbehalfby](#BKMK_lk_sample_bankaccount_modifiedonbehalfby)
- [owner_sample_bankaccount](#BKMK_owner_sample_bankaccount)
- [sample_Account_BankAccounts](#BKMK_sample_Account_BankAccounts)
- [sample_BankAccount_Customer_Account](#BKMK_sample_BankAccount_Customer_Account)
- [sample_BankAccount_Customer_Contact](#BKMK_sample_BankAccount_Customer_Contact)
- [team_sample_bankaccount](#BKMK_team_sample_bankaccount)
- [TransactionCurrency_sample_BankAccount](#BKMK_TransactionCurrency_sample_BankAccount)
- [user_sample_bankaccount](#BKMK_user_sample_bankaccount)

### <a name="BKMK_business_unit_sample_bankaccount"></a> business_unit_sample_bankaccount

One-To-Many Relationship: [businessunit business_unit_sample_bankaccount](businessunit.md#BKMK_business_unit_sample_bankaccount)

|Property|Value|
|--------|-----|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_lk_sample_bankaccount_createdby"></a> lk_sample_bankaccount_createdby

One-To-Many Relationship: [systemuser lk_sample_bankaccount_createdby](systemuser.md#BKMK_lk_sample_bankaccount_createdby)

|Property|Value|
|--------|-----|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_lk_sample_bankaccount_createdonbehalfby"></a> lk_sample_bankaccount_createdonbehalfby

One-To-Many Relationship: [systemuser lk_sample_bankaccount_createdonbehalfby](systemuser.md#BKMK_lk_sample_bankaccount_createdonbehalfby)

|Property|Value|
|--------|-----|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_lk_sample_bankaccount_modifiedby"></a> lk_sample_bankaccount_modifiedby

One-To-Many Relationship: [systemuser lk_sample_bankaccount_modifiedby](systemuser.md#BKMK_lk_sample_bankaccount_modifiedby)

|Property|Value|
|--------|-----|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_lk_sample_bankaccount_modifiedonbehalfby"></a> lk_sample_bankaccount_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_sample_bankaccount_modifiedonbehalfby](systemuser.md#BKMK_lk_sample_bankaccount_modifiedonbehalfby)

|Property|Value|
|--------|-----|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_owner_sample_bankaccount"></a> owner_sample_bankaccount

One-To-Many Relationship: [owner owner_sample_bankaccount](owner.md#BKMK_owner_sample_bankaccount)

|Property|Value|
|--------|-----|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_sample_Account_BankAccounts"></a> sample_Account_BankAccounts

One-To-Many Relationship: [account sample_Account_BankAccounts](account.md#BKMK_sample_Account_BankAccounts)

|Property|Value|
|--------|-----|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`sample_relatedaccountid`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_sample_BankAccount_Customer_Account"></a> sample_BankAccount_Customer_Account

One-To-Many Relationship: [account sample_BankAccount_Customer_Account](account.md#BKMK_sample_BankAccount_Customer_Account)

|Property|Value|
|--------|-----|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`sample_customerid`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_sample_BankAccount_Customer_Contact"></a> sample_BankAccount_Customer_Contact

One-To-Many Relationship: [contact sample_BankAccount_Customer_Contact](contact.md#BKMK_sample_BankAccount_Customer_Contact)

|Property|Value|
|--------|-----|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`sample_customerid`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_team_sample_bankaccount"></a> team_sample_bankaccount

One-To-Many Relationship: [team team_sample_bankaccount](team.md#BKMK_team_sample_bankaccount)

|Property|Value|
|--------|-----|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_TransactionCurrency_sample_BankAccount"></a> TransactionCurrency_sample_BankAccount

One-To-Many Relationship: [transactioncurrency TransactionCurrency_sample_BankAccount](transactioncurrency.md#BKMK_TransactionCurrency_sample_BankAccount)

|Property|Value|
|--------|-----|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||

### <a name="BKMK_user_sample_bankaccount"></a> user_sample_bankaccount

One-To-Many Relationship: [systemuser user_sample_bankaccount](systemuser.md#BKMK_user_sample_bankaccount)

|Property|Value|
|--------|-----|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [sample_bankaccount_ActivityPointers](#BKMK_sample_bankaccount_ActivityPointers)
- [sample_bankaccount_adx_inviteredemptions](#BKMK_sample_bankaccount_adx_inviteredemptions)
- [sample_bankaccount_adx_portalcomments](#BKMK_sample_bankaccount_adx_portalcomments)
- [sample_bankaccount_Appointments](#BKMK_sample_bankaccount_Appointments)
- [sample_bankaccount_AsyncOperations](#BKMK_sample_bankaccount_AsyncOperations)
- [sample_bankaccount_BulkDeleteFailures](#BKMK_sample_bankaccount_BulkDeleteFailures)
- [sample_bankaccount_chats](#BKMK_sample_bankaccount_chats)
- [sample_BankAccount_Contacts](#BKMK_sample_BankAccount_Contacts)
- [sample_bankaccount_Emails](#BKMK_sample_bankaccount_Emails)
- [sample_bankaccount_Faxes](#BKMK_sample_bankaccount_Faxes)
- [sample_bankaccount_Letters](#BKMK_sample_bankaccount_Letters)
- [sample_bankaccount_MailboxTrackingFolders](#BKMK_sample_bankaccount_MailboxTrackingFolders)
- [sample_bankaccount_msdyn_copilottranscripts](#BKMK_sample_bankaccount_msdyn_copilottranscripts)
- [sample_bankaccount_msdyn_ocliveworkitems](#BKMK_sample_bankaccount_msdyn_ocliveworkitems)
- [sample_bankaccount_msdyn_ocsessions](#BKMK_sample_bankaccount_msdyn_ocsessions)
- [sample_bankaccount_msfp_alerts](#BKMK_sample_bankaccount_msfp_alerts)
- [sample_bankaccount_msfp_surveyinvites](#BKMK_sample_bankaccount_msfp_surveyinvites)
- [sample_bankaccount_msfp_surveyresponses](#BKMK_sample_bankaccount_msfp_surveyresponses)
- [sample_bankaccount_PhoneCalls](#BKMK_sample_bankaccount_PhoneCalls)
- [sample_bankaccount_PrincipalObjectAttributeAccesses](#BKMK_sample_bankaccount_PrincipalObjectAttributeAccesses)
- [sample_bankaccount_ProcessSession](#BKMK_sample_bankaccount_ProcessSession)
- [sample_bankaccount_RecurringAppointmentMasters](#BKMK_sample_bankaccount_RecurringAppointmentMasters)
- [sample_bankaccount_ServiceAppointments](#BKMK_sample_bankaccount_ServiceAppointments)
- [sample_bankaccount_SocialActivities](#BKMK_sample_bankaccount_SocialActivities)
- [sample_bankaccount_SyncErrors](#BKMK_sample_bankaccount_SyncErrors)
- [sample_bankaccount_Tasks](#BKMK_sample_bankaccount_Tasks)

### <a name="BKMK_sample_bankaccount_ActivityPointers"></a> sample_bankaccount_ActivityPointers

Many-To-One Relationship: [activitypointer sample_bankaccount_ActivityPointers](activitypointer.md#BKMK_sample_bankaccount_ActivityPointers)

|Property|Value|
|--------|-----|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_ActivityPointers`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_adx_inviteredemptions"></a> sample_bankaccount_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption sample_bankaccount_adx_inviteredemptions](adx_inviteredemption.md#BKMK_sample_bankaccount_adx_inviteredemptions)

|Property|Value|
|--------|-----|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_adx_inviteredemptions`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_adx_portalcomments"></a> sample_bankaccount_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment sample_bankaccount_adx_portalcomments](adx_portalcomment.md#BKMK_sample_bankaccount_adx_portalcomments)

|Property|Value|
|--------|-----|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_adx_portalcomments`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_Appointments"></a> sample_bankaccount_Appointments

Many-To-One Relationship: [appointment sample_bankaccount_Appointments](appointment.md#BKMK_sample_bankaccount_Appointments)

|Property|Value|
|--------|-----|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_Appointments`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_AsyncOperations"></a> sample_bankaccount_AsyncOperations

Many-To-One Relationship: [asyncoperation sample_bankaccount_AsyncOperations](asyncoperation.md#BKMK_sample_bankaccount_AsyncOperations)

|Property|Value|
|--------|-----|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_AsyncOperations`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_BulkDeleteFailures"></a> sample_bankaccount_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure sample_bankaccount_BulkDeleteFailures](bulkdeletefailure.md#BKMK_sample_bankaccount_BulkDeleteFailures)

|Property|Value|
|--------|-----|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_BulkDeleteFailures`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_chats"></a> sample_bankaccount_chats

Many-To-One Relationship: [chat sample_bankaccount_chats](chat.md#BKMK_sample_bankaccount_chats)

|Property|Value|
|--------|-----|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_chats`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_BankAccount_Contacts"></a> sample_BankAccount_Contacts

Many-To-One Relationship: [contact sample_BankAccount_Contacts](contact.md#BKMK_sample_BankAccount_Contacts)

|Property|Value|
|--------|-----|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`sample_bankaccountid`|
|ReferencedEntityNavigationPropertyName|`sample_BankAccount_Contacts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Cardholders<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_Emails"></a> sample_bankaccount_Emails

Many-To-One Relationship: [email sample_bankaccount_Emails](email.md#BKMK_sample_bankaccount_Emails)

|Property|Value|
|--------|-----|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_Emails`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_Faxes"></a> sample_bankaccount_Faxes

Many-To-One Relationship: [fax sample_bankaccount_Faxes](fax.md#BKMK_sample_bankaccount_Faxes)

|Property|Value|
|--------|-----|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_Faxes`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_Letters"></a> sample_bankaccount_Letters

Many-To-One Relationship: [letter sample_bankaccount_Letters](letter.md#BKMK_sample_bankaccount_Letters)

|Property|Value|
|--------|-----|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_Letters`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_MailboxTrackingFolders"></a> sample_bankaccount_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder sample_bankaccount_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_sample_bankaccount_MailboxTrackingFolders)

|Property|Value|
|--------|-----|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_MailboxTrackingFolders`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_msdyn_copilottranscripts"></a> sample_bankaccount_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript sample_bankaccount_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_sample_bankaccount_msdyn_copilottranscripts)

|Property|Value|
|--------|-----|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_msdyn_copilottranscripts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_msdyn_ocliveworkitems"></a> sample_bankaccount_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem sample_bankaccount_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_sample_bankaccount_msdyn_ocliveworkitems)

|Property|Value|
|--------|-----|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_msdyn_ocliveworkitems`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_msdyn_ocsessions"></a> sample_bankaccount_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession sample_bankaccount_msdyn_ocsessions](msdyn_ocsession.md#BKMK_sample_bankaccount_msdyn_ocsessions)

|Property|Value|
|--------|-----|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_msdyn_ocsessions`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_msfp_alerts"></a> sample_bankaccount_msfp_alerts

Many-To-One Relationship: [msfp_alert sample_bankaccount_msfp_alerts](msfp_alert.md#BKMK_sample_bankaccount_msfp_alerts)

|Property|Value|
|--------|-----|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_msfp_alerts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_msfp_surveyinvites"></a> sample_bankaccount_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite sample_bankaccount_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_sample_bankaccount_msfp_surveyinvites)

|Property|Value|
|--------|-----|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_msfp_surveyinvites`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_msfp_surveyresponses"></a> sample_bankaccount_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse sample_bankaccount_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_sample_bankaccount_msfp_surveyresponses)

|Property|Value|
|--------|-----|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_msfp_surveyresponses`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_PhoneCalls"></a> sample_bankaccount_PhoneCalls

Many-To-One Relationship: [phonecall sample_bankaccount_PhoneCalls](phonecall.md#BKMK_sample_bankaccount_PhoneCalls)

|Property|Value|
|--------|-----|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_PhoneCalls`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_PrincipalObjectAttributeAccesses"></a> sample_bankaccount_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess sample_bankaccount_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_sample_bankaccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|--------|-----|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_PrincipalObjectAttributeAccesses`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_ProcessSession"></a> sample_bankaccount_ProcessSession

Many-To-One Relationship: [processsession sample_bankaccount_ProcessSession](processsession.md#BKMK_sample_bankaccount_ProcessSession)

|Property|Value|
|--------|-----|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_ProcessSession`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_RecurringAppointmentMasters"></a> sample_bankaccount_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster sample_bankaccount_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_sample_bankaccount_RecurringAppointmentMasters)

|Property|Value|
|--------|-----|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_RecurringAppointmentMasters`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_ServiceAppointments"></a> sample_bankaccount_ServiceAppointments

Many-To-One Relationship: [serviceappointment sample_bankaccount_ServiceAppointments](serviceappointment.md#BKMK_sample_bankaccount_ServiceAppointments)

|Property|Value|
|--------|-----|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_ServiceAppointments`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_SocialActivities"></a> sample_bankaccount_SocialActivities

Many-To-One Relationship: [socialactivity sample_bankaccount_SocialActivities](socialactivity.md#BKMK_sample_bankaccount_SocialActivities)

|Property|Value|
|--------|-----|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_SocialActivities`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_SyncErrors"></a> sample_bankaccount_SyncErrors

Many-To-One Relationship: [syncerror sample_bankaccount_SyncErrors](syncerror.md#BKMK_sample_bankaccount_SyncErrors)

|Property|Value|
|--------|-----|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_SyncErrors`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_bankaccount_Tasks"></a> sample_bankaccount_Tasks

Many-To-One Relationship: [task sample_bankaccount_Tasks](task.md#BKMK_sample_bankaccount_Tasks)

|Property|Value|
|--------|-----|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sample_bankaccount_Tasks`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_sample_sample_BankAccounts_Contacts"></a> sample_sample_BankAccounts_Contacts

See [contact sample_sample_BankAccounts_Contacts Many-To-Many Relationship](contact.md#BKMK_sample_sample_BankAccounts_Contacts)

|Property|Value|
|--------|-----|
|IntersectEntityName|`sample_sample_bankaccounts_contacts`|
|IsCustomizable|True|
|SchemaName|`sample_sample_BankAccounts_Contacts`|
|IntersectAttribute|`sample_bankaccountid`|
|NavigationPropertyName|`sample_sample_BankAccounts_Contacts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Bank Accounts<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

