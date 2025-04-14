---
title: "Forecast Prediction Data (msdyn_forecastpredictiondata) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast Prediction Data (msdyn_forecastpredictiondata) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast Prediction Data (msdyn_forecastpredictiondata) table/entity reference (Microsoft Dynamics 365)

Forecast Prediction Data

## Messages

The following table lists the messages for the Forecast Prediction Data (msdyn_forecastpredictiondata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_forecastpredictiondatas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_forecastpredictiondatas(*msdyn_forecastpredictiondataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_forecastpredictiondatas(*msdyn_forecastpredictiondataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_forecastpredictiondatas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_forecastpredictiondatas(*msdyn_forecastpredictiondataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_forecastpredictiondatas(*msdyn_forecastpredictiondataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast Prediction Data (msdyn_forecastpredictiondata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast Prediction Data** |
| **DisplayCollectionName** | **Forecast Prediction Data** |
| **SchemaName** | `msdyn_forecastpredictiondata` |
| **CollectionSchemaName** | `msdyn_forecastpredictiondatas` |
| **EntitySetName** | `msdyn_forecastpredictiondatas`|
| **LogicalName** | `msdyn_forecastpredictiondata` |
| **LogicalCollectionName** | `msdyn_forecastpredictiondatas` |
| **PrimaryIdAttribute** | `msdyn_forecastpredictiondataid` |
| **PrimaryNameAttribute** |`msdyn_hierarchyrecordid` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_childgranularpredictions](#BKMK_msdyn_childgranularpredictions)
- [msdyn_forecastconfigurationid](#BKMK_msdyn_forecastconfigurationid)
- [msdyn_forecastid](#BKMK_msdyn_forecastid)
- [msdyn_forecastidPId](#BKMK_msdyn_forecastidPId)
- [msdyn_forecastpredictiondataId](#BKMK_msdyn_forecastpredictiondataId)
- [msdyn_forecastrecurrenceid](#BKMK_msdyn_forecastrecurrenceid)
- [msdyn_forecastrecurrenceidPId](#BKMK_msdyn_forecastrecurrenceidPId)
- [msdyn_hierarchyrecordid](#BKMK_msdyn_hierarchyrecordid)
- [msdyn_parentgranularpredictions](#BKMK_msdyn_parentgranularpredictions)
- [msdyn_predictionon](#BKMK_msdyn_predictionon)
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

### <a name="BKMK_msdyn_childgranularpredictions"></a> msdyn_childgranularpredictions

|Property|Value|
|---|---|
|Description|**Child Granular Predictions**|
|DisplayName|**Child Granular Predictions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_childgranularpredictions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

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

### <a name="BKMK_msdyn_forecastpredictiondataId"></a> msdyn_forecastpredictiondataId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Forecast Prediction Data**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastpredictiondataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_forecastrecurrenceid"></a> msdyn_forecastrecurrenceid

|Property|Value|
|---|---|
|Description|**Forecast Recurrence Id**|
|DisplayName|**Forecast Recurrence Id**|
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

### <a name="BKMK_msdyn_hierarchyrecordid"></a> msdyn_hierarchyrecordid

|Property|Value|
|---|---|
|Description|**Hierarchy Record Id**|
|DisplayName|**Hierarchy Record Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hierarchyrecordid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_parentgranularpredictions"></a> msdyn_parentgranularpredictions

|Property|Value|
|---|---|
|Description|**Parent Granular Predictions**|
|DisplayName|**Parent Granular Predictions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentgranularpredictions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_predictionon"></a> msdyn_predictionon

|Property|Value|
|---|---|
|Description|**Date and time when the prediction was made**|
|DisplayName|**Prediction on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictionon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

- [lk_msdyn_forecastpredictiondata_createdby](#BKMK_lk_msdyn_forecastpredictiondata_createdby)
- [lk_msdyn_forecastpredictiondata_createdonbehalfby](#BKMK_lk_msdyn_forecastpredictiondata_createdonbehalfby)
- [lk_msdyn_forecastpredictiondata_modifiedby](#BKMK_lk_msdyn_forecastpredictiondata_modifiedby)
- [lk_msdyn_forecastpredictiondata_modifiedonbehalfby](#BKMK_lk_msdyn_forecastpredictiondata_modifiedonbehalfby)
- [msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid](#BKMK_msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid)
- [msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid)
- [msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid](#BKMK_msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid)

### <a name="BKMK_lk_msdyn_forecastpredictiondata_createdby"></a> lk_msdyn_forecastpredictiondata_createdby

One-To-Many Relationship: [systemuser lk_msdyn_forecastpredictiondata_createdby](systemuser.md#BKMK_lk_msdyn_forecastpredictiondata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastpredictiondata_createdonbehalfby"></a> lk_msdyn_forecastpredictiondata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastpredictiondata_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastpredictiondata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastpredictiondata_modifiedby"></a> lk_msdyn_forecastpredictiondata_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_forecastpredictiondata_modifiedby](systemuser.md#BKMK_lk_msdyn_forecastpredictiondata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastpredictiondata_modifiedonbehalfby"></a> lk_msdyn_forecastpredictiondata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastpredictiondata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastpredictiondata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid"></a> msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid

One-To-Many Relationship: [msdyn_forecast msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid](msdyn_forecast.md#BKMK_msdyn_msdyn_forecast_msdyn_forecastpredictiondata_forecastid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecast`|
|ReferencedAttribute|`msdyn_forecastid`|
|ReferencingAttribute|`msdyn_forecastid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid

One-To-Many Relationship: [msdyn_forecastconfiguration msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid](msdyn_forecastconfiguration.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastconfiguration`|
|ReferencedAttribute|`msdyn_forecastconfigurationid`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastconfigurationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid"></a> msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid

One-To-Many Relationship: [msdyn_recurrence msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid](msdyn_recurrence.md#BKMK_msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_recurrence`|
|ReferencedAttribute|`msdyn_recurrenceid`|
|ReferencingAttribute|`msdyn_forecastrecurrenceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastrecurrenceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

