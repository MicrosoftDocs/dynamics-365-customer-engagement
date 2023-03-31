---
title: Installation and setup - Connected Field Service for Azure IoT Hub
description: Learn how connect and setup Dynamics 365 Field Service with Azure IoT Hub.
ms.date: 03/09/2023
ms.subservice: connected-field-service
ms.topic: how-to
ms.author: vhorvath
author: vhorvathms
search.app:
  - D365CE
  - D365FS
---
# Installation and setup - Connected Field Service for Azure IoT Hub

This guide provides all the steps required for getting up and running with Connected Field Service (CFS) for IoT Hub.

> [!NOTE]
> Time Series Insights (TSI) will be deprecated after March 2025. Connected Field Service will be transitioning to Azure Data Explorer. More information regarding the transition will be provided soon.

## Prerequisites

 Ensure the following before configuring Connected Field Service.
  
- [Dynamics 365 Field Service is installed](install-field-service.md).
  
- System Administrator and IoT-Administrator security roles.

- Active [Azure subscription with privileges to create resources and services](cfs-azure-subscription.md).

- For Azure Time Series Insights, [create an app registration](/azure/active-directory/develop/quickstart-register-app) in the Azure portal. Take note of the Application (client) ID and the Object ID. [Add a client secret](/azure/active-directory/develop/quickstart-register-app#add-a-client-secret), and record the client secret value. You'll need these values multiple times during the installation.

## Step 1: Deploy Connected Field Service and Azure resources from an ARM template

Deploy and connect Azure IoT Hub to your Field Service environment.

1. Go to the **Deployment steps** section on [https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment](https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment#deploy-the-arm-template) and deploy the Azure Resource Manager (ARM) template. Select **Deploy to Azure** to initiate the deployment.

1. Choose an existing Azure subscription. Choose a resource group or create one in the selected subscription. Set the region to the same region as your Field Service environment.

   :::image type="content" source="media/ARM-deployment-template.png" alt-text="Screenshot of the Azure Resource Manager template to deploy IoT Hub for Connected Field Service.":::

1. Enter the [unique name of your organization](/power-platform/admin/determine-org-id-name#find-your-organization-name), and the organization URL of the Field Service environment.

1. Select the optional resources you want to deploy.
   - We recommend adding **Azure Time Series Insights** to enable visualization for device readings and summary tiles.
   - Add the simulator to test and validate IoT scenarios with sample data.
   - To create you own reports in Power BI, add the SQL server and provide the credentials you want to create.

1. Review and create the resources from the template.

Before proceeding, ensure the deployment is complete.  

## Step 2: Create new IoT Provider Instance

1. Sign into your Dynamics 365 organization and open the Connected Field Service app module.

1. In Connected Field Service, go to the **Settings** area.

1. Select **Providers** and select **New**.

1. On the **New IoT Provider Instance** page, fill out the fields:

   :::image type="content" source="media/cfs-iot-hub-provider-instance.png" alt-text="Screenshot of a new IoT Hub provider instance with sample data.":::

   - **Name**: Enter the name of the resource group in Azure where you deployed IoT resources.
   - **IoT Provider**: [Choose or create the IoT provider for IoT Hub](cfs-provider-iot-hub.md).
   - **Provider Instance Id**: Enter the name of the IoT Hub resource that was deployed to your resource group in Azure.
   - **URL**: Enter the URL of the overview for the resource group in the Azure portal. Example: `https://portal.azure.com/[tenant_id]/subscriptions/[subscription_id]/resourceGroups/[resource_group_name]/overview`.

1. Select **Save** to create the new IoT Provider Instance record.

1. We now need to update the IoT Provider Settings for the newly created provider instance. In the **Settings** area, select **IoT Settings** > **IoT Provider Settings**.

   :::image type="content" source="media/cfs-iothub-default-provider-instance.png" alt-text="Screenshot of Default Provider Instance page.":::

1. For **Default IoT Provider**, set the **Instance** to the IoT Provider Instance you created previously.

1. Select **Save & Close** to save your changes.

## Step 3: Set up IoT endpoint

1. Download the [Power Platform CLI](https://aka.ms/PowerAppsCLI) and install it.

1. Open the CLI and launch the [Plugin Registration Tool (PRT)](/power-platform/developer/cli/reference/tool#pac-tool-prt) with the command `pac tool prt`.

1. In the PRT window, select **Create New Connection**. In **Display list of available organizations**, select **Office 365**.

1. Open **Advanced settings**. Select the region of your Field Service environment, enter your Field Service credentials and select **Login**.

1. Once connected to the organization, find the **IoT Message** Service Endpoint and select it.

1. Select **Update**.

1. For **NameSpace Address**, find the hostname for the [Service Bus Namespace](/azure/service-bus-messaging/explorer#use-the-service-bus-explorer) deployed to your resource group. Enter the hostname in the Plug-in Registration Tool, prefixed by `sb://`. Example: `sb://myServiceBusNamespace.servicebus.windows.net`

1. In the Service Bus Namespace resource, go to **Queues** and find the queue with a name ending in `-crm`. Copy the full name and enter it as the **Topic Name** in the Plug-in Registration Tool.
1. For **Message Format**, choose *XML*.

1. In the Service Bus Namespace resource, go to **Shared access policies** > **RootManageSharedAccessKey**.
   - Copy the name and paste it for SaS Key Name.
   - Copy the [primary key](/azure/service-bus-messaging/service-bus-quickstart-topics-subscriptions-portal) and paste it into the Plug-in Registration Tool for **SAS Key**.

1. Select **Save**.

:::image type="content" source="media/cfs-iothub-register-service-endpoint.png" alt-text="Screenshot of Plug-in Registration Tool.":::

## Step 4: Authorize Azure app connection

Connect the Azure IoT Hub to your Field Service environment.

1. Sign into your Azure account, and then go to the [Azure portal](https://portal.azure.com).

1. On the Azure portal, go to **Resource Groups** and find the resource group you recently deployed IoT Hub to.

1. Select and edit the *API Connection* resource **commondataservice**.

1. Select **Authorize** and sign in with your Dynamics 365 credentials that you use to sign into your Connected Field Service environment. They may be different than your Azure credentials to the Azure portal. Select **Save** to apply your changes.

## Step 5: Update devicerules.json

The Stream Analytics job deployed to your resource group will have a reference to a `devicerules.json` file. This file defines a rule that is used to create IoT Alerts when using the optional device simulator. To use the rule, upload the `devicerules.json` file and reproduce the directory structure. The exact structure is needed for the sample alert to work.

1. Download the `devicerules.json` file from the [GitHub repo](https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment).

1. Open the resource group in the Azure admin portal and select the storage account deployed to your resource group. Select **Containers** and create a container called `devicerules`.

1. Open the newly created storage container `devicerules` and select **Upload**. Select **Browse for files** and select `devicerules.json`. Expand the Advanced section, enter *2016-05-30* in the **Upload to folder** field, then select **Upload**.

1. Open the newly created folder `2016-05-30` and select **Upload**. Select **Browse for files** and select `devicerules.json`. Expand the Advanced section, enter *22-40* in the **Upload to folder** field, then select **Upload**.

## Step 6: Start Azure Stream Analytics job

1. Sign into your Azure account, and then go to the [Azure portal](https://portal.azure.com).

1. On the Azure portal, go to **Resource Groups** and find the resource group you recently deployed IoT Hub to.

1. Select each Stream Analytics job that was deployed and, from the **Overview** tab, select **Start**.

Congratulations! You're now ready to pass data between Azure IoT Hub and Dynamics 365 to use Connected Field Service.

## Step 7: Update Azure Time Series Insights connection

Use Azure Time Series Insights to create visualizations.

1. Open the Connected Field Service app module in Dynamics 365.

1. Launch the browser developer tools and go to the console.

1. Enter the following script into the console and run it, replacing the `Value` parameter with the Azure tenant ID. You can [get the tenant ID from the Azure portal](/azure/active-directory/fundamentals/active-directory-how-to-find-tenant).

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

1. Run the script again, replacing the `Key` with `TSI_PLUGIN_CLIENT_APPLICATION_ID` and the `Value` with the `Application Client ID` from the app registration for Time Series Insights that you created as a [prerequisite](#prerequisites).

1. Run the script again, replacing the `Key` with `TSI_PLUGIN_CLIENT_SECRET` and the `Value` with the `Client Secret` from the app registration for Time Series Insights that you created and recorded as a [prerequisite](#prerequisites).

1. Run the following script, using your Time Series Insights URL and the GUID of the IoT Provider Instance row in the msdyn_iotproviderinstance table for the instance you created earlier.

    ```javascript
    var data = {"msdyn_timeseriesinsightsurl": "Enter Data Access FQDN found on Time Series Insights environment overview"};
    Xrm.WebApi.updateRecord("msdyn_iotproviderinstance", "Copy the value for msdyn_iotproviderinstanceid from the json object returned with the API call https://[your-environment-name].crm.dynamics.com/api/data/v9.2/msdyn_iotproviderinstances", data);
    ```

## Step 8: Set up the simulator (optional)

The simulator lets you test Connected Field Service without the need to connect physical hardware. Simulated IoT devices and data help you understand different parts that contribute to turning IoT data into work orders.

Set up the simulator to simulate IoT devices and data and begin to see device data pulled into Field Service.

To find the simulator URL, sign in to your Azure subscription, and then select the App Service resource type that starts with "Simulator" under the newly created resource group. You’ll see the URL is in the top-right corner. Copy the URL and complete the following steps:  
  
1. Paste the URL into your browser’s address bar to load the page.  
  
1. When the simulator page opens, select **Connection**.  
  
1. Enter the IoT hub host name and key. The host is the host name of the IoT Hub resource in the Azure admin portal.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the "configure connection" dialog in Azure.](./media/cfs-iothub-thermostadt-simulator.png)

   Get the access key by selecting the IoT Hub resource and opening the shared access policies. Copy the primary key for *iothubowner*.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of Azure IoT Hub showing the primary key.](./media/cfs-simulator-connection.png)
  
1. Select the IoT hub in the **Resource Group**.  
  
1. On the left under **General**, select **Shared access policies** to get the host name and primary key.  
  
1. Make sure **Connection status**  is marked as **Connected** and then close the dialog box.  

Now you can send a test command by using the sample simulator. For example, select the temperature and increase it to above 70 degrees. The simulator is preprogrammed to create an IoT alert if temperature is above 70 degrees.

## Next steps

- [Register devices](cfs-register-devices.md)
- [Pull device data](cfs-pull-device-data.md)
- [Visualize device readings](cfs-visualizations-iot-hub.md)

## Privacy notice

[!INCLUDE[cc_privacy_crm_connected_field_service](../includes/cc-privacy-crm-connected-field-service.md)]

[Azure Time Series Insights](/azure/time-series-insights/)

[Connected Field Service Device Readings](cfs-visualizations-iot-hub.md) uses Azure Time Series Insight to store, process, and query IoT devices measurements from IoT Hub.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
