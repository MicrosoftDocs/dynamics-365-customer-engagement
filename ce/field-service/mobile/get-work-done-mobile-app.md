---
title: Work with the mobile app (Unified Interface)
description: Learn how to use the Dynamics 365 Field Service mobile app to plan your work day, track your work orders, and view customer details.
ms.topic: how-to
ms.subservice: field-service-mobile
ms.date: 02/05/2025
author: JonBaker007
ms.author: jobaker
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/26/2023
  - bap-template
---

# Work with the mobile app (Unified Interface)

The Dynamics 365 Field Service mobile app helps frontline workers complete work orders efficiently and effectively. They can view jobs in a daily overview, dive into detailed instructions, and update work orders on the go. The Field Service mobile app uses the Power Apps mobile app as a player for the model-driven Field Service mobile app module. Therefore, core concepts like navigation, views, and actions are explained here: [Use model-driven apps in the Power Apps mobile app](/power-apps/mobile/use-custom-model-driven-app-on-mobile).

This article discusses concepts that are specific to the Field Service mobile app and its common scenarios.

## Sign in

An admin has to [ensure access and assign permissions to users](../users-licenses-permissions.md).

After [installing and opening the mobile app](download-mobile-app.md), users can sign in. If users have access to more than one app, they have to choose which app to load. The app might download [data from the offline profile](offline-data-sync.md) to the device, which can take some time to complete.

## View scheduled work orders

The first screen shows a calendar view of the currently scheduled work orders. Users can use the date picker to switch between days and change the view of the home page. To show bookings as a list, select **More** > **Show as** > **Read-only Grid**.

:::image type="content" source="../media/mobile-2020-booking-view.jpg" alt-text="Renderings of four mobile devices showing the Bookings screens in the Field Service mobile app.":::

Frontline workers can [view their daily bookings on a map](booking-maps.md).

## Travel to a job location

Select a booking to see more details about the job, such as booking time, planned duration, or the related work order. Frontline workers can change the status of a booking when they're driving to the job location. The **Customer** tab shows the work order location and lets users get turn-by-turn directions.

:::image type="content" source="../media/mobile-2020-work-order-navigate-directions-map.jpg" alt-text="Renderings of two mobile devices showing booking status and a mapped work location in the Field Service mobile app.":::

For more complex locations, Field Service supports [functional locations that let you structure locations](../functional-locations.md). Watch this video to learn more about functional locations in the Field Service mobile app:
>
> [!VIDEO c28b1012-203c-4df1-8435-d39cdd999030]

## Do and record your work

The **Service** tab contains work order details like service tasks, products, and services. Users can mark a service or service task as complete and include products that were used in the process to make sure the invoicing is accurate. They can adjust the product units and the service hours as needed. To see more details, select a service task, service, or product name.

:::image type="content" source="../media/mobile-2020-work-order-service-notes-new.jpg" alt-text="Renderings of three mobile devices showing service tasks, parts used, and the Notes screen in the Field Service mobile app.":::

## Add notes and attachments

On the **Notes** tab, frontline workers can add text, image, audio, and video notes and link them to the booking. These notes help document and build a work history. Images added to notes [use image optimization](/power-apps/mobile/optimize-images-upload) to save storage space.

The **Timeline** tab shows you other historical data related to the booking.

:::image type="content" source="../media/mobile-uci-quick-notes.png" alt-text="Renderings of three mobile devices showing the Notes screen, the device camera view, and a note with photos in the Field Service mobile app.":::

Notes are available only when they're included with the Bookable Resource Booking form. You can't use notes with other forms.

To save notes, users need a [security role with access](../users-licenses-permissions.md) to the `msdyn_bookableresourcebookingquicknotes` table.

## Manage customer assets

When the mobile device has internet connection, users can view and interact with functional locations and customer asset hierarchies.

:::image type="content" source="../media/mobile-2020-customer-asset-navigate.png" alt-text="Renderings of three mobile devices showing information about customer assets in the Field Service mobile app.":::

Sometimes, it's handy to scan a barcode to find records that have a matching barcode field, especially in the context of assets (for example, when installing a new device and making sure the serial number gets captured in the system). An administrator can [set up barcode scanning](scan-barcode.md) and add it to the relevant forms.

## Track time

Users can track the time that they spend on work orders, on break, traveling, and other scenarios with time entries. The mobile app allows them to create time entries quickly.

From the main menu, go to **Time Entry** to create them.

:::image type="content" source="../media/mobile-2020-time-entry-all.png" alt-text="Renderings of three mobile devices showing the process of entering time in the Field Service mobile app.":::

Watch this video to learn more about time entry in the Field Service mobile app:
>
> [!VIDEO https://learn-video.azurefd.net/vod/player?id=881e6a12-aca1-43ec-9a7d-5cb5ea876e22]

## Create follow-up work orders

To schedule more work for another time, users can create follow-up work orders. This might come in handy when they are working on a job and notice that something else needs fixing and they are missing the spare part.

To create a follow-up work order, select the **Follow up** option in the bottom app menu. The following fields are already filled in based on the current work order:

- Address
- Billing Account
- Service Account
- Service Territory
- Exchange Rate
- Tax Code
- Taxable
- Transaction Currency ID

After saving the work order, a dispatcher can schedule it.

If users don't see the follow-up option, an administrator needs to assign them [**create** permissions](../users-licenses-permissions.md) to the work order table.

:::image type="content" source="../media/mobile-2020-follow-up.png" alt-text="Rendering of a mobile device showing the Follow-up option in the Field Service mobile app.":::

Watch this video to learn more about follow-up work orders in the Field Service mobile app:
>
[!VIDEO fb3c067f-75ec-4b6d-aad0-714885351460]

## Troubleshoot app issues

Issues with the Field Service mobile app can be the result of corrupted data. You can often solve them by deleting the app's cached data.

Select your profile icon in the upper-left corner, select **Reconfigure**, and confirm when you're prompted to do so.

:::image type="content" source="../media/mobile-2020-offline-reconfigure.png" alt-text="Rendering of a mobile device showing the Reconfigure option in the Field Service mobile app.":::

[!INCLUDE [footer-include](../../includes/footer-banner.md)]
