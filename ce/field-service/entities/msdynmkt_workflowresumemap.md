---
title: "Workflow Resume Map (msdynmkt_workflowresumemap) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Workflow Resume Map (msdynmkt_workflowresumemap) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Workflow Resume Map (msdynmkt_workflowresumemap) table/entity reference

Event to flow mapping for resuming of a waiting flow.

## Messages

The following table lists the messages for the Workflow Resume Map (msdynmkt_workflowresumemap) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_workflowresumemaps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_workflowresumemaps(*msdynmkt_workflowresumemapid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_workflowresumemaps(*msdynmkt_workflowresumemapid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_workflowresumemaps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_workflowresumemaps(*msdynmkt_workflowresumemapid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdynmkt_workflowresumemaps(*msdynmkt_workflowresumemapid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Workflow Resume Map (msdynmkt_workflowresumemap) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Workflow Resume Map (msdynmkt_workflowresumemap) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Workflow Resume Map** |
| **DisplayCollectionName** | **Workflow Resume Maps** |
| **SchemaName** | `msdynmkt_workflowresumemap` |
| **CollectionSchemaName** | `msdynmkt_workflowresumemaps` |
| **EntitySetName** | `msdynmkt_workflowresumemaps`|
| **LogicalName** | `msdynmkt_workflowresumemap` |
| **LogicalCollectionName** | `msdynmkt_workflowresumemaps` |
| **PrimaryIdAttribute** | `msdynmkt_workflowresumemapid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_eventdata](#BKMK_msdynmkt_eventdata)
- [msdynmkt_eventname](#BKMK_msdynmkt_eventname)
- [msdynmkt_isseriestile](#BKMK_msdynmkt_isseriestile)
- [msdynmkt_journeydefinitionid](#BKMK_msdynmkt_journeydefinitionid)
- [msdynmkt_journeyinstanceid](#BKMK_msdynmkt_journeyinstanceid)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_resultstatus](#BKMK_msdynmkt_resultstatus)
- [msdynmkt_resumecriteria](#BKMK_msdynmkt_resumecriteria)
- [msdynmkt_targetentity](#BKMK_msdynmkt_targetentity)
- [msdynmkt_targetid](#BKMK_msdynmkt_targetid)
- [msdynmkt_workflowresumemapId](#BKMK_msdynmkt_workflowresumemapId)
- [msdynmkt_workflowresumeurl](#BKMK_msdynmkt_workflowresumeurl)
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

### <a name="BKMK_msdynmkt_eventdata"></a> msdynmkt_eventdata

|Property|Value|
|---|---|
|Description|**Event data from the event that finished the series, if any**|
|DisplayName|**Persisted event data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_eventdata`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_eventname"></a> msdynmkt_eventname

|Property|Value|
|---|---|
|Description|**Event name to resume a waiting flow.**|
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

### <a name="BKMK_msdynmkt_isseriestile"></a> msdynmkt_isseriestile

|Property|Value|
|---|---|
|Description|**Whether or not this resume map is for a series tile**|
|DisplayName|**Is Series Tile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_isseriestile`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_workflowresumemap_msdynmkt_isseriestile`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdynmkt_journeyinstanceid"></a> msdynmkt_journeyinstanceid

|Property|Value|
|---|---|
|Description|**Unique identifier for journey instances.**|
|DisplayName|**Journey Instance Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyinstanceid`|
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

### <a name="BKMK_msdynmkt_resultstatus"></a> msdynmkt_resultstatus

|Property|Value|
|---|---|
|Description|**Result code for a series operation**|
|DisplayName|**Result of a series**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_resultstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_resumecriteria"></a> msdynmkt_resumecriteria

|Property|Value|
|---|---|
|Description|**A set of journey properties to determine if a target can resume a journey.**|
|DisplayName|**Resume Criteria**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_resumecriteria`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_targetentity"></a> msdynmkt_targetentity

|Property|Value|
|---|---|
|Description|**Name of the entity associated with the Target Id.**|
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

### <a name="BKMK_msdynmkt_targetid"></a> msdynmkt_targetid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_targetid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_workflowresumemapId"></a> msdynmkt_workflowresumemapId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Workflow Resume Map**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_workflowresumemapid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_workflowresumeurl"></a> msdynmkt_workflowresumeurl

|Property|Value|
|---|---|
|Description|**HTTP URL which orchestration engine calls to resume a PA flow.**|
|DisplayName|**Workflow Resume Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_workflowresumeurl`|
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

- [lk_msdynmkt_workflowresumemap_createdby](#BKMK_lk_msdynmkt_workflowresumemap_createdby)
- [lk_msdynmkt_workflowresumemap_createdonbehalfby](#BKMK_lk_msdynmkt_workflowresumemap_createdonbehalfby)
- [lk_msdynmkt_workflowresumemap_modifiedby](#BKMK_lk_msdynmkt_workflowresumemap_modifiedby)
- [lk_msdynmkt_workflowresumemap_modifiedonbehalfby](#BKMK_lk_msdynmkt_workflowresumemap_modifiedonbehalfby)

### <a name="BKMK_lk_msdynmkt_workflowresumemap_createdby"></a> lk_msdynmkt_workflowresumemap_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_workflowresumemap_createdby](systemuser.md#BKMK_lk_msdynmkt_workflowresumemap_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_workflowresumemap_createdonbehalfby"></a> lk_msdynmkt_workflowresumemap_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_workflowresumemap_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_workflowresumemap_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_workflowresumemap_modifiedby"></a> lk_msdynmkt_workflowresumemap_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_workflowresumemap_modifiedby](systemuser.md#BKMK_lk_msdynmkt_workflowresumemap_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_workflowresumemap_modifiedonbehalfby"></a> lk_msdynmkt_workflowresumemap_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_workflowresumemap_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_workflowresumemap_modifiedonbehalfby)

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

