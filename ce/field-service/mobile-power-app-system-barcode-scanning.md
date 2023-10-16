---
title: Barcode scanning and global search
description: Learn about barcode scanning and global search in the Dynamics 365 Field Service mobile app.
ms.date: 10/16/2023
ms.topic: article
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Barcode scanning and global search

Technicians can use the Dynamics 365 Field Service mobile app to scan a barcode.

Scanning a barcode simplifies data entry and lets technicians search the database for records that match the barcode for easy lookup.

> [!div class="mx-imgBorder"]
> ![Four mobile devices in different stages of the barcode scan process.](./media/mobile-scan-barcode-new.png)

For a video walkthrough, see: [Use and configure the Dynamics 365 Field Service mobile app](https://youtu.be/tcDt_vJ5csI?t=479).

## Add a barcode field to the form

First, make sure there's a barcode field on the record type you want to add the barcode information. A common example is adding a barcode field to the customer asset form.

1. Find the **Field Service Mobile** app module in your list of Dynamics 365 apps and select the ellipsis (&hellip;) > **Open in App Designer**.

1. In the navigation, select the form you want to use barcode scanning on. In the list of available forms, choose the one you want to change and select **Edit**.

1. Add a table column for which you want to use barcode scanning to the form.

1. Select the newly added column and add the **BarcodeScannerControl** component in the **Properties** side pane. Make sure you enable **Show component on** for **Mobile** and **Tablet**.

   :::image type="content" source="media/power-apps-designer-add-barcode.png" alt-text="Screenshot of the Power Apps app designer with the BarcodeScannerControl opened.":::

1. **Save and publish** the changes.

> [!NOTE]
> Currently, the barcode scanner control doesn't support setting control-level error notifications. For more information, see [setNotification docs](/power-apps/developer/model-driven-apps/clientapi/reference/controls/setnotification).

## Scan a barcode to populate the field value

In the mobile app, a barcode-enabled field has a barcode icon. Select the barcode icon to open the camera and scan a barcode or QR code. After a successful scan, the barcode value is added to the field. Save the form to store the scanned value.

## Enable search

Field Service uses [Dataverse search](/powerapps/mobile/relevance-search-mobile) and includes a barcode scanner option within the search view.   Dataverse search requires an active internet connection. If the device has no connectivity, the search experience falls back to [categorized search](/powerapps/user/quick-find) experience.

By default, Dynamics 365 Field Service is configured to search against activity, contact, user, customer asset, incident type, work order, and IoT alert/device. You can customize search to include more record types, such as products. Expanding search parameters can help technicians search, find by keyword, and scan to search by barcode, UPC, or QR code.

To enable a new barcode field for search within a table:

1. If the desired table isn't enabled for search, [follow these steps](/power-platform/admin/configure-relevance-search-organization#select-tables-for-dataverse-search) to enable the table for search. 
2. Add the barcode-enabled field to the [table's quick-find view](/power-platform/admin/configure-relevance-search-organization#select-searchable-fields-and-filters-for-each-table).
3. **Save and publish** the changes.

> [!NOTE]
>
> - Custom integration using barcode can be accomplished on mobile devices with [getBarcodeValue API](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-device/getbarcodevalue).
> - Currently, global search with barcode scanning isn't available on tablet and Windows versions of the app.
> - If the updated fields don't show on the mobile app of a user, ask them to reconfigure the application to get the latest version.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
