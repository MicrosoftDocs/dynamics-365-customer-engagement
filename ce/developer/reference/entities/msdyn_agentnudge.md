---
title: "Agent Nudge (msdyn_AgentNudge) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Agent Nudge (msdyn_AgentNudge) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Agent Nudge (msdyn_AgentNudge) table/entity reference (Microsoft Dynamics 365)

Represents an occurrence of a compliance rule being violated in a conversation.

## Messages

The following table lists the messages for the Agent Nudge (msdyn_AgentNudge) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `AcknowledgeNudge`<br />Event: False |**AcknowledgeNudge action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_agentnudges<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_agentnudges(*msdyn_agentnudgeid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `DismissNudge`<br />Event: False |**DismissNudge action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_agentnudges(*msdyn_agentnudgeid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_agentnudges<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_agentnudges(*msdyn_agentnudgeid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_agentnudges(*msdyn_agentnudgeid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agent Nudge (msdyn_AgentNudge) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agent Nudge** |
| **DisplayCollectionName** | **Agent Nudges** |
| **SchemaName** | `msdyn_AgentNudge` |
| **CollectionSchemaName** | `msdyn_AgentNudges` |
| **EntitySetName** | `msdyn_agentnudges`|
| **LogicalName** | `msdyn_agentnudge` |
| **LogicalCollectionName** | `msdyn_agentnudges` |
| **PrimaryIdAttribute** | `msdyn_agentnudgeid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AgentNudgeId](#BKMK_msdyn_AgentNudgeId)
- [msdyn_Escalated](#BKMK_msdyn_Escalated)
- [msdyn_Explanation](#BKMK_msdyn_Explanation)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_NudgeTemplateID](#BKMK_msdyn_NudgeTemplateID)
- [msdyn_NudgeText](#BKMK_msdyn_NudgeText)
- [msdyn_ocliveworkitem](#BKMK_msdyn_ocliveworkitem)
- [msdyn_Priority](#BKMK_msdyn_Priority)
- [msdyn_ShowNudge](#BKMK_msdyn_ShowNudge)
- [msdyn_Status](#BKMK_msdyn_Status)
- [msdyn_SuggestedResponse](#BKMK_msdyn_SuggestedResponse)
- [msdyn_SystemUser](#BKMK_msdyn_SystemUser)
- [msdyn_Timestamp](#BKMK_msdyn_Timestamp)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [PartitionId](#BKMK_PartitionId)
- [TTLInSeconds](#BKMK_TTLInSeconds)

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

### <a name="BKMK_msdyn_AgentNudgeId"></a> msdyn_AgentNudgeId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Agent Nudge ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agentnudgeid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Escalated"></a> msdyn_Escalated

|Property|Value|
|---|---|
|Description|**Flag indicating if this violation led to a CSR escalation.**|
|DisplayName|**Escalated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_escalated`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentnudge_msdyn_escalated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Explanation"></a> msdyn_Explanation

|Property|Value|
|---|---|
|Description|**Explanation why the nudge was triggered.**|
|DisplayName|**Explanation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_explanation`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

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
|MaxLength|200|

### <a name="BKMK_msdyn_NudgeTemplateID"></a> msdyn_NudgeTemplateID

|Property|Value|
|---|---|
|Description|**Reference to template that triggered this nudge.**|
|DisplayName|**Nudge Template ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nudgetemplateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_agentnudgetemplate|

### <a name="BKMK_msdyn_NudgeText"></a> msdyn_NudgeText

|Property|Value|
|---|---|
|Description|**Nudge text displayed to the user.**|
|DisplayName|**Nudge Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nudgetext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|RichText|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdyn_ocliveworkitem"></a> msdyn_ocliveworkitem

|Property|Value|
|---|---|
|Description|**Reference to the conversation.**|
|DisplayName|**Conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocliveworkitem`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_Priority"></a> msdyn_Priority

|Property|Value|
|---|---|
|Description|**Priority of the agent nudge.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_priority`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|419550001|
|GlobalChoiceName|`msdyn_prioritychoices`|

#### msdyn_Priority Choices/Options

|Value|Label|
|---|---|
|419550000|**Low**|
|419550001|**Medium**|
|419550002|**High**|

### <a name="BKMK_msdyn_ShowNudge"></a> msdyn_ShowNudge

|Property|Value|
|---|---|
|Description|**Show nudge notification to agent.**|
|DisplayName|**Show Nudge**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shownudge`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentnudge_msdyn_shownudge`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Status"></a> msdyn_Status

|Property|Value|
|---|---|
|Description|**The agent’s handling status.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|419550000|
|GlobalChoiceName|`msdyn_statuschoices`|

#### msdyn_Status Choices/Options

|Value|Label|
|---|---|
|419550000|**New**|
|419550001|**Acknowledged**|
|419550002|**Dismissed**|

### <a name="BKMK_msdyn_SuggestedResponse"></a> msdyn_SuggestedResponse

|Property|Value|
|---|---|
|Description|**Suggested response offered to the agent.**|
|DisplayName|**Suggested response**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedresponse`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdyn_SystemUser"></a> msdyn_SystemUser

|Property|Value|
|---|---|
|Description|**The agent who sent the non-compliant message.**|
|DisplayName|**User**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_systemuser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_Timestamp"></a> msdyn_Timestamp

|Property|Value|
|---|---|
|Description|**When the notification was created.**|
|DisplayName|**Timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timestamp`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
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

### <a name="BKMK_PartitionId"></a> PartitionId

|Property|Value|
|---|---|
|Description|**Logical partition id. A logical partition consists of a set of records with same partition id.**|
|DisplayName|**Partition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TTLInSeconds"></a> TTLInSeconds

|Property|Value|
|---|---|
|Description|**Time to live in seconds.**|
|DisplayName|**Time to live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ttlinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
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

- [lk_msdyn_agentnudge_createdby](#BKMK_lk_msdyn_agentnudge_createdby)
- [lk_msdyn_agentnudge_createdonbehalfby](#BKMK_lk_msdyn_agentnudge_createdonbehalfby)
- [lk_msdyn_agentnudge_modifiedby](#BKMK_lk_msdyn_agentnudge_modifiedby)
- [lk_msdyn_agentnudge_modifiedonbehalfby](#BKMK_lk_msdyn_agentnudge_modifiedonbehalfby)
- [msdyn_AgentNudge_msdyn_ocliveworkitem](#BKMK_msdyn_AgentNudge_msdyn_ocliveworkitem)
- [msdyn_AgentNudge_NudgeTemplateID_msdyn_agentnudgetemplate](#BKMK_msdyn_AgentNudge_NudgeTemplateID_msdyn_agentnudgetemplate)
- [msdyn_AgentNudge_SystemUser](#BKMK_msdyn_AgentNudge_SystemUser)

### <a name="BKMK_lk_msdyn_agentnudge_createdby"></a> lk_msdyn_agentnudge_createdby

One-To-Many Relationship: [systemuser lk_msdyn_agentnudge_createdby](systemuser.md#BKMK_lk_msdyn_agentnudge_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentnudge_createdonbehalfby"></a> lk_msdyn_agentnudge_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentnudge_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agentnudge_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentnudge_modifiedby"></a> lk_msdyn_agentnudge_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_agentnudge_modifiedby](systemuser.md#BKMK_lk_msdyn_agentnudge_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentnudge_modifiedonbehalfby"></a> lk_msdyn_agentnudge_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentnudge_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agentnudge_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_AgentNudge_msdyn_ocliveworkitem"></a> msdyn_AgentNudge_msdyn_ocliveworkitem

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_AgentNudge_msdyn_ocliveworkitem](msdyn_ocliveworkitem.md#BKMK_msdyn_AgentNudge_msdyn_ocliveworkitem)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_ocliveworkitem`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_AgentNudge_NudgeTemplateID_msdyn_agentnudgetemplate"></a> msdyn_AgentNudge_NudgeTemplateID_msdyn_agentnudgetemplate

One-To-Many Relationship: [msdyn_agentnudgetemplate msdyn_AgentNudge_NudgeTemplateID_msdyn_agentnudgetemplate](msdyn_agentnudgetemplate.md#BKMK_msdyn_AgentNudge_NudgeTemplateID_msdyn_agentnudgetemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agentnudgetemplate`|
|ReferencedAttribute|`msdyn_agentnudgetemplateid`|
|ReferencingAttribute|`msdyn_nudgetemplateid`|
|ReferencingEntityNavigationPropertyName|`msdyn_NudgeTemplateID`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_AgentNudge_SystemUser"></a> msdyn_AgentNudge_SystemUser

One-To-Many Relationship: [systemuser msdyn_AgentNudge_SystemUser](systemuser.md#BKMK_msdyn_AgentNudge_SystemUser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_systemuser`|
|ReferencingEntityNavigationPropertyName|`msdyn_SystemUser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

