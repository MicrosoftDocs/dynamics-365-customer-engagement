---
title: "msdyn_ConversationParticipantInsights table/entity reference"
description: "Includes schema information and supported messages for the msdyn_ConversationParticipantInsights table/entity."
ms.date: 02/27/2024
ms.service: "dynamics-365-sales"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "lavanyakr01"
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.audienceType: 
  - developer
---

# msdyn_ConversationParticipantInsights table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).



**Added by**: Conversation Intelligence Solution


## Messages

|Message|Web API Operation|SDK class or method|
|-|-|-|
|Assign|PATCH /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|BulkRetain|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Create|POST /msdyn_conversationparticipantinsights<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|DELETE /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|PurgeRetainedContent|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Retain|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Retrieve|GET /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET /msdyn_conversationparticipantinsights<br />See [Query Data](/powerapps/developer/data-platform/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|RollbackRetain|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|SetState|PATCH /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH /msdyn_conversationparticipantinsights(*msdyn_conversationparticipantinsightsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
|ValidateRetentionConfig|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_ConversationParticipantInsightses|
|DisplayCollectionName|Conversation Participant Insights|
|DisplayName|Conversation Participant Insights|
|EntitySetName|msdyn_conversationparticipantinsights|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_conversationparticipantinsightses|
|LogicalName|msdyn_conversationparticipantinsights|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_conversationparticipantinsightsid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_ConversationParticipantInsights|

<a name="writable-attributes"></a>

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
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_AadId"></a> msdyn_AadId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|AadId|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_aadid|
|MaxLength|36|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AvgPauseBeforeSpeakingInMS"></a> msdyn_AvgPauseBeforeSpeakingInMS

|Property|Value|
|--------|-----|
|Description||
|DisplayName|AvgPauseBeforeSpeakingInMS|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_avgpausebeforespeakinginms|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_ChannelIndex"></a> msdyn_ChannelIndex

|Property|Value|
|--------|-----|
|Description||
|DisplayName|ChannelIndex|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_channelindex|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_ConversationAggregatedInsights"></a> msdyn_ConversationAggregatedInsights

|Property|Value|
|--------|-----|
|Description||
|DisplayName|ConversationAggregatedInsights|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_conversationaggregatedinsights|
|RequiredLevel|None|
|Targets|msdyn_conversationaggregatedinsights|
|Type|Lookup|


### <a name="BKMK_msdyn_ConversationParticipantInsightsId"></a> msdyn_ConversationParticipantInsightsId

|Property|Value|
|--------|-----|
|Description|Unique identifier for conversation participant insights|
|DisplayName|ConversationParticipantInsights|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_conversationparticipantinsightsid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_DisplayName"></a> msdyn_DisplayName

|Property|Value|
|--------|-----|
|Description||
|DisplayName|DisplayName|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_displayname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Email"></a> msdyn_Email

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Email|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_email|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_LongestMonologueInMS"></a> msdyn_LongestMonologueInMS

|Property|Value|
|--------|-----|
|Description||
|DisplayName|LongestMonologueInMS|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_longestmonologueinms|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_ParticipantId"></a> msdyn_ParticipantId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|ParticipantId|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_participantid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ParticipantRole"></a> msdyn_ParticipantRole

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Participant Role|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_participantrole|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_ParticipantRole Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Agent||
|1|Customer||



### <a name="BKMK_msdyn_ParticipationMethod"></a> msdyn_ParticipationMethod

|Property|Value|
|--------|-----|
|Description||
|DisplayName|ParticipationMethod|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_participationmethod|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_ParticipationMethod Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|192350000|Caller||
|192350001|Callee||



### <a name="BKMK_msdyn_PhoneNumber"></a> msdyn_PhoneNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName|PhoneNumber|
|FormatName|Phone|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_phonenumber|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SwitchCount"></a> msdyn_SwitchCount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|SwitchCount|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_switchcount|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_TalkingSpeedWordsPerMin"></a> msdyn_TalkingSpeedWordsPerMin

|Property|Value|
|--------|-----|
|Description||
|DisplayName|TalkingSpeedWordsPerMin|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_talkingspeedwordspermin|
|MaxValue|100000000000|
|MinValue|-1|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_TalkToListenRatio"></a> msdyn_TalkToListenRatio

|Property|Value|
|--------|-----|
|Description||
|DisplayName|TalkToListenRatio|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_talktolistenratio|
|MaxValue|100000000000|
|MinValue|-1|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_TenantId"></a> msdyn_TenantId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|TenantId|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_tenantid|
|MaxLength|36|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_User"></a> msdyn_User

|Property|Value|
|--------|-----|
|Description||
|DisplayName|User|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_user|
|RequiredLevel|None|
|Targets|account,contact,systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_UserIdType"></a> msdyn_UserIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_useridtype|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the ConversationParticipantInsights|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the ConversationParticipantInsights|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_ConversationAggregatedInsightsName](#BKMK_msdyn_ConversationAggregatedInsightsName)
- [msdyn_UserName](#BKMK_msdyn_UserName)
- [msdyn_UserYomiName](#BKMK_msdyn_UserYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_ConversationAggregatedInsightsName"></a> msdyn_ConversationAggregatedInsightsName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_conversationaggregatedinsightsname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_UserName"></a> msdyn_UserName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_username|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_UserYomiName"></a> msdyn_UserYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_useryominame|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_msdyn_conversationactionitem_Conversation](#BKMK_msdyn_msdyn_conversationactionitem_Conversation)
- [msdyn_msdyn_conversationparticipantsentiment_Co](#BKMK_msdyn_msdyn_conversationparticipantsentiment_Co)
- [msdyn_msdyn_conversationquestion_ConversationPa](#BKMK_msdyn_msdyn_conversationquestion_ConversationPa)
- [msdyn_msdyn_conversationsignal_ConversationPart](#BKMK_msdyn_msdyn_conversationsignal_ConversationPart)
- [msdyn_msdyn_conversationsummarysuggestion_Conve](#BKMK_msdyn_msdyn_conversationsummarysuggestion_Conve)


### <a name="BKMK_msdyn_msdyn_conversationactionitem_Conversation"></a> msdyn_msdyn_conversationactionitem_Conversation

Same as the [msdyn_msdyn_conversationactionitem_Conversation](msdyn_conversationactionitem.md#BKMK_msdyn_msdyn_conversationactionitem_Conversation) many-to-one relationship for the [msdyn_conversationactionitem](msdyn_conversationactionitem.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_conversationactionitem|
|ReferencingAttribute|msdyn_conversationparticipantinsights|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_conversationactionitem_conversation|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_conversationparticipantsentiment_Co"></a> msdyn_msdyn_conversationparticipantsentiment_Co

Same as the [msdyn_msdyn_conversationparticipantsentiment_Co](msdyn_conversationparticipantsentiment.md#BKMK_msdyn_msdyn_conversationparticipantsentiment_Co) many-to-one relationship for the [msdyn_conversationparticipantsentiment](msdyn_conversationparticipantsentiment.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_conversationparticipantsentiment|
|ReferencingAttribute|msdyn_conversationparticipantinsights|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_conversationparticipantsentiment_co|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_conversationquestion_ConversationPa"></a> msdyn_msdyn_conversationquestion_ConversationPa

Same as the [msdyn_msdyn_conversationquestion_ConversationPa](msdyn_conversationquestion.md#BKMK_msdyn_msdyn_conversationquestion_ConversationPa) many-to-one relationship for the [msdyn_conversationquestion](msdyn_conversationquestion.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_conversationquestion|
|ReferencingAttribute|msdyn_conversationparticipantinsights|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_conversationquestion_conversationpa|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_conversationsignal_ConversationPart"></a> msdyn_msdyn_conversationsignal_ConversationPart

Same as the [msdyn_msdyn_conversationsignal_ConversationPart](msdyn_conversationsignal.md#BKMK_msdyn_msdyn_conversationsignal_ConversationPart) many-to-one relationship for the [msdyn_conversationsignal](msdyn_conversationsignal.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_conversationsignal|
|ReferencingAttribute|msdyn_conversationparticipantinsights|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_conversationsignal_conversationpart|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_conversationsummarysuggestion_Conve"></a> msdyn_msdyn_conversationsummarysuggestion_Conve

Same as the [msdyn_msdyn_conversationsummarysuggestion_Conve](msdyn_conversationsummarysuggestion.md#BKMK_msdyn_msdyn_conversationsummarysuggestion_Conve) many-to-one relationship for the [msdyn_conversationsummarysuggestion](msdyn_conversationsummarysuggestion.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_conversationsummarysuggestion|
|ReferencingAttribute|msdyn_conversationparticipantinsights|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_conversationsummarysuggestion_conve|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [msdyn_msdyn_conversationparticipantinsights_account_msdyn_User](#BKMK_msdyn_msdyn_conversationparticipantinsights_account_msdyn_User)
- [msdyn_msdyn_conversationparticipantinsights_Con](#BKMK_msdyn_msdyn_conversationparticipantinsights_Con)
- [msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User](#BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User)


### <a name="BKMK_msdyn_msdyn_conversationparticipantinsights_account_msdyn_User"></a> msdyn_msdyn_conversationparticipantinsights_account_msdyn_User

**Added by**: System Solution Solution

See the [msdyn_msdyn_conversationparticipantinsights_account_msdyn_User](account.md#BKMK_msdyn_msdyn_conversationparticipantinsights_account_msdyn_User) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_msdyn_msdyn_conversationparticipantinsights_Con"></a> msdyn_msdyn_conversationparticipantinsights_Con

See the [msdyn_msdyn_conversationparticipantinsights_Con](msdyn_conversationaggregatedinsights.md#BKMK_msdyn_msdyn_conversationparticipantinsights_Con) one-to-many relationship for the [msdyn_conversationaggregatedinsights](msdyn_conversationaggregatedinsights.md) table/entity.

### <a name="BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User"></a> msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User

**Added by**: System Solution Solution

See the [msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User](contact.md#BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User) one-to-many relationship for the [contact](contact.md) table/entity.

## Related information

[Dataverse table/entity reference](../about-entity-reference.md)  
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)