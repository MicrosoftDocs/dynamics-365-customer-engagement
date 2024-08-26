---
title: "Property Association (DynamicPropertyAssociation) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Property Association (DynamicPropertyAssociation) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Property Association (DynamicPropertyAssociation) table/entity reference

Association of a property definition with another entity in the system.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Property Association (DynamicPropertyAssociation) table extends the [Microsoft Dynamics 365 Property Association (DynamicPropertyAssociation) table](/dynamics365/developer/entities/dynamicpropertyassociation).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_DynamicPropertyAssociation_TransactionCurrency"></a> DynamicPropertyAssociation_TransactionCurrency

One-To-Many Relationship: [transactioncurrency DynamicPropertyAssociation_TransactionCurrency](transactioncurrency.md#BKMK_DynamicPropertyAssociation_TransactionCurrency)

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

