---
title: Dynamics 365 Field Service mobile app overview
description: Learn about the Field Service mobile app, key features, and system requirements with this general overview.
ms.date: 09/14/2026
ms.topic: overview
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Dynamics 365 Field Service mobile app overview

The Dynamics 365 Field Service mobile app helps technicians manage assigned work, get directions to job sites, complete service tasks, and record work from a mobile device. When an administrator configures offline capabilities, technicians can continue to access and update work data without an internet connection.

The [app is available for Apple iOS, Google Android, and Windows 10+ devices](download-mobile-app.md). It's included in your Field Service license at no extra charge.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=78a4ad09-8320-4895-a69f-100cbf46ac14]

The mobile app is built on Microsoft Power Platform as a [model-driven app](/powerapps/maker/model-driven-apps/model-driven-app-overview), which makes it customizable to your business needs.

## For administrators

Set up and manage the mobile app for your technicians:

- [Set up the Field Service mobile app](set-up-field-service-mobile.md), including access, the mobile app module, and the refreshed mobile experience.
- [Set up the mobile offline profile](set-up-offline-profile.md) to choose tables, filters, relationships, and sync intervals.
- [Review offline-profile best practices and limitations](best-practices-limitations-offline-profile.md) before you customize the default profile.
- [Configure offline data synchronization](offline-data-sync.md) and learn how to review sync status and errors.
- [Customize the mobile app](customize-mobile-app.md) to match your organization's processes.
- [Enable push notifications](enable-push-notifications.md) for events such as new booking assignments.
- [Manage the mobile app with Microsoft Intune](app-management-intune.md) to protect organizational data and manage mobile devices.
- [Track technician location](track-technician-location.md) to help dispatchers monitor travel and arrival.
- [Configure geofencing](configure-geofencing.md) to respond when technicians enter or leave work locations.

## For technicians

Install the app and complete your assigned work:

- [Download and install the mobile app](download-mobile-app.md), and then sign in with your organizational account.
- [Use the refreshed mobile experience](do-work-newux.md) to work from the agenda, use booking quick actions, navigate the app, and manage user settings.
- [Use Unified Interface](get-work-done-mobile-app.md) to view bookings, travel to jobs, record service, add notes, track time, and create follow-up work orders.
- [Work offline and manually update offline data](work-offline.md) after an administrator enables offline capabilities. The refreshed mobile experience doesn't currently support working offline.
- [View daily bookings on a map](booking-maps.md) to plan travel between scheduled jobs.
- [Perform inspections](../inspections.md#perform-inspections-on-mobile) to capture structured service results.
- [Scan barcodes to find or populate records](scan-barcode.md) when you identify assets, equipment, or other service data.
- [Work with Connected Field Service Internet of Things (IoT) data](iot-mobile.md) to view device information, register devices, and send commands.
- [Create and run service reports](create-service-report.md) to review and share completed work.

## Troubleshoot the mobile app

Start with the following resources:

- [Troubleshoot common issues in the Field Service mobile app](/troubleshoot/dynamics-365/field-service/mobile-app/mobile-app-common-issues) to diagnose setup, synchronization, and usage problems.
- [Resolve incorrect or missing offline data](/troubleshoot/dynamics-365/field-service/mobile-app/incorrect-missing-data-offline-mode) by checking profile configuration and record filters.
- [Troubleshoot offline synchronization](offline-data-sync.md#troubleshoot-offline-sync) when synchronization doesn't finish, data is missing, or the app reports an error.
- [Resolve WebView reset errors](/troubleshoot/dynamics-365/field-service/mobile-app/webview-reset) when the app repeatedly downloads metadata updates.

For information about planned features, see [Dynamics 365 Field Service release plans](/dynamics365/release-plans/).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
