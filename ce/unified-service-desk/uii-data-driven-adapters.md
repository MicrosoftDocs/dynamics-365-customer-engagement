---
title: "UII data driven adapters in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn how to use a data-driven adapter to define a way to identify a UI component of a hosted application in Unified Service Desk."
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
ms.assetid: 95a71291-e769-4eb6-b58e-085424ed29c1
caps.latest.revision: 5
author: kabala123
ms.author: kabala
manager: sakudes
---
# UII data driven adapters in Unified Service Desk
Data-driven adapters are used by the [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)]. These adapters handle only the interaction with the user interface (UI) and don’t contain business processes. This is different than custom adapters, which frequently intermingle with the business processes and the UI interaction code.  
  
 A data-driven adapter uses data, called bindings, to define the way that it identifies a UI component of a hosted application. For example, the bindings may consist of Document Object Model (DOM) paths for describing elements on a webpage. The [!INCLUDE[pn_hat](../includes/pn-hat.md)] adapter leverages business processes implemented using the [!INCLUDE[pn_windows_workflow_foundation_wf](../includes/pn-windows-workflow-foundation-wf.md)], these bindings, and data-driven adapters to manage the business flows between one or more applications.  
  
 [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] provides the following four data-driven adapters:  
  
- **WinDataDrivenAdapter**: A Microsoft Active Accessibility (MSAA)–based data-driven adapter for [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)]-based applications.  
  
- **WebDataDrivenAdapter**: A DOM-based data-driven adapter for web applications.  
  
- **UIDataDrivenAdapter**: A UI automation–based data-driven adapter for [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] (including [!INCLUDE[pn_MS_Silverlight_full](../includes/pn-ms-silverlight-full.md)] and [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)] applications) and web applications.  
  
- **JavaDataDrivenAdapter**: A [!INCLUDE[pn_Java](../includes/pn-java.md)] Development Kit (JDK) level 1.7–based data-driven adapter for [!INCLUDE[pn_Java](../includes/pn-java.md)] applications.  
  
  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)  
  
### See also  
 [UII Hosted Application Toolkit (HAT)](../unified-service-desk/uii-hosted-application-toolkit-hat.md)   
 [Use UII automation adapter to interact with external and web applications](../unified-service-desk/use-uii-automation-adapter-interact-external-web-applications.md)   
 [Extend Unified Service Desk](../unified-service-desk/extend-unified-service-desk.md)
