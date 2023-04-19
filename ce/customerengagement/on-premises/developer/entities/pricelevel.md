---
title: "Price List (PriceLevel)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Price List (PriceLevel)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Price List (PriceLevel)  entity reference

Entity that defines pricing levels.

**Added by**: Product Management Solution


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|PriceLevels|
|DisplayCollectionName|Price Lists|
|DisplayName|Price List|
|EntitySetName|pricelevels|
|IsBPFEntity|False|
|LogicalCollectionName|pricelevels|
|LogicalName|pricelevel|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|pricelevelid|
|PrimaryNameAttribute|name|
|SchemaName|PriceLevel|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BeginDate](#BKMK_BeginDate)
- [Description](#BKMK_Description)
- [EndDate](#BKMK_EndDate)
- [FreightTermsCode](#BKMK_FreightTermsCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
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

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date on which the price list becomes effective.|
|DisplayName|Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|begindate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the price list.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EndDate"></a> EndDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date that is the last day the price list is valid.|
|DisplayName|End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|enddate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_FreightTermsCode"></a> FreightTermsCode

|Property|Value|
|--------|-----|
|Description|Freight terms for the price list.|
|DisplayName|Freight Terms|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|freighttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### FreightTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the price list.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_PaymentMethodCode"></a> PaymentMethodCode

|Property|Value|
|--------|-----|
|Description|Payment terms to use with the price list.|
|DisplayName|Payment Method |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|paymentmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### PaymentMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the price list.|
|DisplayName|Price List|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|pricelevelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Method of shipment for products in the price list.|
|DisplayName|Shipping Method|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### ShippingMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the price list.|
|DisplayName|Status |
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|100001|Active|
|1|Inactive|100002|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the price list.|
|DisplayName|Status Reason|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|100001|Active|0|
|100002|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the price level.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|transactioncurrencyid|
|RequiredLevel|ApplicationRequired|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

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
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the price list.|
|DisplayName|Created By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the pricelevel.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the price list.|
|DisplayName|Modified By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the pricelevel.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [PriceLevel_SyncErrors](#BKMK_PriceLevel_SyncErrors)
- [PriceLevel_AsyncOperations](#BKMK_PriceLevel_AsyncOperations)
- [pricelevel_MailboxTrackingFolders](#BKMK_pricelevel_MailboxTrackingFolders)
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


### <a name="BKMK_PriceLevel_SyncErrors"></a> PriceLevel_SyncErrors

**Added by**: System Solution Solution

Same as the [PriceLevel_SyncErrors](syncerror.md#BKMK_PriceLevel_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|PriceLevel_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_PriceLevel_AsyncOperations"></a> PriceLevel_AsyncOperations

**Added by**: System Solution Solution

Same as the [PriceLevel_AsyncOperations](asyncoperation.md#BKMK_PriceLevel_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|PriceLevel_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_pricelevel_MailboxTrackingFolders"></a> pricelevel_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as the [pricelevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_pricelevel_MailboxTrackingFolders) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|pricelevel_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_PriceLevel_ProcessSessions"></a> PriceLevel_ProcessSessions

**Added by**: System Solution Solution

Same as the [PriceLevel_ProcessSessions](processsession.md#BKMK_PriceLevel_ProcessSessions) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|PriceLevel_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_PriceLevel_BulkDeleteFailures"></a> PriceLevel_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [PriceLevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_PriceLevel_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|PriceLevel_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_pricelevel_principalobjectattributeaccess"></a> pricelevel_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as the [pricelevel_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_pricelevel_principalobjectattributeaccess) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|pricelevel_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_pricelevel_connections1"></a> pricelevel_connections1

**Added by**: System Solution Solution

Same as the [pricelevel_connections1](connection.md#BKMK_pricelevel_connections1) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|pricelevel_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_pricelevel_connections2"></a> pricelevel_connections2

**Added by**: System Solution Solution

Same as the [pricelevel_connections2](connection.md#BKMK_pricelevel_connections2) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|pricelevel_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_product_price_levels"></a> price_level_product_price_levels

Same as the [price_level_product_price_levels](productpricelevel.md#BKMK_price_level_product_price_levels) many-to-one relationship for the [productpricelevel](productpricelevel.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|productpricelevel|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|price_level_product_price_levels|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_accounts"></a> price_level_accounts

Same as the [price_level_accounts](account.md#BKMK_price_level_accounts) many-to-one relationship for the [account](account.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|defaultpricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_accounts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_contacts"></a> price_level_contacts

Same as the [price_level_contacts](contact.md#BKMK_price_level_contacts) many-to-one relationship for the [contact](contact.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|defaultpricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_contacts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_products"></a> price_level_products

Same as the [price_level_products](product.md#BKMK_price_level_products) many-to-one relationship for the [product](product.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_products|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_PriceList_Campaigns"></a> PriceList_Campaigns

**Added by**: Marketing Solution

Same as the [PriceList_Campaigns](campaign.md#BKMK_PriceList_Campaigns) many-to-one relationship for the [campaign](campaign.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaign|
|ReferencingAttribute|pricelistid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|PriceList_Campaigns|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_invoices"></a> price_level_invoices

**Added by**: Sales Solution

Same as the [price_level_invoices](invoice.md#BKMK_price_level_invoices) many-to-one relationship for the [invoice](invoice.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_invoices|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_opportunties"></a> price_level_opportunties

**Added by**: Sales Solution

Same as the [price_level_opportunties](opportunity.md#BKMK_price_level_opportunties) many-to-one relationship for the [opportunity](opportunity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_opportunties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_orders"></a> price_level_orders

**Added by**: Sales Solution

Same as the [price_level_orders](salesorder.md#BKMK_price_level_orders) many-to-one relationship for the [salesorder](salesorder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_orders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_price_level_quotes"></a> price_level_quotes

**Added by**: Sales Solution

Same as the [price_level_quotes](quote.md#BKMK_price_level_quotes) many-to-one relationship for the [quote](quote.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|pricelevelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|price_level_quotes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_pricelevelbase_createdby](#BKMK_lk_pricelevelbase_createdby)
- [lk_pricelevel_createdonbehalfby](#BKMK_lk_pricelevel_createdonbehalfby)
- [lk_pricelevelbase_modifiedby](#BKMK_lk_pricelevelbase_modifiedby)
- [lk_pricelevel_modifiedonbehalfby](#BKMK_lk_pricelevel_modifiedonbehalfby)
- [organization_price_levels](#BKMK_organization_price_levels)
- [transactioncurrency_pricelevel](#BKMK_transactioncurrency_pricelevel)


### <a name="BKMK_lk_pricelevelbase_createdby"></a> lk_pricelevelbase_createdby

**Added by**: System Solution Solution

See the [lk_pricelevelbase_createdby](systemuser.md#BKMK_lk_pricelevelbase_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_pricelevel_createdonbehalfby"></a> lk_pricelevel_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_pricelevel_createdonbehalfby](systemuser.md#BKMK_lk_pricelevel_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_pricelevelbase_modifiedby"></a> lk_pricelevelbase_modifiedby

**Added by**: System Solution Solution

See the [lk_pricelevelbase_modifiedby](systemuser.md#BKMK_lk_pricelevelbase_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_pricelevel_modifiedonbehalfby"></a> lk_pricelevel_modifiedonbehalfby

**Added by**: System Solution Solution

See the [lk_pricelevel_modifiedonbehalfby](systemuser.md#BKMK_lk_pricelevel_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_organization_price_levels"></a> organization_price_levels

**Added by**: System Solution Solution

See the [organization_price_levels](organization.md#BKMK_organization_price_levels) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_transactioncurrency_pricelevel"></a> transactioncurrency_pricelevel

**Added by**: System Solution Solution

See the [transactioncurrency_pricelevel](transactioncurrency.md#BKMK_transactioncurrency_pricelevel) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
