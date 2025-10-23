---
title: "Forecast Summary and Setting (msdyn_forecastsettingsandsummary) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast Summary and Setting (msdyn_forecastsettingsandsummary) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast Summary and Setting (msdyn_forecastsettingsandsummary) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Forecast Summary and Setting (msdyn_forecastsettingsandsummary) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_forecastsettingsandsummaries<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_forecastsettingsandsummaries(*msdyn_forecastsettingsandsummaryid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_forecastsettingsandsummaries(*msdyn_forecastsettingsandsummaryid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_forecastsettingsandsummaries<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_forecastsettingsandsummaries(*msdyn_forecastsettingsandsummaryid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_forecastsettingsandsummaries(*msdyn_forecastsettingsandsummaryid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_forecastsettingsandsummaries(*msdyn_forecastsettingsandsummaryid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast Summary and Setting (msdyn_forecastsettingsandsummary) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast Summary and Setting** |
| **DisplayCollectionName** | **Forecast Summary and Setting** |
| **SchemaName** | `msdyn_forecastsettingsandsummary` |
| **CollectionSchemaName** | `msdyn_forecastsettingsandsummaries` |
| **EntitySetName** | `msdyn_forecastsettingsandsummaries`|
| **LogicalName** | `msdyn_forecastsettingsandsummary` |
| **LogicalCollectionName** | `msdyn_forecastsettingsandsummaries` |
| **PrimaryIdAttribute** | `msdyn_forecastsettingsandsummaryid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_datainsightsandanalyticsfeatureid](#BKMK_msdyn_datainsightsandanalyticsfeatureid)
- [msdyn_forecastjobstatus](#BKMK_msdyn_forecastjobstatus)
- [msdyn_forecastlastrun](#BKMK_msdyn_forecastlastrun)
- [msdyn_forecastsettingsandsummaryId](#BKMK_msdyn_forecastsettingsandsummaryId)
- [msdyn_historicalstartdate](#BKMK_msdyn_historicalstartdate)
- [msdyn_holidaycalendarenabled](#BKMK_msdyn_holidaycalendarenabled)
- [msdyn_name](#BKMK_msdyn_name)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeatureid"></a> msdyn_datainsightsandanalyticsfeatureid

|Property|Value|
|---|---|
|Description|**Look up field to feature entity**|
|DisplayName|**Data Insights And Analytics Feature Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datainsightsandanalyticsfeatureid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_datainsightsandanalyticsfeature|

### <a name="BKMK_msdyn_forecastjobstatus"></a> msdyn_forecastjobstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Forecast Job Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastjobstatus`|
|RequiredLevel|ApplicationRequired|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastsettingsandsummary_msdyn_forecastjobstatus`|

#### msdyn_forecastjobstatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Success**|
|192350001|**Data Failure**|
|192350002|**Pipeline Failure**|

### <a name="BKMK_msdyn_forecastlastrun"></a> msdyn_forecastlastrun

|Property|Value|
|---|---|
|Description||
|DisplayName|**Forecast Last Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastlastrun`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_forecastsettingsandsummaryId"></a> msdyn_forecastsettingsandsummaryId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Forecast Summary and Setting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastsettingsandsummaryid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_historicalstartdate"></a> msdyn_historicalstartdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Historical Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_historicalstartdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_holidaycalendarenabled"></a> msdyn_holidaycalendarenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Holiday Calendar Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_holidaycalendarenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_forecastsettingsandsummary_msdyn_holidaycalendarenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|Description|**Status of the Forecast Summary and Setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastsettingsandsummary_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Forecast Summary and Setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastsettingsandsummary_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [lk_msdyn_forecastsettingsandsummary_createdby](#BKMK_lk_msdyn_forecastsettingsandsummary_createdby)
- [lk_msdyn_forecastsettingsandsummary_createdonbehalfby](#BKMK_lk_msdyn_forecastsettingsandsummary_createdonbehalfby)
- [lk_msdyn_forecastsettingsandsummary_modifiedby](#BKMK_lk_msdyn_forecastsettingsandsummary_modifiedby)
- [lk_msdyn_forecastsettingsandsummary_modifiedonbehalfby](#BKMK_lk_msdyn_forecastsettingsandsummary_modifiedonbehalfby)
- [msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid](#BKMK_msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid)
- [organization_msdyn_forecastsettingsandsummary](#BKMK_organization_msdyn_forecastsettingsandsummary)

### <a name="BKMK_lk_msdyn_forecastsettingsandsummary_createdby"></a> lk_msdyn_forecastsettingsandsummary_createdby

One-To-Many Relationship: [systemuser lk_msdyn_forecastsettingsandsummary_createdby](systemuser.md#BKMK_lk_msdyn_forecastsettingsandsummary_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastsettingsandsummary_createdonbehalfby"></a> lk_msdyn_forecastsettingsandsummary_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastsettingsandsummary_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastsettingsandsummary_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastsettingsandsummary_modifiedby"></a> lk_msdyn_forecastsettingsandsummary_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_forecastsettingsandsummary_modifiedby](systemuser.md#BKMK_lk_msdyn_forecastsettingsandsummary_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastsettingsandsummary_modifiedonbehalfby"></a> lk_msdyn_forecastsettingsandsummary_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastsettingsandsummary_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastsettingsandsummary_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid"></a> msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid

One-To-Many Relationship: [msdyn_datainsightsandanalyticsfeature msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid](msdyn_datainsightsandanalyticsfeature.md#BKMK_msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_datainsightsandanalyticsfeature`|
|ReferencedAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencingEntityNavigationPropertyName|`msdyn_datainsightsandanalyticsfeatureid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_forecastsettingsandsummary"></a> organization_msdyn_forecastsettingsandsummary

One-To-Many Relationship: [organization organization_msdyn_forecastsettingsandsummary](organization.md#BKMK_organization_msdyn_forecastsettingsandsummary)

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

- [msdyn_forecastsettingsandsummary_AsyncOperations](#BKMK_msdyn_forecastsettingsandsummary_AsyncOperations)
- [msdyn_forecastsettingsandsummary_BulkDeleteFailures](#BKMK_msdyn_forecastsettingsandsummary_BulkDeleteFailures)
- [msdyn_forecastsettingsandsummary_DuplicateBaseRecord](#BKMK_msdyn_forecastsettingsandsummary_DuplicateBaseRecord)
- [msdyn_forecastsettingsandsummary_DuplicateMatchingRecord](#BKMK_msdyn_forecastsettingsandsummary_DuplicateMatchingRecord)
- [msdyn_forecastsettingsandsummary_MailboxTrackingFolders](#BKMK_msdyn_forecastsettingsandsummary_MailboxTrackingFolders)
- [msdyn_forecastsettingsandsummary_PrincipalObjectAttributeAccesses](#BKMK_msdyn_forecastsettingsandsummary_PrincipalObjectAttributeAccesses)
- [msdyn_forecastsettingsandsummary_ProcessSession](#BKMK_msdyn_forecastsettingsandsummary_ProcessSession)
- [msdyn_forecastsettingsandsummary_SyncErrors](#BKMK_msdyn_forecastsettingsandsummary_SyncErrors)

### <a name="BKMK_msdyn_forecastsettingsandsummary_AsyncOperations"></a> msdyn_forecastsettingsandsummary_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_forecastsettingsandsummary_AsyncOperations](asyncoperation.md#BKMK_msdyn_forecastsettingsandsummary_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastsettingsandsummary_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastsettingsandsummary_BulkDeleteFailures"></a> msdyn_forecastsettingsandsummary_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_forecastsettingsandsummary_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_forecastsettingsandsummary_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastsettingsandsummary_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastsettingsandsummary_DuplicateBaseRecord"></a> msdyn_forecastsettingsandsummary_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastsettingsandsummary_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_forecastsettingsandsummary_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastsettingsandsummary_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastsettingsandsummary_DuplicateMatchingRecord"></a> msdyn_forecastsettingsandsummary_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastsettingsandsummary_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_forecastsettingsandsummary_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastsettingsandsummary_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastsettingsandsummary_MailboxTrackingFolders"></a> msdyn_forecastsettingsandsummary_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_forecastsettingsandsummary_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_forecastsettingsandsummary_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastsettingsandsummary_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastsettingsandsummary_PrincipalObjectAttributeAccesses"></a> msdyn_forecastsettingsandsummary_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_forecastsettingsandsummary_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_forecastsettingsandsummary_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastsettingsandsummary_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastsettingsandsummary_ProcessSession"></a> msdyn_forecastsettingsandsummary_ProcessSession

Many-To-One Relationship: [processsession msdyn_forecastsettingsandsummary_ProcessSession](processsession.md#BKMK_msdyn_forecastsettingsandsummary_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastsettingsandsummary_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastsettingsandsummary_SyncErrors"></a> msdyn_forecastsettingsandsummary_SyncErrors

Many-To-One Relationship: [syncerror msdyn_forecastsettingsandsummary_SyncErrors](syncerror.md#BKMK_msdyn_forecastsettingsandsummary_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastsettingsandsummary_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

