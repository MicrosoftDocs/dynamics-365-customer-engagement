---
title: "Webinar Type (msevtmgt_WebinarType) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Webinar Type (msevtmgt_WebinarType) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Webinar Type (msevtmgt_WebinarType) table/entity reference

Types of webinars from the On24 API

## Messages

The following table lists the messages for the Webinar Type (msevtmgt_WebinarType) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msevtmgt_webinartypes<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_webinartypes(*msevtmgt_webinartypeid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_webinartypes(*msevtmgt_webinartypeid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_webinartypes<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_webinartypes(*msevtmgt_webinartypeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_webinartypes(*msevtmgt_webinartypeid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_webinartypes(*msevtmgt_webinartypeid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Webinar Type (msevtmgt_WebinarType) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Webinar Type (msevtmgt_WebinarType) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Webinar Type** |
| **DisplayCollectionName** | **Webinar Types** |
| **SchemaName** | `msevtmgt_WebinarType` |
| **CollectionSchemaName** | `msevtmgt_WebinarTypes` |
| **EntitySetName** | `msevtmgt_webinartypes`|
| **LogicalName** | `msevtmgt_webinartype` |
| **LogicalCollectionName** | `msevtmgt_webinartypes` |
| **PrimaryIdAttribute** | `msevtmgt_webinartypeid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_Value](#BKMK_msevtmgt_Value)
- [msevtmgt_webinarconfiguration](#BKMK_msevtmgt_webinarconfiguration)
- [msevtmgt_WebinarProviderId](#BKMK_msevtmgt_WebinarProviderId)
- [msevtmgt_WebinarTypeId](#BKMK_msevtmgt_WebinarTypeId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**The sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Value"></a> msevtmgt_Value

|Property|Value|
|---|---|
|Description||
|DisplayName|**Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_value`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_webinarconfiguration"></a> msevtmgt_webinarconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_webinarconfiguration|

### <a name="BKMK_msevtmgt_WebinarProviderId"></a> msevtmgt_WebinarProviderId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarproviderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_webinarprovider|

### <a name="BKMK_msevtmgt_WebinarTypeId"></a> msevtmgt_WebinarTypeId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Webinar type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinartypeid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was migrated**|
|DisplayName|**Record created on**|
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
|Description|**Status of the webinar type**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_webinartype_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the webinar type**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_webinartype_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time zone rule version number**|
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
|Description|**The time zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time zone code**|
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
|Description|**Unique identifier of the user who created the record**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was created**|
|DisplayName|**Created on**|
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
|Description|**Unique identifier of the delegate user who created the record**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was modified**|
|DisplayName|**Modified on**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
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
|DisplayName|**Organization ID**|
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

- [lk_msevtmgt_webinartype_createdby](#BKMK_lk_msevtmgt_webinartype_createdby)
- [lk_msevtmgt_webinartype_createdonbehalfby](#BKMK_lk_msevtmgt_webinartype_createdonbehalfby)
- [lk_msevtmgt_webinartype_modifiedby](#BKMK_lk_msevtmgt_webinartype_modifiedby)
- [lk_msevtmgt_webinartype_modifiedonbehalfby](#BKMK_lk_msevtmgt_webinartype_modifiedonbehalfby)
- [msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration](#BKMK_msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration)
- [msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId](#BKMK_msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId)
- [organization_msevtmgt_webinartype](#BKMK_organization_msevtmgt_webinartype)

### <a name="BKMK_lk_msevtmgt_webinartype_createdby"></a> lk_msevtmgt_webinartype_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinartype_createdby](systemuser.md#BKMK_lk_msevtmgt_webinartype_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webinartype_createdonbehalfby"></a> lk_msevtmgt_webinartype_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinartype_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_webinartype_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webinartype_modifiedby"></a> lk_msevtmgt_webinartype_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinartype_modifiedby](systemuser.md#BKMK_lk_msevtmgt_webinartype_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webinartype_modifiedonbehalfby"></a> lk_msevtmgt_webinartype_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinartype_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_webinartype_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration"></a> msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`msevtmgt_webinarconfiguration`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_webinarconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId"></a> msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId](msevtmgt_webinarprovider.md#BKMK_msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`msevtmgt_webinarproviderid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_WebinarProviderId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msevtmgt_webinartype"></a> organization_msevtmgt_webinartype

One-To-Many Relationship: [organization organization_msevtmgt_webinartype](organization.md#BKMK_organization_msevtmgt_webinartype)

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

- [msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType](#BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType)
- [msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType](#BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType)
- [msevtmgt_webinartype_AsyncOperations](#BKMK_msevtmgt_webinartype_AsyncOperations)
- [msevtmgt_webinartype_BulkDeleteFailures](#BKMK_msevtmgt_webinartype_BulkDeleteFailures)
- [msevtmgt_webinartype_MailboxTrackingFolders](#BKMK_msevtmgt_webinartype_MailboxTrackingFolders)
- [msevtmgt_webinartype_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_webinartype_PrincipalObjectAttributeAccesses)
- [msevtmgt_webinartype_ProcessSession](#BKMK_msevtmgt_webinartype_ProcessSession)
- [msevtmgt_webinartype_SyncErrors](#BKMK_msevtmgt_webinartype_SyncErrors)

### <a name="BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType"></a> msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType

Many-To-One Relationship: [msevtmgt_event msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType](msevtmgt_event.md#BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`msevtmgt_webinartype`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType"></a> msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType

Many-To-One Relationship: [msevtmgt_session msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType](msevtmgt_session.md#BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`msevtmgt_webinartype`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinartype_AsyncOperations"></a> msevtmgt_webinartype_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_webinartype_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_webinartype_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinartype_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinartype_BulkDeleteFailures"></a> msevtmgt_webinartype_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_webinartype_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_webinartype_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinartype_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinartype_MailboxTrackingFolders"></a> msevtmgt_webinartype_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_webinartype_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_webinartype_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinartype_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinartype_PrincipalObjectAttributeAccesses"></a> msevtmgt_webinartype_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_webinartype_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_webinartype_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinartype_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinartype_ProcessSession"></a> msevtmgt_webinartype_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_webinartype_ProcessSession](processsession.md#BKMK_msevtmgt_webinartype_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinartype_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinartype_SyncErrors"></a> msevtmgt_webinartype_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_webinartype_SyncErrors](syncerror.md#BKMK_msevtmgt_webinartype_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinartype_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

