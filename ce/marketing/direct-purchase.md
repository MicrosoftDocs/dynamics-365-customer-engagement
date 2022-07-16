---
title: "Purchase a license directly from the Marketing app (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to a license to purchase a paid license directly within the Dynamics 365 Marketing app."
ms.date: 07/14/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Purchase a license directly from the Marketing app

You can now purchase a Marketing license directly within the app. Previously, the only way to purchase Dynamics 365 Marketing was through the [Microsoft product website](https://dynamics.microsoft.com/marketing/overview/) or through the [admin center](admin.microsoft.com). The ability to directly purchase saves you time and streamlines the buying process. To further simplify things, the purchase experience is no longer just for administrators. Now, department heads like Marketing Directors can purchase a license directly, improving agile workflows.

This article details who can purchase a license within the app, how can they purchase a license, and what happens after the purchase.

## Who can purchase a license

As detailed below, the ability to purchase a license depends on whether a license has previously been purchased.

- When no license was previously purchased, these users can purchase directly within the app:
    - Tenant admins who are signed up for a trial, in a trial app.
    - Non-tenant admins who sign-up for a free trial, in-app trial.
- When a license was previously purchased, these users can purchase directly within the app:
    - Anyone who comes to the trial experience after a new license is available on the tenant.

### Roles & responsibilities for tenant admin vs. departmental purchasers

The [Power Platform admin center](admin.microsoft.com) offers users administrators and departmental purchasers many ways to limit and control the purchase experience.

In the admin center, *tenant admins* can:
- Disable purchase by product ID of any product.
- View all departmental purchases made in the org.
- Cancel any departmental purchase and (optionally) move assigned users to an org purchase.

In the admin center, *departmental purchasers* can:
- Acquire a departmental license through a paid/trial motion.
- Assign those licenses to users in their tenant if applicable.
- Add/remove licenses as needed.
- Pay their bill/manage their account.

Put simply, the purchaser controls anything money-related. The administrator can cancel the subscription but can't make a user pay more or less and can't take something a user paid for and give it to someone else.

## Purchase a license within the app

To purchase a license within the Marketing app, select **Click here to purchase** from the information banner at the top of the screen in your trial.

> [!div class="mx-imgBorder"]
> ![Screenshot of top purchase banner.](media/direct-purhcase-top-banner.png "Screenshot of top purchase banner")

A modal window will open, which will automatically show you the appropriate license for your tenant.

> [!div class="mx-imgBorder"]
> ![Screenshot of the purchase modal window.](media/direct-purchase-modal.png "Screenshot of the purchase modal window")

> [!NOTE]
> The license shown depends on whether you already have another qualifying Dynamics 365 app with 10 or more users. If you have no other qualifying Dynamics 365 apps, a full license costs $1,500 per tenant/month. If you have a qualifying app, the license costs $750 per tenant/month. If you have pre-qualifying Marketing app licenses, the license costs $500 per tenant/month (for production use) or $250 per tenant/month (for non-production use). Learn more: [Get started with Dynamics 365 Marketing licensing](marketing-license.md).

Next, enter your purchase information to finalize the transaction.

## What happens after the purchase

After your purchased is processed, the page will return to the trial and inform you that your license is ready to activate. From this point you have two options:

1. To convert the existing trial environment to a paid instance, select the **Activate** button.
1. To create a new environment to apply the license to or to apply the license to an existing Dynamics 365 environment with other apps already installed, select the **Learn more** link.

> [!div class="mx-imgBorder"]
> ![Screenshot of the activate window.](media/direct-purchase-activate.png "Screenshot of the activate window")

> [!NOTE]
> If you do not have the required administrator user privileges to activate a license in the current environment, you will be shown a window that informs you that the license is ready to activate and to contact the system admin for the environment. Alternatively, you can activate the license on a separate environment.

After you activate the license, your trial environment will change from a trial to a full production environment.

> [!IMPORTANT]
> - Your new Marketing license will appear on your tenant instantly, but will take up to 24 hours to replicate to the Power Platform admin center. 
> - Additionally, you will experience some Marketing app downtime while your trial app is being upgraded. The downtime may last up to an hour.