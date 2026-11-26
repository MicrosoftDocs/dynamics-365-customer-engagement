---
title: Upgrade your Dynamics 365 Sales license
description: Follow the steps in this topic to upgrade to a higher Dynamics 365 Sales license tier.
ms.date: 04/16/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---
# Upgrade your Dynamics 365 Sales license

Learn how to upgrade to a higher Dynamics 365 Sales license. Dynamics 365 Sales has the following licenses: Sales Professional, Sales Enterprise, Microsoft Relationship Sales, and Sales Premium. Each license offers different features and capabilities to meet the needs of various businesses. By upgrading your license, you can access additional functionalities that can help your sales team be more productive and efficient.

## Overview

The upgrade process is the same regardless of which license you're upgrading to. You must have the appropriate admin permissions to manage licenses in Microsoft 365 and manage environments and apps in Power Platform admin center.  

The upgrade involves these steps:

1. [Purchase the new Dynamics 365 Sales license subscription](#purchase-a-new-dynamics-365-sales-subscription).
2. [Assign the new license to users](#assign-licenses-to-users).
3. [Install the corresponding app](#install-the-app).
4. [Remove the previous solution](#remove-the-previous-solution).

## Purchase a new Dynamics 365 Sales subscription

1. Sign in to [Microsoft 365 admin center](https://admin.microsoft.com) with your admin account.
2. In the left pane, select **Billing** > **Purchase Services**.
3. Find your Dynamics 365 Sales license, and then select **Details**.
4. In **Select license quantity**, enter the number of licenses you need.
5. Select **Buy**, and then complete the purchase.

## Assign licenses to users

1. Go to Microsoft 365 admin center, and in the left pane, select **Users** > **Active users**.
2. Select the users who need the new license.
3. Select **Manage product licenses**.
4. In the **Manage product licenses** pane, select **Replace**, and then select your new Dynamics 365 Sales license.  
    :::image type="content" source="media/assign-licenses-multiple-users.png" alt-text="Screenshot of assigning licenses to multiple users.":::  
5. Select **Save changes**, and then select **Done**.

## Install the app

Dynamics 365 Sales has two out-of-box apps: Sales Hub and Sales Professional. These apps are specific to licenses, and you must install the app that corresponds to your new license. Learn more about the apps included in each license in the [Dynamics 365 Sales licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544).

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com) as an admin.
1. Select **Environments**, and then open your environment.
1. Select **Dynamics 365 apps**.
1. Select **Install app**.
1. Select the app specific to your Dynamics 365 Sales license, and then select **Next**.
    :::image type="content" source="media/select-install-app-dynamics365-apps-resource.png" alt-text="Screenshot of selecting the Sales app to install.":::
6. Agree to the terms, and then select **Install**.

## Remove the previous solution

1. Sign in to Dynamics 365, and select **Settings** > **Advanced Settings**.
2. Select **Customization** > **Solutions**.
3. Select your previous Dynamics 365 Sales solution, and then select **Delete**.
    > [!NOTE]
    > Deleting the solution removes associated app modules and configurations like site maps and form preferences.

## Related information

[Licenses and storage FAQs](faq-licenses-storage.md)
