---
title: "Insight (msdyn_salessuggestion) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Insight (msdyn_salessuggestion) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Insight (msdyn_salessuggestion) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Insight (msdyn_salessuggestion) table extends the [Microsoft Dynamics 365 Insight (msdyn_salessuggestion) table](/dynamics365/developer/entities/msdyn_salessuggestion).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_msdyn_salessuggestion"></a> TransactionCurrency_msdyn_salessuggestion

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_salessuggestion](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_salessuggestion_msdyn_bookingalerts"></a> msdyn_salessuggestion_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_salessuggestion_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_salessuggestion_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

