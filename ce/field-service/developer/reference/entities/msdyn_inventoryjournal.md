---
title: "Inventory Journal (msdyn_inventoryjournal) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Inventory Journal (msdyn_inventoryjournal) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Inventory Journal (msdyn_inventoryjournal) table/entity reference (Microsoft Dynamics 365 Field Service)

Inventory change tracking

## Messages

The following table lists the messages for the Inventory Journal (msdyn_inventoryjournal) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_inventoryjournals<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_inventoryjournals<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Inventory Journal (msdyn_inventoryjournal) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Inventory Journal** |
| **DisplayCollectionName** | **Inventory Journals** |
| **SchemaName** | `msdyn_inventoryjournal` |
| **CollectionSchemaName** | `msdyn_inventoryjournals` |
| **EntitySetName** | `msdyn_inventoryjournals`|
| **LogicalName** | `msdyn_inventoryjournal` |
| **LogicalCollectionName** | `msdyn_inventoryjournals` |
| **PrimaryIdAttribute** | `msdyn_inventoryjournalid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AllocatedToWorkOrder](#BKMK_msdyn_AllocatedToWorkOrder)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_InventoryAdjustmentProduct](#BKMK_msdyn_InventoryAdjustmentProduct)
- [msdyn_inventoryjournalId](#BKMK_msdyn_inventoryjournalId)
- [msdyn_JournalType](#BKMK_msdyn_JournalType)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OriginatingJournal](#BKMK_msdyn_OriginatingJournal)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_PurchaseOrderProduct](#BKMK_msdyn_PurchaseOrderProduct)
- [msdyn_PurchaseOrderReceiptProduct](#BKMK_msdyn_PurchaseOrderReceiptProduct)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_Reversal](#BKMK_msdyn_Reversal)
- [msdyn_RMAReceiptProduct](#BKMK_msdyn_RMAReceiptProduct)
- [msdyn_TransactionType](#BKMK_msdyn_TransactionType)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)
- [msdyn_WorkOrderProduct](#BKMK_msdyn_WorkOrderProduct)
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

### <a name="BKMK_msdyn_AllocatedToWorkOrder"></a> msdyn_AllocatedToWorkOrder

|Property|Value|
|---|---|
|Description|**Work Order this product is allocated to**|
|DisplayName|**Allocated To Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allocatedtoworkorder`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorder|

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_InventoryAdjustmentProduct"></a> msdyn_InventoryAdjustmentProduct

|Property|Value|
|---|---|
|Description|**The Inventory Adjustment Product record related to this journal**|
|DisplayName|**Inventory Adjustment Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inventoryadjustmentproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_inventoryadjustmentproduct|

### <a name="BKMK_msdyn_inventoryjournalId"></a> msdyn_inventoryjournalId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Inventory Journal**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_inventoryjournalid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_JournalType"></a> msdyn_JournalType

|Property|Value|
|---|---|
|Description|**Shows the transaction type of this journal.**|
|DisplayName|**Journal Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_journaltype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_inventoryjournaltype`|

#### msdyn_JournalType Choices/Options

|Value|Label|
|---|---|
|690970000|**On Hand**|
|690970001|**On Order**|
|690970002|**Allocated**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_OriginatingJournal"></a> msdyn_OriginatingJournal

|Property|Value|
|---|---|
|Description|**Indicates the Journal reversed by this journal record**|
|DisplayName|**Originating Journal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_originatingjournal`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_inventoryjournal|

### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|---|---|
|Description|**Product this journal relates to**|
|DisplayName|**Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_product`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_PurchaseOrderProduct"></a> msdyn_PurchaseOrderProduct

|Property|Value|
|---|---|
|Description|**The Purchase Order Product record related to this journal**|
|DisplayName|**Purchase Order Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseorderproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_purchaseorderproduct|

### <a name="BKMK_msdyn_PurchaseOrderReceiptProduct"></a> msdyn_PurchaseOrderReceiptProduct

|Property|Value|
|---|---|
|Description|**Unique identifier for Purchase Order Receipt Product associated with Inventory Journal.**|
|DisplayName|**Purchase Order Receipt Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseorderreceiptproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_purchaseorderreceiptproduct|

### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

|Property|Value|
|---|---|
|Description|**Enter the quantity affected. A positive quantity indicates the receipt of this product into the specified warehouse, whereas a negative indicates a withdrawal.**|
|DisplayName|**Quantity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quantity`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|2|

### <a name="BKMK_msdyn_Reversal"></a> msdyn_Reversal

|Property|Value|
|---|---|
|Description|**Indicates if this Journal reverses a previous journal record**|
|DisplayName|**Reversal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reversal`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_inventoryjournal_msdyn_reversal`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_RMAReceiptProduct"></a> msdyn_RMAReceiptProduct

|Property|Value|
|---|---|
|Description|**The RMA Receipt Product record related to this journal**|
|DisplayName|**RMA Receipt Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rmareceiptproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_rmareceiptproduct|

### <a name="BKMK_msdyn_TransactionType"></a> msdyn_TransactionType

|Property|Value|
|---|---|
|Description|**Shows the transaction type of this journal.**|
|DisplayName|**Transaction Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transactiontype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|690970006|
|GlobalChoiceName|`msdyn_inventorytransactiontype`|

#### msdyn_TransactionType Choices/Options

|Value|Label|
|---|---|
|690970000|**Purchase Order Product**|
|690970001|**Purchase Order Receipt**|
|690970002|**WO Product**|
|690970003|**Inventory Adjustment**|
|690970004|**Inventory Transfer**|
|690970005|**RMA Product**|
|690970006|**Manual**|

### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|---|---|
|Description|**Unit of product used**|
|DisplayName|**Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unit`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

|Property|Value|
|---|---|
|Description|**Warehouse affected by this transaction**|
|DisplayName|**Warehouse**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_warehouse`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_warehouse|

### <a name="BKMK_msdyn_WorkOrderProduct"></a> msdyn_WorkOrderProduct

|Property|Value|
|---|---|
|Description|**The Work Order Product record related to this journal**|
|DisplayName|**Work Order Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorderproduct|

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
|Description|**Status of the Inventory Journal**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_inventoryjournal_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Inventory Journal**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_inventoryjournal_statuscode`|

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

- [msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct](#BKMK_msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct)
- [msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal](#BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal-many-to-one)
- [msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct](#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct)
- [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct](#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct)
- [msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct)
- [msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse)
- [msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder)
- [msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct)
- [msdyn_product_msdyn_inventoryjournal_Product](#BKMK_msdyn_product_msdyn_inventoryjournal_Product)

### <a name="BKMK_msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct"></a> msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`msdyn_inventoryadjustmentproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal-many-to-one"></a> msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal](#BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`msdyn_originatingjournal`|
|ReferencingEntityNavigationPropertyName|`msdyn_originatingjournal_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct"></a> msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`msdyn_purchaseorderproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct"></a> msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`msdyn_purchaseorderreceiptproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct"></a> msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](msdyn_rmareceiptproduct.md#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`msdyn_rmareceiptproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse

One-To-Many Relationship: [msdyn_warehouse msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencingEntityNavigationPropertyName|`msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_allocatedtoworkorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_allocatedtoworkorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct

One-To-Many Relationship: [msdyn_workorderproduct msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`msdyn_workorderproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_inventoryjournal_Product"></a> msdyn_product_msdyn_inventoryjournal_Product

One-To-Many Relationship: [product msdyn_product_msdyn_inventoryjournal_Product](product.md#BKMK_msdyn_product_msdyn_inventoryjournal_Product)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_product`|
|ReferencingEntityNavigationPropertyName|`msdyn_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_inventoryjournal_msdyn_bookingalerts](#BKMK_msdyn_inventoryjournal_msdyn_bookingalerts)
- [msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal](#BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal-one-to-many)

### <a name="BKMK_msdyn_inventoryjournal_msdyn_bookingalerts"></a> msdyn_inventoryjournal_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_inventoryjournal_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_inventoryjournal_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_inventoryjournal_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal-one-to-many"></a> msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal

Many-To-One Relationship: [msdyn_inventoryjournal msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal](#BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`msdyn_originatingjournal`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

