---
title: Update apps and solutions
description: Learn how to upgrade Dynamics 365 Field Service, mobile apps, and related solutions.
ms.date: 02/03/2023
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

The Field Service app will be updated automatically as part of the Dynamics 365 platform [One version](https://cloudblogs.microsoft.com/dynamics365/bdm/2018/07/06/modernizing-the-way-we-update-dynamics-365/) initiative. You can manually upgrade the app in the seven days between the update release and when the automatic update applies.

Go to [https://admin.powerplatform.microsoft.com/environments](https://admin.powerplatform.microsoft.com/environments) and select the environment with the Field Service app you want to update. In the top ribbon, select **Resources** > **Dynamics 365 apps**.

Select the **Dynamics 365 Field Service** app and select **Update**. Updating the Field Service app also gets the latest version of other related solutions that are part of the Field Service app.
:::image type="content" source="media/update-field-service-callouts.png" alt-text="Screenshot of the Dynamics 365 apps in Power Platform admin center.":::

<!-- Before your organization updates to 8.8.6+ or later, you can manually apply updates by going to the Microsoft 365 Admin Center.

Go to [https://admin.powerplatform.microsoft.com/environments](https://admin.powerplatform.microsoft.com/environments) and select the environment with the Field Service app you want to update. In the top ribbon, select **Resources** > **Dynamics 365 apps**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Dynamics 365 admin center_2.](./media/upgrade-fs-new-ppac.jpg)

In the list of solutions, select **Dynamics 365 Field Service**. The status column shows if an update is available. Then select the **Update** in the top. Updating the Field Service app also gets the latest version of other related solutions that are part of the Field Service app.

> [!div class="mx-imgBorder"]
> ![Screenshot of a list of solutions in the admin center noting there's an upgrade available for Field Service.](./media/upgrade-fs-new-popup.jpg)






> [!div class="mx-imgBorder"]
> ![Screenshot of a list of solutions.](./media/upgrade-solution-list.png)

To understand what version of the Field Service solution is in your environment, look at the version of the solution named **FieldService_anchor**. 

### Best practices

1. Before upgrading your production instance of Field Service, make a copy of the production instance and upgrade the copy first. Then test your business processes to understand consequences and upgrade the actual production instance after.
1. If your organization is using Project Service Automation along with Field Service, it is recommended to upgrade both at the same time or soon after each other due to shared functionality.
1. Editing out-of-the-box web resources is unsupported and can cause issues after an update. You can use the [Solution Health Hub](troubleshoot-field-service-solution-health.md) to look for edited web resources. -->

## Field Service (Dynamics 365) mobile app

We recommend enabling automatic app updates on your mobile device. For more information, see these articles: [iOS: automatic app updates iOS](https://support.apple.com/HT202180#automatic) or [Android: automatic app updates](https://support.google.com/googleplay/answer/113412).

If you can't enable automatic updates, regularly check for updates in the app store for Field Service (Dynamics 365) and [install the latest version](mobile-power-app-overview.md).

## Universal Resource Scheduling

[Universal Resource Scheduling](universal-resource-scheduling.md) powers the scheduling capabilities in Field Service and other Dynamics 365 apps. You automatically get the latest version with updates for the Dynamics 365 app.

<!-- However, before upgrading Resource Scheduling consider:

1. Running the Resource Scheduling: Service Health Diagnostics
2. Planning for updated Universal FetchXML (UFX) queries on the schedule board and schedule assistant.

### Run Resource Scheduling: Service Health Diagnostics

Before upgrading, run the **Resource Scheduling: Service Health Diagnostics** tool to understand if any critical web resources or JavaScript files were edited. If so, they will get skipped during upgrade, which could cause functional issues and missed functionality. 

Go to **Resource Scheduling app** > **Settings** > **Administration** > **Scheduling Parameters**

Then select **Health Diagnostics** in the top ribbon.

> [!div class="mx-imgBorder"]
> ![Screenshot of resource scheduling health diagnostics.](./media/upgrade-rs-health-diagnostics.png)

If the diagnostic tool flags any web resources that should not have been edited, you will need to remove the customizations from the web resources and then run the upgrade. Not all customized web resources will be flagged by this tool, only the ones that could have critical impact. -->

### Updated Universal FetchXML (UFX) queries

Occasionally, Universal Resource Scheduling releases include updates to the Universal FetchXML (UFX) queries. UFX queries control how resources and requirements are fetched and loaded on the schedule board or in schedule assistant results.

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
