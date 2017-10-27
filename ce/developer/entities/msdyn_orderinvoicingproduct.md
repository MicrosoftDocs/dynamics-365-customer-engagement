---
title: "msdyn_orderinvoicingproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_orderinvoicingproduct entity."
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
# msdyn_orderinvoicingproduct Entity Reference



**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_orderinvoicingproducts(*msdyn_orderinvoicingproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_orderinvoicingproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_orderinvoicingproducts(*msdyn_orderinvoicingproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_orderinvoicingproducts(*msdyn_orderinvoicingproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_orderinvoicingproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_orderinvoicingproducts(*msdyn_orderinvoicingproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_orderinvoicingproducts(*msdyn_orderinvoicingproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Order Invoicing Product<br />
**DisplayCollectionName**: Order Invoicing Products<br />
**SchemaName**: msdyn_orderinvoicingproduct<br />
**CollectionSchemaName**: msdyn_orderinvoicingproducts<br />
**LogicalName**: msdyn_orderinvoicingproduct<br />
**LogicalCollectionName**: msdyn_orderinvoicingproducts<br />
**EntitySetName**: msdyn_orderinvoicingproducts<br />
**PrimaryIdAttribute**: msdyn_orderinvoicingproductid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_orderinvoicingproductId](#BKMK_msdyn_orderinvoicingproductId)
- [msdyn_OrderInvoicingSetup](#BKMK_msdyn_OrderInvoicingSetup)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitPrice](#BKMK_msdyn_UnitPrice)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
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


### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

**Description**: Shows the order of this product within the order invoicing setup.<br />
**DisplayName**: Line Order<br />
**LogicalName**: msdyn_lineorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: The name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_orderinvoicingproductId"></a> msdyn_orderinvoicingproductId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Order invoicing product<br />
**LogicalName**: msdyn_orderinvoicingproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_OrderInvoicingSetup"></a> msdyn_OrderInvoicingSetup

**Description**: The invoicing setup this product belongs to.<br />
**DisplayName**: Order Invoicing Setup<br />
**LogicalName**: msdyn_orderinvoicingsetup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_orderinvoicingsetup


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: The product associated with the transaction.<br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

**Description**: Enter the quantity to bill.<br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

**Description**: The unit that determines the pricing for this product<br />
**DisplayName**: Unit<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_UnitPrice"></a> msdyn_UnitPrice

**Description**: Enter the amount you want to charge the customer per unit.<br />
**DisplayName**: Unit Price<br />
**LogicalName**: msdyn_unitprice<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
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

**Description**: Status of the Order invoicing product<br />
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

**Description**: Reason for the status of the Order invoicing product<br />
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

**Description**: Time zone code that was in use when the record was created.<br />
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
- [msdyn_Amount](#BKMK_msdyn_Amount)
- [msdyn_amount_Base](#BKMK_msdyn_amount_Base)
- [msdyn_OrderInvoicingSetupName](#BKMK_msdyn_OrderInvoicingSetupName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_unitprice_Base](#BKMK_msdyn_unitprice_Base)
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

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the record.<br />
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

**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />
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

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the record.<br />
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


### <a name="BKMK_msdyn_Amount"></a> msdyn_Amount

**Description**: Total sales amount for the product line.<br />
**DisplayName**: Amount<br />
**LogicalName**: msdyn_amount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_amount_Base"></a> msdyn_amount_Base

**Description**: Value of the Amount in base currency.<br />
**DisplayName**: Amount (Base)<br />
**LogicalName**: msdyn_amount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_OrderInvoicingSetupName"></a> msdyn_OrderInvoicingSetupName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_orderinvoicingsetupname<br />
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


### <a name="BKMK_msdyn_unitprice_Base"></a> msdyn_unitprice_Base

**Description**: Value of the Unit Price in base currency.<br />
**DisplayName**: Unit Price (Base)<br />
**LogicalName**: msdyn_unitprice_base<br />
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

- [msdyn_orderinvoicingproduct_SyncErrors](#BKMK_msdyn_orderinvoicingproduct_SyncErrors)
- [msdyn_orderinvoicingproduct_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingproduct_DuplicateMatchingRecord)
- [msdyn_orderinvoicingproduct_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingproduct_DuplicateBaseRecord)
- [msdyn_orderinvoicingproduct_AsyncOperations](#BKMK_msdyn_orderinvoicingproduct_AsyncOperations)
- [msdyn_orderinvoicingproduct_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingproduct_MailboxTrackingFolders)
- [msdyn_orderinvoicingproduct_UserEntityInstanceDatas](#BKMK_msdyn_orderinvoicingproduct_UserEntityInstanceDatas)
- [msdyn_orderinvoicingproduct_ProcessSession](#BKMK_msdyn_orderinvoicingproduct_ProcessSession)
- [msdyn_orderinvoicingproduct_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingproduct_BulkDeleteFailures)
- [msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct](#BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct)


### <a name="BKMK_msdyn_orderinvoicingproduct_SyncErrors"></a> msdyn_orderinvoicingproduct_SyncErrors

Same as syncerror entity [msdyn_orderinvoicingproduct_SyncErrors](syncerror.md#BKMK_msdyn_orderinvoicingproduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingproduct_SyncErrors<br />
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


### <a name="BKMK_msdyn_orderinvoicingproduct_DuplicateMatchingRecord"></a> msdyn_orderinvoicingproduct_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_orderinvoicingproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_orderinvoicingproduct_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingproduct_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_orderinvoicingproduct_DuplicateBaseRecord"></a> msdyn_orderinvoicingproduct_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_orderinvoicingproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_orderinvoicingproduct_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingproduct_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_orderinvoicingproduct_AsyncOperations"></a> msdyn_orderinvoicingproduct_AsyncOperations

Same as asyncoperation entity [msdyn_orderinvoicingproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_orderinvoicingproduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingproduct_AsyncOperations<br />
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


### <a name="BKMK_msdyn_orderinvoicingproduct_MailboxTrackingFolders"></a> msdyn_orderinvoicingproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_orderinvoicingproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_orderinvoicingproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_orderinvoicingproduct_UserEntityInstanceDatas"></a> msdyn_orderinvoicingproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_orderinvoicingproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_orderinvoicingproduct_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingproduct_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_orderinvoicingproduct_ProcessSession"></a> msdyn_orderinvoicingproduct_ProcessSession

Same as processsession entity [msdyn_orderinvoicingproduct_ProcessSession](processsession.md#BKMK_msdyn_orderinvoicingproduct_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingproduct_ProcessSession<br />
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


### <a name="BKMK_msdyn_orderinvoicingproduct_BulkDeleteFailures"></a> msdyn_orderinvoicingproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_orderinvoicingproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_orderinvoicingproduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingproduct_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct"></a> msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct

Same as invoicedetail entity [msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct](invoicedetail.md#BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: msdyn_orderinvoicingproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct<br />
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

- [lk_msdyn_orderinvoicingproduct_createdby](#BKMK_lk_msdyn_orderinvoicingproduct_createdby)
- [lk_msdyn_orderinvoicingproduct_createdonbehalfby](#BKMK_lk_msdyn_orderinvoicingproduct_createdonbehalfby)
- [lk_msdyn_orderinvoicingproduct_modifiedby](#BKMK_lk_msdyn_orderinvoicingproduct_modifiedby)
- [lk_msdyn_orderinvoicingproduct_modifiedonbehalfby](#BKMK_lk_msdyn_orderinvoicingproduct_modifiedonbehalfby)
- [user_msdyn_orderinvoicingproduct](#BKMK_user_msdyn_orderinvoicingproduct)
- [team_msdyn_orderinvoicingproduct](#BKMK_team_msdyn_orderinvoicingproduct)
- [business_unit_msdyn_orderinvoicingproduct](#BKMK_business_unit_msdyn_orderinvoicingproduct)
- [TransactionCurrency_msdyn_orderinvoicingproduct](#BKMK_TransactionCurrency_msdyn_orderinvoicingproduct)
- [msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingproduct_OrderInvoicingSetup](#BKMK_msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingproduct_OrderInvoicingSetup)
- [msdyn_product_msdyn_orderinvoicingproduct_Product](#BKMK_msdyn_product_msdyn_orderinvoicingproduct_Product)
- [msdyn_uom_msdyn_orderinvoicingproduct_Unit](#BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit)


### <a name="BKMK_lk_msdyn_orderinvoicingproduct_createdby"></a> lk_msdyn_orderinvoicingproduct_createdby

See systemuser Entity [lk_msdyn_orderinvoicingproduct_createdby](systemuser.md#BKMK_lk_msdyn_orderinvoicingproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_orderinvoicingproduct_createdonbehalfby"></a> lk_msdyn_orderinvoicingproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_orderinvoicingproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_orderinvoicingproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_orderinvoicingproduct_modifiedby"></a> lk_msdyn_orderinvoicingproduct_modifiedby

See systemuser Entity [lk_msdyn_orderinvoicingproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_orderinvoicingproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_orderinvoicingproduct_modifiedonbehalfby"></a> lk_msdyn_orderinvoicingproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_orderinvoicingproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_orderinvoicingproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_orderinvoicingproduct"></a> user_msdyn_orderinvoicingproduct

See systemuser Entity [user_msdyn_orderinvoicingproduct](systemuser.md#BKMK_user_msdyn_orderinvoicingproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_orderinvoicingproduct"></a> team_msdyn_orderinvoicingproduct

See team Entity [team_msdyn_orderinvoicingproduct](team.md#BKMK_team_msdyn_orderinvoicingproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_orderinvoicingproduct"></a> business_unit_msdyn_orderinvoicingproduct

See businessunit Entity [business_unit_msdyn_orderinvoicingproduct](businessunit.md#BKMK_business_unit_msdyn_orderinvoicingproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_orderinvoicingproduct"></a> TransactionCurrency_msdyn_orderinvoicingproduct

See transactioncurrency Entity [TransactionCurrency_msdyn_orderinvoicingproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_orderinvoicingproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingproduct_OrderInvoicingSetup"></a> msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingproduct_OrderInvoicingSetup

See msdyn_orderinvoicingsetup Entity [msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingproduct_OrderInvoicingSetup](msdyn_orderinvoicingsetup.md#BKMK_msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingproduct_OrderInvoicingSetup) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_orderinvoicingproduct_Product"></a> msdyn_product_msdyn_orderinvoicingproduct_Product

See product Entity [msdyn_product_msdyn_orderinvoicingproduct_Product](product.md#BKMK_msdyn_product_msdyn_orderinvoicingproduct_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit"></a> msdyn_uom_msdyn_orderinvoicingproduct_Unit

See uom Entity [msdyn_uom_msdyn_orderinvoicingproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_orderinvoicingproduct?text=msdyn_orderinvoicingproduct EntityType" />