---
title: Field Service (Preview) Teams app for the frontline manager
description: Learn about the Dynamics 365 Field Service (Preview) Teams and Viva Connections app to create, view, and edit work orders.
ms.date: 10/06/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Field Service (Preview) Teams app for the frontline manager

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Dynamics 365 Field Service (Preview) for Teams enable frontline managers to manage work orders without disrupting their workflow. As a frontline manager, you can create, view, and edit work orders directly in Teams. You can quickly respond to requests for service or questions about existing requests.

## Prerequisite

Environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages)

## Install the Field Service (Preview) Teams app

If your admin installed the Field Service (Preview) Teams app for your organization, you can skip this step.

[!INCLUDE [fsp-deploy-teams](../includes/fsp-deploy-teams.md)]

## Select your environment to open your dashboard the first time

1. In Teams, select **Apps** and select **Field Service (Preview)**. Your dashboard displays.

1. Select the **Settings** tab.

1. Select your Field Service environment.

   :::image type="content" source="media/fsp-environment-flm.png" alt-text="Screenshot of Field Service environment selection for the frontline manager":::

1. Once the environment is validated, select **Open Viva Connections**. The **Home** page displays.

   :::image type="content" source="media/fsp-flm-teams-home.png" alt-text="Field Service (Preview) Teams Home page for the frontline manager":::

   > [!TIP]
   > In Teams, if you have multiple environments, you can easily [switch environments](#switch-environments).

## Create a work order in Teams

1. From your Viva dashboard, select **Create work order** on the **Work orders all in one place** tile. From your Teams Field Service (Preview) **Home** page, select the **Create work order** button.

   :::image type="content" source="media/fsp-teams-create-button.png" alt-text="Screenshot of Field Service (Preview) Teams Create a work order button":::

1. At a minimum, enter the required information for the work order. For any field on the work order, if a value isn't available in the drop-down list, select **+**. The Field Service app opens so you can enter a new value and its details. Save and close the Field Service app. Type the new value or select **Refresh** to add the new value to the drop-down list.

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

1. From your Viva dashboard, select **See all** from the **Work orders all in one place** tile. From your Teams Field Service (Preview) **Home** page, select one of the following:

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

1. From your Viva dashboard, select **See all** from the **Work orders all in one place** tile. From your Teams Field Service (Preview) **Home** page, select the work order you want to edit. Use **Find by ID** or **Filter** to find the work order if necessary.

   :::image type="content" source="media/fsp-viva-edit-work-order.png" alt-text="Screenshot of Field Service (Preview) Teams work order to edit":::

1. Make the necessary changes and select **Save**.

## Call for remote collaboration through Remote Assist

[!INCLUDE [fsp-launch-ra](../includes/fsp-launch-ra.md)]

## Switch environments

[!INCLUDE [fsp-switch-env](../includes/fsp-switch-env.md)]


[!INCLUDE [footer-include](../includes/footer-banner.md)]
