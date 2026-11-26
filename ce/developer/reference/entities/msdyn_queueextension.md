---
title: "Queue Extension (msdyn_queueextension) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Queue Extension (msdyn_queueextension) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Queue Extension (msdyn_queueextension) table/entity reference (Microsoft Dynamics 365)

Queue extension entity for tracking queue and conversation metrics

## Messages

The following table lists the messages for the Queue Extension (msdyn_queueextension) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_queueextensions(*msdyn_queueextensionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_queueextensions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_queueextensions(*msdyn_queueextensionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_queueextensions(*msdyn_queueextensionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_queueextensions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_queueextensions(*msdyn_queueextensionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_queueextensions(*msdyn_queueextensionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_queueextensions(*msdyn_queueextensionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Queue Extension (msdyn_queueextension) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Queue Extension** |
| **DisplayCollectionName** | **Queue Extensions** |
| **SchemaName** | `msdyn_queueextension` |
| **CollectionSchemaName** | `msdyn_queueextensions` |
| **EntitySetName** | `msdyn_queueextensions`|
| **LogicalName** | `msdyn_queueextension` |
| **LogicalCollectionName** | `msdyn_queueextensions` |
| **PrimaryIdAttribute** | `msdyn_queueextensionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_ActiveChatTime](#BKMK_msdyn_ActiveChatTime)
- [msdyn_ActiveTime](#BKMK_msdyn_ActiveTime)
- [msdyn_ActiveWrapupTime](#BKMK_msdyn_ActiveWrapupTime)
- [msdyn_AgentAcceptedOn](#BKMK_msdyn_AgentAcceptedOn)
- [msdyn_AgentAssignedOn](#BKMK_msdyn_AgentAssignedOn)
- [msdyn_ClosedOn](#BKMK_msdyn_ClosedOn)
- [msdyn_ClosureReason](#BKMK_msdyn_ClosureReason)
- [msdyn_ConversationId](#BKMK_msdyn_ConversationId)
- [msdyn_CreationReason](#BKMK_msdyn_CreationReason)
- [msdyn_EndTime](#BKMK_msdyn_EndTime)
- [msdyn_firstwaitstartedon](#BKMK_msdyn_firstwaitstartedon)
- [msdyn_FirstWaitTimeInSeconds](#BKMK_msdyn_FirstWaitTimeInSeconds)
- [msdyn_HandleTime](#BKMK_msdyn_HandleTime)
- [msdyn_HoldTime](#BKMK_msdyn_HoldTime)
- [msdyn_InActiveTime](#BKMK_msdyn_InActiveTime)
- [msdyn_IsAbandoned](#BKMK_msdyn_IsAbandoned)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_queueextensionId](#BKMK_msdyn_queueextensionId)
- [msdyn_QueueId](#BKMK_msdyn_QueueId)
- [msdyn_SourceQueue](#BKMK_msdyn_SourceQueue)
- [msdyn_StartActiveTime](#BKMK_msdyn_StartActiveTime)
- [msdyn_StartActiveWrapupTime](#BKMK_msdyn_StartActiveWrapupTime)
- [msdyn_StartHoldTime](#BKMK_msdyn_StartHoldTime)
- [msdyn_StartInactiveTime](#BKMK_msdyn_StartInactiveTime)
- [msdyn_StartTalkTime](#BKMK_msdyn_StartTalkTime)
- [msdyn_StartTime](#BKMK_msdyn_StartTime)
- [msdyn_TalkTime](#BKMK_msdyn_TalkTime)
- [msdyn_TargetQueue](#BKMK_msdyn_TargetQueue)
- [msdyn_waitstartedon](#BKMK_msdyn_waitstartedon)
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

### <a name="BKMK_msdyn_ActiveChatTime"></a> msdyn_ActiveChatTime

|Property|Value|
|---|---|
|Description|**Active chat time in seconds**|
|DisplayName|**Active Chat Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activechattime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_ActiveTime"></a> msdyn_ActiveTime

|Property|Value|
|---|---|
|Description|**Active time in seconds**|
|DisplayName|**Active Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activetime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_ActiveWrapupTime"></a> msdyn_ActiveWrapupTime

|Property|Value|
|---|---|
|Description|**Active wrapup time in seconds**|
|DisplayName|**Active Wrapup Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activewrapuptime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_AgentAcceptedOn"></a> msdyn_AgentAcceptedOn

|Property|Value|
|---|---|
|Description|**Date and time when agent accepted**|
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

### <a name="BKMK_msdyn_AgentAssignedOn"></a> msdyn_AgentAssignedOn

|Property|Value|
|---|---|
|Description|**Date and time when agent was assigned**|
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

### <a name="BKMK_msdyn_ClosedOn"></a> msdyn_ClosedOn

|Property|Value|
|---|---|
|Description|**Date and time when closed**|
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

### <a name="BKMK_msdyn_ClosureReason"></a> msdyn_ClosureReason

|Property|Value|
|---|---|
|Description|**Reason for closure**|
|DisplayName|**Closure Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_closurereason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_ConversationId"></a> msdyn_ConversationId

|Property|Value|
|---|---|
|Description|**Lookup to conversation**|
|DisplayName|**Conversation Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_CreationReason"></a> msdyn_CreationReason

|Property|Value|
|---|---|
|Description|**Reason for creation**|
|DisplayName|**Creation Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_creationreason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_EndTime"></a> msdyn_EndTime

|Property|Value|
|---|---|
|Description|**End time**|
|DisplayName|**End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_firstwaitstartedon"></a> msdyn_firstwaitstartedon

|Property|Value|
|---|---|
|Description|**Date and time when the first wait period started for this queue segment**|
|DisplayName|**First Wait Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firstwaitstartedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_FirstWaitTimeInSeconds"></a> msdyn_FirstWaitTimeInSeconds

|Property|Value|
|---|---|
|Description|**First wait time in seconds**|
|DisplayName|**First Wait Time In Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firstwaittimeinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_HandleTime"></a> msdyn_HandleTime

|Property|Value|
|---|---|
|Description|**Handle time**|
|DisplayName|**Handle Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_handletime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_HoldTime"></a> msdyn_HoldTime

|Property|Value|
|---|---|
|Description|**Hold time in seconds**|
|DisplayName|**Hold Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_holdtime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_InActiveTime"></a> msdyn_InActiveTime

|Property|Value|
|---|---|
|Description|**Inactive time in seconds**|
|DisplayName|**Inactive Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inactivetime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_IsAbandoned"></a> msdyn_IsAbandoned

|Property|Value|
|---|---|
|Description|**Indicates if abandoned**|
|DisplayName|**Is Abandoned**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isabandoned`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_queueextension_msdyn_isabandoned`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description|**Name of the queue extension record**|
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

### <a name="BKMK_msdyn_queueextensionId"></a> msdyn_queueextensionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Queue Extension**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_queueextensionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_QueueId"></a> msdyn_QueueId

|Property|Value|
|---|---|
|Description|**Queue identifier**|
|DisplayName|**Queue Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queue|

### <a name="BKMK_msdyn_SourceQueue"></a> msdyn_SourceQueue

|Property|Value|
|---|---|
|Description|**Lookup to source queue**|
|DisplayName|**Source Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourcequeue`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queue|

### <a name="BKMK_msdyn_StartActiveTime"></a> msdyn_StartActiveTime

|Property|Value|
|---|---|
|Description|**Start active time for the queue extension segment**|
|DisplayName|**Start Active Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startactivetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_StartActiveWrapupTime"></a> msdyn_StartActiveWrapupTime

|Property|Value|
|---|---|
|Description|**Start active wrapup time for the queue extension segment**|
|DisplayName|**Start Active Wrapup Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startactivewrapuptime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_StartHoldTime"></a> msdyn_StartHoldTime

|Property|Value|
|---|---|
|Description|**Start hold time for the queue extension segment**|
|DisplayName|**Start Hold Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startholdtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_StartInactiveTime"></a> msdyn_StartInactiveTime

|Property|Value|
|---|---|
|Description|**Start inactive time for the queue extension segment**|
|DisplayName|**Start Inactive Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startinactivetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_StartTalkTime"></a> msdyn_StartTalkTime

|Property|Value|
|---|---|
|Description|**Start talk time for the queue extension segment**|
|DisplayName|**Start Talk Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_starttalktime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_StartTime"></a> msdyn_StartTime

|Property|Value|
|---|---|
|Description|**Start time**|
|DisplayName|**Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_starttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TalkTime"></a> msdyn_TalkTime

|Property|Value|
|---|---|
|Description|**Talk time in seconds**|
|DisplayName|**Talk Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_talktime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_TargetQueue"></a> msdyn_TargetQueue

|Property|Value|
|---|---|
|Description|**Lookup to target queue**|
|DisplayName|**Target Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetqueue`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queue|

### <a name="BKMK_msdyn_waitstartedon"></a> msdyn_waitstartedon

|Property|Value|
|---|---|
|Description|**Date and time when wait started**|
|DisplayName|**Wait Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_waitstartedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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
|Description|**Status of the Queue Extension**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_queueextension_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Queue Extension**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_queueextension_statuscode`|

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

- [business_unit_msdyn_queueextension](#BKMK_business_unit_msdyn_queueextension)
- [lk_msdyn_queueextension_createdby](#BKMK_lk_msdyn_queueextension_createdby)
- [lk_msdyn_queueextension_createdonbehalfby](#BKMK_lk_msdyn_queueextension_createdonbehalfby)
- [lk_msdyn_queueextension_modifiedby](#BKMK_lk_msdyn_queueextension_modifiedby)
- [lk_msdyn_queueextension_modifiedonbehalfby](#BKMK_lk_msdyn_queueextension_modifiedonbehalfby)
- [msdyn_ocliveworkitem_msdyn_queueextension_msdyn_conversationid](#BKMK_msdyn_ocliveworkitem_msdyn_queueextension_msdyn_conversationid)
- [owner_msdyn_queueextension](#BKMK_owner_msdyn_queueextension)
- [queue_msdyn_queueextension_msdyn_queueid](#BKMK_queue_msdyn_queueextension_msdyn_queueid)
- [queue_msdyn_queueextension_msdyn_sourcequeue](#BKMK_queue_msdyn_queueextension_msdyn_sourcequeue)
- [queue_msdyn_queueextension_msdyn_targetqueue](#BKMK_queue_msdyn_queueextension_msdyn_targetqueue)
- [team_msdyn_queueextension](#BKMK_team_msdyn_queueextension)
- [user_msdyn_queueextension](#BKMK_user_msdyn_queueextension)

### <a name="BKMK_business_unit_msdyn_queueextension"></a> business_unit_msdyn_queueextension

One-To-Many Relationship: [businessunit business_unit_msdyn_queueextension](businessunit.md#BKMK_business_unit_msdyn_queueextension)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_queueextension_createdby"></a> lk_msdyn_queueextension_createdby

One-To-Many Relationship: [systemuser lk_msdyn_queueextension_createdby](systemuser.md#BKMK_lk_msdyn_queueextension_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_queueextension_createdonbehalfby"></a> lk_msdyn_queueextension_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_queueextension_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_queueextension_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_queueextension_modifiedby"></a> lk_msdyn_queueextension_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_queueextension_modifiedby](systemuser.md#BKMK_lk_msdyn_queueextension_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_queueextension_modifiedonbehalfby"></a> lk_msdyn_queueextension_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_queueextension_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_queueextension_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_queueextension_msdyn_conversationid"></a> msdyn_ocliveworkitem_msdyn_queueextension_msdyn_conversationid

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_msdyn_queueextension_msdyn_conversationid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_msdyn_queueextension_msdyn_conversationid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_conversationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_conversationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_queueextension"></a> owner_msdyn_queueextension

One-To-Many Relationship: [owner owner_msdyn_queueextension](owner.md#BKMK_owner_msdyn_queueextension)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_queue_msdyn_queueextension_msdyn_queueid"></a> queue_msdyn_queueextension_msdyn_queueid

One-To-Many Relationship: [queue queue_msdyn_queueextension_msdyn_queueid](queue.md#BKMK_queue_msdyn_queueextension_msdyn_queueid)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_queueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_queueid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_queue_msdyn_queueextension_msdyn_sourcequeue"></a> queue_msdyn_queueextension_msdyn_sourcequeue

One-To-Many Relationship: [queue queue_msdyn_queueextension_msdyn_sourcequeue](queue.md#BKMK_queue_msdyn_queueextension_msdyn_sourcequeue)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_sourcequeue`|
|ReferencingEntityNavigationPropertyName|`msdyn_sourcequeue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_queue_msdyn_queueextension_msdyn_targetqueue"></a> queue_msdyn_queueextension_msdyn_targetqueue

One-To-Many Relationship: [queue queue_msdyn_queueextension_msdyn_targetqueue](queue.md#BKMK_queue_msdyn_queueextension_msdyn_targetqueue)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_targetqueue`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetqueue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_queueextension"></a> team_msdyn_queueextension

One-To-Many Relationship: [team team_msdyn_queueextension](team.md#BKMK_team_msdyn_queueextension)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_queueextension"></a> user_msdyn_queueextension

One-To-Many Relationship: [systemuser user_msdyn_queueextension](systemuser.md#BKMK_user_msdyn_queueextension)

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

- [msdyn_ocsession_msdyn_queueextension](#BKMK_msdyn_ocsession_msdyn_queueextension)
- [msdyn_queueextension_AsyncOperations](#BKMK_msdyn_queueextension_AsyncOperations)
- [msdyn_queueextension_BulkDeleteFailures](#BKMK_msdyn_queueextension_BulkDeleteFailures)
- [msdyn_queueextension_DuplicateBaseRecord](#BKMK_msdyn_queueextension_DuplicateBaseRecord)
- [msdyn_queueextension_DuplicateMatchingRecord](#BKMK_msdyn_queueextension_DuplicateMatchingRecord)
- [msdyn_queueextension_MailboxTrackingFolders](#BKMK_msdyn_queueextension_MailboxTrackingFolders)
- [msdyn_queueextension_PrincipalObjectAttributeAccesses](#BKMK_msdyn_queueextension_PrincipalObjectAttributeAccesses)
- [msdyn_queueextension_ProcessSession](#BKMK_msdyn_queueextension_ProcessSession)
- [msdyn_queueextension_SyncErrors](#BKMK_msdyn_queueextension_SyncErrors)

### <a name="BKMK_msdyn_ocsession_msdyn_queueextension"></a> msdyn_ocsession_msdyn_queueextension

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_msdyn_queueextension](msdyn_ocsession.md#BKMK_msdyn_ocsession_msdyn_queueextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`msdyn_queueextensionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_msdyn_queueextension`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queueextension_AsyncOperations"></a> msdyn_queueextension_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_queueextension_AsyncOperations](asyncoperation.md#BKMK_msdyn_queueextension_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueextension_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queueextension_BulkDeleteFailures"></a> msdyn_queueextension_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_queueextension_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_queueextension_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueextension_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queueextension_DuplicateBaseRecord"></a> msdyn_queueextension_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_queueextension_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_queueextension_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueextension_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queueextension_DuplicateMatchingRecord"></a> msdyn_queueextension_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_queueextension_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_queueextension_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueextension_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queueextension_MailboxTrackingFolders"></a> msdyn_queueextension_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_queueextension_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_queueextension_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueextension_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queueextension_PrincipalObjectAttributeAccesses"></a> msdyn_queueextension_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_queueextension_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_queueextension_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueextension_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queueextension_ProcessSession"></a> msdyn_queueextension_ProcessSession

Many-To-One Relationship: [processsession msdyn_queueextension_ProcessSession](processsession.md#BKMK_msdyn_queueextension_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueextension_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queueextension_SyncErrors"></a> msdyn_queueextension_SyncErrors

Many-To-One Relationship: [syncerror msdyn_queueextension_SyncErrors](syncerror.md#BKMK_msdyn_queueextension_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueextension_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

