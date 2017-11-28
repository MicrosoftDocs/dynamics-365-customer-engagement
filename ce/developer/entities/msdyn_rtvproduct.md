---
title: "msdyn_rtvproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_rtvproduct entity."
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
# msdyn_rtvproduct Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Records products to be returned on an RTV

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_rtvproducts(*msdyn_rtvproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_rtvproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_rtvproducts(*msdyn_rtvproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_rtvproducts(*msdyn_rtvproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_rtvproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_rtvproducts(*msdyn_rtvproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_rtvproducts(*msdyn_rtvproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: RTV Product<br />
**DisplayCollectionName**: RTV Products<br />
**SchemaName**: msdyn_rtvproduct<br />
**CollectionSchemaName**: msdyn_rtvproducts<br />
**LogicalName**: msdyn_rtvproduct<br />
**LogicalCollectionName**: msdyn_rtvproducts<br />
**EntitySetName**: msdyn_rtvproducts<br />
**PrimaryIdAttribute**: msdyn_rtvproductid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_RMA](#BKMK_msdyn_RMA)
- [msdyn_RMAProduct](#BKMK_msdyn_RMAProduct)
- [msdyn_RTV](#BKMK_msdyn_RTV)
- [msdyn_rtvproductId](#BKMK_msdyn_rtvproductId)
- [msdyn_TotalCreditAmount](#BKMK_msdyn_TotalCreditAmount)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitCreditAmount](#BKMK_msdyn_UnitCreditAmount)
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_WorkOrderProduct](#BKMK_msdyn_WorkOrderProduct)
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


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

**Description**: Type a description of the product.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

**Description**: Shows the order of this product within the RTV.<br />
**DisplayName**: Line Order<br />
**LogicalName**: msdyn_lineorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


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


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: Product to return<br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

**Description**: Enter the quantity returned.<br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_RMA"></a> msdyn_RMA

**Description**: Originating RMA if item was returned from customer<br />
**DisplayName**: RMA<br />
**LogicalName**: msdyn_rma<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_rma


### <a name="BKMK_msdyn_RMAProduct"></a> msdyn_RMAProduct

**Description**: Originating RMA Product if item was returned from customer<br />
**DisplayName**: RMA Product<br />
**LogicalName**: msdyn_rmaproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_rmaproduct


### <a name="BKMK_msdyn_RTV"></a> msdyn_RTV

**Description**: RTV this line item relates to<br />
**DisplayName**: RTV<br />
**LogicalName**: msdyn_rtv<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_rtv


### <a name="BKMK_msdyn_rtvproductId"></a> msdyn_rtvproductId

**Description**: Shows the entity instances.<br />
**DisplayName**: RTV Product<br />
**LogicalName**: msdyn_rtvproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_TotalCreditAmount"></a> msdyn_TotalCreditAmount

**Description**: Shows the total Amount to be credited on this item.<br />
**DisplayName**: Total Credit Amount<br />
**LogicalName**: msdyn_totalcreditamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 0


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

**Description**: Unit for this product<br />
**DisplayName**: Unit<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_UnitCreditAmount"></a> msdyn_UnitCreditAmount

**Description**: Enter the unit amount to be credited.<br />
**DisplayName**: Unit Credit Amount<br />
**LogicalName**: msdyn_unitcreditamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 0


### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

**Description**: Warehouse from where this product is returned<br />
**DisplayName**: Warehouse<br />
**LogicalName**: msdyn_warehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Description**: Originating Work Order if item was returned from customer<br />
**DisplayName**: Work Order<br />
**LogicalName**: msdyn_workorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_msdyn_WorkOrderProduct"></a> msdyn_WorkOrderProduct

**Description**: Originating Work Order Product if item was returned from customer<br />
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

**Description**: Status of the RTV Product<br />
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

**Description**: Reason for the status of the RTV Product<br />
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
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_RMAName](#BKMK_msdyn_RMAName)
- [msdyn_RMAProductName](#BKMK_msdyn_RMAProductName)
- [msdyn_RTVName](#BKMK_msdyn_RTVName)
- [msdyn_totalcreditamount_Base](#BKMK_msdyn_totalcreditamount_Base)
- [msdyn_unitcreditamount_Base](#BKMK_msdyn_unitcreditamount_Base)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_WarehouseName](#BKMK_msdyn_WarehouseName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
- [msdyn_WorkOrderProductName](#BKMK_msdyn_WorkOrderProductName)
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


### <a name="BKMK_msdyn_RMAName"></a> msdyn_RMAName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rmaname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RMAProductName"></a> msdyn_RMAProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rmaproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RTVName"></a> msdyn_RTVName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rtvname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_totalcreditamount_Base"></a> msdyn_totalcreditamount_Base

**Description**: Shows the value of the total credit amount in the base currency.<br />
**DisplayName**: Total Credit Amount (Base)<br />
**LogicalName**: msdyn_totalcreditamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 0


### <a name="BKMK_msdyn_unitcreditamount_Base"></a> msdyn_unitcreditamount_Base

**Description**: Shows the value of the unit credit amount in the base currency.<br />
**DisplayName**: Unit Credit Amount (Base)<br />
**LogicalName**: msdyn_unitcreditamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 0


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


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workordername<br />
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

- [msdyn_rtvproduct_ActivityPointers](#BKMK_msdyn_rtvproduct_ActivityPointers)
- [msdyn_rtvproduct_msdyn_approvals](#BKMK_msdyn_rtvproduct_msdyn_approvals)
- [msdyn_rtvproduct_msdyn_bookingalerts](#BKMK_msdyn_rtvproduct_msdyn_bookingalerts)
- [msdyn_rtvproduct_SyncErrors](#BKMK_msdyn_rtvproduct_SyncErrors)
- [msdyn_rtvproduct_DuplicateMatchingRecord](#BKMK_msdyn_rtvproduct_DuplicateMatchingRecord)
- [msdyn_rtvproduct_DuplicateBaseRecord](#BKMK_msdyn_rtvproduct_DuplicateBaseRecord)
- [msdyn_rtvproduct_AsyncOperations](#BKMK_msdyn_rtvproduct_AsyncOperations)
- [msdyn_rtvproduct_MailboxTrackingFolders](#BKMK_msdyn_rtvproduct_MailboxTrackingFolders)
- [msdyn_rtvproduct_UserEntityInstanceDatas](#BKMK_msdyn_rtvproduct_UserEntityInstanceDatas)
- [msdyn_rtvproduct_ProcessSession](#BKMK_msdyn_rtvproduct_ProcessSession)
- [msdyn_rtvproduct_BulkDeleteFailures](#BKMK_msdyn_rtvproduct_BulkDeleteFailures)
- [msdyn_rtvproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtvproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rtvproduct_Appointments](#BKMK_msdyn_rtvproduct_Appointments)
- [msdyn_rtvproduct_Emails](#BKMK_msdyn_rtvproduct_Emails)
- [msdyn_rtvproduct_Faxes](#BKMK_msdyn_rtvproduct_Faxes)
- [msdyn_rtvproduct_Letters](#BKMK_msdyn_rtvproduct_Letters)
- [msdyn_rtvproduct_PhoneCalls](#BKMK_msdyn_rtvproduct_PhoneCalls)
- [msdyn_rtvproduct_Tasks](#BKMK_msdyn_rtvproduct_Tasks)
- [msdyn_rtvproduct_RecurringAppointmentMasters](#BKMK_msdyn_rtvproduct_RecurringAppointmentMasters)
- [msdyn_rtvproduct_SocialActivities](#BKMK_msdyn_rtvproduct_SocialActivities)
- [msdyn_rtvproduct_connections1](#BKMK_msdyn_rtvproduct_connections1)
- [msdyn_rtvproduct_connections2](#BKMK_msdyn_rtvproduct_connections2)
- [msdyn_rtvproduct_Annotations](#BKMK_msdyn_rtvproduct_Annotations)
- [msdyn_rtvproduct_ServiceAppointments](#BKMK_msdyn_rtvproduct_ServiceAppointments)
- [msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct](#BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct)


### <a name="BKMK_msdyn_rtvproduct_ActivityPointers"></a> msdyn_rtvproduct_ActivityPointers

Same as activitypointer entity [msdyn_rtvproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_rtvproduct_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_ActivityPointers<br />
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


### <a name="BKMK_msdyn_rtvproduct_msdyn_approvals"></a> msdyn_rtvproduct_msdyn_approvals

Same as msdyn_approval entity [msdyn_rtvproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_rtvproduct_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_rtvproduct_msdyn_bookingalerts"></a> msdyn_rtvproduct_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_rtvproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rtvproduct_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_rtvproduct_SyncErrors"></a> msdyn_rtvproduct_SyncErrors

Same as syncerror entity [msdyn_rtvproduct_SyncErrors](syncerror.md#BKMK_msdyn_rtvproduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_SyncErrors<br />
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


### <a name="BKMK_msdyn_rtvproduct_DuplicateMatchingRecord"></a> msdyn_rtvproduct_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_rtvproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rtvproduct_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_rtvproduct_DuplicateBaseRecord"></a> msdyn_rtvproduct_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_rtvproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rtvproduct_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_rtvproduct_AsyncOperations"></a> msdyn_rtvproduct_AsyncOperations

Same as asyncoperation entity [msdyn_rtvproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_rtvproduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_AsyncOperations<br />
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


### <a name="BKMK_msdyn_rtvproduct_MailboxTrackingFolders"></a> msdyn_rtvproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_rtvproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rtvproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_rtvproduct_UserEntityInstanceDatas"></a> msdyn_rtvproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_rtvproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_rtvproduct_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_rtvproduct_ProcessSession"></a> msdyn_rtvproduct_ProcessSession

Same as processsession entity [msdyn_rtvproduct_ProcessSession](processsession.md#BKMK_msdyn_rtvproduct_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_ProcessSession<br />
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


### <a name="BKMK_msdyn_rtvproduct_BulkDeleteFailures"></a> msdyn_rtvproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_rtvproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rtvproduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_rtvproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rtvproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_rtvproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rtvproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_rtvproduct_Appointments"></a> msdyn_rtvproduct_Appointments

Same as appointment entity [msdyn_rtvproduct_Appointments](appointment.md#BKMK_msdyn_rtvproduct_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_Appointments<br />
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


### <a name="BKMK_msdyn_rtvproduct_Emails"></a> msdyn_rtvproduct_Emails

Same as email entity [msdyn_rtvproduct_Emails](email.md#BKMK_msdyn_rtvproduct_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_Emails<br />
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


### <a name="BKMK_msdyn_rtvproduct_Faxes"></a> msdyn_rtvproduct_Faxes

Same as fax entity [msdyn_rtvproduct_Faxes](fax.md#BKMK_msdyn_rtvproduct_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_Faxes<br />
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


### <a name="BKMK_msdyn_rtvproduct_Letters"></a> msdyn_rtvproduct_Letters

Same as letter entity [msdyn_rtvproduct_Letters](letter.md#BKMK_msdyn_rtvproduct_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_Letters<br />
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


### <a name="BKMK_msdyn_rtvproduct_PhoneCalls"></a> msdyn_rtvproduct_PhoneCalls

Same as phonecall entity [msdyn_rtvproduct_PhoneCalls](phonecall.md#BKMK_msdyn_rtvproduct_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_PhoneCalls<br />
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


### <a name="BKMK_msdyn_rtvproduct_Tasks"></a> msdyn_rtvproduct_Tasks

Same as task entity [msdyn_rtvproduct_Tasks](task.md#BKMK_msdyn_rtvproduct_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_Tasks<br />
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


### <a name="BKMK_msdyn_rtvproduct_RecurringAppointmentMasters"></a> msdyn_rtvproduct_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_rtvproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rtvproduct_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_rtvproduct_SocialActivities"></a> msdyn_rtvproduct_SocialActivities

Same as socialactivity entity [msdyn_rtvproduct_SocialActivities](socialactivity.md#BKMK_msdyn_rtvproduct_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_SocialActivities<br />
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


### <a name="BKMK_msdyn_rtvproduct_connections1"></a> msdyn_rtvproduct_connections1

Same as connection entity [msdyn_rtvproduct_connections1](connection.md#BKMK_msdyn_rtvproduct_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_connections1<br />
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


### <a name="BKMK_msdyn_rtvproduct_connections2"></a> msdyn_rtvproduct_connections2

Same as connection entity [msdyn_rtvproduct_connections2](connection.md#BKMK_msdyn_rtvproduct_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_connections2<br />
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


### <a name="BKMK_msdyn_rtvproduct_Annotations"></a> msdyn_rtvproduct_Annotations

Same as annotation entity [msdyn_rtvproduct_Annotations](annotation.md#BKMK_msdyn_rtvproduct_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_Annotations<br />
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


### <a name="BKMK_msdyn_rtvproduct_ServiceAppointments"></a> msdyn_rtvproduct_ServiceAppointments

Same as serviceappointment entity [msdyn_rtvproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rtvproduct_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtvproduct_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct"></a> msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct

Same as msdyn_rmareceiptproduct entity [msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct](msdyn_rmareceiptproduct.md#BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmareceiptproduct<br />
**ReferencingAttribute**: msdyn_rtvproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct<br />
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

- [lk_msdyn_rtvproduct_createdby](#BKMK_lk_msdyn_rtvproduct_createdby)
- [lk_msdyn_rtvproduct_createdonbehalfby](#BKMK_lk_msdyn_rtvproduct_createdonbehalfby)
- [lk_msdyn_rtvproduct_modifiedby](#BKMK_lk_msdyn_rtvproduct_modifiedby)
- [lk_msdyn_rtvproduct_modifiedonbehalfby](#BKMK_lk_msdyn_rtvproduct_modifiedonbehalfby)
- [user_msdyn_rtvproduct](#BKMK_user_msdyn_rtvproduct)
- [team_msdyn_rtvproduct](#BKMK_team_msdyn_rtvproduct)
- [business_unit_msdyn_rtvproduct](#BKMK_business_unit_msdyn_rtvproduct)
- [TransactionCurrency_msdyn_rtvproduct](#BKMK_TransactionCurrency_msdyn_rtvproduct)
- [msdyn_msdyn_rma_msdyn_rtvproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rtvproduct_RMA)
- [msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct](#BKMK_msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct)
- [msdyn_msdyn_rtv_msdyn_rtvproduct_RTV](#BKMK_msdyn_msdyn_rtv_msdyn_rtvproduct_RTV)
- [msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse)
- [msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder)
- [msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct)
- [msdyn_product_msdyn_rtvproduct_Product](#BKMK_msdyn_product_msdyn_rtvproduct_Product)
- [msdyn_uom_msdyn_rtvproduct_Unit](#BKMK_msdyn_uom_msdyn_rtvproduct_Unit)


### <a name="BKMK_lk_msdyn_rtvproduct_createdby"></a> lk_msdyn_rtvproduct_createdby

See systemuser Entity [lk_msdyn_rtvproduct_createdby](systemuser.md#BKMK_lk_msdyn_rtvproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rtvproduct_createdonbehalfby"></a> lk_msdyn_rtvproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_rtvproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rtvproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rtvproduct_modifiedby"></a> lk_msdyn_rtvproduct_modifiedby

See systemuser Entity [lk_msdyn_rtvproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_rtvproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rtvproduct_modifiedonbehalfby"></a> lk_msdyn_rtvproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_rtvproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rtvproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_rtvproduct"></a> user_msdyn_rtvproduct

See systemuser Entity [user_msdyn_rtvproduct](systemuser.md#BKMK_user_msdyn_rtvproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_rtvproduct"></a> team_msdyn_rtvproduct

See team Entity [team_msdyn_rtvproduct](team.md#BKMK_team_msdyn_rtvproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_rtvproduct"></a> business_unit_msdyn_rtvproduct

See businessunit Entity [business_unit_msdyn_rtvproduct](businessunit.md#BKMK_business_unit_msdyn_rtvproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_rtvproduct"></a> TransactionCurrency_msdyn_rtvproduct

See transactioncurrency Entity [TransactionCurrency_msdyn_rtvproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_rtvproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rtvproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rtvproduct_RMA

See msdyn_rma Entity [msdyn_msdyn_rma_msdyn_rtvproduct_RMA](msdyn_rma.md#BKMK_msdyn_msdyn_rma_msdyn_rtvproduct_RMA) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct"></a> msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct

See msdyn_rmaproduct Entity [msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rtv_msdyn_rtvproduct_RTV"></a> msdyn_msdyn_rtv_msdyn_rtvproduct_RTV

See msdyn_rtv Entity [msdyn_msdyn_rtv_msdyn_rtvproduct_RTV](msdyn_rtv.md#BKMK_msdyn_msdyn_rtv_msdyn_rtvproduct_RTV) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct

See msdyn_workorderproduct Entity [msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_rtvproduct_Product"></a> msdyn_product_msdyn_rtvproduct_Product

See product Entity [msdyn_product_msdyn_rtvproduct_Product](product.md#BKMK_msdyn_product_msdyn_rtvproduct_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_rtvproduct_Unit"></a> msdyn_uom_msdyn_rtvproduct_Unit

See uom Entity [msdyn_uom_msdyn_rtvproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_rtvproduct_Unit) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_rtvproduct?text=msdyn_rtvproduct EntityType" />