---
title: "SARunInstance (msdyn_saruninstance) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the SARunInstance (msdyn_saruninstance) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# SARunInstance (msdyn_saruninstance) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the SARunInstance (msdyn_saruninstance) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_saruninstances<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_saruninstances(*msdyn_saruninstanceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_saruninstances(*msdyn_saruninstanceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_saruninstances<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_saruninstances(*msdyn_saruninstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_saruninstances(*msdyn_saruninstanceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_saruninstances(*msdyn_saruninstanceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the SARunInstance (msdyn_saruninstance) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **SARunInstance** |
| **DisplayCollectionName** | **SARunInstances** |
| **SchemaName** | `msdyn_saruninstance` |
| **CollectionSchemaName** | `msdyn_saruninstances` |
| **EntitySetName** | `msdyn_saruninstances`|
| **LogicalName** | `msdyn_saruninstance` |
| **LogicalCollectionName** | `msdyn_saruninstances` |
| **PrimaryIdAttribute** | `msdyn_saruninstanceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Endtime](#BKMK_msdyn_Endtime)
- [msdyn_entityname](#BKMK_msdyn_entityname)
- [msdyn_InstanceType](#BKMK_msdyn_InstanceType)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_recordids](#BKMK_msdyn_recordids)
- [msdyn_RecordsFailedCount](#BKMK_msdyn_RecordsFailedCount)
- [msdyn_RecordsSuccededCount](#BKMK_msdyn_RecordsSuccededCount)
- [msdyn_saruninstanceId](#BKMK_msdyn_saruninstanceId)
- [msdyn_SegmentId](#BKMK_msdyn_SegmentId)
- [msdyn_StartTime](#BKMK_msdyn_StartTime)
- [msdyn_TotalRecords](#BKMK_msdyn_TotalRecords)
- [msdyn_TriggerType](#BKMK_msdyn_TriggerType)
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

### <a name="BKMK_msdyn_Endtime"></a> msdyn_Endtime

|Property|Value|
|---|---|
|Description||
|DisplayName|**End time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_entityname"></a> msdyn_entityname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity logical name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_InstanceType"></a> msdyn_InstanceType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Instance type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_instancetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_saruninstance_msdyn_instancetype`|

#### msdyn_InstanceType Choices/Options

|Value|Label|
|---|---|
|0|**Reassignment**|
|1|**ForceRoute**|

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

### <a name="BKMK_msdyn_recordids"></a> msdyn_recordids

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record ids to process**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordids`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_RecordsFailedCount"></a> msdyn_RecordsFailedCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Records failed count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordsfailedcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_RecordsSuccededCount"></a> msdyn_RecordsSuccededCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Records succeded count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordssuccededcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_saruninstanceId"></a> msdyn_saruninstanceId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**SARunInstance**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_saruninstanceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SegmentId"></a> msdyn_SegmentId

|Property|Value|
|---|---|
|Description|**Unique identifier for Segment associated with SARunInstance.**|
|DisplayName|**Segment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_segment|

### <a name="BKMK_msdyn_StartTime"></a> msdyn_StartTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_starttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TotalRecords"></a> msdyn_TotalRecords

|Property|Value|
|---|---|
|Description||
|DisplayName|**Total records**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalrecords`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_TriggerType"></a> msdyn_TriggerType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Trigger type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_triggertype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_saruninstance_msdyn_triggertype`|

#### msdyn_TriggerType Choices/Options

|Value|Label|
|---|---|
|0|**Manual**|
|1|**Scheduled**|

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
|Description|**Status of the SARunInstance**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_saruninstance_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 0<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the SARunInstance**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_saruninstance_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|0|Label: **In Progress**<br />State:0<br />TransitionData: None|
|1|Label: **Succeeded**<br />State:1<br />TransitionData: None|
|2|Label: **Failed**<br />State:1<br />TransitionData: None|
|3|Label: **Skipped**<br />State:1<br />TransitionData: None|
|4|Label: **Queued**<br />State:0<br />TransitionData: None|

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

- [lk_msdyn_saruninstance_createdby](#BKMK_lk_msdyn_saruninstance_createdby)
- [lk_msdyn_saruninstance_createdonbehalfby](#BKMK_lk_msdyn_saruninstance_createdonbehalfby)
- [lk_msdyn_saruninstance_modifiedby](#BKMK_lk_msdyn_saruninstance_modifiedby)
- [lk_msdyn_saruninstance_modifiedonbehalfby](#BKMK_lk_msdyn_saruninstance_modifiedonbehalfby)
- [msdyn_msdyn_segment_msdyn_saruninstance](#BKMK_msdyn_msdyn_segment_msdyn_saruninstance)
- [organization_msdyn_saruninstance](#BKMK_organization_msdyn_saruninstance)

### <a name="BKMK_lk_msdyn_saruninstance_createdby"></a> lk_msdyn_saruninstance_createdby

One-To-Many Relationship: [systemuser lk_msdyn_saruninstance_createdby](systemuser.md#BKMK_lk_msdyn_saruninstance_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_saruninstance_createdonbehalfby"></a> lk_msdyn_saruninstance_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_saruninstance_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_saruninstance_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_saruninstance_modifiedby"></a> lk_msdyn_saruninstance_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_saruninstance_modifiedby](systemuser.md#BKMK_lk_msdyn_saruninstance_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_saruninstance_modifiedonbehalfby"></a> lk_msdyn_saruninstance_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_saruninstance_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_saruninstance_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_segment_msdyn_saruninstance"></a> msdyn_msdyn_segment_msdyn_saruninstance

One-To-Many Relationship: [msdyn_segment msdyn_msdyn_segment_msdyn_saruninstance](msdyn_segment.md#BKMK_msdyn_msdyn_segment_msdyn_saruninstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_segment`|
|ReferencedAttribute|`msdyn_segmentid`|
|ReferencingAttribute|`msdyn_segmentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_SegmentId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_organization_msdyn_saruninstance"></a> organization_msdyn_saruninstance

One-To-Many Relationship: [organization organization_msdyn_saruninstance](organization.md#BKMK_organization_msdyn_saruninstance)

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

- [msdyn_msdyn_saruninstance_msdyn_sabatchinstance](#BKMK_msdyn_msdyn_saruninstance_msdyn_sabatchinstance)
- [msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid](#BKMK_msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid)
- [msdyn_saruninstance_AsyncOperations](#BKMK_msdyn_saruninstance_AsyncOperations)
- [msdyn_saruninstance_BulkDeleteFailures](#BKMK_msdyn_saruninstance_BulkDeleteFailures)
- [msdyn_saruninstance_DuplicateBaseRecord](#BKMK_msdyn_saruninstance_DuplicateBaseRecord)
- [msdyn_saruninstance_DuplicateMatchingRecord](#BKMK_msdyn_saruninstance_DuplicateMatchingRecord)
- [msdyn_saruninstance_MailboxTrackingFolders](#BKMK_msdyn_saruninstance_MailboxTrackingFolders)
- [msdyn_saruninstance_PrincipalObjectAttributeAccesses](#BKMK_msdyn_saruninstance_PrincipalObjectAttributeAccesses)
- [msdyn_saruninstance_ProcessSession](#BKMK_msdyn_saruninstance_ProcessSession)
- [msdyn_saruninstance_SyncErrors](#BKMK_msdyn_saruninstance_SyncErrors)

### <a name="BKMK_msdyn_msdyn_saruninstance_msdyn_sabatchinstance"></a> msdyn_msdyn_saruninstance_msdyn_sabatchinstance

Many-To-One Relationship: [msdyn_sabatchruninstance msdyn_msdyn_saruninstance_msdyn_sabatchinstance](msdyn_sabatchruninstance.md#BKMK_msdyn_msdyn_saruninstance_msdyn_sabatchinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sabatchruninstance`|
|ReferencingAttribute|`msdyn_saruninstanceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_saruninstance_msdyn_sabatchinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid"></a> msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid](msdyn_salesroutingrun.md#BKMK_msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_saruninstanceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_saruninstance_AsyncOperations"></a> msdyn_saruninstance_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_saruninstance_AsyncOperations](asyncoperation.md#BKMK_msdyn_saruninstance_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_saruninstance_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_saruninstance_BulkDeleteFailures"></a> msdyn_saruninstance_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_saruninstance_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_saruninstance_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_saruninstance_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_saruninstance_DuplicateBaseRecord"></a> msdyn_saruninstance_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_saruninstance_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_saruninstance_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_saruninstance_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_saruninstance_DuplicateMatchingRecord"></a> msdyn_saruninstance_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_saruninstance_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_saruninstance_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_saruninstance_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_saruninstance_MailboxTrackingFolders"></a> msdyn_saruninstance_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_saruninstance_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_saruninstance_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_saruninstance_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_saruninstance_PrincipalObjectAttributeAccesses"></a> msdyn_saruninstance_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_saruninstance_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_saruninstance_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_saruninstance_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_saruninstance_ProcessSession"></a> msdyn_saruninstance_ProcessSession

Many-To-One Relationship: [processsession msdyn_saruninstance_ProcessSession](processsession.md#BKMK_msdyn_saruninstance_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_saruninstance_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_saruninstance_SyncErrors"></a> msdyn_saruninstance_SyncErrors

Many-To-One Relationship: [syncerror msdyn_saruninstance_SyncErrors](syncerror.md#BKMK_msdyn_saruninstance_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_saruninstance_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

