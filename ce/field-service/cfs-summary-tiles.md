---
title: View and edit device summary tiles
description: Learn how to view and edit summary tiles in Connected Field Service for Dynamics 365 Field Service.
ms.date: 10/10/2025
ms.subservice: connected-field-service
ms.topic: how-to
ms.author: vhorvath
author: vhorvathms
---

# View and edit device summary tiles in Connected Field Service

Summary tiles provide a numeric overview of key metrics for Internet of Things (IoT) devices. For example, users see the average of recent device readings or the number of work orders generated from an IoT alert. Summary tiles appear on IoT devices, IoT alerts, and customer asset records. Summary tile calculations follow security roles, and the summary information updates based on the signed-in user's access.  

:::image type="content" source="media/cfs-device-readings-history.png" alt-text="Screenshot of the Boiler 2022 IoT device summary tiles displaying the average temperature and humidity, New Alerts, and New Work Orders.":::

## Prerequisite

You need Field Service version 8.8.2 or later.

## View the default summary tiles

After you [create an IoT device](cfs-register-devices.md), the **IoT Device** page displays three default summary tiles.

- New IoT alerts related to the IoT device in the last day
- New cases related to the IoT device in the last 30 days
- New work orders related to the IoT device in the last 30 days

1. In Dynamics 365 Field Service under **Assets**, select **IoT Devices**.

1. Open an IoT device.

   :::image type="content" source="media/cfs-summary-tiles-default.svg" alt-text="Screenshot of the summary tiles on an IoT device in Field Service.":::

   If a device is registered with Azure IoT or a custom IoT provider and its data is pulled into Field Service, the first two device properties automatically appear: temperature and humidity.

   :::image type="content" source="media/cfs-device-readings-history-edited.svg" alt-text="Screenshot of the IoT device summary tiles showing the average temperature and the average humidity for the past seven days.":::

   The device summaries use the device data history on the device record, which updates with a slight delay (30-60 min). You can select **Pull Device Data** to get the latest data from Azure IoT.

## Edit summary tiles

You can create summary tiles or edit existing tiles. Changes to summary tiles are saved to the related IoT device. If the IoT device is related to IoT alerts or customer assets, the changes are reflected on the summary tiles. You can display up to six summary tiles.

1. To edit an existing summary tile, select the vertical ellipsis (&vellip;) > **Edit**. To create a summary tile, select **+**.

   :::image type="content" source="media/cfs-summary-tiles-edit.png" alt-text="Screenshot of an IoT device that shows the option to edit summary tiles.":::

1. Choose whether the information relates to a **Device Measurement** (such as temperature or humidity) or a **Device Event** (such as the creation of a work order).

1. Enter the rest of the configuration and select **Save & Close**.

## Add summary tiles via device categories

Organizations often want to apply summary tiles to a group of IoT devices instead of editing the summary tiles on each IoT device. To apply summary tiles to a group of IoT devices, associate the tiles with device categories. [Editing summary tiles](#edit-summary-tiles) for an IoT device overrides the summary tiles applied through device categories.  

1. In Dynamics Field Service, open the **Settings** area.  

1. In the **IoT** section, select **Device Categories**.

1. Select an existing device category or [create a new device category](cfs-device-categories.md).  

1. Open the device category and select the **IoT Device Visualization Configuration** tab.

1. Select **New IoT Device Visualization Configuration**. Each configuration represents a summary tile.

1. Select **Save & Close**.

1. Make sure your IoT devices are related to the device category. You can add all IoT devices that belong to the category from the device category. Alternatively, use the field on each IoT device to associate a category.  

## View summary tiles on the mobile app

You can view summary tiles and device readings on the Dynamics 365 Field Service mobile app when you're connected to the internet. Learn more in [Work with IoT data on the mobile app](./cfs-mobile-powerapp.md#view-summary-tiles-and-device-readings).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
