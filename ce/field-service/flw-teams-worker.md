---
title: Work with Field Service in Teams (frontline workers)
description: Learn how field technicians and other frontline workers can use the Dynamics 365 Field Service Teams app to view and update work orders in Teams on their mobile devices.
ms.date: 12/12/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Work with Field Service in Teams (frontline workers)

The Dynamics 365 Field Service app for Teams enables frontline workers to manage their work orders without disrupting their workflow. In a Viva Connections dashboard or directly in Teams, you can view and update work orders that are assigned to you on your mobile device.

## Prerequisite

Your environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages)

> [!NOTE]
> The supported language is based on your Teams' language. If you access Teams from the web, the language is based on the web browser. If you access Teams from Teams Desktop, the language is based on Teams Desktop's language.

## Install the Field Service Teams app

Your admin might have installed the app for your organization. If you see the Field Service or Viva Connections icon in the Teams side rail or **Field Service** in the app list, you can skip this step.

[!INCLUDE [fsp-deploy-teams](../includes/fsp-deploy-teams.md)]

## Select your environment

1. In Teams, select **Apps** and select **Field Service**.

1. Select the **Settings** tab.

1. Select your Field Service environment. If you work in more than one environment, you can easily [switch environments](#switch-environments) when you need to.

   :::image type="content" source="media/fsp-environment-flw.png" alt-text="Screenshot of Field Service environment selection for the frontline worker":::

   [Look up your environment](/power-platform/admin/determine-org-id-name) if you're not sure which one to choose.

1. Once the environment is validated, select one of the following:

   - The **Home** tab to go to the Teams **Home** page.

     :::image type="content" source="media/fsp-flw-menu.png" alt-text="Mobile device rendering of the Field Service main menu for the frontline worker.":::

   - **Open Viva Connections** to go to your Viva Connections dashboard.

     :::image type="content" source="media/fsp-viva-dashboard-flw.png" alt-text="Screenshot of the Field Service dashboard in Viva Connections for the frontline worker.":::

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

   - Change any fields except Service account and Work order type.

   - Open a map to locate the service address.

   - Open the work order in Dynamics 365 Field Service. Select the pop-out icon.

     :::image type="content" source="media/fsp-copilot-pop-out-icon.png" alt-text="Mobile device rendering of Field Service Teams highlighting the pop-out icon to go to Field Service.":::

   - View tasks and products in Field Service

   - [Launch Remote Assist for remote collaboration](#call-for-remote-collaboration-through-remote-assist)

1. If you made changes, select **Save**.

## Call for remote collaboration through Remote Assist

[!INCLUDE [fsp-launch-ra](../includes/fsp-launch-ra.md)]

## Enable the Microsoft Copilot for Field Service work orders

[!INCLUDE [fsp-m365-copilot](../includes/fsp-m365-copilot.md)]

## Switch environments

[!INCLUDE [fsp-switch-env](../includes/fsp-switch-env.md)]


[!INCLUDE[footer-include](../includes/footer-banner.md)]
