---
title: "Rating Model (RatingModel) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Rating Model (RatingModel) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Rating Model (RatingModel) table/entity reference (Microsoft Dynamics 365 Customer Service)

Represents a model to evaluate skills or other related entities.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Rating Model (RatingModel) table extends the [Microsoft Dynamics 365 Rating Model (RatingModel) table](/dynamics365/developer/entities/ratingmodel).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_ratingmodel"></a> TransactionCurrency_ratingmodel

One-To-Many Relationship: [transactioncurrency TransactionCurrency_ratingmodel](transactioncurrency.md#BKMK_TransactionCurrency_ratingmodel)

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

