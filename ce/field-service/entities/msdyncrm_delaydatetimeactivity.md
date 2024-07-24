---
title: "Delay (date and time) Activity (msdyncrm_delaydatetimeactivity) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Delay (date and time) Activity (msdyncrm_delaydatetimeactivity) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Delay (date and time) Activity (msdyncrm_delaydatetimeactivity) table/entity reference



## Messages

The following table lists the messages for the Delay (date and time) Activity (msdyncrm_delaydatetimeactivity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyncrm_delaydatetimeactivities<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_delaydatetimeactivities(*msdyncrm_delaydatetimeactivityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_delaydatetimeactivities(*msdyncrm_delaydatetimeactivityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_delaydatetimeactivities<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_delaydatetimeactivities(*msdyncrm_delaydatetimeactivityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_delaydatetimeactivities(*msdyncrm_delaydatetimeactivityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_delaydatetimeactivities(*msdyncrm_delaydatetimeactivityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Delay (date and time) Activity (msdyncrm_delaydatetimeactivity) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Delay (date and time) Activity (msdyncrm_delaydatetimeactivity) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Delay (date and time) Activity** |
| **DisplayCollectionName** | **Delay (date and time) activities** |
| **SchemaName** | `msdyncrm_delaydatetimeactivity` |
| **CollectionSchemaName** | `msdyncrm_delaydatetimeactivities` |
| **EntitySetName** | `msdyncrm_delaydatetimeactivities`|
| **LogicalName** | `msdyncrm_delaydatetimeactivity` |
| **LogicalCollectionName** | `msdyncrm_delaydatetimeactivities` |
| **PrimaryIdAttribute** | `msdyncrm_delaydatetimeactivityid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_automateschedule](#BKMK_msdyncrm_automateschedule)
- [msdyncrm_datetime](#BKMK_msdyncrm_datetime)
- [msdyncrm_delaydatetimeactivityId](#BKMK_msdyncrm_delaydatetimeactivityId)
- [msdyncrm_description](#BKMK_msdyncrm_description)
- [msdyncrm_expiration](#BKMK_msdyncrm_expiration)
- [msdyncrm_expirationdate](#BKMK_msdyncrm_expirationdate)
- [msdyncrm_insightsdata](#BKMK_msdyncrm_insightsdata)
- [msdyncrm_manualschedulerdisabled](#BKMK_msdyncrm_manualschedulerdisabled)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_permitteddays](#BKMK_msdyncrm_permitteddays)
- [msdyncrm_permittedtimeend](#BKMK_msdyncrm_permittedtimeend)
- [msdyncrm_permittedtimestart](#BKMK_msdyncrm_permittedtimestart)
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

### <a name="BKMK_msdyncrm_automateschedule"></a> msdyncrm_automateschedule

|Property|Value|
|---|---|
|Description||
|DisplayName|**Automate schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_automateschedule`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_delaydatetimeactivity_msdyncrm_automateschedule`|
|DefaultValue|False|
|True Label|Automated scheduling enabled|
|False Label|Automated scheduling disabled|

### <a name="BKMK_msdyncrm_datetime"></a> msdyncrm_datetime

|Property|Value|
|---|---|
|Description||
|DisplayName|**datetime2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_datetime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_delaydatetimeactivityId"></a> msdyncrm_delaydatetimeactivityId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Delay (date and time) activity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_delaydatetimeactivityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_description"></a> msdyncrm_description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_expiration"></a> msdyncrm_expiration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Automate schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_expiration`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_delaydatetimeactivity_msdyncrm_expiration`|
|DefaultValue|False|
|True Label|Scheduler expiration enabled|
|False Label|Scheduler expiration disabled|

### <a name="BKMK_msdyncrm_expirationdate"></a> msdyncrm_expirationdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Expiration date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_expirationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_insightsdata"></a> msdyncrm_insightsdata

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_insightsdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_manualschedulerdisabled"></a> msdyncrm_manualschedulerdisabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Manual schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_manualschedulerdisabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_delaydatetimeactivity_msdyncrm_manualschedulerdisabled`|
|DefaultValue|False|
|True Label|Manual scheduler enabled|
|False Label|Manual scheduler disabled|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_permitteddays"></a> msdyncrm_permitteddays

|Property|Value|
|---|---|
|Description||
|DisplayName|**Permitted Days**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_permitteddays`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_days`|

#### msdyncrm_permitteddays Choices/Options

|Value|Label|
|---|---|
|192350000|**Monday**|
|192350001|**Tuesday**|
|192350002|**Wednesday**|
|192350003|**Thursday**|
|192350004|**Friday**|
|192350005|**Saturday**|
|192350006|**Sunday**|

### <a name="BKMK_msdyncrm_permittedtimeend"></a> msdyncrm_permittedtimeend

|Property|Value|
|---|---|
|Description||
|DisplayName|**Permitted hours: end**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_permittedtimeend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_permittedtimestart"></a> msdyncrm_permittedtimestart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Permitted hours: start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_permittedtimestart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Delay (date and time) activity**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_delaydatetimeactivity_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Delay (date and time) activity**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_delaydatetimeactivity_statuscode`|

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

- [lk_msdyncrm_delaydatetimeactivity_createdby](#BKMK_lk_msdyncrm_delaydatetimeactivity_createdby)
- [lk_msdyncrm_delaydatetimeactivity_createdonbehalfby](#BKMK_lk_msdyncrm_delaydatetimeactivity_createdonbehalfby)
- [lk_msdyncrm_delaydatetimeactivity_modifiedby](#BKMK_lk_msdyncrm_delaydatetimeactivity_modifiedby)
- [lk_msdyncrm_delaydatetimeactivity_modifiedonbehalfby](#BKMK_lk_msdyncrm_delaydatetimeactivity_modifiedonbehalfby)
- [organization_msdyncrm_delaydatetimeactivity](#BKMK_organization_msdyncrm_delaydatetimeactivity)

### <a name="BKMK_lk_msdyncrm_delaydatetimeactivity_createdby"></a> lk_msdyncrm_delaydatetimeactivity_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_delaydatetimeactivity_createdby](systemuser.md#BKMK_lk_msdyncrm_delaydatetimeactivity_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_delaydatetimeactivity_createdonbehalfby"></a> lk_msdyncrm_delaydatetimeactivity_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_delaydatetimeactivity_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_delaydatetimeactivity_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_delaydatetimeactivity_modifiedby"></a> lk_msdyncrm_delaydatetimeactivity_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_delaydatetimeactivity_modifiedby](systemuser.md#BKMK_lk_msdyncrm_delaydatetimeactivity_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_delaydatetimeactivity_modifiedonbehalfby"></a> lk_msdyncrm_delaydatetimeactivity_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_delaydatetimeactivity_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_delaydatetimeactivity_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyncrm_delaydatetimeactivity"></a> organization_msdyncrm_delaydatetimeactivity

One-To-Many Relationship: [organization organization_msdyncrm_delaydatetimeactivity](organization.md#BKMK_organization_msdyncrm_delaydatetimeactivity)

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

- [msdyncrm_delaydatetimeactivity_AsyncOperations](#BKMK_msdyncrm_delaydatetimeactivity_AsyncOperations)
- [msdyncrm_delaydatetimeactivity_BulkDeleteFailures](#BKMK_msdyncrm_delaydatetimeactivity_BulkDeleteFailures)
- [msdyncrm_delaydatetimeactivity_MailboxTrackingFolders](#BKMK_msdyncrm_delaydatetimeactivity_MailboxTrackingFolders)
- [msdyncrm_delaydatetimeactivity_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_delaydatetimeactivity_PrincipalObjectAttributeAccesses)
- [msdyncrm_delaydatetimeactivity_ProcessSession](#BKMK_msdyncrm_delaydatetimeactivity_ProcessSession)
- [msdyncrm_delaydatetimeactivity_SyncErrors](#BKMK_msdyncrm_delaydatetimeactivity_SyncErrors)

### <a name="BKMK_msdyncrm_delaydatetimeactivity_AsyncOperations"></a> msdyncrm_delaydatetimeactivity_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_delaydatetimeactivity_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_delaydatetimeactivity_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_delaydatetimeactivity_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_delaydatetimeactivity_BulkDeleteFailures"></a> msdyncrm_delaydatetimeactivity_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_delaydatetimeactivity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_delaydatetimeactivity_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_delaydatetimeactivity_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_delaydatetimeactivity_MailboxTrackingFolders"></a> msdyncrm_delaydatetimeactivity_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_delaydatetimeactivity_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_delaydatetimeactivity_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_delaydatetimeactivity_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_delaydatetimeactivity_PrincipalObjectAttributeAccesses"></a> msdyncrm_delaydatetimeactivity_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_delaydatetimeactivity_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_delaydatetimeactivity_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_delaydatetimeactivity_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_delaydatetimeactivity_ProcessSession"></a> msdyncrm_delaydatetimeactivity_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_delaydatetimeactivity_ProcessSession](processsession.md#BKMK_msdyncrm_delaydatetimeactivity_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_delaydatetimeactivity_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_delaydatetimeactivity_SyncErrors"></a> msdyncrm_delaydatetimeactivity_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_delaydatetimeactivity_SyncErrors](syncerror.md#BKMK_msdyncrm_delaydatetimeactivity_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_delaydatetimeactivity_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

