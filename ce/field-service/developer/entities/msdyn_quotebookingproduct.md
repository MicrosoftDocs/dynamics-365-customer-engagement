---
title: "Quote Booking Product (msdyn_quotebookingproduct) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Quote Booking Product (msdyn_quotebookingproduct) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Quote Booking Product (msdyn_quotebookingproduct) table/entity reference (Microsoft Dynamics 365 Field Service)

Provides ability to store information about the products that are associated with Quote Booking Setup

## Messages

The following table lists the messages for the Quote Booking Product (msdyn_quotebookingproduct) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_quotebookingproducts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_quotebookingproducts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_quotebookingproducts(*msdyn_quotebookingproductid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Quote Booking Product (msdyn_quotebookingproduct) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Quote Booking Product (msdyn_quotebookingproduct) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Quote Booking Product** |
| **DisplayCollectionName** | **Quote Booking Products** |
| **SchemaName** | `msdyn_quotebookingproduct` |
| **CollectionSchemaName** | `msdyn_quotebookingproducts` |
| **EntitySetName** | `msdyn_quotebookingproducts`|
| **LogicalName** | `msdyn_quotebookingproduct` |
| **LogicalCollectionName** | `msdyn_quotebookingproducts` |
| **PrimaryIdAttribute** | `msdyn_quotebookingproductid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

### <a name="BKMK_msdyn_currency"></a> msdyn_currency

|Property|Value|
|---|---|
|Description|**The currency that will be used to charge this product**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currency`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_customerasset"></a> msdyn_customerasset

|Property|Value|
|---|---|
|Description|**Customer asset related to this Product**|
|DisplayName|**Customer Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_EstimatedCost"></a> msdyn_EstimatedCost

|Property|Value|
|---|---|
|Description|**The estimated cost of this quote booking product**|
|DisplayName|**Estimated Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_EstimatedSalesAmount"></a> msdyn_EstimatedSalesAmount

|Property|Value|
|---|---|
|Description|**The estimated sales amount of this quote booking product**|
|DisplayName|**Estimated Sales Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedsalesamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_Internalflags"></a> msdyn_Internalflags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_Internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_iscopied"></a> msdyn_iscopied

|Property|Value|
|---|---|
|Description|**Internal use only**|
|DisplayName|**Is Copied**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscopied`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_quotebookingproduct_msdyn_iscopied`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_lineorder"></a> msdyn_lineorder

|Property|Value|
|---|---|
|Description|**Shows the order of this task within the quote booking products.**|
|DisplayName|**Line Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lineorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_pricelist"></a> msdyn_pricelist

|Property|Value|
|---|---|
|Description|**Optionally set Price List that will determine the pricing for this product on the Work Order**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_product"></a> msdyn_product

|Property|Value|
|---|---|
|Description|**Unique identifier for Product/Service associated with Quote Booking Product.**|
|DisplayName|**Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_product`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_qtytobill"></a> msdyn_qtytobill

|Property|Value|
|---|---|
|Description|**Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity."**|
|DisplayName|**Quantity To Bill**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qtytobill`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_quantity"></a> msdyn_quantity

|Property|Value|
|---|---|
|Description|**Shows the actual quantity of the product.**|
|DisplayName|**Quantity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quantity`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_quote"></a> msdyn_quote

|Property|Value|
|---|---|
|Description|**Unique identifier for Quote associated with Quote Booking Product.**|
|DisplayName|**Quote**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quote`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|quote|

### <a name="BKMK_msdyn_quotebookingincident"></a> msdyn_quotebookingincident

|Property|Value|
|---|---|
|Description|**The Quote Booking Incident related to this product**|
|DisplayName|**Quote Booking Incident**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quotebookingincident`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_quotebookingincident|

### <a name="BKMK_msdyn_quotebookingproductId"></a> msdyn_quotebookingproductId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Quote Booking Product**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_quotebookingproductid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_quotebookingsetup"></a> msdyn_quotebookingsetup

|Property|Value|
|---|---|
|Description|**Unique identifier for Quote Booking Setup associated with Quote  Booking Product.**|
|DisplayName|**Quote Booking Setup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quotebookingsetup`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_quotebookingsetup|

### <a name="BKMK_msdyn_unit"></a> msdyn_unit

|Property|Value|
|---|---|
|Description|**The unit that determines the pricing for this product when Price List is set**|
|DisplayName|**Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_msdyn_unitamount"></a> msdyn_unitamount

|Property|Value|
|---|---|
|Description|**Enter the amount you wish to charge the customer per unit. This field is optional.**|
|DisplayName|**Unit Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_unitcostamount"></a> msdyn_unitcostamount

|Property|Value|
|---|---|
|Description|**Enter the  unit cost amount. This field is optional.**|
|DisplayName|**Unit Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitcostamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Quote Booking Product**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_quotebookingproduct_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Quote Booking Product**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_quotebookingproduct_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

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
|Description|**Unique identifier of the currency associated with the entity.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
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
- [msdyn_currency_Base](#BKMK_msdyn_currency_Base)
- [msdyn_estimatedcost_Base](#BKMK_msdyn_estimatedcost_Base)
- [msdyn_estimatedsalesamount_Base](#BKMK_msdyn_estimatedsalesamount_Base)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
- [msdyn_unitcostamount_Base](#BKMK_msdyn_unitcostamount_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
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
|IsValidForForm|True|
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
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the entity with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-10|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
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
|IsValidForForm|True|
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
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_currency_Base"></a> msdyn_currency_Base

|Property|Value|
|---|---|
|Description|**Value of the Currency in base currency.**|
|DisplayName|**Currency (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currency_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedcost_Base"></a> msdyn_estimatedcost_Base

|Property|Value|
|---|---|
|Description|**Value of the EstimatedCost in base currency.**|
|DisplayName|**EstimatedCost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedsalesamount_Base"></a> msdyn_estimatedsalesamount_Base

|Property|Value|
|---|---|
|Description|**Value of the EstimatedSalesAmount in base currency.**|
|DisplayName|**EstimatedSalesAmount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedsalesamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_unitamount_Base"></a> msdyn_unitamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Unit Amount in base currency.**|
|DisplayName|**Unit Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_unitcostamount_Base"></a> msdyn_unitcostamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Unit Cost in base currency.**|
|DisplayName|**Unit Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitcostamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

- [business_unit_msdyn_quotebookingproduct](#BKMK_business_unit_msdyn_quotebookingproduct)
- [lk_msdyn_quotebookingproduct_createdby](#BKMK_lk_msdyn_quotebookingproduct_createdby)
- [lk_msdyn_quotebookingproduct_createdonbehalfby](#BKMK_lk_msdyn_quotebookingproduct_createdonbehalfby)
- [lk_msdyn_quotebookingproduct_modifiedby](#BKMK_lk_msdyn_quotebookingproduct_modifiedby)
- [lk_msdyn_quotebookingproduct_modifiedonbehalfby](#BKMK_lk_msdyn_quotebookingproduct_modifiedonbehalfby)
- [msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup)
- [msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList)
- [msdyn_product_msdyn_quotebookingproduct_Product](#BKMK_msdyn_product_msdyn_quotebookingproduct_Product)
- [msdyn_quote_msdyn_quotebookingproduct_Quote](#BKMK_msdyn_quote_msdyn_quotebookingproduct_Quote)
- [msdyn_uom_msdyn_quotebookingproduct_Unit](#BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit)
- [owner_msdyn_quotebookingproduct](#BKMK_owner_msdyn_quotebookingproduct)
- [team_msdyn_quotebookingproduct](#BKMK_team_msdyn_quotebookingproduct)
- [TransactionCurrency_msdyn_quotebookingproduct](#BKMK_TransactionCurrency_msdyn_quotebookingproduct)
- [user_msdyn_quotebookingproduct](#BKMK_user_msdyn_quotebookingproduct)

### <a name="BKMK_business_unit_msdyn_quotebookingproduct"></a> business_unit_msdyn_quotebookingproduct

One-To-Many Relationship: [businessunit business_unit_msdyn_quotebookingproduct](businessunit.md#BKMK_business_unit_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingproduct_createdby"></a> lk_msdyn_quotebookingproduct_createdby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingproduct_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingproduct_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingproduct_createdonbehalfby"></a> lk_msdyn_quotebookingproduct_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingproduct_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingproduct_modifiedby"></a> lk_msdyn_quotebookingproduct_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingproduct_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingproduct_modifiedonbehalfby"></a> lk_msdyn_quotebookingproduct_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingproduct_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`msdyn_quotebookingincident`|
|ReferencingEntityNavigationPropertyName|`msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](msdyn_quotebookingsetup.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`msdyn_quotebookingsetup`|
|ReferencingEntityNavigationPropertyName|`msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList"></a> msdyn_pricelevel_msdyn_quotebookingproduct_PriceList

One-To-Many Relationship: [pricelevel msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencingEntityNavigationPropertyName|`msdyn_pricelist`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_quotebookingproduct_Product"></a> msdyn_product_msdyn_quotebookingproduct_Product

One-To-Many Relationship: [product msdyn_product_msdyn_quotebookingproduct_Product](product.md#BKMK_msdyn_product_msdyn_quotebookingproduct_Product)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_product`|
|ReferencingEntityNavigationPropertyName|`msdyn_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quote_msdyn_quotebookingproduct_Quote"></a> msdyn_quote_msdyn_quotebookingproduct_Quote

One-To-Many Relationship: [quote msdyn_quote_msdyn_quotebookingproduct_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingproduct_Quote)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`msdyn_quote`|
|ReferencingEntityNavigationPropertyName|`msdyn_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit"></a> msdyn_uom_msdyn_quotebookingproduct_Unit

One-To-Many Relationship: [uom msdyn_uom_msdyn_quotebookingproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencingEntityNavigationPropertyName|`msdyn_unit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_quotebookingproduct"></a> owner_msdyn_quotebookingproduct

One-To-Many Relationship: [owner owner_msdyn_quotebookingproduct](owner.md#BKMK_owner_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_quotebookingproduct"></a> team_msdyn_quotebookingproduct

One-To-Many Relationship: [team team_msdyn_quotebookingproduct](team.md#BKMK_team_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingproduct"></a> TransactionCurrency_msdyn_quotebookingproduct

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_quotebookingproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_quotebookingproduct"></a> user_msdyn_quotebookingproduct

One-To-Many Relationship: [systemuser user_msdyn_quotebookingproduct](systemuser.md#BKMK_user_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_quotebookingproduct_ActivityPointers](#BKMK_msdyn_quotebookingproduct_ActivityPointers)
- [msdyn_quotebookingproduct_adx_inviteredemptions](#BKMK_msdyn_quotebookingproduct_adx_inviteredemptions)
- [msdyn_quotebookingproduct_adx_portalcomments](#BKMK_msdyn_quotebookingproduct_adx_portalcomments)
- [msdyn_quotebookingproduct_Annotations](#BKMK_msdyn_quotebookingproduct_Annotations)
- [msdyn_quotebookingproduct_Appointments](#BKMK_msdyn_quotebookingproduct_Appointments)
- [msdyn_quotebookingproduct_AsyncOperations](#BKMK_msdyn_quotebookingproduct_AsyncOperations)
- [msdyn_quotebookingproduct_BulkDeleteFailures](#BKMK_msdyn_quotebookingproduct_BulkDeleteFailures)
- [msdyn_quotebookingproduct_chats](#BKMK_msdyn_quotebookingproduct_chats)
- [msdyn_quotebookingproduct_connections1](#BKMK_msdyn_quotebookingproduct_connections1)
- [msdyn_quotebookingproduct_connections2](#BKMK_msdyn_quotebookingproduct_connections2)
- [msdyn_quotebookingproduct_DuplicateBaseRecord](#BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord)
- [msdyn_quotebookingproduct_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord)
- [msdyn_quotebookingproduct_Emails](#BKMK_msdyn_quotebookingproduct_Emails)
- [msdyn_quotebookingproduct_Faxes](#BKMK_msdyn_quotebookingproduct_Faxes)
- [msdyn_quotebookingproduct_Letters](#BKMK_msdyn_quotebookingproduct_Letters)
- [msdyn_quotebookingproduct_MailboxTrackingFolders](#BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders)
- [msdyn_quotebookingproduct_msdyn_bookingalerts](#BKMK_msdyn_quotebookingproduct_msdyn_bookingalerts)
- [msdyn_quotebookingproduct_msdyn_copilottranscripts](#BKMK_msdyn_quotebookingproduct_msdyn_copilottranscripts)
- [msdyn_quotebookingproduct_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingproduct_msdyn_ocliveworkitems)
- [msdyn_quotebookingproduct_msdyn_ocsessions](#BKMK_msdyn_quotebookingproduct_msdyn_ocsessions)
- [msdyn_quotebookingproduct_msfp_alerts](#BKMK_msdyn_quotebookingproduct_msfp_alerts)
- [msdyn_quotebookingproduct_msfp_surveyinvites](#BKMK_msdyn_quotebookingproduct_msfp_surveyinvites)
- [msdyn_quotebookingproduct_msfp_surveyresponses](#BKMK_msdyn_quotebookingproduct_msfp_surveyresponses)
- [msdyn_quotebookingproduct_PhoneCalls](#BKMK_msdyn_quotebookingproduct_PhoneCalls)
- [msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingproduct_ProcessSession](#BKMK_msdyn_quotebookingproduct_ProcessSession)
- [msdyn_quotebookingproduct_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters)
- [msdyn_quotebookingproduct_ServiceAppointments](#BKMK_msdyn_quotebookingproduct_ServiceAppointments)
- [msdyn_quotebookingproduct_SocialActivities](#BKMK_msdyn_quotebookingproduct_SocialActivities)
- [msdyn_quotebookingproduct_SyncErrors](#BKMK_msdyn_quotebookingproduct_SyncErrors)
- [msdyn_quotebookingproduct_Tasks](#BKMK_msdyn_quotebookingproduct_Tasks)

### <a name="BKMK_msdyn_quotebookingproduct_ActivityPointers"></a> msdyn_quotebookingproduct_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_quotebookingproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_quotebookingproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_adx_inviteredemptions"></a> msdyn_quotebookingproduct_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_quotebookingproduct_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_quotebookingproduct_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_adx_portalcomments"></a> msdyn_quotebookingproduct_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_quotebookingproduct_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_quotebookingproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_Annotations"></a> msdyn_quotebookingproduct_Annotations

Many-To-One Relationship: [annotation msdyn_quotebookingproduct_Annotations](annotation.md#BKMK_msdyn_quotebookingproduct_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_Appointments"></a> msdyn_quotebookingproduct_Appointments

Many-To-One Relationship: [appointment msdyn_quotebookingproduct_Appointments](appointment.md#BKMK_msdyn_quotebookingproduct_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_AsyncOperations"></a> msdyn_quotebookingproduct_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_quotebookingproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_BulkDeleteFailures"></a> msdyn_quotebookingproduct_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_quotebookingproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_chats"></a> msdyn_quotebookingproduct_chats

Many-To-One Relationship: [chat msdyn_quotebookingproduct_chats](chat.md#BKMK_msdyn_quotebookingproduct_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_connections1"></a> msdyn_quotebookingproduct_connections1

Many-To-One Relationship: [connection msdyn_quotebookingproduct_connections1](connection.md#BKMK_msdyn_quotebookingproduct_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_connections2"></a> msdyn_quotebookingproduct_connections2

Many-To-One Relationship: [connection msdyn_quotebookingproduct_connections2](connection.md#BKMK_msdyn_quotebookingproduct_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord"></a> msdyn_quotebookingproduct_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_quotebookingproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord"></a> msdyn_quotebookingproduct_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_quotebookingproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_Emails"></a> msdyn_quotebookingproduct_Emails

Many-To-One Relationship: [email msdyn_quotebookingproduct_Emails](email.md#BKMK_msdyn_quotebookingproduct_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_Faxes"></a> msdyn_quotebookingproduct_Faxes

Many-To-One Relationship: [fax msdyn_quotebookingproduct_Faxes](fax.md#BKMK_msdyn_quotebookingproduct_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_Letters"></a> msdyn_quotebookingproduct_Letters

Many-To-One Relationship: [letter msdyn_quotebookingproduct_Letters](letter.md#BKMK_msdyn_quotebookingproduct_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders"></a> msdyn_quotebookingproduct_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_quotebookingproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_bookingalerts"></a> msdyn_quotebookingproduct_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_quotebookingproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_quotebookingproduct_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_copilottranscripts"></a> msdyn_quotebookingproduct_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_quotebookingproduct_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_quotebookingproduct_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_ocliveworkitems"></a> msdyn_quotebookingproduct_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_quotebookingproduct_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_quotebookingproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_ocsessions"></a> msdyn_quotebookingproduct_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_quotebookingproduct_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_quotebookingproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_msfp_alerts"></a> msdyn_quotebookingproduct_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_quotebookingproduct_msfp_alerts](msfp_alert.md#BKMK_msdyn_quotebookingproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_msfp_surveyinvites"></a> msdyn_quotebookingproduct_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_quotebookingproduct_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_quotebookingproduct_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_msfp_surveyresponses"></a> msdyn_quotebookingproduct_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_quotebookingproduct_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_quotebookingproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_PhoneCalls"></a> msdyn_quotebookingproduct_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_quotebookingproduct_PhoneCalls](phonecall.md#BKMK_msdyn_quotebookingproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_ProcessSession"></a> msdyn_quotebookingproduct_ProcessSession

Many-To-One Relationship: [processsession msdyn_quotebookingproduct_ProcessSession](processsession.md#BKMK_msdyn_quotebookingproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters"></a> msdyn_quotebookingproduct_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_quotebookingproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_ServiceAppointments"></a> msdyn_quotebookingproduct_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_quotebookingproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_quotebookingproduct_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_SocialActivities"></a> msdyn_quotebookingproduct_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_quotebookingproduct_SocialActivities](socialactivity.md#BKMK_msdyn_quotebookingproduct_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_SyncErrors"></a> msdyn_quotebookingproduct_SyncErrors

Many-To-One Relationship: [syncerror msdyn_quotebookingproduct_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingproduct_Tasks"></a> msdyn_quotebookingproduct_Tasks

Many-To-One Relationship: [task msdyn_quotebookingproduct_Tasks](task.md#BKMK_msdyn_quotebookingproduct_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingproduct_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

