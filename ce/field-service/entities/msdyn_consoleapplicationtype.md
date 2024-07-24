---
title: "Application Type (Deprecated) (msdyn_consoleapplicationtype) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Application Type (Deprecated) (msdyn_consoleapplicationtype) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Application Type (Deprecated) (msdyn_consoleapplicationtype) table/entity reference

Define a UCI pagetype. For each pagetype, define the parameters that need to be a part of the template for this application type

## Messages

The following table lists the messages for the Application Type (Deprecated) (msdyn_consoleapplicationtype) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_consoleapplicationtypes<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_consoleapplicationtypes(*msdyn_consoleapplicationtypeid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_consoleapplicationtypes(*msdyn_consoleapplicationtypeid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_consoleapplicationtypes<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyn_consoleapplicationtypes(*msdyn_consoleapplicationtypeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_consoleapplicationtypes(*msdyn_consoleapplicationtypeid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_consoleapplicationtypes(*msdyn_consoleapplicationtypeid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Application Type (Deprecated) (msdyn_consoleapplicationtype) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Application Type (Deprecated) (msdyn_consoleapplicationtype) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Application Type (Deprecated)** |
| **DisplayCollectionName** | **ConsoleApplicationTypes (Deprecated)** |
| **SchemaName** | `msdyn_consoleapplicationtype` |
| **CollectionSchemaName** | `msdyn_consoleapplicationtypes` |
| **EntitySetName** | `msdyn_consoleapplicationtypes`|
| **LogicalName** | `msdyn_consoleapplicationtype` |
| **LogicalCollectionName** | `msdyn_consoleapplicationtypes` |
| **PrimaryIdAttribute** | `msdyn_consoleapplicationtypeid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_consoleapplicationtypeId](#BKMK_msdyn_consoleapplicationtypeId)
- [msdyn_displayname](#BKMK_msdyn_displayname)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_RenderingOrder](#BKMK_msdyn_RenderingOrder)
- [msdyn_TemplateParameters](#BKMK_msdyn_TemplateParameters)
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

### <a name="BKMK_msdyn_consoleapplicationtypeId"></a> msdyn_consoleapplicationtypeId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ConsoleApplicationType**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_consoleapplicationtypeid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_displayname"></a> msdyn_displayname

|Property|Value|
|---|---|
|Description|**The display name of the custom entity.**|
|DisplayName|**Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_RenderingOrder"></a> msdyn_RenderingOrder

|Property|Value|
|---|---|
|Description|**The order between various page-types rendered in a session template**|
|DisplayName|**Rendering Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_renderingorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_TemplateParameters"></a> msdyn_TemplateParameters

|Property|Value|
|---|---|
|Description|**Populated by plugin at post-retrieve stage. Computed from the parameters relationship**|
|DisplayName|**Template Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_templateparameters`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2048|

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
|Description|**Status of the Application Type**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_consoleapplicationtype_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Application Type**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_consoleapplicationtype_statuscode`|

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

- [lk_msdyn_consoleapplicationtype_createdby](#BKMK_lk_msdyn_consoleapplicationtype_createdby)
- [lk_msdyn_consoleapplicationtype_createdonbehalfby](#BKMK_lk_msdyn_consoleapplicationtype_createdonbehalfby)
- [lk_msdyn_consoleapplicationtype_modifiedby](#BKMK_lk_msdyn_consoleapplicationtype_modifiedby)
- [lk_msdyn_consoleapplicationtype_modifiedonbehalfby](#BKMK_lk_msdyn_consoleapplicationtype_modifiedonbehalfby)
- [organization_msdyn_consoleapplicationtype](#BKMK_organization_msdyn_consoleapplicationtype)

### <a name="BKMK_lk_msdyn_consoleapplicationtype_createdby"></a> lk_msdyn_consoleapplicationtype_createdby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationtype_createdby](systemuser.md#BKMK_lk_msdyn_consoleapplicationtype_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationtype_createdonbehalfby"></a> lk_msdyn_consoleapplicationtype_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationtype_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_consoleapplicationtype_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationtype_modifiedby"></a> lk_msdyn_consoleapplicationtype_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationtype_modifiedby](systemuser.md#BKMK_lk_msdyn_consoleapplicationtype_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationtype_modifiedonbehalfby"></a> lk_msdyn_consoleapplicationtype_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationtype_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_consoleapplicationtype_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_consoleapplicationtype"></a> organization_msdyn_consoleapplicationtype

One-To-Many Relationship: [organization organization_msdyn_consoleapplicationtype](organization.md#BKMK_organization_msdyn_consoleapplicationtype)

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

- [msdyn_consoleapplicationtype_AsyncOperations](#BKMK_msdyn_consoleapplicationtype_AsyncOperations)
- [msdyn_consoleapplicationtype_BulkDeleteFailures](#BKMK_msdyn_consoleapplicationtype_BulkDeleteFailures)
- [msdyn_consoleapplicationtype_DuplicateBaseRecord](#BKMK_msdyn_consoleapplicationtype_DuplicateBaseRecord)
- [msdyn_consoleapplicationtype_DuplicateMatchingRecord](#BKMK_msdyn_consoleapplicationtype_DuplicateMatchingRecord)
- [msdyn_consoleapplicationtype_MailboxTrackingFolders](#BKMK_msdyn_consoleapplicationtype_MailboxTrackingFolders)
- [msdyn_consoleapplicationtype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_consoleapplicationtype_PrincipalObjectAttributeAccesses)
- [msdyn_consoleapplicationtype_ProcessSession](#BKMK_msdyn_consoleapplicationtype_ProcessSession)
- [msdyn_consoleapplicationtype_SyncErrors](#BKMK_msdyn_consoleapplicationtype_SyncErrors)
- [msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType](#BKMK_msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType)

### <a name="BKMK_msdyn_consoleapplicationtype_AsyncOperations"></a> msdyn_consoleapplicationtype_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_consoleapplicationtype_AsyncOperations](asyncoperation.md#BKMK_msdyn_consoleapplicationtype_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtype_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtype_BulkDeleteFailures"></a> msdyn_consoleapplicationtype_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_consoleapplicationtype_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_consoleapplicationtype_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtype_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtype_DuplicateBaseRecord"></a> msdyn_consoleapplicationtype_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_consoleapplicationtype_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_consoleapplicationtype_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtype_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtype_DuplicateMatchingRecord"></a> msdyn_consoleapplicationtype_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_consoleapplicationtype_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_consoleapplicationtype_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtype_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtype_MailboxTrackingFolders"></a> msdyn_consoleapplicationtype_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_consoleapplicationtype_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_consoleapplicationtype_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtype_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtype_PrincipalObjectAttributeAccesses"></a> msdyn_consoleapplicationtype_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_consoleapplicationtype_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_consoleapplicationtype_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtype_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtype_ProcessSession"></a> msdyn_consoleapplicationtype_ProcessSession

Many-To-One Relationship: [processsession msdyn_consoleapplicationtype_ProcessSession](processsession.md#BKMK_msdyn_consoleapplicationtype_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtype_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtype_SyncErrors"></a> msdyn_consoleapplicationtype_SyncErrors

Many-To-One Relationship: [syncerror msdyn_consoleapplicationtype_SyncErrors](syncerror.md#BKMK_msdyn_consoleapplicationtype_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtype_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType"></a> msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType

Many-To-One Relationship: [msdyn_consoleapplicationtemplate msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType](msdyn_consoleapplicationtemplate.md#BKMK_msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationtemplate`|
|ReferencingAttribute|`msdyn_pagetype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_consoleapplicationtype_msdyn_consol"></a> msdyn_msdyn_consoleapplicationtype_msdyn_consol

See [msdyn_consoleappparameterdefinition msdyn_msdyn_consoleapplicationtype_msdyn_consol Many-To-Many Relationship](msdyn_consoleappparameterdefinition.md#BKMK_msdyn_msdyn_consoleapplicationtype_msdyn_consol)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_consoleapplicationtype_msdyn_cons`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_consoleapplicationtype_msdyn_consol`|
|IntersectAttribute|`msdyn_consoleapplicationtypeid`|
|NavigationPropertyName|`msdyn_msdyn_consoleapplicationtype_msdyn_consol`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

