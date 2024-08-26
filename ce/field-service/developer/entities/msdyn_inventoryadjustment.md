---
title: "Inventory Adjustment (msdyn_inventoryadjustment) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Inventory Adjustment (msdyn_inventoryadjustment) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Inventory Adjustment (msdyn_inventoryadjustment) table/entity reference

Records inventory adjustments

## Messages

The following table lists the messages for the Inventory Adjustment (msdyn_inventoryadjustment) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_inventoryadjustments(*msdyn_inventoryadjustmentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_inventoryadjustments<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_inventoryadjustments(*msdyn_inventoryadjustmentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_inventoryadjustments(*msdyn_inventoryadjustmentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_inventoryadjustments<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_inventoryadjustments(*msdyn_inventoryadjustmentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_inventoryadjustments(*msdyn_inventoryadjustmentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_inventoryadjustments(*msdyn_inventoryadjustmentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Inventory Adjustment (msdyn_inventoryadjustment) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Inventory Adjustment (msdyn_inventoryadjustment) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Inventory Adjustment** |
| **DisplayCollectionName** | **Inventory Adjustments** |
| **SchemaName** | `msdyn_inventoryadjustment` |
| **CollectionSchemaName** | `msdyn_inventoryadjustments` |
| **EntitySetName** | `msdyn_inventoryadjustments`|
| **LogicalName** | `msdyn_inventoryadjustment` |
| **LogicalCollectionName** | `msdyn_inventoryadjustments` |
| **PrimaryIdAttribute** | `msdyn_inventoryadjustmentid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdjustedByResource](#BKMK_msdyn_AdjustedByResource)
- [msdyn_AdjustmentTime](#BKMK_msdyn_AdjustmentTime)
- [msdyn_AutoNumbering](#BKMK_msdyn_AutoNumbering)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_inventoryadjustmentId](#BKMK_msdyn_inventoryadjustmentId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_RequestedByResource](#BKMK_msdyn_RequestedByResource)
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)
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
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_AdjustedByResource"></a> msdyn_AdjustedByResource

|Property|Value|
|---|---|
|Description|**Unique identifier for Resource associated with Inventory Adjustment.**|
|DisplayName|**Adjusted By Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_adjustedbyresource`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_AdjustmentTime"></a> msdyn_AdjustmentTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Adjustment Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_adjustmenttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_AutoNumbering"></a> msdyn_AutoNumbering

|Property|Value|
|---|---|
|Description|**Internal field used to generate the next name upon entity creation. It is optionally copied to the msdyn_name field.**|
|DisplayName|**Auto-Numbering**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autonumbering`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_inventoryadjustmentId"></a> msdyn_inventoryadjustmentId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Inventory Adjustment**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_inventoryadjustmentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
|DisplayName|**Adjustment No**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_RequestedByResource"></a> msdyn_RequestedByResource

|Property|Value|
|---|---|
|Description|**Unique identifier for Resource associated with Inventory Adjustment.**|
|DisplayName|**Requested By Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requestedbyresource`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

|Property|Value|
|---|---|
|Description|**Unique identifier for Warehouse associated with Inventory Adjustment.**|
|DisplayName|**Warehouse**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_warehouse`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_warehouse|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
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
|Description|**Status of the Inventory Adjustment**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_inventoryadjustment_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Inventory Adjustment**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_inventoryadjustment_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
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
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
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

- [business_unit_msdyn_inventoryadjustment](#BKMK_business_unit_msdyn_inventoryadjustment)
- [lk_msdyn_inventoryadjustment_createdby](#BKMK_lk_msdyn_inventoryadjustment_createdby)
- [lk_msdyn_inventoryadjustment_createdonbehalfby](#BKMK_lk_msdyn_inventoryadjustment_createdonbehalfby)
- [lk_msdyn_inventoryadjustment_modifiedby](#BKMK_lk_msdyn_inventoryadjustment_modifiedby)
- [lk_msdyn_inventoryadjustment_modifiedonbehalfby](#BKMK_lk_msdyn_inventoryadjustment_modifiedonbehalfby)
- [msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource](#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource)
- [msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource](#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource)
- [msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse)
- [owner_msdyn_inventoryadjustment](#BKMK_owner_msdyn_inventoryadjustment)
- [team_msdyn_inventoryadjustment](#BKMK_team_msdyn_inventoryadjustment)
- [user_msdyn_inventoryadjustment](#BKMK_user_msdyn_inventoryadjustment)

### <a name="BKMK_business_unit_msdyn_inventoryadjustment"></a> business_unit_msdyn_inventoryadjustment

One-To-Many Relationship: [businessunit business_unit_msdyn_inventoryadjustment](businessunit.md#BKMK_business_unit_msdyn_inventoryadjustment)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_inventoryadjustment_createdby"></a> lk_msdyn_inventoryadjustment_createdby

One-To-Many Relationship: [systemuser lk_msdyn_inventoryadjustment_createdby](systemuser.md#BKMK_lk_msdyn_inventoryadjustment_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_inventoryadjustment_createdonbehalfby"></a> lk_msdyn_inventoryadjustment_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_inventoryadjustment_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_inventoryadjustment_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_inventoryadjustment_modifiedby"></a> lk_msdyn_inventoryadjustment_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_inventoryadjustment_modifiedby](systemuser.md#BKMK_lk_msdyn_inventoryadjustment_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_inventoryadjustment_modifiedonbehalfby"></a> lk_msdyn_inventoryadjustment_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_inventoryadjustment_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_inventoryadjustment_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource"></a> msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource

One-To-Many Relationship: [bookableresource msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_adjustedbyresource`|
|ReferencingEntityNavigationPropertyName|`msdyn_adjustedbyresource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource"></a> msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource

One-To-Many Relationship: [bookableresource msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_requestedbyresource`|
|ReferencingEntityNavigationPropertyName|`msdyn_requestedbyresource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse

One-To-Many Relationship: [msdyn_warehouse msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencingEntityNavigationPropertyName|`msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_inventoryadjustment"></a> owner_msdyn_inventoryadjustment

One-To-Many Relationship: [owner owner_msdyn_inventoryadjustment](owner.md#BKMK_owner_msdyn_inventoryadjustment)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_inventoryadjustment"></a> team_msdyn_inventoryadjustment

One-To-Many Relationship: [team team_msdyn_inventoryadjustment](team.md#BKMK_team_msdyn_inventoryadjustment)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_inventoryadjustment"></a> user_msdyn_inventoryadjustment

One-To-Many Relationship: [systemuser user_msdyn_inventoryadjustment](systemuser.md#BKMK_user_msdyn_inventoryadjustment)

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

- [msdyn_inventoryadjustment_ActivityPointers](#BKMK_msdyn_inventoryadjustment_ActivityPointers)
- [msdyn_inventoryadjustment_adx_inviteredemptions](#BKMK_msdyn_inventoryadjustment_adx_inviteredemptions)
- [msdyn_inventoryadjustment_adx_portalcomments](#BKMK_msdyn_inventoryadjustment_adx_portalcomments)
- [msdyn_inventoryadjustment_Annotations](#BKMK_msdyn_inventoryadjustment_Annotations)
- [msdyn_inventoryadjustment_Appointments](#BKMK_msdyn_inventoryadjustment_Appointments)
- [msdyn_inventoryadjustment_AsyncOperations](#BKMK_msdyn_inventoryadjustment_AsyncOperations)
- [msdyn_inventoryadjustment_BulkDeleteFailures](#BKMK_msdyn_inventoryadjustment_BulkDeleteFailures)
- [msdyn_inventoryadjustment_chats](#BKMK_msdyn_inventoryadjustment_chats)
- [msdyn_inventoryadjustment_connections1](#BKMK_msdyn_inventoryadjustment_connections1)
- [msdyn_inventoryadjustment_connections2](#BKMK_msdyn_inventoryadjustment_connections2)
- [msdyn_inventoryadjustment_DuplicateBaseRecord](#BKMK_msdyn_inventoryadjustment_DuplicateBaseRecord)
- [msdyn_inventoryadjustment_DuplicateMatchingRecord](#BKMK_msdyn_inventoryadjustment_DuplicateMatchingRecord)
- [msdyn_inventoryadjustment_Emails](#BKMK_msdyn_inventoryadjustment_Emails)
- [msdyn_inventoryadjustment_Faxes](#BKMK_msdyn_inventoryadjustment_Faxes)
- [msdyn_inventoryadjustment_Letters](#BKMK_msdyn_inventoryadjustment_Letters)
- [msdyn_inventoryadjustment_MailboxTrackingFolders](#BKMK_msdyn_inventoryadjustment_MailboxTrackingFolders)
- [msdyn_inventoryadjustment_msdyn_bookingalerts](#BKMK_msdyn_inventoryadjustment_msdyn_bookingalerts)
- [msdyn_inventoryadjustment_msdyn_copilottranscripts](#BKMK_msdyn_inventoryadjustment_msdyn_copilottranscripts)
- [msdyn_inventoryadjustment_msdyn_ocliveworkitems](#BKMK_msdyn_inventoryadjustment_msdyn_ocliveworkitems)
- [msdyn_inventoryadjustment_msdyn_ocsessions](#BKMK_msdyn_inventoryadjustment_msdyn_ocsessions)
- [msdyn_inventoryadjustment_msfp_alerts](#BKMK_msdyn_inventoryadjustment_msfp_alerts)
- [msdyn_inventoryadjustment_msfp_surveyinvites](#BKMK_msdyn_inventoryadjustment_msfp_surveyinvites)
- [msdyn_inventoryadjustment_msfp_surveyresponses](#BKMK_msdyn_inventoryadjustment_msfp_surveyresponses)
- [msdyn_inventoryadjustment_PhoneCalls](#BKMK_msdyn_inventoryadjustment_PhoneCalls)
- [msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses)
- [msdyn_inventoryadjustment_ProcessSession](#BKMK_msdyn_inventoryadjustment_ProcessSession)
- [msdyn_inventoryadjustment_QueueItems](#BKMK_msdyn_inventoryadjustment_QueueItems)
- [msdyn_inventoryadjustment_RecurringAppointmentMasters](#BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters)
- [msdyn_inventoryadjustment_ServiceAppointments](#BKMK_msdyn_inventoryadjustment_ServiceAppointments)
- [msdyn_inventoryadjustment_SharePointDocumentLocations](#BKMK_msdyn_inventoryadjustment_SharePointDocumentLocations)
- [msdyn_inventoryadjustment_SocialActivities](#BKMK_msdyn_inventoryadjustment_SocialActivities)
- [msdyn_inventoryadjustment_SyncErrors](#BKMK_msdyn_inventoryadjustment_SyncErrors)
- [msdyn_inventoryadjustment_Tasks](#BKMK_msdyn_inventoryadjustment_Tasks)
- [msdyn_msdyn_inventoryadjustment_msdyn_inventoryadjustmentproduct_InventoryAdjustment](#BKMK_msdyn_msdyn_inventoryadjustment_msdyn_inventoryadjustmentproduct_InventoryAdjustment)

### <a name="BKMK_msdyn_inventoryadjustment_ActivityPointers"></a> msdyn_inventoryadjustment_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_inventoryadjustment_ActivityPointers](activitypointer.md#BKMK_msdyn_inventoryadjustment_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_adx_inviteredemptions"></a> msdyn_inventoryadjustment_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_inventoryadjustment_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_inventoryadjustment_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_adx_portalcomments"></a> msdyn_inventoryadjustment_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_inventoryadjustment_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_inventoryadjustment_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_Annotations"></a> msdyn_inventoryadjustment_Annotations

Many-To-One Relationship: [annotation msdyn_inventoryadjustment_Annotations](annotation.md#BKMK_msdyn_inventoryadjustment_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_Appointments"></a> msdyn_inventoryadjustment_Appointments

Many-To-One Relationship: [appointment msdyn_inventoryadjustment_Appointments](appointment.md#BKMK_msdyn_inventoryadjustment_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_AsyncOperations"></a> msdyn_inventoryadjustment_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_inventoryadjustment_AsyncOperations](asyncoperation.md#BKMK_msdyn_inventoryadjustment_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_BulkDeleteFailures"></a> msdyn_inventoryadjustment_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_inventoryadjustment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_inventoryadjustment_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_chats"></a> msdyn_inventoryadjustment_chats

Many-To-One Relationship: [chat msdyn_inventoryadjustment_chats](chat.md#BKMK_msdyn_inventoryadjustment_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_connections1"></a> msdyn_inventoryadjustment_connections1

Many-To-One Relationship: [connection msdyn_inventoryadjustment_connections1](connection.md#BKMK_msdyn_inventoryadjustment_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_connections2"></a> msdyn_inventoryadjustment_connections2

Many-To-One Relationship: [connection msdyn_inventoryadjustment_connections2](connection.md#BKMK_msdyn_inventoryadjustment_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_DuplicateBaseRecord"></a> msdyn_inventoryadjustment_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_inventoryadjustment_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_inventoryadjustment_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_DuplicateMatchingRecord"></a> msdyn_inventoryadjustment_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_inventoryadjustment_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_inventoryadjustment_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_Emails"></a> msdyn_inventoryadjustment_Emails

Many-To-One Relationship: [email msdyn_inventoryadjustment_Emails](email.md#BKMK_msdyn_inventoryadjustment_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_Faxes"></a> msdyn_inventoryadjustment_Faxes

Many-To-One Relationship: [fax msdyn_inventoryadjustment_Faxes](fax.md#BKMK_msdyn_inventoryadjustment_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_Letters"></a> msdyn_inventoryadjustment_Letters

Many-To-One Relationship: [letter msdyn_inventoryadjustment_Letters](letter.md#BKMK_msdyn_inventoryadjustment_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_MailboxTrackingFolders"></a> msdyn_inventoryadjustment_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_inventoryadjustment_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_inventoryadjustment_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_bookingalerts"></a> msdyn_inventoryadjustment_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_inventoryadjustment_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_inventoryadjustment_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_copilottranscripts"></a> msdyn_inventoryadjustment_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_inventoryadjustment_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_inventoryadjustment_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_ocliveworkitems"></a> msdyn_inventoryadjustment_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_inventoryadjustment_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_inventoryadjustment_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_ocsessions"></a> msdyn_inventoryadjustment_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_inventoryadjustment_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_inventoryadjustment_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_msfp_alerts"></a> msdyn_inventoryadjustment_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_inventoryadjustment_msfp_alerts](msfp_alert.md#BKMK_msdyn_inventoryadjustment_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_msfp_surveyinvites"></a> msdyn_inventoryadjustment_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_inventoryadjustment_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_inventoryadjustment_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_msfp_surveyresponses"></a> msdyn_inventoryadjustment_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_inventoryadjustment_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_inventoryadjustment_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_PhoneCalls"></a> msdyn_inventoryadjustment_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_inventoryadjustment_PhoneCalls](phonecall.md#BKMK_msdyn_inventoryadjustment_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses"></a> msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_ProcessSession"></a> msdyn_inventoryadjustment_ProcessSession

Many-To-One Relationship: [processsession msdyn_inventoryadjustment_ProcessSession](processsession.md#BKMK_msdyn_inventoryadjustment_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_QueueItems"></a> msdyn_inventoryadjustment_QueueItems

Many-To-One Relationship: [queueitem msdyn_inventoryadjustment_QueueItems](queueitem.md#BKMK_msdyn_inventoryadjustment_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters"></a> msdyn_inventoryadjustment_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_inventoryadjustment_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_ServiceAppointments"></a> msdyn_inventoryadjustment_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_inventoryadjustment_ServiceAppointments](serviceappointment.md#BKMK_msdyn_inventoryadjustment_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_SharePointDocumentLocations"></a> msdyn_inventoryadjustment_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_inventoryadjustment_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_inventoryadjustment_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_SocialActivities"></a> msdyn_inventoryadjustment_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_inventoryadjustment_SocialActivities](socialactivity.md#BKMK_msdyn_inventoryadjustment_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_SyncErrors"></a> msdyn_inventoryadjustment_SyncErrors

Many-To-One Relationship: [syncerror msdyn_inventoryadjustment_SyncErrors](syncerror.md#BKMK_msdyn_inventoryadjustment_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_inventoryadjustment_Tasks"></a> msdyn_inventoryadjustment_Tasks

Many-To-One Relationship: [task msdyn_inventoryadjustment_Tasks](task.md#BKMK_msdyn_inventoryadjustment_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryadjustment_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_inventoryadjustment_msdyn_inventoryadjustmentproduct_InventoryAdjustment"></a> msdyn_msdyn_inventoryadjustment_msdyn_inventoryadjustmentproduct_InventoryAdjustment

Many-To-One Relationship: [msdyn_inventoryadjustmentproduct msdyn_msdyn_inventoryadjustment_msdyn_inventoryadjustmentproduct_InventoryAdjustment](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_msdyn_inventoryadjustment_msdyn_inventoryadjustmentproduct_InventoryAdjustment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencingAttribute|`msdyn_inventoryadjustment`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_inventoryadjustment_msdyn_inventoryadjustmentproduct_InventoryAdjustment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

