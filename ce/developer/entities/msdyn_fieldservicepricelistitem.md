---
title: "msdyn_fieldservicepricelistitem Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_fieldservicepricelistitem entity."
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
# msdyn_fieldservicepricelistitem Entity Reference

Pricing options in addition to or above the Price List Items

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_fieldservicepricelistitems<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_fieldservicepricelistitems(*msdyn_fieldservicepricelistitemid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicepricelistitems(*msdyn_fieldservicepricelistitemid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicepricelistitems<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicepricelistitems(*msdyn_fieldservicepricelistitemid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicepricelistitems(*msdyn_fieldservicepricelistitemid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Field Service Price List Item<br />
**DisplayCollectionName**: Field Service Price List Items<br />
**SchemaName**: msdyn_fieldservicepricelistitem<br />
**CollectionSchemaName**: msdyn_fieldservicepricelistitems<br />
**LogicalName**: msdyn_fieldservicepricelistitem<br />
**LogicalCollectionName**: msdyn_fieldservicepricelistitems<br />
**EntitySetName**: msdyn_fieldservicepricelistitems<br />
**PrimaryIdAttribute**: msdyn_fieldservicepricelistitemid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_DurationRoundingPolicy](#BKMK_msdyn_DurationRoundingPolicy)
- [msdyn_DurationRoundTo](#BKMK_msdyn_DurationRoundTo)
- [msdyn_fieldservicepricelistitemId](#BKMK_msdyn_fieldservicepricelistitemId)
- [msdyn_FlatFee](#BKMK_msdyn_FlatFee)
- [msdyn_MinimumChargeAmount](#BKMK_msdyn_MinimumChargeAmount)
- [msdyn_MinimumChargeDuration](#BKMK_msdyn_MinimumChargeDuration)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_ProductService](#BKMK_msdyn_ProductService)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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


### <a name="BKMK_msdyn_DurationRoundingPolicy"></a> msdyn_DurationRoundingPolicy

**Description**: Specify how the system should round the Duration To Bill on the Work Order Service<br />
**DisplayName**: Duration Rounding Policy<br />
**LogicalName**: msdyn_durationroundingpolicy<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: None
- **Value**: 690970001 **Label**: Up
- **Value**: 690970002 **Label**: Down
- **Value**: 690970003 **Label**: Nearest



### <a name="BKMK_msdyn_DurationRoundTo"></a> msdyn_DurationRoundTo

**Description**: Specify the rounding duration.<br />
**DisplayName**: Duration Round To<br />
**LogicalName**: msdyn_durationroundto<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_fieldservicepricelistitemId"></a> msdyn_fieldservicepricelistitemId

**Description**: Shows the entity instances.<br />
**DisplayName**: Field Service Price List Item<br />
**LogicalName**: msdyn_fieldservicepricelistitemid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_FlatFee"></a> msdyn_FlatFee

**Description**: If enabled then the pricing of this item will not be multiplied by quantity<br />
**DisplayName**: Flat Fee<br />
**LogicalName**: msdyn_flatfee<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_MinimumChargeAmount"></a> msdyn_MinimumChargeAmount

**Description**: Specify the minimum charge you wish to charge for this service. See note on Minimum Charge Duration<br />
**DisplayName**: Minimum Charge Amount<br />
**LogicalName**: msdyn_minimumchargeamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_MinimumChargeDuration"></a> msdyn_MinimumChargeDuration

**Description**: If this field has a value, the Minimum Charge Amount will first apply to the Minimum Duration and beyond the minimum duration the regular fee will apply<br />
**DisplayName**: Minimum Charge Duration<br />
**LogicalName**: msdyn_minimumchargeduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


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


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

**Description**: Shows the price list associated with the field service price list item.<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_ProductService"></a> msdyn_ProductService

**Description**: If you wish to limit this price list item to a certain product or service you can specify it. Otherwise this should be left blank<br />
**DisplayName**: Product / Service<br />
**LogicalName**: msdyn_productservice<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: product


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


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Field Service Price List Item<br />
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

**Description**: Shows the reason for the status of the field service price list item.<br />
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
- [msdyn_minimumchargeamount_Base](#BKMK_msdyn_minimumchargeamount_Base)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_ProductServiceName](#BKMK_msdyn_ProductServiceName)
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


### <a name="BKMK_msdyn_minimumchargeamount_Base"></a> msdyn_minimumchargeamount_Base

**Description**: Shows the value of the minimum charge amount in the base currency.<br />
**DisplayName**: Minimum Charge Amount (Base)<br />
**LogicalName**: msdyn_minimumchargeamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


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


### <a name="BKMK_msdyn_ProductServiceName"></a> msdyn_ProductServiceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_productservicename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [msdyn_fieldservicepricelistitem_SyncErrors](#BKMK_msdyn_fieldservicepricelistitem_SyncErrors)
- [msdyn_fieldservicepricelistitem_DuplicateMatchingRecord](#BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord)
- [msdyn_fieldservicepricelistitem_DuplicateBaseRecord](#BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord)
- [msdyn_fieldservicepricelistitem_AsyncOperations](#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations)
- [msdyn_fieldservicepricelistitem_MailboxTrackingFolders](#BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders)
- [msdyn_fieldservicepricelistitem_UserEntityInstanceDatas](#BKMK_msdyn_fieldservicepricelistitem_UserEntityInstanceDatas)
- [msdyn_fieldservicepricelistitem_ProcessSession](#BKMK_msdyn_fieldservicepricelistitem_ProcessSession)
- [msdyn_fieldservicepricelistitem_BulkDeleteFailures](#BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures)
- [msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_fieldservicepricelistitem_SyncErrors"></a> msdyn_fieldservicepricelistitem_SyncErrors

Same as syncerror entity [msdyn_fieldservicepricelistitem_SyncErrors](syncerror.md#BKMK_msdyn_fieldservicepricelistitem_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicepricelistitem_SyncErrors<br />
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


### <a name="BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord"></a> msdyn_fieldservicepricelistitem_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_fieldservicepricelistitem_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicepricelistitem_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord"></a> msdyn_fieldservicepricelistitem_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_fieldservicepricelistitem_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicepricelistitem_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_fieldservicepricelistitem_AsyncOperations"></a> msdyn_fieldservicepricelistitem_AsyncOperations

Same as asyncoperation entity [msdyn_fieldservicepricelistitem_AsyncOperations](asyncoperation.md#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicepricelistitem_AsyncOperations<br />
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


### <a name="BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders"></a> msdyn_fieldservicepricelistitem_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_fieldservicepricelistitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicepricelistitem_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_fieldservicepricelistitem_UserEntityInstanceDatas"></a> msdyn_fieldservicepricelistitem_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_fieldservicepricelistitem_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_fieldservicepricelistitem_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicepricelistitem_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_fieldservicepricelistitem_ProcessSession"></a> msdyn_fieldservicepricelistitem_ProcessSession

Same as processsession entity [msdyn_fieldservicepricelistitem_ProcessSession](processsession.md#BKMK_msdyn_fieldservicepricelistitem_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicepricelistitem_ProcessSession<br />
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


### <a name="BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures"></a> msdyn_fieldservicepricelistitem_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_fieldservicepricelistitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicepricelistitem_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses<br />
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

- [lk_msdyn_fieldservicepricelistitem_createdby](#BKMK_lk_msdyn_fieldservicepricelistitem_createdby)
- [lk_msdyn_fieldservicepricelistitem_createdonbehalfby](#BKMK_lk_msdyn_fieldservicepricelistitem_createdonbehalfby)
- [lk_msdyn_fieldservicepricelistitem_modifiedby](#BKMK_lk_msdyn_fieldservicepricelistitem_modifiedby)
- [lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby](#BKMK_lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby)
- [organization_msdyn_fieldservicepricelistitem](#BKMK_organization_msdyn_fieldservicepricelistitem)
- [TransactionCurrency_msdyn_fieldservicepricelistitem](#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem)
- [msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList)
- [msdyn_product_msdyn_fieldservicepricelistitem_ProductService](#BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService)


### <a name="BKMK_lk_msdyn_fieldservicepricelistitem_createdby"></a> lk_msdyn_fieldservicepricelistitem_createdby

See systemuser Entity [lk_msdyn_fieldservicepricelistitem_createdby](systemuser.md#BKMK_lk_msdyn_fieldservicepricelistitem_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicepricelistitem_createdonbehalfby"></a> lk_msdyn_fieldservicepricelistitem_createdonbehalfby

See systemuser Entity [lk_msdyn_fieldservicepricelistitem_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicepricelistitem_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicepricelistitem_modifiedby"></a> lk_msdyn_fieldservicepricelistitem_modifiedby

See systemuser Entity [lk_msdyn_fieldservicepricelistitem_modifiedby](systemuser.md#BKMK_lk_msdyn_fieldservicepricelistitem_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby"></a> lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby

See systemuser Entity [lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_fieldservicepricelistitem"></a> organization_msdyn_fieldservicepricelistitem

See organization Entity [organization_msdyn_fieldservicepricelistitem](organization.md#BKMK_organization_msdyn_fieldservicepricelistitem) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem"></a> TransactionCurrency_msdyn_fieldservicepricelistitem

See transactioncurrency Entity [TransactionCurrency_msdyn_fieldservicepricelistitem](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList"></a> msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService"></a> msdyn_product_msdyn_fieldservicepricelistitem_ProductService

See product Entity [msdyn_product_msdyn_fieldservicepricelistitem_ProductService](product.md#BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_fieldservicepricelistitem?text=msdyn_fieldservicepricelistitem EntityType" />