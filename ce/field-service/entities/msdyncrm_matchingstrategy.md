---
title: "Form matching (msdyncrm_matchingstrategy) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Form matching (msdyncrm_matchingstrategy) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Form matching (msdyncrm_matchingstrategy) table/entity reference



## Messages

The following table lists the messages for the Form matching (msdyncrm_matchingstrategy) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyncrm_matchingstrategies<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_matchingstrategies(*msdyncrm_matchingstrategyid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_matchingstrategies(*msdyncrm_matchingstrategyid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_matchingstrategies<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_matchingstrategies(*msdyncrm_matchingstrategyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_matchingstrategies(*msdyncrm_matchingstrategyid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_matchingstrategies(*msdyncrm_matchingstrategyid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Form matching (msdyncrm_matchingstrategy) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Form matching (msdyncrm_matchingstrategy) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Form matching** |
| **DisplayCollectionName** | **Forms matching** |
| **SchemaName** | `msdyncrm_matchingstrategy` |
| **CollectionSchemaName** | `msdyncrm_matchingstrategies` |
| **EntitySetName** | `msdyncrm_matchingstrategies`|
| **LogicalName** | `msdyncrm_matchingstrategy` |
| **LogicalCollectionName** | `msdyncrm_matchingstrategies` |
| **PrimaryIdAttribute** | `msdyncrm_matchingstrategyid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_description](#BKMK_msdyncrm_description)
- [msdyncrm_matchingstrategyfields](#BKMK_msdyncrm_matchingstrategyfields)
- [msdyncrm_matchingstrategyfieldsstatus](#BKMK_msdyncrm_matchingstrategyfieldsstatus)
- [msdyncrm_matchingstrategyId](#BKMK_msdyncrm_matchingstrategyId)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_targetentity](#BKMK_msdyncrm_targetentity)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_description"></a> msdyncrm_description

|Property|Value|
|---|---|
|Description|**Description of the form matching**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_matchingstrategyfields"></a> msdyncrm_matchingstrategyfields

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form matching fields**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_matchingstrategyfields`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyncrm_matchingstrategyfieldsstatus"></a> msdyncrm_matchingstrategyfieldsstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form matching fields status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_matchingstrategyfieldsstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_matchingstrategy_msdyncrm_matchingstrategyfieldsstatus`|

#### msdyncrm_matchingstrategyfieldsstatus Choices/Options

|Value|Label|
|---|---|
|100000000|**Not validated**|
|100000001|**Validated**|

### <a name="BKMK_msdyncrm_matchingstrategyId"></a> msdyncrm_matchingstrategyId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Form matching**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_matchingstrategyid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**Name of the form matching record**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_targetentity"></a> msdyncrm_targetentity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_targetentity`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_matchingstrategy_target`|

#### msdyncrm_targetentity Choices/Options

|Value|Label|
|---|---|
|192350000|**Contact**|
|192350001|**Lead**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the form matching**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_matchingstrategy_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Form matching status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_matchingstrategy_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time-zone rule version number**|
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
|Description|**Time-zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time-zone code**|
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
|Description|**Indicates the person who created this.**|
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
|Description|**Date and time when the record was created**|
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
|Description|**Indicates the person who created this for another person.**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who modified this.**|
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
|Description|**Date and time when the record was modified**|
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
|Description|**Indicates the person who modified this for another person.**|
|DisplayName|**Modified by (delegate)**|
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

- [lk_msdyncrm_matchingstrategy_createdby](#BKMK_lk_msdyncrm_matchingstrategy_createdby)
- [lk_msdyncrm_matchingstrategy_createdonbehalfby](#BKMK_lk_msdyncrm_matchingstrategy_createdonbehalfby)
- [lk_msdyncrm_matchingstrategy_modifiedby](#BKMK_lk_msdyncrm_matchingstrategy_modifiedby)
- [lk_msdyncrm_matchingstrategy_modifiedonbehalfby](#BKMK_lk_msdyncrm_matchingstrategy_modifiedonbehalfby)
- [organization_msdyncrm_matchingstrategy](#BKMK_organization_msdyncrm_matchingstrategy)

### <a name="BKMK_lk_msdyncrm_matchingstrategy_createdby"></a> lk_msdyncrm_matchingstrategy_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_matchingstrategy_createdby](systemuser.md#BKMK_lk_msdyncrm_matchingstrategy_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_matchingstrategy_createdonbehalfby"></a> lk_msdyncrm_matchingstrategy_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_matchingstrategy_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_matchingstrategy_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_matchingstrategy_modifiedby"></a> lk_msdyncrm_matchingstrategy_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_matchingstrategy_modifiedby](systemuser.md#BKMK_lk_msdyncrm_matchingstrategy_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_matchingstrategy_modifiedonbehalfby"></a> lk_msdyncrm_matchingstrategy_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_matchingstrategy_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_matchingstrategy_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyncrm_matchingstrategy"></a> organization_msdyncrm_matchingstrategy

One-To-Many Relationship: [organization organization_msdyncrm_matchingstrategy](organization.md#BKMK_organization_msdyncrm_matchingstrategy)

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

- [msdyncrm_matchingstrategy_AsyncOperations](#BKMK_msdyncrm_matchingstrategy_AsyncOperations)
- [msdyncrm_matchingstrategy_BulkDeleteFailures](#BKMK_msdyncrm_matchingstrategy_BulkDeleteFailures)
- [msdyncrm_matchingstrategy_MailboxTrackingFolders](#BKMK_msdyncrm_matchingstrategy_MailboxTrackingFolders)
- [msdyncrm_matchingstrategy_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_matchingstrategy_PrincipalObjectAttributeAccesses)
- [msdyncrm_matchingstrategy_ProcessSession](#BKMK_msdyncrm_matchingstrategy_ProcessSession)
- [msdyncrm_matchingstrategy_SyncErrors](#BKMK_msdyncrm_matchingstrategy_SyncErrors)
- [msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy](#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy)
- [msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy](#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy)
- [msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy](#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy)
- [msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy](#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy)
- [msdyncrm_msdyncrm_matchingstrategy_msdyncrm_matchingstrategyattribute_msdyncrm_matchingstrategy](#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_matchingstrategyattribute_msdyncrm_matchingstrategy)

### <a name="BKMK_msdyncrm_matchingstrategy_AsyncOperations"></a> msdyncrm_matchingstrategy_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_matchingstrategy_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_matchingstrategy_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_matchingstrategy_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_matchingstrategy_BulkDeleteFailures"></a> msdyncrm_matchingstrategy_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_matchingstrategy_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_matchingstrategy_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_matchingstrategy_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_matchingstrategy_MailboxTrackingFolders"></a> msdyncrm_matchingstrategy_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_matchingstrategy_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_matchingstrategy_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_matchingstrategy_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_matchingstrategy_PrincipalObjectAttributeAccesses"></a> msdyncrm_matchingstrategy_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_matchingstrategy_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_matchingstrategy_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_matchingstrategy_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_matchingstrategy_ProcessSession"></a> msdyncrm_matchingstrategy_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_matchingstrategy_ProcessSession](processsession.md#BKMK_msdyncrm_matchingstrategy_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_matchingstrategy_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_matchingstrategy_SyncErrors"></a> msdyncrm_matchingstrategy_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_matchingstrategy_SyncErrors](syncerror.md#BKMK_msdyncrm_matchingstrategy_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_matchingstrategy_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy"></a> msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy

Many-To-One Relationship: [msdyncrm_marketingform msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy](msdyncrm_marketingform.md#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingform`|
|ReferencingAttribute|`msdyncrm_contactmatchingstrategy`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Marketing forms: Contacts<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy"></a> msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy

Many-To-One Relationship: [msdyncrm_marketingform msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy](msdyncrm_marketingform.md#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingform`|
|ReferencingAttribute|`msdyncrm_leadmatchingstrategy`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Marketing forms: Leads<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy"></a> msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy

Many-To-One Relationship: [msdyncrm_marketingpageconfiguration msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy](msdyncrm_marketingpageconfiguration.md#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingpageconfiguration`|
|ReferencingAttribute|`msdyncrm_contactmatchingstrategy`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Landing pages: Contacts<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy"></a> msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy

Many-To-One Relationship: [msdyncrm_marketingpageconfiguration msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy](msdyncrm_marketingpageconfiguration.md#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingpageconfiguration`|
|ReferencingAttribute|`msdyncrm_leadmatchingstrategy`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Landing pages: Leads<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_matchingstrategyattribute_msdyncrm_matchingstrategy"></a> msdyncrm_msdyncrm_matchingstrategy_msdyncrm_matchingstrategyattribute_msdyncrm_matchingstrategy

Many-To-One Relationship: [msdyncrm_matchingstrategyattribute msdyncrm_msdyncrm_matchingstrategy_msdyncrm_matchingstrategyattribute_msdyncrm_matchingstrategy](msdyncrm_matchingstrategyattribute.md#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_matchingstrategyattribute_msdyncrm_matchingstrategy)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_matchingstrategyattribute`|
|ReferencingAttribute|`msdyncrm_matchingstrategyid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_matchingstrategy_msdyncrm_matchingstrategyattribute_msdyncrm_matchingstrategy`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Form matching attributes<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

