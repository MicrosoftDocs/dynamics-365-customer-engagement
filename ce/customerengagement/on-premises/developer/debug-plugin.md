---
title: "Debug a plug-In (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about debugging a plug-in executing on a D365 Server."
keywords: 
ms.date: 01/28/2019
ms.service: crm-online
ms.custom: on-premise
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: b4bbe405-a56f-450b-acd9-0c063cf35990
author: JimDaly
ms.author: jdaly
manager: amyla
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 60
topic-status: Drafting
search.audienceType: 
  - developer

---

# Debug an on-premise registered plug-In

General information about plug-in debugging can be found in the Dataverse topic [Debug a plug-in](/powerapps/developer/common-data-service/debug-plug-in). The following steps describe how to debug a plug-in executing on Dynamics 365 Customer Engagement (on-premises).

> [!NOTE]
> An alternate method to debug a plug-in that executes in the sandbox on any deployment type is to use the tracing service. For more information about tracing see [Logging and tracing](/powerapps/developer/common-data-service/logging-tracing). For more information about debugging, including a tutorial, see the Dataverse topic [Debug a plug-in](/powerapps/developer/common-data-service/debug-plug-in).
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

<a name="bkmk_debugaplugin"></a>   
## Debug a plug-in  
  
1. Register and deploy the plug-in assembly.  
  
    If there is another copy of the assembly at the same location and you cannot overwrite that copy because it is locked by Dynamics 365 Customer Engagement (on-premises), you must restart the service process that was executing the plug-in. Refer to the table below for the correct service process. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Register and Deploy Plug-ins](register-deploy-plugins.md)  
  
2. Configure the debugger.  
  
    Attach the debugger to the process on the Dynamics 365 Server that will run your plug-in. Refer to the following table to identify the process.  
  
   |Plug-in Registration Configuration|Service Process|  
   |-----------------------------------------|---------------------|  
   |online|w3wp.exe|  
   |offline|Microsoft.Crm.Application.Hoster.exe|  
   |asynchronous registered plug-ins (or custom workflow assemblies)|CrmAsyncService.exe|  
   |sandbox (isolation mode)|Microsoft.Crm.Sandbox.WorkerProcess.exe|  
  
    If there are multiple processes running the same executable file, for example multiple w3wp.exe processes, attach the debugger to all instances of the running executable process. Next, set one or more breakpoints in your plug-in code.  
  
3. Test the plug-in.  
  
    Run the Dynamics 365 Customer Engagement (on-premises) application, or other custom application that uses the SDK, and perform whatever action is required to cause the plug-in to execute. For example, if a plug-in is registered for an account creation event, create a new account.  
  
4. Debug your plug-in code.  
  
    Make any needed changes to your code so that it performs as you want. If the code is changed, compile the code into an assembly and repeat steps 1 through 4 in this procedure as necessary. However, if you change the plug-in assembly’s major or minor version numbers, you must unregister the earlier version of the assembly and register the new version. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Register and Deploy Plug-ins](register-deploy-plugins.md)  
  
5. Register the plug-in in the database.  
  
    After the edit/compile/deploy/test/debug cycle for your plug-in has been completed, unregister the (on-disk or GAC) plug-in assembly and then reregister the plug-in in the Dynamics 365 Customer Engagement (on-premises) database. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Register and Deploy Plug-ins](register-deploy-plugins.md)  
  
> [!TIP]
>  It is possible to debug a database deployed plug-in. The compiled plug-in assembly's symbol file (.pdb) must be copied to the server's \<*crm-root*>\Server\bin\assembly folder and [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] must then be restarted. After debugging has been completed, you must remove the symbol file and reset IIS to prevent the process that was executing the plug-in from consuming additional memory.  
  
 For more information about debugging a plug-in using the Plug-in Profiler tool, see [Debug a plug-in](/powerapps/developer/common-data-service/tutorial-debug-plug-in).  
  
<a name="bkmk_sandboxplugin"></a>   
## Debug a sandboxed plug-in  
 It is important to perform these steps before the first execution of a sandboxed plug-in. If the plug-in has already been executed, either change the code of the assembly, causing the hash of the assembly to change on the server, or restart the Dynamics 365 Customer Engagement (on-premises) Sandbox Processing Service on the sandbox server.  
  
 **Configure the on-premise server**  
  
 The sandbox host process monitors the sandbox worker process which is executing the plug-in. The host process checks if the plug-in stops responding, if it is exceeding memory thresholds, and more. If the worker process doesn't respond for than 30 seconds, it will be shutdown. In order to debug a sandbox plug-in, you must disable this shutdown feature. To disable the shutdown feature, set the following registry key to 1 (`DWORD`):  
  
```ms-dos  
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM\SandboxDebugPlugins  
```  
  
 **Debug the Plug-in**  
  
 Follow these steps to debug a sandboxed plug-in.  
  
1. Register the plug-in in the sandbox (isolation mode) and deploy it to the Dynamics 365 Server database.  
  
2. Copy the symbol file (.pdb) of the compiled plug-in assembly to the server\bin\assembly folder on the server running the sandbox worker process named Microsoft.Crm.Sandbox.WorkerProcess.exe. This is the server hosting the Sandbox Processing Service role.  
  
3. Follow the instructions in steps 2 through 4 presented at the beginning of this topic.  
  
   For more information about debugging a plug-in using the Plug-in Profiler tool, see [Debug a plug-in](/powerapps/developer/common-data-service/tutorial-debug-plug-in).  
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Debug a plug-in](/powerapps/developer/common-data-service/tutorial-debug-plug-in)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)   
 [Write a plug-in](/powerapps/developer/common-data-service/write-plug-in) 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]