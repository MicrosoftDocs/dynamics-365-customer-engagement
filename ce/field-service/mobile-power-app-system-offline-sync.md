---
title: Offline data synchronization
description: Learn how offline data is synchronized to the server for the Dynamics 365 Field Service mobile app.
ms.date: 01/23/2024
ms.topic: conceptual
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Offline data synchronization

After configuring the offline profile and the initial sync of downloading data, the mobile app always runs [offline-first](/power-apps/mobile/mobile-offline-overview). This functionality optimizes performance and creates a consistent experience for frontline workers as they move through areas with and without internet connection.

## Sync intervals

Sync intervals define how often record type data automatically syncs down to the users' devices. Sync intervals can be a minimum of five minutes or as long as one day. Records that change frequently can have a short duration sync interval, while infrequently changed records don't need to sync as often. With variable sync intervals, administrators have greater control over data and can help improve sync performance.

The default **Field Service Mobile - Offline Profile** contains predetermined sync intervals for each record type, based on typical usage patterns of those record types.

A sync is only initiated when there's connectivity and when the app is actively running on the user's mobile device. For Android and iOS devices, once the sync is initiated, it can be completed even when the app is in the [background](/power-apps/mobile/sync-data-offline-background). Dependencies based on selected relationships and custom filters that include related tables are analyzed at each sync request. A sync interval for a table might not be respected if there's a related table with a lower sync interval.

In addition, users can [control when synchronizations are triggered](/power-apps/mobile/offline-sync-icon#offline-sync-settings) from the mobile app.

## Sync conflicts

Sync conflicts happen if there's a mismatch between data on the device and data on the server. For example, when a frontline worker and a dispatcher edit the same work order without synchronizing the changes. The system doesn't know which modification to apply to the record because it gets conflicting information.

You can resolve conflict errors based on the settings set by the administrator. Conflicts happen at the table level and not per field.

To set conflict detection, see [Open the System Settings dialog box](/power-platform/admin/system-settings-dialog-box-mobile-client-tab).

- **No**: Data on the client device (mobile app) wins resulting in no sync errors. This setting is the default.

- **Yes**: Data on the server wins. The technician using the app might see errors informing them of conflict. In this case, while syncing changes to the server, you might see that resolved automatically. Server values can overwrite client changes. In this case, while syncing changes to the server, the technician using the application might see errors informing them of conflict.

Administrators can view past sync errors by going to **Settings** > **Sync Error**.

## Sync notifications

During regular use, a frontline worker receives a notification during:

- Initial sync going offline for the first time.
- Manual refresh by selecting Refresh button on a grid.
- Large incremental sync after not using the app for a while.

These notifications show while the sync is in progress. The larger incremental sync lets you refresh the current view with latest data when complete.

The **Offline Status** page in the app, available from the sitemap, shows synchronized tables and the last date and time of the sync.

> [!div class="mx-imgBorder"]
> ![Screenshot of the sync notifications.](./media/syncnotifications.png)

## View offline sync status

The Field Service mobile app provides an [offline sync icon](/power-apps/mobile/offline-sync-icon) that indicates the synchronization status of the mobile app. It's always visible in the main app navigation on Windows, iOS, and Android devices. Find out at a glance whether your app connects to the network, a sync is in progress, or if there are sync errors. When you select the offline sync icon, the [**Device Status** page](/power-apps/mobile/offline-sync-icon#device-status-page) opens providing more details.

If the application detects the network isn't suitable for online activity, the message "Network or Service Unavailable" appears. The client won't sync new data and some network-dependent areas of the application won't work. For example, maps or Dataverse searches that depend on device connectivity. The following events determine network detection, which might result in the error message:

- Application boots into offline mode prior to detecting network availability.
- Application network check fails with no response or a response that takes too long.

## Data removal from the mobile device

At certain points following a sync, data that no longer meets the offline profile filter criteria might be removed from the mobile device. Data removal is most common in two instances:

- Following the completion of the first sync, the application changes to offline mode and shows only data that matches the mobile offline profile and the filters applied to the view. Depending on the filters of the mobile offline profile, a frontline worker might find some records removed from their view when the application changes from online to offline mode. For example, while online they might see all past *Bookable Resource Bookings*, but after moving to offline mode, they see only bookings that start today or in the future.

- After an incremental sync while the user is already offline, data that doesn't meet filters of the mobile offline profile might be removed. For example, if the mobile offline profile filters all completed *Bookable Resource Bookings*, a newly completed booking gets removed from the agenda following a sync and is no longer accessible in the mobile application.

If a user is actively viewing a record that is removed from the mobile offline database, they see a **Record Not Found** error. If this error appears frequently, we recommend you review the filters to ensure they aren't overly restrictive for key scenarios.

If the mobile application is reconfigured, the offline database on the device is cleared.

## Next steps

- [Configure the mobile offline profile](mobile-power-app-system-offline-setup.md)
- [Mobile offline capabilities](mobile-power-app-system-offline.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
