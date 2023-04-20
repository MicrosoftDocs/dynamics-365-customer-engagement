---
title: Enable the Omnichannel for Customer Service app and disable the Customer Service workspace app for Omnichannel users
description: Enable the Dynamics 365 Omnichannel for Customer Service app and disable the Customer Service workspace app for Omnichannel users
author: lalexms
ms.author: laalexan
ms.reviewer: shujoshi
ms.service: dynamics-365 
ms.topic: how-to
ms.date: 04/19/2023
ms.custom: bap-template
---

# Enable the Omnichannel for Customer Service app and disable the Customer Service workspace app

With the deprecation of the Omnichannel for Customer Service agent-facing app, the app is hidden and by default, the Customer Service workspace app is shown to the following user profiles:

- Omnichannel Agent
- Omnichannel Supervisor
- Omnichannel Administrator

If your business still requires the Omnichannel for Customer Service app, use the steps in this article to [enable the Omnichannel for Customer Service app](#enable-the-omnichannel-for-customer-service-app).

If you don't want the Customer Service workspace app to be visible for any of these profiles, follow the steps in [Disable the Customer Service workspace app](#disable-the-customer-service-workspace-app) to remove it from the apps page in your environment.

## Enable the Omnichannel for Customer Service app 

1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083).

1. Select **Environment** on the top navigation bar. The **Select environment** pane is displayed.

1. Search for your environment, and then select it.

1. On the site map, select **Apps**, and then select the ellipsis next to **Omnichannel for Customer Service**.

1. Select **Activate**. Omnichannel will then become visible on your environment's apps page.
    

## Disable the Customer Service workspace app

1. On the Dynamice 365 **Apps** page, navigate to the **Customer Service workspace** app, and then select **MANAGE ROLES** from the app menu.

1. On the **Manage roles - Customer Service workspace** menu, deselect the boxes for the roles you don't want the Customer Service workspace app to be visible to.

   :::image type="content" source="media/deactivate-csw-app.png" alt-text="Remove the Omnichannel for Custmoer Service app from roles":::

1. Select **Save**.


