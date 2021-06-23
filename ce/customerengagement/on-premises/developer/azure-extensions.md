---
title: "Azure extensions for Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Dynamics 365 Customer Engagement (on-premises) can be integrated with Microsoft Azure. Developers can register plug-ins with Dynamics 365 Customer Engagement (on-premises) that can pass run-time message data, to one or more Microsoft Azure solutions in the cloud."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
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

---
# Azure extensions for Dynamics 365 Customer Engagement (on-premises)

[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] supports integration with [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)]. Developers can register plug-ins with Dynamics 365 Customer Engagement (on-premises) that can pass run-time message data, known as the execution context, to one or more [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] solutions in the cloud. This is especially important for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] because [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] is one of two supported solutions for communicating run-time context obtained in a plug-in to external line-of-business (LOB) applications. The other solution is the external custom endpoint access capability from a plug-in registered in the sandbox.  
  
 The [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] provides a secure communication channel for Dynamics 365 Customer Engagement (on-premises) run-time data to external line of business applications. This capability is especially useful in keeping disparate Dynamics 365 Customer Engagement (on-premises) system or other [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] server synchronized with Dynamics 365 Customer Engagement (on-premises) business data changes.  
  
## In This Section  
 [Azure integration with Dynamics 365 Customer Engagement (on-premises)](azure-integration.md)  
  
 [Configure Microsoft Azure Integration with Dynamics 365 Customer Engagement (on-premises)](configure-azure-integration.md)  
  
 [Work with Dynamics 365 Customer Engagement (on-premises) data in your Azure solution](work-data-azure-solution.md)  
  
 [Work with Dynamics 365 Customer Engagement (on-premises) event data in your Azure Event Hub solution](work-event-data-azure-event-hub-solution.md)  
  
 [Write a Custom Azure-aware Plug-in](write-custom-azure-aware-plugin.md)  
  
 [Write a Listener for a Microsoft Azure Solution](write-listener-application-azure-solution.md)  
  
 [Walkthrough: Configure Microsoft Azure (SAS) for integration with Dynamics 365 Customer Engagement (on-premises)](walkthrough-configure-azure-sas-integration.md)  
  
 [Walkthrough: Register an Azure-aware Plug-in with Plug-in Registration Tool](walkthrough-register-azure-aware-plug-in-using-plug-in-registration-tool.md)  
 [Walkthrough: Update a service endpoint from ACS to SAS authorization](walkthrough-update-service-endpoint-acs-sas-authorization.md)  
  
 [Walkthrough: Update a service endpoint imported from a solution](walkthrough-update-service-endpoint-imported-solution.md)  
  
 [Sample Code for Dynamics 365 Customer Engagement (on-premises)-Azure Integration](sample-code-azure-integration.md)  
  
## Related Sections  
 [Plug-ins for Extending Dynamics 365 Customer Engagement (on-premises)](write-plugin-extend-business-processes.md)  
  
 [Microsoft Azure Platform Developer Center](https://msdn.microsoft.com/azure/default.aspx)  
  
 [Microsoft Azure Service Bus](https://www.windowsazure.com/develop/net/fundamentals/hybrid-solutions/)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]