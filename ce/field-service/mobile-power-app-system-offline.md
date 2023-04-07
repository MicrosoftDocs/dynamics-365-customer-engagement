---
title: Configure offline capabilities in the Field Service (Dynamics 365) mobile app (contains video)
description: Learn how to configure the mobile offline profile to work with the Field Service (Dynamics 365) mobile app when no network is available.
ms.date: 02/17/2023
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Configure offline capabilities in the Field Service (Dynamics 365) mobile app

Often frontline workers need to work in areas without internet access like remote areas or underground. Configure offline capabilities to allow frontline workers to continue using the Field Service (Dynamics 365) mobile app when there's no internet connection.

With offline capabilities, important data syncs to the device for viewing when there's no internet connection. Store the changes on the device and sync them with the server with an active internet connection.

> [!div class="mx-imgBorder"]
> ![Device render showing offline status mode in Field Service (Dynamics 365) mobile app.](./media/mobile-2020-offline-complete.png)

>[!TIP]
> Configuring offline capabilities creates a fast and consistent experience and is strongly recommended.

Administrators can control what data the Field Service (Dynamics 365) mobile app downloads with the offline profile.

Configure offline capabilities in four steps:

1. Set up an offline profile (one exists by default).
2. Add users to the offline profile.
3. Edit and publish the offline profile as needed.
4. Add the offline profile to the Field Service mobile model-driven app.

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4J8no]

## Step 1: Set up an offline profile

The offline profile manages offline record types, relationships, and user assignments.

Within your offline profile you can:

- Define record types that are available offline and their sync interval.
- Define filters for each record type. For example, by default the offline profile downloads bookings that start within the next seven days to the device.
- Set up item association by creating relationships between entities. Item association saves time because not every record type needs a filter. You can associate related record types that follow filters set on the related record type.

Go to the Power Platform admin center at [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/), and find and select your environment.

Select **Settings** at the top.

> [!div class="mx-imgBorder"]
> ![The Power Platform admin center, on an environment, showing the settings option.](./media/offline-2020-ppac-settings.png)

Go to **Users + permissions section** > **Mobile configuration**.

> [!div class="mx-imgBorder"]
> ![The Power Platform admin center, showing the Mobile configuration option.](./media/offline-2020-ppac-mobile-configuration.png)

Field Service provides an out-of-the-box offline profile called **Field Service Mobile - Offline Profile** with recommended default settings for Field Service record types.

> [!div class="mx-imgBorder"]
> ![The Power Platform admin center, showing mobile offline profiles.](./media/mobile-2020-offline-profile-ppac.png)

### Implementation guidance for the offline profile

**Use the offline profile included with Field Service**. The default **Field Service Mobile - Offline Profile** provides an ideal starting point for offline configuration, with defaults for out-of-the-box record types and sync intervals. Use this profile and build upon it by including your custom record types. By working within the provided profile, default entities can still receive updates over time. With offline data, in-app performance such as displaying forms will increase. Limiting the amount of data in the offline profile increases sync performance.

**Avoid removing default record types from the offline profile**. We purposefully added default record types  to ensure the right data is available to the frontline worker. Focus on adding the record types you need to the offline profile rather than removing ones you don't need.

**Avoid using "All records" as an offline filter**. The offline profile is the gate that controls the amount of data downloaded to the frontline workers’ devices. To keep sync times fast and efficient, avoid including "All records" as an entity filter and avoid wide date ranges. For example, rather than downloading all customer asset records, download only the records related to scheduled work orders. It reduces the number of customer asset records without impacting work at hand.

**Use offline JavaScript**. Organizations often need to run workflows on mobile devices to execute business processes. However, Power Automate flows only run when the device has network connection or on the next sync. Use offline JavaScript to run workflows on the device quickly and without internet access. For more information, go to [Workflows and scripts for the Field Service (Dynamics 365) mobile app](mobile-power-app-workflows.md).

For more best practices, go to [Power Apps Mobile Offline Guidelines](/power-apps/mobile/mobile-offline-guidelines)

## Step 2: Add users and teams to the offline profile

Open the **Field Service Mobile - Offline Profile**.  

Add users or [teams](/power-platform/admin/manage-group-teams) to the offline profile in the right **People with offline access** panel. When you add a team to the profile, the users within that team show under the team, while individual users show directly in the offline profile. Organizations with many users should use teams to help ease maintenance of user access.

You can only add a user or a team to one offline profile one at a time. Adding them to another offline profile shows a warning stating they're already part of a different offline profile. If you continue with the change, the user or team move to the new profile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the section where to add users to the offline profile.](./media/mobile-2020-offline-profile-add-user.png)

## Step 3: Edit and publish the offline profile

For each record type, you can choose a data download filter:

1. Download related data only.
2. All records. We don't recommend this setting because it can lead to a slow sync.
3. Other data filter.
4. Custom data filter.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the edit bookable resource booking entity options.](./media/mobile-offline-mop-latest.png)

For example, the **Bookable Resource Booking** (in other words, the booking) entity has a data download filter set to **custom data filter** that downloads resource bookings that start or end in the next seven days or today.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the set filter logic.](./media/mobile-2020-offline-ppac-brb-custom-filter.png)

**Save and Publish** the offline profile.

> [!NOTE]
> The default offline profile is updated periodically as part of Field Service updates. If you edited the offline sync filter of an entity, the entity's sync filter will not receive updates; other entity sync filters that have not been edited will receive updates in an unpublished state. Administrators can review the updates and decide if they want to take the update or continue with the previous sync filters. This only applies to sync filters and relationships will receive updates while keeping your specific changes.

For more information on offline profiles, see [Setting up mobile offline synchronization](/dynamics365/mobile-app/preview-setup-mobile-offline).

## Step 4: Add the offline profile to the app

Go to your Dynamics 365 apps by going to `yourenvironment.crm.dynamics.com/apps`, then go to the app designer for Field Service mobile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer.](./media/mobile-2020-open-app-designer.png)

Go to **Properties** and add the offline profile you published if it's not already there. Remember to save and publish your changes if you add an offline profile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer, on the Field Service mobile properties tab.](./media/mobile-2020-add-offline-profiles.png)

> [!NOTE]
> Field Service customers can create additional offline profiles to enable scenarios where different user roles have different sync settings or entities available to them. For example, a Field Service manager may require seeing a broader scope of work orders that may not be assigned to the current operator of the mobile app. If you create a new offline profile, you'll need to add it to the Field Service mobile app in the app designer as well.

Sign into your mobile app, then go to **Settings** > **Offline Setting (globe icon)** to see the status of downloaded data.

> [!div class="mx-imgBorder"]
> ![Device render showing offline status mode in Field Service (Dynamics 365) mobile app.](./media/mobile-2020-offline-complete.png)

If data isn't downloading, try signing out and signing back in. If offline data is still not downloading, make sure the user you're signing into the mobile app as uses a **Published** mobile offline profile.

## Understanding offline vs. online capabilities

Once you assigned users to a configured offline profile, following the initial sync to download data, the mobile app will always run offline-first. This functionality optimizes performance and creates a consistent experience for frontline workers as they move through areas with and without internet connection.

1. **Offline not configured**: Occurs when there's internet but no offline profile. The mobile app functions like using a Dynamics 365 app with internet on your PC. Without network, the mobile app is unusable. Not recommended.
2. **Offline First without internet connection**: Data downloads to the device and it stores all changes locally. When restoring the network connection, changes sync with the server.
3. **Offline First with internet connection**: Data downloads to the device and it stores all changes locally.  Because there's internet connection, the user can manually sync to receive the latest data from the server. The app will also automatically attempt to sync every few minutes. For more information, see [sync filters](#sync-intervals) in this article.

In summary, an offline-first application always reads from the local device database and only uses an active internet connection for sync. Ensure your offline profile syncs all data to the device that the frontline worker requires during their working hours.

> [!NOTE]
> After the offline-enabled user configures and signs into the app, the initial data sync will begin. During this time period, the app with run in online mode and changes will be updated on the server. After completing the offline sync, the app will be in offline-first mode and will read data from the local device database. During the time period of subsequent sync cycles, the app will not run as though in online mode.
>
> When an offline-enabled mobile application has network access, internal business logic fetches data from the server if a required record isn't found in the mobile offline profile. If no network access is available, a more specific error message will show, informing users of the missing table.

## Sync intervals

Sync intervals define how often record type data will automatically sync down to the users' devices. Sync intervals can be a minimum of five minutes or as long as one day. Records that change frequently can have a short duration sync interval, while infrequently changed records don't need to sync as often. With variable sync intervals, administrators have greater control over data and can help improve sync performance.

The default **Field Service Mobile - Offline Profile** has predetermined sync intervals for each record type, based on typical usage patterns of those record types.

> [!NOTE]
> A sync is only initiated when there is connectivity and when the app is actively running on the user’s mobile device. For Android devices, once the sync is initiated, it can be completed even when the app is in the background.
Dependencies based on selected relationships and custom filters that include related tables are analyzed at each sync request. Sync interval for an entity may not be respected if there is a related table with a lower sync interval.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the option to customize the records you want to make available offline.](./media/mobile-2020-offline-sync-filter.png)

> [!NOTE]
> Sync intervals are defined per record type with Field Service v8.8.40+. In earlier versions, all record types will have a five-minute sync interval.

## Sync conflicts

Sync conflicts happen if there's a mismatch between data on the device and data on the server. For example, when a frontline worker and a dispatcher edit the same work order without synchronizing the changes. The system won't know which modification to apply to the record because it gets conflicting information.

You can resolve conflict errors based on the settings set by the administrator. Conflicts happen at the entity level and not per field.

To set conflict detection, go to **Settings** > **Mobile Offline** > **Mobile Offline Settings** and the **Mobile Client** tab.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service settings showing the mobile offline menu option.](./media/mobile-powerapp-sync-conflict-navigate.png)

### Set conflict detection for mobile offline synchronization

- **No**: Data on the client device (mobile app) wins and there will be no sync errors. This setting is the default.

- **Yes**: Data on the server wins. The technician using the app may see errors informing them of conflict. In this case, while syncing changes to the server, you might see that resolved automatically. Server values can overwrite client changes. In this case, while syncing changes to the server, the technician using the application may see errors informing them of conflict.

> [!div class="mx-imgBorder"]
> ![Screenshot of system settings for Dynamics 365 showing the conflict detection setting.](./media/mobile-powerapp-sync-conflict.png)

Administrators can view past sync errors by going to **Settings** > **Sync Error**.

## View offline sync status (preview)

Field Service (Dynamics 365) provides an offline sync icon that indicates the synchronization status of the mobile app. It's always visible in the main app navigation on Windows, iOS, and Android devices. Find out at a glance whether your app connects to the network, a sync is in progress, or if there are sync errors.

For more information, see [View offline sync status (preview)](/power-apps/mobile/offline-sync-icon).

## Configuration considerations

### Should I make a copy of the offline profile?

We recommend using the mobile offline profile included with Field Service and then make offline filter changes directly in the *Field Service Mobile - Offline Profile*. Using the default offline profile allows your offline profile to receive updates to unchanged entity sync filters. You can also copy the default *Field Service Mobile - Offline Profile*, and make changes to the copy. The system considers the copy unmanaged it and won't receive any updates. If you make changes to the default offline profile and want to see the latest offline profile, create a new trial of Field Service to view it.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center showing the copy option for the Field Service Mobile - Offline profile.](./media/mobile-2020-offline-profile-copy.png)

### What is the best practice when moving the mobile offline profile between environments?

To control changes and keep your offline profiles in sync, your organization may require making changes to your mobile offline profile in one environment and the moving that profile into other environments. Best practice is to perform the following steps:

1. Create a copy of the default **Field Service Mobile - Offline Profile**.
2. Modify your copied profile as needed.
3. Create a managed solution that includes the mobile offline profile.  
   - In Dynamics 365, go to **Settings** > **Solutions** > **Create a new solution**.
   - Within the new solution, **Add Existing** > **Mobile Offline Profile**.
4. Export the managed solution containing the mobile offline profile from the original environment.
5. Import the managed solution into the new environment.

> [!div class="mx-imgBorder"]
> ![Screenshot of the adding Mobile Offline Profile to a solution.](./media/Solution_AddMOP.png)

### Are WebResources supported in offline mode?

Due to some current [limitations](/power-apps/mobile/offline-capabilities#limitations) of offline WebResources, we recommend using the [Power Apps component framework (PCF)](/powerapps/developer/component-framework/overview) to implement custom capabilities that work in both the Field Service (Dynamics 365) mobile app and in the browser.

### How do I know when a sync is in progress?

During regular use, a frontline worker will receive a notification during:

- Initial sync going offline for the first time.
- Manual refresh by selecting **Refresh** button on a grid.
- Large incremental sync after not using the app for a while.

These notifications show while the sync is in progress. The larger incremental sync lets you refresh the current view with latest data when complete.

The **Offline Status** page in the app, available from the sitemap, shows synchronized tables and the last date and time of the sync.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service (Dynamics 365) Sync Notifications.](./media/syncnotifications.png)

### Why does the offline enabled application show a message "Network or Service Unavailable"

The message "Network or Service Unavailable" shows when the application detects the network isn't suitable for online activity. While this message shows, the client won't sync new data, and some network-dependent areas of the application won't work. For example, maps or Dataverse search depends on device connectivity.

The application will check for connectivity whenever you navigate. The following events determine network detection, which may result in the error message:

- Application boots into offline mode prior to detecting network availability.
- Application network check fails with no response or a response that takes too long.

### Known Limitations

- Offline sync filters: Creating a record on the device while in offline mode, and that record doesn't meet filter conditions, then the record doesn't get resynchronized from the service until it meets the conditions.
- Offline sync filters: After setting up commands or capabilities to work with internet connectivity but not in offline mode, review them to confirm they're calling correct APIs: `Xrm.WebApi.online`.
- Offline Tables: Tables that support offline are part of the default Field Service Mobile Offline Profile. Some field service tables such as Purchase Order, Agreements, RTV, and RMA don't support offline profiles. Adding these tables and running the application while offline may result in errors in the mobile application.
- Inventory Validation doesn't run without network.
- When configuring the Mobile Offline Profile, there can be a maximum of 15 linked Tables. This 15-link limit includes downstream Tables. For example, if Table A has relationship with Table B, C, D and Table B has a relationship with Table F, G, H. Table A will have six relationships: B, C, D, F, G H. 
- [Details on other platform supported capabilities and limitations for offline](../mobile-app/mobile-offline-capabilities.md)

> [!NOTE]
> As part of Wave 1, 2021, Power Platform is introducing new (preview) features for the mobile offline profile. These features include a new way to access the mobile offline profile from [http://make.powerapps.com](http://make.powerapps.com), improved error handling, and removing the need to manually add individual user access. For more information, see [mobile offline overview](/power-apps/mobile/mobile-offline-overview) in Power Platform documentation.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
