---
title: Field Service (Preview) Teams app for the Frontline Worker
description: Learn about the Dynamics 365 Field Service (Preview) Teams and Viva Connections app to view and edit current work orders.
ms.date: 07/31/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Field Service (Preview) Teams app for the Frontline Worker

[!INCLUDE[public-preview-banner](../../includes/public-preview-banner.md)]

The Dynamics 365 Field Service Teams app enables frontline workers to view upcoming work orders and edit current work orders without disrupting their workflow. As a frontline worker, you can view work orders assigned to you and manage your current work order directly in Microsoft Viva Connections on your mobile device.

## Select your environment to open your dashboard the first time

1. In Teams, select **Apps** and select the name of the Viva Connections app provided by your admin. Your dashboard displays.

1. On a card that says **Get Started**, select **Settings**. The Team Settings page displays.

1. Select your Field Service environment.

   :::image type="content" source="media/fsp-environment-flw.png" alt-text="Screenshot of Field Service environment selection":::

1. Once the environment is validated, select **Return to Viva Connections dashboard**.

   :::image type="content" source="media/fsp-viva-mobile-dashboard.png" alt-text="Field Service (Preview) Viva Connections mobile dashboard":::

## View work orders assigned to me

1. From your mobile device, access the Microsoft Viva dashboard.

1. Under **Work Orders**, select **See all**.

   :::image type="content" source="media/fsp-flw-viva-work-orders.png" alt-text="Field Service (Preview) Viva Connections mobile list of work orders":::

1. To filter by **Booking status**, select **Filter**, make your selection, and then select **Apply**. For more information on booking status, see [Work order life cycle and statuses](../work-order-status-booking-status.md).

## View and manage your current work order

1. From your mobile device, access the Microsoft Viva dashboard.

1. Under **Current Work Order**, if you only need to update the booking status, select **Update Status**. Otherwise, select **Details**.

   :::image type="content" source="media/fsp-flw-work-order-details.png" alt-text="Field Service (Preview) Viva Connections mobile work order details":::

1. Within the details of the work order, you can:

   - Open a map to locate the service address
   - View tasks and products in Field Service
   - [Launch Remote Assist for remote collaboration](#call-for-remote-collaboration-through-remote-assist)
   - Change the [Booking status](../work-order-status-booking-status.md)
   - Change the Actual arrival or end time

1. If you made changes, select **Save**.

## Call for remote collaboration through Remote Assist

1. From the work order details, under **Support contact**, select **Launch Remote Assist**.

1. Search for and select the contact you want to call.

1. Select **OK** for Remote Assist to access your camera and select **Launch call**.

For more information about Dynamics 365 Remote Assist, see [Overview of Dynamics 365 Remote Assist](/dynamics365/mixed-reality/remote-assist/ra-overview).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
