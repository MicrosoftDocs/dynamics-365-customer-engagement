---
title: Upgrade your Dynamics 365 Sales license
description: Follow the steps in this topic to upgrade to a higher Dynamics 365 Sales license tier.
ms.date: 04/06/2025
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---
# Upgrade your Dynamics 365 Sales license

Learn how to upgrade to a higher Dynamics 365 Sales license tier.

## Overview

As your business needs grow, you can upgrade your Dynamics 365 Sales license to access additional features and capabilities. The upgrade process is the same regardless of which license tier you're upgrading to.

The upgrade involves these steps:

1. Purchase the new Dynamics 365 Sales license subscription.
2. Assign the new license to users.
3. Install the corresponding Sales solution.
4. Remove the previous solution.

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

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com) as an admin.
   > [!NOTE]
   > The Sales Hub app is preinstalled with the Dynamics 365 Sales Enterprise and Premium licenses. If you're upgrading to one of these licenses, you can skip to the next section to remove the previous solution.
1. Select **Environments**, and then open your environment.
1. Select **Dynamics 365 apps**.
1. Select **Install app**.
1. Select the app specific to your Dynamics 365 Sales license, and then select **Next**.

    :::image type="content" source="media/select-install-app-dynamics365-apps-resource.png" alt-text="Screenshot of selecting the Sales app to install.":::

6. Agree to the terms, and then select **Install**.

## Remove the previous solution

1. Make sure you have System Administrator or System Customizer security role.
2. Sign in to Dynamics 365, and select **Settings** > **Advanced Settings**.
3. Select **Customization** > **Solutions**.
4. Select your previous Dynamics 365 Sales solution, and then select **Delete**.

    > [!NOTE]
    > Deleting the solution removes associated app modules and configurations like site maps and form preferences.

> [!IMPORTANT]
> Check your licensing agreement. You cannot mix different license tiers on the same instance.

