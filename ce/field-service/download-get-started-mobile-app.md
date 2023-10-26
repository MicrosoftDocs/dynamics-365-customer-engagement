---
title: Download the mobile app and get started
description: Learn where to download the Dynamics 365 Field Service mobile app and get started with onsite customer service.
ms.date: 10/05/2023
ms.topic: how-to
ms.subservice: field-service-mobile
author: josephshum-msft
ms.author: jshum
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/26/2023
  - bap-template
---

# Download the mobile app and get started

<!-- EDITOR'S NOTE: This note applies to all articles. It looks like you want the device renderings to carry most of the instructional weight. This violates Microsoft accessibility standards. Alt text is too short to document a process. You also need to put the steps in the article to make the content fully accessible. -->

The Dynamics 365 Field Service mobile app works on iOS and Android devices and on Windows laptops and tablets. It gives technicians the tools they need to serve customers onsite.

Sample screens show both the classic user experience ("Unified Interface UX") and the new mobile app user experience (preview) in separate tabs.

## Prerequisites

A system administrator has [set up the mobile app](mobile-power-app-get-started.md) along with users and security roles.

## Download the app

Go to the app store on your iOS, Android, or Windows device and search for **Dynamics 365 Field Service**.

- Android app: [Dynamics 365 Field Service on Google Play](https://play.google.com/store/apps/details?id=com.microsoft.crm.crmphone.fieldServices)
- iOS app: [Dynamics 365 Field Service in the Apple App Store](https://apps.apple.com/us/app/field-service-dynamics-365/id1485579247)
- Windows app: [Dynamics 365 Field Service in the Microsoft Store](https://apps.microsoft.com/detail/9PMX4FNSSF5P)

## Sign in

Launch the mobile app and sign in with your Field Service username and password.

If you can't sign in, it might be because you haven't been given the right permissions. Ask your organization's administrator to confirm you have [access and permissions](view-user-accounts-security-roles.md) to use the app.

After you sign in, the app might download data to your device so that you can use it when your device is offline. It can take some time to complete. The data that's downloaded depends on your administrator's settings for the app's offline profile.

## View scheduled work orders

## [Unified Interface UX](#tab/vCurrent)

The first screen shows a calendar view of your scheduled work orders. At the bottom of the screen, select **More** > **Show as** > **Read-only Grid** to see your bookings as a list instead.

:::image type="content" source="./media/mobile-2020-booking-view.jpg" alt-text="Renderings of four mobile devices showing the Bookings screens in the Field Service mobile app.":::

## [New mobile UX (preview)](#tab/vNext)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

The home screen lists today's scheduled work orders. Above the list, you have options to filter your bookings by work order status. To sort the list by account, incident type, time, or duration, select **Sort by** in the upper right.

Use the buttons below the list for easy access to the bookings home page (**Home**), the [embedded Guides feature](access-related-apps-mobile-app.md) (**Library**), and the [app navigation menu](#navigate-the-app) (**More**).

To view and change the app settings, provide feedback, and change the environment, select your profile picture at the top of the screen.

:::image type="content" source="./media/mobile-newux-bookings.png" alt-text="Renderings of three mobile devices showing the work orders list, filtering, sorting, and navigation options in the Field Service mobile app.":::

Swipe left or right on any work order in the list to use a quick action to change the booking status or get directions.

:::image type="content" source="./media/mobile-newux-swipe.png" alt-text="Renderings of five mobile devices showing the use of work order quick actions in the Field Service mobile app.":::

---

## Navigate the app

## [Unified Interface UX](#tab/vCurrent)

To open the navigation menu, select the menu icon in the upper-left corner of the screen. The navigation menu quickly gets you to important information like accounts, contacts, customer assets, or to submit time entries.

:::image type="content" source="./media/mobile-2020-sitemap-account.jpg" alt-text="Renderings of three mobile devices showing app navigation and an account detail screen in the Field Service mobile app.":::

## [New mobile UX (preview)](#tab/vNext)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

To open the navigation menu, select **More** at the bottom of the screen.

:::image type="content" source="./media/mobile-newux-navigation.png" alt-text="Renderings of two mobile devices showing the navigation menu in the Field Service mobile app.":::

---

## View recent items and pin important ones

To quickly find work orders, assets, time entries, and other items you recently looked at, select **Recent** in the app menu.

To easily get back to important items you need quick access to, select **Pin**.

:::image type="content" source="./media/mobile-2020-menu-pin.png" alt-text="Rendering of a mobile device showing the navigation menu with the Recent and Pin buttons highlighted in the Field Service mobile app.":::

## Troubleshoot app issues

As with other mobile apps, issues with the Field Service mobile app are often the result of corrupted data. You can often solve them yourself by deleting the app's cached data.

Select your profile icon in the upper-left corner, select **Reconfigure**, and confirm when you're prompted to do so.

:::image type="content" source="./media/mobile-2020-offline-reconfigure.png" alt-text="Rendering of a mobile device showing the Reconfigure option in the Field Service mobile app.":::

[!INCLUDE [footer-include](../includes/footer-banner.md)]
