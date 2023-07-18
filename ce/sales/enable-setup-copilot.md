---
title: Enable and set up copilot capabilities
description: Learn about how to enable and set up copilot capabilities (preview) in Dynamics 365 Sales.
ms.date: 06/20/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# Enable and set up copilot capabilities

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Copilot is a virtual assistant that helps sellers to be more productive and efficient in their daily work. Copilot can summarize records, help sellers catch up on updates, prepare for meetings, respond to emails, and so on.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Enable Sales Copilot

Select the apps and the copilot features that you want to enable on the apps. You can enable copilot only from the Sales Hub app. If you're using a custom sales app, you need to switch to the Sales Hub app to enable copilot for the custom app.

1. From the Change area in the Sales Hub app, select **App Settings**.  

1. Under **General Settings**, select **Sales Copilot (preview)**.
    If this is the first time you're setting up copilot, you'll see **Set up Copilot**. If you've already set up copilot, you can enable or disable apps or copilot features by selecting **Manage apps**.

1. Select **Set up Copilot** or **Manage apps** depending on what you see.

    :::image type="content" source="media/sales-copilot-setup.png" alt-text="Screenshot of the Set up Sales Copilot panel with the list of apps and options to turn on Compose and Chat." lightbox="media/sales-copilot-setup.png":::

    The side panel displays the list of apps installed in your organization.  
1. Select the following copilot features to enable them:
    - **Compose**: Select this checkbox to enable the copilot feature that helps sellers quickly compose emails. More information: [Learn more about composing emails with Copilot](compose-send-email-copilot.md).
    - **Chat**: Select this checkbox to enable the copilot features that help sellers chat with copilot to get contextual insights and suggestions. For example, sellers can ask copilot to summarize an opportunity or lead, help them prepare for a meeting, and so on. [Learn more about chat with copilot](use-sales-copilot.md).

    After you save the changes, you'll see the Copilot icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) in the right most bar. Select the icon to open the copilot panel.

## Grant audit access to users

Catch up information in Sales Copilot is generated from the audit history. Hence, users need to have access to view audit history and audit summary to be able to view lead and opportunity catch ups.

1. Allow users to access the audit:

    1. In the Sales Hub app, select **Settings** > **Advanced Settings**.

    1. Select **Settings** > **Administration** > **System Settings**

    1. Select the **Auditing** tab and select **Audit user access**.

    > [!NOTE]
    > Alternatively, you can turn on audit access from the [Sales Copilot settings page](configure-sales-copilot.md).
1. Grant users access to view audit history and audit summary:

    1. In the Sales Hub app, select **Settings** > **Security** > **Security Roles**.

    1. Select the security role that you want to edit and select the **Core Records** tab.

    1. Under **Miscellaneous Privileges** and select the following privileges:
        - **View Audit History**
        - **View Audit Summary**

    1. Save the changes.

## Next step

[Configure copilot capabilities (preview)](configure-sales-copilot.md)