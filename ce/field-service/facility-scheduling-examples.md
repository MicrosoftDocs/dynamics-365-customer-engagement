---
title: Facility scheduling examples in Dynamics 365 Field Service
description: Learn about different scenarios on how facility scheduling is used.
ms.date: 06/30/2026
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
ai-usage: ai-assisted
---

# Facility scheduling examples

Facility scheduling lets you book physical spaces—like repair bays, treatment rooms, or inspection lanes—and, when you need to, pair those spaces with the people who staff them. This article shows four common setups in order of complexity.

These examples assume you're familiar with the basics. If you're not, start with [Schedule a facility](facility-scheduling.md), which covers facility resources, the booking steps, and how to [pick the right facility setup](facility-scheduling.md#facility-variations). These examples build on a few core concepts. Learn more in:

- [Work locations for scheduling requirements](scheduling-requirement-locations.md): what **Work Location = Facility** does.
- [Add work hours](set-up-bookable-resources.md#add-work-hours): how **Capacity** lets one resource take concurrent bookings.
- [Schedule resource pools](resource-pools.md): facility and people pools.
- [Schedule multiple resources with requirement groups](multi-resource-scheduling-requirement-groups.md): requirement groups and **Part of Same**.

## How resources relate to a facility

These scenarios connect resources to a facility in two different ways. Knowing which one a scenario uses helps you follow the steps:

- **Resource children** define what a pool *contains*—each bay is a child of its facility pool ("these spaces are part of this location").
- **Bookable resource association** links two separate resources that *work together*—a mechanic associated to a facility ("this person works at this place").

Scenario 3 uses children, Scenario 2 uses an association, and Scenario 4 uses both.

## Before you begin

Keep these rules in mind for every scenario:

- For requirements that aren't part of a requirement group, the schedule assistant returns only facility or facility-pool resources when **Work Location** is set to **Facility**.
- A resource can't be related to two facilities (as a child or an association) at the same time.
- Manually scheduling a single requirement to a facility doesn't create bookings for the other resources related to that facility.

## Compare the scenarios

Use this table to find the scenario that matches your situation, and then follow its steps.

| | Scenario 1 | Scenario 2 | Scenario 3 | Scenario 4 |
|---|---|---|---|---|
| **Spaces** | Generic (capacity) | Single facility | Specific (children) | Specific (children) |
| **People** | — | One specific person | — | Pool of specialists |
| **Uses a pool** | No | No | Yes (facilities) | Yes (facilities + people) |
| **Uses association** | No | Yes | No | Yes |
| **Requirement group** | No | Yes | Yes | Yes |
| **Key setting** | Capacity = 5 | Part of Same = Resource Tree | Part of Same = Same Location | Part of Same = Resource Tree |

## Scenario 1: Schedule a facility with five generic spaces

**Use this scenario when:** your spaces are interchangeable and you only need to limit how many bookings happen at once.

**What you're building:** a single facility resource with a capacity of 5, so you can book it up to five times in the same time slot.

An auto repair shop has five identical bays and schedulers don't need to book each bay specifically. They must, however, ensure that no more than five repairs are booked across all bays during any one time slot.

1. [Create a facility resource](facility-scheduling.md#step-1-create-a-facility-resource). On the **Work Hours** tab, enable **Capacity** and set it to 5. Learn more in [Add work hours](set-up-bookable-resources.md#add-work-hours).

1. [Create a requirement for the facility](facility-scheduling.md#step-2-create-a-requirement-for-a-facility) with **Work Location** set to **Facility**.

1. Book the requirements at the facility. The facility resource shows as available and can be double-booked up to the capacity limit (in this case, five times).

> [!Note]
> Capacity scheduling isn't intended for booking the same requirement multiple times, but rather to book multiple requirements. Rebooking a previously booked requirement cancels the existing booking and creates a new one.

## Scenario 2: Schedule a facility and a related resource

**Use this scenario when:** a booking needs both a space and one specific person who works there.

**What you're building:** a facility resource and a person resource, linked by a bookable resource association, then booked together as a requirement group.

An auto repair shop offers transmission repairs including luxury cars. They have a mechanic that specializes in luxury cars. Schedulers want to schedule the specialized mechanic at their facility. You can associate a resource (user, account, or contact) to a facility.

1. [Create a facility resource](facility-scheduling.md#step-1-create-a-facility-resource) for the auto repair shop.

1. Create a resource to represent the specialized mechanic.

   - Set the **Resource Type** to **User**, **Account**, or **Contact**.
   - Set the **Start/End location** to **Organizational Unit Address** and the organizational unit should be set to the same organizational unit of the facility resource (in this case, the auto repair shop). We recommend this setting, but it isn't required.

1. Associate the specialized mechanic resource to the facility resource.

   - From the facility resource, select **Related > Bookable Resource Association (Resource 2)**. This related entity is called [Bookable Resource Association (**msdyn_bookableresourceassociation**)](developer/reference/entities/msdyn_bookableresourceassociation.md).
   - Select **New Bookable Resource Association**.
   - Enter a name, timeframe, and select the mechanic resource for **Resource 1**.

   :::image type="content" source="media/scheduling-facility-associate-resource.png" alt-text="Screenshot of the association between the mechanic resource and facility resource.":::

   > [!NOTE]
   > You open the association from the facility, but the mechanic goes in the **Resource 1** field. Double-check this—it's easy to reverse.

1. [Create a requirement group](facility-scheduling.md#step-2-create-a-requirement-for-a-facility) with one requirement for the facility (auto repair shop) and another requirement for the mechanic resource.

   - Set **Select** to **All** so that all requirements must be met.
   - Set **Part of Same** to **Resource Tree** so that resources from different locations aren't recommended for work at this facility. As an example, a mechanic associated with Facility B shouldn't be paired with Facility A.
   - Set duration, characteristics, or other criteria.
   - For each requirement, set the **Work Location** to **Facility** and the latitude and longitude fields for the customer's location.

1. Book the requirement group. Scheduling the requirement group creates a booking for the facility resource and the mechanic resource.

   :::image type="content" source="media/scheduling-facility-schedule-board-2-resources.png" alt-text="Screenshot of two bookings for each requirement in the requirement group, one for the facility and one for the mechanic resource.":::

> [!NOTE]
> Travel time and distance are calculated as the time and distance for the customer to travel to the facility. There's no travel calculation considered for the mechanic resource, as the assumption is that they're at the facility at the required time.

## Scenario 3: Schedule a facility with three specific spaces

**Use this scenario when:** you need to book particular individual spaces, not just any open space.

**What you're building:** a facility pool for the shop, with each bay as a child facility resource, booked through a requirement group.

An auto repair shop wants to schedule each individual bay at their facility. Create a pool of facilities to represent the auto repair shop and each individual bay.

1. [Create a facility resource](facility-scheduling.md#step-1-create-a-facility-resource) for the auto repair shop where the **Resource Type** is **Pool** and **Pool Type** is **Facility**.

1. Create multiple facility resources to represent each bay.

   - Set **Resource Type** to **Facility** on each resource.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.  

1. Add each bay as a child resource to the repair shop facility resource pool.

   - From the auto repair shop facility pool resource, select **Related > Resource's Children**.
   - Select **New Bookable Resource Group** and add each bay resource as a child record to the parent facility pool.

   :::image type="content" source="media/scheduling-facility-room-specific-children.png" alt-text="Screenshot of all bay resources related as children to the auto repair shop facility.":::

1. [Create a requirement group](facility-scheduling.md#step-2-create-a-requirement-for-a-facility). In this example, you're looking for two specific bays within the same auto repair shop. Create two requirements in the group.

   - Set **Part of Same** to **Same Location** to ensure each bay is at the same physical address.
   - Set duration, characteristics, or other criteria.
   - For each requirement, set the **Resource Type** to **Facility**.
   - For each requirement, set the **Work Location** to **Facility** and the latitude and longitude fields for the customer's location.

   > [!NOTE]
   > Latitude and longitude fields on all requirements within a group must be equal; updating the values on one requirement updates the others.

1. Book the requirement group. Two specific bays are recommended at the same location. The travel time and distance is calculated from the customer's location (latitude and longitude values on the requirement records) and the location of the facility resources (resource children organizational units).

   :::image type="content" source="media/scheduling-facility-schedule-assistant-specific-rooms.png" alt-text="Screenshot of schedule assistant results showing pairs of two bays each at the same location.":::

## Scenario 4: Schedule a facility with two specific spaces and two related resources

**Use this scenario when:** you need specific spaces and a pool of qualified people, without assigning a named person up front.

**What you're building:** a facility pool of bays and a pool of mechanics, linked by an association, booked together as a requirement group.

An auto repair shop wants to schedule specific bays at their facility to a pool of specialized mechanics who work at the facility. Create a pool of facilities and a pool of mechanics.

1. [Create a facility pool resource](facility-scheduling.md#step-1-create-a-facility-resource) for the auto repair shop where the **Resource Type = Pool** and **Pool Type = Facility**.

1. Create facility resources to represent each bay.

   - Set **Resource Type** to **Facility** on each resource.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.

1. Add each bay as a child resource to the repair shop facility resource pool.

   - Open the auto repair shop facility pool resource, and go to **Related > Resource Children**.
   - Add each bay resource as a child record to the parent facility pool.

1. [Create a pool](resource-pools.md) of specialized mechanics. By using a pool, schedulers can book appointments based on capacity without having to assign a specific mechanic at the time of scheduling.

   - Set **Resource Type** to **Pool**.
   - Set **Pool Type** to **Contact**, **User**, or **Account**.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.
   - Set **Derive Capacity from Group Members** to **Yes** so that the capacity of the pool is based on how many mechanics are associated to it.

1. Create resources to represent the specialized mechanics.

   - Set the resource type to **User**, **Account**, or **Contact**.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.

1. Add the mechanic resources as [resource children to the mechanics pool](resource-pools.md).

   :::image type="content" source="media/scheduling-facility-mechanic-pool-children.png" alt-text="Screenshot of relating mechanics as children to the parent mechanic pool.":::

1. Associate the mechanic pool to the facility pool.

   - From the facility pool, select **Related > Bookable Resource Association (Resource 2)**. This related entity is called [Bookable Resource Association (**msdyn_bookableresourceassociation**)](developer/reference/entities/msdyn_bookableresourceassociation.md).
   - Select **New Bookable Resource Association**.
   - Enter a name, timeframe, and select the mechanic pool for **Resource 1**.

   :::image type="content" source="media/scheduling-facility-associate-mechanic-pool.png" alt-text="Screenshot of associating the mechanic pool to the auto repair facility pool.":::

1. Create a requirement group for bays and mechanics.

   - Set **Part of Same** to **Resource Tree** to ensure bays and mechanics are related to the same facility resource through resource children or resource association.
   - Set duration, characteristics, or other criteria.
   - Create a requirement for each bay.
   - Create a requirement for the pool of mechanics. Set the **Resource Type** to **Pool** and **Pool Type** to **Contact**, **User**, or **Account** depending on how you set up your mechanics.

   :::image type="content" source="media/scheduling-facility-mechanic-pool-req-group.png" alt-text="Screenshot of requirement group showing two bays and a pool of mechanics.":::

     > [!TIP]
     > If you want specific mechanics to show in the results rather than the pool, set the **Resource Type** to **Contact**, **User**, or **Account** depending on how you set up your mechanics.

1. Book the requirement group.

   :::image type="content" source="media/scheduling-facility-mechanic-pool-bookings.png" alt-text="Screenshot of schedule board with available booking slots for the bays and mechanic pool.":::

   > [!NOTE]
   > Use fulfillment preferences to display schedule assistant results in neat hourly timeslots.

## Troubleshooting

If the schedule assistant returns no results:

- Confirm **Work Location** is set to **Facility** on every requirement.
- Confirm latitude and longitude are set and match across all requirements in a group.
- Confirm each bay and person shares the same organizational unit as the facility.
- For requirement groups, confirm **Part of Same** matches your intent (**Same Location** for one address, **Resource Tree** to keep resources tied to the same facility).
- Confirm associated resources or pool children aren't already related to a different facility.

[!INCLUDE[footer-include](../includes/footer-banner.md)]