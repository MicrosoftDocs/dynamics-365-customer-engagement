---
title: Configure barcode scanning
description: Learn about barcode scanning and global search in the Dynamics 365 Field Service mobile app.
ms.date: 10/06/2025
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Configure barcode scanning

Technicians can use the Dynamics 365 Field Service mobile app to scan a barcode.

Scanning a barcode simplifies data entry and lets technicians search the database for records that match the barcode.

:::image type="content" source="../media/mobile-scan-barcode-new.png" alt-text="Four mobile devices in different stages of the barcode scan process.":::

## Add a barcode field to a form

Make sure the form has a barcode field for barcode information. Customers often add the barcode field to the customer asset form. For more information about customizing your app, see [Model-driven app interface design overview](/power-apps/maker/model-driven-apps/app-interface-design-overview) and [Overview of the model-driven form designer](/power-apps/maker/model-driven-apps/form-designer-overview). For more information about customizing your app, go to [Model-driven app interface design overview](/power-apps/maker/model-driven-apps/app-interface-design-overview) and [Overview of the model-driven form designer](/power-apps/maker/model-driven-apps/form-designer-overview).

1. Find the **Field Service Mobile** app module in your list of Dynamics 365 apps and select the ellipsis (&hellip;) > **Open in App Designer**.

1. In the navigation, select the form for barcode scanning. In the list of available forms, select the form to change, and then select **Edit**.

1. Add the table column for barcode scanning to the form.

1. Select the new column and add the **BarcodeScannerControl** component in the **Properties** side pane. Enable **Show component on** for **Mobile** and **Tablet**.

   :::image type="content" source="../media/power-apps-designer-add-barcode.png" alt-text="Screenshot of the Power Apps app designer with the BarcodeScannerControl opened.":::

1. **Save and publish** the changes.

> [!NOTE]
> Currently, the barcode scanner control doesn't support setting control-level error notifications. For more information, see [setNotification docs](/power-apps/developer/model-driven-apps/clientapi/reference/controls/setnotification).

## Scan a barcode to populate the field value

In the mobile app, a barcode-enabled field has a barcode icon. Select the barcode icon to open the camera and scan a barcode or QR code. After a successful scan, the barcode value is added to the field. Save the form to write the scanned value to the database.

## Enable search

Field Service uses [Dataverse search](/power-apps/mobile/relevance-search-mobile) and includes a barcode scanner option within the search view. Dataverse search requires an active internet connection. If the device doesn't have connectivity, the search experience uses [categorized search](/power-apps/user/quick-find). If you configure the application to offline-first mode, add tables indexed for search to categorized search. In online-only mode, add them to the Dataverse search index.

By default, Dynamics 365 Field Service searches activity, contact, user, customer asset, incident type, work order, and IoT alert/device records. Customize search to include more record types, like products. Expanding search parameters helps technicians search by keyword and scan to search by barcode, UPC, or QR code.

To enable a new barcode field for search in a table:

1. If the desired table isn't enabled for search, [select the table for Dataverse search](/power-platform/admin/configure-relevance-search-organization#select-tables-for-dataverse-search) to enable the table for search.
2. Add the barcode field to the [table's quick-find view](/power-platform/admin/configure-relevance-search-organization#select-searchable-fields-and-filters-for-each-table).
3. **Save and publish** the changes.

> [!NOTE]
>
> - Create custom integrations using barcodes on mobile devices with [getBarcodeValue API](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-device/getbarcodevalue).
> - Global search with barcode scanning isn't available on tablet and Windows versions of the app.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
