---
title: IoT data connections overview
description: Learn about options to integrate your IoT solution with Connected Field Service using Azure IoT Hub, service endpoints, or a multicloud strategy.
ms.date: 03/15/2024
ms.subservice: connected-field-service
ms.topic: overview
ms.author: vhorvath
author: vhorvathms
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/22/2023
  - bap-template
---

# IoT data connections overview

Choosing the right IoT (Internet of Things) solution for your business can be a challenge. One size doesn't always fit all. Dynamics 365 Field Service offers an extensible architecture that integrates with any IoT provider. Dataverse APIs and custom data endpoints allow you to customize your organization's IoT solution according to your unique business requirements. With this flexible approach, you can develop a scalable solution that's right for your business today and in the future.

## Connect with Microsoft services through Azure IoT Hub​

[Azure IoT Hub](/azure/iot-hub/iot-concepts-and-iot-hub) is a cloud-based service that provides a secure and scalable platform for connecting, monitoring, and managing IoT devices. It's our out-of-the-box solution for Connected Field Services. With Azure IoT Hub, you can [collect data from millions of devices and send it to the cloud](/azure/iot-hub/iot-hub-devguide-endpoints) for analysis, insights, and action. Bidirectional communication between IoT devices and the cloud allows you to remotely monitor and control your devices from anywhere.

:::image type="content" source="media/IoT-Hub-diagram.svg" alt-text="Diagram of the architecture for Connected Field Service that uses Azure IoT Hub as the IoT provider.":::

## Connect with Microsoft services using service endpoints

Service endpoints are a popular hybrid integration pattern used to connect your IoT solution with Field Service. One example is [Azure Event Hubs](/azure/iot-hub/iot-hub-compare-event-hubs), a cloud-based service that's designed to handle the significant amount of data that a large number of devices or systems can generate. It's ideal when you need to ingest and process data quickly and send it to other services for further processing or analysis. Azure Event Hubs is scalable, reliable, and fully managed, and can process and store millions of events per second.  

:::image type="content" source="media/IoT-ServiceEndpoint-diagram.svg" alt-text="Diagram of the architecture for Connected Field Service that uses service endpoints.":::

## Connect using a multicloud strategy

With a multicloud strategy, you choose the cloud provider that best suits the requirements of each application or service. You can adapt quickly to changes in your organization, industry, or market conditions. As your business evolves, applications or services may perform better or offer more cost-effective solutions on one cloud provider compared to another. A multicloud strategy lets you seamlessly migrate or deploy workloads to the most suitable cloud environment.

:::image type="content" source="media/IoT-multicloud-diagram.svg" alt-text="Diagram of a hybrid architecture for multicloud solutions.":::

## Privacy notice

[Read the privacy notice for Connected Field Service](cfs-privacy-notice.md).

## Next steps

- [Connected Field Service overview](connected-field-service.md)
- [IoT provider for custom IoT solutions](cfs-custom-iot-provider.md)
- [Architecture of Connected Field Service with IoT Hub](connected-field-service-architecture.md)

### See also

- [Microsoft Dataverse Developer Guide](/power-apps/developer/data-platform/overview)
- [Use Insomnia with the Web API](/power-apps/developer/data-platform/webapi/insomnia)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
