---
title: "Unified Service Desk for Dynamics 365 Customer Engagement system requirements | MicrosoftDocs"
description: "Describes the supported dependent and optional components you need to install and use Unified Service Desk for Dynamics 365 Customer Engagement. " 
ms.custom:
  - dyn365-USD, dyn365-admin
ms.date: 02/06/2018
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 8a0e7dc4-5d32-412a-ae72-b6ce010c1c85
author: kabala123
ms.author: kabala
manager: sakudes
---
# Requirements
This topic provides information about the system requirements for installing the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application and deploying the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample applications on a [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] instance.  
  
<a name="hardware"></a>   
## Hardware requirements for the Unified Service Desk client  
 The following table lists the minimum and recommended hardware requirements when you run the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  
  
|Component|Minimum|Recommended|  
|---------------|-------------|-----------------|  
|Processor|x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor|x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor|  
|Memory|2-GB RAM or more|4-GB RAM or more|  
|Hard disk|*1.5 GB of available hard disk space|12 GB of available hard disk space: 2 GB of available hard disk space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application files and 10 GB additional available hard disk space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client log files<br /><br /> 7200 RPM or more|  
  
 *Requires disabling [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client logging. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure client diagnostic logging in Unified Service Desk](../../unified-service-desk/admin/configure-client-diagnostic-logging-unified-service-desk.md)  
  
<a name="client"></a>   
## Software requirements for the Unified Service Desk client  
 To install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client on a computer, the following is required:  
  
- [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)], [!INCLUDE[pn_windows_8_1](../../includes/pn-windows-8-1.md)], [!INCLUDE[pn_windows8](../../includes/pn-windows8.md)], or [!INCLUDE[pn_Windows_7](../../includes/pn-windows-7.md)]  
  
- [!INCLUDE[pn_ie_11](../../includes/pn-ie-11.md)], [!INCLUDE[pn_IE_10](../../includes/pn-ie-10.md)], or <sup>*</sup>[!INCLUDE[pn_IE_9](../../includes/pn-ie-9.md)]  

    > [!Tip]
    > We recommend that you use [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)] and [!INCLUDE[pn_ie_11](../../includes/pn-ie-11.md)].
  
    > [!IMPORTANT]
    >  Although [!INCLUDE[pn_microsoft_edge](../../includes/pn-microsoft-edge.md)] is currently not supported for use with the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, you can use [!INCLUDE[pn_ie_11](../../includes/pn-ie-11.md)] with [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)].  
    >   
    >  <sup>*</sup> [!INCLUDE[pn_IE_9](../../includes/pn-ie-9.md)] is supported for use only with [!INCLUDE[pn_crm_2013_sp](../../includes/pn-crm-2013-sp.md)] organizations. Also, [!INCLUDE[pn_IE_9](../../includes/pn-ie-9.md)] may work for systems that are not [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
- [!INCLUDE[pn_NET_Framework_462_long](../../includes/pn-net-framework-462-long.md)] (installed during [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Setup if missing)  

> [!NOTE]
> - [!INCLUDE [pn-unified-service-desk-3-1](../../includes/pn-unified-service-desk-3-1.md)] or higher version installs [!INCLUDE[pn_NET_Framework_462_long](../../includes/pn-net-framework-462-long.md)]. 
> - [!INCLUDE [pn-unified-service-desk-3-0](../../includes/pn-unified-service-desk-3-0.md)] version installs [!INCLUDE[pn_NET_Framework_452_long](../../includes/pn-net-framework-452-long.md)].
 
  
- [!INCLUDE[pn_Windows_Identity_Foundation](../../includes/pn-windows-identity-foundation.md)] 3.5 (installed during [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Setup if missing)  
  
-   Recommended screen resolution (in pixels): 1920 x 1080  
  
-   Recommended zoom level in Magnifier: 100%  
  
<a name="SampleApps"></a>   
## Software requirements for deploying Unified Service Desk sample applications  
 To deploy a [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample application, an instance of [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] (online or on-premises), [!INCLUDE[pn_crm_2015](../../includes/pn-crm-2015.md)], or [!INCLUDE[pn_crm_2013_sp](../../includes/pn-crm-2013-sp.md)] is required.  
  
> [!IMPORTANT]
>  Although you can deploy and use [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample applications with [!INCLUDE[pn_crm_2015](../../includes/pn-crm-2015.md)] or [!INCLUDE[pn_crm_2013_sp](../../includes/pn-crm-2013-sp.md)], we recommend that you upgrade to [!INCLUDE[pn_crm_2016](../../includes/pn-crm-2016.md)] so you can use the new features available.  
> We recommend that you use [!INCLUDE [pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)] with [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)]. [Get Unified Service Desk 3.2 for Dynamics 365 now](https://go.microsoft.com/fwlink/p/?linkid=867343).
  
 For information about the sample applications available for this release, see [Deploy sample Unified Service Desk applications to Dynamics 365 server using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md).  
  
<a name="packdeploy"></a>   
## Software requirements for the Package Deployer tool  
 The [!INCLUDE[pn_package_deployer_tool](../../includes/pn-package-deployer-tool.md)] is used for deploying [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample applications. The tool supports and requires the following technologies:  
  
-   For running the tool, use one of these [!INCLUDE[pn_Windows_Server](../../includes/pn-windows-server.md)] versions: [!INCLUDE[pn_windows_server_2012_r2](../../includes/pn-windows-server-2012-r2.md)], [!INCLUDE[pn_windowsserver2012](../../includes/pn-windowsserver2012.md)], [!INCLUDE[pn_Windows_Server_2008_R2](../../includes/pn-windows-server-2008-r2.md)].
  
-   An instance of [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] (online or on-premises), [!INCLUDE[pn_crm_2015](../../includes/pn-crm-2015.md)], or [!INCLUDE[pn_crm_2013_sp](../../includes/pn-crm-2013-sp.md)].  
  
-   Additionally, [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] 3.0 or later is required if you’ll be using [!INCLUDE[pn_PowerShell_short](../../includes/pn-powershell-short.md)] cmdlets for [!INCLUDE[pn_package_deployer_short](../../includes/pn-package-deployer-short.md)] to deploy sample applications. To check your [!INCLUDE[pn_PowerShell_short](../../includes/pn-powershell-short.md)] version, open a [!INCLUDE[pn_PowerShell_short](../../includes/pn-powershell-short.md)] window, and then run the following command: `$Host`  
  
<a name="appvirtual"></a>   
## Software requirements for Citrix XenApp application virtualization  
 You can install and run the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client as a published app on Citrix XenApp 7.6. This allows agents to access the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client from a central location.  
  
 You can also configure a Windows application as a virtual application on Citrix XenApp 7.6 that run as a hosted application in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Integrate with Citrix applications](../integrate-citrix-applications.md)  
  
## See also  
 [Install Unified Service Desk Client](../../unified-service-desk/admin/install-upgrade-unified-service-desk-client.md)   
 [Deploy Unified Service Desk packages to Dynamics 365 Server using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)   
 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)   
