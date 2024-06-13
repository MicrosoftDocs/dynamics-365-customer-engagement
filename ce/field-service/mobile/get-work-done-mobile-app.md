---
title: Complete work orders in the mobile app
description: Learn how to use the Dynamics 365 Field Service mobile app to plan your work day, track your work orders, and view customer details.
ms.date: 11/28/2023
ms.topic: how-to
ms.subservice: field-service-mobile
author: josephshum-msft
ms.author: jshum
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/26/2023
  - bap-template
ms.collection: bap-ai-copilot 
---

# Work with the mobile app (Unified Interface)

> [!WARNING]
> update metadata.

The Dynamics 365 Field Service mobile app helps frontline workers complete work orders efficiently and effectively. They can view jobs in a daily overview, dive into detailed instructions, and update work orders on the go. Field Service mobile app uses the Power Apps mobile app as a player for the model-driven Field Service Mobile app module. Therefore, core concepts like navigation, views, actions are explained in the here: [Use model-driven apps in the Power Apps mobile app](/power-apps/mobile/use-custom-model-driven-app-on-mobile).

This article discusses concepts that are specific to the Field Service mobile app its common scenarios.

<!-- here-->

## Sign in

Launch the mobile app and sign in with your Field Service username and password.

If you can't sign in, it might be because you haven't been given the right permissions. Ask your organization's administrator to confirm you have [access and permissions](../users-licenses-permissions.md) to use the app.

After you sign in, the app might download data to your device so that you can use it when your device is offline. It can take some time to complete. The data that's downloaded depends on your administrator's settings for the app's offline profile.

## Access the mobile app as a guest user

[B2B guest users](../users-licenses-permissions.md#b2b-collaboration-users) need a special deep link that identifies the guest tenant to access the environment and open the mobile app.

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

:::image type="content" source="../media/mobile-2020-booking-view.jpg" alt-text="Renderings of four mobile devices showing the Bookings screens in the Field Service mobile app.":::

## Navigate the app

To open the navigation menu, select the menu icon in the upper-left corner of the screen. The navigation menu quickly gets you to important information like accounts, contacts, customer assets, or to submit time entries.

:::image type="content" source="../media/mobile-2020-sitemap-account.jpg" alt-text="Renderings of three mobile devices showing app navigation and an account detail screen in the Field Service mobile app.":::

## View recent items and pin important ones

To quickly find work orders, assets, time entries, and other items you recently looked at, select **Recent** in the app menu.

To easily get back to important items you need quick access to, select **Pin**.

:::image type="content" source="../media/mobile-2020-menu-pin.png" alt-text="Rendering of a mobile device showing the navigation menu with the Recent and Pin buttons highlighted in the Field Service mobile app.":::

## Troubleshoot app issues

As with other mobile apps, issues with the Field Service mobile app are often the result of corrupted data. You can often solve them yourself by deleting the app's cached data.

Select your profile icon in the upper-left corner, select **Reconfigure**, and confirm when you're prompted to do so.

:::image type="content" source="../media/mobile-2020-offline-reconfigure.png" alt-text="Rendering of a mobile device showing the Reconfigure option in the Field Service mobile app.":::

## Travel to a job location

Select a booking to see more details about the booking time and the work order. Change the status to show that you're driving to the customer location. On the **Customer** tab, you can see the work order location on a map and launch your preferred maps app for turn-by-turn directions. The functional location field on the work order tells you exactly where to go when you arrive at the address.

:::image type="content" source="../media/mobile-2020-work-order-navigate-directions-map.jpg" alt-text="Renderings of two mobile devices showing booking status and a mapped work location in the Field Service mobile app.":::

## Do and record your work

On the **Service tab**, you see work order details like work order service tasks, products, and services. Mark a service or service task as complete and include any products you used. Adjust the product units and the service hours as needed. Select the service task, service, or product name to open the full details.

:::image type="content" source="../media/mobile-2020-work-order-service-notes-new.jpg" alt-text="Renderings of three mobile devices showing service tasks, parts used, and the Notes screen in the Field Service mobile app.":::

## Add notes and attachments

On the **Notes** tab, you can add text, image, audio, and video notes and link them to the booking. You can also attach files and capture signatures. These notes help you record and build a work history. Images added to notes [use image optimization](/power-apps/mobile/optimize-images-upload) to save storage space.

The **Timeline** tab shows you other historical data related to the booking.

:::image type="content" source="../media/mobile-uci-quick-notes.png" alt-text="Renderings of three mobile devices showing the Notes screen, the device camera view, and a note with photos in the Field Service mobile app.":::

Notes are available only when they're included with the Bookable Resource Booking form. You can't use notes with other forms.

If you can't save a note, you might not have the right permissions to the table that notes are stored in. Ask your administrator to make sure that your [security role has access](../users-licenses-permissions.md) to the `msdyn_bookableresourcebookingquicknotes` table.

## Service assets

When you're online, you can view and interact with functional locations and customer asset hierarchies in the mobile app.

:::image type="content" source="../media/mobile-2020-customer-asset-navigate.png" alt-text="Renderings of three mobile devices showing information about customer assets in the Field Service mobile app.":::

Watch this video to learn more about functional locations in the Field Service mobile app:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4I2pU]

## Scan barcodes

Sometimes, it's handy to scan a barcode to find records that have a matching barcode field. Ask your administrator to [set up barcode scanning](scan-barcode.md) for the relevant forms.

## Enter time

Track the time that you spend on work orders and other scenarios and create time entries in the mobile app for reporting and billing.

From the main menu, go to **Time Entry** and create one.

:::image type="content" source="../media/mobile-2020-time-entry-all.png" alt-text="Renderings of three mobile devices showing the process of entering time in the Field Service mobile app.":::

Watch this video to learn more about time entry in the Field Service mobile app:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4J6mQ]

## Create follow-up work orders

Sometimes you might need to schedule more work for another time. The mobile app makes it easy to create follow-up work orders.

To create a follow-up work order, select the **Follow up** option in the bottom app menu. The following fields are already filled in based on the current work order:

- Address
- Billing Account
- Service Account
- Service Territory
- Exchange Rate
- Tax Code
- Taxable
- Transaction Currency ID

Save the work order so a dispatcher can book it.

If you don't see the **Follow up** option, you might not have the right permissions. Ask your administrator to make sure you have [**create** permissions](../users-licenses-permissions.md)] to the work order table.

:::image type="content" source="../media/mobile-2020-follow-up.png" alt-text="Rendering of a mobile device showing the Follow up option in the Field Service mobile app.":::

Watch this video to learn more about follow-up work orders in the Field Service mobile app:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWyHY4]

[!INCLUDE [footer-include](../../includes/footer-banner.md)]

