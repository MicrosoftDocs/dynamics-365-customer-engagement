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

# Complete work orders in the mobile app

The Dynamics 365 Field Service mobile app helps you work efficiently and effectively as a technician. You can use the app to:

- View your assigned jobs on a calendar with all the details you need
- Scan pictures, videos, and asset barcodes
- Integrate with other Microsoft apps for seamless collaboration
- Work offline in areas without Internet access

Sample screens show both the classic user experience ("Unified Interface UX") and the new mobile app user experience (preview) in separate tabs.

## Travel to a job location

Select a booking to see more details about the booking time and the work order. Change the status to show that you're driving to the customer location. On the **Customer** tab, you can see the work order location on a map and launch your preferred maps app for turn-by-turn directions. The functional location field on the work order tells you exactly where to go when you arrive at the address.

:::image type="content" source="./media/mobile-2020-work-order-navigate-directions-map.jpg" alt-text="Renderings of two mobile devices showing booking status and a mapped work location in the Field Service mobile app.":::

## Do and record your work

On the **Service tab**, you see work order details like work order service tasks, products, and services. Mark a service or service task as complete and include any products you used. Adjust the product units and the service hours as needed. Select the service task, service, or product name to open the full details.

:::image type="content" source="./media/mobile-2020-work-order-service-notes-new.jpg" alt-text="Renderings of three mobile devices showing service tasks, parts used, and the Notes screen in the Field Service mobile app.":::

## Add notes and attachments

On the **Notes** tab, you can add text, image, audio, and video notes and link them to the booking. You can also attach files and capture signatures. These notes help you record and build a work history. Images added to notes [use image optimization](/power-apps/mobile/optimize-images-upload) to save storage space.

The **Timeline** tab shows you other historical data related to the booking.

:::image type="content" source="./media/mobile-uci-quick-notes.png" alt-text="Renderings of three mobile devices showing the Notes screen, the device camera view, and a note with photos in the Field Service mobile app.":::

Notes are available only when they're included with the Bookable Resource Booking form. You can't use notes with other forms.

If you can't save a note, you might not have the right permissions to the table that notes are stored in. Ask your administrator to make sure that your [security role has access](users-licenses-permissions.md) to the `msdyn_bookableresourcebookingquicknotes` table.

## Service assets

When you're online, you can view and interact with functional locations and customer asset hierarchies in the mobile app.

:::image type="content" source="./media/mobile-2020-customer-asset-navigate.png" alt-text="Renderings of three mobile devices showing information about customer assets in the Field Service mobile app.":::

Watch this video to learn more about functional locations in the Field Service mobile app:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4I2pU]

## Scan barcodes

Sometimes, it's handy to scan a barcode to find records that have a matching barcode field. Ask your administrator to [set up barcode scanning](scan-barcode.md) for the relevant forms.

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

Save the work order so a dispatcher can book it.

If you don't see the **Follow up** option, you might not have the right permissions. Ask your administrator to make sure you have [**create** permissions](./users-licenses-permissions.md) to the work order table.

:::image type="content" source="./media/mobile-2020-follow-up.png" alt-text="Rendering of a mobile device showing the Follow up option in the Field Service mobile app.":::

Watch this video to learn more about follow-up work orders in the Field Service mobile app:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWyHY4]

[!INCLUDE [footer-include](../../includes/footer-banner.md)]

