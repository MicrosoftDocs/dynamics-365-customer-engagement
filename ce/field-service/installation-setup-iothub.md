---
title: "Installation and setup for Connected Field Service for Azure IoT Hub (Dynamics 365 Field Service) | Microsoft Docs"
description: Learn how connect and setup Dynamics 365 Field Service with Azure IoT Hub.
ms.date: 07/27/2022
ms.reviewer: mhart

ms.subservice: connected-field-service
ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
  - D365CE
  - D365FS
---
# Installation and setup - Connected Field Service for Azure IoT Hub

This guide provides all the steps required for getting up and running with Connected Field Service (CFS) for IoT Hub.

> [!NOTE]
> Time Series Insights (TSI) will be deprecated after March 2025. We'll transition Connected Field Service to a new platform and announce it when the deprecation takes place. More information: [Migrate to Azure Data Explorer](/azure/time-series-insights/migration-to-adx)

## Prerequisites

 Ensure the following before configuring Connected Field Service.
  
- Dynamics 365 Field Service. For more information, visit the [article on installing Dynamics 365 Field Service](../field-service/install-field-service.md).
  
- Assign your Dynamics 365 user the System Administrator and IoT-Administrator security roles. 

- An active Azure subscription with appropriate privileges. For more information, see the [article on Azure prerequisites](cfs-azure-subscription.md).

## Step 1: Install or upgrade Field Service  
 
Connected Field Service is included with Dynamics 365 Field Service. Creating a new Field Service environment or upgrading an existing one to v7.5.5 or v8.3+ will automatically include the following Connected Field Service entities and related processes:

- Assets
- IoT alerts
- Devices
- Commands
 
> [!div class="mx-imgBorder"]
> ![Screenshot of IoT alerts in the asset menu in the sidebar.](./media/cfs-navigation.png)

Verify you have the Connected Field Service entities in your environment.

## Step 2: Deploy Connected Field Service and Azure resources

Next, deploy and connect Azure IoTHub to your Field Service environment by going to [https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment](https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment) and following the instructions.

<!-- >> [!div class="mx-imgBorder"]
> ![Screenshot of the IoT deployment app.](./media/cfs-deployment-app-screen-1.png) -->

> [!Note]
> If you are using an older version of Field Service and cannot upgrade, you can add the connected field service solution in your field service environment from the app store.

Before proceeding, make sure all required Azure resources are successfully deployed and that the overall deployment status is **Success**.  

## Step 3: Authorize Azure app connection

Sign into your Azure account, and then go to the [Azure portal](https://portal.azure.com).

From there, go to **Resource Groups** and find the resource group you recently deployed IoTHub to. See the following screenshot for reference.

> [!div class="mx-imgBorder"]
> ![Screenshot of Azure resource groups.](./media/cfs-iothub-resource-group.png)

One such resource will be an API Connection type to Dynamics CRM. Select and edit this resource.

> [!div class="mx-imgBorder"]
> ![Screenshot of API connection between dynamics and azure.](./media/cfs-iothub-api-connection.png)

Select **Authorize** and sign in with your Dynamics 365 credentials that you use to sign into your Connected Field Service environment. They may be different than your Azure credentials to the Azure portal. Select **Save** to apply your changes.

> [!div class="mx-imgBorder"]
> ![Screenshot of authorizing the subscription.](./media/cfs-iothub-api-connection-authorize.png)

Congratulations! You are now ready to pass data between Azure IoT Hub and Dynamics 365 to use Connected Field Service.

Back in Dynamics 365 Field Service, go to **Settings** > **Providers** to see your Azure IoT Hub subscription connected as an IoT provider.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service, showing active IoT provider instances.](./media/cfs-deploy-providers.png)
  
## Step 4: Set up the simulator (optional) 

The simulator will allow you to test Connected Field Service without the need to connect physical hardware. By simulating IoT devices and data, you can understand all the different parts that contribute to turning IoT data into work orders. 

Set up the simulator to simulate IoT devices and data and begin to see device data pulled into Field Service.

To find the simulator URL, sign in to your Azure subscription, and then select the App Service resource type under the newly created resource group. You’ll see the URL is in the top-right corner. Copy the URL and complete the following steps:  
  
1. Paste the URL into your browser’s address bar to load the page.  
  
2. When the simulator page opens, select **Configuration**.  
  
3. Enter the IoT hub host name and key. The host is simply the name of the IoT Hub resource in Azure portal. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the "configure connection" dialog in Azure.](./media/cfs-iothub-thermostadt-simulator.png)

 The key can be accessed by selecting the IoT Hub resource and going to the shared access policies, then copying the primary key for **iothubowner** as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of Azure IoT Hub showing the primary key.](./media/cfs-simulator-connection.png)
  
1. Select the IoT hub in the **Resource Group**.  
  
2. On the left under **General**, select **Shared access policies** to get the host name and primary key.  
  
3. Make sure **Connection status**  is marked as **Connected** and then close the dialog box.  

Now you can send a test command by using the sample simulator. For example, select the temperature and increase it to above 70 degrees. The simulator is preprogrammed to create an IoT alert if temperature is above 70 degrees.

## Next steps

1. [Register devices](cfs-register-devices.md)
2. [Pull device data](cfs-pull-device-data.md)
3. [Visualize device readings](cfs-visualizations-iot-hub.md)

## Privacy notice
[!INCLUDE[cc_privacy_crm_connected_field_service](../includes/cc-privacy-crm-connected-field-service.md)]

[Azure Time Series Insights](/azure/time-series-insights/)

[Connected Field Service Device Readings](cfs-visualizations-iot-hub.md) uses Azure Time Series Insight to store, process, and query IoT devices measurements from IoT Hub.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
