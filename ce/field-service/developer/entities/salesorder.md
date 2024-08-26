---
title: "Order (SalesOrder) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Order (SalesOrder) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Order (SalesOrder) table/entity reference (Microsoft Dynamics 365 Field Service)

Quote that has been accepted.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Order (SalesOrder) table extends the [Microsoft Dynamics 365 Order (SalesOrder) table](/dynamics365/developer/entities/salesorder).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_ordertype](#BKMK_msdyn_ordertype)
- [msdyn_ProcessStartedOn](#BKMK_msdyn_ProcessStartedOn)

### <a name="BKMK_msdyn_Account"></a> msdyn_Account

|Property|Value|
|---|---|
|Description|**Customer Account associated with this Order**|
|DisplayName|**Potential Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_account`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_ordertype"></a> msdyn_ordertype

|Property|Value|
|---|---|
|Description|**Internal use only**|
|DisplayName|**Order Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ordertype`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_salesorder_msdyn_ordertype`|

#### msdyn_ordertype Choices/Options

|Value|Label|
|---|---|
|192350000|**Item based**|
|690970002|**Service-Maintenance Based**|

### <a name="BKMK_msdyn_ProcessStartedOn"></a> msdyn_ProcessStartedOn

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Process Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_processstartedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_StatusCode"></a> StatusCode

Changes from [StatusCode (Microsoft Dynamics 365)](/dynamics365/developer/entities/salesorder#BKMK_StatusCode)

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1||
|2||
|3||
|4||
|100001||
|100002||
|100003||
|690970000|Label: On hold|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_account_salesorder_Account](#BKMK_msdyn_account_salesorder_Account)
- [transactioncurrency_salesorder](#BKMK_transactioncurrency_salesorder)

### <a name="BKMK_msdyn_account_salesorder_Account"></a> msdyn_account_salesorder_Account

One-To-Many Relationship: [account msdyn_account_salesorder_Account](account.md#BKMK_msdyn_account_salesorder_Account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_account`|
|ReferencingEntityNavigationPropertyName|`msdyn_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_salesorder"></a> transactioncurrency_salesorder

One-To-Many Relationship: [transactioncurrency transactioncurrency_salesorder](transactioncurrency.md#BKMK_transactioncurrency_salesorder)

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

- [msdyn_salesorder_msdyn_actual_SalesContract](#BKMK_msdyn_salesorder_msdyn_actual_SalesContract)
- [msdyn_salesorder_msdyn_orderinvoicingdate_Order](#BKMK_msdyn_salesorder_msdyn_orderinvoicingdate_Order)
- [msdyn_salesorder_msdyn_orderinvoicingsetup_Order](#BKMK_msdyn_salesorder_msdyn_orderinvoicingsetup_Order)
- [msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order](#BKMK_msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order)
- [salesorder_msdyn_bookingalerts](#BKMK_salesorder_msdyn_bookingalerts)

### <a name="BKMK_msdyn_salesorder_msdyn_actual_SalesContract"></a> msdyn_salesorder_msdyn_actual_SalesContract

Many-To-One Relationship: [msdyn_actual msdyn_salesorder_msdyn_actual_SalesContract](msdyn_actual.md#BKMK_msdyn_salesorder_msdyn_actual_SalesContract)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_salescontract`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesorder_msdyn_actual_SalesContract`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesorder_msdyn_orderinvoicingdate_Order"></a> msdyn_salesorder_msdyn_orderinvoicingdate_Order

Many-To-One Relationship: [msdyn_orderinvoicingdate msdyn_salesorder_msdyn_orderinvoicingdate_Order](msdyn_orderinvoicingdate.md#BKMK_msdyn_salesorder_msdyn_orderinvoicingdate_Order)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingdate`|
|ReferencingAttribute|`msdyn_order`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesorder_msdyn_orderinvoicingdate_Order`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesorder_msdyn_orderinvoicingsetup_Order"></a> msdyn_salesorder_msdyn_orderinvoicingsetup_Order

Many-To-One Relationship: [msdyn_orderinvoicingsetup msdyn_salesorder_msdyn_orderinvoicingsetup_Order](msdyn_orderinvoicingsetup.md#BKMK_msdyn_salesorder_msdyn_orderinvoicingsetup_Order)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetup`|
|ReferencingAttribute|`msdyn_order`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesorder_msdyn_orderinvoicingsetup_Order`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order"></a> msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order

Many-To-One Relationship: [msdyn_orderinvoicingsetupdate msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencingAttribute|`msdyn_order`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_msdyn_bookingalerts"></a> salesorder_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert salesorder_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_salesorder_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

