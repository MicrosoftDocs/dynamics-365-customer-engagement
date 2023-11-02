---
title: Complete work orders in the mobile app
description: Learn how to use the Dynamics 365 Field Service mobile app to plan your work day, track your work orders, and view customer details.
ms.date: 08/02/2023
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

# Complete work orders in the mobile app

The Dynamics 365 Field Service mobile app helps you work efficiently and effectively as a technician. You can use the app to:

- View your assigned jobs on a calendar with all the details you need
- Scan pictures, videos, and asset barcodes
- Integrate with other Microsoft apps for seamless collaboration
- Work offline in areas without Internet access

Sample screens show both the classic user experience ("Unified Interface UX") and the new mobile app user experience (preview) in separate tabs.

## Travel to a job location

## [Unified Interface UX](#tab/vCurrent)

Select a booking to see more details about the booking time and the work order. Change the status to show that you're driving to the customer location. On the **Customer** tab, you can see the work order location on a map and launch your preferred maps app for turn-by-turn directions. The functional location field on the work order tells you exactly where to go when you arrive at the address.

:::image type="content" source="./media/mobile-2020-work-order-navigate-directions-map.jpg" alt-text="Renderings of two mobile devices showing booking status and a mapped work location in the Field Service mobile app.":::

## [New mobile UX (preview)](#tab/vNext)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

Swipe a booking from left to right or select the booking's menu to access its quick actions and set the status to **Traveling**. You can also open the booking and select **Edit status** on the **General** tab.

:::image type="content" source="./media/mobile-newux-traveling.png" alt-text="Renderings of three mobile devices showing how to change a booking's status in the Field Service mobile app.":::

Select the directions icon on a booking tile on the bookings home page to open your default maps app and get directions. The directions use the geolocation of the address or the address string if no geolocation is available. If no address is specified, then the directions icon doesn't appear.

To automatically change the booking status to **Traveling** every time you get directions to a work location, select **Automatically update**. You can change it later in the app settings.

:::image type="content" source="./media/mobile-newux-traveling-directions.png" alt-text="Renderings of three mobile devices showing how to get directions to a work location and update booking status automatically in the Field Service mobile app.":::

---

## Do and record your work

## [Unified Interface UX](#tab/vCurrent)

On the **Service tab**, you see work order details like work order service tasks, products, and services. Mark a service or service task as complete and include any products you used. Adjust the product units and the service hours as needed. Select the service task, service, or product name to open the full details form.

:::image type="content" source="./media/mobile-2020-work-order-service-notes-new.jpg" alt-text="Renderings of three mobile devices showing service tasks, parts used, and the Notes screen in the Field Service mobile app.":::

## [New mobile UX (preview)](#tab/vNext)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

When you're ready to start work, select the booking tile on the booking home page. The booking details view has three tabs, **Tasks**, **Products**, and **Services**. Mark a service or service task as complete and add any products you used. Adjust the product units and the service hours as needed. Select the service task, service, or product name to open the full details form.

:::image type="content" source="./media/mobile-newux-work.png" alt-text="Renderings of four mobile devices showing the General, Tasks, Services, and Products screens in the Field Service mobile app.":::

---

## Add notes and attachments

## [Unified Interface UX](#tab/vCurrent)

On the **Notes** tab, you can add text, image, audio, and video notes and link them to the booking. You can also attach files and capture signatures. These notes help you record and build a work history.

The **Timeline** tab shows you other historical data related to the booking.

:::image type="content" source="./media/mobile-uci-quick-notes.png" alt-text="Renderings of three mobile devices showing the Notes screen, the device camera view, and a note with photos in the Field Service mobile app.":::

Notes are available only when they're included with the Bookable Resource Booking form. You can't use notes with other forms.

If you can't save a note, you might not have the right permissions to the table that notes are stored in. Ask your administrator to make sure that your [security role has access](view-user-accounts-security-roles.md#q--a) to the `msdyn_bookableresourcebookingquicknotes` table.

## [New mobile UX (preview)](#tab/vNext)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

On the **Timeline** tab, select **+ Add note** to add text and images to your note. Notes taken here are visible on this booking's timeline. You can attach a single image by selecting the file attachment icon or select the image icon to choose multiple files and add them to the message body. Images added to notes [use image optimization](/power-apps/mobile/optimize-images-upload) to save storage space.

:::image type="content" source="./media/mobile-newux-notes.png" alt-text="Renderings of four mobile devices showing the process of adding a note with a photo in the Field Service mobile app.":::

Notes in **Timeline** are stored as annotations that are associated with the booking. They don't appear on the parent work order timeline.

---

## Service assets

When you're online, you can view and interact with functional locations and customer asset hierarchies in the mobile app.

:::image type="content" source="./media/mobile-2020-customer-asset-navigate.png" alt-text="Renderings of three mobile devices showing information about customer assets in the Field Service mobile app.":::

Watch this video to learn more about functional locations in the Field Service mobile app:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4I2pU]

## Scan barcodes

Select the search icon to find records from any table. You can also scan a barcode to find records that have a matching barcode field.

:::image type="content" source="./media/mobile-2020-global-search-use.png" alt-text="Renderings of four mobile devices showing the process of scanning a barcode in the Field Service mobile app.":::

If you don't have the option to scan a barcode, ask your administrator to [set up global search](mobile-power-app-system-barcode-scanning.md) for your organization.

## Enter time

Track the time that you spend on work orders and other scenarios and create time entries in the mobile app for reporting and billing.

From the main menu, go to **Time Entry** and create one.

:::image type="content" source="./media/mobile-2020-time-entry-all.png" alt-text="Renderings of three mobile devices showing the process of entering time in the Field Service mobile app.":::

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

When you save the work order, it's uploaded and available for booking by the dispatcher.

If you don't see the **Follow up** option, you might not have the right permissions. Ask your administrator to make sure you have [**create** permissions](./view-user-accounts-security-roles.md) to the work order table.

:::image type="content" source="./media/mobile-2020-follow-up.png" alt-text="Rendering of a mobile device showing the Follow up option in the Field Service mobile app.":::

Watch this video to learn more about follow-up work orders in the Field Service mobile app:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWyHY4]

[!INCLUDE [footer-include](../includes/footer-banner.md)]
