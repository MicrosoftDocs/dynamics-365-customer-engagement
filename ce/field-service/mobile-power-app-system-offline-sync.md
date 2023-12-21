---
title: Offline data synchronization
description: Learn how offline data is synchronized to the server for the Dynamics 365 Field Service mobile app.
ms.date: 12/18/2023
ms.topic: conceptual
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Offline data synchronization

After configuring the offline profile and the initial sync of downloading data, the mobile app always runs [offline-first](/power-apps/mobile/mobile-offline-overview). This functionality optimizes performance and creates a consistent experience for frontline workers as they move through areas with and without internet connection.

## Sync intervals

Sync intervals define how often record type data will automatically sync down to the users' devices. Sync intervals can be a minimum of five minutes or as long as one day. Records that change frequently can have a short duration sync interval, while infrequently changed records don't need to sync as often. With variable sync intervals, administrators have greater control over data and can help improve sync performance.

The default **Field Service Mobile - Offline Profile** has predetermined sync intervals for each record type, based on typical usage patterns of those record types.

A synch is only initiated when there is connectivity and when the app is actively running on the user’s mobile device. For Android devices, once the sync is initiated, it can be completed even when the app is in the background.
Dependencies based on selected relationships and custom filters that include related tables are analyzed at each sync request. A sync interval for a table may not be respected if there is a related table with a lower sync interval.

<!--- Can we take this note out?

> [!NOTE]
> Sync intervals are defined per record type with Field Service v8.8.40+. In earlier versions, all record types will have a five-minute sync interval.

--->

## Sync conflicts

Sync conflicts happen if there's a mismatch between data on the device and data on the server. For example, when a frontline worker and a dispatcher edit the same work order without synchronizing the changes. The system won't know which modification to apply to the record because it gets conflicting information.

You can resolve conflict errors based on the settings set by the administrator. Conflicts happen at the table level and not per field.

<!--- Is this still accurate? See https://learn.microsoft.com/en-us/power-platform/admin/system-settings-dialog-box-mobile-client-tab --->

To set conflict detection, go to **Settings** > **Mobile Offline** > **Mobile Offline Settings** and the **Mobile Client** tab.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service settings showing the mobile offline menu option.](./media/mobile-powerapp-sync-conflict-navigate.png)

- **No**: Data on the client device (mobile app) wins and there will be no sync errors. This setting is the default.

- **Yes**: Data on the server wins. The technician using the app may see errors informing them of conflict. In this case, while syncing changes to the server, you might see that resolved automatically. Server values can overwrite client changes. In this case, while syncing changes to the server, the technician using the application may see errors informing them of conflict.

> [!div class="mx-imgBorder"]
> ![Screenshot of system settings for Dynamics 365 showing the conflict detection setting.](./media/mobile-powerapp-sync-conflict.png)

Administrators can view past sync errors by going to **Settings** > **Sync Error**.

## View offline sync status

The Field Service mobile app provides an [offline sync icon](/power-apps/mobile/offline-sync-icon) that indicates the synchronization status of the mobile app. It's always visible in the main app navigation on Windows, iOS, and Android devices. Find out at a glance whether your app connects to the network, a sync is in progress, or if there are sync errors. When you select the offline sync icon, the [**Device Status** page](/power-apps/mobile/offline-sync-icon#device-status-page) opens providing more details.

You can [control when synchronizations are triggered](/power-apps/mobile/offline-sync-icon#offline-sync-settings).

## Data removal from the mobile device

At certain points following a sync, data which no longer meets the offline profile filter criteria might be removed from the mobile device. Data removal is most common in two instances:

<!--- Do we need all this info? --->

1. When the user of the mobile offline profile first signs in to the mobile application, it behaves as if it is in online mode until the first sync completes. During this time, data presented to the user is only restricted based on view filters. Following the completion of the first sync, the application changes to offline mode and shows only data that matches the mobile offline profile and the filters applied to the view.   Depending on the filters of the mobile offline profile, a frontline worker may find some records removed from their view when the application changes from online to offline mode. For example, while online they may see all past *Bookable Resource Bookings*, but after moving to offline mode bookings that start today or in the future.

2. After an incremental sync while the user is already offline, data which does not meet filters of the mobile offline profile might be removed. For example, if the mobile offline profile filters all completed *Bookable Resource Bookings*, a newly completed booking gets removed from the agenda following a sync and is no longer accessible in the mobile application.

If a user is actively viewing a record which is removed from the mobile offline database, they see a **Record Not Found** error. If this is a frequent occurrence, we recommend to review the filters to ensure they are not overly restrictive for key scenarios.