---
title: "Plug-in isolation, trusts, and statistics (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about collecting run-time statistics and monitors plug-ins and custom workflow activities that execute in the sandbox."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "sandbox"
  - "plug-in"
ms.assetid: fe83bfd4-7ac1-4b9c-8cea-dc32d3ed60b6
caps.latest.revision: 41
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Plug-in isolation, trusts, and statistics

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement supports the execution of plug-ins and custom workflow activities in an isolated environment. In this isolated environment, also known as a *sandbox*, a plug-in or custom activity can make use of the full power of the Organization Service. Access to the file system, system event log, certain network protocols, registry, and more is prevented in the sandbox. However, sandbox plug-ins and custom activities do have access to external endpoints like [!INCLUDE[pn_azure_cloud_services](../includes/pn-azure-cloud-services.md)].  
  
 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] collects run-time statistics and monitors plug-ins and custom workflow activities that execute in the sandbox. If the sandbox worker process that hosts this custom code exceeds threshold CPU, memory, or handle limits or is otherwise unresponsive, that process will be killed by the platform. At that point any currently executing plug-in or custom workflow activity in that worker process will fail with exceptions. However, the next time that the plug-in or custom workflow activity is executed it will run normally. There is one worker process per organization so failures in one organization will not affect another organization.  
  
 In summary, the sandbox is the recommended execution environment for plug-ins as it is more secure, supports run-time monitoring and statistics reporting, and is supported on all [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] deployments. In addition, [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] only supports execution of custom workflow activities if they are registered in the sandbox.  
  
## Trusts  
 Developers have the option of registering their plug-ins in the sandbox, known as partial trust, or outside the sandbox, known as full trust. Full trust is supported for on-premises and Internet-facing [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] deployments. For a [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] deployment, plug-ins or custom workflow activities must be registered in the sandbox (partial trust) where they are isolated as previously described.  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]
## Run-time statistics  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] platform collects run-time information about plug-ins and custom workflow activities that execute in the sandbox. This information is stored in the database using `PluginTypeStatistic` entity records. These records are populated within 30 minutes to one hour after the sandboxed custom code executes. See the `PluginTypeStatistic` attributes to find out what information is collected. You can retrieve this information by using the retrieve message or method.  
  
## Web access  
 Sandboxed plug-ins and custom workflow activities can access the network through the HTTP and HTTPS protocols. This capability provides support for accessing popular web resources like social sites, news feeds, web services, and more. The following web access restrictions apply to this sandbox capability.  
  
-   Only the HTTP and HTTPS protocols are allowed.  
  
-   Access to localhost (loopback) is not permitted.  
  
-   IP addresses cannot be used. You must use a named web address that requires DNS name resolution.  
  
-   Anonymous authentication is supported and recommended. There is no provision for prompting the logged on user for credentials or saving those credentials.  
  
 These default web access restrictions are defined in a registry key on the server that is running the Microsoft.Crm.Sandbox.HostService.exe process. The value of the registry key can be changed by the System Administrator according to business and security needs. The registry key path on the server is:  
  
 `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM\SandboxWorkerOutboundUriPattern`  
  
 The key value is a regular expression string that defines the web access restrictions. The default key value is:  
  
```
"^http[s]?://(?!((localhost[:/])|(\[.*\])|([0-9]+[:/])|(0x[0-9a-f]+[:/])|(((([0-9]+)|(0x[0-9A-F]+))\.){3}(([0-9]+)|(0x[0-9A-F]+))[:/]))).+";  
```  
  
 By changing this registry key value, you can change the web access for sandboxed plug-ins.  
  
> [!IMPORTANT]
>  The sandbox processing service role defaults to outbound calls being enabled. If you do not want to permit outbound calls from custom code (plug-ins or custom workflow activities), you can disable outbound calls by setting the following registry key to 1 (DWORD) on the server that hosts the sandbox processing service role. Next, restart the Dynamics 365 Sandbox Processing Service.  
>   
>  `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM\SandboxWorkerDisableOutboundCalls`  
  
### See also  
 [Introduction to the Event Framework](introduction-event-framework.md)   
 [Write a Plug-in](write-plugin.md)   
 [Create a Custom Workflow Activity](workflow/create-custom-workflow-activity.md)   
 [Azure Extensions for Dynamics 365](azure-extensions.md)   
 <!-- Bug 700894 to make PluginTypeStatistic public  [PluginTypeStatistic Entity](entities/plugintypestatistic.md)   -->
 [Sample: Web Access from a Sandboxed Plug-in](sample-web-access-sandboxed-plugin.md)
