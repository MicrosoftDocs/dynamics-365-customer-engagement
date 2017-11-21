---
title: "msdyn_purchaseorderbill Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_purchaseorderbill entity."
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
# msdyn_purchaseorderbill Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Specify purchase order bill.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Purchase Order Bill<br />
**DisplayCollectionName**: Purchase Order Bills<br />
**SchemaName**: msdyn_purchaseorderbill<br />
**CollectionSchemaName**: msdyn_purchaseorderbills<br />
**LogicalName**: msdyn_purchaseorderbill<br />
**LogicalCollectionName**: msdyn_purchaseorderbills<br />
**EntitySetName**: msdyn_purchaseorderbills<br />
**PrimaryIdAttribute**: msdyn_purchaseorderbillid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BillDate](#BKMK_msdyn_BillDate)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Note](#BKMK_msdyn_Note)
- [msdyn_PaymentTerm](#BKMK_msdyn_PaymentTerm)
- [msdyn_PurchaseOrder](#BKMK_msdyn_PurchaseOrder)
- [msdyn_purchaseorderbillId](#BKMK_msdyn_purchaseorderbillId)
- [msdyn_ShippingAmount](#BKMK_msdyn_ShippingAmount)
- [msdyn_Subtotal](#BKMK_msdyn_Subtotal)
- [msdyn_TaxAmount](#BKMK_msdyn_TaxAmount)
- [msdyn_TaxCode](#BKMK_msdyn_TaxCode)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_VendorInvoiceNumber](#BKMK_msdyn_VendorInvoiceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [traversedpath](#BKMK_traversedpath)
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


### <a name="BKMK_msdyn_BillDate"></a> msdyn_BillDate

**Description**: <br />
**DisplayName**: Bill Date<br />
**LogicalName**: msdyn_billdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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


### <a name="BKMK_msdyn_Note"></a> msdyn_Note

**Description**: <br />
**DisplayName**: Note<br />
**LogicalName**: msdyn_note<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_PaymentTerm"></a> msdyn_PaymentTerm

**Description**: Unique identifier for Payment Term associated with Purchase Order Bill.<br />
**DisplayName**: Payment Term<br />
**LogicalName**: msdyn_paymentterm<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_paymentterm


### <a name="BKMK_msdyn_PurchaseOrder"></a> msdyn_PurchaseOrder

**Description**: Unique identifier for Purchase Order associated with Purchase Order Bill.<br />
**DisplayName**: Purchase Order<br />
**LogicalName**: msdyn_purchaseorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorder


### <a name="BKMK_msdyn_purchaseorderbillId"></a> msdyn_purchaseorderbillId

**Description**: Shows the entity instances.<br />
**DisplayName**: Purchase Order Bill<br />
**LogicalName**: msdyn_purchaseorderbillid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_ShippingAmount"></a> msdyn_ShippingAmount

**Description**: <br />
**DisplayName**: Shipping Amount<br />
**LogicalName**: msdyn_shippingamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_Subtotal"></a> msdyn_Subtotal

**Description**: <br />
**DisplayName**: Subtotal<br />
**LogicalName**: msdyn_subtotal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 900000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_TaxAmount"></a> msdyn_TaxAmount

**Description**: <br />
**DisplayName**: Tax Amount<br />
**LogicalName**: msdyn_taxamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

**Description**: Unique identifier for Tax Code associated with Purchase Order Bill.<br />
**DisplayName**: Tax Code<br />
**LogicalName**: msdyn_taxcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_taxcode


### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

**Description**: <br />
**DisplayName**: Total Amount<br />
**LogicalName**: msdyn_totalamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_VendorInvoiceNumber"></a> msdyn_VendorInvoiceNumber

**Description**: <br />
**DisplayName**: Vendor Invoice Number<br />
**LogicalName**: msdyn_vendorinvoicenumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_processid"></a> processid

**Description**: Contains the ID of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_stageid"></a> stageid

**Description**: Contains the ID of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Purchase Order Bill<br />
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

**Description**: Reason for the status of the Purchase Order Bill<br />
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


### <a name="BKMK_traversedpath"></a> traversedpath

**Description**: Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


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
- [msdyn_PaymentTermName](#BKMK_msdyn_PaymentTermName)
- [msdyn_PurchaseOrderName](#BKMK_msdyn_PurchaseOrderName)
- [msdyn_shippingamount_Base](#BKMK_msdyn_shippingamount_Base)
- [msdyn_subtotal_Base](#BKMK_msdyn_subtotal_Base)
- [msdyn_taxamount_Base](#BKMK_msdyn_taxamount_Base)
- [msdyn_TaxCodeName](#BKMK_msdyn_TaxCodeName)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
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


### <a name="BKMK_msdyn_PaymentTermName"></a> msdyn_PaymentTermName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_paymenttermname<br />
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


### <a name="BKMK_msdyn_shippingamount_Base"></a> msdyn_shippingamount_Base

**Description**: Shows the value of the shipping amount in the base currency.<br />
**DisplayName**: Shipping Amount (Base)<br />
**LogicalName**: msdyn_shippingamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_subtotal_Base"></a> msdyn_subtotal_Base

**Description**: Shows the value of the subtotal in the base currency.<br />
**DisplayName**: Subtotal (Base)<br />
**LogicalName**: msdyn_subtotal_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_taxamount_Base"></a> msdyn_taxamount_Base

**Description**: Shows the value of the tax amount in the base currency.<br />
**DisplayName**: Tax Amount (Base)<br />
**LogicalName**: msdyn_taxamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_TaxCodeName"></a> msdyn_TaxCodeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_taxcodename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

**Description**: Shows the value of the total amount in the base currency.<br />
**DisplayName**: Total Amount (Base)<br />
**LogicalName**: msdyn_totalamount_base<br />
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

- [msdyn_purchaseorderbill_ActivityPointers](#BKMK_msdyn_purchaseorderbill_ActivityPointers)
- [msdyn_purchaseorderbill_msdyn_approvals](#BKMK_msdyn_purchaseorderbill_msdyn_approvals)
- [msdyn_purchaseorderbill_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderbill_msdyn_bookingalerts)
- [msdyn_purchaseorderbill_SyncErrors](#BKMK_msdyn_purchaseorderbill_SyncErrors)
- [msdyn_purchaseorderbill_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord)
- [msdyn_purchaseorderbill_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord)
- [msdyn_purchaseorderbill_AsyncOperations](#BKMK_msdyn_purchaseorderbill_AsyncOperations)
- [msdyn_purchaseorderbill_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders)
- [msdyn_purchaseorderbill_UserEntityInstanceDatas](#BKMK_msdyn_purchaseorderbill_UserEntityInstanceDatas)
- [msdyn_purchaseorderbill_ProcessSession](#BKMK_msdyn_purchaseorderbill_ProcessSession)
- [msdyn_purchaseorderbill_BulkDeleteFailures](#BKMK_msdyn_purchaseorderbill_BulkDeleteFailures)
- [msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderbill_Appointments](#BKMK_msdyn_purchaseorderbill_Appointments)
- [msdyn_purchaseorderbill_Emails](#BKMK_msdyn_purchaseorderbill_Emails)
- [msdyn_purchaseorderbill_Faxes](#BKMK_msdyn_purchaseorderbill_Faxes)
- [msdyn_purchaseorderbill_Letters](#BKMK_msdyn_purchaseorderbill_Letters)
- [msdyn_purchaseorderbill_PhoneCalls](#BKMK_msdyn_purchaseorderbill_PhoneCalls)
- [msdyn_purchaseorderbill_Tasks](#BKMK_msdyn_purchaseorderbill_Tasks)
- [msdyn_purchaseorderbill_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters)
- [msdyn_purchaseorderbill_SocialActivities](#BKMK_msdyn_purchaseorderbill_SocialActivities)
- [msdyn_purchaseorderbill_connections1](#BKMK_msdyn_purchaseorderbill_connections1)
- [msdyn_purchaseorderbill_connections2](#BKMK_msdyn_purchaseorderbill_connections2)
- [msdyn_purchaseorderbill_Annotations](#BKMK_msdyn_purchaseorderbill_Annotations)
- [msdyn_purchaseorderbill_ServiceAppointments](#BKMK_msdyn_purchaseorderbill_ServiceAppointments)
- [bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](#BKMK_bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799)
- [msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill](#BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill)


### <a name="BKMK_msdyn_purchaseorderbill_ActivityPointers"></a> msdyn_purchaseorderbill_ActivityPointers

Same as activitypointer entity [msdyn_purchaseorderbill_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseorderbill_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_ActivityPointers<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_msdyn_approvals"></a> msdyn_purchaseorderbill_msdyn_approvals

Same as msdyn_approval entity [msdyn_purchaseorderbill_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_purchaseorderbill_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_msdyn_bookingalerts"></a> msdyn_purchaseorderbill_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_purchaseorderbill_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseorderbill_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_SyncErrors"></a> msdyn_purchaseorderbill_SyncErrors

Same as syncerror entity [msdyn_purchaseorderbill_SyncErrors](syncerror.md#BKMK_msdyn_purchaseorderbill_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_SyncErrors<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord"></a> msdyn_purchaseorderbill_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_purchaseorderbill_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord"></a> msdyn_purchaseorderbill_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_purchaseorderbill_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_AsyncOperations"></a> msdyn_purchaseorderbill_AsyncOperations

Same as asyncoperation entity [msdyn_purchaseorderbill_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseorderbill_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_AsyncOperations<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders"></a> msdyn_purchaseorderbill_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_purchaseorderbill_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_UserEntityInstanceDatas"></a> msdyn_purchaseorderbill_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_purchaseorderbill_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_purchaseorderbill_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_ProcessSession"></a> msdyn_purchaseorderbill_ProcessSession

Same as processsession entity [msdyn_purchaseorderbill_ProcessSession](processsession.md#BKMK_msdyn_purchaseorderbill_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_ProcessSession<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_BulkDeleteFailures"></a> msdyn_purchaseorderbill_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_purchaseorderbill_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseorderbill_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_Appointments"></a> msdyn_purchaseorderbill_Appointments

Same as appointment entity [msdyn_purchaseorderbill_Appointments](appointment.md#BKMK_msdyn_purchaseorderbill_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_Appointments<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_Emails"></a> msdyn_purchaseorderbill_Emails

Same as email entity [msdyn_purchaseorderbill_Emails](email.md#BKMK_msdyn_purchaseorderbill_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_Emails<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_Faxes"></a> msdyn_purchaseorderbill_Faxes

Same as fax entity [msdyn_purchaseorderbill_Faxes](fax.md#BKMK_msdyn_purchaseorderbill_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_Faxes<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_Letters"></a> msdyn_purchaseorderbill_Letters

Same as letter entity [msdyn_purchaseorderbill_Letters](letter.md#BKMK_msdyn_purchaseorderbill_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_Letters<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_PhoneCalls"></a> msdyn_purchaseorderbill_PhoneCalls

Same as phonecall entity [msdyn_purchaseorderbill_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseorderbill_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_PhoneCalls<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_Tasks"></a> msdyn_purchaseorderbill_Tasks

Same as task entity [msdyn_purchaseorderbill_Tasks](task.md#BKMK_msdyn_purchaseorderbill_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_Tasks<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters"></a> msdyn_purchaseorderbill_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_purchaseorderbill_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_SocialActivities"></a> msdyn_purchaseorderbill_SocialActivities

Same as socialactivity entity [msdyn_purchaseorderbill_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseorderbill_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_SocialActivities<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_connections1"></a> msdyn_purchaseorderbill_connections1

Same as connection entity [msdyn_purchaseorderbill_connections1](connection.md#BKMK_msdyn_purchaseorderbill_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_connections1<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_connections2"></a> msdyn_purchaseorderbill_connections2

Same as connection entity [msdyn_purchaseorderbill_connections2](connection.md#BKMK_msdyn_purchaseorderbill_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_connections2<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_Annotations"></a> msdyn_purchaseorderbill_Annotations

Same as annotation entity [msdyn_purchaseorderbill_Annotations](annotation.md#BKMK_msdyn_purchaseorderbill_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_Annotations<br />
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


### <a name="BKMK_msdyn_purchaseorderbill_ServiceAppointments"></a> msdyn_purchaseorderbill_ServiceAppointments

Same as serviceappointment entity [msdyn_purchaseorderbill_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseorderbill_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderbill_ServiceAppointments<br />
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


### <a name="BKMK_bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799"></a> bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799

Same as msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 entity [bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />
**ReferencingAttribute**: bpf_msdyn_purchaseorderbillid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: msdyn_purchaseorderbill
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill"></a> msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceiptproduct<br />
**ReferencingAttribute**: msdyn_purchaseorderbill<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill<br />
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

- [lk_msdyn_purchaseorderbill_createdby](#BKMK_lk_msdyn_purchaseorderbill_createdby)
- [lk_msdyn_purchaseorderbill_createdonbehalfby](#BKMK_lk_msdyn_purchaseorderbill_createdonbehalfby)
- [lk_msdyn_purchaseorderbill_modifiedby](#BKMK_lk_msdyn_purchaseorderbill_modifiedby)
- [lk_msdyn_purchaseorderbill_modifiedonbehalfby](#BKMK_lk_msdyn_purchaseorderbill_modifiedonbehalfby)
- [user_msdyn_purchaseorderbill](#BKMK_user_msdyn_purchaseorderbill)
- [team_msdyn_purchaseorderbill](#BKMK_team_msdyn_purchaseorderbill)
- [business_unit_msdyn_purchaseorderbill](#BKMK_business_unit_msdyn_purchaseorderbill)
- [processstage_msdyn_purchaseorderbill](#BKMK_processstage_msdyn_purchaseorderbill)
- [TransactionCurrency_msdyn_purchaseorderbill](#BKMK_TransactionCurrency_msdyn_purchaseorderbill)
- [msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm](#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder)
- [msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode)


### <a name="BKMK_lk_msdyn_purchaseorderbill_createdby"></a> lk_msdyn_purchaseorderbill_createdby

See systemuser Entity [lk_msdyn_purchaseorderbill_createdby](systemuser.md#BKMK_lk_msdyn_purchaseorderbill_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderbill_createdonbehalfby"></a> lk_msdyn_purchaseorderbill_createdonbehalfby

See systemuser Entity [lk_msdyn_purchaseorderbill_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderbill_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderbill_modifiedby"></a> lk_msdyn_purchaseorderbill_modifiedby

See systemuser Entity [lk_msdyn_purchaseorderbill_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseorderbill_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderbill_modifiedonbehalfby"></a> lk_msdyn_purchaseorderbill_modifiedonbehalfby

See systemuser Entity [lk_msdyn_purchaseorderbill_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderbill_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_purchaseorderbill"></a> user_msdyn_purchaseorderbill

See systemuser Entity [user_msdyn_purchaseorderbill](systemuser.md#BKMK_user_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_team_msdyn_purchaseorderbill"></a> team_msdyn_purchaseorderbill

See team Entity [team_msdyn_purchaseorderbill](team.md#BKMK_team_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_purchaseorderbill"></a> business_unit_msdyn_purchaseorderbill

See businessunit Entity [business_unit_msdyn_purchaseorderbill](businessunit.md#BKMK_business_unit_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_purchaseorderbill"></a> processstage_msdyn_purchaseorderbill

See processstage Entity [processstage_msdyn_purchaseorderbill](processstage.md#BKMK_processstage_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderbill"></a> TransactionCurrency_msdyn_purchaseorderbill

See transactioncurrency Entity [TransactionCurrency_msdyn_purchaseorderbill](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm"></a> msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm

See msdyn_paymentterm Entity [msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm](msdyn_paymentterm.md#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder

See msdyn_purchaseorder Entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_purchaseorderbill?text=msdyn_purchaseorderbill EntityType" />