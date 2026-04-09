---
title: "Evaluation (msdyn_Evaluation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Evaluation (msdyn_Evaluation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Evaluation (msdyn_Evaluation) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Evaluation (msdyn_Evaluation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_evaluations(*msdyn_evaluationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_evaluations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_evaluations(*msdyn_evaluationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_evaluations(*msdyn_evaluationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_evaluations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_evaluations(*msdyn_evaluationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_evaluations(*msdyn_evaluationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_evaluations(*msdyn_evaluationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Evaluation (msdyn_Evaluation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Evaluation** |
| **DisplayCollectionName** | **Evaluations** |
| **SchemaName** | `msdyn_Evaluation` |
| **CollectionSchemaName** | `msdyn_Evaluations` |
| **EntitySetName** | `msdyn_evaluations`|
| **LogicalName** | `msdyn_evaluation` |
| **LogicalCollectionName** | `msdyn_evaluations` |
| **PrimaryIdAttribute** | `msdyn_evaluationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdditionalDetails](#BKMK_msdyn_AdditionalDetails)
- [msdyn_AgentEndDate](#BKMK_msdyn_AgentEndDate)
- [msdyn_AgentResponseJson](#BKMK_msdyn_AgentResponseJson)
- [msdyn_CreateType](#BKMK_msdyn_CreateType)
- [msdyn_ErrorDetails](#BKMK_msdyn_ErrorDetails)
- [msdyn_EvaluationCriteria](#BKMK_msdyn_EvaluationCriteria)
- [msdyn_EvaluationCriteriaParentVersion](#BKMK_msdyn_EvaluationCriteriaParentVersion)
- [msdyn_EvaluationCriteriaVersion](#BKMK_msdyn_EvaluationCriteriaVersion)
- [msdyn_EvaluationExtension](#BKMK_msdyn_EvaluationExtension)
- [msdyn_EvaluationExtensionPId](#BKMK_msdyn_EvaluationExtensionPId)
- [msdyn_EvaluationId](#BKMK_msdyn_EvaluationId)
- [msdyn_EvaluationMethod](#BKMK_msdyn_EvaluationMethod)
- [msdyn_EvaluationPlan](#BKMK_msdyn_EvaluationPlan)
- [msdyn_EvaluatorCompletionDate](#BKMK_msdyn_EvaluatorCompletionDate)
- [msdyn_EvaluatorDueDate](#BKMK_msdyn_EvaluatorDueDate)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_QualityAgentStatus](#BKMK_msdyn_QualityAgentStatus)
- [msdyn_RegardingObjectId](#BKMK_msdyn_RegardingObjectId)
- [msdyn_RegardingObjectIdType](#BKMK_msdyn_RegardingObjectIdType)
- [msdyn_RegardingObjectOwner](#BKMK_msdyn_RegardingObjectOwner)
- [msdyn_RegardingObjectOwnerIdType](#BKMK_msdyn_RegardingObjectOwnerIdType)
- [msdyn_Relatedrecordtype](#BKMK_msdyn_Relatedrecordtype)
- [msdyn_RequestedBy](#BKMK_msdyn_RequestedBy)
- [msdyn_ResponseJson](#BKMK_msdyn_ResponseJson)
- [msdyn_Schema](#BKMK_msdyn_Schema)
- [msdyn_Score](#BKMK_msdyn_Score)
- [msdyn_ScoreJson](#BKMK_msdyn_ScoreJson)
- [msdyn_ScoringEnabledOnCreation](#BKMK_msdyn_ScoringEnabledOnCreation)
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
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_AdditionalDetails"></a> msdyn_AdditionalDetails

|Property|Value|
|---|---|
|Description|**Any additional provided on the evaluation.**|
|DisplayName|**Additional details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_additionaldetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|RichText|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048575|

### <a name="BKMK_msdyn_AgentEndDate"></a> msdyn_AgentEndDate

|Property|Value|
|---|---|
|Description|**The date and time the agent created a response.**|
|DisplayName|**Agent end date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentenddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_AgentResponseJson"></a> msdyn_AgentResponseJson

|Property|Value|
|---|---|
|Description|**The raw response from the AI agent.**|
|DisplayName|**Agent response json**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agentresponsejson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048575|

### <a name="BKMK_msdyn_CreateType"></a> msdyn_CreateType

|Property|Value|
|---|---|
|Description|**The type of process used to create Evalaution.**|
|DisplayName|**Create Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_createtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_evaluationcreatetype`|

#### msdyn_CreateType Choices/Options

|Value|Label|
|---|---|
|192350000|**OnDemand**|
|192350001|**RealTime**|
|192350002|**BulkEvaluation**|
|192350003|**OnTrigger**|

### <a name="BKMK_msdyn_ErrorDetails"></a> msdyn_ErrorDetails

|Property|Value|
|---|---|
|Description|**Field for storing error details about the evalution**|
|DisplayName|**Error Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errordetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048575|

### <a name="BKMK_msdyn_EvaluationCriteria"></a> msdyn_EvaluationCriteria

|Property|Value|
|---|---|
|Description|**The lookup to the criteria this evaluation is answering.**|
|DisplayName|**Evaluation criteria**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationcriteria`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_evaluationcriteria|

### <a name="BKMK_msdyn_EvaluationCriteriaParentVersion"></a> msdyn_EvaluationCriteriaParentVersion

|Property|Value|
|---|---|
|Description|**The parent evaluation criteria version used to create this evaluation.**|
|DisplayName|**Evaluation criteria parent version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationcriteriaparentversion`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_EvaluationCriteriaVersion"></a> msdyn_EvaluationCriteriaVersion

|Property|Value|
|---|---|
|Description|**The version of the EvaluationCriteria that was used to create this evaluation.**|
|DisplayName|**Evaluation criteria version**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationcriteriaversion`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_EvaluationExtension"></a> msdyn_EvaluationExtension

|Property|Value|
|---|---|
|Description|**Reference to Evaluation Extension record**|
|DisplayName|**Evaluation Extension**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationextension`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_evaluationextension|

### <a name="BKMK_msdyn_EvaluationExtensionPId"></a> msdyn_EvaluationExtensionPId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationextensionpid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_EvaluationId"></a> msdyn_EvaluationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Evaluation**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_EvaluationMethod"></a> msdyn_EvaluationMethod

|Property|Value|
|---|---|
|Description|**The method the evaluation went through.**|
|DisplayName|**Evaluation method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationmethod`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_evaluationmethod`|

#### msdyn_EvaluationMethod Choices/Options

|Value|Label|
|---|---|
|700610000|**AI assisted**|
|700610001|**AI agent**|
|700610002|**Manual**|

### <a name="BKMK_msdyn_EvaluationPlan"></a> msdyn_EvaluationPlan

|Property|Value|
|---|---|
|Description||
|DisplayName|**EvaluationPlan**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationplan`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_evaluationplan|

### <a name="BKMK_msdyn_EvaluatorCompletionDate"></a> msdyn_EvaluatorCompletionDate

|Property|Value|
|---|---|
|Description|**The date the evaluator completed the evaluation.**|
|DisplayName|**Evaluator completion date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluatorcompletiondate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EvaluatorDueDate"></a> msdyn_EvaluatorDueDate

|Property|Value|
|---|---|
|Description|**The due date set which the evaluator has until to complete the evaluation.**|
|DisplayName|**Evaluator expiration date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluatorduedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_QualityAgentStatus"></a> msdyn_QualityAgentStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**AI agent status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qualityagentstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_qualityagentstatus`|

#### msdyn_QualityAgentStatus Choices/Options

|Value|Label|
|---|---|
|700610000|**Pending**|
|700610001|**In progress**|
|700610002|**Completed**|
|700610003|**Error**|
|700610004|**Not applicable**|
|700610005|**Skipped**|

### <a name="BKMK_msdyn_RegardingObjectId"></a> msdyn_RegardingObjectId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Related record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident, msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_RegardingObjectIdType"></a> msdyn_RegardingObjectIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_RegardingObjectOwner"></a> msdyn_RegardingObjectOwner

|Property|Value|
|---|---|
|Description|**The regarding object owner at time of evaluation creation.**|
|DisplayName|**Representative**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectowner`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser, team|

### <a name="BKMK_msdyn_RegardingObjectOwnerIdType"></a> msdyn_RegardingObjectOwnerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectowneridtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_Relatedrecordtype"></a> msdyn_Relatedrecordtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrecordtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_evaluation_msdyn_relatedrecordtype`|

#### msdyn_Relatedrecordtype Choices/Options

|Value|Label|
|---|---|
|0|**Case**|
|1|**Conversation**|

### <a name="BKMK_msdyn_RequestedBy"></a> msdyn_RequestedBy

|Property|Value|
|---|---|
|Description|**The user this evaluation was requested by.**|
|DisplayName|**Requested by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requestedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_ResponseJson"></a> msdyn_ResponseJson

|Property|Value|
|---|---|
|Description|**The response of the evaluation. Contains the answers used to render the component.**|
|DisplayName|**Response json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_responsejson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048575|

### <a name="BKMK_msdyn_Schema"></a> msdyn_Schema

|Property|Value|
|---|---|
|Description|**Schema version to track which entity structure is used for evaluation data storage**|
|DisplayName|**Schema**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schema`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Score"></a> msdyn_Score

|Property|Value|
|---|---|
|Description||
|DisplayName|**Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_score`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ScoreJson"></a> msdyn_ScoreJson

|Property|Value|
|---|---|
|Description|**The JSON that will store the score of the evaluation, categories and answers.**|
|DisplayName|**Score json**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_scorejson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_ScoringEnabledOnCreation"></a> msdyn_ScoringEnabledOnCreation

|Property|Value|
|---|---|
|Description|**Indicates if the scoring is enabled.**|
|DisplayName|**Scoring enabled on creation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scoringenabledoncreation`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_evaluation_msdyn_scoringenabledoncreation`|

#### msdyn_ScoringEnabledOnCreation Choices/Options

|Value|Label|
|---|---|
|0|**No**|
|1|**Yes**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record created on**|
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
|Description|**Status of the Evaluation**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluation_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Evaluator status of the evaluation.**|
|DisplayName|**Evaluator status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluation_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Pending**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|700610001|Label: **In-progress**<br />State:0<br />TransitionData: None|
|700610002|Label: **Completed**<br />State:0<br />TransitionData: None|
|700610003|Label: **Expired**<br />State:0<br />TransitionData: None|
|700610004|Label: **Not applicable**<br />State:0<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time zone rule version number**|
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
|DisplayName|**UTC conversion time zone code**|
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
|DisplayName|**Created by**|
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
|DisplayName|**Created on**|
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
|DisplayName|**Created by (Delegate)**|
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
|DisplayName|**Modified by**|
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
|DisplayName|**Modified on**|
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
|DisplayName|**Modified by (Delegate)**|
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
|Description|**Unique identifier for the business unit that owns the record.**|
|DisplayName|**Owning business unit**|
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
|DisplayName|**Owning team**|
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
|DisplayName|**Owning user**|
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

- [business_unit_msdyn_evaluation](#BKMK_business_unit_msdyn_evaluation)
- [lk_msdyn_evaluation_createdby](#BKMK_lk_msdyn_evaluation_createdby)
- [lk_msdyn_evaluation_createdonbehalfby](#BKMK_lk_msdyn_evaluation_createdonbehalfby)
- [lk_msdyn_evaluation_modifiedby](#BKMK_lk_msdyn_evaluation_modifiedby)
- [lk_msdyn_evaluation_modifiedonbehalfby](#BKMK_lk_msdyn_evaluation_modifiedonbehalfby)
- [msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria)
- [msdyn_evaluation_EvaluationExtension_msdyn_evaluationextension](#BKMK_msdyn_evaluation_EvaluationExtension_msdyn_evaluationextension)
- [msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan](#BKMK_msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan)
- [msdyn_evaluation_RequestedBy_systemuser](#BKMK_msdyn_evaluation_RequestedBy_systemuser)
- [msdyn_evaluation_systemuser_msdyn_RegardingObjectOwner](#BKMK_msdyn_evaluation_systemuser_msdyn_RegardingObjectOwner)
- [msdyn_evaluation_team_msdyn_RegardingObjectOwner](#BKMK_msdyn_evaluation_team_msdyn_RegardingObjectOwner)
- [msdyn_msdyn_evaluation_incident_msdyn_RegardingObjectId](#BKMK_msdyn_msdyn_evaluation_incident_msdyn_RegardingObjectId)
- [msdyn_msdyn_evaluation_msdyn_ocliveworkitem_msdyn_RegardingObjectId](#BKMK_msdyn_msdyn_evaluation_msdyn_ocliveworkitem_msdyn_RegardingObjectId)
- [owner_msdyn_evaluation](#BKMK_owner_msdyn_evaluation)
- [team_msdyn_evaluation](#BKMK_team_msdyn_evaluation)
- [user_msdyn_evaluation](#BKMK_user_msdyn_evaluation)

### <a name="BKMK_business_unit_msdyn_evaluation"></a> business_unit_msdyn_evaluation

One-To-Many Relationship: [businessunit business_unit_msdyn_evaluation](businessunit.md#BKMK_business_unit_msdyn_evaluation)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluation_createdby"></a> lk_msdyn_evaluation_createdby

One-To-Many Relationship: [systemuser lk_msdyn_evaluation_createdby](systemuser.md#BKMK_lk_msdyn_evaluation_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluation_createdonbehalfby"></a> lk_msdyn_evaluation_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluation_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluation_modifiedby"></a> lk_msdyn_evaluation_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_evaluation_modifiedby](systemuser.md#BKMK_lk_msdyn_evaluation_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluation_modifiedonbehalfby"></a> lk_msdyn_evaluation_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluation_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluation_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria"></a> msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria

One-To-Many Relationship: [msdyn_evaluationcriteria msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria](msdyn_evaluationcriteria.md#BKMK_msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationcriteria`|
|ReferencedAttribute|`msdyn_evaluationcriteriaid`|
|ReferencingAttribute|`msdyn_evaluationcriteria`|
|ReferencingEntityNavigationPropertyName|`msdyn_EvaluationCriteria`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluation_EvaluationExtension_msdyn_evaluationextension"></a> msdyn_evaluation_EvaluationExtension_msdyn_evaluationextension

One-To-Many Relationship: [msdyn_evaluationextension msdyn_evaluation_EvaluationExtension_msdyn_evaluationextension](msdyn_evaluationextension.md#BKMK_msdyn_evaluation_EvaluationExtension_msdyn_evaluationextension)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationextension`|
|ReferencedAttribute|`msdyn_evaluationextensionid`|
|ReferencingAttribute|`msdyn_evaluationextension`|
|ReferencingEntityNavigationPropertyName|`msdyn_EvaluationExtension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan"></a> msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan

One-To-Many Relationship: [msdyn_evaluationplan msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan](msdyn_evaluationplan.md#BKMK_msdyn_evaluation_EvaluationPlan_msdyn_evaluationplan)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationplan`|
|ReferencedAttribute|`msdyn_evaluationplanid`|
|ReferencingAttribute|`msdyn_evaluationplan`|
|ReferencingEntityNavigationPropertyName|`msdyn_EvaluationPlan`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluation_RequestedBy_systemuser"></a> msdyn_evaluation_RequestedBy_systemuser

One-To-Many Relationship: [systemuser msdyn_evaluation_RequestedBy_systemuser](systemuser.md#BKMK_msdyn_evaluation_RequestedBy_systemuser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_requestedby`|
|ReferencingEntityNavigationPropertyName|`msdyn_RequestedBy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluation_systemuser_msdyn_RegardingObjectOwner"></a> msdyn_evaluation_systemuser_msdyn_RegardingObjectOwner

One-To-Many Relationship: [systemuser msdyn_evaluation_systemuser_msdyn_RegardingObjectOwner](systemuser.md#BKMK_msdyn_evaluation_systemuser_msdyn_RegardingObjectOwner)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_regardingobjectowner`|
|ReferencingEntityNavigationPropertyName|`msdyn_RegardingObjectOwner`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluation_team_msdyn_RegardingObjectOwner"></a> msdyn_evaluation_team_msdyn_RegardingObjectOwner

One-To-Many Relationship: [team msdyn_evaluation_team_msdyn_RegardingObjectOwner](team.md#BKMK_msdyn_evaluation_team_msdyn_RegardingObjectOwner)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`msdyn_regardingobjectowner`|
|ReferencingEntityNavigationPropertyName|`msdyn_RegardingObjectOwner`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_evaluation_incident_msdyn_RegardingObjectId"></a> msdyn_msdyn_evaluation_incident_msdyn_RegardingObjectId

One-To-Many Relationship: [incident msdyn_msdyn_evaluation_incident_msdyn_RegardingObjectId](incident.md#BKMK_msdyn_msdyn_evaluation_incident_msdyn_RegardingObjectId)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_RegardingObjectId_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_evaluation_msdyn_ocliveworkitem_msdyn_RegardingObjectId"></a> msdyn_msdyn_evaluation_msdyn_ocliveworkitem_msdyn_RegardingObjectId

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_evaluation_msdyn_ocliveworkitem_msdyn_RegardingObjectId](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_evaluation_msdyn_ocliveworkitem_msdyn_RegardingObjectId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_RegardingObjectId_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_evaluation"></a> owner_msdyn_evaluation

One-To-Many Relationship: [owner owner_msdyn_evaluation](owner.md#BKMK_owner_msdyn_evaluation)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_evaluation"></a> team_msdyn_evaluation

One-To-Many Relationship: [team team_msdyn_evaluation](team.md#BKMK_team_msdyn_evaluation)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_evaluation"></a> user_msdyn_evaluation

One-To-Many Relationship: [systemuser user_msdyn_evaluation](systemuser.md#BKMK_user_msdyn_evaluation)

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

- [msdyn_evaluation_AsyncOperations](#BKMK_msdyn_evaluation_AsyncOperations)
- [msdyn_evaluation_BulkDeleteFailures](#BKMK_msdyn_evaluation_BulkDeleteFailures)
- [msdyn_evaluation_MailboxTrackingFolders](#BKMK_msdyn_evaluation_MailboxTrackingFolders)
- [msdyn_evaluation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_evaluation_PrincipalObjectAttributeAccesses)
- [msdyn_evaluation_ProcessSession](#BKMK_msdyn_evaluation_ProcessSession)
- [msdyn_evaluation_SyncErrors](#BKMK_msdyn_evaluation_SyncErrors)

### <a name="BKMK_msdyn_evaluation_AsyncOperations"></a> msdyn_evaluation_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_evaluation_AsyncOperations](asyncoperation.md#BKMK_msdyn_evaluation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluation_BulkDeleteFailures"></a> msdyn_evaluation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_evaluation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_evaluation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluation_MailboxTrackingFolders"></a> msdyn_evaluation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_evaluation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_evaluation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluation_PrincipalObjectAttributeAccesses"></a> msdyn_evaluation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_evaluation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_evaluation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluation_ProcessSession"></a> msdyn_evaluation_ProcessSession

Many-To-One Relationship: [processsession msdyn_evaluation_ProcessSession](processsession.md#BKMK_msdyn_evaluation_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluation_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluation_SyncErrors"></a> msdyn_evaluation_SyncErrors

Many-To-One Relationship: [syncerror msdyn_evaluation_SyncErrors](syncerror.md#BKMK_msdyn_evaluation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

