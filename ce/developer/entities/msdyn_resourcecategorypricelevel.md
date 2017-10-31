---
title: "msdyn_resourcecategorypricelevel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_resourcecategorypricelevel entity."
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
# msdyn_resourcecategorypricelevel Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

List of prices by role on a price list.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels(*msdyn_resourcecategorypricelevelid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels(*msdyn_resourcecategorypricelevelid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels(*msdyn_resourcecategorypricelevelid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcecategorypricelevels(*msdyn_resourcecategorypricelevelid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Role Price<br />
**DisplayCollectionName**: Role Prices<br />
**SchemaName**: msdyn_resourcecategorypricelevel<br />
**CollectionSchemaName**: msdyn_resourcecategorypricelevels<br />
**LogicalName**: msdyn_resourcecategorypricelevel<br />
**LogicalCollectionName**: msdyn_resourcecategorypricelevels<br />
**EntitySetName**: msdyn_resourcecategorypricelevels<br />
**PrimaryIdAttribute**: msdyn_resourcecategorypricelevelid<br />
**PrimaryNameAttribute**: msdyn_description<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_organizationalunit](#BKMK_msdyn_organizationalunit)
- [msdyn_percent](#BKMK_msdyn_percent)
- [msdyn_Price](#BKMK_msdyn_Price)
- [msdyn_pricecalculation](#BKMK_msdyn_pricecalculation)
- [msdyn_PriceInPrimaryUnit](#BKMK_msdyn_PriceInPrimaryUnit)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_PrimaryUnit](#BKMK_msdyn_PrimaryUnit)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_resourcecategorypricelevelId](#BKMK_msdyn_resourcecategorypricelevelId)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitSchedule](#BKMK_msdyn_UnitSchedule)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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


### <a name="BKMK_msdyn_description"></a> msdyn_description

**Description**: Type the name of the custom entity.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_organizationalunit"></a> msdyn_organizationalunit

**Description**: Select the organizational unit of the resource performing the work.<br />
**DisplayName**: Resourcing Unit<br />
**LogicalName**: msdyn_organizationalunit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_organizationalunit


### <a name="BKMK_msdyn_percent"></a> msdyn_percent

**Description**: Enter the markup percent over cost. This field is relevant only when the price calculation method selected is "Markup over cost."<br />
**DisplayName**: Percent<br />
**LogicalName**: msdyn_percent<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100<br />
**Precision**: 2


### <a name="BKMK_msdyn_Price"></a> msdyn_Price

**Description**: Enter the price in time units of the role.<br />
**DisplayName**: Price<br />
**LogicalName**: msdyn_price<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: -1000000000<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_pricecalculation"></a> msdyn_pricecalculation

**Description**: Select the price calculation method to determine the price as a function of cost. This field is only relevant for expense categories.<br />
**DisplayName**: Price Calculation<br />
**LogicalName**: msdyn_pricecalculation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Price per unit
- **Value**: 192350001 **Label**: At cost
- **Value**: 192350002 **Label**: Markup percentage



### <a name="BKMK_msdyn_PriceInPrimaryUnit"></a> msdyn_PriceInPrimaryUnit

**Description**: Value of the price in primary unit of the unit group<br />
**DisplayName**: Price In Primary Unit<br />
**LogicalName**: msdyn_priceinprimaryunit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

**Description**: Select the price list to which this price list item is being added.<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_PrimaryUnit"></a> msdyn_PrimaryUnit

**Description**: Select the primary unit of the unit schedule selected.<br />
**DisplayName**: Primary Unit<br />
**LogicalName**: msdyn_primaryunit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_ResourceCategory"></a> msdyn_ResourceCategory

**Description**: Select the role that the price is being set for.<br />
**DisplayName**: Role<br />
**LogicalName**: msdyn_resourcecategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecategory


### <a name="BKMK_msdyn_resourcecategorypricelevelId"></a> msdyn_resourcecategorypricelevelId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Resource Category Price<br />
**LogicalName**: msdyn_resourcecategorypricelevelid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

**Description**: Select the units of time in which role is being priced.<br />
**DisplayName**: Unit<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_UnitSchedule"></a> msdyn_UnitSchedule

**Description**: Select the unit schedule of the time unit selected.<br />
**DisplayName**: Unit Schedule<br />
**LogicalName**: msdyn_unitschedule<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uomschedule


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


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Resource Category Price<br />
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

**Description**: Reason for the status of the Resource Category Price<br />
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

**Description**: Shows the currency associated with the entity.<br />
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
- [msdyn_organizationalunitName](#BKMK_msdyn_organizationalunitName)
- [msdyn_price_Base](#BKMK_msdyn_price_Base)
- [msdyn_priceinprimaryunit_Base](#BKMK_msdyn_priceinprimaryunit_Base)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_PrimaryUnitName](#BKMK_msdyn_PrimaryUnitName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_UnitScheduleName](#BKMK_msdyn_UnitScheduleName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
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


### <a name="BKMK_msdyn_organizationalunitName"></a> msdyn_organizationalunitName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_organizationalunitname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_price_Base"></a> msdyn_price_Base

**Description**: Value of the Price in base currency.<br />
**DisplayName**: Price (Base)<br />
**LogicalName**: msdyn_price_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_priceinprimaryunit_Base"></a> msdyn_priceinprimaryunit_Base

**Description**: Value of the Price In Primary Unit in base currency.<br />
**DisplayName**: Price In Primary Unit (Base)<br />
**LogicalName**: msdyn_priceinprimaryunit_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


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


### <a name="BKMK_msdyn_PrimaryUnitName"></a> msdyn_PrimaryUnitName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_primaryunitname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ResourceCategoryName"></a> msdyn_ResourceCategoryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcecategoryname<br />
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


### <a name="BKMK_msdyn_UnitScheduleName"></a> msdyn_UnitScheduleName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_unitschedulename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier for the organization<br />
**DisplayName**: Organization Id<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [msdyn_resourcecategorypricelevel_SyncErrors](#BKMK_msdyn_resourcecategorypricelevel_SyncErrors)
- [msdyn_resourcecategorypricelevel_DuplicateMatchingRecord](#BKMK_msdyn_resourcecategorypricelevel_DuplicateMatchingRecord)
- [msdyn_resourcecategorypricelevel_DuplicateBaseRecord](#BKMK_msdyn_resourcecategorypricelevel_DuplicateBaseRecord)
- [msdyn_resourcecategorypricelevel_AsyncOperations](#BKMK_msdyn_resourcecategorypricelevel_AsyncOperations)
- [msdyn_resourcecategorypricelevel_MailboxTrackingFolders](#BKMK_msdyn_resourcecategorypricelevel_MailboxTrackingFolders)
- [msdyn_resourcecategorypricelevel_UserEntityInstanceDatas](#BKMK_msdyn_resourcecategorypricelevel_UserEntityInstanceDatas)
- [msdyn_resourcecategorypricelevel_ProcessSession](#BKMK_msdyn_resourcecategorypricelevel_ProcessSession)
- [msdyn_resourcecategorypricelevel_BulkDeleteFailures](#BKMK_msdyn_resourcecategorypricelevel_BulkDeleteFailures)
- [msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses)
- [msdyn_resourcecategorypricelevel_Annotations](#BKMK_msdyn_resourcecategorypricelevel_Annotations)


### <a name="BKMK_msdyn_resourcecategorypricelevel_SyncErrors"></a> msdyn_resourcecategorypricelevel_SyncErrors

Same as syncerror entity [msdyn_resourcecategorypricelevel_SyncErrors](syncerror.md#BKMK_msdyn_resourcecategorypricelevel_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_SyncErrors<br />
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


### <a name="BKMK_msdyn_resourcecategorypricelevel_DuplicateMatchingRecord"></a> msdyn_resourcecategorypricelevel_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_resourcecategorypricelevel_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_resourcecategorypricelevel_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_resourcecategorypricelevel_DuplicateBaseRecord"></a> msdyn_resourcecategorypricelevel_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_resourcecategorypricelevel_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_resourcecategorypricelevel_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_resourcecategorypricelevel_AsyncOperations"></a> msdyn_resourcecategorypricelevel_AsyncOperations

Same as asyncoperation entity [msdyn_resourcecategorypricelevel_AsyncOperations](asyncoperation.md#BKMK_msdyn_resourcecategorypricelevel_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_AsyncOperations<br />
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


### <a name="BKMK_msdyn_resourcecategorypricelevel_MailboxTrackingFolders"></a> msdyn_resourcecategorypricelevel_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_resourcecategorypricelevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_resourcecategorypricelevel_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_resourcecategorypricelevel_UserEntityInstanceDatas"></a> msdyn_resourcecategorypricelevel_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_resourcecategorypricelevel_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_resourcecategorypricelevel_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_resourcecategorypricelevel_ProcessSession"></a> msdyn_resourcecategorypricelevel_ProcessSession

Same as processsession entity [msdyn_resourcecategorypricelevel_ProcessSession](processsession.md#BKMK_msdyn_resourcecategorypricelevel_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_ProcessSession<br />
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


### <a name="BKMK_msdyn_resourcecategorypricelevel_BulkDeleteFailures"></a> msdyn_resourcecategorypricelevel_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_resourcecategorypricelevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_resourcecategorypricelevel_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses"></a> msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_resourcecategorypricelevel_Annotations"></a> msdyn_resourcecategorypricelevel_Annotations

Same as annotation entity [msdyn_resourcecategorypricelevel_Annotations](annotation.md#BKMK_msdyn_resourcecategorypricelevel_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcecategorypricelevel_Annotations<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_resourcecategorypricelevel_createdby](#BKMK_lk_msdyn_resourcecategorypricelevel_createdby)
- [lk_msdyn_resourcecategorypricelevel_createdonbehalfby](#BKMK_lk_msdyn_resourcecategorypricelevel_createdonbehalfby)
- [lk_msdyn_resourcecategorypricelevel_modifiedby](#BKMK_lk_msdyn_resourcecategorypricelevel_modifiedby)
- [lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby](#BKMK_lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby)
- [organization_msdyn_resourcecategorypricelevel](#BKMK_organization_msdyn_resourcecategorypricelevel)
- [TransactionCurrency_msdyn_resourcecategorypricelevel](#BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel)
- [msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory)
- [msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList](#BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList)
- [msdyn_resourcecategorypricelevel_organizationalunit](#BKMK_msdyn_resourcecategorypricelevel_organizationalunit)
- [msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit](#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit)
- [msdyn_uom_msdyn_resourcecategorypricelevel_Unit](#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit)
- [msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule)


### <a name="BKMK_lk_msdyn_resourcecategorypricelevel_createdby"></a> lk_msdyn_resourcecategorypricelevel_createdby

See systemuser Entity [lk_msdyn_resourcecategorypricelevel_createdby](systemuser.md#BKMK_lk_msdyn_resourcecategorypricelevel_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcecategorypricelevel_createdonbehalfby"></a> lk_msdyn_resourcecategorypricelevel_createdonbehalfby

See systemuser Entity [lk_msdyn_resourcecategorypricelevel_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcecategorypricelevel_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcecategorypricelevel_modifiedby"></a> lk_msdyn_resourcecategorypricelevel_modifiedby

See systemuser Entity [lk_msdyn_resourcecategorypricelevel_modifiedby](systemuser.md#BKMK_lk_msdyn_resourcecategorypricelevel_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby"></a> lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby

See systemuser Entity [lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_resourcecategorypricelevel"></a> organization_msdyn_resourcecategorypricelevel

See organization Entity [organization_msdyn_resourcecategorypricelevel](organization.md#BKMK_organization_msdyn_resourcecategorypricelevel) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel"></a> TransactionCurrency_msdyn_resourcecategorypricelevel

See transactioncurrency Entity [TransactionCurrency_msdyn_resourcecategorypricelevel](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_resourcecategorypricelevel) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList"></a> msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_organizationalunit"></a> msdyn_resourcecategorypricelevel_organizationalunit

See msdyn_organizationalunit Entity [msdyn_resourcecategorypricelevel_organizationalunit](msdyn_organizationalunit.md#BKMK_msdyn_resourcecategorypricelevel_organizationalunit) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit"></a> msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit

See uom Entity [msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit](uom.md#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit"></a> msdyn_uom_msdyn_resourcecategorypricelevel_Unit

See uom Entity [msdyn_uom_msdyn_resourcecategorypricelevel_Unit](uom.md#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit) One-To-Many relationship.

### <a name="BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule"></a> msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule

See uomschedule Entity [msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule](uomschedule.md#BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_resourcecategorypricelevel?text=msdyn_resourcecategorypricelevel EntityType" />