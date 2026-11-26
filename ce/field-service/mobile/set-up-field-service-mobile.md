---
title: Set up the Field Service mobile app
description: Set up the Dynamics 365 Field Service mobile app for your technicians. Follow step-by-step guidance to install, assign roles, and enable the new mobile experience.
ms.date: 07/17/2026
ms.topic: how-to
ms.subservice: field-service-mobile
ms.collection: get-started
author: JonBaker007
ms.author: jobaker
ms.reviewer: v-wendysmith
---

# Set up the mobile app

The Dynamics 365 Field Service mobile app is designed and optimized for technicians in the field. They can work with Field Service work orders, customer assets, accounts, and contacts.

The app is built on Microsoft Power Platform as a [model-driven app](/powerapps/maker/model-driven-apps/model-driven-app-overview). You can customize it to your business needs like other [model-driven apps](/power-apps/maker/model-driven-apps/).

## Prerequisites

- [Install Field Service](../install-field-service.md)
- [Set up Field Service](../field-service-get-started.md)

## Assign security roles to the Field Service mobile app

1. Sign in to [Power Apps](https://make.powerapps.com/) and select **Apps** in the left pane.

1. Find the **Field Service Mobile** model-driven app and select the ellipses (&hellip;).

1. Select **Share** and assign the app to **Field Service-Resource**, **Field Service-Administrator**, or other security roles that need access to the mobile app.

:::image type="content" source="../media/assign-roles-to-app.png" alt-text="Screenshot of the Dynamics 365 list of apps, showing the Field Service mobile solution in the list.":::

1. Select **Share**.

## Assign mobile app users appropriate security roles

Assign Field Service technicians the **Field Service-Resource** security role and **Field Service-Resource** field security profile so they can sign in to the mobile app. If needed, set up other security roles for users who need access to the mobile app. Learn more in [Set up users, licenses, and security roles](../users-licenses-permissions.md).

Alternatively, go through the [frontline worker setup](../frontline-worker-set-up.md) to quickly create a frontline worker and automate setup steps.

## Refreshed mobile user experience

The refreshed user experience in the Dynamics 365 Field Service mobile app helps service technicians swiftly access all the information they need and save valuable time. It offers:

- Familiar mobile navigation and controls to manage work orders, tasks, services, and products.
- Copilot in Field Service to quickly update the status of a booking or get a summary of a work order.

You can find configuration options for the refreshed mobile user experience in the **Settings** area of the Field Service Mobile app module. Makers in an organization can access these settings to enable the new user experience and its features. If you use a custom app module and don't see the settings area, [review the troubleshooting guide to show the settings area](/troubleshoot/dynamics-365/field-service/mobile-app/settings-area-missing).

### Enable the new mobile user experience

You must have **Field Service - Administrator** permissions to enable the refreshed user experience.

:::image type="content" source="../media/FSM-newux-settings.png" alt-text="Screenshot of the Settings page for the Field Service mobile app module.":::

1. Open the Field Service Mobile app module in a web browser.

1. Change to the **Settings** area and go to **Mobile settings** > **Features**.

1. Turn on the **New mobile experience** setting to see all configuration options for the new experience. You can enable the new experience for all users in the environment or individual users. If you choose to enable it for individual users only, existing users continue to receive the Unified Interface experience while users with the **Field Service – New Mobile Experience** security role get the new mobile experience.

1. Save the changes and [publish the updated app](/power-apps/maker/model-driven-apps/validate-app#publish-an-app-using-the-app-designer) to make them visible for your users.

Users don't need to download a new app. However, make sure you have at least the app version 2408.2 and the solution version 8.8.122.6 installed.

### Turn on features for the refreshed experience

After you turn on the new mobile experience, you can choose to enable preview features, such as copilot skills that are available in the new mobile experience.

1. Open the Field Service Mobile app module in a web browser.

1. Change to the **Settings** area and go to **Mobile settings** > **Features**.

1. Enable the features that your users can access:

   - [Summarize work orders with Copilot](../use-work-order-recap.md)
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
