---
title: "msdyn_agreementinvoiceproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_agreementinvoiceproduct entity."
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
# msdyn_agreementinvoiceproduct Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Specify the booking product invoice for the agreement.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementinvoiceproducts(*msdyn_agreementinvoiceproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_agreementinvoiceproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_agreementinvoiceproducts(*msdyn_agreementinvoiceproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_agreementinvoiceproducts(*msdyn_agreementinvoiceproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_agreementinvoiceproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementinvoiceproducts(*msdyn_agreementinvoiceproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementinvoiceproducts(*msdyn_agreementinvoiceproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Agreement Invoice Product<br />
**DisplayCollectionName**: Agreement Invoice Products<br />
**SchemaName**: msdyn_agreementinvoiceproduct<br />
**CollectionSchemaName**: msdyn_agreementinvoiceproducts<br />
**LogicalName**: msdyn_agreementinvoiceproduct<br />
**LogicalCollectionName**: msdyn_agreementinvoiceproducts<br />
**EntitySetName**: msdyn_agreementinvoiceproducts<br />
**PrimaryIdAttribute**: msdyn_agreementinvoiceproductid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_agreementinvoiceproductId](#BKMK_msdyn_agreementinvoiceproductId)
- [msdyn_AgreementInvoiceSetup](#BKMK_msdyn_AgreementInvoiceSetup)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitAmount](#BKMK_msdyn_UnitAmount)
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


### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

**Description**: Unique identifier for Agreement associated with Agreement Invoice Product.<br />
**DisplayName**: Agreement<br />
**LogicalName**: msdyn_agreement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreement


### <a name="BKMK_msdyn_agreementinvoiceproductId"></a> msdyn_agreementinvoiceproductId

**Description**: Shows the entity instances.<br />
**DisplayName**: Agreement Invoice Product<br />
**LogicalName**: msdyn_agreementinvoiceproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_AgreementInvoiceSetup"></a> msdyn_AgreementInvoiceSetup

**Description**: Unique identifier for Agreement Invoice Setup associated with Agreement Invoice Product.<br />
**DisplayName**: Agreement Invoice Setup<br />
**LogicalName**: msdyn_agreementinvoicesetup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementinvoicesetup


### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

**Description**: Shows the order of this product within the agreement invoice setup.<br />
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

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

**Description**: Unique identifier for Price List associated with Agreement Invoice Product.<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: Unique identifier for Product/Service associated with Agreement Invoice Product.<br />
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
**Type**: Double<br />
**MaxValue**: 1000000000<br />
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


### <a name="BKMK_msdyn_UnitAmount"></a> msdyn_UnitAmount

**Description**: Enter the amount you want to charge the customer per unit.<br />
**DisplayName**: Unit Amount<br />
**LogicalName**: msdyn_unitamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
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

**Description**: Status of the Agreement Invoice Product<br />
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

**Description**: Reason for the status of the Agreement Invoice Product<br />
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
- [msdyn_AgreementInvoiceSetupName](#BKMK_msdyn_AgreementInvoiceSetupName)
- [msdyn_AgreementName](#BKMK_msdyn_AgreementName)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
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


### <a name="BKMK_msdyn_AgreementInvoiceSetupName"></a> msdyn_AgreementInvoiceSetupName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementinvoicesetupname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AgreementName"></a> msdyn_AgreementName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PriceListName"></a> msdyn_PriceListName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_pricelistname<br />
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


### <a name="BKMK_msdyn_unitamount_Base"></a> msdyn_unitamount_Base

**Description**: Shows the value of the unit amount in the base currency.<br />
**DisplayName**: Unit Amount (Base)<br />
**LogicalName**: msdyn_unitamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


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

- [msdyn_agreementinvoiceproduct_ActivityPointers](#BKMK_msdyn_agreementinvoiceproduct_ActivityPointers)
- [msdyn_agreementinvoiceproduct_msdyn_approvals](#BKMK_msdyn_agreementinvoiceproduct_msdyn_approvals)
- [msdyn_agreementinvoiceproduct_msdyn_bookingalerts](#BKMK_msdyn_agreementinvoiceproduct_msdyn_bookingalerts)
- [msdyn_agreementinvoiceproduct_SyncErrors](#BKMK_msdyn_agreementinvoiceproduct_SyncErrors)
- [msdyn_agreementinvoiceproduct_DuplicateMatchingRecord](#BKMK_msdyn_agreementinvoiceproduct_DuplicateMatchingRecord)
- [msdyn_agreementinvoiceproduct_DuplicateBaseRecord](#BKMK_msdyn_agreementinvoiceproduct_DuplicateBaseRecord)
- [msdyn_agreementinvoiceproduct_AsyncOperations](#BKMK_msdyn_agreementinvoiceproduct_AsyncOperations)
- [msdyn_agreementinvoiceproduct_MailboxTrackingFolders](#BKMK_msdyn_agreementinvoiceproduct_MailboxTrackingFolders)
- [msdyn_agreementinvoiceproduct_UserEntityInstanceDatas](#BKMK_msdyn_agreementinvoiceproduct_UserEntityInstanceDatas)
- [msdyn_agreementinvoiceproduct_ProcessSession](#BKMK_msdyn_agreementinvoiceproduct_ProcessSession)
- [msdyn_agreementinvoiceproduct_BulkDeleteFailures](#BKMK_msdyn_agreementinvoiceproduct_BulkDeleteFailures)
- [msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses)
- [msdyn_agreementinvoiceproduct_Appointments](#BKMK_msdyn_agreementinvoiceproduct_Appointments)
- [msdyn_agreementinvoiceproduct_Emails](#BKMK_msdyn_agreementinvoiceproduct_Emails)
- [msdyn_agreementinvoiceproduct_Faxes](#BKMK_msdyn_agreementinvoiceproduct_Faxes)
- [msdyn_agreementinvoiceproduct_Letters](#BKMK_msdyn_agreementinvoiceproduct_Letters)
- [msdyn_agreementinvoiceproduct_PhoneCalls](#BKMK_msdyn_agreementinvoiceproduct_PhoneCalls)
- [msdyn_agreementinvoiceproduct_Tasks](#BKMK_msdyn_agreementinvoiceproduct_Tasks)
- [msdyn_agreementinvoiceproduct_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters)
- [msdyn_agreementinvoiceproduct_SocialActivities](#BKMK_msdyn_agreementinvoiceproduct_SocialActivities)
- [msdyn_agreementinvoiceproduct_connections1](#BKMK_msdyn_agreementinvoiceproduct_connections1)
- [msdyn_agreementinvoiceproduct_connections2](#BKMK_msdyn_agreementinvoiceproduct_connections2)
- [msdyn_agreementinvoiceproduct_Annotations](#BKMK_msdyn_agreementinvoiceproduct_Annotations)
- [msdyn_agreementinvoiceproduct_ServiceAppointments](#BKMK_msdyn_agreementinvoiceproduct_ServiceAppointments)
- [msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct](#BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct)


### <a name="BKMK_msdyn_agreementinvoiceproduct_ActivityPointers"></a> msdyn_agreementinvoiceproduct_ActivityPointers

Same as activitypointer entity [msdyn_agreementinvoiceproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_agreementinvoiceproduct_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_ActivityPointers<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_msdyn_approvals"></a> msdyn_agreementinvoiceproduct_msdyn_approvals

Same as msdyn_approval entity [msdyn_agreementinvoiceproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_agreementinvoiceproduct_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_msdyn_bookingalerts"></a> msdyn_agreementinvoiceproduct_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_agreementinvoiceproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreementinvoiceproduct_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_SyncErrors"></a> msdyn_agreementinvoiceproduct_SyncErrors

Same as syncerror entity [msdyn_agreementinvoiceproduct_SyncErrors](syncerror.md#BKMK_msdyn_agreementinvoiceproduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_SyncErrors<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_DuplicateMatchingRecord"></a> msdyn_agreementinvoiceproduct_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_agreementinvoiceproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreementinvoiceproduct_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_DuplicateBaseRecord"></a> msdyn_agreementinvoiceproduct_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_agreementinvoiceproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreementinvoiceproduct_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_AsyncOperations"></a> msdyn_agreementinvoiceproduct_AsyncOperations

Same as asyncoperation entity [msdyn_agreementinvoiceproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreementinvoiceproduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_AsyncOperations<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_MailboxTrackingFolders"></a> msdyn_agreementinvoiceproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_agreementinvoiceproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreementinvoiceproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_UserEntityInstanceDatas"></a> msdyn_agreementinvoiceproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_agreementinvoiceproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_agreementinvoiceproduct_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_ProcessSession"></a> msdyn_agreementinvoiceproduct_ProcessSession

Same as processsession entity [msdyn_agreementinvoiceproduct_ProcessSession](processsession.md#BKMK_msdyn_agreementinvoiceproduct_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_ProcessSession<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_BulkDeleteFailures"></a> msdyn_agreementinvoiceproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_agreementinvoiceproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreementinvoiceproduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses"></a> msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_Appointments"></a> msdyn_agreementinvoiceproduct_Appointments

Same as appointment entity [msdyn_agreementinvoiceproduct_Appointments](appointment.md#BKMK_msdyn_agreementinvoiceproduct_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_Appointments<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_Emails"></a> msdyn_agreementinvoiceproduct_Emails

Same as email entity [msdyn_agreementinvoiceproduct_Emails](email.md#BKMK_msdyn_agreementinvoiceproduct_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_Emails<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_Faxes"></a> msdyn_agreementinvoiceproduct_Faxes

Same as fax entity [msdyn_agreementinvoiceproduct_Faxes](fax.md#BKMK_msdyn_agreementinvoiceproduct_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_Faxes<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_Letters"></a> msdyn_agreementinvoiceproduct_Letters

Same as letter entity [msdyn_agreementinvoiceproduct_Letters](letter.md#BKMK_msdyn_agreementinvoiceproduct_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_Letters<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_PhoneCalls"></a> msdyn_agreementinvoiceproduct_PhoneCalls

Same as phonecall entity [msdyn_agreementinvoiceproduct_PhoneCalls](phonecall.md#BKMK_msdyn_agreementinvoiceproduct_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_PhoneCalls<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_Tasks"></a> msdyn_agreementinvoiceproduct_Tasks

Same as task entity [msdyn_agreementinvoiceproduct_Tasks](task.md#BKMK_msdyn_agreementinvoiceproduct_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_Tasks<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters"></a> msdyn_agreementinvoiceproduct_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_agreementinvoiceproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_SocialActivities"></a> msdyn_agreementinvoiceproduct_SocialActivities

Same as socialactivity entity [msdyn_agreementinvoiceproduct_SocialActivities](socialactivity.md#BKMK_msdyn_agreementinvoiceproduct_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_SocialActivities<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_connections1"></a> msdyn_agreementinvoiceproduct_connections1

Same as connection entity [msdyn_agreementinvoiceproduct_connections1](connection.md#BKMK_msdyn_agreementinvoiceproduct_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_connections1<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_connections2"></a> msdyn_agreementinvoiceproduct_connections2

Same as connection entity [msdyn_agreementinvoiceproduct_connections2](connection.md#BKMK_msdyn_agreementinvoiceproduct_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_connections2<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_Annotations"></a> msdyn_agreementinvoiceproduct_Annotations

Same as annotation entity [msdyn_agreementinvoiceproduct_Annotations](annotation.md#BKMK_msdyn_agreementinvoiceproduct_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_Annotations<br />
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


### <a name="BKMK_msdyn_agreementinvoiceproduct_ServiceAppointments"></a> msdyn_agreementinvoiceproduct_ServiceAppointments

Same as serviceappointment entity [msdyn_agreementinvoiceproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreementinvoiceproduct_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoiceproduct_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct"></a> msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct

Same as invoicedetail entity [msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct](invoicedetail.md#BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: msdyn_agreementinvoiceproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct<br />
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

- [lk_msdyn_agreementinvoiceproduct_createdby](#BKMK_lk_msdyn_agreementinvoiceproduct_createdby)
- [lk_msdyn_agreementinvoiceproduct_createdonbehalfby](#BKMK_lk_msdyn_agreementinvoiceproduct_createdonbehalfby)
- [lk_msdyn_agreementinvoiceproduct_modifiedby](#BKMK_lk_msdyn_agreementinvoiceproduct_modifiedby)
- [lk_msdyn_agreementinvoiceproduct_modifiedonbehalfby](#BKMK_lk_msdyn_agreementinvoiceproduct_modifiedonbehalfby)
- [user_msdyn_agreementinvoiceproduct](#BKMK_user_msdyn_agreementinvoiceproduct)
- [team_msdyn_agreementinvoiceproduct](#BKMK_team_msdyn_agreementinvoiceproduct)
- [business_unit_msdyn_agreementinvoiceproduct](#BKMK_business_unit_msdyn_agreementinvoiceproduct)
- [TransactionCurrency_msdyn_agreementinvoiceproduct](#BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct)
- [msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement)
- [msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup](#BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup)
- [msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList)
- [msdyn_product_msdyn_agreementinvoiceproduct_Product](#BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product)
- [msdyn_uom_msdyn_agreementinvoiceproduct_Unit](#BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit)


### <a name="BKMK_lk_msdyn_agreementinvoiceproduct_createdby"></a> lk_msdyn_agreementinvoiceproduct_createdby

See systemuser Entity [lk_msdyn_agreementinvoiceproduct_createdby](systemuser.md#BKMK_lk_msdyn_agreementinvoiceproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementinvoiceproduct_createdonbehalfby"></a> lk_msdyn_agreementinvoiceproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_agreementinvoiceproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementinvoiceproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementinvoiceproduct_modifiedby"></a> lk_msdyn_agreementinvoiceproduct_modifiedby

See systemuser Entity [lk_msdyn_agreementinvoiceproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_agreementinvoiceproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementinvoiceproduct_modifiedonbehalfby"></a> lk_msdyn_agreementinvoiceproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_agreementinvoiceproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementinvoiceproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_agreementinvoiceproduct"></a> user_msdyn_agreementinvoiceproduct

See systemuser Entity [user_msdyn_agreementinvoiceproduct](systemuser.md#BKMK_user_msdyn_agreementinvoiceproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_agreementinvoiceproduct"></a> team_msdyn_agreementinvoiceproduct

See team Entity [team_msdyn_agreementinvoiceproduct](team.md#BKMK_team_msdyn_agreementinvoiceproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_agreementinvoiceproduct"></a> business_unit_msdyn_agreementinvoiceproduct

See businessunit Entity [business_unit_msdyn_agreementinvoiceproduct](businessunit.md#BKMK_business_unit_msdyn_agreementinvoiceproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct"></a> TransactionCurrency_msdyn_agreementinvoiceproduct

See transactioncurrency Entity [TransactionCurrency_msdyn_agreementinvoiceproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup"></a> msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup

See msdyn_agreementinvoicesetup Entity [msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup](msdyn_agreementinvoicesetup.md#BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList"></a> msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product"></a> msdyn_product_msdyn_agreementinvoiceproduct_Product

See product Entity [msdyn_product_msdyn_agreementinvoiceproduct_Product](product.md#BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit"></a> msdyn_uom_msdyn_agreementinvoiceproduct_Unit

See uom Entity [msdyn_uom_msdyn_agreementinvoiceproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_agreementinvoiceproduct?text=msdyn_agreementinvoiceproduct EntityType" />