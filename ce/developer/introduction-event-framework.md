---
title: "Introduction to the event framework (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Event framework enables your custom code to be developed and integrated into Dynamics 365 server"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6116dde0-c6f5-4858-a4f9-93ccf495d39a
caps.latest.revision: 27
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Introduction to the event framework

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

With [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement you have the ability to extend or customize the functionality of the server through the integration of custom business logic (code). You can customize the product to support the way your company does business, and you can add new features to the product. The technology that enables your custom code to be developed and integrated into the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server is called the *event framework*.  
  
 The event framework enables you to create rich vertical and horizontal solutions on top of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] by supporting the development and integration of custom business logic with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] in a reliable and portable way. After your custom business logic has been integrated into [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], it can be executed synchronously as part of the main [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] execution path, or asynchronously from a managed queue. Business data can be passed to your custom code, which can then perform actions based on the nature of the information, or modify the information itself.  
  
 The Event Framework provides the following key features:  
  
-   An **improved event processing subsystem**. This subsystem provides a unified method of executing both plug-ins and workflow activities, which results in improved reliability, an enhanced feature set, and plug-in portability.  
  
-   An **event framework API** for extending the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] platform through the development of custom business logic in the form of plug-ins and workflow activities.  
  
-   An API for the **deployment of plug-ins and custom workflow activities** to the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] database. Deployment of plug-ins and workflow activities to the database enables automatic distribution of your plug-ins and custom workflow activities to servers running [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] services throughout a datacenter.  
  
- **Synchronous and asynchronous execution of plug-ins**. Synchronous plug-ins are executed in a pre-defined order as part of the main [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] event processing. Asynchronous plug-ins are queued and executed independently.  
  
 The Event Framework is only supported on the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server and the [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] client. For more information about how to extend the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Web application, see [Customize Dynamics 365](customize-dev/customize-applications.md).  
  
## In This Section  
 [Event Execution Pipeline](event-execution-pipeline.md)  
  
 [Plug-in Isolation, Trust, and the Disallowed List](plugin-isolation-trusts-statistics.md)  
  
## Related Sections  
 [Write Plug-Ins to Extend Business Processes](write-plugin-extend-business-processes.md)  
  
 [Supported Messages and Entities for Plugins for Dynamics 365 Customer Engagement](supported-messages-entities-plugin.md)  
  
 [Plug-in Development for Dynamics 365 Customer Engagement](plugin-development.md)  
  
 [Plug-in Entities for Dynamics 365 Customer Engagement](plug-in-entities.md)  
  
 [Plug-in Registration Entities for Dynamics 365 Customer Engagement](plug-in-registration-entities.md)
