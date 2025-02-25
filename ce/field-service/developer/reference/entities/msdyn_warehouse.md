---
title: "Warehouse (msdyn_warehouse) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Warehouse (msdyn_warehouse) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Warehouse (msdyn_warehouse) table/entity reference (Microsoft Dynamics 365 Field Service)

Warehouses where inventory products are stored and managed

## Messages

The following table lists the messages for the Warehouse (msdyn_warehouse) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_warehouses(*msdyn_warehouseid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_warehouses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_warehouses(*msdyn_warehouseid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_warehouses(*msdyn_warehouseid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_warehouses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_warehouses(*msdyn_warehouseid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_warehouses(*msdyn_warehouseid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_warehouses(*msdyn_warehouseid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Warehouse (msdyn_warehouse) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Warehouse** |
| **DisplayCollectionName** | **Warehouses** |
| **SchemaName** | `msdyn_warehouse` |
| **CollectionSchemaName** | `msdyn_warehouses` |
| **EntitySetName** | `msdyn_warehouses`|
| **LogicalName** | `msdyn_warehouse` |
| **LogicalCollectionName** | `msdyn_warehouses` |
| **PrimaryIdAttribute** | `msdyn_warehouseid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_warehouseId](#BKMK_msdyn_warehouseId)
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

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
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

### <a name="BKMK_msdyn_warehouseId"></a> msdyn_warehouseId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Warehouse**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_warehouseid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Warehouse**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_warehouse_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Warehouse**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_warehouse_statuscode`|

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

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_warehouse_bookableresource_Warehouse](#BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_actual_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_actual_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse)
- [msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse)
- [msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse)
- [msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse)
- [msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse)
- [msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse)
- [msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse)
- [msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse)
- [msdyn_warehouse_msdyn_bookingalerts](#BKMK_msdyn_warehouse_msdyn_bookingalerts)

### <a name="BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse"></a> msdyn_msdyn_warehouse_bookableresource_Warehouse

Many-To-One Relationship: [bookableresource msdyn_msdyn_warehouse_bookableresource_Warehouse](bookableresource.md#BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_bookableresource_Warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_actual_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_actual_Warehouse

Many-To-One Relationship: [msdyn_actual msdyn_msdyn_warehouse_msdyn_actual_Warehouse](msdyn_actual.md#BKMK_msdyn_msdyn_warehouse_msdyn_actual_Warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_actual_Warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse"></a> msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_defaultwarehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse

Many-To-One Relationship: [msdyn_inventoryadjustment msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse](msdyn_inventoryadjustment.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustment`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse

Many-To-One Relationship: [msdyn_inventoryjournal msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse"></a> msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse

Many-To-One Relationship: [msdyn_inventorytransfer msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse](msdyn_inventorytransfer.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventorytransfer`|
|ReferencingAttribute|`msdyn_destinationwarehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Destination Warehouse<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse"></a> msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse

Many-To-One Relationship: [msdyn_inventorytransfer msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse](msdyn_inventorytransfer.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventorytransfer`|
|ReferencingAttribute|`msdyn_sourcewarehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Source Warehouse<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse

Many-To-One Relationship: [msdyn_productinventory msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse](msdyn_productinventory.md#BKMK_msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productinventory`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse

Many-To-One Relationship: [msdyn_purchaseorder msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`msdyn_receivetowarehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse

Many-To-One Relationship: [msdyn_purchaseorderproduct msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`msdyn_associatetowarehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Associate To Warehouse<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`msdyn_associatetowarehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse"></a> msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse

Many-To-One Relationship: [msdyn_rmaproduct msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_returntowarehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Warehouse<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse

Many-To-One Relationship: [msdyn_rtvproduct msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse

Many-To-One Relationship: [msdyn_workorderproduct msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_warehouse_msdyn_bookingalerts"></a> msdyn_warehouse_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_warehouse_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_warehouse_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_warehouse_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

