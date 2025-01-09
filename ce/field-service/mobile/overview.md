---
title: Dynamics 365 Field Service mobile app overview
description: Learn about the Field Service mobile app, key features, and system requirements with this general overview.
ms.date: 01/06/2025
ms.topic: overview
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Dynamics 365 Field Service mobile app overview

Service technicians and frontline workers are the essence of any field service organization. They're the vanguard of providing excellent customer service. It's critical that frontline workers have the best digital tools that enable them to engage with their peers, the back office, and customers while staying on top of their field duties. The Field Service mobile app enables technicians and frontline workers to perform better service and achieve high first-time fix rates. The app includes offline capabilities that allow frontline workers to continue working and viewing job details even without internet access.

The [app is available for Apple iOS, Google Android, and Windows 10+ devices](download-mobile-app.md). It's included in your Field Service license at no extra charge.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=78a4ad09-8320-4895-a69f-100cbf46ac14]

The mobile app is built on Microsoft Power Platform as a [model-driven app](/powerapps/maker/model-driven-apps/model-driven-app-overview), which makes it customizable to your business needs.

In 2024, Microsoft released a refreshed user experience for parts of the mobile application. Administrators can enable the new experience for their users. For more information, see [Set up the Field Service mobile app](set-up-field-service-mobile.md).

## Feature list

| Feature | Persona  | Supported |  Details |
| --- | --- | --- |  --- |
| [Camera capture (photo + video)](get-work-done-mobile-app.md) | Technician | Yes |  Use the device camera to capture images and video. |
| [Barcode scanning](get-work-done-mobile-app.md) | Technician | Yes |  Scan bar code from global search or at a field level. |
| [Offline data](work-offline.md) | Technician | Yes |  Offline-enabled application allows you to access your data regardless of internet connectivity. |
| [Calendar view](customize-booking-calendar.md) | Technician | Yes |   Customize your calendar with data relevant for your organization. |
| [Driving directions](get-work-done-mobile-app.md#travel-to-a-job-location) | Technician | Yes | Use your favorite in-app map application for turn-by-turn directions. |
| Speech to text | Technician | Yes | Insert notes with native device speech-to-text capabilities. |
| [Microsoft Intune](app-management-intune.md)  | Integration | Yes | Provide an extra layer of device and data protection with Microsoft Intune. |
| [Time entry](get-work-done-mobile-app.md)  | Technician | Yes | In-application Time Entry enabled by default. |
| [Connected Field Service and IoT alerts](get-work-done-mobile-app.md) | Technician | Yes |  Receive IoT signals and send commands directly from your mobile app. |
| [Inspections](../inspections.md) | Technician | Yes | A Field Service technician can find and capture inspections associated with a work order. |
| [Dynamics 365 Remote Assist](/dynamics365/mixed-reality/remote-assist/overview-hololens) | Integration | Yes* | Get help from remote collaborators with integrated Dynamics 365 Remote Assist. |
| [Push notifications](enable-push-notifications.md) | Technician | Yes |  Send user notifications, such as a new booking appointment and other out-of-the-box triggers. |
| [Geofencing](configure-geofencing.md) | Technician | Yes | Automatically set booking status as a technician arrives or leaves a location. |
| [Reporting](create-service-report.md) | Technician | Yes | Generate customer service reports with a signature, with the option to email a PDF. |
| [Scan to find asset (Global search)](scan-barcode.md) | Technician | Yes |  Not applicable |
| [Location sharing and auditing](track-technician-location.md) | Admin | Yes | Enable real-time sharing of the technician's location with the back office. |
| [Enhanced offline sync filters](work-offline.md) | Admin | Yes |  Data available offline by default and the data available offline can be customized. For example, offline data available by location or by accounts for scheduled bookings. |
| [Offline by default](offline-data-sync.md) | Technician | Yes |  The app is offline by default, so the technician is always ready. |
| [Allow technician to force data sync](work-offline.md) | Technician | Yes |  The technician can manually force data sync. |
| Bulk-add users  | Admin | Yes|  Quickly assign an offline data sync profile to users. |
| Checklist for service tasks  | Technician | Yes |  Use a checklist to quickly mark a task as complete. |

For information about planned features, see [Dynamics 365 Field Service release plans](/dynamics365/release-plans/).

## Next steps

- [Install and set up the mobile app](set-up-field-service-mobile.md)
- [Set up offline data and sync filters](work-offline.md)
- [Download and install the app on a mobile device](download-mobile-app.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
