---
title: Work with customer assets
description: Learn how to add customer assets to use asset management in Dynamics 365 Field Service.
ms.date: 11/11/2024
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Work with customer assets

When you add your customers' assets in Field Service, you can track equipment that requires inspections, maintenance, and repairs. Field Service asset management includes which equipment is located at a [functional location](functional-locations.md) and the [service history of all past and present work orders](service-history.md) for each asset.

If your organization uses [Connected Field Service](connected-field-service.md), you can [connect customer assets to sensors](cfs-register-devices.md) that monitor the assets and [trigger an Internet of Things (IoT) alert](cfs-iot-alerts.md) when something needs attention. Watch the following video for a guided walk-through of servicing a customer asset in response to an IoT alert.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=aaa94b8a-0fe7-4435-b472-cf8ef42571ad]

## Create customer assets

You can [create customer assets individually](#manually-create-customer-assets), in bulk by [importing an Excel workbook](#import-customer-assets-from-excel), and [automatically when using a work order product](#automatically-create-customer-assets-from-work-order-products).

### Manually create customer assets

1. In Field Service, select the **Service** area. Under **Assets**, select **Assets**, and then select **New**.

   :::image type="content" source="media/customer-asset-create-manually-new.svg" alt-text="Screenshot of the New Customer Asset form.":::

1. Enter a descriptive **Name** for the customer asset. For example, the make and model of the asset, the name of the product in the product catalog, a general name like *HVAC Unit*, or a label like *HVAC Unit second floor*.

1. Optionally, enter more details:

    - **Category**: Add or create a category that serves as a label to organize assets into groups.

    - **Account**: Look for and select a [service account](accounts.md) to represent the customer and the asset's location.
       As a simple rule, if you were going to create a work order to repair the customer asset, the service account of the work order and the service account of the customer asset should be the same.

    - **Parent Asset**: Field Service supports hierarchical asset structures. For example, a part can be a component of a piece of equipment that is itself a component of a larger device. Use the **Parent Asset** field to specify the direct parent of the asset you're creating.

    - **Product**: If the asset correlates with a [product in your product catalog](create-product-or-service.md), look for and select it.

1. Select **Save**.

1. Optionally add subcomponents or child assets in the **Sub Assets** grid.

1. Optionally, [link knowledge articles](field-service-km-link.md#link-related-entities-to-knowledge-articles). Learn more: [Knowledge management overview](field-service-km-overview.md).

### Import customer assets from Excel

The Excel workbook must contain at least two columns, **Name** and **Account**. The columns must contain the name and service account of the assets you want to import. If you include columns for optional properties such as **Product** and **Functional Location**, the values you enter in the workbook must already exist in Field Service.

1. In Field Service, select the **Service** area. Under **Assets**, select **Assets**.

1. Select the **More commands** (**&vellip;**) menu, and then select **Import from Excel**.

1. Select **Choose File**, and then open an Excel workbook.

1. Select an owner for the imported records if it should be someone other than you.

1. Select **Next**.

1. Select an **Alternate Key** if needed.

1. If the imported file contains assets that already exist in Field Service, the duplicate records are skipped by default. Select **Allow Duplicates** if those assets should be added, not skipped.

1. Select **Review Mapping** to confirm the asset fields match the columns in the Excel workbook and change the mapping if needed.

1. Select **Finish Import** to queue the records for importing.

    You can keep working while the assets are imported, or select **Track Progress**. Select **Done** to confirm that you want to leave the page, and then check the status of the import in the **My Imports** view.

### Automatically create customer assets from work order products

Customer assets can be created automatically when a product is added to a work order and used when the work is being done.

1. In Field Service, select the **Inventory** area, and then select **Product Inventory**.

1. Select a product that you want to turn into a customer asset.

    You can't turn services into customer assets.

1. In the product page, select the **Field Service** tab.

1. In the **General** section, set **Convert to Customer Asset** to **Yes**.

   :::image type="content" source="media/customer-asset-product-convert-to-customer-asset.svg" alt-text="Screenshot of a product in the Field Service tab, with the Convert to Customer Asset setting highlighted.":::

1. Select **Save**.

When you [add the product to a work order](create-product-or-service.md#add-a-product-or-service-to-a-work-order), it creates a *Work Order Product*. Enter a **Quantity** and set **Line Status** to **Used** to indicate the work order product was consumed during the work.

:::image type="content" source="media/customer-asset-product-used.svg" alt-text="Screenshot of a work order, with the quantity and line status of a work order product highlighted.":::

When the status of the work order changes to **Open-Completed** or **Closed-Posted**, the system automatically creates the customer asset record and associates it with the service account that appears on the work order. Regardless of the quantity on the work order product, only one customer asset is created. The asset record includes a link to the work order product that shows the actual quantity entered on the work order.

> [!TIP]
> By default, you can only use assets that are related to the service account on a work order. You can change this option in settings and [allow the use of assets that are related to other accounts](asset-validation.md).

## Create and assign asset categories

Use an asset category to group customer assets. Asset categories allow you to quickly apply property templates to a group of assets.

1. In Field Service, select the **Settings** area, and then select **Asset Categories**.

1. Select **New**.

1. Enter a **Name** for the category.

1. Select **Save**.

1. To assign an asset to the category, select **Related** > **Customer Assets** and add a new or existing asset. You can also assign a category when you create an asset.

    :::image type="content" source="media/assets-categories-assign.svg" alt-text="Screenshot of a customer asset, with the asset category highlighted.":::

## Connect customer assets to Connected Field Service

[Connected Field Service](connected-field-service.md) uses sensors connected to customers' assets to automatically trigger alerts based on IoT data.

In Connected Field Service, *devices* represent sensors that are connected to the internet. You can associate devices with customer assets in a one-to-many relationship, meaning that one asset can have many related devices. For example, a single asset such as an HVAC unit can have multiple device sensors such as a thermometer and a hygrometer that send data to Connected Field Service.

To establish an IoT relationship with a device, go to [Connect to asset](cfs-register-devices.md#connect-to-asset).

IoT alerts from a specific sensor also tag the related customer asset. If a work order is created from the alert, it contains both the alert and the asset.

When you're viewing a customer asset, select **Check IoT Setup** to get information about the asset's IoT configuration, such as whether IoT is deployed or if there are devices available.

## Next steps

- [Validate customer assets on work orders](asset-validation.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
