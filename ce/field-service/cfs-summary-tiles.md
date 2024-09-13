---
title: View and edit device summary tiles
description: Learn how to view and edit summary tiles in Connected Field Service for Dynamics 365 Field Service.
ms.date: 09/04/2024
ms.subservice: connected-field-service
ms.topic: how-to
ms.author: vhorvath
author: vhorvathms
---

# View and edit device summary tiles in Connected Field Service

Summary tiles give a numeric overview of important metrics related to Internet of Things (IoT) devices. For example, users can see an average of recent device readings or the number of work orders generated from an IoT alert. Summary tiles are visible on IoT devices, Iot alerts, and customer asset records. Summary tile calculations respect security roles. The summary information changes based on what the signed-in user has access to.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Boiler 2022 IOT device summary tiles displaying the Avg Temperature, Avg Humidity, New Alerts, and New Work Orders.](./media/cfs-device-readings-history.png)

## Prerequisites

- Field Service version 8.8.2+

## View the default summary tiles

After you [create an IoT device](cfs-register-devices.md), the **IoT Device** page displays three default summary tiles.

- New IoT alerts related to the IoT device in the last day.
- New cases related to the IoT device in the last 30 days.
- New work orders related to the IoT device in the last 30 days.

1. In Dynamics 365 Field Service under **Assets**, select **IoT Devices**.

1. Open an IoT device.

   :::image type="content" source="media/cfs-summary-tiles-default.svg" alt-text="Screenshot of the summary tiles on an IoT device in Field Service.":::

   If the device is registered with Azure IoT or a custom IoT provider and device data is pulled into Field Service, the first two device properties automatically appear. Temperature and humidity are the first two device properties in the first device data pull.

   :::image type="content" source="media/cfs-device-readings-history-edited.svg" alt-text="Screenshot of the IoT device summary tiles displaying the Avg Temperature and the Avg Humidity for the past seven days.":::

   The device summaries use the device data history information on the device record, which updates with a slight delay (30-60 min). You can select **Pull Device Data** to get the latest data from Azure IoT.

## Edit summary tiles

You can create summary tiles or edit existing tiles. Changes to summary tiles are saved to the related IoT device. When that IoT device is related to IoT alerts or customer assets, the changes are reflected on the summary tiles. You can display up to six summary tiles.

1. To edit an existing summary tile, select the vertical ellipsis &vellip; > **Edit**. To create a summary tile, select **+**.

   :::image type="content" source="media/cfs-summary-tiles-edit.png" alt-text="Screenshot of an IoT device showing the option to edit summary tiles.":::

1. Choose if the information should relate to a **Device Measurement** (such as temperature or humidity) or a **Device Event** (such as the creation of a work order).

1. Enter the rest of the configuration and select **Save & Close**.

## Add summary tiles via device categories

Organizations often want to apply summary tiles to a group of IoT devices, rather than edit the summary tiles on each IoT device. To apply summary tiles to a group of IoT devices, associate the tiles with device categories. [Editing summary tiles](#edit-summary-tiles) for an IoT device overrides the summary tiles applied through device categories.

1. In Dynamics Field Service, go to the **Settings** area.  

1. Under **IoT**, select **Device Categories**.

1. Select or [create a new device category](cfs-device-categories.md).

1. Open the device category and select the **IoT Device Visualization Configuration** tab.

1. Select **New IoT Device Visualization Configuration**. Each configuration corresponds to a summary tile. 

1. Select **Save & Close**.

1. Make sure your IoT devices are related to the device category. You can add all IoT devices that belong to the category from the device category. Alternatively, there's a field on each IoT device to associate a category.

## View summary tiles on the mobile app

Summary tiles and device readings are viewable on the Dynamics 365 Field Service mobile app when connected to the internet. For more information, go to [Work with IoT data on the mobile app](./cfs-mobile-powerapp.md#view-summary-tiles-and-device-readings).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
