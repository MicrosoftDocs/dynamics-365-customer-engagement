---
title: Field Service (Preview) Teams app for the Frontline Worker
description: Learn about the Dynamics 365 Field Service (Preview) Teams and Viva Connections app to view and edit current work orders.
ms.date: 10/06/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Field Service (Preview) Teams app for the Frontline Worker

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Dynamics 365 Field Service Teams app enables frontline workers to view upcoming work orders and edit current work orders without disrupting their workflow. As a frontline worker, you can view work orders assigned to you and manage your current work order directly in Microsoft Viva Connections on your mobile device.

## Prerequisite

Environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages)

## Install the Field Service (Preview) Teams app

If your admin installed the Field Service (Preview) Teams app for your organization, you can skip this step.

[!INCLUDE [fsp-deploy-teams](../includes/fsp-deploy-teams.md)]

## Select your environment to open your dashboard the first time

1. In Teams, select **Apps** and select **Field Service (Preview)**.

1. Select the **Settings** tab.

1. Select your Field Service environment.

   :::image type="content" source="media/fsp-environment-flw.png" alt-text="Screenshot of Field Service environment selection for the Frontline Worker":::

1. Once the environment is validated, select **Open Viva Connections**. The **Home** page displays.

   :::image type="content" source="media/fsp-flw-menu.png" alt-text="Screenshot of Field Service (Preview) Viva Connections Dashboard for the Frontline Worker.":::

   > [!TIP]
   > In Teams, if you have multiple environments, you can easily [switch environments](#switch-environments).

## View all work orders

1. From your Viva dashboard, select **See all** under **Work Orders**. From your Teams Field Service (Preview) Home page, select **All work orders**.

   :::image type="content" source="media/fsp-flw-all-work-orders.png" alt-text="Field Service (Preview) Frontline worker all work orders":::

1. To find a particular work order, enter the work order ID in the **Find by ID** box and select **Search**.

1. To filter the work orders by status or priority, select **Filter**, make your selection, and then select **Apply**. To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

## View work orders assigned to me

View work orders assigned to you.

1. From the Teams Field Service (Preview) **Home** page, select **My work orders**.

   :::image type="content" source="media/fsp-flw-viva-work-orders.png" alt-text="Field Service (Preview) Frontline worker my work orders":::

1. To filter by **Booking status**, select **Filter**, make your selection, and then select **Apply**. For more information on booking status, see [Work order life cycle and statuses](work-order-status-booking-status.md).

## View and manage your current work order

1. From the Teams Field Service (Preview) **Home** page, select **My work orders**. Select your current work order for details.

   :::image type="content" source="media/fsp-flw-work-order-details.png" alt-text="Field Service (Preview) Frontline worker mobile work order details":::

   In Viva, under **Current Work Order**, if you only need to update the booking status, select **Update Status**. Otherwise, select **Details**.

1. Within the details of the work order, you can:

   - In Teams, change any fields except Service account and Work order type
   - Open a map to locate the service address
   - View tasks and products in Field Service
   - [Launch Remote Assist for remote collaboration](#call-for-remote-collaboration-through-remote-assist)

1. If you made changes, select **Save**.

## Call for remote collaboration through Remote Assist

[!INCLUDE [fsp-launch-ra](../includes/fsp-launch-ra.md)]

## Switch environments

[!INCLUDE [fsp-switch-env](../includes/fsp-switch-env.md)]


[!INCLUDE[footer-include](../includes/footer-banner.md)]
