---
title: "Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table/entity reference (Microsoft Dynamics 365)

Mapping between CJO Marketing Triggers and Sdk Message Processing Steps

## Messages

The following table lists the messages for the Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdynmkt_eventmetadata_sdkmessageprocessingsteps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_eventmetadata_sdkmessageprocessingsteps(*msdynmkt_eventmetadata_sdkmessageprocessingstepid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_eventmetadata_sdkmessageprocessingsteps(*msdynmkt_eventmetadata_sdkmessageprocessingstepid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_eventmetadata_sdkmessageprocessingsteps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_eventmetadata_sdkmessageprocessingsteps(*msdynmkt_eventmetadata_sdkmessageprocessingstepid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_eventmetadata_sdkmessageprocessingsteps(*msdynmkt_eventmetadata_sdkmessageprocessingstepid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_eventmetadata_sdkmessageprocessingsteps(*msdynmkt_eventmetadata_sdkmessageprocessingstepid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Triggers To Sdk Message Processing Steps** |
| **DisplayCollectionName** | **Triggers To Sdk Message Processing Steps** |
| **SchemaName** | `msdynmkt_eventmetadata_sdkmessageprocessingstep` |
| **CollectionSchemaName** | `msdynmkt_eventmetadata_sdkmessageprocessingsteps` |
| **EntitySetName** | `msdynmkt_eventmetadata_sdkmessageprocessingsteps`|
| **LogicalName** | `msdynmkt_eventmetadata_sdkmessageprocessingstep` |
| **LogicalCollectionName** | `msdynmkt_eventmetadata_sdkmessageprocessingsteps` |
| **PrimaryIdAttribute** | `msdynmkt_eventmetadata_sdkmessageprocessingstepid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdynmkt_eventmetadata_sdkmessageprocessingstepId](#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstepId)
- [msdynmkt_eventmetadataId](#BKMK_msdynmkt_eventmetadataId)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_sdkmessageprocessingstepId](#BKMK_msdynmkt_sdkmessageprocessingstepId)
- [msdynmkt_uniquename](#BKMK_msdynmkt_uniquename)
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

### <a name="BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstepId"></a> msdynmkt_eventmetadata_sdkmessageprocessingstepId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Triggers To Sdk Message Processing Steps**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_eventmetadata_sdkmessageprocessingstepid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_eventmetadataId"></a> msdynmkt_eventmetadataId

|Property|Value|
|---|---|
|Description|**Unique identifier for Triggers associated with Triggers To Sdk Message Processing Steps.**|
|DisplayName|**Trigger**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_eventmetadataid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|msdynmkt_eventmetadata|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_sdkmessageprocessingstepId"></a> msdynmkt_sdkmessageprocessingstepId

|Property|Value|
|---|---|
|Description|**Unique identifier for Sdk Message Processing Step associated with Triggers To Sdk Message Processing Steps.**|
|DisplayName|**Sdk Message Processing Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sdkmessageprocessingstepid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|sdkmessageprocessingstep|

### <a name="BKMK_msdynmkt_uniquename"></a> msdynmkt_uniquename

|Property|Value|
|---|---|
|Description|**Unique Name for the entity.**|
|DisplayName|**Unique Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uniquename`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|134|

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
|Description|**Status of the Triggers To Sdk Message Processing Steps**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Triggers To Sdk Message Processing Steps**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_statuscode`|

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

- [lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdby](#BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdby)
- [lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdonbehalfby](#BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdonbehalfby)
- [lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedby](#BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedby)
- [lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedonbehalfby](#BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedonbehalfby)
- [msdynmkt_eventmetadata_eventmetadata_sdkmessagepro](#BKMK_msdynmkt_eventmetadata_eventmetadata_sdkmessagepro)
- [msdynmkt_sdkmessageprocessingstep_eventmetadata_sd](#BKMK_msdynmkt_sdkmessageprocessingstep_eventmetadata_sd)
- [organization_msdynmkt_eventmetadata_sdkmessageprocessingstep](#BKMK_organization_msdynmkt_eventmetadata_sdkmessageprocessingstep)

### <a name="BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdby"></a> lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdby](systemuser.md#BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdonbehalfby"></a> lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedby"></a> lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedby](systemuser.md#BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedonbehalfby"></a> lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_eventmetadata_sdkmessageprocessingstep_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_eventmetadata_eventmetadata_sdkmessagepro"></a> msdynmkt_eventmetadata_eventmetadata_sdkmessagepro

One-To-Many Relationship: [msdynmkt_eventmetadata msdynmkt_eventmetadata_eventmetadata_sdkmessagepro](msdynmkt_eventmetadata.md#BKMK_msdynmkt_eventmetadata_eventmetadata_sdkmessagepro)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_eventmetadata`|
|ReferencedAttribute|`msdynmkt_eventmetadataid`|
|ReferencingAttribute|`msdynmkt_eventmetadataid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_eventmetadataId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_sdkmessageprocessingstep_eventmetadata_sd"></a> msdynmkt_sdkmessageprocessingstep_eventmetadata_sd

One-To-Many Relationship: [sdkmessageprocessingstep msdynmkt_sdkmessageprocessingstep_eventmetadata_sd](sdkmessageprocessingstep.md#BKMK_msdynmkt_sdkmessageprocessingstep_eventmetadata_sd)

|Property|Value|
|---|---|
|ReferencedEntity|`sdkmessageprocessingstep`|
|ReferencedAttribute|`sdkmessageprocessingstepid`|
|ReferencingAttribute|`msdynmkt_sdkmessageprocessingstepid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_sdkmessageprocessingstepId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdynmkt_eventmetadata_sdkmessageprocessingstep"></a> organization_msdynmkt_eventmetadata_sdkmessageprocessingstep

One-To-Many Relationship: [organization organization_msdynmkt_eventmetadata_sdkmessageprocessingstep](organization.md#BKMK_organization_msdynmkt_eventmetadata_sdkmessageprocessingstep)

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

- [msdynmkt_eventmetadata_sdkmessageprocessingstep_AsyncOperations](#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_AsyncOperations)
- [msdynmkt_eventmetadata_sdkmessageprocessingstep_BulkDeleteFailures](#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_BulkDeleteFailures)
- [msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateBaseRecord](#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateBaseRecord)
- [msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateMatchingRecord](#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateMatchingRecord)
- [msdynmkt_eventmetadata_sdkmessageprocessingstep_MailboxTrackingFolders](#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_MailboxTrackingFolders)
- [msdynmkt_eventmetadata_sdkmessageprocessingstep_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_PrincipalObjectAttributeAccesses)
- [msdynmkt_eventmetadata_sdkmessageprocessingstep_ProcessSession](#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_ProcessSession)
- [msdynmkt_eventmetadata_sdkmessageprocessingstep_SyncErrors](#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_SyncErrors)

### <a name="BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_AsyncOperations"></a> msdynmkt_eventmetadata_sdkmessageprocessingstep_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_eventmetadata_sdkmessageprocessingstep_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_BulkDeleteFailures"></a> msdynmkt_eventmetadata_sdkmessageprocessingstep_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_eventmetadata_sdkmessageprocessingstep_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateBaseRecord"></a> msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateMatchingRecord"></a> msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_MailboxTrackingFolders"></a> msdynmkt_eventmetadata_sdkmessageprocessingstep_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_eventmetadata_sdkmessageprocessingstep_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_PrincipalObjectAttributeAccesses"></a> msdynmkt_eventmetadata_sdkmessageprocessingstep_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_eventmetadata_sdkmessageprocessingstep_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_ProcessSession"></a> msdynmkt_eventmetadata_sdkmessageprocessingstep_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_eventmetadata_sdkmessageprocessingstep_ProcessSession](processsession.md#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_SyncErrors"></a> msdynmkt_eventmetadata_sdkmessageprocessingstep_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_eventmetadata_sdkmessageprocessingstep_SyncErrors](syncerror.md#BKMK_msdynmkt_eventmetadata_sdkmessageprocessingstep_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_sdkmessageprocessingstep_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

