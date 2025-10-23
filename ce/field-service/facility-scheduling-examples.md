---
title: Facility scheduling examples in Dynamics 365 Field Service
description: Learn about different scenarios on how facility scheduling is used.
ms.date: 06/09/2025
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Facility scheduling examples

When creating requirements in the following scenarios, consider the following information:

- For requirements that aren't part of a requirement group, only facility or facility pool resources can return in the schedule assistant if **Work Location** is set to **Facility**.
- A resource can't be related to two facilities (child or association) at the same time.
- Manually scheduling a single requirement to a facility doesn't create records for all resources related to the facility.

The following examples show how to schedule multiple spaces at a facility or reserve an appointment with a person at a facility.

- [Scenario 1: Schedule a facility with five generic spaces](#scenario-1-schedule-a-facility-with-five-generic-spaces)
- [Scenario 2: Schedule a facility and a related resource](#scenario-2-schedule-a-facility-and-a-related-resource)
- [Scenario 3: Schedule a facility with three specific spaces](#scenario-3-schedule-a-facility-with-three-specific-spaces)
- [Scenario 4: Schedule a facility with two specific spaces and two related resources](#scenario-4-schedule-a-facility-with-two-specific-spaces-and-two-related-resources)

## Scenario 1: Schedule a facility with five generic spaces

An auto repair shop has five identical bays and schedulers don't need to book each bay specifically. They must, however, ensure that no more than five repairs are booked across all bays during any one time slot.

1. [Create a facility resource](facility-scheduling.md#create-a-facility-resource). On the **Work Hours** tab, enable **Capacity** and set it to 5. For more information on capacity, go to [Add work hours](set-up-bookable-resources.md#add-work-hours).

1. [Create a requirement for the facility](facility-scheduling.md#create-a-requirement-for-a-facility).

1. Book the requirements at the facility. The facility resource shows as available and can be double-booked up to the capacity limit (in this case, five times).

> [!Note]
> Capacity scheduling isn't intended for booking the same requirement multiple times, but rather to book multiple requirements. Rebooking a previously booked requirement cancels the existing booking and create a new one.

## Scenario 2: Schedule a facility and a related resource

An auto repair shop offers transmission repairs including luxury cars. They have a mechanic that specializes in luxury cars. Schedulers want to schedule the specialized mechanic at their facility. You can associate a resource (user, account, or contact) to a facility.

1. [Create a facility resource](facility-scheduling.md#create-a-facility-resource) for the auto repair shop.

1. Create a resource to represent the specialized mechanic.

   - Set the **Resource Type** to **User**, **Account**, or **Contact**.
   - Set the **Start/End location** to **Organizational Unit Address** and the organizational unit should be set to the same organizational unit of the facility resource (in this case, the auto repair shop). We recommend this setting, but it isn't required.

1. Associate the specialized mechanic resource to the facility resource.

   - From the facility resource, select **Related > Bookable Resource Association (Resource 2)**. This related entity is called [Bookable Resource Association (**msdyn_bookableresourceassociation**)](developer/reference/entities/msdyn_bookableresourceassociation.md).
   - Select **New Bookable Resource Association**.
   - Enter a name, timeframe, and select the mechanic resource for **Resource 1**.

   :::image type="content" source="media/scheduling-facility-associate-resource.png" alt-text="Screenshot of the association between the mechanic resource and facility resource.":::

1. [Create a requirement group](facility-scheduling.md#create-a-requirement-for-a-facility) with one requirement for the facility (auto repair shop) and another requirement for the mechanic resource.

   - Set **Select** to **All** so that all requirements must be met.
   - Set **Part of Same** to **Resource Tree** so that resources from different locations aren't recommended for work at this facility. As an example, a mechanic associated with Facility B shouldn't be paired with Facility A.
   - Set duration, characteristics, or other criteria.
   - For each requirement, set the **Work Location** to **Facility** and the latitude and longitude fields for the customer's location.

1. Book the requirement group. Scheduling the requirement group creates a booking for the facility resource and the mechanic resource.

   :::image type="content" source="media/scheduling-facility-schedule-board-2-resources.png" alt-text="Screenshot of two bookings for each requirement in the requirement group, one for the facility and one for the mechanic resource.":::

> [!NOTE]
> Travel time and distance are calculated as the time and distance for the customer to travel to the facility. There's no travel calculation considered for the mechanic resource, as the assumption is that they are at the facility at the required time.

## Scenario 3: Schedule a facility with three specific spaces

An auto repair shop wants to schedule each individual bay at their facility. Create a pool of facilities to represent the auto repair shop and each individual bay.

1. [Create a facility resource](facility-scheduling.md#create-a-facility-resource) for the auto repair shop where the **Resource Type = Pool** and **Pool Type = Facility**.

1. Create multiple facility resources to represent each bay.

   - Set **Resource Type** to **Facility** on each resource.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.  

1. Add each bay as a child resource to the repair shop facility resource pool.

   - From the auto repair shop facility pool resource, select **Related > Resource's Children**.
   - Select **New Bookable Resource Group** and add each bay resource as a child record to the parent facility pool.

   :::image type="content" source="media/scheduling-facility-room-specific-children.png" alt-text="Screenshot of all bay resources related as children to the auto repair shop facility.":::

1. [Create a requirement group](facility-scheduling.md#create-a-requirement-for-a-facility). In this example, we're looking for two specific bays within the same auto repair shop. Create two requirements in the group.

   - Set **Part of Same** to **Same Location** to ensure each bay is at the same physical address.
   - Set duration, characteristics, or other criteria.
   - For each requirement, set the **Resource Type** to **Facility**.
   - For each requirement, set the **Work Location** to **Facility** and the latitude and longitude fields for the customer's location.

   > [!NOTE]
   > Latitude and longitude fields on all requirements within a group must be equal; updating the values on one requirement updates the others.

1. Book the requirement group. Two specific bays are recommended at the same location. The travel time and distance is calculated from the customer's location (latitude and longitude values on the requirement records) and the location of the facility resources (resource children organizational units).

   :::image type="content" source="media/scheduling-facility-schedule-assistant-specific-rooms.png" alt-text="Screenshot of schedule assistant results showing pairs of two bays each at the same location.":::

## Scenario 4: Schedule a facility with two specific spaces and two related resources

An auto repair shop wants to schedule specific bays at their facility to a pool of specialized mechanics who work at the facility. Create a pool of facilities and a pool of mechanics.

1. [Create a facility pool resource](facility-scheduling.md#create-a-facility-resource) for the auto repair shop where the **Resource Type = Pool** and **Pool Type = Facility**.

1. Create facility resources to represent each bay.

   - Set **Resource Type** to **Facility** on each resource.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.

1. Add each bay as a child resource to the repair shop facility resource pool.

   - Open the auto repair shop facility pool resource, and go to **Related > Resource Children**.
   - Add each bay resource as a child record to the parent facility pool.

1. [Create a pool](resource-pools.md) of specialized mechanics. Using a pool allows schedulers to book appointments based on capacity without having to assign a specific mechanic at the time of scheduling.

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


[!INCLUDE[footer-include](../includes/footer-banner.md)]