---
title: Set up the mobile app
description: Learn how to install and set up the Dynamics 365 Field Service mobile app.
ms.date: 08/28/2024
ms.topic: how-to
ms.subservice: field-service-mobile
ms.collection: get-started
author: JonBaker007
ms.author: jobaker
---

# Set up the mobile app

The Dynamics 365 Field Service mobile app is designed and optimized for technicians in the field. They can work with Field Service work orders, customer assets, accounts, and contacts. The app is built on Microsoft Power Platform as a [model-driven app](/powerapps/maker/model-driven-apps/model-driven-app-overview). You can customize it to your business needs like other [model-driven apps](/power-apps/maker/model-driven-apps/).

For a guided walkthrough, check out the following video.
>
> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4HKRL]

## Prerequisites

To use the Field Service mobile app, you need [Field Service installed](../install-field-service.md) and [set up](../field-service-get-started.md).

## Assign security roles to the Field Service mobile app

1. Go to [https://make.powerapps.com/](https://make.powerapps.com/) > **Apps** in the left pane.

1. Find the **Field Service Mobile** model-driven app and select the ellipses (&hellip;).

1. Select **Share** and assign the app to **Field Service-Resource**, **Field Service-Administrator**, or other security roles that need access to the mobile app.

:::image type="content" source="../media/assign-roles-to-app.png" alt-text="Screenshot of the Dynamics 365 list of apps, showing the Field Service mobile solution in the list.":::

## Assign mobile app users appropriate security roles

Assign Field Service users the **Field Service-Resource** security role and **Field Service-Resource** field security profile. For more information, see [Set up users, licenses, and security roles](../users-licenses-permissions.md). Alternatively, go through the [frontline worker setup](../frontline-worker-set-up.md) to quickly create a frontline worker and automate setup steps.

Users with these security roles can sign in to the mobile app as a technician.

## Refreshed mobile user experience

The refreshed user experience in the Dynamics 365 Field Service mobile app helps service technicians swiftly access all the information they need. It offers familiar mobile navigation, gestures, and controls to manage work orders, tasks, services, and products. Technicians save valuable time with Copilot in Field Service to quickly update the status of a booking or get a summary of a work order. They can even get detailed information about tasks with [embedded Dynamics 365 Guides](/dynamics365/mixed-reality/guides/admin-connect-field-service-mobile), which provides step-by-step instructions, pictures, and videos.

Configuration options for the refreshed mobile user experience are in the settings area of the Field Service Mobile app module. Makers in an organization can access these settings to enable the new user experience and its features.

If you use a custom app module and don't see the settings area, [review the troubleshooting guide to show the settings area](/dynamics365/field-service/troubleshooting-mobile-newux#settings-area-is-missing-in-the-field-service-mobile-app-module-navigation).

### Enable the new mobile user experience

You need Field Service - Administrator permissions to enable the refreshed user experience.

:::image type="content" source="../media/FSM-newux-settings.png" alt-text="Screenshot of the Settings page for the Field Service mobile app module.":::

1. Open the Field Service Mobile app module in a web browser.

1. Change to the **Settings** area and go to **Mobile settings** > **Features**.

1. Turn on the **New mobile experience** setting to see all configuration options for the new experience. You can enable the new experience for all users in the environment or individual users. If you choose to enable it for individual users only, existing users will continue to receive the Unified Interface experience while users with the **Field Service – New Mobile Experience** security role will get the new mobile experience.

1. Save the changes and [publish the updated app](/power-apps/maker/model-driven-apps/validate-app#publish-an-app-using-the-app-designer) to make them visible for your users.

Users don't need to download a new app. However, make sure you have at least the app version 2408.2 and the solution version 8.8.122.6 installed.

### Turn on features for the refreshed experience

After enabling the new mobile experience, you can choose to enable preview features, such as copilot skills that are available in the new mobile experience.

1. Open the Field Service Mobile app module in a web browser.

1. Change to the **Settings** area and go to **Mobile settings** > **Features**.

1. In the **Preview section**, enable the features that your users can access:

   - [Summarize records with Copilot in Field Service (preview)](../work-order-recap.md)
   - [AI-powered work order update (preview)](../work-order-update.md)

### Limitations of the new experience

- Offline mode isn't supported. Users who are enabled for offline use don't see the new experience. If a user is in offline mode while trying to access the new mobile experience, they fall back to the classic Unified Interface experience instead.

- The new experience isn't available in the [Windows app](download-mobile-app.md#windows) and the app shows the Unified Interface experience instead.

## Download the app and sign in

[Download the Field Service mobile app](download-mobile-app.md) for your preferred platform and sign in with your user credentials.

## Next steps

- [Set up offline data and sync filters](work-offline.md)
- [Five tips for implementing the Field Service mobile app](https://cloudblogs.microsoft.com/dynamics365/it/2021/04/21/5-tips-for-implementing-the-field-service-dynamics-365-mobile-app/)
- [Get started with Dynamics 365 Field Service](../field-service-get-started.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
