---
title: "Opportunity Research Result (msdyn_OpportunityResearchResult) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Opportunity Research Result (msdyn_OpportunityResearchResult) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Opportunity Research Result (msdyn_OpportunityResearchResult) table/entity reference (Microsoft Dynamics 365)

Opportunity Research Result

## Messages

The following table lists the messages for the Opportunity Research Result (msdyn_OpportunityResearchResult) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_opportunityresearchresults<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_opportunityresearchresults(*msdyn_opportunityresearchresultid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_opportunityresearchresults(*msdyn_opportunityresearchresultid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_opportunityresearchresults<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_opportunityresearchresults(*msdyn_opportunityresearchresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_opportunityresearchresults(*msdyn_opportunityresearchresultid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_opportunityresearchresults(*msdyn_opportunityresearchresultid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Opportunity Research Result (msdyn_OpportunityResearchResult) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Opportunity Research Result** |
| **DisplayCollectionName** | **Opportunity Research Results** |
| **SchemaName** | `msdyn_OpportunityResearchResult` |
| **CollectionSchemaName** | `msdyn_OpportunityResearchResults` |
| **EntitySetName** | `msdyn_opportunityresearchresults`|
| **LogicalName** | `msdyn_opportunityresearchresult` |
| **LogicalCollectionName** | `msdyn_opportunityresearchresults` |
| **PrimaryIdAttribute** | `msdyn_opportunityresearchresultid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customresearchinsightconfigid](#BKMK_msdyn_customresearchinsightconfigid)
- [msdyn_IsResearchStale](#BKMK_msdyn_IsResearchStale)
- [msdyn_macroagentorchestrationid](#BKMK_msdyn_macroagentorchestrationid)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_Opportunity](#BKMK_msdyn_Opportunity)
- [msdyn_OpportunityId](#BKMK_msdyn_OpportunityId)
- [msdyn_OpportunityResearchResultId](#BKMK_msdyn_OpportunityResearchResultId)
- [msdyn_OpportunityResearchTopic](#BKMK_msdyn_OpportunityResearchTopic)
- [msdyn_OpportunityResearchTopicResult](#BKMK_msdyn_OpportunityResearchTopicResult)
- [msdyn_SalesAgentRunId](#BKMK_msdyn_SalesAgentRunId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_customresearchinsightconfigid"></a> msdyn_customresearchinsightconfigid

|Property|Value|
|---|---|
|Description|**Custom Research Insight Config Id**|
|DisplayName|**Custom Research Insight Config Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customresearchinsightconfigid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_IsResearchStale"></a> msdyn_IsResearchStale

|Property|Value|
|---|---|
|Description|**Marks whether the research results are stale for this Opportunity**|
|DisplayName|**Is Research Stale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isresearchstale`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_isresearchstale_optionset`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

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
|MaxLength|850|

### <a name="BKMK_msdyn_Opportunity"></a> msdyn_Opportunity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Opportunity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

### <a name="BKMK_msdyn_OpportunityId"></a> msdyn_OpportunityId

|Property|Value|
|---|---|
|Description|**Opportunity Id**|
|DisplayName|**Opportunity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_OpportunityResearchResultId"></a> msdyn_OpportunityResearchResultId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Opportunity Research Result**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityresearchresultid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_OpportunityResearchTopic"></a> msdyn_OpportunityResearchTopic

|Property|Value|
|---|---|
|Description|**Opportunity Research Topic**|
|DisplayName|**Opportunity Research Topic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityresearchtopic`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_opportunityresearchtopicchoice`|

#### msdyn_OpportunityResearchTopic Choices/Options

|Value|Label|
|---|---|
|100000000|**Deal Overview**|
|100000001|**Deal Risk**|
|100000002|**Deal Importance**|
|100000003|**Deal Health**|
|100000004|**Needs and Pain Points**|
|100000005|**Stakeholder Insights**|
|100000006|**Account Insights**|
|100000007|**Key Deal Insights**|
|100000008|**Key Updates**|
|100000009|**Competitor Insights**|
|100000010|**Related Conversation Mapping**|
|100000011|**Deal Summary**|
|100000012|**Chain Of Thoughts**|
|100000013|**Custom OOB Account Research**|
|100000014|**Custom Research Insight**|
|100000015|**Summerized Account Research**|

### <a name="BKMK_msdyn_OpportunityResearchTopicResult"></a> msdyn_OpportunityResearchTopicResult

|Property|Value|
|---|---|
|Description|**Opportunity Research Topic Result**|
|DisplayName|**Opportunity Research Topic Result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityresearchtopicresult`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_SalesAgentRunId"></a> msdyn_SalesAgentRunId

|Property|Value|
|---|---|
|Description|**Sales Agent Run Id**|
|DisplayName|**Sales Agent Run Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentrunid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Opportunity Research Result**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_opportunityresearchresult_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Opportunity Research Result**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_opportunityresearchresult_statuscode`|

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
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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

- [lk_msdyn_opportunityresearchresult_createdby](#BKMK_lk_msdyn_opportunityresearchresult_createdby)
- [lk_msdyn_opportunityresearchresult_createdonbehalfby](#BKMK_lk_msdyn_opportunityresearchresult_createdonbehalfby)
- [lk_msdyn_opportunityresearchresult_modifiedby](#BKMK_lk_msdyn_opportunityresearchresult_modifiedby)
- [lk_msdyn_opportunityresearchresult_modifiedonbehalfby](#BKMK_lk_msdyn_opportunityresearchresult_modifiedonbehalfby)
- [msdyn_OpportunityResearchResult_Opportunity_Opportunity](#BKMK_msdyn_OpportunityResearchResult_Opportunity_Opportunity)

### <a name="BKMK_lk_msdyn_opportunityresearchresult_createdby"></a> lk_msdyn_opportunityresearchresult_createdby

One-To-Many Relationship: [systemuser lk_msdyn_opportunityresearchresult_createdby](systemuser.md#BKMK_lk_msdyn_opportunityresearchresult_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunityresearchresult_createdonbehalfby"></a> lk_msdyn_opportunityresearchresult_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_opportunityresearchresult_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_opportunityresearchresult_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunityresearchresult_modifiedby"></a> lk_msdyn_opportunityresearchresult_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_opportunityresearchresult_modifiedby](systemuser.md#BKMK_lk_msdyn_opportunityresearchresult_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunityresearchresult_modifiedonbehalfby"></a> lk_msdyn_opportunityresearchresult_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_opportunityresearchresult_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_opportunityresearchresult_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_OpportunityResearchResult_Opportunity_Opportunity"></a> msdyn_OpportunityResearchResult_Opportunity_Opportunity

One-To-Many Relationship: [opportunity msdyn_OpportunityResearchResult_Opportunity_Opportunity](opportunity.md#BKMK_msdyn_OpportunityResearchResult_Opportunity_Opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_opportunity`|
|ReferencingEntityNavigationPropertyName|`msdyn_Opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_opportunityresearchresult_AsyncOperations](#BKMK_msdyn_opportunityresearchresult_AsyncOperations)
- [msdyn_opportunityresearchresult_BulkDeleteFailures](#BKMK_msdyn_opportunityresearchresult_BulkDeleteFailures)
- [msdyn_opportunityresearchresult_MailboxTrackingFolders](#BKMK_msdyn_opportunityresearchresult_MailboxTrackingFolders)
- [msdyn_opportunityresearchresult_PrincipalObjectAttributeAccesses](#BKMK_msdyn_opportunityresearchresult_PrincipalObjectAttributeAccesses)
- [msdyn_opportunityresearchresult_ProcessSession](#BKMK_msdyn_opportunityresearchresult_ProcessSession)
- [msdyn_opportunityresearchresult_SyncErrors](#BKMK_msdyn_opportunityresearchresult_SyncErrors)

### <a name="BKMK_msdyn_opportunityresearchresult_AsyncOperations"></a> msdyn_opportunityresearchresult_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_opportunityresearchresult_AsyncOperations](asyncoperation.md#BKMK_msdyn_opportunityresearchresult_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchresult_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchresult_BulkDeleteFailures"></a> msdyn_opportunityresearchresult_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_opportunityresearchresult_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_opportunityresearchresult_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchresult_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchresult_MailboxTrackingFolders"></a> msdyn_opportunityresearchresult_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_opportunityresearchresult_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_opportunityresearchresult_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchresult_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchresult_PrincipalObjectAttributeAccesses"></a> msdyn_opportunityresearchresult_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_opportunityresearchresult_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_opportunityresearchresult_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchresult_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchresult_ProcessSession"></a> msdyn_opportunityresearchresult_ProcessSession

Many-To-One Relationship: [processsession msdyn_opportunityresearchresult_ProcessSession](processsession.md#BKMK_msdyn_opportunityresearchresult_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchresult_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchresult_SyncErrors"></a> msdyn_opportunityresearchresult_SyncErrors

Many-To-One Relationship: [syncerror msdyn_opportunityresearchresult_SyncErrors](syncerror.md#BKMK_msdyn_opportunityresearchresult_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchresult_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

