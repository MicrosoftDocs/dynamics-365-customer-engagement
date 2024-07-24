---
title: "Check-in (msevtmgt_CheckIn) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Check-in (msevtmgt_CheckIn) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Check-in (msevtmgt_CheckIn) table/entity reference



## Messages

The following table lists the messages for the Check-in (msevtmgt_CheckIn) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_checkins(*msevtmgt_checkinid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_checkins<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_checkins(*msevtmgt_checkinid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_checkins(*msevtmgt_checkinid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_checkins<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_checkins(*msevtmgt_checkinid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_checkins(*msevtmgt_checkinid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_checkins(*msevtmgt_checkinid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Check-in (msevtmgt_CheckIn) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Check-in (msevtmgt_CheckIn) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Check-in** |
| **DisplayCollectionName** | **Check-ins** |
| **SchemaName** | `msevtmgt_CheckIn` |
| **CollectionSchemaName** | `msevtmgt_CheckIns` |
| **EntitySetName** | `msevtmgt_checkins`|
| **LogicalName** | `msevtmgt_checkin` |
| **LogicalCollectionName** | `msevtmgt_checkins` |
| **PrimaryIdAttribute** | `msevtmgt_checkinid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_attendancepercentage](#BKMK_msdynmkt_attendancepercentage)
- [msevtmgt_AudienceType](#BKMK_msevtmgt_AudienceType)
- [msevtmgt_CheckInId](#BKMK_msevtmgt_CheckInId)
- [msevtmgt_Checkintime](#BKMK_msevtmgt_Checkintime)
- [msevtmgt_CheckInType](#BKMK_msevtmgt_CheckInType)
- [msevtmgt_CheckOutTime](#BKMK_msevtmgt_CheckOutTime)
- [msevtmgt_Contact](#BKMK_msevtmgt_Contact)
- [msevtmgt_Event](#BKMK_msevtmgt_Event)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_NumberOfQuestionsAsked](#BKMK_msevtmgt_NumberOfQuestionsAsked)
- [msevtmgt_PurchasedPassesId](#BKMK_msevtmgt_PurchasedPassesId)
- [msevtmgt_RegistrationId](#BKMK_msevtmgt_RegistrationId)
- [msevtmgt_registrationidfromqr](#BKMK_msevtmgt_registrationidfromqr)
- [msevtmgt_SessionAttended](#BKMK_msevtmgt_SessionAttended)
- [msevtmgt_SessionCode](#BKMK_msevtmgt_SessionCode)
- [msevtmgt_SessionRegistration](#BKMK_msevtmgt_SessionRegistration)
- [msevtmgt_SessionType](#BKMK_msevtmgt_SessionType)
- [msevtmgt_TransactionCurrencyId](#BKMK_msevtmgt_TransactionCurrencyId)
- [msevtmgt_ViewingDurationInMins](#BKMK_msevtmgt_ViewingDurationInMins)
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

### <a name="BKMK_msdynmkt_attendancepercentage"></a> msdynmkt_attendancepercentage

|Property|Value|
|---|---|
|Description|**Field representing a percentile approximation of time spent for an attendee in the virtual event.**|
|DisplayName|**Attendance percentage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_attendancepercentage`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_AudienceType"></a> msevtmgt_AudienceType

|Property|Value|
|---|---|
|Description|**Audience type**|
|DisplayName|**Audience type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_audiencetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_audiencetype`|

#### msevtmgt_AudienceType Choices/Options

|Value|Label|
|---|---|
|100000000|**General**|
|100000001|**Introductory**|
|100000002|**Intermediate**|
|100000003|**Advanced**|

### <a name="BKMK_msevtmgt_CheckInId"></a> msevtmgt_CheckInId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Check-in**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_checkinid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_Checkintime"></a> msevtmgt_Checkintime

|Property|Value|
|---|---|
|Description|**Check-in time**|
|DisplayName|**Check-in time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_checkintime`|
|RequiredLevel|Recommended|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_CheckInType"></a> msevtmgt_CheckInType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Check-in type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_checkintype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_checkintype`|

#### msevtmgt_CheckInType Choices/Options

|Value|Label|
|---|---|
|100000000|**Session check-in**|
|100000001|**Event check-in**|

### <a name="BKMK_msevtmgt_CheckOutTime"></a> msevtmgt_CheckOutTime

|Property|Value|
|---|---|
|Description|**Check-out time**|
|DisplayName|**Check-out time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_checkouttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_Contact"></a> msevtmgt_Contact

|Property|Value|
|---|---|
|Description|**Contact records of the check-in**|
|DisplayName|**Attendee**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_contact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_Event"></a> msevtmgt_Event

|Property|Value|
|---|---|
|Description|**Unique identifier for the event associated with the check-in**|
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_event`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**Check-in records are used to log attendance at a particular event or session.**|
|DisplayName|**Name**|
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

### <a name="BKMK_msevtmgt_NumberOfQuestionsAsked"></a> msevtmgt_NumberOfQuestionsAsked

|Property|Value|
|---|---|
|Description||
|DisplayName|**Number of interactions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofquestionsasked`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_PurchasedPassesId"></a> msevtmgt_PurchasedPassesId

|Property|Value|
|---|---|
|Description|**Unique identifier for the attendee pass associated with the check-in**|
|DisplayName|**Purchased passes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_purchasedpassesid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_attendeepass|

### <a name="BKMK_msevtmgt_RegistrationId"></a> msevtmgt_RegistrationId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event registration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_eventregistration|

### <a name="BKMK_msevtmgt_registrationidfromqr"></a> msevtmgt_registrationidfromqr

|Property|Value|
|---|---|
|Description||
|DisplayName|**Registration ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationidfromqr`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_SessionAttended"></a> msevtmgt_SessionAttended

|Property|Value|
|---|---|
|Description|**The session attended**|
|DisplayName|**Session attended**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionattended`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|msevtmgt_session|

### <a name="BKMK_msevtmgt_SessionCode"></a> msevtmgt_SessionCode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Session code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessioncode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_SessionRegistration"></a> msevtmgt_SessionRegistration

|Property|Value|
|---|---|
|Description|**All active session registration records for this check-in**|
|DisplayName|**Session registration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionregistration`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_sessionregistration|

### <a name="BKMK_msevtmgt_SessionType"></a> msevtmgt_SessionType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Session type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessiontype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_sessiontype`|

#### msevtmgt_SessionType Choices/Options

|Value|Label|
|---|---|
|100000000|**Hands-on/lab**|
|100000001|**Keynote**|
|100000002|**General**|
|100000003|**Brainstorming**|
|100000004|**Breakout**|
|100000005|**Training**|

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

### <a name="BKMK_msevtmgt_ViewingDurationInMins"></a> msevtmgt_ViewingDurationInMins

|Property|Value|
|---|---|
|Description||
|DisplayName|**Viewing duration in minutes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_viewingdurationinmins`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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
|Description|**Status of the check-in**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_checkin_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the check-in**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_checkin_statuscode`|

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

- [business_unit_msevtmgt_checkin](#BKMK_business_unit_msevtmgt_checkin)
- [lk_msevtmgt_checkin_createdby](#BKMK_lk_msevtmgt_checkin_createdby)
- [lk_msevtmgt_checkin_createdonbehalfby](#BKMK_lk_msevtmgt_checkin_createdonbehalfby)
- [lk_msevtmgt_checkin_modifiedby](#BKMK_lk_msevtmgt_checkin_modifiedby)
- [lk_msevtmgt_checkin_modifiedonbehalfby](#BKMK_lk_msevtmgt_checkin_modifiedonbehalfby)
- [msevtmgt_attendeepass_msevtmgt_checkin](#BKMK_msevtmgt_attendeepass_msevtmgt_checkin)
- [msevtmgt_contact_msevtmgt_checkin_Contact](#BKMK_msevtmgt_contact_msevtmgt_checkin_Contact)
- [msevtmgt_event_msevtmgt_checkin_Event](#BKMK_msevtmgt_event_msevtmgt_checkin_Event)
- [msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId](#BKMK_msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId)
- [msevtmgt_session_msevtmgt_checkin_SessionAttended](#BKMK_msevtmgt_session_msevtmgt_checkin_SessionAttended)
- [msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration](#BKMK_msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration)
- [msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn)
- [owner_msevtmgt_checkin](#BKMK_owner_msevtmgt_checkin)
- [team_msevtmgt_checkin](#BKMK_team_msevtmgt_checkin)
- [user_msevtmgt_checkin](#BKMK_user_msevtmgt_checkin)

### <a name="BKMK_business_unit_msevtmgt_checkin"></a> business_unit_msevtmgt_checkin

One-To-Many Relationship: [businessunit business_unit_msevtmgt_checkin](businessunit.md#BKMK_business_unit_msevtmgt_checkin)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_checkin_createdby"></a> lk_msevtmgt_checkin_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_checkin_createdby](systemuser.md#BKMK_lk_msevtmgt_checkin_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_checkin_createdonbehalfby"></a> lk_msevtmgt_checkin_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_checkin_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_checkin_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_checkin_modifiedby"></a> lk_msevtmgt_checkin_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_checkin_modifiedby](systemuser.md#BKMK_lk_msevtmgt_checkin_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_checkin_modifiedonbehalfby"></a> lk_msevtmgt_checkin_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_checkin_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_checkin_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_attendeepass_msevtmgt_checkin"></a> msevtmgt_attendeepass_msevtmgt_checkin

One-To-Many Relationship: [msevtmgt_attendeepass msevtmgt_attendeepass_msevtmgt_checkin](msevtmgt_attendeepass.md#BKMK_msevtmgt_attendeepass_msevtmgt_checkin)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_attendeepass`|
|ReferencedAttribute|`msevtmgt_attendeepassid`|
|ReferencingAttribute|`msevtmgt_purchasedpassesid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_PurchasedPassesId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_checkin_Contact"></a> msevtmgt_contact_msevtmgt_checkin_Contact

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_checkin_Contact](contact.md#BKMK_msevtmgt_contact_msevtmgt_checkin_Contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_event_msevtmgt_checkin_Event"></a> msevtmgt_event_msevtmgt_checkin_Event

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_msevtmgt_checkin_Event](msevtmgt_event.md#BKMK_msevtmgt_event_msevtmgt_checkin_Event)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Event`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId"></a> msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`msevtmgt_registrationid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_RegistrationId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_session_msevtmgt_checkin_SessionAttended"></a> msevtmgt_session_msevtmgt_checkin_SessionAttended

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_msevtmgt_checkin_SessionAttended](msevtmgt_session.md#BKMK_msevtmgt_session_msevtmgt_checkin_SessionAttended)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`msevtmgt_sessionattended`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_SessionAttended`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration"></a> msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration](msevtmgt_sessionregistration.md#BKMK_msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`msevtmgt_sessionregistration`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_SessionRegistration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn"></a> msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn

One-To-Many Relationship: [transactioncurrency msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn](transactioncurrency.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_checkin"></a> owner_msevtmgt_checkin

One-To-Many Relationship: [owner owner_msevtmgt_checkin](owner.md#BKMK_owner_msevtmgt_checkin)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_checkin"></a> team_msevtmgt_checkin

One-To-Many Relationship: [team team_msevtmgt_checkin](team.md#BKMK_team_msevtmgt_checkin)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_checkin"></a> user_msevtmgt_checkin

One-To-Many Relationship: [systemuser user_msevtmgt_checkin](systemuser.md#BKMK_user_msevtmgt_checkin)

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

- [msevtmgt_checkin_ActivityPointers](#BKMK_msevtmgt_checkin_ActivityPointers)
- [msevtmgt_checkin_adx_alertsubscriptions](#BKMK_msevtmgt_checkin_adx_alertsubscriptions)
- [msevtmgt_checkin_adx_inviteredemptions](#BKMK_msevtmgt_checkin_adx_inviteredemptions)
- [msevtmgt_checkin_adx_portalcomments](#BKMK_msevtmgt_checkin_adx_portalcomments)
- [msevtmgt_checkin_Annotations](#BKMK_msevtmgt_checkin_Annotations)
- [msevtmgt_checkin_Appointments](#BKMK_msevtmgt_checkin_Appointments)
- [msevtmgt_checkin_AsyncOperations](#BKMK_msevtmgt_checkin_AsyncOperations)
- [msevtmgt_checkin_BulkDeleteFailures](#BKMK_msevtmgt_checkin_BulkDeleteFailures)
- [msevtmgt_checkin_chats](#BKMK_msevtmgt_checkin_chats)
- [msevtmgt_checkin_contact](#BKMK_msevtmgt_checkin_contact)
- [msevtmgt_checkin_Emails](#BKMK_msevtmgt_checkin_Emails)
- [msevtmgt_checkin_Faxes](#BKMK_msevtmgt_checkin_Faxes)
- [msevtmgt_checkin_Letters](#BKMK_msevtmgt_checkin_Letters)
- [msevtmgt_checkin_li_inmails](#BKMK_msevtmgt_checkin_li_inmails)
- [msevtmgt_checkin_li_messages](#BKMK_msevtmgt_checkin_li_messages)
- [msevtmgt_checkin_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_checkin_li_pointdrivepresentationvieweds)
- [msevtmgt_checkin_MailboxTrackingFolders](#BKMK_msevtmgt_checkin_MailboxTrackingFolders)
- [msevtmgt_checkin_msdyn_bookingalerts](#BKMK_msevtmgt_checkin_msdyn_bookingalerts)
- [msevtmgt_checkin_msdyn_copilottranscripts](#BKMK_msevtmgt_checkin_msdyn_copilottranscripts)
- [msevtmgt_checkin_msdyn_ocliveworkitems](#BKMK_msevtmgt_checkin_msdyn_ocliveworkitems)
- [msevtmgt_checkin_msdyn_ocoutboundmessages](#BKMK_msevtmgt_checkin_msdyn_ocoutboundmessages)
- [msevtmgt_checkin_msdyn_ocsessions](#BKMK_msevtmgt_checkin_msdyn_ocsessions)
- [msevtmgt_checkin_msdyn_ocvoicemails](#BKMK_msevtmgt_checkin_msdyn_ocvoicemails)
- [msevtmgt_checkin_msfp_alerts](#BKMK_msevtmgt_checkin_msfp_alerts)
- [msevtmgt_checkin_msfp_surveyinvites](#BKMK_msevtmgt_checkin_msfp_surveyinvites)
- [msevtmgt_checkin_msfp_surveyresponses](#BKMK_msevtmgt_checkin_msfp_surveyresponses)
- [msevtmgt_checkin_PhoneCalls](#BKMK_msevtmgt_checkin_PhoneCalls)
- [msevtmgt_checkin_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_checkin_PrincipalObjectAttributeAccesses)
- [msevtmgt_checkin_ProcessSession](#BKMK_msevtmgt_checkin_ProcessSession)
- [msevtmgt_checkin_RecurringAppointmentMasters](#BKMK_msevtmgt_checkin_RecurringAppointmentMasters)
- [msevtmgt_checkin_ServiceAppointments](#BKMK_msevtmgt_checkin_ServiceAppointments)
- [msevtmgt_checkin_SocialActivities](#BKMK_msevtmgt_checkin_SocialActivities)
- [msevtmgt_checkin_SyncErrors](#BKMK_msevtmgt_checkin_SyncErrors)
- [msevtmgt_checkin_Tasks](#BKMK_msevtmgt_checkin_Tasks)

### <a name="BKMK_msevtmgt_checkin_ActivityPointers"></a> msevtmgt_checkin_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_checkin_ActivityPointers](activitypointer.md#BKMK_msevtmgt_checkin_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_adx_alertsubscriptions"></a> msevtmgt_checkin_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_checkin_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_checkin_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_adx_inviteredemptions"></a> msevtmgt_checkin_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_checkin_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_checkin_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_adx_portalcomments"></a> msevtmgt_checkin_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_checkin_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_checkin_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_Annotations"></a> msevtmgt_checkin_Annotations

Many-To-One Relationship: [annotation msevtmgt_checkin_Annotations](annotation.md#BKMK_msevtmgt_checkin_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_Appointments"></a> msevtmgt_checkin_Appointments

Many-To-One Relationship: [appointment msevtmgt_checkin_Appointments](appointment.md#BKMK_msevtmgt_checkin_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_AsyncOperations"></a> msevtmgt_checkin_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_checkin_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_checkin_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_BulkDeleteFailures"></a> msevtmgt_checkin_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_checkin_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_checkin_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_chats"></a> msevtmgt_checkin_chats

Many-To-One Relationship: [chat msevtmgt_checkin_chats](chat.md#BKMK_msevtmgt_checkin_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_contact"></a> msevtmgt_checkin_contact

Many-To-One Relationship: [contact msevtmgt_checkin_contact](contact.md#BKMK_msevtmgt_checkin_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msevtmgt_contactid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_Emails"></a> msevtmgt_checkin_Emails

Many-To-One Relationship: [email msevtmgt_checkin_Emails](email.md#BKMK_msevtmgt_checkin_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_Faxes"></a> msevtmgt_checkin_Faxes

Many-To-One Relationship: [fax msevtmgt_checkin_Faxes](fax.md#BKMK_msevtmgt_checkin_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_Letters"></a> msevtmgt_checkin_Letters

Many-To-One Relationship: [letter msevtmgt_checkin_Letters](letter.md#BKMK_msevtmgt_checkin_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_li_inmails"></a> msevtmgt_checkin_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_checkin_li_inmails](li_inmail.md#BKMK_msevtmgt_checkin_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_li_messages"></a> msevtmgt_checkin_li_messages

Many-To-One Relationship: [li_message msevtmgt_checkin_li_messages](li_message.md#BKMK_msevtmgt_checkin_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_li_pointdrivepresentationvieweds"></a> msevtmgt_checkin_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_checkin_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_checkin_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_MailboxTrackingFolders"></a> msevtmgt_checkin_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_checkin_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_checkin_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_msdyn_bookingalerts"></a> msevtmgt_checkin_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_checkin_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_checkin_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_msdyn_copilottranscripts"></a> msevtmgt_checkin_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_checkin_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_checkin_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_msdyn_ocliveworkitems"></a> msevtmgt_checkin_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_checkin_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_checkin_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_msdyn_ocoutboundmessages"></a> msevtmgt_checkin_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_checkin_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_checkin_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_msdyn_ocsessions"></a> msevtmgt_checkin_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_checkin_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_checkin_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_msdyn_ocvoicemails"></a> msevtmgt_checkin_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_checkin_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_checkin_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_msfp_alerts"></a> msevtmgt_checkin_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_checkin_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_checkin_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_msfp_surveyinvites"></a> msevtmgt_checkin_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_checkin_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_checkin_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_msfp_surveyresponses"></a> msevtmgt_checkin_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_checkin_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_checkin_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_PhoneCalls"></a> msevtmgt_checkin_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_checkin_PhoneCalls](phonecall.md#BKMK_msevtmgt_checkin_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_PrincipalObjectAttributeAccesses"></a> msevtmgt_checkin_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_checkin_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_checkin_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_ProcessSession"></a> msevtmgt_checkin_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_checkin_ProcessSession](processsession.md#BKMK_msevtmgt_checkin_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_RecurringAppointmentMasters"></a> msevtmgt_checkin_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_checkin_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_checkin_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_ServiceAppointments"></a> msevtmgt_checkin_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_checkin_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_checkin_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_SocialActivities"></a> msevtmgt_checkin_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_checkin_SocialActivities](socialactivity.md#BKMK_msevtmgt_checkin_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_SyncErrors"></a> msevtmgt_checkin_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_checkin_SyncErrors](syncerror.md#BKMK_msevtmgt_checkin_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_checkin_Tasks"></a> msevtmgt_checkin_Tasks

Many-To-One Relationship: [task msevtmgt_checkin_Tasks](task.md#BKMK_msevtmgt_checkin_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_checkin_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

