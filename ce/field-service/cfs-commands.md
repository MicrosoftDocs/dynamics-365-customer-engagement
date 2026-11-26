---
title: Send commands in Connected Field Service
description: Send commands to IoT devices with Field Service to remotely control them.
ms.date: 10/03/2025
ms.topic: how-to
ms.subservice: connected-field-service
ms.custom: bap-template
ms.author: vhorvath
author: vhorvathms
---

# Send commands in Connected Field Service

Dynamics 365 Field Services enables seamless bi-directional communication with your IoT devices. It empowers your organization to not only gather data from IoT devices but also send commands and receive real-time updates. This symmetrical flow of information enhances control, monitoring, and decision-making capabilities within the IoT infrastructure.

Commands are programed instructions sent from the Field Service application to IoT devices. They direct devices to perform specific actions, retrieve data, or modify their existing configurations. Commands consist of IoT definition properties that provide a standardized framework for understanding and interacting with device data. These properties represent the attributes or characteristics of IoT devices that can be monitored or controlled. For example, the IoT definition properties for a thermostat might include temperature and humidity.

> [!TIP]
> Commands for an IoT device are usually documented in the device manual or API documentation. These resources provide detailed information on the available commands, their syntax, and how to interact with the device programmatically.

## Create IoT definition properties

Before configuring an IoT command in Field Service, you first need to create IoT definition properties. IoT definition properties help construct the message string for your IoT command.

1. In Field Service, go to the **Settings** area.
1. Under **IoT**, select **IoT Property Definitions**, and then select **New**.
1. Enter a **Name** and select the **Type** of data for the property.
1. Add information in the **Additional Properties** section. Select **Show string** to verify the constructed string.
1. Select **Save**.

:::image type="content" source="media/ioT-property-definition.png" alt-text="Screenshot of a filled out IoT property definition record.":::

## Configure IoT commands

1. In Field Service, go to the **Settings** area.
1. Under **IoT**, select **Command Definitions**, and then select **New**.
1. In the **Name** field, enter the command definition. For example: Reset Thermostat.
1. Select **Save**.
1. In the **Command Parameters** section, select the vertical ellipsis &vellip;, and then select **Add Existing IoT Property**.
1. Select an IoT property definition record, and then select **Add**.
1. Select **Save**.

:::image type="content" source="media/IoT-command-definition.png" alt-text="Screenshot of an IoT command definition record.":::

## Send a command on an active IoT alert

1. In Field Service, go to the **Service** area.
1. Under **Assets**, select **IoT Alerts**, and then open an existing IoT alert record.
1. On the IoT alert record, select **Send Command**.
1. Select a command definition in the **Command** field, and then select **Send Command**.

:::image type="content" source="media/IoT-alert-send-command.png" alt-text="Screenshot of an IoT alert with the send command dialog option.":::

## Next steps

- [Create IoT alerts and convert IoT alerts into work orders](cfs-iot-alerts.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
