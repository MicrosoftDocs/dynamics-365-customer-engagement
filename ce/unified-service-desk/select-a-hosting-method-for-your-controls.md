---
title: "Select a hosting method for your controls in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about different types of hosting methods for your controls in Unified Service Desk."
ms.custom: dyn365-USD
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
ms.assetid: 90ee21c6-d686-4845-9567-800c25008bfc
caps.latest.revision: 17
author: kabala123
ms.author: kabala
manager: sakudes
---
# Select a hosting method for your controls in Unified Service Desk
[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] offers you three browser controls for hosting your webpages:  `IE Process`, `Internal WPF`, and `Web Hosted Application`. Select a browser control to host your webpage in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] from the **Hosting Type** list when you define a hosted control instance.  
  
 ![Hosting type in Unified Service Desk](../unified-service-desk/media/crm-itpro-usd-samplehostedcontrol.PNG "Hosting type in Unified Service Desk")  
  
<a name="IEProcess"></a>   
## IE Process  
 The `IE Process` browser control hosts your controls in individual [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] process instances, and displays them in tabs in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application. It facilitates predictable page rendering by making sure that if your web application works in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], it will work in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. You can select **IE Process** as the hosting method for the **CRM Dialog**, **CRM Page**, **KM Control**, and **Standard Web Application** type of hosted controls.  
  
> [!NOTE]
>  To use the **IE Process** browser control, you must select the **Enable Protected Mode** check box for the **Local Intranet** security zone in Internet Explorer. More information: [What does Internet Explorer protected mode do?](http://windows.microsoft.com/en-US/windows-vista/What-does-Internet-Explorer-protected-mode-do)  
>   
>  If enabling protected mode for intranet sites is not feasible, you must instead add the following URLs to the **Restricted Sites** security zone in Internet Explorer:  
>   
>  -   http://close  
> -   http://event  
> -   http://uii  
>   
> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security zones: adding or removing websites](http://windows.microsoft.com/en-us/windows/security-zones-adding-removing-websites#1TC=windows-7)  
>   
>  If you do not enable the protected mode for the **Local Intranet** security zone or add the above URLs to the **Restricted Sites** security zone, blank pages with `http://event?eventname=usdreload` in the address bar will pop up for users when they work in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Blog: IE Process mode gives http://event popup](https://blogs.msdn.microsoft.com/usd/2016/01/26/ie-process-mode-gives-httpevent-popup/)  
  
 The `IE Process` browser control has been rewritten in [!INCLUDE[pn_unified_service_desk_20](../includes/pn-unified-service-desk-20.md)] to offer significant memory and performance enhancements:  
  
- **Better memory management**: [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] process instances used for hosting your webpages are now hosted outside of the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] process instance. This significantly reduces the memory footprint of [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] when you display or work with multiple controls at the same time within the client application.  
  
- **Improved stability and performance**: The [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] process instances used for hosting your webpages are isolated from each other so that when a hosted control becomes unresponsive in the client application, all the other hosted control tabs along with the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application continue to remain operational. Also, the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] Monitoring Process (usdmp.exe) service continuously monitors the health of [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], and terminates any browser process instances that are unresponsive and causing [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to freeze. If a browser process instance isn’t responding, but [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is responsive, the browser process instance won’t be terminated.  
  
     Use the `ProcessTerminationThreshold` option in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to specify the timeout period for the duration (in milliseconds) that the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] Monitoring Process (usdmp.exe) service waits before terminating an unresponsive [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] process that's causing [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to become unresponsive. Valid range is between 0 and 30000. If set to 0, the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] Monitoring Process (usdmp.exe) service won't start, and won't monitor [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] for unresponsive behavior. If set to any other value within the range, [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] automatically starts the monitoring process. The default value is 5000 milliseconds (5 seconds). For more information about setting this option, see [Manage Options for Unified Service Desk](admin/manage-options-unified-service-desk.md)  
  
> [!NOTE]
>  With [!INCLUDE[pn_unified_service_desk_20](../includes/pn-unified-service-desk-20.md)], when you create an instance of a **CRM Dialog**, **CRM Page**, **KM Control**, or **Standard Web Application** type of hosted control, the **Hosting Type** field in the `New Hosted Control` form is set to `IE Process` as the default option. Previously,  `Internal WPF` used to be the default hosting type option. You can select **Internal WPF** instead for your hosted control, if required.  
  
<a name="InternalWPF"></a>   
## Internal WPF  
 The `Internal WPF` browser control uses the [WpfBrowser](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.controls.wpfbrowser) component, which is based on the [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)][WebBrowser](https://msdn.microsoft.com/library/system.windows.forms.webbrowser.aspx) control, to host the webpages in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. This browser control is the traditional method of hosting controls in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. It uses the security subsystem in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] and [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] to allow the hosted application to operate the browser functionality in the same mode as the application without changing the [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] settings, and therefore reduces the security of Internet Explorer for applications outside of Unified Service Desk. While there are advantages, occasionally you may find that you need the features of an [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] add-in or a feature in the native browser that may not be supported in this browser control, and you should use the **IE Process** browser control instead.  
  
<a name="WebHostedApp"></a>   
## Web Hosted Application  
 The `Web Hosted Application` browser control is applicable only for the legacy `CCA Hosted Application` type of hosted control. This browser control doesn’t provide native features of [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] such as events and toolbars.  
  
### See also  
 [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md)   
 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   
 [Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)
