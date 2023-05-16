---
title: Work offline or with limited connectivity
description: Learn how to work offline and what you need to keep in mind.
ms.date: 06/20/2023
ms.topic: article
ms.subservice: field-service-mobile
author: josephshum-msft
ms.author: jshum
---

# Work offline or with limited connectivity


## Work offline and update offline data

If you expect to be performing work in areas without internet access, you can download important information to your device to keep working.

Consider a scenario where a technician needs to work in the basement of an industrial complex. They'll often have limited or no internet connectivity. Working offline will download their work orders, notes, service tasks, and pictures for use without connectivity. Once connectivity is restored, new data is automatically synced back to the server. This process happens without interruption to the technician's experience.

Upon sign-in, the app will download important Field Service information as defined by system administrators.

> [!div class="mx-imgBorder"]
> ![Devices with the Field Service (Dynamics 365) mobile app, showing the offline status.](./media/mobile-2020-offline-downloading2.png)

When the **Status** is set to **Available**, you'll have all the data you need to work offline.

> [!NOTE]
> When the technician has internet connectivity, data on the device is automatically refreshed every five minutes or as configured in their mobile offline profile.

Technicians can also **Update offline data** manually by going to the home screen, selecting the offline icon in the bottom left, then selecting the **Update offline data** option.

> [!div class="mx-imgBorder"]
> ![Devices with the Field Service (Dynamics 365) mobile app, showing how to get to the update offline data option.](./media/mobile-2020-offline-update-offline-data2.png)

Technicians may also want to sync specific views when they have internet connectivity. For instance:

- The technician wants to check for new bookings on their calendar before starting to drive.
- The technician wants to check for updates on a work order made by other crew members.

To sync specific views, select **Refresh** from the app's bottom menu. For example, you can refresh bookings by selecting the **Refresh** option, shown in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Devices showing Field Service (Dynamics 365), with attention to the refresh option.](./media/mobile-2020-offline-refresh.png)

For more information, see this article: [Offline data and Sync Filters](mobile-power-app-system-offline.md).



[!INCLUDE[footer-include](../includes/footer-banner.md)]
