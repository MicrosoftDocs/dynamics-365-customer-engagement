---
title: "Order Product (SalesOrderDetail) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Order Product (SalesOrderDetail) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Order Product (SalesOrderDetail) table/entity reference

Line item in a sales order.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Order Product (SalesOrderDetail) table extends the [Microsoft Dynamics 365 Order Product (SalesOrderDetail) table](/dynamics365/developer/entities/salesorderdetail).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_salesorderdetail"></a> transactioncurrency_salesorderdetail

One-To-Many Relationship: [transactioncurrency transactioncurrency_salesorderdetail](transactioncurrency.md#BKMK_transactioncurrency_salesorderdetail)

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

