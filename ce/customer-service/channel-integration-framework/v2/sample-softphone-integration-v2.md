---
title: "Sample code for softphone integration using Dynamics 365 Channel Integration Framework version 2.0 | Microsoft Docs"
description: "Learn about sample code for softphone integration using Dynamics 365 Channel Integration Framework version 2.0 with Dynamics 365 model-driven apps."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 11/17/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---
# Sample code for softphone integration using Dynamics 365 Channel Integration Framework version 2.0

[Download](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/channel-integration-framework/TwilioSampleInteg_version2) softphone integration sample for Microsoft Dynamics 365 Channel Integration Framework version 2.0.

> [!NOTE]
> The sample code is not supported on Internet Explorer and on browsers that do not have webRTC support. More information: [WebRTC](https://webrtc.org/)

## Prerequisites

- Omnichannel for Dynamics 365 Customer Service
- A valid Azure subscription is required to publish the sample app to Azure.

  > [!Note]
  > If you don't have an Azure subscription, you can create a [free account](https://azure.microsoft.com/free/).

<a name="bkmk_PublishToAzure"></a>

## Publish a sample app to Azure

1. Open the solution **SampleInteg.sln** using Visual Studio 2017.
2. In **Solution Explorer**, right-click on the solution and build the complete solution.
3. In **Solution Explorer**, right-click on the project **SampleInteg**  and select **Publish**.
4. Select **Start** to launch the **Publish** wizard.
5. Choose **App Service** as the publish target.
6. Select **Create New** and then select **Publish**.
7. Provide an app name. For example, **SampleInteg**.
8. Provide valid subscription, resource group, and hosting plan details.
9. Select **Create** to create the Azure app service, and save the app service URL for future use.

   For example, `https://sampleinteg.azurewebsites.net`.

   ![Select Create to publish app on Azure](../media/publish-app-azure.PNG "Select Create to publish app on Azure")<br />

## Create function to use with the app service

1. Create sample code for the **client-voice** function.<br> Refer to the function from the readme file packaged with the sample softphone integration in the [Dynamics 365 Insider Portal](https://go.microsoft.com/fwlink/p/?linkid=2025867).

2. Use the sample code for the **capability-token** function.<br> Refer to the function from the readme file packaged with the sample softphone integration in the [Dynamics 365 Insider Portal](https://go.microsoft.com/fwlink/p/?linkid=2025867).

> [!Note]
> Save the URL for the **capability-token** function you obtain from the above sample code. For example, the URL is `https://sampleinteg.sample/capability-token`.

<a name="bkmk_Configure"></a>

## Configure sample app in Dynamics 365

1. Note the base URL of the Dynamics 365 organization from where all web resources are stored. For an online org, this should be of the form `https://<orgname>.crmXX.dynamics.com`. For example: `https://sampleorg.crm10.dynamics.com`

1. Get the **Dynamics 365 Channel Integration Framework** solution. For more information, see [Get Dynamics 365 Channel Integration Framework](get-channel-integration-framework.md).

2. Configure the channel provider by providing the detail as shown in the matrix. For more information, see [Configure the channel provider](configure-channel-provider-channel-integration-framework.md).

   | Field | Description |
   |-------|-------|
   |Name|Name of the channel provider.<br><br> Example: Contoso|
   |Unique Name|A unique identifier in the <*prefix*>_<*name*> format. <br>**IMPORTANT:** The following are required for the unique name:<ul><li> The prefix can only be alphanumeric and its length must be between 3 to 8 characters.</li><li>An underscore must be there between the prefix and name</li></ul>|
   |Label|The label is displayed as the title on the widget.<br><br> Example: Contoso|
   |Channel URL| The channel URL is in the format: `<azure_app_service_url>?base=<crm_base_url>`<br /><br />**Note:** For this sample, the URL is `https://sampleinteg.azurewebsites.net?base=https://sampleorg.crm10.dynamics.com`. |
   |Enable Outbound Communication| Yes |
   |Channel Order| 0 |
   |API Version| 2.0 |
   |Trusted Domains|The domain (URL) that can access the Channel Integration Framework APIs.|
   |Select the Unified Interface Apps for the Channel| The list of Unified Interface apps where the channel is displayed for the agents. |
   |Select Roles for the Channel|The security roles that are present in Dynamics 365.<br>**Note:** If you do not assign any role, the channel provider is shown to all users assigned for the Dynamics 365 Unified Interface app.|

3. Launch the Unified Interface app to see the communication widget on the left side.<br><br>

> [!Important]
> - All URLs must be HTTPS.
> - If you use a self-signed certificate for the Azure app or the Dynamics 365 org, certain browsers might reject the connection and fail to load the sample phone. As a workaround, open the Azure app in a separate tab and accept the certificate once.
> - Ensure microphone and speaker access is not blocked by browser policy.

## Import configuration data

1. Download the [Configuration Migration tool](/power-platform/admin/manage-configuration-data). The Configuration Migration tool is available as a NuGet package.

2. Start the Configuration Migration tool. Double-click DataMigrationUtility.exe in the folder: `[your folder]\Tools\ConfigurationMigration\`.

3. On the main screen, select **Import data**, and then select **Continue**.

4. On the sign-in screen, provide authentication details to connect to your Dynamics 365 instance from where you want to import data. If you have multiple organizations on the Dynamics 365 server, and want to select the organization to which to import the configuration data, select the **Always display list of available orgs** check box. Select **Login**.

5. If you have multiple organizations, and you selected the **Always display list of available orgs** check box, the next screen lets you choose the organization that you want to connect to. Select a Dynamics 365 apps organization to connect to.

6. Provide the data file (data.zip) to be imported. Browse to the data file and select it. Select **Import Data**.

7. This step is applicable only if the data that you are importing contains the user information of the source system. Enter mapping user information on the target system. You can either map all of them to the user who is running the import process or map to individual users by using a user map file (.xml). If you choose the latter, you will have to either specify an existing user map file or the tool can generate it for you. If you generate a new file, fill in the mapping user name in the New parameter for every user on the source server. Select the user map file in the tool when you are done, and select **OK**.

8. The next screen displays the import status of your records. The data import is done in multiple passes to first import the foundation data while queuing up the dependent data, and then import the dependent data in the subsequent passes to handle any data dependencies or linkages. This ensures clean and consistent data import.

9. Select **Finish** to close the tool.

## See also

[Get Dynamics 365 Channel Integration Framework](get-channel-integration-framework.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]