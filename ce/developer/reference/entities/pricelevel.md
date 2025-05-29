---
title: "Price List (PriceLevel) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Price List (PriceLevel) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Price List (PriceLevel) table/entity reference (Microsoft Dynamics 365)

Entity that defines pricing levels.

## Messages

The following table lists the messages for the Price List (PriceLevel) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /pricelevels<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /pricelevels(*pricelevelid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /pricelevels(*pricelevelid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /pricelevels<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /pricelevels(*pricelevelid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /pricelevels(*pricelevelid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /pricelevels(*pricelevelid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Price List (PriceLevel) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Price List** |
| **DisplayCollectionName** | **Price Lists** |
| **SchemaName** | `PriceLevel` |
| **CollectionSchemaName** | `PriceLevels` |
| **EntitySetName** | `pricelevels`|
| **LogicalName** | `pricelevel` |
| **LogicalCollectionName** | `pricelevels` |
| **PrimaryIdAttribute** | `pricelevelid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|---|---|
|Description|**Date on which the price list becomes effective.**|
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`begindate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Description of the price list.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_EndDate"></a> EndDate

|Property|Value|
|---|---|
|Description|**Date that is the last day the price list is valid.**|
|DisplayName|**End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`enddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_FreightTermsCode"></a> FreightTermsCode

|Property|Value|
|---|---|
|Description|**Freight terms for the price list.**|
|DisplayName|**Freight Terms**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`freighttermscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`pricelevel_freighttermscode`|

#### FreightTermsCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Name of the price list.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_PaymentMethodCode"></a> PaymentMethodCode

|Property|Value|
|---|---|
|Description|**Payment terms to use with the price list.**|
|DisplayName|**Payment Method**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`paymentmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`pricelevel_paymentmethodcode`|

#### PaymentMethodCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|---|---|
|Description|**Unique identifier of the price list.**|
|DisplayName|**Price List**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`pricelevelid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|---|---|
|Description|**Method of shipment for products in the price list.**|
|DisplayName|**Shipping Method**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`shippingmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`pricelevel_shippingmethodcode`|

#### ShippingMethodCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Status of the price list.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`pricelevel_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 100001<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 100002<br />InvariantName: `Inactive`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Reason for the status of the price list.**|
|DisplayName|**Status Reason**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`pricelevel_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|100001|Label: **Active**<br />State:0<br />TransitionData: None|
|100002|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the price level.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the price list.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the pricelevel.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the price list.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who last modified the pricelevel.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|organization|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [lk_pricelevel_createdonbehalfby](#BKMK_lk_pricelevel_createdonbehalfby)
- [lk_pricelevel_modifiedonbehalfby](#BKMK_lk_pricelevel_modifiedonbehalfby)
- [lk_pricelevelbase_createdby](#BKMK_lk_pricelevelbase_createdby)
- [lk_pricelevelbase_modifiedby](#BKMK_lk_pricelevelbase_modifiedby)
- [organization_price_levels](#BKMK_organization_price_levels)
- [transactioncurrency_pricelevel](#BKMK_transactioncurrency_pricelevel)

### <a name="BKMK_lk_pricelevel_createdonbehalfby"></a> lk_pricelevel_createdonbehalfby

One-To-Many Relationship: [systemuser lk_pricelevel_createdonbehalfby](systemuser.md#BKMK_lk_pricelevel_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_pricelevel_modifiedonbehalfby"></a> lk_pricelevel_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_pricelevel_modifiedonbehalfby](systemuser.md#BKMK_lk_pricelevel_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_pricelevelbase_createdby"></a> lk_pricelevelbase_createdby

One-To-Many Relationship: [systemuser lk_pricelevelbase_createdby](systemuser.md#BKMK_lk_pricelevelbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_pricelevelbase_modifiedby"></a> lk_pricelevelbase_modifiedby

One-To-Many Relationship: [systemuser lk_pricelevelbase_modifiedby](systemuser.md#BKMK_lk_pricelevelbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_price_levels"></a> organization_price_levels

One-To-Many Relationship: [organization organization_price_levels](organization.md#BKMK_organization_price_levels)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_pricelevel"></a> transactioncurrency_pricelevel

One-To-Many Relationship: [transactioncurrency transactioncurrency_pricelevel](transactioncurrency.md#BKMK_transactioncurrency_pricelevel)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [price_level_accounts](#BKMK_price_level_accounts)
- [price_level_contacts](#BKMK_price_level_contacts)
- [price_level_invoices](#BKMK_price_level_invoices)
- [price_level_opportunties](#BKMK_price_level_opportunties)
- [price_level_orders](#BKMK_price_level_orders)
- [price_level_product_price_levels](#BKMK_price_level_product_price_levels)
- [price_level_products](#BKMK_price_level_products)
- [price_level_quotes](#BKMK_price_level_quotes)
- [PriceLevel_AsyncOperations](#BKMK_PriceLevel_AsyncOperations)
- [PriceLevel_BulkDeleteFailures](#BKMK_PriceLevel_BulkDeleteFailures)
- [pricelevel_connections1](#BKMK_pricelevel_connections1)
- [pricelevel_connections2](#BKMK_pricelevel_connections2)
- [pricelevel_MailboxTrackingFolders](#BKMK_pricelevel_MailboxTrackingFolders)
- [pricelevel_principalobjectattributeaccess](#BKMK_pricelevel_principalobjectattributeaccess)
- [PriceLevel_ProcessSessions](#BKMK_PriceLevel_ProcessSessions)
- [PriceLevel_SyncErrors](#BKMK_PriceLevel_SyncErrors)
- [PriceList_Campaigns](#BKMK_PriceList_Campaigns)

### <a name="BKMK_price_level_accounts"></a> price_level_accounts

Many-To-One Relationship: [account price_level_accounts](account.md#BKMK_price_level_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`account`|
|ReferencingAttribute|`defaultpricelevelid`|
|ReferencedEntityNavigationPropertyName|`price_level_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_price_level_contacts"></a> price_level_contacts

Many-To-One Relationship: [contact price_level_contacts](contact.md#BKMK_price_level_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`defaultpricelevelid`|
|ReferencedEntityNavigationPropertyName|`price_level_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_price_level_invoices"></a> price_level_invoices

Many-To-One Relationship: [invoice price_level_invoices](invoice.md#BKMK_price_level_invoices)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`pricelevelid`|
|ReferencedEntityNavigationPropertyName|`price_level_invoices`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_price_level_opportunties"></a> price_level_opportunties

Many-To-One Relationship: [opportunity price_level_opportunties](opportunity.md#BKMK_price_level_opportunties)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`pricelevelid`|
|ReferencedEntityNavigationPropertyName|`price_level_opportunties`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_price_level_orders"></a> price_level_orders

Many-To-One Relationship: [salesorder price_level_orders](salesorder.md#BKMK_price_level_orders)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`pricelevelid`|
|ReferencedEntityNavigationPropertyName|`price_level_orders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_price_level_product_price_levels"></a> price_level_product_price_levels

Many-To-One Relationship: [productpricelevel price_level_product_price_levels](productpricelevel.md#BKMK_price_level_product_price_levels)

|Property|Value|
|---|---|
|ReferencingEntity|`productpricelevel`|
|ReferencingAttribute|`pricelevelid`|
|ReferencedEntityNavigationPropertyName|`price_level_product_price_levels`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMProductPriceLevel.RetrieveByObject`<br />ViewId: `f89e7f79-8829-4433-b4cc-b1c1e2829a95`|

### <a name="BKMK_price_level_products"></a> price_level_products

Many-To-One Relationship: [product price_level_products](product.md#BKMK_price_level_products)

|Property|Value|
|---|---|
|ReferencingEntity|`product`|
|ReferencingAttribute|`pricelevelid`|
|ReferencedEntityNavigationPropertyName|`price_level_products`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_price_level_quotes"></a> price_level_quotes

Many-To-One Relationship: [quote price_level_quotes](quote.md#BKMK_price_level_quotes)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`pricelevelid`|
|ReferencedEntityNavigationPropertyName|`price_level_quotes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_PriceLevel_AsyncOperations"></a> PriceLevel_AsyncOperations

Many-To-One Relationship: [asyncoperation PriceLevel_AsyncOperations](asyncoperation.md#BKMK_PriceLevel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`PriceLevel_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_PriceLevel_BulkDeleteFailures"></a> PriceLevel_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure PriceLevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_PriceLevel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`PriceLevel_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_pricelevel_connections1"></a> pricelevel_connections1

Many-To-One Relationship: [connection pricelevel_connections1](connection.md#BKMK_pricelevel_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`pricelevel_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_pricelevel_connections2"></a> pricelevel_connections2

Many-To-One Relationship: [connection pricelevel_connections2](connection.md#BKMK_pricelevel_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`pricelevel_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_pricelevel_MailboxTrackingFolders"></a> pricelevel_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder pricelevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_pricelevel_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`pricelevel_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_pricelevel_principalobjectattributeaccess"></a> pricelevel_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess pricelevel_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_pricelevel_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`pricelevel_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_PriceLevel_ProcessSessions"></a> PriceLevel_ProcessSessions

Many-To-One Relationship: [processsession PriceLevel_ProcessSessions](processsession.md#BKMK_PriceLevel_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`PriceLevel_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_PriceLevel_SyncErrors"></a> PriceLevel_SyncErrors

Many-To-One Relationship: [syncerror PriceLevel_SyncErrors](syncerror.md#BKMK_PriceLevel_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`PriceLevel_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_PriceList_Campaigns"></a> PriceList_Campaigns

Many-To-One Relationship: [campaign PriceList_Campaigns](campaign.md#BKMK_PriceList_Campaigns)

|Property|Value|
|---|---|
|ReferencingEntity|`campaign`|
|ReferencingAttribute|`pricelistid`|
|ReferencedEntityNavigationPropertyName|`PriceList_Campaigns`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

