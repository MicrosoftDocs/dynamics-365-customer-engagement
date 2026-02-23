---
title: "Voice Channel Setting (msdyn_ocvoicechannelsetting) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Voice Channel Setting (msdyn_ocvoicechannelsetting) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Voice Channel Setting (msdyn_ocvoicechannelsetting) table/entity reference (Microsoft Dynamics 365 Customer Service)



## Messages

The following table lists the messages for the Voice Channel Setting (msdyn_ocvoicechannelsetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocvoicechannelsettings(*msdyn_ocvoicechannelsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocvoicechannelsettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocvoicechannelsettings(*msdyn_ocvoicechannelsettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyn_TelephonyVoiceChannelProvisionAction`<br />Event: False |**msdyn_TelephonyVoiceChannelProvisionAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocvoicechannelsettings(*msdyn_ocvoicechannelsettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocvoicechannelsettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocvoicechannelsettings(*msdyn_ocvoicechannelsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocvoicechannelsettings(*msdyn_ocvoicechannelsettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocvoicechannelsettings(*msdyn_ocvoicechannelsettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Voice Channel Setting (msdyn_ocvoicechannelsetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Voice Channel Setting** |
| **DisplayCollectionName** | **Voice Channel Settings** |
| **SchemaName** | `msdyn_ocvoicechannelsetting` |
| **CollectionSchemaName** | `msdyn_ocvoicechannelsettings` |
| **EntitySetName** | `msdyn_ocvoicechannelsettings`|
| **LogicalName** | `msdyn_ocvoicechannelsetting` |
| **LogicalCollectionName** | `msdyn_ocvoicechannelsettings` |
| **PrimaryIdAttribute** | `msdyn_ocvoicechannelsettingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_agentexternalparticipantcontrolenabled](#BKMK_msdyn_agentexternalparticipantcontrolenabled)
- [msdyn_agentexternalparticipanttransfercontrolenabled](#BKMK_msdyn_agentexternalparticipanttransfercontrolenabled)
- [msdyn_agentexternalteamsparticipantcontrolenabled](#BKMK_msdyn_agentexternalteamsparticipantcontrolenabled)
- [msdyn_agentexternalteamsparticipanttransfercontrolenabled](#BKMK_msdyn_agentexternalteamsparticipanttransfercontrolenabled)
- [msdyn_agentrecordingcontrolsenabled](#BKMK_msdyn_agentrecordingcontrolsenabled)
- [msdyn_agenttranscriptioncontrolsenabled](#BKMK_msdyn_agenttranscriptioncontrolsenabled)
- [msdyn_announceaveragewaittime](#BKMK_msdyn_announceaveragewaittime)
- [msdyn_announcepositioninqueue](#BKMK_msdyn_announcepositioninqueue)
- [msdyn_calleridname](#BKMK_msdyn_calleridname)
- [msdyn_calleridphonenumberid](#BKMK_msdyn_calleridphonenumberid)
- [msdyn_enablepostcallsurvey](#BKMK_msdyn_enablepostcallsurvey)
- [msdyn_enablepostcallsurveyduration](#BKMK_msdyn_enablepostcallsurveyduration)
- [msdyn_enablestoprecordingtranscriptiononhold](#BKMK_msdyn_enablestoprecordingtranscriptiononhold)
- [msdyn_inboundurl](#BKMK_msdyn_inboundurl)
- [msdyn_isanonymouscallerid](#BKMK_msdyn_isanonymouscallerid)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocvoicechannelsettingId](#BKMK_msdyn_ocvoicechannelsettingId)
- [msdyn_operatinghoursid](#BKMK_msdyn_operatinghoursid)
- [msdyn_outboundcallregionallowlist](#BKMK_msdyn_outboundcallregionallowlist)
- [msdyn_phonenumberid](#BKMK_msdyn_phonenumberid)
- [msdyn_postcallsurveyendtime](#BKMK_msdyn_postcallsurveyendtime)
- [msdyn_postcallsurveyfrequency](#BKMK_msdyn_postcallsurveyfrequency)
- [msdyn_postcallsurveystarttime](#BKMK_msdyn_postcallsurveystarttime)
- [msdyn_recordingenabled](#BKMK_msdyn_recordingenabled)
- [msdyn_recordingmode](#BKMK_msdyn_recordingmode)
- [msdyn_showhidetranscriptionfeaturepreview](#BKMK_msdyn_showhidetranscriptionfeaturepreview)
- [msdyn_skipwaitmusicforivr](#BKMK_msdyn_skipwaitmusicforivr)
- [msdyn_stoptranscriptionandrecordingafterpstntransfer](#BKMK_msdyn_stoptranscriptionandrecordingafterpstntransfer)
- [msdyn_stoptranscriptionandrecordingafterteamstransfer](#BKMK_msdyn_stoptranscriptionandrecordingafterteamstransfer)
- [msdyn_transcriptionenabled](#BKMK_msdyn_transcriptionenabled)
- [msdyn_transcriptionmode](#BKMK_msdyn_transcriptionmode)
- [msdyn_transcriptionshowbydefault](#BKMK_msdyn_transcriptionshowbydefault)
- [msdyn_usebridgetransferforpstntransfer](#BKMK_msdyn_usebridgetransferforpstntransfer)
- [msdyn_usebridgetransferforteamstransfer](#BKMK_msdyn_usebridgetransferforteamstransfer)
- [msdyn_voiceauthenticationsettingsid](#BKMK_msdyn_voiceauthenticationsettingsid)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_agentexternalparticipantcontrolenabled"></a> msdyn_agentexternalparticipantcontrolenabled

|Property|Value|
|---|---|
|Description|**Enable agent control to add an external participant**|
|DisplayName|**Enable agent control to add an external participant**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentexternalparticipantcontrolenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_agentexternalparticipantcontrolenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agentexternalparticipanttransfercontrolenabled"></a> msdyn_agentexternalparticipanttransfercontrolenabled

|Property|Value|
|---|---|
|Description|**Enable agent external participant transfer control for external phone numbers**|
|DisplayName|**Enable agent external participant transfer control for external phone numbers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentexternalparticipanttransfercontrolenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_agentexternalparticipanttransfercontrolenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agentexternalteamsparticipantcontrolenabled"></a> msdyn_agentexternalteamsparticipantcontrolenabled

|Property|Value|
|---|---|
|Description|**Enable agent control to add an external participant on Teams**|
|DisplayName|**Enable agent control to add an external participant on Teams**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentexternalteamsparticipantcontrolenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_agentexternalteamsparticipantcontrolenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agentexternalteamsparticipanttransfercontrolenabled"></a> msdyn_agentexternalteamsparticipanttransfercontrolenabled

|Property|Value|
|---|---|
|Description|**Enable agent external participant transfer control for external Microsoft Teams users**|
|DisplayName|**Enable agent external participant transfer control for external Microsoft Teams users**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentexternalteamsparticipanttransfercontrolenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_agentexternalteamsparticipanttransfercontrolenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agentrecordingcontrolsenabled"></a> msdyn_agentrecordingcontrolsenabled

|Property|Value|
|---|---|
|Description|**Enable agent control of the recording**|
|DisplayName|**Enable agent control of the recording**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentrecordingcontrolsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_agentrecordingcontrolsenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agenttranscriptioncontrolsenabled"></a> msdyn_agenttranscriptioncontrolsenabled

|Property|Value|
|---|---|
|Description|**Enable agent control of the transcription**|
|DisplayName|**Enable agent control of the transcription**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agenttranscriptioncontrolsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_agenttranscriptioncontrolsenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_announceaveragewaittime"></a> msdyn_announceaveragewaittime

|Property|Value|
|---|---|
|Description|**Announce the average wait time of the customer in queue**|
|DisplayName|**Announce average wait time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_announceaveragewaittime`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_announceaveragewaittime`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_announcepositioninqueue"></a> msdyn_announcepositioninqueue

|Property|Value|
|---|---|
|Description|**Announce the position of the customer in queue**|
|DisplayName|**Announce position in queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_announcepositioninqueue`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_announcepositioninqueue`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_calleridname"></a> msdyn_calleridname

|Property|Value|
|---|---|
|Description|**Caller ID Name**|
|DisplayName|**Caller ID Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_calleridname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_calleridphonenumberid"></a> msdyn_calleridphonenumberid

|Property|Value|
|---|---|
|Description|**Caller ID Phone Number**|
|DisplayName|**Caller ID Phone Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_calleridphonenumberid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocphonenumber|

### <a name="BKMK_msdyn_enablepostcallsurvey"></a> msdyn_enablepostcallsurvey

|Property|Value|
|---|---|
|Description|**This field is deprecated**|
|DisplayName|**Enable end of call survey (deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablepostcallsurvey`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_enablepostcallsurvey`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablepostcallsurveyduration"></a> msdyn_enablepostcallsurveyduration

|Property|Value|
|---|---|
|Description|**This field is deprecated.**|
|DisplayName|**Set survey duration (deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablepostcallsurveyduration`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_enablepostcallsurveyduration`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablestoprecordingtranscriptiononhold"></a> msdyn_enablestoprecordingtranscriptiononhold

|Property|Value|
|---|---|
|Description|**Enable Stop Recording and Transcription On Hold**|
|DisplayName|**Enable Stop Recording and Transcription On Hold**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablestoprecordingtranscriptiononhold`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_enablestoprecordingtranscriptiononhold`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_inboundurl"></a> msdyn_inboundurl

|Property|Value|
|---|---|
|Description|**Inbound URL**|
|DisplayName|**Inbound URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inboundurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_isanonymouscallerid"></a> msdyn_isanonymouscallerid

|Property|Value|
|---|---|
|Description|**Anonymous Caller ID**|
|DisplayName|**Anonymous Caller ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isanonymouscallerid`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_isanonymouscallerid`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|---|---|
|Description|**Work Stream**|
|DisplayName|**Work Stream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkstreamid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocvoicechannelsettingId"></a> msdyn_ocvoicechannelsettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Voice Channel Setting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocvoicechannelsettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_operatinghoursid"></a> msdyn_operatinghoursid

|Property|Value|
|---|---|
|Description|**Operating Hours**|
|DisplayName|**Operating Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operatinghoursid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_operatinghour|

### <a name="BKMK_msdyn_outboundcallregionallowlist"></a> msdyn_outboundcallregionallowlist

|Property|Value|
|---|---|
|Description|**Outbound Call Region Allowlist**|
|DisplayName|**Outbound Call Region Allowlist**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outboundcallregionallowlist`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|850|

### <a name="BKMK_msdyn_phonenumberid"></a> msdyn_phonenumberid

|Property|Value|
|---|---|
|Description|**Phone Number**|
|DisplayName|**Phone Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumberid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocphonenumber|

### <a name="BKMK_msdyn_postcallsurveyendtime"></a> msdyn_postcallsurveyendtime

|Property|Value|
|---|---|
|Description|**This field is deprecated.**|
|DisplayName|**End of call survey end date (deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postcallsurveyendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_postcallsurveyfrequency"></a> msdyn_postcallsurveyfrequency

|Property|Value|
|---|---|
|Description|**This field is deprecated**|
|DisplayName|**End of call survey frequency (deprecated)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_postcallsurveyfrequency`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|1|

### <a name="BKMK_msdyn_postcallsurveystarttime"></a> msdyn_postcallsurveystarttime

|Property|Value|
|---|---|
|Description|**This field is deprecated.**|
|DisplayName|**End of call survey start date (deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postcallsurveystarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_recordingenabled"></a> msdyn_recordingenabled

|Property|Value|
|---|---|
|Description|**Recording Enabled**|
|DisplayName|**Recording Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordingenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_recordingenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_recordingmode"></a> msdyn_recordingmode

|Property|Value|
|---|---|
|Description|**Recording mode**|
|DisplayName|**Recording mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordingmode`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocfeaturemode`|

#### msdyn_recordingmode Choices/Options

|Value|Label|
|---|---|
|192351000|**None**|
|192351001|**Manual**|
|192351002|**Automatic**|

### <a name="BKMK_msdyn_showhidetranscriptionfeaturepreview"></a> msdyn_showhidetranscriptionfeaturepreview

|Property|Value|
|---|---|
|Description|**Show/Hide transcription feature (preview)**|
|DisplayName|**Show/Hide transcription feature (preview)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_showhidetranscriptionfeaturepreview`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_showhidetranscriptionfeaturepreview`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_skipwaitmusicforivr"></a> msdyn_skipwaitmusicforivr

|Property|Value|
|---|---|
|Description|**Indicates whether we skip wait music for workstream IVR or not.**|
|DisplayName|**Skip wait music for workstream IVR**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_skipwaitmusicforivr`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_skipwaitmusicforivr`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_stoptranscriptionandrecordingafterpstntransfer"></a> msdyn_stoptranscriptionandrecordingafterpstntransfer

|Property|Value|
|---|---|
|Description|**Stop transcription and recording after public switched telephone network transfer**|
|DisplayName|**Stop transcription and recording after public switched telephone network transfer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_stoptranscriptionandrecordingafterpstntransfer`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_liveworkstream_msdyn_stoptranscriptionandrecordingafterpstntransfer`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_stoptranscriptionandrecordingafterteamstransfer"></a> msdyn_stoptranscriptionandrecordingafterteamstransfer

|Property|Value|
|---|---|
|Description|**Stop transcription and recording after Microsoft Teams transfer**|
|DisplayName|**Stop transcription and recording after Microsoft Teams transfer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_stoptranscriptionandrecordingafterteamstransfer`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_liveworkstream_msdyn_stoptranscriptionandrecordingafterteamstransfer`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_transcriptionenabled"></a> msdyn_transcriptionenabled

|Property|Value|
|---|---|
|Description|**Transcription Enabled**|
|DisplayName|**Transcription Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transcriptionenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_transcriptionenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_transcriptionmode"></a> msdyn_transcriptionmode

|Property|Value|
|---|---|
|Description|**Transcription mode**|
|DisplayName|**Transcription mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transcriptionmode`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocfeaturemode`|

#### msdyn_transcriptionmode Choices/Options

|Value|Label|
|---|---|
|192351000|**None**|
|192351001|**Manual**|
|192351002|**Automatic**|

### <a name="BKMK_msdyn_transcriptionshowbydefault"></a> msdyn_transcriptionshowbydefault

|Property|Value|
|---|---|
|Description|**Show transcription by default**|
|DisplayName|**Show transcription by default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transcriptionshowbydefault`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_transcriptionshowbydefault`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_usebridgetransferforpstntransfer"></a> msdyn_usebridgetransferforpstntransfer

|Property|Value|
|---|---|
|Description|**Enable bridged transfer for public switched telephony network**|
|DisplayName|**Enable bridged transfer for public switched telephony network**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_usebridgetransferforpstntransfer`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_usebridgetransferforpstntransfer`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_usebridgetransferforteamstransfer"></a> msdyn_usebridgetransferforteamstransfer

|Property|Value|
|---|---|
|Description|**Enable bridged transfer for Microsoft Teams**|
|DisplayName|**Enable bridged transfer for Microsoft Teams**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_usebridgetransferforteamstransfer`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_msdyn_usebridgetransferforteamstransfer`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_voiceauthenticationsettingsid"></a> msdyn_voiceauthenticationsettingsid

|Property|Value|
|---|---|
|Description|**Unique identifier for Authentication settings associated with Voice Channel instance.**|
|DisplayName|**Voice Authentication Settings Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_voiceauthenticationsettingsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_authenticationsettings|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Voice Channel Setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Voice Channel Setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocvoicechannelsetting_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdyn_ocvoicechannelsetting](#BKMK_business_unit_msdyn_ocvoicechannelsetting)
- [lk_msdyn_ocvoicechannelsetting_createdby](#BKMK_lk_msdyn_ocvoicechannelsetting_createdby)
- [lk_msdyn_ocvoicechannelsetting_createdonbehalfby](#BKMK_lk_msdyn_ocvoicechannelsetting_createdonbehalfby)
- [lk_msdyn_ocvoicechannelsetting_modifiedby](#BKMK_lk_msdyn_ocvoicechannelsetting_modifiedby)
- [lk_msdyn_ocvoicechannelsetting_modifiedonbehalfby](#BKMK_lk_msdyn_ocvoicechannelsetting_modifiedonbehalfby)
- [msdyn_authenticationsettings_msdyn_ocvoicechannelsetting](#BKMK_msdyn_authenticationsettings_msdyn_ocvoicechannelsetting)
- [msdyn_liveworkstream_msdyn_ocvoicechannelsetting_liveworkstreamid](#BKMK_msdyn_liveworkstream_msdyn_ocvoicechannelsetting_liveworkstreamid)
- [msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid](#BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid)
- [msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid](#BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid)
- [msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid](#BKMK_msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid)
- [owner_msdyn_ocvoicechannelsetting](#BKMK_owner_msdyn_ocvoicechannelsetting)
- [team_msdyn_ocvoicechannelsetting](#BKMK_team_msdyn_ocvoicechannelsetting)
- [user_msdyn_ocvoicechannelsetting](#BKMK_user_msdyn_ocvoicechannelsetting)

### <a name="BKMK_business_unit_msdyn_ocvoicechannelsetting"></a> business_unit_msdyn_ocvoicechannelsetting

One-To-Many Relationship: [businessunit business_unit_msdyn_ocvoicechannelsetting](businessunit.md#BKMK_business_unit_msdyn_ocvoicechannelsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocvoicechannelsetting_createdby"></a> lk_msdyn_ocvoicechannelsetting_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocvoicechannelsetting_createdby](systemuser.md#BKMK_lk_msdyn_ocvoicechannelsetting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocvoicechannelsetting_createdonbehalfby"></a> lk_msdyn_ocvoicechannelsetting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocvoicechannelsetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocvoicechannelsetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocvoicechannelsetting_modifiedby"></a> lk_msdyn_ocvoicechannelsetting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocvoicechannelsetting_modifiedby](systemuser.md#BKMK_lk_msdyn_ocvoicechannelsetting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocvoicechannelsetting_modifiedonbehalfby"></a> lk_msdyn_ocvoicechannelsetting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocvoicechannelsetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocvoicechannelsetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_authenticationsettings_msdyn_ocvoicechannelsetting"></a> msdyn_authenticationsettings_msdyn_ocvoicechannelsetting

One-To-Many Relationship: [msdyn_authenticationsettings msdyn_authenticationsettings_msdyn_ocvoicechannelsetting](msdyn_authenticationsettings.md#BKMK_msdyn_authenticationsettings_msdyn_ocvoicechannelsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_authenticationsettings`|
|ReferencedAttribute|`msdyn_authenticationsettingsid`|
|ReferencingAttribute|`msdyn_voiceauthenticationsettingsid`|
|ReferencingEntityNavigationPropertyName|`msdyn_voiceauthenticationsettingsid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_liveworkstream_msdyn_ocvoicechannelsetting_liveworkstreamid"></a> msdyn_liveworkstream_msdyn_ocvoicechannelsetting_liveworkstreamid

One-To-Many Relationship: [msdyn_liveworkstream msdyn_liveworkstream_msdyn_ocvoicechannelsetting_liveworkstreamid](msdyn_liveworkstream.md#BKMK_msdyn_liveworkstream_msdyn_ocvoicechannelsetting_liveworkstreamid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid"></a> msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid](msdyn_ocphonenumber.md#BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`msdyn_calleridphonenumberid`|
|ReferencingEntityNavigationPropertyName|`msdyn_calleridphonenumberid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid"></a> msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid](msdyn_ocphonenumber.md#BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`msdyn_phonenumberid`|
|ReferencingEntityNavigationPropertyName|`msdyn_phonenumberid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid"></a> msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid

One-To-Many Relationship: [msdyn_operatinghour msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid](msdyn_operatinghour.md#BKMK_msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_operatinghour`|
|ReferencedAttribute|`msdyn_operatinghourid`|
|ReferencingAttribute|`msdyn_operatinghoursid`|
|ReferencingEntityNavigationPropertyName|`msdyn_operatinghoursid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocvoicechannelsetting"></a> owner_msdyn_ocvoicechannelsetting

One-To-Many Relationship: [owner owner_msdyn_ocvoicechannelsetting](owner.md#BKMK_owner_msdyn_ocvoicechannelsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocvoicechannelsetting"></a> team_msdyn_ocvoicechannelsetting

One-To-Many Relationship: [team team_msdyn_ocvoicechannelsetting](team.md#BKMK_team_msdyn_ocvoicechannelsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocvoicechannelsetting"></a> user_msdyn_ocvoicechannelsetting

One-To-Many Relationship: [systemuser user_msdyn_ocvoicechannelsetting](systemuser.md#BKMK_user_msdyn_ocvoicechannelsetting)

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

- [msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid](#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid)
- [msdyn_msdyn_ocvoicechannelsetting_msdyn_ocvoicechannellanguagesetting_ocvoicechannelsettingid](#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocvoicechannellanguagesetting_ocvoicechannelsettingid)
- [msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile](#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile)
- [msdyn_ocvoicechannelsetting_AsyncOperations](#BKMK_msdyn_ocvoicechannelsetting_AsyncOperations)
- [msdyn_ocvoicechannelsetting_BulkDeleteFailures](#BKMK_msdyn_ocvoicechannelsetting_BulkDeleteFailures)
- [msdyn_ocvoicechannelsetting_MailboxTrackingFolders](#BKMK_msdyn_ocvoicechannelsetting_MailboxTrackingFolders)
- [msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses)
- [msdyn_ocvoicechannelsetting_ProcessSession](#BKMK_msdyn_ocvoicechannelsetting_ProcessSession)
- [msdyn_ocvoicechannelsetting_SyncErrors](#BKMK_msdyn_ocvoicechannelsetting_SyncErrors)

### <a name="BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid"></a> msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid

Many-To-One Relationship: [msdyn_ocprovisioningstate msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid](msdyn_ocprovisioningstate.md#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocprovisioningstate`|
|ReferencingAttribute|`msdyn_voicechannelsettingid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocvoicechannellanguagesetting_ocvoicechannelsettingid"></a> msdyn_msdyn_ocvoicechannelsetting_msdyn_ocvoicechannellanguagesetting_ocvoicechannelsettingid

Many-To-One Relationship: [msdyn_ocvoicechannellanguagesetting msdyn_msdyn_ocvoicechannelsetting_msdyn_ocvoicechannellanguagesetting_ocvoicechannelsettingid](msdyn_ocvoicechannellanguagesetting.md#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocvoicechannellanguagesetting_ocvoicechannelsettingid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannellanguagesetting`|
|ReferencingAttribute|`msdyn_ocvoicechannelsettingid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocvoicechannelsetting_msdyn_ocvoicechannellanguagesetting_ocvoicechannelsettingid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile"></a> msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile

Many-To-One Relationship: [msdyn_overflowactionconfig msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile](msdyn_overflowactionconfig.md#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_overflowactionconfig`|
|ReferencingAttribute|`msdyn_directcallbackoutboundprofile`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_AsyncOperations"></a> msdyn_ocvoicechannelsetting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocvoicechannelsetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocvoicechannelsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicechannelsetting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_BulkDeleteFailures"></a> msdyn_ocvoicechannelsetting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocvoicechannelsetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocvoicechannelsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicechannelsetting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_MailboxTrackingFolders"></a> msdyn_ocvoicechannelsetting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocvoicechannelsetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocvoicechannelsetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicechannelsetting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses"></a> msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_ProcessSession"></a> msdyn_ocvoicechannelsetting_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocvoicechannelsetting_ProcessSession](processsession.md#BKMK_msdyn_ocvoicechannelsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicechannelsetting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_SyncErrors"></a> msdyn_ocvoicechannelsetting_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocvoicechannelsetting_SyncErrors](syncerror.md#BKMK_msdyn_ocvoicechannelsetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicechannelsetting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

