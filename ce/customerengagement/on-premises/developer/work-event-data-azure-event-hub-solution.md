---
title: "Work with Dynamics 365 Customer Engagement event data in your Azure Event Hub solution (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The topic describes working with event data in your Azure Event Hub solution."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 53e5add8-25e0-458f-b82f-aac60c43fcab
caps.latest.revision: 12
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# Work with Customer Engagement event data in your Azure Event Hub solution

[!INCLUDE[pn_microsoft_azure_event_hubs](../includes/pn-microsoft-azure-event-hubs.md)] is a highly scalable publish-subscribe service that can ingest millions of events per second and stream them into multiple applications. The [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]-[!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] interface enables your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Customer Engagement event data to be published to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] and made available to your event hub solution subscribers. The following information describes the general  tasks that must be completed to send [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] event data to an event hub solution.  
  
> [!NOTE]
>  An [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] subscription and event hub license is required for access to event hubs. [!INCLUDE[cc_feature_included_with_update_8_1_0_admins](../includes/cc-feature-included-with-update-8-1-0-admins.md)]  
  
## 1. Create an event hub  
 You can create an event hub in [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] either through API programming  or interactively by using the [Azure classic portal](https://manage.windowsazure.com). Either way, after creating your event hub you must obtain a copy of the event hub connection string and provide that string when registering the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] service endpoint detailed in the next section.  
  
 [!INCLUDE[sdk_for_more_info_about](../includes/sdk-for-more-info-about.md)] creating event hubs see the [Event Hubs documentation](https://azure.microsoft.com/documentation/services/event-hubs/).  
  
## 2. Register an endpoint  
 Registering a service endpoint for an event hub is similar to registering for any other supported contract type such as queues or topics. You use the Plug-in Registration Tool, provided in the SDK download, to register the service endpoint.  When filling out the registration form specify a contract type of **Event Hub**. For the message body format, you can choose **XML** or **JSON**. In addition, only SAS authorization is permitted and you must provide the connection string obtained when you created the event hub. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Walkthrough: Configure Microsoft Azure (SAS) for integration with Dynamics 365 Customer Engagement (on-premises)](walkthrough-configure-azure-sas-integration.md).  
  
## 3. Register code  
 Dynamics 365 Customer Engagement (on-premises) needs to know the exact operation (entity/message combination) that, when processed, would cause the Azure-aware plug-in to execute. Since you are creating an event hub, this operation would be related to the processing of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] event data in particular. You must register a step for the Azure-aware plug-in in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] event execution pipeline.  For more information see  [Walkthrough: Register an Azure-aware plug-in using the Plug-in Registration Tool](walkthrough-register-azure-aware-plug-in-using-plug-in-registration-tool.md).  
  
 If you are using an Azure-aware custom workflow activity instead of a plug-in, you would register the activity's assembly using the Plug-in Registration Tool and incorporate that activity into a workflow. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Sample: Azure aware custom workflow activity](sample-azure-aware-custom-workflow-activity.md).  
  
## 4. Start listening  
 Start your Azure service hub solution application listening on the service endpoint.  
  
## 5. Trigger  
 Perform an operation in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] that would cause the plug-in or workflow containing the custom workflow activity to execute. This is the same operation (entity/message combination) that you registered the plug-in step for in the previous section of this topic. You can perform the intended operation by using the web application or through application code accessing the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web services.  
  
## 6. Verification  
 You can check the related system job in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application and look for a status of **Succeeded**. If you find a status of **Failed**, use the status information to identify the possible cause of the failure. You can then recheck the configurations of both systems or debug application code to locate and fix the problem, depending on the nature of the failure.  
  
### See also  
 [Azure integration with Dynamics 365 Customer Engagement (on-premises)](azure-integration.md)   
 [Azure extensions for Dynamics 365 Customer Engagement (on-premises)](azure-extensions.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]