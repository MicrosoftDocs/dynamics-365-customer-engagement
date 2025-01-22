---
title: Work offline and update offline data
description: Learn how to work offline and what you need to keep in mind.
ms.date: 01/15/2025
ms.topic: conceptual
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Work offline and update offline data

To work in areas without internet access, the app downloads important information to the mobile device for a seamless experience. When the device connects to the internet, data automatically syncs with the server.

An administrator has to configure the offline profile for the app before technicians can download the data. Administrators [define which data is available offline](set-up-offline-profile.md) and [how often the app looks for changes on the server](offline-data-sync.md).

When you first log into the mobile app, synchronization occurs and data is downloaded. Downloading the offline data can take some time. A banner shows the progress of the sync. The **offline sync** or globe icon shows the sync status. For more information, go to [View offline sync status](/power-apps/mobile/offline-sync-icon).

Synchronization occurs automatically, but you can manually synchronize if needed. You can initiate a full sync or sync a particular view.

- To initiate a full sync, select the **offline sync** or globe icon and then **Check for updates**.

- To initiate a sync on a specific view, select **More** > **Refresh**.

> [!NOTE]
> The [new mobile experience](do-work-newux.md) doesn't support working offline.

## Next steps

- [Set up the mobile offline profile](set-up-offline-profile.md)
- [Configure offline data synchronization](offline-data-sync.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
