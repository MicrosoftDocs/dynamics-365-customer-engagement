---
title: "Bookable Resource Group (BookableResourceGroup) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Bookable Resource Group (BookableResourceGroup) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Bookable Resource Group (BookableResourceGroup) table/entity reference

Associates resources with resource groups that they are a member of.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Bookable Resource Group (BookableResourceGroup) table extends the [Microsoft Dynamics 365 Bookable Resource Group (BookableResourceGroup) table](/dynamics365/developer/entities/bookableresourcegroup).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_bookableresourcegroup"></a> TransactionCurrency_bookableresourcegroup

One-To-Many Relationship: [transactioncurrency TransactionCurrency_bookableresourcegroup](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcegroup)

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

