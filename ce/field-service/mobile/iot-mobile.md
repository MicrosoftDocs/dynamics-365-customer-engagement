---
title: Work IoT data on the mobile app
description: IoT data from Connected Field Service gives technicians real-time asset insights on mobile. Discover how to view summary tiles, register devices, and send commands.
ms.date: 08/31/2026
ms.subservice: connected-field-service
ms.topic: how-to
ms.author: vhorvath
author: vhorvathms
ms.reviewer: v-wendysmith
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 08/31/2026
ai-usage: ai-assisted
---

# Work with IoT data on the mobile app

[Connected Field Service](../connected-field-service.md) is the IoT layer in Dynamics 365 Field Service. It enables organizations to create work orders based on real-time information from connected devices. The integration of IoT data provides technicians with information and tools for efficient onsite service delivery.

Technicians can use Connected Field Service to:

- **[View IoT data](#view-summary-tiles)** to get more information and details about the context of a repair.
- **[Register new IoT devices](#register-new-iot-devices)** when installing an asset onsite.
- **[Send commands](#troubleshoot-devices-by-sending-commands)** to an IoT device from anywhere to troubleshoot issues.

## Prerequisites

- An administrator [deployed and configured the required services for Connected Field Service](../installation-setup-iothub.md).
- You [updated to the latest version of the Dynamics 365 Field Service mobile app](../upgrade-field-service.md#field-service-dynamics-365-mobile-app).
- You have an active internet connection.

## View summary tiles

While performing service on a customer asset, you can check recent IoT data for devices related to that asset.

1. In the mobile app, go to the main menu and select **Assets**.

1. Open the customer asset and select the **Summary** tab. Summary tiles show an overview of recent IoT activity related to the asset.

   :::image type="content" source="../media/cfs-fsm-powerapp-summary-tiles.png" alt-text="Screenshot of a mobile phone, showing summary tiles for an asset in Field Service mobile app.":::

> [!NOTE]
> Summary tiles are only visible after an [asset is related to a connected device](../cfs-visualizations-iot-hub.md). Otherwise, this information shows on the IoT device or IoT alert.

## Register new IoT devices

During asset installations, you can connect new IoT devices to customer assets. First, register the new IoT device with the system.

1. In the mobile app, go to **Customer Assets** and select **New**.

1. Fill in the asset information and go to **More ...** > **Register Device**.

## Troubleshoot devices by sending commands

After an administrator [configures commands for Connected Field Service](../cfs-commands.md), you can run them from the mobile app. Common commands include restart, shutdown, and other custom commands that are device-specific.

To send a command, open the IoT device record and go to **More ...** > **Send Command**.

## Next steps

- [Use the mobile app to complete work orders](overview.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
