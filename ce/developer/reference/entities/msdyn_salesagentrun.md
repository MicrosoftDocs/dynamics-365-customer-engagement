---
title: "Sales agent run (msdyn_salesagentrun) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sales agent run (msdyn_salesagentrun) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sales agent run (msdyn_salesagentrun) table/entity reference (Microsoft Dynamics 365)

This table contains records of sales agent runs.

## Messages

The following table lists the messages for the Sales agent run (msdyn_salesagentrun) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_salesagentruns(*msdyn_salesagentrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_salesagentruns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_salesagentruns(*msdyn_salesagentrunid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salesagentruns(*msdyn_salesagentrunid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salesagentruns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_salesagentruns(*msdyn_salesagentrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_salesagentruns(*msdyn_salesagentrunid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salesagentruns(*msdyn_salesagentrunid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sales agent run (msdyn_salesagentrun) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sales agent run** |
| **DisplayCollectionName** | **Sales agent runs** |
| **SchemaName** | `msdyn_salesagentrun` |
| **CollectionSchemaName** | `msdyn_salesagentruns` |
| **EntitySetName** | `msdyn_salesagentruns`|
| **LogicalName** | `msdyn_salesagentrun` |
| **LogicalCollectionName** | `msdyn_salesagentruns` |
| **PrimaryIdAttribute** | `msdyn_salesagentrunid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentoutputentityid](#BKMK_msdyn_agentoutputentityid)
- [msdyn_agentoutputentityname](#BKMK_msdyn_agentoutputentityname)
- [msdyn_agenttype](#BKMK_msdyn_agenttype)
- [msdyn_endtime](#BKMK_msdyn_endtime)
- [msdyn_macroagentorchestrationid](#BKMK_msdyn_macroagentorchestrationid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_previoussalesagentrunid](#BKMK_msdyn_previoussalesagentrunid)
- [msdyn_regardingid](#BKMK_msdyn_regardingid)
- [msdyn_regardingidIdType](#BKMK_msdyn_regardingidIdType)
- [msdyn_salesagentprofileid](#BKMK_msdyn_salesagentprofileid)
- [msdyn_salesagentrunId](#BKMK_msdyn_salesagentrunId)
- [msdyn_starttime](#BKMK_msdyn_starttime)
- [msdyn_stepentityid](#BKMK_msdyn_stepentityid)
- [msdyn_stepentityname](#BKMK_msdyn_stepentityname)
- [msdyn_triggers](#BKMK_msdyn_triggers)
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

### <a name="BKMK_msdyn_agentoutputentityid"></a> msdyn_agentoutputentityid

|Property|Value|
|---|---|
|Description|**Agent Output Entity Id**|
|DisplayName|**Agent Output Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentoutputentityid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_agentoutputentityname"></a> msdyn_agentoutputentityname

|Property|Value|
|---|---|
|Description|**Agent Output Entity Name**|
|DisplayName|**Agent Output Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentoutputentityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_agenttype"></a> msdyn_agenttype

|Property|Value|
|---|---|
|Description|**Type of agent**|
|DisplayName|**Agent type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agenttype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salesagentrun_msdyn_agenttype`|

#### msdyn_agenttype Choices/Options

|Value|Label|
|---|---|
|1|**EmailValidationAgent**|
|2|**ResearchAgent**|
|3|**OutreachAgent**|
|4|**EngageAgent**|
|5|**CompetitorAgent**|
|6|**StakeholderAgent**|
|7|**Handover Microagent**|
|8|**AccountResearchAgent**|
|9|**RelatedConversationAgent**|
|10|**OpportunityCompetitorResearch**|
|11|**OpportunityStakeholderResearch**|
|12|**OpportunityResearchAgent**|
|13|**DCAOutreachAgent**|
|14|**DCAEngageAgent**|

### <a name="BKMK_msdyn_endtime"></a> msdyn_endtime

|Property|Value|
|---|---|
|Description||
|DisplayName|**msdyn\_endtime**|
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

### <a name="BKMK_msdyn_macroagentorchestrationid"></a> msdyn_macroagentorchestrationid

|Property|Value|
|---|---|
|Description|**Unique Id for the current agent orchestration run**|
|DisplayName|**Agent Orchestration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_macroagentorchestrationid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the activity mapping entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_previoussalesagentrunid"></a> msdyn_previoussalesagentrunid

|Property|Value|
|---|---|
|Description|**Previous Sales Agent Run Id**|
|DisplayName|**Previous Sales Agent Run Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_previoussalesagentrunid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_salesagentrun|

### <a name="BKMK_msdyn_regardingid"></a> msdyn_regardingid

|Property|Value|
|---|---|
|Description|**Unique identifier of the object with which the run is associated.**|
|DisplayName|**Regarding id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, contact, lead, opportunity|

### <a name="BKMK_msdyn_regardingidIdType"></a> msdyn_regardingidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_salesagentprofileid"></a> msdyn_salesagentprofileid

|Property|Value|
|---|---|
|Description||
|DisplayName|**SalesAgentProfile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentprofileid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_salesagentprofile|

### <a name="BKMK_msdyn_salesagentrunId"></a> msdyn_salesagentrunId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sales agent run**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentrunid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_starttime"></a> msdyn_starttime

|Property|Value|
|---|---|
|Description||
|DisplayName|**msdyn\_starttime**|
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

### <a name="BKMK_msdyn_stepentityid"></a> msdyn_stepentityid

|Property|Value|
|---|---|
|Description|**Step Id**|
|DisplayName|**Step Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_stepentityid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_stepentityname"></a> msdyn_stepentityname

|Property|Value|
|---|---|
|Description|**Step Entity Name**|
|DisplayName|**Step Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_stepentityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_triggers"></a> msdyn_triggers

|Property|Value|
|---|---|
|Description|**List of associated triggers created to re-run sales micro-agents.**|
|DisplayName|**Triggers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_triggers`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

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
|Description|**Status of the Sales agent run**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesagentrun_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Completed**<br />DefaultStatus: 3<br />InvariantName: `Completed`|
|2|Label: **Failed**<br />DefaultStatus: 5<br />InvariantName: `Failed`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sales agent run**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesagentrun_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **NotStarted**<br />State:0<br />TransitionData: None|
|2|Label: **Started**<br />State:0<br />TransitionData: None|
|3|Label: **Completed**<br />State:1<br />TransitionData: None|
|4|Label: **InValidEmail**<br />State:1<br />TransitionData: None|
|5|Label: **Failed**<br />State:2<br />TransitionData: None|
|6|Label: **Skipped**<br />State:1<br />TransitionData: None|
|7|Label: **PendingRetry**<br />State:0<br />TransitionData: None|
|8|Label: **MissingFields**<br />State:1<br />TransitionData: None|

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
|RequiredLevel|SystemRequired|
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

- [business_unit_msdyn_salesagentrun](#BKMK_business_unit_msdyn_salesagentrun)
- [lk_msdyn_salesagentrun_createdby](#BKMK_lk_msdyn_salesagentrun_createdby)
- [lk_msdyn_salesagentrun_createdonbehalfby](#BKMK_lk_msdyn_salesagentrun_createdonbehalfby)
- [lk_msdyn_salesagentrun_modifiedby](#BKMK_lk_msdyn_salesagentrun_modifiedby)
- [lk_msdyn_salesagentrun_modifiedonbehalfby](#BKMK_lk_msdyn_salesagentrun_modifiedonbehalfby)
- [msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile](#BKMK_msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile)
- [msdyn_salesagentrun_account](#BKMK_msdyn_salesagentrun_account)
- [msdyn_salesagentrun_contact](#BKMK_msdyn_salesagentrun_contact)
- [msdyn_salesagentrun_lead](#BKMK_msdyn_salesagentrun_lead)
- [msdyn_salesagentrun_msdyn_salesagentrun](#BKMK_msdyn_salesagentrun_msdyn_salesagentrun-many-to-one)
- [msdyn_salesagentrun_opportunity](#BKMK_msdyn_salesagentrun_opportunity)
- [owner_msdyn_salesagentrun](#BKMK_owner_msdyn_salesagentrun)
- [team_msdyn_salesagentrun](#BKMK_team_msdyn_salesagentrun)
- [user_msdyn_salesagentrun](#BKMK_user_msdyn_salesagentrun)

### <a name="BKMK_business_unit_msdyn_salesagentrun"></a> business_unit_msdyn_salesagentrun

One-To-Many Relationship: [businessunit business_unit_msdyn_salesagentrun](businessunit.md#BKMK_business_unit_msdyn_salesagentrun)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentrun_createdby"></a> lk_msdyn_salesagentrun_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentrun_createdby](systemuser.md#BKMK_lk_msdyn_salesagentrun_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentrun_createdonbehalfby"></a> lk_msdyn_salesagentrun_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentrun_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salesagentrun_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentrun_modifiedby"></a> lk_msdyn_salesagentrun_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentrun_modifiedby](systemuser.md#BKMK_lk_msdyn_salesagentrun_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentrun_modifiedonbehalfby"></a> lk_msdyn_salesagentrun_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentrun_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salesagentrun_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile"></a> msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile

One-To-Many Relationship: [msdyn_salesagentprofile msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile](msdyn_salesagentprofile.md#BKMK_msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salesagentprofile`|
|ReferencedAttribute|`msdyn_salesagentprofileid`|
|ReferencingAttribute|`msdyn_salesagentprofileid`|
|ReferencingEntityNavigationPropertyName|`msdyn_salesagentprofileid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesagentrun_account"></a> msdyn_salesagentrun_account

One-To-Many Relationship: [account msdyn_salesagentrun_account](account.md#BKMK_msdyn_salesagentrun_account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_regardingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_regardingid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesagentrun_contact"></a> msdyn_salesagentrun_contact

One-To-Many Relationship: [contact msdyn_salesagentrun_contact](contact.md#BKMK_msdyn_salesagentrun_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_regardingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_regardingid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesagentrun_lead"></a> msdyn_salesagentrun_lead

One-To-Many Relationship: [lead msdyn_salesagentrun_lead](lead.md#BKMK_msdyn_salesagentrun_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_regardingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_regardingid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesagentrun_msdyn_salesagentrun-many-to-one"></a> msdyn_salesagentrun_msdyn_salesagentrun

One-To-Many Relationship: [msdyn_salesagentrun msdyn_salesagentrun_msdyn_salesagentrun](#BKMK_msdyn_salesagentrun_msdyn_salesagentrun-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salesagentrun`|
|ReferencedAttribute|`msdyn_salesagentrunid`|
|ReferencingAttribute|`msdyn_previoussalesagentrunid`|
|ReferencingEntityNavigationPropertyName|`msdyn_previoussalesagentrunid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesagentrun_opportunity"></a> msdyn_salesagentrun_opportunity

One-To-Many Relationship: [opportunity msdyn_salesagentrun_opportunity](opportunity.md#BKMK_msdyn_salesagentrun_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_regardingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_regardingid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_salesagentrun"></a> owner_msdyn_salesagentrun

One-To-Many Relationship: [owner owner_msdyn_salesagentrun](owner.md#BKMK_owner_msdyn_salesagentrun)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_salesagentrun"></a> team_msdyn_salesagentrun

One-To-Many Relationship: [team team_msdyn_salesagentrun](team.md#BKMK_team_msdyn_salesagentrun)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_salesagentrun"></a> user_msdyn_salesagentrun

One-To-Many Relationship: [systemuser user_msdyn_salesagentrun](systemuser.md#BKMK_user_msdyn_salesagentrun)

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

- [msdyn_salesagenthandover_msdyn_salesagentrun](#BKMK_msdyn_salesagenthandover_msdyn_salesagentrun)
- [msdyn_salesagentrun_AsyncOperations](#BKMK_msdyn_salesagentrun_AsyncOperations)
- [msdyn_salesagentrun_BulkDeleteFailures](#BKMK_msdyn_salesagentrun_BulkDeleteFailures)
- [msdyn_salesagentrun_MailboxTrackingFolders](#BKMK_msdyn_salesagentrun_MailboxTrackingFolders)
- [msdyn_salesagentrun_msdyn_engageandreadinessagentresult](#BKMK_msdyn_salesagentrun_msdyn_engageandreadinessagentresult)
- [msdyn_salesagentrun_msdyn_engagereadinessagentresult](#BKMK_msdyn_salesagentrun_msdyn_engagereadinessagentresult)
- [msdyn_salesagentrun_msdyn_salesagentrun](#BKMK_msdyn_salesagentrun_msdyn_salesagentrun-one-to-many)
- [msdyn_salesagentrun_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salesagentrun_PrincipalObjectAttributeAccesses)
- [msdyn_salesagentrun_ProcessSession](#BKMK_msdyn_salesagentrun_ProcessSession)
- [msdyn_salesagentrun_SyncErrors](#BKMK_msdyn_salesagentrun_SyncErrors)

### <a name="BKMK_msdyn_salesagenthandover_msdyn_salesagentrun"></a> msdyn_salesagenthandover_msdyn_salesagentrun

Many-To-One Relationship: [msdyn_salesagenthandover msdyn_salesagenthandover_msdyn_salesagentrun](msdyn_salesagenthandover.md#BKMK_msdyn_salesagenthandover_msdyn_salesagentrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesagenthandover`|
|ReferencingAttribute|`msdyn_salesagentrun`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagenthandover_msdyn_salesagentrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentrun_AsyncOperations"></a> msdyn_salesagentrun_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salesagentrun_AsyncOperations](asyncoperation.md#BKMK_msdyn_salesagentrun_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentrun_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentrun_BulkDeleteFailures"></a> msdyn_salesagentrun_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salesagentrun_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salesagentrun_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentrun_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentrun_MailboxTrackingFolders"></a> msdyn_salesagentrun_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salesagentrun_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salesagentrun_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentrun_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentrun_msdyn_engageandreadinessagentresult"></a> msdyn_salesagentrun_msdyn_engageandreadinessagentresult

Many-To-One Relationship: [msdyn_engageandreadinessagentresult msdyn_salesagentrun_msdyn_engageandreadinessagentresult](msdyn_engageandreadinessagentresult.md#BKMK_msdyn_salesagentrun_msdyn_engageandreadinessagentresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_engageandreadinessagentresult`|
|ReferencingAttribute|`msdyn_salesagentrun`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentrun_msdyn_engageandreadinessagentresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentrun_msdyn_engagereadinessagentresult"></a> msdyn_salesagentrun_msdyn_engagereadinessagentresult

Many-To-One Relationship: [msdyn_engagereadinessagentresult msdyn_salesagentrun_msdyn_engagereadinessagentresult](msdyn_engagereadinessagentresult.md#BKMK_msdyn_salesagentrun_msdyn_engagereadinessagentresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_engagereadinessagentresult`|
|ReferencingAttribute|`msdyn_salesagentrun`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentrun_msdyn_engagereadinessagentresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentrun_msdyn_salesagentrun-one-to-many"></a> msdyn_salesagentrun_msdyn_salesagentrun

Many-To-One Relationship: [msdyn_salesagentrun msdyn_salesagentrun_msdyn_salesagentrun](#BKMK_msdyn_salesagentrun_msdyn_salesagentrun-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesagentrun`|
|ReferencingAttribute|`msdyn_previoussalesagentrunid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentrun_msdyn_salesagentrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentrun_PrincipalObjectAttributeAccesses"></a> msdyn_salesagentrun_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salesagentrun_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salesagentrun_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentrun_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentrun_ProcessSession"></a> msdyn_salesagentrun_ProcessSession

Many-To-One Relationship: [processsession msdyn_salesagentrun_ProcessSession](processsession.md#BKMK_msdyn_salesagentrun_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentrun_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentrun_SyncErrors"></a> msdyn_salesagentrun_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salesagentrun_SyncErrors](syncerror.md#BKMK_msdyn_salesagentrun_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentrun_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

