---
title: IoT integration with Connected Field Service
description: Integrate your IoT solution with Microsoft services or a multicloud strategy for a scalable, customized solution.
ms.date: 05/06/2023
ms.subservice: connected-field-service
ms.topic: overview
ms.author: vhorvath
author: vhorvathms
---

# IoT integration with Connected Field Service

Choosing the right IoT solution for your business is a challenge. Often, there's no "one size fits all" solution. Dynamics 365 Field Service offers an extensible architecture that integrates with any IoT solution. Dataverse APIs and custom data endpoints empower your organization customize you IoT solution according to your unique business requirements. This flexible approach lets you develop a scalable solution that is unique to your business today and in the future.

## Connect with Microsoft services through Azure IoT Hub​

[Azure IoT Hub](/azure/iot-hub/iot-concepts-and-iot-hub) is a cloud-based platform-as-a-service (PaaS) solution that provides a secure and scalable platform for connecting, monitoring, and managing IoT devices. It's also our out of the box solution for Connected Field Services. With Azure IoT Hub, you can [collect data from millions of devices and send that data to the cloud](/azure/iot-hub/iot-hub-devguide-endpoints) for analysis, insights, and action. Azure IoT Hub also enables bidirectional communication between IoT devices and the cloud, allowing you to remotely monitor and control your devices from anywhere.

:::image type="content" source="IoT-Hub-diagram.svg" alt-text="Diagram with the architecture for Connected Field Service that uses Azure IoT Hub as IoT provider.":::

## Microsoft services using service endpoints

Service endpoints are a popular hybrid integration pattern used to connect your IoT solution with Field Service, allowing your organization to collect and analyze real-time data from IoT devices. For example, using [Azure Event Hubs, a cloud-based service that is designed for large-scale event ingestion and processing scenarios](/azure/iot-hub/iot-hub-compare-event-hubs) for significant data volume that gets generated from a large number of devices or systems. It's ideal for scenarios where the focus is on ingesting and processing data quickly and then sending it to other services for further processing or analysis. Azure Event Hubs is scalable and fully managed, providing a reliable event ingestion service that can process and store millions of events per second.  

// A picture containing circle, colorfulness, graphics

## Multicloud strategy

With a multicloud strategy, you can choose the cloud provider that best fits your needs for each application or service. Take advantage of the unique strengths and capabilities of each provider, and quickly adapt to changing business needs.

// A picture containing yellow, circle, amber

<!--
## Supported Developer Scenarios

Connected Field Service supports the following two primary development scenarios:  
  
- Extend Dynamics 365 Field Service so that manufacturers and hardware service organizations can register, monitor, and manage—including controlling and correcting—IoT devices. 
  
- Provide an IoT Platform that ISVs and partners can build on to IOT-enable their custom entities and managed solutions.  
  
 To enable the first scenario, the following capabilities are supported:  
  
- Abstract device registration in an action, so that devices can be easily registered using the CRM web client or the mobile client  
  
- Enable any CRM entity to be IOT-enabled, enabling straightforward IoT integration within existing business processes by using [Connection entities](../developer/connection-entities.md)  
  
- Receive service alerts and automating their response with a customized workflow  
  
- Send remote commands to IoT devices, for example after diagnosing a problem to correct a malfunctioning device  
  
- Analyze incoming device data, and displaying aggregate, trend and other metrics in custom dashboards  
- 
- -->