---
title: "Conversation Participant Insights (msdyn_ConversationParticipantInsights) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Conversation Participant Insights (msdyn_ConversationParticipantInsights) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Conversation Participant Insights (msdyn_ConversationParticipantInsights) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Conversation Participant Insights (msdyn_ConversationParticipantInsights) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_conversationparticipantinsights<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_conversationparticipantinsights<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Conversation Participant Insights (msdyn_ConversationParticipantInsights) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Conversation Participant Insights** |
| **DisplayCollectionName** | **Conversation Participant Insights** |
| **SchemaName** | `msdyn_ConversationParticipantInsights` |
| **CollectionSchemaName** | `msdyn_ConversationParticipantInsightses` |
| **EntitySetName** | `msdyn_conversationparticipantinsights`|
| **LogicalName** | `msdyn_conversationparticipantinsights` |
| **LogicalCollectionName** | `msdyn_conversationparticipantinsightses` |
| **PrimaryIdAttribute** | `msdyn_conversationparticipantinsightsid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AadId](#BKMK_msdyn_AadId)
- [msdyn_AvgPauseBeforeSpeakingInMS](#BKMK_msdyn_AvgPauseBeforeSpeakingInMS)
- [msdyn_ChannelIndex](#BKMK_msdyn_ChannelIndex)
- [msdyn_ConversationAggregatedInsights](#BKMK_msdyn_ConversationAggregatedInsights)
- [msdyn_ConversationParticipantInsightsId](#BKMK_msdyn_ConversationParticipantInsightsId)
- [msdyn_DisplayName](#BKMK_msdyn_DisplayName)
- [msdyn_Email](#BKMK_msdyn_Email)
- [msdyn_LongestMonologueInMS](#BKMK_msdyn_LongestMonologueInMS)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_ParticipantId](#BKMK_msdyn_ParticipantId)
- [msdyn_ParticipantRole](#BKMK_msdyn_ParticipantRole)
- [msdyn_ParticipationMethod](#BKMK_msdyn_ParticipationMethod)
- [msdyn_PhoneNumber](#BKMK_msdyn_PhoneNumber)
- [msdyn_SwitchCount](#BKMK_msdyn_SwitchCount)
- [msdyn_TalkingSpeedWordsPerMin](#BKMK_msdyn_TalkingSpeedWordsPerMin)
- [msdyn_TalkToListenRatio](#BKMK_msdyn_TalkToListenRatio)
- [msdyn_TenantId](#BKMK_msdyn_TenantId)
- [msdyn_User](#BKMK_msdyn_User)
- [msdyn_UserIdType](#BKMK_msdyn_UserIdType)
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

### <a name="BKMK_msdyn_AadId"></a> msdyn_AadId

|Property|Value|
|---|---|
|Description||
|DisplayName|**AadId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aadid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_AvgPauseBeforeSpeakingInMS"></a> msdyn_AvgPauseBeforeSpeakingInMS

|Property|Value|
|---|---|
|Description||
|DisplayName|**AvgPauseBeforeSpeakingInMS**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_avgpausebeforespeakinginms`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_ChannelIndex"></a> msdyn_ChannelIndex

|Property|Value|
|---|---|
|Description||
|DisplayName|**ChannelIndex**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channelindex`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_ConversationAggregatedInsights"></a> msdyn_ConversationAggregatedInsights

|Property|Value|
|---|---|
|Description||
|DisplayName|**ConversationAggregatedInsights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationaggregatedinsights`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_conversationaggregatedinsights|

### <a name="BKMK_msdyn_ConversationParticipantInsightsId"></a> msdyn_ConversationParticipantInsightsId

|Property|Value|
|---|---|
|Description|**Unique identifier for conversation participant insights**|
|DisplayName|**ConversationParticipantInsights**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationparticipantinsightsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_DisplayName"></a> msdyn_DisplayName

|Property|Value|
|---|---|
|Description||
|DisplayName|**DisplayName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Email"></a> msdyn_Email

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_email`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_LongestMonologueInMS"></a> msdyn_LongestMonologueInMS

|Property|Value|
|---|---|
|Description||
|DisplayName|**LongestMonologueInMS**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_longestmonologueinms`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

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
|MaxLength|100|

### <a name="BKMK_msdyn_ParticipantId"></a> msdyn_ParticipantId

|Property|Value|
|---|---|
|Description||
|DisplayName|**ParticipantId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_participantid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ParticipantRole"></a> msdyn_ParticipantRole

|Property|Value|
|---|---|
|Description||
|DisplayName|**Participant Role**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_participantrole`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_conversationparticipantinsights_msdyn_participantrole`|

#### msdyn_ParticipantRole Choices/Options

|Value|Label|
|---|---|
|0|**Agent**|
|1|**Customer**|

### <a name="BKMK_msdyn_ParticipationMethod"></a> msdyn_ParticipationMethod

|Property|Value|
|---|---|
|Description||
|DisplayName|**ParticipationMethod**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_participationmethod`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_conversationparticipantinsights_msdyn_participationmethod`|

#### msdyn_ParticipationMethod Choices/Options

|Value|Label|
|---|---|
|192350000|**Caller**|
|192350001|**Callee**|

### <a name="BKMK_msdyn_PhoneNumber"></a> msdyn_PhoneNumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**PhoneNumber**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SwitchCount"></a> msdyn_SwitchCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**SwitchCount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_switchcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_TalkingSpeedWordsPerMin"></a> msdyn_TalkingSpeedWordsPerMin

|Property|Value|
|---|---|
|Description||
|DisplayName|**TalkingSpeedWordsPerMin**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_talkingspeedwordspermin`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-1|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TalkToListenRatio"></a> msdyn_TalkToListenRatio

|Property|Value|
|---|---|
|Description||
|DisplayName|**TalkToListenRatio**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_talktolistenratio`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-1|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TenantId"></a> msdyn_TenantId

|Property|Value|
|---|---|
|Description||
|DisplayName|**TenantId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tenantid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_User"></a> msdyn_User

|Property|Value|
|---|---|
|Description||
|DisplayName|**User**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_user`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, contact, systemuser|

### <a name="BKMK_msdyn_UserIdType"></a> msdyn_UserIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_useridtype`|
|RequiredLevel|None|
|Type|EntityName|

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
|Description|**Status of the ConversationParticipantInsights**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationparticipantinsights_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ConversationParticipantInsights**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationparticipantinsights_statuscode`|

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

- [business_unit_msdyn_conversationparticipantinsights](#BKMK_business_unit_msdyn_conversationparticipantinsights)
- [lk_msdyn_conversationparticipantinsights_createdby](#BKMK_lk_msdyn_conversationparticipantinsights_createdby)
- [lk_msdyn_conversationparticipantinsights_createdonbehalfby](#BKMK_lk_msdyn_conversationparticipantinsights_createdonbehalfby)
- [lk_msdyn_conversationparticipantinsights_modifiedby](#BKMK_lk_msdyn_conversationparticipantinsights_modifiedby)
- [lk_msdyn_conversationparticipantinsights_modifiedonbehalfby](#BKMK_lk_msdyn_conversationparticipantinsights_modifiedonbehalfby)
- [msdyn_msdyn_conversationparticipantinsights_account_msdyn_User](#BKMK_msdyn_msdyn_conversationparticipantinsights_account_msdyn_User)
- [msdyn_msdyn_conversationparticipantinsights_Con](#BKMK_msdyn_msdyn_conversationparticipantinsights_Con)
- [msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User](#BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User)
- [msdyn_msdyn_conversationparticipantinsights_systemuser_msdyn_User](#BKMK_msdyn_msdyn_conversationparticipantinsights_systemuser_msdyn_User)
- [owner_msdyn_conversationparticipantinsights](#BKMK_owner_msdyn_conversationparticipantinsights)
- [team_msdyn_conversationparticipantinsights](#BKMK_team_msdyn_conversationparticipantinsights)
- [user_msdyn_conversationparticipantinsights](#BKMK_user_msdyn_conversationparticipantinsights)

### <a name="BKMK_business_unit_msdyn_conversationparticipantinsights"></a> business_unit_msdyn_conversationparticipantinsights

One-To-Many Relationship: [businessunit business_unit_msdyn_conversationparticipantinsights](businessunit.md#BKMK_business_unit_msdyn_conversationparticipantinsights)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationparticipantinsights_createdby"></a> lk_msdyn_conversationparticipantinsights_createdby

One-To-Many Relationship: [systemuser lk_msdyn_conversationparticipantinsights_createdby](systemuser.md#BKMK_lk_msdyn_conversationparticipantinsights_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationparticipantinsights_createdonbehalfby"></a> lk_msdyn_conversationparticipantinsights_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationparticipantinsights_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationparticipantinsights_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationparticipantinsights_modifiedby"></a> lk_msdyn_conversationparticipantinsights_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_conversationparticipantinsights_modifiedby](systemuser.md#BKMK_lk_msdyn_conversationparticipantinsights_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationparticipantinsights_modifiedonbehalfby"></a> lk_msdyn_conversationparticipantinsights_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationparticipantinsights_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationparticipantinsights_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_conversationparticipantinsights_account_msdyn_User"></a> msdyn_msdyn_conversationparticipantinsights_account_msdyn_User

One-To-Many Relationship: [account msdyn_msdyn_conversationparticipantinsights_account_msdyn_User](account.md#BKMK_msdyn_msdyn_conversationparticipantinsights_account_msdyn_User)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_user`|
|ReferencingEntityNavigationPropertyName|`msdyn_user_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_conversationparticipantinsights_Con"></a> msdyn_msdyn_conversationparticipantinsights_Con

One-To-Many Relationship: [msdyn_conversationaggregatedinsights msdyn_msdyn_conversationparticipantinsights_Con](msdyn_conversationaggregatedinsights.md#BKMK_msdyn_msdyn_conversationparticipantinsights_Con)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_conversationaggregatedinsights`|
|ReferencedAttribute|`msdyn_conversationaggregatedinsightsid`|
|ReferencingAttribute|`msdyn_conversationaggregatedinsights`|
|ReferencingEntityNavigationPropertyName|`msdyn_conversationaggregatedinsights`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User"></a> msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User

One-To-Many Relationship: [contact msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User](contact.md#BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_user`|
|ReferencingEntityNavigationPropertyName|`msdyn_user_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_conversationparticipantinsights_systemuser_msdyn_User"></a> msdyn_msdyn_conversationparticipantinsights_systemuser_msdyn_User

One-To-Many Relationship: [systemuser msdyn_msdyn_conversationparticipantinsights_systemuser_msdyn_User](systemuser.md#BKMK_msdyn_msdyn_conversationparticipantinsights_systemuser_msdyn_User)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_user`|
|ReferencingEntityNavigationPropertyName|`msdyn_user_systemuser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_conversationparticipantinsights"></a> owner_msdyn_conversationparticipantinsights

One-To-Many Relationship: [owner owner_msdyn_conversationparticipantinsights](owner.md#BKMK_owner_msdyn_conversationparticipantinsights)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_conversationparticipantinsights"></a> team_msdyn_conversationparticipantinsights

One-To-Many Relationship: [team team_msdyn_conversationparticipantinsights](team.md#BKMK_team_msdyn_conversationparticipantinsights)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_conversationparticipantinsights"></a> user_msdyn_conversationparticipantinsights

One-To-Many Relationship: [systemuser user_msdyn_conversationparticipantinsights](systemuser.md#BKMK_user_msdyn_conversationparticipantinsights)

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

- [msdyn_conversationparticipantinsights_AsyncOperations](#BKMK_msdyn_conversationparticipantinsights_AsyncOperations)
- [msdyn_conversationparticipantinsights_BulkDeleteFailures](#BKMK_msdyn_conversationparticipantinsights_BulkDeleteFailures)
- [msdyn_conversationparticipantinsights_DuplicateBaseRecord](#BKMK_msdyn_conversationparticipantinsights_DuplicateBaseRecord)
- [msdyn_conversationparticipantinsights_DuplicateMatchingRecord](#BKMK_msdyn_conversationparticipantinsights_DuplicateMatchingRecord)
- [msdyn_conversationparticipantinsights_MailboxTrackingFolders](#BKMK_msdyn_conversationparticipantinsights_MailboxTrackingFolders)
- [msdyn_conversationparticipantinsights_PrincipalObjectAttributeAccesses](#BKMK_msdyn_conversationparticipantinsights_PrincipalObjectAttributeAccesses)
- [msdyn_conversationparticipantinsights_ProcessSession](#BKMK_msdyn_conversationparticipantinsights_ProcessSession)
- [msdyn_conversationparticipantinsights_SyncErrors](#BKMK_msdyn_conversationparticipantinsights_SyncErrors)
- [msdyn_msdyn_conversationactionitem_Conversation](#BKMK_msdyn_msdyn_conversationactionitem_Conversation)
- [msdyn_msdyn_conversationparticipantsentiment_Co](#BKMK_msdyn_msdyn_conversationparticipantsentiment_Co)
- [msdyn_msdyn_conversationquestion_ConversationPa](#BKMK_msdyn_msdyn_conversationquestion_ConversationPa)
- [msdyn_msdyn_conversationsegmentsentiment_Conver](#BKMK_msdyn_msdyn_conversationsegmentsentiment_Conver)
- [msdyn_msdyn_conversationsignal_ConversationPart](#BKMK_msdyn_msdyn_conversationsignal_ConversationPart)
- [msdyn_msdyn_conversationsummarysuggestion_Conve](#BKMK_msdyn_msdyn_conversationsummarysuggestion_Conve)

### <a name="BKMK_msdyn_conversationparticipantinsights_AsyncOperations"></a> msdyn_conversationparticipantinsights_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_conversationparticipantinsights_AsyncOperations](asyncoperation.md#BKMK_msdyn_conversationparticipantinsights_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationparticipantinsights_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationparticipantinsights_BulkDeleteFailures"></a> msdyn_conversationparticipantinsights_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_conversationparticipantinsights_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_conversationparticipantinsights_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationparticipantinsights_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationparticipantinsights_DuplicateBaseRecord"></a> msdyn_conversationparticipantinsights_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_conversationparticipantinsights_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_conversationparticipantinsights_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationparticipantinsights_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationparticipantinsights_DuplicateMatchingRecord"></a> msdyn_conversationparticipantinsights_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_conversationparticipantinsights_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_conversationparticipantinsights_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationparticipantinsights_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationparticipantinsights_MailboxTrackingFolders"></a> msdyn_conversationparticipantinsights_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_conversationparticipantinsights_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_conversationparticipantinsights_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationparticipantinsights_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationparticipantinsights_PrincipalObjectAttributeAccesses"></a> msdyn_conversationparticipantinsights_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_conversationparticipantinsights_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_conversationparticipantinsights_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationparticipantinsights_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationparticipantinsights_ProcessSession"></a> msdyn_conversationparticipantinsights_ProcessSession

Many-To-One Relationship: [processsession msdyn_conversationparticipantinsights_ProcessSession](processsession.md#BKMK_msdyn_conversationparticipantinsights_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationparticipantinsights_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationparticipantinsights_SyncErrors"></a> msdyn_conversationparticipantinsights_SyncErrors

Many-To-One Relationship: [syncerror msdyn_conversationparticipantinsights_SyncErrors](syncerror.md#BKMK_msdyn_conversationparticipantinsights_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationparticipantinsights_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationactionitem_Conversation"></a> msdyn_msdyn_conversationactionitem_Conversation

Many-To-One Relationship: [msdyn_conversationactionitem msdyn_msdyn_conversationactionitem_Conversation](msdyn_conversationactionitem.md#BKMK_msdyn_msdyn_conversationactionitem_Conversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionitem`|
|ReferencingAttribute|`msdyn_conversationparticipantinsights`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationactionitem_conversation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationparticipantsentiment_Co"></a> msdyn_msdyn_conversationparticipantsentiment_Co

Many-To-One Relationship: [msdyn_conversationparticipantsentiment msdyn_msdyn_conversationparticipantsentiment_Co](msdyn_conversationparticipantsentiment.md#BKMK_msdyn_msdyn_conversationparticipantsentiment_Co)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationparticipantsentiment`|
|ReferencingAttribute|`msdyn_conversationparticipantinsights`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationparticipantsentiment_co`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationquestion_ConversationPa"></a> msdyn_msdyn_conversationquestion_ConversationPa

Many-To-One Relationship: [msdyn_conversationquestion msdyn_msdyn_conversationquestion_ConversationPa](msdyn_conversationquestion.md#BKMK_msdyn_msdyn_conversationquestion_ConversationPa)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationquestion`|
|ReferencingAttribute|`msdyn_conversationparticipantinsights`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationquestion_conversationpa`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationsegmentsentiment_Conver"></a> msdyn_msdyn_conversationsegmentsentiment_Conver

Many-To-One Relationship: [msdyn_conversationsegmentsentiment msdyn_msdyn_conversationsegmentsentiment_Conver](msdyn_conversationsegmentsentiment.md#BKMK_msdyn_msdyn_conversationsegmentsentiment_Conver)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsegmentsentiment`|
|ReferencingAttribute|`msdyn_conversationparticipantinsights`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationsegmentsentiment_conver`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationsignal_ConversationPart"></a> msdyn_msdyn_conversationsignal_ConversationPart

Many-To-One Relationship: [msdyn_conversationsignal msdyn_msdyn_conversationsignal_ConversationPart](msdyn_conversationsignal.md#BKMK_msdyn_msdyn_conversationsignal_ConversationPart)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsignal`|
|ReferencingAttribute|`msdyn_conversationparticipantinsights`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationsignal_conversationpart`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationsummarysuggestion_Conve"></a> msdyn_msdyn_conversationsummarysuggestion_Conve

Many-To-One Relationship: [msdyn_conversationsummarysuggestion msdyn_msdyn_conversationsummarysuggestion_Conve](msdyn_conversationsummarysuggestion.md#BKMK_msdyn_msdyn_conversationsummarysuggestion_Conve)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsummarysuggestion`|
|ReferencingAttribute|`msdyn_conversationparticipantinsights`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationsummarysuggestion_conve`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

