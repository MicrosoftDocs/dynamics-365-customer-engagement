---
title: "Prediction Computation Operation (msdyn_predictioncomputationoperation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Prediction Computation Operation (msdyn_predictioncomputationoperation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Prediction Computation Operation (msdyn_predictioncomputationoperation) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Prediction Computation Operation (msdyn_predictioncomputationoperation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_predictioncomputationoperations(*msdyn_predictioncomputationoperationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_predictioncomputationoperations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_predictioncomputationoperations(*msdyn_predictioncomputationoperationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_predictioncomputationoperations(*msdyn_predictioncomputationoperationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_predictioncomputationoperations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_predictioncomputationoperations(*msdyn_predictioncomputationoperationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_predictioncomputationoperations(*msdyn_predictioncomputationoperationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_predictioncomputationoperations(*msdyn_predictioncomputationoperationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Prediction Computation Operation (msdyn_predictioncomputationoperation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Prediction Computation Operation** |
| **DisplayCollectionName** | **Prediction Computation Operations** |
| **SchemaName** | `msdyn_predictioncomputationoperation` |
| **CollectionSchemaName** | `msdyn_predictioncomputationoperations` |
| **EntitySetName** | `msdyn_predictioncomputationoperations`|
| **LogicalName** | `msdyn_predictioncomputationoperation` |
| **LogicalCollectionName** | `msdyn_predictioncomputationoperations` |
| **PrimaryIdAttribute** | `msdyn_predictioncomputationoperationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ComputationTriggerId](#BKMK_msdyn_ComputationTriggerId)
- [msdyn_Created](#BKMK_msdyn_Created)
- [msdyn_DockerImageName](#BKMK_msdyn_DockerImageName)
- [msdyn_ExpiryDateTime](#BKMK_msdyn_ExpiryDateTime)
- [msdyn_ExplanationPath](#BKMK_msdyn_ExplanationPath)
- [msdyn_Finished](#BKMK_msdyn_Finished)
- [msdyn_IslandUrl](#BKMK_msdyn_IslandUrl)
- [msdyn_JobId](#BKMK_msdyn_JobId)
- [msdyn_ModelId](#BKMK_msdyn_ModelId)
- [msdyn_ModelPath](#BKMK_msdyn_ModelPath)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OperationGuid](#BKMK_msdyn_OperationGuid)
- [msdyn_OperationId](#BKMK_msdyn_OperationId)
- [msdyn_predictioncomputationoperationId](#BKMK_msdyn_predictioncomputationoperationId)
- [msdyn_PredictionGuid](#BKMK_msdyn_PredictionGuid)
- [msdyn_PredictionName](#BKMK_msdyn_PredictionName)
- [msdyn_ResultPath](#BKMK_msdyn_ResultPath)
- [msdyn_RetryCounter](#BKMK_msdyn_RetryCounter)
- [msdyn_State](#BKMK_msdyn_State)
- [msdyn_TimeSpentCrmSyncSiJobId](#BKMK_msdyn_TimeSpentCrmSyncSiJobId)
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

### <a name="BKMK_msdyn_ComputationTriggerId"></a> msdyn_ComputationTriggerId

|Property|Value|
|---|---|
|Description|**Unique trigger ID for each computation that is triggerred from dataverse**|
|DisplayName|**ComputationTriggerId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_computationtriggerid`|
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
|Description|**Stores created time for the record.**|
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
|Description|**Stores docker image name on which computation should run.**|
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

### <a name="BKMK_msdyn_ExpiryDateTime"></a> msdyn_ExpiryDateTime

|Property|Value|
|---|---|
|Description|**Stores the time when the record should be unusable and can be cleared out.**|
|DisplayName|**Expiry Date Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_expirydatetime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ExplanationPath"></a> msdyn_ExplanationPath

|Property|Value|
|---|---|
|Description|**Stores path where explanation files are stored.**|
|DisplayName|**Explanation Path**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_explanationpath`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_Finished"></a> msdyn_Finished

|Property|Value|
|---|---|
|Description|**Stores boolean value which shows if the docker job is finished or not.**|
|DisplayName|**Finished**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_finished`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_predictioncomputationoperation_msdyn_finished`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_IslandUrl"></a> msdyn_IslandUrl

|Property|Value|
|---|---|
|Description|**Stores Island url where the computation job will be issued.**|
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

### <a name="BKMK_msdyn_JobId"></a> msdyn_JobId

|Property|Value|
|---|---|
|Description|**Stores Job Id of the Azure batch job.**|
|DisplayName|**Job Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobid`|
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
|Description|**Stores model id.**|
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
|Description|**Stores the path where models are stored.**|
|DisplayName|**Model Path**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modelpath`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_msdyn_OperationGuid"></a> msdyn_OperationGuid

|Property|Value|
|---|---|
|Description|**Stores Guid for each computaiton operation**|
|DisplayName|**Operation Guid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operationguid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_OperationId"></a> msdyn_OperationId

|Property|Value|
|---|---|
|Description|**Stores the task id which is used to create task in batch by service.**|
|DisplayName|**Operation Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_predictioncomputationoperationId"></a> msdyn_predictioncomputationoperationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Prediction Computation Operation**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_predictioncomputationoperationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_PredictionGuid"></a> msdyn_PredictionGuid

|Property|Value|
|---|---|
|Description|**Stores Guid for the prediction.**|
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

### <a name="BKMK_msdyn_PredictionName"></a> msdyn_PredictionName

|Property|Value|
|---|---|
|Description|**Stores prediction name.**|
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

### <a name="BKMK_msdyn_ResultPath"></a> msdyn_ResultPath

|Property|Value|
|---|---|
|Description|**Stores path where result file (scores) for scoring is stored.**|
|DisplayName|**ResultPath**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resultpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_RetryCounter"></a> msdyn_RetryCounter

|Property|Value|
|---|---|
|Description|**Stores retry counts.**|
|DisplayName|**Retry Counter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_retrycounter`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_State"></a> msdyn_State

|Property|Value|
|---|---|
|Description|**Stores the state of the docker job**|
|DisplayName|**State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_state`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_TimeSpentCrmSyncSiJobId"></a> msdyn_TimeSpentCrmSyncSiJobId

|Property|Value|
|---|---|
|Description|**Stores SI job ID for crm sync of time spent data.**|
|DisplayName|**Time Spent Crm Sync Si Job Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timespentcrmsyncsijobid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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
|Description|**Status of the Prediction Computation Operation**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_predictioncomputationoperation_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Prediction Computation Operation**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_predictioncomputationoperation_statuscode`|

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

- [business_unit_msdyn_predictioncomputationoperation](#BKMK_business_unit_msdyn_predictioncomputationoperation)
- [lk_msdyn_predictioncomputationoperation_createdby](#BKMK_lk_msdyn_predictioncomputationoperation_createdby)
- [lk_msdyn_predictioncomputationoperation_createdonbehalfby](#BKMK_lk_msdyn_predictioncomputationoperation_createdonbehalfby)
- [lk_msdyn_predictioncomputationoperation_modifiedby](#BKMK_lk_msdyn_predictioncomputationoperation_modifiedby)
- [lk_msdyn_predictioncomputationoperation_modifiedonbehalfby](#BKMK_lk_msdyn_predictioncomputationoperation_modifiedonbehalfby)
- [owner_msdyn_predictioncomputationoperation](#BKMK_owner_msdyn_predictioncomputationoperation)
- [team_msdyn_predictioncomputationoperation](#BKMK_team_msdyn_predictioncomputationoperation)
- [user_msdyn_predictioncomputationoperation](#BKMK_user_msdyn_predictioncomputationoperation)

### <a name="BKMK_business_unit_msdyn_predictioncomputationoperation"></a> business_unit_msdyn_predictioncomputationoperation

One-To-Many Relationship: [businessunit business_unit_msdyn_predictioncomputationoperation](businessunit.md#BKMK_business_unit_msdyn_predictioncomputationoperation)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictioncomputationoperation_createdby"></a> lk_msdyn_predictioncomputationoperation_createdby

One-To-Many Relationship: [systemuser lk_msdyn_predictioncomputationoperation_createdby](systemuser.md#BKMK_lk_msdyn_predictioncomputationoperation_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictioncomputationoperation_createdonbehalfby"></a> lk_msdyn_predictioncomputationoperation_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_predictioncomputationoperation_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_predictioncomputationoperation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictioncomputationoperation_modifiedby"></a> lk_msdyn_predictioncomputationoperation_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_predictioncomputationoperation_modifiedby](systemuser.md#BKMK_lk_msdyn_predictioncomputationoperation_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_predictioncomputationoperation_modifiedonbehalfby"></a> lk_msdyn_predictioncomputationoperation_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_predictioncomputationoperation_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_predictioncomputationoperation_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_predictioncomputationoperation"></a> owner_msdyn_predictioncomputationoperation

One-To-Many Relationship: [owner owner_msdyn_predictioncomputationoperation](owner.md#BKMK_owner_msdyn_predictioncomputationoperation)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_predictioncomputationoperation"></a> team_msdyn_predictioncomputationoperation

One-To-Many Relationship: [team team_msdyn_predictioncomputationoperation](team.md#BKMK_team_msdyn_predictioncomputationoperation)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_predictioncomputationoperation"></a> user_msdyn_predictioncomputationoperation

One-To-Many Relationship: [systemuser user_msdyn_predictioncomputationoperation](systemuser.md#BKMK_user_msdyn_predictioncomputationoperation)

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

- [msdyn_predictioncomputationoperation_AsyncOperations](#BKMK_msdyn_predictioncomputationoperation_AsyncOperations)
- [msdyn_predictioncomputationoperation_BulkDeleteFailures](#BKMK_msdyn_predictioncomputationoperation_BulkDeleteFailures)
- [msdyn_predictioncomputationoperation_DuplicateBaseRecord](#BKMK_msdyn_predictioncomputationoperation_DuplicateBaseRecord)
- [msdyn_predictioncomputationoperation_DuplicateMatchingRecord](#BKMK_msdyn_predictioncomputationoperation_DuplicateMatchingRecord)
- [msdyn_predictioncomputationoperation_MailboxTrackingFolders](#BKMK_msdyn_predictioncomputationoperation_MailboxTrackingFolders)
- [msdyn_predictioncomputationoperation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_predictioncomputationoperation_PrincipalObjectAttributeAccesses)
- [msdyn_predictioncomputationoperation_ProcessSession](#BKMK_msdyn_predictioncomputationoperation_ProcessSession)
- [msdyn_predictioncomputationoperation_SyncErrors](#BKMK_msdyn_predictioncomputationoperation_SyncErrors)

### <a name="BKMK_msdyn_predictioncomputationoperation_AsyncOperations"></a> msdyn_predictioncomputationoperation_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_predictioncomputationoperation_AsyncOperations](asyncoperation.md#BKMK_msdyn_predictioncomputationoperation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictioncomputationoperation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictioncomputationoperation_BulkDeleteFailures"></a> msdyn_predictioncomputationoperation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_predictioncomputationoperation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_predictioncomputationoperation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictioncomputationoperation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictioncomputationoperation_DuplicateBaseRecord"></a> msdyn_predictioncomputationoperation_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_predictioncomputationoperation_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_predictioncomputationoperation_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictioncomputationoperation_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictioncomputationoperation_DuplicateMatchingRecord"></a> msdyn_predictioncomputationoperation_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_predictioncomputationoperation_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_predictioncomputationoperation_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictioncomputationoperation_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictioncomputationoperation_MailboxTrackingFolders"></a> msdyn_predictioncomputationoperation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_predictioncomputationoperation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_predictioncomputationoperation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictioncomputationoperation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictioncomputationoperation_PrincipalObjectAttributeAccesses"></a> msdyn_predictioncomputationoperation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_predictioncomputationoperation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_predictioncomputationoperation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictioncomputationoperation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictioncomputationoperation_ProcessSession"></a> msdyn_predictioncomputationoperation_ProcessSession

Many-To-One Relationship: [processsession msdyn_predictioncomputationoperation_ProcessSession](processsession.md#BKMK_msdyn_predictioncomputationoperation_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictioncomputationoperation_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_predictioncomputationoperation_SyncErrors"></a> msdyn_predictioncomputationoperation_SyncErrors

Many-To-One Relationship: [syncerror msdyn_predictioncomputationoperation_SyncErrors](syncerror.md#BKMK_msdyn_predictioncomputationoperation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_predictioncomputationoperation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

