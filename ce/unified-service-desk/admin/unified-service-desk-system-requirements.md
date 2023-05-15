---
title: "Unified Service Desk system requirements | MicrosoftDocs"
description: "This topic lists the software and hardware requirements you need to install and use Unified Service Desk."
ms.date: 09/20/2022
ms.topic: get-started-article
author: gandhamm
ms.author: mgandham
ms.custom: 
  - dyn365-USD
  - dyn365-admin
---

# System requirements

This topic provides information about the system requirements for installing the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application and deploying the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample applications on the Microsoft Dataverse instance.  

<a name="hardware"></a>

## Hardware requirements for the Unified Service Desk client  

The following table lists the minimum and recommended hardware requirements to run the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  

| Component    | Minimum requirements     | Recommended requirements  |
|-----------|-----------------|--------------|
| Processor | x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor |   x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor     |
|  Memory   |   ^4 GB RAM or more            |  8 GB RAM or more    |
| Hard disk |  \*1.5 GB of available hard disk space             | 12 GB of available hard disk space: 2 GB of available hard disk space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application files and 10 GB additional available hard disk space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client log files<br /><br /> 7200 RPM or more |

^The minimum memory is for running basic scenarios. The actual memory required for Unified Service Desk increases with complex configurations and custom development (UI experience).

*Requires disabling [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client logging. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure client diagnostic logging in Unified Service Desk](../../unified-service-desk/admin/configure-client-diagnostic-logging-unified-service-desk.md)  

<a name="client"></a>

## Software requirements for the Unified Service Desk client

To install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client on a computer, you need the following:  

| Requirement | Recommended version | Supported version|
|---------------------------|---------------------------|-------------------------------------|
| Operating system | [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)]  |<ul><li> Windows 11 </li> <li> [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)] </li><li> [!INCLUDE[pn_windows_8_1](../../includes/pn-windows-8-1.md)]</li><li> [!INCLUDE[pn_windows8](../../includes/pn-windows8.md)]</li><li> [!INCLUDE[pn_Windows_7](../../includes/pn-windows-7.md)] Service Pack 1 (SP1)</li></ul>  |
| Microsoft .NET Framework |[!INCLUDE[pn_NET_Framework_462_long](../../includes/pn-net-framework-462-long.md)] (installed during [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] setup if missing) |  |
| Windows Identity Foundation  | Windows Identity Foundation 3.5 (installed during Unified Service Desk setup if missing) |  |
| Screen resolution |  1920 x 1080 (Pixels)  |  |
| Magnifier |  100 %  |
|||

## Support for Unified Service Desk

The latest three versions of Unified Service Desk are supported. On the release of the latest version of Unified Service Desk, the oldest supported version will be deprecated.

The supported versions of Unified Service Desk are 4.2, 4.1, and 4.0.

> [!IMPORTANT]
>
> Unified Service Desk version 3.3 and earlier are not supported after June 21, 2021; after this date, organizations with these versions will not have access to the Unified Service Desk client. If you're using Unified Service Desk version 3.3 or earlier, we recommend that you upgrade to the latest versions of Unified Service Desk and Dynamics 365 for Customer Service by October 01, 2021.

<a name="packdeploy"></a>

## Software requirements for the Package Deployer tool

 The [!INCLUDE[pn_package_deployer_tool](../../includes/pn-package-deployer-tool.md)] is used for deploying [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample applications. For more information on the requirements, see [Deploy packages using Dynamics CRM Package Deployer and Windows PowerShell](/dynamics365/customer-engagement/admin/deploy-packages-using-package-deployer-windows-powershell).

## Hosting types

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] offers you different browser controls for hosting your webpages.

| Supported hosting types | Recommended hosting types |
|-----------------------------|--------------------------------------|
| <ul><li> Edge WebView2 Process </li><li> Chrome Process </li><li> IE Process (discontinued) </li><li>Edge Process (discontinued) </li> <li> Internal WPF (deprecated) </li></ul> | Edge WebView2 Process  |
||

> [!Note]
>
> - Because support for Internet Explorer 11 is deprecated, support for IE Process has also been discontinued in Unified Service Desk. More information: [Deprecation announcement](../../customer-service/deprecations-customer-service.md#internet-explorer-11-support-for-dynamics-365-and-microsoft-power-platform-is-deprecated)
>
> - The support for hosting Unified Interface pages using Chrome Process (CefSharp) in Unified Service Desk 4.1.1.1397 and earlier versions is based on the Power Apps system requirements and limits. More information: [Supported browsers for running Power Apps](/power-apps/limits-and-config#supported-browsers-for-running-power-apps)

## Impact of Unified Interface Only availability with Unified Service Desk

You have deployed Unified Service Desk in a sandbox environment and when you reset the sandbox environment, you will have only the Unified Interface experience. To enable the web client experience, see [How to enable/disable Unified Interface Only mode](/dynamics365/customer-engagement/admin/enable-unified-interface-only#how-to-enable-unified-interface-only-mode).

After you enable the web client experience, go to the Window Navigation Rules and update the navigation URLs for all the rules.

<a name="appvirtual"></a>

## Software requirements for Citrix XenApp application virtualization

 You can install and run the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client as a published app on Citrix XenApp 7.6. This allows agents to access the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client from a central location.  

 You can also configure a Windows application as a virtual application on Citrix XenApp 7.6 that runs as a hosted application in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Integrate with Citrix applications](../integrate-citrix-applications.md)  

### See also

 [Install Unified Service Desk client](../../unified-service-desk/admin/install-upgrade-unified-service-desk-client.md)  
 [Deploy Unified Service Desk packages to Dataverse using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)  
 [Install and deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)  
[Upgrade a Unified Service Desk solution](upgrade-unified-service-desk-solution.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
