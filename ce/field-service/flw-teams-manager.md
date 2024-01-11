---
title: Work with Field Service in Teams (frontline managers)
description: Learn how service managers and dispatchers can use the Dynamics 365 Field Service Teams app to create, view, update, and schedule work orders in Teams.
ms.date: 12/11/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Work with Field Service in Teams (frontline managers)

The Dynamics 365 Field Service app for Teams enables frontline managers to manage work orders without disrupting their workflow. Without leaving Teams, you can create, view, and edit work orders and quickly respond to requests for service or questions about existing requests.

## Prerequisites

Your environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages).

> [!NOTE]
> The supported language is based on your Teams' language. If you access Teams from the web, the language is based on the web browser. If you access Teams from Teams Desktop, the language is based on Teams Desktop's language.

## Install the Field Service Teams app

Your admin might have installed the app for your organization. If you see the Field Service or Viva Connections icon in the Teams side rail or **Field Service** in the app list, you can skip this step.

[!INCLUDE [fsp-deploy-teams](../includes/fsp-deploy-teams.md)]

## Select your environment

1. In Teams, select **Apps** and select **Field Service**.

1. Select the **Settings** tab.

1. Select your Field Service environment. If you work in more than one environment, you can easily [switch environments](#switch-environments) when you need to.

   :::image type="content" source="media/fsp-environment-flm.png" alt-text="Screenshot of Field Service environment selection for the frontline manager":::

   [Look up your environment](/power-platform/admin/determine-org-id-name) if you're not sure which one to choose.

1. Once the environment is validated, select one of the following:

   - The **Home** tab to go to the Teams **Home** page.

     :::image type="content" source="media/fsp-flm-teams-home.png" alt-text="Field Service Teams Home page for the frontline manager":::

   - **Open Viva Connections** to go to your Viva Connections dashboard.

     :::image type="content" source="media/fsp-flm-teams-viva-dashboard.png" alt-text="Screenshot of the Field Service dashboard in Viva Connections in Teams.":::

## Create a work order in Teams

1. From your Viva Connections dashboard, select **Create work order** on the **Work orders all in one place** tile.

   From your Field Service Teams **Home** page, select the **Create work order** button.

   :::image type="content" source="media/fsp-teams-create-button.png" alt-text="Screenshot of  the Field Service Teams app with the Create a work order button highlighted":::

1. Fill in the required information.

   If a value doesn't appear in the list, select **+ New item type** to create it in the Field Service app. Save and close the Field Service app. Type the new value or select **Refresh** to make it appear in the list.

   - [Service account](accounts.md)
   - [Work order type](create-work-order-types.md)
   - [Price list](create-price-list.md)

   :::image type="content" source="media/fsp-viva-create-work-order.png" alt-text="Screenshot of Field Service Teams Create a work order":::

1. Select **Save**.

   The work order number displays.

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

1. Next to **Reschedule**, select the ellipsis (**&hellip;**) > **Move booking**. The system automatically displays the current resource, but you can change it.

   :::image type="content" source="media/fsp-flm-move-booking.png" alt-text="Screenshot of Field Service Teams ellipsis button to select Move booking":::

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

   - Type the work order ID in the **Find by ID** box and select **Search**.

   - To filter the list by status or priority, select **Filter**, make your choice, and then select **Apply**.

   - To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

1. Select a work order to view or edit it.  

   :::image type="content" source="media/fsp-viva-edit-work-order.png" alt-text="Screenshot of Field Service Teams work order to edit":::

While you're viewing a work order, you can also:

- [**Schedule**](#schedule-or-reschedule-a-work-order) or **View schedule** to schedule or view scheduling information.

- Reflect new or changed information. Select the **Refresh** icon.

- Open the work order in Dynamics 365 Field Service. Select the pop-out icon.

  :::image type="content" source="media/fsp-copilot-pop-out-icon.png" alt-text="Field Service Outlook pane highlighting the pop-out icon to go to Field Service.":::

- For unscheduled work orders, open a map to locate the service address. Select the **Open in Bing Maps** icon.

   :::image type="content" source="media/fsp-map-icon.png" alt-text="Screenshot of a work order in Outlook, with the Open in Bing Maps icon highlighted.":::

## Edit a work order in Teams

1. [View the work order](#view-a-work-order) you want to edit.

1. Make the necessary changes and select **Save**.

## Call for remote collaboration through Remote Assist

[!INCLUDE [fsp-launch-ra](../includes/fsp-launch-ra.md)]

## Enable the Microsoft Copilot for Field Service work orders

[!INCLUDE [fsp-m365-copilot](../includes/fsp-m365-copilot.md)]

## Switch environments

[!INCLUDE [fsp-switch-env](../includes/fsp-switch-env.md)]


[!INCLUDE [footer-include](../includes/footer-banner.md)]
