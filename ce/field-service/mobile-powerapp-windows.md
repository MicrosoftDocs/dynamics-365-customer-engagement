---
title: "Field Service (Dynamics 365) app for Windows 10+ devices (preview) | MicrosoftDocs"
description: Learn about the Field Service (Dynamics 365) app for Windows 10+ devices.
ms.date: 10/01/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-field-service
ms.subservice: field-service-mobile
ms.topic: article
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Field Service (Dynamics 365) app for Windows 10+ devices (preview)

> [!Note]
> This feature is in public preview.

The Field Service (Dynamics 365) app is now available for Windows. This native Windows app lets frontline workers view Dynamics 365 Field Service work orders, customer assets, accounts, and contacts.

Built on Microsoft Power Platform as a model-driven app, the Field Service (Dynamics 365) Windows app is built for frontline workers using Microsoft Surface laptops, Surface duos, and other devices running Windows 10 or Windows 11.

> [!div class="mx-imgBorder"]
> ![Field Service native app on a Windows device.](./media/mobile-2020-windows-agenda-view.jpg)

The app supports offline by default and allows frontline workers using a Windows laptop or tablet to be able to use Field Service in low or no connectivity areas.

The Field Service (Dynamics 365) Windows app supports:

- Access to the device's camera, which means you can capture images and videos.
- Barcode scanning for assets and global search.
- Deep-linking into the Field Service mobile app.

## Prerequisites

Device requirements:

- Windows 10 or 11
- A device with minimum 3-GB RAM and 64-GB storage.

For additional system requirements, see: [System requirements for the Field Service (Dynamics 365) mobile app](mobile-power-app-system-requirements.md)

Also, be sure to [review installation and set up of the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md) 


## Download the app

Go to the Microsoft Store and search for **Field Service (Dynamics 365) (Preview)**.

Download the app named **Field Service (Dynamics 365) (Preview) app**.
 
Open the app and sign in with your username and password, which should be the credentials of a frontline worker user who has the _Field Service - Resource_ security role.

> [!div class="mx-imgBorder"]
> ![Launch screen for the Field Service Windows app.](./media/mobile-2020-windows-login-screen.jpg)

>[!Note]
> To access non-product environments, enable non-production apps from settings.
 
## View bookings

You can access your bookings from the **Home** screen or **Bookings** screen. Selecting a booking will open the record, where you can then change status, complete service tasks (including inspections), and attach notes to the timeline.
 
> [!div class="mx-imgBorder"]
> ![Bookings in the Field Service Windows app.](./media/mobile-2020-windows-agenda-view.jpg)

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

The app automatically downloads offline data after you sign in, though you can also force an update of the offline data by selecting **Update date**.
 
> [!div class="mx-imgBorder"]
> ![Offline status panel in the Field Service Windows app.](./media/mobile-2020-windows-offline.jpg)

## Configuration considerations

The following capabilities *are not* available in this public preview. but are planned for future releases. These capabilities *are* available in the iOS and Android apps.

- Push notifications
- Geo tracking of users
- Quick notes
- Large file and image support