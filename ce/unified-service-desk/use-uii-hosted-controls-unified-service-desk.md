---
title: "Use UII hosted controls with Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn how to use UII hosted controls in Unified Service Desk."
ms.custom:
  - dyn365-USD
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 7e889489-bf8c-48d0-9a44-2b8504dac8f1
caps.latest.revision: 6
author: kabala123
ms.author: kabala
manager: sakudes
---
# Use UII hosted controls with Unified Service Desk
[!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] hosted controls are user controls that are derived from the [HostedControl](https://docs.microsoft.com/dotnet/api/microsoft.uii.csr.hostedcontrol) class, and  implements the [IHostedApplication4](https://docs.microsoft.com/dotnet/api/microsoft.uii.csr.ihostedapplication4) interface, which provides most of the implementation code for a hosted control. You can override the functions in the [HostedControl](https://docs.microsoft.com/dotnet/api/microsoft.uii.csr.hostedcontrol) class, as required.  
  
 [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] hosted controls can be used to create new or advanced user interface elements with complex business logic to interact with external applications from within [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. You can either create a Windows Forms-based or a WPF-based [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] hosted control, and host it in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
 For more information about the properties, functions, and events available for a UII hosted control, see [HostedControl](https://docs.microsoft.com/dotnet/api/microsoft.uii.csr.hostedcontrol).  
  
 The following walkthroughs demonstrate how to create a [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] hosted control, and use it in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]:  
  
-   [Walkthrough: Create a UII Windows Forms Hosted Control](../unified-service-desk/walkthrough-create-uii-windows-forms-hosted-control.md)  
  
-   [Walkthrough: Create a UII WPF Hosted Control](../unified-service-desk/walkthrough-create-uii-wpf-hosted-control.md)  
  
### See also  
 [UII Hosted Applications](../unified-service-desk/uii-hosted-applications.md)   
 [Create and manage UII hosted applications](../unified-service-desk/create-manage-uii-hosted-applications.md)
