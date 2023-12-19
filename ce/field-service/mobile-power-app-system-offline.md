---
title: Mobile offline profile (contains video)
description: Learn about the mobile offline profile for the Dynamics 365 Field Service mobile app including guidance and limitations for its use.
ms.date: 12/18/2023
ms.topic: overview
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Mobile offline profile

Often frontline workers need to work in areas without internet access like remote areas or underground. The Dynamics 365 Field Service mobile app offers offline capabilities through a mobile offline profile. When an admin [configures the offline profile](mobile-power-app-system-offline-setup.md), frontline workers can continue using the Field Service mobile app when there's no internet connection.  With offline capabilities, important data syncs to the device for viewing when there's no internet connection. Changes on the device are stored locally and then they sync with the server when an active internet connection becomes available.

If the offline profile is not configured, the mobile app can't be used without network connectivity.

The offline profile manages offline record types, relationships, and user assignments.

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4J8no]

Field Service mobile follows the same architecture and security as the Power Apps mobile app. For more information, see: [Overview of Power Platform security](/power-platform/admin/security/overview#the-application-and-data-on-the-device).

## Implementation guidance for the offline profile

**Use the default offline profile**. Although you can create your own mobile offline profile, we highly recommend using the default offline profile included with Field Service. The  **Field Service Mobile - Offline Profile** provides an ideal starting point for offline configuration, with defaults for out-of-the-box record types and sync intervals.

Use this profile and build upon it by including your custom record types. By working within the provided profile, default tables can still receive updates over time. With offline data, in-app performance such as displaying forms increase. Limiting the amount of data in the offline profile increases sync performance.

**Avoid removing default record types from the offline profile**. We purposefully added default record types  to ensure the right data is available to the frontline worker. Focus on adding the record types you need to the offline profile rather than removing ones you don't need.

**Avoid using "All records" as an offline filter**. The offline profile is the gate that controls the amount of data downloaded to the frontline workers’ devices. Technically, there's no limit to the number of records the offline profile supports. However, to keep sync times fast and efficient, avoid including "All records" as an entity filter and avoid wide date ranges. For example, rather than downloading all customer asset records, download only the records related to scheduled work orders. It reduces the number of customer asset records without impacting work at hand. For optimal performance we recommend that you follow the [offline profile guidelines](/power-apps/mobile/mobile-offline-guidelines).

**Use offline JavaScript**. Organizations often need to run workflows on mobile devices to execute business processes. However, Power Automate flows only run when the device has network connection or on the next sync. Use offline JavaScript to run workflows on the device quickly and without internet access. For more information, go to [Workflows and scripts for the Field Service mobile app](mobile-power-app-workflows.md).

For more best practices, go to [Power Apps Mobile Offline Guidelines](/power-apps/mobile/mobile-offline-guidelines)

## Limitations of the offline profile

- Offline sync filters: Creating a record on the device while in offline mode, and that record doesn't meet filter conditions, then the record doesn't get resynchronized from the service until it meets the conditions.
- Offline sync filters: After setting up commands or capabilities to work with internet connectivity but not in offline mode, review them to confirm they're calling correct APIs: `Xrm.WebApi.online`.
- Offline Tables: Tables that support offline are part of the default *Field Service Mobile - Offline Profile*. Some field service tables such as Purchase Order, Agreements, RTV, and RMA don't support offline profiles. Adding these tables and running the application while offline may result in errors in the mobile application.
- Inventory Validation doesn't run without network.
- When configuring the Mobile Offline Profile, there can be a maximum of 15 linked Tables. This 15-link limit includes downstream Tables. For example, if Table A has relationship with Table B, C, D and Table B has a relationship with Table F, G, H. Table A will have six relationships: B, C, D, F, G, and H. 
- [Details on other platform supported capabilities and limitations for offline](../mobile-app/mobile-offline-capabilities.md)
- Access to SharePoint documents isn't supported in offline mode.

> [!NOTE]
> As part of Wave 1, 2021, Power Platform is introducing new (preview) features for the mobile offline profile. These features include a new way to access the mobile offline profile from [https://make.powerapps.com](https://make.powerapps.com), improved error handling, and removing the need to manually add individual user access. For more information, see [mobile offline overview](/power-apps/mobile/mobile-offline-overview) in Power Platform documentation.


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

Due to some current [limitations](/power-apps/mobile/offline-capabilities#limitations) of offline WebResources, we recommend using the [Power Apps component framework (PCF)](/powerapps/developer/component-framework/overview) to implement custom capabilities that work in the mobile app and in the browser.

### How do I know when a sync is in progress?

During regular use, a frontline worker will receive a notification during:

- Initial sync going offline for the first time.
- Manual refresh by selecting **Refresh** button on a grid.
- Large incremental sync after not using the app for a while.

These notifications show while the sync is in progress. The larger incremental sync lets you refresh the current view with latest data when complete.

The **Offline Status** page in the app, available from the sitemap, shows synchronized tables and the last date and time of the sync.

> [!div class="mx-imgBorder"]
> ![Screenshot of the sync notifications.](./media/syncnotifications.png)

### Why does some data become unavailable after completing the offline sync?

The offline-enabled application downloads data as configured in the mobile offline profile. Makers configure queries in the mobile offline profile and build relationships between tables to limit the downloaded data. Often, this configuration includes time-based filtering. For example, a frontline worker may not require access to completed *Bookable Resource Bookings* or bookings that are a few days in the past.

At certain points following a sync, data which no longer meets the offline profile filter criteria may be removed form the mobile application. Data removal is most common in two instances:

1. When the user of the mobile offline profile first signs in to the mobile application, it behaves as if it is in online mode until the first sync completes. During this time, data presented to the user is only restricted based on view filters. Following the completion of the first sync, the application changes to offline mode and shows only data that matches the mobile offline profile and the filters applied to the view.
   Depending on the filters of the mobile offline profile, a frontline worker may find some records removed from their view when the application changes from online to offline mode. For example, while online they may see all past *Bookable Resource Bookings*, but after moving to offline mode bookings that start today or in the future.

2. After an incremental sync while the user is already offline, data which does not meet filters of the mobile offline profile may be removed. For example, if the mobile offline profile filters all completed *Bookable Resource Bookings*, a newly completed booking gets removed from the agenda following a sync and is no longer accessible in the mobile application.

If a user is actively viewing a record which is removed from the mobile offline database, they see a **Record Not Found** error. If this is a frequent occurrence, we recommend to review the filters to ensure they are not overly restrictive for key scenarios.

### What happens when I reconfigure the offline-enabled application?

Reconfiguring the mobile application clears the offline database on the device. The application starts a new full offline sync and then transition back into offline mode. Between starting the reconfigure process and completing the offline sync, the application works as in online mode.

### Why does the offline enabled application show a message "Network or Service Unavailable"

The message "Network or Service Unavailable" shows when the application detects the network isn't suitable for online activity. While this message shows, the client won't sync new data, and some network-dependent areas of the application won't work. For example, maps or Dataverse search depends on device connectivity.

The application will check for connectivity whenever you navigate. The following events determine network detection, which may result in the error message:

- Application boots into offline mode prior to detecting network availability.
- Application network check fails with no response or a response that takes too long.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
