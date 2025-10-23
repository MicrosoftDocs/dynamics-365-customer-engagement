---
title: "Agent Resource Forecasting (msdyn_agentresourceforecasting) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Agent Resource Forecasting (msdyn_agentresourceforecasting) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Agent Resource Forecasting (msdyn_agentresourceforecasting) table/entity reference (Microsoft Dynamics 365)

Agent Resource Forecasting

## Messages

The following table lists the messages for the Agent Resource Forecasting (msdyn_agentresourceforecasting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_agentresourceforecastings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_agentresourceforecastings(*msdyn_agentresourceforecastingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_agentresourceforecastings(*msdyn_agentresourceforecastingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_agentresourceforecastings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_agentresourceforecastings(*msdyn_agentresourceforecastingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_agentresourceforecastings(*msdyn_agentresourceforecastingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_agentresourceforecastings(*msdyn_agentresourceforecastingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agent Resource Forecasting (msdyn_agentresourceforecasting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agent Resource Forecasting** |
| **DisplayCollectionName** | **Agent Resource Forecastings** |
| **SchemaName** | `msdyn_agentresourceforecasting` |
| **CollectionSchemaName** | `msdyn_agentresourceforecastings` |
| **EntitySetName** | `msdyn_agentresourceforecastings`|
| **LogicalName** | `msdyn_agentresourceforecasting` |
| **LogicalCollectionName** | `msdyn_agentresourceforecastings` |
| **PrimaryIdAttribute** | `msdyn_agentresourceforecastingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentresourceforecastingId](#BKMK_msdyn_agentresourceforecastingId)
- [msdyn_channel](#BKMK_msdyn_channel)
- [msdyn_concurrency](#BKMK_msdyn_concurrency)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_servicetime](#BKMK_msdyn_servicetime)
- [msdyn_shrinkage](#BKMK_msdyn_shrinkage)
- [msdyn_sla](#BKMK_msdyn_sla)
- [msdyn_type](#BKMK_msdyn_type)
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

### <a name="BKMK_msdyn_agentresourceforecastingId"></a> msdyn_agentresourceforecastingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**agentresourceforecasting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agentresourceforecastingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_channel"></a> msdyn_channel

|Property|Value|
|---|---|
|Description|**Defines the channel related with the data**|
|DisplayName|**Channels**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channel`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_occhannelconfiguration|

### <a name="BKMK_msdyn_concurrency"></a> msdyn_concurrency

|Property|Value|
|---|---|
|Description|**Defines the concurrency for the channel**|
|DisplayName|**Concurrency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_concurrency`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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

### <a name="BKMK_msdyn_servicetime"></a> msdyn_servicetime

|Property|Value|
|---|---|
|Description|**Defines the service time set for the channel(seconds)**|
|DisplayName|**Service time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_servicetime`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_shrinkage"></a> msdyn_shrinkage

|Property|Value|
|---|---|
|Description|**Defines the shrinkage for the channel(%)**|
|DisplayName|**Shrinkage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shrinkage`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Auto|
|MaxValue|100|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_sla"></a> msdyn_sla

|Property|Value|
|---|---|
|Description|**Defines the sla set for the channel(%)**|
|DisplayName|**SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sla`|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description|**Defines the type of forecasting(case or conversation)**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the agentresourceforecasting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agentresourceforecasting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the agentresourceforecasting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agentresourceforecasting_statuscode`|

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

- [lk_msdyn_agentresourceforecasting_createdby](#BKMK_lk_msdyn_agentresourceforecasting_createdby)
- [lk_msdyn_agentresourceforecasting_createdonbehalfby](#BKMK_lk_msdyn_agentresourceforecasting_createdonbehalfby)
- [lk_msdyn_agentresourceforecasting_modifiedby](#BKMK_lk_msdyn_agentresourceforecasting_modifiedby)
- [lk_msdyn_agentresourceforecasting_modifiedonbehalfby](#BKMK_lk_msdyn_agentresourceforecasting_modifiedonbehalfby)
- [msdyn_msdyn_occhannelconfiguration_msdyn_agentresourceforecasting_channel](#BKMK_msdyn_msdyn_occhannelconfiguration_msdyn_agentresourceforecasting_channel)
- [organization_msdyn_agentresourceforecasting](#BKMK_organization_msdyn_agentresourceforecasting)

### <a name="BKMK_lk_msdyn_agentresourceforecasting_createdby"></a> lk_msdyn_agentresourceforecasting_createdby

One-To-Many Relationship: [systemuser lk_msdyn_agentresourceforecasting_createdby](systemuser.md#BKMK_lk_msdyn_agentresourceforecasting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentresourceforecasting_createdonbehalfby"></a> lk_msdyn_agentresourceforecasting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentresourceforecasting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agentresourceforecasting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentresourceforecasting_modifiedby"></a> lk_msdyn_agentresourceforecasting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_agentresourceforecasting_modifiedby](systemuser.md#BKMK_lk_msdyn_agentresourceforecasting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentresourceforecasting_modifiedonbehalfby"></a> lk_msdyn_agentresourceforecasting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentresourceforecasting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agentresourceforecasting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_occhannelconfiguration_msdyn_agentresourceforecasting_channel"></a> msdyn_msdyn_occhannelconfiguration_msdyn_agentresourceforecasting_channel

One-To-Many Relationship: [msdyn_occhannelconfiguration msdyn_msdyn_occhannelconfiguration_msdyn_agentresourceforecasting_channel](msdyn_occhannelconfiguration.md#BKMK_msdyn_msdyn_occhannelconfiguration_msdyn_agentresourceforecasting_channel)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occhannelconfiguration`|
|ReferencedAttribute|`msdyn_occhannelconfigurationid`|
|ReferencingAttribute|`msdyn_channel`|
|ReferencingEntityNavigationPropertyName|`msdyn_channel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_agentresourceforecasting"></a> organization_msdyn_agentresourceforecasting

One-To-Many Relationship: [organization organization_msdyn_agentresourceforecasting](organization.md#BKMK_organization_msdyn_agentresourceforecasting)

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

- [msdyn_agentresourceforecasting_AsyncOperations](#BKMK_msdyn_agentresourceforecasting_AsyncOperations)
- [msdyn_agentresourceforecasting_BulkDeleteFailures](#BKMK_msdyn_agentresourceforecasting_BulkDeleteFailures)
- [msdyn_agentresourceforecasting_DuplicateBaseRecord](#BKMK_msdyn_agentresourceforecasting_DuplicateBaseRecord)
- [msdyn_agentresourceforecasting_DuplicateMatchingRecord](#BKMK_msdyn_agentresourceforecasting_DuplicateMatchingRecord)
- [msdyn_agentresourceforecasting_MailboxTrackingFolders](#BKMK_msdyn_agentresourceforecasting_MailboxTrackingFolders)
- [msdyn_agentresourceforecasting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agentresourceforecasting_PrincipalObjectAttributeAccesses)
- [msdyn_agentresourceforecasting_ProcessSession](#BKMK_msdyn_agentresourceforecasting_ProcessSession)
- [msdyn_agentresourceforecasting_SyncErrors](#BKMK_msdyn_agentresourceforecasting_SyncErrors)

### <a name="BKMK_msdyn_agentresourceforecasting_AsyncOperations"></a> msdyn_agentresourceforecasting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_agentresourceforecasting_AsyncOperations](asyncoperation.md#BKMK_msdyn_agentresourceforecasting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentresourceforecasting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentresourceforecasting_BulkDeleteFailures"></a> msdyn_agentresourceforecasting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_agentresourceforecasting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agentresourceforecasting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentresourceforecasting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentresourceforecasting_DuplicateBaseRecord"></a> msdyn_agentresourceforecasting_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_agentresourceforecasting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agentresourceforecasting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentresourceforecasting_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentresourceforecasting_DuplicateMatchingRecord"></a> msdyn_agentresourceforecasting_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_agentresourceforecasting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agentresourceforecasting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentresourceforecasting_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentresourceforecasting_MailboxTrackingFolders"></a> msdyn_agentresourceforecasting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_agentresourceforecasting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agentresourceforecasting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentresourceforecasting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentresourceforecasting_PrincipalObjectAttributeAccesses"></a> msdyn_agentresourceforecasting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_agentresourceforecasting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agentresourceforecasting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentresourceforecasting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentresourceforecasting_ProcessSession"></a> msdyn_agentresourceforecasting_ProcessSession

Many-To-One Relationship: [processsession msdyn_agentresourceforecasting_ProcessSession](processsession.md#BKMK_msdyn_agentresourceforecasting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentresourceforecasting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentresourceforecasting_SyncErrors"></a> msdyn_agentresourceforecasting_SyncErrors

Many-To-One Relationship: [syncerror msdyn_agentresourceforecasting_SyncErrors](syncerror.md#BKMK_msdyn_agentresourceforecasting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentresourceforecasting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

