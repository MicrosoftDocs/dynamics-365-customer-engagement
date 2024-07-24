---
title: "Sponsorship (msevtmgt_Sponsorship) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Sponsorship (msevtmgt_Sponsorship) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Sponsorship (msevtmgt_Sponsorship) table/entity reference



## Messages

The following table lists the messages for the Sponsorship (msevtmgt_Sponsorship) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_sponsorships(*msevtmgt_sponsorshipid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_sponsorships<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_sponsorships(*msevtmgt_sponsorshipid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_sponsorships(*msevtmgt_sponsorshipid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_sponsorships<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_sponsorships(*msevtmgt_sponsorshipid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_sponsorships(*msevtmgt_sponsorshipid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_sponsorships(*msevtmgt_sponsorshipid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Sponsorship (msevtmgt_Sponsorship) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sponsorship (msevtmgt_Sponsorship) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sponsorship** |
| **DisplayCollectionName** | **Sponsorships** |
| **SchemaName** | `msevtmgt_Sponsorship` |
| **CollectionSchemaName** | `msevtmgt_Sponsorships` |
| **EntitySetName** | `msevtmgt_sponsorships`|
| **LogicalName** | `msevtmgt_sponsorship` |
| **LogicalCollectionName** | `msevtmgt_sponsorships` |
| **PrimaryIdAttribute** | `msevtmgt_sponsorshipid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_Description](#BKMK_msevtmgt_Description)
- [msevtmgt_Event](#BKMK_msevtmgt_Event)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_Sponsor](#BKMK_msevtmgt_Sponsor)
- [msevtmgt_SponsorshipAmount](#BKMK_msevtmgt_SponsorshipAmount)
- [msevtmgt_SponsorshipCategory](#BKMK_msevtmgt_SponsorshipCategory)
- [msevtmgt_SponsorshipId](#BKMK_msevtmgt_SponsorshipId)
- [msevtmgt_SponsorshipType](#BKMK_msevtmgt_SponsorshipType)
- [msevtmgt_TransactionCurrencyId](#BKMK_msevtmgt_TransactionCurrencyId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sponsor image**|
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

### <a name="BKMK_msevtmgt_Event"></a> msevtmgt_Event

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_event`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description||
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

### <a name="BKMK_msevtmgt_Sponsor"></a> msevtmgt_Sponsor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sponsor**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sponsor`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msevtmgt_SponsorshipAmount"></a> msevtmgt_SponsorshipAmount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sponsorship amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sponsorshipamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_SponsorshipCategory"></a> msevtmgt_SponsorshipCategory

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sponsorship category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sponsorshipcategory`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_sponsorshipcategory`|

#### msevtmgt_SponsorshipCategory Choices/Options

|Value|Label|
|---|---|
|100000000|**Platinum**|
|100000001|**Gold**|
|100000002|**Silver**|
|100000003|**Bronze**|

### <a name="BKMK_msevtmgt_SponsorshipId"></a> msevtmgt_SponsorshipId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sponsorship**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sponsorshipid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_SponsorshipType"></a> msevtmgt_SponsorshipType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sponsorship type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sponsorshiptype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_sponsorshiptype`|

#### msevtmgt_SponsorshipType Choices/Options

|Value|Label|
|---|---|
|100000000|**Monetary**|
|100000001|**Services**|
|100000002|**Equipment**|

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
|Description|**Status of the sponsorship**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_sponsorship_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the sponsorship**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_sponsorship_statuscode`|

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
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msevtmgt_sponsorshipamount_Base](#BKMK_msevtmgt_sponsorshipamount_Base)
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
|ImeMode|Disabled|
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

### <a name="BKMK_msevtmgt_sponsorshipamount_Base"></a> msevtmgt_sponsorshipamount_Base

|Property|Value|
|---|---|
|Description|**Value of the sponsorship amount (in the base currency)**|
|DisplayName|**Sponsorship amount (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sponsorshipamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
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

- [business_unit_msevtmgt_sponsorship](#BKMK_business_unit_msevtmgt_sponsorship)
- [lk_msevtmgt_sponsorship_createdby](#BKMK_lk_msevtmgt_sponsorship_createdby)
- [lk_msevtmgt_sponsorship_createdonbehalfby](#BKMK_lk_msevtmgt_sponsorship_createdonbehalfby)
- [lk_msevtmgt_sponsorship_modifiedby](#BKMK_lk_msevtmgt_sponsorship_modifiedby)
- [lk_msevtmgt_sponsorship_modifiedonbehalfby](#BKMK_lk_msevtmgt_sponsorship_modifiedonbehalfby)
- [msevtmgt_account_msevtmgt_sponsorship_Sponsor](#BKMK_msevtmgt_account_msevtmgt_sponsorship_Sponsor)
- [msevtmgt_Event_msevtmgt_Sponsorship](#BKMK_msevtmgt_Event_msevtmgt_Sponsorship)
- [msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship)
- [owner_msevtmgt_sponsorship](#BKMK_owner_msevtmgt_sponsorship)
- [team_msevtmgt_sponsorship](#BKMK_team_msevtmgt_sponsorship)
- [TransactionCurrency_msevtmgt_Sponsorship](#BKMK_TransactionCurrency_msevtmgt_Sponsorship)
- [user_msevtmgt_sponsorship](#BKMK_user_msevtmgt_sponsorship)

### <a name="BKMK_business_unit_msevtmgt_sponsorship"></a> business_unit_msevtmgt_sponsorship

One-To-Many Relationship: [businessunit business_unit_msevtmgt_sponsorship](businessunit.md#BKMK_business_unit_msevtmgt_sponsorship)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sponsorship_createdby"></a> lk_msevtmgt_sponsorship_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_sponsorship_createdby](systemuser.md#BKMK_lk_msevtmgt_sponsorship_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sponsorship_createdonbehalfby"></a> lk_msevtmgt_sponsorship_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_sponsorship_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_sponsorship_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sponsorship_modifiedby"></a> lk_msevtmgt_sponsorship_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_sponsorship_modifiedby](systemuser.md#BKMK_lk_msevtmgt_sponsorship_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sponsorship_modifiedonbehalfby"></a> lk_msevtmgt_sponsorship_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_sponsorship_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_sponsorship_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_account_msevtmgt_sponsorship_Sponsor"></a> msevtmgt_account_msevtmgt_sponsorship_Sponsor

One-To-Many Relationship: [account msevtmgt_account_msevtmgt_sponsorship_Sponsor](account.md#BKMK_msevtmgt_account_msevtmgt_sponsorship_Sponsor)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msevtmgt_sponsor`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Sponsor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_Event_msevtmgt_Sponsorship"></a> msevtmgt_Event_msevtmgt_Sponsorship

One-To-Many Relationship: [msevtmgt_event msevtmgt_Event_msevtmgt_Sponsorship](msevtmgt_event.md#BKMK_msevtmgt_Event_msevtmgt_Sponsorship)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Event`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship"></a> msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship

One-To-Many Relationship: [transactioncurrency msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship](transactioncurrency.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_sponsorship"></a> owner_msevtmgt_sponsorship

One-To-Many Relationship: [owner owner_msevtmgt_sponsorship](owner.md#BKMK_owner_msevtmgt_sponsorship)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_sponsorship"></a> team_msevtmgt_sponsorship

One-To-Many Relationship: [team team_msevtmgt_sponsorship](team.md#BKMK_team_msevtmgt_sponsorship)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Sponsorship"></a> TransactionCurrency_msevtmgt_Sponsorship

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msevtmgt_Sponsorship](transactioncurrency.md#BKMK_TransactionCurrency_msevtmgt_Sponsorship)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_sponsorship"></a> user_msevtmgt_sponsorship

One-To-Many Relationship: [systemuser user_msevtmgt_sponsorship](systemuser.md#BKMK_user_msevtmgt_sponsorship)

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

- [msevtmgt_sponsorablearticle_sponsorship](#BKMK_msevtmgt_sponsorablearticle_sponsorship)
- [msevtmgt_sponsorship_ActivityPointers](#BKMK_msevtmgt_sponsorship_ActivityPointers)
- [msevtmgt_sponsorship_adx_alertsubscriptions](#BKMK_msevtmgt_sponsorship_adx_alertsubscriptions)
- [msevtmgt_sponsorship_adx_inviteredemptions](#BKMK_msevtmgt_sponsorship_adx_inviteredemptions)
- [msevtmgt_sponsorship_adx_portalcomments](#BKMK_msevtmgt_sponsorship_adx_portalcomments)
- [msevtmgt_sponsorship_Annotations](#BKMK_msevtmgt_sponsorship_Annotations)
- [msevtmgt_sponsorship_Appointments](#BKMK_msevtmgt_sponsorship_Appointments)
- [msevtmgt_sponsorship_AsyncOperations](#BKMK_msevtmgt_sponsorship_AsyncOperations)
- [msevtmgt_sponsorship_BulkDeleteFailures](#BKMK_msevtmgt_sponsorship_BulkDeleteFailures)
- [msevtmgt_sponsorship_chats](#BKMK_msevtmgt_sponsorship_chats)
- [msevtmgt_sponsorship_Emails](#BKMK_msevtmgt_sponsorship_Emails)
- [msevtmgt_sponsorship_Faxes](#BKMK_msevtmgt_sponsorship_Faxes)
- [msevtmgt_sponsorship_Letters](#BKMK_msevtmgt_sponsorship_Letters)
- [msevtmgt_sponsorship_li_inmails](#BKMK_msevtmgt_sponsorship_li_inmails)
- [msevtmgt_sponsorship_li_messages](#BKMK_msevtmgt_sponsorship_li_messages)
- [msevtmgt_sponsorship_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_sponsorship_li_pointdrivepresentationvieweds)
- [msevtmgt_sponsorship_MailboxTrackingFolders](#BKMK_msevtmgt_sponsorship_MailboxTrackingFolders)
- [msevtmgt_sponsorship_msdyn_bookingalerts](#BKMK_msevtmgt_sponsorship_msdyn_bookingalerts)
- [msevtmgt_sponsorship_msdyn_copilottranscripts](#BKMK_msevtmgt_sponsorship_msdyn_copilottranscripts)
- [msevtmgt_sponsorship_msdyn_ocliveworkitems](#BKMK_msevtmgt_sponsorship_msdyn_ocliveworkitems)
- [msevtmgt_sponsorship_msdyn_ocoutboundmessages](#BKMK_msevtmgt_sponsorship_msdyn_ocoutboundmessages)
- [msevtmgt_sponsorship_msdyn_ocsessions](#BKMK_msevtmgt_sponsorship_msdyn_ocsessions)
- [msevtmgt_sponsorship_msdyn_ocvoicemails](#BKMK_msevtmgt_sponsorship_msdyn_ocvoicemails)
- [msevtmgt_sponsorship_msfp_alerts](#BKMK_msevtmgt_sponsorship_msfp_alerts)
- [msevtmgt_sponsorship_msfp_surveyinvites](#BKMK_msevtmgt_sponsorship_msfp_surveyinvites)
- [msevtmgt_sponsorship_msfp_surveyresponses](#BKMK_msevtmgt_sponsorship_msfp_surveyresponses)
- [msevtmgt_sponsorship_PhoneCalls](#BKMK_msevtmgt_sponsorship_PhoneCalls)
- [msevtmgt_sponsorship_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_sponsorship_PrincipalObjectAttributeAccesses)
- [msevtmgt_sponsorship_ProcessSession](#BKMK_msevtmgt_sponsorship_ProcessSession)
- [msevtmgt_sponsorship_RecurringAppointmentMasters](#BKMK_msevtmgt_sponsorship_RecurringAppointmentMasters)
- [msevtmgt_sponsorship_ServiceAppointments](#BKMK_msevtmgt_sponsorship_ServiceAppointments)
- [msevtmgt_sponsorship_SocialActivities](#BKMK_msevtmgt_sponsorship_SocialActivities)
- [msevtmgt_sponsorship_SyncErrors](#BKMK_msevtmgt_sponsorship_SyncErrors)
- [msevtmgt_sponsorship_Tasks](#BKMK_msevtmgt_sponsorship_Tasks)

### <a name="BKMK_msevtmgt_sponsorablearticle_sponsorship"></a> msevtmgt_sponsorablearticle_sponsorship

Many-To-One Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_sponsorship](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_sponsorship)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorablearticle`|
|ReferencingAttribute|`msevtmgt_eventsponsorship`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorablearticle_sponsorship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_ActivityPointers"></a> msevtmgt_sponsorship_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_sponsorship_ActivityPointers](activitypointer.md#BKMK_msevtmgt_sponsorship_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_adx_alertsubscriptions"></a> msevtmgt_sponsorship_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_sponsorship_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_sponsorship_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_adx_inviteredemptions"></a> msevtmgt_sponsorship_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_sponsorship_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_sponsorship_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_adx_portalcomments"></a> msevtmgt_sponsorship_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_sponsorship_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_sponsorship_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_Annotations"></a> msevtmgt_sponsorship_Annotations

Many-To-One Relationship: [annotation msevtmgt_sponsorship_Annotations](annotation.md#BKMK_msevtmgt_sponsorship_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_Appointments"></a> msevtmgt_sponsorship_Appointments

Many-To-One Relationship: [appointment msevtmgt_sponsorship_Appointments](appointment.md#BKMK_msevtmgt_sponsorship_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_AsyncOperations"></a> msevtmgt_sponsorship_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_sponsorship_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_sponsorship_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_BulkDeleteFailures"></a> msevtmgt_sponsorship_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_sponsorship_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_sponsorship_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_chats"></a> msevtmgt_sponsorship_chats

Many-To-One Relationship: [chat msevtmgt_sponsorship_chats](chat.md#BKMK_msevtmgt_sponsorship_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_Emails"></a> msevtmgt_sponsorship_Emails

Many-To-One Relationship: [email msevtmgt_sponsorship_Emails](email.md#BKMK_msevtmgt_sponsorship_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_Faxes"></a> msevtmgt_sponsorship_Faxes

Many-To-One Relationship: [fax msevtmgt_sponsorship_Faxes](fax.md#BKMK_msevtmgt_sponsorship_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_Letters"></a> msevtmgt_sponsorship_Letters

Many-To-One Relationship: [letter msevtmgt_sponsorship_Letters](letter.md#BKMK_msevtmgt_sponsorship_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_li_inmails"></a> msevtmgt_sponsorship_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_sponsorship_li_inmails](li_inmail.md#BKMK_msevtmgt_sponsorship_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_li_messages"></a> msevtmgt_sponsorship_li_messages

Many-To-One Relationship: [li_message msevtmgt_sponsorship_li_messages](li_message.md#BKMK_msevtmgt_sponsorship_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_li_pointdrivepresentationvieweds"></a> msevtmgt_sponsorship_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_sponsorship_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_sponsorship_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_MailboxTrackingFolders"></a> msevtmgt_sponsorship_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_sponsorship_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_sponsorship_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_msdyn_bookingalerts"></a> msevtmgt_sponsorship_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_sponsorship_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_sponsorship_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_msdyn_copilottranscripts"></a> msevtmgt_sponsorship_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_sponsorship_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_sponsorship_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_msdyn_ocliveworkitems"></a> msevtmgt_sponsorship_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_sponsorship_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_sponsorship_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_msdyn_ocoutboundmessages"></a> msevtmgt_sponsorship_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_sponsorship_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_sponsorship_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_msdyn_ocsessions"></a> msevtmgt_sponsorship_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_sponsorship_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_sponsorship_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_msdyn_ocvoicemails"></a> msevtmgt_sponsorship_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_sponsorship_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_sponsorship_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_msfp_alerts"></a> msevtmgt_sponsorship_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_sponsorship_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_sponsorship_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_msfp_surveyinvites"></a> msevtmgt_sponsorship_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_sponsorship_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_sponsorship_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_msfp_surveyresponses"></a> msevtmgt_sponsorship_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_sponsorship_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_sponsorship_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_PhoneCalls"></a> msevtmgt_sponsorship_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_sponsorship_PhoneCalls](phonecall.md#BKMK_msevtmgt_sponsorship_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_PrincipalObjectAttributeAccesses"></a> msevtmgt_sponsorship_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_sponsorship_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_sponsorship_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_ProcessSession"></a> msevtmgt_sponsorship_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_sponsorship_ProcessSession](processsession.md#BKMK_msevtmgt_sponsorship_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_RecurringAppointmentMasters"></a> msevtmgt_sponsorship_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_sponsorship_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_sponsorship_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_ServiceAppointments"></a> msevtmgt_sponsorship_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_sponsorship_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_sponsorship_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_SocialActivities"></a> msevtmgt_sponsorship_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_sponsorship_SocialActivities](socialactivity.md#BKMK_msevtmgt_sponsorship_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_SyncErrors"></a> msevtmgt_sponsorship_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_sponsorship_SyncErrors](syncerror.md#BKMK_msevtmgt_sponsorship_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sponsorship_Tasks"></a> msevtmgt_sponsorship_Tasks

Many-To-One Relationship: [task msevtmgt_sponsorship_Tasks](task.md#BKMK_msevtmgt_sponsorship_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sponsorship_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

