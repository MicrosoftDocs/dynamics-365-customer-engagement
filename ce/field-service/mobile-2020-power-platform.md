---
title: "Dynamics 365 Field Service mobile apps | Microsoft Docs"
description: Learn about the two Field Service mobile apps and when to use each one.
ms.date: 06/04/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-field-service
ms.subservice: field-service-mobile
ms.topic: overview
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

# Implement the Field Service (Dynamics 365) mobile app for your technicians

Field service technicians often need to see and update their work orders while onsite at a job.

There are currently two mobile apps available for technicians who use Dynamics 365 Field Service:

> [!div class="mx-imgBorder"]
> ![Device render showing side-by-side screenshots of the two Field Service mobile apps in the app store.](./media/mobile-2020-app-store-compare.png)

- Field Service (Dynamics 365), shown to the left in the preceding image, is built on Microsoft Power Platform. In our documentation, we refer to this app as the **Field Service (Dynamics 365) mobile app**. This mobile app is recommended.

- Field Service Mobile, shown to the right in the image, is built on the Xamarin platform. In our documentation, we refer to this app as **Field Service Mobile (Xamarin)**. This mobile app will be supported until June 2022.

Both the Field Service (Dynamics 365) mobile app _and_ Field Service Mobile (Xamarin) are included with Field Service.

## Implementation and migration

We recommend using the Field Service (Dynamics 365) mobile app to benefit from the new features and continuous investments in the platform, and to avoid future migration, which must occur by June 2022. To learn about existing and upcoming capabilities for the two apps, refer to the feature comparison table later in this article.

While the new Field Service (Dynamics 365) mobile app continues to evolve, we'll continue to make available and support the current Field Service Mobile (Xamarin) app. By June 2021, new deployments must use the Field Service (Dynamics 365) mobile app; support for the current Field Service Mobile (Xamarin) app will end June 2022.

## Feature comparison: Field Service (Dynamics 365) mobile app vs. Field Service Mobile (Xamarin)

Use the following feature comparison table to understand which mobile app is right for your business.


| Feature | Category | Field Service (Dynamics 365) mobile app | Field Service Mobile (Xamarin) | Details |
| --- | --- | --- | --- | --- |
| Mobile platform |  | iOS, Android | iOS, Android, Windows | Not applicable |
| Camera capture (photo + video) | Technician | Yes | Yes | Not applicable |
| Barcode scanning | Technician | Yes | Yes | Not applicable |
| Offline data | Technician | Yes | Yes | Not applicable |
| Calendar view | Technician | Yes | Yes |  Not applicable |
| Driving directions | Technician | Yes | Yes | Not applicable |
| Speech to text | Technician | Yes | Yes | Not applicable |
| Geocoding | Technician | Yes | Yes | Not applicable |
| [Microsoft Intune](field-service-mobile-intune.md)  | Integration | Yes | Yes | Not applicable |
| Time entry  | Technician | Yes | Yes | Not applicable |
| Connected Field Service and IoT alerts | Technician | Yes | Yes | Not applicable |
| [Inspections](inspections.md) | Technician | Yes | Yes | A Field Service technician can find and capture inspections associated with a work order. |
| [Dynamics 365 Remote Assist](/dynamics365/mixed-reality/remote-assist/overview-hololens) | Integration | Yes | Yes | You can get help from remote collaborators with integrated Dynamics 365 Remote Assist. |
| [Push notifications](mobile-push-notifications.md) | Technician | Yes | Yes | You can send user notifications, such as a new booking appointment and other out-of-the-box triggers. |
| [Geofencing](geofencing.md) | Technician | Yes | Yes | You can automatically set booking status as a technician arrives or leaves a location. |
| Reporting | Technician | Yes | Yes | You can generate customer service reports with a signature, with the option to email a PDF. |
| Scan to find asset (Global search) | Technician | Yes | Yes | Not applicable |
| [Location sharing and auditing](./geofencing.md#step-3-enable-location-auditing-for-the-field-service-mobile-app) | Admin | Yes | Yes | You can enable real-time sharing of the technician's location with the back office. |
| Enhanced offline sync filters | Admin | Yes | Yes | These are offline by default, and the data available offline can be customized (for example, by location or by accounts for scheduled bookings). |
| Offline by default | Technician | Yes | Yes | The app is offline by default, so the technician is always ready. |
| Allow technician to force data sync | Technician | Yes | Yes | The technician can manually force data sync. |
| Bulk-add users  | Admin | Yes| Yes | You can quickly assign an offline data sync profile to users. |
| Checklist for service tasks  | Technician | Yes | Yes | Use a checklist to quickly mark a task as complete. |

Check [release plans](/dynamics365/release-plans/) to stay up to date on upcoming features for Field Service, including the Field Service (Dynamics 365) mobile app.

## Planning for your deployment

Here are a few more planning tips to help with your project:

**Do user acceptance training**. Ensure buy-in across your organization by bringing the people who will be using the app into the release process early. Select a diverse set of users across geographies or business units. Set up feedback channels to understand pain points and address problems before going live.

**Do a phased roll out**. Reduce risk by segmenting your release over phases; commonly this is done by geography, or by business group. Take feedback from users and expand the deployment once stable.

**Pilot the mobile apps side by side**. If you're a current customer of Field Service, you can pilot the new Field Service (Dynamics 365) mobile app alongside the Field Service Mobile (Xamarin) app, as well as other Field Service apps your organization might be using. This will help you assess how your frontline workers are currently using the apps, like what data is most important and what information is most commonly viewed and edited. You'll better understand what functionality to include in the new Field Service (Dynamics 365) mobile app.

**Measure performance**. How the mobile app performs is a big factor in how much frontline workers enjoy using the app. Add performance measures to the deployment plan and test how editing forms, the mobile offline profile, and workflows affect app performance. Take feedback from users to determine what is necessary and what can be removed or hidden from forms.


### See also

- [What are model-driven apps in Power Apps?](/powerapps/maker/model-driven-apps/model-driven-app-overview)
- [5 tips for implementing the Field Service (Dynamics 365) mobile app](https://cloudblogs.microsoft.com/dynamics365/it/2021/04/21/5-tips-for-implementing-the-field-service-dynamics-365-mobile-app/)
- [Enable entities for mobile offline synchronization](/dynamics365/mobile-app/setup-mobile-offline-for-admin#step-1-enable-entities-for-mobile-offline-synchronization)



[!INCLUDE[footer-include](../includes/footer-banner.md)]
