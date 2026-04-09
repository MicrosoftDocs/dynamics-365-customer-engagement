---
title: "Evaluation Plan Run (msdyn_EvaluationPlanRun) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Evaluation Plan Run (msdyn_EvaluationPlanRun) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Evaluation Plan Run (msdyn_EvaluationPlanRun) table/entity reference (Microsoft Dynamics 365)

Contains configuration for creating evaluations in Bulk for Evaluation Plan

## Messages

The following table lists the messages for the Evaluation Plan Run (msdyn_EvaluationPlanRun) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_evaluationplanruns(*msdyn_evaluationplanrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_evaluationplanruns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_evaluationplanruns(*msdyn_evaluationplanrunid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_evaluationplanruns(*msdyn_evaluationplanrunid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_evaluationplanruns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_evaluationplanruns(*msdyn_evaluationplanrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_evaluationplanruns(*msdyn_evaluationplanrunid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_evaluationplanruns(*msdyn_evaluationplanrunid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Evaluation Plan Run (msdyn_EvaluationPlanRun) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Evaluation Plan Run** |
| **DisplayCollectionName** | **Evaluation Plan Runs** |
| **SchemaName** | `msdyn_EvaluationPlanRun` |
| **CollectionSchemaName** | `msdyn_EvaluationPlanRuns` |
| **EntitySetName** | `msdyn_evaluationplanruns`|
| **LogicalName** | `msdyn_evaluationplanrun` |
| **LogicalCollectionName** | `msdyn_evaluationplanruns` |
| **PrimaryIdAttribute** | `msdyn_evaluationplanrunid` |
| **PrimaryNameAttribute** |`msdyn_planname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AssignedTo](#BKMK_msdyn_AssignedTo)
- [msdyn_DueDate](#BKMK_msdyn_DueDate)
- [msdyn_EvaluationCriteria](#BKMK_msdyn_EvaluationCriteria)
- [msdyn_Evaluationmethod](#BKMK_msdyn_Evaluationmethod)
- [msdyn_EvaluationPlan](#BKMK_msdyn_EvaluationPlan)
- [msdyn_EvaluationPlanEndDate](#BKMK_msdyn_EvaluationPlanEndDate)
- [msdyn_EvaluationPlanRunId](#BKMK_msdyn_EvaluationPlanRunId)
- [msdyn_EvaluationPlanStartDate](#BKMK_msdyn_EvaluationPlanStartDate)
- [msdyn_FilterRulesXML](#BKMK_msdyn_FilterRulesXML)
- [msdyn_PageIndex](#BKMK_msdyn_PageIndex)
- [msdyn_PaginationMarker](#BKMK_msdyn_PaginationMarker)
- [msdyn_PlanName](#BKMK_msdyn_PlanName)
- [msdyn_RecordsIdentificationCompletedOn](#BKMK_msdyn_RecordsIdentificationCompletedOn)
- [msdyn_RecordType](#BKMK_msdyn_RecordType)
- [msdyn_TotalRecordsDiscovered](#BKMK_msdyn_TotalRecordsDiscovered)
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

### <a name="BKMK_msdyn_AssignedTo"></a> msdyn_AssignedTo

|Property|Value|
|---|---|
|Description|**User or team to whom the evaluation plan is assigned.**|
|DisplayName|**Assigned To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignedto`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_DueDate"></a> msdyn_DueDate

|Property|Value|
|---|---|
|Description|**Expiry date for evaluation plan**|
|DisplayName|**Due Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duedate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EvaluationCriteria"></a> msdyn_EvaluationCriteria

|Property|Value|
|---|---|
|Description|**Lookup field for evaluation criteria**|
|DisplayName|**Evaluation Criteria**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationcriteria`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_evaluationcriteria|

### <a name="BKMK_msdyn_Evaluationmethod"></a> msdyn_Evaluationmethod

|Property|Value|
|---|---|
|Description|**The method the evaluation went through.**|
|DisplayName|**Evaluation method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationmethod`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_evaluationmethod`|

#### msdyn_Evaluationmethod Choices/Options

|Value|Label|
|---|---|
|700610000|**AI assisted**|
|700610001|**AI agent**|
|700610002|**Manual**|

### <a name="BKMK_msdyn_EvaluationPlan"></a> msdyn_EvaluationPlan

|Property|Value|
|---|---|
|Description|**Lookup field for evaluation plan.**|
|DisplayName|**Evaluation Plan**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationplan`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_evaluationplan|

### <a name="BKMK_msdyn_EvaluationPlanEndDate"></a> msdyn_EvaluationPlanEndDate

|Property|Value|
|---|---|
|Description|**Evaluation Plan End Date**|
|DisplayName|**Evaluation Plan End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationplanenddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EvaluationPlanRunId"></a> msdyn_EvaluationPlanRunId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Evaluation Plan Run**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationplanrunid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_EvaluationPlanStartDate"></a> msdyn_EvaluationPlanStartDate

|Property|Value|
|---|---|
|Description|**Evaluation Plan Start Date**|
|DisplayName|**Evaluation Plan Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationplanstartdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_FilterRulesXML"></a> msdyn_FilterRulesXML

|Property|Value|
|---|---|
|Description|**Evaluation filter rules in XML format.**|
|DisplayName|**Filter Rules XML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_filterrulesxml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_PageIndex"></a> msdyn_PageIndex

|Property|Value|
|---|---|
|Description|**Index for pagination**|
|DisplayName|**Page Index**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pageindex`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_PaginationMarker"></a> msdyn_PaginationMarker

|Property|Value|
|---|---|
|Description|**Pagination marker**|
|DisplayName|**Pagination Marker**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_paginationmarker`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_PlanName"></a> msdyn_PlanName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Plan Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_planname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_RecordsIdentificationCompletedOn"></a> msdyn_RecordsIdentificationCompletedOn

|Property|Value|
|---|---|
|Description|**Date and time when the records identification was completed.**|
|DisplayName|**Records Identification Completed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordsidentificationcompletedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_RecordType"></a> msdyn_RecordType

|Property|Value|
|---|---|
|Description|**Record type selected for evaluation**|
|DisplayName|**Record Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_evaluationrecordtype`|

#### msdyn_RecordType Choices/Options

|Value|Label|
|---|---|
|0|**Case**|
|1|**Conversation**|

### <a name="BKMK_msdyn_TotalRecordsDiscovered"></a> msdyn_TotalRecordsDiscovered

|Property|Value|
|---|---|
|Description|**Total count of number of records discovered**|
|DisplayName|**Total Records**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalrecordsdiscovered`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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
|Description|**Status of the Evaluation Plan Run**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationplanrun_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **InProgress**<br />DefaultStatus: 1<br />InvariantName: `InProgress`|
|1|Label: **Completed**<br />DefaultStatus: 4<br />InvariantName: `Completed`|
|2|Label: **Failed**<br />DefaultStatus: 5<br />InvariantName: `Failed`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Evaluation Plan Run**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationplanrun_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Ready**<br />State:0<br />TransitionData: None|
|2|Label: **RecordIdentificationInProgress**<br />State:0<br />TransitionData: None|
|3|Label: **RecordIdentificationCompleted**<br />State:0<br />TransitionData: None|
|4|Label: **Completed**<br />State:1<br />TransitionData: None|
|5|Label: **RecordIdentificationFailed**<br />State:2<br />TransitionData: None|

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

- [business_unit_msdyn_evaluationplanrun](#BKMK_business_unit_msdyn_evaluationplanrun)
- [lk_msdyn_evaluationplanrun_createdby](#BKMK_lk_msdyn_evaluationplanrun_createdby)
- [lk_msdyn_evaluationplanrun_createdonbehalfby](#BKMK_lk_msdyn_evaluationplanrun_createdonbehalfby)
- [lk_msdyn_evaluationplanrun_modifiedby](#BKMK_lk_msdyn_evaluationplanrun_modifiedby)
- [lk_msdyn_evaluationplanrun_modifiedonbehalfby](#BKMK_lk_msdyn_evaluationplanrun_modifiedonbehalfby)
- [msdyn_evaluationplanrun_AssignedTo_systemuser](#BKMK_msdyn_evaluationplanrun_AssignedTo_systemuser)
- [msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria)
- [msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan](#BKMK_msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan)
- [owner_msdyn_evaluationplanrun](#BKMK_owner_msdyn_evaluationplanrun)
- [team_msdyn_evaluationplanrun](#BKMK_team_msdyn_evaluationplanrun)
- [user_msdyn_evaluationplanrun](#BKMK_user_msdyn_evaluationplanrun)

### <a name="BKMK_business_unit_msdyn_evaluationplanrun"></a> business_unit_msdyn_evaluationplanrun

One-To-Many Relationship: [businessunit business_unit_msdyn_evaluationplanrun](businessunit.md#BKMK_business_unit_msdyn_evaluationplanrun)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplanrun_createdby"></a> lk_msdyn_evaluationplanrun_createdby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplanrun_createdby](systemuser.md#BKMK_lk_msdyn_evaluationplanrun_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplanrun_createdonbehalfby"></a> lk_msdyn_evaluationplanrun_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplanrun_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationplanrun_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplanrun_modifiedby"></a> lk_msdyn_evaluationplanrun_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplanrun_modifiedby](systemuser.md#BKMK_lk_msdyn_evaluationplanrun_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplanrun_modifiedonbehalfby"></a> lk_msdyn_evaluationplanrun_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplanrun_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationplanrun_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationplanrun_AssignedTo_systemuser"></a> msdyn_evaluationplanrun_AssignedTo_systemuser

One-To-Many Relationship: [systemuser msdyn_evaluationplanrun_AssignedTo_systemuser](systemuser.md#BKMK_msdyn_evaluationplanrun_AssignedTo_systemuser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_assignedto`|
|ReferencingEntityNavigationPropertyName|`msdyn_AssignedTo`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria"></a> msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria

One-To-Many Relationship: [msdyn_evaluationcriteria msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria](msdyn_evaluationcriteria.md#BKMK_msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationcriteria`|
|ReferencedAttribute|`msdyn_evaluationcriteriaid`|
|ReferencingAttribute|`msdyn_evaluationcriteria`|
|ReferencingEntityNavigationPropertyName|`msdyn_EvaluationCriteria`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan"></a> msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan

One-To-Many Relationship: [msdyn_evaluationplan msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan](msdyn_evaluationplan.md#BKMK_msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationplan`|
|ReferencedAttribute|`msdyn_evaluationplanid`|
|ReferencingAttribute|`msdyn_evaluationplan`|
|ReferencingEntityNavigationPropertyName|`msdyn_EvaluationPlan`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_evaluationplanrun"></a> owner_msdyn_evaluationplanrun

One-To-Many Relationship: [owner owner_msdyn_evaluationplanrun](owner.md#BKMK_owner_msdyn_evaluationplanrun)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_evaluationplanrun"></a> team_msdyn_evaluationplanrun

One-To-Many Relationship: [team team_msdyn_evaluationplanrun](team.md#BKMK_team_msdyn_evaluationplanrun)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_evaluationplanrun"></a> user_msdyn_evaluationplanrun

One-To-Many Relationship: [systemuser user_msdyn_evaluationplanrun](systemuser.md#BKMK_user_msdyn_evaluationplanrun)

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

- [msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun](#BKMK_msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun)
- [msdyn_evaluationplanrun_AsyncOperations](#BKMK_msdyn_evaluationplanrun_AsyncOperations)
- [msdyn_evaluationplanrun_BulkDeleteFailures](#BKMK_msdyn_evaluationplanrun_BulkDeleteFailures)
- [msdyn_evaluationplanrun_DuplicateBaseRecord](#BKMK_msdyn_evaluationplanrun_DuplicateBaseRecord)
- [msdyn_evaluationplanrun_DuplicateMatchingRecord](#BKMK_msdyn_evaluationplanrun_DuplicateMatchingRecord)
- [msdyn_evaluationplanrun_MailboxTrackingFolders](#BKMK_msdyn_evaluationplanrun_MailboxTrackingFolders)
- [msdyn_evaluationplanrun_PrincipalObjectAttributeAccesses](#BKMK_msdyn_evaluationplanrun_PrincipalObjectAttributeAccesses)
- [msdyn_evaluationplanrun_ProcessSession](#BKMK_msdyn_evaluationplanrun_ProcessSession)
- [msdyn_evaluationplanrun_SyncErrors](#BKMK_msdyn_evaluationplanrun_SyncErrors)

### <a name="BKMK_msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun"></a> msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun

Many-To-One Relationship: [msdyn_evaluationplanbatch msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun](msdyn_evaluationplanbatch.md#BKMK_msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationplanbatch`|
|ReferencingAttribute|`msdyn_evaluationplanrun`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanbatch_EvaluationPlanRun_msdyn_evaluationplanrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_AsyncOperations"></a> msdyn_evaluationplanrun_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_evaluationplanrun_AsyncOperations](asyncoperation.md#BKMK_msdyn_evaluationplanrun_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_BulkDeleteFailures"></a> msdyn_evaluationplanrun_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_evaluationplanrun_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_evaluationplanrun_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_DuplicateBaseRecord"></a> msdyn_evaluationplanrun_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_evaluationplanrun_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_evaluationplanrun_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_DuplicateMatchingRecord"></a> msdyn_evaluationplanrun_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_evaluationplanrun_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_evaluationplanrun_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_MailboxTrackingFolders"></a> msdyn_evaluationplanrun_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_evaluationplanrun_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_evaluationplanrun_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_PrincipalObjectAttributeAccesses"></a> msdyn_evaluationplanrun_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_evaluationplanrun_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_evaluationplanrun_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_ProcessSession"></a> msdyn_evaluationplanrun_ProcessSession

Many-To-One Relationship: [processsession msdyn_evaluationplanrun_ProcessSession](processsession.md#BKMK_msdyn_evaluationplanrun_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_SyncErrors"></a> msdyn_evaluationplanrun_SyncErrors

Many-To-One Relationship: [syncerror msdyn_evaluationplanrun_SyncErrors](syncerror.md#BKMK_msdyn_evaluationplanrun_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

