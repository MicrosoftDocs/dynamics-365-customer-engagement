---
title: Get started with the refreshed mobile experience
description: Learn about the key features and limitations of the new user experience for the Dynamics 365 Field Service mobile app.
ms.topic: how-to
ms.subservice: field-service-mobile
ms.date: 10/10/2024
author: JonBaker007
ms.author: jobaker
ms.collection: bap-ai-copilot 
---

# Get started with the refreshed mobile experience

The new user experience in the Dynamics 365 Field Service mobile app helps service technicians swiftly access information they need. It offers mobile-friendly navigation, gestures, and controls to help technicians save valuable time by quickly updating the status of a booking and get driving directions to their work locations.

## Agenda view for the new mobile user experience

The agenda view in the new mobile experience is optimized for frontline workers. It supports quick access to key actions such as updating the booking status, getting directions, or access to Copilot.

Admins can [configure the agenda view to show fields relevant to the organization's business needs](/dynamics365/field-service/mobile/customize-booking-calendar).

### Agenda view time update

Updating the booking status in the agenda view also updates some time values in the underlying booking record. The following are the values that are updated when the status changes. The list refers to the out-of-the-box status to which all custom statuses are mapped.

- From *Scheduled* to *Traveling*:
  - Start time is updated to current time
  - End time is updated to current time plus duration

- From *Scheduled* or *Traveling* to *In progress*:
  - End time is updated to current time plus duration
  - If arrival time is empty (the first time the technician has arrived onsite), then arrival time is updated to current time

- From *Completed* to *In progress*:
  - End time is updated to current time plus 1 minute

- From any status to *Completed*:
  - End time is updated to current time
  - If a future booking is set to completed (start time is later than the current time), start time is updated to current time minus 1 minute

Updating the status in agenda view doesn't change the *estimated arrival time*.

## Navigate the app

To open the navigation menu, select **More** at the bottom of the screen.

:::image type="content" source="../media/mobile-newux-navigation.png" alt-text="Renderings of two mobile devices showing the navigation menu in the Field Service mobile app.":::

Views are optimized for the mobile app and provide frontline workers with the information they require to find the records they need. More information: [Understand model-driven app views](/power-apps/maker/model-driven-apps/create-edit-views)

:::image type="content" source="../media/newux-view-portrait.png" alt-text="Screenshot of a mobile view in portrait.":::

Sitemap elements that don't link to a view, such as dashboards or custom pages, render in classic Unified Interface.

## Work on a booking from agenda view

Swipe a booking from left to right or select the booking's menu to access its quick actions. Open a booking to see the full form and update details in the Unified Interface. Quick actions let you update the booking status and give access to [Copilot features if enabled](set-up-field-service-mobile.md#turn-on-features-for-the-refreshed-experience).

:::image type="content" source="../media/mobile-newux-options.png" alt-text="Screenshot of a mobile device with options of a booking in the Field Service mobile app.":::

Select the directions icon on a booking tile to open the maps app and get directions. Directions use the coordinates of the address or the address string if no geolocation is available. If no address is specified, the directions icon doesn't appear.

To automatically change the booking status to **Traveling** every time you get directions to a work location, select **Automatically update**. You can change it later in the app settings.

:::image type="content" source="../media/mobile-newux-traveling-directions.png" alt-text="Renderings of three mobile devices showing how to get directions to a work location and update booking status automatically in the Field Service mobile app.":::

## Work with Copilot

The new mobile UX uses Copilot in Field Service to enable technicians with a quick and easy way of updating work orders and getting a summary of the work order. Swipe a booking to the left to open Copilot.

:::image type="content" source="../media/copilot-newux.png" alt-text="Screenshot of a mobile device with a swiped booking, revealing further options.":::

For more information, see [AI-powered work order update (preview)](../work-order-update.md) and [Summarize records with Copilot in Field Service (preview)](../work-order-recap.md).

## Use embedded Guides in the mobile app

If your organization uses Dynamics 365 Guides, you can [use the new user experience for the Field Service mobile app](set-up-field-service-mobile.md) to access guides from mobile devices. If Guides uses the same environment as Field Service, users find a **Library** option at the bottom of the app. Select it to access your organization's guides library, search for specific guides, and follow them step by step.

:::image type="content" source="../media/mobile-newux-related-guides-home.png" alt-text="Screenshot of Guides home page within the Field Service mobile app.":::

For more information, see [Embedded Guides in Field Service mobile app (preview)](/dynamics365/mixed-reality/guides/admin-connect-field-service-mobile).

## Manage user settings

In the new mobile user experience, app users can tap the user icon to access the app settings.

:::image type="content" source="../media/user-settings-newux.png" alt-text="Screenshot of the user settings in the new mobile experience.":::

- **Timezone**: Set the time zone for the app. If the configuration of the device and the user's settings in Dynamics 365 don't match, the system updates the Dynamics 365 profile to align with the device settings.
- **Language**: Set the language for the mobile app.
- **Map**: Define the behavior of the app when getting directions to a customer site and choose the default map provider.
- **Apps**: If a user has access to multiple Field Service mobile app modules, they can choose which app module to load. They can also access app module settings to [turn on optimized image upload](optimize-image-size.md) or get debugging information.

> [!NOTE]
>
> - The new mobile UX caches changes to metadata for up to 8 hours. To see changes more quickly, users need to sign-out and sign back into the application.
> - The new mobile UX uses the time zone and location of the device, while the forms built for Unified Interface use the system's time zone. If there's a mismatch between the device the system, users are requested to match system time with the device. If the language of the device is not enabled in the system, users might see mixed languages.
> - Searching within lists of the new mobile UX only returns results of text-based fields. Values in other field types such as Lookup won't return results. 
