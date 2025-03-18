---
title: "Forecast (msdyn_forecast) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast (msdyn_forecast) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast (msdyn_forecast) table/entity reference (Microsoft Dynamics 365)

Forecast

## Messages

The following table lists the messages for the Forecast (msdyn_forecast) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_forecasts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_forecasts(*msdyn_forecastid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_forecasts(*msdyn_forecastid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_forecasts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_forecasts(*msdyn_forecastid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_forecasts(*msdyn_forecastid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast (msdyn_forecast) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast** |
| **DisplayCollectionName** | **Forecasts** |
| **SchemaName** | `msdyn_forecast` |
| **CollectionSchemaName** | `msdyn_forecasts` |
| **EntitySetName** | `msdyn_forecasts`|
| **LogicalName** | `msdyn_forecast` |
| **LogicalCollectionName** | `msdyn_forecasts` |
| **PrimaryIdAttribute** | `msdyn_forecastid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_aggregatedcolumns](#BKMK_msdyn_aggregatedcolumns)
- [msdyn_forecastconfigurationid](#BKMK_msdyn_forecastconfigurationid)
- [msdyn_forecastId](#BKMK_msdyn_forecastId)
- [msdyn_forecastrecurrenceid](#BKMK_msdyn_forecastrecurrenceid)
- [msdyn_forecastrecurrenceidPId](#BKMK_msdyn_forecastrecurrenceidPId)
- [msdyn_hierarchyentityrecord](#BKMK_msdyn_hierarchyentityrecord)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ownerid](#BKMK_msdyn_ownerid)
- [msdyn_parentinstanceid](#BKMK_msdyn_parentinstanceid)
- [msdyn_parentinstanceidPId](#BKMK_msdyn_parentinstanceidPId)
- [msdyn_rolledupcolumns](#BKMK_msdyn_rolledupcolumns)
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

### <a name="BKMK_msdyn_aggregatedcolumns"></a> msdyn_aggregatedcolumns

|Property|Value|
|---|---|
|Description|**AggregatedColumns**|
|DisplayName|**AggregatedColumns**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aggregatedcolumns`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50000|

### <a name="BKMK_msdyn_forecastconfigurationid"></a> msdyn_forecastconfigurationid

|Property|Value|
|---|---|
|Description|**ForecastConfigurationId**|
|DisplayName|**ForecastConfigurationId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastconfigurationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_forecastconfiguration|

### <a name="BKMK_msdyn_forecastId"></a> msdyn_forecastId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Forecast**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_forecastrecurrenceid"></a> msdyn_forecastrecurrenceid

|Property|Value|
|---|---|
|Description|**ForecastRecurrenceId**|
|DisplayName|**ForecastRecurrenceId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastrecurrenceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_recurrence|

### <a name="BKMK_msdyn_forecastrecurrenceidPId"></a> msdyn_forecastrecurrenceidPId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastrecurrenceidpid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_hierarchyentityrecord"></a> msdyn_hierarchyentityrecord

|Property|Value|
|---|---|
|Description|**HierarchyEntityRecord**|
|DisplayName|**HierarchyEntityRecord**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hierarchyentityrecord`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Forecast Id**|
|DisplayName|**Forecast Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ownerid"></a> msdyn_ownerid

|Property|Value|
|---|---|
|Description|**OwnerId**|
|DisplayName|**OwnerId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ownerid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_parentinstanceid"></a> msdyn_parentinstanceid

|Property|Value|
|---|---|
|Description|**ParentInstanceId**|
|DisplayName|**ParentInstanceId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentinstanceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_forecast|

### <a name="BKMK_msdyn_parentinstanceidPId"></a> msdyn_parentinstanceidPId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_parentinstanceidpid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_rolledupcolumns"></a> msdyn_rolledupcolumns

|Property|Value|
|---|---|
|Description|**RolledUpColumns**|
|DisplayName|**RolledUpColumns**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rolledupcolumns`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50000|

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

- [lk_msdyn_forecast_createdby](#BKMK_lk_msdyn_forecast_createdby)
- [lk_msdyn_forecast_createdonbehalfby](#BKMK_lk_msdyn_forecast_createdonbehalfby)
- [lk_msdyn_forecast_modifiedby](#BKMK_lk_msdyn_forecast_modifiedby)
- [lk_msdyn_forecast_modifiedonbehalfby](#BKMK_lk_msdyn_forecast_modifiedonbehalfby)
- [msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid](#BKMK_msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid-many-to-one)
- [msdyn_msdyn_forecast_ownerid](#BKMK_msdyn_msdyn_forecast_ownerid)
- [msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid)
- [msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid](#BKMK_msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid)

### <a name="BKMK_lk_msdyn_forecast_createdby"></a> lk_msdyn_forecast_createdby

One-To-Many Relationship: [systemuser lk_msdyn_forecast_createdby](systemuser.md#BKMK_lk_msdyn_forecast_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecast_createdonbehalfby"></a> lk_msdyn_forecast_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecast_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecast_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecast_modifiedby"></a> lk_msdyn_forecast_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_forecast_modifiedby](systemuser.md#BKMK_lk_msdyn_forecast_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecast_modifiedonbehalfby"></a> lk_msdyn_forecast_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecast_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecast_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid-many-to-one"></a> msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid

One-To-Many Relationship: [msdyn_forecast msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid](#BKMK_msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecast`|
|ReferencedAttribute|`msdyn_forecastid`|
|ReferencingAttribute|`msdyn_parentinstanceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_parentinstanceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecast_ownerid"></a> msdyn_msdyn_forecast_ownerid

One-To-Many Relationship: [systemuser msdyn_msdyn_forecast_ownerid](systemuser.md#BKMK_msdyn_msdyn_forecast_ownerid)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_ownerid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid

One-To-Many Relationship: [msdyn_forecastconfiguration msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid](msdyn_forecastconfiguration.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastconfiguration`|
|ReferencedAttribute|`msdyn_forecastconfigurationid`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastconfigurationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid"></a> msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid

One-To-Many Relationship: [msdyn_recurrence msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid](msdyn_recurrence.md#BKMK_msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_recurrence`|
|ReferencedAttribute|`msdyn_recurrenceid`|
|ReferencingAttribute|`msdyn_forecastrecurrenceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastrecurrenceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid](#BKMK_msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid)
- [msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid](#BKMK_msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid-one-to-many)
- [msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid](#BKMK_msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid)

### <a name="BKMK_msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid"></a> msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid

Many-To-One Relationship: [msdyn_adjustmenthistory msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid](msdyn_adjustmenthistory.md#BKMK_msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_adjustmenthistory`|
|ReferencingAttribute|`msdyn_forecastid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid-one-to-many"></a> msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid

Many-To-One Relationship: [msdyn_forecast msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid](#BKMK_msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecast`|
|ReferencingAttribute|`msdyn_parentinstanceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecast_msdyn_forecast_parentinstanceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid"></a> msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid

Many-To-One Relationship: [msdyn_forecastpredictiondata msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid](msdyn_forecastpredictiondata.md#BKMK_msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastpredictiondata`|
|ReferencingAttribute|`msdyn_forecastid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

