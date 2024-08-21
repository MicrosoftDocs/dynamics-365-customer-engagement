---
title: "Currency (TransactionCurrency) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Currency (TransactionCurrency) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Currency (TransactionCurrency) table/entity reference

Currency in which a financial transaction is carried out.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Currency (TransactionCurrency) table extends the [Microsoft Dataverse Currency (TransactionCurrency) table](/power-apps/developer/data-platform/reference/entities/transactioncurrency).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid)
- [msdyn_transactioncurrency_invoicedetail_Currency](#BKMK_msdyn_transactioncurrency_invoicedetail_Currency)
- [TransactionCurrency_msdyn_actual](#BKMK_TransactionCurrency_msdyn_actual)
- [TransactionCurrency_msdyn_agreementbookingproduct](#BKMK_TransactionCurrency_msdyn_agreementbookingproduct)
- [TransactionCurrency_msdyn_agreementbookingservice](#BKMK_TransactionCurrency_msdyn_agreementbookingservice)
- [TransactionCurrency_msdyn_agreementinvoiceproduct](#BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct)
- [TransactionCurrency_msdyn_bookingjournal](#BKMK_TransactionCurrency_msdyn_bookingjournal)
- [TransactionCurrency_msdyn_fieldservicepricelistitem](#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem)
- [TransactionCurrency_msdyn_nottoexceed](#BKMK_TransactionCurrency_msdyn_nottoexceed)
- [TransactionCurrency_msdyn_orderinvoicingproduct](#BKMK_TransactionCurrency_msdyn_orderinvoicingproduct)
- [TransactionCurrency_msdyn_payment](#BKMK_TransactionCurrency_msdyn_payment)
- [TransactionCurrency_msdyn_paymentdetail](#BKMK_TransactionCurrency_msdyn_paymentdetail)
- [TransactionCurrency_msdyn_problematicasset](#BKMK_TransactionCurrency_msdyn_problematicasset)
- [TransactionCurrency_msdyn_purchaseorder](#BKMK_TransactionCurrency_msdyn_purchaseorder)
- [TransactionCurrency_msdyn_purchaseorderbill](#BKMK_TransactionCurrency_msdyn_purchaseorderbill)
- [TransactionCurrency_msdyn_purchaseorderproduct](#BKMK_TransactionCurrency_msdyn_purchaseorderproduct)
- [TransactionCurrency_msdyn_purchaseorderreceiptproduct](#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct)
- [TransactionCurrency_msdyn_quotebookingproduct](#BKMK_TransactionCurrency_msdyn_quotebookingproduct)
- [TransactionCurrency_msdyn_quotebookingservice](#BKMK_TransactionCurrency_msdyn_quotebookingservice)
- [TransactionCurrency_msdyn_quotebookingsetup](#BKMK_TransactionCurrency_msdyn_quotebookingsetup)
- [TransactionCurrency_msdyn_quoteinvoicingproduct](#BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct)
- [TransactionCurrency_msdyn_quoteinvoicingsetup](#BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup)
- [TransactionCurrency_msdyn_rma](#BKMK_TransactionCurrency_msdyn_rma)
- [TransactionCurrency_msdyn_rmaproduct](#BKMK_TransactionCurrency_msdyn_rmaproduct)
- [TransactionCurrency_msdyn_rtv](#BKMK_TransactionCurrency_msdyn_rtv)
- [TransactionCurrency_msdyn_rtvproduct](#BKMK_TransactionCurrency_msdyn_rtvproduct)
- [TransactionCurrency_msdyn_workorder](#BKMK_TransactionCurrency_msdyn_workorder)
- [TransactionCurrency_msdyn_workordernte](#BKMK_TransactionCurrency_msdyn_workordernte)
- [TransactionCurrency_msdyn_workorderproduct](#BKMK_TransactionCurrency_msdyn_workorderproduct)
- [TransactionCurrency_msdyn_workorderservice](#BKMK_TransactionCurrency_msdyn_workorderservice)

### <a name="BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid"></a> msdyn_bookingalert_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_transactioncurrency_transactioncurrencyid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transactioncurrency_invoicedetail_Currency"></a> msdyn_transactioncurrency_invoicedetail_Currency

Many-To-One Relationship: [invoicedetail msdyn_transactioncurrency_invoicedetail_Currency](invoicedetail.md#BKMK_msdyn_transactioncurrency_invoicedetail_Currency)

|Property|Value|
|---|---|
|ReferencingEntity|`invoicedetail`|
|ReferencingAttribute|`msdyn_currency`|
|ReferencedEntityNavigationPropertyName|`msdyn_transactioncurrency_invoicedetail_Currency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_actual"></a> TransactionCurrency_msdyn_actual

Many-To-One Relationship: [msdyn_actual TransactionCurrency_msdyn_actual](msdyn_actual.md#BKMK_TransactionCurrency_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_agreementbookingproduct"></a> TransactionCurrency_msdyn_agreementbookingproduct

Many-To-One Relationship: [msdyn_agreementbookingproduct TransactionCurrency_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_TransactionCurrency_msdyn_agreementbookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_agreementbookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_agreementbookingservice"></a> TransactionCurrency_msdyn_agreementbookingservice

Many-To-One Relationship: [msdyn_agreementbookingservice TransactionCurrency_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_TransactionCurrency_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_agreementbookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct"></a> TransactionCurrency_msdyn_agreementinvoiceproduct

Many-To-One Relationship: [msdyn_agreementinvoiceproduct TransactionCurrency_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_agreementinvoiceproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_bookingjournal"></a> TransactionCurrency_msdyn_bookingjournal

Many-To-One Relationship: [msdyn_bookingjournal TransactionCurrency_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_TransactionCurrency_msdyn_bookingjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingjournal`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_bookingjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem"></a> TransactionCurrency_msdyn_fieldservicepricelistitem

Many-To-One Relationship: [msdyn_fieldservicepricelistitem TransactionCurrency_msdyn_fieldservicepricelistitem](msdyn_fieldservicepricelistitem.md#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicepricelistitem`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_fieldservicepricelistitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_nottoexceed"></a> TransactionCurrency_msdyn_nottoexceed

Many-To-One Relationship: [msdyn_nottoexceed TransactionCurrency_msdyn_nottoexceed](msdyn_nottoexceed.md#BKMK_TransactionCurrency_msdyn_nottoexceed)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_nottoexceed`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_orderinvoicingproduct"></a> TransactionCurrency_msdyn_orderinvoicingproduct

Many-To-One Relationship: [msdyn_orderinvoicingproduct TransactionCurrency_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_TransactionCurrency_msdyn_orderinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_orderinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_payment"></a> TransactionCurrency_msdyn_payment

Many-To-One Relationship: [msdyn_payment TransactionCurrency_msdyn_payment](msdyn_payment.md#BKMK_TransactionCurrency_msdyn_payment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_payment`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_payment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_paymentdetail"></a> TransactionCurrency_msdyn_paymentdetail

Many-To-One Relationship: [msdyn_paymentdetail TransactionCurrency_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_TransactionCurrency_msdyn_paymentdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentdetail`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_paymentdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_problematicasset"></a> TransactionCurrency_msdyn_problematicasset

Many-To-One Relationship: [msdyn_problematicasset TransactionCurrency_msdyn_problematicasset](msdyn_problematicasset.md#BKMK_TransactionCurrency_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicasset`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_problematicasset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorder"></a> TransactionCurrency_msdyn_purchaseorder

Many-To-One Relationship: [msdyn_purchaseorder TransactionCurrency_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_TransactionCurrency_msdyn_purchaseorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_purchaseorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderbill"></a> TransactionCurrency_msdyn_purchaseorderbill

Many-To-One Relationship: [msdyn_purchaseorderbill TransactionCurrency_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_TransactionCurrency_msdyn_purchaseorderbill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderbill`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_purchaseorderbill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderproduct"></a> TransactionCurrency_msdyn_purchaseorderproduct

Many-To-One Relationship: [msdyn_purchaseorderproduct TransactionCurrency_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_TransactionCurrency_msdyn_purchaseorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_purchaseorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct"></a> TransactionCurrency_msdyn_purchaseorderreceiptproduct

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct TransactionCurrency_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_purchaseorderreceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingproduct"></a> TransactionCurrency_msdyn_quotebookingproduct

Many-To-One Relationship: [msdyn_quotebookingproduct TransactionCurrency_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_TransactionCurrency_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quotebookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingservice"></a> TransactionCurrency_msdyn_quotebookingservice

Many-To-One Relationship: [msdyn_quotebookingservice TransactionCurrency_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_TransactionCurrency_msdyn_quotebookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quotebookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingsetup"></a> TransactionCurrency_msdyn_quotebookingsetup

Many-To-One Relationship: [msdyn_quotebookingsetup TransactionCurrency_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_TransactionCurrency_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quotebookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct"></a> TransactionCurrency_msdyn_quoteinvoicingproduct

Many-To-One Relationship: [msdyn_quoteinvoicingproduct TransactionCurrency_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quoteinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup"></a> TransactionCurrency_msdyn_quoteinvoicingsetup

Many-To-One Relationship: [msdyn_quoteinvoicingsetup TransactionCurrency_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingsetup`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quoteinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_rma"></a> TransactionCurrency_msdyn_rma

Many-To-One Relationship: [msdyn_rma TransactionCurrency_msdyn_rma](msdyn_rma.md#BKMK_TransactionCurrency_msdyn_rma)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_rma`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_rmaproduct"></a> TransactionCurrency_msdyn_rmaproduct

Many-To-One Relationship: [msdyn_rmaproduct TransactionCurrency_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_TransactionCurrency_msdyn_rmaproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_rmaproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_rtv"></a> TransactionCurrency_msdyn_rtv

Many-To-One Relationship: [msdyn_rtv TransactionCurrency_msdyn_rtv](msdyn_rtv.md#BKMK_TransactionCurrency_msdyn_rtv)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_rtv`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_rtvproduct"></a> TransactionCurrency_msdyn_rtvproduct

Many-To-One Relationship: [msdyn_rtvproduct TransactionCurrency_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_TransactionCurrency_msdyn_rtvproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_rtvproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_workorder"></a> TransactionCurrency_msdyn_workorder

Many-To-One Relationship: [msdyn_workorder TransactionCurrency_msdyn_workorder](msdyn_workorder.md#BKMK_TransactionCurrency_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_workordernte"></a> TransactionCurrency_msdyn_workordernte

Many-To-One Relationship: [msdyn_workordernte TransactionCurrency_msdyn_workordernte](msdyn_workordernte.md#BKMK_TransactionCurrency_msdyn_workordernte)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordernte`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_workordernte`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_workorderproduct"></a> TransactionCurrency_msdyn_workorderproduct

Many-To-One Relationship: [msdyn_workorderproduct TransactionCurrency_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_TransactionCurrency_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_workorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_workorderservice"></a> TransactionCurrency_msdyn_workorderservice

Many-To-One Relationship: [msdyn_workorderservice TransactionCurrency_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_TransactionCurrency_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_workorderservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.transactioncurrency?displayProperty=fullName>
