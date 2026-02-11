---
title: "Migration tracker (msdyn_migrationtracker) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Migration tracker (msdyn_migrationtracker) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Migration tracker (msdyn_migrationtracker) table/entity reference (Microsoft Dynamics 365)

Entity that tracks the migration process of legacy to modern SLA/ARC items

## Messages

The following table lists the messages for the Migration tracker (msdyn_migrationtracker) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_migrationtrackers(*msdyn_migrationtrackerid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_migrationtrackers<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_migrationtrackers(*msdyn_migrationtrackerid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_migrationtrackers(*msdyn_migrationtrackerid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_migrationtrackers<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_migrationtrackers(*msdyn_migrationtrackerid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_migrationtrackers(*msdyn_migrationtrackerid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_migrationtrackers(*msdyn_migrationtrackerid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Migration tracker (msdyn_migrationtracker) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Migration tracker** |
| **DisplayCollectionName** | **Migration trackers** |
| **SchemaName** | `msdyn_migrationtracker` |
| **CollectionSchemaName** | `msdyn_migrationtrackers` |
| **EntitySetName** | `msdyn_migrationtrackers`|
| **LogicalName** | `msdyn_migrationtracker` |
| **LogicalCollectionName** | `msdyn_migrationtrackers` |
| **PrimaryIdAttribute** | `msdyn_migrationtrackerid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CorrelationId](#BKMK_CorrelationId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_CorrelationId](#BKMK_msdyn_CorrelationId)
- [msdyn_IsMigrationComplete](#BKMK_msdyn_IsMigrationComplete)
- [msdyn_LegacyConvertRuleId](#BKMK_msdyn_LegacyConvertRuleId)
- [msdyn_LegacyConvertRuleItemId](#BKMK_msdyn_LegacyConvertRuleItemId)
- [msdyn_LegacyRuleIdType](#BKMK_msdyn_LegacyRuleIdType)
- [msdyn_LegacyRuleItemIdType](#BKMK_msdyn_LegacyRuleItemIdType)
- [msdyn_LegacySLAId](#BKMK_msdyn_LegacySLAId)
- [msdyn_LegacySLAItemId](#BKMK_msdyn_LegacySLAItemId)
- [msdyn_MigrationStatus](#BKMK_msdyn_MigrationStatus)
- [msdyn_MigrationStatusException](#BKMK_msdyn_MigrationStatusException)
- [msdyn_MigrationStatusReason](#BKMK_msdyn_MigrationStatusReason)
- [msdyn_migrationtrackerId](#BKMK_msdyn_migrationtrackerId)
- [msdyn_MigrationType](#BKMK_msdyn_MigrationType)
- [msdyn_ModernConvertRuleId](#BKMK_msdyn_ModernConvertRuleId)
- [msdyn_ModernConvertRuleItemId](#BKMK_msdyn_ModernConvertRuleItemId)
- [msdyn_ModernRuleIdType](#BKMK_msdyn_ModernRuleIdType)
- [msdyn_ModernRuleItemIdType](#BKMK_msdyn_ModernRuleItemIdType)
- [msdyn_ModernSLAId](#BKMK_msdyn_ModernSLAId)
- [msdyn_ModernSLAItemId](#BKMK_msdyn_ModernSLAItemId)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_Objecttypecode](#BKMK_msdyn_Objecttypecode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_CorrelationId"></a> CorrelationId

|Property|Value|
|---|---|
|Description|**Unique identifier to distinguish each batch of migration(Deprecated)**|
|DisplayName|**CorrelationId(Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`correlationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyn_CorrelationId"></a> msdyn_CorrelationId

|Property|Value|
|---|---|
|Description|**Unique identifier to distinguish each batch of migration**|
|DisplayName|**CorrelationId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_correlationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_IsMigrationComplete"></a> msdyn_IsMigrationComplete

|Property|Value|
|---|---|
|Description|**Indicates if the migration was successfully completed or not**|
|DisplayName|**Is Migration Complete**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_IsMigrationComplete`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_migrationtracker_IsMigrationComplete`|
|DefaultValue|False|
|True Label|Success|
|False Label|Failure|

### <a name="BKMK_msdyn_LegacyConvertRuleId"></a> msdyn_LegacyConvertRuleId

|Property|Value|
|---|---|
|Description|**Id of the legacy ARC rule to be migrated**|
|DisplayName|**Legacy Convert Rule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_legacyconvertruleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|convertrule|

### <a name="BKMK_msdyn_LegacyConvertRuleItemId"></a> msdyn_LegacyConvertRuleItemId

|Property|Value|
|---|---|
|Description|**Id of the legacy ARC item to be migrated**|
|DisplayName|**Legacy convert rule item**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_legacyconvertruleitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|convertruleitem|

### <a name="BKMK_msdyn_LegacyRuleIdType"></a> msdyn_LegacyRuleIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Legacy rule type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_legacyruleidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_LegacyRuleItemIdType"></a> msdyn_LegacyRuleItemIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Legacy rule item type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_legacyruleitemidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_LegacySLAId"></a> msdyn_LegacySLAId

|Property|Value|
|---|---|
|Description|**Id of the legacy SLA to be migrated**|
|DisplayName|**Legacy SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_legacyslaid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_msdyn_LegacySLAItemId"></a> msdyn_LegacySLAItemId

|Property|Value|
|---|---|
|Description|**Id of the legacy SLA item to be migrated**|
|DisplayName|**Legacy sla item**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_legacyslaitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|slaitem|

### <a name="BKMK_msdyn_MigrationStatus"></a> msdyn_MigrationStatus

|Property|Value|
|---|---|
|Description|**The overall status of a migration process**|
|DisplayName|**Migration status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_migrationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_migrationtracker_migrationstatus`|

#### msdyn_MigrationStatus Choices/Options

|Value|Label|
|---|---|
|0|**In Progress**|
|1|**Migrated**|
|2|**Incomplete**|

### <a name="BKMK_msdyn_MigrationStatusException"></a> msdyn_MigrationStatusException

|Property|Value|
|---|---|
|Description|**The exception of a certain status**|
|DisplayName|**Migration status reason exception**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_migrationstatusexception`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_MigrationStatusReason"></a> msdyn_MigrationStatusReason

|Property|Value|
|---|---|
|Description|**The reason of a certain status**|
|DisplayName|**Migration status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_migrationstatusreason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_migrationtrackerId"></a> msdyn_migrationtrackerId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Migration tracker id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_migrationtrackerid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_MigrationType"></a> msdyn_MigrationType

|Property|Value|
|---|---|
|Description|**Indicates whether the request is a pre-validation check or an actual migration run**|
|DisplayName|**Migration Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_migrationtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_migrationtracker_migrationtype`|

#### msdyn_MigrationType Choices/Options

|Value|Label|
|---|---|
|0|**Migration**|
|1|**PreValidation**|

### <a name="BKMK_msdyn_ModernConvertRuleId"></a> msdyn_ModernConvertRuleId

|Property|Value|
|---|---|
|Description|**Id of the Uci ARC rule created post migration**|
|DisplayName|**Modern Convert rule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modernconvertruleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|convertrule|

### <a name="BKMK_msdyn_ModernConvertRuleItemId"></a> msdyn_ModernConvertRuleItemId

|Property|Value|
|---|---|
|Description|**Id of the Uci ARC item created post migration**|
|DisplayName|**Modern convert rule item**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modernconvertruleitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|convertruleitem|

### <a name="BKMK_msdyn_ModernRuleIdType"></a> msdyn_ModernRuleIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Modern rule type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_modernruleidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_ModernRuleItemIdType"></a> msdyn_ModernRuleItemIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Monitored activity type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_modernruleitemidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_ModernSLAId"></a> msdyn_ModernSLAId

|Property|Value|
|---|---|
|Description|**Id of the Uci SLA created post migration**|
|DisplayName|**Modern SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modernslaid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_msdyn_ModernSLAItemId"></a> msdyn_ModernSLAItemId

|Property|Value|
|---|---|
|Description|**Id of the Uci SLA item created post migration**|
|DisplayName|**Modern SLA item**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modernslaitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|slaitem|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

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

### <a name="BKMK_msdyn_Objecttypecode"></a> msdyn_Objecttypecode

|Property|Value|
|---|---|
|Description|**Object type code**|
|DisplayName|**Object type code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objecttypecode`|
|RequiredLevel|None|
|Type|EntityName|

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
|Description|**Status of the Migration tracker**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`migrationtracker_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Migration tracker**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_migrationtracker_statuscode`|

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
- [msdyn_LegacyRuleIdName](#BKMK_msdyn_LegacyRuleIdName)
- [msdyn_LegacyRuleItemIdName](#BKMK_msdyn_LegacyRuleItemIdName)
- [msdyn_ModernRuleIdName](#BKMK_msdyn_ModernRuleIdName)
- [msdyn_ModernRuleItemIdName](#BKMK_msdyn_ModernRuleItemIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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

### <a name="BKMK_msdyn_LegacyRuleIdName"></a> msdyn_LegacyRuleIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_legacyruleidname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_msdyn_LegacyRuleItemIdName"></a> msdyn_LegacyRuleItemIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_legacyruleitemidname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_msdyn_ModernRuleIdName"></a> msdyn_ModernRuleIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_modernruleidname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_msdyn_ModernRuleItemIdName"></a> msdyn_ModernRuleItemIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_modernruleitemidname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

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
|RequiredLevel|None|
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

- [business_unit_msdyn_migrationtracker](#BKMK_business_unit_msdyn_migrationtracker)
- [lk_msdyn_migrationtracker_createdby](#BKMK_lk_msdyn_migrationtracker_createdby)
- [lk_msdyn_migrationtracker_createdonbehalfby](#BKMK_lk_msdyn_migrationtracker_createdonbehalfby)
- [lk_msdyn_migrationtracker_modifiedby](#BKMK_lk_msdyn_migrationtracker_modifiedby)
- [lk_msdyn_migrationtracker_modifiedonbehalfby](#BKMK_lk_msdyn_migrationtracker_modifiedonbehalfby)
- [msdyn_migrationtracker_LegacySLA_sla](#BKMK_msdyn_migrationtracker_LegacySLA_sla)
- [msdyn_migrationtracker_LegacySLAItem_slaitem](#BKMK_msdyn_migrationtracker_LegacySLAItem_slaitem)
- [msdyn_migrationtracker_ModernSLA_sla](#BKMK_msdyn_migrationtracker_ModernSLA_sla)
- [msdyn_migrationtracker_ModernSLAItem_slaitem](#BKMK_msdyn_migrationtracker_ModernSLAItem_slaitem)
- [owner_msdyn_migrationtracker](#BKMK_owner_msdyn_migrationtracker)
- [team_msdyn_migrationtracker](#BKMK_team_msdyn_migrationtracker)
- [user_msdyn_migrationtracker](#BKMK_user_msdyn_migrationtracker)

### <a name="BKMK_business_unit_msdyn_migrationtracker"></a> business_unit_msdyn_migrationtracker

One-To-Many Relationship: [businessunit business_unit_msdyn_migrationtracker](businessunit.md#BKMK_business_unit_msdyn_migrationtracker)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_migrationtracker_createdby"></a> lk_msdyn_migrationtracker_createdby

One-To-Many Relationship: [systemuser lk_msdyn_migrationtracker_createdby](systemuser.md#BKMK_lk_msdyn_migrationtracker_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_migrationtracker_createdonbehalfby"></a> lk_msdyn_migrationtracker_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_migrationtracker_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_migrationtracker_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_migrationtracker_modifiedby"></a> lk_msdyn_migrationtracker_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_migrationtracker_modifiedby](systemuser.md#BKMK_lk_msdyn_migrationtracker_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_migrationtracker_modifiedonbehalfby"></a> lk_msdyn_migrationtracker_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_migrationtracker_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_migrationtracker_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_migrationtracker_LegacySLA_sla"></a> msdyn_migrationtracker_LegacySLA_sla

One-To-Many Relationship: [sla msdyn_migrationtracker_LegacySLA_sla](sla.md#BKMK_msdyn_migrationtracker_LegacySLA_sla)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`msdyn_legacyslaid`|
|ReferencingEntityNavigationPropertyName|`msdyn_LegacySLAId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_migrationtracker_LegacySLAItem_slaitem"></a> msdyn_migrationtracker_LegacySLAItem_slaitem

One-To-Many Relationship: [slaitem msdyn_migrationtracker_LegacySLAItem_slaitem](slaitem.md#BKMK_msdyn_migrationtracker_LegacySLAItem_slaitem)

|Property|Value|
|---|---|
|ReferencedEntity|`slaitem`|
|ReferencedAttribute|`slaitemid`|
|ReferencingAttribute|`msdyn_legacyslaitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_LegacySLAItemId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_migrationtracker_ModernSLA_sla"></a> msdyn_migrationtracker_ModernSLA_sla

One-To-Many Relationship: [sla msdyn_migrationtracker_ModernSLA_sla](sla.md#BKMK_msdyn_migrationtracker_ModernSLA_sla)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`msdyn_modernslaid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ModernSLAId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_migrationtracker_ModernSLAItem_slaitem"></a> msdyn_migrationtracker_ModernSLAItem_slaitem

One-To-Many Relationship: [slaitem msdyn_migrationtracker_ModernSLAItem_slaitem](slaitem.md#BKMK_msdyn_migrationtracker_ModernSLAItem_slaitem)

|Property|Value|
|---|---|
|ReferencedEntity|`slaitem`|
|ReferencedAttribute|`slaitemid`|
|ReferencingAttribute|`msdyn_modernslaitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ModernSLAItemId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_migrationtracker"></a> owner_msdyn_migrationtracker

One-To-Many Relationship: [owner owner_msdyn_migrationtracker](owner.md#BKMK_owner_msdyn_migrationtracker)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_migrationtracker"></a> team_msdyn_migrationtracker

One-To-Many Relationship: [team team_msdyn_migrationtracker](team.md#BKMK_team_msdyn_migrationtracker)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_migrationtracker"></a> user_msdyn_migrationtracker

One-To-Many Relationship: [systemuser user_msdyn_migrationtracker](systemuser.md#BKMK_user_msdyn_migrationtracker)

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

- [msdyn_migrationtracker_AsyncOperations](#BKMK_msdyn_migrationtracker_AsyncOperations)
- [msdyn_migrationtracker_BulkDeleteFailures](#BKMK_msdyn_migrationtracker_BulkDeleteFailures)
- [msdyn_migrationtracker_DuplicateBaseRecord](#BKMK_msdyn_migrationtracker_DuplicateBaseRecord)
- [msdyn_migrationtracker_DuplicateMatchingRecord](#BKMK_msdyn_migrationtracker_DuplicateMatchingRecord)
- [msdyn_migrationtracker_MailboxTrackingFolders](#BKMK_msdyn_migrationtracker_MailboxTrackingFolders)
- [msdyn_migrationtracker_PrincipalObjectAttributeAccesses](#BKMK_msdyn_migrationtracker_PrincipalObjectAttributeAccesses)
- [msdyn_migrationtracker_ProcessSession](#BKMK_msdyn_migrationtracker_ProcessSession)
- [msdyn_migrationtracker_SyncErrors](#BKMK_msdyn_migrationtracker_SyncErrors)

### <a name="BKMK_msdyn_migrationtracker_AsyncOperations"></a> msdyn_migrationtracker_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_migrationtracker_AsyncOperations](asyncoperation.md#BKMK_msdyn_migrationtracker_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_BulkDeleteFailures"></a> msdyn_migrationtracker_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_migrationtracker_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_migrationtracker_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_DuplicateBaseRecord"></a> msdyn_migrationtracker_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_migrationtracker_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_migrationtracker_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_DuplicateMatchingRecord"></a> msdyn_migrationtracker_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_migrationtracker_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_migrationtracker_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_MailboxTrackingFolders"></a> msdyn_migrationtracker_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_migrationtracker_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_migrationtracker_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_PrincipalObjectAttributeAccesses"></a> msdyn_migrationtracker_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_migrationtracker_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_migrationtracker_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_ProcessSession"></a> msdyn_migrationtracker_ProcessSession

Many-To-One Relationship: [processsession msdyn_migrationtracker_ProcessSession](processsession.md#BKMK_msdyn_migrationtracker_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_SyncErrors"></a> msdyn_migrationtracker_SyncErrors

Many-To-One Relationship: [syncerror msdyn_migrationtracker_SyncErrors](syncerror.md#BKMK_msdyn_migrationtracker_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

