---
title: "Connected Field Service with IoTHub Architecture | MicrosoftDocs"
ms.custom:
 - dyn365-fieldservice
ms.date: 04/19/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology:
 - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to:
 - "Dynamics 365 (online)"
 - "Dynamics 365 Version 9.x"
author: gregdegruy
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType:
 - admin
 - customizer
search.app:
 - D365CE
 - D365FS
---

# Architecture of Connected Field Service with IoTHub

Connected Field Service with IoTHub brings together AzureIoT and Dynamics 365 Field Service. In this topic, you will find an explanation of the architecture and how it all works together.

## Prerequisites

To understand what's covered in this topic, you need to know that Connected Field Service (CFS) refers to a set of solutions, entities, and processes built on top of the Dynamics 365 Field Service app. As of Field Service v8.3+, CFS is included as part of Field Service.

For this topic, the words **data** and **telemetry** refer to information sent from an IoT device to the cloud. The words **devices** and **sensors** refer to internet-connected things like thermometers, gyroscopes, magnetometers, pressure readers, and more that take specific measurements. An **asset** is a piece of equipment that can have one or more sensors connected to it.

## Architecture

> [!div class="mx-imgBorder"]
> ![Diagram illustrating the connections between Connected Field Service with IoTHub architecture, and how each elements relate to each other](../media/cfs-iothub-architecture.png)

- **IoT Devices & Edge**: Internet-connected sensors on equipment send data to IoTHub typically via WiFi or cellular connectivity. A single piece of equipment can have multiple sensors each taking different measurements such as temperature and pressure. If a building or area has a collection of equipment each with multiple sensors, then an **Edge device** can be used to organize them and broker telemetry sent to IoTHub.

- **Device Simulator**: Administrators can simulate devices and telemetry for testing and development purposes before the hardware is set up. This lets them see how simulated alerts flow to Dynamics 365 Field Service and create work orders.

- **IoTHub**: The gateway to the cloud, capable of ingesting data on a large scale. IoTHub is a collection of applications and processes tailored to connected device scenarios that are also customizable. Deploying IoTHub will deploy a resource group with this collection of applications and processes.

- **Azure Stream Analytics**: Queries device data as it enters IoTHub. Data only passes through and is not stored.

- **Threshold Rules Store**: Helps decide if device data is abnormal and beyond acceptable boundaries. Abnormal data is characterized as a **Fault**.

- **Service Bus**: Takes faults and enters them into a queue to systematically keep track of them. The queue is helpful for scenarios where faults fail to get transferred to Dynamics 365 and should be attempted again after some time.

- **Stream Analytics & Azure SQL**: Used to store device data for longer time periods to perform data analysis. For example, this would be an option for organizations interested in analyzing large amounts of historical data to predict device failures in the future. This generally incurs a greater Azure cost.

- **Logic App Azure to Dynamics**: Connects Azure with Dynamics 365 (and other applications and platforms). Serves as a way to apply more logic, map entities, and trigger the appropriate actions in Dynamics 365, such as the creation of an **IoT Alert** record. Compare this to IoTCentral, which uses Power Automate.

- **IoT Alert**: Faults are passed from IoTHub to Dynamics 365 in the form of IoT alerts, which is an entity in Field Service. An IoT alert is the first part of the process inside Dynamics 365. An IoT alert is a subset of all device data that requires attention and potentially an action from the field service or customer service department.

- **Connected Field Service Model Driven App**: A set of entities and processes built on Dynamics 365 Field Service. Among other things, Connected Field Service allows you to connect IoT devices (sensors) with Field Service customer assets. As of Field Service v8.3+, Connected Field Service is built in and shipped with the Field Service app.

- **Field Service Dispatchers & Technicians**: The end users of Connected Field Service who interact with IoT alerts, cases, and work orders on their phones, tablets, and computers.

- **Devices and Assets**: Entities in Connected Field Service in Dynamics 365 that help you manage the sensors and equipment that your organization manages.

- **Registration, Commands & Properties**: Processes used in Connected Field Service to interact with and send data back to IoTHub and finally to the device, making CFS a bi-directional solution. For example, registration allows you to create a new device in CFS and register it in IoTHub. Commands allow you to execute actions on devices such as reboot. Another example is to display a message on the device for someone to view.

- **Logic App Dynamics to Azure**: The reverse of the previously explained Logic App, this adds detail to data and actions that need to be sent to IoTHub from Dynamics. IoTHub will then send the data or action to the connected device.


## Component data flow diagram
 A data flow between the Azure IoT Hub and Connected Field Services components is detailed in this [downloadable diagram](https://download.microsoft.com/download/3/A/7/3A744B76-3E04-49F5-A30B-938400CEB73E/AzureIoTCfsDataFlowDiagram.jpg). It details each information flow, its flow direction and relative order for a standard installation of [!INCLUDE[pn_connected_field_service_msdyn365](../../includes/pn-connected-field-service-msdyn365.md)].

### See also

[Connected Field Service with Azure IotHub Overview](https://docs.microsoft.com/dynamics365/customer-engagement/field-service/developer/connected-field-service-developer-guide)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]