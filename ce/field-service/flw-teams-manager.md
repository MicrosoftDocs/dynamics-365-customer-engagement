---
title: Manage work orders with Field Service in Teams (frontline managers)
description: Learn how service managers and dispatchers can use the Dynamics 365 Field Service Teams app to create, view, update, and schedule work orders in Teams.
ms.date: 05/08/2024
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Manage work orders with Field Service in Teams (frontline managers)

The Dynamics 365 Field Service app for Teams enables frontline managers to manage work orders without disrupting their workflow. Without leaving Teams, you can create, view, and edit work orders and quickly respond to requests for service or questions about existing requests.

## Prerequisites

- You have completed [Get started with Field Service in Teams](flw-teams-manager-get-started.md).

## Create a work order in Teams

1. From your Viva Connections dashboard, select **Create work order** on the **Work orders all in one place** tile.

   From your Field Service Teams **Home** page, select the **Create work order** button.

   :::image type="content" source="media/fsp-teams-create-button.png" alt-text="Screenshot of  the Field Service Teams app with the Create work order button highlighted.":::

1. Fill in the required information.

   If a value doesn't appear in the list, select **+ New item type** to create it in the Field Service app. Save and close the Field Service app. Type the new value or select **Refresh** to make it appear in the list.

   - [Service account](accounts.md)
   - [Work order type](create-work-order-types.md)
   - [Price list](create-price-list.md)

   :::image type="content" source="media/fsp-viva-create-work-order.png" alt-text="Screenshot of Field Service Teams Create a work order":::

1. Select **Save**.

   The work order number appears. If you want to open the work order in the Dynamics 365 Field Service app, select the open web app icon :::image type="icon" source="media/fsp-open-web-app-icon.png":::.

## Schedule or reschedule a work order

The Field Service app helps you schedule work orders. Scheduling suggestions are based on technicians' availability and skills, proximity to the customer's location, promised time windows, and the business unit.

1. Open the work order you need to schedule or reschedule.

1. To schedule, select **Schedule** under **Suggested actions**. To reschedule, select **View schedule** under **Suggested actions** and then **Reschedule**.

   The system searches for available technicians based on the work order requirements and then displays suggestions. To view more suggestions, select **Show more** at the bottom of the list.

1. Review the list of suggestions. You can search for a technician by name, filter by dates, or sort the list by start time or travel time.

   If the **Estimated Duration** hasn't been set up in the resource requirements, 30 minutes is used as a default.

   :::image type="content" source="media/fsp-flm-schedule-options.png" alt-text="Field Service Teams scheduling.":::

   If the system doesn't find suggestions or you don't find the right technician, use the [schedule board in Field Service](preview-schedule-board.md) instead.

1. To assign the work order to a technician, select the **Book resource** icon.

   The technician is booked and the status is changed to **Scheduled**. A confirmation displays.

1. Select the back arrow to return to the work order.

## Move a booking

If you don't need to change the assigned technician, just the date or time of the service appointment, you can move the booking. If needed, you can also assign the work order to a different resource.

1. Open a scheduled work order and select **View schedule**.

1. Select **Move booking**.

   :::image type="content" source="media/fsp-flm-move-booking.png" alt-text="Screenshot of Field Service Teams with Move booking highlighted":::

1. Select the new date and time and, if needed, a different resource.

1. Select **Update**.

   The technician is booked. A confirmation displays.

1. Select the back arrow to return to the work order.

## View a work order

You can view all work orders, overdue work orders, or work orders in progress. An overdue work order is an unscheduled or scheduled work order where the time promised has passed.

1. From your Viva Connections dashboard, select **See all** from the **Work orders all in one place** tile.

   From your Field Service Teams **Home** page, select one of the following:

   - **All work orders**
   - **Overdue**
   - **In progress**

   :::image type="content" source="media/fsp-viva-work-order-list.png" alt-text="Screenshot of Field Service Teams list of work orders":::

   Work orders are listed with the most recent one first.

1. Find the work order you want to view:

   - Type the work order ID in the **Find by ID** box and select **Search**. Clear any filters first.

   - To filter the list by status or priority, select **Filter**, make your choice, and then select **Apply**.

   - To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

1. Select a work order to view or edit it.  

   :::image type="content" source="media/fsp-viva-edit-work-order.png" alt-text="Screenshot of Field Service Teams work order to edit":::

While you're viewing a work order, you can also:

- [**Schedule**](#schedule-or-reschedule-a-work-order) or **View schedule** to schedule or view scheduling information.

- Reflect new or changed information. Select the **Refresh** icon.

- Open the work order in Dynamics 365 Field Service. Select the open web app :::image type="icon" source="media/fsp-open-web-app-icon.png"::: icon.

- Open a map to locate the service address. Select the **Open in Bing Maps** :::image type="icon" source="media/fsp-flm-map-icon.png"::: icon.

## Edit a work order

1. [View the work order](#view-a-work-order) you want to edit.

1. Make the necessary changes and select **Save**.

## Add attachments to a work order

Add installation manuals, maintenance documents, specifications, or troubleshooting tips relevant to a work order. Attachments enable technicians to ask Copilot questions and quickly obtain answers allowing for quicker diagnostics and problem-solving. As technicians work on jobs, they can interact with Copilot for real-time advice.

To add knowledge articles, go to [Link a knowledge article to a work order](field-service-km-link.md#link-a-knowledge-article-to-a-work-order).

To add notes, Microsoft Word, or PDF documents, perform the following steps.

1. [View the work order](#view-a-work-order).

1. Select the open web app :::image type="icon" source="media/fsp-open-web-app-icon.png"::: icon to open the work order in Dynamics 365 Field Service.

1. Select the **Timeline tab**.

1. Select the **Attachment** icon. Browse and select the item, and then select **Add note and close**.

   :::image type="content" source="media/timeline-tab.svg" alt-text="Field Service Work Order page, Timeline tab.":::

## Share work order information

[!INCLUDE [fsp-share-wo](../includes/fsp-share-wo.md)]

## Call for remote collaboration through Remote Assist

[!INCLUDE [fsp-launch-ra](../includes/fsp-launch-ra.md)]

## Switch environments

[!INCLUDE [fsp-switch-env](../includes/fsp-switch-env.md)]


[!INCLUDE [footer-include](../includes/footer-banner.md)]