---
title: Prerequisites for setting up Connected Customer Service for Azure IoT Central
description: Prerequisites for connecting Azure IoT Central to Connected Customer Service using Power Automate.
ms.date: 03/30/2026
topic: overview
author: lalexms
---

# Prerequisites for setting up Connected Customer Service for Azure IoT Central

Before you connect Azure IoT Central to Connected Customer Service by using Power Automate, complete the following prerequisites.

## Prerequisite tasks

To set up Connected Customer Service with Azure IoT Central, you must complete these tasks:

- Provision an Azure IoT Central application.
- Obtain a Customer Service environment with system administrator credentials.
- Install the Connected Customer Service add-on from the Dynamics 365 admin center.

## Provision an Azure IoT Central application

Azure IoT Central provides industry templates that include device models and telemetry schemas for testing and evaluation scenarios. Templates are available for industries such as retail, energy, government, and healthcare.

To create an Azure IoT Central application, perform the following steps:

1. Go to [Azure IoT Central](https://azure.microsoft.com/services/iot-central/).
1. Select **Create a custom app**.
1. Choose a **Legacy template** or create a custom application from scratch.
1. Complete the application setup.

After the application is created, the Azure IoT Central application home page opens.

:::image type="content" source="media/cs-iot-azure-central-app-home.png" alt-text="Azure IoT Central application home page":::

## Customer Service environment requirements

You need a Customer Service environment with the following requirements:

- System Administrator security role
- Access to connect external services by using Power Automate

If you don't already have a Customer Service environment, you can create one by signing up for a free trial for development or evaluation. Learn more in [Sign up for a Dynamics 365 Customer Service free trial](https://learn.microsoft.com/dynamics365/customer-service/implement/try-customer-service).

## Install Connected Customer Service

Connected Customer Service is installed from the Dynamics 365 admin center. After installation, the required entities and processes—such as **Devices** and **IoT alerts**—are available in the Customer Service environment.

After installation completes, you can connect Azure IoT Central to Connected Customer Service by using Power Automate.

[!INCLUDE [footer-banner](includes/footer-banner.md)]

