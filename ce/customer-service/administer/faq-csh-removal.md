---
title: Customer Service Hub app removal and migration FAQ
description: Find answers about Customer Service Hub app availability and migration to Copilot Service workspace for Dynamics 365 Customer Service.
ms.date: 09/23/2026
ms.topic: faq
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.custom: bap-template
---

# Customer Service Hub app removal and migration FAQ

This article answers common questions about Customer Service Hub availability for new organizations with Enterprise licenses and migration to Copilot Service workspace.

## Why has the Copilot Service workspace app replaced Customer Service Hub for new organizations with Enterprise licenses?

Copilot Service workspace is a multisession app that lets customer service representatives work across multiple sessions and tabs in a single window. In contrast, Customer Service Hub is a single-session app that requires representatives to open multiple browser windows to manage their work items.

Representatives can respond to email, chats, and messages from configured social media channels, and handle calls. They can view and filter conversations and work items in an Outlook-style inbox. Administrators can create custom inbox views to meet their organization's needs.

When administrators enable Copilot in Copilot Service workspace, representatives can use the following features:

- Summarize cases.
- Summarize conversations.
- Ask Copilot questions.
- Draft email replies.

## What does removal mean?

Removal means that Microsoft plans to remove a feature or app on a specific date. In this case, as of February 2025, the Customer Service Hub app is no longer available for all new organizations with Enterprise licenses. We continue to support the application for all existing organizations and new customers who have other license types other than Enterprise (for example, Customer Service Professional licenses). However, we recommend that all existing customers migrate to Copilot Service workspace.

## Can I continue to use the Customer Service Hub app?

Yes. If you're already using Customer Service Hub, you can continue to use it. As of July 12, 2024, new customers can only deploy Copilot Service workspace in their enterprise environments. We continue to support the application for all existing organizations and new customers who have other license types other than Enterprise (for example, Customer Service Professional licenses).

## Since Customer Service Hub is no longer available to new enterprise organizations, what app should I use?

You can use the Copilot Service workspace app.

## What's the best way to get familiar with Copilot Service workspace?

Learn more in [Copilot Service workspace in a day](https://go.microsoft.com/fwlink/?linkid=2300097).

## I'm an existing enterprise customer and still need to use Customer Service Hub. How do I enable it?

If you're an existing customer and need to set up Customer Service Hub in your enterprise environment for testing purposes, complete the steps in this section.

1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), and then select your solution.

1. Select **Default Solutions**, and then select **Environment variables**. The **Add existing environment variables** page appears.

1. In the search field, type either "msdyn_AllowCSHAppHide" or "Enable or disable the ability to hide the CSH application", and then select it in the search results. The **Edit Allow CSH App Hide** dialog appears.

1. Change **Current Value** to **No**, and then select **Save**.

1. Open Copilot Service admin center, and then on the site map, select **New and upcoming features** in **Miscellaneous**.

1. On the **New and upcoming features** page, select the checkbox for **Provider icon configuration**.

1. Select **Save and close**.

## Why doesn't Customer Service Hub appear in my app list?

If **Customer Service Hub** doesn't appear in the **Published Apps** area or the app switcher, check the following items in order:

1. Verify that the user has the **Customer Service app access**, **System Administrator**, or **System Customizer** security role. Learn more in [Assign a security role to a user](/power-platform/admin/create-users#assign-a-security-role-to-a-user).
1. Verify that the app is shared with the user's security role. In [Power Apps](https://make.powerapps.com), select **Apps**. Next to **Customer Service Hub**, select **...**, and then select **Share**. Verify that the user's security role is selected. Learn more in [Share a model-driven app using Power Apps](/power-apps/maker/model-driven-apps/share-model-driven-app).
1. In the [Microsoft 365 admin center](https://admin.microsoft.com), verify that the user has a valid Dynamics 365 Customer Service Enterprise or Professional license. A Team Members or Dataverse-only license doesn't provide access to the full Customer Service Hub app.
1. Verify that the Customer Service applications are installed in the environment. Customer Service applications aren't available in Dataverse-only environments. Learn more in [Can't install Dynamics 365 Customer Service apps in an existing environment](/troubleshoot/dynamics-365/customer-service/customer-service-admin-center/cant-install-dynamics-365-customer-service-apps-in-existing-environment#cause-1-the-environment-is-dataverse-only).
1. If a role or license was recently changed, sign out and sign back in, or clear the browser cache, to load the updated app list.

If the app still doesn't appear, refer to [We can't find any apps for your role](/troubleshoot/power-platform/dataverse/environment-app-access/we-cannot-find-any-apps-your-role).

## How do I install or upgrade the Customer Service Hub app?

The Customer Service Hub app is installed as part of the Customer Service applications in an environment. Before you install or upgrade the app, verify the following prerequisites:

- The Dynamics 365 Customer Service applications are installed in the environment, and the environment isn't Dataverse-only. Learn more in [Customer Service Hub availability](../implement/availability-customer-service-hub.md).
- The account used to install or upgrade the app has the **System Administrator** role.
- Users who need access to the app have a Customer Service license and the **Customer Service app access**, **System Administrator**, or **System Customizer** role.

Learn more in [Manage Dynamics 365 apps that run on Microsoft Dataverse](/power-platform/admin/manage-apps).

If the installation or upgrade fails, use the following resources:

- For failures in an existing environment, including a Dataverse-only environment or missing or incorrect licensing, refer to [Can't install Dynamics 365 Customer Service apps in an existing environment](/troubleshoot/dynamics-365/customer-service/customer-service-admin-center/cant-install-dynamics-365-customer-service-apps-in-existing-environment).
- If you're moving from Interactive Service Hub, refer to [Upgrade from Interactive Service Hub to the Customer Service Hub app](upgrade-ish-csh.md) and [What to expect after the upgrade](upgrade-ish-csh.md#what-to-expect-after-the-upgrade).
 
## Related information
[Migrate to Copilot Service workspace from removed or deprecated apps](migrate-to-csw.md)  
[Get started with Copilot Service workspace](../implement/csw-overview.md)  
[Overview of the productivity pane](../use/csw-productivity-pane.md)
