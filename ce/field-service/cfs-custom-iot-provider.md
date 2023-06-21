---
title: IoT provider for custom IoT solutions
description: Understand how to integrate external IoT solutions with Connected Field Service using Dataverse APIs, webhooks, connectors, custom code, and more.
ms.date: 06/21/2023
ms.subservice: connected-field-service
ms.topic: conceptual
ms.author: vhorvath
author: vhorvathms
ms.custom: bap-template
---

# IoT provider for custom IoT solutions

Dynamics 365 Field Service allows seamless integration with IoT-enabled devices from any IoT vendor through the *IoT provider* feature. The IoT provider allows the integration of IoT alerts from various vendors into a unified list, regardless of their origin. When users interact with an IoT device, Field Service identifies the device's provider and routes the command to the corresponding IoT system.

In Field Service, the [out-of-box deployment experience integrates with Azure IoT Hub](installation-setup-iothub.md). However, custom IoT providers let developers, partners, and independent software vendors build on this framework to include their custom IoT solutions. These custom IoT providers can then be published as solutions in the [Microsoft commercial marketplace](https://appsource.microsoft.com/) for easier distribution and usage by customers.

## Prerequisites

- Development experience in model-driven apps that connect to Dynamics 365 and Microsoft Dataverse. For more information, see the [overview on model-driven apps](/powerapps/developer/model-driven-apps/overview).
- Programming experience with C#, .NET, and Visual Studio.
- Knowledge of REST/OData API.

## Architecture and entity model

In this article, we focus on the integration of IoT solutions.

There are several methods to integrate external IoT services with Field Service. However, they all must fit the Field Service IoT provider entity model. The following sections discuss the entities in detail.

:::image type="content" source="media/cfs-entity-model.svg" alt-text="Diagram showing the entity model and relationships between entities.":::

### IoT provider entity

This entity identifies the IoT provider and its supported actions.

:::image type="content" source="media/iot-hub-provider.png" alt-text="Screenshot of an IoT provider record.":::

Required information:

- **Entity name**
- **IoT source**
  - Other
  - IoT Suite
  - IoT Central
- **Action names**. For more information about actions, see [Configure IoT provider actions](cfs-configure-actions.md).

### IoT provider instance entity

As shown in the diagram, the IoT provider instance is the organization's instance of the provider. For example, if your Connected Field Service organization is connected to two different Azure IoT Hubs, you have two IoT provider instance records, one for each of your IoT Hub instances. You can see the list of IoT provider instances within your Field Service app by going to **Settings** > **IoT** > **Providers**.

:::image type="content" source="media/cfs-iot-hub-provider-instance.png" alt-text="Screenshot of an IoT Provider Instance record.":::

Required information:

- **Provider Instance ID**. Indicates the identifier within your source IoT system.
- **URL**. A URL that could be used in your provider code or the user experience. For example, an API endpoint or a link to the Azure resource group of the deployment.

### IoT device

The IoT device entity maps each device to an IoT provider instance.

Required information:

- **Name**.
- **Account**. Customer account in Field Service that the IoT device maps to.
- **Category**. The device category that the IoT device belongs to.
- **Time Zone**. The IoT device time zone.
- **Device ID**. The IoT device ID used to register with the IoT provider.
- **Simulated**. Used for development and testing purposes.
- **IoT Provider Instance**. The IoT provider instance that the IoT device is assigned to.

## Connection methods and development tools

Connection methods for custom solutions come with pros and cons. The following table lists common connection methods.

|       Method    |     Advantages    |     Risks    |
|---|---|---|
|     [Dataverse APIs](/power-apps/developer/data-platform/overview)          |   Allows direct communication between Connected Field Service and external services. It's a robust protocol for building software applications.   |   External services need to have capability to integrate with APIs. This method requires strong understanding of Connected Field Service API capabilities.   |
|     Webhooks     |   Sends real-time updates to an external service when specific actions are taken in Connected Field Service.    |   External service needs to be able to receive and process webhook messages.   |
|     Connectors     |   Provides seamless integration experience, acts as a bridge between Connected Field Service and the external service.   |   Requires more robust technical knowledge and development resources.   |
|     Custom code     |   Highly tailored and effective integration.     |   Requires high level of technical expertise, may involve more risk than other methods.   |

Commonly used development tools to build custom solutions for Connected Field Service:

- **Power Apps**, a low-code development platform provided by Microsoft that allows developers to create custom business applications quickly and easily. With Power Apps, developers can build custom solutions for Connected Field Service without the need for extensive coding skills.

- **Azure Functions**, a serverless computing service provided by Microsoft that allows developers to run code on-demand without the need for dedicated servers. Azure Functions can be used to create custom integrations and automate tasks in Connected Field Service.

- **.NET Framework**, a software development framework provided by Microsoft that supports building and running applications on Windows. It can be used to build custom applications and integrations for Connected Field Service.

- **JavaScript**, a widely used programming language that can be used to create custom applications and integrations for Connected Field Service. It's often used with other tools and frameworks, such as Node.js and React.

- **REST APIs** provide a standardized way for applications to communicate with each other over the web. Connected Field Service provides many REST APIs that can be used to integrate with external services and build custom solutions.

- **Visual Studio**, a popular integrated development environment (IDE) provided by Microsoft that can be used to build custom applications and integrations for Connected Field Service. It supports a wide range of programming languages and frameworks, including .NET, JavaScript, and Python.

## Next steps

- [Configure IoT provider actions](cfs-configure-actions.md)
- [Send commands in Connected Field Service](cfs-commands.md)
- [IoT integration with Connected Field Service](cfs-connect-data-overview.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
