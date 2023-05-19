---
title: Install and configure Connected Field Service for Azure IoT Hub
description: Learn how to install and configure Dynamics 365 Connected Field Service for Azure IoT Hub.
ms.date: 05/08/2023
ms.subservice: connected-field-service
ms.topic: how-to
ms.author: vhorvath
author: vhorvathms
ms.custom: bap-template
---

# Install and configure Connected Field Service for Azure IoT Hub

Follow the steps in this article to set up Connected Field Service for use with Azure IoT Hub.

- [Step 1: Deploy Connected Field Service and Azure resources from an ARM template](#deploy-connected-field-service-and-azure-resources-from-an-arm-template)
- [Step 2: Create an IoT provider instance](#create-an-iot-provider-instance)
- [Step 3: Set up an IoT endpoint](#set-up-an-iot-endpoint)
- [Step 4: Authorize the Azure app connection](#authorize-the-azure-app-connection)
- [Step 5: Update devicerules.json](#update-devicerulesjson)
- [Step 6: Start the Azure Stream Analytics jobs](#start-the-azure-stream-analytics-jobs)
- [Step 7: Set up the Azure Time Series Insights connection](#set-up-the-azure-time-series-insights-connection)
- [Step 8: (Optional) Set up the simulator](#optional-set-up-the-simulator)

> [!NOTE]
> Time Series Insights will be deprecated after March 2025. Connected Field Service is transitioning to Azure Data Explorer. More information about the transition is coming soon.

## Prerequisites

- [Dynamics 365 Field Service is installed](install-field-service.md).

- You have the System Administrator and IoT Administrator security roles.

- You have an active [Azure subscription](cfs-azure-subscription.md) with privileges to create resources and services.

- You have [created an app registration](/azure/active-directory/develop/quickstart-register-app) for Azure Time Series Insights in the Azure portal and have the Application (client) ID and the Object ID. [Add a Client Secret](/azure/active-directory/develop/quickstart-register-app#add-a-client-secret) and record the value. You need these values multiple times in this procedure.

[!INCLUDE [Lightbox tip](~/../shared-content/shared/lightbox-tip.md)]

## Deploy Connected Field Service and Azure resources from an ARM template

Use an Azure Resource Management (Azure Resource Manager) template to deploy Azure IoT Hub and connect it to your Field Service environment.

1. Select **Deploy to Azure** on the page [https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment](https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment#deploy-the-arm-template).

1. Select your Azure subscription.

1. Select a resource group or create one.

1. Set the region to the same region as your Field Service environment.

    :::image type="content" source="media/ARM-deployment-template.png" alt-text="Screenshot of the Azure Resource Manager template to deploy IoT Hub for Connected Field Service." lightbox="media/ARM-deployment-template.png":::

1. Enter the [unique name of your organization](/power-platform/admin/determine-org-id-name#find-your-organization-name) and the organization URL of the Field Service environment.

1. Select the optional resources you want to deploy.

    - Select **Deploy Simulator (optional)** to test and validate IoT scenarios with sample data.
    - Select **Azure Time Series Insights (optional)** to enable visualizations of device readings and summary tiles.
    - Select **Deploy SQL Server for Power BI (optional)** and enter the SQL server and credentials to create your own reports in Power BI.

1. Select **Review + create**.

Make sure the deployment is complete before you proceed.

## Create an IoT provider instance

1. Sign in to Dynamics 365 and open the Connected Field Service app.

1. In Connected Field Service, go to the **Settings** area.

1. Select **Providers**, and then select **New**.

1. Enter the following information:

    :::image type="content" source="media/cfs-iot-hub-provider-instance.png" alt-text="Screenshot of a new IoT Hub provider instance with sample data.":::

    - **Name**: The name of the resource group in Azure where you deployed IoT resources
    - **IoT Provider**: [The IoT provider for IoT Hub](cfs-provider-iot-hub.md)
    - **Provider Instance Id**: The name of the IoT Hub resource that you deployed to your resource group in Azure
    - **URL**: The URL of the overview for the resource group in the Azure portal; for example, `https://portal.azure.com/[tenant_id]/subscriptions/[subscription_id]/resourceGroups/[resource_group_name]/overview`.

1. Select **Save**.

You now need to update the settings for the new provider instance.

1. In the **Settings** area, select **IoT Settings** > **IoT Provider Settings**.

    :::image type="content" source="media/cfs-iothub-default-provider-instance.png" alt-text="Screenshot of the IoT Settings page.":::

1. For **Default IoT Provider**, select the IoT provider instance you created.

1. Select **Save & Close**.

1. For a later step, find the **IoT Provider Instance** row in the `msdyn_iotproviderinstance` table and copy the GUID.

## Set up an IoT endpoint

For this step, you need to know the hostname for the [Service Bus Namespace](/azure/service-bus-messaging/explorer#use-the-service-bus-explorer) deployed to your resource group.

1. Download the [Power Platform CLI](https://aka.ms/PowerAppsCLI) and install it.

1. Open the CLI and launch the [Plugin Registration Tool (PRT)](/power-platform/developer/cli/reference/tool#pac-tool-prt) using the command `pac tool prt`.

1. In the PRT window, select **Create New Connection**.

1. In **Display list of available organizations**, select **Office 365**.

1. Select **Display list of available organizations**, and then select **Show Advanced**.

1. Select the region of your Field Service environment, enter your Field Service credentials, and then select **Login**.

    If you have access to multiple Dynamics 365 organizations, select the name of the org you want to work with.

Now you need to update the IoT Message service endpoint.

1. After you're connected to the organization, find and select the **IoT Message** Service Endpoint.

1. Select **Update**.

1. For **NameSpace Address**, enter the hostname of the Service Bus Namespace in the Plug-in Registration Tool, prefixed by `sb://`; for example, `sb://myServiceBusNamespace.servicebus.windows.net`.

1. In the Service Bus Namespace resource, go to **Queues** and find the queue with a name ending in `-crm`. Copy the full name and enter it as the **Topic Name** in the Plug-in Registration Tool.

1. For **Message Format**, choose *XML*.

1. In the Service Bus Namespace resource, go to **Shared access policies** > **RootManageSharedAccessKey**.

1. Copy the name and paste it in **SaS Key Name**.

1. Copy the [primary key](/azure/service-bus-messaging/service-bus-quickstart-topics-subscriptions-portal) and paste it in **SAS Key**.

1. Select **Save**.

    :::image type="content" source="media/cfs-iothub-register-service-endpoint.png" alt-text="Screenshot of the Service Endpoint Registration page.":::

## Authorize the Azure app connection

1. Sign in to your Azure account and go to the [Azure portal](https://portal.azure.com).

1. Go to **Resource Groups** and find the resource group you deployed IoT Hub to.

1. Select and edit the *API Connection* resource **commondataservice**.

1. Under **General**, select **Edit API Connection**, and then select **Authorize**.

1. Sign in with the Dynamics 365 credentials that you use to sign in to your Connected Field Service environment.

    They may be different from the credentials you use to sign in to the Azure portal.

1. Select **Save**.

## Update devicerules.json

The Stream Analytics job deployed to your resource group refers to a file named `devicerules.json`. This file defines a rule that creates IoT Alerts when you're using the optional device simulator.

To use the rule, upload the `devicerules.json` file. You must reproduce the exact directory structure for the sample alert to work.

1. Download the `devicerules.json` file from the [GitHub repo](https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment).

1. Open the resource group in the Azure admin portal and select the storage account deployed to your resource group.

1. Select **Containers**, and then create a container called `devicerules`.

1. Open the new container `devicerules` and select **Upload**.

1. Browse to and select `devicerules.json`.

1. Expand the Advanced section. In the **Upload to folder** field, enter **2016-05-30**, and then select **Upload**.

1. Open the new folder `2016-05-30` and select **Upload**.

1. Browse to and select `devicerules.json`.

1. Expand the Advanced section. In the **Upload to folder** field, enter **22-40**, and then select **Upload**.

## Start the Azure Stream Analytics jobs

1. In the [Azure portal](https://portal.azure.com), go to **Resource Groups** and find the resource group you deployed IoT Hub to.

1. Select each Stream Analytics job and from the **Overview** tab, select **Start**.

Congratulations! You're now ready to pass data between Azure IoT Hub and Dynamics 365 to use Connected Field Service.

## Set up the Azure Time Series Insights connection

Use Azure Time Series Insights to create visualizations. For this step, you need to know your [your Azure tenant ID](/azure/active-directory/fundamentals/active-directory-how-to-find-tenant).

1. In Dynamics 365, open the Connected Field Service app.

1. Launch the browser developer tools and go to the console.

1. Type or paste the following script in the console and run it. Replace the `Value` parameter with your Azure tenant ID.

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

1. Run the script again. This time, replace `Key` with `TSI_PLUGIN_CLIENT_APPLICATION_ID` and `Value` with the Application Client ID from the Time Series Insights app registration you created as a [prerequisite](#prerequisites).

1. Run the script one more time. This time, replace `Key` with `TSI_PLUGIN_CLIENT_SECRET` and `Value` with the Client Secret from the Time Series Insights app registration you created as a [prerequisite](#prerequisites).

1. Run the following script, using your Time Series Insights URL and the GUID of the IoT provider instance row in the *msdyn_iotproviderinstance* table for the IoT provider instance you created earlier.

```javascript
var data = {"msdyn_timeseriesinsightsurl": "Enter Data Access FQDN found on Time Series Insights environment overview"};
Xrm.WebApi.updateRecord("msdyn_iotproviderinstance", "Copy the value for msdyn_iotproviderinstanceid from the json object returned with the API call https://[your-environment-name].crm.dynamics.com/api/data/v9.2/msdyn_iotproviderinstances", data);
```

## (Optional) Set up the simulator

The simulator lets you test Connected Field Service without the need to connect physical hardware. Simulated IoT devices and data help you understand the parts of the system that contribute to turning IoT data into work orders.

For this step, you need the simulator URL and the primary key for the `iothubowner` policy.

### Get the access key

1. Sign in to your Azure account and go to the [Azure portal](https://portal.azure.com).

1. Go to **Resource Groups** and find the resource group you deployed IoT Hub to.

1. Select the IoT hub.

1. Select **Shared access policies**, and then copy the primary key for *iothubowner*.

    :::image type="content" source="media/cfs-simulator-connection.png" alt-text="Screenshot of Azure IoT Hub resource shared access policy for iothubowner, with the primary key highlighted.":::

### Get the simulator URL

1. In the [Azure portal](https://portal.azure.com) resource group you deployed IoT Hub to, select the App Service resource type that starts with `Simulator` and copy the URL in the upper-right corner.

1. Paste the URL into your browser's address bar and load the page.

1. Select **Connection**.

1. Enter the host name from the IoT Hub resource and **iothubowner** as the policy name. In the **Key** field, paste the primary key you copied earlier.

    :::image type="content" source="media/cfs-iothub-thermostadt-simulator.png" alt-text="Screenshot of the 'Configure connection' window in Azure.":::

1. Make sure **Connection status** is **Connected** and then close the connection window.

Send a test command using the simulator. For example, select the temperature and increase it to above 70 degrees. The simulator is preprogrammed to create an IoT alert if the temperature rises above 70 degrees.

## Next steps

- [Register devices](cfs-register-devices.md)  
- [Pull device data](cfs-pull-device-data.md)  
- [Visualize device readings](cfs-visualizations-iot-hub.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
