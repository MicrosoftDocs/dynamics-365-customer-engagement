---
title: "Channel Profile (msdyn_channelprofile) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Channel Profile (msdyn_channelprofile) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Channel Profile (msdyn_channelprofile) table/entity reference (Microsoft Dynamics 365)

Channel profile configuration for omnichannel

## Messages

The following table lists the messages for the Channel Profile (msdyn_channelprofile) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_channelprofiles(*msdyn_channelprofileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_channelprofiles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_channelprofiles(*msdyn_channelprofileid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_channelprofiles(*msdyn_channelprofileid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_channelprofiles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_channelprofiles(*msdyn_channelprofileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_channelprofiles(*msdyn_channelprofileid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_channelprofiles(*msdyn_channelprofileid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Channel Profile (msdyn_channelprofile) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Channel Profile** |
| **DisplayCollectionName** | **Channel Profiles** |
| **SchemaName** | `msdyn_channelprofile` |
| **CollectionSchemaName** | `msdyn_channelprofiles` |
| **EntitySetName** | `msdyn_channelprofiles`|
| **LogicalName** | `msdyn_channelprofile` |
| **LogicalCollectionName** | `msdyn_channelprofiles` |
| **PrimaryIdAttribute** | `msdyn_channelprofileid` |
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
- [msdyn_allowedpresences](#BKMK_msdyn_allowedpresences)
- [msdyn_announceaveragewaittime](#BKMK_msdyn_announceaveragewaittime)
- [msdyn_announcepositioninqueue](#BKMK_msdyn_announcepositioninqueue)
- [msdyn_autocloseafterinactivity](#BKMK_msdyn_autocloseafterinactivity)
- [msdyn_averagewaittime_enabled](#BKMK_msdyn_averagewaittime_enabled)
- [msdyn_capacityformat](#BKMK_msdyn_capacityformat)
- [msdyn_capacityrequired](#BKMK_msdyn_capacityrequired)
- [msdyn_capacitywrapuptimeid](#BKMK_msdyn_capacitywrapuptimeid)
- [msdyn_channelprofileId](#BKMK_msdyn_channelprofileId)
- [msdyn_conversationmode](#BKMK_msdyn_conversationmode)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_enableagentaffinity](#BKMK_msdyn_enableagentaffinity)
- [msdyn_isconversationcounterenabled](#BKMK_msdyn_isconversationcounterenabled)
- [msdyn_matchinglogic](#BKMK_msdyn_matchinglogic)
- [msdyn_maxdispositioncodesperconversation](#BKMK_msdyn_maxdispositioncodesperconversation)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_positioninqueue_enabled](#BKMK_msdyn_positioninqueue_enabled)
- [msdyn_requireddispositioncodeforchannelprofileconversations](#BKMK_msdyn_requireddispositioncodeforchannelprofileconversations)
- [msdyn_sessiontemplate_default](#BKMK_msdyn_sessiontemplate_default)
- [msdyn_streamsource](#BKMK_msdyn_streamsource)
- [msdyn_surveyconfigid](#BKMK_msdyn_surveyconfigid)
- [msdyn_usebridgetransferforpstntransfer](#BKMK_msdyn_usebridgetransferforpstntransfer)
- [msdyn_usebridgetransferforteamstransfer](#BKMK_msdyn_usebridgetransferforteamstransfer)
- [msdyn_useglobalsettingsforrequiringdispositioncode](#BKMK_msdyn_useglobalsettingsforrequiringdispositioncode)
- [msdyn_workdistributionmode](#BKMK_msdyn_workdistributionmode)
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
|Description|**Indicates whether representatives can control external participants on this channel profile**|
|DisplayName|**Agent external participant control enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentexternalparticipantcontrolenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_agentexternalparticipantcontrolenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agentexternalparticipanttransfercontrolenabled"></a> msdyn_agentexternalparticipanttransfercontrolenabled

|Property|Value|
|---|---|
|Description|**Indicates whether representatives can control external participant transfers on this channel profile**|
|DisplayName|**Agent external participant transfer control enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentexternalparticipanttransfercontrolenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_agentexternalparticipanttransfercontrolenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agentexternalteamsparticipantcontrolenabled"></a> msdyn_agentexternalteamsparticipantcontrolenabled

|Property|Value|
|---|---|
|Description|**Indicates whether representatives can control external Teams participants on this channel profile**|
|DisplayName|**Agent external teams participant control enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentexternalteamsparticipantcontrolenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_agentexternalteamsparticipantcontrolenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agentexternalteamsparticipanttransfercontrolenabled"></a> msdyn_agentexternalteamsparticipanttransfercontrolenabled

|Property|Value|
|---|---|
|Description|**Indicates whether representatives can control external Teams participant transfers on this channel profile**|
|DisplayName|**Agent external teams participant transfer control enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentexternalteamsparticipanttransfercontrolenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_agentexternalteamsparticipanttransfercontrolenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_allowedpresences"></a> msdyn_allowedpresences

|Property|Value|
|---|---|
|Description|**Presence statuses in which representatives can receive work from this channel profile**|
|DisplayName|**Allowed Presences**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allowedpresences`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_basepresencestatus`|

#### msdyn_allowedpresences Choices/Options

|Value|Label|
|---|---|
|192360000|**Available**|
|192360001|**Busy**|
|192360002|**Busy - DND**|
|192360003|**Away**|
|192360004|**Offline**|

### <a name="BKMK_msdyn_announceaveragewaittime"></a> msdyn_announceaveragewaittime

|Property|Value|
|---|---|
|Description|**Indicates whether average wait time is announced for this channel profile**|
|DisplayName|**Announce average wait time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_announceaveragewaittime`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_announceaveragewaittime`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_announcepositioninqueue"></a> msdyn_announcepositioninqueue

|Property|Value|
|---|---|
|Description|**Indicates whether position in queue is announced for this channel profile**|
|DisplayName|**Announce position in queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_announcepositioninqueue`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_announcepositioninqueue`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_autocloseafterinactivity"></a> msdyn_autocloseafterinactivity

|Property|Value|
|---|---|
|Description|**Duration of inactivity after which conversations on this channel profile are automatically closed**|
|DisplayName|**Auto-close after inactivity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autocloseafterinactivity`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_averagewaittime_enabled"></a> msdyn_averagewaittime_enabled

|Property|Value|
|---|---|
|Description|**Indicates whether average wait time is enabled for this channel profile**|
|DisplayName|**Average wait time enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_averagewaittime_enabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_averagewaittime_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_capacityformat"></a> msdyn_capacityformat

|Property|Value|
|---|---|
|Description|**Unit in which capacity is consumed for conversations on this channel profile**|
|DisplayName|**Capacity format**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_capacityformat`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_capacityformat`|

#### msdyn_capacityformat Choices/Options

|Value|Label|
|---|---|
|192350000|**Unit based**|
|192360000|**Profile based**|

### <a name="BKMK_msdyn_capacityrequired"></a> msdyn_capacityrequired

|Property|Value|
|---|---|
|Description|**Amount of capacity a conversation on this channel profile consumes**|
|DisplayName|**Capacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_capacityrequired`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_capacitywrapuptimeid"></a> msdyn_capacitywrapuptimeid

|Property|Value|
|---|---|
|Description|**Channel Wrap up time associated with Channel Profile**|
|DisplayName|**Capacity Wrap Up Time Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_capacitywrapuptimeid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_capacitywrapuptime|

### <a name="BKMK_msdyn_channelprofileId"></a> msdyn_channelprofileId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Channel Profile**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channelprofileid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_conversationmode"></a> msdyn_conversationmode

|Property|Value|
|---|---|
|Description|**Conversation Mode**|
|DisplayName|**Conversation Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_conversationmode`|

#### msdyn_conversationmode Choices/Options

|Value|Label|
|---|---|
|192350000|**Live Chat**|
|192350001|**Persistent Chat**|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Description of the channel profile**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_enableagentaffinity"></a> msdyn_enableagentaffinity

|Property|Value|
|---|---|
|Description|**When enabled, the same representative is kept for the entire conversation on this channel profile.**|
|DisplayName|**Enable Agent Affinity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableagentaffinity`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_enableagentaffinity`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isconversationcounterenabled"></a> msdyn_isconversationcounterenabled

|Property|Value|
|---|---|
|Description|**Indicates whether the live conversation counter is enabled for this channel profile**|
|DisplayName|**Is Live conversation counter enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isconversationcounterenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_isconversationcounterenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_matchinglogic"></a> msdyn_matchinglogic

|Property|Value|
|---|---|
|Description|**Logic used to match conversations to representatives for this channel profile**|
|DisplayName|**Matching Logic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_matchinglogic`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channelprofile_msdyn_matchinglogic`|

#### msdyn_matchinglogic Choices/Options

|Value|Label|
|---|---|
|192350000|**Exact Match**|
|192350001|**Closest Match**|

### <a name="BKMK_msdyn_maxdispositioncodesperconversation"></a> msdyn_maxdispositioncodesperconversation

|Property|Value|
|---|---|
|Description|**Maximum number of disposition codes allowed per conversation on this channel profile**|
|DisplayName|**Maximum number of disposition codes allowed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maxdispositioncodesperconversation`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_positioninqueue_enabled"></a> msdyn_positioninqueue_enabled

|Property|Value|
|---|---|
|Description|**Indicates whether position in queue is enabled for this channel profile**|
|DisplayName|**Position in queue enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_positioninqueue_enabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_positioninqueue_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_requireddispositioncodeforchannelprofileconversations"></a> msdyn_requireddispositioncodeforchannelprofileconversations

|Property|Value|
|---|---|
|Description|**Indicates whether disposition codes are required to close conversations on this channel profile**|
|DisplayName|**Requires disposition codes to close conversations**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requireddispositioncodeforchannelprofileconversations`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_requireddispositioncodeforchannelprofileconversations`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_sessiontemplate_default"></a> msdyn_sessiontemplate_default

|Property|Value|
|---|---|
|Description|**Default session template applied for conversations on this channel profile**|
|DisplayName|**Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sessiontemplate_default`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_streamsource"></a> msdyn_streamsource

|Property|Value|
|---|---|
|Description|**Channel**|
|DisplayName|**Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_streamsource`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_streamsource`|

#### msdyn_streamsource Choices/Options

|Value|Label|
|---|---|
|192350000|**Entity Records**|

### <a name="BKMK_msdyn_surveyconfigid"></a> msdyn_surveyconfigid

|Property|Value|
|---|---|
|Description|**Channel Survey Configuration associated with Channel Profile**|
|DisplayName|**Survey Configuration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_surveyconfigid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_channelprofilesurveyconfig|

### <a name="BKMK_msdyn_usebridgetransferforpstntransfer"></a> msdyn_usebridgetransferforpstntransfer

|Property|Value|
|---|---|
|Description|**Indicates whether bridge transfer is used for PSTN transfers on this channel profile**|
|DisplayName|**Use bridge transfer for PSTN transfer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_usebridgetransferforpstntransfer`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_usebridgetransferforpstntransfer`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_usebridgetransferforteamstransfer"></a> msdyn_usebridgetransferforteamstransfer

|Property|Value|
|---|---|
|Description|**Indicates whether bridge transfer is used for Teams transfers on this channel profile**|
|DisplayName|**Use bridge transfer for Teams transfer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_usebridgetransferforteamstransfer`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_usebridgetransferforteamstransfer`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_useglobalsettingsforrequiringdispositioncode"></a> msdyn_useglobalsettingsforrequiringdispositioncode

|Property|Value|
|---|---|
|Description|**Indicates whether global settings are used for requiring disposition codes on this channel profile**|
|DisplayName|**Use global settings for requiring disposition code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_useglobalsettingsforrequiringdispositioncode`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channelprofile_msdyn_useglobalsettingsforrequiringdispositioncode`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_workdistributionmode"></a> msdyn_workdistributionmode

|Property|Value|
|---|---|
|Description|**Specifies the mode i.e Push/Pick for the channel profile**|
|DisplayName|**Work Distribution Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workdistributionmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_workdistributionmode`|

#### msdyn_workdistributionmode Choices/Options

|Value|Label|
|---|---|
|192350000|**Push**|
|192350001|**Pick**|

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
|Description|**Status of the Channel Profile**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channelprofile_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Channel Profile**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channelprofile_statuscode`|

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

- [business_unit_msdyn_channelprofile](#BKMK_business_unit_msdyn_channelprofile)
- [lk_msdyn_channelprofile_createdby](#BKMK_lk_msdyn_channelprofile_createdby)
- [lk_msdyn_channelprofile_createdonbehalfby](#BKMK_lk_msdyn_channelprofile_createdonbehalfby)
- [lk_msdyn_channelprofile_modifiedby](#BKMK_lk_msdyn_channelprofile_modifiedby)
- [lk_msdyn_channelprofile_modifiedonbehalfby](#BKMK_lk_msdyn_channelprofile_modifiedonbehalfby)
- [msdyn_channelprofile_msdyn_capacitywrapuptimeid_msdyn_capacitywrapuptime](#BKMK_msdyn_channelprofile_msdyn_capacitywrapuptimeid_msdyn_capacitywrapuptime)
- [msdyn_channelprofile_msdyn_surveyconfigid_msdyn_channelprofilesurveyconfig](#BKMK_msdyn_channelprofile_msdyn_surveyconfigid_msdyn_channelprofilesurveyconfig)
- [owner_msdyn_channelprofile](#BKMK_owner_msdyn_channelprofile)
- [team_msdyn_channelprofile](#BKMK_team_msdyn_channelprofile)
- [user_msdyn_channelprofile](#BKMK_user_msdyn_channelprofile)

### <a name="BKMK_business_unit_msdyn_channelprofile"></a> business_unit_msdyn_channelprofile

One-To-Many Relationship: [businessunit business_unit_msdyn_channelprofile](businessunit.md#BKMK_business_unit_msdyn_channelprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelprofile_createdby"></a> lk_msdyn_channelprofile_createdby

One-To-Many Relationship: [systemuser lk_msdyn_channelprofile_createdby](systemuser.md#BKMK_lk_msdyn_channelprofile_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelprofile_createdonbehalfby"></a> lk_msdyn_channelprofile_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_channelprofile_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_channelprofile_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelprofile_modifiedby"></a> lk_msdyn_channelprofile_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_channelprofile_modifiedby](systemuser.md#BKMK_lk_msdyn_channelprofile_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelprofile_modifiedonbehalfby"></a> lk_msdyn_channelprofile_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_channelprofile_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_channelprofile_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channelprofile_msdyn_capacitywrapuptimeid_msdyn_capacitywrapuptime"></a> msdyn_channelprofile_msdyn_capacitywrapuptimeid_msdyn_capacitywrapuptime

One-To-Many Relationship: [msdyn_capacitywrapuptime msdyn_channelprofile_msdyn_capacitywrapuptimeid_msdyn_capacitywrapuptime](msdyn_capacitywrapuptime.md#BKMK_msdyn_channelprofile_msdyn_capacitywrapuptimeid_msdyn_capacitywrapuptime)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_capacitywrapuptime`|
|ReferencedAttribute|`msdyn_capacitywrapuptimeid`|
|ReferencingAttribute|`msdyn_capacitywrapuptimeid`|
|ReferencingEntityNavigationPropertyName|`msdyn_capacitywrapuptimeid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channelprofile_msdyn_surveyconfigid_msdyn_channelprofilesurveyconfig"></a> msdyn_channelprofile_msdyn_surveyconfigid_msdyn_channelprofilesurveyconfig

One-To-Many Relationship: [msdyn_channelprofilesurveyconfig msdyn_channelprofile_msdyn_surveyconfigid_msdyn_channelprofilesurveyconfig](msdyn_channelprofilesurveyconfig.md#BKMK_msdyn_channelprofile_msdyn_surveyconfigid_msdyn_channelprofilesurveyconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelprofilesurveyconfig`|
|ReferencedAttribute|`msdyn_channelprofilesurveyconfigid`|
|ReferencingAttribute|`msdyn_surveyconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_surveyconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_channelprofile"></a> owner_msdyn_channelprofile

One-To-Many Relationship: [owner owner_msdyn_channelprofile](owner.md#BKMK_owner_msdyn_channelprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_channelprofile"></a> team_msdyn_channelprofile

One-To-Many Relationship: [team team_msdyn_channelprofile](team.md#BKMK_team_msdyn_channelprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_channelprofile"></a> user_msdyn_channelprofile

One-To-Many Relationship: [systemuser user_msdyn_channelprofile](systemuser.md#BKMK_user_msdyn_channelprofile)

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

- [msdyn_channelprofile_AsyncOperations](#BKMK_msdyn_channelprofile_AsyncOperations)
- [msdyn_channelprofile_BulkDeleteFailures](#BKMK_msdyn_channelprofile_BulkDeleteFailures)
- [msdyn_channelprofile_DuplicateBaseRecord](#BKMK_msdyn_channelprofile_DuplicateBaseRecord)
- [msdyn_channelprofile_DuplicateMatchingRecord](#BKMK_msdyn_channelprofile_DuplicateMatchingRecord)
- [msdyn_channelprofile_MailboxTrackingFolders](#BKMK_msdyn_channelprofile_MailboxTrackingFolders)
- [msdyn_channelprofile_PrincipalObjectAttributeAccesses](#BKMK_msdyn_channelprofile_PrincipalObjectAttributeAccesses)
- [msdyn_channelprofile_ProcessSession](#BKMK_msdyn_channelprofile_ProcessSession)
- [msdyn_channelprofile_SyncErrors](#BKMK_msdyn_channelprofile_SyncErrors)
- [msdyn_channelprofilenotificationtemplate_msdyn_channelprofileid_msdyn_channelprofile](#BKMK_msdyn_channelprofilenotificationtemplate_msdyn_channelprofileid_msdyn_channelprofile)
- [msdyn_liveworkstreamcapacityprofile_msdyn_engagementprofileid_msdyn_channelprofile](#BKMK_msdyn_liveworkstreamcapacityprofile_msdyn_engagementprofileid_msdyn_channelprofile)
- [msdyn_ocliveworkitem_msdyn_engagementprofileid_msdyn_channelprofile](#BKMK_msdyn_ocliveworkitem_msdyn_engagementprofileid_msdyn_channelprofile)
- [msdyn_ocsession_msdyn_channelprofileid_msdyn_channelprofile](#BKMK_msdyn_ocsession_msdyn_channelprofileid_msdyn_channelprofile)
- [Queue_msdyn_channelprofileid_msdyn_channelprofile](#BKMK_Queue_msdyn_channelprofileid_msdyn_channelprofile)

### <a name="BKMK_msdyn_channelprofile_AsyncOperations"></a> msdyn_channelprofile_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_channelprofile_AsyncOperations](asyncoperation.md#BKMK_msdyn_channelprofile_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofile_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelprofile_BulkDeleteFailures"></a> msdyn_channelprofile_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_channelprofile_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_channelprofile_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofile_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelprofile_DuplicateBaseRecord"></a> msdyn_channelprofile_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_channelprofile_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_channelprofile_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofile_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelprofile_DuplicateMatchingRecord"></a> msdyn_channelprofile_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_channelprofile_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_channelprofile_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofile_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelprofile_MailboxTrackingFolders"></a> msdyn_channelprofile_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_channelprofile_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_channelprofile_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofile_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelprofile_PrincipalObjectAttributeAccesses"></a> msdyn_channelprofile_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_channelprofile_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_channelprofile_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofile_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelprofile_ProcessSession"></a> msdyn_channelprofile_ProcessSession

Many-To-One Relationship: [processsession msdyn_channelprofile_ProcessSession](processsession.md#BKMK_msdyn_channelprofile_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofile_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelprofile_SyncErrors"></a> msdyn_channelprofile_SyncErrors

Many-To-One Relationship: [syncerror msdyn_channelprofile_SyncErrors](syncerror.md#BKMK_msdyn_channelprofile_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofile_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelprofilenotificationtemplate_msdyn_channelprofileid_msdyn_channelprofile"></a> msdyn_channelprofilenotificationtemplate_msdyn_channelprofileid_msdyn_channelprofile

Many-To-One Relationship: [msdyn_channelprofilenotificationtemplate msdyn_channelprofilenotificationtemplate_msdyn_channelprofileid_msdyn_channelprofile](msdyn_channelprofilenotificationtemplate.md#BKMK_msdyn_channelprofilenotificationtemplate_msdyn_channelprofileid_msdyn_channelprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelprofilenotificationtemplate`|
|ReferencingAttribute|`msdyn_channelprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofilenotificationtemplate_msdyn_channelprofileid_msdyn_channelprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveworkstreamcapacityprofile_msdyn_engagementprofileid_msdyn_channelprofile"></a> msdyn_liveworkstreamcapacityprofile_msdyn_engagementprofileid_msdyn_channelprofile

Many-To-One Relationship: [msdyn_liveworkstreamcapacityprofile msdyn_liveworkstreamcapacityprofile_msdyn_engagementprofileid_msdyn_channelprofile](msdyn_liveworkstreamcapacityprofile.md#BKMK_msdyn_liveworkstreamcapacityprofile_msdyn_engagementprofileid_msdyn_channelprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstreamcapacityprofile`|
|ReferencingAttribute|`msdyn_engagementprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveworkstreamcapacityprofile_msdyn_engagementprofileid_msdyn_channelprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_engagementprofileid_msdyn_channelprofile"></a> msdyn_ocliveworkitem_msdyn_engagementprofileid_msdyn_channelprofile

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_msdyn_engagementprofileid_msdyn_channelprofile](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_msdyn_engagementprofileid_msdyn_channelprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_engagementprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_msdyn_engagementprofileid_msdyn_channelprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_msdyn_channelprofileid_msdyn_channelprofile"></a> msdyn_ocsession_msdyn_channelprofileid_msdyn_channelprofile

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_msdyn_channelprofileid_msdyn_channelprofile](msdyn_ocsession.md#BKMK_msdyn_ocsession_msdyn_channelprofileid_msdyn_channelprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`msdyn_channelprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_msdyn_channelprofileid_msdyn_channelprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Queue_msdyn_channelprofileid_msdyn_channelprofile"></a> Queue_msdyn_channelprofileid_msdyn_channelprofile

Many-To-One Relationship: [queue Queue_msdyn_channelprofileid_msdyn_channelprofile](queue.md#BKMK_Queue_msdyn_channelprofileid_msdyn_channelprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`queue`|
|ReferencingAttribute|`msdyn_channelprofileid`|
|ReferencedEntityNavigationPropertyName|`Queue_msdyn_channelprofileid_msdyn_channelprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_channelprofile_msdyn_ocautomatedactionrule](#BKMK_msdyn_msdyn_channelprofile_msdyn_ocautomatedactionrule)
- [msdyn_msdyn_channelprofile_msdyn_ocsystemmessage](#BKMK_msdyn_msdyn_channelprofile_msdyn_ocsystemmessage)
- [msdyn_msdyn_channelprofile_systemuser](#BKMK_msdyn_msdyn_channelprofile_systemuser)

### <a name="BKMK_msdyn_msdyn_channelprofile_msdyn_ocautomatedactionrule"></a> msdyn_msdyn_channelprofile_msdyn_ocautomatedactionrule

See [msdyn_ocautomatedactionrule msdyn_msdyn_channelprofile_msdyn_ocautomatedactionrule Many-To-Many Relationship](msdyn_ocautomatedactionrule.md#BKMK_msdyn_msdyn_channelprofile_msdyn_ocautomatedactionrule)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_channelprofile_msdyn_ocautomateda`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_channelprofile_msdyn_ocautomatedactionrule`|
|IntersectAttribute|`msdyn_channelprofileid`|
|NavigationPropertyName|`msdyn_msdyn_channelprofile_msdyn_ocautomatedactionrule`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelprofile_msdyn_ocsystemmessage"></a> msdyn_msdyn_channelprofile_msdyn_ocsystemmessage

See [msdyn_ocsystemmessage msdyn_msdyn_channelprofile_msdyn_ocsystemmessage Many-To-Many Relationship](msdyn_ocsystemmessage.md#BKMK_msdyn_msdyn_channelprofile_msdyn_ocsystemmessage)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_channelprofile_msdyn_ocsystemmess`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_channelprofile_msdyn_ocsystemmessage`|
|IntersectAttribute|`msdyn_channelprofileid`|
|NavigationPropertyName|`msdyn_msdyn_channelprofile_msdyn_ocsystemmessage`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelprofile_systemuser"></a> msdyn_msdyn_channelprofile_systemuser

See [systemuser msdyn_msdyn_channelprofile_systemuser Many-To-Many Relationship](systemuser.md#BKMK_msdyn_msdyn_channelprofile_systemuser)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_channelprofile_systemuser`|
|IsCustomizable|False|
|SchemaName|`msdyn_msdyn_channelprofile_systemuser`|
|IntersectAttribute|`msdyn_channelprofileid`|
|NavigationPropertyName|`msdyn_msdyn_channelprofile_systemuser`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

