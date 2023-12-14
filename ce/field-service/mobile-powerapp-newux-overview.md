---
title: New mobile user experience (preview)
description: Learn how to enable and find out more about the new user experience features in the Dynamics 365 Field Service mobile app.
ms.date: 07/30/2023
ms.topic: overview
ms.subservice: field-service-mobile
author: andrea-orimoto
ms.author: andreo
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/30/2023
---

# New mobile user experience (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

The new user experience (UX) features in the Dynamics 365 Field Service mobile app help service technicians swiftly access all the information they need. The modern UX offers familiar mobile navigation, gestures, and controls to manage work orders, tasks, services, and products. Technicians save valuable time by quickly updating the status of a booking and getting driving directions to a customer site, changing or completing work order details, and adding notes with photos. They can even get detailed information about tasks with [embedded Dynamics 365 Guides](/dynamics365/mixed-reality/guides/admin-connect-field-service-mobile), which provide step-by-step instructions, pictures, and videos.

Watch this brief video to learn more about the new user experience in the Field Service mobile app:

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RW18Uzz]

## Preview content in the documentation

After an administrator [enables the preview features](#enable-the-preview-features), they're available directly in the Field Service mobile app. Technicians don't need to download a new app and organizations don't need to migrate anything.

Make sure the mobile app and the Field Service solution are updated to the latest version. For the preview of the new UX, the minimum Field Service version required is [8.8.95.25](version-history.md#889525). The minimum app version required is 13.23072.18 (iOS) and 3.23072.18 (Android).

The following articles contain preview content alongside the current content in dedicated tabs:

- [Download the mobile app and get started](download-get-started-mobile-app.md)
- [Complete work orders in the mobile app](get-work-done-mobile-app.md)
- [Access related apps from the mobile app](access-related-apps-mobile-app.md)
- [Embedded Guides in Field Service (preview)](access-related-apps-mobile-app.md)

## Enable the preview features

To enable the preview features, sign in as a Field Service Administrator to Dynamics 365 in a web browser. Select the Field Service Mobile app module. In the app settings, select the toggle to enable the preview features for all users in your organization.

## Limitations of preview features

The preview features have the following limitations:

- Offline mode isn't supported. Users who are enabled for offline use don't see the new experience. To properly experience the new preview features, disable the offline profile.

- While it's in preview, the new UX can't be customized. [Field Service Mobile app module customizations](field-service-customizations.md) aren't supported and don't work in the new UX. However, an icon in the upper-right corner allows users to switch between the classic and modern UX to access customized model-driven app experiences, like custom forms and business logic.

- The new mobile experience uses the display language that's set in the device's language settings. The classic experience uses the language that's set in the app's user profile. Users might see a mixed language experience if the two settings are out of sync.

## Preview support

During the preview period, support for the new mobile experience features is limited and we don't recommend it for production use. If you run into issues with the preview, select **Send feedback** in the app's left navigation menu to send an email and system logs to our team.

## Next steps

[Install and set up the mobile app](mobile-power-app-get-started.md).

[!INCLUDE [footer-include](../includes/footer-banner.md)]
