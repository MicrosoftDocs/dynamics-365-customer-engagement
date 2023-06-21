---
title: IoT integration with Connected Field Service
description: Integrate your IoT solution with Microsoft services or a multicloud strategy for a scalable, customized solution.
ms.date: 06/21/2023
ms.subservice: connected-field-service
ms.topic: overview
ms.author: vhorvath
author: vhorvathms
---

# IoT integration with Connected Field Service

Choosing the right IoT solution for your business is a challenge. Often, there's no "one size fits all" solution. Dynamics 365 Field Service offers an extensible architecture that integrates with any IoT solution. Dataverse APIs and custom data endpoints empower your organization customize you IoT solution according to your unique business requirements. This flexible approach lets you develop a scalable solution that is unique to your business today and in the future.

## Connect with Microsoft services through Azure IoT Hub​

[Azure IoT Hub](/azure/iot-hub/iot-concepts-and-iot-hub) is a cloud-based platform-as-a-service (PaaS) solution that provides a secure and scalable platform for connecting, monitoring, and managing IoT devices. It's also our out of the box solution for Connected Field Services. With Azure IoT Hub, you can [collect data from millions of devices and send that data to the cloud](/azure/iot-hub/iot-hub-devguide-endpoints) for analysis, insights, and action. Azure IoT Hub also enables bidirectional communication between IoT devices and the cloud, allowing you to remotely monitor and control your devices from anywhere.

:::image type="content" source="media/IoT-Hub-diagram.svg" alt-text="Diagram with the architecture for Connected Field Service that uses Azure IoT Hub as IoT provider.":::

## Microsoft services using service endpoints

Service endpoints are a popular hybrid integration pattern used to connect your IoT solution with Field Service, allowing your organization to collect and analyze real-time data from IoT devices. For example, using [Azure Event Hubs, a cloud-based service that is designed for large-scale event ingestion and processing scenarios](/azure/iot-hub/iot-hub-compare-event-hubs) for significant data volume that gets generated from a large number of devices or systems. It's ideal for scenarios where the focus is on ingesting and processing data quickly and then sending it to other services for further processing or analysis. Azure Event Hubs is scalable and fully managed, providing a reliable event ingestion service that can process and store millions of events per second.  

:::image type="content" source="media/IoT-ServiceEndpoint-diagram.svg" alt-text="Diagram with the Connected Field Service architecture using service endpoints.":::

## Multicloud strategy

A multicloud strategy lets you choose the cloud provider that best suits the specific requirements of each application or service. This flexibility uses the unique strengths and capabilities of different cloud providers, enabling you to tailor your infrastructure to meet your evolving business needs.

With a multicloud approach, you can adapt quickly to changes in your organization, industry, or market conditions. As your business evolves, applications or services may perform better or offer more cost-effective solutions on one cloud provider compared to another. A multicloud strategy lets you seamlessly migrate or deploy workloads to the most suitable cloud environment.

The following diagram illustrates how organizations integrate with a combination of Microsoft services and their preferred cloud provider. Make use of Microsoft's extensive offerings while still benefiting from the unique capabilities of your cloud provider. This hybrid approach enables customized solutions that best align with your business goals and technical requirements.

:::image type="content" source="media/IoT-multicloud-diagram.svg" alt-text="Diagram with a hybrid architecture for multicloud solutions.":::

In the next diagram, Field Service takes advantage of the [Dataverse platform](/power-apps/maker/data-platform/data-platform-intro) to unlock its full extensibility potential. This flexibility allows you to tailor your IoT solution to your specific needs, whether you prefer a simple or complex implementation.  

:::image type="content" source="media/IoT-multicloud-diagram-simple.svg" alt-text="Diagram with simplified architecture for multicloud solutions.":::

To gain a deeper understanding of making API calls into Dataverse, see the [Microsoft Dataverse Developer Guide](/power-apps/developer/data-platform/overview). Additionally, see [Use Postman with the Web API](/power-apps/developer/data-platform/webapi/use-postman-web-api), which provides valuable instructions for setting up Postman and conducting API testing with Dataverse.

## Next steps

- [Connected Field Service overview](connected-field-service.md)
- [IoT provider for custom IoT solutions](cfs-custom-iot-provider.md)
- [Architecture of Connected Field Service with IoT Hub](connected-field-service-architecture.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
