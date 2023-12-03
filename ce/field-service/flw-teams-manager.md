---
title: Field Service Teams app for the frontline manager
description: Learn about the Dynamics 365 Field Service Teams and Viva Connections app to create, view, and edit work orders.
ms.date: 12/03/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Field Service Teams app for the frontline manager

The Dynamics 365 Field Service for Teams enable frontline managers to manage work orders without disrupting their workflow. As a frontline manager, you can create, view, and edit work orders directly in Teams. You can quickly respond to requests for service or questions about existing requests.

## Prerequisite

Environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages)

> [!NOTE]
> The supported language is based on your Teams' language. If you access Teams from the web, the language is based on the web browser. If you access Teams from Teams Desktop, the language is based on Teams Desktop's language.

## Install the Field Service Teams app

If your admin installed the Field Service Teams app for your organization, you can skip this step.

[!INCLUDE [fsp-deploy-teams](../includes/fsp-deploy-teams.md)]

## Select your environment to open your dashboard the first time

1. In Teams, select **Apps** and select **Field Service (Preview)**. The **Home** page displays.

1. Select the **Settings** tab.

1. Select your Field Service environment.

   :::image type="content" source="media/fsp-environment-flm.png" alt-text="Screenshot of Field Service environment selection for the frontline manager":::

1. Once the environment is validated, select the **Home** tab to go to the Teams **Home** page or select **Open Viva Connections** to go to your Viva Connections dashboard.

   :::image type="content" source="media/fsp-flm-teams-home.png" alt-text="Field Service Teams Home page for the frontline manager":::

   > [!TIP]
   > In Teams, if you have multiple environments, you can easily [**Switch environments**](#switch-environments).

## Create a work order in Teams

1. From your Viva dashboard, select **Create work order** on the **Work orders all in one place** tile. From your Teams Field Service **Home** page, select the **Create work order** button.

   :::image type="content" source="media/fsp-teams-create-button.png" alt-text="Screenshot of Field Service Teams Create a work order button":::

1. At a minimum, enter the required information for the work order. For any field on the work order, if a value isn't available in the drop-down list, select **+**. The Field Service app opens so you can enter a new value and its details. Save and close the Field Service app. Type the new value or select **Refresh** to add the new value to the drop-down list.

   - [Service account](accounts.md)
   - [Work order type](create-work-order-types.md)
   - [Price list](create-price-list.md)

   :::image type="content" source="media/fsp-viva-create-work-order.png" alt-text="Screenshot of Field Service Teams Create a work order":::

1. Select **Save**. After the work order is created, the work order number displays. The **Status** default is **Unscheduled**.

   :::image type="content" source="media/fsp-viva-pop-out-icon.png" alt-text="Screenshot of Field Service Teams work orders highlighting pop-out icon":::

   > [!TIP]
   > If you want to open the work order in Field Service, select the pop-out icon.

## Get schedule assistance

In Teams, schedule assist functionality helps you schedule, reschedule, or move a booking for a work order.

### Schedule a work order in Teams

Scheduling is based on resource availability, skills, customer promised time windows, customer location proximity, and business unit.

1. After you create a work order or open an unscheduled work order, select **Schedule** under **Suggested actions**. The system searches for available technicians based on the work order requirements and then displays suggestions. To view more suggestions, select **Show more** at the bottom of the list.

1. Review the suggested technicians and their availability. You can search for a technician by name, filter by dates, or sort the technicians by start time or travel time. If the **Estimated Duration** hasn't been set up in the resource requirements, 30 minutes is used as a default.

   :::image type="content" source="media/fsp-flm-schedule-options.png" alt-text="Field Service (Preview) Teams scheduling.":::

   > [!TIP]
   > If the system doesn't find suggestions or you don't find the right technician, use the [schedule board in Field Service](preview-schedule-board.md) instead.

1. Select the **Book resource** icon for the technician. The technician is booked and the status is changed to **Scheduled**. A confirmation displays.

1. Select the back arrow to return to the work order.

### Reschedule a work order in Teams

Reschedule a scheduled work order to a different resource, date, or time. Use schedule assist to provide schedules based on resource availability, skills, customer promised time windows, customer location proximity, and business unit. Or [manually move the date, time, or technician](#move-a-booking-in-teams).

1. From a scheduled work order, select **View schedule** under **Suggested actions**.

   :::image type="content" source="media/fsp-flm-teams-reschedule.png" alt-text="Field Service (Preview) Teams reschedule.":::

1. Select **Reschedule**. The system searches for available technicians based on the work order requirements and then displays suggestions. To view more suggestions, select **Show more** at the bottom of the list.

1. Review the suggested technicians and their availability. You can search for a technician by name, filter by dates, or sort the technicians by start time or travel time. If the **Estimated Duration** hasn't been set up in the resource requirements, 30 minutes is used as a default.

   > [!TIP]
   > If the system doesn't find suggestions or you don't find the right technician, select [**Go to schedule board** in Field Service](preview-schedule-board.md) instead.

1. Select the **Book resource** icon for the technician. The technician is booked. A confirmation displays.

1. Select the back arrow to return to the work order.

### Move a booking in Teams

Change the date and time scheduled for the technician.

1. From a scheduled work order, select **View schedule**.

   :::image type="content" source="media/fsp-flm-move-booking.png" alt-text="Screenshot of Field Service (Preview) Teams ellipsis button to select Move booking":::

1. Next to **Reschedule**, select the ellipsis (**&hellip;**) > **Move booking**. The system automatically displays the current resource, but you can change it.

1. Select the date and time and select **Update**. The technician is booked. A confirmation displays.

1. Select the back arrow to return to the work order.

## View work orders in Teams

You can view all work orders, overdue work orders, or work orders with a status of **In progress**. An overdue work order is an unscheduled or scheduled work order where the time promised has passed.

1. From your Viva dashboard, select **See all** from the **Work orders all in one place** tile. From your Teams Field Service **Home** page, select one of the following:

   - **All work orders**
   - **Overdue** work orders
   - **In progress** work orders

   :::image type="content" source="media/fsp-viva-work-order-list.png" alt-text="Screenshot of Field Service Teams list of work orders":::

   > [!TIP]
   > To view more work orders in the Field Service app, select **See more** at the bottom of the list.

1. To find a particular work order, enter the work order ID in the **Find by ID** box and select **Search**.

1. To filter the work orders by status or priority, select **Filter**, make your selection, and then select **Apply**. To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

1. Select a work order to view or edit the details.  

## Edit a work order in Teams

1. From your Viva dashboard, select **See all** from the **Work orders all in one place** tile. From your Teams Field Service **Home** page, select the work order you want to edit. Use **Find by ID** or **Filter** to find the work order if necessary.

   :::image type="content" source="media/fsp-viva-edit-work-order.png" alt-text="Screenshot of Field Service Teams work order to edit":::

1. Make the necessary changes and select **Save**. If the work order is unscheduled and you want to [schedule it](#schedule-a-work-order-in-teams), select **Schedule**.

## Call for remote collaboration through Remote Assist

[!INCLUDE [fsp-launch-ra](../includes/fsp-launch-ra.md)]

## Enable the Microsoft Copilot for Field Service work orders

[!INCLUDE [fsp-m365-copilot](../includes/fsp-m365-copilot.md)]

## Switch environments

[!INCLUDE [fsp-switch-env](../includes/fsp-switch-env.md)]


[!INCLUDE [footer-include](../includes/footer-banner.md)]
