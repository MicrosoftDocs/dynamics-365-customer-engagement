---
title: "Packaged Guide Session Step Visit (msmrw_packagedguidesessionstepvisit) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Packaged Guide Session Step Visit (msmrw_packagedguidesessionstepvisit) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Packaged Guide Session Step Visit (msmrw_packagedguidesessionstepvisit) table/entity reference

Stores information about the duration of a step visit, along step specific details.

## Messages

The following table lists the messages for the Packaged Guide Session Step Visit (msmrw_packagedguidesessionstepvisit) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msmrw_packagedguidesessionstepvisits(*msmrw_packagedguidesessionstepvisitid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msmrw_packagedguidesessionstepvisits<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msmrw_packagedguidesessionstepvisits(*msmrw_packagedguidesessionstepvisitid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msmrw_packagedguidesessionstepvisits(*msmrw_packagedguidesessionstepvisitid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msmrw_packagedguidesessionstepvisits<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msmrw_packagedguidesessionstepvisits(*msmrw_packagedguidesessionstepvisitid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msmrw_packagedguidesessionstepvisits(*msmrw_packagedguidesessionstepvisitid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msmrw_packagedguidesessionstepvisits(*msmrw_packagedguidesessionstepvisitid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Packaged Guide Session Step Visit (msmrw_packagedguidesessionstepvisit) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Packaged Guide Session Step Visit (msmrw_packagedguidesessionstepvisit) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Packaged Guide Session Step Visit** |
| **DisplayCollectionName** | **Packaged Guide Session Step Visits** |
| **SchemaName** | `msmrw_packagedguidesessionstepvisit` |
| **CollectionSchemaName** | `msmrw_packagedguidesessionstepvisits` |
| **EntitySetName** | `msmrw_packagedguidesessionstepvisits`|
| **LogicalName** | `msmrw_packagedguidesessionstepvisit` |
| **LogicalCollectionName** | `msmrw_packagedguidesessionstepvisits` |
| **PrimaryIdAttribute** | `msmrw_packagedguidesessionstepvisitid` |
| **PrimaryNameAttribute** |`msmrw_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msmrw_instructiontext](#BKMK_msmrw_instructiontext)
- [msmrw_name](#BKMK_msmrw_name)
- [msmrw_packagedguidesessionid](#BKMK_msmrw_packagedguidesessionid)
- [msmrw_packagedguidesessionstepvisitId](#BKMK_msmrw_packagedguidesessionstepvisitId)
- [msmrw_step_id](#BKMK_msmrw_step_id)
- [msmrw_StepDurationSeconds](#BKMK_msmrw_StepDurationSeconds)
- [msmrw_StepIndex](#BKMK_msmrw_StepIndex)
- [msmrw_StepTemplateType](#BKMK_msmrw_StepTemplateType)
- [msmrw_StepVisitEndTime](#BKMK_msmrw_StepVisitEndTime)
- [msmrw_StepVisitNumber](#BKMK_msmrw_StepVisitNumber)
- [msmrw_StepVisitStartTime](#BKMK_msmrw_StepVisitStartTime)
- [msmrw_taskid](#BKMK_msmrw_taskid)
- [msmrw_TaskIndex](#BKMK_msmrw_TaskIndex)
- [msmrw_taskname](#BKMK_msmrw_taskname)
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

### <a name="BKMK_msmrw_instructiontext"></a> msmrw_instructiontext

|Property|Value|
|---|---|
|Description|**Instruction text from visited step**|
|DisplayName|**Step Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_instructiontext`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msmrw_name"></a> msmrw_name

|Property|Value|
|---|---|
|Description||
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_packagedguidesessionid"></a> msmrw_packagedguidesessionid

|Property|Value|
|---|---|
|Description|**Reference to the guide session.**|
|DisplayName|**Packaged Guide Session Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_packagedguidesessionid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msmrw_packagedguidesoperatorsession|

### <a name="BKMK_msmrw_packagedguidesessionstepvisitId"></a> msmrw_packagedguidesessionstepvisitId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Packaged Guide Session Step Visit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_packagedguidesessionstepvisitid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msmrw_step_id"></a> msmrw_step_id

|Property|Value|
|---|---|
|Description|**Reference to the packaged guide step.**|
|DisplayName|**Step Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_step_id`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_StepDurationSeconds"></a> msmrw_StepDurationSeconds

|Property|Value|
|---|---|
|Description|**Time (in seconds) spent on a step.**|
|DisplayName|**Step Duration Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_stepdurationseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msmrw_StepIndex"></a> msmrw_StepIndex

|Property|Value|
|---|---|
|Description|**The placement of the step in the guide in relation to other steps.**|
|DisplayName|**Step Index**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_stepindex`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_StepTemplateType"></a> msmrw_StepTemplateType

|Property|Value|
|---|---|
|Description|**Defines the type of the step (Can be set to: Default, Question, Completion).**|
|DisplayName|**Step Template Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_steptemplatetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|937380000|
|GlobalChoiceName|`msmrw_steptemplatetype`|

#### msmrw_StepTemplateType Choices/Options

|Value|Label|
|---|---|
|937380000|**Default**|
|937380001|**Question**|
|937380002|**Completion**|

### <a name="BKMK_msmrw_StepVisitEndTime"></a> msmrw_StepVisitEndTime

|Property|Value|
|---|---|
|Description|**Date and time when the step visit ended.**|
|DisplayName|**Step Visit End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_stepvisitendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msmrw_StepVisitNumber"></a> msmrw_StepVisitNumber

|Property|Value|
|---|---|
|Description|**Counter that indicates the step visit number for the guide session. The counter increments whether the operator moves forward OR backward in the guide.**|
|DisplayName|**Step Visit Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_stepvisitnumber`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_StepVisitStartTime"></a> msmrw_StepVisitStartTime

|Property|Value|
|---|---|
|Description|**Date and time when the step visit started.**|
|DisplayName|**Step Visit Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_stepvisitstarttime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msmrw_taskid"></a> msmrw_taskid

|Property|Value|
|---|---|
|Description|**reference to packaged guide task**|
|DisplayName|**TaskId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_taskid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_TaskIndex"></a> msmrw_TaskIndex

|Property|Value|
|---|---|
|Description|**The placement of the task in the guide in relation to other tasks.**|
|DisplayName|**Task Index**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_taskindex`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_taskname"></a> msmrw_taskname

|Property|Value|
|---|---|
|Description|**Name of the Task visited**|
|DisplayName|**Task Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_taskname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Packaged Guide Session Step Visit**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_packagedguidesessionstepvisit_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Packaged Guide Session Step Visit**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_packagedguidesessionstepvisit_statuscode`|

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

- [business_unit_msmrw_packagedguidesessionstepvisit](#BKMK_business_unit_msmrw_packagedguidesessionstepvisit)
- [lk_msmrw_packagedguidesessionstepvisit_createdby](#BKMK_lk_msmrw_packagedguidesessionstepvisit_createdby)
- [lk_msmrw_packagedguidesessionstepvisit_createdonbehalfby](#BKMK_lk_msmrw_packagedguidesessionstepvisit_createdonbehalfby)
- [lk_msmrw_packagedguidesessionstepvisit_modifiedby](#BKMK_lk_msmrw_packagedguidesessionstepvisit_modifiedby)
- [lk_msmrw_packagedguidesessionstepvisit_modifiedonbehalfby](#BKMK_lk_msmrw_packagedguidesessionstepvisit_modifiedonbehalfby)
- [msmrw_msmrw_packagedguidesessionstepvisit_pack](#BKMK_msmrw_msmrw_packagedguidesessionstepvisit_pack)
- [owner_msmrw_packagedguidesessionstepvisit](#BKMK_owner_msmrw_packagedguidesessionstepvisit)
- [team_msmrw_packagedguidesessionstepvisit](#BKMK_team_msmrw_packagedguidesessionstepvisit)
- [user_msmrw_packagedguidesessionstepvisit](#BKMK_user_msmrw_packagedguidesessionstepvisit)

### <a name="BKMK_business_unit_msmrw_packagedguidesessionstepvisit"></a> business_unit_msmrw_packagedguidesessionstepvisit

One-To-Many Relationship: [businessunit business_unit_msmrw_packagedguidesessionstepvisit](businessunit.md#BKMK_business_unit_msmrw_packagedguidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_packagedguidesessionstepvisit_createdby"></a> lk_msmrw_packagedguidesessionstepvisit_createdby

One-To-Many Relationship: [systemuser lk_msmrw_packagedguidesessionstepvisit_createdby](systemuser.md#BKMK_lk_msmrw_packagedguidesessionstepvisit_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_packagedguidesessionstepvisit_createdonbehalfby"></a> lk_msmrw_packagedguidesessionstepvisit_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_packagedguidesessionstepvisit_createdonbehalfby](systemuser.md#BKMK_lk_msmrw_packagedguidesessionstepvisit_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_packagedguidesessionstepvisit_modifiedby"></a> lk_msmrw_packagedguidesessionstepvisit_modifiedby

One-To-Many Relationship: [systemuser lk_msmrw_packagedguidesessionstepvisit_modifiedby](systemuser.md#BKMK_lk_msmrw_packagedguidesessionstepvisit_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_packagedguidesessionstepvisit_modifiedonbehalfby"></a> lk_msmrw_packagedguidesessionstepvisit_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_packagedguidesessionstepvisit_modifiedonbehalfby](systemuser.md#BKMK_lk_msmrw_packagedguidesessionstepvisit_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_packagedguidesessionstepvisit_pack"></a> msmrw_msmrw_packagedguidesessionstepvisit_pack

One-To-Many Relationship: [msmrw_packagedguidesoperatorsession msmrw_msmrw_packagedguidesessionstepvisit_pack](msmrw_packagedguidesoperatorsession.md#BKMK_msmrw_msmrw_packagedguidesessionstepvisit_pack)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_packagedguidesoperatorsession`|
|ReferencedAttribute|`msmrw_packagedguidesoperatorsessionid`|
|ReferencingAttribute|`msmrw_packagedguidesessionid`|
|ReferencingEntityNavigationPropertyName|`msmrw_packagedguidesessionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msmrw_packagedguidesessionstepvisit"></a> owner_msmrw_packagedguidesessionstepvisit

One-To-Many Relationship: [owner owner_msmrw_packagedguidesessionstepvisit](owner.md#BKMK_owner_msmrw_packagedguidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msmrw_packagedguidesessionstepvisit"></a> team_msmrw_packagedguidesessionstepvisit

One-To-Many Relationship: [team team_msmrw_packagedguidesessionstepvisit](team.md#BKMK_team_msmrw_packagedguidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msmrw_packagedguidesessionstepvisit"></a> user_msmrw_packagedguidesessionstepvisit

One-To-Many Relationship: [systemuser user_msmrw_packagedguidesessionstepvisit](systemuser.md#BKMK_user_msmrw_packagedguidesessionstepvisit)

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

- [msmrw_packagedguidesessionstepvisit_AsyncOperations](#BKMK_msmrw_packagedguidesessionstepvisit_AsyncOperations)
- [msmrw_packagedguidesessionstepvisit_BulkDeleteFailures](#BKMK_msmrw_packagedguidesessionstepvisit_BulkDeleteFailures)
- [msmrw_packagedguidesessionstepvisit_MailboxTrackingFolders](#BKMK_msmrw_packagedguidesessionstepvisit_MailboxTrackingFolders)
- [msmrw_packagedguidesessionstepvisit_PrincipalObjectAttributeAccesses](#BKMK_msmrw_packagedguidesessionstepvisit_PrincipalObjectAttributeAccesses)
- [msmrw_packagedguidesessionstepvisit_ProcessSession](#BKMK_msmrw_packagedguidesessionstepvisit_ProcessSession)
- [msmrw_packagedguidesessionstepvisit_SyncErrors](#BKMK_msmrw_packagedguidesessionstepvisit_SyncErrors)

### <a name="BKMK_msmrw_packagedguidesessionstepvisit_AsyncOperations"></a> msmrw_packagedguidesessionstepvisit_AsyncOperations

Many-To-One Relationship: [asyncoperation msmrw_packagedguidesessionstepvisit_AsyncOperations](asyncoperation.md#BKMK_msmrw_packagedguidesessionstepvisit_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesessionstepvisit_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesessionstepvisit_BulkDeleteFailures"></a> msmrw_packagedguidesessionstepvisit_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msmrw_packagedguidesessionstepvisit_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msmrw_packagedguidesessionstepvisit_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesessionstepvisit_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesessionstepvisit_MailboxTrackingFolders"></a> msmrw_packagedguidesessionstepvisit_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msmrw_packagedguidesessionstepvisit_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msmrw_packagedguidesessionstepvisit_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesessionstepvisit_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesessionstepvisit_PrincipalObjectAttributeAccesses"></a> msmrw_packagedguidesessionstepvisit_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msmrw_packagedguidesessionstepvisit_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msmrw_packagedguidesessionstepvisit_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesessionstepvisit_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesessionstepvisit_ProcessSession"></a> msmrw_packagedguidesessionstepvisit_ProcessSession

Many-To-One Relationship: [processsession msmrw_packagedguidesessionstepvisit_ProcessSession](processsession.md#BKMK_msmrw_packagedguidesessionstepvisit_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesessionstepvisit_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesessionstepvisit_SyncErrors"></a> msmrw_packagedguidesessionstepvisit_SyncErrors

Many-To-One Relationship: [syncerror msmrw_packagedguidesessionstepvisit_SyncErrors](syncerror.md#BKMK_msmrw_packagedguidesessionstepvisit_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesessionstepvisit_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

