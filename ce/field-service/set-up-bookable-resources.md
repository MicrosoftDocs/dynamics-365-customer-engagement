---
title: Set up bookable resources (contains video)
description: Learn how to create a bookable resource and add details to distinguish it from other resources.
ms.date: 02/09/2024
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Set up bookable resources

A bookable resource in Dynamics 365 Field Service is anything that needs to be scheduled. Most often, that's people, equipment, and facilities.

Each resource can have properties that distinguish it from others. For example characteristics (skills or certifications), categories, or locations.

## Prerequisites

- You have a **Field Service - Administrator** or **System Administrator** security role assigned.

## Create frontline workers

Frontline workers are people in your organization who are primarily scheduled for onsite jobs. They use the Dynamics 365 Field Service mobile app to view and update the details of their work orders. Frontline workers are bookable resources. You can quickly [create frontline workers from the **Get started** page](frontline-worker-set-up.md).

## Create other bookable resources
  
1. In Field Service, change to the **Resources** area and go to **Resource** > **Resources** and select **New**.

1. On the **General** tab:

   - Choose a **Resource Type**. A classification that describes who or what the resource is and how the resource relates to your organization. Depending on the value you choose, there are other related details to define.

       - **User**: A person  in your organization who needs access to the system. For more information, see [Set up frontline workers](frontline-worker-set-up.md).
       - **Account** or **Contact**: The resource isn't directly a part of your organization but you want to schedule it. For example, a vendor company that doesn't have access to your system but provides services on your behalf.
       - **Equipment**: A piece of equipment that you want to schedule. For example, a truck or a machine.
       - **Crew**: A group of resources that gets scheduled together. For example, two or more people or a person and a vehicle. For more information, see [Group resources in crews](resource-crews.md).
       - **Facility**: A physical space that needs to be scheduled, such as a building or room. For more information, see [Schedule a facility and associated resources](facility-scheduling.md).
       - **Pool**: A group of similar resources. Pools are scheduled when you want to pick the actual resource at a later stage. For example, a group of cars. For more information, see [Schedule resource pools](resource-pools.md).

   - Enter the **Name** of the resource how it appears on the schedule board and set the **Time Zone**.  

1. On the **Scheduling** tab:

   - Set the **Start Location** and **End Location** to define where the resource starts and ends their working day. The system uses these values for scheduling and routing.
       - **Location agnostic**: The home location of this resource isn't relevant for the business scenario. Travel time will not be calculated or taken in to account to get to their first booking or from their last booking.
       - **Resource Address**: The resource starts and/or ends their day at a unique location. The system derives the exact location from the [latitude and longitude values on the related user, account, or contact record](turn-on-auto-geocoding.md).
       - **Organizational Unit**: The resource starts and/or ends the day at an organizational unit. Typically, that's a company location like a branch office or an assembly point. The exact location is derived from the [latitude and longitude values on the selected organizational unit](turn-on-auto-geocoding.md). If the resource type is *facility*, the organizational unit acts as the location of the facility.

   - Choose which **Organizational Unit** the resource belongs to.

   - Choose if the resource can **Display On Schedule Board**. For more information about showing resources on the schedule board, see [Experience the schedule board in Universal Resource Scheduling](../common-scheduler/use-schedule-board.md).

   - Set **Enable for Availability Search** to define if the [schedule assistant can return the resource](../common-scheduler/schedule-assistant.md) if it matches the criteria.

1. On the Field Service tab:

   - Set an **Hourly Rate** to define the cost of the resource. It's used to calculate pay for time worked.

   - Choose a **Warehouse** to set a default from where the resource gets their parts.

   - For **Time Off Approval Required**, choose if someone needs to approve a resource's time off. A *time off request* blocks the configured time frame and you can't book the resource during that time.

   - **Enable Drip Scheduling** is no longer supported in the Field Service mobile app. For more information, see [Feature deprecations](deprecations-field-service.md).

1. **Save** the record.
  
## Add work hours  

You can define work hours for each resource. If you don't change them, it uses the default work hours. The schedule board differentiates work hours and non-work hours with colors. The schedule assistant returns only resources that have capacity in their designated work hours.

1. Change to the **Resources** area and go to **Resource** > **Resources**. Open a resource record and select **New** > **Working hours**.

1. Set the start and end time of the resource's work hours and choose a repeat pattern. Use the *Custom* repeat patter for recurring working hours, where resources can have different working hours on different days of the week.

   :::image type="content" source="media/resource-work-hours-new-hours.png" alt-text="Screenshot of the working hours pane to configure work hours of a resource.":::

1. Enable **Capacity** to define the number of times the resource can be booked during their work hours. For example, setting the capacity to *5* means that when booking a resource with the schedule assistant, the resource shows as available and can be overbooked up to the capacity limit (in this case, five times). It's set to *1* by default. Changing the value to *0* stops showing the resource as available in a resource search.

1. **Add break** splits each working hours entry and adds a break of 30 minutes. **Add split** splits each working hours entry evenly into two working hours entries, so that each split entry can have a different capacity. The **Add split** option only shows when you enable **Capacity**.

1. Set the time zone for the resource work hours to make sure the system uses them correctly.

1. **Save** the work hours to update the work hours calendar.

For more information about editing work hour calendars with code, see [Edit work hour calendars by using APIs](field-service-work-hours-calendar-api.md).

## Add characteristics, territories, and categories

The most common attributes that distinguish resources are characteristics, territories, and categories.

### Add characteristics

Characteristics represent a resource's skills and certifications. For example, a specific skill like a CPR certification; more general, like accounting or web development experience; or as simple as security clearance for a specific building.

A resource can have multiple characteristics. [Create the characteristic](set-up-characteristics.md), map it to a resource, and provide a proficiency rating.
  
1. Change to the **Resources** area and go to **Resource** > **Resources**. Open a resource record and select **Related** > **Resource Characteristics**.  
  
2. Select **Add New Bookable Resource Characteristics**.  
  
3. Select a **Characteristic** from the lookup.

4. (Optional) Select a **Rating Value** for skill proficiency. Depending on the [proficiency model of the characteristic](set-up-characteristics.md#create-a-proficiency-model), it could be a 1-to-10 rating, or even represent the score on a certification exam.

### Add categories

Resource categories are groups of resources that help distinguish them. For example, a resource's role or job title.

A resource can have multiple categories. [Create a resource category](set-up-bookable-resource-categories.md) and map it to a resource.

1. Change to the **Resources** area and go to **Resource** > **Resources**. Open a resource record and select **Related** > **Resource Category Assns**.
  
2. Select **New Resource Category Assns**.
  
3. Select a **Resource Category** from the lookup.

### Add territories

Territories represent geographic regions. Common examples include a city, county, or a general region.

A resource can be part of multiple territories, but requirements map to a single territory. [Create territories](set-up-territories.md) and map them to a resource.

1. Change to the **Resources** area and go to **Resource** > **Resources**. Open a resource record and select **Related** > **Resource Territories**.
  
2. Select **New Resource Territory**.
  
3. Select a **Territory** from the lookup.

## Define resource location

To enable features like routing, travel estimations, or the map view of the schedule board, the system needs to know the location of a resource. The location of a resource is their work location or the location of the mobile device. If no other value is available, the system uses the start and end location defined on the resource record.

1. Change to the **Resources** area and go to **Resource** > **Resources**. Open a resource record and select **Scheduling**.

1. Set the **Start Location** and **End Location** for the resource. Choose **Resource Address** or **Organizational Unit Address**, depending where they start or end their work day. Ensure the related resource record (user, account, contact) has [a geocoded address and valid latitude/longitude values](turn-on-auto-geocoding.md). The system uses the start and end location of a resource as the resource's location during break hours if a break is configured in their work hours.

   For example, a bookable resource has resource type set to *Contact*; the related contact record needs valid latitude and longitude values.

   :::image type="content" source="media/resource-contact-location-example.png" alt-text="Screenshot of geo coding a contact record.":::

1. Confirm geocoding works. Open the **Schedule Board** and verify that the resource appears on the map. Select a resource to highlight their location on the map.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
