---
title: Field Service (Dynamics 365) mobile Public Preview overview
description: Learn about the Public Preview features of the Field Service (Dynamics 365) mobile app.
ms.date: 06/26/2023
ms.topic: overview
ms.subservice: field-service-mobile
author: andrea-orimoto
ms.author: andreo
---

# Field Service (Dynamics 365) mobile app Public Preview

## Public Preview availability

In August 2023, we’re introducing the preview of a **new Dynamics 365 Field Service mobile experience for frontline technicians** to swiftly access all the information they need on the go. This modern user experience supports familiar mobile navigation, gestures and controls to streamline managing work order Tasks, Services, and Products. 

From changing the status of a booking with a quick swipe to accessing driving directions to a customer site with one tap, the redesign saves valuable technician time for daily work – cutting down the number of taps for key tasks in half. Technicians can not only easily pick, change, or complete work order details, but also add notes with multiple inline images. 

Technicians who need additional support can now also use **Dynamics 365 Guides** embedded in Field Service mobile. Embedded Guides in Field Service provide technicians with step-by-step guided instructions, pictures, and videos explaining the immediate task. [Learn more about Guides.](https://aka.ms/fs-guides-mobile) 

> [Add link to this video](https://microsoft-my.sharepoint.com/:v:/p/marewa/EaKlFvr-Pt1BiLOJiy0ylM8Bv1AaRnCv-vCt0-JfZJQEvA?e=ATavzi)

## Public Preview content in the docs

Once enabled by your administrator, the Public Preview features are accessible directly in the GA app on top of the current features and screens, you don't need to download a different app. To learn more about these new features you can navigate these docs and find the specific Public Preview content alongside the current content in dedicated tabs.

Here's a list of documents that contain specific Public Preview content.

| Document | 
| --- | 
| [Download the mobile app and get started](download-get-started-mobile-app.md) | 
| [Complete work orders on the mobile app](get-work-done-mobile-app.md) |
| [Access related apps form the Field Service mobile app](access-related-apps-mobile-app.md) |

## Enabling the Public Preview features (admin)

To enable the Field Service Mobile Public Preview features for your organization's technicians, you need to log in as an administrator to Dynamics 365 and then select the **Field Service Mobile** app from the list of all installed apps in your organizations.

Once the Filed Service Mobile app screen loads, click on the bottom left menu and select **Settings**. Finally use the toggle to enable or disable the Public Preview features for all users within the organization.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Field Service Mobile app settings page and toggle to enable/disable the Public Preview features](./media/mobile-public-preview-enable-toggle.png)

## Public Preview features limitations

The public preview features currently have the following limitations:
- Offline is not supported. In order to properly experience the new Public Preview features, please disable the offline profile.
- All Field Service Mobile customizations described [here](field-service-customizations.md) are not supported and will not work in Public Preview.
- Language. The new Public Preview features respect the mobile device language settings, while the current app respects the language settings in the user profile. This might cause a mixed language experience if the two settings are out of sync.

## Public Preview Support

If you run into issues with the FSM Public Preview please use the "Send feedback" feature in the left navigation menu of the app itself, this will send an email to our team with logs attached to it. If there is a more serious failure, then please submit a support request through your [usual channels](field-service-get-help.md).

## Next steps

- [Install and set up the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
