---
title: "Property Instance (DynamicPropertyInstance) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Property Instance (DynamicPropertyInstance) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Property Instance (DynamicPropertyInstance) table/entity reference

Instance of a property with its value.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Property Instance (DynamicPropertyInstance) table extends the [Microsoft Dynamics 365 Property Instance (DynamicPropertyInstance) table](/dynamics365/developer/entities/dynamicpropertyinstance).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_Dynamicpropertyinsatance"></a> TransactionCurrency_Dynamicpropertyinsatance

One-To-Many Relationship: [transactioncurrency TransactionCurrency_Dynamicpropertyinsatance](transactioncurrency.md#BKMK_TransactionCurrency_Dynamicpropertyinsatance)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`dynamicpropertyinstanceid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

