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

<!--- How do you get to this screen? --->

To set conflict detection, go to **Settings** > **Mobile Offline** > **Mobile Offline Settings** and the **Mobile Client** tab.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service settings showing the mobile offline menu option.](./media/mobile-powerapp-sync-conflict-navigate.png)

### Set conflict detection for mobile offline synchronization

- **No**: Data on the client device (mobile app) wins and there will be no sync errors. This setting is the default.

- **Yes**: Data on the server wins. The technician using the app may see errors informing them of conflict. In this case, while syncing changes to the server, you might see that resolved automatically. Server values can overwrite client changes. In this case, while syncing changes to the server, the technician using the application may see errors informing them of conflict.

> [!div class="mx-imgBorder"]
> ![Screenshot of system settings for Dynamics 365 showing the conflict detection setting.](./media/mobile-powerapp-sync-conflict.png)

Administrators can view past sync errors by going to **Settings** > **Sync Error**.

## View offline sync status

The Field Service mobile app provides an offline sync icon that indicates the synchronization status of the mobile app. It's always visible in the main app navigation on Windows, iOS, and Android devices. Find out at a glance whether your app connects to the network, a sync is in progress, or if there are sync errors.

For more information, see [View offline sync status](/power-apps/mobile/offline-sync-icon).

Additionally, you can [control when synchronizations are triggered](/power-apps/mobile/offline-sync-icon#offline-sync-settings).