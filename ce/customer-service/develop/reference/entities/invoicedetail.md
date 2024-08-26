---
title: "Invoice Product (InvoiceDetail) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Invoice Product (InvoiceDetail) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Invoice Product (InvoiceDetail) table/entity reference (Microsoft Dynamics 365 Customer Service)

Line item in an invoice containing detailed billing information for a product.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Invoice Product (InvoiceDetail) table extends the [Microsoft Dynamics 365 Invoice Product (InvoiceDetail) table](/dynamics365/developer/entities/invoicedetail).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

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

