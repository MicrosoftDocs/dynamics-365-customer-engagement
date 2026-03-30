---
title: Manage app visibility for Omnichannel users during transition to Copilot Service workspace
description: Learn how to manage app visibility for users assigned Omnichannel roles during the transition to Copilot Service workspace in Dynamics 365 Customer Service.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.date: 03/30/2026
ms.service: dynamics-365-customer-service
ms.custom: ce-admin
---

# Manage app visibility for Omnichannel users during transition to Copilot Service workspace

During the transition from the Omnichannel for Customer Service app to Copilot Service workspace, you may need to manage app visibility for users who are assigned Omnichannel roles.

By default, the Copilot Service workspace app is shown to the following Omnichannel user profiles:

- Omnichannel Agent  
- Omnichannel Supervisor  
- Omnichannel Administrator  

If users in these roles aren't ready to use Copilot Service workspace, you can activate the Omnichannel app and limit visibility of Copilot Service workspace for those users.

## Activate the Omnichannel app for assigned roles 

1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083).

1. Select **Environment** on the top navigation bar. The **Select environment** pane is displayed.

1. Search for your environment, and then select it.

1. On the site map, select **Apps**, and then select the ellipsis next to **Omnichannel for Customer Service**.

1. Select **Activate**. Omnichannel then becomes visible on your environment's apps page.
    

## Limit Copilot Service workspace visibility for assigned roles

1. On the Dynamics 365 **Apps** page, navigate to the **Copilot Service workspace** app, and then select **MANAGE ROLES** from the app menu.

1. On the **Manage Roles - Copilot Service workspace** right-side pane, deselect the roles you don't want the Copilot Service workspace app to be visible to.

   :::image type="content" source="../media/deactivate-csw-app.png" alt-text="Remove the Copilot workspace app from roles":::

1. Select **Save**.

## Next steps

Learn more about transitioning from legacy apps in [Migrate from removed or deprecated apps](migrate-to-csw.md).
