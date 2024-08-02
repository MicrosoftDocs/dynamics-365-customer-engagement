---
title: "Work List View Configuration (msdyn_worklistviewconfiguration) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Work List View Configuration (msdyn_worklistviewconfiguration) table/entity with Microsoft Dynamics 365."
ms.date: 08.01.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Work List View Configuration (msdyn_worklistviewconfiguration) table/entity reference

Entity to store work list view configurations on filter, icons, sort etc

## Messages

The following table lists the messages for the Work List View Configuration (msdyn_worklistviewconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_worklistviewconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_worklistviewconfigurations(*msdyn_worklistviewconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_worklistviewconfigurations(*msdyn_worklistviewconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_worklistviewconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyn_worklistviewconfigurations(*msdyn_worklistviewconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_worklistviewconfigurations(*msdyn_worklistviewconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_worklistviewconfigurations(*msdyn_worklistviewconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Work List View Configuration (msdyn_worklistviewconfiguration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Work List View Configuration (msdyn_worklistviewconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Work List View Configuration** |
| **DisplayCollectionName** | **Work List View Configurations** |
| **SchemaName** | `msdyn_worklistviewconfiguration` |
| **CollectionSchemaName** | `msdyn_worklistviewconfigurations` |
| **EntitySetName** | `msdyn_worklistviewconfigurations`|
| **LogicalName** | `msdyn_worklistviewconfiguration` |
| **LogicalCollectionName** | `msdyn_worklistviewconfigurations` |
| **PrimaryIdAttribute** | `msdyn_worklistviewconfigurationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_adminsortconfiguration](#BKMK_msdyn_adminsortconfiguration)
- [msdyn_cardlayout](#BKMK_msdyn_cardlayout)
- [msdyn_defaultsortconfiguration](#BKMK_msdyn_defaultsortconfiguration)
- [msdyn_entityconfiguration](#BKMK_msdyn_entityconfiguration)
- [msdyn_filterconfiguration](#BKMK_msdyn_filterconfiguration)
- [msdyn_inheritrolesfromparentsettings](#BKMK_msdyn_inheritrolesfromparentsettings)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_salesaccelerationsettingsid](#BKMK_msdyn_salesaccelerationsettingsid)
- [msdyn_securityrolelist](#BKMK_msdyn_securityrolelist)
- [msdyn_tagsconfiguration](#BKMK_msdyn_tagsconfiguration)
- [msdyn_viewtype](#BKMK_msdyn_viewtype)
- [msdyn_worklistviewconfigurationId](#BKMK_msdyn_worklistviewconfigurationId)
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

### <a name="BKMK_msdyn_adminsortconfiguration"></a> msdyn_adminsortconfiguration

|Property|Value|
|---|---|
|Description|**Json to hold sort options set by admin**|
|DisplayName|**Admin Sort Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_adminsortconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_cardlayout"></a> msdyn_cardlayout

|Property|Value|
|---|---|
|Description|**Layouts of card designed by admin**|
|DisplayName|**Card Layout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cardlayout`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_defaultsortconfiguration"></a> msdyn_defaultsortconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default Sort Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultsortconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_entityconfiguration"></a> msdyn_entityconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_filterconfiguration"></a> msdyn_filterconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Filter Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_filterconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_inheritrolesfromparentsettings"></a> msdyn_inheritrolesfromparentsettings

|Property|Value|
|---|---|
|Description|**Indicates if roles for current view are inherited from parent settings.**|
|DisplayName|**Inherit roles from parent settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inheritrolesfromparentsettings`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_worklistviewconfiguration_msdyn_inheritrolesfromparentsettings`|
|DefaultValue|False|
|True Label||
|False Label||

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

### <a name="BKMK_msdyn_salesaccelerationsettingsid"></a> msdyn_salesaccelerationsettingsid

|Property|Value|
|---|---|
|Description|**Many to one relationship to sales acceleration entity's primary key**|
|DisplayName|**Settings Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesaccelerationsettingsid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_salesaccelerationsettings|

### <a name="BKMK_msdyn_securityrolelist"></a> msdyn_securityrolelist

|Property|Value|
|---|---|
|Description|**Security roles enabled for worklist configuration**|
|DisplayName|**Security Role List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securityrolelist`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_tagsconfiguration"></a> msdyn_tagsconfiguration

|Property|Value|
|---|---|
|Description|**Tags Configuration for worklist view**|
|DisplayName|**Tags Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tagsconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_viewtype"></a> msdyn_viewtype

|Property|Value|
|---|---|
|Description|**Sales accelerator worklist view type**|
|DisplayName|**View Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_viewtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_viewtypeoptionset`|

#### msdyn_viewtype Choices/Options

|Value|Label|
|---|---|
|0|**Sequence**|
|1|**Suggestion**|

### <a name="BKMK_msdyn_worklistviewconfigurationId"></a> msdyn_worklistviewconfigurationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Work List View Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_worklistviewconfigurationid`|
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
|Description|**Status of the Work List View Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_worklistviewconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Work List View Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_worklistviewconfiguration_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **Published**<br />State:1<br />TransitionData: None|

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

- [lk_msdyn_worklistviewconfiguration_createdby](#BKMK_lk_msdyn_worklistviewconfiguration_createdby)
- [lk_msdyn_worklistviewconfiguration_createdonbehalfby](#BKMK_lk_msdyn_worklistviewconfiguration_createdonbehalfby)
- [lk_msdyn_worklistviewconfiguration_modifiedby](#BKMK_lk_msdyn_worklistviewconfiguration_modifiedby)
- [lk_msdyn_worklistviewconfiguration_modifiedonbehalfby](#BKMK_lk_msdyn_worklistviewconfiguration_modifiedonbehalfby)
- [msdyn_worklistviewconfig_salesaccelerationsettingsid](#BKMK_msdyn_worklistviewconfig_salesaccelerationsettingsid)
- [organization_msdyn_worklistviewconfiguration](#BKMK_organization_msdyn_worklistviewconfiguration)

### <a name="BKMK_lk_msdyn_worklistviewconfiguration_createdby"></a> lk_msdyn_worklistviewconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyn_worklistviewconfiguration_createdby](systemuser.md#BKMK_lk_msdyn_worklistviewconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_worklistviewconfiguration_createdonbehalfby"></a> lk_msdyn_worklistviewconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_worklistviewconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_worklistviewconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_worklistviewconfiguration_modifiedby"></a> lk_msdyn_worklistviewconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_worklistviewconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyn_worklistviewconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_worklistviewconfiguration_modifiedonbehalfby"></a> lk_msdyn_worklistviewconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_worklistviewconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_worklistviewconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_worklistviewconfig_salesaccelerationsettingsid"></a> msdyn_worklistviewconfig_salesaccelerationsettingsid

One-To-Many Relationship: [msdyn_salesaccelerationsettings msdyn_worklistviewconfig_salesaccelerationsettingsid](msdyn_salesaccelerationsettings.md#BKMK_msdyn_worklistviewconfig_salesaccelerationsettingsid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salesaccelerationsettings`|
|ReferencedAttribute|`msdyn_salesaccelerationsettingsid`|
|ReferencingAttribute|`msdyn_salesaccelerationsettingsid`|
|ReferencingEntityNavigationPropertyName|`msdyn_salesaccelerationsettingsid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_worklistviewconfiguration"></a> organization_msdyn_worklistviewconfiguration

One-To-Many Relationship: [organization organization_msdyn_worklistviewconfiguration](organization.md#BKMK_organization_msdyn_worklistviewconfiguration)

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

- [msdyn_worklistviewconfiguration_AsyncOperations](#BKMK_msdyn_worklistviewconfiguration_AsyncOperations)
- [msdyn_worklistviewconfiguration_BulkDeleteFailures](#BKMK_msdyn_worklistviewconfiguration_BulkDeleteFailures)
- [msdyn_worklistviewconfiguration_DuplicateBaseRecord](#BKMK_msdyn_worklistviewconfiguration_DuplicateBaseRecord)
- [msdyn_worklistviewconfiguration_DuplicateMatchingRecord](#BKMK_msdyn_worklistviewconfiguration_DuplicateMatchingRecord)
- [msdyn_worklistviewconfiguration_MailboxTrackingFolders](#BKMK_msdyn_worklistviewconfiguration_MailboxTrackingFolders)
- [msdyn_worklistviewconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_worklistviewconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_worklistviewconfiguration_ProcessSession](#BKMK_msdyn_worklistviewconfiguration_ProcessSession)
- [msdyn_worklistviewconfiguration_SyncErrors](#BKMK_msdyn_worklistviewconfiguration_SyncErrors)

### <a name="BKMK_msdyn_worklistviewconfiguration_AsyncOperations"></a> msdyn_worklistviewconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_worklistviewconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyn_worklistviewconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_worklistviewconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_worklistviewconfiguration_BulkDeleteFailures"></a> msdyn_worklistviewconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_worklistviewconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_worklistviewconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_worklistviewconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_worklistviewconfiguration_DuplicateBaseRecord"></a> msdyn_worklistviewconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_worklistviewconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_worklistviewconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_worklistviewconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_worklistviewconfiguration_DuplicateMatchingRecord"></a> msdyn_worklistviewconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_worklistviewconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_worklistviewconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_worklistviewconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_worklistviewconfiguration_MailboxTrackingFolders"></a> msdyn_worklistviewconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_worklistviewconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_worklistviewconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_worklistviewconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_worklistviewconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_worklistviewconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_worklistviewconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_worklistviewconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_worklistviewconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_worklistviewconfiguration_ProcessSession"></a> msdyn_worklistviewconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyn_worklistviewconfiguration_ProcessSession](processsession.md#BKMK_msdyn_worklistviewconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_worklistviewconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_worklistviewconfiguration_SyncErrors"></a> msdyn_worklistviewconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyn_worklistviewconfiguration_SyncErrors](syncerror.md#BKMK_msdyn_worklistviewconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_worklistviewconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

