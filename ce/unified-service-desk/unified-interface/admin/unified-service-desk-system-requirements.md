---
title: "Unified Service Desk  system requirements | MicrosoftDocs"
description: "Describes the supported dependent and optional components you need to install and use Unified Service Desk . "
keywords: 
ms.date: 05/14/2019
ms.service:
  - dynamics-365-customerservice
ms.custom:
  - dyn365-USD, dyn365-admin
ms.topic: get-started-article
applies_to:
  - Dynamics 365 Customer Engagement apps
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
ms.assetid: 8a0e7dc4-5d32-412a-ae72-b6ce010c1c85
author: kabala123
ms.author: kabala
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Requirements
This topic provides information about the system requirements for installing the [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] client application and deploying the [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] sample applications on a the Common Data Service platform instance.  

<a name="hardware"></a>   
## Hardware requirements for the Unified Service Desk client  
 The following table lists the minimum and recommended hardware requirements when you run the [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] client.  


| Component |                                           Minimum                                           |                                                                                                                                                                            Recommended                                                                                                                                                                            |
|-----------|---------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Processor | x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor |                                                                                                                                    x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor                                                                                                                                    |
|  Memory   |                                      ^4-GB RAM or more                                       |                                                                                                                                                                         8-GB RAM or more                                                                                                                                                                          |
| Hard disk |                            \*1.5 GB of available hard disk space                            | 12 GB of available hard disk space: 2 GB of available hard disk space for [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] client application files and 10 GB additional available hard disk space for [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] client log files<br /><br /> 7200 RPM or more |

 ^The minimum memory is for running basic scenarios. The actual memory required for Unified Service Desk increases with the complex configurations and custom development (UI experience).
 
 *Requires disabling [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] client logging. [!INCLUDE[proc_more_information](../../../includes/proc-more-information.md)] [Configure client diagnostic logging in Unified Service Desk](../../../unified-service-desk/admin/configure-client-diagnostic-logging-unified-service-desk.md)  

<a name="client"></a>   
## Software requirements for the Unified Service Desk client

 To install the [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] client on a computer, the following is required:  

| Requirement | Recommended Version | Supported Version|
|---------------------------|---------------------------|---------------------|
| Operating system | <ul><li>[!INCLUDE[pn_windows_10](../../../includes/pn-windows-10.md)] </li></ul> |<ul><li> [!INCLUDE[pn_windows_10](../../../includes/pn-windows-10.md)] </li><li> [!INCLUDE[pn_windows_8_1](../../../includes/pn-windows-8-1.md)]</li><li> [!INCLUDE[pn_windows8](../../../includes/pn-windows8.md)]</li><li> [!INCLUDE[pn_Windows_7](../../../includes/pn-windows-7.md)] Service Pack 1 (SP1)</li></ul>  |
| Web browser | <ul><li> [!INCLUDE[pn_ie_11](../../../includes/pn-ie-11.md)] </li><li> Microsoft Edge (Preview)</li></ul> | <ul><li> [!INCLUDE[pn_ie_11](../../../includes/pn-ie-11.md)] </li><li> Microsoft Edge (Preview)</li></ul> |
| Microsoft .NET Framework | <ul><li>[!INCLUDE[pn_NET_Framework_462_long](../../../includes/pn-net-framework-462-long.md)] (installed during [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] Setup if missing)</li></ul> |  |
| Windows Identity Foundation  | <ul><li> Windows Identity Foundation 3.5 (installed during Unified Service Desk Setup if missing) </li></ul> |  |
| Screen resolution | <ul><li> 1920 x 1080 (Pixels) </li></ul> |  |
| Magnifier | <ul><li> 100 % </li></ul> |  

  > [!Tip]
  > We recommend that you use [!INCLUDE[pn_windows_10](../../../includes/pn-windows-10.md)] and [!INCLUDE[pn_ie_11](../../../includes/pn-ie-11.md)].
  > 
  > [!IMPORTANT]
  > [!INCLUDE[pn_microsoft_edge](../../../includes/pn-microsoft-edge.md)] (Preview) is currently supported for use with the [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] client. More information: [Edge Process](../../edge-process.md).

<a name="SampleApps"></a>   
## Software requirements for deploying Unified Service Desk sample applications  
 To deploy a [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] sample application, an instance of the Common Data Service platform (online or on-premises), [!INCLUDE[pn_crm_2015](../../../includes/pn-crm-2015.md)], or [!INCLUDE[pn_crm_2013_sp](../../../includes/pn-crm-2013-sp.md)] is required.  

::: moniker range=">=dynamics-usd-4.1"

> [!IMPORTANT]
>  Although you can deploy and use [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] sample applications with [!INCLUDE[pn_crm_2015](../../../includes/pn-crm-2015.md)] or [!INCLUDE[pn_crm_2013_sp](../../../includes/pn-crm-2013-sp.md)], we recommend that you upgrade to [!INCLUDE[pn_crm_2016](../../../includes/pn-crm-2016.md)] so you can use the new features available.  
> We recommend that you use Unified Service Desk 4.1 with [!INCLUDE [pn-crm-9-0-0-online](../../../includes/pn-crm-9-0-0-online.md)]. [Get Unified Service Desk 4.1  now](https://go.microsoft.com/fwlink/p/?linkid=2086721).

::: moniker-end

::: moniker range="=dynamics-usd-4" 

> [!IMPORTANT]
>  Although you can deploy and use [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] sample applications with [!INCLUDE[pn_crm_2015](../../../includes/pn-crm-2015.md)] or [!INCLUDE[pn_crm_2013_sp](../../../includes/pn-crm-2013-sp.md)], we recommend that you upgrade to [!INCLUDE[pn_crm_2016](../../../includes/pn-crm-2016.md)] so you can use the new features available.  
> We recommend that you use Unified Service Desk 4.0 with [!INCLUDE [pn-crm-9-0-0-online](../../../includes/pn-crm-9-0-0-online.md)]. [Get Unified Service Desk 4.0  now](https://go.microsoft.com/fwlink/p/?linkid=2007340).

::: moniker-end

 For information about the sample applications available for this release, see [Deploy sample Unified Service Desk applications to Dynamics 365 Customer Engagement server using Package Deployer](../../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md).  

<a name="packdeploy"></a>   
## Software requirements for the Package Deployer tool  
 The [!INCLUDE[pn_package_deployer_tool](../../../includes/pn-package-deployer-tool.md)] is used for deploying [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] sample applications. The tool supports and requires the following technologies:  

- For running the tool, use one of these [!INCLUDE[pn_Windows_Server](../../../includes/pn-windows-server.md)] versions: [!INCLUDE[pn_windows_server_2012_r2](../../../includes/pn-windows-server-2012-r2.md)], [!INCLUDE[pn_windowsserver2012](../../../includes/pn-windowsserver2012.md)], [!INCLUDE[pn_Windows_Server_2008_R2](../../../includes/pn-windows-server-2008-r2.md)].

- An instance of the Common Data Service platform (online or on-premises), [!INCLUDE[pn_crm_2015](../../../includes/pn-crm-2015.md)], or [!INCLUDE[pn_crm_2013_sp](../../../includes/pn-crm-2013-sp.md)].  

- Additionally, [!INCLUDE[pn_PowerShell](../../../includes/pn-powershell.md)] 3.0 or later is required if you’ll be using [!INCLUDE[pn_PowerShell_short](../../../includes/pn-powershell-short.md)] cmdlets for [!INCLUDE[pn_package_deployer_short](../../../includes/pn-package-deployer-short.md)] to deploy sample applications. To check your [!INCLUDE[pn_PowerShell_short](../../../includes/pn-powershell-short.md)] version, open a [!INCLUDE[pn_PowerShell_short](../../../includes/pn-powershell-short.md)] window, and then run the following command: `$Host`  
 

## Impact of Unified Interface Only availability with Unified Service Desk

You have deployed Unified Service Desk in a Customer Engagement Sandbox environment and when you reset the sandbox environment, you will have only the Unified Interface experience. To enable the Web Client experience, set **No** for the **Use the new Unified Interface Only** option in the system settings. More information: [How to enable/disable Unified Interface Only mode](/dynamics365/customer-engagement/admin/enable-unified-interface-only#how-to-enable-unified-interface-only-mode).

After you enable the Web Client experience, go to the Window Navigation Rules and update the navigation URLs for the all the rules.

<a name="appvirtual"></a>   
## Software requirements for Citrix XenApp application virtualization  
 You can install and run the [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] client as a published app on Citrix XenApp 7.6. This allows agents to access the [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)] client from a central location.  

 You can also configure a Windows application as a virtual application on Citrix XenApp 7.6 that run as a hosted application in [!INCLUDE[pn_unified_service_desk](../../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../../includes/proc-more-information.md)] [Integrate with Citrix applications](../../integrate-citrix-applications.md)  

## See also  
 [Install Unified Service Desk Client](../../../unified-service-desk/admin/install-upgrade-unified-service-desk-client.md)   
 [Deploy Unified Service Desk packages to Dynamics 365 Customer Engagement server using Package Deployer](../../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)   
 [Install and Deploy Unified Service Desk](../../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)   
