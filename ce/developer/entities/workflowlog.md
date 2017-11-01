---
title: "WorkflowLog Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the WorkflowLog entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# WorkflowLog Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Log used to track process execution.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/workflowlogs<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/workflowlogs(*workflowlogid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/workflowlogs(*workflowlogid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/workflowlogs<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/workflowlogs(*workflowlogid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Process Log<br />
**DisplayCollectionName**: Process Logs<br />
**SchemaName**: WorkflowLog<br />
**CollectionSchemaName**: WorkflowLogs<br />
**LogicalName**: workflowlog<br />
**LogicalCollectionName**: workflowlogs<br />
**EntitySetName**: workflowlogs<br />
**PrimaryIdAttribute**: workflowlogid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityName](#BKMK_ActivityName)
- [AsyncOperationId](#BKMK_AsyncOperationId)
- [ChildWorkflowInstanceId](#BKMK_ChildWorkflowInstanceId)
- [ChildWorkflowInstanceObjectTypeCode](#BKMK_ChildWorkflowInstanceObjectTypeCode)
- [CompletedOn](#BKMK_CompletedOn)
- [Description](#BKMK_Description)
- [ErrorCode](#BKMK_ErrorCode)
- [InteractionActivityResult](#BKMK_InteractionActivityResult)
- [Message](#BKMK_Message)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [StageName](#BKMK_StageName)
- [StartedOn](#BKMK_StartedOn)
- [Status](#BKMK_Status)
- [StepName](#BKMK_StepName)
- [WorkflowLogId](#BKMK_WorkflowLogId)


### <a name="BKMK_ActivityName"></a> ActivityName

**Description**: Name of the activity which the process step is currently processing.<br />
**DisplayName**: Activity Name<br />
**LogicalName**: activityname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_AsyncOperationId"></a> AsyncOperationId

**Description**: Unique identifier of the parent record.<br />
**DisplayName**: Parent record<br />
**LogicalName**: asyncoperationid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: asyncoperation,processsession


### <a name="BKMK_ChildWorkflowInstanceId"></a> ChildWorkflowInstanceId

**Description**: Unique identifier of the system job.<br />
**DisplayName**: Child Workflow System Job<br />
**LogicalName**: childworkflowinstanceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: asyncoperation,processsession


### <a name="BKMK_ChildWorkflowInstanceObjectTypeCode"></a> ChildWorkflowInstanceObjectTypeCode

**Description**: Object Type Code of the entity that is associated with the child workflow.<br />
**DisplayName**: Entity<br />
**LogicalName**: childworkflowinstanceobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_CompletedOn"></a> CompletedOn

**Description**: Date and time when the operation was completed.<br />
**DisplayName**: Completed On<br />
**LogicalName**: completedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_Description"></a> Description

**Description**: Description of the process step.<br />
**DisplayName**: Step Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


### <a name="BKMK_ErrorCode"></a> ErrorCode

**Description**: Error code related to process.<br />
**DisplayName**: Error Message<br />
**LogicalName**: errorcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_InteractionActivityResult"></a> InteractionActivityResult

**Description**: String specifying the result of an interaction activity.<br />
**DisplayName**: Interaction Activity Result<br />
**LogicalName**: interactionactivityresult<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


### <a name="BKMK_Message"></a> Message

**Description**: Message related to process.<br />
**DisplayName**: Message<br />
**LogicalName**: message<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

**Description**: Type of entity with which the process is associated.<br />
**DisplayName**: Entity<br />
**LogicalName**: objecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Unique identifier of the associated record.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: 


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Description**: <br />
**DisplayName**: Regarding Object Id Name<br />
**LogicalName**: regardingobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

**Description**: <br />
**DisplayName**: Regarding Object Id Yomi Name<br />
**LogicalName**: regardingobjectidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: Regarding Object Type Code<br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_StageName"></a> StageName

**Description**: Name of the process stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stagename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_StartedOn"></a> StartedOn

**Description**: Date and time when the operation was started.<br />
**DisplayName**: Started On<br />
**LogicalName**: startedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_Status"></a> Status

**Description**: Status of the process step for which process log record has been created: In Progress, Successfully Completed, or Failed.<br />
**DisplayName**: Status<br />
**LogicalName**: status<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: In Progress
- **Value**: 2 **Label**: Succeeded
- **Value**: 3 **Label**: Failed
- **Value**: 4 **Label**: Canceled
- **Value**: 5 **Label**: Waiting



### <a name="BKMK_StepName"></a> StepName

**Description**: Name of the process step.<br />
**DisplayName**: Step Name<br />
**LogicalName**: stepname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_WorkflowLogId"></a> WorkflowLogId

**Description**: Unique identifier of the process log entry.<br />
**DisplayName**: Process Log<br />
**LogicalName**: workflowlogid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AsyncOperationIdName](#BKMK_AsyncOperationIdName)
- [ChildWorkflowInstanceIdName](#BKMK_ChildWorkflowInstanceIdName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [Duration](#BKMK_Duration)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)


### <a name="BKMK_AsyncOperationIdName"></a> AsyncOperationIdName

**Description**: Name of the parent record.<br />
**DisplayName**: Parent record<br />
**LogicalName**: asyncoperationidname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_ChildWorkflowInstanceIdName"></a> ChildWorkflowInstanceIdName

**Description**: Name of the async operation.<br />
**DisplayName**: Child Async Operation Name<br />
**LogicalName**: childworkflowinstanceidname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the process log entry.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: Created By Name<br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: Created By Yomi Name<br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the process log entry was created.<br />
**DisplayName**: Started On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the process log.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: Created By(Delegate) Name<br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: Created By(Delegate) Yomi Name<br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Duration"></a> Duration

**Description**: Duration between completed on and started on, used by business process flow.<br />
**DisplayName**: Duration<br />
**LogicalName**: duration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the process log entry.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: Name of the user who last modified the operation.<br />
**DisplayName**: Modified By Name<br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: YomiName of the user who last modified the operation.<br />
**DisplayName**: Modified By Yomi Name<br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the process log entry was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the process log.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: Modified On Behalf By Name<br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: Modified On Behalf By Yomi Name<br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the process log.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: Owner Id Type<br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns the process.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns the process log.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the process.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_userentityinstancedata_workflowlog"></a> userentityinstancedata_workflowlog

Same as userentityinstancedata entity [userentityinstancedata_workflowlog](userentityinstancedata.md#BKMK_userentityinstancedata_workflowlog) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_workflowlog<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs)
- [lk_phonetocaseprocess_workflowlogs](#BKMK_lk_phonetocaseprocess_workflowlogs)
- [lk_leadtoopportunitysalesprocess_workflowlogs](#BKMK_lk_leadtoopportunitysalesprocess_workflowlogs)
- [lk_opportunitysalesprocess_workflowlogs](#BKMK_lk_opportunitysalesprocess_workflowlogs)
- [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_WorkflowLogs](#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_WorkflowLogs)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs)
- [business_unit_workflowlogs](#BKMK_business_unit_workflowlogs)
- [lk_workflowlog_createdby](#BKMK_lk_workflowlog_createdby)
- [lk_workflowlog_processsession](#BKMK_lk_workflowlog_processsession)
- [lk_workflowlog_processsession_childworkflow](#BKMK_lk_workflowlog_processsession_childworkflow)
- [lk_workflowlog_asyncoperation_childworkflow](#BKMK_lk_workflowlog_asyncoperation_childworkflow)
- [lk_workflowlog_asyncoperations](#BKMK_lk_workflowlog_asyncoperations)
- [lk_workflowlog_modifiedby](#BKMK_lk_workflowlog_modifiedby)
- [lk_newprocess_workflowlogs](#BKMK_lk_newprocess_workflowlogs)
- [team_workflowlog](#BKMK_team_workflowlog)
- [lk_workflowlog_createdonbehalfby](#BKMK_lk_workflowlog_createdonbehalfby)
- [lk_translationprocess_workflowlogs](#BKMK_lk_translationprocess_workflowlogs)
- [lk_expiredprocess_workflowlogs](#BKMK_lk_expiredprocess_workflowlogs)
- [lk_workflowlog_modifiedonbehalfby](#BKMK_lk_workflowlog_modifiedonbehalfby)


### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs

See msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b Entity [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs) One-To-Many relationship.

### <a name="BKMK_lk_phonetocaseprocess_workflowlogs"></a> lk_phonetocaseprocess_workflowlogs

See phonetocaseprocess Entity [lk_phonetocaseprocess_workflowlogs](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_workflowlogs) One-To-Many relationship.

### <a name="BKMK_lk_leadtoopportunitysalesprocess_workflowlogs"></a> lk_leadtoopportunitysalesprocess_workflowlogs

See leadtoopportunitysalesprocess Entity [lk_leadtoopportunitysalesprocess_workflowlogs](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_workflowlogs) One-To-Many relationship.

### <a name="BKMK_lk_opportunitysalesprocess_workflowlogs"></a> lk_opportunitysalesprocess_workflowlogs

See opportunitysalesprocess Entity [lk_opportunitysalesprocess_workflowlogs](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_workflowlogs) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_WorkflowLogs"></a> msdyn_bpf_665e73aa18c247d886bfc50499c73b82_WorkflowLogs

See msdyn_bpf_665e73aa18c247d886bfc50499c73b82 Entity [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_WorkflowLogs](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_WorkflowLogs) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs

See msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs

See msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 Entity [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs

See msdyn_bpf_989e9b1857e24af18787d5143b67523b Entity [msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs

See msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs

See msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 Entity [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs) One-To-Many relationship.

### <a name="BKMK_business_unit_workflowlogs"></a> business_unit_workflowlogs

See businessunit Entity [business_unit_workflowlogs](businessunit.md#BKMK_business_unit_workflowlogs) One-To-Many relationship.

### <a name="BKMK_lk_workflowlog_createdby"></a> lk_workflowlog_createdby

See systemuser Entity [lk_workflowlog_createdby](systemuser.md#BKMK_lk_workflowlog_createdby) One-To-Many relationship.

### <a name="BKMK_lk_workflowlog_processsession"></a> lk_workflowlog_processsession

See processsession Entity [lk_workflowlog_processsession](processsession.md#BKMK_lk_workflowlog_processsession) One-To-Many relationship.

### <a name="BKMK_lk_workflowlog_processsession_childworkflow"></a> lk_workflowlog_processsession_childworkflow

See processsession Entity [lk_workflowlog_processsession_childworkflow](processsession.md#BKMK_lk_workflowlog_processsession_childworkflow) One-To-Many relationship.

### <a name="BKMK_lk_workflowlog_asyncoperation_childworkflow"></a> lk_workflowlog_asyncoperation_childworkflow

See asyncoperation Entity [lk_workflowlog_asyncoperation_childworkflow](asyncoperation.md#BKMK_lk_workflowlog_asyncoperation_childworkflow) One-To-Many relationship.

### <a name="BKMK_lk_workflowlog_asyncoperations"></a> lk_workflowlog_asyncoperations

See asyncoperation Entity [lk_workflowlog_asyncoperations](asyncoperation.md#BKMK_lk_workflowlog_asyncoperations) One-To-Many relationship.

### <a name="BKMK_lk_workflowlog_modifiedby"></a> lk_workflowlog_modifiedby

See systemuser Entity [lk_workflowlog_modifiedby](systemuser.md#BKMK_lk_workflowlog_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_newprocess_workflowlogs"></a> lk_newprocess_workflowlogs

See newprocess Entity [lk_newprocess_workflowlogs](newprocess.md#BKMK_lk_newprocess_workflowlogs) One-To-Many relationship.

### <a name="BKMK_team_workflowlog"></a> team_workflowlog

See team Entity [team_workflowlog](team.md#BKMK_team_workflowlog) One-To-Many relationship.

### <a name="BKMK_lk_workflowlog_createdonbehalfby"></a> lk_workflowlog_createdonbehalfby

See systemuser Entity [lk_workflowlog_createdonbehalfby](systemuser.md#BKMK_lk_workflowlog_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_translationprocess_workflowlogs"></a> lk_translationprocess_workflowlogs

See translationprocess Entity [lk_translationprocess_workflowlogs](translationprocess.md#BKMK_lk_translationprocess_workflowlogs) One-To-Many relationship.

### <a name="BKMK_lk_expiredprocess_workflowlogs"></a> lk_expiredprocess_workflowlogs

See expiredprocess Entity [lk_expiredprocess_workflowlogs](expiredprocess.md#BKMK_lk_expiredprocess_workflowlogs) One-To-Many relationship.

### <a name="BKMK_lk_workflowlog_modifiedonbehalfby"></a> lk_workflowlog_modifiedonbehalfby

See systemuser Entity [lk_workflowlog_modifiedonbehalfby](systemuser.md#BKMK_lk_workflowlog_modifiedonbehalfby) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.workflowlog?text=workflowlog EntityType" />