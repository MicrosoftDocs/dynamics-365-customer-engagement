---
title: "Teams Dialer Admin settings (msdyn_teamsdialeradminsettings) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Teams Dialer Admin settings (msdyn_teamsdialeradminsettings) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Teams Dialer Admin settings (msdyn_teamsdialeradminsettings) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Teams Dialer Admin settings (msdyn_teamsdialeradminsettings) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_teamsdialeradminsettingset<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_teamsdialeradminsettingset(*msdyn_teamsdialeradminsettingsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_teamsdialeradminsettingset(*msdyn_teamsdialeradminsettingsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_teamsdialeradminsettingset<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_teamsdialeradminsettingset(*msdyn_teamsdialeradminsettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_teamsdialeradminsettingset(*msdyn_teamsdialeradminsettingsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_teamsdialeradminsettingset(*msdyn_teamsdialeradminsettingsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Teams Dialer Admin settings (msdyn_teamsdialeradminsettings) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Teams Dialer Admin settings** |
| **DisplayCollectionName** | **Teams Dialer Admin settings set** |
| **SchemaName** | `msdyn_teamsdialeradminsettings` |
| **CollectionSchemaName** | `msdyn_teamsdialeradminsettingses` |
| **EntitySetName** | `msdyn_teamsdialeradminsettingset`|
| **LogicalName** | `msdyn_teamsdialeradminsettings` |
| **LogicalCollectionName** | `msdyn_teamsdialeradminsettingses` |
| **PrimaryIdAttribute** | `msdyn_teamsdialeradminsettingsid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_addparticipantenabled](#BKMK_msdyn_addparticipantenabled)
- [msdyn_answerexternalincomingcalls](#BKMK_msdyn_answerexternalincomingcalls)
- [msdyn_AppModules](#BKMK_msdyn_AppModules)
- [msdyn_CICallPaneEntryPoints](#BKMK_msdyn_CICallPaneEntryPoints)
- [msdyn_ignoreinternalincomingcalls](#BKMK_msdyn_ignoreinternalincomingcalls)
- [msdyn_LayoutSchema](#BKMK_msdyn_LayoutSchema)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_RecordingSecurityRoles](#BKMK_msdyn_RecordingSecurityRoles)
- [msdyn_SecurityRoles](#BKMK_msdyn_SecurityRoles)
- [msdyn_SecurityRolesAllSelected](#BKMK_msdyn_SecurityRolesAllSelected)
- [msdyn_teamsdialeradminsettingsId](#BKMK_msdyn_teamsdialeradminsettingsId)
- [msdyn_transfercallsenabled](#BKMK_msdyn_transfercallsenabled)
- [msdyn_valuesjson](#BKMK_msdyn_valuesjson)
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

### <a name="BKMK_msdyn_addparticipantenabled"></a> msdyn_addparticipantenabled

|Property|Value|
|---|---|
|Description|**Control if Add Particiapnt featrue is enabled or not**|
|DisplayName|**msdyn_addparticipantenabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_addparticipantenabled`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_answerexternalincomingcalls"></a> msdyn_answerexternalincomingcalls

|Property|Value|
|---|---|
|Description|**Should answer incoming calls from users outside my org**|
|DisplayName|**Answer External Incoming Calls**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_answerexternalincomingcalls`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_teamsdialeradminsettings_msdyn_answerexternalincomingcalls`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_AppModules"></a> msdyn_AppModules

|Property|Value|
|---|---|
|Description|**App modules enabled for settings instance**|
|DisplayName|**App module list**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_appmodules`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_CICallPaneEntryPoints"></a> msdyn_CICallPaneEntryPoints

|Property|Value|
|---|---|
|Description|**Layout configuration for custom controls to be loaded**|
|DisplayName|**Layout configuration schema**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cicallpaneentrypoints`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_ignoreinternalincomingcalls"></a> msdyn_ignoreinternalincomingcalls

|Property|Value|
|---|---|
|Description|**Should incoming calls from users within the org be ignored**|
|DisplayName|**Ignore Internal Incoming Calls**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ignoreinternalincomingcalls`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_teamsdialeradminsettings_msdyn_ignoreinternalincomingcalls`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_LayoutSchema"></a> msdyn_LayoutSchema

|Property|Value|
|---|---|
|Description|**Layout configuration for custom controls to be loaded**|
|DisplayName|**Layout configuration schema**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_layoutschema`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the Teams Dialer Admin settings instance.**|
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

### <a name="BKMK_msdyn_RecordingSecurityRoles"></a> msdyn_RecordingSecurityRoles

|Property|Value|
|---|---|
|Description|**Recording security roles enabled for the settings instance**|
|DisplayName|**Recording Security Roles List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordingsecurityroles`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_SecurityRoles"></a> msdyn_SecurityRoles

|Property|Value|
|---|---|
|Description|**Security roles enabled for the settings instance**|
|DisplayName|**Security role list**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securityroles`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_SecurityRolesAllSelected"></a> msdyn_SecurityRolesAllSelected

|Property|Value|
|---|---|
|Description|**In Teams dialer settings page, were all security roles selected or not**|
|DisplayName|**msdyn_SecurityRolesAllSelected**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securityrolesallselected`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_teamsdialeradminsettingsId"></a> msdyn_teamsdialeradminsettingsId

|Property|Value|
|---|---|
|Description|**Unique identifier for Teams Dialer Admin settings instance**|
|DisplayName|**Teams Dialer Admin settings ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_teamsdialeradminsettingsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_transfercallsenabled"></a> msdyn_transfercallsenabled

|Property|Value|
|---|---|
|Description|**Control if Calls Transfer featrue is enabled or not (controlled by admin in Teams calls settings page)**|
|DisplayName|**msdyn_transfercallsenabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transfercallsenabled`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_valuesjson"></a> msdyn_valuesjson

|Property|Value|
|---|---|
|Description|**json to store all msdyn_teamsdialeradminsettings fields, to avoid changing this file when adding a field**|
|DisplayName|**msdyn_valuesjson**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_valuesjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

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
|Description|**Status of the Teams Dialer Admin settings**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_teamsdialeradminsettings_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Closed**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Teams Dialer Admin settings**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_teamsdialeradminsettings_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Saved**<br />State:0<br />TransitionData: None|
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

- [lk_msdyn_teamsdialeradminsettings_createdby](#BKMK_lk_msdyn_teamsdialeradminsettings_createdby)
- [lk_msdyn_teamsdialeradminsettings_createdonbehalfby](#BKMK_lk_msdyn_teamsdialeradminsettings_createdonbehalfby)
- [lk_msdyn_teamsdialeradminsettings_modifiedby](#BKMK_lk_msdyn_teamsdialeradminsettings_modifiedby)
- [lk_msdyn_teamsdialeradminsettings_modifiedonbehalfby](#BKMK_lk_msdyn_teamsdialeradminsettings_modifiedonbehalfby)
- [organization_msdyn_teamsdialeradminsettings](#BKMK_organization_msdyn_teamsdialeradminsettings)

### <a name="BKMK_lk_msdyn_teamsdialeradminsettings_createdby"></a> lk_msdyn_teamsdialeradminsettings_createdby

One-To-Many Relationship: [systemuser lk_msdyn_teamsdialeradminsettings_createdby](systemuser.md#BKMK_lk_msdyn_teamsdialeradminsettings_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_teamsdialeradminsettings_createdonbehalfby"></a> lk_msdyn_teamsdialeradminsettings_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_teamsdialeradminsettings_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_teamsdialeradminsettings_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_teamsdialeradminsettings_modifiedby"></a> lk_msdyn_teamsdialeradminsettings_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_teamsdialeradminsettings_modifiedby](systemuser.md#BKMK_lk_msdyn_teamsdialeradminsettings_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_teamsdialeradminsettings_modifiedonbehalfby"></a> lk_msdyn_teamsdialeradminsettings_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_teamsdialeradminsettings_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_teamsdialeradminsettings_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_teamsdialeradminsettings"></a> organization_msdyn_teamsdialeradminsettings

One-To-Many Relationship: [organization organization_msdyn_teamsdialeradminsettings](organization.md#BKMK_organization_msdyn_teamsdialeradminsettings)

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

- [msdyn_teamsdialeradminsettings_AsyncOperations](#BKMK_msdyn_teamsdialeradminsettings_AsyncOperations)
- [msdyn_teamsdialeradminsettings_BulkDeleteFailures](#BKMK_msdyn_teamsdialeradminsettings_BulkDeleteFailures)
- [msdyn_teamsdialeradminsettings_DuplicateBaseRecord](#BKMK_msdyn_teamsdialeradminsettings_DuplicateBaseRecord)
- [msdyn_teamsdialeradminsettings_DuplicateMatchingRecord](#BKMK_msdyn_teamsdialeradminsettings_DuplicateMatchingRecord)
- [msdyn_teamsdialeradminsettings_MailboxTrackingFolders](#BKMK_msdyn_teamsdialeradminsettings_MailboxTrackingFolders)
- [msdyn_teamsdialeradminsettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_teamsdialeradminsettings_PrincipalObjectAttributeAccesses)
- [msdyn_teamsdialeradminsettings_ProcessSession](#BKMK_msdyn_teamsdialeradminsettings_ProcessSession)
- [msdyn_teamsdialeradminsettings_SyncErrors](#BKMK_msdyn_teamsdialeradminsettings_SyncErrors)

### <a name="BKMK_msdyn_teamsdialeradminsettings_AsyncOperations"></a> msdyn_teamsdialeradminsettings_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_teamsdialeradminsettings_AsyncOperations](asyncoperation.md#BKMK_msdyn_teamsdialeradminsettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamsdialeradminsettings_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamsdialeradminsettings_BulkDeleteFailures"></a> msdyn_teamsdialeradminsettings_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_teamsdialeradminsettings_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_teamsdialeradminsettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamsdialeradminsettings_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamsdialeradminsettings_DuplicateBaseRecord"></a> msdyn_teamsdialeradminsettings_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_teamsdialeradminsettings_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_teamsdialeradminsettings_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamsdialeradminsettings_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamsdialeradminsettings_DuplicateMatchingRecord"></a> msdyn_teamsdialeradminsettings_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_teamsdialeradminsettings_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_teamsdialeradminsettings_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamsdialeradminsettings_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamsdialeradminsettings_MailboxTrackingFolders"></a> msdyn_teamsdialeradminsettings_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_teamsdialeradminsettings_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_teamsdialeradminsettings_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamsdialeradminsettings_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamsdialeradminsettings_PrincipalObjectAttributeAccesses"></a> msdyn_teamsdialeradminsettings_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_teamsdialeradminsettings_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_teamsdialeradminsettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamsdialeradminsettings_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamsdialeradminsettings_ProcessSession"></a> msdyn_teamsdialeradminsettings_ProcessSession

Many-To-One Relationship: [processsession msdyn_teamsdialeradminsettings_ProcessSession](processsession.md#BKMK_msdyn_teamsdialeradminsettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamsdialeradminsettings_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamsdialeradminsettings_SyncErrors"></a> msdyn_teamsdialeradminsettings_SyncErrors

Many-To-One Relationship: [syncerror msdyn_teamsdialeradminsettings_SyncErrors](syncerror.md#BKMK_msdyn_teamsdialeradminsettings_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamsdialeradminsettings_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

