---
title: Installation and setup for Connected Customer Service with Azure IoT Hub
description: Learn how to install and configure Connected Customer Service with Azure IoT Hub, including prerequisites, deployment, device simulation, and optional Power BI integration.
ms.date: 03/30/2026
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Installation and setup of Connected Customer Service with Azure IoT Hub

This article explains how to install and set up Connected Customer Service with Azure IoT Hub. After setup, Customer Service can ingest device telemetry, generate IoT alerts, create cases, and send commands to registered devices.

For scenarios that use Azure IoT Central instead of IoT Hub, learn more in [Connected Customer Service for Azure IoT Central](connected-customer-service-iot-central-overview.md).

## Prerequisites

Before you install Connected Customer Service with Azure IoT Hub, make sure that the following requirements are met:

- A Customer Service environment with **System Administrator** access
- Microsoft 365 global administrator access
- The **System Administrator** security role in Customer Service
- The **IoT Administrator** role to access IoT entities and functionality
- A supported Customer Service role such as **Customer Service Dispatcher**
- An active Azure subscription with sufficient privileges  

For Azure-specific requirements, learn more in [Azure subscription prerequisites for Connected Customer Service with IoT Hub](azure-subscription-prerequisites-iot-hub.md).

### Optional: Power BI requirements

If you want to visualize device data, you also need:

- A Power BI account
- Power BI Desktop
- A Power BI Pro license to publish and share reports

You can download the sample Power BI template for Connected Customer Service from the Microsoft Download Center.

## Install Connected Customer Service

Connected Customer Service is included with Customer Service.

You can install it by either:

- Creating a new Customer Service environment, or  
- Upgrading an existing environment to a supported version (for example, version `9.0.20034.x`)

After installation, the following entities and processes are available in your environment:

- Devices  
- IoT alerts  

These entities appear in the **Customer Service** app navigation.

## Deploy and connect Azure IoT Hub

To connect Azure IoT Hub to your Customer Service environment, perform the following steps:

1. Open the IoT deployment app: [iotdeployment.dynamics.com](https://iotdeployment.dynamics.com)
1. Complete the deployment steps to provision and connect the required Azure resources.
1. When deployment is complete, verify that the Azure IoT Hub is connected to your Customer Service environment.

## Set up the device simulator (optional)

You can use the device simulator to test telemetry and commands without physical hardware.

Perform the following steps:

1. In the Azure portal, open the resource group created by the deployment app.
1. Select the **App Service** resource.
1. Copy the app URL from the top-right corner and open it in a browser.
1. On the simulator page, select **Configuration**.
1. Enter the following values from your IoT Hub:
   - **Host name**
   - **Primary key**

   You can find these values in the Azure portal under **IoT Hub** > **Shared access policies**. Use the **iothubowner** policy.

1. Confirm that the connection status shows **Connected**.
1. Send test telemetry, such as increasing a temperature value above a configured threshold.

## Visualize device data with Power BI (optional)

You can use Power BI to visualize device telemetry stored in Azure SQL Database.

Perform the following steps:

1. Create or sign in to a Power BI account at [https://powerbi.microsoft.com](https://powerbi.microsoft.com).
1. Install **Power BI Desktop**.
1. Download and open the sample Power BI report template for Connected Customer Service.
1. Replace the sample SQL connection with the SQL database created in your Azure resource group.
1. Publish the report to Power BI and provide SQL credentials when prompted.
1. Pin report tiles to a Power BI dashboard and share the dashboard with users who need access.

### Add Power BI tiles to Customer Service records

To display Power BI tiles in Customer Service, perform the following steps:

1. Open a device or IoT alert record.  
   The device must be registered and have a device ID.
1. Select **Add** in the Power BI section.
1. Choose the dashboard tile and save the configuration.

The tile automatically filters data based on the current device or alert.

## Categorize devices

You can organize devices by using IoT device categories.

Perform the following steps:

### Create a device category

1. Open the **Copilot Service admin center**.
1. Select **Operations** > **Miscellaneous**.
1. Under **Device Categories**, select **Manage**.
1. Select **New**, enter a name, and save the record.
1. Add one or more devices to the category.

### Add a device to an existing category

1. In the **Customer Service** app, select **Internet of Things** > **Registered Devices**.
1. Open a device record.
1. In the **Category** field, select an existing device category.
1. Select **Save**.

## View device readings

After a device is registered, you can view recent telemetry values associated with the device.

1. In the **Customer Service** app, select **Devices**.
2. Open a device record.
3. Review telemetry in the **Connected Device Readings** section.

By default, the last 20 readings are displayed. You can adjust this value in Power BI Desktop.

## Send commands to devices

You can send commands to devices from a device record or directly from an IoT alert.

### Send a command from a device record

1. In the **Customer Service** app, open a registered device.
1. Select **Send Command**.
1. Enter the command name and parameters.
1. Select **Send & Close**.

> [!Note]
> Ensure that the command payload doesn't include extra spaces or invalid characters.

### Respond to an IoT alert

1. In the **Customer Service** app, select **IoT Alerts**.
1. Open an alert record.
1. Select **Send Command**, enter the command details, and send the command.

### View command history

To view the history of commands sent to a device:

1. Open a device record.
1. Scroll to the **Commands** section.

## Automate IoT alert handling

You can guide or automate responses to IoT alerts by using business process flows. Business process flows help service teams diagnose issues, send commands, and create cases or work orders when escalation is required.

Learn more in [Create a business process flow](create-business-process-flow.md).

## View the IoT dashboard

The default IoT dashboard provides visibility into:

- Registered devices
- IoT alert trends
- Resolution actions

You can customize dashboards to support your service scenarios.

## Privacy notice

Installing Connected Customer Service deploys Azure resources in your subscription. Customer Service sends device registrations, telemetry, and commands to Azure to enable IoT scenarios.

Administrators can uninstall Connected Customer Service and manage related Azure resources in the Azure portal.

Learn more in the [Microsoft Azure Trust Center](https://www.microsoft.com/trust-center).

[!INCLUDE [footer-banner](../includes/footer-banner.md)]

