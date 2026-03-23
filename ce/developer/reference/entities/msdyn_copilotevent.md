---
title: "Copilot Event (msdyn_copilotevent) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Copilot Event (msdyn_copilotevent) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Copilot Event (msdyn_copilotevent) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Copilot Event (msdyn_copilotevent) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_copilotevents(*msdyn_copiloteventid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_copilotevents<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_copilotevents(*msdyn_copiloteventid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_copilotevents(*msdyn_copiloteventid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_copilotevents<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_copilotevents(*msdyn_copiloteventid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_copilotevents(*msdyn_copiloteventid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Copilot Event (msdyn_copilotevent) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Copilot Event** |
| **DisplayCollectionName** | **Copilot Events** |
| **SchemaName** | `msdyn_copilotevent` |
| **CollectionSchemaName** | `msdyn_copilotevents` |
| **EntitySetName** | `msdyn_copilotevents`|
| **LogicalName** | `msdyn_copilotevent` |
| **LogicalCollectionName** | `msdyn_copilotevents` |
| **PrimaryIdAttribute** | `msdyn_copiloteventid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_aiagent](#BKMK_msdyn_aiagent)
- [msdyn_clienttimestamp](#BKMK_msdyn_clienttimestamp)
- [msdyn_copiloteventId](#BKMK_msdyn_copiloteventId)
- [msdyn_interactioncontext](#BKMK_msdyn_interactioncontext)
- [msdyn_interactionforid](#BKMK_msdyn_interactionforid)
- [msdyn_interactionforlogicalname](#BKMK_msdyn_interactionforlogicalname)
- [msdyn_interactiontype](#BKMK_msdyn_interactiontype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_scenariorequestid](#BKMK_msdyn_scenariorequestid)
- [msdyn_scenariotype](#BKMK_msdyn_scenariotype)
- [msdyn_verbatim](#BKMK_msdyn_verbatim)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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

### <a name="BKMK_msdyn_aiagent"></a> msdyn_aiagent

|Property|Value|
|---|---|
|Description|**Identifies the AI Agent Involved**|
|DisplayName|**AI Agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aiagent`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_aiagents`|

#### msdyn_aiagent Choices/Options

|Value|Label|
|---|---|
|192350001|**Resolution Discovery Agent**|
|192350002|**Quality Evaluation Agent**|
|192350003|**Case Processing Agent**|
|192350004|**Customer Engagement Agent**|

### <a name="BKMK_msdyn_clienttimestamp"></a> msdyn_clienttimestamp

|Property|Value|
|---|---|
|Description|**Utc Timestamp from client**|
|DisplayName|**Client Timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_clienttimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_copiloteventId"></a> msdyn_copiloteventId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Copilot Event**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_copiloteventid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_interactioncontext"></a> msdyn_interactioncontext

|Property|Value|
|---|---|
|Description|**Stores additional context about the interaction**|
|DisplayName|**Interaction Context**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactioncontext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_interactionforid"></a> msdyn_interactionforid

|Property|Value|
|---|---|
|Description|**Id of the record to which this interaction is associated**|
|DisplayName|**Interaction For Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactionforid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_interactionforlogicalname"></a> msdyn_interactionforlogicalname

|Property|Value|
|---|---|
|Description|**LogicalName of the record to which this interaction is associated**|
|DisplayName|**Interaction For Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactionforlogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_interactiontype"></a> msdyn_interactiontype

|Property|Value|
|---|---|
|Description|**Identifies the type of interaction**|
|DisplayName|**Interaction Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactiontype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_interactiontype`|

#### msdyn_interactiontype Choices/Options

|Value|Label|
|---|---|
|100230301|**ThumbsUp**|
|100230302|**ThumbsDown**|
|100230303|**ThumbsClear**|
|100230304|**Copy**|
|100230305|**Generated**|
|100230306|**SendToCustomer**|
|100230307|**EditAndSend**|
|100230308|**ManualCopy**|
|100230309|**Available**|
|100230310|**ArticleProposed**|
|100230311|**MarkAsReviewed**|
|100230312|**AcceptSuggestion**|
|100230313|**ViewHistory**|
|100230314|**ExpandTile**|
|100230315|**RequestSolution**|
|100230316|**KeepIt**|
|100230317|**Discard**|
|100230318|**ChooseDifferentTemplate**|
|100230319|**TemplateSelection**|
|100230320|**EmailSent**|
|100230321|**EmailDrafted**|
|100230322|**RecordUpdated**|
|100230323|**ResolveCase**|
|100230324|**Escalate**|
|100230325|**TemplateRecommended**|
|100230326|**CheckSources**|
|100230327|**TemplateInstantiation**|
|100230328|**AboutThisSuggestion**|

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

### <a name="BKMK_msdyn_scenariorequestid"></a> msdyn_scenariorequestid

|Property|Value|
|---|---|
|Description|**Unique identifier that ties the request across layers**|
|DisplayName|**Scenario Request Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scenariorequestid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_scenariotype"></a> msdyn_scenariotype

|Property|Value|
|---|---|
|Description|**Identifies the type of scenario**|
|DisplayName|**Scenario Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scenariotype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_scenariotype`|

#### msdyn_scenariotype Choices/Options

|Value|Label|
|---|---|
|100230201|**Ask a question**|
|100230202|**Live conversation response**|
|100230203|**Write an email**|
|100230204|**Copilot**|
|100230205|**Case summary**|
|100230206|**Live conversation summary**|
|100230207|**Timeline highlights**|
|100230208|**Knowledge draft assist**|
|100230209|**Custom entity summary**|
|100230210|**Collaborate with SMEs**|
|100230211|**Inline Copilot for email**|
|100230212|**Timeline next best actions**|
|100230213|**Intent Assist**|
|100230214|**knowledge harvest**|
|100230215|**Resolution notes**|
|100230216|**Chat Assist**|
|100230217|**Teams collaboration summary**|
|100230218|**Autonomous Case Create and Update**|
|100230219|**Proactive Insights**|
|100230220|**Quality Evaluation**|
|100230321|**Enrich record**|
|100230322|**Resolve case**|
|100230323|**Case Follow Up**|
|100230324|**Case Closure**|
|100230325|**Workload**|

### <a name="BKMK_msdyn_verbatim"></a> msdyn_verbatim

|Property|Value|
|---|---|
|Description|**Contains the verbatim feedback**|
|DisplayName|**Verbatim**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_verbatim`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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
- [msdyn_interactiondata](#BKMK_msdyn_interactiondata)
- [msdyn_interactiondata_Name](#BKMK_msdyn_interactiondata_Name)
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

### <a name="BKMK_msdyn_interactiondata"></a> msdyn_interactiondata

|Property|Value|
|---|---|
|Description|**Stores the contents of the Copilot interaction**|
|DisplayName|**Interaction Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactiondata`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|32768|

### <a name="BKMK_msdyn_interactiondata_Name"></a> msdyn_interactiondata_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_interactiondata_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

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

- [business_unit_msdyn_copilotevent](#BKMK_business_unit_msdyn_copilotevent)
- [ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata](#BKMK_ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata)
- [lk_msdyn_copilotevent_createdby](#BKMK_lk_msdyn_copilotevent_createdby)
- [lk_msdyn_copilotevent_createdonbehalfby](#BKMK_lk_msdyn_copilotevent_createdonbehalfby)
- [lk_msdyn_copilotevent_modifiedby](#BKMK_lk_msdyn_copilotevent_modifiedby)
- [lk_msdyn_copilotevent_modifiedonbehalfby](#BKMK_lk_msdyn_copilotevent_modifiedonbehalfby)
- [owner_msdyn_copilotevent](#BKMK_owner_msdyn_copilotevent)
- [team_msdyn_copilotevent](#BKMK_team_msdyn_copilotevent)
- [user_msdyn_copilotevent](#BKMK_user_msdyn_copilotevent)

### <a name="BKMK_business_unit_msdyn_copilotevent"></a> business_unit_msdyn_copilotevent

One-To-Many Relationship: [businessunit business_unit_msdyn_copilotevent](businessunit.md#BKMK_business_unit_msdyn_copilotevent)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata"></a> ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata

One-To-Many Relationship: [elasticfileattachment ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata](elasticfileattachment.md#BKMK_ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata)

|Property|Value|
|---|---|
|ReferencedEntity|`elasticfileattachment`|
|ReferencedAttribute|`elasticfileattachmentid`|
|ReferencingAttribute|`msdyn_interactiondata`|
|ReferencingEntityNavigationPropertyName|`msdyn_interactiondata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotevent_createdby"></a> lk_msdyn_copilotevent_createdby

One-To-Many Relationship: [systemuser lk_msdyn_copilotevent_createdby](systemuser.md#BKMK_lk_msdyn_copilotevent_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotevent_createdonbehalfby"></a> lk_msdyn_copilotevent_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_copilotevent_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_copilotevent_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotevent_modifiedby"></a> lk_msdyn_copilotevent_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_copilotevent_modifiedby](systemuser.md#BKMK_lk_msdyn_copilotevent_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotevent_modifiedonbehalfby"></a> lk_msdyn_copilotevent_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_copilotevent_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_copilotevent_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_copilotevent"></a> owner_msdyn_copilotevent

One-To-Many Relationship: [owner owner_msdyn_copilotevent](owner.md#BKMK_owner_msdyn_copilotevent)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_copilotevent"></a> team_msdyn_copilotevent

One-To-Many Relationship: [team team_msdyn_copilotevent](team.md#BKMK_team_msdyn_copilotevent)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_copilotevent"></a> user_msdyn_copilotevent

One-To-Many Relationship: [systemuser user_msdyn_copilotevent](systemuser.md#BKMK_user_msdyn_copilotevent)

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

### <a name="BKMK_msdyn_copilotevent_ElasticFileAttachments"></a> msdyn_copilotevent_ElasticFileAttachments

Many-To-One Relationship: [elasticfileattachment msdyn_copilotevent_ElasticFileAttachments](elasticfileattachment.md#BKMK_msdyn_copilotevent_ElasticFileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`elasticfileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotevent_ElasticFileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

