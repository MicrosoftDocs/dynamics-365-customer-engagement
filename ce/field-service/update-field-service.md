---
title: Update apps and solutions
description: Learn how to upgrade Dynamics 365 Field Service, mobile apps, and related solutions.
ms.date: 06/28/2024
ms.topic: how-to
ms.custom: bap-template
author: jshotts
ms.author: jasonshotts
---

# Update apps and solutions

Microsoft regularly releases updates to Dynamics 365 Field Service and related solutions. Updates add new capabilities, enhance the performance and usability of existing features, and fix bugs. This article discusses how to update Field Service, including the related mobile app and resource scheduling solutions.

Multiple updates are released throughout the year.

- **Minor updates** are released each month and include only minor bug fixes. Administrators receive a notification when an update is planned.

- **Major updates** are released in April and October and include new features, enhancements, and bug fixes. Some changes to controls and user experiences can roll out more frequently. To get the latest updates to controls as soon as they're available, [enable the monthly release channel for your environment](#update-model-driven-apps). Changes to business logic and other backend-related items continue to roll out twice a year.

- **Hot fixes** are rare, but occasionally a critical update is released outside the planned update schedule.

> [!TIP]
> Find information about new features and changes for upcoming releases in the [Dynamics 365 release plans](/dynamics365/release-plans/).

## Early Access update

Dynamics 365 releases major updates two months before the general rollout in an Early Access flight to evaluate upcoming changes. [Learn more about how to opt-in and update your org to Early Access](/power-platform/admin/opt-in-early-access-updates).

## Dynamics 365 Field Service

The Field Service app [updates automatically as part of platform updates](/power-platform/admin/general-availability-deployment).

You can also manually update the app right after release.

1. Open the [Power Platform admin center](https://admin.powerplatform.microsoft.com/environments) and select the environment with the Field Service app you want to update.

1. In the top ribbon, select **Resources** > **Dynamics 365 apps**.

1. Select the **Dynamics 365 Field Service** app, and then select **Update**.

    When you update the Field Service app, you also get the latest version of solutions that are part of the Field Service app.

    :::image type="content" source="media/update-field-service-callouts.png" alt-text="Screenshot of the Dynamics 365 apps in Power Platform admin center.":::

To find the version number of your Field Service app, look in the app details under Dynamics 365 apps in the Power Platform admin center.

## Field Service mobile app

We recommend that you turn on automatic app updates on your mobile device. If you don't, you should regularly check your app store for mobile app updates and [install the latest version](mobile/overview.md).

## Universal Resource Scheduling

[Universal Resource Scheduling](universal-resource-scheduling-for-field-service.md) powers the scheduling capabilities in Field Service and other Dynamics 365 apps. You automatically get the latest version with updates for the Dynamics 365 app.

### Updated Universal FetchXML queries

Occasionally, Universal Resource Scheduling releases include updates to the Universal FetchXML (UFX) queries. UFX queries control how the system fetches resources and requirements.

It's possible to customize UFX queries. If a UFX query is customized, updates import the latest version, but they *don't apply it automatically*. Add your customizations to the new UFX query and apply them manually in the [schedule board settings](schedule-board-tab-settings.md). Consider using GitHub for version control to understand the differences between the old XML file with your custom queries and the updated XML file.

## Resource Scheduling Optimization add-in

The [Resource Scheduling Optimization add-in](rso-overview.md) enables the automated scheduling of work orders, resources, and bookings. Updates are released throughout the year. An administrator has to apply the updates.

You can check for available updates in the [Power Platform admin center](https://admin.powerplatform.microsoft.com/). Go to **Resources** > **Dynamics 365 apps**, select **Resource Scheduling Optimization**, and select **Manage**.

In the **RSO Deployment** dialog box, select **Upgrade to new version**.

For more information, see [Manage the Resource Scheduling Optimization instance](rso-deployment.md#manage-the-resource-scheduling-optimization-instance).

## Update model-driven apps

To get the latest updates to controls and other frontend items, you can set the release channel for your environment or app. Microsoft regularly provides new and updated features for your model-driven apps. The release channel defines how quickly updates in Power Apps roll out in your organization.

For more information, see [Release channels for your model-driven app](/power-apps/maker/model-driven-apps/channel-overview).

## Next steps

- [Get started with Dynamics 365 Field Service](field-service-get-started.md)
- [Use the Field Service mobile app](mobile/overview.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
