---
title: Configure offline data synchronization
description: Learn how offline data is synchronized to the server in the Dynamics 365 Field Service mobile app.
ms.date: 09/13/2024
ms.topic: conceptual
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Configure offline data synchronization

After the offline profile is set up and data is downloaded to the mobile device for the first time, the mobile app always runs [offline-first](/power-apps/mobile/mobile-offline-overview). Prioritizing offline use optimizes the app's performance. It also creates a consistent experience for field technicians as they move through areas with and without an Internet connection.

## Sync intervals

Sync intervals define how often data automatically syncs on users' devices. They can be as short as five minutes or as long as one day. With variable sync intervals, administrators have greater control over data sync and can help improve app performance. Records that change often can sync more often, and records that don't change as often don't need to sync as often.

The default offline profile, **Field Service Mobile - Offline Profile**, has predetermined sync intervals for each record type, based on typical usage patterns.

A sync is initiated only when the app is active and the device is connected to the Internet. On Android and iOS devices, after the sync is initiated, it can complete even if the [app is in the background](/power-apps/mobile/sync-data-offline-background).

Dependencies that are based on selected relationships and custom filters that include related tables are analyzed during each sync request. A sync interval for a table might not be respected if a related table has a lower sync interval.

## Sync settings and online mode (preview)

Admins can [enable more sync settings](/power-apps/mobile/offline-sync-icon#offline-sync-settings-preview) for end users to provide more control over the sync experience. For example, an option to sync only when the device is connected to a Wi-Fi network.

Admins can also [activate online mode](/power-apps/mobile/offline-sync-icon#online-mode-preview) to have devices load data from the server as long as there's network connection. Users can change back to offline mode when the network connection is lost to seamlessly continue their work.

## Sync conflicts

Sync conflicts happen if there's a mismatch between data on the device and data on the server. That can happen when a field technician and a dispatcher edit the same work order without synchronizing their changes. The system doesn't know which modification to apply to the record because it gets conflicting information.

Conflicts happen at the table level, not the field level. For example, if a field technician changes the *Start Time* of a work order and a dispatcher changes the *End Time*, that's a conflict. The system doesn't try to merge changes field by field. Instead, it looks at the entire record and tries to determine which one to keep.

Conflicts are resolved based on what the administrator selects for the **Set conflict detection for mobile offline synchronization** setting. This setting is available in the [mobile client system settings](/power-platform/admin/system-settings-dialog-box-mobile-client-tab).

- **No**: The system doesn't check for conflicts when an offline device comes back online. The changes the field technician made offline "win," overwriting the changes the dispatcher made. This setting is the default.

- **Yes**: The system checks for conflicts when an offline device comes back online. The changes the dispatcher made "win," overwriting the changes the field technician made offline. The field technician might see a sync conflict error.

[Learn more about working offline](/power-apps/mobile/work-offline-mode-classic).

Administrators can view past sync errors by going to **Settings** > **Sync Errors**.

## Sync notifications

Users receive an in-app notification when:

- The app is downloading data during the initial sync.
- The user selects **Refresh** on a table.
- A large incremental sync runs after the app hasn't been used for a while.

The notifications appear while the sync is in progress. After a large incremental sync is finished, the user can refresh the view to get the latest updates.

:::image type="content" source="../media/syncnotifications.png" alt-text="Renderings of three device screens, each with one of the three types of sync notifications highlighted.":::

## View offline sync status

The **Offline Status** page in the app shows the last date and time that synced tables were updated.

The [offline sync icon](/power-apps/mobile/offline-sync-icon) shows the sync status of the mobile app itself. It's always visible in the main app navigation on Windows, iOS, and Android devices. Know at a glance whether your app is connected to the network, a sync is in progress, or there are sync errors.

To view details, select the offline sync icon to open the [**Device Status** page](/power-apps/mobile/offline-sync-icon#device-status-page).

If the app detects a weak or no network connection, the message "Network or Service Unavailable" appears. The app doesn't sync new data, and some network-dependent features of the app, such as maps or Dataverse searches, don't work. The following events can cause the app to display this message:

- The app boots into offline mode before it detects the network's availability.
- The app's network check gets no response or the response takes too long.

## Data removal from the mobile device

After a sync, data that no longer meets the offline profile filter criteria might be removed from the mobile device. Data removal is most common in two instances:

- After the first sync. For example, a field technician might see all past bookings while online, but after moving to an area without connectivity, see only bookings that start today or in the future.

- After an incremental sync. For example, if the mobile offline profile filters out completed bookings, a newly completed booking is removed from the agenda after a sync and no longer accessible in the app.

If a user is viewing a record that's removed from the mobile offline database, the app shows a **Record Not Found** error. If this error appears frequently, we recommend you review the filters to make sure that they aren't overly restrictive.

If the mobile app is reset, the offline database on the device is cleared.

## Next steps

- [Configure the mobile offline profile](set-up-offline-profile.md)
- [Mobile offline capabilities](work-offline.md)

[!INCLUDE [footer-include](../../includes/footer-banner.md)]
