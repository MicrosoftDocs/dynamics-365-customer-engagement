---
title: Pull device data in Connected Field Service (contains video)
description: Learn how to pull in device data in Connected Field Service for Dynamics 365 Field Service.
ms.date: 09/04/2024
ms.subservice: connected-field-service
ms.topic: how-to
ms.author: vhorvath
author: vhorvathms
---

# Pull device data in Connected Field Service

There are several ways you can pull the most recent device data from your Internet of Things (IoT) connected devices into Connected Field Service. When IoT alerts are triggered, device data is automatically pulled for the associated device.

Check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4HKuF]

## Prerequisite

- [Register your IoT Devices](cfs-register-devices.md).

## Pull device data

1. In Dynamics Field Service, go to the **Service** area.  

1. Under **Assets**, select **IoT Devices**.  
  
1. Open an IoT device record and select **Pull Device Data**.

   :::image type="content" source="media/cfs-device-data-iot-device.png" alt-text="Screenshot of Field Service showing an IoT device, highlighting the Pull Device Data option.":::

1. Select the **Device Data History** tab to view a list of all data pulls for this device.

> [!Note]
> You can pull device data from a customer asset if the customer asset is [connected to IoT devices](cfs-register-devices.md#connect-to-asset). Select **Pull Device Data** in the ribbon of the customer asset record.

## Schedule device data pulls

If you're using Azure IoT Hub as your IoT provider, you can schedule device data pulls to happen when you need them.

1. In Dynamics Field Service, go to the **Settings** area.  

1. Under **IoT**, select **IoT Settings**.

1. Select the **Device Data Pulls** tab.

1. Set **Scheduled Data Pull** to **On**. Then configure the frequency as needed.

> [!div class="mx-imgBorder"]
> ![Screenshot of the IoT settings, on the Device Data Pulls tab.](./media/cfs-device-pulls-schedule.png)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
