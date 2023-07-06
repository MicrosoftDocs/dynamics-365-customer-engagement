---
title: Field Service (Preview) Teams app for the Frontline Manager
description: Learn about the Dynamics 365 Field Service (Preview) Teams and Viva Connections app to create, view, and edit work orders.
ms.date: 06/28/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Field Service (Preview) Teams app for the Frontline Manager

The Dynamics 365 Field Service (Preview) for Teams uses Viva Connection cards and a Teams tab to enable frontline managers to manage work orders without disrupting their workflow. As a frontline manager, you can create, view, and edit work orders directly in Teams. You can quickly respond to requests for service or questions about existing requests.

[!INCLUDE[public-preview-banner](../../includes/public-preview-banner.md)]

## Select your environment to open your dashboard the first time

1. In Teams, select **Apps** and select the name of the Viva Connections app provided by your admin. Your dashboard displays.

1. On a card that says **Get Started**, select **Settings**. The Team Settings page displays.

1. Select your Field Service environment.

   :::image type="content" source="media/fsp-environment-flw.png" alt-text="Screenshot of Field Service environment selection":::

1. Once the environment is validated, select **Return to Viva Connections dashboard**.

   :::image type="content" source="media/fsp-viva-dashboard-flm.png" alt-text="Field Service (Preview) Viva Connections dashboard":::

## Create a work order in Teams

1. From your Microsoft Viva dashboard, select **Create work order** on the **Work orders all in one place** tile.

1. At a minimum, enter the required information for the work order.

   - [Service Account](../accounts.md)
   - [Work Order Type](../create-work-order-types.md)
   - [Price List](../create-price-list.md)

   :::image type="content" source="media/fsp-viva-create-work-order.png" alt-text="Screenshot of Field Service (Preview) Teams Create a work order":::

1. Select **Save**. After the work order is created, the work order number displays. The **System Status** default is **Unscheduled**.

   :::image type="content" source="media/fsp-viva-pop-out-icon.png" alt-text="Screenshot of Field Service (Preview) Teams work orders highlighting pop-out icon":::

   > [!TIP]
   > If you want to open the work order in Field Service, select the pop-out icon.

## View work orders in Teams

1. From your Microsoft Viva dashboard, select **See all** on the **Work orders all in one place** tile. A list of work orders display.

   :::image type="content" source="media/fsp-viva-work-order-list.png" alt-text="Screenshot of Field Service (Preview) Teams list of work orders":::

1. To find a particular work order, enter the work order ID in the **Find by ID** box and select **Search**.

1. To filter the work orders by status or priority, select **Filter**, make your selection, and then select **Apply**. To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

1. Select a work order to view or edit the details.

## Edit a work order in Teams

1. From your Microsoft Viva dashboard, select **See all** on the **Work orders all in one place** tile. A list of work orders display.

1. Select the work order you want to edit. Use **Find by ID** or **Filter** to find the work order if necessary.

   :::image type="content" source="media/fsp-viva-edit-work-order.png" alt-text="Screenshot of Field Service (Preview) Teams work order to edit":::

1. Make the necessary changes and select **Save**.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
