---
title: "Debug your custom code for Unified Service Desk | MicrosoftDocs"
description: "Learn about debugging your custom code that you create for Unified Service Desk."
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
ms.assetid: eabf5f09-b999-466b-8231-0d395f13c595
caps.latest.revision: 8
author: kabala123
ms.author: kabala
manager: sakudes
---
# Debug your custom code for Unified Service Desk
Using custom code for extending [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] involves compiling your custom code into an assembly (DLL file), and then distributing the assembly to the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client installation directory on each client computer.  
  
 Debugging your custom code for [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] requires access to the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application and a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] instance with [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] solutions deployed.  
  
 To effectively debug your custom code, set your Visual Studio project properties to:  
  
-   Ensure that the latest version of the assembly is copied to the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client installation directory every time you build your [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] project so that you are testing the executable (the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application) using the latest code.  
  
-   Specify the executable or the calling application (the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application) for debugging your code.  
  
 To do so:  
  
1.  In your [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] project, from the **Project** menu, select **<Project_Name> Properties**.  
  
2.  On the **Build** tab, under the **Output** area, set the **Output path** field value to the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client installation directory, typically C:\Program Files\Microsoft Dynamics CRM USD\USD\\.  
  
 ![Set the output path of the assembly](../unified-service-desk/media/usd-project-build-tab.png "Set the output path of the assembly")  
  
3.  On the **Debug** tab, select **Start external program**, and specify the full path to the `UnifiedServiceDesk.exe` file in the field, typically C:\Program Files\Microsoft Dynamics CRM USD\USD\ UnifiedServiceDesk.exe  
  
 ![Set the external application name](../unified-service-desk/media/usd-project-debug-tab.png "Set the external application name")  
  
4.  Save your project.  
  
     This ensures that the latest version of the assembly is copied to the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client installation directory every time you build your project, and the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application is automatically started when you debug your project.  
  
5.  Set breakpoints in your Visual Studio project as required, and then build/debug your project.  
  
     When the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application starts automatically on debugging the project, specify the credentials to connect to your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance to continue with the debugging session until you hit a breakpoint or issue in your code.  
  
 Additionally, the **Debug Output** tab of the Debugger hosted control in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application provides real time trace information of the underlying execution, which can be also used to debug your custom code. For more information, see [Debug issues in Unified Service Desk](debug-issues-unified-service-desk.md)  
  
 The Debugger hosted control comes pre-configured if you have deployed one of the sample [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] packages. Alternatively, you can easily set up the Debugger hosted control in your [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] deployment. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Walkthrough 6: Configure the Debugger hosted control in your agent application](../unified-service-desk/walkthrough-configure-debugger-hosted-control-agent-application.md)  
  
### See also  
 [Extend Unified Service Desk](../unified-service-desk/extend-unified-service-desk.md)   
 [Unified Service Desk and the UII framework](../unified-service-desk/unified-service-desk-uii-framework.md)
