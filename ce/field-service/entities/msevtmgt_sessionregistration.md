---
title: "Session Registration (msevtmgt_SessionRegistration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Session Registration (msevtmgt_SessionRegistration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Session Registration (msevtmgt_SessionRegistration) table/entity reference



## Messages

The following table lists the messages for the Session Registration (msevtmgt_SessionRegistration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_sessionregistrations(*msevtmgt_sessionregistrationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_sessionregistrations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_sessionregistrations(*msevtmgt_sessionregistrationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_sessionregistrations(*msevtmgt_sessionregistrationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_sessionregistrations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_sessionregistrations(*msevtmgt_sessionregistrationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_sessionregistrations(*msevtmgt_sessionregistrationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_sessionregistrations(*msevtmgt_sessionregistrationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Session Registration (msevtmgt_SessionRegistration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Session Registration (msevtmgt_SessionRegistration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Session Registration** |
| **DisplayCollectionName** | **Session Registrations** |
| **SchemaName** | `msevtmgt_SessionRegistration` |
| **CollectionSchemaName** | `msevtmgt_SessionRegistrations` |
| **EntitySetName** | `msevtmgt_sessionregistrations`|
| **LogicalName** | `msevtmgt_sessionregistration` |
| **LogicalCollectionName** | `msevtmgt_sessionregistrations` |
| **PrimaryIdAttribute** | `msevtmgt_sessionregistrationid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_ContactId](#BKMK_msevtmgt_ContactId)
- [msevtmgt_createdFromApi](#BKMK_msevtmgt_createdFromApi)
- [msevtmgt_Event](#BKMK_msevtmgt_Event)
- [msevtmgt_iscanceled](#BKMK_msevtmgt_iscanceled)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_publishingstate](#BKMK_msevtmgt_publishingstate)
- [msevtmgt_RegistrationID](#BKMK_msevtmgt_RegistrationID)
- [msevtmgt_registrationnotificationseen](#BKMK_msevtmgt_registrationnotificationseen)
- [msevtmgt_registrationoperation](#BKMK_msevtmgt_registrationoperation)
- [msevtmgt_registrationstatus](#BKMK_msevtmgt_registrationstatus)
- [msevtmgt_SessionId](#BKMK_msevtmgt_SessionId)
- [msevtmgt_SessionRegistrationId](#BKMK_msevtmgt_SessionRegistrationId)
- [msevtmgt_SyncedWithProvider](#BKMK_msevtmgt_SyncedWithProvider)
- [msevtmgt_TimesCheckedIn](#BKMK_msevtmgt_TimesCheckedIn)
- [msevtmgt_WebinarRegistrationID](#BKMK_msevtmgt_WebinarRegistrationID)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
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

### <a name="BKMK_msevtmgt_ContactId"></a> msevtmgt_ContactId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_contactid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_createdFromApi"></a> msevtmgt_createdFromApi

|Property|Value|
|---|---|
|Description|**A flag that indicates the origin of the registration**|
|DisplayName|**createdFromApi**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_createdfromapi`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_sessionregistration_msevtmgt_createdfromapi`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_Event"></a> msevtmgt_Event

|Property|Value|
|---|---|
|Description|**Active events records**|
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_event`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_iscanceled"></a> msevtmgt_iscanceled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is canceled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_iscanceled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_sessionregistration_msevtmgt_iscanceled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Registration ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_publishingstate"></a> msevtmgt_publishingstate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Publishing state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publishingstate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_sessionregistration_msevtmgt_publishingstate`|

#### msevtmgt_publishingstate Choices/Options

|Value|Label|
|---|---|
|100000000|**Pending**|
|100000001|**Published**|
|100000002|**Parent webinar failed**|
|100000003|**Failed to publish**|
|100000004|**Webinar provider error**|

### <a name="BKMK_msevtmgt_RegistrationID"></a> msevtmgt_RegistrationID

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event registration ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_eventregistration|

### <a name="BKMK_msevtmgt_registrationnotificationseen"></a> msevtmgt_registrationnotificationseen

|Property|Value|
|---|---|
|Description||
|DisplayName|**Registration notification seen**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationnotificationseen`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_sessionregistration_msevtmgt_registrationnotificationseen`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_registrationoperation"></a> msevtmgt_registrationoperation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Registration operation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationoperation`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_registrationstatus"></a> msevtmgt_registrationstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Registration status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_SessionId"></a> msevtmgt_SessionId

|Property|Value|
|---|---|
|Description|**Unique identifier for the session associated with the session registration**|
|DisplayName|**Session**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_session|

### <a name="BKMK_msevtmgt_SessionRegistrationId"></a> msevtmgt_SessionRegistrationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Session registration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionregistrationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_SyncedWithProvider"></a> msevtmgt_SyncedWithProvider

|Property|Value|
|---|---|
|Description|**A flag that indicates that the registration was synced with the provider**|
|DisplayName|**Synced with provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_syncedwithprovider`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_nooryes`|

#### msevtmgt_SyncedWithProvider Choices/Options

|Value|Label|
|---|---|
|100000001|**No**|
|100000002|**Yes**|

### <a name="BKMK_msevtmgt_TimesCheckedIn"></a> msevtmgt_TimesCheckedIn

|Property|Value|
|---|---|
|Description|**Deprecated attribute**|
|DisplayName|**(Deprecated) Times checked-in**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_timescheckedin`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_WebinarRegistrationID"></a> msevtmgt_WebinarRegistrationID

|Property|Value|
|---|---|
|Description|**Webinar ID of the session registration**|
|DisplayName|**Webinar registration ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarregistrationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the session registration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_sessionregistration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the session registration**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_sessionregistration_statuscode`|

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
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
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

- [business_unit_msevtmgt_sessionregistration](#BKMK_business_unit_msevtmgt_sessionregistration)
- [lk_msevtmgt_sessionregistration_createdby](#BKMK_lk_msevtmgt_sessionregistration_createdby)
- [lk_msevtmgt_sessionregistration_createdonbehalfby](#BKMK_lk_msevtmgt_sessionregistration_createdonbehalfby)
- [lk_msevtmgt_sessionregistration_modifiedby](#BKMK_lk_msevtmgt_sessionregistration_modifiedby)
- [lk_msevtmgt_sessionregistration_modifiedonbehalfby](#BKMK_lk_msevtmgt_sessionregistration_modifiedonbehalfby)
- [msevtmgt_contact_msevtmgt_sessionregistration_contactid](#BKMK_msevtmgt_contact_msevtmgt_sessionregistration_contactid)
- [msevtmgt_event_msevtmgt_sessionregistration_Event](#BKMK_msevtmgt_event_msevtmgt_sessionregistration_Event)
- [msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID](#BKMK_msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID)
- [msevtmgt_session_msevtmgt_sessionregistration](#BKMK_msevtmgt_session_msevtmgt_sessionregistration)
- [owner_msevtmgt_sessionregistration](#BKMK_owner_msevtmgt_sessionregistration)
- [team_msevtmgt_sessionregistration](#BKMK_team_msevtmgt_sessionregistration)
- [user_msevtmgt_sessionregistration](#BKMK_user_msevtmgt_sessionregistration)

### <a name="BKMK_business_unit_msevtmgt_sessionregistration"></a> business_unit_msevtmgt_sessionregistration

One-To-Many Relationship: [businessunit business_unit_msevtmgt_sessionregistration](businessunit.md#BKMK_business_unit_msevtmgt_sessionregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sessionregistration_createdby"></a> lk_msevtmgt_sessionregistration_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_sessionregistration_createdby](systemuser.md#BKMK_lk_msevtmgt_sessionregistration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sessionregistration_createdonbehalfby"></a> lk_msevtmgt_sessionregistration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_sessionregistration_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_sessionregistration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sessionregistration_modifiedby"></a> lk_msevtmgt_sessionregistration_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_sessionregistration_modifiedby](systemuser.md#BKMK_lk_msevtmgt_sessionregistration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sessionregistration_modifiedonbehalfby"></a> lk_msevtmgt_sessionregistration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_sessionregistration_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_sessionregistration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_sessionregistration_contactid"></a> msevtmgt_contact_msevtmgt_sessionregistration_contactid

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_sessionregistration_contactid](contact.md#BKMK_msevtmgt_contact_msevtmgt_sessionregistration_contactid)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_contactid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_contactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_event_msevtmgt_sessionregistration_Event"></a> msevtmgt_event_msevtmgt_sessionregistration_Event

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_msevtmgt_sessionregistration_Event](msevtmgt_event.md#BKMK_msevtmgt_event_msevtmgt_sessionregistration_Event)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Event`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID"></a> msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`msevtmgt_registrationid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_RegistrationID`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_msevtmgt_sessionregistration"></a> msevtmgt_session_msevtmgt_sessionregistration

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_msevtmgt_sessionregistration](msevtmgt_session.md#BKMK_msevtmgt_session_msevtmgt_sessionregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`msevtmgt_sessionid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_SessionId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_sessionregistration"></a> owner_msevtmgt_sessionregistration

One-To-Many Relationship: [owner owner_msevtmgt_sessionregistration](owner.md#BKMK_owner_msevtmgt_sessionregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_sessionregistration"></a> team_msevtmgt_sessionregistration

One-To-Many Relationship: [team team_msevtmgt_sessionregistration](team.md#BKMK_team_msevtmgt_sessionregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_sessionregistration"></a> user_msevtmgt_sessionregistration

One-To-Many Relationship: [systemuser user_msevtmgt_sessionregistration](systemuser.md#BKMK_user_msevtmgt_sessionregistration)

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

- [msevtmgt_sessionregistration_ActivityPointers](#BKMK_msevtmgt_sessionregistration_ActivityPointers)
- [msevtmgt_sessionregistration_adx_alertsubscriptions](#BKMK_msevtmgt_sessionregistration_adx_alertsubscriptions)
- [msevtmgt_sessionregistration_adx_inviteredemptions](#BKMK_msevtmgt_sessionregistration_adx_inviteredemptions)
- [msevtmgt_sessionregistration_adx_portalcomments](#BKMK_msevtmgt_sessionregistration_adx_portalcomments)
- [msevtmgt_sessionregistration_Annotations](#BKMK_msevtmgt_sessionregistration_Annotations)
- [msevtmgt_sessionregistration_Appointments](#BKMK_msevtmgt_sessionregistration_Appointments)
- [msevtmgt_sessionregistration_AsyncOperations](#BKMK_msevtmgt_sessionregistration_AsyncOperations)
- [msevtmgt_sessionregistration_BulkDeleteFailures](#BKMK_msevtmgt_sessionregistration_BulkDeleteFailures)
- [msevtmgt_sessionregistration_chats](#BKMK_msevtmgt_sessionregistration_chats)
- [msevtmgt_sessionregistration_Emails](#BKMK_msevtmgt_sessionregistration_Emails)
- [msevtmgt_sessionregistration_Faxes](#BKMK_msevtmgt_sessionregistration_Faxes)
- [msevtmgt_sessionregistration_Letters](#BKMK_msevtmgt_sessionregistration_Letters)
- [msevtmgt_sessionregistration_li_inmails](#BKMK_msevtmgt_sessionregistration_li_inmails)
- [msevtmgt_sessionregistration_li_messages](#BKMK_msevtmgt_sessionregistration_li_messages)
- [msevtmgt_sessionregistration_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_sessionregistration_li_pointdrivepresentationvieweds)
- [msevtmgt_sessionregistration_MailboxTrackingFolders](#BKMK_msevtmgt_sessionregistration_MailboxTrackingFolders)
- [msevtmgt_sessionregistration_msdyn_bookingalerts](#BKMK_msevtmgt_sessionregistration_msdyn_bookingalerts)
- [msevtmgt_sessionregistration_msdyn_copilottranscripts](#BKMK_msevtmgt_sessionregistration_msdyn_copilottranscripts)
- [msevtmgt_sessionregistration_msdyn_ocliveworkitems](#BKMK_msevtmgt_sessionregistration_msdyn_ocliveworkitems)
- [msevtmgt_sessionregistration_msdyn_ocoutboundmessages](#BKMK_msevtmgt_sessionregistration_msdyn_ocoutboundmessages)
- [msevtmgt_sessionregistration_msdyn_ocsessions](#BKMK_msevtmgt_sessionregistration_msdyn_ocsessions)
- [msevtmgt_sessionregistration_msdyn_ocvoicemails](#BKMK_msevtmgt_sessionregistration_msdyn_ocvoicemails)
- [msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration](#BKMK_msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration)
- [msevtmgt_sessionregistration_msfp_alerts](#BKMK_msevtmgt_sessionregistration_msfp_alerts)
- [msevtmgt_sessionregistration_msfp_surveyinvites](#BKMK_msevtmgt_sessionregistration_msfp_surveyinvites)
- [msevtmgt_sessionregistration_msfp_surveyresponses](#BKMK_msevtmgt_sessionregistration_msfp_surveyresponses)
- [msevtmgt_sessionregistration_PhoneCalls](#BKMK_msevtmgt_sessionregistration_PhoneCalls)
- [msevtmgt_sessionregistration_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_sessionregistration_PrincipalObjectAttributeAccesses)
- [msevtmgt_sessionregistration_ProcessSession](#BKMK_msevtmgt_sessionregistration_ProcessSession)
- [msevtmgt_sessionregistration_RecurringAppointmentMasters](#BKMK_msevtmgt_sessionregistration_RecurringAppointmentMasters)
- [msevtmgt_sessionregistration_ServiceAppointments](#BKMK_msevtmgt_sessionregistration_ServiceAppointments)
- [msevtmgt_sessionregistration_SocialActivities](#BKMK_msevtmgt_sessionregistration_SocialActivities)
- [msevtmgt_sessionregistration_SyncErrors](#BKMK_msevtmgt_sessionregistration_SyncErrors)
- [msevtmgt_sessionregistration_Tasks](#BKMK_msevtmgt_sessionregistration_Tasks)

### <a name="BKMK_msevtmgt_sessionregistration_ActivityPointers"></a> msevtmgt_sessionregistration_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_sessionregistration_ActivityPointers](activitypointer.md#BKMK_msevtmgt_sessionregistration_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_adx_alertsubscriptions"></a> msevtmgt_sessionregistration_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_sessionregistration_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_sessionregistration_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_adx_inviteredemptions"></a> msevtmgt_sessionregistration_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_sessionregistration_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_sessionregistration_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_adx_portalcomments"></a> msevtmgt_sessionregistration_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_sessionregistration_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_sessionregistration_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_Annotations"></a> msevtmgt_sessionregistration_Annotations

Many-To-One Relationship: [annotation msevtmgt_sessionregistration_Annotations](annotation.md#BKMK_msevtmgt_sessionregistration_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_Appointments"></a> msevtmgt_sessionregistration_Appointments

Many-To-One Relationship: [appointment msevtmgt_sessionregistration_Appointments](appointment.md#BKMK_msevtmgt_sessionregistration_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_AsyncOperations"></a> msevtmgt_sessionregistration_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_sessionregistration_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_sessionregistration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_BulkDeleteFailures"></a> msevtmgt_sessionregistration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_sessionregistration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_sessionregistration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_chats"></a> msevtmgt_sessionregistration_chats

Many-To-One Relationship: [chat msevtmgt_sessionregistration_chats](chat.md#BKMK_msevtmgt_sessionregistration_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_Emails"></a> msevtmgt_sessionregistration_Emails

Many-To-One Relationship: [email msevtmgt_sessionregistration_Emails](email.md#BKMK_msevtmgt_sessionregistration_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_Faxes"></a> msevtmgt_sessionregistration_Faxes

Many-To-One Relationship: [fax msevtmgt_sessionregistration_Faxes](fax.md#BKMK_msevtmgt_sessionregistration_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_Letters"></a> msevtmgt_sessionregistration_Letters

Many-To-One Relationship: [letter msevtmgt_sessionregistration_Letters](letter.md#BKMK_msevtmgt_sessionregistration_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_li_inmails"></a> msevtmgt_sessionregistration_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_sessionregistration_li_inmails](li_inmail.md#BKMK_msevtmgt_sessionregistration_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_li_messages"></a> msevtmgt_sessionregistration_li_messages

Many-To-One Relationship: [li_message msevtmgt_sessionregistration_li_messages](li_message.md#BKMK_msevtmgt_sessionregistration_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_li_pointdrivepresentationvieweds"></a> msevtmgt_sessionregistration_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_sessionregistration_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_sessionregistration_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_MailboxTrackingFolders"></a> msevtmgt_sessionregistration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_sessionregistration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_sessionregistration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_msdyn_bookingalerts"></a> msevtmgt_sessionregistration_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_sessionregistration_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_sessionregistration_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_msdyn_copilottranscripts"></a> msevtmgt_sessionregistration_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_sessionregistration_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_sessionregistration_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_msdyn_ocliveworkitems"></a> msevtmgt_sessionregistration_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_sessionregistration_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_sessionregistration_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_msdyn_ocoutboundmessages"></a> msevtmgt_sessionregistration_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_sessionregistration_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_sessionregistration_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_msdyn_ocsessions"></a> msevtmgt_sessionregistration_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_sessionregistration_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_sessionregistration_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_msdyn_ocvoicemails"></a> msevtmgt_sessionregistration_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_sessionregistration_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_sessionregistration_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration"></a> msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration

Many-To-One Relationship: [msevtmgt_checkin msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration](msevtmgt_checkin.md#BKMK_msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_checkin`|
|ReferencingAttribute|`msevtmgt_sessionregistration`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_msfp_alerts"></a> msevtmgt_sessionregistration_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_sessionregistration_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_sessionregistration_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_msfp_surveyinvites"></a> msevtmgt_sessionregistration_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_sessionregistration_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_sessionregistration_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_msfp_surveyresponses"></a> msevtmgt_sessionregistration_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_sessionregistration_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_sessionregistration_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_PhoneCalls"></a> msevtmgt_sessionregistration_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_sessionregistration_PhoneCalls](phonecall.md#BKMK_msevtmgt_sessionregistration_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_PrincipalObjectAttributeAccesses"></a> msevtmgt_sessionregistration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_sessionregistration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_sessionregistration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_ProcessSession"></a> msevtmgt_sessionregistration_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_sessionregistration_ProcessSession](processsession.md#BKMK_msevtmgt_sessionregistration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_RecurringAppointmentMasters"></a> msevtmgt_sessionregistration_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_sessionregistration_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_sessionregistration_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_ServiceAppointments"></a> msevtmgt_sessionregistration_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_sessionregistration_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_sessionregistration_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_SocialActivities"></a> msevtmgt_sessionregistration_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_sessionregistration_SocialActivities](socialactivity.md#BKMK_msevtmgt_sessionregistration_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_SyncErrors"></a> msevtmgt_sessionregistration_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_sessionregistration_SyncErrors](syncerror.md#BKMK_msevtmgt_sessionregistration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessionregistration_Tasks"></a> msevtmgt_sessionregistration_Tasks

Many-To-One Relationship: [task msevtmgt_sessionregistration_Tasks](task.md#BKMK_msevtmgt_sessionregistration_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessionregistration_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

