---
title: "Intent Family Solution Map (msdyn_intentfamilysolutionmap) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Intent Family Solution Map (msdyn_intentfamilysolutionmap) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Intent Family Solution Map (msdyn_intentfamilysolutionmap) table/entity reference (Microsoft Dynamics 365)

Captures Solutions for Intent Families (Line of Business)

## Messages

The following table lists the messages for the Intent Family Solution Map (msdyn_intentfamilysolutionmap) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_intentfamilysolutionmaps(*msdyn_intentfamilysolutionmapid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_intentfamilysolutionmaps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_intentfamilysolutionmaps(*msdyn_intentfamilysolutionmapid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_intentfamilysolutionmaps(*msdyn_intentfamilysolutionmapid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_intentfamilysolutionmaps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_intentfamilysolutionmaps(*msdyn_intentfamilysolutionmapid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_intentfamilysolutionmaps(*msdyn_intentfamilysolutionmapid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_intentfamilysolutionmaps(*msdyn_intentfamilysolutionmapid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Intent Family Solution Map (msdyn_intentfamilysolutionmap) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Intent Family Solution Map** |
| **DisplayCollectionName** | **Intent Family Solution Maps** |
| **SchemaName** | `msdyn_intentfamilysolutionmap` |
| **CollectionSchemaName** | `msdyn_intentfamilysolutionmaps` |
| **EntitySetName** | `msdyn_intentfamilysolutionmaps`|
| **LogicalName** | `msdyn_intentfamilysolutionmap` |
| **LogicalCollectionName** | `msdyn_intentfamilysolutionmaps` |
| **PrimaryIdAttribute** | `msdyn_intentfamilysolutionmapid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_agentgroupid](#BKMK_msdyn_agentgroupid)
- [msdyn_intentfamilyid](#BKMK_msdyn_intentfamilyid)
- [msdyn_intentfamilysolutionmapId](#BKMK_msdyn_intentfamilysolutionmapId)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_queueid](#BKMK_msdyn_queueid)
- [msdyn_reviewstate](#BKMK_msdyn_reviewstate)
- [msdyn_rootknowledgearticleid](#BKMK_msdyn_rootknowledgearticleid)
- [msdyn_solutionmapid](#BKMK_msdyn_solutionmapid)
- [msdyn_solutionmetadata](#BKMK_msdyn_solutionmetadata)
- [msdyn_solutiontype](#BKMK_msdyn_solutiontype)
- [msdyn_source](#BKMK_msdyn_source)
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

### <a name="BKMK_msdyn_agentgroupid"></a> msdyn_agentgroupid

|Property|Value|
|---|---|
|Description|**Lookup to Customer Service Representative Group**|
|DisplayName|**agentgroupid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentgroupid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agentgroup|

### <a name="BKMK_msdyn_intentfamilyid"></a> msdyn_intentfamilyid

|Property|Value|
|---|---|
|Description|**Lookup to Intent Family**|
|DisplayName|**intentfamilyid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentfamilyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_intentfamily|

### <a name="BKMK_msdyn_intentfamilysolutionmapId"></a> msdyn_intentfamilysolutionmapId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Intent Family Solution Map**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentfamilysolutionmapid`|
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
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_queueid"></a> msdyn_queueid

|Property|Value|
|---|---|
|Description|**Lookup to Queue**|
|DisplayName|**queueid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queue|

### <a name="BKMK_msdyn_reviewstate"></a> msdyn_reviewstate

|Property|Value|
|---|---|
|Description|**Review State for Intent Family Solution Map**|
|DisplayName|**reviewstate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reviewstate`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_reviewstate`|

#### msdyn_reviewstate Choices/Options

|Value|Label|
|---|---|
|192350000|**Pending**|
|192350001|**Approved**|
|192350002|**Discarded**|

### <a name="BKMK_msdyn_rootknowledgearticleid"></a> msdyn_rootknowledgearticleid

|Property|Value|
|---|---|
|Description|**Lookup to Knowledge Article**|
|DisplayName|**Root Knowledge Article Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rootknowledgearticleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|knowledgearticle|

### <a name="BKMK_msdyn_solutionmapid"></a> msdyn_solutionmapid

|Property|Value|
|---|---|
|Description|**Lookup to Organization Solution Map**|
|DisplayName|**msdyn\_solutionmapid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_solutionmapid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_organizationsolutionmap|

### <a name="BKMK_msdyn_solutionmetadata"></a> msdyn_solutionmetadata

|Property|Value|
|---|---|
|Description||
|DisplayName|**msdyn\_solutionmetadata**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_solutionmetadata`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_solutiontype"></a> msdyn_solutiontype

|Property|Value|
|---|---|
|Description|**Solution Type of the Solution (AIAction / CustomAIAgent / Knowledge Article / Queue / Agent Group)**|
|DisplayName|**solutiontype**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_solutiontype`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_source"></a> msdyn_source

|Property|Value|
|---|---|
|Description|**Source of the Intent Family Solution Map**|
|DisplayName|**source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_source`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_intent_source`|

#### msdyn_source Choices/Options

|Value|Label|
|---|---|
|192350000|**Data Execution Run**|
|192350001|**Simulation**|
|192350002|**Manually Edited**|

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
|Description|**Status of the Intent Family Solution Map**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentfamilysolutionmap_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Intent Family Solution Map**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentfamilysolutionmap_statuscode`|

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
|RequiredLevel|SystemRequired|
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

- [business_unit_msdyn_intentfamilysolutionmap](#BKMK_business_unit_msdyn_intentfamilysolutionmap)
- [lk_msdyn_intentfamilysolutionmap_createdby](#BKMK_lk_msdyn_intentfamilysolutionmap_createdby)
- [lk_msdyn_intentfamilysolutionmap_createdonbehalfby](#BKMK_lk_msdyn_intentfamilysolutionmap_createdonbehalfby)
- [lk_msdyn_intentfamilysolutionmap_modifiedby](#BKMK_lk_msdyn_intentfamilysolutionmap_modifiedby)
- [lk_msdyn_intentfamilysolutionmap_modifiedonbehalfby](#BKMK_lk_msdyn_intentfamilysolutionmap_modifiedonbehalfby)
- [msdyn_intentfamilysolutionmap_agentgroupid_msdyn_agentgroup](#BKMK_msdyn_intentfamilysolutionmap_agentgroupid_msdyn_agentgroup)
- [msdyn_intentfamilysolutionmap_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_intentfamilysolutionmap_intentfamilyid_msdyn_intentfamily)
- [msdyn_intentfamilysolutionmap_knowledgearticleid_knowledgearticle](#BKMK_msdyn_intentfamilysolutionmap_knowledgearticleid_knowledgearticle)
- [msdyn_intentfamilysolutionmap_queueid_queue](#BKMK_msdyn_intentfamilysolutionmap_queueid_queue)
- [msdyn_intentfamilysolutionmap_solutionmapid_msdyn_organizationsolutionmap](#BKMK_msdyn_intentfamilysolutionmap_solutionmapid_msdyn_organizationsolutionmap)
- [owner_msdyn_intentfamilysolutionmap](#BKMK_owner_msdyn_intentfamilysolutionmap)
- [team_msdyn_intentfamilysolutionmap](#BKMK_team_msdyn_intentfamilysolutionmap)
- [user_msdyn_intentfamilysolutionmap](#BKMK_user_msdyn_intentfamilysolutionmap)

### <a name="BKMK_business_unit_msdyn_intentfamilysolutionmap"></a> business_unit_msdyn_intentfamilysolutionmap

One-To-Many Relationship: [businessunit business_unit_msdyn_intentfamilysolutionmap](businessunit.md#BKMK_business_unit_msdyn_intentfamilysolutionmap)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamilysolutionmap_createdby"></a> lk_msdyn_intentfamilysolutionmap_createdby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamilysolutionmap_createdby](systemuser.md#BKMK_lk_msdyn_intentfamilysolutionmap_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamilysolutionmap_createdonbehalfby"></a> lk_msdyn_intentfamilysolutionmap_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamilysolutionmap_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_intentfamilysolutionmap_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamilysolutionmap_modifiedby"></a> lk_msdyn_intentfamilysolutionmap_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamilysolutionmap_modifiedby](systemuser.md#BKMK_lk_msdyn_intentfamilysolutionmap_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamilysolutionmap_modifiedonbehalfby"></a> lk_msdyn_intentfamilysolutionmap_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamilysolutionmap_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_intentfamilysolutionmap_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_agentgroupid_msdyn_agentgroup"></a> msdyn_intentfamilysolutionmap_agentgroupid_msdyn_agentgroup

One-To-Many Relationship: [msdyn_agentgroup msdyn_intentfamilysolutionmap_agentgroupid_msdyn_agentgroup](msdyn_agentgroup.md#BKMK_msdyn_intentfamilysolutionmap_agentgroupid_msdyn_agentgroup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agentgroup`|
|ReferencedAttribute|`msdyn_agentgroupid`|
|ReferencingAttribute|`msdyn_agentgroupid`|
|ReferencingEntityNavigationPropertyName|`msdyn_agentgroupid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_intentfamilyid_msdyn_intentfamily"></a> msdyn_intentfamilysolutionmap_intentfamilyid_msdyn_intentfamily

One-To-Many Relationship: [msdyn_intentfamily msdyn_intentfamilysolutionmap_intentfamilyid_msdyn_intentfamily](msdyn_intentfamily.md#BKMK_msdyn_intentfamilysolutionmap_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intentfamily`|
|ReferencedAttribute|`msdyn_intentfamilyid`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencingEntityNavigationPropertyName|`msdyn_intentfamilyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_knowledgearticleid_knowledgearticle"></a> msdyn_intentfamilysolutionmap_knowledgearticleid_knowledgearticle

One-To-Many Relationship: [knowledgearticle msdyn_intentfamilysolutionmap_knowledgearticleid_knowledgearticle](knowledgearticle.md#BKMK_msdyn_intentfamilysolutionmap_knowledgearticleid_knowledgearticle)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgearticle`|
|ReferencedAttribute|`knowledgearticleid`|
|ReferencingAttribute|`msdyn_rootknowledgearticleid`|
|ReferencingEntityNavigationPropertyName|`msdyn_rootknowledgearticleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_queueid_queue"></a> msdyn_intentfamilysolutionmap_queueid_queue

One-To-Many Relationship: [queue msdyn_intentfamilysolutionmap_queueid_queue](queue.md#BKMK_msdyn_intentfamilysolutionmap_queueid_queue)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_queueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_queueid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_solutionmapid_msdyn_organizationsolutionmap"></a> msdyn_intentfamilysolutionmap_solutionmapid_msdyn_organizationsolutionmap

One-To-Many Relationship: [msdyn_organizationsolutionmap msdyn_intentfamilysolutionmap_solutionmapid_msdyn_organizationsolutionmap](msdyn_organizationsolutionmap.md#BKMK_msdyn_intentfamilysolutionmap_solutionmapid_msdyn_organizationsolutionmap)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationsolutionmap`|
|ReferencedAttribute|`msdyn_organizationsolutionmapid`|
|ReferencingAttribute|`msdyn_solutionmapid`|
|ReferencingEntityNavigationPropertyName|`msdyn_solutionmapid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_intentfamilysolutionmap"></a> owner_msdyn_intentfamilysolutionmap

One-To-Many Relationship: [owner owner_msdyn_intentfamilysolutionmap](owner.md#BKMK_owner_msdyn_intentfamilysolutionmap)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_intentfamilysolutionmap"></a> team_msdyn_intentfamilysolutionmap

One-To-Many Relationship: [team team_msdyn_intentfamilysolutionmap](team.md#BKMK_team_msdyn_intentfamilysolutionmap)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_intentfamilysolutionmap"></a> user_msdyn_intentfamilysolutionmap

One-To-Many Relationship: [systemuser user_msdyn_intentfamilysolutionmap](systemuser.md#BKMK_user_msdyn_intentfamilysolutionmap)

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

- [msdyn_intentfamilysolutionmap_AsyncOperations](#BKMK_msdyn_intentfamilysolutionmap_AsyncOperations)
- [msdyn_intentfamilysolutionmap_BulkDeleteFailures](#BKMK_msdyn_intentfamilysolutionmap_BulkDeleteFailures)
- [msdyn_intentfamilysolutionmap_DuplicateBaseRecord](#BKMK_msdyn_intentfamilysolutionmap_DuplicateBaseRecord)
- [msdyn_intentfamilysolutionmap_DuplicateMatchingRecord](#BKMK_msdyn_intentfamilysolutionmap_DuplicateMatchingRecord)
- [msdyn_intentfamilysolutionmap_MailboxTrackingFolders](#BKMK_msdyn_intentfamilysolutionmap_MailboxTrackingFolders)
- [msdyn_intentfamilysolutionmap_PrincipalObjectAttributeAccesses](#BKMK_msdyn_intentfamilysolutionmap_PrincipalObjectAttributeAccesses)
- [msdyn_intentfamilysolutionmap_ProcessSession](#BKMK_msdyn_intentfamilysolutionmap_ProcessSession)
- [msdyn_intentfamilysolutionmap_SyncErrors](#BKMK_msdyn_intentfamilysolutionmap_SyncErrors)

### <a name="BKMK_msdyn_intentfamilysolutionmap_AsyncOperations"></a> msdyn_intentfamilysolutionmap_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_intentfamilysolutionmap_AsyncOperations](asyncoperation.md#BKMK_msdyn_intentfamilysolutionmap_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamilysolutionmap_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_BulkDeleteFailures"></a> msdyn_intentfamilysolutionmap_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_intentfamilysolutionmap_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_intentfamilysolutionmap_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamilysolutionmap_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_DuplicateBaseRecord"></a> msdyn_intentfamilysolutionmap_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_intentfamilysolutionmap_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_intentfamilysolutionmap_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamilysolutionmap_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_DuplicateMatchingRecord"></a> msdyn_intentfamilysolutionmap_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_intentfamilysolutionmap_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_intentfamilysolutionmap_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamilysolutionmap_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_MailboxTrackingFolders"></a> msdyn_intentfamilysolutionmap_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_intentfamilysolutionmap_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_intentfamilysolutionmap_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamilysolutionmap_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_PrincipalObjectAttributeAccesses"></a> msdyn_intentfamilysolutionmap_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_intentfamilysolutionmap_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_intentfamilysolutionmap_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamilysolutionmap_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_ProcessSession"></a> msdyn_intentfamilysolutionmap_ProcessSession

Many-To-One Relationship: [processsession msdyn_intentfamilysolutionmap_ProcessSession](processsession.md#BKMK_msdyn_intentfamilysolutionmap_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamilysolutionmap_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamilysolutionmap_SyncErrors"></a> msdyn_intentfamilysolutionmap_SyncErrors

Many-To-One Relationship: [syncerror msdyn_intentfamilysolutionmap_SyncErrors](syncerror.md#BKMK_msdyn_intentfamilysolutionmap_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamilysolutionmap_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

