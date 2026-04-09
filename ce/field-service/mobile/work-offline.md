---
title: Work offline and update offline data
description: Learn how to work offline and what you need to keep in mind.
ms.date: 10/20/2025
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Work offline and update offline data

To work in areas without internet access, the app downloads important information to the mobile device for a seamless experience. When the device connects to the internet, data automatically syncs with the server.

For a guided walkthrough, check out the following video.
>
> [!VIDEO fb3c067f-75ec-4b6d-aad0-714885351460]

To understand the mobile offline experience, first time sync, delta sync, and up sync, go to [Best Practices for Offline Mode in the Field Service mobile app – Part 1 ](https://www.microsoft.com/en-us/dynamics-365/blog/it-professional/2023/11/06/best-practices-for-offline-mode-in-the-field-service-mobile-app-part-1/).

An administrator has to configure the offline profile for the app before technicians can download the data. Administrators [define which data is available offline](set-up-offline-profile.md) and [how often the app looks for changes on the server](offline-data-sync.md).

When you first log into the mobile app, synchronization occurs and data is downloaded. Downloading the offline data can take some time. A banner shows the progress of the sync. The **offline sync** or globe icon shows the sync status. For more information, go to [View offline sync status](/power-apps/mobile/offline-sync-icon) and [Work with model-driven apps offline](/power-apps/mobile/work-in-offline-mode).

Synchronization occurs automatically, but you can manually synchronize if needed. You can initiate a full sync or sync a particular view.

- To initiate a full sync, select the **offline sync** or globe icon and then **Check for updates**.

- To initiate a sync on a specific view, select **More** > **Refresh**.

> [!NOTE]
> The [new mobile experience](do-work-newux.md) doesn't support working offline.


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
