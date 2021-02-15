---
title: "UII adapters in Unified Service Desk | MicrosoftDocs"
description: 
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# UII adapters in Unified Service Desk
A [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] adapter allows you to modify the behavior of the application without access to its source code. [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] provides adapters for web applications, external (Windows-based) applications, and the [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)], which can be extended to build additional application adapter capabilities.  
  
 There are three types of application adapters:  
  
- **Application adapters**: Used for external (usually Win32) applications. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use UII application adapter](../unified-service-desk/use-uii-adapters-interact-external-web-applications.md#AppAdapter)  
  
- **Web application adapters**: Used for web applications. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use UII web application adapter](../unified-service-desk/use-uii-adapters-interact-external-web-applications.md#WebAppAdapter)  
  
- **Automation adapters**: Used by HAT. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Understanding HAT adapters](../unified-service-desk/use-uii-automation-adapter-interact-external-web-applications.md)  
  
  All types of adapters provide virtual methods that can be overridden.  
  
### See also  
 [Hosted Application Toolkit (HAT)](../unified-service-desk/uii-hosted-application-toolkit-hat.md)   
 [Walkthrough: Create a UII Application Adapter](../unified-service-desk/walkthrough-create-uii-application-adapter.md)   
 [Walkthrough: Create a UII Web Application Adapter](../unified-service-desk/walkthrough-create-uii-web-application-adapter.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]