---
title: "Deploy the hosted application to Unified Service Desk | MicrosoftDocs"
description: "Learn about deploying the hosted application in Unified Service Desk."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 12/31/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Deploy the hosted application to Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

Once you have created a hosted application as described in [Create a HAT hosted application project](../unified-service-desk/use-hat-software-factory-create-hosted-application.md#Create), you can deploy it to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is configured on Microsoft Dataverse server. You must ensure that all workflow-dependent applications that contain a default workflow include the workflow assembly (.dll file). If the assembly file isn’t found or is deleted, the `Type` field in the Action XML is set to `NULL`.  
  
<a name="deploy"></a>   
## Deploy your hosted application to Unified Service Desk  
  
1. Right-click the application in **Solution Explorer** and select **Deploy**.  
  
   ![Use the shortcut menu to configure](../unified-service-desk/media/usd-create-hat-control-11.png "Use the shortcut menu to configure")  
  
2. In the next dialog box, enter Dataverse server name and your credentials.  
  
   ![Publish to dialog box](../unified-service-desk/media/usd-deploy.png "Publish to dialog box")  
  
3. If there is more than one organization, check the **Display list of available organizations** check box and select **Login**.  
  
4. Select your organization from the list of organizations displayed and select **OK**.  
  
<a name="verify"></a>   
## Verify that the application is successfully deployed  
  
1. Sign in to Unified Service Desk Administrator.  
  
2. Select **Hosted Controls** under **Basic Settings**.  
  
3. From the list of hosted controls, select the hosted application you just deployed. In this case, it’s [!INCLUDE[pn_bing](../includes/pn-bing.md)] Search. 
  
4. The configuration information for the hosted application is displayed.  
  
   ![Hosted control information dialog box](../unified-service-desk/media/usd-deploy-test-hosted-control-info.PNG "Hosted control information dialog box")  
  
6. The bindings you created in [Use UII inspector to create bindings for the hosted application](../unified-service-desk/use-uii-inspector-create-bindings-hosted-application.md) are displayed in the Automation XML area.  
  
   ![Automation bindings](../unified-service-desk/media/usd-automation-xml.PNG "Automation bindings")  
  
7. Copy the assembly that you generated in [Create a HAT hosted application project](../unified-service-desk/use-hat-software-factory-create-hosted-application.md#Create) from your [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] project output folder (\<ProjectFolder>\bin\debug) to the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] application directory. In this case, we will copy the Bing Search.dll file to the c:\Program Files\Microsoft Dynamics CRM USD\USD directory.  
  
### See also  
 [Create a HAT hosted application project](../unified-service-desk/use-hat-software-factory-create-hosted-application.md#Create)   
 [Using UII inspector to create bindings](../unified-service-desk/use-uii-inspector-create-bindings-hosted-application.md)   
 [Configure the HAT application](../unified-service-desk/configure-hosted-application.md)   
 [Configuring an action for the HAT application](../unified-service-desk/configure-action-hosted-application.md)   
 [Import the hosted application from Unified Service Desk](../unified-service-desk/import-hosted-application-from-unified-service-desk.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]