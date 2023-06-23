---
title: Send commands in Connected Field Service
description: Send commands to IoT devices with Field Service to remotely control them.
ms.date: 06/23/2023
ms.topic: how-to
ms.subservice: connected-field-service
ms.custom: bap-template
ms.author: vhorvath
author: vhorvathms
---

# Send commands in Connected Field Service

Dynamics 365 Field Services enables seamless bi-directional communication with your IoT devices. It empowers your organization to not only gather data from IoT devices but also send commands and receive real-time updates. This symmetrical flow of information enhances control, monitoring, and decision-making capabilities within the IoT infrastructure.

Commands are programed instructions sent from the Field Service application to IoT devices. They direct devices to perform specific actions, retrieve data, or modify their existing configurations. Commands consist of IoT definition properties that provide a standardized framework for understanding and interacting with device data. These properties represent the attributes or characteristics of IoT devices that can be monitored or controlled. For example, the IoT definition properties for a thermostat may include temperature and humidity.

> [!TIP]
> Commands for an IoT device are usually documented in the device manual or API documentation. These resources provide detailed information on the available commands, their syntax, and how to interact with the device programmatically.

## Create IoT definition properties

Before configuring an IoT command in Field Service, you first need tocreate IoT definition properties.

1. In Field Service, change to the **Settings** area.
1. Under **IoT**, select **IoT Property Definitions** and add a new record.
1. Enter a **Name** and choose the **Type** of data for the property.

## Configure IoT commands

1. In Field Service, change to the **Settings** area.
1. Under **IoT**, select **Command Definitions** and add a new record.
1. In the **Name** field, add the command definition. For example: Reset Thermostat.
1. **Save** the record.
1. In the **Command Parameters** section, select the vertical ellipsis &vellip; and choose **Add Existing IoT Property**.
1. Select a IoT property definition record and select **Add** and save the record again.

## Send a command on an active IoT alert

In Field Service, open the **Service** area.
Under **Assets**, select **IoT Alerts** and open an existing IoT alert record.
On the Iot alert record, select **Send Command**.
Choose a command definition in the **Command** field and select **Send Command**.

## Thermostat simulator commands

If you use the [IoT deployment template for Azure IoT Hub](installation-setup-iothub.md), you can choose to install a thermostat simulator. The following table lists commands that you can send to the thermostat simulator.

|       Command  |     Command Message String   |
|---|---|
|     Reset Thermostat  |   {"CommandName":"Reset Thermostat","Parameters":{}}  |
|     Notification  |   {"CommandName":"Notification","Parameters”: {"Message":"Technician has been dispatched"}}  |
|     Update IoT property definitions    |      {"CommandName":"Set Values","Parameters”: {"Reading":{"Temperature":"70","Humidity":"60"}}}    |

## Next steps

- [Create IoT alerts and convert IoT alerts into work orders](cfs-iot-alerts.md)
- [AI suggestions for IoT alerts](iot-alerts-ai-based-suggestions.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
