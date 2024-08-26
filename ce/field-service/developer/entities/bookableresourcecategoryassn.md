---
title: "Bookable Resource Category Assn (BookableResourceCategoryAssn) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bookable Resource Category Assn (BookableResourceCategoryAssn) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bookable Resource Category Assn (BookableResourceCategoryAssn) table/entity reference

Association entity to model the categorization of resources.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Bookable Resource Category Assn (BookableResourceCategoryAssn) table extends the [Microsoft Dynamics 365 Bookable Resource Category Assn (BookableResourceCategoryAssn) table](/dynamics365/developer/entities/bookableresourcecategoryassn).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_bookableresourcecategoryassn"></a> TransactionCurrency_bookableresourcecategoryassn

One-To-Many Relationship: [transactioncurrency TransactionCurrency_bookableresourcecategoryassn](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcecategoryassn)

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

