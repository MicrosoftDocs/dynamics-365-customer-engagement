---
title: "Playbook (msdyn_playbookinstance) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Playbook (msdyn_playbookinstance) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Playbook (msdyn_playbookinstance) table/entity reference

Actual instance of a playbook template once it is launched.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Playbook (msdyn_playbookinstance) table extends the [Microsoft Dynamics 365 Playbook (msdyn_playbookinstance) table](/dynamics365/developer/entities/msdyn_playbookinstance).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_playbookinstance_msdyn_bookingalerts"></a> msdyn_playbookinstance_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_playbookinstance_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_playbookinstance_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

