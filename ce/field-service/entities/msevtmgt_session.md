---
title: "Session (msevtmgt_Session) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Session (msevtmgt_Session) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Session (msevtmgt_Session) table/entity reference



## Messages

The following table lists the messages for the Session (msevtmgt_Session) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_sessions(*msevtmgt_sessionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_sessions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_sessions(*msevtmgt_sessionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_sessions(*msevtmgt_sessionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_sessions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_sessions(*msevtmgt_sessionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_sessions(*msevtmgt_sessionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_sessions(*msevtmgt_sessionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Session (msevtmgt_Session) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Session (msevtmgt_Session) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Session** |
| **DisplayCollectionName** | **Sessions** |
| **SchemaName** | `msevtmgt_Session` |
| **CollectionSchemaName** | `msevtmgt_Sessions` |
| **EntitySetName** | `msevtmgt_sessions`|
| **LogicalName** | `msevtmgt_session` |
| **LogicalCollectionName** | `msevtmgt_sessions` |
| **PrimaryIdAttribute** | `msevtmgt_sessionid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_allowattendeestounmute](#BKMK_msevtmgt_allowattendeestounmute)
- [msevtmgt_allowcameraforattendees](#BKMK_msevtmgt_allowcameraforattendees)
- [msevtmgt_allowexternalpresenters](#BKMK_msevtmgt_allowexternalpresenters)
- [msevtmgt_allowmeetingchat](#BKMK_msevtmgt_allowmeetingchat)
- [msevtmgt_allowpstnsserstobypasslobby](#BKMK_msevtmgt_allowpstnsserstobypasslobby)
- [msevtmgt_allowteamsmeetingreactions](#BKMK_msevtmgt_allowteamsmeetingreactions)
- [msevtmgt_attendeeengagementreport](#BKMK_msevtmgt_attendeeengagementreport)
- [msevtmgt_attendeeurl](#BKMK_msevtmgt_attendeeurl)
- [msevtmgt_AudienceType](#BKMK_msevtmgt_AudienceType)
- [msevtmgt_autoadmittedusers](#BKMK_msevtmgt_autoadmittedusers)
- [msevtmgt_autorecordingenabled](#BKMK_msevtmgt_autorecordingenabled)
- [msevtmgt_AVSupport](#BKMK_msevtmgt_AVSupport)
- [msevtmgt_baserecurrentsessionid](#BKMK_msevtmgt_baserecurrentsessionid)
- [msevtmgt_building](#BKMK_msevtmgt_building)
- [msevtmgt_ByInvitationOnly](#BKMK_msevtmgt_ByInvitationOnly)
- [msevtmgt_calendarcontent](#BKMK_msevtmgt_calendarcontent)
- [msevtmgt_calendarcontent_plaintext](#BKMK_msevtmgt_calendarcontent_plaintext)
- [msevtmgt_CamerasPermitted](#BKMK_msevtmgt_CamerasPermitted)
- [msevtmgt_changemeetingoptions](#BKMK_msevtmgt_changemeetingoptions)
- [msevtmgt_CheckInCount](#BKMK_msevtmgt_CheckInCount)
- [msevtmgt_creationsource](#BKMK_msevtmgt_creationsource)
- [msevtmgt_descriptorsyncstatus](#BKMK_msevtmgt_descriptorsyncstatus)
- [msevtmgt_DetailedDescription](#BKMK_msevtmgt_DetailedDescription)
- [msevtmgt_EndTime](#BKMK_msevtmgt_EndTime)
- [msevtmgt_entryexitannouncementsenabled](#BKMK_msevtmgt_entryexitannouncementsenabled)
- [msevtmgt_Event](#BKMK_msevtmgt_Event)
- [msevtmgt_EventSpeakerId](#BKMK_msevtmgt_EventSpeakerId)
- [msevtmgt_ExternalUrl](#BKMK_msevtmgt_ExternalUrl)
- [msevtmgt_FlipChart](#BKMK_msevtmgt_FlipChart)
- [msevtmgt_Industry](#BKMK_msevtmgt_Industry)
- [msevtmgt_InternetConnection](#BKMK_msevtmgt_InternetConnection)
- [msevtmgt_isoutofsync](#BKMK_msevtmgt_isoutofsync)
- [msevtmgt_Keywords](#BKMK_msevtmgt_Keywords)
- [msevtmgt_Language](#BKMK_msevtmgt_Language)
- [msevtmgt_lastteamssyncdate](#BKMK_msevtmgt_lastteamssyncdate)
- [msevtmgt_layout](#BKMK_msevtmgt_layout)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_NDA](#BKMK_msevtmgt_NDA)
- [msevtmgt_PassSessions](#BKMK_msevtmgt_PassSessions)
- [msevtmgt_PresentationManagerUrl](#BKMK_msevtmgt_PresentationManagerUrl)
- [msevtmgt_previousnumberoffreeslots](#BKMK_msevtmgt_previousnumberoffreeslots)
- [msevtmgt_Producer](#BKMK_msevtmgt_Producer)
- [msevtmgt_PublishStatus](#BKMK_msevtmgt_PublishStatus)
- [msevtmgt_qna](#BKMK_msevtmgt_qna)
- [msevtmgt_recordingforattendees](#BKMK_msevtmgt_recordingforattendees)
- [msevtmgt_recordingforproducersandspeakers](#BKMK_msevtmgt_recordingforproducersandspeakers)
- [msevtmgt_RecordingsPermitted](#BKMK_msevtmgt_RecordingsPermitted)
- [msevtmgt_recurrencepattern](#BKMK_msevtmgt_recurrencepattern)
- [msevtmgt_RegistrationCount](#BKMK_msevtmgt_RegistrationCount)
- [msevtmgt_registrationcounterlock](#BKMK_msevtmgt_registrationcounterlock)
- [msevtmgt_room](#BKMK_msevtmgt_room)
- [msevtmgt_SessionCode](#BKMK_msevtmgt_SessionCode)
- [msevtmgt_sessionformat](#BKMK_msevtmgt_sessionformat)
- [msevtmgt_SessionId](#BKMK_msevtmgt_SessionId)
- [msevtmgt_SessionMaxCapacity](#BKMK_msevtmgt_SessionMaxCapacity)
- [msevtmgt_SessionObjectives](#BKMK_msevtmgt_SessionObjectives)
- [msevtmgt_SessionPreRequisites](#BKMK_msevtmgt_SessionPreRequisites)
- [msevtmgt_SessionSummary](#BKMK_msevtmgt_SessionSummary)
- [msevtmgt_SessionType](#BKMK_msevtmgt_SessionType)
- [msevtmgt_StartTime](#BKMK_msevtmgt_StartTime)
- [msevtmgt_streamingenabled](#BKMK_msevtmgt_streamingenabled)
- [msevtmgt_streamingprovider](#BKMK_msevtmgt_streamingprovider)
- [msevtmgt_streamowner](#BKMK_msevtmgt_streamowner)
- [msevtmgt_teamsinvitationhtml](#BKMK_msevtmgt_teamsinvitationhtml)
- [msevtmgt_Venue](#BKMK_msevtmgt_Venue)
- [msevtmgt_VideoConferencing](#BKMK_msevtmgt_VideoConferencing)
- [msevtmgt_WebinarConfigurationId](#BKMK_msevtmgt_WebinarConfigurationId)
- [msevtmgt_WebinarID](#BKMK_msevtmgt_WebinarID)
- [msevtmgt_webinarnotificationseen](#BKMK_msevtmgt_webinarnotificationseen)
- [msevtmgt_webinaroperation](#BKMK_msevtmgt_webinaroperation)
- [msevtmgt_webinarstatus](#BKMK_msevtmgt_webinarstatus)
- [msevtmgt_webinarstatusreason](#BKMK_msevtmgt_webinarstatusreason)
- [msevtmgt_WebinarType](#BKMK_msevtmgt_WebinarType)
- [msevtmgt_webinarurl](#BKMK_msevtmgt_webinarurl)
- [msevtmgt_WhiteBoard](#BKMK_msevtmgt_WhiteBoard)
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

### <a name="BKMK_msevtmgt_allowattendeestounmute"></a> msevtmgt_allowattendeestounmute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow attendees to unmute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowattendeestounmute`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_allowattendeestounmute`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowcameraforattendees"></a> msevtmgt_allowcameraforattendees

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow camera for attendees**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowcameraforattendees`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_allowcameraforattendees`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowexternalpresenters"></a> msevtmgt_allowexternalpresenters

|Property|Value|
|---|---|
|Description||
|DisplayName|**Do you want to allow external presenters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowexternalpresenters`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_allowexternalpresenters`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowmeetingchat"></a> msevtmgt_allowmeetingchat

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow meeting chat**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowmeetingchat`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_allowmeetingchat`|

#### msevtmgt_allowmeetingchat Choices/Options

|Value|Label|
|---|---|
|100000000|**Enabled**|
|100000001|**Disabled**|
|100000002|**In-meeting only**|

### <a name="BKMK_msevtmgt_allowpstnsserstobypasslobby"></a> msevtmgt_allowpstnsserstobypasslobby

|Property|Value|
|---|---|
|Description||
|DisplayName|**Always let callers bypass the lobby**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowpstnsserstobypasslobby`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_allowpstnsserstobypasslobby`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowteamsmeetingreactions"></a> msevtmgt_allowteamsmeetingreactions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow reactions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowteamsmeetingreactions`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_allowteamsmeetingreactions`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_attendeeengagementreport"></a> msevtmgt_attendeeengagementreport

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attendee engagement report**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_attendeeengagementreport`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_attendeeengagementreport`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_attendeeurl"></a> msevtmgt_attendeeurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Teams URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_attendeeurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msevtmgt_AudienceType"></a> msevtmgt_AudienceType

|Property|Value|
|---|---|
|Description|**The intended audience for the session**|
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

### <a name="BKMK_msevtmgt_autoadmittedusers"></a> msevtmgt_autoadmittedusers

|Property|Value|
|---|---|
|Description||
|DisplayName|**Who can bypass the lobby?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_autoadmittedusers`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_autoadmittedusers`|

#### msevtmgt_autoadmittedusers Choices/Options

|Value|Label|
|---|---|
|100000001|**People in my organization and guests**|
|100000002|**People in my organization, trusted organizations and guests**|
|100000003|**Everyone**|
|100000004|**People I invite**|
|100000005|**Only me**|

### <a name="BKMK_msevtmgt_autorecordingenabled"></a> msevtmgt_autorecordingenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record automatically**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_autorecordingenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_autorecordingenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_AVSupport"></a> msevtmgt_AVSupport

|Property|Value|
|---|---|
|Description|**Audio/video support**|
|DisplayName|**A/V support**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_avsupport`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_AVSupport Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_baserecurrentsessionid"></a> msevtmgt_baserecurrentsessionid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Base Recurrent SessionId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_baserecurrentsessionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_building"></a> msevtmgt_building

|Property|Value|
|---|---|
|Description||
|DisplayName|**Building**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_building`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_building|

### <a name="BKMK_msevtmgt_ByInvitationOnly"></a> msevtmgt_ByInvitationOnly

|Property|Value|
|---|---|
|Description|**Access is by invitation only**|
|DisplayName|**By invitation only**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_byinvitationonly`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000002|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_ByInvitationOnly Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_calendarcontent"></a> msevtmgt_calendarcontent

|Property|Value|
|---|---|
|Description|**Rich text calendar content for session.**|
|DisplayName|**HTML calendar content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_calendarcontent`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msevtmgt_calendarcontent_plaintext"></a> msevtmgt_calendarcontent_plaintext

|Property|Value|
|---|---|
|Description|**Plain text calendar content for sessions.**|
|DisplayName|**Text calendar content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_calendarcontent_plaintext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msevtmgt_CamerasPermitted"></a> msevtmgt_CamerasPermitted

|Property|Value|
|---|---|
|Description|**Are cameras permitted?**|
|DisplayName|**Cameras permitted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_cameraspermitted`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_CamerasPermitted Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_changemeetingoptions"></a> msevtmgt_changemeetingoptions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Change meeting options**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_changemeetingoptions`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_changemeetingoptions`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_CheckInCount"></a> msevtmgt_CheckInCount

|Property|Value|
|---|---|
|Description|**Check-in count**|
|DisplayName|**Check-in count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_checkincount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_creationsource"></a> msevtmgt_creationsource

|Property|Value|
|---|---|
|Description|**Creation source**|
|DisplayName|**Creation source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_creationsource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_creationsource`|

#### msevtmgt_creationsource Choices/Options

|Value|Label|
|---|---|
|100000001|**Dynamics**|
|100000002|**Microsoft Teams**|

### <a name="BKMK_msevtmgt_descriptorsyncstatus"></a> msevtmgt_descriptorsyncstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Descriptor sync status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_descriptorsyncstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_descriptorsyncstatus`|

#### msevtmgt_descriptorsyncstatus Choices/Options

|Value|Label|
|---|---|
|100000000|**Synced**|
|100000001|**Going live**|
|100000002|**Going live failed**|
|100000003|**Modifying capacity**|
|100000004|**Modifying capacity failed**|
|100000005|**Not Synced**|

### <a name="BKMK_msevtmgt_DetailedDescription"></a> msevtmgt_DetailedDescription

|Property|Value|
|---|---|
|Description|**Detailed description of the session**|
|DisplayName|**Detailed description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_detaileddescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_EndTime"></a> msevtmgt_EndTime

|Property|Value|
|---|---|
|Description|**End time of the session**|
|DisplayName|**End time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_endtime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_entryexitannouncementsenabled"></a> msevtmgt_entryexitannouncementsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Announce when callers join or leave**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_entryexitannouncementsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_entryexitannouncementsenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_Event"></a> msevtmgt_Event

|Property|Value|
|---|---|
|Description|**Unique identifier for the event associated with the event session**|
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_event`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_EventSpeakerId"></a> msevtmgt_EventSpeakerId

|Property|Value|
|---|---|
|Description|**Unique identifier for the speaker associated with the session**|
|DisplayName|**Event speaker**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventspeakerid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_speaker|

### <a name="BKMK_msevtmgt_ExternalUrl"></a> msevtmgt_ExternalUrl

|Property|Value|
|---|---|
|Description|**External URL for the session**|
|DisplayName|**Session URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_externalurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msevtmgt_FlipChart"></a> msevtmgt_FlipChart

|Property|Value|
|---|---|
|Description|**A flip-chart is available for the session**|
|DisplayName|**Flip-chart**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_flipchart`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_FlipChart Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_Industry"></a> msevtmgt_Industry

|Property|Value|
|---|---|
|Description|**Industry of the session**|
|DisplayName|**Industry**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_industry`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_industry`|

#### msevtmgt_Industry Choices/Options

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

### <a name="BKMK_msevtmgt_InternetConnection"></a> msevtmgt_InternetConnection

|Property|Value|
|---|---|
|Description|**Are internet connections available?**|
|DisplayName|**Internet connection**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_internetconnection`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_InternetConnection Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_isoutofsync"></a> msevtmgt_isoutofsync

|Property|Value|
|---|---|
|Description|**Field specifying if a streamed session is out of synchronization with its provider.**|
|DisplayName|**Session is out of sync**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_isoutofsync`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_isoutofsync`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_Keywords"></a> msevtmgt_Keywords

|Property|Value|
|---|---|
|Description|**A comma-delimited list of keywords for this session**|
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
|MaxLength|500|

### <a name="BKMK_msevtmgt_Language"></a> msevtmgt_Language

|Property|Value|
|---|---|
|Description|**The language of the webinar**|
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_language`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_webinarlanguage`|

#### msevtmgt_Language Choices/Options

|Value|Label|
|---|---|
|100000000|**English**|
|100000001|**French**|
|100000002|**German**|
|100000003|**Spanish**|
|100000004|**Italian**|
|100000005|**Russian**|
|100000006|**Dutch**|
|100000007|**Turkish**|
|100000008|**Portuguese**|
|100000009|**Chinese (Simplified)**|
|100000010|**Japanese**|
|100000011|**Korean**|
|100000012|**Hebrew**|
|100000013|**Chinese (Traditional)**|

### <a name="BKMK_msevtmgt_lastteamssyncdate"></a> msevtmgt_lastteamssyncdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last sync with Teams date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_lastteamssyncdate`|
|RequiredLevel|Recommended|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_layout"></a> msevtmgt_layout

|Property|Value|
|---|---|
|Description||
|DisplayName|**Layout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_layout`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_layout|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Session title**|
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

### <a name="BKMK_msevtmgt_NDA"></a> msevtmgt_NDA

|Property|Value|
|---|---|
|Description|**Non disclosure agreement**|
|DisplayName|**NDA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_nda`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_NDA Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_PassSessions"></a> msevtmgt_PassSessions

|Property|Value|
|---|---|
|Description|**Unique identifier for the product associated with the session**|
|DisplayName|**Product pass sessions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_passsessions`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_pass|

### <a name="BKMK_msevtmgt_PresentationManagerUrl"></a> msevtmgt_PresentationManagerUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Presentation manager URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_presentationmanagerurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msevtmgt_previousnumberoffreeslots"></a> msevtmgt_previousnumberoffreeslots

|Property|Value|
|---|---|
|Description||
|DisplayName|**Previous number of free slots**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_previousnumberoffreeslots`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_Producer"></a> msevtmgt_Producer

|Property|Value|
|---|---|
|Description|**Producer of the session**|
|DisplayName|**Producer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_producer`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_eventteammember|

### <a name="BKMK_msevtmgt_PublishStatus"></a> msevtmgt_PublishStatus

|Property|Value|
|---|---|
|Description|**Publish status of the session**|
|DisplayName|**Publish status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publishstatus`|
|RequiredLevel|None|
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

### <a name="BKMK_msevtmgt_qna"></a> msevtmgt_qna

|Property|Value|
|---|---|
|Description||
|DisplayName|**Do you want to enable Q/A for this event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_qna`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_qna`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_recordingforattendees"></a> msevtmgt_recordingforattendees

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recording available to attendees**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_recordingforattendees`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_recordingforattendees`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_recordingforproducersandspeakers"></a> msevtmgt_recordingforproducersandspeakers

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recording available to producers and speakers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_recordingforproducersandspeakers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_recordingforproducersandspeakers`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_RecordingsPermitted"></a> msevtmgt_RecordingsPermitted

|Property|Value|
|---|---|
|Description|**Are recordings permitted?**|
|DisplayName|**Recordings permitted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_recordingspermitted`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_RecordingsPermitted Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_recurrencepattern"></a> msevtmgt_recurrencepattern

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recurrence pattern**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_recurrencepattern`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msevtmgt_RegistrationCount"></a> msevtmgt_RegistrationCount

|Property|Value|
|---|---|
|Description|**Number of registrations for this session**|
|DisplayName|**Registration count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_registrationcounterlock"></a> msevtmgt_registrationcounterlock

|Property|Value|
|---|---|
|Description||
|DisplayName|**Session registration counter lock**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationcounterlock`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_room"></a> msevtmgt_room

|Property|Value|
|---|---|
|Description||
|DisplayName|**Room**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_room`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_room|

### <a name="BKMK_msevtmgt_SessionCode"></a> msevtmgt_SessionCode

|Property|Value|
|---|---|
|Description|**A code for the session**|
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

### <a name="BKMK_msevtmgt_sessionformat"></a> msevtmgt_sessionformat

|Property|Value|
|---|---|
|Description||
|DisplayName|**Session Format**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionformat`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_eventformat`|

#### msevtmgt_sessionformat Choices/Options

|Value|Label|
|---|---|
|100000001|**On site**|
|100000002|**Webinar**|
|100000003|**Hybrid**|

### <a name="BKMK_msevtmgt_SessionId"></a> msevtmgt_SessionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Session**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_SessionMaxCapacity"></a> msevtmgt_SessionMaxCapacity

|Property|Value|
|---|---|
|Description|**Maximum capacity of the session**|
|DisplayName|**Session max. capacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionmaxcapacity`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|50000|
|MinValue|0|

### <a name="BKMK_msevtmgt_SessionObjectives"></a> msevtmgt_SessionObjectives

|Property|Value|
|---|---|
|Description|**Objectives of the session**|
|DisplayName|**Session Objectives**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionobjectives`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_SessionPreRequisites"></a> msevtmgt_SessionPreRequisites

|Property|Value|
|---|---|
|Description|**Prerequisites for the session**|
|DisplayName|**Session Prerequisites**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionprerequisites`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_SessionSummary"></a> msevtmgt_SessionSummary

|Property|Value|
|---|---|
|Description|**Summary of the session**|
|DisplayName|**Session summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sessionsummary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|700|

### <a name="BKMK_msevtmgt_SessionType"></a> msevtmgt_SessionType

|Property|Value|
|---|---|
|Description|**Type of the session**|
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

### <a name="BKMK_msevtmgt_StartTime"></a> msevtmgt_StartTime

|Property|Value|
|---|---|
|Description|**The time the session will begin**|
|DisplayName|**Start time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_starttime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_streamingenabled"></a> msevtmgt_streamingenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Streamed session**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_streamingenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_streamingenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_streamingprovider"></a> msevtmgt_streamingprovider

|Property|Value|
|---|---|
|Description||
|DisplayName|**Streaming provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_streamingprovider`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_streamingprovider`|

#### msevtmgt_streamingprovider Choices/Options

|Value|Label|
|---|---|
|100000001|**Teams Live Events**|
|100000002|**Teams Meetings**|
|100000003|**Other**|
|100000004|**Teams Webinars**|
|100000005|**Teams Virtual Events**|
|100000006|**Teams Town Hall**|

### <a name="BKMK_msevtmgt_streamowner"></a> msevtmgt_streamowner

|Property|Value|
|---|---|
|Description|**User that owns the streamed session.**|
|DisplayName|**Streamed session owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_streamowner`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msevtmgt_teamsinvitationhtml"></a> msevtmgt_teamsinvitationhtml

|Property|Value|
|---|---|
|Description||
|DisplayName|**Invitation HTML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_teamsinvitationhtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msevtmgt_Venue"></a> msevtmgt_Venue

|Property|Value|
|---|---|
|Description|**Active venue records for this session**|
|DisplayName|**Venue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_venue`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_venue|

### <a name="BKMK_msevtmgt_VideoConferencing"></a> msevtmgt_VideoConferencing

|Property|Value|
|---|---|
|Description|**Video conferencing is available for the session**|
|DisplayName|**Video conferencing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_videoconferencing`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_VideoConferencing Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_WebinarConfigurationId"></a> msevtmgt_WebinarConfigurationId

|Property|Value|
|---|---|
|Description|**Webinar configuration**|
|DisplayName|**Webinar configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarconfigurationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_webinarconfiguration|

### <a name="BKMK_msevtmgt_WebinarID"></a> msevtmgt_WebinarID

|Property|Value|
|---|---|
|Description|**Webinar ID of the session**|
|DisplayName|**Webinar ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_webinarnotificationseen"></a> msevtmgt_webinarnotificationseen

|Property|Value|
|---|---|
|Description|**Indicates whether the webinar notification has been seen**|
|DisplayName|**Webinar notification seen**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarnotificationseen`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_session_msevtmgt_webinarnotificationseen`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_webinaroperation"></a> msevtmgt_webinaroperation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar operation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinaroperation`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_webinarstatus"></a> msevtmgt_webinarstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_webinarstatusreason"></a> msevtmgt_webinarstatusreason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarstatusreason`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msevtmgt_WebinarType"></a> msevtmgt_WebinarType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinartype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_webinartype|

### <a name="BKMK_msevtmgt_webinarurl"></a> msevtmgt_webinarurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_WhiteBoard"></a> msevtmgt_WhiteBoard

|Property|Value|
|---|---|
|Description|**A white board is available for the session**|
|DisplayName|**Whiteboard**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_whiteboard`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_WhiteBoard Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

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
|Description|**Status of the session**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_session_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the session**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_session_statuscode`|

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
- [msevtmgt_DurationMins](#BKMK_msevtmgt_DurationMins)
- [msevtmgt_TotalNumberOfQuestionsAsked](#BKMK_msevtmgt_TotalNumberOfQuestionsAsked)
- [msevtmgt_TotalNumberOfQuestionsAsked_Date](#BKMK_msevtmgt_TotalNumberOfQuestionsAsked_Date)
- [msevtmgt_TotalNumberOfQuestionsAsked_State](#BKMK_msevtmgt_TotalNumberOfQuestionsAsked_State)
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

### <a name="BKMK_msevtmgt_DurationMins"></a> msevtmgt_DurationMins

|Property|Value|
|---|---|
|Description|**Session duration in minutes**|
|DisplayName|**Duration (minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_durationmins`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_TotalNumberOfQuestionsAsked"></a> msevtmgt_TotalNumberOfQuestionsAsked

|Property|Value|
|---|---|
|Description|**Total numbers of questions asked at the session**|
|DisplayName|**Total number of questions asked**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalnumberofquestionsasked`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_TotalNumberOfQuestionsAsked_Date"></a> msevtmgt_TotalNumberOfQuestionsAsked_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Total number of questions asked.**|
|DisplayName|**Total number of questions asked (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalnumberofquestionsasked_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_TotalNumberOfQuestionsAsked_State"></a> msevtmgt_TotalNumberOfQuestionsAsked_State

|Property|Value|
|---|---|
|Description|**State of rollup field Total number of questions asked.**|
|DisplayName|**Total number of questions asked (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalnumberofquestionsasked_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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

- [business_unit_msevtmgt_session](#BKMK_business_unit_msevtmgt_session)
- [lk_msevtmgt_session_createdby](#BKMK_lk_msevtmgt_session_createdby)
- [lk_msevtmgt_session_createdonbehalfby](#BKMK_lk_msevtmgt_session_createdonbehalfby)
- [lk_msevtmgt_session_modifiedby](#BKMK_lk_msevtmgt_session_modifiedby)
- [lk_msevtmgt_session_modifiedonbehalfby](#BKMK_lk_msevtmgt_session_modifiedonbehalfby)
- [msevtmgt_event_msevtmgt_session_Event](#BKMK_msevtmgt_event_msevtmgt_session_Event)
- [msevtmgt_EventTeamMember_msevtmgt_Session_Producer](#BKMK_msevtmgt_EventTeamMember_msevtmgt_Session_Producer)
- [msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType](#BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType)
- [msevtmgt_pass_msevtmgt_session_PassSessions](#BKMK_msevtmgt_pass_msevtmgt_session_PassSessions)
- [msevtmgt_session_building](#BKMK_msevtmgt_session_building)
- [msevtmgt_session_layout](#BKMK_msevtmgt_session_layout)
- [msevtmgt_session_room](#BKMK_msevtmgt_session_room)
- [msevtmgt_speaker_msevtmgt_Session](#BKMK_msevtmgt_speaker_msevtmgt_Session)
- [msevtmgt_systemuser_msevtmgt_session_streamowner](#BKMK_msevtmgt_systemuser_msevtmgt_session_streamowner)
- [msevtmgt_Venue_msevtmgt_Session_Venue](#BKMK_msevtmgt_Venue_msevtmgt_Session_Venue)
- [msevtmgt_webinarconfiguration_msevtmgt_session_Web](#BKMK_msevtmgt_webinarconfiguration_msevtmgt_session_Web)
- [owner_msevtmgt_session](#BKMK_owner_msevtmgt_session)
- [team_msevtmgt_session](#BKMK_team_msevtmgt_session)
- [user_msevtmgt_session](#BKMK_user_msevtmgt_session)

### <a name="BKMK_business_unit_msevtmgt_session"></a> business_unit_msevtmgt_session

One-To-Many Relationship: [businessunit business_unit_msevtmgt_session](businessunit.md#BKMK_business_unit_msevtmgt_session)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_session_createdby"></a> lk_msevtmgt_session_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_session_createdby](systemuser.md#BKMK_lk_msevtmgt_session_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_session_createdonbehalfby"></a> lk_msevtmgt_session_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_session_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_session_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_session_modifiedby"></a> lk_msevtmgt_session_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_session_modifiedby](systemuser.md#BKMK_lk_msevtmgt_session_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_session_modifiedonbehalfby"></a> lk_msevtmgt_session_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_session_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_session_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_event_msevtmgt_session_Event"></a> msevtmgt_event_msevtmgt_session_Event

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_msevtmgt_session_Event](msevtmgt_event.md#BKMK_msevtmgt_event_msevtmgt_session_Event)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Event`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_EventTeamMember_msevtmgt_Session_Producer"></a> msevtmgt_EventTeamMember_msevtmgt_Session_Producer

One-To-Many Relationship: [msevtmgt_eventteammember msevtmgt_EventTeamMember_msevtmgt_Session_Producer](msevtmgt_eventteammember.md#BKMK_msevtmgt_EventTeamMember_msevtmgt_Session_Producer)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventteammember`|
|ReferencedAttribute|`msevtmgt_eventteammemberid`|
|ReferencingAttribute|`msevtmgt_producer`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Producer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType"></a> msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType

One-To-Many Relationship: [msevtmgt_webinartype msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType](msevtmgt_webinartype.md#BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinartype`|
|ReferencedAttribute|`msevtmgt_webinartypeid`|
|ReferencingAttribute|`msevtmgt_webinartype`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_WebinarType`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_pass_msevtmgt_session_PassSessions"></a> msevtmgt_pass_msevtmgt_session_PassSessions

One-To-Many Relationship: [msevtmgt_pass msevtmgt_pass_msevtmgt_session_PassSessions](msevtmgt_pass.md#BKMK_msevtmgt_pass_msevtmgt_session_PassSessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_pass`|
|ReferencedAttribute|`msevtmgt_passid`|
|ReferencingAttribute|`msevtmgt_passsessions`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_passsessions`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_session_building"></a> msevtmgt_session_building

One-To-Many Relationship: [msevtmgt_building msevtmgt_session_building](msevtmgt_building.md#BKMK_msevtmgt_session_building)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_building`|
|ReferencedAttribute|`msevtmgt_buildingid`|
|ReferencingAttribute|`msevtmgt_building`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_building`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_session_layout"></a> msevtmgt_session_layout

One-To-Many Relationship: [msevtmgt_layout msevtmgt_session_layout](msevtmgt_layout.md#BKMK_msevtmgt_session_layout)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`msevtmgt_layout`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_layout`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_session_room"></a> msevtmgt_session_room

One-To-Many Relationship: [msevtmgt_room msevtmgt_session_room](msevtmgt_room.md#BKMK_msevtmgt_session_room)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`msevtmgt_room`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_room`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_speaker_msevtmgt_Session"></a> msevtmgt_speaker_msevtmgt_Session

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_msevtmgt_Session](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_msevtmgt_Session)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`msevtmgt_eventspeakerid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_EventSpeakerId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_systemuser_msevtmgt_session_streamowner"></a> msevtmgt_systemuser_msevtmgt_session_streamowner

One-To-Many Relationship: [systemuser msevtmgt_systemuser_msevtmgt_session_streamowner](systemuser.md#BKMK_msevtmgt_systemuser_msevtmgt_session_streamowner)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msevtmgt_streamowner`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_streamowner`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_Venue_msevtmgt_Session_Venue"></a> msevtmgt_Venue_msevtmgt_Session_Venue

One-To-Many Relationship: [msevtmgt_venue msevtmgt_Venue_msevtmgt_Session_Venue](msevtmgt_venue.md#BKMK_msevtmgt_Venue_msevtmgt_Session_Venue)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`msevtmgt_venue`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Venue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msevtmgt_session_Web"></a> msevtmgt_webinarconfiguration_msevtmgt_session_Web

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_msevtmgt_session_Web](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_msevtmgt_session_Web)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_WebinarConfigurationId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_session"></a> owner_msevtmgt_session

One-To-Many Relationship: [owner owner_msevtmgt_session](owner.md#BKMK_owner_msevtmgt_session)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_session"></a> team_msevtmgt_session

One-To-Many Relationship: [team team_msevtmgt_session](team.md#BKMK_team_msevtmgt_session)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_session"></a> user_msevtmgt_session

One-To-Many Relationship: [systemuser user_msevtmgt_session](systemuser.md#BKMK_user_msevtmgt_session)

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

- [msevtmgt_msevtmgt_session_msevtmgt_speakerengagement_Session](#BKMK_msevtmgt_msevtmgt_session_msevtmgt_speakerengagement_Session)
- [msevtmgt_session_ActivityPointers](#BKMK_msevtmgt_session_ActivityPointers)
- [msevtmgt_session_adx_alertsubscriptions](#BKMK_msevtmgt_session_adx_alertsubscriptions)
- [msevtmgt_session_adx_inviteredemptions](#BKMK_msevtmgt_session_adx_inviteredemptions)
- [msevtmgt_session_adx_portalcomments](#BKMK_msevtmgt_session_adx_portalcomments)
- [msevtmgt_session_Annotations](#BKMK_msevtmgt_session_Annotations)
- [msevtmgt_session_Appointments](#BKMK_msevtmgt_session_Appointments)
- [msevtmgt_session_AsyncOperations](#BKMK_msevtmgt_session_AsyncOperations)
- [msevtmgt_session_BulkDeleteFailures](#BKMK_msevtmgt_session_BulkDeleteFailures)
- [msevtmgt_session_chats](#BKMK_msevtmgt_session_chats)
- [msevtmgt_session_Emails](#BKMK_msevtmgt_session_Emails)
- [msevtmgt_session_Faxes](#BKMK_msevtmgt_session_Faxes)
- [msevtmgt_session_Letters](#BKMK_msevtmgt_session_Letters)
- [msevtmgt_session_li_inmails](#BKMK_msevtmgt_session_li_inmails)
- [msevtmgt_session_li_messages](#BKMK_msevtmgt_session_li_messages)
- [msevtmgt_session_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_session_li_pointdrivepresentationvieweds)
- [msevtmgt_session_MailboxTrackingFolders](#BKMK_msevtmgt_session_MailboxTrackingFolders)
- [msevtmgt_session_msdyn_bookingalerts](#BKMK_msevtmgt_session_msdyn_bookingalerts)
- [msevtmgt_session_msdyn_copilottranscripts](#BKMK_msevtmgt_session_msdyn_copilottranscripts)
- [msevtmgt_session_msdyn_ocliveworkitems](#BKMK_msevtmgt_session_msdyn_ocliveworkitems)
- [msevtmgt_session_msdyn_ocoutboundmessages](#BKMK_msevtmgt_session_msdyn_ocoutboundmessages)
- [msevtmgt_session_msdyn_ocsessions](#BKMK_msevtmgt_session_msdyn_ocsessions)
- [msevtmgt_session_msdyn_ocvoicemails](#BKMK_msevtmgt_session_msdyn_ocvoicemails)
- [msevtmgt_session_msevtmgt_checkin_SessionAttended](#BKMK_msevtmgt_session_msevtmgt_checkin_SessionAttended)
- [msevtmgt_session_msevtmgt_roomreservation](#BKMK_msevtmgt_session_msevtmgt_roomreservation)
- [msevtmgt_session_msevtmgt_sessionregistration](#BKMK_msevtmgt_session_msevtmgt_sessionregistration)
- [msevtmgt_session_msfp_alerts](#BKMK_msevtmgt_session_msfp_alerts)
- [msevtmgt_session_msfp_surveyinvites](#BKMK_msevtmgt_session_msfp_surveyinvites)
- [msevtmgt_session_msfp_surveyresponses](#BKMK_msevtmgt_session_msfp_surveyresponses)
- [msevtmgt_session_PhoneCalls](#BKMK_msevtmgt_session_PhoneCalls)
- [msevtmgt_session_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_session_PrincipalObjectAttributeAccesses)
- [msevtmgt_session_ProcessSession](#BKMK_msevtmgt_session_ProcessSession)
- [msevtmgt_session_RecurringAppointmentMasters](#BKMK_msevtmgt_session_RecurringAppointmentMasters)
- [msevtmgt_session_ServiceAppointments](#BKMK_msevtmgt_session_ServiceAppointments)
- [msevtmgt_session_SocialActivities](#BKMK_msevtmgt_session_SocialActivities)
- [msevtmgt_session_SyncErrors](#BKMK_msevtmgt_session_SyncErrors)
- [msevtmgt_session_Tasks](#BKMK_msevtmgt_session_Tasks)
- [msevtmgt_session_waitlistitem](#BKMK_msevtmgt_session_waitlistitem)

### <a name="BKMK_msevtmgt_msevtmgt_session_msevtmgt_speakerengagement_Session"></a> msevtmgt_msevtmgt_session_msevtmgt_speakerengagement_Session

Many-To-One Relationship: [msevtmgt_speakerengagement msevtmgt_msevtmgt_session_msevtmgt_speakerengagement_Session](msevtmgt_speakerengagement.md#BKMK_msevtmgt_msevtmgt_session_msevtmgt_speakerengagement_Session)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speakerengagement`|
|ReferencingAttribute|`msevtmgt_session`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_session_msevtmgt_speakerengagement_Session`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_ActivityPointers"></a> msevtmgt_session_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_session_ActivityPointers](activitypointer.md#BKMK_msevtmgt_session_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_adx_alertsubscriptions"></a> msevtmgt_session_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_session_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_session_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_adx_inviteredemptions"></a> msevtmgt_session_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_session_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_session_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_adx_portalcomments"></a> msevtmgt_session_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_session_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_session_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_Annotations"></a> msevtmgt_session_Annotations

Many-To-One Relationship: [annotation msevtmgt_session_Annotations](annotation.md#BKMK_msevtmgt_session_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_Appointments"></a> msevtmgt_session_Appointments

Many-To-One Relationship: [appointment msevtmgt_session_Appointments](appointment.md#BKMK_msevtmgt_session_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_AsyncOperations"></a> msevtmgt_session_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_session_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_session_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_BulkDeleteFailures"></a> msevtmgt_session_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_session_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_session_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_chats"></a> msevtmgt_session_chats

Many-To-One Relationship: [chat msevtmgt_session_chats](chat.md#BKMK_msevtmgt_session_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_Emails"></a> msevtmgt_session_Emails

Many-To-One Relationship: [email msevtmgt_session_Emails](email.md#BKMK_msevtmgt_session_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_Faxes"></a> msevtmgt_session_Faxes

Many-To-One Relationship: [fax msevtmgt_session_Faxes](fax.md#BKMK_msevtmgt_session_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_Letters"></a> msevtmgt_session_Letters

Many-To-One Relationship: [letter msevtmgt_session_Letters](letter.md#BKMK_msevtmgt_session_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_li_inmails"></a> msevtmgt_session_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_session_li_inmails](li_inmail.md#BKMK_msevtmgt_session_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_li_messages"></a> msevtmgt_session_li_messages

Many-To-One Relationship: [li_message msevtmgt_session_li_messages](li_message.md#BKMK_msevtmgt_session_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_li_pointdrivepresentationvieweds"></a> msevtmgt_session_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_session_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_session_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_MailboxTrackingFolders"></a> msevtmgt_session_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_session_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_session_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msdyn_bookingalerts"></a> msevtmgt_session_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_session_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_session_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msdyn_copilottranscripts"></a> msevtmgt_session_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_session_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_session_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msdyn_ocliveworkitems"></a> msevtmgt_session_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_session_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_session_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msdyn_ocoutboundmessages"></a> msevtmgt_session_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_session_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_session_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msdyn_ocsessions"></a> msevtmgt_session_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_session_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_session_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msdyn_ocvoicemails"></a> msevtmgt_session_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_session_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_session_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msevtmgt_checkin_SessionAttended"></a> msevtmgt_session_msevtmgt_checkin_SessionAttended

Many-To-One Relationship: [msevtmgt_checkin msevtmgt_session_msevtmgt_checkin_SessionAttended](msevtmgt_checkin.md#BKMK_msevtmgt_session_msevtmgt_checkin_SessionAttended)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_checkin`|
|ReferencingAttribute|`msevtmgt_sessionattended`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msevtmgt_checkin_SessionAttended`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msevtmgt_roomreservation"></a> msevtmgt_session_msevtmgt_roomreservation

Many-To-One Relationship: [msevtmgt_roomreservation msevtmgt_session_msevtmgt_roomreservation](msevtmgt_roomreservation.md#BKMK_msevtmgt_session_msevtmgt_roomreservation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_roomreservation`|
|ReferencingAttribute|`msevtmgt_session`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msevtmgt_roomreservation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msevtmgt_sessionregistration"></a> msevtmgt_session_msevtmgt_sessionregistration

Many-To-One Relationship: [msevtmgt_sessionregistration msevtmgt_session_msevtmgt_sessionregistration](msevtmgt_sessionregistration.md#BKMK_msevtmgt_session_msevtmgt_sessionregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sessionregistration`|
|ReferencingAttribute|`msevtmgt_sessionid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msevtmgt_sessionregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msfp_alerts"></a> msevtmgt_session_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_session_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_session_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msfp_surveyinvites"></a> msevtmgt_session_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_session_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_session_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msfp_surveyresponses"></a> msevtmgt_session_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_session_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_session_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_PhoneCalls"></a> msevtmgt_session_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_session_PhoneCalls](phonecall.md#BKMK_msevtmgt_session_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_PrincipalObjectAttributeAccesses"></a> msevtmgt_session_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_session_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_session_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_ProcessSession"></a> msevtmgt_session_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_session_ProcessSession](processsession.md#BKMK_msevtmgt_session_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_RecurringAppointmentMasters"></a> msevtmgt_session_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_session_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_session_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_ServiceAppointments"></a> msevtmgt_session_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_session_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_session_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_SocialActivities"></a> msevtmgt_session_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_session_SocialActivities](socialactivity.md#BKMK_msevtmgt_session_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_SyncErrors"></a> msevtmgt_session_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_session_SyncErrors](syncerror.md#BKMK_msevtmgt_session_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_Tasks"></a> msevtmgt_session_Tasks

Many-To-One Relationship: [task msevtmgt_session_Tasks](task.md#BKMK_msevtmgt_session_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_waitlistitem"></a> msevtmgt_session_waitlistitem

Many-To-One Relationship: [msevtmgt_waitlistitem msevtmgt_session_waitlistitem](msevtmgt_waitlistitem.md#BKMK_msevtmgt_session_waitlistitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_waitlistitem`|
|ReferencingAttribute|`msevtmgt_session`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_waitlistitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msevtmgt_eventregistration_msevtmgt_session](#BKMK_msevtmgt_eventregistration_msevtmgt_session)
- [msevtmgt_msevtmgt_session_msevtmgt_teammember](#BKMK_msevtmgt_msevtmgt_session_msevtmgt_teammember)
- [msevtmgt_pass_msevtmgt_session](#BKMK_msevtmgt_pass_msevtmgt_session)
- [msevtmgt_session_msevtmgt_attendeepass](#BKMK_msevtmgt_session_msevtmgt_attendeepass)
- [msevtmgt_session_msevtmgt_session](#BKMK_msevtmgt_session_msevtmgt_session)
- [msevtmgt_session_msevtmgt_speaker](#BKMK_msevtmgt_session_msevtmgt_speaker)
- [msevtmgt_sessiontrack_msevtmgt_session](#BKMK_msevtmgt_sessiontrack_msevtmgt_session)

### <a name="BKMK_msevtmgt_eventregistration_msevtmgt_session"></a> msevtmgt_eventregistration_msevtmgt_session

See [msevtmgt_eventregistration msevtmgt_eventregistration_msevtmgt_session Many-To-Many Relationship](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_msevtmgt_session)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_eventregistration_msevtmgt_session`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_eventregistration_msevtmgt_session`|
|IntersectAttribute|`msevtmgt_sessionid`|
|NavigationPropertyName|`msevtmgt_eventregistration_msevtmgt_session`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_session_msevtmgt_teammember"></a> msevtmgt_msevtmgt_session_msevtmgt_teammember

See [msevtmgt_eventteammember msevtmgt_msevtmgt_session_msevtmgt_teammember Many-To-Many Relationship](msevtmgt_eventteammember.md#BKMK_msevtmgt_msevtmgt_session_msevtmgt_teammember)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_msevtmgt_session_msevtmgt_teammember`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_msevtmgt_session_msevtmgt_teammember`|
|IntersectAttribute|`msevtmgt_sessionid`|
|NavigationPropertyName|`msevtmgt_msevtmgt_session_msevtmgt_teammember`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_pass_msevtmgt_session"></a> msevtmgt_pass_msevtmgt_session

See [msevtmgt_pass msevtmgt_pass_msevtmgt_session Many-To-Many Relationship](msevtmgt_pass.md#BKMK_msevtmgt_pass_msevtmgt_session)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_pass_msevtmgt_session`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_pass_msevtmgt_session`|
|IntersectAttribute|`msevtmgt_sessionid`|
|NavigationPropertyName|`msevtmgt_pass_msevtmgt_session`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msevtmgt_attendeepass"></a> msevtmgt_session_msevtmgt_attendeepass

See [msevtmgt_attendeepass msevtmgt_session_msevtmgt_attendeepass Many-To-Many Relationship](msevtmgt_attendeepass.md#BKMK_msevtmgt_session_msevtmgt_attendeepass)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_session_msevtmgt_attendeepass`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_session_msevtmgt_attendeepass`|
|IntersectAttribute|`msevtmgt_sessionid`|
|NavigationPropertyName|`msevtmgt_session_msevtmgt_attendeepass`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msevtmgt_session"></a> msevtmgt_session_msevtmgt_session

This is a self-referencing many-to-many relationship.

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_session_msevtmgt_session`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_session_msevtmgt_session`|
|Entity1IntersectAttribute|`msevtmgt_sessionidone`|
|Entity2IntersectAttribute|`msevtmgt_sessionidtwo`|
|Entity1NavigationPropertyName|`msevtmgt_session_msevtmgt_session`|
|Entity2NavigationPropertyName|`msevtmgt_session_msevtmgt_session`|
|Entity1AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|
|Entity2AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_msevtmgt_speaker"></a> msevtmgt_session_msevtmgt_speaker

See [msevtmgt_speaker msevtmgt_session_msevtmgt_speaker Many-To-Many Relationship](msevtmgt_speaker.md#BKMK_msevtmgt_session_msevtmgt_speaker)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_session_msevtmgt_speaker`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_session_msevtmgt_speaker`|
|IntersectAttribute|`msevtmgt_sessionid`|
|NavigationPropertyName|`msevtmgt_session_msevtmgt_speaker`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_sessiontrack_msevtmgt_session"></a> msevtmgt_sessiontrack_msevtmgt_session

See [msevtmgt_sessiontrack msevtmgt_sessiontrack_msevtmgt_session Many-To-Many Relationship](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_msevtmgt_session)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_sessiontrack_msevtmgt_session`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_sessiontrack_msevtmgt_session`|
|IntersectAttribute|`msevtmgt_sessionid`|
|NavigationPropertyName|`msevtmgt_sessiontrack_msevtmgt_session`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

