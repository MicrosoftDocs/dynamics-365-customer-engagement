---
title: "Unified Service Desk  system requirements | MicrosoftDocs"
description: "Describes the supported dependent and optional components you need to install and use Unified Service Desk."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 01/29/2021
ms.topic: get-started-article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
---

# Requirements

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

This topic provides information about the system requirements for installing the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application and deploying the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample applications on the Microsoft Dataverse instance.  

<a name="hardware"></a>
## Hardware requirements for the Unified Service Desk client  
 The following table lists the minimum and recommended hardware requirements when you run the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  


| Component |                                           Minimum                                           |                                                                                                                                                                            Recommended                                                                                                                                                                            |
|-----------|---------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Processor | x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor |                                                                                                                                    x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor                                                                                                                                    |
|  Memory   |                                      ^4-GB RAM or more                                       |                                                                                                                                                                         8-GB RAM or more                                                                                                                                                                          |
| Hard disk |                            \*1.5 GB of available hard disk space                            | 12 GB of available hard disk space: 2 GB of available hard disk space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application files and 10 GB additional available hard disk space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client log files<br /><br /> 7200 RPM or more |

 ^The minimum memory is for running basic scenarios. The actual memory required for Unified Service Desk increases with the complex configurations and custom development (UI experience).
 
 *Requires disabling [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client logging. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure client diagnostic logging in Unified Service Desk](../../unified-service-desk/admin/configure-client-diagnostic-logging-unified-service-desk.md)  

<a name="client"></a>   
## Software requirements for the Unified Service Desk client

 To install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client on a computer, the following is required:  

| Requirement | Recommended Version | Supported Version|
|---------------------------|---------------------------|-------------------------------------|
| Operating system | <ul><li>[!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)] </li></ul> |<ul><li> [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)] </li><li> [!INCLUDE[pn_windows_8_1](../../includes/pn-windows-8-1.md)]</li><li> [!INCLUDE[pn_windows8](../../includes/pn-windows8.md)]</li><li> [!INCLUDE[pn_Windows_7](../../includes/pn-windows-7.md)] Service Pack 1 (SP1)</li></ul>  |
| Microsoft .NET Framework | <ul><li>[!INCLUDE[pn_NET_Framework_462_long](../../includes/pn-net-framework-462-long.md)] (installed during [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Setup if missing)</li></ul> |  |
| Windows Identity Foundation  | <ul><li> Windows Identity Foundation 3.5 (installed during Unified Service Desk Setup if missing) </li></ul> |  |
| Screen resolution | <ul><li> 1920 x 1080 (Pixels) </li></ul> |  |
| Magnifier | <ul><li> 100 % </li></ul> |

## Support for Unified Service Desk

Unified Service Desk supports the latest three releases (N-2 format). On the release of the next version of Unified Service Desk, the oldest supported version will be deprecated.

For example, If Unified Service Desk 4.2 is released, then Unified Service Desk 3.3 version will be deprecated.

Supported Unified Service Desk versions are:

- Unified Service Desk 4.1

- Unified Service Desk 4.0

- Unified Service Desk 3.3

> [!IMPORTANT]
>
> Unified Service Desk version 3.2 and earlier will not be supported after February 28, 2021; after this date, organizations with these versions will not have access to the Unified Service Desk client. If you are using Unified Service Desk version 3.2 or earlier, we recommend that you upgrade to the latest versions of Unified Service Desk and Dynamics 365 Customer Service by February 28, 2021.

<a name="packdeploy"></a>   
## Software requirements for the Package Deployer tool  
 The [!INCLUDE[pn_package_deployer_tool](../../includes/pn-package-deployer-tool.md)] is used for deploying [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample applications. For more information on the requirements, see [Deploy packages using Dynamics CRM Package Deployer and Windows PowerShell](/dynamics365/customer-engagement/admin/deploy-packages-using-package-deployer-windows-powershell).

## Hosting types

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] offers you different browser controls for hosting your webpages.

| Supported Hosting Types | Recommended Hosting Types |
|-----------------------------|--------------------------------------|
| <ul><li> Chrome Process </li><li> IE Process (Deprecated) </li><li>Edge Process (Preview) </li> <li> Internal WPF </li></ul> | <ul><li> Chrome Process </li></ul> |
||

> [!Note]
>
> Because support for Internet Explorer 11 is deprecated, support for IE Process has also been deprecated in Unified Service Desk. For information: [Deprecation announcement](../../customer-service/deprecations-customer-service.md#internetexplorer11).

## Impact of Unified Interface Only availability with Unified Service Desk

You have deployed Unified Service Desk in a sandbox environment and when you reset the sandbox environment, you will have only the Unified Interface experience. To enable the web client experience, see [How to enable/disable Unified Interface Only mode](/dynamics365/customer-engagement/admin/enable-unified-interface-only#how-to-enable-unified-interface-only-mode).

After you enable the web client experience, go to the Window Navigation Rules and update the navigation URLs for the all the rules.

<a name="appvirtual"></a>   
## Software requirements for Citrix XenApp application virtualization  
 You can install and run the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client as a published app on Citrix XenApp 7.6. This allows agents to access the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client from a central location.  

 You can also configure a Windows application as a virtual application on Citrix XenApp 7.6 that run as a hosted application in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Integrate with Citrix applications](../integrate-citrix-applications.md)  

## See also

 [Install Unified Service Desk Client](../../unified-service-desk/admin/install-upgrade-unified-service-desk-client.md)

 [Deploy Unified Service Desk packages to Dataverse using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)
 
 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)
