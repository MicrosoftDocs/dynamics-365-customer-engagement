---
title: "Configure Azure integration with Dynamics 365 Customer Engagement (on-premises) (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The topic describes configuring Azure integration with Dynamics 365 Customer Engagement (on-premises)."
ms.custom: 
ms.date: 05/16/2018
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 79e49782-edd1-41ef-b110-2c2ed0771058
caps.latest.revision: 62
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Configure Azure integration with Dynamics 365 Customer Engagement (on-premises)

You can post the message request data for the current core operation to cloud hosted applications listening on the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. To enable this capability in Dynamics 365 Customer Engagement (on-premises), perform the tasks detailed in this topic.  

> [!NOTE]
> These instructions apply to Online deployments only. For on-premises deployments, see documentation for the most recent on-premises release at [Dynamics CRM 2016 SDK: Configure Azure integration with Microsoft Dynamics 365 Customer Engagement apps](https://msdn.microsoft.com/library/gg309340.aspx)
  

<a name="bkmk_configureappfabric"></a>
   
## Configure Azure For Dynamics 365 Customer Engagement (on-premises) integration

When you use SAS for authorization, you need to configure the rules and issuers of your [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] solution to allow a listener application to read the Dynamics 365 Customer Engagement (on-premises) message posted to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. In addition, you must configure the service bus rules to accept the Dynamics 365 Customer Engagement (on-premises) issuer claim. The recommended method to configure [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] is to use the Plug-in Registration Tool.  
  
For instructions on configuring authorization see [Walkthrough: Configure Microsoft Azure (SAS) for integration with Dynamics 365 Customer Engagement (on-premises)](walkthrough-configure-azure-sas-integration.md).  

## Test Configuration

After configuring [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] integration, you will need to perform these additional tasks.  
  
1. Write and register a listener application with a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] solution endpoint. For more information, see the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] [documentation](https://azure.microsoft.com/documentation/articles/service-bus-fundamentals-hybrid-solutions/).  
  
2. Register a [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] aware plug-in or a [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] aware custom workflow activity with Dynamics 365 Customer Engagement (on-premises). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Walkthrough: Register an Azure-aware Plug-in with Plug-in Registration Tool](walkthrough-register-azure-aware-plug-in-using-plug-in-registration-tool.md)  
  
3. Perform the necessary Dynamics 365 Customer Engagement (on-premises) operation that triggers the plug-in or custom workflow activity to run.  
  
If all of the preceding steps were performed correctly, a message containing the Dynamics 365 Customer Engagement (on-premises) data context should be sent to a [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] queue or topic and ultimately received by the listener application. You can navigate to the **System Jobs** grid in the Dynamics 365 Customer Engagement (on-premises) web application and check the status of the related System Job to see if the post to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] succeeded. In case of errors, the message section of the System Job displays the error details.  
 
  
<!-- 
The following information is for on-premises only.
TODO: Review and add back relevant content when a v9 on-premise release ships

<a name="bkmk_obtain"></a>

## Get a public certificate

[!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] users can download a public certificate from the web application by going to **Settings** > **Customizations** > **Developer Resources**. On that page, click the **Download Certificate** link below **Microsoft Azure Issuer Certificate** to download and save the public certificate. In addition, write down the issuer name because you’ll need it later.  
  
For [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] on-premises and IFD installations, you can purchase a private certificate from an issuing authority. Import the certificate file into the Personal\Certificates store on your computer using the certificate [!INCLUDE[pn_Microsoft_Management_Console](../includes/pn-microsoft-management-console.md)] snap-in. Next, export a public key file of your certificate in Base64 format. This public certificate will be used in the next task. For more information, see the MMC Help.  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

<a name="bkmk_configurecrm"></a>

## Configure Dynamics 365 Customer Engagement (on-premises) for Azure integration
  
For [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] on-premises and IFD deployments, configuring the server for [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] integration involves storing the public certificate in the Dynamics 365 Customer Engagement (on-premises) configuration database and setting the proper security access to the certificate so Dynamics 365 Customer Engagement (on-premises) can read it. [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] comes pre-configured to work with [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)].
  
> [!IMPORTANT]
>  For the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] integration feature to work, the Dynamics 365 Customer Engagement (on-premises) asynchronous service must have access to the Internet through the server’s firewall. The server where the Asynchronous Service role is installed must be exposed to the Internet, and the account that the service runs under must have Internet access. Only outbound connections on ports 80 and 443 are required. Inbound connection access is not required. Use the Windows Firewall control panel to enable outbound connections for the `CrmAsyncService.exe` application located on the server in the `%PROGRAMFILES%\Microsoft Dynamics CRM\Server\bin` folder.   -->
  

  
### See also

[Azure Extensions for Dynamics 365 Customer Engagement (on-premises)](azure-extensions.md)<br />
[Write a plug-in](/powerapps/developer/common-data-service/write-plug-in)<br />
[Using the Provided Azure Plug-in](work-data-azure-solution.md)<br />
[Writing a Listener for a Azure Solution](write-listener-application-azure-solution.md)<br />
[Azure Platform – Getting Started](https://www.microsoft.com/windowsazure/learn/get-started/)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]