---
title: Install Dynamics 365 Sales apps
description: Learn how to install Dynamics 365 Sales apps.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: overview 
ms.date: 05/27/2026
ms.custom: bap-template
ai-usage: ai-assisted
---

# Install Dynamics 365 Sales apps

Depending on your license, you can install the sales apps to get started with Dynamics 365 Sales immediately. Some apps are pre-installed, while others can be installed separately. Follow the instructions in this article to install the apps included in your license and start using them.

## System requirements

Review the system requirements before installing Dynamics 365 Sales apps. [System requirements for Sales Hub and Sales Professional apps](system-requirements-for-sales-apps.md)

## Install and use the sales apps

Your Dynamics 365 Sales license comes with free apps that are either pre-installed or can be installed separately. To know about the apps available with your license, refer to the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

The following table lists the apps and the installation instructions.  

|App name  | Instructions to access  |
|---------|----------------------|
|Sales Hub app** (pre-installed with Dynamics 365 Sales Embedded Package)   | [Link](intro-saleshub.md)        |
|Sales Professional app     | [Link](provision-sales-professional-instance.md)        |
|Sales Team member app     | [Link](sales-team-member.md)         |

** The Sales Hub app installed from the Dynamics 365 Sales Embedded Package has the latest features and updates. The Sales App or Enterprise Edition Apps include legacy versions of the Sales Hub app. Even if they appear in your list of installed apps in Power Platform, the Sales Hub app installed with the Embedded Package takes precedence. In some environments, the legacy apps are hidden to avoid confusion.

## Install an app from Power Platform admin center

After purchasing a Dynamics 365 Sales license, install your apps from the Power Platform admin center.

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com).

1. In the left pane, select **Manage** > **Environments** and then search and select your Dynamics 365 Sales environment.
1. From the command bar, select **Resources** > **Dynamics 365 apps**.

   You see a list of all available Dynamics 365 apps for your organization.

1. Search for "Sales" and find the app you want to install. Select **...** (More options) next to the app name, and then select **Install**.
   
   :::image type="content" source="media/dynamics365-apps-list.png" alt-text="Screenshot of the Power Platform admin center showing the Dynamics 365 apps list under Resources.":::

1. After installation completes, verify the app appears on the Power Apps **Apps** page.
   1. Go to [Power Apps](https://make.powerapps.com) and switch to your Dynamics 365 Sales environment.
   2. Select **Apps** > **All**, and confirm the app is listed.
   3. Search for **Sales** to view all apps related to Dynamics 365 Sales. 

      :::image type="content" source="media/powerapps-verify-app-installed.png" alt-text="Screenshot of the Power Apps Apps page showing the Sales Hub app listed under All apps.":::

## Share the app with users

After you install the app, share it with users in your organization. Before you share the app, ensure that users have been [assigned the necessary licenses](/power-platform/admin/assign-licenses).

1. In Power Apps, select **...** (More options) next to the app name, and then select **Share**.
2. Select a user and assign the [appropriate security roles](grant-access-saleshub.md) to the user on the right pane. 

   :::image type="content" source="media/share-app-powerapps.png" alt-text="Screenshot of the Power Apps Apps page showing the Share Sales Hub page.":::
3. Select **Share**.

Alternatively, you can share the app URL with the users after granting them [appropriate security roles](grant-access-saleshub.md).
