---
title: "Evaluation Plan (msdyn_EvaluationPlan) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Evaluation Plan (msdyn_EvaluationPlan) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Evaluation Plan (msdyn_EvaluationPlan) table/entity reference (Microsoft Dynamics 365)

Has configuration for executing evaluations in Bulk for an entity.

## Messages

The following table lists the messages for the Evaluation Plan (msdyn_EvaluationPlan) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_evaluationplans(*msdyn_evaluationplanid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_evaluationplans<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_evaluationplans(*msdyn_evaluationplanid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_evaluationplans(*msdyn_evaluationplanid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_evaluationplans<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_evaluationplans(*msdyn_evaluationplanid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_evaluationplans(*msdyn_evaluationplanid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_evaluationplans(*msdyn_evaluationplanid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Evaluation Plan (msdyn_EvaluationPlan) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Evaluation Plan** |
| **DisplayCollectionName** | **Evaluation Plans** |
| **SchemaName** | `msdyn_EvaluationPlan` |
| **CollectionSchemaName** | `msdyn_EvaluationPlans` |
| **EntitySetName** | `msdyn_evaluationplans`|
| **LogicalName** | `msdyn_evaluationplan` |
| **LogicalCollectionName** | `msdyn_evaluationplans` |
| **PrimaryIdAttribute** | `msdyn_evaluationplanid` |
| **PrimaryNameAttribute** |`msdyn_planname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_AssignedTo](#BKMK_msdyn_AssignedTo)
- [msdyn_AssignedToIdType](#BKMK_msdyn_AssignedToIdType)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_DueDate](#BKMK_msdyn_DueDate)
- [msdyn_EvaluationCriteria](#BKMK_msdyn_EvaluationCriteria)
- [msdyn_EvaluationFilterRulesXML](#BKMK_msdyn_EvaluationFilterRulesXML)
- [msdyn_EvaluationMethod](#BKMK_msdyn_EvaluationMethod)
- [msdyn_EvaluationPlanId](#BKMK_msdyn_EvaluationPlanId)
- [msdyn_Event](#BKMK_msdyn_Event)
- [msdyn_Frequency](#BKMK_msdyn_Frequency)
- [msdyn_Occurrence](#BKMK_msdyn_Occurrence)
- [msdyn_PlanEndDate](#BKMK_msdyn_PlanEndDate)
- [msdyn_planname](#BKMK_msdyn_planname)
- [msdyn_PlanStartDate](#BKMK_msdyn_PlanStartDate)
- [msdyn_RecordType](#BKMK_msdyn_RecordType)
- [msdyn_UniqueName](#BKMK_msdyn_UniqueName)
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

### <a name="BKMK_msdyn_AssignedTo"></a> msdyn_AssignedTo

|Property|Value|
|---|---|
|Description|**User or team to whom the evaluation plan is assigned.**|
|DisplayName|**Assigned To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignedto`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|systemuser, team|

### <a name="BKMK_msdyn_AssignedToIdType"></a> msdyn_AssignedToIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_assignedtoidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**Description of the evaluation plan**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_msdyn_EvaluationFilterRulesXML"></a> msdyn_EvaluationFilterRulesXML

|Property|Value|
|---|---|
|Description|**Evaluation filter rules in XML format.**|
|DisplayName|**Evaluation Filter Rules XML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationfilterrulesxml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_EvaluationMethod"></a> msdyn_EvaluationMethod

|Property|Value|
|---|---|
|Description|**The method the evaluation went through.**|
|DisplayName|**Evaluation method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationmethod`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_evaluationmethod`|

#### msdyn_EvaluationMethod Choices/Options

|Value|Label|
|---|---|
|700610000|**AI assisted**|
|700610001|**AI agent**|
|700610002|**Manual**|

### <a name="BKMK_msdyn_EvaluationPlanId"></a> msdyn_EvaluationPlanId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Evaluation Plan**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationplanid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Event"></a> msdyn_Event

|Property|Value|
|---|---|
|Description|**Type of on trigger event for evaluation plan**|
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_event`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_evaluationplan_msdyn_event`|

#### msdyn_Event Choices/Options

|Value|Label|
|---|---|
|0|**Closed Conversation**|

### <a name="BKMK_msdyn_Frequency"></a> msdyn_Frequency

|Property|Value|
|---|---|
|Description|**The frequency of the evaluation plan.**|
|DisplayName|**Frequency**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_frequency`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_evaluationplan_msdyn_frequency`|

#### msdyn_Frequency Choices/Options

|Value|Label|
|---|---|
|0|**Once**|
|1|**Recurring**|
|2|**Trigger**|
|3|**Real-Time**|

### <a name="BKMK_msdyn_Occurrence"></a> msdyn_Occurrence

|Property|Value|
|---|---|
|Description|**The occurrence of the scheduled evaluation plan execution.**|
|DisplayName|**Occurrence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occurrence`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_evaluationplan_msdyn_occurrence`|

#### msdyn_Occurrence Choices/Options

|Value|Label|
|---|---|
|0|**Daily**|

### <a name="BKMK_msdyn_PlanEndDate"></a> msdyn_PlanEndDate

|Property|Value|
|---|---|
|Description|**Evaluation plan end date**|
|DisplayName|**Plan End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_planenddate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_planname"></a> msdyn_planname

|Property|Value|
|---|---|
|Description|**The name of the evaluation plan.**|
|DisplayName|**Evaluation Plan Name**|
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

### <a name="BKMK_msdyn_PlanStartDate"></a> msdyn_PlanStartDate

|Property|Value|
|---|---|
|Description|**Evaluation plan start date**|
|DisplayName|**Plan Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_planstartdate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_RecordType"></a> msdyn_RecordType

|Property|Value|
|---|---|
|Description|**Record type selected for evaluation.**|
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

### <a name="BKMK_msdyn_UniqueName"></a> msdyn_UniqueName

|Property|Value|
|---|---|
|Description|**Unique Name for the entity.**|
|DisplayName|**Unique Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_uniquename`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

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
|Description|**Status of the Evaluation Plan**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationplan_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 2<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 4<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Evaluation Plan**|
|DisplayName|**Evaluation Plan Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationplan_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Draft**<br />State:0<br />TransitionData: None|
|3|Label: **Paused**<br />State:0<br />TransitionData: None|
|4|Label: **Deactivated**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdyn_evaluationplan](#BKMK_business_unit_msdyn_evaluationplan)
- [lk_msdyn_evaluationplan_createdby](#BKMK_lk_msdyn_evaluationplan_createdby)
- [lk_msdyn_evaluationplan_createdonbehalfby](#BKMK_lk_msdyn_evaluationplan_createdonbehalfby)
- [lk_msdyn_evaluationplan_modifiedby](#BKMK_lk_msdyn_evaluationplan_modifiedby)
- [lk_msdyn_evaluationplan_modifiedonbehalfby](#BKMK_lk_msdyn_evaluationplan_modifiedonbehalfby)
- [msdyn_evaluationplan_AssignedTo_systemuser](#BKMK_msdyn_evaluationplan_AssignedTo_systemuser)
- [msdyn_evaluationplan_AssignedTo_team](#BKMK_msdyn_evaluationplan_AssignedTo_team)
- [msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria)
- [owner_msdyn_evaluationplan](#BKMK_owner_msdyn_evaluationplan)
- [team_msdyn_evaluationplan](#BKMK_team_msdyn_evaluationplan)
- [user_msdyn_evaluationplan](#BKMK_user_msdyn_evaluationplan)

### <a name="BKMK_business_unit_msdyn_evaluationplan"></a> business_unit_msdyn_evaluationplan

One-To-Many Relationship: [businessunit business_unit_msdyn_evaluationplan](businessunit.md#BKMK_business_unit_msdyn_evaluationplan)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplan_createdby"></a> lk_msdyn_evaluationplan_createdby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplan_createdby](systemuser.md#BKMK_lk_msdyn_evaluationplan_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplan_createdonbehalfby"></a> lk_msdyn_evaluationplan_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplan_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationplan_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplan_modifiedby"></a> lk_msdyn_evaluationplan_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplan_modifiedby](systemuser.md#BKMK_lk_msdyn_evaluationplan_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationplan_modifiedonbehalfby"></a> lk_msdyn_evaluationplan_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationplan_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationplan_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationplan_AssignedTo_systemuser"></a> msdyn_evaluationplan_AssignedTo_systemuser

One-To-Many Relationship: [systemuser msdyn_evaluationplan_AssignedTo_systemuser](systemuser.md#BKMK_msdyn_evaluationplan_AssignedTo_systemuser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_assignedto`|
|ReferencingEntityNavigationPropertyName|`msdyn_AssignedTo`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationplan_AssignedTo_team"></a> msdyn_evaluationplan_AssignedTo_team

One-To-Many Relationship: [team msdyn_evaluationplan_AssignedTo_team](team.md#BKMK_msdyn_evaluationplan_AssignedTo_team)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`msdyn_assignedto`|
|ReferencingEntityNavigationPropertyName|`msdyn_AssignedTo`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria"></a> msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria

One-To-Many Relationship: [msdyn_evaluationcriteria msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria](msdyn_evaluationcriteria.md#BKMK_msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationcriteria`|
|ReferencedAttribute|`msdyn_evaluationcriteriaid`|
|ReferencingAttribute|`msdyn_evaluationcriteria`|
|ReferencingEntityNavigationPropertyName|`msdyn_EvaluationCriteria`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_evaluationplan"></a> owner_msdyn_evaluationplan

One-To-Many Relationship: [owner owner_msdyn_evaluationplan](owner.md#BKMK_owner_msdyn_evaluationplan)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_evaluationplan"></a> team_msdyn_evaluationplan

One-To-Many Relationship: [team team_msdyn_evaluationplan](team.md#BKMK_team_msdyn_evaluationplan)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_evaluationplan"></a> user_msdyn_evaluationplan

One-To-Many Relationship: [systemuser user_msdyn_evaluationplan](systemuser.md#BKMK_user_msdyn_evaluationplan)

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

- [msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan](#BKMK_msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan)
- [msdyn_evaluationnotificationconfiguration_msdyn_evaluationplan](#BKMK_msdyn_evaluationnotificationconfiguration_msdyn_evaluationplan)
- [msdyn_evaluationplan_AsyncOperations](#BKMK_msdyn_evaluationplan_AsyncOperations)
- [msdyn_evaluationplan_BulkDeleteFailures](#BKMK_msdyn_evaluationplan_BulkDeleteFailures)
- [msdyn_evaluationplan_DuplicateBaseRecord](#BKMK_msdyn_evaluationplan_DuplicateBaseRecord)
- [msdyn_evaluationplan_DuplicateMatchingRecord](#BKMK_msdyn_evaluationplan_DuplicateMatchingRecord)
- [msdyn_evaluationplan_MailboxTrackingFolders](#BKMK_msdyn_evaluationplan_MailboxTrackingFolders)
- [msdyn_evaluationplan_PrincipalObjectAttributeAccesses](#BKMK_msdyn_evaluationplan_PrincipalObjectAttributeAccesses)
- [msdyn_evaluationplan_ProcessSession](#BKMK_msdyn_evaluationplan_ProcessSession)
- [msdyn_evaluationplan_SyncErrors](#BKMK_msdyn_evaluationplan_SyncErrors)
- [msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan](#BKMK_msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan)

### <a name="BKMK_msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan"></a> msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan

Many-To-One Relationship: [msdyn_evaluation msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan](msdyn_evaluation.md#BKMK_msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluation`|
|ReferencingAttribute|`msdyn_evaluationplan`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationnotificationconfiguration_msdyn_evaluationplan"></a> msdyn_evaluationnotificationconfiguration_msdyn_evaluationplan

Many-To-One Relationship: [msdyn_evaluationnotificationconfiguration msdyn_evaluationnotificationconfiguration_msdyn_evaluationplan](msdyn_evaluationnotificationconfiguration.md#BKMK_msdyn_evaluationnotificationconfiguration_msdyn_evaluationplan)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationnotificationconfiguration`|
|ReferencingAttribute|`msdyn_evaluationplanid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationnotificationconfiguration_msdyn_evaluationplan`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplan_AsyncOperations"></a> msdyn_evaluationplan_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_evaluationplan_AsyncOperations](asyncoperation.md#BKMK_msdyn_evaluationplan_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplan_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplan_BulkDeleteFailures"></a> msdyn_evaluationplan_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_evaluationplan_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_evaluationplan_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplan_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplan_DuplicateBaseRecord"></a> msdyn_evaluationplan_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_evaluationplan_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_evaluationplan_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplan_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplan_DuplicateMatchingRecord"></a> msdyn_evaluationplan_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_evaluationplan_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_evaluationplan_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplan_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplan_MailboxTrackingFolders"></a> msdyn_evaluationplan_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_evaluationplan_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_evaluationplan_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplan_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplan_PrincipalObjectAttributeAccesses"></a> msdyn_evaluationplan_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_evaluationplan_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_evaluationplan_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplan_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplan_ProcessSession"></a> msdyn_evaluationplan_ProcessSession

Many-To-One Relationship: [processsession msdyn_evaluationplan_ProcessSession](processsession.md#BKMK_msdyn_evaluationplan_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplan_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplan_SyncErrors"></a> msdyn_evaluationplan_SyncErrors

Many-To-One Relationship: [syncerror msdyn_evaluationplan_SyncErrors](syncerror.md#BKMK_msdyn_evaluationplan_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplan_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan"></a> msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan

Many-To-One Relationship: [msdyn_evaluationplanrun msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan](msdyn_evaluationplanrun.md#BKMK_msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationplanrun`|
|ReferencingAttribute|`msdyn_evaluationplan`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_EvaluationPlan_msdyn_evaluationplan`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

