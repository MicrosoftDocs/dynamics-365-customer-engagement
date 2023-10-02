---
title: Field Service (Preview) Teams app for the Frontline Manager
description: Learn about the Dynamics 365 Field Service (Preview) Teams and Viva Connections app to create, view, and edit work orders.
ms.date: 09/29/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Field Service (Preview) Teams app for the Frontline Manager

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Dynamics 365 Field Service (Preview) for Teams enable frontline managers to manage work orders without disrupting their workflow. As a frontline manager, you can create, view, and edit work orders directly in Teams. You can quickly respond to requests for service or questions about existing requests.

[!INCLUDE [us-uk-only](../includes/fsp-m365-us-uk-only.md)]

## Select your environment to open your dashboard the first time

1. In Teams, select **Apps** and select **Field Service (Preview)**. Your dashboard displays.

   > [!NOTE]
   > If your administrator hasn't set up the Field Service (Preview) Teams app, [install the app first](../includes/fsp-deploy-teams.md).

1. Select the **Settings** tab.

1. Select your Field Service environment.

   :::image type="content" source="media/fsp-environment-flw.png" alt-text="Screenshot of Field Service environment selection":::

1. Once the environment is validated, select **Open Viva Connections**. The **Home** page displays.

   :::image type="content" source="media/fsp-viva-dashboard-flm.png" alt-text="Field Service (Preview) Viva Connections dashboard":::

## Create a work order in Teams

1. From your Field Service (Preview) Home page, select the **Create work order** button.

   :::image type="content" source="media/fsp-teams-create-button.png" alt-text="Screenshot of Field Service (Preview) Teams Create a work order button":::

1. At a minimum, enter the required information for the work order. For any field on the work order, if a value is not available in the drop-down list, select **+** and enter a new value and its details. The new value is added to the drop-down list.

   - [Service Account](accounts.md)
   - [Work Order Type](create-work-order-types.md)
   - [Price List](create-price-list.md)

   :::image type="content" source="media/fsp-viva-create-work-order.png" alt-text="Screenshot of Field Service (Preview) Teams Create a work order":::

1. Select **Save**. After the work order is created, the work order number displays. The **System Status** default is **Unscheduled**.

   :::image type="content" source="media/fsp-viva-pop-out-icon.png" alt-text="Screenshot of Field Service (Preview) Teams work orders highlighting pop-out icon":::

   > [!TIP]
   > If you want to open the work order in Field Service, select the pop-out icon.

## View work orders in Teams

You can view all work orders, overdue work orders, or work orders with a status of **In progress**. An overdue work order is an unscheduled or scheduled work order where the time promised has passed.

1. From your Field Service (Preview) Home page, select one of the following:

   - **All work orders**
   - **Overdue** work orders
   - **In progress** work orders

   :::image type="content" source="media/fsp-viva-work-order-list.png" alt-text="Screenshot of Field Service (Preview) Teams list of work orders":::

   > [!TIP]
   > To view more work orders in the Field Service app, select **See more** at the bottom of the list.

1. To find a particular work order, enter the work order ID in the **Find by ID** box and select **Search**.

1. To filter the work orders by status or priority, select **Filter**, make your selection, and then select **Apply**. To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

1. Select a work order to view or edit the details.

## Edit a work order in Teams

1. From your Field Service (Preview) Home page, select the work order you want to edit. Use **Find by ID** or **Filter** to find the work order if necessary.

   :::image type="content" source="media/fsp-viva-edit-work-order.png" alt-text="Screenshot of Field Service (Preview) Teams work order to edit":::

1. Make the necessary changes and select **Save**.

[!INCLUDE [footer-include](../includes/footer-banner.md)]
