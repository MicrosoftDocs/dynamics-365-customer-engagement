---
title: "Price List (PriceLevel) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Price List (PriceLevel) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Price List (PriceLevel) table/entity reference

Entity that defines pricing levels.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Price List (PriceLevel) table extends the [Microsoft Dynamics 365 Price List (PriceLevel) table](/dynamics365/developer/entities/pricelevel).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_pricelevel"></a> transactioncurrency_pricelevel

One-To-Many Relationship: [transactioncurrency transactioncurrency_pricelevel](transactioncurrency.md#BKMK_transactioncurrency_pricelevel)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_pricelevel_msdyn_actual_PriceList"></a> msdyn_pricelevel_msdyn_actual_PriceList

Many-To-One Relationship: [msdyn_actual msdyn_pricelevel_msdyn_actual_PriceList](msdyn_actual.md#BKMK_msdyn_pricelevel_msdyn_actual_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_actual_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

