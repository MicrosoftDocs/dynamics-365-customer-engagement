---
title: How Connected Field Service with IoT Hub works
description: Learn about the architecture and data flow of Connected Field Service with IoT Hub, a solution that combines Azure IoT and Dynamics 365 Field Service.
ms.date: 08/08/2024
ms.subservice: connected-field-service
ms.author: vhorvath
author: vhorvathms
ms.topic: overview
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/21/2023
---

# How Connected Field Service with IoT Hub works

Connected Field Service with IoT Hub is a solution that integrates [Azure Internet of Things (IoT)](/azure/iot) and Dynamics 365 Field Service. It lets you monitor and manage your Internet-connected devices and equipment from the cloud. You can also automate the creation of work orders and dispatch technicians when a device needs service.

This article explains how Connected Field Service works including how the main components communicate with each other and how the data flows between the devices and the cloud.

In this article, *data* refers to information that an IoT device sends to the cloud. *Devices* and *sensors* refer to Internet-connected things that take measurements, like thermometers, gyroscopes, and pressure readers. An *asset* is a piece of equipment that can have one or more sensors connected to it.

## Architecture overview

The following diagram shows the main components of Connected Field Service with IoT Hub and how they connect with each other.

:::image type="content" source="media/cfs-iothub-architecture.png" alt-text="Diagram illustrating the components of Connected Field Service with IoT Hub and the connections between them.":::

The main components include:

- **IoT Devices & Edge**: Internet-connected sensors on equipment send data to IoT Hub over a network. A single asset can have multiple sensors for different measurements. An *Edge device* can be used to organize and broker data from multiple sensors and assets. However, telemetry data on IoT Edge modules can't be split.

- **Device Simulator**: A tool that lets you simulate devices and alerts in the cloud before installing the hardware.

- **IoT Hub**: The gateway to the cloud that receives and sends data from and to the devices. It also provides device management and security features.

- **Azure Stream Analytics**: A service that queries device data as it enters IoT Hub and detects faults based on threshold rules.

- **Threshold Rules Store**: A database that stores the acceptable boundaries for device data. If data exceeds these boundaries, it's considered a fault.

- **Service Bus**: A service that queues faults and transfers them to Dynamics 365. It also handles retries if the transfer fails.

- **Stream Analytics & Azure SQL**: A service and a database that store device data for analysis and reporting. For example, you can use them to predict device failures based on historical data.

- **Logic App Azure to Dynamics**: A service that connects Azure with Dynamics 365 and other applications. It also applies logic, maps entities, and triggers actions in Dynamics 365, such as creating an IoT alert record.

- **IoT Alert**: A record in Dynamics 365 that shows the device data that needs attention. It starts the process of creating a case and a work order.

- **Connected Field Service Model Driven App**: A set of entities and processes built on Dynamics 365 Field Service. It lets you connect IoT devices with customer assets and manage them from a unified interface.

- **Field Service Dispatchers & Technicians**: The end users of Connected Field Service who interact with IoT alerts, cases, and work orders on their devices.

- **Devices and Assets**: Entities in Dynamics 365 that help you manage the sensors and equipment that your organization owns.

- **Registration, Commands & Properties**: Processes for bi-directional communication with the devices through IoT Hub. For example, you can register new devices, reboot them, or display a message on them.

- **Logic App Dynamics to Azure**: A service that connects Dynamics 365 with Azure and sends data and actions to IoT Hub. IoT Hub then sends them to the devices.

## Data flow of Connected Field Service

The following diagram shows how data flows between the Azure IoT Hub and Connected Field Service components. It also shows the direction and order of the data flow for a standard installation of Connected Field Service.

 [Download the data flow diagram](https://download.microsoft.com/download/3/A/7/3A744B76-3E04-49F5-A30B-938400CEB73E/AzureIoTCfsDataFlowDiagram.jpg).

The data flow diagram helps you understand how Connected Field Service works in different scenarios. For example, you can see how a device sends data to IoT Hub, how IoT Hub detects a fault and sends an IoT alert to Dynamics 365. It also shows how Dynamics 365 creates a case and a work order for the fault.

## Next steps

- [Azure subscription prerequisites for Connected Field Service with IoT Hub](cfs-azure-subscription.md)
- [Install and configure Connected Field Service for Azure IoT Hub](installation-setup-iothub.md)
- [Create IoT alerts and convert IoT alerts into work orders](cfs-iot-alerts.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
