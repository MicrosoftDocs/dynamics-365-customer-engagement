---
title: Set up the mobile app
description: Learn how to install and set up the Dynamics 365 Field Service mobile app.
ms.date: 10/16/2023
ms.topic: article
ms.subservice: field-service-mobile
ms.collection: get-started
author: Andrea-Orimoto
ms.author: andreo
---

# Set up the mobile app

> [!WARNING]
> Michael and Jon to create/refine content for enable new UX. This is the admin-facing article. update metadata

The Dynamics 365 Field Service mobile app is designed and optimized for technicians in the field. They can work with Field Service work orders, customer assets, accounts, and contacts. The app is built on Microsoft Power Platform as a [model-driven app](/powerapps/maker/model-driven-apps/model-driven-app-overview). You can customize it to your business needs like other [model-driven apps](/power-apps/maker/model-driven-apps/).

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4HKRL]

## Prerequisites

To use the Field Service mobile app, you need [Field Service installed](../install-field-service.md) and [set up](../field-service-get-started.md).

## Assign security roles to the Field Service mobile app

1. Go to [https://make.powerapps.com/](https://make.powerapps.com/) > **Apps** in the left pane.

1. Find the **Field Service Mobile** model-driven app and select the ellipses (&hellip;).

1. Select **Share** and assign the app to the **Field Service-Resource**, **Field Service-Administrator**, or other security roles need access to the mobile app.

:::image type="content" source="../media/assign-roles-to-app.png" alt-text="Screenshot of the Dynamics 365 list of apps, showing the Field Service Mobile solution in the list.":::

## Assign mobile app users appropriate security roles

Assign Field Service users the **Field Service-Resource** security role and **Field Service-Resource** field security profile. For more information, see [Set up users, licenses, and security roles](../users-licenses-permissions.md). Alternatively, go through the [frontline worker setup](../frontline-worker-set-up.md) to quickly create a frontline worker and automate setup steps.

Users with these security roles can sign in to the mobile app as a technician.

## Enable the refreshed mobile user experience

The refreshed user experience in the Dynamics 365 Field Service mobile app helps service technicians swiftly access all the information they need. It offers familiar mobile navigation, gestures, and controls to manage work orders, tasks, services, and products. Technicians save valuable time with Copilot in Field Service to quickly updating the status of a booking or get a summary of a work order. They can even get detailed information about tasks with [embedded Dynamics 365 Guides](/dynamics365/mixed-reality/guides/admin-connect-field-service-mobile), which provide step-by-step instructions, pictures, and videos.

Watch this brief video to learn more:

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RW18Uzz]

### Turn on features for the refreshed experience

> [!IMPORTANT]
> TODO: This section needs more detail on the toggles, what they do, and how they are connected.

To enable the preview features, sign in as a Field Service Administrator to Dynamics 365 in a web browser. Select the Field Service Mobile app module. In the app settings, select the toggle to enable the preview features for all users in your organization.

If you use a custom app module and don't see the settings area, [review the troubleshooting guide to show the settings area](/dynamics365/field-service/troubleshooting-mobile-newux#settings-area-is-missing-in-the-field-service-mobile-app-module-navigation).

Technicians don't need to download a new app. Just make sure the mobile app and the Field Service solution are updated to the latest version.

### Limitations of the new experience

- Offline mode isn't supported. Users who are enabled for offline use don't see the new experience.

- [Field Service Mobile app module customizations](../field-service-customizations.md) aren't supported. However, an icon in the upper-right corner allows users to switch between the classic and modern UX to access customized model-driven app experiences, like custom forms and business logic.

- The new mobile experience uses the display language that's set in the device's language settings. The classic experience uses the language that's set in the user profile. Users might see a mixed language experience if the two settings are not the same.

## Download the app and sign in

[Download the Field Service mobile app](download-mobile-app.md) for your preferred platform and sign in with your user credentials.

## Next steps

- [Set up offline data and sync filters](work-offline.md)
- [Five tips for implementing the Field Service mobile app](https://cloudblogs.microsoft.com/dynamics365/it/2021/04/21/5-tips-for-implementing-the-field-service-dynamics-365-mobile-app/)
- [Get started with Dynamics 365 Field Service](../field-service-get-started.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
