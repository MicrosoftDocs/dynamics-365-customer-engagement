---
title: "Field Service Price List Item (msdyn_fieldservicepricelistitem) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Field Service Price List Item (msdyn_fieldservicepricelistitem) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Field Service Price List Item (msdyn_fieldservicepricelistitem) table/entity reference (Microsoft Dynamics 365 Field Service)

Pricing options in addition to or above the Price List Items

## Messages

The following table lists the messages for the Field Service Price List Item (msdyn_fieldservicepricelistitem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_fieldservicepricelistitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_fieldservicepricelistitems(*msdyn_fieldservicepricelistitemid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_fieldservicepricelistitems(*msdyn_fieldservicepricelistitemid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_fieldservicepricelistitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyn_fieldservicepricelistitems(*msdyn_fieldservicepricelistitemid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_fieldservicepricelistitems(*msdyn_fieldservicepricelistitemid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_fieldservicepricelistitems(*msdyn_fieldservicepricelistitemid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Field Service Price List Item (msdyn_fieldservicepricelistitem) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Field Service Price List Item (msdyn_fieldservicepricelistitem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Field Service Price List Item** |
| **DisplayCollectionName** | **Field Service Price List Items** |
| **SchemaName** | `msdyn_fieldservicepricelistitem` |
| **CollectionSchemaName** | `msdyn_fieldservicepricelistitems` |
| **EntitySetName** | `msdyn_fieldservicepricelistitems`|
| **LogicalName** | `msdyn_fieldservicepricelistitem` |
| **LogicalCollectionName** | `msdyn_fieldservicepricelistitems` |
| **PrimaryIdAttribute** | `msdyn_fieldservicepricelistitemid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

|Property|Value|
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_DurationRoundingPolicy"></a> msdyn_DurationRoundingPolicy

|Property|Value|
|---|---|
|Description|**Specify how the system should round the Duration To Bill on the Work Order Service**|
|DisplayName|**Duration Rounding Policy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_durationroundingpolicy`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_durationroundingpolicy`|

#### msdyn_DurationRoundingPolicy Choices/Options

|Value|Label|
|---|---|
|690970000|**None**|
|690970001|**Up**|
|690970002|**Down**|
|690970003|**Nearest**|

### <a name="BKMK_msdyn_DurationRoundTo"></a> msdyn_DurationRoundTo

|Property|Value|
|---|---|
|Description|**Specify the rounding duration.**|
|DisplayName|**Duration Round To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_durationroundto`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_fieldservicepricelistitemId"></a> msdyn_fieldservicepricelistitemId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Field Service Price List Item**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldservicepricelistitemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_FlatFee"></a> msdyn_FlatFee

|Property|Value|
|---|---|
|Description|**If enabled then the pricing of this item will not be multiplied by quantity**|
|DisplayName|**Flat Fee**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_flatfee`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicepricelistitem_msdyn_flatfee`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_MinimumChargeAmount"></a> msdyn_MinimumChargeAmount

|Property|Value|
|---|---|
|Description|**Specify the minimum charge you wish to charge for this service. See note on Minimum Charge Duration**|
|DisplayName|**Minimum Charge Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_minimumchargeamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_MinimumChargeDuration"></a> msdyn_MinimumChargeDuration

|Property|Value|
|---|---|
|Description|**If this field has a value, the Minimum Charge Amount will first apply to the Minimum Duration and beyond the minimum duration the regular fee will apply**|
|DisplayName|**Minimum Charge Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_minimumchargeduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
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

### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|---|---|
|Description|**Shows the price list associated with the field service price list item.**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_ProductService"></a> msdyn_ProductService

|Property|Value|
|---|---|
|Description|**If you wish to limit this price list item to a certain product or service you can specify it. Otherwise this should be left blank**|
|DisplayName|**Product / Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_productservice`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Field Service Price List Item**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_fieldservicepricelistitem_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Shows the reason for the status of the field service price list item.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_fieldservicepricelistitem_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
- [msdyn_minimumchargeamount_Base](#BKMK_msdyn_minimumchargeamount_Base)
- [OrganizationId](#BKMK_OrganizationId)
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the exchange rate for the currency associated with the entity with respect to the base currency.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_minimumchargeamount_Base"></a> msdyn_minimumchargeamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the minimum charge amount in the base currency.**|
|DisplayName|**Minimum Charge Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_minimumchargeamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
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

- [lk_msdyn_fieldservicepricelistitem_createdby](#BKMK_lk_msdyn_fieldservicepricelistitem_createdby)
- [lk_msdyn_fieldservicepricelistitem_createdonbehalfby](#BKMK_lk_msdyn_fieldservicepricelistitem_createdonbehalfby)
- [lk_msdyn_fieldservicepricelistitem_modifiedby](#BKMK_lk_msdyn_fieldservicepricelistitem_modifiedby)
- [lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby](#BKMK_lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby)
- [msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList)
- [msdyn_product_msdyn_fieldservicepricelistitem_ProductService](#BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService)
- [organization_msdyn_fieldservicepricelistitem](#BKMK_organization_msdyn_fieldservicepricelistitem)
- [TransactionCurrency_msdyn_fieldservicepricelistitem](#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem)

### <a name="BKMK_lk_msdyn_fieldservicepricelistitem_createdby"></a> lk_msdyn_fieldservicepricelistitem_createdby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicepricelistitem_createdby](systemuser.md#BKMK_lk_msdyn_fieldservicepricelistitem_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicepricelistitem_createdonbehalfby"></a> lk_msdyn_fieldservicepricelistitem_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicepricelistitem_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicepricelistitem_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicepricelistitem_modifiedby"></a> lk_msdyn_fieldservicepricelistitem_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicepricelistitem_modifiedby](systemuser.md#BKMK_lk_msdyn_fieldservicepricelistitem_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby"></a> lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList"></a> msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList

One-To-Many Relationship: [pricelevel msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencingEntityNavigationPropertyName|`msdyn_pricelist`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService"></a> msdyn_product_msdyn_fieldservicepricelistitem_ProductService

One-To-Many Relationship: [product msdyn_product_msdyn_fieldservicepricelistitem_ProductService](product.md#BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_productservice`|
|ReferencingEntityNavigationPropertyName|`msdyn_productservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_fieldservicepricelistitem"></a> organization_msdyn_fieldservicepricelistitem

One-To-Many Relationship: [organization organization_msdyn_fieldservicepricelistitem](organization.md#BKMK_organization_msdyn_fieldservicepricelistitem)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem"></a> TransactionCurrency_msdyn_fieldservicepricelistitem

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_fieldservicepricelistitem](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_fieldservicepricelistitem_AsyncOperations](#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations)
- [msdyn_fieldservicepricelistitem_BulkDeleteFailures](#BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures)
- [msdyn_fieldservicepricelistitem_DuplicateBaseRecord](#BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord)
- [msdyn_fieldservicepricelistitem_DuplicateMatchingRecord](#BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord)
- [msdyn_fieldservicepricelistitem_MailboxTrackingFolders](#BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders)
- [msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicepricelistitem_ProcessSession](#BKMK_msdyn_fieldservicepricelistitem_ProcessSession)
- [msdyn_fieldservicepricelistitem_SyncErrors](#BKMK_msdyn_fieldservicepricelistitem_SyncErrors)

### <a name="BKMK_msdyn_fieldservicepricelistitem_AsyncOperations"></a> msdyn_fieldservicepricelistitem_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_fieldservicepricelistitem_AsyncOperations](asyncoperation.md#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicepricelistitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures"></a> msdyn_fieldservicepricelistitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_fieldservicepricelistitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicepricelistitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord"></a> msdyn_fieldservicepricelistitem_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_fieldservicepricelistitem_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicepricelistitem_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord"></a> msdyn_fieldservicepricelistitem_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_fieldservicepricelistitem_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicepricelistitem_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders"></a> msdyn_fieldservicepricelistitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_fieldservicepricelistitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicepricelistitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_ProcessSession"></a> msdyn_fieldservicepricelistitem_ProcessSession

Many-To-One Relationship: [processsession msdyn_fieldservicepricelistitem_ProcessSession](processsession.md#BKMK_msdyn_fieldservicepricelistitem_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicepricelistitem_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_SyncErrors"></a> msdyn_fieldservicepricelistitem_SyncErrors

Many-To-One Relationship: [syncerror msdyn_fieldservicepricelistitem_SyncErrors](syncerror.md#BKMK_msdyn_fieldservicepricelistitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicepricelistitem_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

