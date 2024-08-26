---
title: "Ongoing conversation (Deprecated) (msdyn_liveconversation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Ongoing conversation (Deprecated) (msdyn_liveconversation) table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Ongoing conversation (Deprecated) (msdyn_liveconversation) table/entity reference

Tracks the interactions between the agents and customer

## Messages

The following table lists the messages for the Ongoing conversation (Deprecated) (msdyn_liveconversation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_liveconversations(*msdyn_liveconversationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_liveconversations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_liveconversations(*msdyn_liveconversationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_liveconversations(*msdyn_liveconversationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_liveconversations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_liveconversations(*msdyn_liveconversationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_liveconversations(*msdyn_liveconversationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_liveconversations(*msdyn_liveconversationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Ongoing conversation (Deprecated) (msdyn_liveconversation) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Ongoing conversation (Deprecated) (msdyn_liveconversation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Ongoing conversation (Deprecated)** |
| **DisplayCollectionName** | **Ongoing conversations (Deprecated)** |
| **SchemaName** | `msdyn_liveconversation` |
| **CollectionSchemaName** | `msdyn_liveconversations` |
| **EntitySetName** | `msdyn_liveconversations`|
| **LogicalName** | `msdyn_liveconversation` |
| **LogicalCollectionName** | `msdyn_liveconversations` |
| **PrimaryIdAttribute** | `msdyn_liveconversationid` |
| **PrimaryNameAttribute** |`msdyn_subject` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activeagentassignedon](#BKMK_msdyn_activeagentassignedon)
- [msdyn_activeagentid](#BKMK_msdyn_activeagentid)
- [msdyn_cdsqueueid](#BKMK_msdyn_cdsqueueid)
- [msdyn_channel](#BKMK_msdyn_channel)
- [msdyn_closedon](#BKMK_msdyn_closedon)
- [msdyn_createdon](#BKMK_msdyn_createdon)
- [msdyn_customer](#BKMK_msdyn_customer)
- [msdyn_customerIdType](#BKMK_msdyn_customerIdType)
- [msdyn_customersentimentlabel](#BKMK_msdyn_customersentimentlabel)
- [msdyn_escalationcount](#BKMK_msdyn_escalationcount)
- [msdyn_initiatedon](#BKMK_msdyn_initiatedon)
- [msdyn_liveconversationId](#BKMK_msdyn_liveconversationId)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_modifiedon](#BKMK_msdyn_modifiedon)
- [msdyn_oclastsessionid](#BKMK_msdyn_oclastsessionid)
- [msdyn_queueid](#BKMK_msdyn_queueid)
- [msdyn_startedon](#BKMK_msdyn_startedon)
- [msdyn_statecode](#BKMK_msdyn_statecode)
- [msdyn_statuscode](#BKMK_msdyn_statuscode)
- [msdyn_statusupdatedon](#BKMK_msdyn_statusupdatedon)
- [msdyn_subject](#BKMK_msdyn_subject)
- [msdyn_title](#BKMK_msdyn_title)
- [msdyn_transfercount](#BKMK_msdyn_transfercount)
- [msdyn_workstreamworkdistributionmode](#BKMK_msdyn_workstreamworkdistributionmode)
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
|Description|**Last agent assigned to the conversation**|
|DisplayName|**Active Agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activeagentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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
|192350000|**Entity Records**|

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

### <a name="BKMK_msdyn_createdon"></a> msdyn_createdon

|Property|Value|
|---|---|
|Description|**Date and time when conversation was created**|
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
|Description|**Customer associated to the conversation**|
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
|GlobalChoiceName|`msdyn_liveconversation_msdyn_customersentimentlabel`|

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

### <a name="BKMK_msdyn_liveconversationId"></a> msdyn_liveconversationId

|Property|Value|
|---|---|
|Description|**Id of this ongoing conversation record**|
|DisplayName|**OngoingConversationId (Deprecated)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_liveconversationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdyn_oclastsessionid"></a> msdyn_oclastsessionid

|Property|Value|
|---|---|
|Description|**Last agent session**|
|DisplayName|**Last session Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_oclastsessionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyn_statecode"></a> msdyn_statecode

|Property|Value|
|---|---|
|Description|**State of the conversation record**|
|DisplayName|**State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversation_statecode`|

#### msdyn_statecode Choices/Options

|Value|Label|
|---|---|
|0|**Open**|
|1|**Active**|
|2|**Waiting**|
|3|**Closed**|
|4|**Wrap-up**|

### <a name="BKMK_msdyn_statuscode"></a> msdyn_statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of Ongoing conversation record**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statuscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversation_statuscode`|

#### msdyn_statuscode Choices/Options

|Value|Label|
|---|---|
|1|**Open**|
|2|**Active**|
|3|**Waiting**|
|4|**Closed**|
|5|**Wrap-up**|

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

### <a name="BKMK_msdyn_subject"></a> msdyn_subject

|Property|Value|
|---|---|
|Description|**Subject associated with the conversation record**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subject`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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
|Description|**Unique identifier of the user or team who owns the conversation record.**|
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
|Description|**Status of the Ongoing conversation record**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_liveconversation_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Active**<br />DefaultStatus: 2<br />InvariantName: `Active`|
|2|Label: **Waiting**<br />DefaultStatus: 3<br />InvariantName: `Waiting`|
|3|Label: **Closed**<br />DefaultStatus: 4<br />InvariantName: `Closed`|
|4|Label: **Wrap-up**<br />DefaultStatus: 5<br />InvariantName: `Wrap-up`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of Ongoing conversation record**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_liveconversation_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Open**<br />State:0<br />TransitionData: None|
|2|Label: **Active**<br />State:1<br />TransitionData: None|
|3|Label: **Waiting**<br />State:2<br />TransitionData: None|
|4|Label: **Closed**<br />State:3<br />TransitionData: None|
|5|Label: **Wrap-up**<br />State:4<br />TransitionData: None|

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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_customerName](#BKMK_msdyn_customerName)
- [msdyn_customerYomiName](#BKMK_msdyn_customerYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the Ongoing Conversation.**|
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
|Description|**Date and time when the Ongoing Conversation was created.**|
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
|Description|**Unique identifier of the delegate user who created the Ongoing Conversation.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of user who last modified the Ongoing Conversation.**|
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
|Description|**Date and time when Ongoing Conversation was last modified.**|
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
|Description|**Unique identifier of the delegate user who last modified the Ongoing Conversation.**|
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
|Description|**Unique identifier of the business unit that owns the Ongoing Conversation.**|
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
|Description|**Unique identifier of the team that owns the Ongoing Conversation.**|
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
|Description|**Unique identifier of the user that owns the Ongoing Conversation.**|
|DisplayName|**Owning User**|
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

- [business_unit_msdyn_liveconversation](#BKMK_business_unit_msdyn_liveconversation)
- [lk_msdyn_liveconversation_createdby](#BKMK_lk_msdyn_liveconversation_createdby)
- [lk_msdyn_liveconversation_createdonbehalfby](#BKMK_lk_msdyn_liveconversation_createdonbehalfby)
- [lk_msdyn_liveconversation_modifiedby](#BKMK_lk_msdyn_liveconversation_modifiedby)
- [lk_msdyn_liveconversation_modifiedonbehalfby](#BKMK_lk_msdyn_liveconversation_modifiedonbehalfby)
- [msdyn_account_msdyn_liveconversation_Customer](#BKMK_msdyn_account_msdyn_liveconversation_Customer)
- [msdyn_contact_msdyn_liveconversation_Customer](#BKMK_msdyn_contact_msdyn_liveconversation_Customer)
- [msdyn_msdyn_liveworkstream_msdyn_liveconversation](#BKMK_msdyn_msdyn_liveworkstream_msdyn_liveconversation)
- [msdyn_msdyn_omnichannelqueue_msdyn_liveconversation](#BKMK_msdyn_msdyn_omnichannelqueue_msdyn_liveconversation)
- [msdyn_queue_msdyn_liveconversation](#BKMK_msdyn_queue_msdyn_liveconversation)
- [msdyn_systemuser_msdyn_liveconversation](#BKMK_msdyn_systemuser_msdyn_liveconversation)
- [owner_msdyn_liveconversation](#BKMK_owner_msdyn_liveconversation)
- [team_msdyn_liveconversation](#BKMK_team_msdyn_liveconversation)
- [user_msdyn_liveconversation](#BKMK_user_msdyn_liveconversation)

### <a name="BKMK_business_unit_msdyn_liveconversation"></a> business_unit_msdyn_liveconversation

One-To-Many Relationship: [businessunit business_unit_msdyn_liveconversation](businessunit.md#BKMK_business_unit_msdyn_liveconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_liveconversation_createdby"></a> lk_msdyn_liveconversation_createdby

One-To-Many Relationship: [systemuser lk_msdyn_liveconversation_createdby](systemuser.md#BKMK_lk_msdyn_liveconversation_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_liveconversation_createdonbehalfby"></a> lk_msdyn_liveconversation_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_liveconversation_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_liveconversation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_liveconversation_modifiedby"></a> lk_msdyn_liveconversation_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_liveconversation_modifiedby](systemuser.md#BKMK_lk_msdyn_liveconversation_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_liveconversation_modifiedonbehalfby"></a> lk_msdyn_liveconversation_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_liveconversation_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_liveconversation_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_liveconversation_Customer"></a> msdyn_account_msdyn_liveconversation_Customer

One-To-Many Relationship: [account msdyn_account_msdyn_liveconversation_Customer](account.md#BKMK_msdyn_account_msdyn_liveconversation_Customer)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_customer`|
|ReferencingEntityNavigationPropertyName|`msdyn_customer_msdyn_liveconversation_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_contact_msdyn_liveconversation_Customer"></a> msdyn_contact_msdyn_liveconversation_Customer

One-To-Many Relationship: [contact msdyn_contact_msdyn_liveconversation_Customer](contact.md#BKMK_msdyn_contact_msdyn_liveconversation_Customer)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_customer`|
|ReferencingEntityNavigationPropertyName|`msdyn_customer_msdyn_liveconversation_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_liveworkstream_msdyn_liveconversation"></a> msdyn_msdyn_liveworkstream_msdyn_liveconversation

One-To-Many Relationship: [msdyn_liveworkstream msdyn_msdyn_liveworkstream_msdyn_liveconversation](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_liveworkstream_msdyn_liveconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_omnichannelqueue_msdyn_liveconversation"></a> msdyn_msdyn_omnichannelqueue_msdyn_liveconversation

One-To-Many Relationship: [msdyn_omnichannelqueue msdyn_msdyn_omnichannelqueue_msdyn_liveconversation](msdyn_omnichannelqueue.md#BKMK_msdyn_msdyn_omnichannelqueue_msdyn_liveconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_omnichannelqueue`|
|ReferencedAttribute|`msdyn_omnichannelqueueid`|
|ReferencingAttribute|`msdyn_queueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_queueid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_queue_msdyn_liveconversation"></a> msdyn_queue_msdyn_liveconversation

One-To-Many Relationship: [queue msdyn_queue_msdyn_liveconversation](queue.md#BKMK_msdyn_queue_msdyn_liveconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_cdsqueueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_cdsqueueid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_liveconversation"></a> msdyn_systemuser_msdyn_liveconversation

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_liveconversation](systemuser.md#BKMK_msdyn_systemuser_msdyn_liveconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_activeagentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_activeagentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_liveconversation"></a> owner_msdyn_liveconversation

One-To-Many Relationship: [owner owner_msdyn_liveconversation](owner.md#BKMK_owner_msdyn_liveconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_liveconversation"></a> team_msdyn_liveconversation

One-To-Many Relationship: [team team_msdyn_liveconversation](team.md#BKMK_team_msdyn_liveconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_liveconversation"></a> user_msdyn_liveconversation

One-To-Many Relationship: [systemuser user_msdyn_liveconversation](systemuser.md#BKMK_user_msdyn_liveconversation)

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

- [msdyn_liveconversation_Annotations](#BKMK_msdyn_liveconversation_Annotations)
- [msdyn_liveconversation_AsyncOperations](#BKMK_msdyn_liveconversation_AsyncOperations)
- [msdyn_liveconversation_BulkDeleteFailures](#BKMK_msdyn_liveconversation_BulkDeleteFailures)
- [msdyn_liveconversation_connections1](#BKMK_msdyn_liveconversation_connections1)
- [msdyn_liveconversation_connections2](#BKMK_msdyn_liveconversation_connections2)
- [msdyn_liveconversation_Feedback](#BKMK_msdyn_liveconversation_Feedback)
- [msdyn_liveconversation_MailboxTrackingFolders](#BKMK_msdyn_liveconversation_MailboxTrackingFolders)
- [msdyn_liveconversation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_liveconversation_PrincipalObjectAttributeAccesses)
- [msdyn_liveconversation_ProcessSession](#BKMK_msdyn_liveconversation_ProcessSession)
- [msdyn_liveconversation_QueueItems](#BKMK_msdyn_liveconversation_QueueItems)
- [msdyn_liveconversation_SyncErrors](#BKMK_msdyn_liveconversation_SyncErrors)

### <a name="BKMK_msdyn_liveconversation_Annotations"></a> msdyn_liveconversation_Annotations

Many-To-One Relationship: [annotation msdyn_liveconversation_Annotations](annotation.md#BKMK_msdyn_liveconversation_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_AsyncOperations"></a> msdyn_liveconversation_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_liveconversation_AsyncOperations](asyncoperation.md#BKMK_msdyn_liveconversation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_BulkDeleteFailures"></a> msdyn_liveconversation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_liveconversation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_liveconversation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_connections1"></a> msdyn_liveconversation_connections1

Many-To-One Relationship: [connection msdyn_liveconversation_connections1](connection.md#BKMK_msdyn_liveconversation_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_connections2"></a> msdyn_liveconversation_connections2

Many-To-One Relationship: [connection msdyn_liveconversation_connections2](connection.md#BKMK_msdyn_liveconversation_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_Feedback"></a> msdyn_liveconversation_Feedback

Many-To-One Relationship: [feedback msdyn_liveconversation_Feedback](feedback.md#BKMK_msdyn_liveconversation_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_MailboxTrackingFolders"></a> msdyn_liveconversation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_liveconversation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_liveconversation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_PrincipalObjectAttributeAccesses"></a> msdyn_liveconversation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_liveconversation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_liveconversation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_ProcessSession"></a> msdyn_liveconversation_ProcessSession

Many-To-One Relationship: [processsession msdyn_liveconversation_ProcessSession](processsession.md#BKMK_msdyn_liveconversation_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_QueueItems"></a> msdyn_liveconversation_QueueItems

Many-To-One Relationship: [queueitem msdyn_liveconversation_QueueItems](queueitem.md#BKMK_msdyn_liveconversation_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveconversation_SyncErrors"></a> msdyn_liveconversation_SyncErrors

Many-To-One Relationship: [syncerror msdyn_liveconversation_SyncErrors](syncerror.md#BKMK_msdyn_liveconversation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveconversation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

