---
title: "Prediction Model Status (msdyn_predictionmodelstatus) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Prediction Model Status (msdyn_predictionmodelstatus) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Prediction Model Status (msdyn_predictionmodelstatus) table/entity reference (Microsoft Dynamics 365)

Stores metadata about predictive models

## Messages

The following table lists the messages for the Prediction Model Status (msdyn_predictionmodelstatus) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_predictionmodelstatuses(*msdyn_predictionmodelstatusid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_predictionmodelstatuses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_predictionmodelstatuses(*msdyn_predictionmodelstatusid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_predictionmodelstatuses(*msdyn_predictionmodelstatusid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_predictionmodelstatuses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_predictionmodelstatuses(*msdyn_predictionmodelstatusid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_predictionmodelstatuses(*msdyn_predictionmodelstatusid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_predictionmodelstatuses(*msdyn_predictionmodelstatusid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Prediction Model Status (msdyn_predictionmodelstatus) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Prediction Model Status** |
| **DisplayCollectionName** | **Prediction Model Statuses** |
| **SchemaName** | `msdyn_predictionmodelstatus` |
| **CollectionSchemaName** | `msdyn_predictionmodelstatuses` |
| **EntitySetName** | `msdyn_predictionmodelstatuses`|
| **LogicalName** | `msdyn_predictionmodelstatus` |
| **LogicalCollectionName** | `msdyn_predictionmodelstatuses` |
| **PrimaryIdAttribute** | `msdyn_predictionmodelstatusid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ChangeGradesOnRetrain](#BKMK_msdyn_ChangeGradesOnRetrain)
- [msdyn_ComputationConfig](#BKMK_msdyn_ComputationConfig)
- [msdyn_ComputationFrequency](#BKMK_msdyn_ComputationFrequency)
- [msdyn_ConfigVersion](#BKMK_msdyn_ConfigVersion)
- [msdyn_Created](#BKMK_msdyn_Created)
- [msdyn_DockerImageName](#BKMK_msdyn_DockerImageName)
- [msdyn_ExplanationPath](#BKMK_msdyn_ExplanationPath)
- [msdyn_GradeDefinition](#BKMK_msdyn_GradeDefinition)
- [msdyn_IsCurrent](#BKMK_msdyn_IsCurrent)
- [msdyn_IslandUrl](#BKMK_msdyn_IslandUrl)
- [msdyn_isnewentityadditionopted](#BKMK_msdyn_isnewentityadditionopted)
- [msdyn_IsScheduled](#BKMK_msdyn_IsScheduled)
- [msdyn_Message](#BKMK_msdyn_Message)
- [msdyn_ModelId](#BKMK_msdyn_ModelId)
- [msdyn_ModelPath](#BKMK_msdyn_ModelPath)
- [msdyn_ModelVersion](#BKMK_msdyn_ModelVersion)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NextComputation](#BKMK_msdyn_NextComputation)
- [msdyn_PredictionGuid](#BKMK_msdyn_PredictionGuid)
- [msdyn_predictionmodelstatusId](#BKMK_msdyn_predictionmodelstatusId)
- [msdyn_PredictionName](#BKMK_msdyn_PredictionName)
- [msdyn_PredictionType](#BKMK_msdyn_PredictionType)
- [msdyn_PsmOpted](#BKMK_msdyn_PsmOpted)
- [msdyn_PublishOnTrain](#BKMK_msdyn_PublishOnTrain)
- [msdyn_RetryCounter](#BKMK_msdyn_RetryCounter)
- [msdyn_SignalsUsed](#BKMK_msdyn_SignalsUsed)
- [msdyn_Status](#BKMK_msdyn_Status)
- [msdyn_TestSetCount](#BKMK_msdyn_TestSetCount)
- [msdyn_TimeoutPeriodInMinutes](#BKMK_msdyn_TimeoutPeriodInMinutes)
- [msdyn_TrainingAccuracy](#BKMK_msdyn_TrainingAccuracy)
- [msdyn_TrainingAuc](#BKMK_msdyn_TrainingAuc)
- [msdyn_TrainingConfig](#BKMK_msdyn_TrainingConfig)
- [msdyn_TrainingSetCount](#BKMK_msdyn_TrainingSetCount)
- [msdyn_UseBPFAsFilter](#BKMK_msdyn_UseBPFAsFilter)
- [msdyn_ValidationSetCount](#BKMK_msdyn_ValidationSetCount)
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

### <a name="BKMK_msdyn_ChangeGradesOnRetrain"></a> msdyn_ChangeGradesOnRetrain

|Property|Value|
|---|---|
|Description|**Stores boolean value to tell if grades should be updated after training or not.**|
|DisplayName|**Change Grades On Retrain**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_changegradesonretrain`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_predictionmodelstatus_msdyn_changegradesonretrain`|
|DefaultValue|True|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_ComputationConfig"></a> msdyn_ComputationConfig

|Property|Value|
|---|---|
|Description|**Stores computation config of the model**|
|DisplayName|**Computation Config**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_computationconfig`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_ComputationFrequency"></a> msdyn_ComputationFrequency

|Property|Value|
|---|---|
|Description|**Stores computation frequence for the model.**|
|DisplayName|**Computation Frequency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_computationfrequency`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ConfigVersion"></a> msdyn_ConfigVersion

|Property|Value|
|---|---|
|Description|**Stores version for the config used.**|
|DisplayName|**Config Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_configversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Created"></a> msdyn_Created

|Property|Value|
|---|---|
|Description|**Stores the Created time for the model**|
|DisplayName|**Created**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_created`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_DockerImageName"></a> msdyn_DockerImageName

|Property|Value|
|---|---|
|Description|**Stores the docker image that will be used to train the model**|
|DisplayName|**Docker Image Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dockerimagename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_ExplanationPath"></a> msdyn_ExplanationPath

|Property|Value|
|---|---|
|Description|**Stores path of the explanation file after training.**|
|DisplayName|**Explanation Path**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_explanationpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_GradeDefinition"></a> msdyn_GradeDefinition

|Property|Value|
|---|---|
|Description|**Stores grade definition for the model.**|
|DisplayName|**Grade Definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gradedefinition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_IsCurrent"></a> msdyn_IsCurrent

|Property|Value|
|---|---|
|Description|**Stores bool value which tells if the model is current model or not on UX.**|
|DisplayName|**Is Current**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscurrent`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_predictionmodelstatus_msdyn_iscurrent`|
|DefaultValue|True|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_IslandUrl"></a> msdyn_IslandUrl

|Property|Value|
|---|---|
|Description|**Stores island url where the job was submitted.**|
|DisplayName|**Island Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_islandurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_isnewentityadditionopted"></a> msdyn_isnewentityadditionopted

|Property|Value|
|---|---|
|Description|**Tells if new Entity Addition is opted or not**|
|DisplayName|**Is New Entity Addition Opted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isnewentityadditionopted`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_predictionmodelstatus_msdyn_isnewentityadditionopted`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_IsScheduled"></a> msdyn_IsScheduled

|Property|Value|
|---|---|
|Description|**Stores boolean variable to tell if predictive model is scheduled or not.**|
|DisplayName|**Is Scheduled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isscheduled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_predictionmodelstatus_msdyn_isscheduled`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_Message"></a> msdyn_Message

|Property|Value|
|---|---|
|Description|**Stores intermediate training message**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_message`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_ModelId"></a> msdyn_ModelId

|Property|Value|
|---|---|
|Description|**Stores guid for each predictive model.**|
|DisplayName|**Model Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modelid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ModelPath"></a> msdyn_ModelPath

|Property|Value|
|---|---|
|Description|**Stores the path where model is stored after training.**|
|DisplayName|**Model Path**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modelpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_ModelVersion"></a> msdyn_ModelVersion

|Property|Value|
|---|---|
|Description|**Stores version of the model.**|
|DisplayName|**Model Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modelversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_NextComputation"></a> msdyn_NextComputation

|Property|Value|
|---|---|
|Description|**Stores the time when next computation to be run.**|
|DisplayName|**Next Computation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextcomputation`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_PredictionGuid"></a> msdyn_PredictionGuid

|Property|Value|
|---|---|
|Description|**Stores unique guid for prediction**|
|DisplayName|**Prediction Guid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictionguid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_predictionmodelstatusId"></a> msdyn_predictionmodelstatusId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Prediction Model Status**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_predictionmodelstatusid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_PredictionName"></a> msdyn_PredictionName

|Property|Value|
|---|---|
|Description|**Stores name of prediction**|
|DisplayName|**Prediction Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictionname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_PredictionType"></a> msdyn_PredictionType

|Property|Value|
|---|---|
|Description|**Type of prediction - lead or opportunity**|
|DisplayName|**Prediction Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictiontype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_predictionmodelstatus_msdyn_predictiontype`|

#### msdyn_PredictionType Choices/Options

|Value|Label|
|---|---|
|192350000|**LeadScoring**|
|192350001|**OpportunityScoring**|
|192350002|**SimilarOpportunity**|

### <a name="BKMK_msdyn_PsmOpted"></a> msdyn_PsmOpted

|Property|Value|
|---|---|
|Description|**Tells if per stage modeling is opted or not.**|
|DisplayName|**Psm Opted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_psmopted`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_predictionmodelstatus_msdyn_psmopted`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_PublishOnTrain"></a> msdyn_PublishOnTrain

|Property|Value|
|---|---|
|Description|**Stores boolean variable to tell if model needs to be published automatically after training or not.**|
|DisplayName|**Publish On Train**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_publishontrain`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_predictionmodelstatus_msdyn_publishontrain`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_RetryCounter"></a> msdyn_RetryCounter

|Property|Value|
|---|---|
|Description|**Stores number of times the training is retried after submit was failed in service.**|
|DisplayName|**Retry Counter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_retrycounter`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_SignalsUsed"></a> msdyn_SignalsUsed

|Property|Value|
|---|---|
|Description|**Stores training metrics related data.**|
|DisplayName|**Signals Used**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_signalsused`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_Status"></a> msdyn_Status

|Property|Value|
|---|---|
|Description|**Stores status of predictive model**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_TestSetCount"></a> msdyn_TestSetCount

|Property|Value|
|---|---|
|Description|**Stores training metrics data.**|
|DisplayName|**Test Set Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_testsetcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_TimeoutPeriodInMinutes"></a> msdyn_TimeoutPeriodInMinutes

|Property|Value|
|---|---|
|Description|**Tells the status check scheduler when it should consider some submitted job as "Terminated"**|
|DisplayName|**TimeoutPeriodInMinutes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timeoutperiodinminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_TrainingAccuracy"></a> msdyn_TrainingAccuracy

|Property|Value|
|---|---|
|Description|**Stores training accuracy for predictive model.**|
|DisplayName|**Training Accuracy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_trainingaccuracy`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TrainingAuc"></a> msdyn_TrainingAuc

|Property|Value|
|---|---|
|Description|**Stores training AUC for predictive models.**|
|DisplayName|**Training Auc**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_trainingauc`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TrainingConfig"></a> msdyn_TrainingConfig

|Property|Value|
|---|---|
|Description|**Stores training config of the model**|
|DisplayName|**Training Config**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_trainingconfig`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_TrainingSetCount"></a> msdyn_TrainingSetCount

|Property|Value|
|---|---|
|Description|**Stores training metrics data.**|
|DisplayName|**Training Set Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_trainingsetcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_UseBPFAsFilter"></a> msdyn_UseBPFAsFilter

|Property|Value|
|---|---|
|Description|**Stores boolean value to tell if BPF should be used as filter criteria or not.**|
|DisplayName|**Use BPF As Filter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_usebpfasfilter`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_predictionmodelstatus_msdyn_usebpfasfilter`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_ValidationSetCount"></a> msdyn_ValidationSetCount

|Property|Value|
|---|---|
|Description|**Stores training metrics related data.**|
|DisplayName|**Validation Set Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validationsetcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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
|Description|**Status of the Prediction Model Status**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_predictionmodelstatus_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Prediction Model Status**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_predictionmodelstatus_statuscode`|

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

- [business_unit_msdyn_predictionmodelstatus](#BKMK_business_unit_msdyn_predictionmodelstatus)
- [lk_msdyn_predictionmodelstatus_createdby](#BKMK_lk_msdyn_predictionmodelstatus_createdby)
- [lk_msdyn_predictionmodelstatus_createdonbehalfby](#BKMK_lk_msdyn_predictionmodelstatus_createdonbehalfby)
- [lk_msdyn_predictionmodelstatus_modifiedby](#BKMK_lk_msdyn_predictionmodelstatus_modifiedby)
- [lk_msdyn_predictionmodelstatus_modifiedonbehalfby](#BKMK_lk_msdyn_predictionmodelstatus_modifiedonbehalfby)
- [owner_msdyn_predictionmodelstatus](#BKMK_owner_msdyn_predictionmodelstatus)
- [team_msdyn_predictionmodelstatus](#BKMK_team_msdyn_predictionmodelstatus)
- [user_msdyn_predictionmodelstatus](#BKMK_user_msdyn_predictionmodelstatus)

### <a name="BKMK_business_unit_msdyn_predictionmodelstatus"></a> business_unit_msdyn_predictionmodelstatus

One-To-Many Relationship: [businessunit business_unit_msdyn_predictionmodelstatus](businessunit.md#BKMK_business_unit_msdyn_predictionmodelstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictionmodelstatus_createdby"></a> lk_msdyn_predictionmodelstatus_createdby

One-To-Many Relationship: [systemuser lk_msdyn_predictionmodelstatus_createdby](systemuser.md#BKMK_lk_msdyn_predictionmodelstatus_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictionmodelstatus_createdonbehalfby"></a> lk_msdyn_predictionmodelstatus_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_predictionmodelstatus_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_predictionmodelstatus_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictionmodelstatus_modifiedby"></a> lk_msdyn_predictionmodelstatus_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_predictionmodelstatus_modifiedby](systemuser.md#BKMK_lk_msdyn_predictionmodelstatus_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictionmodelstatus_modifiedonbehalfby"></a> lk_msdyn_predictionmodelstatus_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_predictionmodelstatus_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_predictionmodelstatus_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_predictionmodelstatus"></a> owner_msdyn_predictionmodelstatus

One-To-Many Relationship: [owner owner_msdyn_predictionmodelstatus](owner.md#BKMK_owner_msdyn_predictionmodelstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_predictionmodelstatus"></a> team_msdyn_predictionmodelstatus

One-To-Many Relationship: [team team_msdyn_predictionmodelstatus](team.md#BKMK_team_msdyn_predictionmodelstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_predictionmodelstatus"></a> user_msdyn_predictionmodelstatus

One-To-Many Relationship: [systemuser user_msdyn_predictionmodelstatus](systemuser.md#BKMK_user_msdyn_predictionmodelstatus)

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

- [msdyn_predictionmodelstatus_AsyncOperations](#BKMK_msdyn_predictionmodelstatus_AsyncOperations)
- [msdyn_predictionmodelstatus_BulkDeleteFailures](#BKMK_msdyn_predictionmodelstatus_BulkDeleteFailures)
- [msdyn_predictionmodelstatus_DuplicateBaseRecord](#BKMK_msdyn_predictionmodelstatus_DuplicateBaseRecord)
- [msdyn_predictionmodelstatus_DuplicateMatchingRecord](#BKMK_msdyn_predictionmodelstatus_DuplicateMatchingRecord)
- [msdyn_predictionmodelstatus_MailboxTrackingFolders](#BKMK_msdyn_predictionmodelstatus_MailboxTrackingFolders)
- [msdyn_predictionmodelstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_predictionmodelstatus_PrincipalObjectAttributeAccesses)
- [msdyn_predictionmodelstatus_ProcessSession](#BKMK_msdyn_predictionmodelstatus_ProcessSession)
- [msdyn_predictionmodelstatus_SyncErrors](#BKMK_msdyn_predictionmodelstatus_SyncErrors)

### <a name="BKMK_msdyn_predictionmodelstatus_AsyncOperations"></a> msdyn_predictionmodelstatus_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_predictionmodelstatus_AsyncOperations](asyncoperation.md#BKMK_msdyn_predictionmodelstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictionmodelstatus_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictionmodelstatus_BulkDeleteFailures"></a> msdyn_predictionmodelstatus_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_predictionmodelstatus_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_predictionmodelstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictionmodelstatus_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictionmodelstatus_DuplicateBaseRecord"></a> msdyn_predictionmodelstatus_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_predictionmodelstatus_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_predictionmodelstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictionmodelstatus_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictionmodelstatus_DuplicateMatchingRecord"></a> msdyn_predictionmodelstatus_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_predictionmodelstatus_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_predictionmodelstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictionmodelstatus_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictionmodelstatus_MailboxTrackingFolders"></a> msdyn_predictionmodelstatus_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_predictionmodelstatus_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_predictionmodelstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictionmodelstatus_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictionmodelstatus_PrincipalObjectAttributeAccesses"></a> msdyn_predictionmodelstatus_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_predictionmodelstatus_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_predictionmodelstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictionmodelstatus_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictionmodelstatus_ProcessSession"></a> msdyn_predictionmodelstatus_ProcessSession

Many-To-One Relationship: [processsession msdyn_predictionmodelstatus_ProcessSession](processsession.md#BKMK_msdyn_predictionmodelstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictionmodelstatus_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictionmodelstatus_SyncErrors"></a> msdyn_predictionmodelstatus_SyncErrors

Many-To-One Relationship: [syncerror msdyn_predictionmodelstatus_SyncErrors](syncerror.md#BKMK_msdyn_predictionmodelstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictionmodelstatus_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

