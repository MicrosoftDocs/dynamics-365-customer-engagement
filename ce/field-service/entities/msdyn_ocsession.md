---
title: "Session (msdyn_ocsession) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Session (msdyn_ocsession) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Session (msdyn_ocsession) table/entity reference

Session for interacting with a customer

## Messages

The following table lists the messages for the Session (msdyn_ocsession) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocsessions(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_ocsessions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocsessions(*activityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocsessions(*activityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocsessions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocsessions(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocsessions(*activityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocsessions(*activityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Session (msdyn_ocsession) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Session (msdyn_ocsession) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Session** |
| **DisplayCollectionName** | **Sessions** |
| **SchemaName** | `msdyn_ocsession` |
| **CollectionSchemaName** | `msdyn_ocsessions` |
| **EntitySetName** | `msdyn_ocsessions`|
| **LogicalName** | `msdyn_ocsession` |
| **LogicalCollectionName** | `msdyn_ocsessions` |
| **PrimaryIdAttribute** | `activityid` |
| **PrimaryNameAttribute** |`subject` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityAdditionalParams](#BKMK_ActivityAdditionalParams)
- [ActivityId](#BKMK_ActivityId)
- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [ActualEnd](#BKMK_ActualEnd)
- [ActualStart](#BKMK_ActualStart)
- [BCC](#BKMK_BCC)
- [CC](#BKMK_CC)
- [Community](#BKMK_Community)
- [Customers](#BKMK_Customers)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [Description](#BKMK_Description)
- [ExchangeItemId](#BKMK_ExchangeItemId)
- [ExchangeWebLink](#BKMK_ExchangeWebLink)
- [From](#BKMK_From)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBilled](#BKMK_IsBilled)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LeftVoiceMail](#BKMK_LeftVoiceMail)
- [msdyn_agentacceptedon](#BKMK_msdyn_agentacceptedon)
- [msdyn_agentassignedon](#BKMK_msdyn_agentassignedon)
- [msdyn_botengagementmode](#BKMK_msdyn_botengagementmode)
- [msdyn_cdsqueueid](#BKMK_msdyn_cdsqueueid)
- [msdyn_channel](#BKMK_msdyn_channel)
- [msdyn_channelinstanceid](#BKMK_msdyn_channelinstanceid)
- [msdyn_closurereason](#BKMK_msdyn_closurereason)
- [msdyn_liveworkitemid](#BKMK_msdyn_liveworkitemid)
- [msdyn_primarysession](#BKMK_msdyn_primarysession)
- [msdyn_queueassignedon](#BKMK_msdyn_queueassignedon)
- [msdyn_queueassignedreason](#BKMK_msdyn_queueassignedreason)
- [msdyn_queueid](#BKMK_msdyn_queueid)
- [msdyn_routingfailurestage](#BKMK_msdyn_routingfailurestage)
- [msdyn_sessionclosedon](#BKMK_msdyn_sessionclosedon)
- [msdyn_sessioncreatedon](#BKMK_msdyn_sessioncreatedon)
- [msdyn_sessioncreationreason](#BKMK_msdyn_sessioncreationreason)
- [msdyn_sessionid](#BKMK_msdyn_sessionid)
- [msdyn_sessionmodifiedon](#BKMK_msdyn_sessionmodifiedon)
- [msdyn_state](#BKMK_msdyn_state)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [Organizer](#BKMK_Organizer)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Partners](#BKMK_Partners)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RequiredAttendees](#BKMK_RequiredAttendees)
- [Resources](#BKMK_Resources)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [ServiceId](#BKMK_ServiceId)
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subject](#BKMK_Subject)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [To](#BKMK_To)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ActivityAdditionalParams"></a> ActivityAdditionalParams

|Property|Value|
|---|---|
|Description|**Additional information provided by the external application as JSON. For internal use only.**|
|DisplayName|**Activity Additional Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`activityadditionalparams`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8192|

### <a name="BKMK_ActivityId"></a> ActivityId

|Property|Value|
|---|---|
|Description|**Unique identifier of the activity.**|
|DisplayName|**Activity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`activityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|---|---|
|Description|**Actual duration of the activity in minutes.**|
|DisplayName|**Actual Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualdurationminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_ActualEnd"></a> ActualEnd

|Property|Value|
|---|---|
|Description|**Actual end time of the activity.**|
|DisplayName|**Actual End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|---|---|
|Description|**Actual start time of the activity.**|
|DisplayName|**Actual Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_BCC"></a> BCC

|Property|Value|
|---|---|
|Description|**Blind Carbon-copy (bcc) recipients of the activity.**|
|DisplayName|**BCC**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`bcc`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, lead, systemuser|

### <a name="BKMK_CC"></a> CC

|Property|Value|
|---|---|
|Description|**Carbon-copy (cc) recipients of the activity.**|
|DisplayName|**CC**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`cc`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, lead, systemuser|

### <a name="BKMK_Community"></a> Community

|Property|Value|
|---|---|
|Description|**Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.**|
|DisplayName|**Social Channel**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`community`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`socialprofile_community`|

#### Community Choices/Options

|Value|Label|
|---|---|
|0|**Other**|
|1|**Facebook**|
|2|**Twitter**|
|3|**Line**|
|4|**Wechat**|
|5|**Cortana**|
|6|**Direct Line**|
|7|**Microsoft Teams**|
|8|**Direct Line Speech**|
|9|**Email**|
|10|**GroupMe**|
|11|**Kik**|
|12|**Telegram**|
|13|**Skype**|
|14|**Slack**|
|15|**WhatsApp**|
|16|**Apple Messages For Business**|
|17|**Google's Business Messages**|

### <a name="BKMK_Customers"></a> Customers

|Property|Value|
|---|---|
|Description|**Customer with which the activity is associated.**|
|DisplayName|**Customers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customers`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact|

### <a name="BKMK_DeliveryPriorityCode"></a> DeliveryPriorityCode

|Property|Value|
|---|---|
|Description|**Priority of delivery of the activity to the email server.**|
|DisplayName|**Delivery Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`deliveryprioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`activitypointer_deliveryprioritycode`|

#### DeliveryPriorityCode Choices/Options

|Value|Label|
|---|---|
|0|**Low**|
|1|**Normal**|
|2|**High**|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Description of the activity.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_ExchangeItemId"></a> ExchangeItemId

|Property|Value|
|---|---|
|Description|**The message id of activity which is returned from Exchange Server.**|
|DisplayName|**Exchange Item ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`exchangeitemid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_ExchangeWebLink"></a> ExchangeWebLink

|Property|Value|
|---|---|
|Description|**Shows the web link of Activity of type email.**|
|DisplayName|**Exchange WebLink**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`exchangeweblink`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_From"></a> From

|Property|Value|
|---|---|
|Description|**Person who the activity is from.**|
|DisplayName|**From**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`from`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, lead, systemuser|

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

### <a name="BKMK_IsBilled"></a> IsBilled

|Property|Value|
|---|---|
|Description|**Information regarding whether the activity was billed as part of resolving a case.**|
|DisplayName|**Is Billed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isbilled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocsession_isbilled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsMapiPrivate"></a> IsMapiPrivate

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Private**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismapiprivate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocsession_ismapiprivate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|---|---|
|Description|**Information regarding whether the activity was created from a workflow rule.**|
|DisplayName|**Is Workflow Created**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isworkflowcreated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocsession_isworkflowcreated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|---|---|
|Description|**Contains the date and time stamp of the last on hold time.**|
|DisplayName|**Last On Hold Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastonholdtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_LeftVoiceMail"></a> LeftVoiceMail

|Property|Value|
|---|---|
|Description|**Left the voice mail**|
|DisplayName|**Left Voice Mail**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`leftvoicemail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocsession_leftvoicemail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agentacceptedon"></a> msdyn_agentacceptedon

|Property|Value|
|---|---|
|Description|**Date and time when session was accepted by agent**|
|DisplayName|**Agent Accepted On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentacceptedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_agentassignedon"></a> msdyn_agentassignedon

|Property|Value|
|---|---|
|Description|**Date and time when session was assigned to agent**|
|DisplayName|**Agent Assigned On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentassignedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_botengagementmode"></a> msdyn_botengagementmode

|Property|Value|
|---|---|
|Description|**Indicates when a bot was engaged**|
|DisplayName|**Bot Engagement Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_botengagementmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocsession_msdyn_botengagementmode`|

#### msdyn_botengagementmode Choices/Options

|Value|Label|
|---|---|
|192350000|**Default**|
|192350001|**PreConversation**|
|192350002|**PostConverstation**|
|192350003|**OffBusinessHour**|

### <a name="BKMK_msdyn_cdsqueueid"></a> msdyn_cdsqueueid

|Property|Value|
|---|---|
|Description|**Unique identifier for Queue associated with Session.**|
|DisplayName|**Queue Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cdsqueueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queue|

### <a name="BKMK_msdyn_channel"></a> msdyn_channel

|Property|Value|
|---|---|
|Description|**The channel type of the session**|
|DisplayName|**Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_streamsource`|

#### msdyn_channel Choices/Options

|Value|Label|
|---|---|
|19241000|**Microsoft Teams**|
|192300000|**WhatsApp**|
|192310000|**LINE**|
|192320000|**WeChat**|
|192330000|**Facebook**|
|192340000|**SMS**|
|192350000|**Entity Records**|
|192350001|**Twitter**|
|192350002|**Custom**|
|192360000|**Live chat**|
|192370000|**Voice**|
|192380000|**Video**|
|192390000|**Co-browse**|
|192400000|**Screen sharing**|
|192440000|**Voice call**|
|192450000|**Apple Messages for Business**|
|192450001|**Google's Business Messages**|

### <a name="BKMK_msdyn_channelinstanceid"></a> msdyn_channelinstanceid

|Property|Value|
|---|---|
|Description|**Unique identifier to identify the app to which this conversation belogs to.**|
|DisplayName|**Channel Instance ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channelinstanceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_channelinstance|

### <a name="BKMK_msdyn_closurereason"></a> msdyn_closurereason

|Property|Value|
|---|---|
|Description|**Reason for session closure**|
|DisplayName|**Closure Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_closurereason`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocsession_msdyn_closurereason`|

#### msdyn_closurereason Choices/Options

|Value|Label|
|---|---|
|192350000|**Default**|
|192350001|**AgentReject**|
|192350002|**AgentTimeout**|
|192350003|**ConversationTimeout**|
|192350004|**AgentClosed**|
|192350005|**ConversationClosed**|
|192350006|**AgentTransfered**|
|192350007|**AgentDisconnected**|
|192350008|**AgentReRouted**|
|192350009|**VirtualAgentClosed**|
|192350010|**AgentTransferToQueue**|
|192350011|**SupervisorAssignToQueue**|
|192350012|**SupervisorTransferToAgent**|
|192350013|**SystemReject**|
|192350014|**ForceClose**|
|192350015|**OverflowQueueTransfer**|
|192350016|**OverflowEndConversation**|
|192350017|**AddAgentFailed**|
|192350018|**AutoClose**|
|192350019|**SecondaryChannelClosed**|
|192350020|**CustomerDisconnect**|
|192350021|**AgentEndConversation**|
|192350022|**CustomerEndConversation**|

### <a name="BKMK_msdyn_liveworkitemid"></a> msdyn_liveworkitemid

|Property|Value|
|---|---|
|Description|**Unique Identifier  of Conversation associated to the session**|
|DisplayName|**Conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_primarysession"></a> msdyn_primarysession

|Property|Value|
|---|---|
|Description|**Reference to primary session.**|
|DisplayName|**Primary Session**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primarysession`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocsession|

### <a name="BKMK_msdyn_queueassignedon"></a> msdyn_queueassignedon

|Property|Value|
|---|---|
|Description|**Date and time when queue was assigned to session**|
|DisplayName|**Queue Assigned On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queueassignedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_queueassignedreason"></a> msdyn_queueassignedreason

|Property|Value|
|---|---|
|Description|**Reason for Queue Assignment (This is for internal use only. Customers are advised to not use this property)**|
|DisplayName|**Queue Assignment Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queueassignedreason`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_occallsessioneventreasons`|

#### msdyn_queueassignedreason Choices/Options

|Value|Label|
|---|---|
|192350000|**Default**|
|192350001|**AgentTransfer**|
|192350002|**QueueTransfer**|
|192350003|**PreChatSurvey**|
|192350004|**PostchatSurvey**|
|192350005|**UserAccept**|
|192350006|**AutoAccept**|
|192350007|**Closed**|
|192350008|**AgentInviteRejected**|
|192350009|**AgentInviteTimeout**|
|192350010|**AgentDisconnected**|
|192350011|**AgentTimeout**|
|192350012|**AgentTransferred**|
|192350013|**CustomerTimeout**|
|192350014|**CustomerDisconnect**|
|192350015|**SessionTimeout**|
|192350016|**Escalated**|
|192350017|**Rejected**|
|192350018|**TimedOut**|
|192350019|**Accepted**|
|192350020|**AutoAccepted**|
|192350021|**Disconnect**|
|192350022|**Timeout**|
|192350023|**End**|
|192350024|**BotTransferSession**|
|192350025|**BotEndConversation**|
|192350026|**AssignToAgentBySupervisor**|
|192350027|**AssignToQueueBySupervisor**|
|192350028|**CustomerRejoin**|
|192350029|**CustomerEndConversation**|
|192350030|**AgentEndConversation**|
|192350031|**SupervisorTransferToAgent**|
|192350032|**AgentEndConsult**|
|192350033|**ForceClose**|
|192350034|**OverflowQueueTransfer**|
|192350035|**OverflowEndConversation**|
|192350036|**OverflowAssignToQueue**|
|192350037|**SessionEndAfterWrapUp**|
|192350038|**ConversationExpired**|
|192350039|**Consult**|
|192350040|**AgentMonitor**|
|192350041|**AgentConversationJoin**|
|192350042|**Preview**|

### <a name="BKMK_msdyn_queueid"></a> msdyn_queueid

|Property|Value|
|---|---|
|Description|**Queue associated to the session**|
|DisplayName|**Queue Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_omnichannelqueue|

### <a name="BKMK_msdyn_routingfailurestage"></a> msdyn_routingfailurestage

|Property|Value|
|---|---|
|Description|**Routing Failure Stage**|
|DisplayName|**Routing Failure Stage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routingfailurestage`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|10|
|GlobalChoiceName|`msdyn_routingfailurestage`|

#### msdyn_routingfailurestage Choices/Options

|Value|Label|
|---|---|
|10|**None**|
|1000|**Record Identification**|
|2000|**Demand Classification**|

### <a name="BKMK_msdyn_sessionclosedon"></a> msdyn_sessionclosedon

|Property|Value|
|---|---|
|Description|**Date and time when session was closed**|
|DisplayName|**Session Closed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sessionclosedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_sessioncreatedon"></a> msdyn_sessioncreatedon

|Property|Value|
|---|---|
|Description|**Date and time when session was created**|
|DisplayName|**Session Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sessioncreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_sessioncreationreason"></a> msdyn_sessioncreationreason

|Property|Value|
|---|---|
|Description|**Reason for session creation (This is for internal use only. Customers are advised to not use this property)**|
|DisplayName|**Created Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sessioncreationreason`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_occallsessioneventreasons`|

#### msdyn_sessioncreationreason Choices/Options

|Value|Label|
|---|---|
|192350000|**Default**|
|192350001|**AgentTransfer**|
|192350002|**QueueTransfer**|
|192350003|**PreChatSurvey**|
|192350004|**PostchatSurvey**|
|192350005|**UserAccept**|
|192350006|**AutoAccept**|
|192350007|**Closed**|
|192350008|**AgentInviteRejected**|
|192350009|**AgentInviteTimeout**|
|192350010|**AgentDisconnected**|
|192350011|**AgentTimeout**|
|192350012|**AgentTransferred**|
|192350013|**CustomerTimeout**|
|192350014|**CustomerDisconnect**|
|192350015|**SessionTimeout**|
|192350016|**Escalated**|
|192350017|**Rejected**|
|192350018|**TimedOut**|
|192350019|**Accepted**|
|192350020|**AutoAccepted**|
|192350021|**Disconnect**|
|192350022|**Timeout**|
|192350023|**End**|
|192350024|**BotTransferSession**|
|192350025|**BotEndConversation**|
|192350026|**AssignToAgentBySupervisor**|
|192350027|**AssignToQueueBySupervisor**|
|192350028|**CustomerRejoin**|
|192350029|**CustomerEndConversation**|
|192350030|**AgentEndConversation**|
|192350031|**SupervisorTransferToAgent**|
|192350032|**AgentEndConsult**|
|192350033|**ForceClose**|
|192350034|**OverflowQueueTransfer**|
|192350035|**OverflowEndConversation**|
|192350036|**OverflowAssignToQueue**|
|192350037|**SessionEndAfterWrapUp**|
|192350038|**ConversationExpired**|
|192350039|**Consult**|
|192350040|**AgentMonitor**|
|192350041|**AgentConversationJoin**|
|192350042|**Preview**|

### <a name="BKMK_msdyn_sessionid"></a> msdyn_sessionid

|Property|Value|
|---|---|
|Description|**Unique Identifier of Session**|
|DisplayName|**Session Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sessionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_sessionmodifiedon"></a> msdyn_sessionmodifiedon

|Property|Value|
|---|---|
|Description|**Date and time when session was last modified**|
|DisplayName|**Session Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sessionmodifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_state"></a> msdyn_state

|Property|Value|
|---|---|
|Description|**(Deprecated)**|
|DisplayName|**State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_state`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocsession_msdyn_state`|

#### msdyn_state Choices/Options

|Value|Label|
|---|---|
|192350000|**Default**|
|192350001|**Active**|
|192350002|**Closed**|
|192350003|**New**|

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

|Property|Value|
|---|---|
|Description|**List of optional attendees for the activity.**|
|DisplayName|**Optional Attendees**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`optionalattendees`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, entitlement, equipment, knowledgearticle, lead, msdyn_salessuggestion, queue, systemuser, unresolvedaddress|

### <a name="BKMK_Organizer"></a> Organizer

|Property|Value|
|---|---|
|Description|**Person who organized the activity.**|
|DisplayName|**Organizer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`organizer`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|systemuser|

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
|Description|**Unique identifier of the user or team who owns the activity.**|
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
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_Partners"></a> Partners

|Property|Value|
|---|---|
|Description|**Outsource vendor with which activity is associated.**|
|DisplayName|**Outsource Vendors**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partners`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact|

### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|---|---|
|Description|**Priority of the activity.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`prioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_ocsession_prioritycode`|

#### PriorityCode Choices/Options

|Value|Label|
|---|---|
|0|**Low**|
|1|**Normal**|
|2|**High**|

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Unique identifier of the Process.**|
|DisplayName|**Process**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|---|---|
|Description|**Unique identifier of the object with which the activity is associated.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, adx_ad, adx_adplacement, adx_casedeflection, adx_communityforumaccesspermission, adx_communityforumalert, adx_contentaccesslevel, adx_invitation, adx_poll, adx_polloption, adx_pollplacement, adx_pollsubmission, adx_publishingstatetransitionrule, adx_redirect, adx_shortcut, adx_webpage, adx_website, bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contact, contract, entitlement, entitlementtemplate, incident, interactionforemail, invoice, knowledgearticle, knowledgebaserecord, lead, msdyncrm_contentsettings, msdyncrm_customerjourney, msdyncrm_leadscoremodel, msdyncrm_linkedinaccount, msdyncrm_linkedinactivity, msdyncrm_linkedinfieldmapping, msdyncrm_linkedinform, msdyncrm_linkedinformanswer, msdyncrm_linkedinformquestion, msdyncrm_linkedinformsubmission, msdyncrm_linkedinleadmatchingstrategy, msdyncrm_linkedinuserprofile, msdyncrm_marketingdynamiccontentmetadata, msdyncrm_marketingemaildynamiccontentmetadata, msdyncrm_marketingemailtestsend, msdyncrm_migration, msdyncrm_uicconfig, msdyn_agreement, msdyn_agreementbookingdate, msdyn_agreementbookingincident, msdyn_agreementbookingproduct, msdyn_agreementbookingservice, msdyn_agreementbookingservicetask, msdyn_agreementbookingsetup, msdyn_agreementinvoicedate, msdyn_agreementinvoiceproduct, msdyn_agreementinvoicesetup, msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_bookingtimestamp, msdyn_customerasset, msdyn_fieldservicesetting, msdyn_incidenttypecharacteristic, msdyn_incidenttypeproduct, msdyn_incidenttypeservice, msdyn_inventoryadjustment, msdyn_inventoryadjustmentproduct, msdyn_inventoryjournal, msdyn_inventorytransfer, msdyn_payment, msdyn_paymentdetail, msdyn_paymentmethod, msdyn_paymentterm, msdyn_playbookinstance, msdyn_postalbum, msdyn_postalcode, msdyn_productinventory, msdyn_purchaseorder, msdyn_purchaseorderbill, msdyn_purchaseorderproduct, msdyn_purchaseorderreceipt, msdyn_purchaseorderreceiptproduct, msdyn_purchaseordersubstatus, msdyn_quotebookingincident, msdyn_quotebookingproduct, msdyn_quotebookingservice, msdyn_quotebookingservicetask, msdyn_resourceterritory, msdyn_rma, msdyn_rmaproduct, msdyn_rmareceipt, msdyn_rmareceiptproduct, msdyn_rmasubstatus, msdyn_rtv, msdyn_rtvproduct, msdyn_rtvsubstatus, msdyn_salessuggestion, msdyn_shipvia, msdyn_swarm, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail, msdyn_timeoffrequest, msdyn_warehouse, msdyn_workorder, msdyn_workordercharacteristic, msdyn_workorderincident, msdyn_workorderproduct, msdyn_workorderresourcerestriction, msdyn_workorderservice, msdyn_workorderservicetask, msevtmgt_checkin, msevtmgt_event, msevtmgt_eventpurchase, msevtmgt_eventpurchaseattendee, msevtmgt_eventpurchasepass, msevtmgt_eventregistration, msevtmgt_hotel, msevtmgt_hotelroomallocation, msevtmgt_hotelroomreservation, msevtmgt_layout, msevtmgt_room, msevtmgt_session, msevtmgt_sessionregistration, msevtmgt_sessiontrack, msevtmgt_speaker, msevtmgt_speakerengagement, msevtmgt_sponsorablearticle, msevtmgt_sponsorship, msevtmgt_venue, msevtmgt_webinarconfiguration, msevtmgt_webinarprovider, mspp_adplacement, mspp_pollplacement, mspp_publishingstatetransitionrule, mspp_redirect, mspp_shortcut, mspp_website, opportunity, quote, salesorder, site|

### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjecttypecode`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

|Property|Value|
|---|---|
|Description|**List of required attendees for the activity.**|
|DisplayName|**Required Attendees**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`requiredattendees`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, entitlement, equipment, knowledgearticle, lead, msdyn_salessuggestion, queue, systemuser, unresolvedaddress|

### <a name="BKMK_Resources"></a> Resources

|Property|Value|
|---|---|
|Description|**Users or facility/equipment that are required for the activity.**|
|DisplayName|**Resources**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resources`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|equipment, systemuser|

### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|---|---|
|Description|**Scheduled duration of the activity, specified in minutes.**|
|DisplayName|**Scheduled Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduleddurationminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|---|---|
|Description|**Scheduled end time of the activity.**|
|DisplayName|**Due Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|---|---|
|Description|**Scheduled start time of the activity.**|
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier of an associated service.**|
|DisplayName|**Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`serviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|service|

### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|---|---|
|Description|**Choose the service level agreement (SLA) that you want to apply to the case record.**|
|DisplayName|**SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`slaid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_SortDate"></a> SortDate

|Property|Value|
|---|---|
|Description|**Shows the date and time by which the activities are sorted.**|
|DisplayName|**Sort Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sortdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Unique identifier of the Stage.**|
|DisplayName|**Process Stage**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Status of the activity.**|
|DisplayName|**Activity Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_ocsession_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Completed**<br />DefaultStatus: 2<br />InvariantName: `Completed`|
|2|Label: **Canceled**<br />DefaultStatus: 3<br />InvariantName: `Canceled`|
|3|Label: **Scheduled**<br />DefaultStatus: 4<br />InvariantName: `Scheduled`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Reason for the status of the activity.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocsession_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Open**<br />State:0<br />TransitionData: None|
|2|Label: **Completed**<br />State:1<br />TransitionData: None|
|3|Label: **Canceled**<br />State:2<br />TransitionData: None|
|4|Label: **Scheduled**<br />State:3<br />TransitionData: None|

### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|---|---|
|Description|**Subject associated with the activity.**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`subject`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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

### <a name="BKMK_To"></a> To

|Property|Value|
|---|---|
|Description|**Person who is the receiver of the activity.**|
|DisplayName|**To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`to`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, lead, systemuser|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the activitypointer.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Traversed Path**|
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

- [ActivityTypeCode](#BKMK_ActivityTypeCode)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [DeliveryLastAttemptedOn](#BKMK_DeliveryLastAttemptedOn)
- [ExchangeRate](#BKMK_ExchangeRate)
- [InstanceTypeCode](#BKMK_InstanceTypeCode)
- [IsRegularActivity](#BKMK_IsRegularActivity)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PostponeActivityProcessingUntil](#BKMK_PostponeActivityProcessingUntil)
- [SenderMailboxId](#BKMK_SenderMailboxId)
- [SentOn](#BKMK_SentOn)
- [SeriesId](#BKMK_SeriesId)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ActivityTypeCode"></a> ActivityTypeCode

|Property|Value|
|---|---|
|Description|**Type of activity.**|
|DisplayName|**Activity Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`activitytypecode`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the activity.**|
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
|Description|**Date and time when the activity was created.**|
|DisplayName|**Date Created**|
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
|Description|**Unique identifier of the delegate user who created the activitypointer.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_DeliveryLastAttemptedOn"></a> DeliveryLastAttemptedOn

|Property|Value|
|---|---|
|Description|**Date and time when the delivery of the activity was last attempted.**|
|DisplayName|**Date Delivery Last Attempted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`deliverylastattemptedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the activitypointer with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

|Property|Value|
|---|---|
|Description|**Type of instance of a recurring series.**|
|DisplayName|**Recurring Instance Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`instancetypecode`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_ocsession_instancetypecode`|

#### InstanceTypeCode Choices/Options

|Value|Label|
|---|---|
|0|**Not Recurring**|
|1|**Recurring Master**|
|2|**Recurring Instance**|
|3|**Recurring Exception**|
|4|**Recurring Future Exception**|

### <a name="BKMK_IsRegularActivity"></a> IsRegularActivity

|Property|Value|
|---|---|
|Description|**Information regarding whether the activity is a regular activity type or event type.**|
|DisplayName|**Is Regular Activity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isregularactivity`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`activitypointer_isregularactivity`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of user who last modified the activity.**|
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
|Description|**Date and time when activity was last modified.**|
|DisplayName|**Last Updated**|
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
|Description|**Unique identifier of the delegate user who last modified the activitypointer.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|---|---|
|Description|**Shows how long, in minutes, that the record was on hold.**|
|DisplayName|**On Hold Time (Minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`onholdtime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description||
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
|Description||
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
|Description|**Unique identifier of the business unit that owns the activity.**|
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
|Description|**Unique identifier of the team that owns the activity.**|
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
|Description|**Unique identifier of the user that owns the activity.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_PostponeActivityProcessingUntil"></a> PostponeActivityProcessingUntil

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Delay activity processing until**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`postponeactivityprocessinguntil`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SenderMailboxId"></a> SenderMailboxId

|Property|Value|
|---|---|
|Description|**Unique identifier of the mailbox associated with the sender of the email message.**|
|DisplayName|**Sender's Mailbox**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sendermailboxid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|mailbox|

### <a name="BKMK_SentOn"></a> SentOn

|Property|Value|
|---|---|
|Description|**Date and time when the activity was sent.**|
|DisplayName|**Date Sent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`senton`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SeriesId"></a> SeriesId

|Property|Value|
|---|---|
|Description|**Uniqueidentifier specifying the id of recurring series of an instance.**|
|DisplayName|**Series Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`seriesid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|---|---|
|Description|**Last SLA that was applied to this case. This field is for internal use only.**|
|DisplayName|**Last SLA applied**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`slainvokedid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version number of the activity.**|
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

- [account_msdyn_ocsessions](#BKMK_account_msdyn_ocsessions)
- [activity_pointer_msdyn_ocsession](#BKMK_activity_pointer_msdyn_ocsession)
- [adx_ad_msdyn_ocsessions](#BKMK_adx_ad_msdyn_ocsessions)
- [adx_adplacement_msdyn_ocsessions](#BKMK_adx_adplacement_msdyn_ocsessions)
- [adx_casedeflection_msdyn_ocsessions](#BKMK_adx_casedeflection_msdyn_ocsessions)
- [adx_communityforumaccesspermission_msdyn_ocsessions](#BKMK_adx_communityforumaccesspermission_msdyn_ocsessions)
- [adx_communityforumalert_msdyn_ocsessions](#BKMK_adx_communityforumalert_msdyn_ocsessions)
- [adx_contentaccesslevel_msdyn_ocsessions](#BKMK_adx_contentaccesslevel_msdyn_ocsessions)
- [adx_invitation_msdyn_ocsessions](#BKMK_adx_invitation_msdyn_ocsessions)
- [adx_poll_msdyn_ocsessions](#BKMK_adx_poll_msdyn_ocsessions)
- [adx_polloption_msdyn_ocsessions](#BKMK_adx_polloption_msdyn_ocsessions)
- [adx_pollplacement_msdyn_ocsessions](#BKMK_adx_pollplacement_msdyn_ocsessions)
- [adx_pollsubmission_msdyn_ocsessions](#BKMK_adx_pollsubmission_msdyn_ocsessions)
- [adx_publishingstatetransitionrule_msdyn_ocsessions](#BKMK_adx_publishingstatetransitionrule_msdyn_ocsessions)
- [adx_redirect_msdyn_ocsessions](#BKMK_adx_redirect_msdyn_ocsessions)
- [adx_shortcut_msdyn_ocsessions](#BKMK_adx_shortcut_msdyn_ocsessions)
- [adx_webpage_msdyn_ocsessions](#BKMK_adx_webpage_msdyn_ocsessions)
- [adx_website_msdyn_ocsessions](#BKMK_adx_website_msdyn_ocsessions)
- [bookableresourcebooking_msdyn_ocsessions](#BKMK_bookableresourcebooking_msdyn_ocsessions)
- [bookableresourcebookingheader_msdyn_ocsessions](#BKMK_bookableresourcebookingheader_msdyn_ocsessions)
- [bulkoperation_msdyn_ocsessions](#BKMK_bulkoperation_msdyn_ocsessions)
- [campaign_msdyn_ocsessions](#BKMK_campaign_msdyn_ocsessions)
- [campaignactivity_msdyn_ocsessions](#BKMK_campaignactivity_msdyn_ocsessions)
- [contact_msdyn_ocsessions](#BKMK_contact_msdyn_ocsessions)
- [contract_msdyn_ocsessions](#BKMK_contract_msdyn_ocsessions)
- [entitlement_msdyn_ocsessions](#BKMK_entitlement_msdyn_ocsessions)
- [entitlementtemplate_msdyn_ocsessions](#BKMK_entitlementtemplate_msdyn_ocsessions)
- [incident_msdyn_ocsessions](#BKMK_incident_msdyn_ocsessions)
- [interactionforemail_msdyn_ocsessions](#BKMK_interactionforemail_msdyn_ocsessions)
- [invoice_msdyn_ocsessions](#BKMK_invoice_msdyn_ocsessions)
- [knowledgearticle_msdyn_ocsessions](#BKMK_knowledgearticle_msdyn_ocsessions)
- [knowledgebaserecord_msdyn_ocsessions](#BKMK_knowledgebaserecord_msdyn_ocsessions)
- [lead_msdyn_ocsessions](#BKMK_lead_msdyn_ocsessions)
- [msdyn_agreement_msdyn_ocsessions](#BKMK_msdyn_agreement_msdyn_ocsessions)
- [msdyn_agreementbookingdate_msdyn_ocsessions](#BKMK_msdyn_agreementbookingdate_msdyn_ocsessions)
- [msdyn_agreementbookingincident_msdyn_ocsessions](#BKMK_msdyn_agreementbookingincident_msdyn_ocsessions)
- [msdyn_agreementbookingproduct_msdyn_ocsessions](#BKMK_msdyn_agreementbookingproduct_msdyn_ocsessions)
- [msdyn_agreementbookingservice_msdyn_ocsessions](#BKMK_msdyn_agreementbookingservice_msdyn_ocsessions)
- [msdyn_agreementbookingservicetask_msdyn_ocsessions](#BKMK_msdyn_agreementbookingservicetask_msdyn_ocsessions)
- [msdyn_agreementbookingsetup_msdyn_ocsessions](#BKMK_msdyn_agreementbookingsetup_msdyn_ocsessions)
- [msdyn_agreementinvoicedate_msdyn_ocsessions](#BKMK_msdyn_agreementinvoicedate_msdyn_ocsessions)
- [msdyn_agreementinvoiceproduct_msdyn_ocsessions](#BKMK_msdyn_agreementinvoiceproduct_msdyn_ocsessions)
- [msdyn_agreementinvoicesetup_msdyn_ocsessions](#BKMK_msdyn_agreementinvoicesetup_msdyn_ocsessions)
- [msdyn_bookingalertstatus_msdyn_ocsessions](#BKMK_msdyn_bookingalertstatus_msdyn_ocsessions)
- [msdyn_bookingrule_msdyn_ocsessions](#BKMK_msdyn_bookingrule_msdyn_ocsessions)
- [msdyn_bookingtimestamp_msdyn_ocsessions](#BKMK_msdyn_bookingtimestamp_msdyn_ocsessions)
- [msdyn_customerasset_msdyn_ocsessions](#BKMK_msdyn_customerasset_msdyn_ocsessions)
- [msdyn_fieldservicesetting_msdyn_ocsessions](#BKMK_msdyn_fieldservicesetting_msdyn_ocsessions)
- [msdyn_incidenttypecharacteristic_msdyn_ocsessions](#BKMK_msdyn_incidenttypecharacteristic_msdyn_ocsessions)
- [msdyn_incidenttypeproduct_msdyn_ocsessions](#BKMK_msdyn_incidenttypeproduct_msdyn_ocsessions)
- [msdyn_incidenttypeservice_msdyn_ocsessions](#BKMK_msdyn_incidenttypeservice_msdyn_ocsessions)
- [msdyn_inventoryadjustment_msdyn_ocsessions](#BKMK_msdyn_inventoryadjustment_msdyn_ocsessions)
- [msdyn_inventoryadjustmentproduct_msdyn_ocsessions](#BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocsessions)
- [msdyn_inventoryjournal_msdyn_ocsessions](#BKMK_msdyn_inventoryjournal_msdyn_ocsessions)
- [msdyn_inventorytransfer_msdyn_ocsessions](#BKMK_msdyn_inventorytransfer_msdyn_ocsessions)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid)
- [msdyn_msdyn_ocsession_msdyn_channelinstance](#BKMK_msdyn_msdyn_ocsession_msdyn_channelinstance)
- [msdyn_msdyn_ocsession_msdyn_ocsession_primarysession](#BKMK_msdyn_msdyn_ocsession_msdyn_ocsession_primarysession-many-to-one)
- [msdyn_msdyn_omnichannelqueue_msdyn_ocsession_queueid](#BKMK_msdyn_msdyn_omnichannelqueue_msdyn_ocsession_queueid)
- [msdyn_ocsession_businessunit_owningbusinessunit](#BKMK_msdyn_ocsession_businessunit_owningbusinessunit)
- [msdyn_ocsession_mailbox_sendermailboxid](#BKMK_msdyn_ocsession_mailbox_sendermailboxid)
- [msdyn_ocsession_owner_ownerid](#BKMK_msdyn_ocsession_owner_ownerid)
- [msdyn_ocsession_service_serviceid](#BKMK_msdyn_ocsession_service_serviceid)
- [msdyn_ocsession_sla_slaid](#BKMK_msdyn_ocsession_sla_slaid)
- [msdyn_ocsession_sla_slainvokedid](#BKMK_msdyn_ocsession_sla_slainvokedid)
- [msdyn_ocsession_systemuser_createdby](#BKMK_msdyn_ocsession_systemuser_createdby)
- [msdyn_ocsession_systemuser_createdonbehalfby](#BKMK_msdyn_ocsession_systemuser_createdonbehalfby)
- [msdyn_ocsession_systemuser_modifiedby](#BKMK_msdyn_ocsession_systemuser_modifiedby)
- [msdyn_ocsession_systemuser_modifiedonbehalfby](#BKMK_msdyn_ocsession_systemuser_modifiedonbehalfby)
- [msdyn_ocsession_systemuser_owninguser](#BKMK_msdyn_ocsession_systemuser_owninguser)
- [msdyn_ocsession_team_owningteam](#BKMK_msdyn_ocsession_team_owningteam)
- [msdyn_ocsession_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_ocsession_transactioncurrency_transactioncurrencyid)
- [msdyn_payment_msdyn_ocsessions](#BKMK_msdyn_payment_msdyn_ocsessions)
- [msdyn_paymentdetail_msdyn_ocsessions](#BKMK_msdyn_paymentdetail_msdyn_ocsessions)
- [msdyn_paymentmethod_msdyn_ocsessions](#BKMK_msdyn_paymentmethod_msdyn_ocsessions)
- [msdyn_paymentterm_msdyn_ocsessions](#BKMK_msdyn_paymentterm_msdyn_ocsessions)
- [msdyn_playbookinstance_msdyn_ocsessions](#BKMK_msdyn_playbookinstance_msdyn_ocsessions)
- [msdyn_postalbum_msdyn_ocsessions](#BKMK_msdyn_postalbum_msdyn_ocsessions)
- [msdyn_postalcode_msdyn_ocsessions](#BKMK_msdyn_postalcode_msdyn_ocsessions)
- [msdyn_productinventory_msdyn_ocsessions](#BKMK_msdyn_productinventory_msdyn_ocsessions)
- [msdyn_purchaseorder_msdyn_ocsessions](#BKMK_msdyn_purchaseorder_msdyn_ocsessions)
- [msdyn_purchaseorderbill_msdyn_ocsessions](#BKMK_msdyn_purchaseorderbill_msdyn_ocsessions)
- [msdyn_purchaseorderproduct_msdyn_ocsessions](#BKMK_msdyn_purchaseorderproduct_msdyn_ocsessions)
- [msdyn_purchaseorderreceipt_msdyn_ocsessions](#BKMK_msdyn_purchaseorderreceipt_msdyn_ocsessions)
- [msdyn_purchaseorderreceiptproduct_msdyn_ocsessions](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocsessions)
- [msdyn_purchaseordersubstatus_msdyn_ocsessions](#BKMK_msdyn_purchaseordersubstatus_msdyn_ocsessions)
- [msdyn_queue_msdyn_ocsession_queueid](#BKMK_msdyn_queue_msdyn_ocsession_queueid)
- [msdyn_quotebookingincident_msdyn_ocsessions](#BKMK_msdyn_quotebookingincident_msdyn_ocsessions)
- [msdyn_quotebookingproduct_msdyn_ocsessions](#BKMK_msdyn_quotebookingproduct_msdyn_ocsessions)
- [msdyn_quotebookingservice_msdyn_ocsessions](#BKMK_msdyn_quotebookingservice_msdyn_ocsessions)
- [msdyn_quotebookingservicetask_msdyn_ocsessions](#BKMK_msdyn_quotebookingservicetask_msdyn_ocsessions)
- [msdyn_resourceterritory_msdyn_ocsessions](#BKMK_msdyn_resourceterritory_msdyn_ocsessions)
- [msdyn_rma_msdyn_ocsessions](#BKMK_msdyn_rma_msdyn_ocsessions)
- [msdyn_rmaproduct_msdyn_ocsessions](#BKMK_msdyn_rmaproduct_msdyn_ocsessions)
- [msdyn_rmareceipt_msdyn_ocsessions](#BKMK_msdyn_rmareceipt_msdyn_ocsessions)
- [msdyn_rmareceiptproduct_msdyn_ocsessions](#BKMK_msdyn_rmareceiptproduct_msdyn_ocsessions)
- [msdyn_rmasubstatus_msdyn_ocsessions](#BKMK_msdyn_rmasubstatus_msdyn_ocsessions)
- [msdyn_rtv_msdyn_ocsessions](#BKMK_msdyn_rtv_msdyn_ocsessions)
- [msdyn_rtvproduct_msdyn_ocsessions](#BKMK_msdyn_rtvproduct_msdyn_ocsessions)
- [msdyn_rtvsubstatus_msdyn_ocsessions](#BKMK_msdyn_rtvsubstatus_msdyn_ocsessions)
- [msdyn_salessuggestion_msdyn_ocsessions](#BKMK_msdyn_salessuggestion_msdyn_ocsessions)
- [msdyn_shipvia_msdyn_ocsessions](#BKMK_msdyn_shipvia_msdyn_ocsessions)
- [msdyn_swarm_msdyn_ocsessions](#BKMK_msdyn_swarm_msdyn_ocsessions)
- [msdyn_systemuserschedulersetting_msdyn_ocsessions](#BKMK_msdyn_systemuserschedulersetting_msdyn_ocsessions)
- [msdyn_timegroup_msdyn_ocsessions](#BKMK_msdyn_timegroup_msdyn_ocsessions)
- [msdyn_timegroupdetail_msdyn_ocsessions](#BKMK_msdyn_timegroupdetail_msdyn_ocsessions)
- [msdyn_timeoffrequest_msdyn_ocsessions](#BKMK_msdyn_timeoffrequest_msdyn_ocsessions)
- [msdyn_warehouse_msdyn_ocsessions](#BKMK_msdyn_warehouse_msdyn_ocsessions)
- [msdyn_workorder_msdyn_ocsessions](#BKMK_msdyn_workorder_msdyn_ocsessions)
- [msdyn_workordercharacteristic_msdyn_ocsessions](#BKMK_msdyn_workordercharacteristic_msdyn_ocsessions)
- [msdyn_workorderincident_msdyn_ocsessions](#BKMK_msdyn_workorderincident_msdyn_ocsessions)
- [msdyn_workorderproduct_msdyn_ocsessions](#BKMK_msdyn_workorderproduct_msdyn_ocsessions)
- [msdyn_workorderresourcerestriction_msdyn_ocsessions](#BKMK_msdyn_workorderresourcerestriction_msdyn_ocsessions)
- [msdyn_workorderservice_msdyn_ocsessions](#BKMK_msdyn_workorderservice_msdyn_ocsessions)
- [msdyn_workorderservicetask_msdyn_ocsessions](#BKMK_msdyn_workorderservicetask_msdyn_ocsessions)
- [msdyncrm_contentsettings_msdyn_ocsessions](#BKMK_msdyncrm_contentsettings_msdyn_ocsessions)
- [msdyncrm_customerjourney_msdyn_ocsessions](#BKMK_msdyncrm_customerjourney_msdyn_ocsessions)
- [msdyncrm_leadscoremodel_msdyn_ocsessions](#BKMK_msdyncrm_leadscoremodel_msdyn_ocsessions)
- [msdyncrm_linkedinaccount_msdyn_ocsessions](#BKMK_msdyncrm_linkedinaccount_msdyn_ocsessions)
- [msdyncrm_linkedinactivity_msdyn_ocsessions](#BKMK_msdyncrm_linkedinactivity_msdyn_ocsessions)
- [msdyncrm_linkedinfieldmapping_msdyn_ocsessions](#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocsessions)
- [msdyncrm_linkedinform_msdyn_ocsessions](#BKMK_msdyncrm_linkedinform_msdyn_ocsessions)
- [msdyncrm_linkedinformanswer_msdyn_ocsessions](#BKMK_msdyncrm_linkedinformanswer_msdyn_ocsessions)
- [msdyncrm_linkedinformquestion_msdyn_ocsessions](#BKMK_msdyncrm_linkedinformquestion_msdyn_ocsessions)
- [msdyncrm_linkedinformsubmission_msdyn_ocsessions](#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocsessions)
- [msdyncrm_linkedinleadmatchingstrategy_msdyn_ocsessions](#BKMK_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocsessions)
- [msdyncrm_linkedinuserprofile_msdyn_ocsessions](#BKMK_msdyncrm_linkedinuserprofile_msdyn_ocsessions)
- [msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions)
- [msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocsessions](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocsessions)
- [msdyncrm_marketingemailtestsend_msdyn_ocsessions](#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocsessions)
- [msdyncrm_migration_msdyn_ocsessions](#BKMK_msdyncrm_migration_msdyn_ocsessions)
- [msdyncrm_uicconfig_msdyn_ocsessions](#BKMK_msdyncrm_uicconfig_msdyn_ocsessions)
- [msevtmgt_checkin_msdyn_ocsessions](#BKMK_msevtmgt_checkin_msdyn_ocsessions)
- [msevtmgt_event_msdyn_ocsessions](#BKMK_msevtmgt_event_msdyn_ocsessions)
- [msevtmgt_eventpurchase_msdyn_ocsessions](#BKMK_msevtmgt_eventpurchase_msdyn_ocsessions)
- [msevtmgt_eventpurchaseattendee_msdyn_ocsessions](#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocsessions)
- [msevtmgt_eventpurchasepass_msdyn_ocsessions](#BKMK_msevtmgt_eventpurchasepass_msdyn_ocsessions)
- [msevtmgt_eventregistration_msdyn_ocsessions](#BKMK_msevtmgt_eventregistration_msdyn_ocsessions)
- [msevtmgt_hotel_msdyn_ocsessions](#BKMK_msevtmgt_hotel_msdyn_ocsessions)
- [msevtmgt_hotelroomallocation_msdyn_ocsessions](#BKMK_msevtmgt_hotelroomallocation_msdyn_ocsessions)
- [msevtmgt_hotelroomreservation_msdyn_ocsessions](#BKMK_msevtmgt_hotelroomreservation_msdyn_ocsessions)
- [msevtmgt_layout_msdyn_ocsessions](#BKMK_msevtmgt_layout_msdyn_ocsessions)
- [msevtmgt_room_msdyn_ocsessions](#BKMK_msevtmgt_room_msdyn_ocsessions)
- [msevtmgt_session_msdyn_ocsessions](#BKMK_msevtmgt_session_msdyn_ocsessions)
- [msevtmgt_sessionregistration_msdyn_ocsessions](#BKMK_msevtmgt_sessionregistration_msdyn_ocsessions)
- [msevtmgt_sessiontrack_msdyn_ocsessions](#BKMK_msevtmgt_sessiontrack_msdyn_ocsessions)
- [msevtmgt_speaker_msdyn_ocsessions](#BKMK_msevtmgt_speaker_msdyn_ocsessions)
- [msevtmgt_speakerengagement_msdyn_ocsessions](#BKMK_msevtmgt_speakerengagement_msdyn_ocsessions)
- [msevtmgt_sponsorablearticle_msdyn_ocsessions](#BKMK_msevtmgt_sponsorablearticle_msdyn_ocsessions)
- [msevtmgt_sponsorship_msdyn_ocsessions](#BKMK_msevtmgt_sponsorship_msdyn_ocsessions)
- [msevtmgt_venue_msdyn_ocsessions](#BKMK_msevtmgt_venue_msdyn_ocsessions)
- [msevtmgt_webinarconfiguration_msdyn_ocsessions](#BKMK_msevtmgt_webinarconfiguration_msdyn_ocsessions)
- [msevtmgt_webinarprovider_msdyn_ocsessions](#BKMK_msevtmgt_webinarprovider_msdyn_ocsessions)
- [mspp_adplacement_msdyn_ocsessions](#BKMK_mspp_adplacement_msdyn_ocsessions)
- [mspp_pollplacement_msdyn_ocsessions](#BKMK_mspp_pollplacement_msdyn_ocsessions)
- [mspp_publishingstatetransitionrule_msdyn_ocsessions](#BKMK_mspp_publishingstatetransitionrule_msdyn_ocsessions)
- [mspp_redirect_msdyn_ocsessions](#BKMK_mspp_redirect_msdyn_ocsessions)
- [mspp_shortcut_msdyn_ocsessions](#BKMK_mspp_shortcut_msdyn_ocsessions)
- [mspp_website_msdyn_ocsessions](#BKMK_mspp_website_msdyn_ocsessions)
- [opportunity_msdyn_ocsessions](#BKMK_opportunity_msdyn_ocsessions)
- [quote_msdyn_ocsessions](#BKMK_quote_msdyn_ocsessions)
- [salesorder_msdyn_ocsessions](#BKMK_salesorder_msdyn_ocsessions)
- [site_msdyn_ocsessions](#BKMK_site_msdyn_ocsessions)

### <a name="BKMK_account_msdyn_ocsessions"></a> account_msdyn_ocsessions

One-To-Many Relationship: [account account_msdyn_ocsessions](account.md#BKMK_account_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_account_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_activity_pointer_msdyn_ocsession"></a> activity_pointer_msdyn_ocsession

One-To-Many Relationship: [activitypointer activity_pointer_msdyn_ocsession](activitypointer.md#BKMK_activity_pointer_msdyn_ocsession)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_ad_msdyn_ocsessions"></a> adx_ad_msdyn_ocsessions

One-To-Many Relationship: [adx_ad adx_ad_msdyn_ocsessions](adx_ad.md#BKMK_adx_ad_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_msdyn_ocsessions"></a> adx_adplacement_msdyn_ocsessions

One-To-Many Relationship: [adx_adplacement adx_adplacement_msdyn_ocsessions](adx_adplacement.md#BKMK_adx_adplacement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_msdyn_ocsessions"></a> adx_casedeflection_msdyn_ocsessions

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_msdyn_ocsessions](adx_casedeflection.md#BKMK_adx_casedeflection_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_msdyn_ocsessions"></a> adx_communityforumaccesspermission_msdyn_ocsessions

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_msdyn_ocsessions](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumalert_msdyn_ocsessions"></a> adx_communityforumalert_msdyn_ocsessions

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_msdyn_ocsessions](adx_communityforumalert.md#BKMK_adx_communityforumalert_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_msdyn_ocsessions"></a> adx_contentaccesslevel_msdyn_ocsessions

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_msdyn_ocsessions](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_invitation_msdyn_ocsessions"></a> adx_invitation_msdyn_ocsessions

One-To-Many Relationship: [adx_invitation adx_invitation_msdyn_ocsessions](adx_invitation.md#BKMK_adx_invitation_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_invitation`|
|ReferencedAttribute|`adx_invitationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_invitation_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_poll_msdyn_ocsessions"></a> adx_poll_msdyn_ocsessions

One-To-Many Relationship: [adx_poll adx_poll_msdyn_ocsessions](adx_poll.md#BKMK_adx_poll_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_msdyn_ocsessions"></a> adx_polloption_msdyn_ocsessions

One-To-Many Relationship: [adx_polloption adx_polloption_msdyn_ocsessions](adx_polloption.md#BKMK_adx_polloption_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_msdyn_ocsessions"></a> adx_pollplacement_msdyn_ocsessions

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_msdyn_ocsessions](adx_pollplacement.md#BKMK_adx_pollplacement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_msdyn_ocsessions"></a> adx_pollsubmission_msdyn_ocsessions

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_msdyn_ocsessions](adx_pollsubmission.md#BKMK_adx_pollsubmission_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_msdyn_ocsessions"></a> adx_publishingstatetransitionrule_msdyn_ocsessions

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_msdyn_ocsessions](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_msdyn_ocsessions"></a> adx_redirect_msdyn_ocsessions

One-To-Many Relationship: [adx_redirect adx_redirect_msdyn_ocsessions](adx_redirect.md#BKMK_adx_redirect_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_msdyn_ocsessions"></a> adx_shortcut_msdyn_ocsessions

One-To-Many Relationship: [adx_shortcut adx_shortcut_msdyn_ocsessions](adx_shortcut.md#BKMK_adx_shortcut_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_msdyn_ocsessions"></a> adx_webpage_msdyn_ocsessions

One-To-Many Relationship: [adx_webpage adx_webpage_msdyn_ocsessions](adx_webpage.md#BKMK_adx_webpage_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_msdyn_ocsessions"></a> adx_website_msdyn_ocsessions

One-To-Many Relationship: [adx_website adx_website_msdyn_ocsessions](adx_website.md#BKMK_adx_website_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebooking_msdyn_ocsessions"></a> bookableresourcebooking_msdyn_ocsessions

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_msdyn_ocsessions](bookableresourcebooking.md#BKMK_bookableresourcebooking_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_msdyn_ocsessions"></a> bookableresourcebookingheader_msdyn_ocsessions

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_msdyn_ocsessions](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_msdyn_ocsessions"></a> bulkoperation_msdyn_ocsessions

One-To-Many Relationship: [bulkoperation bulkoperation_msdyn_ocsessions](bulkoperation.md#BKMK_bulkoperation_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaign_msdyn_ocsessions"></a> campaign_msdyn_ocsessions

One-To-Many Relationship: [campaign campaign_msdyn_ocsessions](campaign.md#BKMK_campaign_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_msdyn_ocsessions"></a> campaignactivity_msdyn_ocsessions

One-To-Many Relationship: [campaignactivity campaignactivity_msdyn_ocsessions](campaignactivity.md#BKMK_campaignactivity_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contact_msdyn_ocsessions"></a> contact_msdyn_ocsessions

One-To-Many Relationship: [contact contact_msdyn_ocsessions](contact.md#BKMK_contact_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contact_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contract_msdyn_ocsessions"></a> contract_msdyn_ocsessions

One-To-Many Relationship: [contract contract_msdyn_ocsessions](contract.md#BKMK_contract_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_msdyn_ocsessions"></a> entitlement_msdyn_ocsessions

One-To-Many Relationship: [entitlement entitlement_msdyn_ocsessions](entitlement.md#BKMK_entitlement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_msdyn_ocsessions"></a> entitlementtemplate_msdyn_ocsessions

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_msdyn_ocsessions](entitlementtemplate.md#BKMK_entitlementtemplate_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_msdyn_ocsessions"></a> incident_msdyn_ocsessions

One-To-Many Relationship: [incident incident_msdyn_ocsessions](incident.md#BKMK_incident_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_interactionforemail_msdyn_ocsessions"></a> interactionforemail_msdyn_ocsessions

One-To-Many Relationship: [interactionforemail interactionforemail_msdyn_ocsessions](interactionforemail.md#BKMK_interactionforemail_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`interactionforemail`|
|ReferencedAttribute|`interactionforemailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_new_interactionforemail_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_invoice_msdyn_ocsessions"></a> invoice_msdyn_ocsessions

One-To-Many Relationship: [invoice invoice_msdyn_ocsessions](invoice.md#BKMK_invoice_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgearticle_msdyn_ocsessions"></a> knowledgearticle_msdyn_ocsessions

One-To-Many Relationship: [knowledgearticle knowledgearticle_msdyn_ocsessions](knowledgearticle.md#BKMK_knowledgearticle_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgearticle`|
|ReferencedAttribute|`knowledgearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgearticle_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgebaserecord_msdyn_ocsessions"></a> knowledgebaserecord_msdyn_ocsessions

One-To-Many Relationship: [knowledgebaserecord knowledgebaserecord_msdyn_ocsessions](knowledgebaserecord.md#BKMK_knowledgebaserecord_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgebaserecord`|
|ReferencedAttribute|`knowledgebaserecordid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgebaserecord_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_msdyn_ocsessions"></a> lead_msdyn_ocsessions

One-To-Many Relationship: [lead lead_msdyn_ocsessions](lead.md#BKMK_lead_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreement_msdyn_ocsessions"></a> msdyn_agreement_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_msdyn_ocsessions](msdyn_agreement.md#BKMK_msdyn_agreement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_msdyn_ocsessions"></a> msdyn_agreementbookingdate_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_msdyn_ocsessions](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_msdyn_ocsessions"></a> msdyn_agreementbookingincident_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_msdyn_ocsessions](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_msdyn_ocsessions"></a> msdyn_agreementbookingproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_msdyn_ocsessions](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_ocsessions"></a> msdyn_agreementbookingservice_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_msdyn_ocsessions](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_msdyn_ocsessions"></a> msdyn_agreementbookingservicetask_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_msdyn_ocsessions](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_ocsessions"></a> msdyn_agreementbookingsetup_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_msdyn_ocsessions](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_msdyn_ocsessions"></a> msdyn_agreementinvoicedate_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_msdyn_ocsessions](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_msdyn_ocsessions"></a> msdyn_agreementinvoiceproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_msdyn_ocsessions](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_ocsessions"></a> msdyn_agreementinvoicesetup_msdyn_ocsessions

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_msdyn_ocsessions](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_ocsessions"></a> msdyn_bookingalertstatus_msdyn_ocsessions

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msdyn_ocsessions](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msdyn_ocsessions"></a> msdyn_bookingrule_msdyn_ocsessions

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msdyn_ocsessions](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_ocsessions"></a> msdyn_bookingtimestamp_msdyn_ocsessions

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_msdyn_ocsessions](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_msdyn_ocsessions"></a> msdyn_customerasset_msdyn_ocsessions

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_msdyn_ocsessions](msdyn_customerasset.md#BKMK_msdyn_customerasset_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_msdyn_ocsessions"></a> msdyn_fieldservicesetting_msdyn_ocsessions

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_msdyn_ocsessions](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_msdyn_ocsessions"></a> msdyn_incidenttypecharacteristic_msdyn_ocsessions

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_msdyn_ocsessions](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_ocsessions"></a> msdyn_incidenttypeproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_msdyn_ocsessions](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_ocsessions"></a> msdyn_incidenttypeservice_msdyn_ocsessions

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_msdyn_ocsessions](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_ocsessions"></a> msdyn_inventoryadjustment_msdyn_ocsessions

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_msdyn_ocsessions](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocsessions"></a> msdyn_inventoryadjustmentproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_msdyn_ocsessions](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_msdyn_ocsessions"></a> msdyn_inventoryjournal_msdyn_ocsessions

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_msdyn_ocsessions](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_msdyn_ocsessions"></a> msdyn_inventorytransfer_msdyn_ocsessions

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_msdyn_ocsessions](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkitemid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_channelinstance"></a> msdyn_msdyn_ocsession_msdyn_channelinstance

One-To-Many Relationship: [msdyn_channelinstance msdyn_msdyn_ocsession_msdyn_channelinstance](msdyn_channelinstance.md#BKMK_msdyn_msdyn_ocsession_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelinstance`|
|ReferencedAttribute|`msdyn_channelinstanceid`|
|ReferencingAttribute|`msdyn_channelinstanceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_channelinstanceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_ocsession_primarysession-many-to-one"></a> msdyn_msdyn_ocsession_msdyn_ocsession_primarysession

One-To-Many Relationship: [msdyn_ocsession msdyn_msdyn_ocsession_msdyn_ocsession_primarysession](#BKMK_msdyn_msdyn_ocsession_msdyn_ocsession_primarysession-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_primarysession`|
|ReferencingEntityNavigationPropertyName|`msdyn_primarysession_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_omnichannelqueue_msdyn_ocsession_queueid"></a> msdyn_msdyn_omnichannelqueue_msdyn_ocsession_queueid

One-To-Many Relationship: [msdyn_omnichannelqueue msdyn_msdyn_omnichannelqueue_msdyn_ocsession_queueid](msdyn_omnichannelqueue.md#BKMK_msdyn_msdyn_omnichannelqueue_msdyn_ocsession_queueid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_omnichannelqueue`|
|ReferencedAttribute|`msdyn_omnichannelqueueid`|
|ReferencingAttribute|`msdyn_queueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_queueid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_businessunit_owningbusinessunit"></a> msdyn_ocsession_businessunit_owningbusinessunit

One-To-Many Relationship: [businessunit msdyn_ocsession_businessunit_owningbusinessunit](businessunit.md#BKMK_msdyn_ocsession_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_mailbox_sendermailboxid"></a> msdyn_ocsession_mailbox_sendermailboxid

One-To-Many Relationship: [mailbox msdyn_ocsession_mailbox_sendermailboxid](mailbox.md#BKMK_msdyn_ocsession_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencedEntity|`mailbox`|
|ReferencedAttribute|`mailboxid`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencingEntityNavigationPropertyName|`sendermailboxid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_owner_ownerid"></a> msdyn_ocsession_owner_ownerid

One-To-Many Relationship: [owner msdyn_ocsession_owner_ownerid](owner.md#BKMK_msdyn_ocsession_owner_ownerid)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_service_serviceid"></a> msdyn_ocsession_service_serviceid

One-To-Many Relationship: [service msdyn_ocsession_service_serviceid](service.md#BKMK_msdyn_ocsession_service_serviceid)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_sla_slaid"></a> msdyn_ocsession_sla_slaid

One-To-Many Relationship: [sla msdyn_ocsession_sla_slaid](sla.md#BKMK_msdyn_ocsession_sla_slaid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_activitypointer_sla_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_sla_slainvokedid"></a> msdyn_ocsession_sla_slainvokedid

One-To-Many Relationship: [sla msdyn_ocsession_sla_slainvokedid](sla.md#BKMK_msdyn_ocsession_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_activitypointer_sla_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_systemuser_createdby"></a> msdyn_ocsession_systemuser_createdby

One-To-Many Relationship: [systemuser msdyn_ocsession_systemuser_createdby](systemuser.md#BKMK_msdyn_ocsession_systemuser_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_systemuser_createdonbehalfby"></a> msdyn_ocsession_systemuser_createdonbehalfby

One-To-Many Relationship: [systemuser msdyn_ocsession_systemuser_createdonbehalfby](systemuser.md#BKMK_msdyn_ocsession_systemuser_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_systemuser_modifiedby"></a> msdyn_ocsession_systemuser_modifiedby

One-To-Many Relationship: [systemuser msdyn_ocsession_systemuser_modifiedby](systemuser.md#BKMK_msdyn_ocsession_systemuser_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_systemuser_modifiedonbehalfby"></a> msdyn_ocsession_systemuser_modifiedonbehalfby

One-To-Many Relationship: [systemuser msdyn_ocsession_systemuser_modifiedonbehalfby](systemuser.md#BKMK_msdyn_ocsession_systemuser_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_systemuser_owninguser"></a> msdyn_ocsession_systemuser_owninguser

One-To-Many Relationship: [systemuser msdyn_ocsession_systemuser_owninguser](systemuser.md#BKMK_msdyn_ocsession_systemuser_owninguser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_team_owningteam"></a> msdyn_ocsession_team_owningteam

One-To-Many Relationship: [team msdyn_ocsession_team_owningteam](team.md#BKMK_msdyn_ocsession_team_owningteam)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_transactioncurrency_transactioncurrencyid"></a> msdyn_ocsession_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency msdyn_ocsession_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_msdyn_ocsession_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_msdyn_ocsessions"></a> msdyn_payment_msdyn_ocsessions

One-To-Many Relationship: [msdyn_payment msdyn_payment_msdyn_ocsessions](msdyn_payment.md#BKMK_msdyn_payment_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_msdyn_ocsessions"></a> msdyn_paymentdetail_msdyn_ocsessions

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_msdyn_ocsessions](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_msdyn_ocsessions"></a> msdyn_paymentmethod_msdyn_ocsessions

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_msdyn_ocsessions](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_msdyn_ocsessions"></a> msdyn_paymentterm_msdyn_ocsessions

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_msdyn_ocsessions](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_msdyn_ocsessions"></a> msdyn_playbookinstance_msdyn_ocsessions

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_msdyn_ocsessions](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_msdyn_ocsessions"></a> msdyn_postalbum_msdyn_ocsessions

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_msdyn_ocsessions](msdyn_postalbum.md#BKMK_msdyn_postalbum_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_msdyn_ocsessions"></a> msdyn_postalcode_msdyn_ocsessions

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_msdyn_ocsessions](msdyn_postalcode.md#BKMK_msdyn_postalcode_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_msdyn_ocsessions"></a> msdyn_productinventory_msdyn_ocsessions

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_msdyn_ocsessions](msdyn_productinventory.md#BKMK_msdyn_productinventory_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_msdyn_ocsessions"></a> msdyn_purchaseorder_msdyn_ocsessions

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_msdyn_ocsessions](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_msdyn_ocsessions"></a> msdyn_purchaseorderbill_msdyn_ocsessions

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_msdyn_ocsessions](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_msdyn_ocsessions"></a> msdyn_purchaseorderproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_msdyn_ocsessions](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_ocsessions"></a> msdyn_purchaseorderreceipt_msdyn_ocsessions

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_msdyn_ocsessions](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocsessions"></a> msdyn_purchaseorderreceiptproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_msdyn_ocsessions](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_ocsessions"></a> msdyn_purchaseordersubstatus_msdyn_ocsessions

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_msdyn_ocsessions](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_queue_msdyn_ocsession_queueid"></a> msdyn_queue_msdyn_ocsession_queueid

One-To-Many Relationship: [queue msdyn_queue_msdyn_ocsession_queueid](queue.md#BKMK_msdyn_queue_msdyn_ocsession_queueid)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_cdsqueueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_cdsqueueid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_msdyn_ocsessions"></a> msdyn_quotebookingincident_msdyn_ocsessions

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_msdyn_ocsessions](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_ocsessions"></a> msdyn_quotebookingproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_msdyn_ocsessions](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_msdyn_ocsessions"></a> msdyn_quotebookingservice_msdyn_ocsessions

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_msdyn_ocsessions](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_ocsessions"></a> msdyn_quotebookingservicetask_msdyn_ocsessions

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_msdyn_ocsessions](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_msdyn_ocsessions"></a> msdyn_resourceterritory_msdyn_ocsessions

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msdyn_ocsessions](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_msdyn_ocsessions"></a> msdyn_rma_msdyn_ocsessions

One-To-Many Relationship: [msdyn_rma msdyn_rma_msdyn_ocsessions](msdyn_rma.md#BKMK_msdyn_rma_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_msdyn_ocsessions"></a> msdyn_rmaproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_msdyn_ocsessions](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_msdyn_ocsessions"></a> msdyn_rmareceipt_msdyn_ocsessions

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_msdyn_ocsessions](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_ocsessions"></a> msdyn_rmareceiptproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_msdyn_ocsessions](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_msdyn_ocsessions"></a> msdyn_rmasubstatus_msdyn_ocsessions

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_msdyn_ocsessions](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_msdyn_ocsessions"></a> msdyn_rtv_msdyn_ocsessions

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_msdyn_ocsessions](msdyn_rtv.md#BKMK_msdyn_rtv_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_msdyn_ocsessions"></a> msdyn_rtvproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_msdyn_ocsessions](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_ocsessions"></a> msdyn_rtvsubstatus_msdyn_ocsessions

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_msdyn_ocsessions](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_msdyn_ocsessions"></a> msdyn_salessuggestion_msdyn_ocsessions

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_msdyn_ocsessions](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_msdyn_ocsessions"></a> msdyn_shipvia_msdyn_ocsessions

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_msdyn_ocsessions](msdyn_shipvia.md#BKMK_msdyn_shipvia_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_msdyn_ocsessions"></a> msdyn_swarm_msdyn_ocsessions

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_msdyn_ocsessions](msdyn_swarm.md#BKMK_msdyn_swarm_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_ocsessions"></a> msdyn_systemuserschedulersetting_msdyn_ocsessions

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msdyn_ocsessions](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msdyn_ocsessions"></a> msdyn_timegroup_msdyn_ocsessions

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msdyn_ocsessions](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_ocsessions"></a> msdyn_timegroupdetail_msdyn_ocsessions

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msdyn_ocsessions](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_msdyn_ocsessions"></a> msdyn_timeoffrequest_msdyn_ocsessions

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_msdyn_ocsessions](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_msdyn_ocsessions"></a> msdyn_warehouse_msdyn_ocsessions

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_msdyn_ocsessions](msdyn_warehouse.md#BKMK_msdyn_warehouse_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_msdyn_ocsessions"></a> msdyn_workorder_msdyn_ocsessions

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_msdyn_ocsessions](msdyn_workorder.md#BKMK_msdyn_workorder_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_msdyn_ocsessions"></a> msdyn_workordercharacteristic_msdyn_ocsessions

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_msdyn_ocsessions](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_msdyn_ocsessions"></a> msdyn_workorderincident_msdyn_ocsessions

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_msdyn_ocsessions](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_msdyn_ocsessions"></a> msdyn_workorderproduct_msdyn_ocsessions

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_msdyn_ocsessions](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_ocsessions"></a> msdyn_workorderresourcerestriction_msdyn_ocsessions

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_msdyn_ocsessions](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_msdyn_ocsessions"></a> msdyn_workorderservice_msdyn_ocsessions

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_msdyn_ocsessions](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_msdyn_ocsessions"></a> msdyn_workorderservicetask_msdyn_ocsessions

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_msdyn_ocsessions](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_msdyn_ocsessions"></a> msdyncrm_contentsettings_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_msdyn_ocsessions](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_msdyn_ocsessions"></a> msdyncrm_customerjourney_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_msdyn_ocsessions](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_msdyn_ocsessions"></a> msdyncrm_leadscoremodel_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_msdyn_ocsessions](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_msdyn_ocsessions"></a> msdyncrm_linkedinaccount_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_msdyn_ocsessions](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_msdyn_ocsessions"></a> msdyncrm_linkedinactivity_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_msdyn_ocsessions](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocsessions"></a> msdyncrm_linkedinfieldmapping_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_msdyn_ocsessions](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_msdyn_ocsessions"></a> msdyncrm_linkedinform_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_msdyn_ocsessions](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_msdyn_ocsessions"></a> msdyncrm_linkedinformanswer_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_msdyn_ocsessions](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_msdyn_ocsessions"></a> msdyncrm_linkedinformquestion_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_msdyn_ocsessions](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msdyn_ocsessions"></a> msdyncrm_linkedinformsubmission_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_msdyn_ocsessions](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocsessions"></a> msdyncrm_linkedinleadmatchingstrategy_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_msdyn_ocsessions](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_msdyn_ocsessions"></a> msdyncrm_linkedinuserprofile_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_msdyn_ocsessions](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions"></a> msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocsessions"></a> msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocsessions](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msdyn_ocsessions"></a> msdyncrm_marketingemailtestsend_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_msdyn_ocsessions](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_msdyn_ocsessions"></a> msdyncrm_migration_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_msdyn_ocsessions](msdyncrm_migration.md#BKMK_msdyncrm_migration_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_uicconfig_msdyn_ocsessions"></a> msdyncrm_uicconfig_msdyn_ocsessions

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_msdyn_ocsessions](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_checkin_msdyn_ocsessions"></a> msevtmgt_checkin_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_msdyn_ocsessions](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_msdyn_ocsessions"></a> msevtmgt_event_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_msdyn_ocsessions](msevtmgt_event.md#BKMK_msevtmgt_event_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_msdyn_ocsessions"></a> msevtmgt_eventpurchase_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_msdyn_ocsessions](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocsessions"></a> msevtmgt_eventpurchaseattendee_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_msdyn_ocsessions](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msdyn_ocsessions"></a> msevtmgt_eventpurchasepass_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_msdyn_ocsessions](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_msdyn_ocsessions"></a> msevtmgt_eventregistration_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_msdyn_ocsessions](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_msdyn_ocsessions"></a> msevtmgt_hotel_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_msdyn_ocsessions](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msdyn_ocsessions"></a> msevtmgt_hotelroomallocation_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_msdyn_ocsessions](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_msdyn_ocsessions"></a> msevtmgt_hotelroomreservation_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_msdyn_ocsessions](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_msdyn_ocsessions"></a> msevtmgt_layout_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_msdyn_ocsessions](msevtmgt_layout.md#BKMK_msevtmgt_layout_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_msdyn_ocsessions"></a> msevtmgt_room_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_msdyn_ocsessions](msevtmgt_room.md#BKMK_msevtmgt_room_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_msdyn_ocsessions"></a> msevtmgt_session_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_msdyn_ocsessions](msevtmgt_session.md#BKMK_msevtmgt_session_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_msdyn_ocsessions"></a> msevtmgt_sessionregistration_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_msdyn_ocsessions](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_msdyn_ocsessions"></a> msevtmgt_sessiontrack_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_msdyn_ocsessions](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_msdyn_ocsessions"></a> msevtmgt_speaker_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_msdyn_ocsessions](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_msdyn_ocsessions"></a> msevtmgt_speakerengagement_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_msdyn_ocsessions](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msdyn_ocsessions"></a> msevtmgt_sponsorablearticle_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_msdyn_ocsessions](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_msdyn_ocsessions"></a> msevtmgt_sponsorship_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_msdyn_ocsessions](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_msdyn_ocsessions"></a> msevtmgt_venue_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_msdyn_ocsessions](msevtmgt_venue.md#BKMK_msevtmgt_venue_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msdyn_ocsessions"></a> msevtmgt_webinarconfiguration_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_msdyn_ocsessions](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_msdyn_ocsessions"></a> msevtmgt_webinarprovider_msdyn_ocsessions

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_msdyn_ocsessions](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_adplacement_msdyn_ocsessions"></a> mspp_adplacement_msdyn_ocsessions

One-To-Many Relationship: [mspp_adplacement mspp_adplacement_msdyn_ocsessions](mspp_adplacement.md#BKMK_mspp_adplacement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_adplacement`|
|ReferencedAttribute|`mspp_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_adplacement_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_pollplacement_msdyn_ocsessions"></a> mspp_pollplacement_msdyn_ocsessions

One-To-Many Relationship: [mspp_pollplacement mspp_pollplacement_msdyn_ocsessions](mspp_pollplacement.md#BKMK_mspp_pollplacement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_pollplacement`|
|ReferencedAttribute|`mspp_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_pollplacement_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_publishingstatetransitionrule_msdyn_ocsessions"></a> mspp_publishingstatetransitionrule_msdyn_ocsessions

One-To-Many Relationship: [mspp_publishingstatetransitionrule mspp_publishingstatetransitionrule_msdyn_ocsessions](mspp_publishingstatetransitionrule.md#BKMK_mspp_publishingstatetransitionrule_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_publishingstatetransitionrule`|
|ReferencedAttribute|`mspp_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_publishingstatetransitionrule_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_redirect_msdyn_ocsessions"></a> mspp_redirect_msdyn_ocsessions

One-To-Many Relationship: [mspp_redirect mspp_redirect_msdyn_ocsessions](mspp_redirect.md#BKMK_mspp_redirect_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_redirect`|
|ReferencedAttribute|`mspp_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_redirect_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_shortcut_msdyn_ocsessions"></a> mspp_shortcut_msdyn_ocsessions

One-To-Many Relationship: [mspp_shortcut mspp_shortcut_msdyn_ocsessions](mspp_shortcut.md#BKMK_mspp_shortcut_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_shortcut`|
|ReferencedAttribute|`mspp_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_shortcut_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_website_msdyn_ocsessions"></a> mspp_website_msdyn_ocsessions

One-To-Many Relationship: [mspp_website mspp_website_msdyn_ocsessions](mspp_website.md#BKMK_mspp_website_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_website`|
|ReferencedAttribute|`mspp_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_website_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_msdyn_ocsessions"></a> opportunity_msdyn_ocsessions

One-To-Many Relationship: [opportunity opportunity_msdyn_ocsessions](opportunity.md#BKMK_opportunity_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_quote_msdyn_ocsessions"></a> quote_msdyn_ocsessions

One-To-Many Relationship: [quote quote_msdyn_ocsessions](quote.md#BKMK_quote_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_salesorder_msdyn_ocsessions"></a> salesorder_msdyn_ocsessions

One-To-Many Relationship: [salesorder salesorder_msdyn_ocsessions](salesorder.md#BKMK_salesorder_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_site_msdyn_ocsessions"></a> site_msdyn_ocsessions

One-To-Many Relationship: [site site_msdyn_ocsessions](site.md#BKMK_site_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [CampaignResponse_msdyn_ocsessions](#BKMK_CampaignResponse_msdyn_ocsessions)
- [msdyn_msdyn_botsession_sessionid_msdyn_oc](#BKMK_msdyn_msdyn_botsession_sessionid_msdyn_oc)
- [msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid](#BKMK_msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid)
- [msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid](#BKMK_msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid)
- [msdyn_msdyn_ocsession_msdyn_ocsession_primarysession](#BKMK_msdyn_msdyn_ocsession_msdyn_ocsession_primarysession-one-to-many)
- [msdyn_msdyn_ocsession_msdyn_ocsessionparticipantevent_sessionid](#BKMK_msdyn_msdyn_ocsession_msdyn_ocsessionparticipantevent_sessionid)
- [msdyn_msdyn_ocsession_msdyn_ocsessionsentiment_omnichannelsession](#BKMK_msdyn_msdyn_ocsession_msdyn_ocsessionsentiment_omnichannelsession)
- [msdyn_ocsession_ActionCards](#BKMK_msdyn_ocsession_ActionCards)
- [msdyn_ocsession_activity_parties](#BKMK_msdyn_ocsession_activity_parties)
- [msdyn_ocsession_Annotations](#BKMK_msdyn_ocsession_Annotations)
- [msdyn_ocsession_AsyncOperations](#BKMK_msdyn_ocsession_AsyncOperations)
- [msdyn_ocsession_BulkDeleteFailures](#BKMK_msdyn_ocsession_BulkDeleteFailures)
- [msdyn_ocsession_connections1](#BKMK_msdyn_ocsession_connections1)
- [msdyn_ocsession_connections2](#BKMK_msdyn_ocsession_connections2)
- [msdyn_ocsession_DuplicateBaseRecord](#BKMK_msdyn_ocsession_DuplicateBaseRecord)
- [msdyn_ocsession_DuplicateMatchingRecord](#BKMK_msdyn_ocsession_DuplicateMatchingRecord)
- [msdyn_ocsession_Feedback](#BKMK_msdyn_ocsession_Feedback)
- [msdyn_ocsession_MailboxTrackingFolders](#BKMK_msdyn_ocsession_MailboxTrackingFolders)
- [msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid](#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid)
- [msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid](#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid)
- [msdyn_ocsession_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocsession_PrincipalObjectAttributeAccesses)
- [msdyn_ocsession_ProcessSession](#BKMK_msdyn_ocsession_ProcessSession)
- [msdyn_ocsession_QueueItems](#BKMK_msdyn_ocsession_QueueItems)
- [msdyn_ocsession_sessioncharacteristic_nested](#BKMK_msdyn_ocsession_sessioncharacteristic_nested)
- [msdyn_ocsession_sessionevent_nested](#BKMK_msdyn_ocsession_sessionevent_nested)
- [msdyn_ocsession_sessionparticipant_nested](#BKMK_msdyn_ocsession_sessionparticipant_nested)
- [msdyn_ocsession_SyncErrors](#BKMK_msdyn_ocsession_SyncErrors)

### <a name="BKMK_CampaignResponse_msdyn_ocsessions"></a> CampaignResponse_msdyn_ocsessions

Many-To-One Relationship: [campaignresponse CampaignResponse_msdyn_ocsessions](campaignresponse.md#BKMK_CampaignResponse_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_botsession_sessionid_msdyn_oc"></a> msdyn_msdyn_botsession_sessionid_msdyn_oc

Many-To-One Relationship: [msdyn_botsession msdyn_msdyn_botsession_sessionid_msdyn_oc](msdyn_botsession.md#BKMK_msdyn_msdyn_botsession_sessionid_msdyn_oc)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_botsession`|
|ReferencingAttribute|`msdyn_sessionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_botsession_sessionid_msdyn_oc`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid"></a> msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid

Many-To-One Relationship: [msdyn_agentcapacityupdatehistory msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid](msdyn_agentcapacityupdatehistory.md#BKMK_msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentcapacityupdatehistory`|
|ReferencingAttribute|`msdyn_sessionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid"></a> msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_lastsessionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_ocsession_primarysession-one-to-many"></a> msdyn_msdyn_ocsession_msdyn_ocsession_primarysession

Many-To-One Relationship: [msdyn_ocsession msdyn_msdyn_ocsession_msdyn_ocsession_primarysession](#BKMK_msdyn_msdyn_ocsession_msdyn_ocsession_primarysession-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`msdyn_primarysession`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsession_msdyn_ocsession_primarysession`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_ocsessionparticipantevent_sessionid"></a> msdyn_msdyn_ocsession_msdyn_ocsessionparticipantevent_sessionid

Many-To-One Relationship: [msdyn_ocsessionparticipantevent msdyn_msdyn_ocsession_msdyn_ocsessionparticipantevent_sessionid](msdyn_ocsessionparticipantevent.md#BKMK_msdyn_msdyn_ocsession_msdyn_ocsessionparticipantevent_sessionid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessionparticipantevent`|
|ReferencingAttribute|`msdyn_sessionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsession_msdyn_ocsessionparticipantevent_sessionid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_ocsessionsentiment_omnichannelsession"></a> msdyn_msdyn_ocsession_msdyn_ocsessionsentiment_omnichannelsession

Many-To-One Relationship: [msdyn_ocsessionsentiment msdyn_msdyn_ocsession_msdyn_ocsessionsentiment_omnichannelsession](msdyn_ocsessionsentiment.md#BKMK_msdyn_msdyn_ocsession_msdyn_ocsessionsentiment_omnichannelsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessionsentiment`|
|ReferencingAttribute|`msdyn_omnichannelsession`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsession_msdyn_ocsessionsentiment_omnichannelsession`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_ActionCards"></a> msdyn_ocsession_ActionCards

Many-To-One Relationship: [actioncard msdyn_ocsession_ActionCards](actioncard.md#BKMK_msdyn_ocsession_ActionCards)

|Property|Value|
|---|---|
|ReferencingEntity|`actioncard`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_ActionCards`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_activity_parties"></a> msdyn_ocsession_activity_parties

Many-To-One Relationship: [activityparty msdyn_ocsession_activity_parties](activityparty.md#BKMK_msdyn_ocsession_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_activity_parties`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_Annotations"></a> msdyn_ocsession_Annotations

Many-To-One Relationship: [annotation msdyn_ocsession_Annotations](annotation.md#BKMK_msdyn_ocsession_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_AsyncOperations"></a> msdyn_ocsession_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocsession_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocsession_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_BulkDeleteFailures"></a> msdyn_ocsession_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocsession_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocsession_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_connections1"></a> msdyn_ocsession_connections1

Many-To-One Relationship: [connection msdyn_ocsession_connections1](connection.md#BKMK_msdyn_ocsession_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_connections2"></a> msdyn_ocsession_connections2

Many-To-One Relationship: [connection msdyn_ocsession_connections2](connection.md#BKMK_msdyn_ocsession_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_DuplicateBaseRecord"></a> msdyn_ocsession_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsession_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocsession_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_DuplicateMatchingRecord"></a> msdyn_ocsession_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsession_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocsession_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_Feedback"></a> msdyn_ocsession_Feedback

Many-To-One Relationship: [feedback msdyn_ocsession_Feedback](feedback.md#BKMK_msdyn_ocsession_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_MailboxTrackingFolders"></a> msdyn_ocsession_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocsession_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocsession_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid"></a> msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid

Many-To-One Relationship: [msdyn_conversationmessageblock msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid](msdyn_conversationmessageblock.md#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationmessageblock`|
|ReferencingAttribute|`msdyn_agentresponsesessionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid"></a> msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid

Many-To-One Relationship: [msdyn_conversationmessageblock msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid](msdyn_conversationmessageblock.md#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationmessageblock`|
|ReferencingAttribute|`msdyn_customermessagesessionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_PrincipalObjectAttributeAccesses"></a> msdyn_ocsession_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocsession_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocsession_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_ProcessSession"></a> msdyn_ocsession_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocsession_ProcessSession](processsession.md#BKMK_msdyn_ocsession_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_QueueItems"></a> msdyn_ocsession_QueueItems

Many-To-One Relationship: [queueitem msdyn_ocsession_QueueItems](queueitem.md#BKMK_msdyn_ocsession_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_sessioncharacteristic_nested"></a> msdyn_ocsession_sessioncharacteristic_nested

Many-To-One Relationship: [msdyn_ocsessioncharacteristic msdyn_ocsession_sessioncharacteristic_nested](msdyn_ocsessioncharacteristic.md#BKMK_msdyn_ocsession_sessioncharacteristic_nested)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessioncharacteristic`|
|ReferencingAttribute|`msdyn_ocsession`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_sessioncharacteristic_nested`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_sessionevent_nested"></a> msdyn_ocsession_sessionevent_nested

Many-To-One Relationship: [msdyn_sessionevent msdyn_ocsession_sessionevent_nested](msdyn_sessionevent.md#BKMK_msdyn_ocsession_sessionevent_nested)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionevent`|
|ReferencingAttribute|`msdyn_omnichannelsession`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_sessionevent_nested`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_sessionparticipant_nested"></a> msdyn_ocsession_sessionparticipant_nested

Many-To-One Relationship: [msdyn_sessionparticipant msdyn_ocsession_sessionparticipant_nested](msdyn_sessionparticipant.md#BKMK_msdyn_ocsession_sessionparticipant_nested)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipant`|
|ReferencingAttribute|`msdyn_omnichannelsession`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_sessionparticipant_nested`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_SyncErrors"></a> msdyn_ocsession_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocsession_SyncErrors](syncerror.md#BKMK_msdyn_ocsession_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

