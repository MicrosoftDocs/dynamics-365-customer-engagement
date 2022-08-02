---
title: "Field Service (Dynamics 365) app for Windows 10+ devices (contains video) | MicrosoftDocs"
description: Learn about the Field Service (Dynamics 365) app for Windows 10+ devices.
ms.date: 10/01/2021
ms.reviewer: krbjoran
ms.subservice: field-service-mobile
ms.topic: article
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: JonBaker007
ms.author: jobaker
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Field Service (Dynamics 365) app for Windows 10+ devices

Built on Microsoft Power Platform as a model-driven app, the Field Service (Dynamics 365) Windows app is built for frontline workers using Microsoft Surface laptops, Surface duos, and other Windows devices running Windows 10 or Windows 11.

> [!div class="mx-imgBorder"]
> ![Field Service native app on a Windows device.](./media/mobile-2020-windows-agenda-view.jpg)


The Field Service (Dynamics 365) Windows app supports most common features as iOS & Android versions, including [offline mode](mobile-power-app-system-offline.md), for a consistent cross-platform experience. 

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWNWjN]

## Prerequisites

Device requirements:

- Windows 10 or 11
- A device with minimum 3-GB RAM and 64-GB storage.

For additional system requirements, see: [System requirements for the Field Service (Dynamics 365) mobile app](mobile-power-app-system-requirements.md)

Also, be sure to [review installation and set up of the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md) 


## Download the app

[Download from Windows store](https://aka.ms/fsmobile-windows10) or simply search for **Field Service (Dynamics 365) **.

Download the app named **Field Service (Dynamics 365) app**.
 
Open the app and sign in with your username and password, which should be the credentials of a frontline worker user who has the _Field Service - Resource_ security role.

> [!div class="mx-imgBorder"]
> ![Launch screen for the Field Service Windows app.](./media/mobile-2020-windows-login-screen.jpg)

>[!Note]
> To access non-product environments, enable non-production apps from settings.
 
## View bookings

You can access your bookings from the **Home** screen or **Bookings** screen. On the bookings screen, you have the option to view bookings on an agenda, day, week, month, or [map view](mobile-powerapp-booking-maps.md). You can [customize the agenda view](/mobile-powerapp-customize-booking-calendar.md) in the same way as iOS and Android apps.
 
> [!div class="mx-imgBorder"]
> ![Bookings agenda view in the Field Service Windows app.](./media/mobile-2020-windows-agenda-view.jpg)

Selecting a booking will open the record, where you can then change status, complete service tasks (including inspections), and attach notes to the timeline.

> [!div class="mx-imgBorder"]
> ![An open booking record in the Field Service Windows app.](./media/mobile-2020-windows-booking-form-with-status-dropdown.jpg)

## Capture pictures

When adding a note to the timeline, you can also attach a picture by selecting the camera icon, which opens the device's camera app.

> [!div class="mx-imgBorder"]
> ![The timeline tab on a booking in the Field Service Windows app.](./media/mobile-2020-windows-timeline-control-to-add-images-and-videos.jpg)
 
> [!div class="mx-imgBorder"]
> ![The camera popup after selecting the camera icon on the timeline in Field Service Windows app.](./media/mobile-2020-windows-launch-device-camera-to-capture-image.jpg)

> [!div class="mx-imgBorder"]
> ![The booking timeline, listing a capture taken from the device's camera.](./media/mobile-2020-windows-note-added-to-timeline.jpg)

## Scan barcodes

You can use the device camera to scan barcodes either for global search or for filling any field of the barcode type.

> [!div class="mx-imgBorder"]
> ![Launched barcode reader in the Field Service Windows app.](./media/mobile-2020-windows-barcode-reader-launched.jpg) 

## Download data for offline use

When enabled for [offline mode](mobile-power-app-system-offline.md), the app will automatically download offline data after you sign in. You can also force an update of the offline data from the **Offline Status** page by selecting **Update date**.
 
> [!div class="mx-imgBorder"]
> ![Offline status panel in the Field Service Windows app.](./media/mobile-2020-windows-offline.jpg)

>[!Note]
> At this time, offline is supported on devices running Windows OS 20H2 (19042.1348) and greater.

## Configuration considerations

The following capabilities *are not* available at this time. These capabilities *are* available in the iOS and Android apps.

- Quick notes photos and videos
- Access to GCC High or China cloud environment
- Search with barcode via global search
