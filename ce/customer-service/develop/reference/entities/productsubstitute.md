---
title: "Product Relationship (ProductSubstitute) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Product Relationship (ProductSubstitute) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Product Relationship (ProductSubstitute) table/entity reference (Microsoft Dynamics 365 Customer Service)

Information about the selling relationship between two products, including the relationship type, such as up-sell, cross-sell, substitute, or accessory.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Product Relationship (ProductSubstitute) table extends the [Microsoft Dynamics 365 Product Relationship (ProductSubstitute) table](/dynamics365/developer/entities/productsubstitute).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_ProductSubstitute"></a> transactioncurrency_ProductSubstitute

One-To-Many Relationship: [transactioncurrency transactioncurrency_ProductSubstitute](transactioncurrency.md#BKMK_transactioncurrency_ProductSubstitute)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

