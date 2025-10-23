---
title: "Evaluation criteria (msdyn_EvaluationCriteria) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Evaluation criteria (msdyn_EvaluationCriteria) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Evaluation criteria (msdyn_EvaluationCriteria) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Evaluation criteria (msdyn_EvaluationCriteria) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_evaluationcriterias(*msdyn_evaluationcriteriaid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_evaluationcriterias<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_evaluationcriterias(*msdyn_evaluationcriteriaid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_evaluationcriterias(*msdyn_evaluationcriteriaid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_evaluationcriterias<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_evaluationcriterias(*msdyn_evaluationcriteriaid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_evaluationcriterias(*msdyn_evaluationcriteriaid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_evaluationcriterias(*msdyn_evaluationcriteriaid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Evaluation criteria (msdyn_EvaluationCriteria) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Evaluation criteria** |
| **DisplayCollectionName** | **Evaluation criteria** |
| **SchemaName** | `msdyn_EvaluationCriteria` |
| **CollectionSchemaName** | `msdyn_EvaluationCriterias` |
| **EntitySetName** | `msdyn_evaluationcriterias`|
| **LogicalName** | `msdyn_evaluationcriteria` |
| **LogicalCollectionName** | `msdyn_evaluationcriterias` |
| **PrimaryIdAttribute** | `msdyn_evaluationcriteriaid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_ActiveVersion](#BKMK_msdyn_ActiveVersion)
- [msdyn_CriteriaJson](#BKMK_msdyn_CriteriaJson)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EvaluationCriteriaId](#BKMK_msdyn_EvaluationCriteriaId)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_Numberofassociatedplans](#BKMK_msdyn_Numberofassociatedplans)
- [msdyn_NumberofQuestions](#BKMK_msdyn_NumberofQuestions)
- [msdyn_ParentEvaluationCriteria](#BKMK_msdyn_ParentEvaluationCriteria)
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

### <a name="BKMK_msdyn_ActiveVersion"></a> msdyn_ActiveVersion

|Property|Value|
|---|---|
|Description|**The active Evaluation criteria version being used.**|
|DisplayName|**Active version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activeversion`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_evaluationcriteriaversion|

### <a name="BKMK_msdyn_CriteriaJson"></a> msdyn_CriteriaJson

|Property|Value|
|---|---|
|Description|**The JSON blob used to render the EvaluationCriteria.**|
|DisplayName|**CriteriaJson**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_criteriajson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048575|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**The description of the criteria**|
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
|MaxLength|850|

### <a name="BKMK_msdyn_EvaluationCriteriaId"></a> msdyn_EvaluationCriteriaId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Evaluation criteria**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationcriteriaid`|
|RequiredLevel|SystemRequired|
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

### <a name="BKMK_msdyn_Numberofassociatedplans"></a> msdyn_Numberofassociatedplans

|Property|Value|
|---|---|
|Description|**The number of evaluation plans that are actively using this criteria.**|
|DisplayName|**Evaluation plans associated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofassociatedplans`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_NumberofQuestions"></a> msdyn_NumberofQuestions

|Property|Value|
|---|---|
|Description|**The number of questions for the criteria.**|
|DisplayName|**Number of questions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofquestions`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ParentEvaluationCriteria"></a> msdyn_ParentEvaluationCriteria

|Property|Value|
|---|---|
|Description|**The parent evaluation criteria that this criteria derives from.**|
|DisplayName|**Parent evaluation criteria**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentevaluationcriteria`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_evaluationcriteria|

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
|Description|**Status of the evaluation criteria**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationcriteria_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the evaluation criteria.**|
|DisplayName|**Status reason**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationcriteria_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|700610001|Label: **Published**<br />State:0<br />TransitionData: None|
|700610002|Label: **Approved**<br />State:0<br />TransitionData: None|
|700610003|Label: **Denied**<br />State:0<br />TransitionData: None|

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

- [business_unit_msdyn_evaluationcriteria](#BKMK_business_unit_msdyn_evaluationcriteria)
- [lk_msdyn_evaluationcriteria_createdby](#BKMK_lk_msdyn_evaluationcriteria_createdby)
- [lk_msdyn_evaluationcriteria_createdonbehalfby](#BKMK_lk_msdyn_evaluationcriteria_createdonbehalfby)
- [lk_msdyn_evaluationcriteria_modifiedby](#BKMK_lk_msdyn_evaluationcriteria_modifiedby)
- [lk_msdyn_evaluationcriteria_modifiedonbehalfby](#BKMK_lk_msdyn_evaluationcriteria_modifiedonbehalfby)
- [msdyn_evaluationcriteria_ActiveVersion_msdyn_evaluationcriteriaversion](#BKMK_msdyn_evaluationcriteria_ActiveVersion_msdyn_evaluationcriteriaversion)
- [msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria-many-to-one)
- [owner_msdyn_evaluationcriteria](#BKMK_owner_msdyn_evaluationcriteria)
- [team_msdyn_evaluationcriteria](#BKMK_team_msdyn_evaluationcriteria)
- [user_msdyn_evaluationcriteria](#BKMK_user_msdyn_evaluationcriteria)

### <a name="BKMK_business_unit_msdyn_evaluationcriteria"></a> business_unit_msdyn_evaluationcriteria

One-To-Many Relationship: [businessunit business_unit_msdyn_evaluationcriteria](businessunit.md#BKMK_business_unit_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationcriteria_createdby"></a> lk_msdyn_evaluationcriteria_createdby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationcriteria_createdby](systemuser.md#BKMK_lk_msdyn_evaluationcriteria_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationcriteria_createdonbehalfby"></a> lk_msdyn_evaluationcriteria_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationcriteria_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationcriteria_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationcriteria_modifiedby"></a> lk_msdyn_evaluationcriteria_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationcriteria_modifiedby](systemuser.md#BKMK_lk_msdyn_evaluationcriteria_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationcriteria_modifiedonbehalfby"></a> lk_msdyn_evaluationcriteria_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationcriteria_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationcriteria_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationcriteria_ActiveVersion_msdyn_evaluationcriteriaversion"></a> msdyn_evaluationcriteria_ActiveVersion_msdyn_evaluationcriteriaversion

One-To-Many Relationship: [msdyn_evaluationcriteriaversion msdyn_evaluationcriteria_ActiveVersion_msdyn_evaluationcriteriaversion](msdyn_evaluationcriteriaversion.md#BKMK_msdyn_evaluationcriteria_ActiveVersion_msdyn_evaluationcriteriaversion)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationcriteriaversion`|
|ReferencedAttribute|`msdyn_evaluationcriteriaversionid`|
|ReferencingAttribute|`msdyn_activeversion`|
|ReferencingEntityNavigationPropertyName|`msdyn_ActiveVersion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria-many-to-one"></a> msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria

One-To-Many Relationship: [msdyn_evaluationcriteria msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationcriteria`|
|ReferencedAttribute|`msdyn_evaluationcriteriaid`|
|ReferencingAttribute|`msdyn_parentevaluationcriteria`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentEvaluationCriteria`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_evaluationcriteria"></a> owner_msdyn_evaluationcriteria

One-To-Many Relationship: [owner owner_msdyn_evaluationcriteria](owner.md#BKMK_owner_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_evaluationcriteria"></a> team_msdyn_evaluationcriteria

One-To-Many Relationship: [team team_msdyn_evaluationcriteria](team.md#BKMK_team_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_evaluationcriteria"></a> user_msdyn_evaluationcriteria

One-To-Many Relationship: [systemuser user_msdyn_evaluationcriteria](systemuser.md#BKMK_user_msdyn_evaluationcriteria)

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

- [msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria)
- [msdyn_evaluationcategory_EvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationcategory_EvaluationCriteria_msdyn_evaluationcriteria)
- [msdyn_evaluationcriteria_AsyncOperations](#BKMK_msdyn_evaluationcriteria_AsyncOperations)
- [msdyn_evaluationcriteria_BulkDeleteFailures](#BKMK_msdyn_evaluationcriteria_BulkDeleteFailures)
- [msdyn_evaluationcriteria_MailboxTrackingFolders](#BKMK_msdyn_evaluationcriteria_MailboxTrackingFolders)
- [msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria-one-to-many)
- [msdyn_evaluationcriteria_PrincipalObjectAttributeAccesses](#BKMK_msdyn_evaluationcriteria_PrincipalObjectAttributeAccesses)
- [msdyn_evaluationcriteria_ProcessSession](#BKMK_msdyn_evaluationcriteria_ProcessSession)
- [msdyn_evaluationcriteria_SyncErrors](#BKMK_msdyn_evaluationcriteria_SyncErrors)
- [msdyn_evaluationcriteriaversion_EvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationcriteriaversion_EvaluationCriteria_msdyn_evaluationcriteria)
- [msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria)
- [msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria)
- [msdyn_evaluationquestion_EvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationquestion_EvaluationCriteria_msdyn_evaluationcriteria)

### <a name="BKMK_msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria"></a> msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria

Many-To-One Relationship: [msdyn_evaluation msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria](msdyn_evaluation.md#BKMK_msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluation`|
|ReferencingAttribute|`msdyn_evaluationcriteria`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluation_EvaluationCriteria_msdyn_evaluationcriteria`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationcategory_EvaluationCriteria_msdyn_evaluationcriteria"></a> msdyn_evaluationcategory_EvaluationCriteria_msdyn_evaluationcriteria

Many-To-One Relationship: [msdyn_evaluationcategory msdyn_evaluationcategory_EvaluationCriteria_msdyn_evaluationcriteria](msdyn_evaluationcategory.md#BKMK_msdyn_evaluationcategory_EvaluationCriteria_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationcategory`|
|ReferencingAttribute|`msdyn_evaluationcriteria`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationcategory_EvaluationCriteria_msdyn_evaluationcriteria`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationcriteria_AsyncOperations"></a> msdyn_evaluationcriteria_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_evaluationcriteria_AsyncOperations](asyncoperation.md#BKMK_msdyn_evaluationcriteria_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationcriteria_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationcriteria_BulkDeleteFailures"></a> msdyn_evaluationcriteria_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_evaluationcriteria_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_evaluationcriteria_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationcriteria_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationcriteria_MailboxTrackingFolders"></a> msdyn_evaluationcriteria_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_evaluationcriteria_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_evaluationcriteria_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationcriteria_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria-one-to-many"></a> msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria

Many-To-One Relationship: [msdyn_evaluationcriteria msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria](#BKMK_msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationcriteria`|
|ReferencingAttribute|`msdyn_parentevaluationcriteria`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationcriteria_ParentEvaluationCriteria_msdyn_evaluationcriteria`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationcriteria_PrincipalObjectAttributeAccesses"></a> msdyn_evaluationcriteria_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_evaluationcriteria_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_evaluationcriteria_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationcriteria_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationcriteria_ProcessSession"></a> msdyn_evaluationcriteria_ProcessSession

Many-To-One Relationship: [processsession msdyn_evaluationcriteria_ProcessSession](processsession.md#BKMK_msdyn_evaluationcriteria_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationcriteria_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationcriteria_SyncErrors"></a> msdyn_evaluationcriteria_SyncErrors

Many-To-One Relationship: [syncerror msdyn_evaluationcriteria_SyncErrors](syncerror.md#BKMK_msdyn_evaluationcriteria_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationcriteria_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationcriteriaversion_EvaluationCriteria_msdyn_evaluationcriteria"></a> msdyn_evaluationcriteriaversion_EvaluationCriteria_msdyn_evaluationcriteria

Many-To-One Relationship: [msdyn_evaluationcriteriaversion msdyn_evaluationcriteriaversion_EvaluationCriteria_msdyn_evaluationcriteria](msdyn_evaluationcriteriaversion.md#BKMK_msdyn_evaluationcriteriaversion_EvaluationCriteria_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationcriteriaversion`|
|ReferencingAttribute|`msdyn_evaluationcriteria`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationcriteriaversion_EvaluationCriteria_msdyn_evaluationcriteria`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria"></a> msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria

Many-To-One Relationship: [msdyn_evaluationplan msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria](msdyn_evaluationplan.md#BKMK_msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationplan`|
|ReferencingAttribute|`msdyn_evaluationcriteria`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplan_EvaluationCriteria_msdyn_evaluationcriteria`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria"></a> msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria

Many-To-One Relationship: [msdyn_evaluationplanrun msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria](msdyn_evaluationplanrun.md#BKMK_msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationplanrun`|
|ReferencingAttribute|`msdyn_evaluationcriteria`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationplanrun_EvaluationCriteria_msdyn_evaluationcriteria`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationquestion_EvaluationCriteria_msdyn_evaluationcriteria"></a> msdyn_evaluationquestion_EvaluationCriteria_msdyn_evaluationcriteria

Many-To-One Relationship: [msdyn_evaluationquestion msdyn_evaluationquestion_EvaluationCriteria_msdyn_evaluationcriteria](msdyn_evaluationquestion.md#BKMK_msdyn_evaluationquestion_EvaluationCriteria_msdyn_evaluationcriteria)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationquestion`|
|ReferencingAttribute|`msdyn_evaluationcriteria`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationquestion_EvaluationCriteria_msdyn_evaluationcriteria`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

