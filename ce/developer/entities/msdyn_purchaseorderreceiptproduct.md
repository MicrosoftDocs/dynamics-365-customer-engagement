---
title: "msdyn_purchaseorderreceiptproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_purchaseorderreceiptproduct entity."
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
# msdyn_purchaseorderreceiptproduct Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Specify product for purchase order receipt.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Purchase Order Receipt Product<br />
**DisplayCollectionName**: Purchase Order Receipt Products<br />
**SchemaName**: msdyn_purchaseorderreceiptproduct<br />
**CollectionSchemaName**: msdyn_purchaseorderreceiptproducts<br />
**LogicalName**: msdyn_purchaseorderreceiptproduct<br />
**LogicalCollectionName**: msdyn_purchaseorderreceiptproducts<br />
**EntitySetName**: msdyn_purchaseorderreceiptproducts<br />
**PrimaryIdAttribute**: msdyn_purchaseorderreceiptproductid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AssociateToBooking](#BKMK_msdyn_AssociateToBooking)
- [msdyn_AssociateToWarehouse](#BKMK_msdyn_AssociateToWarehouse)
- [msdyn_AssociateToWorkOrder](#BKMK_msdyn_AssociateToWorkOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PurchaseOrder](#BKMK_msdyn_PurchaseOrder)
- [msdyn_PurchaseOrderBill](#BKMK_msdyn_PurchaseOrderBill)
- [msdyn_PurchaseOrderProduct](#BKMK_msdyn_PurchaseOrderProduct)
- [msdyn_PurchaseOrderReceipt](#BKMK_msdyn_PurchaseOrderReceipt)
- [msdyn_purchaseorderreceiptproductId](#BKMK_msdyn_purchaseorderreceiptproductId)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_TotalCost](#BKMK_msdyn_TotalCost)
- [msdyn_UnitCost](#BKMK_msdyn_UnitCost)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
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


### <a name="BKMK_msdyn_AssociateToBooking"></a> msdyn_AssociateToBooking

**Description**: Unique identifier for Resource Booking associated with Purchase Order Receipt Product.<br />
**DisplayName**: Associate To Booking<br />
**LogicalName**: msdyn_associatetobooking<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcebooking


### <a name="BKMK_msdyn_AssociateToWarehouse"></a> msdyn_AssociateToWarehouse

**Description**: Unique identifier for Warehouse associated with Purchase Order Receipt Product.<br />
**DisplayName**: Associate To Warehouse<br />
**LogicalName**: msdyn_associatetowarehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_AssociateToWorkOrder"></a> msdyn_AssociateToWorkOrder

**Description**: Unique identifier for Work Order associated with Purchase Order Receipt Product.<br />
**DisplayName**: Associate To Work Order<br />
**LogicalName**: msdyn_associatetoworkorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PurchaseOrder"></a> msdyn_PurchaseOrder

**Description**: Unique identifier for Purchase Order associated with Purchase Order Receipt Product.<br />
**DisplayName**: Purchase Order<br />
**LogicalName**: msdyn_purchaseorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorder


### <a name="BKMK_msdyn_PurchaseOrderBill"></a> msdyn_PurchaseOrderBill

**Description**: Unique identifier for Purchase Order Bill associated with Purchase Order Receipt Product.<br />
**DisplayName**: Purchase Order Bill<br />
**LogicalName**: msdyn_purchaseorderbill<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorderbill


### <a name="BKMK_msdyn_PurchaseOrderProduct"></a> msdyn_PurchaseOrderProduct

**Description**: Unique identifier for Purchase Order Product associated with Purchase Order Receipt Product.<br />
**DisplayName**: Purchase Order Product<br />
**LogicalName**: msdyn_purchaseorderproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorderproduct


### <a name="BKMK_msdyn_PurchaseOrderReceipt"></a> msdyn_PurchaseOrderReceipt

**Description**: Unique identifier for Purchase Order Receipt associated with Purchase Order Receipt Product.<br />
**DisplayName**: Purchase Order Receipt<br />
**LogicalName**: msdyn_purchaseorderreceipt<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorderreceipt


### <a name="BKMK_msdyn_purchaseorderreceiptproductId"></a> msdyn_purchaseorderreceiptproductId

**Description**: Shows the entity instances.<br />
**DisplayName**: Purchase Order Receipt Product<br />
**LogicalName**: msdyn_purchaseorderreceiptproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

**Description**: <br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_TotalCost"></a> msdyn_TotalCost

**Description**: <br />
**DisplayName**: Total Cost<br />
**LogicalName**: msdyn_totalcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_UnitCost"></a> msdyn_UnitCost

**Description**: <br />
**DisplayName**: Unit Cost<br />
**LogicalName**: msdyn_unitcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


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

**Description**: Status of the Purchase Order Receipt Product<br />
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

**Description**: Reason for the status of the Purchase Order Receipt Product<br />
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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the entity.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_AssociateToBookingName](#BKMK_msdyn_AssociateToBookingName)
- [msdyn_AssociateToWarehouseName](#BKMK_msdyn_AssociateToWarehouseName)
- [msdyn_AssociateToWorkOrderName](#BKMK_msdyn_AssociateToWorkOrderName)
- [msdyn_PurchaseOrderBillName](#BKMK_msdyn_PurchaseOrderBillName)
- [msdyn_PurchaseOrderName](#BKMK_msdyn_PurchaseOrderName)
- [msdyn_PurchaseOrderProductName](#BKMK_msdyn_PurchaseOrderProductName)
- [msdyn_PurchaseOrderReceiptName](#BKMK_msdyn_PurchaseOrderReceiptName)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_unitcost_Base](#BKMK_msdyn_unitcost_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


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


### <a name="BKMK_msdyn_AssociateToBookingName"></a> msdyn_AssociateToBookingName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_associatetobookingname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AssociateToWarehouseName"></a> msdyn_AssociateToWarehouseName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_associatetowarehousename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AssociateToWorkOrderName"></a> msdyn_AssociateToWorkOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_associatetoworkordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PurchaseOrderBillName"></a> msdyn_PurchaseOrderBillName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_purchaseorderbillname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PurchaseOrderName"></a> msdyn_PurchaseOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_purchaseordername<br />
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


### <a name="BKMK_msdyn_PurchaseOrderReceiptName"></a> msdyn_PurchaseOrderReceiptName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_purchaseorderreceiptname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

**Description**: Shows the value of the total cost in the base currency.<br />
**DisplayName**: Total Cost (Base)<br />
**LogicalName**: msdyn_totalcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_unitcost_Base"></a> msdyn_unitcost_Base

**Description**: Shows the value of the unit cost in the base currency.<br />
**DisplayName**: Unit Cost (Base)<br />
**LogicalName**: msdyn_unitcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


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


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [msdyn_purchaseorderreceiptproduct_ActivityPointers](#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers)
- [msdyn_purchaseorderreceiptproduct_msdyn_approvals](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_approvals)
- [msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts)
- [msdyn_purchaseorderreceiptproduct_SyncErrors](#BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors)
- [msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord)
- [msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord)
- [msdyn_purchaseorderreceiptproduct_AsyncOperations](#BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations)
- [msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders)
- [msdyn_purchaseorderreceiptproduct_UserEntityInstanceDatas](#BKMK_msdyn_purchaseorderreceiptproduct_UserEntityInstanceDatas)
- [msdyn_purchaseorderreceiptproduct_ProcessSession](#BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession)
- [msdyn_purchaseorderreceiptproduct_BulkDeleteFailures](#BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures)
- [msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderreceiptproduct_Appointments](#BKMK_msdyn_purchaseorderreceiptproduct_Appointments)
- [msdyn_purchaseorderreceiptproduct_Emails](#BKMK_msdyn_purchaseorderreceiptproduct_Emails)
- [msdyn_purchaseorderreceiptproduct_Faxes](#BKMK_msdyn_purchaseorderreceiptproduct_Faxes)
- [msdyn_purchaseorderreceiptproduct_Letters](#BKMK_msdyn_purchaseorderreceiptproduct_Letters)
- [msdyn_purchaseorderreceiptproduct_PhoneCalls](#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls)
- [msdyn_purchaseorderreceiptproduct_Tasks](#BKMK_msdyn_purchaseorderreceiptproduct_Tasks)
- [msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceiptproduct_SocialActivities](#BKMK_msdyn_purchaseorderreceiptproduct_SocialActivities)
- [msdyn_purchaseorderreceiptproduct_connections1](#BKMK_msdyn_purchaseorderreceiptproduct_connections1)
- [msdyn_purchaseorderreceiptproduct_connections2](#BKMK_msdyn_purchaseorderreceiptproduct_connections2)
- [msdyn_purchaseorderreceiptproduct_Annotations](#BKMK_msdyn_purchaseorderreceiptproduct_Annotations)
- [msdyn_purchaseorderreceiptproduct_ServiceAppointments](#BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments)
- [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct](#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct)
- [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct](#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct)


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers"></a> msdyn_purchaseorderreceiptproduct_ActivityPointers

Same as activitypointer entity [msdyn_purchaseorderreceiptproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_ActivityPointers<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_approvals"></a> msdyn_purchaseorderreceiptproduct_msdyn_approvals

Same as msdyn_approval entity [msdyn_purchaseorderreceiptproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts"></a> msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors"></a> msdyn_purchaseorderreceiptproduct_SyncErrors

Same as syncerror entity [msdyn_purchaseorderreceiptproduct_SyncErrors](syncerror.md#BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_SyncErrors<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord"></a> msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord"></a> msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations"></a> msdyn_purchaseorderreceiptproduct_AsyncOperations

Same as asyncoperation entity [msdyn_purchaseorderreceiptproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_AsyncOperations<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders"></a> msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_UserEntityInstanceDatas"></a> msdyn_purchaseorderreceiptproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_purchaseorderreceiptproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_purchaseorderreceiptproduct_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession"></a> msdyn_purchaseorderreceiptproduct_ProcessSession

Same as processsession entity [msdyn_purchaseorderreceiptproduct_ProcessSession](processsession.md#BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_ProcessSession<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures"></a> msdyn_purchaseorderreceiptproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_purchaseorderreceiptproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Appointments"></a> msdyn_purchaseorderreceiptproduct_Appointments

Same as appointment entity [msdyn_purchaseorderreceiptproduct_Appointments](appointment.md#BKMK_msdyn_purchaseorderreceiptproduct_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_Appointments<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Emails"></a> msdyn_purchaseorderreceiptproduct_Emails

Same as email entity [msdyn_purchaseorderreceiptproduct_Emails](email.md#BKMK_msdyn_purchaseorderreceiptproduct_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_Emails<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Faxes"></a> msdyn_purchaseorderreceiptproduct_Faxes

Same as fax entity [msdyn_purchaseorderreceiptproduct_Faxes](fax.md#BKMK_msdyn_purchaseorderreceiptproduct_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_Faxes<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Letters"></a> msdyn_purchaseorderreceiptproduct_Letters

Same as letter entity [msdyn_purchaseorderreceiptproduct_Letters](letter.md#BKMK_msdyn_purchaseorderreceiptproduct_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_Letters<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls"></a> msdyn_purchaseorderreceiptproduct_PhoneCalls

Same as phonecall entity [msdyn_purchaseorderreceiptproduct_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_PhoneCalls<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Tasks"></a> msdyn_purchaseorderreceiptproduct_Tasks

Same as task entity [msdyn_purchaseorderreceiptproduct_Tasks](task.md#BKMK_msdyn_purchaseorderreceiptproduct_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_Tasks<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_SocialActivities"></a> msdyn_purchaseorderreceiptproduct_SocialActivities

Same as socialactivity entity [msdyn_purchaseorderreceiptproduct_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseorderreceiptproduct_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_SocialActivities<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_connections1"></a> msdyn_purchaseorderreceiptproduct_connections1

Same as connection entity [msdyn_purchaseorderreceiptproduct_connections1](connection.md#BKMK_msdyn_purchaseorderreceiptproduct_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_connections1<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_connections2"></a> msdyn_purchaseorderreceiptproduct_connections2

Same as connection entity [msdyn_purchaseorderreceiptproduct_connections2](connection.md#BKMK_msdyn_purchaseorderreceiptproduct_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_connections2<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Annotations"></a> msdyn_purchaseorderreceiptproduct_Annotations

Same as annotation entity [msdyn_purchaseorderreceiptproduct_Annotations](annotation.md#BKMK_msdyn_purchaseorderreceiptproduct_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_Annotations<br />
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


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments"></a> msdyn_purchaseorderreceiptproduct_ServiceAppointments

Same as serviceappointment entity [msdyn_purchaseorderreceiptproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceiptproduct_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct"></a> msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct

Same as msdyn_inventoryjournal entity [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: msdyn_purchaseorderreceiptproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct<br />
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


### <a name="BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct"></a> msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct

Same as msdyn_workorderproduct entity [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: msdyn_purchaseorderreceiptproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct<br />
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

- [lk_msdyn_purchaseorderreceiptproduct_createdby](#BKMK_lk_msdyn_purchaseorderreceiptproduct_createdby)
- [lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby](#BKMK_lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby)
- [lk_msdyn_purchaseorderreceiptproduct_modifiedby](#BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedby)
- [lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby](#BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby)
- [user_msdyn_purchaseorderreceiptproduct](#BKMK_user_msdyn_purchaseorderreceiptproduct)
- [team_msdyn_purchaseorderreceiptproduct](#BKMK_team_msdyn_purchaseorderreceiptproduct)
- [business_unit_msdyn_purchaseorderreceiptproduct](#BKMK_business_unit_msdyn_purchaseorderreceiptproduct)
- [TransactionCurrency_msdyn_purchaseorderreceiptproduct](#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct)
- [msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder)
- [msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill](#BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill)
- [msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct](#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct)
- [msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt](#BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt)
- [msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse)
- [msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder)


### <a name="BKMK_lk_msdyn_purchaseorderreceiptproduct_createdby"></a> lk_msdyn_purchaseorderreceiptproduct_createdby

See systemuser Entity [lk_msdyn_purchaseorderreceiptproduct_createdby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceiptproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby"></a> lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedby"></a> lk_msdyn_purchaseorderreceiptproduct_modifiedby

See systemuser Entity [lk_msdyn_purchaseorderreceiptproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby"></a> lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_purchaseorderreceiptproduct"></a> user_msdyn_purchaseorderreceiptproduct

See systemuser Entity [user_msdyn_purchaseorderreceiptproduct](systemuser.md#BKMK_user_msdyn_purchaseorderreceiptproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_purchaseorderreceiptproduct"></a> team_msdyn_purchaseorderreceiptproduct

See team Entity [team_msdyn_purchaseorderreceiptproduct](team.md#BKMK_team_msdyn_purchaseorderreceiptproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_purchaseorderreceiptproduct"></a> business_unit_msdyn_purchaseorderreceiptproduct

See businessunit Entity [business_unit_msdyn_purchaseorderreceiptproduct](businessunit.md#BKMK_business_unit_msdyn_purchaseorderreceiptproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct"></a> TransactionCurrency_msdyn_purchaseorderreceiptproduct

See transactioncurrency Entity [TransactionCurrency_msdyn_purchaseorderreceiptproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder

See msdyn_purchaseorder Entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill"></a> msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill

See msdyn_purchaseorderbill Entity [msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill](msdyn_purchaseorderbill.md#BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct"></a> msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct

See msdyn_purchaseorderproduct Entity [msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt"></a> msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt

See msdyn_purchaseorderreceipt Entity [msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt](msdyn_purchaseorderreceipt.md#BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_purchaseorderreceiptproduct?text=msdyn_purchaseorderreceiptproduct EntityType" />