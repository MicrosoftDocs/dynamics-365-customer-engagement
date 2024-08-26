---
title: "msdyn_msteamssettingsv2 table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdyn_msteamssettingsv2 table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# msdyn_msteamssettingsv2 table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the msdyn_msteamssettingsv2 table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_msteamssettingsv2<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /msdyn_msteamssettingsv2(*msdyn_msteamssettingsv2id*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_msteamssettingsv2(*msdyn_msteamssettingsv2id*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_msteamssettingsv2<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdyn_msteamssettingsv2(*msdyn_msteamssettingsv2id*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /msdyn_msteamssettingsv2(*msdyn_msteamssettingsv2id*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|


## Events

The following table lists the events for the msdyn_msteamssettingsv2 table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdyn_msteamssettingsv2 table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdyn_msteamssettingsv2** |
| **DisplayCollectionName** | **msdyn_msteamssettingsv2** |
| **SchemaName** | `msdyn_msteamssettingsv2` |
| **CollectionSchemaName** | `msdyn_msteamssettingsv2s` |
| **EntitySetName** | `msdyn_msteamssettingsv2`|
| **LogicalName** | `msdyn_msteamssettingsv2` |
| **LogicalCollectionName** | `msdyn_msteamssettingsv2s` |
| **PrimaryIdAttribute** | `msdyn_msteamssettingsv2id` |
| **PrimaryNameAttribute** |`msdyn_msteamssettingsname` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_DefaultTeamsChatTitleEnabled](#BKMK_msdyn_DefaultTeamsChatTitleEnabled)
- [msdyn_EmbedCollabServiceUrl](#BKMK_msdyn_EmbedCollabServiceUrl)
- [msdyn_EmbedCollabTeamsIntegrationEnabled](#BKMK_msdyn_EmbedCollabTeamsIntegrationEnabled)
- [msdyn_EntitySettingForTeamsMeetingIntegration](#BKMK_msdyn_EntitySettingForTeamsMeetingIntegration)
- [msdyn_IsDefaultEntitySettingCreatedForTMI](#BKMK_msdyn_IsDefaultEntitySettingCreatedForTMI)
- [msdyn_MSTeamsSettingsName](#BKMK_msdyn_MSTeamsSettingsName)
- [msdyn_msteamssettingsv2Id](#BKMK_msdyn_msteamssettingsv2Id)
- [msdyn_SecurityRoleSettingForTeamsMeetingIntegration](#BKMK_msdyn_SecurityRoleSettingForTeamsMeetingIntegration)
- [msdyn_SensitivityLabelSettingEnabled](#BKMK_msdyn_SensitivityLabelSettingEnabled)
- [msdyn_TabServiceUrl](#BKMK_msdyn_TabServiceUrl)
- [msdyn_TeamsAppAutoInstallEnabled](#BKMK_msdyn_TeamsAppAutoInstallEnabled)
- [msdyn_TeamsMeetingIntegrationEnabled](#BKMK_msdyn_TeamsMeetingIntegrationEnabled)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

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

### <a name="BKMK_msdyn_DefaultTeamsChatTitleEnabled"></a> msdyn_DefaultTeamsChatTitleEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether the default title for linked chat is the record name**|
|DisplayName|**Default title for linked chat**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultteamschattitleenabled`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msteamssettingsv2_msdyn_defaultteamschattitleenabled`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_EmbedCollabServiceUrl"></a> msdyn_EmbedCollabServiceUrl

|Property|Value|
|---|---|
|Description|**URL for embeded collaboration MSteams service**|
|DisplayName|**Embeded Collaboration Service Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_embedcollabserviceurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_EmbedCollabTeamsIntegrationEnabled"></a> msdyn_EmbedCollabTeamsIntegrationEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether embed-collab teams integration is enabled**|
|DisplayName|**Embed-collab teams integration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_embedcollabteamsintegrationenabled`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msteamssettingsv2_msdyn_embedcollabteamsintegrationenabled`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_EntitySettingForTeamsMeetingIntegration"></a> msdyn_EntitySettingForTeamsMeetingIntegration

|Property|Value|
|---|---|
|Description|**Default form list of entities which are used for Teams meeting integration**|
|DisplayName|**Entity setting for Teams meeting integration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitysettingforteamsmeetingintegration`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_IsDefaultEntitySettingCreatedForTMI"></a> msdyn_IsDefaultEntitySettingCreatedForTMI

|Property|Value|
|---|---|
|Description|**Indicates whether the default entity setting is created for Teams meeting integration**|
|DisplayName|**Is default entity setting created for Teams meeting integration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdefaultentitysettingcreatedfortmi`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msteamssettingsv2_msdyn_isdefaultentitysettingcreatedfortmi`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_MSTeamsSettingsName"></a> msdyn_MSTeamsSettingsName

|Property|Value|
|---|---|
|Description|**MSTeams settingsv2 name**|
|DisplayName|**MSTeams settingsv2 name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_msteamssettingsname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_msteamssettingsv2Id"></a> msdyn_msteamssettingsv2Id

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**msdyn_msteamssettingsv2**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_msteamssettingsv2id`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SecurityRoleSettingForTeamsMeetingIntegration"></a> msdyn_SecurityRoleSettingForTeamsMeetingIntegration

|Property|Value|
|---|---|
|Description|**Security roles list which can set Teams meeting integration**|
|DisplayName|**Security role setting for Teams meeting integration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securityrolesettingforteamsmeetingintegration`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_SensitivityLabelSettingEnabled"></a> msdyn_SensitivityLabelSettingEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether sensitivity label setting for new team creation has been enabled**|
|DisplayName|**Enable sensitivity labels for Teams collaboration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sensitivitylabelsettingenabled`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msteamssettingsv2_msdyn_sensitivitylabelsettingenabled`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_TabServiceUrl"></a> msdyn_TabServiceUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**msdyn_TabServiceUrl**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tabserviceurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_TeamsAppAutoInstallEnabled"></a> msdyn_TeamsAppAutoInstallEnabled

|Property|Value|
|---|---|
|Description|**Indicates if teams auto-install is enabled**|
|DisplayName|**Indicates if auto-installation of Teams app is enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamsappautoinstallenabled`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msteamssettingsv2_msdyn_teamsappautoinstallenabled`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_TeamsMeetingIntegrationEnabled"></a> msdyn_TeamsMeetingIntegrationEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether teams meeting integration is enabled**|
|DisplayName|**teams meeting integration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamsmeetingintegrationenabled`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msteamssettingsv2_msdyn_teamsmeetingintegrationenabled`|
|DefaultValue|False|
|True Label||
|False Label||

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
|Description|**Status of the msdyn_msteamssettingsv2**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_msteamssettingsv2_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the msdyn_msteamssettingsv2**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_msteamssettingsv2_statuscode`|

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

- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [VersionNumber](#BKMK_VersionNumber)

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

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets||

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

- [lk_msdyn_msteamssettingsv2_createdby](#BKMK_lk_msdyn_msteamssettingsv2_createdby)
- [lk_msdyn_msteamssettingsv2_createdonbehalfby](#BKMK_lk_msdyn_msteamssettingsv2_createdonbehalfby)
- [lk_msdyn_msteamssettingsv2_modifiedby](#BKMK_lk_msdyn_msteamssettingsv2_modifiedby)
- [lk_msdyn_msteamssettingsv2_modifiedonbehalfby](#BKMK_lk_msdyn_msteamssettingsv2_modifiedonbehalfby)

### <a name="BKMK_lk_msdyn_msteamssettingsv2_createdby"></a> lk_msdyn_msteamssettingsv2_createdby

One-To-Many Relationship: [systemuser lk_msdyn_msteamssettingsv2_createdby](systemuser.md#BKMK_lk_msdyn_msteamssettingsv2_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_msteamssettingsv2_createdonbehalfby"></a> lk_msdyn_msteamssettingsv2_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_msteamssettingsv2_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_msteamssettingsv2_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_msteamssettingsv2_modifiedby"></a> lk_msdyn_msteamssettingsv2_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_msteamssettingsv2_modifiedby](systemuser.md#BKMK_lk_msdyn_msteamssettingsv2_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_msteamssettingsv2_modifiedonbehalfby"></a> lk_msdyn_msteamssettingsv2_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_msteamssettingsv2_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_msteamssettingsv2_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msteamssettingsv2_AsyncOperations](#BKMK_msdyn_msteamssettingsv2_AsyncOperations)
- [msdyn_msteamssettingsv2_BulkDeleteFailures](#BKMK_msdyn_msteamssettingsv2_BulkDeleteFailures)
- [msdyn_msteamssettingsv2_MailboxTrackingFolders](#BKMK_msdyn_msteamssettingsv2_MailboxTrackingFolders)
- [msdyn_msteamssettingsv2_PrincipalObjectAttributeAccesses](#BKMK_msdyn_msteamssettingsv2_PrincipalObjectAttributeAccesses)
- [msdyn_msteamssettingsv2_ProcessSession](#BKMK_msdyn_msteamssettingsv2_ProcessSession)
- [msdyn_msteamssettingsv2_SyncErrors](#BKMK_msdyn_msteamssettingsv2_SyncErrors)

### <a name="BKMK_msdyn_msteamssettingsv2_AsyncOperations"></a> msdyn_msteamssettingsv2_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_msteamssettingsv2_AsyncOperations](asyncoperation.md#BKMK_msdyn_msteamssettingsv2_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msteamssettingsv2_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msteamssettingsv2_BulkDeleteFailures"></a> msdyn_msteamssettingsv2_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_msteamssettingsv2_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_msteamssettingsv2_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msteamssettingsv2_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msteamssettingsv2_MailboxTrackingFolders"></a> msdyn_msteamssettingsv2_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_msteamssettingsv2_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_msteamssettingsv2_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msteamssettingsv2_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msteamssettingsv2_PrincipalObjectAttributeAccesses"></a> msdyn_msteamssettingsv2_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_msteamssettingsv2_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_msteamssettingsv2_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msteamssettingsv2_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msteamssettingsv2_ProcessSession"></a> msdyn_msteamssettingsv2_ProcessSession

Many-To-One Relationship: [processsession msdyn_msteamssettingsv2_ProcessSession](processsession.md#BKMK_msdyn_msteamssettingsv2_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msteamssettingsv2_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msteamssettingsv2_SyncErrors"></a> msdyn_msteamssettingsv2_SyncErrors

Many-To-One Relationship: [syncerror msdyn_msteamssettingsv2_SyncErrors](syncerror.md#BKMK_msdyn_msteamssettingsv2_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msteamssettingsv2_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

