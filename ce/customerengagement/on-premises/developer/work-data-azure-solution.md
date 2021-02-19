---
title: "Work with Dynamics 365 Customer Engagement data in your Azure solution (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The ServiceBusPlugin plug-in contains the business logic to post the Dynamics 365 Customer Engagement message execution context to the Azure Service Bus. To use this plug-in, you need to register a Azure Service Bus solution endpoint and a step for the plug-in. The step defines what message and entity combination being processed by the core Dynamics 365 Customer Engagement operation should trigger the plug-in to execute. The ServiceBusPlugin can only be registered to run asynchronously."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: ccc4abde-9e4b-427a-a98c-c2b6bfce1195
caps.latest.revision: 30
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Work with Customer Engagement data in your Azure solution

An internal plug-in named ServiceBusPlugin is provided with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. The plug-in contains the business logic to post the Dynamics 365 Customer Engagement (on-premises) message execution context to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. To use this plug-in, you need to register a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] solution endpoint and a step for the plug-in. The step defines what message and entity combination being processed by the core Dynamics 365 Customer Engagement (on-premises) operation should trigger the plug-in to execute. The ServiceBusPlugin can only be registered to run asynchronously. For more information, see [Walkthrough: Register an Azure-aware Plug-in using the Plug-in Registration Tool](walkthrough-register-azure-aware-plug-in-using-plug-in-registration-tool.md).  
  
 In addition, you can write a custom plug-in that includes the required lines of code to post to the service bus. The plug-in is registered in a similar way, except that it must be registered in the sandbox and run under partial trust. For more information on writing a custom plug-in that can post to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)], see [Write a Custom Azure-aware Plug-in](write-custom-azure-aware-plugin.md).  
  
 You can also write a custom workflow activity that can post the execution context to the service bus and include this activity in your workflows. Sample code for a custom [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)]-aware workflow activity is provided in the topic [Sample: Azure Aware Custom Workflow Activity](sample-azure-aware-custom-workflow-activity.md).  
  
### See also  
[Azure Extensions for Dynamics 365 Customer Engagement (on-premises)](azure-extensions.md)  
[Write a custom Azure-aware plug-in](write-custom-azure-aware-plugin.md)  
[Walkthrough: Register an Azure-aware plug-in using the Plug-in Registration Tool](walkthrough-register-azure-aware-plug-in-using-plug-in-registration-tool.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]