---
title: Enable an entity for scheduling
description: Learn how to enable an entity for scheduling in Dynamics 365 Field Service
author: lalexms 
ms.author: laalexan
ms.reviewer: shujoshi
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 06/21/2023 
ms.custom: bap-template 
---

# Enable an entity for scheduling
Enabling an entity for scheduling allows agents to schedule the requirements related to that entity to the matching resources.

## Prerequisites

You must have the System Administrator role to enable an entity for scheduling.

## Enable an entity for scheduling

1. In **Resource Scheduling**, change to the **Settings** area, and then under **Scheduling**, select **Administration** > **Enable Resource Scheduling for Entities**.
1. In the **Enable New Entity** section, under **Add Entity**, select an entity from the list.
   
   > [!TIP]
   > If the entity you want to enable doesn't show in the list, update the **Can be customized setting** to **True** for the managed property.
  
1. For **Booking Relationship** and **Requirement Relationship**, select **Create New Relationship**. Select an existing relationship if you've previously created relationships to the bookable resource booking or resource requirement entities.
1. Select **Publish Customization**.

## Disable scheduling for an enabled entity

To turn off scheduling for a previously enabled entity, select **Deactivate** in the ribbon on the **Booking Setup Metadata** record of the enabled entity.

## Edit settings for enabled entities

If you want to change the booking settings for entities you enabled for scheduling, complete the following steps.

1. In **Resource Scheduling**, change to the **Settings** area, and then in **Scheduling**, select **Administration** > **Enable Resource Scheduling for Entities**.
   
1. In the **Enabled Entities** section, double-click the entity you want to edit. A new tab with the booking setup metadata for the selected entity is opened.

   | Setting | Effect | Value |
   | -------- | ---------- | ---------|
   | Default booking duration | Defines the default duration of a new booking. | Predefined set of duration options. |
   | Default booking committed status | Sets the default value to use when a booking moves into Committed state. | Available booking statuses. |
   | Default requirement active status | Sets the default value to use when a requirement moves into Active state. | Available requirement statuses. |
   | Default requirement canceled status | Sets the default value to use when a requirement moves in Canceled state. | Available requirement statuses.|
   | Resource availability retrieval limit | Defines the maximum number of resources returned as a result of the scheduling assistant. | Number. |
   | Enable quick book | Use the quick book experience on an entity record. | Yes: Use quick book experience. <br> No: Use schedule assistant experience. |
   | Cancel bookings when moving | Cancel bookings moving the booking to a different time slot. | Yes: Cancel booking and create a new one in the updated time slot. <br> No: Keep booking and update start/end time. |
   | Default booking canceled status | Sets the default value to use when booking moves into Canceled state. | Available booking statuses. |
   | Disable requirement auto creation for bookings | Defines if the system creates a requirement for a booking | Yes: Disable automated requirement creation. <br> No: Enable automated booking creation. |
   | Default requirement completed status | Sets the default value to use when a requirement moves into Completed status. | Available requirement statuses. |
   | Available duration minimum (%) | Defines the availability of a resource in relation to the booking duration. For example, if the value is 50 and the booking takes four hours. The system only considers resources for the job that have at least two hours available. | 0 to 100. |
   
1. In the **Attribute Mapping** section, choose values on the target entity that match with the requirement fields.

1. Save your changes. You've successfully enabled an entity for scheduling when:
   - **Resource Requirements** shows as a related entity. Create them manually or with a custom workflow.
   - The **Book** option appears on the entity record.

## Add a requirement view to the schedule board

After you create a requirement for the lead, it will appear in the **Open Requirements** view in the lower pane of the schedule board that shows all open requirements related to any schedulable entity. This is a default view for resource scheduling. However, the views in the lower pane of the schedule board are system views that can be edited and added to. It's common to add custom resource requirement views for schedulable entities.

1. Go to **Advanced Settings** > **Customizations** > **Entities** > **Resource Requirement** > **Views**.

1. Create a new view and add fields to the view that provide details for what you are scheduling.

1. Name the view and edit the filter criteria to show the records you want to see in the view.

1. Select **Save** > **Close & Publish**.

Now that the view is created, edit the schedule board that uses the new view by completing the following steps.

1. Open the board settings, and then in the **Requirement panels** section, add a new panel.
1. Type a **Title**, and then select the view to use.
1. Save your changes.

### See also

[Create bookable resources](resources-service-scheduling.md)  
[Overview of service scheduling](basics-service-service-scheduling.md) 

[!INCLUDE[footer-include](../includes/footer-banner.md)]
