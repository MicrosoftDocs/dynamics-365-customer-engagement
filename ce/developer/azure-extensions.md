---
title: "Azure extensions for Dynamics 365 for Customer Engagement (Developer Guide for Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
description: "Dynamics 365 for Customer Engagement apps can be integrated with Microsoft Azure. Developers can register plug-ins with Dynamics 365 for Customer Engagement apps that can pass run-time message data, to one or more Microsoft Azure solutions in the cloud."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
helpviewer_keywords: 
  - azure
  - appfabric
ms.assetid: 70140156-f6b5-4cae-846c-23009ed755b2
caps.latest.revision: 56
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Azure extensions for Dynamics 365 for Customer Engagement apps

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] apps supports integration with [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)]. Developers can register plug-ins with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps that can pass run-time message data, known as the execution context, to one or more [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] solutions in the cloud. This is especially important for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps because [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] is one of two supported solutions for communicating run-time context obtained in a plug-in to external line-of-business (LOB) applications. The other solution is the external custom endpoint access capability from a plug-in registered in the sandbox.  
  
 The [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] provides a secure communication channel for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps run-time data to external line of business applications. This capability is especially useful in keeping disparate [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps system or other [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps server synchronized with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] business data changes.  
  
## In This Section  
 [Azure integration with Dynamics 365 for Customer Engagement apps](azure-integration.md)  
  
 [Configure Microsoft Azure Integration with Dynamics 365 for Customer Engagement apps](configure-azure-integration.md)  
  
 [Work with Dynamics 365 for Customer Engagement apps data in your Azure solution](work-data-azure-solution.md)  
  
 [Work with Dynamics 365 for Customer Engagement apps event data in your Azure Event Hub solution](work-event-data-azure-event-hub-solution.md)  
  
 [Write a Custom Azure-aware Plug-in](write-custom-azure-aware-plugin.md)  
  
 [Write a Listener for a Microsoft Azure Solution](write-listener-application-azure-solution.md)  
  
 [Walkthrough: Configure Microsoft Azure (SAS) for integration with Dynamics 365 for Customer Engagement apps](walkthrough-configure-azure-sas-integration.md)  
  
 [Walkthrough: Register an Azure-aware Plug-in with Plug-in Registration Tool](walkthrough-register-azure-aware-plug-in-using-plug-in-registration-tool.md)  
 [Walkthrough: Update a service endpoint from ACS to SAS authorization](walkthrough-update-service-endpoint-acs-sas-authorization.md)  
  
 [Walkthrough: Update a service endpoint imported from a solution](walkthrough-update-service-endpoint-imported-solution.md)  
  
 [Sample Code for Dynamics 365 for Customer Engagement apps-Azure Integration](sample-code-azure-integration.md)  
  
## Related Sections  
 [Plug-ins for Extending Dynamics 365 for Customer Engagement apps](write-plugin-extend-business-processes.md)  
  
 [Microsoft Azure Platform Developer Center](https://msdn.microsoft.com/azure/default.aspx)  
  
 [Microsoft Azure Service Bus](http://www.windowsazure.com/develop/net/fundamentals/hybrid-solutions/)
