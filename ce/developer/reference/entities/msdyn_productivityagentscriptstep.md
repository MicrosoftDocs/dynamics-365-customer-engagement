---
title: "Agent script step (msdyn_productivityagentscriptstep) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Agent script step (msdyn_productivityagentscriptstep) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Agent script step (msdyn_productivityagentscriptstep) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Agent script step (msdyn_productivityagentscriptstep) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_productivityagentscriptsteps(*msdyn_productivityagentscriptstepid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_productivityagentscriptsteps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_productivityagentscriptsteps(*msdyn_productivityagentscriptstepid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_productivityagentscriptsteps(*msdyn_productivityagentscriptstepid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_productivityagentscriptsteps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_productivityagentscriptsteps(*msdyn_productivityagentscriptstepid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_productivityagentscriptsteps(*msdyn_productivityagentscriptstepid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_productivityagentscriptsteps(*msdyn_productivityagentscriptstepid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agent script step (msdyn_productivityagentscriptstep) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agent script step** |
| **DisplayCollectionName** | **Agent script steps** |
| **SchemaName** | `msdyn_productivityagentscriptstep` |
| **CollectionSchemaName** | `msdyn_productivityagentscriptsteps` |
| **EntitySetName** | `msdyn_productivityagentscriptsteps`|
| **LogicalName** | `msdyn_productivityagentscriptstep` |
| **LogicalCollectionName** | `msdyn_productivityagentscriptsteps` |
| **PrimaryIdAttribute** | `msdyn_productivityagentscriptstepid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_actiontype](#BKMK_msdyn_actiontype)
- [msdyn_agentscriptid](#BKMK_msdyn_agentscriptid)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_macroactionid](#BKMK_msdyn_macroactionid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_order](#BKMK_msdyn_order)
- [msdyn_productivityagentscriptstepId](#BKMK_msdyn_productivityagentscriptstepId)
- [msdyn_routeactionid](#BKMK_msdyn_routeactionid)
- [msdyn_textinstruction](#BKMK_msdyn_textinstruction)
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

### <a name="BKMK_msdyn_actiontype"></a> msdyn_actiontype

|Property|Value|
|---|---|
|Description|**Action type for agent script step**|
|DisplayName|**Action type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actiontype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_productivityagentscriptstep_msdyn_actiontype`|

#### msdyn_actiontype Choices/Options

|Value|Label|
|---|---|
|192350000|**Text**|
|192350001|**Macro**|
|192350002|**Script**|

### <a name="BKMK_msdyn_agentscriptid"></a> msdyn_agentscriptid

|Property|Value|
|---|---|
|Description|**Unique identifier for agent script associated with agent script step.**|
|DisplayName|**Agent script**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentscriptid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_productivityagentscript|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Description for agent script step**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|2000|

### <a name="BKMK_msdyn_macroactionid"></a> msdyn_macroactionid

|Property|Value|
|---|---|
|Description|**Unique identifier for macro associated with agent script step**|
|DisplayName|**Target macro**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_macroactionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|workflow|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|100|

### <a name="BKMK_msdyn_order"></a> msdyn_order

|Property|Value|
|---|---|
|Description|**Display order**|
|DisplayName|**Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_order`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_productivityagentscriptstepId"></a> msdyn_productivityagentscriptstepId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Agent script step**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_productivityagentscriptstepid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_routeactionid"></a> msdyn_routeactionid

|Property|Value|
|---|---|
|Description|**Unique identifier for target script associated with agent script step**|
|DisplayName|**Target script**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routeactionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_productivityagentscript|

### <a name="BKMK_msdyn_textinstruction"></a> msdyn_textinstruction

|Property|Value|
|---|---|
|Description|**Instruction for text action type**|
|DisplayName|**Text instructions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_textinstruction`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|2000|

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
|Description|**Status of the Agent script step**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_productivityagentscriptstep_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Agent script step**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_productivityagentscriptstep_statuscode`|

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

- [business_unit_msdyn_productivityagentscriptstep](#BKMK_business_unit_msdyn_productivityagentscriptstep)
- [lk_msdyn_productivityagentscriptstep_createdby](#BKMK_lk_msdyn_productivityagentscriptstep_createdby)
- [lk_msdyn_productivityagentscriptstep_createdonbehalfby](#BKMK_lk_msdyn_productivityagentscriptstep_createdonbehalfby)
- [lk_msdyn_productivityagentscriptstep_modifiedby](#BKMK_lk_msdyn_productivityagentscriptstep_modifiedby)
- [lk_msdyn_productivityagentscriptstep_modifiedonbehalfby](#BKMK_lk_msdyn_productivityagentscriptstep_modifiedonbehalfby)
- [msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_agentscriptid](#BKMK_msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_agentscriptid)
- [msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_routeactionid](#BKMK_msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_routeactionid)
- [msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid](#BKMK_msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid)
- [owner_msdyn_productivityagentscriptstep](#BKMK_owner_msdyn_productivityagentscriptstep)
- [team_msdyn_productivityagentscriptstep](#BKMK_team_msdyn_productivityagentscriptstep)
- [user_msdyn_productivityagentscriptstep](#BKMK_user_msdyn_productivityagentscriptstep)

### <a name="BKMK_business_unit_msdyn_productivityagentscriptstep"></a> business_unit_msdyn_productivityagentscriptstep

One-To-Many Relationship: [businessunit business_unit_msdyn_productivityagentscriptstep](businessunit.md#BKMK_business_unit_msdyn_productivityagentscriptstep)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_productivityagentscriptstep_createdby"></a> lk_msdyn_productivityagentscriptstep_createdby

One-To-Many Relationship: [systemuser lk_msdyn_productivityagentscriptstep_createdby](systemuser.md#BKMK_lk_msdyn_productivityagentscriptstep_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_productivityagentscriptstep_createdonbehalfby"></a> lk_msdyn_productivityagentscriptstep_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_productivityagentscriptstep_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_productivityagentscriptstep_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_productivityagentscriptstep_modifiedby"></a> lk_msdyn_productivityagentscriptstep_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_productivityagentscriptstep_modifiedby](systemuser.md#BKMK_lk_msdyn_productivityagentscriptstep_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_productivityagentscriptstep_modifiedonbehalfby"></a> lk_msdyn_productivityagentscriptstep_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_productivityagentscriptstep_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_productivityagentscriptstep_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_agentscriptid"></a> msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_agentscriptid

One-To-Many Relationship: [msdyn_productivityagentscript msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_agentscriptid](msdyn_productivityagentscript.md#BKMK_msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_agentscriptid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productivityagentscript`|
|ReferencedAttribute|`msdyn_productivityagentscriptid`|
|ReferencingAttribute|`msdyn_agentscriptid`|
|ReferencingEntityNavigationPropertyName|`msdyn_agentscriptid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_routeactionid"></a> msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_routeactionid

One-To-Many Relationship: [msdyn_productivityagentscript msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_routeactionid](msdyn_productivityagentscript.md#BKMK_msdyn_msdyn_prod_agentscript_msdyn_prod_agentscriptstep_routeactionid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productivityagentscript`|
|ReferencedAttribute|`msdyn_productivityagentscriptid`|
|ReferencingAttribute|`msdyn_routeactionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_routeactionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid"></a> msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid

One-To-Many Relationship: [workflow msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid](workflow.md#BKMK_msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid)

|Property|Value|
|---|---|
|ReferencedEntity|`workflow`|
|ReferencedAttribute|`workflowid`|
|ReferencingAttribute|`msdyn_macroactionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_macroactionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_productivityagentscriptstep"></a> owner_msdyn_productivityagentscriptstep

One-To-Many Relationship: [owner owner_msdyn_productivityagentscriptstep](owner.md#BKMK_owner_msdyn_productivityagentscriptstep)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_productivityagentscriptstep"></a> team_msdyn_productivityagentscriptstep

One-To-Many Relationship: [team team_msdyn_productivityagentscriptstep](team.md#BKMK_team_msdyn_productivityagentscriptstep)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_productivityagentscriptstep"></a> user_msdyn_productivityagentscriptstep

One-To-Many Relationship: [systemuser user_msdyn_productivityagentscriptstep](systemuser.md#BKMK_user_msdyn_productivityagentscriptstep)

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

- [msdyn_productivityagentscriptstep_AsyncOperations](#BKMK_msdyn_productivityagentscriptstep_AsyncOperations)
- [msdyn_productivityagentscriptstep_BulkDeleteFailures](#BKMK_msdyn_productivityagentscriptstep_BulkDeleteFailures)
- [msdyn_productivityagentscriptstep_DuplicateBaseRecord](#BKMK_msdyn_productivityagentscriptstep_DuplicateBaseRecord)
- [msdyn_productivityagentscriptstep_DuplicateMatchingRecord](#BKMK_msdyn_productivityagentscriptstep_DuplicateMatchingRecord)
- [msdyn_productivityagentscriptstep_MailboxTrackingFolders](#BKMK_msdyn_productivityagentscriptstep_MailboxTrackingFolders)
- [msdyn_productivityagentscriptstep_PrincipalObjectAttributeAccesses](#BKMK_msdyn_productivityagentscriptstep_PrincipalObjectAttributeAccesses)
- [msdyn_productivityagentscriptstep_ProcessSession](#BKMK_msdyn_productivityagentscriptstep_ProcessSession)
- [msdyn_productivityagentscriptstep_SyncErrors](#BKMK_msdyn_productivityagentscriptstep_SyncErrors)

### <a name="BKMK_msdyn_productivityagentscriptstep_AsyncOperations"></a> msdyn_productivityagentscriptstep_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_productivityagentscriptstep_AsyncOperations](asyncoperation.md#BKMK_msdyn_productivityagentscriptstep_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivityagentscriptstep_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivityagentscriptstep_BulkDeleteFailures"></a> msdyn_productivityagentscriptstep_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_productivityagentscriptstep_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_productivityagentscriptstep_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivityagentscriptstep_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivityagentscriptstep_DuplicateBaseRecord"></a> msdyn_productivityagentscriptstep_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_productivityagentscriptstep_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_productivityagentscriptstep_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivityagentscriptstep_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivityagentscriptstep_DuplicateMatchingRecord"></a> msdyn_productivityagentscriptstep_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_productivityagentscriptstep_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_productivityagentscriptstep_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivityagentscriptstep_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivityagentscriptstep_MailboxTrackingFolders"></a> msdyn_productivityagentscriptstep_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_productivityagentscriptstep_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_productivityagentscriptstep_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivityagentscriptstep_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivityagentscriptstep_PrincipalObjectAttributeAccesses"></a> msdyn_productivityagentscriptstep_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_productivityagentscriptstep_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_productivityagentscriptstep_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivityagentscriptstep_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivityagentscriptstep_ProcessSession"></a> msdyn_productivityagentscriptstep_ProcessSession

Many-To-One Relationship: [processsession msdyn_productivityagentscriptstep_ProcessSession](processsession.md#BKMK_msdyn_productivityagentscriptstep_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivityagentscriptstep_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivityagentscriptstep_SyncErrors"></a> msdyn_productivityagentscriptstep_SyncErrors

Many-To-One Relationship: [syncerror msdyn_productivityagentscriptstep_SyncErrors](syncerror.md#BKMK_msdyn_productivityagentscriptstep_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivityagentscriptstep_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

