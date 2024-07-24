---
title: "Conversation (msdyn_ocliveworkitem) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Conversation (msdyn_ocliveworkitem) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Conversation (msdyn_ocliveworkitem) table/entity reference

Tracks the interaction between the agents and customer

## Messages

The following table lists the messages for the Conversation (msdyn_ocliveworkitem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocliveworkitems(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `CCaaS_AcceptCall`<br />Event: False |**CCaaS_AcceptCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_AcceptPhoneCall`<br />Event: False |**CCaaS_AcceptPhoneCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_BargeInToCall`<br />Event: False |**CCaaS_BargeInToCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_CloseExternalSession`<br />Event: False |**CCaaS_CloseExternalSession action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_EndCall`<br />Event: False |**CCaaS_EndCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_EndPhoneCall`<br />Event: False |**CCaaS_EndPhoneCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_ExternalCallReject`<br />Event: False |**CCaaS_ExternalCallReject action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_ExternalCallTransfer`<br />Event: False |**CCaaS_ExternalCallTransfer action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_GetCallState`<br />Event: False |**CCaaS_GetCallState action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_HoldCall`<br />Event: False |**CCaaS_HoldCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_InitiateExternalTransfer`<br />Event: False |**CCaaS_InitiateExternalTransfer action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_PauseRecordingAndTranscription`<br />Event: False |**CCaaS_PauseRecordingAndTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_RejectExternalTransfer`<br />Event: False |**CCaaS_RejectExternalTransfer action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_ResumeRecordingAndTranscription`<br />Event: False |**CCaaS_ResumeRecordingAndTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_StartRecordingAndTranscription`<br />Event: False |**CCaaS_StartRecordingAndTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_StartTranscription`<br />Event: False |**CCaaS_StartTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_StopTranscription`<br />Event: False |**CCaaS_StopTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_UnholdCall`<br />Event: False |**CCaaS_UnholdCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocliveworkitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocliveworkitems(*activityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocliveworkitems(*activityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocliveworkitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocliveworkitems(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocliveworkitems(*activityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocliveworkitems(*activityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Conversation (msdyn_ocliveworkitem) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Conversation (msdyn_ocliveworkitem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Conversation** |
| **DisplayCollectionName** | **Conversations** |
| **SchemaName** | `msdyn_ocliveworkitem` |
| **CollectionSchemaName** | `msdyn_ocliveworkitems` |
| **EntitySetName** | `msdyn_ocliveworkitems`|
| **LogicalName** | `msdyn_ocliveworkitem` |
| **LogicalCollectionName** | `msdyn_ocliveworkitems` |
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
- [msdyn_activeagentassignedon](#BKMK_msdyn_activeagentassignedon)
- [msdyn_activeagentid](#BKMK_msdyn_activeagentid)
- [msdyn_activesessionparticipantid](#BKMK_msdyn_activesessionparticipantid)
- [msdyn_averageresponsetimeinmsadjforoh](#BKMK_msdyn_averageresponsetimeinmsadjforoh)
- [msdyn_cdsqueueid](#BKMK_msdyn_cdsqueueid)
- [msdyn_channel](#BKMK_msdyn_channel)
- [msdyn_channelinstanceid](#BKMK_msdyn_channelinstanceid)
- [msdyn_channelproviderName](#BKMK_msdyn_channelproviderName)
- [msdyn_closedon](#BKMK_msdyn_closedon)
- [msdyn_conversationfirstwaittimeinseconds](#BKMK_msdyn_conversationfirstwaittimeinseconds)
- [msdyn_conversationhandletimeinseconds](#BKMK_msdyn_conversationhandletimeinseconds)
- [msdyn_conversationholdtimeinseconds](#BKMK_msdyn_conversationholdtimeinseconds)
- [msdyn_ConversationSummaryField](#BKMK_msdyn_ConversationSummaryField)
- [msdyn_conversationtalktimeinseconds](#BKMK_msdyn_conversationtalktimeinseconds)
- [msdyn_conversationwrapuptimeinseconds](#BKMK_msdyn_conversationwrapuptimeinseconds)
- [msdyn_copilotengaged](#BKMK_msdyn_copilotengaged)
- [msdyn_createdon](#BKMK_msdyn_createdon)
- [msdyn_customer](#BKMK_msdyn_customer)
- [msdyn_customerIdType](#BKMK_msdyn_customerIdType)
- [msdyn_customerlanguageid](#BKMK_msdyn_customerlanguageid)
- [msdyn_customerlocale](#BKMK_msdyn_customerlocale)
- [msdyn_customersentimentlabel](#BKMK_msdyn_customersentimentlabel)
- [msdyn_dailytopicid](#BKMK_msdyn_dailytopicid)
- [msdyn_effortpredictionresult](#BKMK_msdyn_effortpredictionresult)
- [msdyn_escalationcount](#BKMK_msdyn_escalationcount)
- [msdyn_externalcontext](#BKMK_msdyn_externalcontext)
- [msdyn_firstresponsetimeinmsadjforoh](#BKMK_msdyn_firstresponsetimeinmsadjforoh)
- [msdyn_firstwaitstartedon](#BKMK_msdyn_firstwaitstartedon)
- [msdyn_initiatedon](#BKMK_msdyn_initiatedon)
- [msdyn_intent](#BKMK_msdyn_intent)
- [msdyn_isabandoned](#BKMK_msdyn_isabandoned)
- [msdyn_isagentaccepted](#BKMK_msdyn_isagentaccepted)
- [msdyn_isagentsession](#BKMK_msdyn_isagentsession)
- [msdyn_isoutbound](#BKMK_msdyn_isoutbound)
- [msdyn_IssueId](#BKMK_msdyn_IssueId)
- [msdyn_lastsessionid](#BKMK_msdyn_lastsessionid)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_liveworkstreamnotificationdata](#BKMK_msdyn_liveworkstreamnotificationdata)
- [msdyn_modifiedon](#BKMK_msdyn_modifiedon)
- [msdyn_ocliveworkitemid](#BKMK_msdyn_ocliveworkitemid)
- [msdyn_overflowtransfercount](#BKMK_msdyn_overflowtransfercount)
- [msdyn_queueid](#BKMK_msdyn_queueid)
- [msdyn_queueitemid](#BKMK_msdyn_queueitemid)
- [msdyn_routableobjectid](#BKMK_msdyn_routableobjectid)
- [msdyn_routableobjectidIdType](#BKMK_msdyn_routableobjectidIdType)
- [msdyn_routableobjectlogicalname](#BKMK_msdyn_routableobjectlogicalname)
- [msdyn_socialprofileid](#BKMK_msdyn_socialprofileid)
- [msdyn_startedon](#BKMK_msdyn_startedon)
- [msdyn_statereason](#BKMK_msdyn_statereason)
- [msdyn_statuschangereason](#BKMK_msdyn_statuschangereason)
- [msdyn_statusupdatedon](#BKMK_msdyn_statusupdatedon)
- [msdyn_thirdpartyconversation](#BKMK_msdyn_thirdpartyconversation)
- [msdyn_TimelineControlField](#BKMK_msdyn_TimelineControlField)
- [msdyn_title](#BKMK_msdyn_title)
- [msdyn_TranscriptControl](#BKMK_msdyn_TranscriptControl)
- [msdyn_transfercount](#BKMK_msdyn_transfercount)
- [msdyn_urcustomersentimentkeywords](#BKMK_msdyn_urcustomersentimentkeywords)
- [msdyn_urcustomersentimentlabel](#BKMK_msdyn_urcustomersentimentlabel)
- [msdyn_urcustomersentimentscore](#BKMK_msdyn_urcustomersentimentscore)
- [msdyn_workstreamworkdistributionmode](#BKMK_msdyn_workstreamworkdistributionmode)
- [msdyn_wrapupinitiatedon](#BKMK_msdyn_wrapupinitiatedon)
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
|GlobalChoiceName|`msdyn_ocliveworkitem_isbilled`|
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
|GlobalChoiceName|`msdyn_ocliveworkitem_ismapiprivate`|
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
|GlobalChoiceName|`msdyn_ocliveworkitem_isworkflowcreated`|
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
|GlobalChoiceName|`msdyn_ocliveworkitem_leftvoicemail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_activeagentassignedon"></a> msdyn_activeagentassignedon

|Property|Value|
|---|---|
|Description|**Date and time when last agent was assigned to the conversation**|
|DisplayName|**Active Agent Assigned On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activeagentassignedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_activeagentid"></a> msdyn_activeagentid

|Property|Value|
|---|---|
|Description|**Indicates the agent currently assigned to the conversation or last assigned agent for a closed conversation. It is populated as empty or null if the customer(C2) ends or is disconnected before the agent accepts conversation.**|
|DisplayName|**Active Agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activeagentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_activesessionparticipantid"></a> msdyn_activesessionparticipantid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Active session participant**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activesessionparticipantid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_sessionparticipant|

### <a name="BKMK_msdyn_averageresponsetimeinmsadjforoh"></a> msdyn_averageresponsetimeinmsadjforoh

|Property|Value|
|---|---|
|Description|**Average time it took to respond to customer, excluding agent's out of operating hours (OOOH)**|
|DisplayName|**Conversation average response time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_averageresponsetimeinmsadjforoh`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_cdsqueueid"></a> msdyn_cdsqueueid

|Property|Value|
|---|---|
|Description|**Unique identifier for Queue associated with Conversation.**|
|DisplayName|**Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cdsqueueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queue|

### <a name="BKMK_msdyn_channel"></a> msdyn_channel

|Property|Value|
|---|---|
|Description|**The channel(s) in the conversation.**|
|DisplayName|**Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channel`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
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

### <a name="BKMK_msdyn_channelproviderName"></a> msdyn_channelproviderName

|Property|Value|
|---|---|
|Description|**Channel Provider Name.**|
|DisplayName|**Channel Provider Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channelproviderName`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_closedon"></a> msdyn_closedon

|Property|Value|
|---|---|
|Description|**Date and time when conversation was closed**|
|DisplayName|**Closed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_closedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_conversationfirstwaittimeinseconds"></a> msdyn_conversationfirstwaittimeinseconds

|Property|Value|
|---|---|
|Description|**Time in seconds conversation spend to be accepted**|
|DisplayName|**Conversation First Wait Time In Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationfirstwaittimeinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_conversationhandletimeinseconds"></a> msdyn_conversationhandletimeinseconds

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conversation Handle Time In Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationhandletimeinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_conversationholdtimeinseconds"></a> msdyn_conversationholdtimeinseconds

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conversation Hold Time In Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationholdtimeinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_ConversationSummaryField"></a> msdyn_ConversationSummaryField

|Property|Value|
|---|---|
|Description|**Field to bind conversation summary control**|
|DisplayName|**Conversation summary field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationsummaryfield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_conversationtalktimeinseconds"></a> msdyn_conversationtalktimeinseconds

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conversation Talk Time In Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationtalktimeinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_conversationwrapuptimeinseconds"></a> msdyn_conversationwrapuptimeinseconds

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conversation Wrap Up Time In Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationwrapuptimeinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_copilotengaged"></a> msdyn_copilotengaged

|Property|Value|
|---|---|
|Description||
|DisplayName|**Copilot Engaged**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_copilotengaged`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocliveworkitem_msdyn_copilotengaged`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_createdon"></a> msdyn_createdon

|Property|Value|
|---|---|
|Description|**Date and time when the activity was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_customer"></a> msdyn_customer

|Property|Value|
|---|---|
|Description|**Customer with which the activity is associated.**|
|DisplayName|**Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customer`|
|RequiredLevel|None|
|Type|Customer|
|Targets|account, contact|

### <a name="BKMK_msdyn_customerIdType"></a> msdyn_customerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_customeridtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_customerlanguageid"></a> msdyn_customerlanguageid

|Property|Value|
|---|---|
|Description|**The language of the customer in this conversation.**|
|DisplayName|**Customer Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerlanguageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_oclanguage|

### <a name="BKMK_msdyn_customerlocale"></a> msdyn_customerlocale

|Property|Value|
|---|---|
|Description|**The locale of the customer participated in this conversation.**|
|DisplayName|**Customer Locale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerlocale`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_customersentimentlabel"></a> msdyn_customersentimentlabel

|Property|Value|
|---|---|
|Description|**Customer Sentiment Label powered by Sentiment Service**|
|DisplayName|**Customer Sentiment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customersentimentlabel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocliveworkitem_msdyn_customersentimentlabel`|

#### msdyn_customersentimentlabel Choices/Options

|Value|Label|
|---|---|
|0|**N/A**|
|7|**Very negative**|
|8|**Negative**|
|9|**Slightly negative**|
|10|**Neutral**|
|11|**Slightly positive**|
|12|**Positive**|
|13|**Very positive**|

### <a name="BKMK_msdyn_dailytopicid"></a> msdyn_dailytopicid

|Property|Value|
|---|---|
|Description|**Look up to daily topic entity.**|
|DisplayName|**TopicID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dailytopicid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocsentimentdailytopic|

### <a name="BKMK_msdyn_effortpredictionresult"></a> msdyn_effortpredictionresult

|Property|Value|
|---|---|
|Description||
|DisplayName|**Effort prediction result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_effortpredictionresult`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_effortpredictionresult|

### <a name="BKMK_msdyn_escalationcount"></a> msdyn_escalationcount

|Property|Value|
|---|---|
|Description|**Number of times conversation was escalated to Supervisor i.e. transferred to Supervisor**|
|DisplayName|**Escalation Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_escalationcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_externalcontext"></a> msdyn_externalcontext

|Property|Value|
|---|---|
|Description|**External context captured.**|
|DisplayName|**External context**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_externalcontext`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocexternalcontext|

### <a name="BKMK_msdyn_firstresponsetimeinmsadjforoh"></a> msdyn_firstresponsetimeinmsadjforoh

|Property|Value|
|---|---|
|Description|**Time it took to respond to customer, excluding agent's out of operating hours (OOOH)**|
|DisplayName|**Conversation first response time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firstresponsetimeinmsadjforoh`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_firstwaitstartedon"></a> msdyn_firstwaitstartedon

|Property|Value|
|---|---|
|Description|**Time when conversation started waiting to be assigned**|
|DisplayName|**First Wait Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firstwaitstartedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_initiatedon"></a> msdyn_initiatedon

|Property|Value|
|---|---|
|Description|**Time when conversation was initiated**|
|DisplayName|**Initiated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_initiatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_intent"></a> msdyn_intent

|Property|Value|
|---|---|
|Description|**Intent  of Conversation**|
|DisplayName|**Intent  of Conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intent`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_isabandoned"></a> msdyn_isabandoned

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Abandoned**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isabandoned`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocliveworkitem_msdyn_isabandoned`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isagentaccepted"></a> msdyn_isagentaccepted

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Agent Accepted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isagentaccepted`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocliveworkitem_msdyn_isagentaccepted`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isagentsession"></a> msdyn_isagentsession

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Agent Session**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isagentsession`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocliveworkitem_msdyn_isagentsession`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isoutbound"></a> msdyn_isoutbound

|Property|Value|
|---|---|
|Description|**Indicates if its an outbound Conversation**|
|DisplayName|**Outbound Conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isoutbound`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocliveworkitem_msdyn_isoutbound`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IssueId"></a> msdyn_IssueId

|Property|Value|
|---|---|
|Description|**Unique identifier for Case associated with Conversation.**|
|DisplayName|**Issue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_msdyn_lastsessionid"></a> msdyn_lastsessionid

|Property|Value|
|---|---|
|Description|**Last agent session**|
|DisplayName|**Last Session**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastsessionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocsession|

### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|---|---|
|Description|**Work stream associated to the conversation**|
|DisplayName|**Work stream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkstreamid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

### <a name="BKMK_msdyn_liveworkstreamnotificationdata"></a> msdyn_liveworkstreamnotificationdata

|Property|Value|
|---|---|
|Description|**LiveWorkStream notification data provided as JSON. For internal use only.**|
|DisplayName|**LiveWorkStream Notification Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkstreamnotificationdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8192|

### <a name="BKMK_msdyn_modifiedon"></a> msdyn_modifiedon

|Property|Value|
|---|---|
|Description|**Date and time when conversation was last modified**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ocliveworkitemid"></a> msdyn_ocliveworkitemid

|Property|Value|
|---|---|
|Description|**Unique Id of conversation**|
|DisplayName|**ConversationId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocliveworkitemid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_overflowtransfercount"></a> msdyn_overflowtransfercount

|Property|Value|
|---|---|
|Description|**Number of times work item got transferred to another queue due to overflow**|
|DisplayName|**Overflow Transfer Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_overflowtransfercount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_queueid"></a> msdyn_queueid

|Property|Value|
|---|---|
|Description|**Unique identifier for msdyn_omnichannelqueue associated with Conversation**|
|DisplayName|**Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_omnichannelqueue|

### <a name="BKMK_msdyn_queueitemid"></a> msdyn_queueitemid

|Property|Value|
|---|---|
|Description|**Queue item associated with the conversation**|
|DisplayName|**Queue item**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queueitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queueitem|

### <a name="BKMK_msdyn_routableobjectid"></a> msdyn_routableobjectid

|Property|Value|
|---|---|
|Description|**Unique identifier of the routed record. Records are of those entities enabled for Unified Routing and have at least one Workstream created. For internal use only.**|
|DisplayName|**Routed record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routableobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocvoicemail, task|

### <a name="BKMK_msdyn_routableobjectidIdType"></a> msdyn_routableobjectidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_routableobjectididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_routableobjectlogicalname"></a> msdyn_routableobjectlogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record routing routable object type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routableobjectlogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_socialprofileid"></a> msdyn_socialprofileid

|Property|Value|
|---|---|
|Description|**Lookup for the Social Profile Entity Record.**|
|DisplayName|**Social Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_socialprofileid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|socialprofile|

### <a name="BKMK_msdyn_startedon"></a> msdyn_startedon

|Property|Value|
|---|---|
|Description|**Date and time when conversation was started**|
|DisplayName|**Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_statereason"></a> msdyn_statereason

|Property|Value|
|---|---|
|Description|**Reason for conversation for being in the current state**|
|DisplayName|**State Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statereason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_statuschangereason"></a> msdyn_statuschangereason

|Property|Value|
|---|---|
|Description|**Reason for conversation status change**|
|DisplayName|**Status change reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statuschangereason`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocliveworkitem_msdyn_statuschangereason`|

#### msdyn_statuschangereason Choices/Options

|Value|Label|
|---|---|
|192350001|**AwaitingAgentAssignment**|
|192350002|**AwaitingAgentAcceptance**|
|192350003|**InConversation**|
|192350004|**AwaitingCustomerResponse**|
|192350005|**AgentMovedToWrapUp**|
|192350006|**CustomerDisconnectedOrLeftActiveConversation**|
|192350007|**CutomerMovedToWrapUp**|
|192350008|**ConversationEndedByAgent**|
|192350009|**AutoClosedFromWaitingState**|
|192350010|**AutoClosedBySystem**|
|192350011|**ClosedDueToOverflow**|
|192350012|**CustomerDisconnectedOrLeftOpenConversation**|
|192350013|**ConversationEndedByBot**|
|192350014|**ClosedDueToFailure**|
|192350015|**ForceClosedBySupervisor**|
|192350016|**ClosedInDataverseDirectlyByAdmin**|
|192350017|**AssignedBySupervisor**|

### <a name="BKMK_msdyn_statusupdatedon"></a> msdyn_statusupdatedon

|Property|Value|
|---|---|
|Description|**Date and time when conversation status was last modified**|
|DisplayName|**Status Updated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statusupdatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_thirdpartyconversation"></a> msdyn_thirdpartyconversation

|Property|Value|
|---|---|
|Description|**Third Party Conversation**|
|DisplayName|**Third Party Conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_thirdpartyconversation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocliverworkitem_msdyn_thirdpartyconversation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_TimelineControlField"></a> msdyn_TimelineControlField

|Property|Value|
|---|---|
|Description|**Field to bind Timelinewall control**|
|DisplayName|**Timeline Control Field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timelinecontrolfield`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_title"></a> msdyn_title

|Property|Value|
|---|---|
|Description|**Conversation Title**|
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_title`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_TranscriptControl"></a> msdyn_TranscriptControl

|Property|Value|
|---|---|
|Description|**Placeholder for Transcript Control**|
|DisplayName|**Chat Transcript**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transcriptcontrol`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_transfercount"></a> msdyn_transfercount

|Property|Value|
|---|---|
|Description|**Number of times the conversation was transferred**|
|DisplayName|**Transfer Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transfercount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_urcustomersentimentkeywords"></a> msdyn_urcustomersentimentkeywords

|Property|Value|
|---|---|
|Description|**UR Customer Sentiment Keywords**|
|DisplayName|**UR Customer Sentiment Keywords**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_urcustomersentimentkeywords`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_urcustomersentimentlabel"></a> msdyn_urcustomersentimentlabel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sentiment Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_urcustomersentimentlabel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocliveworkitem_msdyn_urcustomersentimentlabel`|

#### msdyn_urcustomersentimentlabel Choices/Options

|Value|Label|
|---|---|
|0|**N/A**|
|7|**Very negative**|
|8|**Negative**|
|9|**Slightly negative**|
|10|**Neutral**|
|11|**Slightly positive**|
|12|**Positive**|
|13|**Very positive**|

### <a name="BKMK_msdyn_urcustomersentimentscore"></a> msdyn_urcustomersentimentscore

|Property|Value|
|---|---|
|Description|**UR Customer Sentiment Score**|
|DisplayName|**UR Customer Sentiment Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_urcustomersentimentscore`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyn_workstreamworkdistributionmode"></a> msdyn_workstreamworkdistributionmode

|Property|Value|
|---|---|
|Description|**Work distribution mode of the associated work stream**|
|DisplayName|**Work distribution mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workstreamworkdistributionmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_workdistributionmode`|

#### msdyn_workstreamworkdistributionmode Choices/Options

|Value|Label|
|---|---|
|192350000|**Push**|
|192350001|**Pick**|

### <a name="BKMK_msdyn_wrapupinitiatedon"></a> msdyn_wrapupinitiatedon

|Property|Value|
|---|---|
|Description|**Date and time when conversation end**|
|DisplayName|**Wrap-up Status Intiated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wrapupinitiatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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
|GlobalChoiceName|`msdyn_ocliveworkitem_prioritycode`|

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
|Description|**State of the conversation record**|
|DisplayName|**State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_ocliveworkitem_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Closed**<br />DefaultStatus: 4<br />InvariantName: `Closed`|
|2|Label: **Resolved**<br />DefaultStatus: 6<br />InvariantName: `Resolved`|
|3|Label: **Scheduled**<br />DefaultStatus: 7<br />InvariantName: `Scheduled`|
|4|Label: **Wrap-up (Deprecated)**<br />DefaultStatus: 5<br />InvariantName: `Wrap-up (Deprecated)`|

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
|GlobalChoiceName|`msdyn_ocliveworkitem_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Open**<br />State:0<br />TransitionData: None|
|2|Label: **Active**<br />State:0<br />TransitionData: None|
|3|Label: **Waiting**<br />State:0<br />TransitionData: None|
|4|Label: **Closed**<br />State:1<br />TransitionData: None|
|5|Label: **Wrap-up**<br />State:0<br />TransitionData: None|
|6|Label: **Resolved**<br />State:2<br />TransitionData: None|
|7|Label: **Scheduled**<br />State:3<br />TransitionData: None|

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
- [msdyn_customerName](#BKMK_msdyn_customerName)
- [msdyn_customerYomiName](#BKMK_msdyn_customerYomiName)
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
|GlobalChoiceName|`msdyn_ocliveworkitem_instancetypecode`|

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

### <a name="BKMK_msdyn_customerName"></a> msdyn_customerName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_customername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_customerYomiName"></a> msdyn_customerYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_customeryominame`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

- [account_msdyn_ocliveworkitems](#BKMK_account_msdyn_ocliveworkitems)
- [activity_pointer_msdyn_ocliveworkitem](#BKMK_activity_pointer_msdyn_ocliveworkitem)
- [adx_ad_msdyn_ocliveworkitems](#BKMK_adx_ad_msdyn_ocliveworkitems)
- [adx_adplacement_msdyn_ocliveworkitems](#BKMK_adx_adplacement_msdyn_ocliveworkitems)
- [adx_casedeflection_msdyn_ocliveworkitems](#BKMK_adx_casedeflection_msdyn_ocliveworkitems)
- [adx_communityforumaccesspermission_msdyn_ocliveworkitems](#BKMK_adx_communityforumaccesspermission_msdyn_ocliveworkitems)
- [adx_communityforumalert_msdyn_ocliveworkitems](#BKMK_adx_communityforumalert_msdyn_ocliveworkitems)
- [adx_contentaccesslevel_msdyn_ocliveworkitems](#BKMK_adx_contentaccesslevel_msdyn_ocliveworkitems)
- [adx_invitation_msdyn_ocliveworkitems](#BKMK_adx_invitation_msdyn_ocliveworkitems)
- [adx_poll_msdyn_ocliveworkitems](#BKMK_adx_poll_msdyn_ocliveworkitems)
- [adx_polloption_msdyn_ocliveworkitems](#BKMK_adx_polloption_msdyn_ocliveworkitems)
- [adx_pollplacement_msdyn_ocliveworkitems](#BKMK_adx_pollplacement_msdyn_ocliveworkitems)
- [adx_pollsubmission_msdyn_ocliveworkitems](#BKMK_adx_pollsubmission_msdyn_ocliveworkitems)
- [adx_publishingstatetransitionrule_msdyn_ocliveworkitems](#BKMK_adx_publishingstatetransitionrule_msdyn_ocliveworkitems)
- [adx_redirect_msdyn_ocliveworkitems](#BKMK_adx_redirect_msdyn_ocliveworkitems)
- [adx_shortcut_msdyn_ocliveworkitems](#BKMK_adx_shortcut_msdyn_ocliveworkitems)
- [adx_webpage_msdyn_ocliveworkitems](#BKMK_adx_webpage_msdyn_ocliveworkitems)
- [adx_website_msdyn_ocliveworkitems](#BKMK_adx_website_msdyn_ocliveworkitems)
- [bookableresourcebooking_msdyn_ocliveworkitems](#BKMK_bookableresourcebooking_msdyn_ocliveworkitems)
- [bookableresourcebookingheader_msdyn_ocliveworkitems](#BKMK_bookableresourcebookingheader_msdyn_ocliveworkitems)
- [bulkoperation_msdyn_ocliveworkitems](#BKMK_bulkoperation_msdyn_ocliveworkitems)
- [campaign_msdyn_ocliveworkitems](#BKMK_campaign_msdyn_ocliveworkitems)
- [campaignactivity_msdyn_ocliveworkitems](#BKMK_campaignactivity_msdyn_ocliveworkitems)
- [contact_msdyn_ocliveworkitems](#BKMK_contact_msdyn_ocliveworkitems)
- [contract_msdyn_ocliveworkitems](#BKMK_contract_msdyn_ocliveworkitems)
- [entitlement_msdyn_ocliveworkitems](#BKMK_entitlement_msdyn_ocliveworkitems)
- [entitlementtemplate_msdyn_ocliveworkitems](#BKMK_entitlementtemplate_msdyn_ocliveworkitems)
- [incident_msdyn_ocliveworkitems](#BKMK_incident_msdyn_ocliveworkitems)
- [interactionforemail_msdyn_ocliveworkitems](#BKMK_interactionforemail_msdyn_ocliveworkitems)
- [invoice_msdyn_ocliveworkitems](#BKMK_invoice_msdyn_ocliveworkitems)
- [knowledgearticle_msdyn_ocliveworkitems](#BKMK_knowledgearticle_msdyn_ocliveworkitems)
- [knowledgebaserecord_msdyn_ocliveworkitems](#BKMK_knowledgebaserecord_msdyn_ocliveworkitems)
- [lead_msdyn_ocliveworkitems](#BKMK_lead_msdyn_ocliveworkitems)
- [msdyn_account_msdyn_ocliveworkitem_Customer](#BKMK_msdyn_account_msdyn_ocliveworkitem_Customer)
- [msdyn_agreement_msdyn_ocliveworkitems](#BKMK_msdyn_agreement_msdyn_ocliveworkitems)
- [msdyn_agreementbookingdate_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingdate_msdyn_ocliveworkitems)
- [msdyn_agreementbookingincident_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingincident_msdyn_ocliveworkitems)
- [msdyn_agreementbookingproduct_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingproduct_msdyn_ocliveworkitems)
- [msdyn_agreementbookingservice_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingservice_msdyn_ocliveworkitems)
- [msdyn_agreementbookingservicetask_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingservicetask_msdyn_ocliveworkitems)
- [msdyn_agreementbookingsetup_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingsetup_msdyn_ocliveworkitems)
- [msdyn_agreementinvoicedate_msdyn_ocliveworkitems](#BKMK_msdyn_agreementinvoicedate_msdyn_ocliveworkitems)
- [msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems](#BKMK_msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems)
- [msdyn_agreementinvoicesetup_msdyn_ocliveworkitems](#BKMK_msdyn_agreementinvoicesetup_msdyn_ocliveworkitems)
- [msdyn_bookingalertstatus_msdyn_ocliveworkitems](#BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems)
- [msdyn_bookingrule_msdyn_ocliveworkitems](#BKMK_msdyn_bookingrule_msdyn_ocliveworkitems)
- [msdyn_bookingtimestamp_msdyn_ocliveworkitems](#BKMK_msdyn_bookingtimestamp_msdyn_ocliveworkitems)
- [msdyn_contact_msdyn_ocliveworkitem_Customer](#BKMK_msdyn_contact_msdyn_ocliveworkitem_Customer)
- [msdyn_customerasset_msdyn_ocliveworkitems](#BKMK_msdyn_customerasset_msdyn_ocliveworkitems)
- [msdyn_fieldservicesetting_msdyn_ocliveworkitems](#BKMK_msdyn_fieldservicesetting_msdyn_ocliveworkitems)
- [msdyn_incident_msdyn_ocliveworkitem](#BKMK_msdyn_incident_msdyn_ocliveworkitem)
- [msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems](#BKMK_msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems)
- [msdyn_incidenttypeproduct_msdyn_ocliveworkitems](#BKMK_msdyn_incidenttypeproduct_msdyn_ocliveworkitems)
- [msdyn_incidenttypeservice_msdyn_ocliveworkitems](#BKMK_msdyn_incidenttypeservice_msdyn_ocliveworkitems)
- [msdyn_inventoryadjustment_msdyn_ocliveworkitems](#BKMK_msdyn_inventoryadjustment_msdyn_ocliveworkitems)
- [msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems](#BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems)
- [msdyn_inventoryjournal_msdyn_ocliveworkitems](#BKMK_msdyn_inventoryjournal_msdyn_ocliveworkitems)
- [msdyn_inventorytransfer_msdyn_ocliveworkitems](#BKMK_msdyn_inventorytransfer_msdyn_ocliveworkitems)
- [msdyn_msdyn_effortpredictionresult_msdyn_ocliveworkitem_effortpredictionresult](#BKMK_msdyn_msdyn_effortpredictionresult_msdyn_ocliveworkitem_effortpredictionresult)
- [msdyn_msdyn_liveworkitem_msdyn_channelinstance](#BKMK_msdyn_msdyn_liveworkitem_msdyn_channelinstance)
- [msdyn_msdyn_liveworkstream_msdyn_ocliveworkitem_liveworkstreamid](#BKMK_msdyn_msdyn_liveworkstream_msdyn_ocliveworkitem_liveworkstreamid)
- [msdyn_msdyn_oclanguage_msdyn_ocliveworkitem_customerlanguageid](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocliveworkitem_customerlanguageid)
- [msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid](#BKMK_msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid)
- [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid](#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid)
- [msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid](#BKMK_msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid)
- [msdyn_msdyn_omnichannelqueue_msdyn_ocliveworkitem_queueid](#BKMK_msdyn_msdyn_omnichannelqueue_msdyn_ocliveworkitem_queueid)
- [msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid](#BKMK_msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid)
- [msdyn_ocliveworkitem_businessunit_owningbusinessunit](#BKMK_msdyn_ocliveworkitem_businessunit_owningbusinessunit)
- [msdyn_ocliveworkitem_mailbox_sendermailboxid](#BKMK_msdyn_ocliveworkitem_mailbox_sendermailboxid)
- [msdyn_ocliveworkitem_msdyn_externalcontext_msdyn_ocexternalcontextid](#BKMK_msdyn_ocliveworkitem_msdyn_externalcontext_msdyn_ocexternalcontextid)
- [msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid](#BKMK_msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid)
- [msdyn_ocliveworkitem_owner_ownerid](#BKMK_msdyn_ocliveworkitem_owner_ownerid)
- [msdyn_ocliveworkitem_service_serviceid](#BKMK_msdyn_ocliveworkitem_service_serviceid)
- [msdyn_ocliveworkitem_sla_slaid](#BKMK_msdyn_ocliveworkitem_sla_slaid)
- [msdyn_ocliveworkitem_sla_slainvokedid](#BKMK_msdyn_ocliveworkitem_sla_slainvokedid)
- [msdyn_ocliveworkitem_systemuser_createdby](#BKMK_msdyn_ocliveworkitem_systemuser_createdby)
- [msdyn_ocliveworkitem_systemuser_createdonbehalfby](#BKMK_msdyn_ocliveworkitem_systemuser_createdonbehalfby)
- [msdyn_ocliveworkitem_systemuser_modifiedby](#BKMK_msdyn_ocliveworkitem_systemuser_modifiedby)
- [msdyn_ocliveworkitem_systemuser_modifiedonbehalfby](#BKMK_msdyn_ocliveworkitem_systemuser_modifiedonbehalfby)
- [msdyn_ocliveworkitem_systemuser_owninguser](#BKMK_msdyn_ocliveworkitem_systemuser_owninguser)
- [msdyn_ocliveworkitem_team_owningteam](#BKMK_msdyn_ocliveworkitem_team_owningteam)
- [msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid)
- [msdyn_payment_msdyn_ocliveworkitems](#BKMK_msdyn_payment_msdyn_ocliveworkitems)
- [msdyn_paymentdetail_msdyn_ocliveworkitems](#BKMK_msdyn_paymentdetail_msdyn_ocliveworkitems)
- [msdyn_paymentmethod_msdyn_ocliveworkitems](#BKMK_msdyn_paymentmethod_msdyn_ocliveworkitems)
- [msdyn_paymentterm_msdyn_ocliveworkitems](#BKMK_msdyn_paymentterm_msdyn_ocliveworkitems)
- [msdyn_playbookinstance_msdyn_ocliveworkitems](#BKMK_msdyn_playbookinstance_msdyn_ocliveworkitems)
- [msdyn_postalbum_msdyn_ocliveworkitems](#BKMK_msdyn_postalbum_msdyn_ocliveworkitems)
- [msdyn_postalcode_msdyn_ocliveworkitems](#BKMK_msdyn_postalcode_msdyn_ocliveworkitems)
- [msdyn_productinventory_msdyn_ocliveworkitems](#BKMK_msdyn_productinventory_msdyn_ocliveworkitems)
- [msdyn_purchaseorder_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorder_msdyn_ocliveworkitems)
- [msdyn_purchaseorderbill_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorderbill_msdyn_ocliveworkitems)
- [msdyn_purchaseorderproduct_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorderproduct_msdyn_ocliveworkitems)
- [msdyn_purchaseorderreceipt_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorderreceipt_msdyn_ocliveworkitems)
- [msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems)
- [msdyn_purchaseordersubstatus_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseordersubstatus_msdyn_ocliveworkitems)
- [msdyn_queue_msdyn_ocliveworkitem_queueid](#BKMK_msdyn_queue_msdyn_ocliveworkitem_queueid)
- [msdyn_queueitem_msdyn_ocliveworkitem_queueitemid](#BKMK_msdyn_queueitem_msdyn_ocliveworkitem_queueitemid)
- [msdyn_quotebookingincident_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingincident_msdyn_ocliveworkitems)
- [msdyn_quotebookingproduct_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingproduct_msdyn_ocliveworkitems)
- [msdyn_quotebookingservice_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingservice_msdyn_ocliveworkitems)
- [msdyn_quotebookingservicetask_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingservicetask_msdyn_ocliveworkitems)
- [msdyn_resourceterritory_msdyn_ocliveworkitems](#BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems)
- [msdyn_rma_msdyn_ocliveworkitems](#BKMK_msdyn_rma_msdyn_ocliveworkitems)
- [msdyn_rmaproduct_msdyn_ocliveworkitems](#BKMK_msdyn_rmaproduct_msdyn_ocliveworkitems)
- [msdyn_rmareceipt_msdyn_ocliveworkitems](#BKMK_msdyn_rmareceipt_msdyn_ocliveworkitems)
- [msdyn_rmareceiptproduct_msdyn_ocliveworkitems](#BKMK_msdyn_rmareceiptproduct_msdyn_ocliveworkitems)
- [msdyn_rmasubstatus_msdyn_ocliveworkitems](#BKMK_msdyn_rmasubstatus_msdyn_ocliveworkitems)
- [msdyn_rtv_msdyn_ocliveworkitems](#BKMK_msdyn_rtv_msdyn_ocliveworkitems)
- [msdyn_rtvproduct_msdyn_ocliveworkitems](#BKMK_msdyn_rtvproduct_msdyn_ocliveworkitems)
- [msdyn_rtvsubstatus_msdyn_ocliveworkitems](#BKMK_msdyn_rtvsubstatus_msdyn_ocliveworkitems)
- [msdyn_salessuggestion_msdyn_ocliveworkitems](#BKMK_msdyn_salessuggestion_msdyn_ocliveworkitems)
- [msdyn_shipvia_msdyn_ocliveworkitems](#BKMK_msdyn_shipvia_msdyn_ocliveworkitems)
- [msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid](#BKMK_msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid)
- [msdyn_swarm_msdyn_ocliveworkitems](#BKMK_msdyn_swarm_msdyn_ocliveworkitems)
- [msdyn_systemuser_msdyn_ocliveworkitem_activeagentid](#BKMK_msdyn_systemuser_msdyn_ocliveworkitem_activeagentid)
- [msdyn_systemuserschedulersetting_msdyn_ocliveworkitems](#BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems)
- [msdyn_timegroup_msdyn_ocliveworkitems](#BKMK_msdyn_timegroup_msdyn_ocliveworkitems)
- [msdyn_timegroupdetail_msdyn_ocliveworkitems](#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)
- [msdyn_timeoffrequest_msdyn_ocliveworkitems](#BKMK_msdyn_timeoffrequest_msdyn_ocliveworkitems)
- [msdyn_warehouse_msdyn_ocliveworkitems](#BKMK_msdyn_warehouse_msdyn_ocliveworkitems)
- [msdyn_workorder_msdyn_ocliveworkitems](#BKMK_msdyn_workorder_msdyn_ocliveworkitems)
- [msdyn_workordercharacteristic_msdyn_ocliveworkitems](#BKMK_msdyn_workordercharacteristic_msdyn_ocliveworkitems)
- [msdyn_workorderincident_msdyn_ocliveworkitems](#BKMK_msdyn_workorderincident_msdyn_ocliveworkitems)
- [msdyn_workorderproduct_msdyn_ocliveworkitems](#BKMK_msdyn_workorderproduct_msdyn_ocliveworkitems)
- [msdyn_workorderresourcerestriction_msdyn_ocliveworkitems](#BKMK_msdyn_workorderresourcerestriction_msdyn_ocliveworkitems)
- [msdyn_workorderservice_msdyn_ocliveworkitems](#BKMK_msdyn_workorderservice_msdyn_ocliveworkitems)
- [msdyn_workorderservicetask_msdyn_ocliveworkitems](#BKMK_msdyn_workorderservicetask_msdyn_ocliveworkitems)
- [msdyncrm_contentsettings_msdyn_ocliveworkitems](#BKMK_msdyncrm_contentsettings_msdyn_ocliveworkitems)
- [msdyncrm_customerjourney_msdyn_ocliveworkitems](#BKMK_msdyncrm_customerjourney_msdyn_ocliveworkitems)
- [msdyncrm_leadscoremodel_msdyn_ocliveworkitems](#BKMK_msdyncrm_leadscoremodel_msdyn_ocliveworkitems)
- [msdyncrm_linkedinaccount_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinaccount_msdyn_ocliveworkitems)
- [msdyncrm_linkedinactivity_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinactivity_msdyn_ocliveworkitems)
- [msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems)
- [msdyncrm_linkedinform_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinform_msdyn_ocliveworkitems)
- [msdyncrm_linkedinformanswer_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinformanswer_msdyn_ocliveworkitems)
- [msdyncrm_linkedinformquestion_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinformquestion_msdyn_ocliveworkitems)
- [msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems)
- [msdyncrm_linkedinleadmatchingstrategy_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocliveworkitems)
- [msdyncrm_linkedinuserprofile_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinuserprofile_msdyn_ocliveworkitems)
- [msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems)
- [msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocliveworkitems](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocliveworkitems)
- [msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems](#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems)
- [msdyncrm_migration_msdyn_ocliveworkitems](#BKMK_msdyncrm_migration_msdyn_ocliveworkitems)
- [msdyncrm_uicconfig_msdyn_ocliveworkitems](#BKMK_msdyncrm_uicconfig_msdyn_ocliveworkitems)
- [msevtmgt_checkin_msdyn_ocliveworkitems](#BKMK_msevtmgt_checkin_msdyn_ocliveworkitems)
- [msevtmgt_event_msdyn_ocliveworkitems](#BKMK_msevtmgt_event_msdyn_ocliveworkitems)
- [msevtmgt_eventpurchase_msdyn_ocliveworkitems](#BKMK_msevtmgt_eventpurchase_msdyn_ocliveworkitems)
- [msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems](#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems)
- [msevtmgt_eventpurchasepass_msdyn_ocliveworkitems](#BKMK_msevtmgt_eventpurchasepass_msdyn_ocliveworkitems)
- [msevtmgt_eventregistration_msdyn_ocliveworkitems](#BKMK_msevtmgt_eventregistration_msdyn_ocliveworkitems)
- [msevtmgt_hotel_msdyn_ocliveworkitems](#BKMK_msevtmgt_hotel_msdyn_ocliveworkitems)
- [msevtmgt_hotelroomallocation_msdyn_ocliveworkitems](#BKMK_msevtmgt_hotelroomallocation_msdyn_ocliveworkitems)
- [msevtmgt_hotelroomreservation_msdyn_ocliveworkitems](#BKMK_msevtmgt_hotelroomreservation_msdyn_ocliveworkitems)
- [msevtmgt_layout_msdyn_ocliveworkitems](#BKMK_msevtmgt_layout_msdyn_ocliveworkitems)
- [msevtmgt_room_msdyn_ocliveworkitems](#BKMK_msevtmgt_room_msdyn_ocliveworkitems)
- [msevtmgt_session_msdyn_ocliveworkitems](#BKMK_msevtmgt_session_msdyn_ocliveworkitems)
- [msevtmgt_sessionregistration_msdyn_ocliveworkitems](#BKMK_msevtmgt_sessionregistration_msdyn_ocliveworkitems)
- [msevtmgt_sessiontrack_msdyn_ocliveworkitems](#BKMK_msevtmgt_sessiontrack_msdyn_ocliveworkitems)
- [msevtmgt_speaker_msdyn_ocliveworkitems](#BKMK_msevtmgt_speaker_msdyn_ocliveworkitems)
- [msevtmgt_speakerengagement_msdyn_ocliveworkitems](#BKMK_msevtmgt_speakerengagement_msdyn_ocliveworkitems)
- [msevtmgt_sponsorablearticle_msdyn_ocliveworkitems](#BKMK_msevtmgt_sponsorablearticle_msdyn_ocliveworkitems)
- [msevtmgt_sponsorship_msdyn_ocliveworkitems](#BKMK_msevtmgt_sponsorship_msdyn_ocliveworkitems)
- [msevtmgt_venue_msdyn_ocliveworkitems](#BKMK_msevtmgt_venue_msdyn_ocliveworkitems)
- [msevtmgt_webinarconfiguration_msdyn_ocliveworkitems](#BKMK_msevtmgt_webinarconfiguration_msdyn_ocliveworkitems)
- [msevtmgt_webinarprovider_msdyn_ocliveworkitems](#BKMK_msevtmgt_webinarprovider_msdyn_ocliveworkitems)
- [mspp_adplacement_msdyn_ocliveworkitems](#BKMK_mspp_adplacement_msdyn_ocliveworkitems)
- [mspp_pollplacement_msdyn_ocliveworkitems](#BKMK_mspp_pollplacement_msdyn_ocliveworkitems)
- [mspp_publishingstatetransitionrule_msdyn_ocliveworkitems](#BKMK_mspp_publishingstatetransitionrule_msdyn_ocliveworkitems)
- [mspp_redirect_msdyn_ocliveworkitems](#BKMK_mspp_redirect_msdyn_ocliveworkitems)
- [mspp_shortcut_msdyn_ocliveworkitems](#BKMK_mspp_shortcut_msdyn_ocliveworkitems)
- [mspp_website_msdyn_ocliveworkitems](#BKMK_mspp_website_msdyn_ocliveworkitems)
- [opportunity_msdyn_ocliveworkitems](#BKMK_opportunity_msdyn_ocliveworkitems)
- [quote_msdyn_ocliveworkitems](#BKMK_quote_msdyn_ocliveworkitems)
- [salesorder_msdyn_ocliveworkitems](#BKMK_salesorder_msdyn_ocliveworkitems)
- [site_msdyn_ocliveworkitems](#BKMK_site_msdyn_ocliveworkitems)

### <a name="BKMK_account_msdyn_ocliveworkitems"></a> account_msdyn_ocliveworkitems

One-To-Many Relationship: [account account_msdyn_ocliveworkitems](account.md#BKMK_account_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_account_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_activity_pointer_msdyn_ocliveworkitem"></a> activity_pointer_msdyn_ocliveworkitem

One-To-Many Relationship: [activitypointer activity_pointer_msdyn_ocliveworkitem](activitypointer.md#BKMK_activity_pointer_msdyn_ocliveworkitem)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_ad_msdyn_ocliveworkitems"></a> adx_ad_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_ad adx_ad_msdyn_ocliveworkitems](adx_ad.md#BKMK_adx_ad_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_msdyn_ocliveworkitems"></a> adx_adplacement_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_adplacement adx_adplacement_msdyn_ocliveworkitems](adx_adplacement.md#BKMK_adx_adplacement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_msdyn_ocliveworkitems"></a> adx_casedeflection_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_msdyn_ocliveworkitems](adx_casedeflection.md#BKMK_adx_casedeflection_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_msdyn_ocliveworkitems"></a> adx_communityforumaccesspermission_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_msdyn_ocliveworkitems](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumalert_msdyn_ocliveworkitems"></a> adx_communityforumalert_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_msdyn_ocliveworkitems](adx_communityforumalert.md#BKMK_adx_communityforumalert_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_msdyn_ocliveworkitems"></a> adx_contentaccesslevel_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_msdyn_ocliveworkitems](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_invitation_msdyn_ocliveworkitems"></a> adx_invitation_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_invitation adx_invitation_msdyn_ocliveworkitems](adx_invitation.md#BKMK_adx_invitation_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_invitation`|
|ReferencedAttribute|`adx_invitationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_invitation_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_poll_msdyn_ocliveworkitems"></a> adx_poll_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_poll adx_poll_msdyn_ocliveworkitems](adx_poll.md#BKMK_adx_poll_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_msdyn_ocliveworkitems"></a> adx_polloption_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_polloption adx_polloption_msdyn_ocliveworkitems](adx_polloption.md#BKMK_adx_polloption_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_msdyn_ocliveworkitems"></a> adx_pollplacement_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_msdyn_ocliveworkitems](adx_pollplacement.md#BKMK_adx_pollplacement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_msdyn_ocliveworkitems"></a> adx_pollsubmission_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_msdyn_ocliveworkitems](adx_pollsubmission.md#BKMK_adx_pollsubmission_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_msdyn_ocliveworkitems"></a> adx_publishingstatetransitionrule_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_msdyn_ocliveworkitems](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_msdyn_ocliveworkitems"></a> adx_redirect_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_redirect adx_redirect_msdyn_ocliveworkitems](adx_redirect.md#BKMK_adx_redirect_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_msdyn_ocliveworkitems"></a> adx_shortcut_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_shortcut adx_shortcut_msdyn_ocliveworkitems](adx_shortcut.md#BKMK_adx_shortcut_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_msdyn_ocliveworkitems"></a> adx_webpage_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_webpage adx_webpage_msdyn_ocliveworkitems](adx_webpage.md#BKMK_adx_webpage_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_msdyn_ocliveworkitems"></a> adx_website_msdyn_ocliveworkitems

One-To-Many Relationship: [adx_website adx_website_msdyn_ocliveworkitems](adx_website.md#BKMK_adx_website_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebooking_msdyn_ocliveworkitems"></a> bookableresourcebooking_msdyn_ocliveworkitems

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_msdyn_ocliveworkitems](bookableresourcebooking.md#BKMK_bookableresourcebooking_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_msdyn_ocliveworkitems"></a> bookableresourcebookingheader_msdyn_ocliveworkitems

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_msdyn_ocliveworkitems](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_msdyn_ocliveworkitems"></a> bulkoperation_msdyn_ocliveworkitems

One-To-Many Relationship: [bulkoperation bulkoperation_msdyn_ocliveworkitems](bulkoperation.md#BKMK_bulkoperation_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaign_msdyn_ocliveworkitems"></a> campaign_msdyn_ocliveworkitems

One-To-Many Relationship: [campaign campaign_msdyn_ocliveworkitems](campaign.md#BKMK_campaign_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_msdyn_ocliveworkitems"></a> campaignactivity_msdyn_ocliveworkitems

One-To-Many Relationship: [campaignactivity campaignactivity_msdyn_ocliveworkitems](campaignactivity.md#BKMK_campaignactivity_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contact_msdyn_ocliveworkitems"></a> contact_msdyn_ocliveworkitems

One-To-Many Relationship: [contact contact_msdyn_ocliveworkitems](contact.md#BKMK_contact_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contact_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contract_msdyn_ocliveworkitems"></a> contract_msdyn_ocliveworkitems

One-To-Many Relationship: [contract contract_msdyn_ocliveworkitems](contract.md#BKMK_contract_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_msdyn_ocliveworkitems"></a> entitlement_msdyn_ocliveworkitems

One-To-Many Relationship: [entitlement entitlement_msdyn_ocliveworkitems](entitlement.md#BKMK_entitlement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_msdyn_ocliveworkitems"></a> entitlementtemplate_msdyn_ocliveworkitems

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_msdyn_ocliveworkitems](entitlementtemplate.md#BKMK_entitlementtemplate_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_msdyn_ocliveworkitems"></a> incident_msdyn_ocliveworkitems

One-To-Many Relationship: [incident incident_msdyn_ocliveworkitems](incident.md#BKMK_incident_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_interactionforemail_msdyn_ocliveworkitems"></a> interactionforemail_msdyn_ocliveworkitems

One-To-Many Relationship: [interactionforemail interactionforemail_msdyn_ocliveworkitems](interactionforemail.md#BKMK_interactionforemail_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`interactionforemail`|
|ReferencedAttribute|`interactionforemailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_new_interactionforemail_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_invoice_msdyn_ocliveworkitems"></a> invoice_msdyn_ocliveworkitems

One-To-Many Relationship: [invoice invoice_msdyn_ocliveworkitems](invoice.md#BKMK_invoice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgearticle_msdyn_ocliveworkitems"></a> knowledgearticle_msdyn_ocliveworkitems

One-To-Many Relationship: [knowledgearticle knowledgearticle_msdyn_ocliveworkitems](knowledgearticle.md#BKMK_knowledgearticle_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgearticle`|
|ReferencedAttribute|`knowledgearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgearticle_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgebaserecord_msdyn_ocliveworkitems"></a> knowledgebaserecord_msdyn_ocliveworkitems

One-To-Many Relationship: [knowledgebaserecord knowledgebaserecord_msdyn_ocliveworkitems](knowledgebaserecord.md#BKMK_knowledgebaserecord_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgebaserecord`|
|ReferencedAttribute|`knowledgebaserecordid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgebaserecord_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_msdyn_ocliveworkitems"></a> lead_msdyn_ocliveworkitems

One-To-Many Relationship: [lead lead_msdyn_ocliveworkitems](lead.md#BKMK_lead_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_account_msdyn_ocliveworkitem_Customer"></a> msdyn_account_msdyn_ocliveworkitem_Customer

One-To-Many Relationship: [account msdyn_account_msdyn_ocliveworkitem_Customer](account.md#BKMK_msdyn_account_msdyn_ocliveworkitem_Customer)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_customer`|
|ReferencingEntityNavigationPropertyName|`msdyn_customer_msdyn_ocliveworkitem_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_msdyn_ocliveworkitems"></a> msdyn_agreement_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_msdyn_ocliveworkitems](msdyn_agreement.md#BKMK_msdyn_agreement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_msdyn_ocliveworkitems"></a> msdyn_agreementbookingdate_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_msdyn_ocliveworkitems](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_msdyn_ocliveworkitems"></a> msdyn_agreementbookingincident_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_msdyn_ocliveworkitems](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_msdyn_ocliveworkitems"></a> msdyn_agreementbookingproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_msdyn_ocliveworkitems](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_ocliveworkitems"></a> msdyn_agreementbookingservice_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_msdyn_ocliveworkitems](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_msdyn_ocliveworkitems"></a> msdyn_agreementbookingservicetask_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_msdyn_ocliveworkitems](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_ocliveworkitems"></a> msdyn_agreementbookingsetup_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_msdyn_ocliveworkitems](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_msdyn_ocliveworkitems"></a> msdyn_agreementinvoicedate_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_msdyn_ocliveworkitems](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems"></a> msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_ocliveworkitems"></a> msdyn_agreementinvoicesetup_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_msdyn_ocliveworkitems](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems"></a> msdyn_bookingalertstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msdyn_ocliveworkitems](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msdyn_ocliveworkitems"></a> msdyn_bookingrule_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msdyn_ocliveworkitems](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_ocliveworkitems"></a> msdyn_bookingtimestamp_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_msdyn_ocliveworkitems](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_contact_msdyn_ocliveworkitem_Customer"></a> msdyn_contact_msdyn_ocliveworkitem_Customer

One-To-Many Relationship: [contact msdyn_contact_msdyn_ocliveworkitem_Customer](contact.md#BKMK_msdyn_contact_msdyn_ocliveworkitem_Customer)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_customer`|
|ReferencingEntityNavigationPropertyName|`msdyn_customer_msdyn_ocliveworkitem_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerasset_msdyn_ocliveworkitems"></a> msdyn_customerasset_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_msdyn_ocliveworkitems](msdyn_customerasset.md#BKMK_msdyn_customerasset_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_msdyn_ocliveworkitems"></a> msdyn_fieldservicesetting_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_msdyn_ocliveworkitems](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incident_msdyn_ocliveworkitem"></a> msdyn_incident_msdyn_ocliveworkitem

One-To-Many Relationship: [incident msdyn_incident_msdyn_ocliveworkitem](incident.md#BKMK_msdyn_incident_msdyn_ocliveworkitem)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_issueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_IssueId_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems"></a> msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_ocliveworkitems"></a> msdyn_incidenttypeproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_msdyn_ocliveworkitems](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_ocliveworkitems"></a> msdyn_incidenttypeservice_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_msdyn_ocliveworkitems](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_ocliveworkitems"></a> msdyn_inventoryadjustment_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_msdyn_ocliveworkitems](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems"></a> msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_msdyn_ocliveworkitems"></a> msdyn_inventoryjournal_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_msdyn_ocliveworkitems](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_msdyn_ocliveworkitems"></a> msdyn_inventorytransfer_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_msdyn_ocliveworkitems](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_effortpredictionresult_msdyn_ocliveworkitem_effortpredictionresult"></a> msdyn_msdyn_effortpredictionresult_msdyn_ocliveworkitem_effortpredictionresult

One-To-Many Relationship: [msdyn_effortpredictionresult msdyn_msdyn_effortpredictionresult_msdyn_ocliveworkitem_effortpredictionresult](msdyn_effortpredictionresult.md#BKMK_msdyn_msdyn_effortpredictionresult_msdyn_ocliveworkitem_effortpredictionresult)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_effortpredictionresult`|
|ReferencedAttribute|`msdyn_effortpredictionresultid`|
|ReferencingAttribute|`msdyn_effortpredictionresult`|
|ReferencingEntityNavigationPropertyName|`msdyn_effortpredictionresult_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_liveworkitem_msdyn_channelinstance"></a> msdyn_msdyn_liveworkitem_msdyn_channelinstance

One-To-Many Relationship: [msdyn_channelinstance msdyn_msdyn_liveworkitem_msdyn_channelinstance](msdyn_channelinstance.md#BKMK_msdyn_msdyn_liveworkitem_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelinstance`|
|ReferencedAttribute|`msdyn_channelinstanceid`|
|ReferencingAttribute|`msdyn_channelinstanceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_channelinstanceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_liveworkstream_msdyn_ocliveworkitem_liveworkstreamid"></a> msdyn_msdyn_liveworkstream_msdyn_ocliveworkitem_liveworkstreamid

One-To-Many Relationship: [msdyn_liveworkstream msdyn_msdyn_liveworkstream_msdyn_ocliveworkitem_liveworkstreamid](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_liveworkstream_msdyn_ocliveworkitem_liveworkstreamid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocliveworkitem_customerlanguageid"></a> msdyn_msdyn_oclanguage_msdyn_ocliveworkitem_customerlanguageid

One-To-Many Relationship: [msdyn_oclanguage msdyn_msdyn_oclanguage_msdyn_ocliveworkitem_customerlanguageid](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocliveworkitem_customerlanguageid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_customerlanguageid`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerlanguageid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid"></a> msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid

One-To-Many Relationship: [task msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid](task.md#BKMK_msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid)

|Property|Value|
|---|---|
|ReferencedEntity|`task`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_routableobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_msdyn_routableobjectid_msdyn_ocliveworkitem_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid"></a> msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid

One-To-Many Relationship: [msdyn_ocsentimentdailytopic msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid](msdyn_ocsentimentdailytopic.md#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsentimentdailytopic`|
|ReferencedAttribute|`msdyn_ocsentimentdailytopicid`|
|ReferencingAttribute|`msdyn_dailytopicid`|
|ReferencingEntityNavigationPropertyName|`msdyn_dailytopicid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid"></a> msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid

One-To-Many Relationship: [msdyn_ocsession msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid](msdyn_ocsession.md#BKMK_msdyn_msdyn_ocsession_msdyn_ocliveworkitem_lastsessionid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_lastsessionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_lastsessionid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_omnichannelqueue_msdyn_ocliveworkitem_queueid"></a> msdyn_msdyn_omnichannelqueue_msdyn_ocliveworkitem_queueid

One-To-Many Relationship: [msdyn_omnichannelqueue msdyn_msdyn_omnichannelqueue_msdyn_ocliveworkitem_queueid](msdyn_omnichannelqueue.md#BKMK_msdyn_msdyn_omnichannelqueue_msdyn_ocliveworkitem_queueid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_omnichannelqueue`|
|ReferencedAttribute|`msdyn_omnichannelqueueid`|
|ReferencingAttribute|`msdyn_queueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_queueid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid"></a> msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid

One-To-Many Relationship: [msdyn_sessionparticipant msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid](msdyn_sessionparticipant.md#BKMK_msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessionparticipant`|
|ReferencedAttribute|`msdyn_sessionparticipantid`|
|ReferencingAttribute|`msdyn_activesessionparticipantid`|
|ReferencingEntityNavigationPropertyName|`msdyn_activesessionparticipantid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_businessunit_owningbusinessunit"></a> msdyn_ocliveworkitem_businessunit_owningbusinessunit

One-To-Many Relationship: [businessunit msdyn_ocliveworkitem_businessunit_owningbusinessunit](businessunit.md#BKMK_msdyn_ocliveworkitem_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_mailbox_sendermailboxid"></a> msdyn_ocliveworkitem_mailbox_sendermailboxid

One-To-Many Relationship: [mailbox msdyn_ocliveworkitem_mailbox_sendermailboxid](mailbox.md#BKMK_msdyn_ocliveworkitem_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencedEntity|`mailbox`|
|ReferencedAttribute|`mailboxid`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencingEntityNavigationPropertyName|`sendermailboxid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_externalcontext_msdyn_ocexternalcontextid"></a> msdyn_ocliveworkitem_msdyn_externalcontext_msdyn_ocexternalcontextid

One-To-Many Relationship: [msdyn_ocexternalcontext msdyn_ocliveworkitem_msdyn_externalcontext_msdyn_ocexternalcontextid](msdyn_ocexternalcontext.md#BKMK_msdyn_ocliveworkitem_msdyn_externalcontext_msdyn_ocexternalcontextid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocexternalcontext`|
|ReferencedAttribute|`msdyn_ocexternalcontextid`|
|ReferencingAttribute|`msdyn_externalcontext`|
|ReferencingEntityNavigationPropertyName|`msdyn_externalcontext_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid"></a> msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid](msdyn_ocvoicemail.md#BKMK_msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_routableobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_routableobjectid_msdyn_ocvoicemail_msdyn_ocliveworkitem_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_owner_ownerid"></a> msdyn_ocliveworkitem_owner_ownerid

One-To-Many Relationship: [owner msdyn_ocliveworkitem_owner_ownerid](owner.md#BKMK_msdyn_ocliveworkitem_owner_ownerid)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_service_serviceid"></a> msdyn_ocliveworkitem_service_serviceid

One-To-Many Relationship: [service msdyn_ocliveworkitem_service_serviceid](service.md#BKMK_msdyn_ocliveworkitem_service_serviceid)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_sla_slaid"></a> msdyn_ocliveworkitem_sla_slaid

One-To-Many Relationship: [sla msdyn_ocliveworkitem_sla_slaid](sla.md#BKMK_msdyn_ocliveworkitem_sla_slaid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_activitypointer_sla_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_sla_slainvokedid"></a> msdyn_ocliveworkitem_sla_slainvokedid

One-To-Many Relationship: [sla msdyn_ocliveworkitem_sla_slainvokedid](sla.md#BKMK_msdyn_ocliveworkitem_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_activitypointer_sla_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_systemuser_createdby"></a> msdyn_ocliveworkitem_systemuser_createdby

One-To-Many Relationship: [systemuser msdyn_ocliveworkitem_systemuser_createdby](systemuser.md#BKMK_msdyn_ocliveworkitem_systemuser_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_systemuser_createdonbehalfby"></a> msdyn_ocliveworkitem_systemuser_createdonbehalfby

One-To-Many Relationship: [systemuser msdyn_ocliveworkitem_systemuser_createdonbehalfby](systemuser.md#BKMK_msdyn_ocliveworkitem_systemuser_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_systemuser_modifiedby"></a> msdyn_ocliveworkitem_systemuser_modifiedby

One-To-Many Relationship: [systemuser msdyn_ocliveworkitem_systemuser_modifiedby](systemuser.md#BKMK_msdyn_ocliveworkitem_systemuser_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_systemuser_modifiedonbehalfby"></a> msdyn_ocliveworkitem_systemuser_modifiedonbehalfby

One-To-Many Relationship: [systemuser msdyn_ocliveworkitem_systemuser_modifiedonbehalfby](systemuser.md#BKMK_msdyn_ocliveworkitem_systemuser_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_systemuser_owninguser"></a> msdyn_ocliveworkitem_systemuser_owninguser

One-To-Many Relationship: [systemuser msdyn_ocliveworkitem_systemuser_owninguser](systemuser.md#BKMK_msdyn_ocliveworkitem_systemuser_owninguser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_team_owningteam"></a> msdyn_ocliveworkitem_team_owningteam

One-To-Many Relationship: [team msdyn_ocliveworkitem_team_owningteam](team.md#BKMK_msdyn_ocliveworkitem_team_owningteam)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid"></a> msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_msdyn_ocliveworkitems"></a> msdyn_payment_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_payment msdyn_payment_msdyn_ocliveworkitems](msdyn_payment.md#BKMK_msdyn_payment_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_msdyn_ocliveworkitems"></a> msdyn_paymentdetail_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_msdyn_ocliveworkitems](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_msdyn_ocliveworkitems"></a> msdyn_paymentmethod_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_msdyn_ocliveworkitems](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_msdyn_ocliveworkitems"></a> msdyn_paymentterm_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_msdyn_ocliveworkitems](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_msdyn_ocliveworkitems"></a> msdyn_playbookinstance_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_msdyn_ocliveworkitems](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_msdyn_ocliveworkitems"></a> msdyn_postalbum_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_msdyn_ocliveworkitems](msdyn_postalbum.md#BKMK_msdyn_postalbum_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_msdyn_ocliveworkitems"></a> msdyn_postalcode_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_msdyn_ocliveworkitems](msdyn_postalcode.md#BKMK_msdyn_postalcode_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_msdyn_ocliveworkitems"></a> msdyn_productinventory_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_msdyn_ocliveworkitems](msdyn_productinventory.md#BKMK_msdyn_productinventory_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_msdyn_ocliveworkitems"></a> msdyn_purchaseorder_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_msdyn_ocliveworkitems](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_msdyn_ocliveworkitems"></a> msdyn_purchaseorderbill_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_msdyn_ocliveworkitems](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_msdyn_ocliveworkitems"></a> msdyn_purchaseorderproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_msdyn_ocliveworkitems](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_ocliveworkitems"></a> msdyn_purchaseorderreceipt_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_msdyn_ocliveworkitems](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems"></a> msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_ocliveworkitems"></a> msdyn_purchaseordersubstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_msdyn_ocliveworkitems](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_queue_msdyn_ocliveworkitem_queueid"></a> msdyn_queue_msdyn_ocliveworkitem_queueid

One-To-Many Relationship: [queue msdyn_queue_msdyn_ocliveworkitem_queueid](queue.md#BKMK_msdyn_queue_msdyn_ocliveworkitem_queueid)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_cdsqueueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_cdsqueueid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_queueitem_msdyn_ocliveworkitem_queueitemid"></a> msdyn_queueitem_msdyn_ocliveworkitem_queueitemid

One-To-Many Relationship: [queueitem msdyn_queueitem_msdyn_ocliveworkitem_queueitemid](queueitem.md#BKMK_msdyn_queueitem_msdyn_ocliveworkitem_queueitemid)

|Property|Value|
|---|---|
|ReferencedEntity|`queueitem`|
|ReferencedAttribute|`queueitemid`|
|ReferencingAttribute|`msdyn_queueitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_queueitemid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_msdyn_ocliveworkitems"></a> msdyn_quotebookingincident_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_msdyn_ocliveworkitems](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_ocliveworkitems"></a> msdyn_quotebookingproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_msdyn_ocliveworkitems](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_msdyn_ocliveworkitems"></a> msdyn_quotebookingservice_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_msdyn_ocliveworkitems](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_ocliveworkitems"></a> msdyn_quotebookingservicetask_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_msdyn_ocliveworkitems](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems"></a> msdyn_resourceterritory_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msdyn_ocliveworkitems](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_msdyn_ocliveworkitems"></a> msdyn_rma_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rma msdyn_rma_msdyn_ocliveworkitems](msdyn_rma.md#BKMK_msdyn_rma_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_msdyn_ocliveworkitems"></a> msdyn_rmaproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_msdyn_ocliveworkitems](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_msdyn_ocliveworkitems"></a> msdyn_rmareceipt_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_msdyn_ocliveworkitems](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_ocliveworkitems"></a> msdyn_rmareceiptproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_msdyn_ocliveworkitems](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_msdyn_ocliveworkitems"></a> msdyn_rmasubstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_msdyn_ocliveworkitems](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_msdyn_ocliveworkitems"></a> msdyn_rtv_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_msdyn_ocliveworkitems](msdyn_rtv.md#BKMK_msdyn_rtv_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_msdyn_ocliveworkitems"></a> msdyn_rtvproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_msdyn_ocliveworkitems](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_ocliveworkitems"></a> msdyn_rtvsubstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_msdyn_ocliveworkitems](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_msdyn_ocliveworkitems"></a> msdyn_salessuggestion_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_msdyn_ocliveworkitems](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_msdyn_ocliveworkitems"></a> msdyn_shipvia_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_msdyn_ocliveworkitems](msdyn_shipvia.md#BKMK_msdyn_shipvia_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid"></a> msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid

One-To-Many Relationship: [socialprofile msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid](socialprofile.md#BKMK_msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid)

|Property|Value|
|---|---|
|ReferencedEntity|`socialprofile`|
|ReferencedAttribute|`socialprofileid`|
|ReferencingAttribute|`msdyn_socialprofileid`|
|ReferencingEntityNavigationPropertyName|`msdyn_socialprofileid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_swarm_msdyn_ocliveworkitems"></a> msdyn_swarm_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_msdyn_ocliveworkitems](msdyn_swarm.md#BKMK_msdyn_swarm_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_ocliveworkitem_activeagentid"></a> msdyn_systemuser_msdyn_ocliveworkitem_activeagentid

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_ocliveworkitem_activeagentid](systemuser.md#BKMK_msdyn_systemuser_msdyn_ocliveworkitem_activeagentid)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_activeagentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_activeagentid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems"></a> msdyn_systemuserschedulersetting_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msdyn_ocliveworkitems](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msdyn_ocliveworkitems"></a> msdyn_timegroup_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msdyn_ocliveworkitems](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems"></a> msdyn_timegroupdetail_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msdyn_ocliveworkitems](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_msdyn_ocliveworkitems"></a> msdyn_timeoffrequest_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_msdyn_ocliveworkitems](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_msdyn_ocliveworkitems"></a> msdyn_warehouse_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_msdyn_ocliveworkitems](msdyn_warehouse.md#BKMK_msdyn_warehouse_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_msdyn_ocliveworkitems"></a> msdyn_workorder_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_msdyn_ocliveworkitems](msdyn_workorder.md#BKMK_msdyn_workorder_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_msdyn_ocliveworkitems"></a> msdyn_workordercharacteristic_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_msdyn_ocliveworkitems](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_msdyn_ocliveworkitems"></a> msdyn_workorderincident_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_msdyn_ocliveworkitems](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_msdyn_ocliveworkitems"></a> msdyn_workorderproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_msdyn_ocliveworkitems](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_ocliveworkitems"></a> msdyn_workorderresourcerestriction_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_msdyn_ocliveworkitems](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_msdyn_ocliveworkitems"></a> msdyn_workorderservice_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_msdyn_ocliveworkitems](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_msdyn_ocliveworkitems"></a> msdyn_workorderservicetask_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_msdyn_ocliveworkitems](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_msdyn_ocliveworkitems"></a> msdyncrm_contentsettings_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_msdyn_ocliveworkitems](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_msdyn_ocliveworkitems"></a> msdyncrm_customerjourney_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_msdyn_ocliveworkitems](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_msdyn_ocliveworkitems"></a> msdyncrm_leadscoremodel_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_msdyn_ocliveworkitems](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_msdyn_ocliveworkitems"></a> msdyncrm_linkedinaccount_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_msdyn_ocliveworkitems](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_msdyn_ocliveworkitems"></a> msdyncrm_linkedinactivity_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_msdyn_ocliveworkitems](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems"></a> msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_msdyn_ocliveworkitems"></a> msdyncrm_linkedinform_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_msdyn_ocliveworkitems](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_msdyn_ocliveworkitems"></a> msdyncrm_linkedinformanswer_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_msdyn_ocliveworkitems](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_msdyn_ocliveworkitems"></a> msdyncrm_linkedinformquestion_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_msdyn_ocliveworkitems](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems"></a> msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocliveworkitems"></a> msdyncrm_linkedinleadmatchingstrategy_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_msdyn_ocliveworkitems](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_msdyn_ocliveworkitems"></a> msdyncrm_linkedinuserprofile_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_msdyn_ocliveworkitems](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems"></a> msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocliveworkitems"></a> msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocliveworkitems](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems"></a> msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_msdyn_ocliveworkitems"></a> msdyncrm_migration_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_msdyn_ocliveworkitems](msdyncrm_migration.md#BKMK_msdyncrm_migration_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_uicconfig_msdyn_ocliveworkitems"></a> msdyncrm_uicconfig_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_msdyn_ocliveworkitems](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_checkin_msdyn_ocliveworkitems"></a> msevtmgt_checkin_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_msdyn_ocliveworkitems](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_msdyn_ocliveworkitems"></a> msevtmgt_event_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_msdyn_ocliveworkitems](msevtmgt_event.md#BKMK_msevtmgt_event_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_msdyn_ocliveworkitems"></a> msevtmgt_eventpurchase_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_msdyn_ocliveworkitems](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems"></a> msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msdyn_ocliveworkitems"></a> msevtmgt_eventpurchasepass_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_msdyn_ocliveworkitems](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_msdyn_ocliveworkitems"></a> msevtmgt_eventregistration_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_msdyn_ocliveworkitems](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_msdyn_ocliveworkitems"></a> msevtmgt_hotel_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_msdyn_ocliveworkitems](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msdyn_ocliveworkitems"></a> msevtmgt_hotelroomallocation_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_msdyn_ocliveworkitems](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_msdyn_ocliveworkitems"></a> msevtmgt_hotelroomreservation_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_msdyn_ocliveworkitems](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_msdyn_ocliveworkitems"></a> msevtmgt_layout_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_msdyn_ocliveworkitems](msevtmgt_layout.md#BKMK_msevtmgt_layout_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_msdyn_ocliveworkitems"></a> msevtmgt_room_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_msdyn_ocliveworkitems](msevtmgt_room.md#BKMK_msevtmgt_room_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_msdyn_ocliveworkitems"></a> msevtmgt_session_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_msdyn_ocliveworkitems](msevtmgt_session.md#BKMK_msevtmgt_session_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_msdyn_ocliveworkitems"></a> msevtmgt_sessionregistration_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_msdyn_ocliveworkitems](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_msdyn_ocliveworkitems"></a> msevtmgt_sessiontrack_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_msdyn_ocliveworkitems](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_msdyn_ocliveworkitems"></a> msevtmgt_speaker_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_msdyn_ocliveworkitems](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_msdyn_ocliveworkitems"></a> msevtmgt_speakerengagement_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_msdyn_ocliveworkitems](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msdyn_ocliveworkitems"></a> msevtmgt_sponsorablearticle_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_msdyn_ocliveworkitems](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_msdyn_ocliveworkitems"></a> msevtmgt_sponsorship_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_msdyn_ocliveworkitems](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_msdyn_ocliveworkitems"></a> msevtmgt_venue_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_msdyn_ocliveworkitems](msevtmgt_venue.md#BKMK_msevtmgt_venue_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msdyn_ocliveworkitems"></a> msevtmgt_webinarconfiguration_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_msdyn_ocliveworkitems](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_msdyn_ocliveworkitems"></a> msevtmgt_webinarprovider_msdyn_ocliveworkitems

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_msdyn_ocliveworkitems](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_adplacement_msdyn_ocliveworkitems"></a> mspp_adplacement_msdyn_ocliveworkitems

One-To-Many Relationship: [mspp_adplacement mspp_adplacement_msdyn_ocliveworkitems](mspp_adplacement.md#BKMK_mspp_adplacement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_adplacement`|
|ReferencedAttribute|`mspp_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_adplacement_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_pollplacement_msdyn_ocliveworkitems"></a> mspp_pollplacement_msdyn_ocliveworkitems

One-To-Many Relationship: [mspp_pollplacement mspp_pollplacement_msdyn_ocliveworkitems](mspp_pollplacement.md#BKMK_mspp_pollplacement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_pollplacement`|
|ReferencedAttribute|`mspp_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_pollplacement_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_publishingstatetransitionrule_msdyn_ocliveworkitems"></a> mspp_publishingstatetransitionrule_msdyn_ocliveworkitems

One-To-Many Relationship: [mspp_publishingstatetransitionrule mspp_publishingstatetransitionrule_msdyn_ocliveworkitems](mspp_publishingstatetransitionrule.md#BKMK_mspp_publishingstatetransitionrule_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_publishingstatetransitionrule`|
|ReferencedAttribute|`mspp_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_publishingstatetransitionrule_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_redirect_msdyn_ocliveworkitems"></a> mspp_redirect_msdyn_ocliveworkitems

One-To-Many Relationship: [mspp_redirect mspp_redirect_msdyn_ocliveworkitems](mspp_redirect.md#BKMK_mspp_redirect_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_redirect`|
|ReferencedAttribute|`mspp_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_redirect_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_shortcut_msdyn_ocliveworkitems"></a> mspp_shortcut_msdyn_ocliveworkitems

One-To-Many Relationship: [mspp_shortcut mspp_shortcut_msdyn_ocliveworkitems](mspp_shortcut.md#BKMK_mspp_shortcut_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_shortcut`|
|ReferencedAttribute|`mspp_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_shortcut_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_website_msdyn_ocliveworkitems"></a> mspp_website_msdyn_ocliveworkitems

One-To-Many Relationship: [mspp_website mspp_website_msdyn_ocliveworkitems](mspp_website.md#BKMK_mspp_website_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_website`|
|ReferencedAttribute|`mspp_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_website_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_msdyn_ocliveworkitems"></a> opportunity_msdyn_ocliveworkitems

One-To-Many Relationship: [opportunity opportunity_msdyn_ocliveworkitems](opportunity.md#BKMK_opportunity_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_quote_msdyn_ocliveworkitems"></a> quote_msdyn_ocliveworkitems

One-To-Many Relationship: [quote quote_msdyn_ocliveworkitems](quote.md#BKMK_quote_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_salesorder_msdyn_ocliveworkitems"></a> salesorder_msdyn_ocliveworkitems

One-To-Many Relationship: [salesorder salesorder_msdyn_ocliveworkitems](salesorder.md#BKMK_salesorder_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_site_msdyn_ocliveworkitems"></a> site_msdyn_ocliveworkitems

One-To-Many Relationship: [site site_msdyn_ocliveworkitems](site.md#BKMK_site_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [CampaignResponse_msdyn_ocliveworkitems](#BKMK_CampaignResponse_msdyn_ocliveworkitems)
- [msdyn_msdyn_ocliveworkitem_msdyn_cdsentityengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_cdsentityengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse)
- [msdyn_msdyn_ocliveworkitem_msdyn_conversationinsight_ConversationId](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationinsight_ConversationId)
- [msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid)
- [msdyn_msdyn_ocliveworkitem_msdyn_conversationtopic_conversation_conversationid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationtopic_conversation_conversationid)
- [msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_effortpredictionresult_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_effortpredictionresult_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcontextitem_ocliveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcontextitem_ocliveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemsentiment_ocliveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemsentiment_ocliveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocrequest_LiveWorkItemId](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrequest_LiveWorkItemId)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail)
- [msdyn_msdyn_ocliveworkitem_msdyn_salesocmessage_conversationid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_salesocmessage_conversationid)
- [msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_suggestioninteraction_msdyn_suggestionfor](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_suggestioninteraction_msdyn_suggestionfor)
- [msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload)
- [msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_teamsengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_teamsengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_transcript](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_transcript)
- [msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_ocliveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_ocliveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_targetobject](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_targetobject)
- [msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem)
- [msdyn_msdyn_ocliveworkitem_msdyn_visitorjourney_ocliveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_visitorjourney_ocliveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid)
- [msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject](#BKMK_msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject)
- [msdyn_ocliveworkitem_ActionCards](#BKMK_msdyn_ocliveworkitem_ActionCards)
- [msdyn_ocliveworkitem_activity_parties](#BKMK_msdyn_ocliveworkitem_activity_parties)
- [msdyn_ocliveworkitem_Annotations](#BKMK_msdyn_ocliveworkitem_Annotations)
- [msdyn_ocliveworkitem_AsyncOperations](#BKMK_msdyn_ocliveworkitem_AsyncOperations)
- [msdyn_ocliveworkitem_BulkDeleteFailures](#BKMK_msdyn_ocliveworkitem_BulkDeleteFailures)
- [msdyn_ocliveworkitem_connections1](#BKMK_msdyn_ocliveworkitem_connections1)
- [msdyn_ocliveworkitem_connections2](#BKMK_msdyn_ocliveworkitem_connections2)
- [msdyn_ocliveworkitem_conv_sug_req_payload](#BKMK_msdyn_ocliveworkitem_conv_sug_req_payload)
- [msdyn_ocliveworkitem_Feedback](#BKMK_msdyn_ocliveworkitem_Feedback)
- [msdyn_ocliveworkitem_MailboxTrackingFolders](#BKMK_msdyn_ocliveworkitem_MailboxTrackingFolders)
- [msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid](#BKMK_msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid)
- [msdyn_ocliveworkitem_msdyn_liveworkitemevent_liveworkitemid](#BKMK_msdyn_ocliveworkitem_msdyn_liveworkitemevent_liveworkitemid)
- [msdyn_ocliveworkitem_msdyn_ocliveworkitemcapacityprofile](#BKMK_msdyn_ocliveworkitem_msdyn_ocliveworkitemcapacityprofile)
- [msdyn_ocliveworkitem_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocliveworkitem_PrincipalObjectAttributeAccesses)
- [msdyn_ocliveworkitem_ProcessSession](#BKMK_msdyn_ocliveworkitem_ProcessSession)
- [msdyn_ocliveworkitem_QueueItems](#BKMK_msdyn_ocliveworkitem_QueueItems)
- [msdyn_ocliveworkitem_SyncErrors](#BKMK_msdyn_ocliveworkitem_SyncErrors)
- [msdyn_readtracker_poly_msdyn_ocliveworkitem](#BKMK_msdyn_readtracker_poly_msdyn_ocliveworkitem)

### <a name="BKMK_CampaignResponse_msdyn_ocliveworkitems"></a> CampaignResponse_msdyn_ocliveworkitems

Many-To-One Relationship: [campaignresponse CampaignResponse_msdyn_ocliveworkitems](campaignresponse.md#BKMK_CampaignResponse_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_cdsentityengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_cdsentityengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_cdsentityengagementctx msdyn_msdyn_ocliveworkitem_msdyn_cdsentityengagementctx_liveworkitemid](msdyn_cdsentityengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_cdsentityengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_cdsentityengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_cdsentityengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse"></a> msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse

Many-To-One Relationship: [msdyn_chatquestionnaireresponse msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse](msdyn_chatquestionnaireresponse.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatquestionnaireresponse`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationinsight_ConversationId"></a> msdyn_msdyn_ocliveworkitem_msdyn_conversationinsight_ConversationId

Many-To-One Relationship: [msdyn_conversationinsight msdyn_msdyn_ocliveworkitem_msdyn_conversationinsight_ConversationId](msdyn_conversationinsight.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationinsight_ConversationId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationinsight`|
|ReferencingAttribute|`msdyn_conversationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_conversationinsight_ConversationId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid"></a> msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid

Many-To-One Relationship: [msdyn_conversationsummaryinteraction msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid](msdyn_conversationsummaryinteraction.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsummaryinteraction`|
|ReferencingAttribute|`msdyn_conversationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationtopic_conversation_conversationid"></a> msdyn_msdyn_ocliveworkitem_msdyn_conversationtopic_conversation_conversationid

Many-To-One Relationship: [msdyn_conversationtopic_conversation msdyn_msdyn_ocliveworkitem_msdyn_conversationtopic_conversation_conversationid](msdyn_conversationtopic_conversation.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationtopic_conversation_conversationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationtopic_conversation`|
|ReferencingAttribute|`msdyn_conversationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_conversationtopic_conversation_conversationid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_customengagementctx msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid](msdyn_customengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_effortpredictionresult_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_effortpredictionresult_liveworkitemid

Many-To-One Relationship: [msdyn_effortpredictionresult msdyn_msdyn_ocliveworkitem_msdyn_effortpredictionresult_liveworkitemid](msdyn_effortpredictionresult.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_effortpredictionresult_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_effortpredictionresult`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_effortpredictionresult_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_facebookengagementctx msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid](msdyn_facebookengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_facebookengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_lineengagementctx msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid](msdyn_lineengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_lineengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_livechatengagementctx msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid](msdyn_livechatengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_ocapplemessagesforbusinessengagementctx msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid](msdyn_ocapplemessagesforbusinessengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplemessagesforbusinessengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_ocgatekeeperengagementctx msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid](msdyn_ocgatekeeperengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgatekeeperengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesengagementctx msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid](msdyn_ocgooglebusinessmessagesengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid

Many-To-One Relationship: [msdyn_ocliveworkitemcharacteristic msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid](msdyn_ocliveworkitemcharacteristic.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcharacteristic`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcontextitem_ocliveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcontextitem_ocliveworkitemid

Many-To-One Relationship: [msdyn_ocliveworkitemcontextitem msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcontextitem_ocliveworkitemid](msdyn_ocliveworkitemcontextitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcontextitem_ocliveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcontextitem`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcontextitem_ocliveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemsentiment_ocliveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemsentiment_ocliveworkitemid

Many-To-One Relationship: [msdyn_ocliveworkitemsentiment msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemsentiment_ocliveworkitemid](msdyn_ocliveworkitemsentiment.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemsentiment_ocliveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemsentiment`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemsentiment_ocliveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_ocphonecallengagementctx msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid](msdyn_ocphonecallengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonecallengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid

Many-To-One Relationship: [msdyn_ocrecording msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid](msdyn_ocrecording.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrecording`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget

Many-To-One Relationship: [msdyn_ocrecording msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget](msdyn_ocrecording.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrecording`|
|ReferencingAttribute|`msdyn_recordingtarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocrecording_liveworkitemid_recordingtarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrequest_LiveWorkItemId"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocrequest_LiveWorkItemId

Many-To-One Relationship: [msdyn_ocrequest msdyn_msdyn_ocliveworkitem_msdyn_ocrequest_LiveWorkItemId](msdyn_ocrequest.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocrequest_LiveWorkItemId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrequest`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocrequest_LiveWorkItemId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid

Many-To-One Relationship: [msdyn_ocsession msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid](msdyn_ocsession.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocsession_liveworkstreamid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail](msdyn_ocvoicemail.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`msdyn_missedconversationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_salesocmessage_conversationid"></a> msdyn_msdyn_ocliveworkitem_msdyn_salesocmessage_conversationid

Many-To-One Relationship: [msdyn_salesocmessage msdyn_msdyn_ocliveworkitem_msdyn_salesocmessage_conversationid](msdyn_salesocmessage.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_salesocmessage_conversationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesocmessage`|
|ReferencingAttribute|`msdyn_conversationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_salesocmessage_conversationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_smsengagementctx msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid](msdyn_smsengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_suggestioninteraction_msdyn_suggestionfor"></a> msdyn_msdyn_ocliveworkitem_msdyn_suggestioninteraction_msdyn_suggestionfor

Many-To-One Relationship: [msdyn_suggestioninteraction msdyn_msdyn_ocliveworkitem_msdyn_suggestioninteraction_msdyn_suggestionfor](msdyn_suggestioninteraction.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_suggestioninteraction_msdyn_suggestionfor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestioninteraction`|
|ReferencingAttribute|`msdyn_suggestionfor`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_suggestioninteraction_msdyn_suggestionfor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload"></a> msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload

Many-To-One Relationship: [msdyn_suggestionrequestpayload msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload](msdyn_suggestionrequestpayload.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionrequestpayload`|
|ReferencingAttribute|`msdyn_suggestionfor`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_teamschannelengagementctx msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid](msdyn_teamschannelengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_teamschannelengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_teamsengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_teamsengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_teamsengagementctx msdyn_msdyn_ocliveworkitem_msdyn_teamsengagementctx_liveworkitemid](msdyn_teamsengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_teamsengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_teamsengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_teamsengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_transcript"></a> msdyn_msdyn_ocliveworkitem_msdyn_transcript

Many-To-One Relationship: [msdyn_transcript msdyn_msdyn_ocliveworkitem_msdyn_transcript](msdyn_transcript.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`msdyn_liveworkitemidid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_transcript`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_twitterengagementctx msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid](msdyn_twitterengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_twitterengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_ocliveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_ocliveworkitemid

Many-To-One Relationship: [msdyn_unifiedroutingdiagnostic msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_ocliveworkitemid](msdyn_unifiedroutingdiagnostic.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_ocliveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingdiagnostic`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_ocliveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_targetobject"></a> msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_targetobject

Many-To-One Relationship: [msdyn_unifiedroutingdiagnostic msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_targetobject](msdyn_unifiedroutingdiagnostic.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_targetobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingdiagnostic`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingdiagnostic_targetobject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem"></a> msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem

Many-To-One Relationship: [msdyn_unifiedroutingrun msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem](msdyn_unifiedroutingrun.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingrun`|
|ReferencingAttribute|`msdyn_liveworkitem`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_visitorjourney_ocliveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_visitorjourney_ocliveworkitemid

Many-To-One Relationship: [msdyn_visitorjourney msdyn_msdyn_ocliveworkitem_msdyn_visitorjourney_ocliveworkitemid](msdyn_visitorjourney.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_visitorjourney_ocliveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_visitorjourney`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_visitorjourney_ocliveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_wechatengagementctx msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid](msdyn_wechatengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wechatengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_whatsappengagementctx msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid](msdyn_whatsappengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_whatsappengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject"></a> msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject

Many-To-One Relationship: [msdyn_unifiedroutingrun msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject](msdyn_unifiedroutingrun.md#BKMK_msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingrun`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_ActionCards"></a> msdyn_ocliveworkitem_ActionCards

Many-To-One Relationship: [actioncard msdyn_ocliveworkitem_ActionCards](actioncard.md#BKMK_msdyn_ocliveworkitem_ActionCards)

|Property|Value|
|---|---|
|ReferencingEntity|`actioncard`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_ActionCards`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_activity_parties"></a> msdyn_ocliveworkitem_activity_parties

Many-To-One Relationship: [activityparty msdyn_ocliveworkitem_activity_parties](activityparty.md#BKMK_msdyn_ocliveworkitem_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_activity_parties`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_Annotations"></a> msdyn_ocliveworkitem_Annotations

Many-To-One Relationship: [annotation msdyn_ocliveworkitem_Annotations](annotation.md#BKMK_msdyn_ocliveworkitem_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_AsyncOperations"></a> msdyn_ocliveworkitem_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocliveworkitem_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocliveworkitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_BulkDeleteFailures"></a> msdyn_ocliveworkitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocliveworkitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocliveworkitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_connections1"></a> msdyn_ocliveworkitem_connections1

Many-To-One Relationship: [connection msdyn_ocliveworkitem_connections1](connection.md#BKMK_msdyn_ocliveworkitem_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_connections2"></a> msdyn_ocliveworkitem_connections2

Many-To-One Relationship: [connection msdyn_ocliveworkitem_connections2](connection.md#BKMK_msdyn_ocliveworkitem_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_conv_sug_req_payload"></a> msdyn_ocliveworkitem_conv_sug_req_payload

Many-To-One Relationship: [msdyn_conversationsuggestionrequestpayload msdyn_ocliveworkitem_conv_sug_req_payload](msdyn_conversationsuggestionrequestpayload.md#BKMK_msdyn_ocliveworkitem_conv_sug_req_payload)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsuggestionrequestpayload`|
|ReferencingAttribute|`msdyn_conversationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_conv_sug_req_payload`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: Conversation Id<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_Feedback"></a> msdyn_ocliveworkitem_Feedback

Many-To-One Relationship: [feedback msdyn_ocliveworkitem_Feedback](feedback.md#BKMK_msdyn_ocliveworkitem_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_MailboxTrackingFolders"></a> msdyn_ocliveworkitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocliveworkitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocliveworkitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid"></a> msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid

Many-To-One Relationship: [msdyn_conversationmessageblock msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid](msdyn_conversationmessageblock.md#BKMK_msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationmessageblock`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_liveworkitemevent_liveworkitemid"></a> msdyn_ocliveworkitem_msdyn_liveworkitemevent_liveworkitemid

Many-To-One Relationship: [msdyn_liveworkitemevent msdyn_ocliveworkitem_msdyn_liveworkitemevent_liveworkitemid](msdyn_liveworkitemevent.md#BKMK_msdyn_ocliveworkitem_msdyn_liveworkitemevent_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkitemevent`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_msdyn_liveworkitemevent_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_ocliveworkitemcapacityprofile"></a> msdyn_ocliveworkitem_msdyn_ocliveworkitemcapacityprofile

Many-To-One Relationship: [msdyn_ocliveworkitemcapacityprofile msdyn_ocliveworkitem_msdyn_ocliveworkitemcapacityprofile](msdyn_ocliveworkitemcapacityprofile.md#BKMK_msdyn_ocliveworkitem_msdyn_ocliveworkitemcapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcapacityprofile`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_msdyn_ocliveworkitemcapacityprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_PrincipalObjectAttributeAccesses"></a> msdyn_ocliveworkitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocliveworkitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocliveworkitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_ProcessSession"></a> msdyn_ocliveworkitem_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocliveworkitem_ProcessSession](processsession.md#BKMK_msdyn_ocliveworkitem_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_QueueItems"></a> msdyn_ocliveworkitem_QueueItems

Many-To-One Relationship: [queueitem msdyn_ocliveworkitem_QueueItems](queueitem.md#BKMK_msdyn_ocliveworkitem_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_SyncErrors"></a> msdyn_ocliveworkitem_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocliveworkitem_SyncErrors](syncerror.md#BKMK_msdyn_ocliveworkitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_readtracker_poly_msdyn_ocliveworkitem"></a> msdyn_readtracker_poly_msdyn_ocliveworkitem

Many-To-One Relationship: [msdyn_readtracker msdyn_readtracker_poly_msdyn_ocliveworkitem](msdyn_readtracker.md#BKMK_msdyn_readtracker_poly_msdyn_ocliveworkitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_readtracker`|
|ReferencingAttribute|`msdyn_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_readtracker_poly_msdyn_ocliveworkitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_ocliveworkitem_knowledgearticle](#BKMK_msdyn_msdyn_ocliveworkitem_knowledgearticle)
- [msdyn_ocliveworkitem_knowledgebaserecord](#BKMK_msdyn_ocliveworkitem_knowledgebaserecord)

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_knowledgearticle"></a> msdyn_msdyn_ocliveworkitem_knowledgearticle

See [knowledgearticle msdyn_msdyn_ocliveworkitem_knowledgearticle Many-To-Many Relationship](knowledgearticle.md#BKMK_msdyn_msdyn_ocliveworkitem_knowledgearticle)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_ocliveworkitem_knowledgeartic`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_ocliveworkitem_knowledgearticle`|
|IntersectAttribute|`activityid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_knowledgebaserecord"></a> msdyn_ocliveworkitem_knowledgebaserecord

See [knowledgebaserecord msdyn_ocliveworkitem_knowledgebaserecord Many-To-Many Relationship](knowledgebaserecord.md#BKMK_msdyn_ocliveworkitem_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_ocliveworkitem_knowledgebaser`|
|IsCustomizable|True|
|SchemaName|`msdyn_ocliveworkitem_knowledgebaserecord`|
|IntersectAttribute|`activityid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

