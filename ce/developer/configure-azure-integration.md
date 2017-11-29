---
title: "Configure Azure integration with Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The topic describes configuring Azure integration with Dynamics 365 Customer Engagement."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
    - "Dynamics 365 (online)"
ms.assetid: 79e49782-edd1-41ef-b110-2c2ed0771058
caps.latest.revision: 62
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Configure Azure integration with Dynamics 365 Customer Engagement

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_crm_2016_and_online_full](../includes/pn-crm-2016-and-online-full.md)] are capable of posting the message request data for the current core operation to cloud hosted applications listening on the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. To enable this capability in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement, perform the tasks detailed in this topic.  
  
<a name="bkmk_configuration"></a>   
## Configuration tasks for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and Azure integration  
  
1.  [Obtain a Public Certificate](configure-azure-integration.md#bkmk_obtain) from [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] or from an issuing authority.  
  
2.  [Configure Dynamics 365 for Azure Integration](configure-azure-integration.md#bkmk_configurecrm).  
  
3.  [Configure Azure ACS for Dynamics 365 Integration](configure-azure-integration.md#bkmk_configureappfabric).  
  
 These tasks are expanded upon in this topic. After configuring [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] integration, you will need to perform these additional tasks.  
  
1.  Write and register a listener application with a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] solution endpoint. For more information, see the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] [documentation](https://azure.microsoft.com/en-us/documentation/articles/service-bus-fundamentals-hybrid-solutions/).  
  
2.  Register a [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] aware plug-in or a [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] aware custom workflow activity with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Walkthrough: Register an Azure-aware Plug-in with Plug-in Registration Tool](walkthrough-register-azure-aware-plug-in-using-plug-in-registration-tool.md)  
  
3.  Perform the necessary [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] operation that triggers the plug-in or custom workflow activity to run.  
  
 If all of the preceding steps were performed correctly, a message containing the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] data context should be sent to a [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] queue or topic and ultimately received by the listener application. You can navigate to the **System Jobs** grid in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web application and check the status of the related                  `System Job` to see if the post to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] succeeded. In case of errors, the message section of the                  `System Job` displays the error details.  
  
 For more information, see the See Also links at the end of this topic.  
  
<a name="bkmk_obtain"></a>   
## Get a public certificate  
 [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] users can download a public certificate from the web application by going to **Settings** > **Customizations** > **Developer Resources**. On that page, click the **Download Certificate** link below **Microsoft Azure Issuer Certificate** to download and save the public certificate. In addition, write down the issuer name because you’ll need it later.  
  
 For [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] on-premises and IFD installations, you can purchase a private certificate from an issuing authority. Import the certificate file into the Personal\Certificates store on your computer using the certificate [!INCLUDE[pn_Microsoft_Management_Console](../includes/pn-microsoft-management-console.md)] snap-in. Next, export a public key file of your certificate in Base64 format. This public certificate will be used in the next task. For more information, see the MMC Help.  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]
<a name="bkmk_configurecrm"></a>   
## Configure [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] for Azure integration  
 For [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] on-premises and IFD deployments, configuring the server for [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] integration involves storing the public certificate in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] configuration database and setting the proper security access to the certificate so [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] can read it. [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] comes pre-configured to work with [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)].
  
> [!IMPORTANT]
>  For the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] integration feature to work, the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] asynchronous service must have access to the Internet through the server’s firewall. The server where the Asynchronous Service role is installed must be exposed to the Internet, and the account that the service runs under must have Internet access. Only outbound connections on ports 80 and 443 are required. Inbound connection access is not required. Use the Windows Firewall control panel to enable outbound connections for the                      CrmAsyncService.exe application located on the server in the `%PROGRAMFILES%\Microsoft Dynamics CRM\Server\bin` folder.  
  
<a name="bkmk_configureappfabric"></a>   
## Configure Azure <br />            
 For [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] integration  
 When you use SAS for authorization, you need to configure the rules and issuers of your [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] solution to allow a listener application to read the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] message posted to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. In addition, you must configure the service bus rules to accept the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] issuer claim. The recommended method to configure [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] is to use the Plug-in Registration Tool.  
  
 For instructions on configuring authorization see [Walkthrough: Configure Microsoft Azure (SAS) for integration with Dynamics 365](walkthrough-configure-azure-sas-integration.md).  
  
### See also  
 [Azure Extensions for Dynamics 365](azure-extensions.md)   
 [Writing a Plug-in](write-plugin.md)   
 [Using the Provided Azure Plug-in](work-data-azure-solution.md)   
 [Writing a Listener for a Azure Solution](write-listener-application-azure-solution.md)   
 [Azure Platform – Getting Started](http://www.microsoft.com/windowsazure/learn/get-started/)