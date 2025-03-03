---
title: "Upgrade Version (msdyn_upgradeversion) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Upgrade Version (msdyn_upgradeversion) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Upgrade Version (msdyn_upgradeversion) table/entity reference (Microsoft Dynamics 365)

Information about upgrading from one release to the next release

## Messages

The following table lists the messages for the Upgrade Version (msdyn_upgradeversion) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_upgradeversions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_upgradeversions(*msdyn_upgradeversionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_upgradeversions(*msdyn_upgradeversionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_upgradeversions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_upgradeversions(*msdyn_upgradeversionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_upgradeversions(*msdyn_upgradeversionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_upgradeversions(*msdyn_upgradeversionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Upgrade Version (msdyn_upgradeversion) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Upgrade Version** |
| **DisplayCollectionName** | **Upgrade Versions** |
| **SchemaName** | `msdyn_upgradeversion` |
| **CollectionSchemaName** | `msdyn_upgradeversions` |
| **EntitySetName** | `msdyn_upgradeversions`|
| **LogicalName** | `msdyn_upgradeversion` |
| **LogicalCollectionName** | `msdyn_upgradeversions` |
| **PrimaryIdAttribute** | `msdyn_upgradeversionid` |
| **PrimaryNameAttribute** |`msdyn_summary` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CreatedOn](#BKMK_CreatedOn)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Finished](#BKMK_msdyn_Finished)
- [msdyn_StartingVersion](#BKMK_msdyn_StartingVersion)
- [msdyn_Status](#BKMK_msdyn_Status)
- [msdyn_summary](#BKMK_msdyn_summary)
- [msdyn_TargetVersion](#BKMK_msdyn_TargetVersion)
- [msdyn_UpgradeRun](#BKMK_msdyn_UpgradeRun)
- [msdyn_upgradeversionId](#BKMK_msdyn_upgradeversionId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Started**|
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

### <a name="BKMK_msdyn_Finished"></a> msdyn_Finished

|Property|Value|
|---|---|
|Description|**Date/time when a single-version upgrade finished**|
|DisplayName|**Finished**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_finished`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_StartingVersion"></a> msdyn_StartingVersion

|Property|Value|
|---|---|
|Description|**Version that was installed before a single-version upgrade**|
|DisplayName|**StartingVersion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startingversion`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Status"></a> msdyn_Status

|Property|Value|
|---|---|
|Description|**Status/outcome of a single-version upgrade**|
|DisplayName|**Upgrade Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_upgradestatus`|

#### msdyn_Status Choices/Options

|Value|Label|
|---|---|
|100000000|**Started**|
|100000001|**Success**|
|100000002|**Failure**|

### <a name="BKMK_msdyn_summary"></a> msdyn_summary

|Property|Value|
|---|---|
|Description|**Summary of a single-version upgrade**|
|DisplayName|**Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_summary`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_TargetVersion"></a> msdyn_TargetVersion

|Property|Value|
|---|---|
|Description|**Version that will be achieved by a single-version upgrade**|
|DisplayName|**TargetVersion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetversion`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_UpgradeRun"></a> msdyn_UpgradeRun

|Property|Value|
|---|---|
|Description|**Package deployer run that invoked a single-version upgrade**|
|DisplayName|**UpgradeRun**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_upgraderun`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_upgraderun|

### <a name="BKMK_msdyn_upgradeversionId"></a> msdyn_upgradeversionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**UpgradeVersion**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_upgradeversionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the UpgradeVersion**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_upgradeversion_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the UpgradeVersion**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_upgradeversion_statuscode`|

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
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
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

- [lk_msdyn_upgradeversion_createdby](#BKMK_lk_msdyn_upgradeversion_createdby)
- [lk_msdyn_upgradeversion_createdonbehalfby](#BKMK_lk_msdyn_upgradeversion_createdonbehalfby)
- [lk_msdyn_upgradeversion_modifiedby](#BKMK_lk_msdyn_upgradeversion_modifiedby)
- [lk_msdyn_upgradeversion_modifiedonbehalfby](#BKMK_lk_msdyn_upgradeversion_modifiedonbehalfby)
- [msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun](#BKMK_msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun)
- [organization_msdyn_upgradeversion](#BKMK_organization_msdyn_upgradeversion)

### <a name="BKMK_lk_msdyn_upgradeversion_createdby"></a> lk_msdyn_upgradeversion_createdby

One-To-Many Relationship: [systemuser lk_msdyn_upgradeversion_createdby](systemuser.md#BKMK_lk_msdyn_upgradeversion_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_upgradeversion_createdonbehalfby"></a> lk_msdyn_upgradeversion_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_upgradeversion_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_upgradeversion_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_upgradeversion_modifiedby"></a> lk_msdyn_upgradeversion_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_upgradeversion_modifiedby](systemuser.md#BKMK_lk_msdyn_upgradeversion_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_upgradeversion_modifiedonbehalfby"></a> lk_msdyn_upgradeversion_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_upgradeversion_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_upgradeversion_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun"></a> msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun

One-To-Many Relationship: [msdyn_upgraderun msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun](msdyn_upgraderun.md#BKMK_msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_upgraderun`|
|ReferencedAttribute|`msdyn_upgraderunid`|
|ReferencingAttribute|`msdyn_upgraderun`|
|ReferencingEntityNavigationPropertyName|`msdyn_UpgradeRun`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_organization_msdyn_upgradeversion"></a> organization_msdyn_upgradeversion

One-To-Many Relationship: [organization organization_msdyn_upgradeversion](organization.md#BKMK_organization_msdyn_upgradeversion)

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

- [msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion](#BKMK_msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion)
- [msdyn_upgradeversion_AsyncOperations](#BKMK_msdyn_upgradeversion_AsyncOperations)
- [msdyn_upgradeversion_BulkDeleteFailures](#BKMK_msdyn_upgradeversion_BulkDeleteFailures)
- [msdyn_upgradeversion_MailboxTrackingFolders](#BKMK_msdyn_upgradeversion_MailboxTrackingFolders)
- [msdyn_upgradeversion_PrincipalObjectAttributeAccesses](#BKMK_msdyn_upgradeversion_PrincipalObjectAttributeAccesses)
- [msdyn_upgradeversion_ProcessSession](#BKMK_msdyn_upgradeversion_ProcessSession)
- [msdyn_upgradeversion_SyncErrors](#BKMK_msdyn_upgradeversion_SyncErrors)

### <a name="BKMK_msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion"></a> msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion

Many-To-One Relationship: [msdyn_upgradestep msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion](msdyn_upgradestep.md#BKMK_msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_upgradestep`|
|ReferencingAttribute|`msdyn_upgradeversion`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_upgradeversion_AsyncOperations"></a> msdyn_upgradeversion_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_upgradeversion_AsyncOperations](asyncoperation.md#BKMK_msdyn_upgradeversion_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_upgradeversion_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_upgradeversion_BulkDeleteFailures"></a> msdyn_upgradeversion_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_upgradeversion_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_upgradeversion_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_upgradeversion_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_upgradeversion_MailboxTrackingFolders"></a> msdyn_upgradeversion_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_upgradeversion_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_upgradeversion_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_upgradeversion_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_upgradeversion_PrincipalObjectAttributeAccesses"></a> msdyn_upgradeversion_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_upgradeversion_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_upgradeversion_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_upgradeversion_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_upgradeversion_ProcessSession"></a> msdyn_upgradeversion_ProcessSession

Many-To-One Relationship: [processsession msdyn_upgradeversion_ProcessSession](processsession.md#BKMK_msdyn_upgradeversion_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_upgradeversion_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_upgradeversion_SyncErrors"></a> msdyn_upgradeversion_SyncErrors

Many-To-One Relationship: [syncerror msdyn_upgradeversion_SyncErrors](syncerror.md#BKMK_msdyn_upgradeversion_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_upgradeversion_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

