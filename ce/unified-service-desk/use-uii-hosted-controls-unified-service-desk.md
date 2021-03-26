---
title: "Use UII hosted controls with Unified Service Desk | MicrosoftDocs"
description: "Learn how to use UII hosted controls in Unified Service Desk."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
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
# Use UII hosted controls with Unified Service Desk
[!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] hosted controls are user controls that are derived from the [HostedControl](/dotnet/api/microsoft.uii.csr.hostedcontrol) class, and  implements the [IHostedApplication4](/dotnet/api/microsoft.uii.csr.ihostedapplication4) interface, which provides most of the implementation code for a hosted control. You can override the functions in the [HostedControl](/dotnet/api/microsoft.uii.csr.hostedcontrol) class, as required.  
  
 [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] hosted controls can be used to create new or advanced user interface elements with complex business logic to interact with external applications from within [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. You can either create a Windows Forms-based or a WPF-based [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] hosted control, and host it in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
 For more information about the properties, functions, and events available for a UII hosted control, see [HostedControl](/dotnet/api/microsoft.uii.csr.hostedcontrol).  
  
 The following walkthroughs demonstrate how to create a [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] hosted control, and use it in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]:  
  
-   [Walkthrough: Create a UII Windows Forms Hosted Control](../unified-service-desk/walkthrough-create-uii-windows-forms-hosted-control.md)  
  
-   [Walkthrough: Create a UII WPF Hosted Control](../unified-service-desk/walkthrough-create-uii-wpf-hosted-control.md)  
  
### See also  
 [UII Hosted Applications](../unified-service-desk/uii-hosted-applications.md)   
 [Create and manage UII hosted applications](../unified-service-desk/create-manage-uii-hosted-applications.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]