---
title: "PriceLevel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the PriceLevel entity."
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
# PriceLevel Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Entity that defines pricing levels.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/pricelevels<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/pricelevels(*pricelevelid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/pricelevels(*pricelevelid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/pricelevels<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/pricelevels(*pricelevelid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/pricelevels(*pricelevelid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Price List<br />
**DisplayCollectionName**: Price Lists<br />
**SchemaName**: PriceLevel<br />
**CollectionSchemaName**: PriceLevels<br />
**LogicalName**: pricelevel<br />
**LogicalCollectionName**: pricelevels<br />
**EntitySetName**: pricelevels<br />
**PrimaryIdAttribute**: pricelevelid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BeginDate](#BKMK_BeginDate)
- [Description](#BKMK_Description)
- [EndDate](#BKMK_EndDate)
- [FreightTermsCode](#BKMK_FreightTermsCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BreakHoursBillable](#BKMK_msdyn_BreakHoursBillable)
- [msdyn_CopiedFromPriceLevel](#BKMK_msdyn_CopiedFromPriceLevel)
- [msdyn_Entity](#BKMK_msdyn_Entity)
- [msdyn_Module](#BKMK_msdyn_Module)
- [msdyn_TimeUnit](#BKMK_msdyn_TimeUnit)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [PaymentMethodCode](#BKMK_PaymentMethodCode)
- [PriceLevelId](#BKMK_PriceLevelId)
- [ShippingMethodCode](#BKMK_ShippingMethodCode)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BeginDate"></a> BeginDate

**Description**: Date on which the price list becomes effective.<br />
**DisplayName**: Start Date<br />
**LogicalName**: begindate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_Description"></a> Description

**Description**: Description of the price list.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EndDate"></a> EndDate

**Description**: Date that is the last day the price list is valid.<br />
**DisplayName**: End Date<br />
**LogicalName**: enddate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_FreightTermsCode"></a> FreightTermsCode

**Description**: Freight terms for the price list.<br />
**DisplayName**: Freight Terms<br />
**LogicalName**: freighttermscode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



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


### <a name="BKMK_msdyn_BreakHoursBillable"></a> msdyn_BreakHoursBillable

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Break Hours Billable<br />
**LogicalName**: msdyn_breakhoursbillable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_msdyn_CopiedFromPriceLevel"></a> msdyn_CopiedFromPriceLevel

**Added by**: Project Service Automation Solution<br />
**Description**: Shows the price level that this price level was copied from.<br />
**DisplayName**: Copied From<br />
**LogicalName**: msdyn_copiedfrompricelevel<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_Entity"></a> msdyn_Entity

**Added by**: Project Service Automation Solution<br />
**Description**: Select the entity for this price level.<br />
**DisplayName**: Entity<br />
**LogicalName**: msdyn_entity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Organization
- **Value**: 192350001 **Label**: Customer
- **Value**: 192350002 **Label**: Sales document
- **Value**: 192350003 **Label**: Project



### <a name="BKMK_msdyn_Module"></a> msdyn_Module

**Added by**: Project Service Automation Solution<br />
**Description**: Select the context for this price level i.e whether it is sales prices, cost prices or purchase prices<br />
**DisplayName**: Context<br />
**LogicalName**: msdyn_module<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Cost
- **Value**: 192350001 **Label**: Purchase
- **Value**: 192350002 **Label**: Sales



### <a name="BKMK_msdyn_TimeUnit"></a> msdyn_TimeUnit

**Added by**: Project Service Automation Solution<br />
**Description**: Select the default unit of role based time on this price list<br />
**DisplayName**: Time Unit<br />
**LogicalName**: msdyn_timeunit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_Name"></a> Name

**Description**: Name of the price list.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_PaymentMethodCode"></a> PaymentMethodCode

**Description**: Payment terms to use with the price list.<br />
**DisplayName**: Payment Method <br />
**LogicalName**: paymentmethodcode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_PriceLevelId"></a> PriceLevelId

**Description**: Unique identifier of the price list.<br />
**DisplayName**: Price List<br />
**LogicalName**: pricelevelid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

**Description**: Method of shipment for products in the price list.<br />
**DisplayName**: Shipping Method<br />
**LogicalName**: shippingmethodcode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the price list.<br />
**DisplayName**: Status <br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 100001 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 100002 **InvariantName**: Inactive



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the price list.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 100001 **Label**: Active **State**: 0
- **Value**: 100002 **Label**: Inactive **State**: 1



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
**MinValue**: -2147483648


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the price level.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
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
**MinValue**: -2147483648

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
- [msdyn_CopiedFromPriceLevelName](#BKMK_msdyn_CopiedFromPriceLevelName)
- [msdyn_TimeUnitName](#BKMK_msdyn_TimeUnitName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the price list.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: False<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the pricelevel.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: False<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
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

**Description**: Unique identifier of the user who last modified the price list.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: False<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the pricelevel.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: False<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_CopiedFromPriceLevelName"></a> msdyn_CopiedFromPriceLevelName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_copiedfrompricelevelname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_TimeUnitName"></a> msdyn_TimeUnitName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_timeunitname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Added by**: Project Service Automation Solution<br />
**Description**: Unique identifier for the organization<br />
**DisplayName**: Organization Id<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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

- [PriceLevel_SyncErrors](#BKMK_PriceLevel_SyncErrors)
- [PriceLevel_AsyncOperations](#BKMK_PriceLevel_AsyncOperations)
- [pricelevel_MailboxTrackingFolders](#BKMK_pricelevel_MailboxTrackingFolders)
- [userentityinstancedata_pricelevel](#BKMK_userentityinstancedata_pricelevel)
- [PriceLevel_ProcessSessions](#BKMK_PriceLevel_ProcessSessions)
- [PriceLevel_BulkDeleteFailures](#BKMK_PriceLevel_BulkDeleteFailures)
- [pricelevel_principalobjectattributeaccess](#BKMK_pricelevel_principalobjectattributeaccess)
- [pricelevel_connections1](#BKMK_pricelevel_connections1)
- [pricelevel_connections2](#BKMK_pricelevel_connections2)
- [price_level_product_price_levels](#BKMK_price_level_product_price_levels)
- [price_level_accounts](#BKMK_price_level_accounts)
- [price_level_contacts](#BKMK_price_level_contacts)
- [price_level_products](#BKMK_price_level_products)
- [PriceList_Campaigns](#BKMK_PriceList_Campaigns)
- [price_level_invoices](#BKMK_price_level_invoices)
- [price_level_opportunties](#BKMK_price_level_opportunties)
- [price_level_orders](#BKMK_price_level_orders)
- [price_level_quotes](#BKMK_price_level_quotes)
- [msdyn_pricelevel_msdyn_actual_PriceList](#BKMK_msdyn_pricelevel_msdyn_actual_PriceList)
- [msdyn_pricelevel_msdyn_accountpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_accountpricelist_PriceList)
- [msdyn_pricelevel_msdyn_contactpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_contactpricelist_PriceList)
- [msdyn_pricelevel_msdyn_estimateline_PriceList](#BKMK_msdyn_pricelevel_msdyn_estimateline_PriceList)
- [msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList](#BKMK_msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList)
- [msdyn_pricelevel_msdyn_journalline_PriceList](#BKMK_msdyn_pricelevel_msdyn_journalline_PriceList)
- [msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList](#BKMK_msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList)
- [msdyn_pricelevel_msdyn_opportunitypricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_opportunitypricelist_PriceList)
- [msdyn_pricelevel_msdyn_orderlinetransaction_PriceList](#BKMK_msdyn_pricelevel_msdyn_orderlinetransaction_PriceList)
- [msdyn_pricelevel_msdyn_orderpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_orderpricelist_PriceList)
- [msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList)
- [msdyn_pricelevel_msdyn_projectpricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_projectpricelist_PriceList)
- [msdyn_pricelevel_msdyn_quotelinetransaction_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotelinetransaction_PriceList)
- [msdyn_pricelevel_msdyn_quotepricelist_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotepricelist_PriceList)
- [msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList](#BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList)
- [msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList](#BKMK_msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList)
- [msdyn_pricelevel_pricelevel_CopiedFromPriceLevel](#BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel)
- [msdyn_pricelevel_msdyn_agreement_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreement_PriceList)
- [msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList)
- [msdyn_pricelevel_msdyn_agreementbookingservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList)
- [msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList)
- [msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList)
- [msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList)
- [msdyn_pricelevel_msdyn_quotebookingservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList)
- [msdyn_pricelevel_msdyn_rma_PriceList](#BKMK_msdyn_pricelevel_msdyn_rma_PriceList)
- [msdyn_pricelevel_msdyn_rmaproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList)
- [msdyn_pricelevel_msdyn_workorder_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorder_PriceList)
- [msdyn_pricelevel_msdyn_workorderproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList)
- [msdyn_pricelevel_msdyn_workorderservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList)
- [msdyn_pricelevel_msdyn_workordertype_PriceList](#BKMK_msdyn_pricelevel_msdyn_workordertype_PriceList)
- [msdyn_pricelevel_opportunityproduct_PriceList](#BKMK_msdyn_pricelevel_opportunityproduct_PriceList)
- [msdyn_pricelevel_quotedetail_PriceList](#BKMK_msdyn_pricelevel_quotedetail_PriceList)


### <a name="BKMK_PriceLevel_SyncErrors"></a> PriceLevel_SyncErrors

Same as syncerror entity [PriceLevel_SyncErrors](syncerror.md#BKMK_PriceLevel_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: PriceLevel_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_PriceLevel_AsyncOperations"></a> PriceLevel_AsyncOperations

Same as asyncoperation entity [PriceLevel_AsyncOperations](asyncoperation.md#BKMK_PriceLevel_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: PriceLevel_AsyncOperations<br />
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


### <a name="BKMK_pricelevel_MailboxTrackingFolders"></a> pricelevel_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [pricelevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_pricelevel_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: pricelevel_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_pricelevel"></a> userentityinstancedata_pricelevel

Same as userentityinstancedata entity [userentityinstancedata_pricelevel](userentityinstancedata.md#BKMK_userentityinstancedata_pricelevel) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_pricelevel<br />
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


### <a name="BKMK_PriceLevel_ProcessSessions"></a> PriceLevel_ProcessSessions

Same as processsession entity [PriceLevel_ProcessSessions](processsession.md#BKMK_PriceLevel_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: PriceLevel_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_PriceLevel_BulkDeleteFailures"></a> PriceLevel_BulkDeleteFailures

Same as bulkdeletefailure entity [PriceLevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_PriceLevel_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: PriceLevel_BulkDeleteFailures<br />
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


### <a name="BKMK_pricelevel_principalobjectattributeaccess"></a> pricelevel_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [pricelevel_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_pricelevel_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: pricelevel_principalobjectattributeaccess<br />
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


### <a name="BKMK_pricelevel_connections1"></a> pricelevel_connections1

Same as connection entity [pricelevel_connections1](connection.md#BKMK_pricelevel_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: pricelevel_connections1<br />
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


### <a name="BKMK_pricelevel_connections2"></a> pricelevel_connections2

Same as connection entity [pricelevel_connections2](connection.md#BKMK_pricelevel_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: pricelevel_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_price_level_product_price_levels"></a> price_level_product_price_levels

Same as productpricelevel entity [price_level_product_price_levels](productpricelevel.md#BKMK_price_level_product_price_levels) Many-To-One relationship.

**ReferencingEntity**: productpricelevel<br />
**ReferencingAttribute**: pricelevelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: price_level_product_price_levels<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_price_level_accounts"></a> price_level_accounts

Same as account entity [price_level_accounts](account.md#BKMK_price_level_accounts) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: defaultpricelevelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: price_level_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_price_level_contacts"></a> price_level_contacts

Same as contact entity [price_level_contacts](contact.md#BKMK_price_level_contacts) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: defaultpricelevelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: price_level_contacts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_price_level_products"></a> price_level_products

Same as product entity [price_level_products](product.md#BKMK_price_level_products) Many-To-One relationship.

**ReferencingEntity**: product<br />
**ReferencingAttribute**: pricelevelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: price_level_products<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_PriceList_Campaigns"></a> PriceList_Campaigns

Same as campaign entity [PriceList_Campaigns](campaign.md#BKMK_PriceList_Campaigns) Many-To-One relationship.

**ReferencingEntity**: campaign<br />
**ReferencingAttribute**: pricelistid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: PriceList_Campaigns<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_price_level_invoices"></a> price_level_invoices

Same as invoice entity [price_level_invoices](invoice.md#BKMK_price_level_invoices) Many-To-One relationship.

**ReferencingEntity**: invoice<br />
**ReferencingAttribute**: pricelevelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: price_level_invoices<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_price_level_opportunties"></a> price_level_opportunties

Same as opportunity entity [price_level_opportunties](opportunity.md#BKMK_price_level_opportunties) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: pricelevelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: price_level_opportunties<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_price_level_orders"></a> price_level_orders

Same as salesorder entity [price_level_orders](salesorder.md#BKMK_price_level_orders) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: pricelevelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: price_level_orders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_price_level_quotes"></a> price_level_quotes

Same as quote entity [price_level_quotes](quote.md#BKMK_price_level_quotes) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: pricelevelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: price_level_quotes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_actual_PriceList"></a> msdyn_pricelevel_msdyn_actual_PriceList

Same as msdyn_actual entity [msdyn_pricelevel_msdyn_actual_PriceList](msdyn_actual.md#BKMK_msdyn_pricelevel_msdyn_actual_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_actual_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_accountpricelist_PriceList"></a> msdyn_pricelevel_msdyn_accountpricelist_PriceList

Same as msdyn_accountpricelist entity [msdyn_pricelevel_msdyn_accountpricelist_PriceList](msdyn_accountpricelist.md#BKMK_msdyn_pricelevel_msdyn_accountpricelist_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_accountpricelist<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_accountpricelist_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_contactpricelist_PriceList"></a> msdyn_pricelevel_msdyn_contactpricelist_PriceList

Same as msdyn_contactpricelist entity [msdyn_pricelevel_msdyn_contactpricelist_PriceList](msdyn_contactpricelist.md#BKMK_msdyn_pricelevel_msdyn_contactpricelist_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_contactpricelist<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_contactpricelist_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_estimateline_PriceList"></a> msdyn_pricelevel_msdyn_estimateline_PriceList

Same as msdyn_estimateline entity [msdyn_pricelevel_msdyn_estimateline_PriceList](msdyn_estimateline.md#BKMK_msdyn_pricelevel_msdyn_estimateline_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_estimateline_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList"></a> msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList

Same as msdyn_invoicelinetransaction entity [msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList](msdyn_invoicelinetransaction.md#BKMK_msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_journalline_PriceList"></a> msdyn_pricelevel_msdyn_journalline_PriceList

Same as msdyn_journalline entity [msdyn_pricelevel_msdyn_journalline_PriceList](msdyn_journalline.md#BKMK_msdyn_pricelevel_msdyn_journalline_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_journalline_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList"></a> msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList

Same as msdyn_opportunitylinetransaction entity [msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList](msdyn_opportunitylinetransaction.md#BKMK_msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_opportunitypricelist_PriceList"></a> msdyn_pricelevel_msdyn_opportunitypricelist_PriceList

Same as msdyn_opportunitypricelist entity [msdyn_pricelevel_msdyn_opportunitypricelist_PriceList](msdyn_opportunitypricelist.md#BKMK_msdyn_pricelevel_msdyn_opportunitypricelist_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitypricelist<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_opportunitypricelist_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_orderlinetransaction_PriceList"></a> msdyn_pricelevel_msdyn_orderlinetransaction_PriceList

Same as msdyn_orderlinetransaction entity [msdyn_pricelevel_msdyn_orderlinetransaction_PriceList](msdyn_orderlinetransaction.md#BKMK_msdyn_pricelevel_msdyn_orderlinetransaction_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_orderlinetransaction_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_orderpricelist_PriceList"></a> msdyn_pricelevel_msdyn_orderpricelist_PriceList

Same as msdyn_orderpricelist entity [msdyn_pricelevel_msdyn_orderpricelist_PriceList](msdyn_orderpricelist.md#BKMK_msdyn_pricelevel_msdyn_orderpricelist_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderpricelist<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_orderpricelist_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList"></a> msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList

Same as msdyn_projectparameterpricelist entity [msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList](msdyn_projectparameterpricelist.md#BKMK_msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectparameterpricelist<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_projectpricelist_PriceList"></a> msdyn_pricelevel_msdyn_projectpricelist_PriceList

Same as msdyn_projectpricelist entity [msdyn_pricelevel_msdyn_projectpricelist_PriceList](msdyn_projectpricelist.md#BKMK_msdyn_pricelevel_msdyn_projectpricelist_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectpricelist<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_projectpricelist_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: Projects
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_quotelinetransaction_PriceList"></a> msdyn_pricelevel_msdyn_quotelinetransaction_PriceList

Same as msdyn_quotelinetransaction entity [msdyn_pricelevel_msdyn_quotelinetransaction_PriceList](msdyn_quotelinetransaction.md#BKMK_msdyn_pricelevel_msdyn_quotelinetransaction_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_quotelinetransaction_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_quotepricelist_PriceList"></a> msdyn_pricelevel_msdyn_quotepricelist_PriceList

Same as msdyn_quotepricelist entity [msdyn_pricelevel_msdyn_quotepricelist_PriceList](msdyn_quotepricelist.md#BKMK_msdyn_pricelevel_msdyn_quotepricelist_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotepricelist<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_quotepricelist_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList"></a> msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList

Same as msdyn_resourcecategorypricelevel entity [msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcecategorypricelevel<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList"></a> msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList

Same as msdyn_transactioncategorypricelevel entity [msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategorypricelevel<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel"></a> msdyn_pricelevel_pricelevel_CopiedFromPriceLevel

Same as pricelevel entity [msdyn_pricelevel_pricelevel_CopiedFromPriceLevel](pricelevel.md#BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel) Many-To-One relationship.

**ReferencingEntity**: pricelevel<br />
**ReferencingAttribute**: msdyn_copiedfrompricelevel<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_pricelevel_CopiedFromPriceLevel<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_agreement_PriceList"></a> msdyn_pricelevel_msdyn_agreement_PriceList

Same as msdyn_agreement entity [msdyn_pricelevel_msdyn_agreement_PriceList](msdyn_agreement.md#BKMK_msdyn_pricelevel_msdyn_agreement_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreement<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_agreement_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList"></a> msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList

Same as msdyn_agreementbookingproduct entity [msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList](msdyn_agreementbookingproduct.md#BKMK_msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingproduct<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Price List
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList"></a> msdyn_pricelevel_msdyn_agreementbookingservice_PriceList

Same as msdyn_agreementbookingservice entity [msdyn_pricelevel_msdyn_agreementbookingservice_PriceList](msdyn_agreementbookingservice.md#BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservice<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_agreementbookingservice_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Price List
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList"></a> msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList

Same as msdyn_agreementinvoiceproduct entity [msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoiceproduct<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList"></a> msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList

Same as msdyn_fieldservicepricelistitem entity [msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldservicepricelistitem<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList"></a> msdyn_pricelevel_msdyn_quotebookingproduct_PriceList

Same as msdyn_quotebookingproduct entity [msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](msdyn_quotebookingproduct.md#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingproduct<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_quotebookingproduct_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList"></a> msdyn_pricelevel_msdyn_quotebookingservice_PriceList

Same as msdyn_quotebookingservice entity [msdyn_pricelevel_msdyn_quotebookingservice_PriceList](msdyn_quotebookingservice.md#BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservice<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_quotebookingservice_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_rma_PriceList"></a> msdyn_pricelevel_msdyn_rma_PriceList

Same as msdyn_rma entity [msdyn_pricelevel_msdyn_rma_PriceList](msdyn_rma.md#BKMK_msdyn_pricelevel_msdyn_rma_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_rma<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_rma_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList"></a> msdyn_pricelevel_msdyn_rmaproduct_PriceList

Same as msdyn_rmaproduct entity [msdyn_pricelevel_msdyn_rmaproduct_PriceList](msdyn_rmaproduct.md#BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_rmaproduct_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_workorder_PriceList"></a> msdyn_pricelevel_msdyn_workorder_PriceList

Same as msdyn_workorder entity [msdyn_pricelevel_msdyn_workorder_PriceList](msdyn_workorder.md#BKMK_msdyn_pricelevel_msdyn_workorder_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_workorder_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList"></a> msdyn_pricelevel_msdyn_workorderproduct_PriceList

Same as msdyn_workorderproduct entity [msdyn_pricelevel_msdyn_workorderproduct_PriceList](msdyn_workorderproduct.md#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_workorderproduct_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList"></a> msdyn_pricelevel_msdyn_workorderservice_PriceList

Same as msdyn_workorderservice entity [msdyn_pricelevel_msdyn_workorderservice_PriceList](msdyn_workorderservice.md#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_workorderservice_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_msdyn_workordertype_PriceList"></a> msdyn_pricelevel_msdyn_workordertype_PriceList

Same as msdyn_workordertype entity [msdyn_pricelevel_msdyn_workordertype_PriceList](msdyn_workordertype.md#BKMK_msdyn_pricelevel_msdyn_workordertype_PriceList) Many-To-One relationship.

**ReferencingEntity**: msdyn_workordertype<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_msdyn_workordertype_PriceList<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_pricelevel_opportunityproduct_PriceList"></a> msdyn_pricelevel_opportunityproduct_PriceList

Same as opportunityproduct entity [msdyn_pricelevel_opportunityproduct_PriceList](opportunityproduct.md#BKMK_msdyn_pricelevel_opportunityproduct_PriceList) Many-To-One relationship.

**ReferencingEntity**: opportunityproduct<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_opportunityproduct_PriceList<br />
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


### <a name="BKMK_msdyn_pricelevel_quotedetail_PriceList"></a> msdyn_pricelevel_quotedetail_PriceList

Same as quotedetail entity [msdyn_pricelevel_quotedetail_PriceList](quotedetail.md#BKMK_msdyn_pricelevel_quotedetail_PriceList) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: msdyn_pricelist<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_pricelevel_quotedetail_PriceList<br />
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

- [lk_pricelevelbase_createdby](#BKMK_lk_pricelevelbase_createdby)
- [lk_pricelevel_createdonbehalfby](#BKMK_lk_pricelevel_createdonbehalfby)
- [lk_pricelevelbase_modifiedby](#BKMK_lk_pricelevelbase_modifiedby)
- [lk_pricelevel_modifiedonbehalfby](#BKMK_lk_pricelevel_modifiedonbehalfby)
- [organization_price_levels](#BKMK_organization_price_levels)
- [transactioncurrency_pricelevel](#BKMK_transactioncurrency_pricelevel)
- [msdyn_pricelevel_pricelevel_CopiedFromPriceLevel](#BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel)
- [msdyn_uom_pricelevel_TimeUnit](#BKMK_msdyn_uom_pricelevel_TimeUnit)


### <a name="BKMK_lk_pricelevelbase_createdby"></a> lk_pricelevelbase_createdby

See systemuser Entity [lk_pricelevelbase_createdby](systemuser.md#BKMK_lk_pricelevelbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_pricelevel_createdonbehalfby"></a> lk_pricelevel_createdonbehalfby

See systemuser Entity [lk_pricelevel_createdonbehalfby](systemuser.md#BKMK_lk_pricelevel_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_pricelevelbase_modifiedby"></a> lk_pricelevelbase_modifiedby

See systemuser Entity [lk_pricelevelbase_modifiedby](systemuser.md#BKMK_lk_pricelevelbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_pricelevel_modifiedonbehalfby"></a> lk_pricelevel_modifiedonbehalfby

See systemuser Entity [lk_pricelevel_modifiedonbehalfby](systemuser.md#BKMK_lk_pricelevel_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_price_levels"></a> organization_price_levels

See organization Entity [organization_price_levels](organization.md#BKMK_organization_price_levels) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_pricelevel"></a> transactioncurrency_pricelevel

See transactioncurrency Entity [transactioncurrency_pricelevel](transactioncurrency.md#BKMK_transactioncurrency_pricelevel) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel"></a> msdyn_pricelevel_pricelevel_CopiedFromPriceLevel

See pricelevel Entity [msdyn_pricelevel_pricelevel_CopiedFromPriceLevel](pricelevel.md#BKMK_msdyn_pricelevel_pricelevel_CopiedFromPriceLevel) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_pricelevel_TimeUnit"></a> msdyn_uom_pricelevel_TimeUnit

See uom Entity [msdyn_uom_pricelevel_TimeUnit](uom.md#BKMK_msdyn_uom_pricelevel_TimeUnit) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the PriceLevel entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_organizationalunit_pricelevel"></a> msdyn_organizationalunit_pricelevel

See msdyn_organizationalunit Entity [msdyn_organizationalunit_pricelevel](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_pricelevel) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.pricelevel?text=pricelevel EntityType" />