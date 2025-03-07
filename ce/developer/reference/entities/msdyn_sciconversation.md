---
title: "SCI Conversation (msdyn_SCIConversation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the SCI Conversation (msdyn_SCIConversation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# SCI Conversation (msdyn_SCIConversation) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the SCI Conversation (msdyn_SCIConversation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_sciconversations(*msdyn_sciconversationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_sciconversations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_sciconversations(*msdyn_sciconversationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_sciconversations(*msdyn_sciconversationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_sciconversations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_sciconversations(*msdyn_sciconversationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_sciconversations(*msdyn_sciconversationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_sciconversations(*msdyn_sciconversationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the SCI Conversation (msdyn_SCIConversation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **SCI Conversation** |
| **DisplayCollectionName** | **SCI Conversations** |
| **SchemaName** | `msdyn_SCIConversation` |
| **CollectionSchemaName** | `msdyn_SCIConversations` |
| **EntitySetName** | `msdyn_sciconversations`|
| **LogicalName** | `msdyn_sciconversation` |
| **LogicalCollectionName** | `msdyn_sciconversations` |
| **PrimaryIdAttribute** | `msdyn_sciconversationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ChatId](#BKMK_msdyn_ChatId)
- [msdyn_ClientFileName](#BKMK_msdyn_ClientFileName)
- [msdyn_CommunicationType](#BKMK_msdyn_CommunicationType)
- [msdyn_ConsentModeId](#BKMK_msdyn_ConsentModeId)
- [msdyn_ConversationAggregatedInsights](#BKMK_msdyn_ConversationAggregatedInsights)
- [msdyn_ConversationId](#BKMK_msdyn_ConversationId)
- [msdyn_ConversationScope](#BKMK_msdyn_ConversationScope)
- [msdyn_ConversationStartTime](#BKMK_msdyn_ConversationStartTime)
- [msdyn_Direction](#BKMK_msdyn_Direction)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_OCRecording](#BKMK_msdyn_OCRecording)
- [msdyn_RelatedActivity](#BKMK_msdyn_RelatedActivity)
- [msdyn_RelatedActivityIdType](#BKMK_msdyn_RelatedActivityIdType)
- [msdyn_SCIConversationId](#BKMK_msdyn_SCIConversationId)
- [msdyn_Transcript](#BKMK_msdyn_Transcript)
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

### <a name="BKMK_msdyn_ChatId"></a> msdyn_ChatId

|Property|Value|
|---|---|
|Description||
|DisplayName|**ChatId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_chatid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_ClientFileName"></a> msdyn_ClientFileName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Client File Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_clientfilename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_CommunicationType"></a> msdyn_CommunicationType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Communication Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_communicationtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sciconversation_msdyn_communicationtype`|

#### msdyn_CommunicationType Choices/Options

|Value|Label|
|---|---|
|0|**Phonecall**|
|1|**Meeting**|

### <a name="BKMK_msdyn_ConsentModeId"></a> msdyn_ConsentModeId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_consentmodeid`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_sciconversation_msdyn_consentmodeid`|

#### msdyn_ConsentModeId Choices/Options

|Value|Label|
|---|---|
|1|**All**|
|2|**AgentsOnly**|
|3|**CurrentUserOnly**|

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

### <a name="BKMK_msdyn_ConversationId"></a> msdyn_ConversationId

|Property|Value|
|---|---|
|Description||
|DisplayName|**ConversationId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_ConversationScope"></a> msdyn_ConversationScope

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conversation Scope**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationscope`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_sciconversation_msdyn_conversationscope`|

#### msdyn_ConversationScope Choices/Options

|Value|Label|
|---|---|
|0|**Internal**|
|1|**External**|

### <a name="BKMK_msdyn_ConversationStartTime"></a> msdyn_ConversationStartTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**ConversationStartTime**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationstarttime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Direction"></a> msdyn_Direction

|Property|Value|
|---|---|
|Description||
|DisplayName|**Direction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_direction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_sciconversation_msdyn_direction`|

#### msdyn_Direction Choices/Options

|Value|Label|
|---|---|
|0|**Outgoing**|
|1|**Incoming**|

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

### <a name="BKMK_msdyn_OCRecording"></a> msdyn_OCRecording

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recording**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocrecording`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocrecording|

### <a name="BKMK_msdyn_RelatedActivity"></a> msdyn_RelatedActivity

|Property|Value|
|---|---|
|Description||
|DisplayName|**RelatedActivity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedactivity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|appointment, phonecall|

### <a name="BKMK_msdyn_RelatedActivityIdType"></a> msdyn_RelatedActivityIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedactivityidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_SCIConversationId"></a> msdyn_SCIConversationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**SCI Conversation**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_sciconversationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Transcript"></a> msdyn_Transcript

|Property|Value|
|---|---|
|Description||
|DisplayName|**Transcript**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transcript`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_transcript|

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
|Description|**Status of the SCI Conversation**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sciconversation_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the SCI Conversation**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sciconversation_statuscode`|

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

- [business_unit_msdyn_sciconversation](#BKMK_business_unit_msdyn_sciconversation)
- [lk_msdyn_sciconversation_createdby](#BKMK_lk_msdyn_sciconversation_createdby)
- [lk_msdyn_sciconversation_createdonbehalfby](#BKMK_lk_msdyn_sciconversation_createdonbehalfby)
- [lk_msdyn_sciconversation_modifiedby](#BKMK_lk_msdyn_sciconversation_modifiedby)
- [lk_msdyn_sciconversation_modifiedonbehalfby](#BKMK_lk_msdyn_sciconversation_modifiedonbehalfby)
- [msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity](#BKMK_msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity)
- [msdyn_msdyn_sciconversation_ConversationAggrega](#BKMK_msdyn_msdyn_sciconversation_ConversationAggrega)
- [msdyn_msdyn_sciconversation_OCRecording_msdyn_o](#BKMK_msdyn_msdyn_sciconversation_OCRecording_msdyn_o)
- [msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity](#BKMK_msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity)
- [msdyn_msdyn_sciconversation_Transcript_msdyn_tr](#BKMK_msdyn_msdyn_sciconversation_Transcript_msdyn_tr)
- [owner_msdyn_sciconversation](#BKMK_owner_msdyn_sciconversation)
- [team_msdyn_sciconversation](#BKMK_team_msdyn_sciconversation)
- [user_msdyn_sciconversation](#BKMK_user_msdyn_sciconversation)

### <a name="BKMK_business_unit_msdyn_sciconversation"></a> business_unit_msdyn_sciconversation

One-To-Many Relationship: [businessunit business_unit_msdyn_sciconversation](businessunit.md#BKMK_business_unit_msdyn_sciconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sciconversation_createdby"></a> lk_msdyn_sciconversation_createdby

One-To-Many Relationship: [systemuser lk_msdyn_sciconversation_createdby](systemuser.md#BKMK_lk_msdyn_sciconversation_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sciconversation_createdonbehalfby"></a> lk_msdyn_sciconversation_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sciconversation_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_sciconversation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sciconversation_modifiedby"></a> lk_msdyn_sciconversation_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_sciconversation_modifiedby](systemuser.md#BKMK_lk_msdyn_sciconversation_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sciconversation_modifiedonbehalfby"></a> lk_msdyn_sciconversation_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sciconversation_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_sciconversation_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity"></a> msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity

One-To-Many Relationship: [appointment msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity](appointment.md#BKMK_msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity)

|Property|Value|
|---|---|
|ReferencedEntity|`appointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_relatedactivity`|
|ReferencingEntityNavigationPropertyName|`msdyn_relatedactivity_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_sciconversation_ConversationAggrega"></a> msdyn_msdyn_sciconversation_ConversationAggrega

One-To-Many Relationship: [msdyn_conversationaggregatedinsights msdyn_msdyn_sciconversation_ConversationAggrega](msdyn_conversationaggregatedinsights.md#BKMK_msdyn_msdyn_sciconversation_ConversationAggrega)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_conversationaggregatedinsights`|
|ReferencedAttribute|`msdyn_conversationaggregatedinsightsid`|
|ReferencingAttribute|`msdyn_conversationaggregatedinsights`|
|ReferencingEntityNavigationPropertyName|`msdyn_conversationaggregatedinsights`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_sciconversation_OCRecording_msdyn_o"></a> msdyn_msdyn_sciconversation_OCRecording_msdyn_o

One-To-Many Relationship: [msdyn_ocrecording msdyn_msdyn_sciconversation_OCRecording_msdyn_o](msdyn_ocrecording.md#BKMK_msdyn_msdyn_sciconversation_OCRecording_msdyn_o)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocrecording`|
|ReferencedAttribute|`msdyn_ocrecordingid`|
|ReferencingAttribute|`msdyn_ocrecording`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocrecording`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity"></a> msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity

One-To-Many Relationship: [phonecall msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity](phonecall.md#BKMK_msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity)

|Property|Value|
|---|---|
|ReferencedEntity|`phonecall`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_relatedactivity`|
|ReferencingEntityNavigationPropertyName|`msdyn_relatedactivity_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_sciconversation_Transcript_msdyn_tr"></a> msdyn_msdyn_sciconversation_Transcript_msdyn_tr

One-To-Many Relationship: [msdyn_transcript msdyn_msdyn_sciconversation_Transcript_msdyn_tr](msdyn_transcript.md#BKMK_msdyn_msdyn_sciconversation_Transcript_msdyn_tr)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transcript`|
|ReferencedAttribute|`msdyn_transcriptid`|
|ReferencingAttribute|`msdyn_transcript`|
|ReferencingEntityNavigationPropertyName|`msdyn_transcript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_sciconversation"></a> owner_msdyn_sciconversation

One-To-Many Relationship: [owner owner_msdyn_sciconversation](owner.md#BKMK_owner_msdyn_sciconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_sciconversation"></a> team_msdyn_sciconversation

One-To-Many Relationship: [team team_msdyn_sciconversation](team.md#BKMK_team_msdyn_sciconversation)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_sciconversation"></a> user_msdyn_sciconversation

One-To-Many Relationship: [systemuser user_msdyn_sciconversation](systemuser.md#BKMK_user_msdyn_sciconversation)

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

- [msdyn_msdyn_conversationsystemtag_TagTarget_msd](#BKMK_msdyn_msdyn_conversationsystemtag_TagTarget_msd)
- [msdyn_msdyn_conversationtag_TagTarget_m](#BKMK_msdyn_msdyn_conversationtag_TagTarget_m)
- [msdyn_sciconversation_AsyncOperations](#BKMK_msdyn_sciconversation_AsyncOperations)
- [msdyn_sciconversation_BulkDeleteFailures](#BKMK_msdyn_sciconversation_BulkDeleteFailures)
- [msdyn_sciconversation_DuplicateBaseRecord](#BKMK_msdyn_sciconversation_DuplicateBaseRecord)
- [msdyn_sciconversation_DuplicateMatchingRecord](#BKMK_msdyn_sciconversation_DuplicateMatchingRecord)
- [msdyn_sciconversation_MailboxTrackingFolders](#BKMK_msdyn_sciconversation_MailboxTrackingFolders)
- [msdyn_sciconversation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_sciconversation_PrincipalObjectAttributeAccesses)
- [msdyn_sciconversation_ProcessSession](#BKMK_msdyn_sciconversation_ProcessSession)
- [msdyn_sciconversation_SyncErrors](#BKMK_msdyn_sciconversation_SyncErrors)

### <a name="BKMK_msdyn_msdyn_conversationsystemtag_TagTarget_msd"></a> msdyn_msdyn_conversationsystemtag_TagTarget_msd

Many-To-One Relationship: [msdyn_conversationsystemtag msdyn_msdyn_conversationsystemtag_TagTarget_msd](msdyn_conversationsystemtag.md#BKMK_msdyn_msdyn_conversationsystemtag_TagTarget_msd)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsystemtag`|
|ReferencingAttribute|`msdyn_tagtarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationsystemtag_tagtarget_msd`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationtag_TagTarget_m"></a> msdyn_msdyn_conversationtag_TagTarget_m

Many-To-One Relationship: [msdyn_conversationtag msdyn_msdyn_conversationtag_TagTarget_m](msdyn_conversationtag.md#BKMK_msdyn_msdyn_conversationtag_TagTarget_m)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationtag`|
|ReferencingAttribute|`msdyn_tagtarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationtag_tagtarget_m`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sciconversation_AsyncOperations"></a> msdyn_sciconversation_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_sciconversation_AsyncOperations](asyncoperation.md#BKMK_msdyn_sciconversation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sciconversation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sciconversation_BulkDeleteFailures"></a> msdyn_sciconversation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_sciconversation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_sciconversation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sciconversation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sciconversation_DuplicateBaseRecord"></a> msdyn_sciconversation_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_sciconversation_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_sciconversation_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sciconversation_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sciconversation_DuplicateMatchingRecord"></a> msdyn_sciconversation_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_sciconversation_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_sciconversation_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sciconversation_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sciconversation_MailboxTrackingFolders"></a> msdyn_sciconversation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_sciconversation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_sciconversation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sciconversation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sciconversation_PrincipalObjectAttributeAccesses"></a> msdyn_sciconversation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_sciconversation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_sciconversation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sciconversation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sciconversation_ProcessSession"></a> msdyn_sciconversation_ProcessSession

Many-To-One Relationship: [processsession msdyn_sciconversation_ProcessSession](processsession.md#BKMK_msdyn_sciconversation_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sciconversation_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sciconversation_SyncErrors"></a> msdyn_sciconversation_SyncErrors

Many-To-One Relationship: [syncerror msdyn_sciconversation_SyncErrors](syncerror.md#BKMK_msdyn_sciconversation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sciconversation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

