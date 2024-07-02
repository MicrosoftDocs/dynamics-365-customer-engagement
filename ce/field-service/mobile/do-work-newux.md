---
title: travel, guides, update WO, refer to copilot, RA
description: Learn where
ms.date: 03/11/2024
ms.topic: how-to
ms.subservice: field-service-mobile
author: josephshum-msft
ms.author: jshum
---

# travel, guides, update WO, refer to copilot, RA, etc.

> [!WARNING]
> Michael and Jon to create and refine content. update metadata

## Get started with the refreshed mobile experience

The new user experience in the Dynamics 365 Field Service mobile app helps service technicians swiftly access information they need. It offers mobile-friendly navigation, gestures, and controls to help technicians save valuable time by quickly updating the status of a booking and get driving directions work location.

## Agenda view for the new mobile user experience

The agenda view in the new mobile experience is optimized for frontline workers. It supports quick access to key actions such as updating the booking status, getting directions, or access to Copilot.

Admins can [configure the agenda view to show fields relevant to the organization's business needs](mobile-powerapp-customize-booking-calendar.md#new-mobile-uxtabvnext). However, you can't change the view for the bookings in the new user experience.

## Navigate the app

To open the navigation menu, select **More** at the bottom of the screen.

:::image type="content" source="../media/mobile-newux-navigation.png" alt-text="Renderings of two mobile devices showing the navigation menu in the Field Service mobile app.":::

Views are optimized for the mobile app and provide frontline workers with the information they require to find the records they need. More information: [Understand model-driven app views](/power-apps/maker/model-driven-apps/create-edit-views).

Sitemap elements that don't link to a view, such as dashboards or custom pages, render in classic Unified Client Interface.

## Manage user settings

In the new mobile user experience, app users can tap the user icon to access the app settings.

- **About**: Details about the current session and app version for debugging in case of error.
- **Send feedback**: Provide feedback to Microsoft about the app or suggest improvements.
- **Settings**: Lets users change the time zone for the app, change the behavior of the app when they get directions to a customer site, change the app module. The new mobile user experience always uses the device configuration for date and time zone settings. If the configuration of the device and the users's settings in Dynamics 35 don't match, it asks the users to update their Dynamics 365 profile to align with the device settings.

> [!WARNING]
> Jon: Do we want to keep the details below?

## travel to job new UX


Swipe a booking from left to right or select the booking's menu to access its quick actions and set the status to **Traveling**. You can also open the booking and select **Edit status** on the **General** tab.

:::image type="content" source="../media/mobile-newux-traveling.png" alt-text="Renderings of three mobile devices showing how to change a booking's status in the Field Service mobile app.":::

Select the directions icon on a booking tile on the bookings home page to open your default maps app and get directions. The directions use the geolocation of the address or the address string if no geolocation is available. If no address is specified, then the directions icon doesn't appear.

To automatically change the booking status to **Traveling** every time you get directions to a work location, select **Automatically update**. You can change it later in the app settings.

:::image type="content" source="../media/mobile-newux-traveling-directions.png" alt-text="Renderings of three mobile devices showing how to get directions to a work location and update booking status automatically in the Field Service mobile app.":::

> [!WARNING]
> Michael and Jon to review/create content. May get consolidated in one "Work with new UX" article.

## Travel to a job location


When you're ready to start work, select the booking tile on the booking home page. The booking details view has three tabs, **Tasks**, **Products**, and **Services**. Mark a service or service task as complete and add any products you used. Adjust the product units and the service hours as needed. Select the service task, service, or product name to open the full details form.

:::image type="content" source="../media/mobile-newux-work.png" alt-text="Renderings of four mobile devices showing the General, Tasks, Services, and Products screens in the Field Service mobile app.":::

Streamlined lists in the new mobile UX views remove unnecessary icons and support up to five columns of data. Currently, users can change the view of a list. It always shows the default view, which is enabled for the app module. If there's no default view defined, a list renders the first view configured for the selected entity. The Booking view is handled differently from other views configured in the application. The Bookings view uses the view configuration of *Bookings - Agenda View*.

:::image type="content" source="../media/mobile-list-configurable.png" alt-text="List of accounts showing the new list type with removed icons and custom columns.":::


## Add notes and attachments

On the **Timeline** tab, select **+ Add note** to add text and images to your note. Notes taken here are visible on this booking's timeline. You can attach a single image by selecting the file attachment icon or select the image icon to choose multiple files and add them to the message body.

:::image type="content" source="../media/mobile-newux-notes.png" alt-text="Renderings of four mobile devices showing the process of adding a note with a photo in the Field Service mobile app.":::

Notes in **Timeline** are stored as annotations that are associated with the booking. They don't appear on the parent work order timeline.

## View scheduled work orders

The home screen lists today's scheduled bookings. 

Use the buttons below the list for easy access to the bookings home page (**Home**), the [embedded Guides feature](access-related-apps.md) (**Library**), and the [app navigation menu](#navigate-the-app) (**More**).

To view and change the app settings, provide feedback, and change the environment, select your profile picture at the top of the screen.

Scroll up or down in the agenda view to see bookings in the future or the past. Tap **Home** to return to today.

:::image type="content" source="../media/mobile-newux-bookings.png" alt-text="Rendering of a mobile device showing the Agenda View with today's and tomorrow's bookings in the Field Service mobile app.":::

Swipe left or right on any work order in the list to use a quick action to change the booking status or get directions.

:::image type="content" source="../media/mobile-newux-bookings-quickaction-swipe.png" alt-text="Renderings of five mobile devices showing the use of work order quick actions in the Field Service mobile app.":::



## Use embedded Guides in the mobile app

If your organization uses Dynamics 365 Guides, you can [use the new user experience for the Field Service mobile app](set-up-field-service-mobile.md) to access guides from mobile devices. If Guides uses the same environment as Field Service, users find a **Library** option at the bottom of the app. Select it to access your organization's guides library, search for specific guides, and follow them step by step.

:::image type="content" source="../media/mobile-newux-related-guides-home.png" alt-text="Screenshot of Guides home page within the Field Service mobile app.":::

For more information, see [Embedded Guides in Field Service mobile app (preview)](/dynamics365/mixed-reality/guides/admin-connect-field-service-mobile)

## Update work orders with Copilot

The new mobile UX uses Copilot in Field Service to enable technicians with a quick and easy way of updating work orders.

For more information, see [AI-powered work order update](../work-order-update.md).