---
title: "Attendee Pass (msevtmgt_AttendeePass) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Attendee Pass (msevtmgt_AttendeePass) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Attendee Pass (msevtmgt_AttendeePass) table/entity reference



## Messages

The following table lists the messages for the Attendee Pass (msevtmgt_AttendeePass) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_attendeepasses(*msevtmgt_attendeepassid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_attendeepasses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_attendeepasses(*msevtmgt_attendeepassid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_attendeepasses(*msevtmgt_attendeepassid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_attendeepasses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_attendeepasses(*msevtmgt_attendeepassid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_attendeepasses(*msevtmgt_attendeepassid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_attendeepasses(*msevtmgt_attendeepassid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Attendee Pass (msevtmgt_AttendeePass) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Attendee Pass (msevtmgt_AttendeePass) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Attendee Pass** |
| **DisplayCollectionName** | **Attendee Passes** |
| **SchemaName** | `msevtmgt_AttendeePass` |
| **CollectionSchemaName** | `msevtmgt_AttendeePasses` |
| **EntitySetName** | `msevtmgt_attendeepasses`|
| **LogicalName** | `msevtmgt_attendeepass` |
| **LogicalCollectionName** | `msevtmgt_attendeepasses` |
| **PrimaryIdAttribute** | `msevtmgt_attendeepassid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_AttendeePassId](#BKMK_msevtmgt_AttendeePassId)
- [msevtmgt_contact](#BKMK_msevtmgt_contact)
- [msevtmgt_EventId](#BKMK_msevtmgt_EventId)
- [msevtmgt_EventRegistrationId](#BKMK_msevtmgt_EventRegistrationId)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_pass](#BKMK_msevtmgt_pass)
- [msevtmgt_PassPrice](#BKMK_msevtmgt_PassPrice)
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

### <a name="BKMK_msevtmgt_AttendeePassId"></a> msevtmgt_AttendeePassId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Attendee pass**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_attendeepassid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_contact"></a> msevtmgt_contact

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_contact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_EventId"></a> msevtmgt_EventId

|Property|Value|
|---|---|
|Description|**Unique identifier for the event associated with the attendee pass**|
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_EventRegistrationId"></a> msevtmgt_EventRegistrationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the event registration associated with the attendee pass**|
|DisplayName|**Event registration ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventregistrationid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_eventregistration|

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

### <a name="BKMK_msevtmgt_pass"></a> msevtmgt_pass

|Property|Value|
|---|---|
|Description|**Unique identifier for the pass associated with the attendee pass**|
|DisplayName|**Pass**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_pass`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_pass|

### <a name="BKMK_msevtmgt_PassPrice"></a> msevtmgt_PassPrice

|Property|Value|
|---|---|
|Description||
|DisplayName|**Pass price**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_passprice`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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
|Description|**Status of the attendee pass**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_attendeepass_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the attendee pass**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_attendeepass_statuscode`|

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
- [msevtmgt_passprice_Base](#BKMK_msevtmgt_passprice_Base)
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
|DisplayName|**Purchased on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|ApplicationRequired|
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

### <a name="BKMK_msevtmgt_passprice_Base"></a> msevtmgt_passprice_Base

|Property|Value|
|---|---|
|Description|**Value of the pass price (in the base currency)**|
|DisplayName|**Pass price (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_passprice_base`|
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

- [business_unit_msevtmgt_attendeepass](#BKMK_business_unit_msevtmgt_attendeepass)
- [lk_msevtmgt_attendeepass_createdby](#BKMK_lk_msevtmgt_attendeepass_createdby)
- [lk_msevtmgt_attendeepass_createdonbehalfby](#BKMK_lk_msevtmgt_attendeepass_createdonbehalfby)
- [lk_msevtmgt_attendeepass_modifiedby](#BKMK_lk_msevtmgt_attendeepass_modifiedby)
- [lk_msevtmgt_attendeepass_modifiedonbehalfby](#BKMK_lk_msevtmgt_attendeepass_modifiedonbehalfby)
- [msevtmgt_contact_msevtmgt_attendeepass_contact](#BKMK_msevtmgt_contact_msevtmgt_attendeepass_contact)
- [msevtmgt_Event_AttendeePass](#BKMK_msevtmgt_Event_AttendeePass)
- [msevtmgt_EventRegistration_AttendeePass](#BKMK_msevtmgt_EventRegistration_AttendeePass)
- [msevtmgt_pass_msevtmgt_attendeepass_Pass](#BKMK_msevtmgt_pass_msevtmgt_attendeepass_Pass)
- [new_TransactionCurrency_msevtmgt_attendeepass](#BKMK_new_TransactionCurrency_msevtmgt_attendeepass)
- [owner_msevtmgt_attendeepass](#BKMK_owner_msevtmgt_attendeepass)
- [team_msevtmgt_attendeepass](#BKMK_team_msevtmgt_attendeepass)
- [TransactionCurrency_msevtmgt_AttendeePass](#BKMK_TransactionCurrency_msevtmgt_AttendeePass)
- [user_msevtmgt_attendeepass](#BKMK_user_msevtmgt_attendeepass)

### <a name="BKMK_business_unit_msevtmgt_attendeepass"></a> business_unit_msevtmgt_attendeepass

One-To-Many Relationship: [businessunit business_unit_msevtmgt_attendeepass](businessunit.md#BKMK_business_unit_msevtmgt_attendeepass)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_attendeepass_createdby"></a> lk_msevtmgt_attendeepass_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_attendeepass_createdby](systemuser.md#BKMK_lk_msevtmgt_attendeepass_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_attendeepass_createdonbehalfby"></a> lk_msevtmgt_attendeepass_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_attendeepass_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_attendeepass_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_attendeepass_modifiedby"></a> lk_msevtmgt_attendeepass_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_attendeepass_modifiedby](systemuser.md#BKMK_lk_msevtmgt_attendeepass_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_attendeepass_modifiedonbehalfby"></a> lk_msevtmgt_attendeepass_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_attendeepass_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_attendeepass_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_attendeepass_contact"></a> msevtmgt_contact_msevtmgt_attendeepass_contact

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_attendeepass_contact](contact.md#BKMK_msevtmgt_contact_msevtmgt_attendeepass_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_Event_AttendeePass"></a> msevtmgt_Event_AttendeePass

One-To-Many Relationship: [msevtmgt_event msevtmgt_Event_AttendeePass](msevtmgt_event.md#BKMK_msevtmgt_Event_AttendeePass)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_EventId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_EventRegistration_AttendeePass"></a> msevtmgt_EventRegistration_AttendeePass

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_EventRegistration_AttendeePass](msevtmgt_eventregistration.md#BKMK_msevtmgt_EventRegistration_AttendeePass)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`msevtmgt_eventregistrationid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_EventRegistrationId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_pass_msevtmgt_attendeepass_Pass"></a> msevtmgt_pass_msevtmgt_attendeepass_Pass

One-To-Many Relationship: [msevtmgt_pass msevtmgt_pass_msevtmgt_attendeepass_Pass](msevtmgt_pass.md#BKMK_msevtmgt_pass_msevtmgt_attendeepass_Pass)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_pass`|
|ReferencedAttribute|`msevtmgt_passid`|
|ReferencingAttribute|`msevtmgt_pass`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_pass`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_new_TransactionCurrency_msevtmgt_attendeepass"></a> new_TransactionCurrency_msevtmgt_attendeepass

One-To-Many Relationship: [transactioncurrency new_TransactionCurrency_msevtmgt_attendeepass](transactioncurrency.md#BKMK_new_TransactionCurrency_msevtmgt_attendeepass)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_attendeepass"></a> owner_msevtmgt_attendeepass

One-To-Many Relationship: [owner owner_msevtmgt_attendeepass](owner.md#BKMK_owner_msevtmgt_attendeepass)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_attendeepass"></a> team_msevtmgt_attendeepass

One-To-Many Relationship: [team team_msevtmgt_attendeepass](team.md#BKMK_team_msevtmgt_attendeepass)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msevtmgt_AttendeePass"></a> TransactionCurrency_msevtmgt_AttendeePass

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msevtmgt_AttendeePass](transactioncurrency.md#BKMK_TransactionCurrency_msevtmgt_AttendeePass)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_attendeepass"></a> user_msevtmgt_attendeepass

One-To-Many Relationship: [systemuser user_msevtmgt_attendeepass](systemuser.md#BKMK_user_msevtmgt_attendeepass)

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

- [msevtmgt_attendeepass_AsyncOperations](#BKMK_msevtmgt_attendeepass_AsyncOperations)
- [msevtmgt_attendeepass_BulkDeleteFailures](#BKMK_msevtmgt_attendeepass_BulkDeleteFailures)
- [msevtmgt_attendeepass_MailboxTrackingFolders](#BKMK_msevtmgt_attendeepass_MailboxTrackingFolders)
- [msevtmgt_attendeepass_msevtmgt_checkin](#BKMK_msevtmgt_attendeepass_msevtmgt_checkin)
- [msevtmgt_attendeepass_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_attendeepass_PrincipalObjectAttributeAccesses)
- [msevtmgt_attendeepass_ProcessSession](#BKMK_msevtmgt_attendeepass_ProcessSession)
- [msevtmgt_attendeepass_SyncErrors](#BKMK_msevtmgt_attendeepass_SyncErrors)
- [msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch](#BKMK_msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch)

### <a name="BKMK_msevtmgt_attendeepass_AsyncOperations"></a> msevtmgt_attendeepass_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_attendeepass_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_attendeepass_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_attendeepass_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_attendeepass_BulkDeleteFailures"></a> msevtmgt_attendeepass_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_attendeepass_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_attendeepass_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_attendeepass_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_attendeepass_MailboxTrackingFolders"></a> msevtmgt_attendeepass_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_attendeepass_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_attendeepass_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_attendeepass_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_attendeepass_msevtmgt_checkin"></a> msevtmgt_attendeepass_msevtmgt_checkin

Many-To-One Relationship: [msevtmgt_checkin msevtmgt_attendeepass_msevtmgt_checkin](msevtmgt_checkin.md#BKMK_msevtmgt_attendeepass_msevtmgt_checkin)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_checkin`|
|ReferencingAttribute|`msevtmgt_purchasedpassesid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_attendeepass_msevtmgt_checkin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_attendeepass_PrincipalObjectAttributeAccesses"></a> msevtmgt_attendeepass_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_attendeepass_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_attendeepass_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_attendeepass_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_attendeepass_ProcessSession"></a> msevtmgt_attendeepass_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_attendeepass_ProcessSession](processsession.md#BKMK_msevtmgt_attendeepass_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_attendeepass_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_attendeepass_SyncErrors"></a> msevtmgt_attendeepass_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_attendeepass_SyncErrors](syncerror.md#BKMK_msevtmgt_attendeepass_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_attendeepass_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch"></a> msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch

Many-To-One Relationship: [msevtmgt_eventpurchasepass msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchasepass`|
|ReferencingAttribute|`msevtmgt_attendeepassid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msevtmgt_session_msevtmgt_attendeepass"></a> msevtmgt_session_msevtmgt_attendeepass

See [msevtmgt_session msevtmgt_session_msevtmgt_attendeepass Many-To-Many Relationship](msevtmgt_session.md#BKMK_msevtmgt_session_msevtmgt_attendeepass)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_session_msevtmgt_attendeepass`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_session_msevtmgt_attendeepass`|
|IntersectAttribute|`msevtmgt_attendeepassid`|
|NavigationPropertyName|`msevtmgt_session_msevtmgt_attendeepass`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

