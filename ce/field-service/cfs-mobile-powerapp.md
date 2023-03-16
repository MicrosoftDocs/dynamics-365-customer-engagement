---
title: Work IoT data on the Field Service (Dynamics 365) mobile app
description: Learn how to access and work with IoT data provided by Connected Field Service from the Field Service (Dynamics 365) mobile app.
ms.date: 02/17/2023
ms.subservice: connected-field-service
ms.topic: how-to
ms.custom: bap-template
ms.author: vhorvath
author: vhorvathms
search.app: 
  - D365CE
  - D365FS
---

# Work IoT data on the Field Service (Dynamics 365) mobile app

[Connected Field Service](connected-field-service.md) is the IoT layer in Dynamics 365 Field Service. It enables organizations to create work orders based on real-time information from connected devices. The integration of IoT data provides technicians with information and tools for efficient onsite service delivery.

> [!div class="mx-imgBorder"]
> ![Simulated image of a mobile phone, showing IoT alerts in the Field Service mobile app.](./media/cfs-fsm-powerapp-site-map.png)

Technicians can use Connected Field Service to:

- **[View IoT data](#view-summary-tiles-and-device-readings)** to get more information and details about the context of a repair.
- **[Register new IoT devices](#register-new-iot-devices)** when installing an asset onsite.
- **[Send commands](#troubleshoot-devices-by-sending-commands)** to an IoT device from anywhere to troubleshoot issues.

## Prerequisites

- An administrator [deployed and configured the required services for Connected Field Service](installation-setup-iothub.md).
- You [updated to the latest version of the Field Service mobile app](upgrade-field-service.md#field-service-dynamics-365-mobile-app).
- You have an active internet connection.

## View summary tiles and device readings

While performing service on a customer asset, you can check recent IoT data for devices related to that asset.

1. Open the customer asset and go the **Summary** tab. Summary tiles show an overview of recent IoT activity related to the asset.

   :::image type="content" source="media/cfs-fsm-powerapp-summary-tiles.png" alt-text="Simulated image of a mobile phone, showing summary tiles for an asset in Field Service mobile app.":::

1. Go to the **Device Readings** tab to see the most recent IoT measurements plotted on a graph.

   :::image type="content" source="media/cfs-device-readings-mobile.png" alt-text="Simulated image of a mobile phone, showing live device readings.":::

> [!NOTE]
> Summary tiles and device readings are only visible after an [asset is related to a connected device](cfs-visualizations-iot-hub.md). Otherwise, this information shows on the IoT device or IoT alert.

## Register new IoT devices

During asset installations, you can connect new IoT devices to customer assets. But first, register the new IoT device with the system.

1. In the mobile app, go to **Customer Assets** and tap the **Add** button.

1. Fill in the asset information and, then tap **Register Device**.

## Troubleshoot devices by sending commands

After an administrator has [configured commands for Connected Field Service](cfs-commands.md), you can run them from mobile app.

:::image type="content" source="media/cfs-fsm-powerapp-commands.png" alt-text="Simulated image of a mobile phone, showing an IoT device record on Field Service mobile app.":::

Common commands include restart and shutdown and other custom commands are device-specific.

To send a comment, open the IoT device record and go to **More ...** > **Send Command**.

## Next steps

- [Use the Field Service (Dynamics 365) mobile app to complete work orders](mobile-power-app-use.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
