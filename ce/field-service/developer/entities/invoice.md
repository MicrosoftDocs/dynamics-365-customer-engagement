---
title: "Invoice table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Invoice table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Invoice table/entity reference

Order that has been billed.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Invoice table extends the [Microsoft Dynamics 365 Invoice table](/dynamics365/developer/entities/invoice).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_AmountDue](#BKMK_msdyn_AmountDue)
- [msdyn_InvoiceDate](#BKMK_msdyn_InvoiceDate)
- [msdyn_OrderType](#BKMK_msdyn_OrderType)

### <a name="BKMK_msdyn_AmountDue"></a> msdyn_AmountDue

|Property|Value|
|---|---|
|Description|**Enter the amount due on this invoice.**|
|DisplayName|**Amount Due**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_amountdue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_InvoiceDate"></a> msdyn_InvoiceDate

|Property|Value|
|---|---|
|Description|**Document date of the Invoice for use in calculation of payment due date**|
|DisplayName|**Invoice Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_invoicedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_OrderType"></a> msdyn_OrderType

|Property|Value|
|---|---|
|Description|**Whether the Invoice is for an Item-based or a service maintainence-based sale**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ordertype`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_invoice_msdyn_ordertype`|

#### msdyn_OrderType Choices/Options

|Value|Label|
|---|---|
|192350000|**Item based**|
|690970002|**Service-Maintenance Based**|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

### <a name="BKMK_msdyn_amountdue_Base"></a> msdyn_amountdue_Base

|Property|Value|
|---|---|
|Description|**Value of the Amount Due in base currency.**|
|DisplayName|**Amount Due (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_amountdue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_invoice"></a> transactioncurrency_invoice

One-To-Many Relationship: [transactioncurrency transactioncurrency_invoice](transactioncurrency.md#BKMK_transactioncurrency_invoice)

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

- [invoice_msdyn_bookingalerts](#BKMK_invoice_msdyn_bookingalerts)
- [msdyn_invoice_msdyn_actual_Invoice](#BKMK_msdyn_invoice_msdyn_actual_Invoice)
- [msdyn_invoice_msdyn_agreementinvoicedate_Invoice](#BKMK_msdyn_invoice_msdyn_agreementinvoicedate_Invoice)
- [msdyn_invoice_msdyn_orderinvoicingdate_Invoice](#BKMK_msdyn_invoice_msdyn_orderinvoicingdate_Invoice)
- [msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice](#BKMK_msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice)
- [msdyn_invoice_msdyn_paymentdetail_Invoice](#BKMK_msdyn_invoice_msdyn_paymentdetail_Invoice)

### <a name="BKMK_invoice_msdyn_bookingalerts"></a> invoice_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert invoice_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_invoice_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_invoice_msdyn_actual_Invoice"></a> msdyn_invoice_msdyn_actual_Invoice

Many-To-One Relationship: [msdyn_actual msdyn_invoice_msdyn_actual_Invoice](msdyn_actual.md#BKMK_msdyn_invoice_msdyn_actual_Invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_invoice`|
|ReferencedEntityNavigationPropertyName|`msdyn_invoice_msdyn_actual_Invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_invoice_msdyn_agreementinvoicedate_Invoice"></a> msdyn_invoice_msdyn_agreementinvoicedate_Invoice

Many-To-One Relationship: [msdyn_agreementinvoicedate msdyn_invoice_msdyn_agreementinvoicedate_Invoice](msdyn_agreementinvoicedate.md#BKMK_msdyn_invoice_msdyn_agreementinvoicedate_Invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicedate`|
|ReferencingAttribute|`msdyn_invoice`|
|ReferencedEntityNavigationPropertyName|`msdyn_invoice_msdyn_agreementinvoicedate_Invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_invoice_msdyn_orderinvoicingdate_Invoice"></a> msdyn_invoice_msdyn_orderinvoicingdate_Invoice

Many-To-One Relationship: [msdyn_orderinvoicingdate msdyn_invoice_msdyn_orderinvoicingdate_Invoice](msdyn_orderinvoicingdate.md#BKMK_msdyn_invoice_msdyn_orderinvoicingdate_Invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingdate`|
|ReferencingAttribute|`msdyn_invoice`|
|ReferencedEntityNavigationPropertyName|`msdyn_invoice_msdyn_orderinvoicingdate_Invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice"></a> msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice

Many-To-One Relationship: [msdyn_orderinvoicingsetupdate msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencingAttribute|`msdyn_invoice`|
|ReferencedEntityNavigationPropertyName|`msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_invoice_msdyn_paymentdetail_Invoice"></a> msdyn_invoice_msdyn_paymentdetail_Invoice

Many-To-One Relationship: [msdyn_paymentdetail msdyn_invoice_msdyn_paymentdetail_Invoice](msdyn_paymentdetail.md#BKMK_msdyn_invoice_msdyn_paymentdetail_Invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentdetail`|
|ReferencingAttribute|`msdyn_invoice`|
|ReferencedEntityNavigationPropertyName|`msdyn_invoice_msdyn_paymentdetail_Invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

