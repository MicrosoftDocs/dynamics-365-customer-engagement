---
title: "msdyn_quotebookingproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotebookingproduct entity."
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
# msdyn_quotebookingproduct Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Provides ability to store information about the products that are associated with Quote Booking Setup

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotebookingproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Quote Booking Product<br />
**DisplayCollectionName**: Quote Booking Products<br />
**SchemaName**: msdyn_quotebookingproduct<br />
**CollectionSchemaName**: msdyn_quotebookingproducts<br />
**LogicalName**: msdyn_quotebookingproduct<br />
**LogicalCollectionName**: msdyn_quotebookingproducts<br />
**EntitySetName**: msdyn_quotebookingproducts<br />
**PrimaryIdAttribute**: msdyn_quotebookingproductid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_currency](#BKMK_msdyn_currency)
- [msdyn_customerasset](#BKMK_msdyn_customerasset)
- [msdyn_EstimatedCost](#BKMK_msdyn_EstimatedCost)
- [msdyn_EstimatedSalesAmount](#BKMK_msdyn_EstimatedSalesAmount)
- [msdyn_Internalflags](#BKMK_msdyn_Internalflags)
- [msdyn_iscopied](#BKMK_msdyn_iscopied)
- [msdyn_lineorder](#BKMK_msdyn_lineorder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_pricelist](#BKMK_msdyn_pricelist)
- [msdyn_product](#BKMK_msdyn_product)
- [msdyn_qtytobill](#BKMK_msdyn_qtytobill)
- [msdyn_quantity](#BKMK_msdyn_quantity)
- [msdyn_quote](#BKMK_msdyn_quote)
- [msdyn_quotebookingincident](#BKMK_msdyn_quotebookingincident)
- [msdyn_quotebookingproductId](#BKMK_msdyn_quotebookingproductId)
- [msdyn_quotebookingsetup](#BKMK_msdyn_quotebookingsetup)
- [msdyn_unit](#BKMK_msdyn_unit)
- [msdyn_unitamount](#BKMK_msdyn_unitamount)
- [msdyn_unitcostamount](#BKMK_msdyn_unitcostamount)
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


### <a name="BKMK_msdyn_currency"></a> msdyn_currency

**Description**: The currency that will be used to charge this product<br />
**DisplayName**: Currency<br />
**LogicalName**: msdyn_currency<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_customerasset"></a> msdyn_customerasset

**Description**: Customer asset related to this Product<br />
**DisplayName**: Customer Asset<br />
**LogicalName**: msdyn_customerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_EstimatedCost"></a> msdyn_EstimatedCost

**Description**: The estimated cost of this quote booking product<br />
**DisplayName**: EstimatedCost<br />
**LogicalName**: msdyn_estimatedcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstimatedSalesAmount"></a> msdyn_EstimatedSalesAmount

**Description**: The estimated sales amount of this quote booking product<br />
**DisplayName**: EstimatedSalesAmount<br />
**LogicalName**: msdyn_estimatedsalesamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_Internalflags"></a> msdyn_Internalflags

**Description**: For internal use only.<br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_Internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_iscopied"></a> msdyn_iscopied

**Description**: Internal use only<br />
**DisplayName**: Is Copied<br />
**LogicalName**: msdyn_iscopied<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_lineorder"></a> msdyn_lineorder

**Description**: Shows the order of this task within the quote booking products.<br />
**DisplayName**: Line Order<br />
**LogicalName**: msdyn_lineorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


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
**MaxLength**: 100


### <a name="BKMK_msdyn_pricelist"></a> msdyn_pricelist

**Description**: Optionally set Price List that will determine the pricing for this product on the Work Order<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_product"></a> msdyn_product

**Description**: Unique identifier for Product/Service associated with Quote Booking Product.<br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_qtytobill"></a> msdyn_qtytobill

**Description**: Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity."<br />
**DisplayName**: Quantity To Bill<br />
**LogicalName**: msdyn_qtytobill<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_quantity"></a> msdyn_quantity

**Description**: Shows the actual quantity of the product.<br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_quote"></a> msdyn_quote

**Description**: Unique identifier for Quote associated with Quote Booking Product.<br />
**DisplayName**: Quote<br />
**LogicalName**: msdyn_quote<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: quote


### <a name="BKMK_msdyn_quotebookingincident"></a> msdyn_quotebookingincident

**Description**: The Quote Booking Incident related to this product<br />
**DisplayName**: Quote Booking Incident<br />
**LogicalName**: msdyn_quotebookingincident<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_quotebookingincident


### <a name="BKMK_msdyn_quotebookingproductId"></a> msdyn_quotebookingproductId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Quote Booking Product<br />
**LogicalName**: msdyn_quotebookingproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_quotebookingsetup"></a> msdyn_quotebookingsetup

**Description**: Unique identifier for Quote Booking Setup associated with Quote  Booking Product.<br />
**DisplayName**: Quote Booking Setup<br />
**LogicalName**: msdyn_quotebookingsetup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_quotebookingsetup


### <a name="BKMK_msdyn_unit"></a> msdyn_unit

**Description**: The unit that determines the pricing for this product when Price List is set<br />
**DisplayName**: Unit<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_unitamount"></a> msdyn_unitamount

**Description**: Enter the amount you wish to charge the customer per unit. This field is optional.<br />
**DisplayName**: Unit Amount<br />
**LogicalName**: msdyn_unitamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_unitcostamount"></a> msdyn_unitcostamount

**Description**: Enter the  unit cost amount. This field is optional.<br />
**DisplayName**: Unit Cost<br />
**LogicalName**: msdyn_unitcostamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


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

**Description**: Status of the Quote Booking Product<br />
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

**Description**: Reason for the status of the Quote Booking Product<br />
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
- [msdyn_currency_Base](#BKMK_msdyn_currency_Base)
- [msdyn_customerassetName](#BKMK_msdyn_customerassetName)
- [msdyn_estimatedcost_Base](#BKMK_msdyn_estimatedcost_Base)
- [msdyn_estimatedsalesamount_Base](#BKMK_msdyn_estimatedsalesamount_Base)
- [msdyn_pricelistName](#BKMK_msdyn_pricelistName)
- [msdyn_productName](#BKMK_msdyn_productName)
- [msdyn_quotebookingincidentName](#BKMK_msdyn_quotebookingincidentName)
- [msdyn_quotebookingsetupName](#BKMK_msdyn_quotebookingsetupName)
- [msdyn_quoteName](#BKMK_msdyn_quoteName)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
- [msdyn_unitcostamount_Base](#BKMK_msdyn_unitcostamount_Base)
- [msdyn_unitName](#BKMK_msdyn_unitName)
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


### <a name="BKMK_msdyn_currency_Base"></a> msdyn_currency_Base

**Description**: Value of the Currency in base currency.<br />
**DisplayName**: Currency (Base)<br />
**LogicalName**: msdyn_currency_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_customerassetName"></a> msdyn_customerassetName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_customerassetname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_estimatedcost_Base"></a> msdyn_estimatedcost_Base

**Description**: Value of the EstimatedCost in base currency.<br />
**DisplayName**: EstimatedCost (Base)<br />
**LogicalName**: msdyn_estimatedcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estimatedsalesamount_Base"></a> msdyn_estimatedsalesamount_Base

**Description**: Value of the EstimatedSalesAmount in base currency.<br />
**DisplayName**: EstimatedSalesAmount (Base)<br />
**LogicalName**: msdyn_estimatedsalesamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_pricelistName"></a> msdyn_pricelistName

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


### <a name="BKMK_msdyn_productName"></a> msdyn_productName

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


### <a name="BKMK_msdyn_quotebookingincidentName"></a> msdyn_quotebookingincidentName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotebookingincidentname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_quotebookingsetupName"></a> msdyn_quotebookingsetupName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotebookingsetupname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_quoteName"></a> msdyn_quoteName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_msdyn_unitamount_Base"></a> msdyn_unitamount_Base

**Description**: Value of the Unit Amount in base currency.<br />
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


### <a name="BKMK_msdyn_unitcostamount_Base"></a> msdyn_unitcostamount_Base

**Description**: Value of the Unit Cost in base currency.<br />
**DisplayName**: Unit Cost (Base)<br />
**LogicalName**: msdyn_unitcostamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_unitName"></a> msdyn_unitName

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

- [msdyn_quotebookingproduct_ActivityPointers](#BKMK_msdyn_quotebookingproduct_ActivityPointers)
- [msdyn_quotebookingproduct_msdyn_approvals](#BKMK_msdyn_quotebookingproduct_msdyn_approvals)
- [msdyn_quotebookingproduct_msdyn_bookingalerts](#BKMK_msdyn_quotebookingproduct_msdyn_bookingalerts)
- [msdyn_quotebookingproduct_SyncErrors](#BKMK_msdyn_quotebookingproduct_SyncErrors)
- [msdyn_quotebookingproduct_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord)
- [msdyn_quotebookingproduct_DuplicateBaseRecord](#BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord)
- [msdyn_quotebookingproduct_AsyncOperations](#BKMK_msdyn_quotebookingproduct_AsyncOperations)
- [msdyn_quotebookingproduct_MailboxTrackingFolders](#BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders)
- [msdyn_quotebookingproduct_UserEntityInstanceDatas](#BKMK_msdyn_quotebookingproduct_UserEntityInstanceDatas)
- [msdyn_quotebookingproduct_ProcessSession](#BKMK_msdyn_quotebookingproduct_ProcessSession)
- [msdyn_quotebookingproduct_BulkDeleteFailures](#BKMK_msdyn_quotebookingproduct_BulkDeleteFailures)
- [msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingproduct_Appointments](#BKMK_msdyn_quotebookingproduct_Appointments)
- [msdyn_quotebookingproduct_Emails](#BKMK_msdyn_quotebookingproduct_Emails)
- [msdyn_quotebookingproduct_Faxes](#BKMK_msdyn_quotebookingproduct_Faxes)
- [msdyn_quotebookingproduct_Letters](#BKMK_msdyn_quotebookingproduct_Letters)
- [msdyn_quotebookingproduct_PhoneCalls](#BKMK_msdyn_quotebookingproduct_PhoneCalls)
- [msdyn_quotebookingproduct_Tasks](#BKMK_msdyn_quotebookingproduct_Tasks)
- [msdyn_quotebookingproduct_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters)
- [msdyn_quotebookingproduct_SocialActivities](#BKMK_msdyn_quotebookingproduct_SocialActivities)
- [msdyn_quotebookingproduct_connections1](#BKMK_msdyn_quotebookingproduct_connections1)
- [msdyn_quotebookingproduct_connections2](#BKMK_msdyn_quotebookingproduct_connections2)
- [msdyn_quotebookingproduct_Annotations](#BKMK_msdyn_quotebookingproduct_Annotations)
- [msdyn_quotebookingproduct_ServiceAppointments](#BKMK_msdyn_quotebookingproduct_ServiceAppointments)


### <a name="BKMK_msdyn_quotebookingproduct_ActivityPointers"></a> msdyn_quotebookingproduct_ActivityPointers

Same as activitypointer entity [msdyn_quotebookingproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_quotebookingproduct_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_ActivityPointers<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_msdyn_approvals"></a> msdyn_quotebookingproduct_msdyn_approvals

Same as msdyn_approval entity [msdyn_quotebookingproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_quotebookingproduct_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_msdyn_bookingalerts"></a> msdyn_quotebookingproduct_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_quotebookingproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_quotebookingproduct_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_SyncErrors"></a> msdyn_quotebookingproduct_SyncErrors

Same as syncerror entity [msdyn_quotebookingproduct_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingproduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_SyncErrors<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord"></a> msdyn_quotebookingproduct_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_quotebookingproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord"></a> msdyn_quotebookingproduct_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_quotebookingproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_AsyncOperations"></a> msdyn_quotebookingproduct_AsyncOperations

Same as asyncoperation entity [msdyn_quotebookingproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingproduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_AsyncOperations<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders"></a> msdyn_quotebookingproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_quotebookingproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_UserEntityInstanceDatas"></a> msdyn_quotebookingproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_quotebookingproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_quotebookingproduct_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_ProcessSession"></a> msdyn_quotebookingproduct_ProcessSession

Same as processsession entity [msdyn_quotebookingproduct_ProcessSession](processsession.md#BKMK_msdyn_quotebookingproduct_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_ProcessSession<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_BulkDeleteFailures"></a> msdyn_quotebookingproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_quotebookingproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingproduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_Appointments"></a> msdyn_quotebookingproduct_Appointments

Same as appointment entity [msdyn_quotebookingproduct_Appointments](appointment.md#BKMK_msdyn_quotebookingproduct_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_Appointments<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_Emails"></a> msdyn_quotebookingproduct_Emails

Same as email entity [msdyn_quotebookingproduct_Emails](email.md#BKMK_msdyn_quotebookingproduct_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_Emails<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_Faxes"></a> msdyn_quotebookingproduct_Faxes

Same as fax entity [msdyn_quotebookingproduct_Faxes](fax.md#BKMK_msdyn_quotebookingproduct_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_Faxes<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_Letters"></a> msdyn_quotebookingproduct_Letters

Same as letter entity [msdyn_quotebookingproduct_Letters](letter.md#BKMK_msdyn_quotebookingproduct_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_Letters<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_PhoneCalls"></a> msdyn_quotebookingproduct_PhoneCalls

Same as phonecall entity [msdyn_quotebookingproduct_PhoneCalls](phonecall.md#BKMK_msdyn_quotebookingproduct_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_PhoneCalls<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_Tasks"></a> msdyn_quotebookingproduct_Tasks

Same as task entity [msdyn_quotebookingproduct_Tasks](task.md#BKMK_msdyn_quotebookingproduct_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_Tasks<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters"></a> msdyn_quotebookingproduct_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_quotebookingproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_SocialActivities"></a> msdyn_quotebookingproduct_SocialActivities

Same as socialactivity entity [msdyn_quotebookingproduct_SocialActivities](socialactivity.md#BKMK_msdyn_quotebookingproduct_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_SocialActivities<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_connections1"></a> msdyn_quotebookingproduct_connections1

Same as connection entity [msdyn_quotebookingproduct_connections1](connection.md#BKMK_msdyn_quotebookingproduct_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_connections1<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_connections2"></a> msdyn_quotebookingproduct_connections2

Same as connection entity [msdyn_quotebookingproduct_connections2](connection.md#BKMK_msdyn_quotebookingproduct_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_connections2<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_Annotations"></a> msdyn_quotebookingproduct_Annotations

Same as annotation entity [msdyn_quotebookingproduct_Annotations](annotation.md#BKMK_msdyn_quotebookingproduct_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_Annotations<br />
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


### <a name="BKMK_msdyn_quotebookingproduct_ServiceAppointments"></a> msdyn_quotebookingproduct_ServiceAppointments

Same as serviceappointment entity [msdyn_quotebookingproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_quotebookingproduct_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingproduct_ServiceAppointments<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_quotebookingproduct_createdby](#BKMK_lk_msdyn_quotebookingproduct_createdby)
- [lk_msdyn_quotebookingproduct_createdonbehalfby](#BKMK_lk_msdyn_quotebookingproduct_createdonbehalfby)
- [lk_msdyn_quotebookingproduct_modifiedby](#BKMK_lk_msdyn_quotebookingproduct_modifiedby)
- [lk_msdyn_quotebookingproduct_modifiedonbehalfby](#BKMK_lk_msdyn_quotebookingproduct_modifiedonbehalfby)
- [user_msdyn_quotebookingproduct](#BKMK_user_msdyn_quotebookingproduct)
- [team_msdyn_quotebookingproduct](#BKMK_team_msdyn_quotebookingproduct)
- [business_unit_msdyn_quotebookingproduct](#BKMK_business_unit_msdyn_quotebookingproduct)
- [TransactionCurrency_msdyn_quotebookingproduct](#BKMK_TransactionCurrency_msdyn_quotebookingproduct)
- [msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup)
- [msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList)
- [msdyn_product_msdyn_quotebookingproduct_Product](#BKMK_msdyn_product_msdyn_quotebookingproduct_Product)
- [msdyn_quote_msdyn_quotebookingproduct_Quote](#BKMK_msdyn_quote_msdyn_quotebookingproduct_Quote)
- [msdyn_uom_msdyn_quotebookingproduct_Unit](#BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit)


### <a name="BKMK_lk_msdyn_quotebookingproduct_createdby"></a> lk_msdyn_quotebookingproduct_createdby

See systemuser Entity [lk_msdyn_quotebookingproduct_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingproduct_createdonbehalfby"></a> lk_msdyn_quotebookingproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_quotebookingproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingproduct_modifiedby"></a> lk_msdyn_quotebookingproduct_modifiedby

See systemuser Entity [lk_msdyn_quotebookingproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingproduct_modifiedonbehalfby"></a> lk_msdyn_quotebookingproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_quotebookingproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotebookingproduct"></a> user_msdyn_quotebookingproduct

See systemuser Entity [user_msdyn_quotebookingproduct](systemuser.md#BKMK_user_msdyn_quotebookingproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotebookingproduct"></a> team_msdyn_quotebookingproduct

See team Entity [team_msdyn_quotebookingproduct](team.md#BKMK_team_msdyn_quotebookingproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotebookingproduct"></a> business_unit_msdyn_quotebookingproduct

See businessunit Entity [business_unit_msdyn_quotebookingproduct](businessunit.md#BKMK_business_unit_msdyn_quotebookingproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingproduct"></a> TransactionCurrency_msdyn_quotebookingproduct

See transactioncurrency Entity [TransactionCurrency_msdyn_quotebookingproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotebookingproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident

See msdyn_quotebookingincident Entity [msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup

See msdyn_quotebookingsetup Entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](msdyn_quotebookingsetup.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList"></a> msdyn_pricelevel_msdyn_quotebookingproduct_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_quotebookingproduct_Product"></a> msdyn_product_msdyn_quotebookingproduct_Product

See product Entity [msdyn_product_msdyn_quotebookingproduct_Product](product.md#BKMK_msdyn_product_msdyn_quotebookingproduct_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_quote_msdyn_quotebookingproduct_Quote"></a> msdyn_quote_msdyn_quotebookingproduct_Quote

See quote Entity [msdyn_quote_msdyn_quotebookingproduct_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingproduct_Quote) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit"></a> msdyn_uom_msdyn_quotebookingproduct_Unit

See uom Entity [msdyn_uom_msdyn_quotebookingproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotebookingproduct?text=msdyn_quotebookingproduct EntityType" />