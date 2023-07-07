---
title: Enable and set up copilot experience
description: 
ms.date: 06/20/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# Enable and set up copilot experiences

Copilot is a virtual assistant that helps sellers to be more productive and effective in their daily work. Copilot provides contextual and actionable insights and suggestions to sellers

## Enable Sales Copilot

Select the apps and copilot features you want to enable on them. You can only enable copilot from the Sales Hub app. If you're using a custom sales app, you need to switch to the Sales Hub app to enable copilot for the custom app.

1. From the Change area in the Sales Hub app, select **App Settings**.  

1. Under **General Settings**, select **Copilot (preview)**.
    If this is the first time you're setting up copilot, you'll see **Set up Copilot**. If you've already set up copilot, you can enable or disable apps or copilot features by selecting **Manage apps**.

1. Select **Set up Copilot** or **Manage apps** depending on what you see.

    :::image type="content" source="media/sales-copilot-setup.png" alt-text="Screenshot of the Set up Sales Copilot panel with the list of apps and options to turn on Compose and Chat." lightbox="media/sales-copilot-setup.png":::

    The side panel displays the list of apps installed in your organization. 
1. Select the following copilot features to enable them:
    - **Compose**: Select this checkbox to enable the copilot feature that helps sellers quickly compose emails using the Email assist feature. Learn more about email assist. 
    - **Chat**: Select this checkbox to enable the copilot features that help sellers chat with copilot to get contextual insights and suggestions. For example, sellers can ask copilot to summarize an opportunity or lead, help them prepare for a meeting, and so on. Learn more about chat with copilot.

    After you save the changes, you'll see the Copilot icon (:::image type="icon" source="media/copilot-icon.png" border="true":::) in the right most bar. Select the icon to open the copilot panel.

## Grant copilot access to users

As catch up summaries are generated from the audit history, users need to have access to view audit history and audit summary.

1. Enable user access to the audit:

    1. In the Sales Hub app, select **Settings** > **Advanced Settings**.

    1. Select **Settings** > **Administration** > **System Settings**

    1. Select the **Auditing** tab and select **Audit user access**. 
2. Grant users access to view audit history and audit summary:

    1. In the Sales Hub app, select **Settings** > **Security** > **Security Roles**.

    1. Select the security role you want to edit and select the **Core Records** tab.

    1. Under **Miscellaneous Privileges** and select the following privileges:
        - **View Audit History**
        - **View Audit Summary**

    1. Save the changes.
