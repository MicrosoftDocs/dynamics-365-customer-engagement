---
title: Update apps and solutions
description: Learn how to upgrade Dynamics 365 Field Service, mobile apps, and related solutions.
ms.date: 02/10/2023
ms.topic: how-to
ms.custom: bap-template
author: jshotts
ms.author: jasonshotts
search.app: 
  - D365CE
  - D365FS
---

# Update apps and solutions

Microsoft regularly releases updates to Dynamics 365 Field Service and related solutions. Updates add new capabilities, enhance the performance and usability of existing features, and fix bugs. This article details on upgrading Field Service, including the related mobile app and resource scheduling solutions.

Multiple updates are released every year.

- **Minor updates** are released each month and include only non-disrupting bug fixes.

- **Major updates** are released twice each year in April and October. Major releases include new features, enhancements, and bug fixes.

- **Hot fixes** are rare but occasionally a critical update gets released outside of the planned update schedule.

> [!TIP]
> The features and changes for upcoming releases are listed in the [Dynamics 365 release plans](/dynamics365/release-plans/).

## Dynamics 365 Field Service

The Field Service app [updates automatically as part of platform updates](/power-platform/admin/general-availability-deployment).

To manually update the app right after release, open the [Power Platform admin center](https://admin.powerplatform.microsoft.com/environments) and select the environment with the Field Service app you want to update. In the top ribbon, select **Resources** > **Dynamics 365 apps**.

Select the **Dynamics 365 Field Service** app and select **Update**. Updating the Field Service app also gets the latest version of other related solutions that are part of the Field Service app.
:::image type="content" source="media/update-field-service-callouts.png" alt-text="Screenshot of the Dynamics 365 apps in Power Platform admin center.":::

To find the version number of your Field Service app, review the details of the app under Dynamics 365 apps in the Power Platform admin center.

## Field Service (Dynamics 365) mobile app

We recommend enabling automatic app updates on your mobile device. For more information, see these articles: [iOS: automatic app updates iOS](https://support.apple.com/HT202180#automatic) or [Android: automatic app updates](https://support.google.com/googleplay/answer/113412).

If you can't enable automatic updates, regularly check for updates in the app store for Field Service (Dynamics 365) and [install the latest version](mobile-power-app-overview.md).

## Universal Resource Scheduling

[Universal Resource Scheduling](universal-resource-scheduling.md) powers the scheduling capabilities in Field Service and other Dynamics 365 apps. You automatically get the latest version with updates for the Dynamics 365 app.

### Updated Universal FetchXML (UFX) queries

Occasionally, Universal Resource Scheduling releases include updates to the Universal FetchXML (UFX) queries. UFX queries control how the system fetches resources and requirements.

It's possible to customize UFX queries based on your specific needs. If a UFX query has been edited, updates will import the latest UFX query, but **won't apply it automatically**. Add your customizations to the new UFX query and apply them manually from the [schedule board settings](schedule-board-tab-settings.md). Consider using GitHub for version control to understand the differences between the old XML file with your custom queries and the updated XML file.

## Resource Scheduling Optimization add-in

The [Resource Scheduling Optimization add-in](rso-overview.md) enables the automated scheduling of work orders, resources, and bookings. Updates are released throughout the year. An administrator has to apply the updates.

You can check for available updates in the [Power Platform admin center](https://admin.powerplatform.microsoft.com/). Go to **Resources** > **Dynamics 365 apps**, select **Resource Scheduling Optimization**, and select **Manage**.

In the **RSO Deployment** dialog box, select **Upgrade to new version**.

For more information, see [Manage the Resource Scheduling Optimization instance](rso-deployment.md#manage-the-resource-scheduling-optimization-instance).

## Next steps

- [Get started with Dynamics 365 Field Service](field-service-get-started.md)
- [Use the Field Service (Dynamics 365) mobile app](mobile-power-app-use.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
