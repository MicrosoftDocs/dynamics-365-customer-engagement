---
title: "Outbound message (msdyn_ocoutboundmessage) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Outbound message (msdyn_ocoutboundmessage) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Outbound message (msdyn_ocoutboundmessage) table/entity reference

Outbound activity entity

## Messages

The following table lists the messages for the Outbound message (msdyn_ocoutboundmessage) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocoutboundmessages(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_ocoutboundmessages<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocoutboundmessages(*activityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocoutboundmessages(*activityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocoutboundmessages<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocoutboundmessages(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocoutboundmessages(*activityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocoutboundmessages(*activityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Outbound message (msdyn_ocoutboundmessage) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Outbound message (msdyn_ocoutboundmessage) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Outbound message** |
| **DisplayCollectionName** | **Outbound messages** |
| **SchemaName** | `msdyn_ocoutboundmessage` |
| **CollectionSchemaName** | `msdyn_ocoutboundmessages` |
| **EntitySetName** | `msdyn_ocoutboundmessages`|
| **LogicalName** | `msdyn_ocoutboundmessage` |
| **LogicalCollectionName** | `msdyn_ocoutboundmessages` |
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
- [msdyn_failurereason](#BKMK_msdyn_failurereason)
- [msdyn_failurestatuscode](#BKMK_msdyn_failurestatuscode)
- [msdyn_occhannelprovidername](#BKMK_msdyn_occhannelprovidername)
- [msdyn_occhanneltype](#BKMK_msdyn_occhanneltype)
- [msdyn_occustomerlocale](#BKMK_msdyn_occustomerlocale)
- [msdyn_ocliveworkstreamid](#BKMK_msdyn_ocliveworkstreamid)
- [msdyn_ocmessagetext](#BKMK_msdyn_ocmessagetext)
- [msdyn_ocmessagetype](#BKMK_msdyn_ocmessagetype)
- [msdyn_ocoutboundconfiguration](#BKMK_msdyn_ocoutboundconfiguration)
- [msdyn_ocReceiverChannelId](#BKMK_msdyn_ocReceiverChannelId)
- [msdyn_ocsenderChannelId](#BKMK_msdyn_ocsenderChannelId)
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
|GlobalChoiceName|`msdyn_ocoutboundmessage_isbilled`|
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
|GlobalChoiceName|`msdyn_ocoutboundmessage_ismapiprivate`|
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
|GlobalChoiceName|`msdyn_ocoutboundmessage_isworkflowcreated`|
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
|GlobalChoiceName|`msdyn_ocoutboundmessage_leftvoicemail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_failurereason"></a> msdyn_failurereason

|Property|Value|
|---|---|
|Description|**Outbound message delivery failure reason.**|
|DisplayName|**Reason for outbound message delivery**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_failurereason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_failurestatuscode"></a> msdyn_failurestatuscode

|Property|Value|
|---|---|
|Description|**Failure status code of outbound message**|
|DisplayName|**Failure status code of outbound message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_failurestatuscode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_occhannelprovidername"></a> msdyn_occhannelprovidername

|Property|Value|
|---|---|
|Description|**Channel Provider Name.**|
|DisplayName|**Channel Provider Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occhannelprovidername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_occhanneltype"></a> msdyn_occhanneltype

|Property|Value|
|---|---|
|Description|**The channel(s) in the conversation.**|
|DisplayName|**Channel Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occhanneltype`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_streamsource`|

#### msdyn_occhanneltype Choices/Options

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

### <a name="BKMK_msdyn_occustomerlocale"></a> msdyn_occustomerlocale

|Property|Value|
|---|---|
|Description|**Customer preferred locale**|
|DisplayName|**Customer locale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occustomerlocale`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_oclanguage|

### <a name="BKMK_msdyn_ocliveworkstreamid"></a> msdyn_ocliveworkstreamid

|Property|Value|
|---|---|
|Description|**Work stream associated to the conversation**|
|DisplayName|**Live Work Stream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocliveworkstreamid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

### <a name="BKMK_msdyn_ocmessagetext"></a> msdyn_ocmessagetext

|Property|Value|
|---|---|
|Description|**Message text.**|
|DisplayName|**Message text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocmessagetext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ocmessagetype"></a> msdyn_ocmessagetype

|Property|Value|
|---|---|
|Description|**Message type**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocmessagetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_messagetype`|

#### msdyn_ocmessagetype Choices/Options

|Value|Label|
|---|---|
|100000000|**Create conversation when customer responds**|
|100000001|**Create conversation on send**|

### <a name="BKMK_msdyn_ocoutboundconfiguration"></a> msdyn_ocoutboundconfiguration

|Property|Value|
|---|---|
|Description|**Associated Outbound Configuration.**|
|DisplayName|**Outbound Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocoutboundconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocoutboundconfiguration|

### <a name="BKMK_msdyn_ocReceiverChannelId"></a> msdyn_ocReceiverChannelId

|Property|Value|
|---|---|
|Description|**This can be an SMS number, Facebook page id, etc.**|
|DisplayName|**Receiver channel ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocreceiverchannelid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocsenderChannelId"></a> msdyn_ocsenderChannelId

|Property|Value|
|---|---|
|Description|**This can be an SMS number, Facebook page id, etc.**|
|DisplayName|**Sender channel ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocsenderchannelid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|GlobalChoiceName|`msdyn_ocoutboundmessage_prioritycode`|

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
|DisplayName|**(Deprecated) Process Stage**|
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
|GlobalChoiceName|`msdyn_ocoutboundmessage_statecode`|

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
|GlobalChoiceName|`msdyn_ocoutboundmessage_statuscode`|

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
|MaxLength|100|

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
|DisplayName|**(Deprecated) Traversed Path**|
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
|GlobalChoiceName|`msdyn_ocoutboundmessage_instancetypecode`|

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

- [account_msdyn_ocoutboundmessages](#BKMK_account_msdyn_ocoutboundmessages)
- [activity_pointer_msdyn_ocoutboundmessage](#BKMK_activity_pointer_msdyn_ocoutboundmessage)
- [adx_ad_msdyn_ocoutboundmessages](#BKMK_adx_ad_msdyn_ocoutboundmessages)
- [adx_adplacement_msdyn_ocoutboundmessages](#BKMK_adx_adplacement_msdyn_ocoutboundmessages)
- [adx_casedeflection_msdyn_ocoutboundmessages](#BKMK_adx_casedeflection_msdyn_ocoutboundmessages)
- [adx_communityforumaccesspermission_msdyn_ocoutboundmessages](#BKMK_adx_communityforumaccesspermission_msdyn_ocoutboundmessages)
- [adx_communityforumalert_msdyn_ocoutboundmessages](#BKMK_adx_communityforumalert_msdyn_ocoutboundmessages)
- [adx_contentaccesslevel_msdyn_ocoutboundmessages](#BKMK_adx_contentaccesslevel_msdyn_ocoutboundmessages)
- [adx_invitation_msdyn_ocoutboundmessages](#BKMK_adx_invitation_msdyn_ocoutboundmessages)
- [adx_poll_msdyn_ocoutboundmessages](#BKMK_adx_poll_msdyn_ocoutboundmessages)
- [adx_polloption_msdyn_ocoutboundmessages](#BKMK_adx_polloption_msdyn_ocoutboundmessages)
- [adx_pollplacement_msdyn_ocoutboundmessages](#BKMK_adx_pollplacement_msdyn_ocoutboundmessages)
- [adx_pollsubmission_msdyn_ocoutboundmessages](#BKMK_adx_pollsubmission_msdyn_ocoutboundmessages)
- [adx_publishingstatetransitionrule_msdyn_ocoutboundmessages](#BKMK_adx_publishingstatetransitionrule_msdyn_ocoutboundmessages)
- [adx_redirect_msdyn_ocoutboundmessages](#BKMK_adx_redirect_msdyn_ocoutboundmessages)
- [adx_shortcut_msdyn_ocoutboundmessages](#BKMK_adx_shortcut_msdyn_ocoutboundmessages)
- [adx_webpage_msdyn_ocoutboundmessages](#BKMK_adx_webpage_msdyn_ocoutboundmessages)
- [adx_website_msdyn_ocoutboundmessages](#BKMK_adx_website_msdyn_ocoutboundmessages)
- [bookableresourcebooking_msdyn_ocoutboundmessages](#BKMK_bookableresourcebooking_msdyn_ocoutboundmessages)
- [bookableresourcebookingheader_msdyn_ocoutboundmessages](#BKMK_bookableresourcebookingheader_msdyn_ocoutboundmessages)
- [bulkoperation_msdyn_ocoutboundmessages](#BKMK_bulkoperation_msdyn_ocoutboundmessages)
- [campaign_msdyn_ocoutboundmessages](#BKMK_campaign_msdyn_ocoutboundmessages)
- [campaignactivity_msdyn_ocoutboundmessages](#BKMK_campaignactivity_msdyn_ocoutboundmessages)
- [contact_msdyn_ocoutboundmessages](#BKMK_contact_msdyn_ocoutboundmessages)
- [contract_msdyn_ocoutboundmessages](#BKMK_contract_msdyn_ocoutboundmessages)
- [entitlement_msdyn_ocoutboundmessages](#BKMK_entitlement_msdyn_ocoutboundmessages)
- [entitlementtemplate_msdyn_ocoutboundmessages](#BKMK_entitlementtemplate_msdyn_ocoutboundmessages)
- [incident_msdyn_ocoutboundmessages](#BKMK_incident_msdyn_ocoutboundmessages)
- [interactionforemail_msdyn_ocoutboundmessages](#BKMK_interactionforemail_msdyn_ocoutboundmessages)
- [invoice_msdyn_ocoutboundmessages](#BKMK_invoice_msdyn_ocoutboundmessages)
- [knowledgearticle_msdyn_ocoutboundmessages](#BKMK_knowledgearticle_msdyn_ocoutboundmessages)
- [knowledgebaserecord_msdyn_ocoutboundmessages](#BKMK_knowledgebaserecord_msdyn_ocoutboundmessages)
- [lead_msdyn_ocoutboundmessages](#BKMK_lead_msdyn_ocoutboundmessages)
- [msdyn_agreement_msdyn_ocoutboundmessages](#BKMK_msdyn_agreement_msdyn_ocoutboundmessages)
- [msdyn_agreementbookingdate_msdyn_ocoutboundmessages](#BKMK_msdyn_agreementbookingdate_msdyn_ocoutboundmessages)
- [msdyn_agreementbookingincident_msdyn_ocoutboundmessages](#BKMK_msdyn_agreementbookingincident_msdyn_ocoutboundmessages)
- [msdyn_agreementbookingproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_agreementbookingproduct_msdyn_ocoutboundmessages)
- [msdyn_agreementbookingservice_msdyn_ocoutboundmessages](#BKMK_msdyn_agreementbookingservice_msdyn_ocoutboundmessages)
- [msdyn_agreementbookingservicetask_msdyn_ocoutboundmessages](#BKMK_msdyn_agreementbookingservicetask_msdyn_ocoutboundmessages)
- [msdyn_agreementbookingsetup_msdyn_ocoutboundmessages](#BKMK_msdyn_agreementbookingsetup_msdyn_ocoutboundmessages)
- [msdyn_agreementinvoicedate_msdyn_ocoutboundmessages](#BKMK_msdyn_agreementinvoicedate_msdyn_ocoutboundmessages)
- [msdyn_agreementinvoiceproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_agreementinvoiceproduct_msdyn_ocoutboundmessages)
- [msdyn_agreementinvoicesetup_msdyn_ocoutboundmessages](#BKMK_msdyn_agreementinvoicesetup_msdyn_ocoutboundmessages)
- [msdyn_bookingalertstatus_msdyn_ocoutboundmessages](#BKMK_msdyn_bookingalertstatus_msdyn_ocoutboundmessages)
- [msdyn_bookingrule_msdyn_ocoutboundmessages](#BKMK_msdyn_bookingrule_msdyn_ocoutboundmessages)
- [msdyn_bookingtimestamp_msdyn_ocoutboundmessages](#BKMK_msdyn_bookingtimestamp_msdyn_ocoutboundmessages)
- [msdyn_customerasset_msdyn_ocoutboundmessages](#BKMK_msdyn_customerasset_msdyn_ocoutboundmessages)
- [msdyn_fieldservicesetting_msdyn_ocoutboundmessages](#BKMK_msdyn_fieldservicesetting_msdyn_ocoutboundmessages)
- [msdyn_incidenttypecharacteristic_msdyn_ocoutboundmessages](#BKMK_msdyn_incidenttypecharacteristic_msdyn_ocoutboundmessages)
- [msdyn_incidenttypeproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_incidenttypeproduct_msdyn_ocoutboundmessages)
- [msdyn_incidenttypeservice_msdyn_ocoutboundmessages](#BKMK_msdyn_incidenttypeservice_msdyn_ocoutboundmessages)
- [msdyn_inventoryadjustment_msdyn_ocoutboundmessages](#BKMK_msdyn_inventoryadjustment_msdyn_ocoutboundmessages)
- [msdyn_inventoryadjustmentproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocoutboundmessages)
- [msdyn_inventoryjournal_msdyn_ocoutboundmessages](#BKMK_msdyn_inventoryjournal_msdyn_ocoutboundmessages)
- [msdyn_inventorytransfer_msdyn_ocoutboundmessages](#BKMK_msdyn_inventorytransfer_msdyn_ocoutboundmessages)
- [msdyn_ocoutboundmessage_businessunit_owningbusinessunit](#BKMK_msdyn_ocoutboundmessage_businessunit_owningbusinessunit)
- [msdyn_ocoutboundmessage_mailbox_sendermailboxid](#BKMK_msdyn_ocoutboundmessage_mailbox_sendermailboxid)
- [msdyn_ocoutboundmessage_msdyn_ocoutbound](#BKMK_msdyn_ocoutboundmessage_msdyn_ocoutbound)
- [msdyn_ocoutboundmessage_occustomerlocale](#BKMK_msdyn_ocoutboundmessage_occustomerlocale)
- [msdyn_ocoutboundmessage_ocliveworkstream](#BKMK_msdyn_ocoutboundmessage_ocliveworkstream)
- [msdyn_ocoutboundmessage_owner_ownerid](#BKMK_msdyn_ocoutboundmessage_owner_ownerid)
- [msdyn_ocoutboundmessage_service_serviceid](#BKMK_msdyn_ocoutboundmessage_service_serviceid)
- [msdyn_ocoutboundmessage_sla_slaid](#BKMK_msdyn_ocoutboundmessage_sla_slaid)
- [msdyn_ocoutboundmessage_sla_slainvokedid](#BKMK_msdyn_ocoutboundmessage_sla_slainvokedid)
- [msdyn_ocoutboundmessage_systemuser_createdby](#BKMK_msdyn_ocoutboundmessage_systemuser_createdby)
- [msdyn_ocoutboundmessage_systemuser_createdonbehalfby](#BKMK_msdyn_ocoutboundmessage_systemuser_createdonbehalfby)
- [msdyn_ocoutboundmessage_systemuser_modifiedby](#BKMK_msdyn_ocoutboundmessage_systemuser_modifiedby)
- [msdyn_ocoutboundmessage_systemuser_modifiedonbehalfby](#BKMK_msdyn_ocoutboundmessage_systemuser_modifiedonbehalfby)
- [msdyn_ocoutboundmessage_systemuser_owninguser](#BKMK_msdyn_ocoutboundmessage_systemuser_owninguser)
- [msdyn_ocoutboundmessage_team_owningteam](#BKMK_msdyn_ocoutboundmessage_team_owningteam)
- [msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid)
- [msdyn_payment_msdyn_ocoutboundmessages](#BKMK_msdyn_payment_msdyn_ocoutboundmessages)
- [msdyn_paymentdetail_msdyn_ocoutboundmessages](#BKMK_msdyn_paymentdetail_msdyn_ocoutboundmessages)
- [msdyn_paymentmethod_msdyn_ocoutboundmessages](#BKMK_msdyn_paymentmethod_msdyn_ocoutboundmessages)
- [msdyn_paymentterm_msdyn_ocoutboundmessages](#BKMK_msdyn_paymentterm_msdyn_ocoutboundmessages)
- [msdyn_playbookinstance_msdyn_ocoutboundmessages](#BKMK_msdyn_playbookinstance_msdyn_ocoutboundmessages)
- [msdyn_postalbum_msdyn_ocoutboundmessages](#BKMK_msdyn_postalbum_msdyn_ocoutboundmessages)
- [msdyn_postalcode_msdyn_ocoutboundmessages](#BKMK_msdyn_postalcode_msdyn_ocoutboundmessages)
- [msdyn_productinventory_msdyn_ocoutboundmessages](#BKMK_msdyn_productinventory_msdyn_ocoutboundmessages)
- [msdyn_purchaseorder_msdyn_ocoutboundmessages](#BKMK_msdyn_purchaseorder_msdyn_ocoutboundmessages)
- [msdyn_purchaseorderbill_msdyn_ocoutboundmessages](#BKMK_msdyn_purchaseorderbill_msdyn_ocoutboundmessages)
- [msdyn_purchaseorderproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_purchaseorderproduct_msdyn_ocoutboundmessages)
- [msdyn_purchaseorderreceipt_msdyn_ocoutboundmessages](#BKMK_msdyn_purchaseorderreceipt_msdyn_ocoutboundmessages)
- [msdyn_purchaseorderreceiptproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocoutboundmessages)
- [msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages](#BKMK_msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages)
- [msdyn_quotebookingincident_msdyn_ocoutboundmessages](#BKMK_msdyn_quotebookingincident_msdyn_ocoutboundmessages)
- [msdyn_quotebookingproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_quotebookingproduct_msdyn_ocoutboundmessages)
- [msdyn_quotebookingservice_msdyn_ocoutboundmessages](#BKMK_msdyn_quotebookingservice_msdyn_ocoutboundmessages)
- [msdyn_quotebookingservicetask_msdyn_ocoutboundmessages](#BKMK_msdyn_quotebookingservicetask_msdyn_ocoutboundmessages)
- [msdyn_resourceterritory_msdyn_ocoutboundmessages](#BKMK_msdyn_resourceterritory_msdyn_ocoutboundmessages)
- [msdyn_rma_msdyn_ocoutboundmessages](#BKMK_msdyn_rma_msdyn_ocoutboundmessages)
- [msdyn_rmaproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_rmaproduct_msdyn_ocoutboundmessages)
- [msdyn_rmareceipt_msdyn_ocoutboundmessages](#BKMK_msdyn_rmareceipt_msdyn_ocoutboundmessages)
- [msdyn_rmareceiptproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_rmareceiptproduct_msdyn_ocoutboundmessages)
- [msdyn_rmasubstatus_msdyn_ocoutboundmessages](#BKMK_msdyn_rmasubstatus_msdyn_ocoutboundmessages)
- [msdyn_rtv_msdyn_ocoutboundmessages](#BKMK_msdyn_rtv_msdyn_ocoutboundmessages)
- [msdyn_rtvproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_rtvproduct_msdyn_ocoutboundmessages)
- [msdyn_rtvsubstatus_msdyn_ocoutboundmessages](#BKMK_msdyn_rtvsubstatus_msdyn_ocoutboundmessages)
- [msdyn_salessuggestion_msdyn_ocoutboundmessages](#BKMK_msdyn_salessuggestion_msdyn_ocoutboundmessages)
- [msdyn_shipvia_msdyn_ocoutboundmessages](#BKMK_msdyn_shipvia_msdyn_ocoutboundmessages)
- [msdyn_swarm_msdyn_ocoutboundmessages](#BKMK_msdyn_swarm_msdyn_ocoutboundmessages)
- [msdyn_systemuserschedulersetting_msdyn_ocoutboundmessages](#BKMK_msdyn_systemuserschedulersetting_msdyn_ocoutboundmessages)
- [msdyn_timegroup_msdyn_ocoutboundmessages](#BKMK_msdyn_timegroup_msdyn_ocoutboundmessages)
- [msdyn_timegroupdetail_msdyn_ocoutboundmessages](#BKMK_msdyn_timegroupdetail_msdyn_ocoutboundmessages)
- [msdyn_timeoffrequest_msdyn_ocoutboundmessages](#BKMK_msdyn_timeoffrequest_msdyn_ocoutboundmessages)
- [msdyn_warehouse_msdyn_ocoutboundmessages](#BKMK_msdyn_warehouse_msdyn_ocoutboundmessages)
- [msdyn_workorder_msdyn_ocoutboundmessages](#BKMK_msdyn_workorder_msdyn_ocoutboundmessages)
- [msdyn_workordercharacteristic_msdyn_ocoutboundmessages](#BKMK_msdyn_workordercharacteristic_msdyn_ocoutboundmessages)
- [msdyn_workorderincident_msdyn_ocoutboundmessages](#BKMK_msdyn_workorderincident_msdyn_ocoutboundmessages)
- [msdyn_workorderproduct_msdyn_ocoutboundmessages](#BKMK_msdyn_workorderproduct_msdyn_ocoutboundmessages)
- [msdyn_workorderresourcerestriction_msdyn_ocoutboundmessages](#BKMK_msdyn_workorderresourcerestriction_msdyn_ocoutboundmessages)
- [msdyn_workorderservice_msdyn_ocoutboundmessages](#BKMK_msdyn_workorderservice_msdyn_ocoutboundmessages)
- [msdyn_workorderservicetask_msdyn_ocoutboundmessages](#BKMK_msdyn_workorderservicetask_msdyn_ocoutboundmessages)
- [msdyncrm_contentsettings_msdyn_ocoutboundmessages](#BKMK_msdyncrm_contentsettings_msdyn_ocoutboundmessages)
- [msdyncrm_customerjourney_msdyn_ocoutboundmessages](#BKMK_msdyncrm_customerjourney_msdyn_ocoutboundmessages)
- [msdyncrm_leadscoremodel_msdyn_ocoutboundmessages](#BKMK_msdyncrm_leadscoremodel_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinaccount_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinaccount_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinactivity_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinactivity_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinform_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinform_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinformanswer_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinformanswer_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinformquestion_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinformquestion_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinleadmatchingstrategy_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinuserprofile_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinuserprofile_msdyn_ocoutboundmessages)
- [msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages)
- [msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocoutboundmessages](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocoutboundmessages)
- [msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages](#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages)
- [msdyncrm_migration_msdyn_ocoutboundmessages](#BKMK_msdyncrm_migration_msdyn_ocoutboundmessages)
- [msdyncrm_uicconfig_msdyn_ocoutboundmessages](#BKMK_msdyncrm_uicconfig_msdyn_ocoutboundmessages)
- [msevtmgt_checkin_msdyn_ocoutboundmessages](#BKMK_msevtmgt_checkin_msdyn_ocoutboundmessages)
- [msevtmgt_event_msdyn_ocoutboundmessages](#BKMK_msevtmgt_event_msdyn_ocoutboundmessages)
- [msevtmgt_eventpurchase_msdyn_ocoutboundmessages](#BKMK_msevtmgt_eventpurchase_msdyn_ocoutboundmessages)
- [msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages](#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages)
- [msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages](#BKMK_msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages)
- [msevtmgt_eventregistration_msdyn_ocoutboundmessages](#BKMK_msevtmgt_eventregistration_msdyn_ocoutboundmessages)
- [msevtmgt_hotel_msdyn_ocoutboundmessages](#BKMK_msevtmgt_hotel_msdyn_ocoutboundmessages)
- [msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages](#BKMK_msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages)
- [msevtmgt_hotelroomreservation_msdyn_ocoutboundmessages](#BKMK_msevtmgt_hotelroomreservation_msdyn_ocoutboundmessages)
- [msevtmgt_layout_msdyn_ocoutboundmessages](#BKMK_msevtmgt_layout_msdyn_ocoutboundmessages)
- [msevtmgt_room_msdyn_ocoutboundmessages](#BKMK_msevtmgt_room_msdyn_ocoutboundmessages)
- [msevtmgt_session_msdyn_ocoutboundmessages](#BKMK_msevtmgt_session_msdyn_ocoutboundmessages)
- [msevtmgt_sessionregistration_msdyn_ocoutboundmessages](#BKMK_msevtmgt_sessionregistration_msdyn_ocoutboundmessages)
- [msevtmgt_sessiontrack_msdyn_ocoutboundmessages](#BKMK_msevtmgt_sessiontrack_msdyn_ocoutboundmessages)
- [msevtmgt_speaker_msdyn_ocoutboundmessages](#BKMK_msevtmgt_speaker_msdyn_ocoutboundmessages)
- [msevtmgt_speakerengagement_msdyn_ocoutboundmessages](#BKMK_msevtmgt_speakerengagement_msdyn_ocoutboundmessages)
- [msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages](#BKMK_msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages)
- [msevtmgt_sponsorship_msdyn_ocoutboundmessages](#BKMK_msevtmgt_sponsorship_msdyn_ocoutboundmessages)
- [msevtmgt_venue_msdyn_ocoutboundmessages](#BKMK_msevtmgt_venue_msdyn_ocoutboundmessages)
- [msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages](#BKMK_msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages)
- [msevtmgt_webinarprovider_msdyn_ocoutboundmessages](#BKMK_msevtmgt_webinarprovider_msdyn_ocoutboundmessages)
- [mspp_adplacement_msdyn_ocoutboundmessages](#BKMK_mspp_adplacement_msdyn_ocoutboundmessages)
- [mspp_pollplacement_msdyn_ocoutboundmessages](#BKMK_mspp_pollplacement_msdyn_ocoutboundmessages)
- [mspp_publishingstatetransitionrule_msdyn_ocoutboundmessages](#BKMK_mspp_publishingstatetransitionrule_msdyn_ocoutboundmessages)
- [mspp_redirect_msdyn_ocoutboundmessages](#BKMK_mspp_redirect_msdyn_ocoutboundmessages)
- [mspp_shortcut_msdyn_ocoutboundmessages](#BKMK_mspp_shortcut_msdyn_ocoutboundmessages)
- [mspp_website_msdyn_ocoutboundmessages](#BKMK_mspp_website_msdyn_ocoutboundmessages)
- [opportunity_msdyn_ocoutboundmessages](#BKMK_opportunity_msdyn_ocoutboundmessages)
- [quote_msdyn_ocoutboundmessages](#BKMK_quote_msdyn_ocoutboundmessages)
- [salesorder_msdyn_ocoutboundmessages](#BKMK_salesorder_msdyn_ocoutboundmessages)
- [site_msdyn_ocoutboundmessages](#BKMK_site_msdyn_ocoutboundmessages)

### <a name="BKMK_account_msdyn_ocoutboundmessages"></a> account_msdyn_ocoutboundmessages

One-To-Many Relationship: [account account_msdyn_ocoutboundmessages](account.md#BKMK_account_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_account_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_activity_pointer_msdyn_ocoutboundmessage"></a> activity_pointer_msdyn_ocoutboundmessage

One-To-Many Relationship: [activitypointer activity_pointer_msdyn_ocoutboundmessage](activitypointer.md#BKMK_activity_pointer_msdyn_ocoutboundmessage)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_ad_msdyn_ocoutboundmessages"></a> adx_ad_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_ad adx_ad_msdyn_ocoutboundmessages](adx_ad.md#BKMK_adx_ad_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_msdyn_ocoutboundmessages"></a> adx_adplacement_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_adplacement adx_adplacement_msdyn_ocoutboundmessages](adx_adplacement.md#BKMK_adx_adplacement_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_msdyn_ocoutboundmessages"></a> adx_casedeflection_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_msdyn_ocoutboundmessages](adx_casedeflection.md#BKMK_adx_casedeflection_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_msdyn_ocoutboundmessages"></a> adx_communityforumaccesspermission_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_msdyn_ocoutboundmessages](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumalert_msdyn_ocoutboundmessages"></a> adx_communityforumalert_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_msdyn_ocoutboundmessages](adx_communityforumalert.md#BKMK_adx_communityforumalert_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_msdyn_ocoutboundmessages"></a> adx_contentaccesslevel_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_msdyn_ocoutboundmessages](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_invitation_msdyn_ocoutboundmessages"></a> adx_invitation_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_invitation adx_invitation_msdyn_ocoutboundmessages](adx_invitation.md#BKMK_adx_invitation_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_invitation`|
|ReferencedAttribute|`adx_invitationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_invitation_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_poll_msdyn_ocoutboundmessages"></a> adx_poll_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_poll adx_poll_msdyn_ocoutboundmessages](adx_poll.md#BKMK_adx_poll_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_msdyn_ocoutboundmessages"></a> adx_polloption_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_polloption adx_polloption_msdyn_ocoutboundmessages](adx_polloption.md#BKMK_adx_polloption_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_msdyn_ocoutboundmessages"></a> adx_pollplacement_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_msdyn_ocoutboundmessages](adx_pollplacement.md#BKMK_adx_pollplacement_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_msdyn_ocoutboundmessages"></a> adx_pollsubmission_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_msdyn_ocoutboundmessages](adx_pollsubmission.md#BKMK_adx_pollsubmission_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_msdyn_ocoutboundmessages"></a> adx_publishingstatetransitionrule_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_msdyn_ocoutboundmessages](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_msdyn_ocoutboundmessages"></a> adx_redirect_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_redirect adx_redirect_msdyn_ocoutboundmessages](adx_redirect.md#BKMK_adx_redirect_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_msdyn_ocoutboundmessages"></a> adx_shortcut_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_shortcut adx_shortcut_msdyn_ocoutboundmessages](adx_shortcut.md#BKMK_adx_shortcut_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_msdyn_ocoutboundmessages"></a> adx_webpage_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_webpage adx_webpage_msdyn_ocoutboundmessages](adx_webpage.md#BKMK_adx_webpage_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_msdyn_ocoutboundmessages"></a> adx_website_msdyn_ocoutboundmessages

One-To-Many Relationship: [adx_website adx_website_msdyn_ocoutboundmessages](adx_website.md#BKMK_adx_website_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebooking_msdyn_ocoutboundmessages"></a> bookableresourcebooking_msdyn_ocoutboundmessages

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_msdyn_ocoutboundmessages](bookableresourcebooking.md#BKMK_bookableresourcebooking_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_msdyn_ocoutboundmessages"></a> bookableresourcebookingheader_msdyn_ocoutboundmessages

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_msdyn_ocoutboundmessages](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_msdyn_ocoutboundmessages"></a> bulkoperation_msdyn_ocoutboundmessages

One-To-Many Relationship: [bulkoperation bulkoperation_msdyn_ocoutboundmessages](bulkoperation.md#BKMK_bulkoperation_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaign_msdyn_ocoutboundmessages"></a> campaign_msdyn_ocoutboundmessages

One-To-Many Relationship: [campaign campaign_msdyn_ocoutboundmessages](campaign.md#BKMK_campaign_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_msdyn_ocoutboundmessages"></a> campaignactivity_msdyn_ocoutboundmessages

One-To-Many Relationship: [campaignactivity campaignactivity_msdyn_ocoutboundmessages](campaignactivity.md#BKMK_campaignactivity_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contact_msdyn_ocoutboundmessages"></a> contact_msdyn_ocoutboundmessages

One-To-Many Relationship: [contact contact_msdyn_ocoutboundmessages](contact.md#BKMK_contact_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contact_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contract_msdyn_ocoutboundmessages"></a> contract_msdyn_ocoutboundmessages

One-To-Many Relationship: [contract contract_msdyn_ocoutboundmessages](contract.md#BKMK_contract_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_msdyn_ocoutboundmessages"></a> entitlement_msdyn_ocoutboundmessages

One-To-Many Relationship: [entitlement entitlement_msdyn_ocoutboundmessages](entitlement.md#BKMK_entitlement_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_msdyn_ocoutboundmessages"></a> entitlementtemplate_msdyn_ocoutboundmessages

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_msdyn_ocoutboundmessages](entitlementtemplate.md#BKMK_entitlementtemplate_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_msdyn_ocoutboundmessages"></a> incident_msdyn_ocoutboundmessages

One-To-Many Relationship: [incident incident_msdyn_ocoutboundmessages](incident.md#BKMK_incident_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_interactionforemail_msdyn_ocoutboundmessages"></a> interactionforemail_msdyn_ocoutboundmessages

One-To-Many Relationship: [interactionforemail interactionforemail_msdyn_ocoutboundmessages](interactionforemail.md#BKMK_interactionforemail_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`interactionforemail`|
|ReferencedAttribute|`interactionforemailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_new_interactionforemail_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_invoice_msdyn_ocoutboundmessages"></a> invoice_msdyn_ocoutboundmessages

One-To-Many Relationship: [invoice invoice_msdyn_ocoutboundmessages](invoice.md#BKMK_invoice_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgearticle_msdyn_ocoutboundmessages"></a> knowledgearticle_msdyn_ocoutboundmessages

One-To-Many Relationship: [knowledgearticle knowledgearticle_msdyn_ocoutboundmessages](knowledgearticle.md#BKMK_knowledgearticle_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgearticle`|
|ReferencedAttribute|`knowledgearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgearticle_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgebaserecord_msdyn_ocoutboundmessages"></a> knowledgebaserecord_msdyn_ocoutboundmessages

One-To-Many Relationship: [knowledgebaserecord knowledgebaserecord_msdyn_ocoutboundmessages](knowledgebaserecord.md#BKMK_knowledgebaserecord_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgebaserecord`|
|ReferencedAttribute|`knowledgebaserecordid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgebaserecord_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_msdyn_ocoutboundmessages"></a> lead_msdyn_ocoutboundmessages

One-To-Many Relationship: [lead lead_msdyn_ocoutboundmessages](lead.md#BKMK_lead_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreement_msdyn_ocoutboundmessages"></a> msdyn_agreement_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_msdyn_ocoutboundmessages](msdyn_agreement.md#BKMK_msdyn_agreement_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_msdyn_ocoutboundmessages"></a> msdyn_agreementbookingdate_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_msdyn_ocoutboundmessages](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_msdyn_ocoutboundmessages"></a> msdyn_agreementbookingincident_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_msdyn_ocoutboundmessages](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_msdyn_ocoutboundmessages"></a> msdyn_agreementbookingproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_msdyn_ocoutboundmessages](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_ocoutboundmessages"></a> msdyn_agreementbookingservice_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_msdyn_ocoutboundmessages](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_msdyn_ocoutboundmessages"></a> msdyn_agreementbookingservicetask_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_msdyn_ocoutboundmessages](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_ocoutboundmessages"></a> msdyn_agreementbookingsetup_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_msdyn_ocoutboundmessages](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_msdyn_ocoutboundmessages"></a> msdyn_agreementinvoicedate_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_msdyn_ocoutboundmessages](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_msdyn_ocoutboundmessages"></a> msdyn_agreementinvoiceproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_msdyn_ocoutboundmessages](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_ocoutboundmessages"></a> msdyn_agreementinvoicesetup_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_msdyn_ocoutboundmessages](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_ocoutboundmessages"></a> msdyn_bookingalertstatus_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msdyn_ocoutboundmessages](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msdyn_ocoutboundmessages"></a> msdyn_bookingrule_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msdyn_ocoutboundmessages](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_ocoutboundmessages"></a> msdyn_bookingtimestamp_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_msdyn_ocoutboundmessages](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_msdyn_ocoutboundmessages"></a> msdyn_customerasset_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_msdyn_ocoutboundmessages](msdyn_customerasset.md#BKMK_msdyn_customerasset_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_msdyn_ocoutboundmessages"></a> msdyn_fieldservicesetting_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_msdyn_ocoutboundmessages](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_msdyn_ocoutboundmessages"></a> msdyn_incidenttypecharacteristic_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_msdyn_ocoutboundmessages](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_ocoutboundmessages"></a> msdyn_incidenttypeproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_msdyn_ocoutboundmessages](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_ocoutboundmessages"></a> msdyn_incidenttypeservice_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_msdyn_ocoutboundmessages](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_ocoutboundmessages"></a> msdyn_inventoryadjustment_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_msdyn_ocoutboundmessages](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocoutboundmessages"></a> msdyn_inventoryadjustmentproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_msdyn_ocoutboundmessages](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_msdyn_ocoutboundmessages"></a> msdyn_inventoryjournal_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_msdyn_ocoutboundmessages](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_msdyn_ocoutboundmessages"></a> msdyn_inventorytransfer_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_msdyn_ocoutboundmessages](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_businessunit_owningbusinessunit"></a> msdyn_ocoutboundmessage_businessunit_owningbusinessunit

One-To-Many Relationship: [businessunit msdyn_ocoutboundmessage_businessunit_owningbusinessunit](businessunit.md#BKMK_msdyn_ocoutboundmessage_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_mailbox_sendermailboxid"></a> msdyn_ocoutboundmessage_mailbox_sendermailboxid

One-To-Many Relationship: [mailbox msdyn_ocoutboundmessage_mailbox_sendermailboxid](mailbox.md#BKMK_msdyn_ocoutboundmessage_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencedEntity|`mailbox`|
|ReferencedAttribute|`mailboxid`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencingEntityNavigationPropertyName|`sendermailboxid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_msdyn_ocoutbound"></a> msdyn_ocoutboundmessage_msdyn_ocoutbound

One-To-Many Relationship: [msdyn_ocoutboundconfiguration msdyn_ocoutboundmessage_msdyn_ocoutbound](msdyn_ocoutboundconfiguration.md#BKMK_msdyn_ocoutboundmessage_msdyn_ocoutbound)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundconfiguration`|
|ReferencedAttribute|`msdyn_ocoutboundconfigurationid`|
|ReferencingAttribute|`msdyn_ocoutboundconfiguration`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocoutboundconfiguration_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_occustomerlocale"></a> msdyn_ocoutboundmessage_occustomerlocale

One-To-Many Relationship: [msdyn_oclanguage msdyn_ocoutboundmessage_occustomerlocale](msdyn_oclanguage.md#BKMK_msdyn_ocoutboundmessage_occustomerlocale)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_occustomerlocale`|
|ReferencingEntityNavigationPropertyName|`msdyn_occustomerlocale_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_ocliveworkstream"></a> msdyn_ocoutboundmessage_ocliveworkstream

One-To-Many Relationship: [msdyn_liveworkstream msdyn_ocoutboundmessage_ocliveworkstream](msdyn_liveworkstream.md#BKMK_msdyn_ocoutboundmessage_ocliveworkstream)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_ocliveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocliveworkstreamid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_owner_ownerid"></a> msdyn_ocoutboundmessage_owner_ownerid

One-To-Many Relationship: [owner msdyn_ocoutboundmessage_owner_ownerid](owner.md#BKMK_msdyn_ocoutboundmessage_owner_ownerid)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_service_serviceid"></a> msdyn_ocoutboundmessage_service_serviceid

One-To-Many Relationship: [service msdyn_ocoutboundmessage_service_serviceid](service.md#BKMK_msdyn_ocoutboundmessage_service_serviceid)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_sla_slaid"></a> msdyn_ocoutboundmessage_sla_slaid

One-To-Many Relationship: [sla msdyn_ocoutboundmessage_sla_slaid](sla.md#BKMK_msdyn_ocoutboundmessage_sla_slaid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_activitypointer_sla_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_sla_slainvokedid"></a> msdyn_ocoutboundmessage_sla_slainvokedid

One-To-Many Relationship: [sla msdyn_ocoutboundmessage_sla_slainvokedid](sla.md#BKMK_msdyn_ocoutboundmessage_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_activitypointer_sla_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_systemuser_createdby"></a> msdyn_ocoutboundmessage_systemuser_createdby

One-To-Many Relationship: [systemuser msdyn_ocoutboundmessage_systemuser_createdby](systemuser.md#BKMK_msdyn_ocoutboundmessage_systemuser_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_systemuser_createdonbehalfby"></a> msdyn_ocoutboundmessage_systemuser_createdonbehalfby

One-To-Many Relationship: [systemuser msdyn_ocoutboundmessage_systemuser_createdonbehalfby](systemuser.md#BKMK_msdyn_ocoutboundmessage_systemuser_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_systemuser_modifiedby"></a> msdyn_ocoutboundmessage_systemuser_modifiedby

One-To-Many Relationship: [systemuser msdyn_ocoutboundmessage_systemuser_modifiedby](systemuser.md#BKMK_msdyn_ocoutboundmessage_systemuser_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_systemuser_modifiedonbehalfby"></a> msdyn_ocoutboundmessage_systemuser_modifiedonbehalfby

One-To-Many Relationship: [systemuser msdyn_ocoutboundmessage_systemuser_modifiedonbehalfby](systemuser.md#BKMK_msdyn_ocoutboundmessage_systemuser_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_systemuser_owninguser"></a> msdyn_ocoutboundmessage_systemuser_owninguser

One-To-Many Relationship: [systemuser msdyn_ocoutboundmessage_systemuser_owninguser](systemuser.md#BKMK_msdyn_ocoutboundmessage_systemuser_owninguser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_team_owningteam"></a> msdyn_ocoutboundmessage_team_owningteam

One-To-Many Relationship: [team msdyn_ocoutboundmessage_team_owningteam](team.md#BKMK_msdyn_ocoutboundmessage_team_owningteam)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid"></a> msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_msdyn_ocoutboundmessages"></a> msdyn_payment_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_payment msdyn_payment_msdyn_ocoutboundmessages](msdyn_payment.md#BKMK_msdyn_payment_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_msdyn_ocoutboundmessages"></a> msdyn_paymentdetail_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_msdyn_ocoutboundmessages](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_msdyn_ocoutboundmessages"></a> msdyn_paymentmethod_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_msdyn_ocoutboundmessages](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_msdyn_ocoutboundmessages"></a> msdyn_paymentterm_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_msdyn_ocoutboundmessages](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_msdyn_ocoutboundmessages"></a> msdyn_playbookinstance_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_msdyn_ocoutboundmessages](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_msdyn_ocoutboundmessages"></a> msdyn_postalbum_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_msdyn_ocoutboundmessages](msdyn_postalbum.md#BKMK_msdyn_postalbum_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_msdyn_ocoutboundmessages"></a> msdyn_postalcode_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_msdyn_ocoutboundmessages](msdyn_postalcode.md#BKMK_msdyn_postalcode_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_msdyn_ocoutboundmessages"></a> msdyn_productinventory_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_msdyn_ocoutboundmessages](msdyn_productinventory.md#BKMK_msdyn_productinventory_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_msdyn_ocoutboundmessages"></a> msdyn_purchaseorder_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_msdyn_ocoutboundmessages](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_msdyn_ocoutboundmessages"></a> msdyn_purchaseorderbill_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_msdyn_ocoutboundmessages](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_msdyn_ocoutboundmessages"></a> msdyn_purchaseorderproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_msdyn_ocoutboundmessages](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_ocoutboundmessages"></a> msdyn_purchaseorderreceipt_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_msdyn_ocoutboundmessages](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocoutboundmessages"></a> msdyn_purchaseorderreceiptproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_msdyn_ocoutboundmessages](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages"></a> msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_msdyn_ocoutboundmessages"></a> msdyn_quotebookingincident_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_msdyn_ocoutboundmessages](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_ocoutboundmessages"></a> msdyn_quotebookingproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_msdyn_ocoutboundmessages](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_msdyn_ocoutboundmessages"></a> msdyn_quotebookingservice_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_msdyn_ocoutboundmessages](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_ocoutboundmessages"></a> msdyn_quotebookingservicetask_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_msdyn_ocoutboundmessages](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_msdyn_ocoutboundmessages"></a> msdyn_resourceterritory_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msdyn_ocoutboundmessages](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_msdyn_ocoutboundmessages"></a> msdyn_rma_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_rma msdyn_rma_msdyn_ocoutboundmessages](msdyn_rma.md#BKMK_msdyn_rma_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_msdyn_ocoutboundmessages"></a> msdyn_rmaproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_msdyn_ocoutboundmessages](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_msdyn_ocoutboundmessages"></a> msdyn_rmareceipt_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_msdyn_ocoutboundmessages](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_ocoutboundmessages"></a> msdyn_rmareceiptproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_msdyn_ocoutboundmessages](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_msdyn_ocoutboundmessages"></a> msdyn_rmasubstatus_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_msdyn_ocoutboundmessages](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_msdyn_ocoutboundmessages"></a> msdyn_rtv_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_msdyn_ocoutboundmessages](msdyn_rtv.md#BKMK_msdyn_rtv_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_msdyn_ocoutboundmessages"></a> msdyn_rtvproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_msdyn_ocoutboundmessages](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_ocoutboundmessages"></a> msdyn_rtvsubstatus_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_msdyn_ocoutboundmessages](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_msdyn_ocoutboundmessages"></a> msdyn_salessuggestion_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_msdyn_ocoutboundmessages](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_msdyn_ocoutboundmessages"></a> msdyn_shipvia_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_msdyn_ocoutboundmessages](msdyn_shipvia.md#BKMK_msdyn_shipvia_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_msdyn_ocoutboundmessages"></a> msdyn_swarm_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_msdyn_ocoutboundmessages](msdyn_swarm.md#BKMK_msdyn_swarm_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_ocoutboundmessages"></a> msdyn_systemuserschedulersetting_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msdyn_ocoutboundmessages](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msdyn_ocoutboundmessages"></a> msdyn_timegroup_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msdyn_ocoutboundmessages](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_ocoutboundmessages"></a> msdyn_timegroupdetail_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msdyn_ocoutboundmessages](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_msdyn_ocoutboundmessages"></a> msdyn_timeoffrequest_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_msdyn_ocoutboundmessages](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_msdyn_ocoutboundmessages"></a> msdyn_warehouse_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_msdyn_ocoutboundmessages](msdyn_warehouse.md#BKMK_msdyn_warehouse_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_msdyn_ocoutboundmessages"></a> msdyn_workorder_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_msdyn_ocoutboundmessages](msdyn_workorder.md#BKMK_msdyn_workorder_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_msdyn_ocoutboundmessages"></a> msdyn_workordercharacteristic_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_msdyn_ocoutboundmessages](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_msdyn_ocoutboundmessages"></a> msdyn_workorderincident_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_msdyn_ocoutboundmessages](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_msdyn_ocoutboundmessages"></a> msdyn_workorderproduct_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_msdyn_ocoutboundmessages](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_ocoutboundmessages"></a> msdyn_workorderresourcerestriction_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_msdyn_ocoutboundmessages](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_msdyn_ocoutboundmessages"></a> msdyn_workorderservice_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_msdyn_ocoutboundmessages](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_msdyn_ocoutboundmessages"></a> msdyn_workorderservicetask_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_msdyn_ocoutboundmessages](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_msdyn_ocoutboundmessages"></a> msdyncrm_contentsettings_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_msdyn_ocoutboundmessages](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_msdyn_ocoutboundmessages"></a> msdyncrm_customerjourney_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_msdyn_ocoutboundmessages](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_msdyn_ocoutboundmessages"></a> msdyncrm_leadscoremodel_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_msdyn_ocoutboundmessages](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinaccount_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_msdyn_ocoutboundmessages](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinactivity_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_msdyn_ocoutboundmessages](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinform_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_msdyn_ocoutboundmessages](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinformanswer_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_msdyn_ocoutboundmessages](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinformquestion_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_msdyn_ocoutboundmessages](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinleadmatchingstrategy_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_msdyn_ocoutboundmessages](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinuserprofile_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_msdyn_ocoutboundmessages](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages"></a> msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocoutboundmessages"></a> msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocoutboundmessages](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages"></a> msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_msdyn_ocoutboundmessages"></a> msdyncrm_migration_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_msdyn_ocoutboundmessages](msdyncrm_migration.md#BKMK_msdyncrm_migration_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_uicconfig_msdyn_ocoutboundmessages"></a> msdyncrm_uicconfig_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_msdyn_ocoutboundmessages](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_checkin_msdyn_ocoutboundmessages"></a> msevtmgt_checkin_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_msdyn_ocoutboundmessages](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_msdyn_ocoutboundmessages"></a> msevtmgt_event_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_msdyn_ocoutboundmessages](msevtmgt_event.md#BKMK_msevtmgt_event_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_msdyn_ocoutboundmessages"></a> msevtmgt_eventpurchase_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_msdyn_ocoutboundmessages](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages"></a> msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages"></a> msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_msdyn_ocoutboundmessages"></a> msevtmgt_eventregistration_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_msdyn_ocoutboundmessages](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_msdyn_ocoutboundmessages"></a> msevtmgt_hotel_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_msdyn_ocoutboundmessages](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages"></a> msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_msdyn_ocoutboundmessages"></a> msevtmgt_hotelroomreservation_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_msdyn_ocoutboundmessages](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_msdyn_ocoutboundmessages"></a> msevtmgt_layout_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_msdyn_ocoutboundmessages](msevtmgt_layout.md#BKMK_msevtmgt_layout_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_msdyn_ocoutboundmessages"></a> msevtmgt_room_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_msdyn_ocoutboundmessages](msevtmgt_room.md#BKMK_msevtmgt_room_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_msdyn_ocoutboundmessages"></a> msevtmgt_session_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_msdyn_ocoutboundmessages](msevtmgt_session.md#BKMK_msevtmgt_session_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_msdyn_ocoutboundmessages"></a> msevtmgt_sessionregistration_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_msdyn_ocoutboundmessages](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_msdyn_ocoutboundmessages"></a> msevtmgt_sessiontrack_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_msdyn_ocoutboundmessages](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_msdyn_ocoutboundmessages"></a> msevtmgt_speaker_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_msdyn_ocoutboundmessages](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_msdyn_ocoutboundmessages"></a> msevtmgt_speakerengagement_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_msdyn_ocoutboundmessages](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages"></a> msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_msdyn_ocoutboundmessages"></a> msevtmgt_sponsorship_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_msdyn_ocoutboundmessages](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_msdyn_ocoutboundmessages"></a> msevtmgt_venue_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_msdyn_ocoutboundmessages](msevtmgt_venue.md#BKMK_msevtmgt_venue_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages"></a> msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_msdyn_ocoutboundmessages"></a> msevtmgt_webinarprovider_msdyn_ocoutboundmessages

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_msdyn_ocoutboundmessages](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_adplacement_msdyn_ocoutboundmessages"></a> mspp_adplacement_msdyn_ocoutboundmessages

One-To-Many Relationship: [mspp_adplacement mspp_adplacement_msdyn_ocoutboundmessages](mspp_adplacement.md#BKMK_mspp_adplacement_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_adplacement`|
|ReferencedAttribute|`mspp_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_adplacement_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_pollplacement_msdyn_ocoutboundmessages"></a> mspp_pollplacement_msdyn_ocoutboundmessages

One-To-Many Relationship: [mspp_pollplacement mspp_pollplacement_msdyn_ocoutboundmessages](mspp_pollplacement.md#BKMK_mspp_pollplacement_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_pollplacement`|
|ReferencedAttribute|`mspp_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_pollplacement_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_publishingstatetransitionrule_msdyn_ocoutboundmessages"></a> mspp_publishingstatetransitionrule_msdyn_ocoutboundmessages

One-To-Many Relationship: [mspp_publishingstatetransitionrule mspp_publishingstatetransitionrule_msdyn_ocoutboundmessages](mspp_publishingstatetransitionrule.md#BKMK_mspp_publishingstatetransitionrule_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_publishingstatetransitionrule`|
|ReferencedAttribute|`mspp_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_publishingstatetransitionrule_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_redirect_msdyn_ocoutboundmessages"></a> mspp_redirect_msdyn_ocoutboundmessages

One-To-Many Relationship: [mspp_redirect mspp_redirect_msdyn_ocoutboundmessages](mspp_redirect.md#BKMK_mspp_redirect_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_redirect`|
|ReferencedAttribute|`mspp_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_redirect_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_shortcut_msdyn_ocoutboundmessages"></a> mspp_shortcut_msdyn_ocoutboundmessages

One-To-Many Relationship: [mspp_shortcut mspp_shortcut_msdyn_ocoutboundmessages](mspp_shortcut.md#BKMK_mspp_shortcut_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_shortcut`|
|ReferencedAttribute|`mspp_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_shortcut_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_website_msdyn_ocoutboundmessages"></a> mspp_website_msdyn_ocoutboundmessages

One-To-Many Relationship: [mspp_website mspp_website_msdyn_ocoutboundmessages](mspp_website.md#BKMK_mspp_website_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_website`|
|ReferencedAttribute|`mspp_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_website_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_msdyn_ocoutboundmessages"></a> opportunity_msdyn_ocoutboundmessages

One-To-Many Relationship: [opportunity opportunity_msdyn_ocoutboundmessages](opportunity.md#BKMK_opportunity_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_quote_msdyn_ocoutboundmessages"></a> quote_msdyn_ocoutboundmessages

One-To-Many Relationship: [quote quote_msdyn_ocoutboundmessages](quote.md#BKMK_quote_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_salesorder_msdyn_ocoutboundmessages"></a> salesorder_msdyn_ocoutboundmessages

One-To-Many Relationship: [salesorder salesorder_msdyn_ocoutboundmessages](salesorder.md#BKMK_salesorder_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_site_msdyn_ocoutboundmessages"></a> site_msdyn_ocoutboundmessages

One-To-Many Relationship: [site site_msdyn_ocoutboundmessages](site.md#BKMK_site_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [CampaignResponse_msdyn_ocoutboundmessages](#BKMK_CampaignResponse_msdyn_ocoutboundmessages)
- [msdyn_ocoutboundmessage_ActionCards](#BKMK_msdyn_ocoutboundmessage_ActionCards)
- [msdyn_ocoutboundmessage_activity_parties](#BKMK_msdyn_ocoutboundmessage_activity_parties)
- [msdyn_ocoutboundmessage_Annotations](#BKMK_msdyn_ocoutboundmessage_Annotations)
- [msdyn_ocoutboundmessage_AsyncOperations](#BKMK_msdyn_ocoutboundmessage_AsyncOperations)
- [msdyn_ocoutboundmessage_BulkDeleteFailures](#BKMK_msdyn_ocoutboundmessage_BulkDeleteFailures)
- [msdyn_ocoutboundmessage_connections1](#BKMK_msdyn_ocoutboundmessage_connections1)
- [msdyn_ocoutboundmessage_connections2](#BKMK_msdyn_ocoutboundmessage_connections2)
- [msdyn_ocoutboundmessage_DuplicateBaseRecord](#BKMK_msdyn_ocoutboundmessage_DuplicateBaseRecord)
- [msdyn_ocoutboundmessage_DuplicateMatchingRecord](#BKMK_msdyn_ocoutboundmessage_DuplicateMatchingRecord)
- [msdyn_ocoutboundmessage_Feedback](#BKMK_msdyn_ocoutboundmessage_Feedback)
- [msdyn_ocoutboundmessage_MailboxTrackingFolders](#BKMK_msdyn_ocoutboundmessage_MailboxTrackingFolders)
- [msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses)
- [msdyn_ocoutboundmessage_ProcessSession](#BKMK_msdyn_ocoutboundmessage_ProcessSession)
- [msdyn_ocoutboundmessage_QueueItems](#BKMK_msdyn_ocoutboundmessage_QueueItems)
- [msdyn_ocoutboundmessage_SyncErrors](#BKMK_msdyn_ocoutboundmessage_SyncErrors)

### <a name="BKMK_CampaignResponse_msdyn_ocoutboundmessages"></a> CampaignResponse_msdyn_ocoutboundmessages

Many-To-One Relationship: [campaignresponse CampaignResponse_msdyn_ocoutboundmessages](campaignresponse.md#BKMK_CampaignResponse_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_ActionCards"></a> msdyn_ocoutboundmessage_ActionCards

Many-To-One Relationship: [actioncard msdyn_ocoutboundmessage_ActionCards](actioncard.md#BKMK_msdyn_ocoutboundmessage_ActionCards)

|Property|Value|
|---|---|
|ReferencingEntity|`actioncard`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_ActionCards`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_activity_parties"></a> msdyn_ocoutboundmessage_activity_parties

Many-To-One Relationship: [activityparty msdyn_ocoutboundmessage_activity_parties](activityparty.md#BKMK_msdyn_ocoutboundmessage_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_activity_parties`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_Annotations"></a> msdyn_ocoutboundmessage_Annotations

Many-To-One Relationship: [annotation msdyn_ocoutboundmessage_Annotations](annotation.md#BKMK_msdyn_ocoutboundmessage_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_AsyncOperations"></a> msdyn_ocoutboundmessage_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocoutboundmessage_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocoutboundmessage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_BulkDeleteFailures"></a> msdyn_ocoutboundmessage_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocoutboundmessage_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocoutboundmessage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_connections1"></a> msdyn_ocoutboundmessage_connections1

Many-To-One Relationship: [connection msdyn_ocoutboundmessage_connections1](connection.md#BKMK_msdyn_ocoutboundmessage_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_connections2"></a> msdyn_ocoutboundmessage_connections2

Many-To-One Relationship: [connection msdyn_ocoutboundmessage_connections2](connection.md#BKMK_msdyn_ocoutboundmessage_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_DuplicateBaseRecord"></a> msdyn_ocoutboundmessage_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocoutboundmessage_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocoutboundmessage_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_DuplicateMatchingRecord"></a> msdyn_ocoutboundmessage_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocoutboundmessage_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocoutboundmessage_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_Feedback"></a> msdyn_ocoutboundmessage_Feedback

Many-To-One Relationship: [feedback msdyn_ocoutboundmessage_Feedback](feedback.md#BKMK_msdyn_ocoutboundmessage_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_MailboxTrackingFolders"></a> msdyn_ocoutboundmessage_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocoutboundmessage_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocoutboundmessage_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses"></a> msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_ProcessSession"></a> msdyn_ocoutboundmessage_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocoutboundmessage_ProcessSession](processsession.md#BKMK_msdyn_ocoutboundmessage_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_QueueItems"></a> msdyn_ocoutboundmessage_QueueItems

Many-To-One Relationship: [queueitem msdyn_ocoutboundmessage_QueueItems](queueitem.md#BKMK_msdyn_ocoutboundmessage_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_SyncErrors"></a> msdyn_ocoutboundmessage_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocoutboundmessage_SyncErrors](syncerror.md#BKMK_msdyn_ocoutboundmessage_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

