---
title: "Enable Unified Interface Only for Dynamics 365 for Customer Engagement apps| MicrosoftDocs"
ms.custom: 
ms.date: 03/25/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: c3742b70-863a-488e-beb3-fb9d63c2e6e5
caps.latest.revision: 5
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Enable Unified Interface Only

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

In 2018, we introduced [Unified Interface](https://docs.microsoft.com/powerapps/user/unified-interface), the latest generation of web app design for the PowerApps model-driven apps and Dynamics 365 Customer Engagement for apps. It brings the best in usability, accessibility, functionality, and speed to every user. Improve how your business applications run by using only the Unified Interface. For more information, see [How to enable Unified Interface Only](#how-to-enable-unified-interface-only-mode).

## When does Unified Interface Only experience become available, and which environments are affected?

All new Dynamics 365 Customer Engagement environments (instances) and Common Data Service environments, including those created in existing tenants, will be provisioned in Unified Interface Only mode per the schedule below. [Server version info text needed]

**Note**: Some geographical regions will get the changes ahead of schedule by as much as 2-3 weeks. 

|Environments (instances) types  |Release date  |
|---------|---------|
|New Trial Dynamics 365 Customer Engagement instances     | Dec 12, 2018         |
|New Trial and Production Common Data Service environments     | Feb 2, 2019        |
|New Production and Sandbox Dynamics 365 Customer Engagement instances     | Apr 12, 2019        |

Environments created before the scheduled release dates (created before version [text needed]) require administrators to change the environment settings to get the Unified Interface Only experience. We recommend that admins switch to this mode by following the steps at [How to enable Unified Interface Only](#how-to-enable-unified-interface-only-mode).

> [!IMPORTANT]
> For existing environments, it’s recommended that you:
>
> - Read [What experiences are available in Unified Interface Only](#what-experiences-are-available-in-unified-interface-only-mode) and understand how it affects end users in your environment. 
> - Test the changes in your Trial or Sandbox environments before applying to your Production environment.

## What experiences are available in Unified Interface Only mode 

### New immersive home page experience on web

Unified Interface Only mode provides easier and quicker access to apps, and gives users the ease of working in simple purpose-built apps. Users with just one app available to their security roles land in the app after signing in using the environment URL (for e.g. https://contoso.crm.dynamics.com/). The first page they see is determined by the first page of the app. 

Users with multiple apps see the list of apps available to them, and can navigate to them by clicking on the app tile. 

> [!div class="mx-imgBorder"] 
> ![](media/uci-apps-home-page.png "Unified interface apps")

**Note**:  This change applies to environment URL based sign-in (for example https://contoso.crm.dynamics.com/) on the web. It doesn’t impact mobile app users or users who sign in using home.dynamics.com or other portals.

### Run all apps in Unified Interface Only mode

Unified Interface is centered around the concept of modular applications known as model-driven apps (https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/model-driven-app-overview). These apps allow developers and admins to streamline the data and functionality to provide exactly what end users need. 

In Unified Interface Only mode, all model-driven apps, including those created for the legacy web client, run in Unified Interface to provide superior performance and usability. 

### Deep linking apps and pages

With Unified Interface Only mode, all URLs (or deep links) open in Unified Interface in the context of the app being referenced. For more information on constructing links, see [Open forms, views, dialogs, and reports with a URL](https://docs.microsoft.com/powerapps/developer/model-driven-apps/open-forms-views-dialogs-reports-url).

If no app is referenced in the URL, the record or page opens without any navigation elements on the page. Navigation elements like sitemap are defined using an app; URLs without apps don’t have them. Users can use the app switcher to navigate to an app and continue their work.

### Dynamics 365 - custom

The legacy web client app, also known as *Dynamics 365 - custom*, is hidden from end users when a new environment is provisioned. It is always visible to those with System Administrator and System Customizer roles, and to other custom roles with similar privileges. The legacy web client app should only be used to check for backwards compatibility while you migrate your environments to the use of Unified Interface.

[need image of KS]

When Unified Interface Only mode is enabled, Dynamics 365 - custom opens in Unified Interface and not in the legacy web client. If users only have access to the Dynamics 365 – custom app and no other model-driven apps, they won’t be redirected automatically when signing in using the environment URL (for example https://contoso.crm.dynamics.com/). Access to this app can be enabled in one of two ways:

- In Customer Engagement, go to **Settings** > **Administration** > **System Settings** > **General** tab. Under **Show legacy Dynamics 365 - custom app**, select **Yes** for **Show this app on the landing page and include in the app switcher**.

> [!div class="mx-imgBorder"] 
> ![](media/uci-show-legacy-custom-app.png "Show legacy custom app")

- In the Power Platform Admin center, go to **Environments** > select an environment > **Settings** > **Behavior** > [need command].

[need image]

### Advanced settings

When Unified Interface Only mode is enabled, environment settings can be accessed via a menu on the navigation bar. Follow these steps to navigate to **Advanced Settings**:

1. Select **Settings** (![Gear button](../admin/media/selection-rule-gear.gif "Gear button")) on the navigation bar.
2. Select **Advanced Settings**.

> [!div class="mx-imgBorder"] 
> ![](media/uci-advanced-settings.png "Advanced Settings")

> [!NOTE]
> You need to select Advanced Settings from a Customer Engagement app page that's displayed in the Unified Interface such as Sales Hub or Customer Service Hub pages.

## How to enable Unified Interface Only mode

Unified Interface Only can be turned on and off in one of two ways:

- In Customer Engagement, go to **Settings** > **Administration** > **System Settings** > **General** tab. Under **Use the new Unified Interface only (recommended)**, select **Yes** for **Enable only the Unified Interface**.


> [!div class="mx-imgBorder"] 
> ![](media/uci-use-new-unified-interface-only.png "Use new Unified Interface Only")

- In the Power Platform Admin center, go to **Environments** > select an environment > **Settings** > **Behavior** > turn on **Open in classic mode**.

> [!div class="mx-imgBorder"] 
> ![](media/ucd-classic-mode.png "Classic mode")

## FAQs

### My instance is still using the legacy web client (fully or partially), and business users are used to it. How does this new setting (April 2019 release) impact my instance?

There are no changes for environments created before version [need text]. To take advantage of the benefits of Unified Interface, admins can choose to turn Unified Interface Only mode.

### I want to use Unified Interface for all the apps, but still want Dynamics 365 – custom in the legacy web client as a fallback option. Is that possible?

1. Customers can achieve such a use case by setting all apps to be Unified Interface apps. They won't get the Unified Interface first sign in experience - a reason  for the Unified Interface Only mode.
2. We recommend customers try Unified Interface for everything that they do – including Dynamics 365 - custom. If there are issues, [please let us know](https://docs.microsoft.com/power-platform/admin/get-help-support).
3. [text needed] https://contoso.crm.dynamics.com/main.aspx?forceClassic=1



















