---
title: Configure offline data synchronization
description: Learn how offline data is synchronized to the server in the Dynamics 365 Field Service mobile app.
ms.date: 12/08/2025
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Configure offline data synchronization

After the offline profile is set up and data is downloaded to the mobile device for the first time, the mobile app runs [offline-first](/power-apps/mobile/mobile-offline-overview). Prioritizing offline use optimizes the app's performance and creates a consistent experience for field technicians as they move through areas with and without an Internet connection.

To define how often data automatically syncs on the user's mobile device, [set sync intervals](#set-sync-intervals). To define how much control the user has in synchronizing their data, [set offline sync settings](#set-offline-sync-settings).

For a guided walkthrough, check out the following video.

>
> [!VIDEO 02bf237b-8c58-4513-bd4e-1c66b7163793]

## Set sync intervals

Sync intervals define how often data automatically syncs on users' devices. They can be as short as five minutes or as long as one day. Records that change often can sync more often, and records that don't change as often don't need to sync as often.

The default offline profile, **Field Service Mobile - Offline Profile**, contains set sync intervals for each record type, based on typical usage patterns. You can update the sync intervals for individual tables.

For example, if customer accounts are updated once a day in your organization, change the sync frequency on the Accounts table to every day.

1. Sign in to Power Apps at [https://make.powerapps.com/](https://make.powerapps.com/), and select your environment.

1. Select **Apps**, and then open **Field Service Mobile**.

1. Select **Settings**, and then select the **General** tab.

1. Under **Select offline mode and profile**, select your organization's mobile offline profile or **Field Service Mobile - Offline Profile** if you're using the default.

1. Select the ellipsis (**&hellip;**) and **Edit selected profile**.

1. Select a table, and then select **Edit**.

    :::image type="content" source="../media/fs-mobile-power-apps-offline-table-edit.png" alt-text="Screenshot of the Bookable Resource Booking table offline data settings in the Field Service mobile app offline profile.":::

1. Select the sync frequency and save. Based on our example, select one day.

1. Repeat for other tables, if needed.

1. Save and publish the offline profile.

The app starts a sync only when it's active and the device is connected to the Internet. On Android and iOS devices, after the sync starts, it can finish even if the [app is in the background](/power-apps/mobile/sync-data-offline-background).

The app analyzes dependencies based on selected relationships and custom filters that include related tables during each sync request. The app might not respect a table's sync interval if a related table has a lower sync interval.

## Set offline sync settings

If your frontline workers work for long periods without syncing or have limited data capacity in their cellular plans, consider letting them control their own sync settings. For example, let users choose:

- Whether sync happens only when connected to a Wi-Fi network.

- Whether they sync on demand instead of automatically.

- Whether to use the app in online mode when connected to a network.

These settings help save mobile device bandwidth and battery life when technicians work in areas with poor cellular connectivity. To update these settings:

1. Access the mobile offline profile in Power Apps at [https://make.powerapps.com/](https://make.powerapps.com/).

1. Select **Settings** and then the **Features** tab.

1. Update the following sync settings based on your business needs. Learn more in [Define sync settings](/power-apps/mobile/setup-mobile-offline#define-sync-settings-on-mobile) and [Turn on online mode](/power-apps/mobile/setup-mobile-offline#turn-on-online-mode).

    - **Allow users to adjust sync frequency**: **On** lets users adjust the sync interval to sync more or less often depending on their needs.
    - **Allow users to sync on Wi-Fi only**: **On** lets users sync only when connected to a Wifi network. This setting is recommended in cases when technicians are working on a metered or limited cellular bandwidth network.
    - **Allow users to work in online mode**: **On** lets users work in online mode. While working in online mode, the app continues to sync data with the server so it's ready for use if network connection is lost. Learn more at [Introducing Online Mode](https://www.microsoft.com/en-us/dynamics-365/blog/it-professional/2025/08/25/go-beyond-offline-introducing-online-mode-for-field-service-mobile/?msockid=2f67332eb2186b5d13332179b61865c9).

1. Select **Save**.

## View sync notifications

Mobile users receive an in-app notification when:

- The app downloads data during the initial sync.
- The user selects **Refresh** on a table.
- A large incremental sync runs after the app isn't used for a while.

The notifications appear while the sync is in progress. After a large incremental sync finishes, the user can refresh the view to get the latest updates by selecting **More** > **Refresh**.

:::image type="content" source="../media/syncnotifications.png" alt-text="Renderings of two device screens, each with one of the two types of sync notifications highlighted.":::

## View offline sync status

The **Offline Status** page in the mobile app shows the last date and time that synced tables updated.

The [offline sync (globe) icon](/power-apps/mobile/offline-sync-icon) shows the sync status of the mobile app. It's always visible in the main app navigation on Windows, iOS, and Android devices. You can see at a glance whether your app is connected to the network, a sync is in progress, or there are sync errors.

To view details, select the offline sync icon to open the [**Device Status** page](/power-apps/mobile/offline-sync-icon#device-status-page).

If the app detects a weak or no network connection, the message "Network or Service Unavailable" appears. The app doesn't sync new data, and some network-dependent features of the app, such as maps or Dataverse searches, don't work. These events can cause the app to display this message:

- The app boots into offline mode before it detects the network's availability.
- The app's network check gets no response or the response takes too long.

## View sync conflicts

Sync conflicts happen if there's a mismatch between data on the device and data on the server. For example, a conflict occurs when a field technician and a dispatcher edit the same work order without syncing their changes. The system doesn't know which change to apply to the record because it gets conflicting information.

Conflicts happen at the table level, not the field level. For example, if a field technician changes the *Start Time* of a work order and a dispatcher changes the *End Time*, that's a conflict. The system doesn't try to merge changes field by field. Instead, it looks at the entire record and decides which one to keep.

The app resolves conflicts based on what the admin selects for the **Set conflict detection for mobile offline synchronization** setting. You can find this setting in the [mobile client system settings](/power-platform/admin/system-settings-dialog-box-mobile-client-tab).

- **No**: The app doesn't check for conflicts when an offline device comes back online. The changes the field technician made offline "win," overwriting the changes the dispatcher made. This setting is the default.

- **Yes**: The app checks for conflicts when an offline device comes back online. The changes the dispatcher made "win," overwriting the changes the field technician made offline. The field technician might see a sync conflict error.

Administrators can view past sync errors by going to **Settings** > **Sync Errors**.

[Learn more about working offline](/power-apps/mobile/work-offline-mode-classic).

## Analyze telemetry for offline synchronization

Use data from offline sync events to check the health and performance of offline sync.

Set up an [Application Insights](/azure/azure-monitor/app/app-insights-overview) environment to get telemetry on diagnostics and performance. Enable or disable the telemetry feed at any time.

For detailed information about the data you can get, go to [Telemetry events for mobile app synchronization and actions](/power-platform/admin/telemetry-events-mobile). For a sample, go to [Sample telemetry dashboard for Field Service mobile app offline profile usage](/dynamics365/guidance/resources/field-service-mobile-sample-telemetry).

## Data removal from the mobile device

After a sync, the app removes data from the mobile device if it no longer meets the offline profile filter criteria. Data removal is most common in two cases:

- After the first sync. For example, a field technician might see all past bookings while online, but after moving to an area without connectivity, sees only bookings that start today or in the future.

- After an incremental sync. For example, if the mobile offline profile filters out completed bookings, a newly completed booking is removed from the agenda after a sync and isn't accessible in the app.

If a user views a record that's removed from the mobile offline database, the app shows a **Record Not Found** error. If this error appears often, check the filters to make sure they aren't too restrictive.

If you reset the mobile app, the app clears the offline database on the device.

## Next steps

- [Configure the mobile offline profile](set-up-offline-profile.md)
- [Mobile offline capabilities](work-offline.md)

[!INCLUDE [footer-include](../../includes/footer-banner.md)]
