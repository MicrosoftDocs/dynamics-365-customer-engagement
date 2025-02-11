---
title: "Order (SalesOrder) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Order (SalesOrder) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Order (SalesOrder) table/entity reference (Microsoft Dynamics 365 Customer Service)

Quote that has been accepted.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Order (SalesOrder) table extends the [Microsoft Dynamics 365 Order (SalesOrder) table](/dynamics365/developer/reference/entities/salesorder).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_salesorder_msdyn_actual_SalesContract](#BKMK_msdyn_salesorder_msdyn_actual_SalesContract)
- [salesorder_msdyn_bookingalerts](#BKMK_salesorder_msdyn_bookingalerts)

### <a name="BKMK_msdyn_salesorder_msdyn_actual_SalesContract"></a> msdyn_salesorder_msdyn_actual_SalesContract

Many-To-One Relationship: [msdyn_actual msdyn_salesorder_msdyn_actual_SalesContract](msdyn_actual.md#BKMK_msdyn_salesorder_msdyn_actual_SalesContract)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_salescontract`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesorder_msdyn_actual_SalesContract`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_msdyn_bookingalerts"></a> salesorder_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert salesorder_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_salesorder_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

