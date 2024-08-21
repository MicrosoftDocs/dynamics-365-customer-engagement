---
title: "Unit Group (UoMSchedule) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Unit Group (UoMSchedule) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Unit Group (UoMSchedule) table/entity reference

Grouping of units.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Unit Group (UoMSchedule) table extends the [Microsoft Dynamics 365 Unit Group (UoMSchedule) table](/dynamics365/developer/entities//uomschedule).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule"></a> msdyn_uomschedule_msdyn_actual_UnitSchedule

Many-To-One Relationship: [msdyn_actual msdyn_uomschedule_msdyn_actual_UnitSchedule](msdyn_actual.md#BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_unitschedule`|
|ReferencedEntityNavigationPropertyName|`msdyn_uomschedule_msdyn_actual_UnitSchedule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

