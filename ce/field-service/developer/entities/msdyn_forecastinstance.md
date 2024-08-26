---
title: "Forecast (msdyn_forecastinstance) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Forecast (msdyn_forecastinstance) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Forecast (msdyn_forecastinstance) table/entity reference (Microsoft Dynamics 365 Field Service)

Stores sales predictions for your team or organization. For internal use.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Forecast (msdyn_forecastinstance) table extends the [Microsoft Dynamics 365 Forecast (msdyn_forecastinstance) table](/dynamics365/developer/entities/msdyn_forecastinstance).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_msdyn_forecastinstance"></a> TransactionCurrency_msdyn_forecastinstance

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_forecastinstance](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_forecastinstance)

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

