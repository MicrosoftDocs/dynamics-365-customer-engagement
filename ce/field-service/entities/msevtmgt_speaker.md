---
title: "Speaker (msevtmgt_Speaker) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Speaker (msevtmgt_Speaker) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Speaker (msevtmgt_Speaker) table/entity reference

Biographies of individual speakers appearing at an event

## Messages

The following table lists the messages for the Speaker (msevtmgt_Speaker) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_speakers(*msevtmgt_speakerid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_speakers<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_speakers(*msevtmgt_speakerid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_speakers(*msevtmgt_speakerid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_speakers<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_speakers(*msevtmgt_speakerid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_speakers(*msevtmgt_speakerid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_speakers(*msevtmgt_speakerid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Speaker (msevtmgt_Speaker) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Speaker (msevtmgt_Speaker) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Speaker** |
| **DisplayCollectionName** | **Speakers** |
| **SchemaName** | `msevtmgt_Speaker` |
| **CollectionSchemaName** | `msevtmgt_Speakers` |
| **EntitySetName** | `msevtmgt_speakers`|
| **LogicalName** | `msevtmgt_speaker` |
| **LogicalCollectionName** | `msevtmgt_speakers` |
| **PrimaryIdAttribute** | `msevtmgt_speakerid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_About](#BKMK_msevtmgt_About)
- [msevtmgt_Accomplishments](#BKMK_msevtmgt_Accomplishments)
- [msevtmgt_Blog](#BKMK_msevtmgt_Blog)
- [msevtmgt_Contact](#BKMK_msevtmgt_Contact)
- [msevtmgt_Email](#BKMK_msevtmgt_Email)
- [msevtmgt_EventId](#BKMK_msevtmgt_EventId)
- [msevtmgt_EventRegistration](#BKMK_msevtmgt_EventRegistration)
- [msevtmgt_LinkedIn](#BKMK_msevtmgt_LinkedIn)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_Publications](#BKMK_msevtmgt_Publications)
- [msevtmgt_SpeakerCost](#BKMK_msevtmgt_SpeakerCost)
- [msevtmgt_SpeakerId](#BKMK_msevtmgt_SpeakerId)
- [msevtmgt_Title](#BKMK_msevtmgt_Title)
- [msevtmgt_TransactionCurrencyId](#BKMK_msevtmgt_TransactionCurrencyId)
- [msevtmgt_Twitter](#BKMK_msevtmgt_Twitter)
- [msevtmgt_Type](#BKMK_msevtmgt_Type)
- [msevtmgt_Website](#BKMK_msevtmgt_Website)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [traversedpath](#BKMK_traversedpath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image**|
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

### <a name="BKMK_msevtmgt_About"></a> msevtmgt_About

|Property|Value|
|---|---|
|Description|**About**|
|DisplayName|**About**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_about`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_Accomplishments"></a> msevtmgt_Accomplishments

|Property|Value|
|---|---|
|Description|**Accomplishments**|
|DisplayName|**Accomplishments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_accomplishments`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_Blog"></a> msevtmgt_Blog

|Property|Value|
|---|---|
|Description|**Blog**|
|DisplayName|**Blog**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_blog`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Contact"></a> msevtmgt_Contact

|Property|Value|
|---|---|
|Description|**Lookup field for contact**|
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_contact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_Email"></a> msevtmgt_Email

|Property|Value|
|---|---|
|Description|**Speaker email**|
|DisplayName|**Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_email`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_EventId"></a> msevtmgt_EventId

|Property|Value|
|---|---|
|Description|**Unique identifier for the event associated with the speaker**|
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_EventRegistration"></a> msevtmgt_EventRegistration

|Property|Value|
|---|---|
|Description|**Lookup field for event registration**|
|DisplayName|**Event registration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventregistration`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_eventregistration|

### <a name="BKMK_msevtmgt_LinkedIn"></a> msevtmgt_LinkedIn

|Property|Value|
|---|---|
|Description|**LinkedIn**|
|DisplayName|**LinkedIn**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_linkedin`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msevtmgt_Publications"></a> msevtmgt_Publications

|Property|Value|
|---|---|
|Description|**Publications**|
|DisplayName|**Publications**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publications`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_SpeakerCost"></a> msevtmgt_SpeakerCost

|Property|Value|
|---|---|
|Description|**Value of the speaker cost.**|
|DisplayName|**Speaker cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_speakercost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_SpeakerId"></a> msevtmgt_SpeakerId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Speaker**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_speakerid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_Title"></a> msevtmgt_Title

|Property|Value|
|---|---|
|Description|**Title**|
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_title`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msevtmgt_Twitter"></a> msevtmgt_Twitter

|Property|Value|
|---|---|
|Description|**Twitter**|
|DisplayName|**Twitter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_twitter`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Type"></a> msevtmgt_Type

|Property|Value|
|---|---|
|Description|**Speaker type**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_type`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_speakertype`|

#### msevtmgt_Type Choices/Options

|Value|Label|
|---|---|
|100000000|**Internal speaker**|
|100000001|**External speaker**|

### <a name="BKMK_msevtmgt_Website"></a> msevtmgt_Website

|Property|Value|
|---|---|
|Description|**Website URL**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_website`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Contains the ID of the process associated with the entity**|
|DisplayName|**Process ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Contains the ID of the stage where the entity is located**|
|DisplayName|**Stage ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the event speaker**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_speaker_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the event speaker**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_speaker_statuscode`|

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

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**A comma-separated list of string values representing the unique IDs of stages in a business-process flow instance, in the order that they occur.**|
|DisplayName|**Traversed path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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
- [msevtmgt_speakercost_Base](#BKMK_msevtmgt_speakercost_Base)
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

### <a name="BKMK_msevtmgt_speakercost_Base"></a> msevtmgt_speakercost_Base

|Property|Value|
|---|---|
|Description|**Value of the speaker cost (in the base currency)**|
|DisplayName|**Speaker cost (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_speakercost_base`|
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

- [business_unit_msevtmgt_speaker](#BKMK_business_unit_msevtmgt_speaker)
- [lk_msevtmgt_speaker_createdby](#BKMK_lk_msevtmgt_speaker_createdby)
- [lk_msevtmgt_speaker_createdonbehalfby](#BKMK_lk_msevtmgt_speaker_createdonbehalfby)
- [lk_msevtmgt_speaker_modifiedby](#BKMK_lk_msevtmgt_speaker_modifiedby)
- [lk_msevtmgt_speaker_modifiedonbehalfby](#BKMK_lk_msevtmgt_speaker_modifiedonbehalfby)
- [msevtmgt_contact_msevtmgt_speaker_Contact](#BKMK_msevtmgt_contact_msevtmgt_speaker_Contact)
- [msevtmgt_Event_Speaker](#BKMK_msevtmgt_Event_Speaker)
- [msevtmgt_EventRegistration_msevtmgt_Speaker](#BKMK_msevtmgt_EventRegistration_msevtmgt_Speaker)
- [msevtmgt_TransactionCurrencyId_msevtmgt_Speaker](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Speaker)
- [owner_msevtmgt_speaker](#BKMK_owner_msevtmgt_speaker)
- [processstage_msevtmgt_Speaker](#BKMK_processstage_msevtmgt_Speaker)
- [team_msevtmgt_speaker](#BKMK_team_msevtmgt_speaker)
- [TransactionCurrency_msevtmgt_Speaker](#BKMK_TransactionCurrency_msevtmgt_Speaker)
- [user_msevtmgt_speaker](#BKMK_user_msevtmgt_speaker)

### <a name="BKMK_business_unit_msevtmgt_speaker"></a> business_unit_msevtmgt_speaker

One-To-Many Relationship: [businessunit business_unit_msevtmgt_speaker](businessunit.md#BKMK_business_unit_msevtmgt_speaker)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_speaker_createdby"></a> lk_msevtmgt_speaker_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_speaker_createdby](systemuser.md#BKMK_lk_msevtmgt_speaker_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_speaker_createdonbehalfby"></a> lk_msevtmgt_speaker_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_speaker_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_speaker_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_speaker_modifiedby"></a> lk_msevtmgt_speaker_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_speaker_modifiedby](systemuser.md#BKMK_lk_msevtmgt_speaker_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_speaker_modifiedonbehalfby"></a> lk_msevtmgt_speaker_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_speaker_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_speaker_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_speaker_Contact"></a> msevtmgt_contact_msevtmgt_speaker_Contact

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_speaker_Contact](contact.md#BKMK_msevtmgt_contact_msevtmgt_speaker_Contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_Event_Speaker"></a> msevtmgt_Event_Speaker

One-To-Many Relationship: [msevtmgt_event msevtmgt_Event_Speaker](msevtmgt_event.md#BKMK_msevtmgt_Event_Speaker)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_EventId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_EventRegistration_msevtmgt_Speaker"></a> msevtmgt_EventRegistration_msevtmgt_Speaker

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_EventRegistration_msevtmgt_Speaker](msevtmgt_eventregistration.md#BKMK_msevtmgt_EventRegistration_msevtmgt_Speaker)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`msevtmgt_eventregistration`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_EventRegistration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Speaker"></a> msevtmgt_TransactionCurrencyId_msevtmgt_Speaker

One-To-Many Relationship: [transactioncurrency msevtmgt_TransactionCurrencyId_msevtmgt_Speaker](transactioncurrency.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Speaker)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_speaker"></a> owner_msevtmgt_speaker

One-To-Many Relationship: [owner owner_msevtmgt_speaker](owner.md#BKMK_owner_msevtmgt_speaker)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_msevtmgt_Speaker"></a> processstage_msevtmgt_Speaker

One-To-Many Relationship: [processstage processstage_msevtmgt_Speaker](processstage.md#BKMK_processstage_msevtmgt_Speaker)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_speaker"></a> team_msevtmgt_speaker

One-To-Many Relationship: [team team_msevtmgt_speaker](team.md#BKMK_team_msevtmgt_speaker)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Speaker"></a> TransactionCurrency_msevtmgt_Speaker

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msevtmgt_Speaker](transactioncurrency.md#BKMK_TransactionCurrency_msevtmgt_Speaker)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_speaker"></a> user_msevtmgt_speaker

One-To-Many Relationship: [systemuser user_msevtmgt_speaker](systemuser.md#BKMK_user_msevtmgt_speaker)

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

- [msevtmgt_msevtmgt_speaker_msevtmgt_speakerengagement_Speaker](#BKMK_msevtmgt_msevtmgt_speaker_msevtmgt_speakerengagement_Speaker)
- [msevtmgt_speaker_ActivityPointers](#BKMK_msevtmgt_speaker_ActivityPointers)
- [msevtmgt_speaker_adx_alertsubscriptions](#BKMK_msevtmgt_speaker_adx_alertsubscriptions)
- [msevtmgt_speaker_adx_inviteredemptions](#BKMK_msevtmgt_speaker_adx_inviteredemptions)
- [msevtmgt_speaker_adx_portalcomments](#BKMK_msevtmgt_speaker_adx_portalcomments)
- [msevtmgt_speaker_Annotations](#BKMK_msevtmgt_speaker_Annotations)
- [msevtmgt_speaker_Appointments](#BKMK_msevtmgt_speaker_Appointments)
- [msevtmgt_speaker_AsyncOperations](#BKMK_msevtmgt_speaker_AsyncOperations)
- [msevtmgt_speaker_BulkDeleteFailures](#BKMK_msevtmgt_speaker_BulkDeleteFailures)
- [msevtmgt_speaker_chats](#BKMK_msevtmgt_speaker_chats)
- [msevtmgt_speaker_Emails](#BKMK_msevtmgt_speaker_Emails)
- [msevtmgt_speaker_Faxes](#BKMK_msevtmgt_speaker_Faxes)
- [msevtmgt_speaker_hotelroomreservation](#BKMK_msevtmgt_speaker_hotelroomreservation)
- [msevtmgt_speaker_Letters](#BKMK_msevtmgt_speaker_Letters)
- [msevtmgt_speaker_li_inmails](#BKMK_msevtmgt_speaker_li_inmails)
- [msevtmgt_speaker_li_messages](#BKMK_msevtmgt_speaker_li_messages)
- [msevtmgt_speaker_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_speaker_li_pointdrivepresentationvieweds)
- [msevtmgt_speaker_MailboxTrackingFolders](#BKMK_msevtmgt_speaker_MailboxTrackingFolders)
- [msevtmgt_speaker_msdyn_bookingalerts](#BKMK_msevtmgt_speaker_msdyn_bookingalerts)
- [msevtmgt_speaker_msdyn_copilottranscripts](#BKMK_msevtmgt_speaker_msdyn_copilottranscripts)
- [msevtmgt_speaker_msdyn_ocliveworkitems](#BKMK_msevtmgt_speaker_msdyn_ocliveworkitems)
- [msevtmgt_speaker_msdyn_ocoutboundmessages](#BKMK_msevtmgt_speaker_msdyn_ocoutboundmessages)
- [msevtmgt_speaker_msdyn_ocsessions](#BKMK_msevtmgt_speaker_msdyn_ocsessions)
- [msevtmgt_speaker_msdyn_ocvoicemails](#BKMK_msevtmgt_speaker_msdyn_ocvoicemails)
- [msevtmgt_speaker_msevtmgt_Session](#BKMK_msevtmgt_speaker_msevtmgt_Session)
- [msevtmgt_speaker_msfp_alerts](#BKMK_msevtmgt_speaker_msfp_alerts)
- [msevtmgt_speaker_msfp_surveyinvites](#BKMK_msevtmgt_speaker_msfp_surveyinvites)
- [msevtmgt_speaker_msfp_surveyresponses](#BKMK_msevtmgt_speaker_msfp_surveyresponses)
- [msevtmgt_speaker_PhoneCalls](#BKMK_msevtmgt_speaker_PhoneCalls)
- [msevtmgt_speaker_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_speaker_PrincipalObjectAttributeAccesses)
- [msevtmgt_speaker_ProcessSession](#BKMK_msevtmgt_speaker_ProcessSession)
- [msevtmgt_speaker_RecurringAppointmentMasters](#BKMK_msevtmgt_speaker_RecurringAppointmentMasters)
- [msevtmgt_speaker_ServiceAppointments](#BKMK_msevtmgt_speaker_ServiceAppointments)
- [msevtmgt_speaker_SocialActivities](#BKMK_msevtmgt_speaker_SocialActivities)
- [msevtmgt_speaker_SyncErrors](#BKMK_msevtmgt_speaker_SyncErrors)
- [msevtmgt_speaker_Tasks](#BKMK_msevtmgt_speaker_Tasks)

### <a name="BKMK_msevtmgt_msevtmgt_speaker_msevtmgt_speakerengagement_Speaker"></a> msevtmgt_msevtmgt_speaker_msevtmgt_speakerengagement_Speaker

Many-To-One Relationship: [msevtmgt_speakerengagement msevtmgt_msevtmgt_speaker_msevtmgt_speakerengagement_Speaker](msevtmgt_speakerengagement.md#BKMK_msevtmgt_msevtmgt_speaker_msevtmgt_speakerengagement_Speaker)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speakerengagement`|
|ReferencingAttribute|`msevtmgt_speaker`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_speaker_msevtmgt_speakerengagement_Speaker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_ActivityPointers"></a> msevtmgt_speaker_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_speaker_ActivityPointers](activitypointer.md#BKMK_msevtmgt_speaker_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_adx_alertsubscriptions"></a> msevtmgt_speaker_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_speaker_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_speaker_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_adx_inviteredemptions"></a> msevtmgt_speaker_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_speaker_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_speaker_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_adx_portalcomments"></a> msevtmgt_speaker_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_speaker_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_speaker_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_Annotations"></a> msevtmgt_speaker_Annotations

Many-To-One Relationship: [annotation msevtmgt_speaker_Annotations](annotation.md#BKMK_msevtmgt_speaker_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_Appointments"></a> msevtmgt_speaker_Appointments

Many-To-One Relationship: [appointment msevtmgt_speaker_Appointments](appointment.md#BKMK_msevtmgt_speaker_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_AsyncOperations"></a> msevtmgt_speaker_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_speaker_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_speaker_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_BulkDeleteFailures"></a> msevtmgt_speaker_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_speaker_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_speaker_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_chats"></a> msevtmgt_speaker_chats

Many-To-One Relationship: [chat msevtmgt_speaker_chats](chat.md#BKMK_msevtmgt_speaker_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_Emails"></a> msevtmgt_speaker_Emails

Many-To-One Relationship: [email msevtmgt_speaker_Emails](email.md#BKMK_msevtmgt_speaker_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_Faxes"></a> msevtmgt_speaker_Faxes

Many-To-One Relationship: [fax msevtmgt_speaker_Faxes](fax.md#BKMK_msevtmgt_speaker_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_hotelroomreservation"></a> msevtmgt_speaker_hotelroomreservation

Many-To-One Relationship: [msevtmgt_hotelroomreservation msevtmgt_speaker_hotelroomreservation](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_speaker_hotelroomreservation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomreservation`|
|ReferencingAttribute|`msevtmgt_speakerid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_hotelroomreservation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_Letters"></a> msevtmgt_speaker_Letters

Many-To-One Relationship: [letter msevtmgt_speaker_Letters](letter.md#BKMK_msevtmgt_speaker_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_li_inmails"></a> msevtmgt_speaker_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_speaker_li_inmails](li_inmail.md#BKMK_msevtmgt_speaker_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_li_messages"></a> msevtmgt_speaker_li_messages

Many-To-One Relationship: [li_message msevtmgt_speaker_li_messages](li_message.md#BKMK_msevtmgt_speaker_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_li_pointdrivepresentationvieweds"></a> msevtmgt_speaker_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_speaker_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_speaker_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_MailboxTrackingFolders"></a> msevtmgt_speaker_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_speaker_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_speaker_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msdyn_bookingalerts"></a> msevtmgt_speaker_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_speaker_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_speaker_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msdyn_copilottranscripts"></a> msevtmgt_speaker_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_speaker_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_speaker_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msdyn_ocliveworkitems"></a> msevtmgt_speaker_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_speaker_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_speaker_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msdyn_ocoutboundmessages"></a> msevtmgt_speaker_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_speaker_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_speaker_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msdyn_ocsessions"></a> msevtmgt_speaker_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_speaker_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_speaker_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msdyn_ocvoicemails"></a> msevtmgt_speaker_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_speaker_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_speaker_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msevtmgt_Session"></a> msevtmgt_speaker_msevtmgt_Session

Many-To-One Relationship: [msevtmgt_session msevtmgt_speaker_msevtmgt_Session](msevtmgt_session.md#BKMK_msevtmgt_speaker_msevtmgt_Session)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`msevtmgt_eventspeakerid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msevtmgt_Session`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msfp_alerts"></a> msevtmgt_speaker_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_speaker_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_speaker_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msfp_surveyinvites"></a> msevtmgt_speaker_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_speaker_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_speaker_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_msfp_surveyresponses"></a> msevtmgt_speaker_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_speaker_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_speaker_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_PhoneCalls"></a> msevtmgt_speaker_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_speaker_PhoneCalls](phonecall.md#BKMK_msevtmgt_speaker_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_PrincipalObjectAttributeAccesses"></a> msevtmgt_speaker_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_speaker_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_speaker_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_ProcessSession"></a> msevtmgt_speaker_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_speaker_ProcessSession](processsession.md#BKMK_msevtmgt_speaker_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_RecurringAppointmentMasters"></a> msevtmgt_speaker_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_speaker_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_speaker_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_ServiceAppointments"></a> msevtmgt_speaker_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_speaker_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_speaker_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_SocialActivities"></a> msevtmgt_speaker_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_speaker_SocialActivities](socialactivity.md#BKMK_msevtmgt_speaker_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_SyncErrors"></a> msevtmgt_speaker_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_speaker_SyncErrors](syncerror.md#BKMK_msevtmgt_speaker_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_speaker_Tasks"></a> msevtmgt_speaker_Tasks

Many-To-One Relationship: [task msevtmgt_speaker_Tasks](task.md#BKMK_msevtmgt_speaker_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_speaker_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msevtmgt_session_msevtmgt_speaker"></a> msevtmgt_session_msevtmgt_speaker

See [msevtmgt_session msevtmgt_session_msevtmgt_speaker Many-To-Many Relationship](msevtmgt_session.md#BKMK_msevtmgt_session_msevtmgt_speaker)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_session_msevtmgt_speaker`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_session_msevtmgt_speaker`|
|IntersectAttribute|`msevtmgt_speakerid`|
|NavigationPropertyName|`msevtmgt_session_msevtmgt_speaker`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

