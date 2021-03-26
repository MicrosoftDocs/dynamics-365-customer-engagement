---
title: "UII hosted applications in Unified Service Desk | MicrosoftDocs"
description: "Learn about using the UII hosted applications in Unified Service Desk."
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
# UII hosted applications in Unified Service Desk
A [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] hosted application is a line-of-business application or component whose user interface is hosted in the shell application. A hosted application can either be an existing application developed with no awareness of [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] or an application or component (hosted control) developed specifically for UII. The [!INCLUDE[pn_application_integration_framework_aif](../includes/pn-application-integration-framework-aif.md)] exposes classes and interfaces that enable you to develop hosted applications that support different scenarios.  
  
 The [IHostedApplication](/dotnet/api/microsoft.uii.csr.ihostedapplication) interface defines a [String)](/dotnet/api/microsoft.uii.csr.hostedcontrol.doaction(microsoft.uii.csr.action,system.string)) method, which enables the application to respond to an action. In the [String)](/dotnet/api/microsoft.uii.csr.hostedcontrol.doaction(microsoft.uii.csr.action,system.string)) method implementation, you can use a switch statement to decide which code to execute, based on the name of the action received through the [!INCLUDE[pn_aif_acronym](../includes/pn-aif-acronym.md)].  
  
<a name="Types"></a>   
## Types of UII hosted application  
 The [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] hosted application can be of the following types:  
  
- **Hosted controls**: These are user controls that are built specifically for [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] to be hosted in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. These hosted controls are different from the predefined [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] hosted controls; the UII hosted controls are derived from the [HostedControl](/dotnet/api/microsoft.uii.csr.hostedcontrol) class whereas the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] hosted controls are derived from the [DynamicsBaseHostedControl](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol) class. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use UII hosted controls with Unified Service Desk](../unified-service-desk/use-uii-hosted-controls-unified-service-desk.md)  
  
- **Web hosted application**: This can be web applications, [!INCLUDE[pn_MS_Silverlight_full](../includes/pn-ms-silverlight-full.md)] applications on a webpage, or [!INCLUDE[pn_Java](../includes/pn-java.md)] applets, which are usually hosted in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)].  
  
- **External hosted application**: This includes MicrosoftWin32 applications, .NET Windows Forms applications, [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)] applications, [!INCLUDE[pn_Java](../includes/pn-java.md)] applications, and other applications that don’t run in the context of the browser, but are executable files.  
  
- **Remote hosted application**: These are [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] hosted applications. This application type provides the channel of communication to an executable file installed on the [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] server. The executable file loads an adapter appropriate for the type of application being hosted in the [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] environment. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Integrate with Citrix applications](../unified-service-desk/integrate-citrix-applications.md)  
  
<a name="GlobalnSession"></a>   
## Global and session UII hosted applications  
 A global hosted application is instantiated when the desktop starts, and is usually closed when the desktop is terminated. There is only a single instance for each global hosted application during the lifetime of the desktop process. Session hosted applications are instantiated when a session is created, and are closed when the session ends.  
  
<a name="Dynamic"></a>   
## Dynamic UII hosted applications  
 The life cycle of a dynamic hosted application can be controlled by the agent or through code. Dynamic hosted applications can be either global or session scoped. A session-scoped dynamic hosted application will be terminated at the end of the session if it hasn’t been closed by the agent or through code.  
  
<a name="Workflow"></a>   
## Workflow-dependent UII hosted applications  
 The instancing model of global and session hosted applications can be further refined by marking them as workflow-dependent hosted applications. A global workflow-dependent hosted application is available to the agent only when the workflow that it’s dependent on is active. The application is first instantiated when the workflow runs the first time, but it keeps running after the workflow completes. Workflow-dependent session hosted applications are only instantiated when the workflow that they are dependent on starts. When the agent closes the workflow, workflow-dependent session hosted applications close.  
  
### See also  
 [Application Integration Framework](../unified-service-desk/uii-application-integration-framework.md)   
 [UII application adapters](../unified-service-desk/uii-adapters.md)   
 [Create and manage UII hosted applications](../unified-service-desk/create-manage-uii-hosted-applications.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]