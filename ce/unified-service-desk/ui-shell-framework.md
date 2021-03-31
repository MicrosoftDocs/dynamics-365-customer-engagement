---
title: "UI Shell Framework in Unified Service Desk | MicrosoftDocs"
description: "Learn about the UI shell framework that enables developers to build a desktop for hosting integrated applications."
author: mh-jaya
ms.author: v-jmh
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
# UI Shell Framework in Unified Service Desk
The UI Shell Framework is the part of [UII Application Integration Framework](../unified-service-desk/uii-application-integration-framework.md) that enables developers to build a desktop for hosting integrated applications. The UI Shell Framework has the following components:  
  
- **Desktop Core**: Contains core interfaces and classes that implement interfaces, exposed as APIs, which allow you to create a new [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] shell. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Core](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.core)  
  
- **Session Manager**:  These classes are derived from Application Integration Framework sessions and [Sessions](https://docs.microsoft.com/dotnet/api/microsoft.uii.csr.sessions) classes.  
  
- **UI Controls**: The UI Shell Framework contains controls such as the WPF panel, windows panel, and floating panel that allow you to create new shells quickly.  
  
- **UI Core**: The Core class is the anchor class for all core functions. It provides APIs for adding and removing sessions; managing notifications, the current view of applications, default operational behaviors for workflow management in relationship to current application views, access to service utility functions and methods; and loading and logging on to a [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] Desktop (such as [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]). This class provides override hooks to allow the developer to intercept, take action, and modify desktop behavior.  
  
- **CTI**: [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] computer telephony integration (CTI) framework contains core interfaces and classes that allow you to integrate CTI into a [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] Desktop (such as [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]).  
  
### See also  
 [UII Application Integration Framework](../unified-service-desk/uii-application-integration-framework.md)   
 [UII Computer Telephony Integration (CTI) framework](../unified-service-desk/uii-computer-telephony-integration-cti-framework.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]