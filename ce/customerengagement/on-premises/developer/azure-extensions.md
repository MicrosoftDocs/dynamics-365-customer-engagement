---
title: "Azure extensions for Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Dynamics 365 Customer Engagement (on-premises) can be integrated with Microsoft Azure. Developers can register plug-ins with Dynamics 365 Customer Engagement (on-premises) that can pass run-time message data, to one or more Microsoft Azure solutions in the cloud."
ms.custom: 
ms.date: 09/16/2022
ms.reviewer: pehecke

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
author: phecke
ms.author: pehecke
search.audienceType: 
  - developer

---
# Azure extensions for Dynamics 365 Customer Engagement (on-premises)

[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] supports integration with [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)]. Developers can register plug-ins with Dynamics 365 Customer Engagement (on-premises) that can pass run-time message data, known as the execution context, to one or more [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] solutions in the cloud. This is especially important for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] because [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] is one of two supported solutions for communicating run-time context obtained in a plug-in to external line-of-business (LOB) applications. The other solution is the external custom endpoint access capability from a plug-in registered in the sandbox.  
  
 The [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] provides a secure communication channel for Dynamics 365 Customer Engagement (on-premises) run-time data to external line of business applications. This capability is especially useful in keeping disparate Dynamics 365 Customer Engagement (on-premises) system or other [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] server synchronized with Dynamics 365 Customer Engagement (on-premises) business data changes.  
  
For more information about configuring and using [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], refer to the Microsoft Power Apps documentation: [Azure integration](/power-apps/developer/data-platform/azure-integration).

However, before you go, please read the following note about configuration that is specific for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] (on-premise) and not included in the Power Apps documentation.

> [!IMPORTANT]
> For on-premises deployments, see the on-premise sections of the configuration documentation [Configure Azure integration with Microsoft Dynamics 365](/previous-versions/dynamicscrm-2016/developers-guide/gg309340(v=crm.8)#get-a-public-certificate).
  
### See also
  
 [Plug-ins for Extending Dynamics 365 Customer Engagement (on-premises)](write-plugin-extend-business-processes.md)  

 [Azure Service Bus Messaging documentation](/azure/service-bus-messaging)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
