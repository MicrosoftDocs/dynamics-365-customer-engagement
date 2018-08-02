---
title: "UII adapters in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about three UII adapters in Unified Service Desk."
description: ""
ms.custom: ""
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 59d89ca1-469d-42e3-98cf-e444c0438ec3
caps.latest.revision: 5
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
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