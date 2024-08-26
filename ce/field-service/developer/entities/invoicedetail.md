---
title: "Invoice Product (InvoiceDetail) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Invoice Product (InvoiceDetail) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Invoice Product (InvoiceDetail) table/entity reference (Microsoft Dynamics 365 Field Service)

Line item in an invoice containing detailed billing information for a product.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Invoice Product (InvoiceDetail) table extends the [Microsoft Dynamics 365 Invoice Product (InvoiceDetail) table](/dynamics365/developer/entities/invoicedetail).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_AgreementInvoiceProduct](#BKMK_msdyn_AgreementInvoiceProduct)
- [msdyn_Currency](#BKMK_msdyn_Currency)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_LineType](#BKMK_msdyn_LineType)
- [msdyn_OrderInvoicingProduct](#BKMK_msdyn_OrderInvoicingProduct)
- [msdyn_WorkOrderId](#BKMK_msdyn_WorkOrderId)
- [msdyn_WorkOrderProductId](#BKMK_msdyn_WorkOrderProductId)
- [msdyn_WorkOrderServiceId](#BKMK_msdyn_WorkOrderServiceId)

### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

|Property|Value|
|---|---|
|Description|**Unique identifier for Agreement associated with Invoice Product.**|
|DisplayName|**Agreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreement|

### <a name="BKMK_msdyn_AgreementInvoiceProduct"></a> msdyn_AgreementInvoiceProduct

|Property|Value|
|---|---|
|Description|**Unique identifier for Agreement Invoice Product associated with Invoice Product.**|
|DisplayName|**Agreement Invoice Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementinvoiceproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreementinvoiceproduct|

### <a name="BKMK_msdyn_Currency"></a> msdyn_Currency

|Property|Value|
|---|---|
|Description|**Unique identifier for Currency associated with Invoice Product.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currency`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

|Property|Value|
|---|---|
|Description|**Shows the order of this invoice product within the invoice.**|
|DisplayName|**Line Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lineorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_LineType"></a> msdyn_LineType

|Property|Value|
|---|---|
|Description|**The field to distinguish the Invoice lines to be of project service or field service**|
|DisplayName|**Line Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970001|
|GlobalChoiceName|`msdyn_linetype`|

#### msdyn_LineType Choices/Options

|Value|Label|
|---|---|
|690970000|**Project Service Line**|
|690970001|**Field Service Line**|

### <a name="BKMK_msdyn_OrderInvoicingProduct"></a> msdyn_OrderInvoicingProduct

|Property|Value|
|---|---|
|Description|**Unique identifier for Order Invoicing Product associated with Invoice Product.**|
|DisplayName|**Order Invoicing Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_orderinvoicingproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_orderinvoicingproduct|

### <a name="BKMK_msdyn_WorkOrderId"></a> msdyn_WorkOrderId

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order associated with Invoice Product.**|
|DisplayName|**Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorder|

### <a name="BKMK_msdyn_WorkOrderProductId"></a> msdyn_WorkOrderProductId

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order Product associated with Invoice Product.**|
|DisplayName|**Work Order Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderproductid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorderproduct|

### <a name="BKMK_msdyn_WorkOrderServiceId"></a> msdyn_WorkOrderServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order Service associated with Invoice Product.**|
|DisplayName|**Work Order Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderserviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorderservice|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_msdyn_agreement_invoicedetail_Agreement](#BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement)
- [msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct](#BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct)
- [msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct](#BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct)
- [msdyn_msdyn_workorder_invoicedetail](#BKMK_msdyn_msdyn_workorder_invoicedetail)
- [msdyn_msdyn_workorderproduct_invoicedetail](#BKMK_msdyn_msdyn_workorderproduct_invoicedetail)
- [msdyn_msdyn_workorderservice_invoicedetail](#BKMK_msdyn_msdyn_workorderservice_invoicedetail)
- [msdyn_transactioncurrency_invoicedetail_Currency](#BKMK_msdyn_transactioncurrency_invoicedetail_Currency)
- [transactioncurrency_invoicedetail](#BKMK_transactioncurrency_invoicedetail)

### <a name="BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement"></a> msdyn_msdyn_agreement_invoicedetail_Agreement

One-To-Many Relationship: [msdyn_agreement msdyn_msdyn_agreement_invoicedetail_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct"></a> msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`msdyn_agreementinvoiceproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct"></a> msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct

One-To-Many Relationship: [msdyn_orderinvoicingproduct msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct](msdyn_orderinvoicingproduct.md#BKMK_msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingproduct`|
|ReferencedAttribute|`msdyn_orderinvoicingproductid`|
|ReferencingAttribute|`msdyn_orderinvoicingproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_OrderInvoicingProduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_invoicedetail"></a> msdyn_msdyn_workorder_invoicedetail

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_invoicedetail](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_invoicedetail)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorderid`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorderproduct_invoicedetail"></a> msdyn_msdyn_workorderproduct_invoicedetail

One-To-Many Relationship: [msdyn_workorderproduct msdyn_msdyn_workorderproduct_invoicedetail](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_invoicedetail)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`msdyn_workorderproductid`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderproductid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorderservice_invoicedetail"></a> msdyn_msdyn_workorderservice_invoicedetail

One-To-Many Relationship: [msdyn_workorderservice msdyn_msdyn_workorderservice_invoicedetail](msdyn_workorderservice.md#BKMK_msdyn_msdyn_workorderservice_invoicedetail)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`msdyn_workorderserviceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderserviceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactioncurrency_invoicedetail_Currency"></a> msdyn_transactioncurrency_invoicedetail_Currency

One-To-Many Relationship: [transactioncurrency msdyn_transactioncurrency_invoicedetail_Currency](transactioncurrency.md#BKMK_msdyn_transactioncurrency_invoicedetail_Currency)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`msdyn_currency`|
|ReferencingEntityNavigationPropertyName|`msdyn_currency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_invoicedetail"></a> transactioncurrency_invoicedetail

One-To-Many Relationship: [transactioncurrency transactioncurrency_invoicedetail](transactioncurrency.md#BKMK_transactioncurrency_invoicedetail)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

