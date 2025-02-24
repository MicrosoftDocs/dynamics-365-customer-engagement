---
title: "Forecast Insights (msdyn_forecastinsight) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast Insights (msdyn_forecastinsight) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast Insights (msdyn_forecastinsight) table/entity reference (Microsoft Dynamics 365)

Forecast Insights

## Messages

The following table lists the messages for the Forecast Insights (msdyn_forecastinsight) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_forecastinsights<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_forecastinsights(*msdyn_forecastinsightid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_forecastinsights(*msdyn_forecastinsightid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_forecastinsights<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_forecastinsights(*msdyn_forecastinsightid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_forecastinsights(*msdyn_forecastinsightid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast Insights (msdyn_forecastinsight) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast Insights** |
| **DisplayCollectionName** | **Forecast Insights** |
| **SchemaName** | `msdyn_forecastinsight` |
| **CollectionSchemaName** | `msdyn_forecastinsights` |
| **EntitySetName** | `msdyn_forecastinsights`|
| **LogicalName** | `msdyn_forecastinsight` |
| **LogicalCollectionName** | `msdyn_forecastinsights` |
| **PrimaryIdAttribute** | `msdyn_forecastinsightid` |
| **PrimaryNameAttribute** |`msdyn_hierarchyrecordid` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_forecastconfigurationid](#BKMK_msdyn_forecastconfigurationid)
- [msdyn_forecastinsightId](#BKMK_msdyn_forecastinsightId)
- [msdyn_forecastrecurrenceid](#BKMK_msdyn_forecastrecurrenceid)
- [msdyn_forecastrecurrenceidPId](#BKMK_msdyn_forecastrecurrenceidPId)
- [msdyn_hierarchyrecordid](#BKMK_msdyn_hierarchyrecordid)
- [msdyn_insights](#BKMK_msdyn_insights)
- [msdyn_isrollup](#BKMK_msdyn_isrollup)
- [msdyn_version](#BKMK_msdyn_version)
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

### <a name="BKMK_msdyn_forecastinsightId"></a> msdyn_forecastinsightId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Forecast Insights**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastinsightid`|
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

### <a name="BKMK_msdyn_insights"></a> msdyn_insights

|Property|Value|
|---|---|
|Description|**Forecast Insights**|
|DisplayName|**Forecast Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_insights`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_isrollup"></a> msdyn_isrollup

|Property|Value|
|---|---|
|Description|**States if row is for rollup node in forecast insights**|
|DisplayName|**States if row is for rollup node**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isrollup`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_forecastinsight_msdyn_isrollup`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_version"></a> msdyn_version

|Property|Value|
|---|---|
|Description|**Version**|
|DisplayName|**Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_version`|
|RequiredLevel|None|
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

- [lk_msdyn_forecastinsight_createdby](#BKMK_lk_msdyn_forecastinsight_createdby)
- [lk_msdyn_forecastinsight_createdonbehalfby](#BKMK_lk_msdyn_forecastinsight_createdonbehalfby)
- [lk_msdyn_forecastinsight_modifiedby](#BKMK_lk_msdyn_forecastinsight_modifiedby)
- [lk_msdyn_forecastinsight_modifiedonbehalfby](#BKMK_lk_msdyn_forecastinsight_modifiedonbehalfby)
- [msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid)
- [msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid](#BKMK_msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid)

### <a name="BKMK_lk_msdyn_forecastinsight_createdby"></a> lk_msdyn_forecastinsight_createdby

One-To-Many Relationship: [systemuser lk_msdyn_forecastinsight_createdby](systemuser.md#BKMK_lk_msdyn_forecastinsight_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastinsight_createdonbehalfby"></a> lk_msdyn_forecastinsight_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastinsight_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastinsight_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastinsight_modifiedby"></a> lk_msdyn_forecastinsight_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_forecastinsight_modifiedby](systemuser.md#BKMK_lk_msdyn_forecastinsight_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastinsight_modifiedonbehalfby"></a> lk_msdyn_forecastinsight_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastinsight_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastinsight_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid

One-To-Many Relationship: [msdyn_forecastconfiguration msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid](msdyn_forecastconfiguration.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastconfiguration`|
|ReferencedAttribute|`msdyn_forecastconfigurationid`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastconfigurationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid"></a> msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid

One-To-Many Relationship: [msdyn_recurrence msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid](msdyn_recurrence.md#BKMK_msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_recurrence`|
|ReferencedAttribute|`msdyn_recurrenceid`|
|ReferencingAttribute|`msdyn_forecastrecurrenceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastrecurrenceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

