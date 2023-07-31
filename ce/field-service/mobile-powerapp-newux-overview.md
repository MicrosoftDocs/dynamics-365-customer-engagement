---
title: Field Service (Dynamics 365) mobile app new UX (preview)
description: Learn about the redesigned user experience of Field Service (Dynamics 365) mobile app for managing bookings and work orders.
ms.date: 07/30/2023
ms.topic: overview
ms.subservice: field-service-mobile
author: andrea-orimoto
ms.author: andreo
---

# Field Service (Dynamics 365) mobile app new UX (preview)

## Preview availability

This document relates to the new user experinece features in the Dynamics 365 Field Service mobile app for service technicians to swiftly access all the information they need on the go. This modern user experience supports familiar mobile navigation, gestures and controls to streamline managing work order Tasks, Services, and Products. 

From changing the status of a booking with a quick swipe to accessing driving directions to a customer site with one tap, the new user experience saves technicians valuable time for daily work. Technicians can not only easily pick, change, or complete work order details, but also add notes with multiple inline images. 

Technicians who need additional support can now also use Dynamics 365 Guides embedded in Field Service mobile. Embedded guides in Field Service provide technicians with step-by-step guided instructions, pictures, and videos explaining the immediate task. [Learn more about Guides.](https://aka.ms/fs-guides-mobile) 

> [Add link to this video](https://microsoft-my.sharepoint.com/:v:/p/marewa/EaKlFvr-Pt1BiLOJiy0ylM8Bv1AaRnCv-vCt0-JfZJQEvA?e=ATavzi)

## Preview content in the docs

Once enabled by your administrator, the preview features are accessible directly in the existing Field Service mobile app available in the app stores. Technicians do not need to download a new app and organizations do not need to perform any migration. To learn more about these new features you can navigate these docs and find the specific preview content alongside the current content in dedicated tabs.

Here's a list of documents that contain specific preview content.

| Document | 
| --- | 
| [Download the mobile app and get started](download-get-started-mobile-app.md) | 
| [Complete work orders on the mobile app](get-work-done-mobile-app.md) |
| [Access related apps form the Field Service mobile app](access-related-apps-mobile-app.md) |

## Enabling the Preview features (admin)

To enable the Field Service Mobile Preview features for your organization's technicians, you need to log in as a **Field Service Administrator** to Dynamics 365 in a web browser and then select the **Field Service Mobile** app from the list of all installed apps in your organizations.

Once the Filed Service Mobile app screen loads, click on the bottom left menu and switch the area to **Settings**. From there, use the toggle to enable or disable the preview features for all users within the organization.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Field Service Mobile app settings page and toggle to enable/disable the Preview features](./media/mobile-preview-enable-toggle.png)

## Limitations of preview features

The preview features currently have the following limitations:
- Offline mode is not supported. Any user who is enabled for offline will not see the new features and see the existing UCI based experiences only. In order to properly experience the new preview features, please disable the offline profile.
- In preview, the new UX is currently not customizable. Field Service Mobile customizations described [here](field-service-customizations.md) are not supported and will not work in the new UX. However, the customized model-driven app experiences (such as custom forms and business logic) will continue to be accessible through an icon on the top right of the new UX, allowing users to switch back and forth.
- The new preview features respect the mobile device language settings, while the current app respects the language settings in the user profile. This might cause a mixed language experience if the two settings are out of sync.

## Preview Support

During the preview period, there is limited support for this feature and it is not recommended to be enabled for production usage. If you run into issues with this preview, please use the "Send feedback" feature in the left navigation menu of the app itself, this will send an email to our team with logs attached to it. For additional help, please submit a support request through your [usual channels](field-service-get-help.md).

## Next steps

- [Install and set up the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
