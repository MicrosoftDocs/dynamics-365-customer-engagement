---
title: Get started with Field Service in Teams (frontline workers)
description: Learn how to set up the Dynamics 365 Field Service app in Teams for field technicians and other frontline workers to manage work orders.
ms.date: 04/03/2024
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Get started with Field Service in Teams (frontline workers)

The Dynamics 365 Field Service app for Teams is designed to help frontline workers manage their work orders. To get started using the Field Service app in Teams, install the app, then sign-in and select your environment.

## Prerequisite

Your environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages).

> [!NOTE]
> The supported language is based on your Teams' language. If you access Teams from the web, the language is based on the web browser. If you access Teams from Teams Desktop, the language is based on Teams Desktop's language.

## Install the Field Service Teams app

[!INCLUDE [fsp-deploy-teams](../includes/fsp-deploy-teams.md)]

## Select your environment

1. In Teams, select **Apps** and select **Field Service**.

1. Select the **Settings** tab.

1. Select your Field Service environment. If you work in more than one environment, you can easily [switch environments](flw-teams-worker.md#switch-environments) when you need to.

   :::image type="content" source="media/fsp-environment-flw.png" alt-text="Screenshot of Field Service environment selection for the frontline worker":::

   [Look up your environment](/power-platform/admin/determine-org-id-name) if you're not sure which one to choose.

1. Once the environment is validated, select one of the following options:

   - The **Home** tab to go to the Teams **Home** page.

     :::image type="content" source="media/fsp-flw-menu.png" alt-text="Mobile device rendering of the Field Service main menu for the frontline worker.":::

   - **Open Viva Connections** to go to your Viva Connections dashboard.

     :::image type="content" source="media/fsp-viva-dashboard-flw.png" alt-text="Screenshot of the Field Service dashboard in Viva Connections for the frontline worker.":::

## Enable the Microsoft Copilot for Field Service work orders

[!INCLUDE [fsp-m365-copilot](../includes/fsp-m365-copilot.md)]

## Next steps

- [Manage work orders with Field Service in Teams (frontline workers)](flw-teams-worker.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
