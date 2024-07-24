---
title: "Layout (msevtmgt_Layout) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Layout (msevtmgt_Layout) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Layout (msevtmgt_Layout) table/entity reference

The layout entity defines the various layouts that can be applied to each room, including the maximum capacity of each layout.

## Messages

The following table lists the messages for the Layout (msevtmgt_Layout) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_layouts(*msevtmgt_layoutid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_layouts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_layouts(*msevtmgt_layoutid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_layouts(*msevtmgt_layoutid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_layouts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_layouts(*msevtmgt_layoutid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_layouts(*msevtmgt_layoutid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_layouts(*msevtmgt_layoutid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Layout (msevtmgt_Layout) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Layout (msevtmgt_Layout) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Layout** |
| **DisplayCollectionName** | **Layouts** |
| **SchemaName** | `msevtmgt_Layout` |
| **CollectionSchemaName** | `msevtmgt_Layouts` |
| **EntitySetName** | `msevtmgt_layouts`|
| **LogicalName** | `msevtmgt_layout` |
| **LogicalCollectionName** | `msevtmgt_layouts` |
| **PrimaryIdAttribute** | `msevtmgt_layoutid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_Capacity](#BKMK_msevtmgt_Capacity)
- [msevtmgt_Description](#BKMK_msevtmgt_Description)
- [msevtmgt_DisabledAccess](#BKMK_msevtmgt_DisabledAccess)
- [msevtmgt_DisabledCapacity](#BKMK_msevtmgt_DisabledCapacity)
- [msevtmgt_FloorPlan](#BKMK_msevtmgt_FloorPlan)
- [msevtmgt_LayoutId](#BKMK_msevtmgt_LayoutId)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_Room](#BKMK_msevtmgt_Room)
- [msevtmgt_Units](#BKMK_msevtmgt_Units)
- [msevtmgt_UsableArea](#BKMK_msevtmgt_UsableArea)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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

### <a name="BKMK_msevtmgt_Capacity"></a> msevtmgt_Capacity

|Property|Value|
|---|---|
|Description|**The number of people that can be located here**|
|DisplayName|**Capacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_capacity`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_Description"></a> msevtmgt_Description

|Property|Value|
|---|---|
|Description|**Description of the layout**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_DisabledAccess"></a> msevtmgt_DisabledAccess

|Property|Value|
|---|---|
|Description|**Indicates whether this location provides easy access for disabled people**|
|DisplayName|**Disabled access**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_disabledaccess`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000002|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_DisabledAccess Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_DisabledCapacity"></a> msevtmgt_DisabledCapacity

|Property|Value|
|---|---|
|Description|**The number of disabled people that can be located here**|
|DisplayName|**Disabled capacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_disabledcapacity`|
|RequiredLevel|Recommended|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_FloorPlan"></a> msevtmgt_FloorPlan

|Property|Value|
|---|---|
|Description|**Standardized floor plan type**|
|DisplayName|**Floor plan**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_floorplan`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_floorplan`|

#### msevtmgt_FloorPlan Choices/Options

|Value|Label|
|---|---|
|100000000|**Theater**|
|100000001|**Classroom**|
|100000002|**Herringbone**|
|100000003|**U-shape**|
|100000004|**Horse shoe**|
|100000005|**Hollow square**|
|100000006|**Boardroom**|
|100000007|**Banquet**|
|100000008|**Cabaret**|
|100000009|**Cocktail**|
|100000010|**Booth**|

### <a name="BKMK_msevtmgt_LayoutId"></a> msevtmgt_LayoutId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Layout**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_layoutid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msevtmgt_Room"></a> msevtmgt_Room

|Property|Value|
|---|---|
|Description|**Link to the room**|
|DisplayName|**Room**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_room`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_room|

### <a name="BKMK_msevtmgt_Units"></a> msevtmgt_Units

|Property|Value|
|---|---|
|Description|**Square units**|
|DisplayName|**Units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_units`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_squareunits`|

#### msevtmgt_Units Choices/Options

|Value|Label|
|---|---|
|100000000|**Sq. meters**|
|100000001|**Sq. feet**|

### <a name="BKMK_msevtmgt_UsableArea"></a> msevtmgt_UsableArea

|Property|Value|
|---|---|
|Description|**Usable area (square units)**|
|DisplayName|**Usable area**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_usablearea`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner ID**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the layout**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_layout_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the layout**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_layout_statuscode`|

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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record**|
|DisplayName|**Owning user**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
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

- [business_unit_msevtmgt_layout](#BKMK_business_unit_msevtmgt_layout)
- [lk_msevtmgt_layout_createdby](#BKMK_lk_msevtmgt_layout_createdby)
- [lk_msevtmgt_layout_createdonbehalfby](#BKMK_lk_msevtmgt_layout_createdonbehalfby)
- [lk_msevtmgt_layout_modifiedby](#BKMK_lk_msevtmgt_layout_modifiedby)
- [lk_msevtmgt_layout_modifiedonbehalfby](#BKMK_lk_msevtmgt_layout_modifiedonbehalfby)
- [msevtmgt_room_msevtmgt_layout_Room](#BKMK_msevtmgt_room_msevtmgt_layout_Room)
- [owner_msevtmgt_layout](#BKMK_owner_msevtmgt_layout)
- [team_msevtmgt_layout](#BKMK_team_msevtmgt_layout)
- [user_msevtmgt_layout](#BKMK_user_msevtmgt_layout)

### <a name="BKMK_business_unit_msevtmgt_layout"></a> business_unit_msevtmgt_layout

One-To-Many Relationship: [businessunit business_unit_msevtmgt_layout](businessunit.md#BKMK_business_unit_msevtmgt_layout)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_layout_createdby"></a> lk_msevtmgt_layout_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_layout_createdby](systemuser.md#BKMK_lk_msevtmgt_layout_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_layout_createdonbehalfby"></a> lk_msevtmgt_layout_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_layout_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_layout_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_layout_modifiedby"></a> lk_msevtmgt_layout_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_layout_modifiedby](systemuser.md#BKMK_lk_msevtmgt_layout_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_layout_modifiedonbehalfby"></a> lk_msevtmgt_layout_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_layout_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_layout_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_room_msevtmgt_layout_Room"></a> msevtmgt_room_msevtmgt_layout_Room

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_msevtmgt_layout_Room](msevtmgt_room.md#BKMK_msevtmgt_room_msevtmgt_layout_Room)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`msevtmgt_room`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Room`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msevtmgt_layout"></a> owner_msevtmgt_layout

One-To-Many Relationship: [owner owner_msevtmgt_layout](owner.md#BKMK_owner_msevtmgt_layout)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_layout"></a> team_msevtmgt_layout

One-To-Many Relationship: [team team_msevtmgt_layout](team.md#BKMK_team_msevtmgt_layout)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_layout"></a> user_msevtmgt_layout

One-To-Many Relationship: [systemuser user_msevtmgt_layout](systemuser.md#BKMK_user_msevtmgt_layout)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msevtmgt_event_layout](#BKMK_msevtmgt_event_layout)
- [msevtmgt_layout_ActivityPointers](#BKMK_msevtmgt_layout_ActivityPointers)
- [msevtmgt_layout_adx_alertsubscriptions](#BKMK_msevtmgt_layout_adx_alertsubscriptions)
- [msevtmgt_layout_adx_inviteredemptions](#BKMK_msevtmgt_layout_adx_inviteredemptions)
- [msevtmgt_layout_adx_portalcomments](#BKMK_msevtmgt_layout_adx_portalcomments)
- [msevtmgt_layout_Annotations](#BKMK_msevtmgt_layout_Annotations)
- [msevtmgt_layout_Appointments](#BKMK_msevtmgt_layout_Appointments)
- [msevtmgt_layout_AsyncOperations](#BKMK_msevtmgt_layout_AsyncOperations)
- [msevtmgt_layout_BulkDeleteFailures](#BKMK_msevtmgt_layout_BulkDeleteFailures)
- [msevtmgt_layout_chats](#BKMK_msevtmgt_layout_chats)
- [msevtmgt_layout_Emails](#BKMK_msevtmgt_layout_Emails)
- [msevtmgt_layout_Faxes](#BKMK_msevtmgt_layout_Faxes)
- [msevtmgt_layout_Letters](#BKMK_msevtmgt_layout_Letters)
- [msevtmgt_layout_li_inmails](#BKMK_msevtmgt_layout_li_inmails)
- [msevtmgt_layout_li_messages](#BKMK_msevtmgt_layout_li_messages)
- [msevtmgt_layout_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_layout_li_pointdrivepresentationvieweds)
- [msevtmgt_layout_MailboxTrackingFolders](#BKMK_msevtmgt_layout_MailboxTrackingFolders)
- [msevtmgt_layout_msdyn_bookingalerts](#BKMK_msevtmgt_layout_msdyn_bookingalerts)
- [msevtmgt_layout_msdyn_copilottranscripts](#BKMK_msevtmgt_layout_msdyn_copilottranscripts)
- [msevtmgt_layout_msdyn_ocliveworkitems](#BKMK_msevtmgt_layout_msdyn_ocliveworkitems)
- [msevtmgt_layout_msdyn_ocoutboundmessages](#BKMK_msevtmgt_layout_msdyn_ocoutboundmessages)
- [msevtmgt_layout_msdyn_ocsessions](#BKMK_msevtmgt_layout_msdyn_ocsessions)
- [msevtmgt_layout_msdyn_ocvoicemails](#BKMK_msevtmgt_layout_msdyn_ocvoicemails)
- [msevtmgt_layout_msfp_alerts](#BKMK_msevtmgt_layout_msfp_alerts)
- [msevtmgt_layout_msfp_surveyinvites](#BKMK_msevtmgt_layout_msfp_surveyinvites)
- [msevtmgt_layout_msfp_surveyresponses](#BKMK_msevtmgt_layout_msfp_surveyresponses)
- [msevtmgt_layout_PhoneCalls](#BKMK_msevtmgt_layout_PhoneCalls)
- [msevtmgt_layout_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_layout_PrincipalObjectAttributeAccesses)
- [msevtmgt_layout_ProcessSession](#BKMK_msevtmgt_layout_ProcessSession)
- [msevtmgt_layout_RecurringAppointmentMasters](#BKMK_msevtmgt_layout_RecurringAppointmentMasters)
- [msevtmgt_layout_ServiceAppointments](#BKMK_msevtmgt_layout_ServiceAppointments)
- [msevtmgt_layout_SocialActivities](#BKMK_msevtmgt_layout_SocialActivities)
- [msevtmgt_layout_SyncErrors](#BKMK_msevtmgt_layout_SyncErrors)
- [msevtmgt_layout_Tasks](#BKMK_msevtmgt_layout_Tasks)
- [msevtmgt_msevtmgt_layout_msevtmgt_venue](#BKMK_msevtmgt_msevtmgt_layout_msevtmgt_venue)
- [msevtmgt_session_layout](#BKMK_msevtmgt_session_layout)

### <a name="BKMK_msevtmgt_event_layout"></a> msevtmgt_event_layout

Many-To-One Relationship: [msevtmgt_event msevtmgt_event_layout](msevtmgt_event.md#BKMK_msevtmgt_event_layout)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`msevtmgt_layout`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_layout`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_ActivityPointers"></a> msevtmgt_layout_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_layout_ActivityPointers](activitypointer.md#BKMK_msevtmgt_layout_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_adx_alertsubscriptions"></a> msevtmgt_layout_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_layout_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_layout_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_adx_inviteredemptions"></a> msevtmgt_layout_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_layout_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_layout_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_adx_portalcomments"></a> msevtmgt_layout_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_layout_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_layout_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_Annotations"></a> msevtmgt_layout_Annotations

Many-To-One Relationship: [annotation msevtmgt_layout_Annotations](annotation.md#BKMK_msevtmgt_layout_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_Appointments"></a> msevtmgt_layout_Appointments

Many-To-One Relationship: [appointment msevtmgt_layout_Appointments](appointment.md#BKMK_msevtmgt_layout_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_AsyncOperations"></a> msevtmgt_layout_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_layout_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_layout_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_BulkDeleteFailures"></a> msevtmgt_layout_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_layout_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_layout_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_chats"></a> msevtmgt_layout_chats

Many-To-One Relationship: [chat msevtmgt_layout_chats](chat.md#BKMK_msevtmgt_layout_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_Emails"></a> msevtmgt_layout_Emails

Many-To-One Relationship: [email msevtmgt_layout_Emails](email.md#BKMK_msevtmgt_layout_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_Faxes"></a> msevtmgt_layout_Faxes

Many-To-One Relationship: [fax msevtmgt_layout_Faxes](fax.md#BKMK_msevtmgt_layout_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_Letters"></a> msevtmgt_layout_Letters

Many-To-One Relationship: [letter msevtmgt_layout_Letters](letter.md#BKMK_msevtmgt_layout_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_li_inmails"></a> msevtmgt_layout_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_layout_li_inmails](li_inmail.md#BKMK_msevtmgt_layout_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_li_messages"></a> msevtmgt_layout_li_messages

Many-To-One Relationship: [li_message msevtmgt_layout_li_messages](li_message.md#BKMK_msevtmgt_layout_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_li_pointdrivepresentationvieweds"></a> msevtmgt_layout_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_layout_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_layout_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_MailboxTrackingFolders"></a> msevtmgt_layout_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_layout_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_layout_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_msdyn_bookingalerts"></a> msevtmgt_layout_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_layout_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_layout_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_msdyn_copilottranscripts"></a> msevtmgt_layout_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_layout_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_layout_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_msdyn_ocliveworkitems"></a> msevtmgt_layout_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_layout_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_layout_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_msdyn_ocoutboundmessages"></a> msevtmgt_layout_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_layout_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_layout_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_msdyn_ocsessions"></a> msevtmgt_layout_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_layout_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_layout_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_msdyn_ocvoicemails"></a> msevtmgt_layout_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_layout_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_layout_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_msfp_alerts"></a> msevtmgt_layout_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_layout_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_layout_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_msfp_surveyinvites"></a> msevtmgt_layout_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_layout_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_layout_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_msfp_surveyresponses"></a> msevtmgt_layout_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_layout_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_layout_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_PhoneCalls"></a> msevtmgt_layout_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_layout_PhoneCalls](phonecall.md#BKMK_msevtmgt_layout_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_PrincipalObjectAttributeAccesses"></a> msevtmgt_layout_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_layout_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_layout_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_ProcessSession"></a> msevtmgt_layout_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_layout_ProcessSession](processsession.md#BKMK_msevtmgt_layout_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_RecurringAppointmentMasters"></a> msevtmgt_layout_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_layout_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_layout_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_ServiceAppointments"></a> msevtmgt_layout_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_layout_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_layout_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_SocialActivities"></a> msevtmgt_layout_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_layout_SocialActivities](socialactivity.md#BKMK_msevtmgt_layout_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_SyncErrors"></a> msevtmgt_layout_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_layout_SyncErrors](syncerror.md#BKMK_msevtmgt_layout_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_layout_Tasks"></a> msevtmgt_layout_Tasks

Many-To-One Relationship: [task msevtmgt_layout_Tasks](task.md#BKMK_msevtmgt_layout_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_layout_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_layout_msevtmgt_venue"></a> msevtmgt_msevtmgt_layout_msevtmgt_venue

Many-To-One Relationship: [msevtmgt_venue msevtmgt_msevtmgt_layout_msevtmgt_venue](msevtmgt_venue.md#BKMK_msevtmgt_msevtmgt_layout_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_venue`|
|ReferencingAttribute|`msevtmgt_layoutid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_layout_msevtmgt_venue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_layout"></a> msevtmgt_session_layout

Many-To-One Relationship: [msevtmgt_session msevtmgt_session_layout](msevtmgt_session.md#BKMK_msevtmgt_session_layout)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`msevtmgt_layout`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_layout`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

