---
title: "Guide Session Step Visit (msmrw_GuideSessionStepVisit) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Guide Session Step Visit (msmrw_GuideSessionStepVisit) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Guide Session Step Visit (msmrw_GuideSessionStepVisit) table/entity reference

Stores information about the duration of a step visit, along step specific details.

## Messages

The following table lists the messages for the Guide Session Step Visit (msmrw_GuideSessionStepVisit) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msmrw_guidesessionstepvisits(*msmrw_guidesessionstepvisitid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msmrw_guidesessionstepvisits<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msmrw_guidesessionstepvisits(*msmrw_guidesessionstepvisitid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msmrw_guidesessionstepvisits(*msmrw_guidesessionstepvisitid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msmrw_guidesessionstepvisits<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msmrw_guidesessionstepvisits(*msmrw_guidesessionstepvisitid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msmrw_guidesessionstepvisits(*msmrw_guidesessionstepvisitid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msmrw_guidesessionstepvisits(*msmrw_guidesessionstepvisitid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Guide Session Step Visit (msmrw_GuideSessionStepVisit) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Guide Session Step Visit (msmrw_GuideSessionStepVisit) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Guide Session Step Visit** |
| **DisplayCollectionName** | **Guide Session Step Visits** |
| **SchemaName** | `msmrw_GuideSessionStepVisit` |
| **CollectionSchemaName** | `msmrw_GuideSessionStepVisits` |
| **EntitySetName** | `msmrw_guidesessionstepvisits`|
| **LogicalName** | `msmrw_guidesessionstepvisit` |
| **LogicalCollectionName** | `msmrw_guidesessionstepvisits` |
| **PrimaryIdAttribute** | `msmrw_guidesessionstepvisitid` |
| **PrimaryNameAttribute** |`msmrw_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msmrw_GuideSessionId](#BKMK_msmrw_GuideSessionId)
- [msmrw_GuideSessionStepVisitId](#BKMK_msmrw_GuideSessionStepVisitId)
- [msmrw_Name](#BKMK_msmrw_Name)
- [msmrw_StepDurationSeconds](#BKMK_msmrw_StepDurationSeconds)
- [msmrw_StepId](#BKMK_msmrw_StepId)
- [msmrw_StepIndex](#BKMK_msmrw_StepIndex)
- [msmrw_StepTemplateType](#BKMK_msmrw_StepTemplateType)
- [msmrw_StepVisitEndTime](#BKMK_msmrw_StepVisitEndTime)
- [msmrw_StepVisitNumber](#BKMK_msmrw_StepVisitNumber)
- [msmrw_StepVisitStartTime](#BKMK_msmrw_StepVisitStartTime)
- [msmrw_TaskIndex](#BKMK_msmrw_TaskIndex)
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

### <a name="BKMK_msmrw_GuideSessionId"></a> msmrw_GuideSessionId

|Property|Value|
|---|---|
|Description|**Reference to the guide session.**|
|DisplayName|**Guide Session Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guidesessionid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msmrw_guidesession|

### <a name="BKMK_msmrw_GuideSessionStepVisitId"></a> msmrw_GuideSessionStepVisitId

|Property|Value|
|---|---|
|Description|**Unique identifier for guide session step visit.**|
|DisplayName|**Guide Session Step Visit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_guidesessionstepvisitid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msmrw_Name"></a> msmrw_Name

|Property|Value|
|---|---|
|Description|**Required name field**|
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

### <a name="BKMK_msmrw_StepId"></a> msmrw_StepId

|Property|Value|
|---|---|
|Description|**Reference to the guide step.**|
|DisplayName|**Step Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_stepid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msmrw_guidestep|

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
|Description|**Status of the Guide Session Step Visit**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guidesessionstepvisit_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Guide Session Step Visit**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guidesessionstepvisit_statuscode`|

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

- [business_unit_msmrw_guidesessionstepvisit](#BKMK_business_unit_msmrw_guidesessionstepvisit)
- [lk_msmrw_guidesessionstepvisit_createdby](#BKMK_lk_msmrw_guidesessionstepvisit_createdby)
- [lk_msmrw_guidesessionstepvisit_createdonbehalfby](#BKMK_lk_msmrw_guidesessionstepvisit_createdonbehalfby)
- [lk_msmrw_guidesessionstepvisit_modifiedby](#BKMK_lk_msmrw_guidesessionstepvisit_modifiedby)
- [lk_msmrw_guidesessionstepvisit_modifiedonbehalfby](#BKMK_lk_msmrw_guidesessionstepvisit_modifiedonbehalfby)
- [msmrw_GuideSessionStepVisit_GuideSessionI](#BKMK_msmrw_GuideSessionStepVisit_GuideSessionI)
- [msmrw_GuideSessionStepVisit_StepId_msmrw_](#BKMK_msmrw_GuideSessionStepVisit_StepId_msmrw_)
- [owner_msmrw_guidesessionstepvisit](#BKMK_owner_msmrw_guidesessionstepvisit)
- [team_msmrw_guidesessionstepvisit](#BKMK_team_msmrw_guidesessionstepvisit)
- [user_msmrw_guidesessionstepvisit](#BKMK_user_msmrw_guidesessionstepvisit)

### <a name="BKMK_business_unit_msmrw_guidesessionstepvisit"></a> business_unit_msmrw_guidesessionstepvisit

One-To-Many Relationship: [businessunit business_unit_msmrw_guidesessionstepvisit](businessunit.md#BKMK_business_unit_msmrw_guidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidesessionstepvisit_createdby"></a> lk_msmrw_guidesessionstepvisit_createdby

One-To-Many Relationship: [systemuser lk_msmrw_guidesessionstepvisit_createdby](systemuser.md#BKMK_lk_msmrw_guidesessionstepvisit_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidesessionstepvisit_createdonbehalfby"></a> lk_msmrw_guidesessionstepvisit_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guidesessionstepvisit_createdonbehalfby](systemuser.md#BKMK_lk_msmrw_guidesessionstepvisit_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidesessionstepvisit_modifiedby"></a> lk_msmrw_guidesessionstepvisit_modifiedby

One-To-Many Relationship: [systemuser lk_msmrw_guidesessionstepvisit_modifiedby](systemuser.md#BKMK_lk_msmrw_guidesessionstepvisit_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidesessionstepvisit_modifiedonbehalfby"></a> lk_msmrw_guidesessionstepvisit_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guidesessionstepvisit_modifiedonbehalfby](systemuser.md#BKMK_lk_msmrw_guidesessionstepvisit_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_GuideSessionStepVisit_GuideSessionI"></a> msmrw_GuideSessionStepVisit_GuideSessionI

One-To-Many Relationship: [msmrw_guidesession msmrw_GuideSessionStepVisit_GuideSessionI](msmrw_guidesession.md#BKMK_msmrw_GuideSessionStepVisit_GuideSessionI)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidesession`|
|ReferencedAttribute|`msmrw_guidesessionid`|
|ReferencingAttribute|`msmrw_guidesessionid`|
|ReferencingEntityNavigationPropertyName|`msmrw_GuideSessionId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_GuideSessionStepVisit_StepId_msmrw_"></a> msmrw_GuideSessionStepVisit_StepId_msmrw_

One-To-Many Relationship: [msmrw_guidestep msmrw_GuideSessionStepVisit_StepId_msmrw_](msmrw_guidestep.md#BKMK_msmrw_GuideSessionStepVisit_StepId_msmrw_)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidestep`|
|ReferencedAttribute|`msmrw_guidestepid`|
|ReferencingAttribute|`msmrw_stepid`|
|ReferencingEntityNavigationPropertyName|`msmrw_StepId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msmrw_guidesessionstepvisit"></a> owner_msmrw_guidesessionstepvisit

One-To-Many Relationship: [owner owner_msmrw_guidesessionstepvisit](owner.md#BKMK_owner_msmrw_guidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msmrw_guidesessionstepvisit"></a> team_msmrw_guidesessionstepvisit

One-To-Many Relationship: [team team_msmrw_guidesessionstepvisit](team.md#BKMK_team_msmrw_guidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msmrw_guidesessionstepvisit"></a> user_msmrw_guidesessionstepvisit

One-To-Many Relationship: [systemuser user_msmrw_guidesessionstepvisit](systemuser.md#BKMK_user_msmrw_guidesessionstepvisit)

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

- [msmrw_guidesessionstepvisit_AsyncOperations](#BKMK_msmrw_guidesessionstepvisit_AsyncOperations)
- [msmrw_guidesessionstepvisit_BulkDeleteFailures](#BKMK_msmrw_guidesessionstepvisit_BulkDeleteFailures)
- [msmrw_guidesessionstepvisit_DuplicateBaseRecord](#BKMK_msmrw_guidesessionstepvisit_DuplicateBaseRecord)
- [msmrw_guidesessionstepvisit_DuplicateMatchingRecord](#BKMK_msmrw_guidesessionstepvisit_DuplicateMatchingRecord)
- [msmrw_guidesessionstepvisit_MailboxTrackingFolders](#BKMK_msmrw_guidesessionstepvisit_MailboxTrackingFolders)
- [msmrw_guidesessionstepvisit_PrincipalObjectAttributeAccesses](#BKMK_msmrw_guidesessionstepvisit_PrincipalObjectAttributeAccesses)
- [msmrw_guidesessionstepvisit_ProcessSession](#BKMK_msmrw_guidesessionstepvisit_ProcessSession)
- [msmrw_guidesessionstepvisit_SyncErrors](#BKMK_msmrw_guidesessionstepvisit_SyncErrors)

### <a name="BKMK_msmrw_guidesessionstepvisit_AsyncOperations"></a> msmrw_guidesessionstepvisit_AsyncOperations

Many-To-One Relationship: [asyncoperation msmrw_guidesessionstepvisit_AsyncOperations](asyncoperation.md#BKMK_msmrw_guidesessionstepvisit_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidesessionstepvisit_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidesessionstepvisit_BulkDeleteFailures"></a> msmrw_guidesessionstepvisit_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msmrw_guidesessionstepvisit_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msmrw_guidesessionstepvisit_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidesessionstepvisit_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidesessionstepvisit_DuplicateBaseRecord"></a> msmrw_guidesessionstepvisit_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msmrw_guidesessionstepvisit_DuplicateBaseRecord](duplicaterecord.md#BKMK_msmrw_guidesessionstepvisit_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidesessionstepvisit_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidesessionstepvisit_DuplicateMatchingRecord"></a> msmrw_guidesessionstepvisit_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msmrw_guidesessionstepvisit_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msmrw_guidesessionstepvisit_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidesessionstepvisit_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidesessionstepvisit_MailboxTrackingFolders"></a> msmrw_guidesessionstepvisit_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msmrw_guidesessionstepvisit_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msmrw_guidesessionstepvisit_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidesessionstepvisit_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidesessionstepvisit_PrincipalObjectAttributeAccesses"></a> msmrw_guidesessionstepvisit_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msmrw_guidesessionstepvisit_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msmrw_guidesessionstepvisit_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidesessionstepvisit_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidesessionstepvisit_ProcessSession"></a> msmrw_guidesessionstepvisit_ProcessSession

Many-To-One Relationship: [processsession msmrw_guidesessionstepvisit_ProcessSession](processsession.md#BKMK_msmrw_guidesessionstepvisit_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidesessionstepvisit_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidesessionstepvisit_SyncErrors"></a> msmrw_guidesessionstepvisit_SyncErrors

Many-To-One Relationship: [syncerror msmrw_guidesessionstepvisit_SyncErrors](syncerror.md#BKMK_msmrw_guidesessionstepvisit_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidesessionstepvisit_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

