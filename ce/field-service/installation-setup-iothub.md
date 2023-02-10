---
title: "Installation and setup for Connected Field Service for Azure IoT Hub (Dynamics 365 Field Service) | Microsoft Docs"
description: Learn how connect and setup Dynamics 365 Field Service with Azure IoT Hub.
ms.date: 08/30/2022
ms.subservice: connected-field-service
ms.topic: article
ms.author: keithh
author: MSKeith
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
  
- Dynamics 365 Field Service is installed. For more information, visit the [article on installing Dynamics 365 Field Service](../field-service/install-field-service.md).
  
- Assign your Dynamics 365 user the System Administrator and IoT-Administrator security roles.

- An active Azure subscription with appropriate privileges to create resources and services. For more information, see the [article on Azure prerequisites](cfs-azure-subscription.md).

- Time Series Insights is required to get visualizations. To use TSI, [register an application](/azure/active-directory/develop/quickstart-register-app) in the Azure portal. Get the application ID, [add a client secret](/azure/active-directory/develop/quickstart-register-app#add-a-client-secret), and records the secret's value.

## Step 1: Deploy Connected Field Service and Azure resources

Deploy and connect Azure IoT Hub to your Field Service environment. Go to the **Deployment steps** section on [https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment](https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment) and deploy the Azure Resource Manager (ARM) template.

The deployment process creates a new resource group, asks for the [unique name of your organization](/power-platform/admin/determine-org-id-name#find-your-organization-name), and the [organization URL](/power-platform/admin/determine-org-id-name#find-your-environment-and-organization-id).

Before proceeding, make sure all required Azure resources are successfully deployed. The overall deployment status should show **Success**.  

## Step 2: Create new IoT Provider Instance

1. Sign into your Dynamics 365 organization and open the Connected Field Service app module.

1. In Connected Field Service, go to the **Settings** area.

   :::image type="content" source="media/cfs-iothub-settings-area.png" alt-text="Screenshot of the Change area control.":::

1. Select **Providers** and select **New**.

   :::image type="content" source="media/cfs-iothub-create-provider.png" alt-text="Screenshot of creating a new IoT Hub provider.":::

1. On the **New IoT Provider Instance** page, fill out the field:
   - **Name**: Enter the name of the resource group in Azure where you deployed IoT resources.
   - **IoT Provider**: Choose IoT Hub Provider.
   - **Provider Instance Id**: Enter the name of the IoT Hub resource that was deployed to your resource group in Azure.
   - **URL**: Enter the URL of the overview for the resource group in the Azure portal. Example: `https://portal.azure.com/[tenant_id]/subscriptions/[subscription_id]/resourceGroups/[resource_group_name]/overview`.

1. Select **Save** to create the new IoT Provider Instance record.

1. We now need to update the IoT Provider Settings for the newly created provider instance. In the **Settings** area, select **IoT Settings** > **IoT Provider Settings**.

   :::image type="content" source="media/cfs-iothub-default-provider-instance.png" alt-text="Screenshot of Default Provider Instance page.":::

1. For **Default IoT Provider**, set the **Instance** to the IoT Provider Instance you created previously.

1. Select **Save & Close** to save your changes.

## Step 3: Set up IoT endpoint

1. Install the [Power Platform CLI](/power-platform/developer/cli/introduction).

1. Open the CLI and launch the Plugin Registration Tool (PRT) with the command `pac tool prt`.

1. In the PRT window, select **Create New Connection** and sign in to the Dynamics 365 environment where you're setting up Connected Field Service.

1. Once connected to the organization, find the **IoT Message** Service Endpoint and select it.

1. Select **Update**.

1. For **NameSpace Address**, find the hostname for the [Service Bus Namespace](/azure/service-bus-messaging/explorer#use-the-service-bus-explorer) deployed to your resource group. Enter the hostname the Plug-in Registration Tool, prefixed by `sb://`. Example: `sb://myServiceBusNamespace.servicebus.windows.net`

1. In the Service Bus Namespace resource, go to **Queues** and find the queue with a name ending in `-crm`. Copy the full name and enter it as the **Topic Name** in the Plug-in Registration Tool.

1. In the Service Bus Namespace resource, go to **Shared access policies** > **RootManageSharedAccessKey**. Copy the [primary key](/azure/service-bus-messaging/service-bus-quickstart-topics-subscriptions-portal) and paste it into the Plug-in Registration Tool for **SAS Key**.

1. Select **Save**.

:::image type="content" source="media/cfs-iothub-register-service-endpoint.png" alt-text="Screenshot of Plug-in Registration Tool.":::

## Step 4: Authorize Azure app connection

Connect the Azure IoTHub to your Field Service environment.

1. Sign into your Azure account, and then go to the [Azure portal](https://portal.azure.com).

1. On the Azure portal, go to **Resource Groups** and find the resource group you recently deployed IoT Hub to. See the following screenshot for reference.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of Azure resource groups.](./media/cfs-iothub-resource-group.png)

1. One resource of type API Connection is called **commondataservice**. Select and edit this resource.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of API connection between dynamics and azure.](./media/cfs-iothub-api-connection.png)

1. Select **Authorize** and sign in with your Dynamics 365 credentials that you use to sign into your Connected Field Service environment. They may be different than your Azure credentials to the Azure portal. Select **Save** to apply your changes.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of authorizing the subscription.](./media/cfs-iothub-api-connection-authorize.png)

## Step 5: Update devicerules.json (optional)

The Stream Analytics job deployed to your resource group will have a reference to a `devicerules.json` file. This file defines a rule that is used to create IoT Alerts when using the thermostat simulator app. To use the rule, upload the `devicerules.json` file to the Azure storage. The file is available in the [GitHub repo](https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment).

1. In the storage account deployed to your resource group, create a container called `devicerules`.

1. In the storage account, use the Storage Browser to open the newly created `devicerules` container.

1. Add a directory in the `devicerules` container named `2016-05-30`.

1. In the `2016-05-30` directory, create another directory called `22-40`.

1. In the `22-40` directory, upload the `devicerules.json` file.

## Step 6: Start Azure Stream Analytics job

1. Sign into your Azure account, and then go to the [Azure portal](https://portal.azure.com).

1. On the Azure portal, go to **Resource Groups** and find the resource group you recently deployed IoT Hub to.

1. Select each Stream Analytics job that was deployed and, from the **Overview** tab, select **Start**.

   :::image type="content" source="media/cfs-iothub-stream-analytics-start.png" alt-text="Screenshot of Stream Analytics job overview.":::

Congratulations! You're now ready to pass data between Azure IoT Hub and Dynamics 365 to use Connected Field Service.

## Step 7: Update Azure Time Series Insights connection

Use Time Series Insights to create visualizations.

1. Open up the Connected Field Service app module in Dynamics 365.

1. Open the browser developer tools and go to the console.

1. Enter the following script into the console and run it, replacing the `Value` parameter with the Azure tenant ID. You can [get the tenant ID from the Azure portal](/azure/active-directory/fundamentals/active-directory-how-to-find-tenant).

1. Run the script two more times, replacing the `Key` first with TSI_PLUGIN_CLIENT_APPLICATION_ID and then with TSI_PLUGIN_CLIENT_SECRET, and replacing the `Value` with the respective values.

    ```javascript
    
    var req = {};
    
    req.getMetadata = function () {
        return {
            boundParameter: null,
            parameterTypes: {
                "Key": {
                    "typeName": "Edm.String",
                    "structuralProperty": 1
                },
                "Value": {
                    "typeName": "Edm.String",
                    "structuralProperty": 1
                },
            },
            operationType: 0,
            operationName: "msdyn_IoTSetConfiguration"
        };
    };
    
    req["Key"]="TSI_PLUGIN_AZURE_TENANT_ID";
    req["Value"]="REPLACE";
    
    Xrm.WebApi.online.execute(req).then( 
        function (data) { 
            console.log("Success Response Status: " + data.status);
        }, 
        function (error) { 
            console.log("Error: " + error.message);
        }
    );
    ```

1. Run the following script, using your Time Series Insights URL and the GUID of the IoT Provider Instance row in the msdyn_iotproviderinstance table for the instance you created earlier.

    ```javascript
    var data = {"msdyn_timeseriesinsightsurl": "Enter Data Access FQDN (found in Time Series Insights resource)"};
    Xrm.WebApi.updateRecord("msdyn_iotproviderinstance", "Enter msdyn_iotproviderinstance GUID ", data);
    ```

## Step 9: Set up the simulator (optional)

The simulator lets you test Connected Field Service without the need to connect physical hardware. Simulated IoT devices and data help you understand different parts that contribute to turning IoT data into work orders.

Set up the simulator to simulate IoT devices and data and begin to see device data pulled into Field Service.

To find the simulator URL, sign in to your Azure subscription, and then select the App Service resource type that starts with "Simulator" under the newly created resource group. You’ll see the URL is in the top-right corner. Copy the URL and complete the following steps:  
  
1. Paste the URL into your browser’s address bar to load the page.  
  
1. When the simulator page opens, select **Connection**.  
  
1. Enter the IoT hub host name and key. The host is simply the name of the IoT Hub resource in Azure portal.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the "configure connection" dialog in Azure.](./media/cfs-iothub-thermostadt-simulator.png)

   The key can be accessed by selecting the IoT Hub resource and going to the shared access policies, then copying the primary key for **iothubowner** as seen in the following screenshot.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of Azure IoT Hub showing the primary key.](./media/cfs-simulator-connection.png)
  
1. Select the IoT hub in the **Resource Group**.  
  
1. On the left under **General**, select **Shared access policies** to get the host name and primary key.  
  
1. Make sure **Connection status**  is marked as **Connected** and then close the dialog box.  

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
