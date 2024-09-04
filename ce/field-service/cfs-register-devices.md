---
title: Register IoT devices (contains video)
description: Learn about IoT devices and how to register them in Dynamics 365 Field Service.
ms.date: 09/04/2024
ms.subservice: connected-field-service
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: vhorvath
author: vhorvathms
---

# Register IoT devices

An appliance or other asset must have sensors and connect to an Internet of Things (IoT) backend to take device readings and send that information to the cloud. These sensors are called IoT devices.

Field technicians can interact with IoT devices in several ways:

- A field technician is installing an entirely new asset like an air conditioner. The air conditioner has an embedded IoT device or devices. The technician must register that device with the appropriate IoT backend in order for the device to start working.

- A field technician is servicing an existing asset and installs a new IoT device that starts sending signals to an IoT backend.

- A field technician uses data from existing IoT devices to troubleshoot their maintenance or repairs.

Register a new IoT device in Connected Field Service and associate it with the correct customer asset in Field Service. While you can use [custom IoT providers with Connected Field Service](cfs-custom-iot-provider.md), this article uses [Azure IoT Hub](installation-setup-iothub.md) in the following examples. For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4GEjn]

## Prerequisites

Connected Field Service is connected to Azure IoT Hub or another custom IoT provider.

## Create and register an IoT device from IoT Hub

Register a new device from Azure IoT Hub.

1. Sign in to Microsoft Azure and access the Azure IoT Hub.

1. Select an environment.

1. Select **IoT devices** > **+New**.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the IoT devices screen in Azure IoT Hub.](./media/cfs-register-device-iothub-new.png)

1. Enter a descriptive ID and select **Save**.

1. In Dynamics 365 Field Service, under **Assets**, select **IoT Devices**.

1. Select **Import Devices**.

   :::image type="content" source="media/cfs-register-device-iothub-import.png" alt-text="Screenshot of Field Service on the Active IoT Devices list after selecting Import Devices.":::

1. Select **OK** and then **Refresh**. Any new devices registered in Azure IoT Hub appear in the list of active IoT devices.

## Create and register an IoT device from Field Service

You can also create an IoT device directly in Field Service.

1. In Dynamics 365 Field Service, under **Assets**, select **IoT Devices**.

1. Select **New**.

1. Enter a descriptive name for the device and any other information, then select **Save**.

1. Select **Register**. Information about the new device is sent to Azure IoT Hub. A device ID is generated and appears on the **IoT Device** page in Field Service.

   :::image type="content" source="media/cfs-register-device-fs-new-register.svg" alt-text="Screenshot of the register option on an IoT device in Field Service.":::

1. Back in Azure IoT Hub, the IoT device created in Field Service appears with its new device ID.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of Azure IoT Hub, showing the new device in the list of devices.](./media/cfs-register-device-fs-new-register-iothub.png)

If the device doesn't register, an error appears in the **Registration Status** field of the asset record. An error might occur if Dynamics 365 isn't connected to Azure or if Azure is offline.

## Connect to asset

The registered IoT device must be associated with a new or existing customer asset.

1. In Field Service, under **Assets** select **Assets**.

1. Open the customer asset to associate with the new IoT device.

1. Select **Connect Device** and find the new IoT device.

   :::image type="content" source="media/cfs-register-device-fs-associate-asset.png" alt-text="Screenshot of the connect device dialog on an asset record in Field Service.":::

   A new section appears called **Connected Devices** that shows information about the new IoT device.

   :::image type="content" source="media/cfs-register-device-fs-associate-asset-more.png" alt-text="Screenshot of the Connected Devices section on the customer asset record in Field Service.":::

Multiple IoT devices can be associated with a single customer asset. On the asset, go to **Related** > **Connections** to connect more IoT devices.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
