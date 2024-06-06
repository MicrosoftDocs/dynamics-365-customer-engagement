---
title: Download the mobile app and get started
description: Learn where to download the Dynamics 365 Field Service mobile app and get started with onsite customer service.
ms.date: 03/11/2024
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

The Dynamics 365 Field Service mobile app works on iOS and Android devices and on Windows laptops and tablets. It gives technicians the tools they need to serve customers onsite.

Sample screens show both the classic user experience ("Unified Interface UX") and the new mobile app user experience (preview) in separate tabs.

## Prerequisites

A system administrator has [set up the mobile app](mobile-power-app-get-started.md), user profiles, and security roles.

## Download the app

Go to the app store on your iOS, Android, or Windows device and search for **Dynamics 365 Field Service**.

- Android app: [Dynamics 365 Field Service on Google Play](https://play.google.com/store/apps/details?id=com.microsoft.crm.crmphone.fieldServices)
- iOS app: [Dynamics 365 Field Service in the Apple App Store](https://apps.apple.com/us/app/field-service-dynamics-365/id1485579247)
- Windows app: [Dynamics 365 Field Service in the Microsoft Store](https://apps.microsoft.com/detail/9PMX4FNSSF5P)

System requirements for the Field Service mobile app are the same as for Power Apps mobile app. See [Supported platforms for running apps using the Power Apps mobile app](/power-apps/limits-and-config#supported-platforms-for-running-apps-using-the-power-apps-mobile-app).

## Supported mobile devices

To provide the best experience for mobile app users, we recommend using modern devices with high [CPU Benchmark scores on Geekbench](https://browser.geekbench.com/v5/cpu/singlecore).

The required storage size depends on the [mobile offline profile](mobile-power-app-system-offline.md). It specifies the amount of data that your organization needs to download for when there's no internet access.

### iOS

| Requirement   |OS Version |CPU Benchmark Score| Storage|
| --- | --- |--- | --- |
| Minimum |	14 or later |	400+ |	64 GB	| 
| Recommended| 15 or later |	1,000+	| 64+ GB	|

[Get the iOS app.](https://aka.ms/fsmobile-apple)

### Android

| Requirement  | OS Version  | CPU Benchmark Score   | RAM   | Storage   |
| ------------ | ------------ | ------------ | ------------ | ------------ |
| Minimum  | 9 or later   | 400+   | 4 GB   | 64 GB|
| Recommended  | 10 or later   | 900+   | 8 GB   | 64+ GB|

[Get the Android app.](https://aka.ms/fsmobile-google)

### Windows

| Requirement  |OS Version |RAM| Storage|
| --- | --- |--- | --- |
| Minimum |	10 17763.0 or later |	6 GB |	64 GB	| 
| Recommended| 10 19042.1348 or later |	8 GB	| 128 GB	|

[Get the Windows app.](https://aka.ms/fsmobile-win)

An administrator can also download the package from the [app center](https://install.appcenter.ms/orgs/dynamics365-mobile/apps/field-service-windows-store-signed-builds/distribution_groups/public%20release) and [distribute it to users using Microsoft Intune](/mem/intune/apps/apps-windows-10-app-deploy).

<!-- make these spearate articles -->

## Sign in

Launch the mobile app and sign in with your Field Service username and password.

If you can't sign in, it might be because you haven't been given the right permissions. Ask your organization's administrator to confirm you have [access and permissions](users-licenses-permissions.md) to use the app.

After you sign in, the app might download data to your device so that you can use it when your device is offline. It can take some time to complete. The data that's downloaded depends on your administrator's settings for the app's offline profile.

## Access the mobile app as a guest user

[B2B guest users](users-licenses-permissions.md#b2b-collaboration-users) need a special deep link that identifies the guest tenant to access the environment and open the mobile app.

1. Download and install the Field Service mobile app.
1. Get the deep link from the Field Service administrator.
    1. The link has to follow this format: `https://apps.powerapps.com/mobile/redirect?appid=<AppModuleID>&tenantid=<TenantID>&playerchannel=FieldServiceMobile&sourceurl=<OrgURL>/main.aspx?appid=<AppModuleID>`.
    1. Sign in to Power Platform admin center to get the placeholder values for TenantID and OrgURL.
    1. TenantID is the Organization ID of the environment that contains Field Service Mobile app module.
    1. OrgURL is the Environment URL of the environment.
    1. Sign in to Field Service and switch to the Field Service Mobile app module. AppModuleID is the appid GUID that shows in the URL.
1. Save the link as a shortcut on your mobile device. Whenever you need to sign in to the guest tenant, use this deep link.
1. Sign in with you guest user credentials after opening the deep link.

## View scheduled work orders

The first screen shows a calendar view of your scheduled work orders. At the bottom of the screen, select **More** > **Show as** > **Read-only Grid** to see your bookings as a list instead.

:::image type="content" source="./media/mobile-2020-booking-view.jpg" alt-text="Renderings of four mobile devices showing the Bookings screens in the Field Service mobile app.":::

## Navigate the app

To open the navigation menu, select the menu icon in the upper-left corner of the screen. The navigation menu quickly gets you to important information like accounts, contacts, customer assets, or to submit time entries.

:::image type="content" source="./media/mobile-2020-sitemap-account.jpg" alt-text="Renderings of three mobile devices showing app navigation and an account detail screen in the Field Service mobile app.":::

## View recent items and pin important ones

To quickly find work orders, assets, time entries, and other items you recently looked at, select **Recent** in the app menu.

To easily get back to important items you need quick access to, select **Pin**.

:::image type="content" source="./media/mobile-2020-menu-pin.png" alt-text="Rendering of a mobile device showing the navigation menu with the Recent and Pin buttons highlighted in the Field Service mobile app.":::

## Troubleshoot app issues

As with other mobile apps, issues with the Field Service mobile app are often the result of corrupted data. You can often solve them yourself by deleting the app's cached data.

Select your profile icon in the upper-left corner, select **Reconfigure**, and confirm when you're prompted to do so.

:::image type="content" source="./media/mobile-2020-offline-reconfigure.png" alt-text="Rendering of a mobile device showing the Reconfigure option in the Field Service mobile app.":::

[!INCLUDE [footer-include](../../includes/footer-banner.md)]

