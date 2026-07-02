---
title: Set up organizational units
description: Organizational units in Dynamics 365 Field Service group your business operations by department, region, or division. Learn how to create units and assign resources.
ms.date: 06/25/2026
ms.topic: how-to
author: ryanchen8
ms.author: chenryan
ms.reviewer: v-wesmith
---

# Set up organizational units

Organizational units represent logical groupings of your business operations, such as departments, regions, or business divisions.

Although territories are the primary geographic construct in Field Service, organizational units can provide another layer of segmentation, like business division (HVAC vs electrical), service line (install vs repair), or internal team structure.

## Organizational units and territories

[!INCLUDE[organizational-units-territories.md](../includes/organizational-units-territories.md)]

## Prerequisites

- You have a **Field Service - Administrator** or **System Administrator** security role assigned.

## Create an organizational unit

1. In **Field Service**, open the **Settings** area.

1. Under **General**, select **Org Units**, and then select **New**.

1. Enter a name.

1. (Optional) Select the **Scheduling** tab and enter an address. This field is required if you assign resources to the organizational unit.

1. Select **Save & Close**.

## Assign resources to organizational units

Bookable resources such as field technicians, equipment, or facilities typically belong to one primary organizational unit.
  
1. Open the **Resources** area. Under **Resource**, select **Resources**.

1. Select the resource you want to assign to an organizational unit.
  
1. Select the **Scheduling** tab.

1. Select **Organizational Unit Address** for the start and end location.  

1. Select the organizational unit you want to assign to the resource.

   :::image type="content" source="media/organizational-unit-resource.png" alt-text="Screenshot of the Bookable Resource record with an associated organizational unit.":::

1. Select **Save & Close**.

Learn more in [Set up bookable resources](set-up-bookable-resources.md).

## Related content

- [Set up territories](set-up-territories.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
