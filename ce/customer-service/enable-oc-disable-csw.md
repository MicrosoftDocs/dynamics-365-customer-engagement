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

With the [previously announced deprecation](deprecations-customer-service.md#omnichannel-for-customer-service-agent-facing-app-is-deprecated-and-will-be-removed-in-june-2024) of the Omnichannel for Customer Service agent-facing app, the app is now hidden in environments. By default, Customer Service workspace is shown to the following user profiles:

- Omnichannel Agent
- Omnichannel Supervisor
- Omnichannel Administrator

If your business still requires the Omnichannel for Customer Service app, use the steps in this article to [enable it](#enable-the-omnichannel-for-customer-service-app).

If you don't want the Customer Service workspace app to be visible for any of the above profiles, follow the steps in [Disable the Customer Service workspace app](#disable-the-customer-service-workspace-app) to remove it from the apps page in your environment.

## Enable the Omnichannel for Customer Service app 

1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083).

1. Select **Environment** on the top navigation bar. The **Select environment** pane is displayed.

1. Search for your environment, and then select it.

1. On the site map, select **Apps**, and then select the ellipsis next to **Omnichannel for Customer Service**.

1. Select **Activate**. Omnichannel will then become visible on your environment's apps page.
    

## Disable the Customer Service workspace app

1. On the Dynamics 365 **Apps** page, navigate to the **Customer Service workspace** app, and then select **MANAGE ROLES** from the app menu.

1. On the **Manage Roles - Customer Service workspace** right-side pane, deselect the roles you don't want the Customer Service workspace app to be visible to.

   :::image type="content" source="media/deactivate-csw-app.png" alt-text="Remove the Omnichannel for Custmoer Service app from roles":::

1. Select **Save**.

## Next steps

For migration information, go to [Migrate from Omnichannel for Customer Service to Customer Service workspace](migrate-oc-to-csw.md)
