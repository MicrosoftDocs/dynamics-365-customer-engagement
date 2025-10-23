---
title: "Wall View (msdyn_wallsavedquery) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Wall View (msdyn_wallsavedquery) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Wall View (msdyn_wallsavedquery) table/entity reference (Microsoft Dynamics 365)

Contains information regarding which views are available for users to display on their personal walls. Only an administrator can specify the views that users can choose from to display on their personal walls.

## Messages

The following table lists the messages for the Wall View (msdyn_wallsavedquery) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_wallsavedqueries<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_wallsavedqueries<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Wall View (msdyn_wallsavedquery) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Wall View** |
| **DisplayCollectionName** | **Wall Views** |
| **SchemaName** | `msdyn_wallsavedquery` |
| **CollectionSchemaName** | `msdyn_wallsavedqueries` |
| **EntitySetName** | `msdyn_wallsavedqueries`|
| **LogicalName** | `msdyn_wallsavedquery` |
| **LogicalCollectionName** | `msdyn_wallsavedqueries` |
| **PrimaryIdAttribute** | `msdyn_wallsavedqueryid` |
| **PrimaryNameAttribute** |`msdyn_entityname` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_entitydisplayname](#BKMK_msdyn_entitydisplayname)
- [msdyn_entityname](#BKMK_msdyn_entityname)
- [msdyn_IsVirtual](#BKMK_msdyn_IsVirtual)
- [msdyn_IsVisible](#BKMK_msdyn_IsVisible)
- [msdyn_isvisiblebit](#BKMK_msdyn_isvisiblebit)
- [msdyn_otc](#BKMK_msdyn_otc)
- [msdyn_postconfigurationid](#BKMK_msdyn_postconfigurationid)
- [msdyn_SavedQueryId](#BKMK_msdyn_SavedQueryId)
- [msdyn_savedqueryname](#BKMK_msdyn_savedqueryname)
- [msdyn_wallsavedqueryId](#BKMK_msdyn_wallsavedqueryId)
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

### <a name="BKMK_msdyn_entitydisplayname"></a> msdyn_entitydisplayname

|Property|Value|
|---|---|
|Description|**Type of entity to which the corresponding views belong**|
|DisplayName|**Entity Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitydisplayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_entityname"></a> msdyn_entityname

|Property|Value|
|---|---|
|Description|**Name of the entity to which the corresponding views belong.**|
|DisplayName|**Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_IsVirtual"></a> msdyn_IsVirtual

|Property|Value|
|---|---|
|Description|**Information that indicates whether the entity is virtual, that is whether, it is generated by a plug-in, and no corresponding entity instance exists.**|
|DisplayName|**Is Virtual**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isvirtual`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_wallsavedquery_msdyn_isvirtual`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsVisible"></a> msdyn_IsVisible

|Property|Value|
|---|---|
|Description|**Indicates that corresponding system view should be displayed on personal wall**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isvisible`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_wallsavedquery_msdyn_isvisible`|
|DefaultValue|False|
|True Label|Shown|
|False Label|Hidden|

### <a name="BKMK_msdyn_isvisiblebit"></a> msdyn_isvisiblebit

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Visible bit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isvisiblebit`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_otc"></a> msdyn_otc

|Property|Value|
|---|---|
|Description|**Type of entity to which the corresponding views belong.**|
|DisplayName|**Entity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_otc`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_postconfigurationid"></a> msdyn_postconfigurationid

|Property|Value|
|---|---|
|Description|**Unique identifier for Post Configuration associated with Wall View.**|
|DisplayName|**Post Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconfigurationid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_postconfig|

### <a name="BKMK_msdyn_SavedQueryId"></a> msdyn_SavedQueryId

|Property|Value|
|---|---|
|Description|**Unique identifier of the view that should be displayed on the personal wall for all users.**|
|DisplayName|**View Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_savedqueryid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_savedqueryname"></a> msdyn_savedqueryname

|Property|Value|
|---|---|
|Description|**Name of the corresponding view.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_savedqueryname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_wallsavedqueryId"></a> msdyn_wallsavedqueryId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Wall View**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_wallsavedqueryid`|
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
|Description|**Status of the Wall View**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_wallsavedquery_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Wall View**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_wallsavedquery_statuscode`|

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

- [lk_msdyn_wallsavedquery_createdby](#BKMK_lk_msdyn_wallsavedquery_createdby)
- [lk_msdyn_wallsavedquery_createdonbehalfby](#BKMK_lk_msdyn_wallsavedquery_createdonbehalfby)
- [lk_msdyn_wallsavedquery_modifiedby](#BKMK_lk_msdyn_wallsavedquery_modifiedby)
- [lk_msdyn_wallsavedquery_modifiedonbehalfby](#BKMK_lk_msdyn_wallsavedquery_modifiedonbehalfby)
- [msdyn_postconfig_wallsavedquery](#BKMK_msdyn_postconfig_wallsavedquery)
- [organization_msdyn_wallsavedquery](#BKMK_organization_msdyn_wallsavedquery)

### <a name="BKMK_lk_msdyn_wallsavedquery_createdby"></a> lk_msdyn_wallsavedquery_createdby

One-To-Many Relationship: [systemuser lk_msdyn_wallsavedquery_createdby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wallsavedquery_createdonbehalfby"></a> lk_msdyn_wallsavedquery_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_wallsavedquery_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wallsavedquery_modifiedby"></a> lk_msdyn_wallsavedquery_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_wallsavedquery_modifiedby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wallsavedquery_modifiedonbehalfby"></a> lk_msdyn_wallsavedquery_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_wallsavedquery_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postconfig_wallsavedquery"></a> msdyn_postconfig_wallsavedquery

One-To-Many Relationship: [msdyn_postconfig msdyn_postconfig_wallsavedquery](msdyn_postconfig.md#BKMK_msdyn_postconfig_wallsavedquery)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postconfig`|
|ReferencedAttribute|`msdyn_postconfigid`|
|ReferencingAttribute|`msdyn_postconfigurationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_postconfigurationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_organization_msdyn_wallsavedquery"></a> organization_msdyn_wallsavedquery

One-To-Many Relationship: [organization organization_msdyn_wallsavedquery](organization.md#BKMK_organization_msdyn_wallsavedquery)

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

- [msdyn_wallsavedquery_AsyncOperations](#BKMK_msdyn_wallsavedquery_AsyncOperations)
- [msdyn_wallsavedquery_BulkDeleteFailures](#BKMK_msdyn_wallsavedquery_BulkDeleteFailures)
- [msdyn_wallsavedquery_MailboxTrackingFolders](#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders)
- [msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses)
- [msdyn_wallsavedquery_ProcessSession](#BKMK_msdyn_wallsavedquery_ProcessSession)
- [msdyn_wallsavedquery_SyncErrors](#BKMK_msdyn_wallsavedquery_SyncErrors)
- [msdyn_wallsavedquery_wallsavedqueryusersettings](#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings)

### <a name="BKMK_msdyn_wallsavedquery_AsyncOperations"></a> msdyn_wallsavedquery_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_wallsavedquery_AsyncOperations](asyncoperation.md#BKMK_msdyn_wallsavedquery_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedquery_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedquery_BulkDeleteFailures"></a> msdyn_wallsavedquery_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_wallsavedquery_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_wallsavedquery_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedquery_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedquery_MailboxTrackingFolders"></a> msdyn_wallsavedquery_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_wallsavedquery_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedquery_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses"></a> msdyn_wallsavedquery_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedquery_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedquery_ProcessSession"></a> msdyn_wallsavedquery_ProcessSession

Many-To-One Relationship: [processsession msdyn_wallsavedquery_ProcessSession](processsession.md#BKMK_msdyn_wallsavedquery_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedquery_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedquery_SyncErrors"></a> msdyn_wallsavedquery_SyncErrors

Many-To-One Relationship: [syncerror msdyn_wallsavedquery_SyncErrors](syncerror.md#BKMK_msdyn_wallsavedquery_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedquery_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings"></a> msdyn_wallsavedquery_wallsavedqueryusersettings

Many-To-One Relationship: [msdyn_wallsavedqueryusersettings msdyn_wallsavedquery_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wallsavedqueryusersettings`|
|ReferencingAttribute|`msdyn_wallsavedqueryid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedquery_wallsavedqueryusersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

