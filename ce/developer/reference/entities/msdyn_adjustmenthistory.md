---
title: "Forecast Manual Adjustment History (msdyn_adjustmenthistory) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast Manual Adjustment History (msdyn_adjustmenthistory) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast Manual Adjustment History (msdyn_adjustmenthistory) table/entity reference (Microsoft Dynamics 365)

Forecast Manual Adjustment History

## Messages

The following table lists the messages for the Forecast Manual Adjustment History (msdyn_adjustmenthistory) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_adjustmenthistories<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_adjustmenthistories(*msdyn_adjustmenthistoryid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_adjustmenthistories(*msdyn_adjustmenthistoryid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_adjustmenthistories<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_adjustmenthistories(*msdyn_adjustmenthistoryid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_adjustmenthistories(*msdyn_adjustmenthistoryid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast Manual Adjustment History (msdyn_adjustmenthistory) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast Manual Adjustment History** |
| **DisplayCollectionName** | **Forecast Manual Adjustment History** |
| **SchemaName** | `msdyn_adjustmenthistory` |
| **CollectionSchemaName** | `msdyn_adjustmenthistories` |
| **EntitySetName** | `msdyn_adjustmenthistories`|
| **LogicalName** | `msdyn_adjustmenthistory` |
| **LogicalCollectionName** | `msdyn_adjustmenthistories` |
| **PrimaryIdAttribute** | `msdyn_adjustmenthistoryid` |
| **PrimaryNameAttribute** |`msdyn_forecastconfigurationcolumnid` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_adjustmenthistory](#BKMK_msdyn_adjustmenthistory)
- [msdyn_adjustmenthistoryId](#BKMK_msdyn_adjustmenthistoryId)
- [msdyn_forecastconfigurationcolumnid](#BKMK_msdyn_forecastconfigurationcolumnid)
- [msdyn_forecastconfigurationid](#BKMK_msdyn_forecastconfigurationid)
- [msdyn_forecastid](#BKMK_msdyn_forecastid)
- [msdyn_forecastidPId](#BKMK_msdyn_forecastidPId)
- [msdyn_forecastinstancecolumngrouptype](#BKMK_msdyn_forecastinstancecolumngrouptype)
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

### <a name="BKMK_msdyn_adjustmenthistory"></a> msdyn_adjustmenthistory

|Property|Value|
|---|---|
|Description|**Manual Adjustment History**|
|DisplayName|**Manual Adjustment History**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_adjustmenthistory`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_adjustmenthistoryId"></a> msdyn_adjustmenthistoryId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Forecast Manual Adjustment History**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_adjustmenthistoryid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_forecastconfigurationcolumnid"></a> msdyn_forecastconfigurationcolumnid

|Property|Value|
|---|---|
|Description|**Forecast Configuration Column Id**|
|DisplayName|**Forecast Configuration Column Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastconfigurationcolumnid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_forecastconfigurationid"></a> msdyn_forecastconfigurationid

|Property|Value|
|---|---|
|Description|**Forecast Configuration Id**|
|DisplayName|**Forecast Configuration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastconfigurationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_forecastconfiguration|

### <a name="BKMK_msdyn_forecastid"></a> msdyn_forecastid

|Property|Value|
|---|---|
|Description|**Forecast Instance Id**|
|DisplayName|**Forecast Instance Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_forecast|

### <a name="BKMK_msdyn_forecastidPId"></a> msdyn_forecastidPId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastidpid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_forecastinstancecolumngrouptype"></a> msdyn_forecastinstancecolumngrouptype

|Property|Value|
|---|---|
|Description|**Forecast Instance Column Group Type**|
|DisplayName|**Forecast Instance Column Group Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastinstancecolumngrouptype`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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

- [lk_msdyn_adjustmenthistory_createdby](#BKMK_lk_msdyn_adjustmenthistory_createdby)
- [lk_msdyn_adjustmenthistory_createdonbehalfby](#BKMK_lk_msdyn_adjustmenthistory_createdonbehalfby)
- [lk_msdyn_adjustmenthistory_modifiedby](#BKMK_lk_msdyn_adjustmenthistory_modifiedby)
- [lk_msdyn_adjustmenthistory_modifiedonbehalfby](#BKMK_lk_msdyn_adjustmenthistory_modifiedonbehalfby)
- [msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid](#BKMK_msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid)
- [msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid)

### <a name="BKMK_lk_msdyn_adjustmenthistory_createdby"></a> lk_msdyn_adjustmenthistory_createdby

One-To-Many Relationship: [systemuser lk_msdyn_adjustmenthistory_createdby](systemuser.md#BKMK_lk_msdyn_adjustmenthistory_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_adjustmenthistory_createdonbehalfby"></a> lk_msdyn_adjustmenthistory_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_adjustmenthistory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_adjustmenthistory_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_adjustmenthistory_modifiedby"></a> lk_msdyn_adjustmenthistory_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_adjustmenthistory_modifiedby](systemuser.md#BKMK_lk_msdyn_adjustmenthistory_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_adjustmenthistory_modifiedonbehalfby"></a> lk_msdyn_adjustmenthistory_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_adjustmenthistory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_adjustmenthistory_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid"></a> msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid

One-To-Many Relationship: [msdyn_forecast msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid](msdyn_forecast.md#BKMK_msdyn_msdyn_forecast_msdyn_adjustmenthistory_forecastid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecast`|
|ReferencedAttribute|`msdyn_forecastid`|
|ReferencingAttribute|`msdyn_forecastid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid

One-To-Many Relationship: [msdyn_forecastconfiguration msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid](msdyn_forecastconfiguration.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastconfiguration`|
|ReferencedAttribute|`msdyn_forecastconfigurationid`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastconfigurationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

