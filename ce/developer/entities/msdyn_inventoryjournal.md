---
title: "msdyn_inventoryjournal Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_inventoryjournal entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_inventoryjournal Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Inventory change tracking

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_inventoryjournals<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_inventoryjournals<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_inventoryjournals(*msdyn_inventoryjournalid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Inventory Journal<br />
**DisplayCollectionName**: Inventory Journals<br />
**SchemaName**: msdyn_inventoryjournal<br />
**CollectionSchemaName**: msdyn_inventoryjournals<br />
**LogicalName**: msdyn_inventoryjournal<br />
**LogicalCollectionName**: msdyn_inventoryjournals<br />
**EntitySetName**: msdyn_inventoryjournals<br />
**PrimaryIdAttribute**: msdyn_inventoryjournalid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

**Description**: Shows the sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_AllocatedToWorkOrder"></a> msdyn_AllocatedToWorkOrder

**Description**: Work Order this product is allocated to<br />
**DisplayName**: Allocated To Work Order<br />
**LogicalName**: msdyn_allocatedtoworkorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

**Description**: For internal use only.<br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_InventoryAdjustmentProduct"></a> msdyn_InventoryAdjustmentProduct

**Description**: The Inventory Adjustment Product record related to this journal<br />
**DisplayName**: Inventory Adjustment Product<br />
**LogicalName**: msdyn_inventoryadjustmentproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_inventoryadjustmentproduct


### <a name="BKMK_msdyn_inventoryjournalId"></a> msdyn_inventoryjournalId

**Description**: Shows the entity instances.<br />
**DisplayName**: Inventory Journal<br />
**LogicalName**: msdyn_inventoryjournalid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_JournalType"></a> msdyn_JournalType

**Description**: Shows the transaction type of this journal.<br />
**DisplayName**: Journal Type<br />
**LogicalName**: msdyn_journaltype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: On Hand
- **Value**: 690970001 **Label**: On Order
- **Value**: 690970002 **Label**: Allocated



### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OriginatingJournal"></a> msdyn_OriginatingJournal

**Description**: Indicates the Journal reversed by this journal record<br />
**DisplayName**: Originating Journal<br />
**LogicalName**: msdyn_originatingjournal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_inventoryjournal


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: Product this journal relates to<br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_PurchaseOrderProduct"></a> msdyn_PurchaseOrderProduct

**Description**: The Purchase Order Product record related to this journal<br />
**DisplayName**: Purchase Order Product<br />
**LogicalName**: msdyn_purchaseorderproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorderproduct


### <a name="BKMK_msdyn_PurchaseOrderReceiptProduct"></a> msdyn_PurchaseOrderReceiptProduct

**Description**: Unique identifier for Purchase Order Receipt Product associated with Inventory Journal.<br />
**DisplayName**: Purchase Order Receipt Product<br />
**LogicalName**: msdyn_purchaseorderreceiptproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorderreceiptproduct


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

**Description**: Enter the quantity affected. A positive quantity indicates the receipt of this product into the specified warehouse, whereas a negative indicates a withdrawal.<br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_Reversal"></a> msdyn_Reversal

**Description**: Indicates if this Journal reverses a previous journal record<br />
**DisplayName**: Reversal<br />
**LogicalName**: msdyn_reversal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_RMAReceiptProduct"></a> msdyn_RMAReceiptProduct

**Description**: The RMA Receipt Product record related to this journal<br />
**DisplayName**: RMA Receipt Product<br />
**LogicalName**: msdyn_rmareceiptproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_rmareceiptproduct


### <a name="BKMK_msdyn_TransactionType"></a> msdyn_TransactionType

**Description**: Shows the transaction type of this journal.<br />
**DisplayName**: Transaction Type<br />
**LogicalName**: msdyn_transactiontype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Purchase Order Product
- **Value**: 690970001 **Label**: Purchase Order Receipt
- **Value**: 690970002 **Label**: WO Product
- **Value**: 690970003 **Label**: Inventory Adjustment
- **Value**: 690970004 **Label**: Inventory Transfer
- **Value**: 690970005 **Label**: RMA Product



### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

**Description**: Unit of product used<br />
**DisplayName**: Unit<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

**Description**: Warehouse affected by this transaction<br />
**DisplayName**: Warehouse<br />
**LogicalName**: msdyn_warehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_WorkOrderProduct"></a> msdyn_WorkOrderProduct

**Description**: The Work Order Product record related to this journal<br />
**DisplayName**: Work Order Product<br />
**LogicalName**: msdyn_workorderproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorderproduct


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Inventory Journal<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Inventory Journal<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Shows the time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_AllocatedToWorkOrderName](#BKMK_msdyn_AllocatedToWorkOrderName)
- [msdyn_InventoryAdjustmentProductName](#BKMK_msdyn_InventoryAdjustmentProductName)
- [msdyn_OriginatingJournalName](#BKMK_msdyn_OriginatingJournalName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_PurchaseOrderProductName](#BKMK_msdyn_PurchaseOrderProductName)
- [msdyn_PurchaseOrderReceiptProductName](#BKMK_msdyn_PurchaseOrderReceiptProductName)
- [msdyn_RMAReceiptProductName](#BKMK_msdyn_RMAReceiptProductName)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_WarehouseName](#BKMK_msdyn_WarehouseName)
- [msdyn_WorkOrderProductName](#BKMK_msdyn_WorkOrderProductName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AllocatedToWorkOrderName"></a> msdyn_AllocatedToWorkOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_allocatedtoworkordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_InventoryAdjustmentProductName"></a> msdyn_InventoryAdjustmentProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_inventoryadjustmentproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OriginatingJournalName"></a> msdyn_OriginatingJournalName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_originatingjournalname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ProductName"></a> msdyn_ProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_productname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PurchaseOrderProductName"></a> msdyn_PurchaseOrderProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_purchaseorderproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PurchaseOrderReceiptProductName"></a> msdyn_PurchaseOrderReceiptProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_purchaseorderreceiptproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RMAReceiptProductName"></a> msdyn_RMAReceiptProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rmareceiptproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_UnitName"></a> msdyn_UnitName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_unitname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WarehouseName"></a> msdyn_WarehouseName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_warehousename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderProductName"></a> msdyn_WorkOrderProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workorderproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_inventoryjournal_ActivityPointers](#BKMK_msdyn_inventoryjournal_ActivityPointers)
- [msdyn_inventoryjournal_msdyn_approvals](#BKMK_msdyn_inventoryjournal_msdyn_approvals)
- [msdyn_inventoryjournal_msdyn_bookingalerts](#BKMK_msdyn_inventoryjournal_msdyn_bookingalerts)
- [msdyn_inventoryjournal_SyncErrors](#BKMK_msdyn_inventoryjournal_SyncErrors)
- [msdyn_inventoryjournal_DuplicateMatchingRecord](#BKMK_msdyn_inventoryjournal_DuplicateMatchingRecord)
- [msdyn_inventoryjournal_DuplicateBaseRecord](#BKMK_msdyn_inventoryjournal_DuplicateBaseRecord)
- [msdyn_inventoryjournal_AsyncOperations](#BKMK_msdyn_inventoryjournal_AsyncOperations)
- [msdyn_inventoryjournal_MailboxTrackingFolders](#BKMK_msdyn_inventoryjournal_MailboxTrackingFolders)
- [msdyn_inventoryjournal_UserEntityInstanceDatas](#BKMK_msdyn_inventoryjournal_UserEntityInstanceDatas)
- [msdyn_inventoryjournal_ProcessSession](#BKMK_msdyn_inventoryjournal_ProcessSession)
- [msdyn_inventoryjournal_BulkDeleteFailures](#BKMK_msdyn_inventoryjournal_BulkDeleteFailures)
- [msdyn_inventoryjournal_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventoryjournal_PrincipalObjectAttributeAccesses)
- [msdyn_inventoryjournal_Appointments](#BKMK_msdyn_inventoryjournal_Appointments)
- [msdyn_inventoryjournal_Emails](#BKMK_msdyn_inventoryjournal_Emails)
- [msdyn_inventoryjournal_Faxes](#BKMK_msdyn_inventoryjournal_Faxes)
- [msdyn_inventoryjournal_Letters](#BKMK_msdyn_inventoryjournal_Letters)
- [msdyn_inventoryjournal_PhoneCalls](#BKMK_msdyn_inventoryjournal_PhoneCalls)
- [msdyn_inventoryjournal_Tasks](#BKMK_msdyn_inventoryjournal_Tasks)
- [msdyn_inventoryjournal_RecurringAppointmentMasters](#BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters)
- [msdyn_inventoryjournal_SocialActivities](#BKMK_msdyn_inventoryjournal_SocialActivities)
- [msdyn_inventoryjournal_connections1](#BKMK_msdyn_inventoryjournal_connections1)
- [msdyn_inventoryjournal_connections2](#BKMK_msdyn_inventoryjournal_connections2)
- [msdyn_inventoryjournal_Annotations](#BKMK_msdyn_inventoryjournal_Annotations)
- [msdyn_inventoryjournal_ServiceAppointments](#BKMK_msdyn_inventoryjournal_ServiceAppointments)
- [msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal](#BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal)


### <a name="BKMK_msdyn_inventoryjournal_ActivityPointers"></a> msdyn_inventoryjournal_ActivityPointers

Same as activitypointer entity [msdyn_inventoryjournal_ActivityPointers](activitypointer.md#BKMK_msdyn_inventoryjournal_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_msdyn_approvals"></a> msdyn_inventoryjournal_msdyn_approvals

Same as msdyn_approval entity [msdyn_inventoryjournal_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_inventoryjournal_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_msdyn_approvals<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_msdyn_bookingalerts"></a> msdyn_inventoryjournal_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_inventoryjournal_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_inventoryjournal_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_msdyn_bookingalerts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_SyncErrors"></a> msdyn_inventoryjournal_SyncErrors

Same as syncerror entity [msdyn_inventoryjournal_SyncErrors](syncerror.md#BKMK_msdyn_inventoryjournal_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_DuplicateMatchingRecord"></a> msdyn_inventoryjournal_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_inventoryjournal_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_inventoryjournal_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_DuplicateBaseRecord"></a> msdyn_inventoryjournal_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_inventoryjournal_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_inventoryjournal_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_AsyncOperations"></a> msdyn_inventoryjournal_AsyncOperations

Same as asyncoperation entity [msdyn_inventoryjournal_AsyncOperations](asyncoperation.md#BKMK_msdyn_inventoryjournal_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_MailboxTrackingFolders"></a> msdyn_inventoryjournal_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_inventoryjournal_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_inventoryjournal_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_UserEntityInstanceDatas"></a> msdyn_inventoryjournal_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_inventoryjournal_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_inventoryjournal_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_ProcessSession"></a> msdyn_inventoryjournal_ProcessSession

Same as processsession entity [msdyn_inventoryjournal_ProcessSession](processsession.md#BKMK_msdyn_inventoryjournal_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_BulkDeleteFailures"></a> msdyn_inventoryjournal_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_inventoryjournal_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_inventoryjournal_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_PrincipalObjectAttributeAccesses"></a> msdyn_inventoryjournal_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_inventoryjournal_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_inventoryjournal_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_Appointments"></a> msdyn_inventoryjournal_Appointments

Same as appointment entity [msdyn_inventoryjournal_Appointments](appointment.md#BKMK_msdyn_inventoryjournal_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_Emails"></a> msdyn_inventoryjournal_Emails

Same as email entity [msdyn_inventoryjournal_Emails](email.md#BKMK_msdyn_inventoryjournal_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_Faxes"></a> msdyn_inventoryjournal_Faxes

Same as fax entity [msdyn_inventoryjournal_Faxes](fax.md#BKMK_msdyn_inventoryjournal_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_Letters"></a> msdyn_inventoryjournal_Letters

Same as letter entity [msdyn_inventoryjournal_Letters](letter.md#BKMK_msdyn_inventoryjournal_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_PhoneCalls"></a> msdyn_inventoryjournal_PhoneCalls

Same as phonecall entity [msdyn_inventoryjournal_PhoneCalls](phonecall.md#BKMK_msdyn_inventoryjournal_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_PhoneCalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_Tasks"></a> msdyn_inventoryjournal_Tasks

Same as task entity [msdyn_inventoryjournal_Tasks](task.md#BKMK_msdyn_inventoryjournal_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters"></a> msdyn_inventoryjournal_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_inventoryjournal_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_SocialActivities"></a> msdyn_inventoryjournal_SocialActivities

Same as socialactivity entity [msdyn_inventoryjournal_SocialActivities](socialactivity.md#BKMK_msdyn_inventoryjournal_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_connections1"></a> msdyn_inventoryjournal_connections1

Same as connection entity [msdyn_inventoryjournal_connections1](connection.md#BKMK_msdyn_inventoryjournal_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_connections2"></a> msdyn_inventoryjournal_connections2

Same as connection entity [msdyn_inventoryjournal_connections2](connection.md#BKMK_msdyn_inventoryjournal_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_inventoryjournal_Annotations"></a> msdyn_inventoryjournal_Annotations

Same as annotation entity [msdyn_inventoryjournal_Annotations](annotation.md#BKMK_msdyn_inventoryjournal_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_Annotations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_inventoryjournal_ServiceAppointments"></a> msdyn_inventoryjournal_ServiceAppointments

Same as serviceappointment entity [msdyn_inventoryjournal_ServiceAppointments](serviceappointment.md#BKMK_msdyn_inventoryjournal_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventoryjournal_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal"></a> msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal

Same as msdyn_inventoryjournal entity [msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: msdyn_originatingjournal<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_inventoryjournal_createdby](#BKMK_lk_msdyn_inventoryjournal_createdby)
- [lk_msdyn_inventoryjournal_createdonbehalfby](#BKMK_lk_msdyn_inventoryjournal_createdonbehalfby)
- [lk_msdyn_inventoryjournal_modifiedby](#BKMK_lk_msdyn_inventoryjournal_modifiedby)
- [lk_msdyn_inventoryjournal_modifiedonbehalfby](#BKMK_lk_msdyn_inventoryjournal_modifiedonbehalfby)
- [user_msdyn_inventoryjournal](#BKMK_user_msdyn_inventoryjournal)
- [team_msdyn_inventoryjournal](#BKMK_team_msdyn_inventoryjournal)
- [business_unit_msdyn_inventoryjournal](#BKMK_business_unit_msdyn_inventoryjournal)
- [msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct](#BKMK_msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct)
- [msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal](#BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal)
- [msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct](#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct)
- [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct](#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct)
- [msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct)
- [msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse)
- [msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder)
- [msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct)
- [msdyn_product_msdyn_inventoryjournal_Product](#BKMK_msdyn_product_msdyn_inventoryjournal_Product)
- [msdyn_uom_msdyn_inventoryjournal_Unit](#BKMK_msdyn_uom_msdyn_inventoryjournal_Unit)


### <a name="BKMK_lk_msdyn_inventoryjournal_createdby"></a> lk_msdyn_inventoryjournal_createdby

See systemuser Entity [lk_msdyn_inventoryjournal_createdby](systemuser.md#BKMK_lk_msdyn_inventoryjournal_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_inventoryjournal_createdonbehalfby"></a> lk_msdyn_inventoryjournal_createdonbehalfby

See systemuser Entity [lk_msdyn_inventoryjournal_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_inventoryjournal_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_inventoryjournal_modifiedby"></a> lk_msdyn_inventoryjournal_modifiedby

See systemuser Entity [lk_msdyn_inventoryjournal_modifiedby](systemuser.md#BKMK_lk_msdyn_inventoryjournal_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_inventoryjournal_modifiedonbehalfby"></a> lk_msdyn_inventoryjournal_modifiedonbehalfby

See systemuser Entity [lk_msdyn_inventoryjournal_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_inventoryjournal_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_inventoryjournal"></a> user_msdyn_inventoryjournal

See systemuser Entity [user_msdyn_inventoryjournal](systemuser.md#BKMK_user_msdyn_inventoryjournal) One-To-Many relationship.

### <a name="BKMK_team_msdyn_inventoryjournal"></a> team_msdyn_inventoryjournal

See team Entity [team_msdyn_inventoryjournal](team.md#BKMK_team_msdyn_inventoryjournal) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_inventoryjournal"></a> business_unit_msdyn_inventoryjournal

See businessunit Entity [business_unit_msdyn_inventoryjournal](businessunit.md#BKMK_business_unit_msdyn_inventoryjournal) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct"></a> msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct

See msdyn_inventoryadjustmentproduct Entity [msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal"></a> msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal

See msdyn_inventoryjournal Entity [msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct"></a> msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct

See msdyn_purchaseorderproduct Entity [msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct"></a> msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct

See msdyn_purchaseorderreceiptproduct Entity [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct"></a> msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct

See msdyn_rmareceiptproduct Entity [msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](msdyn_rmareceiptproduct.md#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct

See msdyn_workorderproduct Entity [msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_inventoryjournal_Product"></a> msdyn_product_msdyn_inventoryjournal_Product

See product Entity [msdyn_product_msdyn_inventoryjournal_Product](product.md#BKMK_msdyn_product_msdyn_inventoryjournal_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_inventoryjournal_Unit"></a> msdyn_uom_msdyn_inventoryjournal_Unit

See uom Entity [msdyn_uom_msdyn_inventoryjournal_Unit](uom.md#BKMK_msdyn_uom_msdyn_inventoryjournal_Unit) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_inventoryjournal?text=msdyn_inventoryjournal EntityType" />