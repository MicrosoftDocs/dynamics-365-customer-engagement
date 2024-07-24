---
title: "Session Track (msevtmgt_SessionTrack) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Session Track (msevtmgt_SessionTrack) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Session Track (msevtmgt_SessionTrack) table/entity reference



## Messages

The following table lists the messages for the Session Track (msevtmgt_SessionTrack) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_sessiontracks(*msevtmgt_sessiontrackid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_sessiontracks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_sessiontracks(*msevtmgt_sessiontrackid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_sessiontracks(*msevtmgt_sessiontrackid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_sessiontracks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_sessiontracks(*msevtmgt_sessiontrackid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_sessiontracks(*msevtmgt_sessiontrackid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_sessiontracks(*msevtmgt_sessiontrackid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Session Track (msevtmgt_SessionTrack) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Session Track (msevtmgt_SessionTrack) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Session Track** |
| **DisplayCollectionName** | **Session Tracks** |
| **SchemaName** | `msevtmgt_SessionTrack` |
| **CollectionSchemaName** | `msevtmgt_SessionTracks` |
| **EntitySetName** | `msevtmgt_sessiontracks`|
| **LogicalName** | `msevtmgt_sessiontrack` |
| **LogicalCollectionName** | `msevtmgt_sessiontracks` |
| **PrimaryIdAttribute** | `msevtmgt_sessiontrackid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_AudienceType](#BKMK_msevtmgt_AudienceType)
- [msevtmgt_Description](#BKMK_msevtmgt_Description)
- [msevtmgt_EventId](#BKMK_msevtmgt_EventId)
- [msevtmgt_IndustryType](#BKMK_msevtmgt_IndustryType)
- [msevtmgt_Keywords](#BKMK_msevtmgt_Keywords)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_numberofregistrations](#BKMK_msevtmgt_numberofregistrations)
- [msevtmgt_PublishStatus](#BKMK_msevtmgt_PublishStatus)
- [msevtmgt_SessionsInTrack](#BKMK_msevtmgt_SessionsInTrack)
- [msevtmgt_SessionTrackId](#BKMK_msevtmgt_SessionTrackId)
- [msevtmgt_TargetNumberOfSessions](#BKMK_msevtmgt_TargetNumberOfSessions)
- [msevtmgt_TrackCode](#BKMK_msevtmgt_TrackCode)
- [msevtmgt_TrackGoal](#BKMK_msevtmgt_TrackGoal)
- [msevtmgt_TrackType](#BKMK_msevtmgt_TrackType)
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

### <a name="BKMK_msevtmgt_AudienceType"></a> msevtmgt_AudienceType

|Property|Value|
|---|---|
|Description|**The intended audience for the session track**|
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

### <a name="BKMK_msevtmgt_EventId"></a> msevtmgt_EventId

|Property|Value|
|---|---|
|Description|**Unique identifier for the event associated with the session track**|
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_IndustryType"></a> msevtmgt_IndustryType

|Property|Value|
|---|---|
|Description|**Industry of the session track**|
|DisplayName|**Industry**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_industrytype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_industry`|

#### msevtmgt_IndustryType Choices/Options

|Value|Label|
|---|---|
|100000000|**Architecture and engineering**|
|100000001|**Financial services**|
|100000002|**Manufacturing**|
|100000003|**Media, entertainment**|
|100000004|**Professional services**|
|100000005|**Public sector**|
|100000006|**Retail**|
|100000007|**Wholesale and distribution**|
|100000008|**Other**|

### <a name="BKMK_msevtmgt_Keywords"></a> msevtmgt_Keywords

|Property|Value|
|---|---|
|Description|**Keywords for the session track**|
|DisplayName|**Keywords**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_keywords`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
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

### <a name="BKMK_msevtmgt_numberofregistrations"></a> msevtmgt_numberofregistrations

|Property|Value|
|---|---|
|Description||
|DisplayName|**Number of registrations**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofregistrations`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_PublishStatus"></a> msevtmgt_PublishStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Publish status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publishstatus`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_publishstatus`|

#### msevtmgt_PublishStatus Choices/Options

|Value|Label|
|---|---|
|100000000|**Draft**|
|100000001|**Ready to go live**|
|100000002|**In progress**|
|100000003|**Live**|
|100000004|**Cancelled**|
|100000005|**Going live**|

### <a name="BKMK_msevtmgt_SessionsInTrack"></a> msevtmgt_SessionsInTrack

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sessions in this track**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionsintrack`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_SessionTrackId"></a> msevtmgt_SessionTrackId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Session track**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessiontrackid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_TargetNumberOfSessions"></a> msevtmgt_TargetNumberOfSessions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target number of sessions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_targetnumberofsessions`|
|RequiredLevel|Recommended|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_TrackCode"></a> msevtmgt_TrackCode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Track code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_trackcode`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_TrackGoal"></a> msevtmgt_TrackGoal

|Property|Value|
|---|---|
|Description||
|DisplayName|**Track goal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_trackgoal`|
|RequiredLevel|Recommended|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_TrackType"></a> msevtmgt_TrackType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Track type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_tracktype`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_tracktype`|

#### msevtmgt_TrackType Choices/Options

|Value|Label|
|---|---|
|100000000|**Internal**|
|100000001|**External**|

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
|Description|**Status of the session track**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_sessiontrack_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the session track**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_sessiontrack_statuscode`|

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

- [business_unit_msevtmgt_sessiontrack](#BKMK_business_unit_msevtmgt_sessiontrack)
- [lk_msevtmgt_sessiontrack_createdby](#BKMK_lk_msevtmgt_sessiontrack_createdby)
- [lk_msevtmgt_sessiontrack_createdonbehalfby](#BKMK_lk_msevtmgt_sessiontrack_createdonbehalfby)
- [lk_msevtmgt_sessiontrack_modifiedby](#BKMK_lk_msevtmgt_sessiontrack_modifiedby)
- [lk_msevtmgt_sessiontrack_modifiedonbehalfby](#BKMK_lk_msevtmgt_sessiontrack_modifiedonbehalfby)
- [msevtmgt_Event__SessionTrack](#BKMK_msevtmgt_Event__SessionTrack)
- [owner_msevtmgt_sessiontrack](#BKMK_owner_msevtmgt_sessiontrack)
- [team_msevtmgt_sessiontrack](#BKMK_team_msevtmgt_sessiontrack)
- [user_msevtmgt_sessiontrack](#BKMK_user_msevtmgt_sessiontrack)

### <a name="BKMK_business_unit_msevtmgt_sessiontrack"></a> business_unit_msevtmgt_sessiontrack

One-To-Many Relationship: [businessunit business_unit_msevtmgt_sessiontrack](businessunit.md#BKMK_business_unit_msevtmgt_sessiontrack)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sessiontrack_createdby"></a> lk_msevtmgt_sessiontrack_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_sessiontrack_createdby](systemuser.md#BKMK_lk_msevtmgt_sessiontrack_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sessiontrack_createdonbehalfby"></a> lk_msevtmgt_sessiontrack_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_sessiontrack_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_sessiontrack_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sessiontrack_modifiedby"></a> lk_msevtmgt_sessiontrack_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_sessiontrack_modifiedby](systemuser.md#BKMK_lk_msevtmgt_sessiontrack_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_sessiontrack_modifiedonbehalfby"></a> lk_msevtmgt_sessiontrack_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_sessiontrack_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_sessiontrack_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_Event__SessionTrack"></a> msevtmgt_Event__SessionTrack

One-To-Many Relationship: [msevtmgt_event msevtmgt_Event__SessionTrack](msevtmgt_event.md#BKMK_msevtmgt_Event__SessionTrack)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_EventId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msevtmgt_sessiontrack"></a> owner_msevtmgt_sessiontrack

One-To-Many Relationship: [owner owner_msevtmgt_sessiontrack](owner.md#BKMK_owner_msevtmgt_sessiontrack)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_sessiontrack"></a> team_msevtmgt_sessiontrack

One-To-Many Relationship: [team team_msevtmgt_sessiontrack](team.md#BKMK_team_msevtmgt_sessiontrack)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_sessiontrack"></a> user_msevtmgt_sessiontrack

One-To-Many Relationship: [systemuser user_msevtmgt_sessiontrack](systemuser.md#BKMK_user_msevtmgt_sessiontrack)

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

- [msevtmgt_sessiontrack_ActivityPointers](#BKMK_msevtmgt_sessiontrack_ActivityPointers)
- [msevtmgt_sessiontrack_adx_alertsubscriptions](#BKMK_msevtmgt_sessiontrack_adx_alertsubscriptions)
- [msevtmgt_sessiontrack_adx_inviteredemptions](#BKMK_msevtmgt_sessiontrack_adx_inviteredemptions)
- [msevtmgt_sessiontrack_adx_portalcomments](#BKMK_msevtmgt_sessiontrack_adx_portalcomments)
- [msevtmgt_sessiontrack_Annotations](#BKMK_msevtmgt_sessiontrack_Annotations)
- [msevtmgt_sessiontrack_Appointments](#BKMK_msevtmgt_sessiontrack_Appointments)
- [msevtmgt_sessiontrack_AsyncOperations](#BKMK_msevtmgt_sessiontrack_AsyncOperations)
- [msevtmgt_sessiontrack_BulkDeleteFailures](#BKMK_msevtmgt_sessiontrack_BulkDeleteFailures)
- [msevtmgt_sessiontrack_chats](#BKMK_msevtmgt_sessiontrack_chats)
- [msevtmgt_sessiontrack_Emails](#BKMK_msevtmgt_sessiontrack_Emails)
- [msevtmgt_sessiontrack_Faxes](#BKMK_msevtmgt_sessiontrack_Faxes)
- [msevtmgt_sessiontrack_Letters](#BKMK_msevtmgt_sessiontrack_Letters)
- [msevtmgt_sessiontrack_li_inmails](#BKMK_msevtmgt_sessiontrack_li_inmails)
- [msevtmgt_sessiontrack_li_messages](#BKMK_msevtmgt_sessiontrack_li_messages)
- [msevtmgt_sessiontrack_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_sessiontrack_li_pointdrivepresentationvieweds)
- [msevtmgt_sessiontrack_MailboxTrackingFolders](#BKMK_msevtmgt_sessiontrack_MailboxTrackingFolders)
- [msevtmgt_sessiontrack_msdyn_bookingalerts](#BKMK_msevtmgt_sessiontrack_msdyn_bookingalerts)
- [msevtmgt_sessiontrack_msdyn_copilottranscripts](#BKMK_msevtmgt_sessiontrack_msdyn_copilottranscripts)
- [msevtmgt_sessiontrack_msdyn_ocliveworkitems](#BKMK_msevtmgt_sessiontrack_msdyn_ocliveworkitems)
- [msevtmgt_sessiontrack_msdyn_ocoutboundmessages](#BKMK_msevtmgt_sessiontrack_msdyn_ocoutboundmessages)
- [msevtmgt_sessiontrack_msdyn_ocsessions](#BKMK_msevtmgt_sessiontrack_msdyn_ocsessions)
- [msevtmgt_sessiontrack_msdyn_ocvoicemails](#BKMK_msevtmgt_sessiontrack_msdyn_ocvoicemails)
- [msevtmgt_sessiontrack_msevtmgt_pass_Track](#BKMK_msevtmgt_sessiontrack_msevtmgt_pass_Track)
- [msevtmgt_sessiontrack_msfp_alerts](#BKMK_msevtmgt_sessiontrack_msfp_alerts)
- [msevtmgt_sessiontrack_msfp_surveyinvites](#BKMK_msevtmgt_sessiontrack_msfp_surveyinvites)
- [msevtmgt_sessiontrack_msfp_surveyresponses](#BKMK_msevtmgt_sessiontrack_msfp_surveyresponses)
- [msevtmgt_sessiontrack_PhoneCalls](#BKMK_msevtmgt_sessiontrack_PhoneCalls)
- [msevtmgt_sessiontrack_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_sessiontrack_PrincipalObjectAttributeAccesses)
- [msevtmgt_sessiontrack_ProcessSession](#BKMK_msevtmgt_sessiontrack_ProcessSession)
- [msevtmgt_sessiontrack_RecurringAppointmentMasters](#BKMK_msevtmgt_sessiontrack_RecurringAppointmentMasters)
- [msevtmgt_sessiontrack_ServiceAppointments](#BKMK_msevtmgt_sessiontrack_ServiceAppointments)
- [msevtmgt_sessiontrack_SocialActivities](#BKMK_msevtmgt_sessiontrack_SocialActivities)
- [msevtmgt_sessiontrack_SyncErrors](#BKMK_msevtmgt_sessiontrack_SyncErrors)
- [msevtmgt_sessiontrack_Tasks](#BKMK_msevtmgt_sessiontrack_Tasks)

### <a name="BKMK_msevtmgt_sessiontrack_ActivityPointers"></a> msevtmgt_sessiontrack_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_sessiontrack_ActivityPointers](activitypointer.md#BKMK_msevtmgt_sessiontrack_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_adx_alertsubscriptions"></a> msevtmgt_sessiontrack_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_sessiontrack_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_sessiontrack_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_adx_inviteredemptions"></a> msevtmgt_sessiontrack_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_sessiontrack_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_sessiontrack_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_adx_portalcomments"></a> msevtmgt_sessiontrack_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_sessiontrack_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_sessiontrack_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_Annotations"></a> msevtmgt_sessiontrack_Annotations

Many-To-One Relationship: [annotation msevtmgt_sessiontrack_Annotations](annotation.md#BKMK_msevtmgt_sessiontrack_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_Appointments"></a> msevtmgt_sessiontrack_Appointments

Many-To-One Relationship: [appointment msevtmgt_sessiontrack_Appointments](appointment.md#BKMK_msevtmgt_sessiontrack_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_AsyncOperations"></a> msevtmgt_sessiontrack_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_sessiontrack_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_sessiontrack_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_BulkDeleteFailures"></a> msevtmgt_sessiontrack_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_sessiontrack_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_sessiontrack_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_chats"></a> msevtmgt_sessiontrack_chats

Many-To-One Relationship: [chat msevtmgt_sessiontrack_chats](chat.md#BKMK_msevtmgt_sessiontrack_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_Emails"></a> msevtmgt_sessiontrack_Emails

Many-To-One Relationship: [email msevtmgt_sessiontrack_Emails](email.md#BKMK_msevtmgt_sessiontrack_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_Faxes"></a> msevtmgt_sessiontrack_Faxes

Many-To-One Relationship: [fax msevtmgt_sessiontrack_Faxes](fax.md#BKMK_msevtmgt_sessiontrack_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_Letters"></a> msevtmgt_sessiontrack_Letters

Many-To-One Relationship: [letter msevtmgt_sessiontrack_Letters](letter.md#BKMK_msevtmgt_sessiontrack_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_li_inmails"></a> msevtmgt_sessiontrack_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_sessiontrack_li_inmails](li_inmail.md#BKMK_msevtmgt_sessiontrack_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_li_messages"></a> msevtmgt_sessiontrack_li_messages

Many-To-One Relationship: [li_message msevtmgt_sessiontrack_li_messages](li_message.md#BKMK_msevtmgt_sessiontrack_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_li_pointdrivepresentationvieweds"></a> msevtmgt_sessiontrack_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_sessiontrack_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_sessiontrack_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_MailboxTrackingFolders"></a> msevtmgt_sessiontrack_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_sessiontrack_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_sessiontrack_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msdyn_bookingalerts"></a> msevtmgt_sessiontrack_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_sessiontrack_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_sessiontrack_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msdyn_copilottranscripts"></a> msevtmgt_sessiontrack_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_sessiontrack_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_sessiontrack_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msdyn_ocliveworkitems"></a> msevtmgt_sessiontrack_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_sessiontrack_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_sessiontrack_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msdyn_ocoutboundmessages"></a> msevtmgt_sessiontrack_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_sessiontrack_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_sessiontrack_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msdyn_ocsessions"></a> msevtmgt_sessiontrack_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_sessiontrack_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_sessiontrack_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msdyn_ocvoicemails"></a> msevtmgt_sessiontrack_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_sessiontrack_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_sessiontrack_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msevtmgt_pass_Track"></a> msevtmgt_sessiontrack_msevtmgt_pass_Track

Many-To-One Relationship: [msevtmgt_pass msevtmgt_sessiontrack_msevtmgt_pass_Track](msevtmgt_pass.md#BKMK_msevtmgt_sessiontrack_msevtmgt_pass_Track)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_pass`|
|ReferencingAttribute|`msevtmgt_track`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msevtmgt_pass_Track`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msfp_alerts"></a> msevtmgt_sessiontrack_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_sessiontrack_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_sessiontrack_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msfp_surveyinvites"></a> msevtmgt_sessiontrack_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_sessiontrack_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_sessiontrack_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msfp_surveyresponses"></a> msevtmgt_sessiontrack_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_sessiontrack_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_sessiontrack_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_PhoneCalls"></a> msevtmgt_sessiontrack_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_sessiontrack_PhoneCalls](phonecall.md#BKMK_msevtmgt_sessiontrack_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_PrincipalObjectAttributeAccesses"></a> msevtmgt_sessiontrack_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_sessiontrack_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_sessiontrack_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_ProcessSession"></a> msevtmgt_sessiontrack_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_sessiontrack_ProcessSession](processsession.md#BKMK_msevtmgt_sessiontrack_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_RecurringAppointmentMasters"></a> msevtmgt_sessiontrack_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_sessiontrack_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_sessiontrack_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_ServiceAppointments"></a> msevtmgt_sessiontrack_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_sessiontrack_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_sessiontrack_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_SocialActivities"></a> msevtmgt_sessiontrack_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_sessiontrack_SocialActivities](socialactivity.md#BKMK_msevtmgt_sessiontrack_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_SyncErrors"></a> msevtmgt_sessiontrack_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_sessiontrack_SyncErrors](syncerror.md#BKMK_msevtmgt_sessiontrack_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_Tasks"></a> msevtmgt_sessiontrack_Tasks

Many-To-One Relationship: [task msevtmgt_sessiontrack_Tasks](task.md#BKMK_msevtmgt_sessiontrack_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_sessiontrack_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msevtmgt_sessiontrack_msevtmgt_session"></a> msevtmgt_sessiontrack_msevtmgt_session

See [msevtmgt_session msevtmgt_sessiontrack_msevtmgt_session Many-To-Many Relationship](msevtmgt_session.md#BKMK_msevtmgt_sessiontrack_msevtmgt_session)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_sessiontrack_msevtmgt_session`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_sessiontrack_msevtmgt_session`|
|IntersectAttribute|`msevtmgt_sessiontrackid`|
|NavigationPropertyName|`msevtmgt_sessiontrack_msevtmgt_session`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

