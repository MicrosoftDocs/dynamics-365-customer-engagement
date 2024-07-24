---
title: "Sponsorable Article (msevtmgt_SponsorableArticle) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Sponsorable Article (msevtmgt_SponsorableArticle) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Sponsorable Article (msevtmgt_SponsorableArticle) table/entity reference

An item or a group of items that can be sponsored

## Messages

The following table lists the messages for the Sponsorable Article (msevtmgt_SponsorableArticle) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_sponsorablearticles(*msevtmgt_sponsorablearticleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_sponsorablearticles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_sponsorablearticles(*msevtmgt_sponsorablearticleid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_sponsorablearticles(*msevtmgt_sponsorablearticleid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_sponsorablearticles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_sponsorablearticles(*msevtmgt_sponsorablearticleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_sponsorablearticles(*msevtmgt_sponsorablearticleid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_sponsorablearticles(*msevtmgt_sponsorablearticleid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Sponsorable Article (msevtmgt_SponsorableArticle) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sponsorable Article (msevtmgt_SponsorableArticle) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sponsorable Article** |
| **DisplayCollectionName** | **Sponsorable Articles** |
| **SchemaName** | `msevtmgt_SponsorableArticle` |
| **CollectionSchemaName** | `msevtmgt_SponsorableArticles` |
| **EntitySetName** | `msevtmgt_sponsorablearticles`|
| **LogicalName** | `msevtmgt_sponsorablearticle` |
| **LogicalCollectionName** | `msevtmgt_sponsorablearticles` |
| **PrimaryIdAttribute** | `msevtmgt_sponsorablearticleid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_CostPerUnit](#BKMK_msevtmgt_CostPerUnit)
- [msevtmgt_Description](#BKMK_msevtmgt_Description)
- [msevtmgt_EventSponsorship](#BKMK_msevtmgt_EventSponsorship)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_NumberOfUnits](#BKMK_msevtmgt_NumberOfUnits)
- [msevtmgt_SponsorableArticleId](#BKMK_msevtmgt_SponsorableArticleId)
- [msevtmgt_TransactionCurrencyId](#BKMK_msevtmgt_TransactionCurrencyId)
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
|---|---|
|Description|**The sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_CostPerUnit"></a> msevtmgt_CostPerUnit

|Property|Value|
|---|---|
|Description||
|DisplayName|**Cost per unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_costperunit`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_Description"></a> msevtmgt_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_EventSponsorship"></a> msevtmgt_EventSponsorship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event sponsorship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventsponsorship`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_sponsorship|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_NumberOfUnits"></a> msevtmgt_NumberOfUnits

|Property|Value|
|---|---|
|Description||
|DisplayName|**Number of units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofunits`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_SponsorableArticleId"></a> msevtmgt_SponsorableArticleId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sponsorable article**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sponsorablearticleid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_TransactionCurrencyId"></a> msevtmgt_TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was migrated**|
|DisplayName|**Record created on**|
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
|Description|**Owner ID**|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the sponsorable article**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_sponsorablearticle_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the sponsorable article**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_sponsorablearticle_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time zone rule version number**|
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
|Description|**Unique identifier of the currency associated with the entity**|
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
|Description|**The time zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time zone code**|
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
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msevtmgt_costperunit_Base](#BKMK_msevtmgt_costperunit_Base)
- [msevtmgt_totalcost](#BKMK_msevtmgt_totalcost)
- [msevtmgt_totalcost_Base](#BKMK_msevtmgt_totalcost_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was created**|
|DisplayName|**Created on**|
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
|Description|**Unique identifier of the delegate user who created the record**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate between the base currency and the currency associated with the entity**|
|DisplayName|**Exchange rate**|
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
|Description|**Unique identifier of the user who modified the record**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was modified**|
|DisplayName|**Modified on**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msevtmgt_costperunit_Base"></a> msevtmgt_costperunit_Base

|Property|Value|
|---|---|
|Description|**Value of the cost per unit (in the base currency)**|
|DisplayName|**Cost per unit (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_costperunit_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_totalcost"></a> msevtmgt_totalcost

|Property|Value|
|---|---|
|Description||
|DisplayName|**Total cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_totalcost_Base"></a> msevtmgt_totalcost_Base

|Property|Value|
|---|---|
|Description|**Value of the total cost (in the base currency)**|
|DisplayName|**Total cost (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
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
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record**|
|DisplayName|**Owning user**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

- [business_unit_msevtmgt_sponsorablearticle](#BKMK_business_unit_msevtmgt_sponsorablearticle)
- [lk_msevtmgt_sponsorablearticle_createdby](#BKMK_lk_msevtmgt_sponsorablearticle_createdby)
- [lk_msevtmgt_sponsorablearticle_createdonbehalfby](#BKMK_lk_msevtmgt_sponsorablearticle_createdonbehalfby)
- [lk_msevtmgt_sponsorablearticle_modifiedby](#BKMK_lk_msevtmgt_sponsorablearticle_modifiedby)
- [lk_msevtmgt_sponsorablearticle_modifiedonbehalfby](#BKMK_lk_msevtmgt_sponsorablearticle_modifiedonbehalfby)
- [msevtmgt_sponsorablearticle_sponsorship](#BKMK_msevtmgt_sponsorablearticle_sponsorship)
- [msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle)
- [owner_msevtmgt_sponsorablearticle](#BKMK_owner_msevtmgt_sponsorablearticle)
- [team_msevtmgt_sponsorablearticle](#BKMK_team_msevtmgt_sponsorablearticle)
- [TransactionCurrency_msevtmgt_SponsorableArticle](#BKMK_TransactionCurrency_msevtmgt_SponsorableArticle)
- [user_msevtmgt_sponsorablearticle](#BKMK_user_msevtmgt_sponsorablearticle)

### <a name="BKMK_business_unit_msevtmgt_sponsorablearticle"></a> business_unit_msevtmgt_sponsorablearticle

One-To-Many Relationship: [businessunit business_unit_msevtmgt_sponsorablearticle](businessunit.md#BKMK_business_unit_msevtmgt_sponsorablearticle)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sponsorablearticle_createdby"></a> lk_msevtmgt_sponsorablearticle_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_sponsorablearticle_createdby](systemuser.md#BKMK_lk_msevtmgt_sponsorablearticle_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sponsorablearticle_createdonbehalfby"></a> lk_msevtmgt_sponsorablearticle_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_sponsorablearticle_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_sponsorablearticle_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sponsorablearticle_modifiedby"></a> lk_msevtmgt_sponsorablearticle_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_sponsorablearticle_modifiedby](systemuser.md#BKMK_lk_msevtmgt_sponsorablearticle_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sponsorablearticle_modifiedonbehalfby"></a> lk_msevtmgt_sponsorablearticle_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_sponsorablearticle_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_sponsorablearticle_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_sponsorship"></a> msevtmgt_sponsorablearticle_sponsorship

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorablearticle_sponsorship](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorablearticle_sponsorship)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`msevtmgt_eventsponsorship`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_EventSponsorship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle"></a> msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle

One-To-Many Relationship: [transactioncurrency msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle](transactioncurrency.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_sponsorablearticle"></a> owner_msevtmgt_sponsorablearticle

One-To-Many Relationship: [owner owner_msevtmgt_sponsorablearticle](owner.md#BKMK_owner_msevtmgt_sponsorablearticle)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_sponsorablearticle"></a> team_msevtmgt_sponsorablearticle

One-To-Many Relationship: [team team_msevtmgt_sponsorablearticle](team.md#BKMK_team_msevtmgt_sponsorablearticle)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msevtmgt_SponsorableArticle"></a> TransactionCurrency_msevtmgt_SponsorableArticle

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msevtmgt_SponsorableArticle](transactioncurrency.md#BKMK_TransactionCurrency_msevtmgt_SponsorableArticle)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_sponsorablearticle"></a> user_msevtmgt_sponsorablearticle

One-To-Many Relationship: [systemuser user_msevtmgt_sponsorablearticle](systemuser.md#BKMK_user_msevtmgt_sponsorablearticle)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msevtmgt_sponsorablearticle_ActivityPointers](#BKMK_msevtmgt_sponsorablearticle_ActivityPointers)
- [msevtmgt_sponsorablearticle_adx_alertsubscriptions](#BKMK_msevtmgt_sponsorablearticle_adx_alertsubscriptions)
- [msevtmgt_sponsorablearticle_adx_inviteredemptions](#BKMK_msevtmgt_sponsorablearticle_adx_inviteredemptions)
- [msevtmgt_sponsorablearticle_adx_portalcomments](#BKMK_msevtmgt_sponsorablearticle_adx_portalcomments)
- [msevtmgt_sponsorablearticle_Annotations](#BKMK_msevtmgt_sponsorablearticle_Annotations)
- [msevtmgt_sponsorablearticle_Appointments](#BKMK_msevtmgt_sponsorablearticle_Appointments)
- [msevtmgt_sponsorablearticle_AsyncOperations](#BKMK_msevtmgt_sponsorablearticle_AsyncOperations)
- [msevtmgt_sponsorablearticle_BulkDeleteFailures](#BKMK_msevtmgt_sponsorablearticle_BulkDeleteFailures)
- [msevtmgt_sponsorablearticle_chats](#BKMK_msevtmgt_sponsorablearticle_chats)
- [msevtmgt_sponsorablearticle_Emails](#BKMK_msevtmgt_sponsorablearticle_Emails)
- [msevtmgt_sponsorablearticle_Faxes](#BKMK_msevtmgt_sponsorablearticle_Faxes)
- [msevtmgt_sponsorablearticle_Letters](#BKMK_msevtmgt_sponsorablearticle_Letters)
- [msevtmgt_sponsorablearticle_li_inmails](#BKMK_msevtmgt_sponsorablearticle_li_inmails)
- [msevtmgt_sponsorablearticle_li_messages](#BKMK_msevtmgt_sponsorablearticle_li_messages)
- [msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds)
- [msevtmgt_sponsorablearticle_MailboxTrackingFolders](#BKMK_msevtmgt_sponsorablearticle_MailboxTrackingFolders)
- [msevtmgt_sponsorablearticle_msdyn_bookingalerts](#BKMK_msevtmgt_sponsorablearticle_msdyn_bookingalerts)
- [msevtmgt_sponsorablearticle_msdyn_copilottranscripts](#BKMK_msevtmgt_sponsorablearticle_msdyn_copilottranscripts)
- [msevtmgt_sponsorablearticle_msdyn_ocliveworkitems](#BKMK_msevtmgt_sponsorablearticle_msdyn_ocliveworkitems)
- [msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages](#BKMK_msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages)
- [msevtmgt_sponsorablearticle_msdyn_ocsessions](#BKMK_msevtmgt_sponsorablearticle_msdyn_ocsessions)
- [msevtmgt_sponsorablearticle_msdyn_ocvoicemails](#BKMK_msevtmgt_sponsorablearticle_msdyn_ocvoicemails)
- [msevtmgt_sponsorablearticle_msfp_alerts](#BKMK_msevtmgt_sponsorablearticle_msfp_alerts)
- [msevtmgt_sponsorablearticle_msfp_surveyinvites](#BKMK_msevtmgt_sponsorablearticle_msfp_surveyinvites)
- [msevtmgt_sponsorablearticle_msfp_surveyresponses](#BKMK_msevtmgt_sponsorablearticle_msfp_surveyresponses)
- [msevtmgt_sponsorablearticle_PhoneCalls](#BKMK_msevtmgt_sponsorablearticle_PhoneCalls)
- [msevtmgt_sponsorablearticle_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_sponsorablearticle_PrincipalObjectAttributeAccesses)
- [msevtmgt_sponsorablearticle_ProcessSession](#BKMK_msevtmgt_sponsorablearticle_ProcessSession)
- [msevtmgt_sponsorablearticle_RecurringAppointmentMasters](#BKMK_msevtmgt_sponsorablearticle_RecurringAppointmentMasters)
- [msevtmgt_sponsorablearticle_ServiceAppointments](#BKMK_msevtmgt_sponsorablearticle_ServiceAppointments)
- [msevtmgt_sponsorablearticle_SocialActivities](#BKMK_msevtmgt_sponsorablearticle_SocialActivities)
- [msevtmgt_sponsorablearticle_SyncErrors](#BKMK_msevtmgt_sponsorablearticle_SyncErrors)
- [msevtmgt_sponsorablearticle_Tasks](#BKMK_msevtmgt_sponsorablearticle_Tasks)

### <a name="BKMK_msevtmgt_sponsorablearticle_ActivityPointers"></a> msevtmgt_sponsorablearticle_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_sponsorablearticle_ActivityPointers](activitypointer.md#BKMK_msevtmgt_sponsorablearticle_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_adx_alertsubscriptions"></a> msevtmgt_sponsorablearticle_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_sponsorablearticle_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_sponsorablearticle_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_adx_inviteredemptions"></a> msevtmgt_sponsorablearticle_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_sponsorablearticle_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_sponsorablearticle_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_adx_portalcomments"></a> msevtmgt_sponsorablearticle_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_sponsorablearticle_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_sponsorablearticle_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_Annotations"></a> msevtmgt_sponsorablearticle_Annotations

Many-To-One Relationship: [annotation msevtmgt_sponsorablearticle_Annotations](annotation.md#BKMK_msevtmgt_sponsorablearticle_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_Appointments"></a> msevtmgt_sponsorablearticle_Appointments

Many-To-One Relationship: [appointment msevtmgt_sponsorablearticle_Appointments](appointment.md#BKMK_msevtmgt_sponsorablearticle_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_AsyncOperations"></a> msevtmgt_sponsorablearticle_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_sponsorablearticle_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_sponsorablearticle_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_BulkDeleteFailures"></a> msevtmgt_sponsorablearticle_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_sponsorablearticle_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_sponsorablearticle_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_chats"></a> msevtmgt_sponsorablearticle_chats

Many-To-One Relationship: [chat msevtmgt_sponsorablearticle_chats](chat.md#BKMK_msevtmgt_sponsorablearticle_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_Emails"></a> msevtmgt_sponsorablearticle_Emails

Many-To-One Relationship: [email msevtmgt_sponsorablearticle_Emails](email.md#BKMK_msevtmgt_sponsorablearticle_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_Faxes"></a> msevtmgt_sponsorablearticle_Faxes

Many-To-One Relationship: [fax msevtmgt_sponsorablearticle_Faxes](fax.md#BKMK_msevtmgt_sponsorablearticle_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_Letters"></a> msevtmgt_sponsorablearticle_Letters

Many-To-One Relationship: [letter msevtmgt_sponsorablearticle_Letters](letter.md#BKMK_msevtmgt_sponsorablearticle_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_li_inmails"></a> msevtmgt_sponsorablearticle_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_sponsorablearticle_li_inmails](li_inmail.md#BKMK_msevtmgt_sponsorablearticle_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_li_messages"></a> msevtmgt_sponsorablearticle_li_messages

Many-To-One Relationship: [li_message msevtmgt_sponsorablearticle_li_messages](li_message.md#BKMK_msevtmgt_sponsorablearticle_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds"></a> msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_MailboxTrackingFolders"></a> msevtmgt_sponsorablearticle_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_sponsorablearticle_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_sponsorablearticle_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msdyn_bookingalerts"></a> msevtmgt_sponsorablearticle_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_sponsorablearticle_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_sponsorablearticle_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msdyn_copilottranscripts"></a> msevtmgt_sponsorablearticle_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_sponsorablearticle_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_sponsorablearticle_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msdyn_ocliveworkitems"></a> msevtmgt_sponsorablearticle_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_sponsorablearticle_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_sponsorablearticle_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages"></a> msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msdyn_ocsessions"></a> msevtmgt_sponsorablearticle_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_sponsorablearticle_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_sponsorablearticle_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msdyn_ocvoicemails"></a> msevtmgt_sponsorablearticle_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_sponsorablearticle_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_sponsorablearticle_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msfp_alerts"></a> msevtmgt_sponsorablearticle_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_sponsorablearticle_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_sponsorablearticle_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msfp_surveyinvites"></a> msevtmgt_sponsorablearticle_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_sponsorablearticle_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_sponsorablearticle_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msfp_surveyresponses"></a> msevtmgt_sponsorablearticle_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_sponsorablearticle_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_sponsorablearticle_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_PhoneCalls"></a> msevtmgt_sponsorablearticle_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_sponsorablearticle_PhoneCalls](phonecall.md#BKMK_msevtmgt_sponsorablearticle_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_PrincipalObjectAttributeAccesses"></a> msevtmgt_sponsorablearticle_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_sponsorablearticle_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_sponsorablearticle_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_ProcessSession"></a> msevtmgt_sponsorablearticle_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_sponsorablearticle_ProcessSession](processsession.md#BKMK_msevtmgt_sponsorablearticle_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_RecurringAppointmentMasters"></a> msevtmgt_sponsorablearticle_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_sponsorablearticle_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_sponsorablearticle_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_ServiceAppointments"></a> msevtmgt_sponsorablearticle_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_sponsorablearticle_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_sponsorablearticle_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_SocialActivities"></a> msevtmgt_sponsorablearticle_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_sponsorablearticle_SocialActivities](socialactivity.md#BKMK_msevtmgt_sponsorablearticle_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_SyncErrors"></a> msevtmgt_sponsorablearticle_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_sponsorablearticle_SyncErrors](syncerror.md#BKMK_msevtmgt_sponsorablearticle_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorablearticle_Tasks"></a> msevtmgt_sponsorablearticle_Tasks

Many-To-One Relationship: [task msevtmgt_sponsorablearticle_Tasks](task.md#BKMK_msevtmgt_sponsorablearticle_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

