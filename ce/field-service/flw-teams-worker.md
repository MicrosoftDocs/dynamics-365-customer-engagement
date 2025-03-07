---
title: Manage work orders with Field Service in Teams (frontline workers)
description: Learn how field technicians and other frontline workers can use the Dynamics 365 Field Service Teams app to view and update work orders in Teams on their mobile devices.
ms.date: 04/18/2024
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Work with Field Service in Teams (frontline workers)

The Dynamics 365 Field Service app for Teams enables frontline workers to manage their work orders without disrupting their workflow. In a Viva Connections dashboard or directly in Teams, you can view and update work orders that are assigned to you on your mobile device.

## Prerequisites

- You have completed [Get started with Field Service in Teams](flw-teams-worker-get-started.md).

## View a work order

1. From your Viva dashboard, select **See all** under **Work Orders**.

   From your Teams Field Service Home page, select **All work orders**, or select **My work orders** to view just the work orders that are assigned to you.

   :::image type="content" source="media/fsp-flw-all-work-orders.png" alt-text="Mobile device rendering showing the list of all work orders in the Field Service Teams app":::

1. Find the work order you want to view:

   - Type the work order ID in the **Find by ID** box and select **Search**. Clear any filters first.

   - To filter the list by status or priority, select **Filter**, make your choice, and then select **Apply**.

   - To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

1. Select the work order to view or edit it.

   :::image type="content" source="media/fsp-flw-work-order-details.png" alt-text="Field Service Frontline worker mobile work order details":::

## Manage your current work order

1. From the Teams Field Service **Home** page, select **My work orders**. Select your current work order for details.

   In Viva, under **Current Work Order**, if you only need to update the [booking status](work-order-status-booking-status.md), select **Update Status** and then select the new status. Otherwise, select **Details**.

   :::image type="content" source="media/fsp-flw-work-order-details.png" alt-text="Rendering of a mobile device, showing the details of a work order in the Field Service app for Teams.":::

1. Within the details of the work order, you can:

   - Change any fields except **Service account** and **Work order type**.

   - Open a map to locate the service address. Select the **Open in Bing Maps** :::image type="icon" source="media/fsp-flm-map-icon.png"::: icon.

   - Open the work order in Dynamics 365 Field Service. Select the open web app :::image type="icon" source="media/fsp-open-web-app-icon.png"::: icon.

   - View tasks and products in Field Service.

   - [Launch Remote Assist for remote collaboration](#call-for-remote-collaboration-through-remote-assist).

1. If you made changes, select **Save**.

## Share work order information 

[!INCLUDE [fsp-share-wo](../includes/fsp-share-wo.md)]

## Call for remote collaboration through Remote Assist

[!INCLUDE [fsp-launch-ra](../includes/fsp-launch-ra.md)]

## Enable the Microsoft Copilot for Field Service work orders

[!INCLUDE [fsp-m365-copilot](../includes/fsp-m365-copilot.md)]

## Switch environments

[!INCLUDE [fsp-switch-env](../includes/fsp-switch-env.md)]


[!INCLUDE[footer-include](../includes/footer-banner.md)]
