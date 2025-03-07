---
title: "Forecast Recurrence (msdyn_recurrence) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast Recurrence (msdyn_recurrence) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast Recurrence (msdyn_recurrence) table/entity reference (Microsoft Dynamics 365)

Forecast Recurrence

## Messages

The following table lists the messages for the Forecast Recurrence (msdyn_recurrence) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_recurrences<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_recurrences(*msdyn_recurrenceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_recurrences(*msdyn_recurrenceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_recurrences<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_recurrences(*msdyn_recurrenceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_recurrences(*msdyn_recurrenceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast Recurrence (msdyn_recurrence) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast Recurrence** |
| **DisplayCollectionName** | **Forecast Recurrences** |
| **SchemaName** | `msdyn_recurrence` |
| **CollectionSchemaName** | `msdyn_recurrences` |
| **EntitySetName** | `msdyn_recurrences`|
| **LogicalName** | `msdyn_recurrence` |
| **LogicalCollectionName** | `msdyn_recurrences` |
| **PrimaryIdAttribute** | `msdyn_recurrenceid` |
| **PrimaryNameAttribute** |`msdyn_forecastrecurrencename` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_forecastconfigurationid](#BKMK_msdyn_forecastconfigurationid)
- [msdyn_forecastrecurrencename](#BKMK_msdyn_forecastrecurrencename)
- [msdyn_lastcomputedon](#BKMK_msdyn_lastcomputedon)
- [msdyn_recomputationstarttime](#BKMK_msdyn_recomputationstarttime)
- [msdyn_recomputeexecutorid](#BKMK_msdyn_recomputeexecutorid)
- [msdyn_recomputepriority](#BKMK_msdyn_recomputepriority)
- [msdyn_recomputestatus](#BKMK_msdyn_recomputestatus)
- [msdyn_recomputestatuschangedon](#BKMK_msdyn_recomputestatuschangedon)
- [msdyn_recurrencefailureinfo](#BKMK_msdyn_recurrencefailureinfo)
- [msdyn_recurrenceId](#BKMK_msdyn_recurrenceId)
- [msdyn_recurrenceindex](#BKMK_msdyn_recurrenceindex)
- [msdyn_recurrencestate](#BKMK_msdyn_recurrencestate)
- [msdyn_validfrom](#BKMK_msdyn_validfrom)
- [msdyn_validto](#BKMK_msdyn_validto)
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
|Description||
|DisplayName|**msdyn_forecastconfigurationid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastconfigurationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_forecastconfiguration|

### <a name="BKMK_msdyn_forecastrecurrencename"></a> msdyn_forecastrecurrencename

|Property|Value|
|---|---|
|Description|**Recurrence Name**|
|DisplayName|**Recurrence Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastrecurrencename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_lastcomputedon"></a> msdyn_lastcomputedon

|Property|Value|
|---|---|
|Description|**Date and time on which last compute was run**|
|DisplayName|**Last computed on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastcomputedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_recomputationstarttime"></a> msdyn_recomputationstarttime

|Property|Value|
|---|---|
|Description|**Date and time on which recompute started**|
|DisplayName|**Recomputation Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recomputationstarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_recomputeexecutorid"></a> msdyn_recomputeexecutorid

|Property|Value|
|---|---|
|Description|**Recurrence Executor Id**|
|DisplayName|**Recurrence Executor Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recomputeexecutorid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_recomputepriority"></a> msdyn_recomputepriority

|Property|Value|
|---|---|
|Description|**Recompute Priority**|
|DisplayName|**Recompute Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recomputepriority`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_forecastrecurrence_recomputepriority`|

#### msdyn_recomputepriority Choices/Options

|Value|Label|
|---|---|
|0|**Normal**|
|1|**High**|

### <a name="BKMK_msdyn_recomputestatus"></a> msdyn_recomputestatus

|Property|Value|
|---|---|
|Description|**Recompute Status**|
|DisplayName|**Recompute Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recomputestatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_forecastrecurrence_recomputestatus`|

#### msdyn_recomputestatus Choices/Options

|Value|Label|
|---|---|
|0|**New**|
|10|**Queued**|
|20|**InProgress**|
|30|**Completed**|
|40|**Failed**|

### <a name="BKMK_msdyn_recomputestatuschangedon"></a> msdyn_recomputestatuschangedon

|Property|Value|
|---|---|
|Description|**Date and time on which recompute status was changed**|
|DisplayName|**Recompute status changed on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recomputestatuschangedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_recurrencefailureinfo"></a> msdyn_recurrencefailureinfo

|Property|Value|
|---|---|
|Description|**Recurrence Failure Info**|
|DisplayName|**Recurrence Failure Info**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrencefailureinfo`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_recurrenceId"></a> msdyn_recurrenceId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Forecast Recurrence**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrenceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_recurrenceindex"></a> msdyn_recurrenceindex

|Property|Value|
|---|---|
|Description|**Recurrence Index**|
|DisplayName|**Recurrence Index**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrenceindex`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_recurrencestate"></a> msdyn_recurrencestate

|Property|Value|
|---|---|
|Description|**Forecast Recurrence State**|
|DisplayName|**Forecast Recurrence State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrencestate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_forecastrecurrence_recurrencestate`|

#### msdyn_recurrencestate Choices/Options

|Value|Label|
|---|---|
|0|**Active**|
|1|**Inactive**|

### <a name="BKMK_msdyn_validfrom"></a> msdyn_validfrom

|Property|Value|
|---|---|
|Description|**Date from which recurrence is valid**|
|DisplayName|**Valid From**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validfrom`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_validto"></a> msdyn_validto

|Property|Value|
|---|---|
|Description|**Date till which recurrence is valid**|
|DisplayName|**Valid To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validto`|
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

- [lk_msdyn_recurrence_createdby](#BKMK_lk_msdyn_recurrence_createdby)
- [lk_msdyn_recurrence_createdonbehalfby](#BKMK_lk_msdyn_recurrence_createdonbehalfby)
- [lk_msdyn_recurrence_modifiedby](#BKMK_lk_msdyn_recurrence_modifiedby)
- [lk_msdyn_recurrence_modifiedonbehalfby](#BKMK_lk_msdyn_recurrence_modifiedonbehalfby)
- [msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid)

### <a name="BKMK_lk_msdyn_recurrence_createdby"></a> lk_msdyn_recurrence_createdby

One-To-Many Relationship: [systemuser lk_msdyn_recurrence_createdby](systemuser.md#BKMK_lk_msdyn_recurrence_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_recurrence_createdonbehalfby"></a> lk_msdyn_recurrence_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_recurrence_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_recurrence_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_recurrence_modifiedby"></a> lk_msdyn_recurrence_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_recurrence_modifiedby](systemuser.md#BKMK_lk_msdyn_recurrence_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_recurrence_modifiedonbehalfby"></a> lk_msdyn_recurrence_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_recurrence_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_recurrence_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid

One-To-Many Relationship: [msdyn_forecastconfiguration msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid](msdyn_forecastconfiguration.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastconfiguration`|
|ReferencedAttribute|`msdyn_forecastconfigurationid`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastconfigurationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid](#BKMK_msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid)
- [msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid](#BKMK_msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid)
- [msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid](#BKMK_msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid)

### <a name="BKMK_msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid"></a> msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid

Many-To-One Relationship: [msdyn_forecast msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid](msdyn_forecast.md#BKMK_msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecast`|
|ReferencingAttribute|`msdyn_forecastrecurrenceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_recurrence_msdyn_forecast_forecastrecurrenceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid"></a> msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid

Many-To-One Relationship: [msdyn_forecastinsight msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid](msdyn_forecastinsight.md#BKMK_msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinsight`|
|ReferencingAttribute|`msdyn_forecastrecurrenceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_recurrence_msdyn_forecastinsight_forecastrecurrenceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid"></a> msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid

Many-To-One Relationship: [msdyn_forecastpredictiondata msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid](msdyn_forecastpredictiondata.md#BKMK_msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastpredictiondata`|
|ReferencingAttribute|`msdyn_forecastrecurrenceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_recurrence_msdyn_forecastpredictiondata_forecastrecurrenceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

