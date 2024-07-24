---
title: "Workflow Trigger Map (msdynmkt_workflowtriggermap) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Workflow Trigger Map (msdynmkt_workflowtriggermap) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Workflow Trigger Map (msdynmkt_workflowtriggermap) table/entity reference

Event to flow mapping for triggering of a flow.

## Messages

The following table lists the messages for the Workflow Trigger Map (msdynmkt_workflowtriggermap) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_workflowtriggermaps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_workflowtriggermaps(*msdynmkt_workflowtriggermapid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_workflowtriggermaps(*msdynmkt_workflowtriggermapid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_workflowtriggermaps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_workflowtriggermaps(*msdynmkt_workflowtriggermapid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdynmkt_workflowtriggermaps(*msdynmkt_workflowtriggermapid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Workflow Trigger Map (msdynmkt_workflowtriggermap) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Workflow Trigger Map (msdynmkt_workflowtriggermap) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Workflow Trigger Map** |
| **DisplayCollectionName** | **Workflow Trigger Maps** |
| **SchemaName** | `msdynmkt_workflowtriggermap` |
| **CollectionSchemaName** | `msdynmkt_workflowtriggermaps` |
| **EntitySetName** | `msdynmkt_workflowtriggermaps`|
| **LogicalName** | `msdynmkt_workflowtriggermap` |
| **LogicalCollectionName** | `msdynmkt_workflowtriggermaps` |
| **PrimaryIdAttribute** | `msdynmkt_workflowtriggermapid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_baseversionjourneyid](#BKMK_msdynmkt_baseversionjourneyid)
- [msdynmkt_entrycriteria](#BKMK_msdynmkt_entrycriteria)
- [msdynmkt_eventname](#BKMK_msdynmkt_eventname)
- [msdynmkt_journeydefinitionid](#BKMK_msdynmkt_journeydefinitionid)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_spliton](#BKMK_msdynmkt_spliton)
- [msdynmkt_targetentity](#BKMK_msdynmkt_targetentity)
- [msdynmkt_version](#BKMK_msdynmkt_version)
- [msdynmkt_webhookid](#BKMK_msdynmkt_webhookid)
- [msdynmkt_workflowdefinitionid](#BKMK_msdynmkt_workflowdefinitionid)
- [msdynmkt_workflowtriggermapId](#BKMK_msdynmkt_workflowtriggermapId)
- [msdynmkt_workflowtriggerurl](#BKMK_msdynmkt_workflowtriggerurl)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [PartitionId](#BKMK_PartitionId)
- [TTLInSeconds](#BKMK_TTLInSeconds)

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

### <a name="BKMK_msdynmkt_baseversionjourneyid"></a> msdynmkt_baseversionjourneyid

|Property|Value|
|---|---|
|Description|**Base version journey id.**|
|DisplayName|**Base Version Journey Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_baseversionjourneyid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_entrycriteria"></a> msdynmkt_entrycriteria

|Property|Value|
|---|---|
|Description|**A set of journey properties to determine if a target can enter a journey.**|
|DisplayName|**Entry Criteria**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_entrycriteria`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_eventname"></a> msdynmkt_eventname

|Property|Value|
|---|---|
|Description|**Event name to trigger a flow.**|
|DisplayName|**Event Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_eventname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdynmkt_journeydefinitionid"></a> msdynmkt_journeydefinitionid

|Property|Value|
|---|---|
|Description|**Unique identifier for journey definitions.**|
|DisplayName|**Journey Definition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeydefinitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdynmkt_spliton"></a> msdynmkt_spliton

|Property|Value|
|---|---|
|Description|**Use Power Automate SplitOn functionality.**|
|DisplayName|**Use SplitOn**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_spliton`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_workflowtriggermap_msdynmkt_spliton`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_targetentity"></a> msdynmkt_targetentity

|Property|Value|
|---|---|
|Description|**Expected identifier type used to trigger the associated workflow.**|
|DisplayName|**Target Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_targetentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_version"></a> msdynmkt_version

|Property|Value|
|---|---|
|Description|**Version of the trigger map behavior.**|
|DisplayName|**Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_version`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_webhookid"></a> msdynmkt_webhookid

|Property|Value|
|---|---|
|Description|**Unique identifier of the webhook trigger.**|
|DisplayName|**Webhook Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_webhookid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_workflowdefinitionid"></a> msdynmkt_workflowdefinitionid

|Property|Value|
|---|---|
|Description|**Unique identifier for PA flows.**|
|DisplayName|**Workflow Definition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_workflowdefinitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_workflowtriggermapId"></a> msdynmkt_workflowtriggermapId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Workflow Trigger Map**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_workflowtriggermapid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_workflowtriggerurl"></a> msdynmkt_workflowtriggerurl

|Property|Value|
|---|---|
|Description|**HTTP URL which orchestration engine calls to trigger a PA flow**|
|DisplayName|**Workflow Trigger Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_workflowtriggerurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
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

### <a name="BKMK_PartitionId"></a> PartitionId

|Property|Value|
|---|---|
|Description|**Logical partition id. A logical partition consists of a set of records with same partition id.**|
|DisplayName|**Partition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TTLInSeconds"></a> TTLInSeconds

|Property|Value|
|---|---|
|Description|**Time to live in seconds.**|
|DisplayName|**Time to live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ttlinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
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

- [lk_msdynmkt_workflowtriggermap_createdby](#BKMK_lk_msdynmkt_workflowtriggermap_createdby)
- [lk_msdynmkt_workflowtriggermap_createdonbehalfby](#BKMK_lk_msdynmkt_workflowtriggermap_createdonbehalfby)
- [lk_msdynmkt_workflowtriggermap_modifiedby](#BKMK_lk_msdynmkt_workflowtriggermap_modifiedby)
- [lk_msdynmkt_workflowtriggermap_modifiedonbehalfby](#BKMK_lk_msdynmkt_workflowtriggermap_modifiedonbehalfby)

### <a name="BKMK_lk_msdynmkt_workflowtriggermap_createdby"></a> lk_msdynmkt_workflowtriggermap_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_workflowtriggermap_createdby](systemuser.md#BKMK_lk_msdynmkt_workflowtriggermap_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_workflowtriggermap_createdonbehalfby"></a> lk_msdynmkt_workflowtriggermap_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_workflowtriggermap_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_workflowtriggermap_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_workflowtriggermap_modifiedby"></a> lk_msdynmkt_workflowtriggermap_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_workflowtriggermap_modifiedby](systemuser.md#BKMK_lk_msdynmkt_workflowtriggermap_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_workflowtriggermap_modifiedonbehalfby"></a> lk_msdynmkt_workflowtriggermap_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_workflowtriggermap_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_workflowtriggermap_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

