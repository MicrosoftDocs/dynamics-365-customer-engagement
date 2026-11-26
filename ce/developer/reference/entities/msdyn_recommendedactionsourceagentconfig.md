---
title: "msdyn_recommendedactionsourceagentconfig table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdyn_recommendedactionsourceagentconfig table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# msdyn_recommendedactionsourceagentconfig table/entity reference (Microsoft Dynamics 365)

This table contains records of msdyn_recommendedactionsourceagentconfig details

## Messages

The following table lists the messages for the msdyn_recommendedactionsourceagentconfig table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_recommendedactionsourceagentconfigs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_recommendedactionsourceagentconfigs(*msdyn_recommendedactionsourceagentconfigid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_recommendedactionsourceagentconfigs(*msdyn_recommendedactionsourceagentconfigid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_recommendedactionsourceagentconfigs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_recommendedactionsourceagentconfigs(*msdyn_recommendedactionsourceagentconfigid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_recommendedactionsourceagentconfigs(*msdyn_recommendedactionsourceagentconfigid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_recommendedactionsourceagentconfigs(*msdyn_recommendedactionsourceagentconfigid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdyn_recommendedactionsourceagentconfig table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdyn_recommendedactionsourceagentconfig** |
| **DisplayCollectionName** | **msdyn_recommendedactionsourceagentconfigs** |
| **SchemaName** | `msdyn_recommendedactionsourceagentconfig` |
| **CollectionSchemaName** | `msdyn_recommendedactionsourceagentconfigs` |
| **EntitySetName** | `msdyn_recommendedactionsourceagentconfigs`|
| **LogicalName** | `msdyn_recommendedactionsourceagentconfig` |
| **LogicalCollectionName** | `msdyn_recommendedactionsourceagentconfigs` |
| **PrimaryIdAttribute** | `msdyn_recommendedactionsourceagentconfigid` |
| **PrimaryNameAttribute** |`msdyn_agentname` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_actioningestionmode](#BKMK_msdyn_actioningestionmode)
- [msdyn_agentimpactmapping](#BKMK_msdyn_agentimpactmapping)
- [msdyn_agentname](#BKMK_msdyn_agentname)
- [msdyn_custominstruction](#BKMK_msdyn_custominstruction)
- [msdyn_internalprioritizationinstruction](#BKMK_msdyn_internalprioritizationinstruction)
- [msdyn_isrecommendedactionagentenabled](#BKMK_msdyn_isrecommendedactionagentenabled)
- [msdyn_pullsourceapiconfig](#BKMK_msdyn_pullsourceapiconfig)
- [msdyn_recommendedactionsourceagentconfigId](#BKMK_msdyn_recommendedactionsourceagentconfigId)
- [msdyn_salesagentprofileid](#BKMK_msdyn_salesagentprofileid)
- [msdyn_sourceagentuniqueid](#BKMK_msdyn_sourceagentuniqueid)
- [msdyn_sourcedescription](#BKMK_msdyn_sourcedescription)
- [msdyn_syncactionexecutionstateapiconfig](#BKMK_msdyn_syncactionexecutionstateapiconfig)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_actioningestionmode"></a> msdyn_actioningestionmode

|Property|Value|
|---|---|
|Description|**Determines whether actions are pushed by the source agent or pulled by the recommended action agent.**|
|DisplayName|**Action Ingestion Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actioningestionmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_recommendedactionsourceagentconfig_msdyn_actioningestionmode`|

#### msdyn_actioningestionmode Choices/Options

|Value|Label|
|---|---|
|1|**Push**|
|2|**Pull**|

### <a name="BKMK_msdyn_agentimpactmapping"></a> msdyn_agentimpactmapping

|Property|Value|
|---|---|
|Description|**agent impact mapping to prioritization principles**|
|DisplayName|**msdyn\_agentimpactmapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentimpactmapping`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_agentname"></a> msdyn_agentname

|Property|Value|
|---|---|
|Description|**SourceAgent name**|
|DisplayName|**SourceAgent name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|850|

### <a name="BKMK_msdyn_custominstruction"></a> msdyn_custominstruction

|Property|Value|
|---|---|
|Description|**custom instructions stored as a JSON object specific to the source agent**|
|DisplayName|**msdyn\_custominstruction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_custominstruction`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_internalprioritizationinstruction"></a> msdyn_internalprioritizationinstruction

|Property|Value|
|---|---|
|Description|**prioritization instructions specific to agent's data**|
|DisplayName|**msdyn\_internalprioritizationinstruction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalprioritizationinstruction`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_isrecommendedactionagentenabled"></a> msdyn_isrecommendedactionagentenabled

|Property|Value|
|---|---|
|Description|**Indicates whether the recommended actions agent is enabled for this source agent config**|
|DisplayName|**Is Recommended Actions Agent Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isrecommendedactionagentenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_recommendedactionsourceagentconfig_msdyn_isrecommendedactionagentenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_pullsourceapiconfig"></a> msdyn_pullsourceapiconfig

|Property|Value|
|---|---|
|Description|**JSON configuration containing API names and watermarkEntityNames for pull-mode action ingestion.**|
|DisplayName|**Pull Source API Config**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pullsourceapiconfig`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfigId"></a> msdyn_recommendedactionsourceagentconfigId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**msdyn\_recommendedactionsourceagentconfig**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_recommendedactionsourceagentconfigid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_salesagentprofileid"></a> msdyn_salesagentprofileid

|Property|Value|
|---|---|
|Description|**Lookup to the sales agent profile associated with this source agent config**|
|DisplayName|**Sales Agent Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentprofileid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_salesagentprofile|

### <a name="BKMK_msdyn_sourceagentuniqueid"></a> msdyn_sourceagentuniqueid

|Property|Value|
|---|---|
|Description|**unique id of the agent to identify the action source**|
|DisplayName|**msdyn\_sourceagentuniqueid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceagentuniqueid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_sourcedescription"></a> msdyn_sourcedescription

|Property|Value|
|---|---|
|Description|**Description of the custom source agent**|
|DisplayName|**Source Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourcedescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_syncactionexecutionstateapiconfig"></a> msdyn_syncactionexecutionstateapiconfig

|Property|Value|
|---|---|
|Description|**json config for custom apis that sync action execution state to upstream agents**|
|DisplayName|**msdyn\_syncactionexecutionstateapiconfig**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_syncactionexecutionstateapiconfig`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the msdyn\_recommendedactionsourceagentconfig**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_recommendedactionsourceagentconfig_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the msdyn\_recommendedactionsourceagentconfig**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_recommendedactionsourceagentconfig_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [lk_msdyn_recommendedactionsourceagentconfig_createdby](#BKMK_lk_msdyn_recommendedactionsourceagentconfig_createdby)
- [lk_msdyn_recommendedactionsourceagentconfig_createdonbehalfby](#BKMK_lk_msdyn_recommendedactionsourceagentconfig_createdonbehalfby)
- [lk_msdyn_recommendedactionsourceagentconfig_modifiedby](#BKMK_lk_msdyn_recommendedactionsourceagentconfig_modifiedby)
- [lk_msdyn_recommendedactionsourceagentconfig_modifiedonbehalfby](#BKMK_lk_msdyn_recommendedactionsourceagentconfig_modifiedonbehalfby)
- [msdyn_recommendedactionsourceagentconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile](#BKMK_msdyn_recommendedactionsourceagentconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile)
- [organization_msdyn_recommendedactionsourceagentconfig](#BKMK_organization_msdyn_recommendedactionsourceagentconfig)

### <a name="BKMK_lk_msdyn_recommendedactionsourceagentconfig_createdby"></a> lk_msdyn_recommendedactionsourceagentconfig_createdby

One-To-Many Relationship: [systemuser lk_msdyn_recommendedactionsourceagentconfig_createdby](systemuser.md#BKMK_lk_msdyn_recommendedactionsourceagentconfig_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_recommendedactionsourceagentconfig_createdonbehalfby"></a> lk_msdyn_recommendedactionsourceagentconfig_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_recommendedactionsourceagentconfig_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_recommendedactionsourceagentconfig_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_recommendedactionsourceagentconfig_modifiedby"></a> lk_msdyn_recommendedactionsourceagentconfig_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_recommendedactionsourceagentconfig_modifiedby](systemuser.md#BKMK_lk_msdyn_recommendedactionsourceagentconfig_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_recommendedactionsourceagentconfig_modifiedonbehalfby"></a> lk_msdyn_recommendedactionsourceagentconfig_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_recommendedactionsourceagentconfig_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_recommendedactionsourceagentconfig_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile"></a> msdyn_recommendedactionsourceagentconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile

One-To-Many Relationship: [msdyn_salesagentprofile msdyn_recommendedactionsourceagentconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile](msdyn_salesagentprofile.md#BKMK_msdyn_recommendedactionsourceagentconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salesagentprofile`|
|ReferencedAttribute|`msdyn_salesagentprofileid`|
|ReferencingAttribute|`msdyn_salesagentprofileid`|
|ReferencingEntityNavigationPropertyName|`msdyn_salesagentprofileid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_recommendedactionsourceagentconfig"></a> organization_msdyn_recommendedactionsourceagentconfig

One-To-Many Relationship: [organization organization_msdyn_recommendedactionsourceagentconfig](organization.md#BKMK_organization_msdyn_recommendedactionsourceagentconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig](#BKMK_msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig)
- [msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig](#BKMK_msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig)
- [msdyn_recommendedactionpullwatermark_msdyn_recommendedactionsourceagentconfig](#BKMK_msdyn_recommendedactionpullwatermark_msdyn_recommendedactionsourceagentconfig)
- [msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig](#BKMK_msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig)
- [msdyn_recommendedactionsourceagentconfig_AsyncOperations](#BKMK_msdyn_recommendedactionsourceagentconfig_AsyncOperations)
- [msdyn_recommendedactionsourceagentconfig_BulkDeleteFailures](#BKMK_msdyn_recommendedactionsourceagentconfig_BulkDeleteFailures)
- [msdyn_recommendedactionsourceagentconfig_DuplicateBaseRecord](#BKMK_msdyn_recommendedactionsourceagentconfig_DuplicateBaseRecord)
- [msdyn_recommendedactionsourceagentconfig_DuplicateMatchingRecord](#BKMK_msdyn_recommendedactionsourceagentconfig_DuplicateMatchingRecord)
- [msdyn_recommendedactionsourceagentconfig_MailboxTrackingFolders](#BKMK_msdyn_recommendedactionsourceagentconfig_MailboxTrackingFolders)
- [msdyn_recommendedactionsourceagentconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_recommendedactionsourceagentconfig_PrincipalObjectAttributeAccesses)
- [msdyn_recommendedactionsourceagentconfig_ProcessSession](#BKMK_msdyn_recommendedactionsourceagentconfig_ProcessSession)
- [msdyn_recommendedactionsourceagentconfig_SyncErrors](#BKMK_msdyn_recommendedactionsourceagentconfig_SyncErrors)

### <a name="BKMK_msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig"></a> msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig

Many-To-One Relationship: [msdyn_prioritizedactioncatalogue msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig](msdyn_prioritizedactioncatalogue.md#BKMK_msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_prioritizedactioncatalogue`|
|ReferencingAttribute|`msdyn_sourceagentconfig`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig"></a> msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig

Many-To-One Relationship: [msdyn_rawactioncatalogue msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig](msdyn_rawactioncatalogue.md#BKMK_msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rawactioncatalogue`|
|ReferencingAttribute|`msdyn_sourceagentconfig`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionpullwatermark_msdyn_recommendedactionsourceagentconfig"></a> msdyn_recommendedactionpullwatermark_msdyn_recommendedactionsourceagentconfig

Many-To-One Relationship: [msdyn_recommendedactionpullwatermark msdyn_recommendedactionpullwatermark_msdyn_recommendedactionsourceagentconfig](msdyn_recommendedactionpullwatermark.md#BKMK_msdyn_recommendedactionpullwatermark_msdyn_recommendedactionsourceagentconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recommendedactionpullwatermark`|
|ReferencingAttribute|`msdyn_sourceagentconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionpullwatermark_msdyn_recommendedactionsourceagentconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig"></a> msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig

Many-To-One Relationship: [msdyn_recommendedactionrundetails msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig](msdyn_recommendedactionrundetails.md#BKMK_msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recommendedactionrundetails`|
|ReferencingAttribute|`msdyn_sourceagentconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfig_AsyncOperations"></a> msdyn_recommendedactionsourceagentconfig_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_recommendedactionsourceagentconfig_AsyncOperations](asyncoperation.md#BKMK_msdyn_recommendedactionsourceagentconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionsourceagentconfig_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfig_BulkDeleteFailures"></a> msdyn_recommendedactionsourceagentconfig_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_recommendedactionsourceagentconfig_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_recommendedactionsourceagentconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionsourceagentconfig_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfig_DuplicateBaseRecord"></a> msdyn_recommendedactionsourceagentconfig_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_recommendedactionsourceagentconfig_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_recommendedactionsourceagentconfig_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionsourceagentconfig_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfig_DuplicateMatchingRecord"></a> msdyn_recommendedactionsourceagentconfig_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_recommendedactionsourceagentconfig_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_recommendedactionsourceagentconfig_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionsourceagentconfig_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfig_MailboxTrackingFolders"></a> msdyn_recommendedactionsourceagentconfig_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_recommendedactionsourceagentconfig_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_recommendedactionsourceagentconfig_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionsourceagentconfig_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfig_PrincipalObjectAttributeAccesses"></a> msdyn_recommendedactionsourceagentconfig_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_recommendedactionsourceagentconfig_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_recommendedactionsourceagentconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionsourceagentconfig_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfig_ProcessSession"></a> msdyn_recommendedactionsourceagentconfig_ProcessSession

Many-To-One Relationship: [processsession msdyn_recommendedactionsourceagentconfig_ProcessSession](processsession.md#BKMK_msdyn_recommendedactionsourceagentconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionsourceagentconfig_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionsourceagentconfig_SyncErrors"></a> msdyn_recommendedactionsourceagentconfig_SyncErrors

Many-To-One Relationship: [syncerror msdyn_recommendedactionsourceagentconfig_SyncErrors](syncerror.md#BKMK_msdyn_recommendedactionsourceagentconfig_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionsourceagentconfig_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

