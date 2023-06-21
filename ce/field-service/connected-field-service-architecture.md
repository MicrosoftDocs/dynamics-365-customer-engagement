---
title: Architecture of Connected Field Service with IoT Hub
description: Learn about how Connected Field Service uses IoT Hub architecture.
ms.date: 06/21/2023
ms.subservice: connected-field-service
ms.author: vhorvath
author: vhorvathms
ms.topic: overview
ms.custom: bap-template
---

# Architecture of Connected Field Service with IoT Hub

Connected Field Service with IoT Hub brings together Azure IoT and Dynamics 365 Field Service. Understand how the various components work together by reviewing the architecture.

Connected Field Service is a set of solutions, entities, and processes built on top of Dynamics 365 Field Service.

For this article, *data* refers to information sent from an IoT device to the cloud. *Devices** and *sensors* refer to internet-connected things that take measurements like thermometers, gyroscopes, or pressure readers. An *asset* is a piece of equipment that can have one or more sensors connected to it.

## Architecture

:::image type="content" source="media/cfs-iothub-architecture.png" alt-text="Diagram illustrating the connections between Connected Field Service with IoT Hub architecture, and how each element relates to others.":::

- **IoT Devices & Edge**: Internet-connected sensors on equipment send data to IoT Hub over a network. A single asset can have multiple sensors for different measurements. If a location has a collection of assets with multiple sensors, an *Edge device* can be used to organize them and broker data sent to IoT Hub.
  
  > [!NOTE]
  > Currently, the Connected Field Service implementation with IoT Hub doesn't support splitting the telemetry data for IoT Edge modules.

- **Device Simulator**: Administrators can simulate devices in the cloud setup and how simulated alerts flow to Dynamics 365 to create work orders before the hardware gets installed.

- **IoT Hub**: The gateway to the cloud, capable of ingesting data on a large scale. Azure IoT Hub is a collection of applications and processes tailored to connected device scenarios that are also customizable.

- **Azure Stream Analytics**: Queries device data as it enters IoT Hub. Data only passes through and isn't stored.

- **Threshold Rules Store**: Helps decide if device data is abnormal and beyond acceptable boundaries. Abnormal data is characterized as a *fault*.

- **Service Bus**: Takes faults and enters them into a queue to systematically track them. The queue is helpful if faults fail to get transferred to Dynamics 365 and should be attempted again after some time.

- **Stream Analytics & Azure SQL**: Stores device data to perform data analysis. For example, organizations can analyze large amounts of historical data to predict device failures in the future.

- **Logic App Azure to Dynamics**: Connects Azure with Dynamics 365 and other applications and platforms. Serves as a way to apply more logic, map entities, and trigger the appropriate actions in Dynamics 365, such as the creation of an **IoT Alert** record.

- **IoT Alert**: Faults are passed from IoT Hub to Dynamics 365 in the form of IoT alerts, which is an entity in Field Service. An IoT alert is starts the process in Dynamics 365. It consists of a subset of all device data that requires attention.

- **Connected Field Service Model Driven App**: A set of entities and processes built on Dynamics 365 Field Service. Among other things, Connected Field Service allows you to connect IoT devices (sensors) with Field Service customer assets.

- **Field Service Dispatchers & Technicians**: The end users of Connected Field Service who interact with IoT alerts, cases, and work orders on their phones, tablets, and computers.

- **Devices and Assets**: Entities in Connected Field Service in Dynamics 365 that help you manage the sensors and equipment that your organization owns.

- **Registration, Commands & Properties**: Processes used in Connected Field Service for bi-directional communication with the IoT Hub, which passes them on to the device. For example, registering new devices, reboot devices, or display a message on them.

- **Logic App Dynamics to Azure**: The reverse of the previously explained Logic App, adding detail to data and actions that need to be sent to the IoT Hub from Dynamics. IoT Hub then sends the data or action to the connected device.

## Component data flow diagram

 A data flow between the Azure IoT Hub and Connected Field Services components is detailed in this [downloadable diagram](https://download.microsoft.com/download/3/A/7/3A744B76-3E04-49F5-A30B-938400CEB73E/AzureIoTCfsDataFlowDiagram.jpg). It details each information flow, its flow direction and relative order for a standard installation of Connected Field Service for Dynamics 365.

## Next steps

- [Azure subscription prerequisites for Connected Field Service with IoT Hub](cfs-azure-subscription.md)
- [Install and configure Connected Field Service for Azure IoT Hub](installation-setup-iothub.md)
- [Create IoT alerts and convert IoT alerts into work orders](cfs-iot-alerts.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
