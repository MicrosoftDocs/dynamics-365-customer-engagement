---
title: "Debug a plug-In (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about debuggin a plug-in by logging and tracing."
keywords: ""
ms.date: 01/19/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: b4bbe405-a56f-450b-acd9-0c063cf35990
author: JimDaly
ms.author: jdaly
manager: amyla
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 60
topic-status: Drafting
---

# Debug a plug-In

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The following steps describe how to debug a plug-in executing on [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-onprem.md)]. To debug a plug-in that executes in the sandbox on [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement, you must be using tracing as described later in this topic.  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]
<a name="bkmk_debugaplugin"></a>   
## Debug a plug-in  
  
1.  Register and deploy the plug-in assembly.  
  
     If there is another copy of the assembly at the same location and you cannot overwrite that copy because it is locked by [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you must restart the service process that was executing the plug-in. Refer to the table below for the correct service process. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Register and Deploy Plug-ins](register-deploy-plugins.md)  
  
2.  Configure the debugger.  
  
     Attach the debugger to the process on the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server that will run your plug-in. Refer to the following table to identify the process.  
  
    |Plug-in Registration Configuration|Service Process|  
    |-----------------------------------------|---------------------|  
    |online|w3wp.exe|  
    |offline|Microsoft.Crm.Application.Hoster.exe|  
    |asynchronous registered plug-ins (or custom workflow assemblies)|CrmAsyncService.exe|  
    |sandbox (isolation mode)|Microsoft.Crm.Sandbox.WorkerProcess.exe|  
  
     If there are multiple processes running the same executable file, for example multiple w3wp.exe processes, attach the debugger to all instances of the running executable process. Next, set one or more breakpoints in your plug-in code.  
  
3.  Test the plug-in.  
  
     Run the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] application, or other custom application that uses the SDK, and perform whatever action is required to cause the plug-in to execute. For example, if a plug-in is registered for an account creation event, create a new account.  
  
4.  Debug your plug-in code.  
  
     Make any needed changes to your code so that it performs as you want. If the code is changed, compile the code into an assembly and repeat steps 1 through 4 in this procedure as necessary. However, if you change the plug-in assembly’s major or minor version numbers, you must unregister the earlier version of the assembly and register the new version. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Register and Deploy Plug-ins](register-deploy-plugins.md)  
  
5.  Register the plug-in in the database.  
  
     After the edit/compile/deploy/test/debug cycle for your plug-in has been completed, unregister the (on-disk) plug-in assembly and then reregister the plug-in in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] database. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Register and Deploy Plug-ins](register-deploy-plugins.md)  
  
> [!TIP]
>  It is possible to debug a database deployed plug-in. The compiled plug-in assembly's symbol file (.pdb) must be copied to the server's \<*crm-root*>\Server\bin\assembly folder and [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] must then be restarted. After debugging has been completed, you must remove the symbol file and reset IIS to prevent the process that was executing the plug-in from consuming additional memory.  
  
 For more information about debugging a plug-in using the Plug-in Profiler tool, see [Analyze Plug-in Performance](analyze-plugin-performance.md).  
  
<a name="bkmk_sandboxplugin"></a>   
## Debug a sandboxed plug-in  
 It is important to perform these steps before the first execution of a sandboxed plug-in. If the plug-in has already been executed, either change the code of the assembly, causing the hash of the assembly to change on the server, or restart the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Sandbox Processing Service on the sandbox server.  
  
 **Configure the Server**  
  
 The sandbox host process monitors the sandbox worker process which is executing the plug-in. The host process checks if the plug-in stops responding, if it is exceeding memory thresholds, and more. If the worker process doesn't respond for than 30 seconds, it will be shutdown. In order to debug a sandbox plug-in, you must disable this shutdown feature. To disable the shutdown feature, set the following registry key to 1 (`DWORD`):  
  
```ms-dos  
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM\SandboxDebugPlugins  
```  
  
 **Debug the Plug-in**  
  
 Follow these steps to debug a sandboxed plug-in.  
  
1.  Register the plug-in in the sandbox (isolation mode) and deploy it to the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server database.  
  
2.  Copy the symbol file (.pdb) of the compiled plug-in assembly to the server\bin\assembly folder on the server running the sandbox worker process named Microsoft.Crm.Sandbox.WorkerProcess.exe. This is the server hosting the Sandbox Processing Service role.  
  
3.  Follow the instructions in steps 2 through 4 presented at the beginning of this topic.  
  
 For more information about debugging a plug-in using the Plug-in Profiler tool, see [Analyze Plug-in Performance](analyze-plugin-performance.md).  
  
<a name="loggingandtracing"></a>   
## Logging and tracing  
 An alternative method to troubleshoot a plug-in or custom workflow activity (custom code), compared to debugging in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)], is to use tracing. Tracing assists developers by recording run-time custom information as an aid in diagnosing the cause of code failures. Tracing is especially useful to troubleshoot [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] registered custom code as it is the only supported troubleshooting method for that scenario. Tracing is supported for sandboxed (partial trust) and full trust registered custom code and during synchronous or asynchronous execution. Tracing isn’t supported for custom code that executes in [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] or other mobile client.  
  
 Recording of run-time tracing information for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] is provided by a service named <xref:Microsoft.Xrm.Sdk.ITracingService>. Information provided to this service by custom code can be recorded in three different places as identified here.  

> [!NOTE]
> Trace logging using `ITracingService` interface works only when the Plug-in is registered in Sandbox mode.

- **Trace log**  
  
     Trace log records of type **PluginTraceLog** can be found in the web application by navigating to **Settings** and choosing the **Plug-in Trace Log** tile. The tile is only visible if you have access to the trace log entity records in your assigned security role. Writing of these records is controlled by the trace settings mentioned in the next section.
  
    > [!NOTE]
    >  Trace logging takes up organization storage space especially when many traces and exceptions are generated. You should only turn trace logging on for debugging and troubleshooting, and turn it off after your investigation is completed.  
  
- **Error dialog**  
  
     A synchronous registered plug-in or custom workflow activity that returns an exception back to the platform results in an error dialog box in the web application presented to the logged on user. The user may select the **Download Log File** button in the dialog to view the log containing exception and trace output.  
  
- **System job**  
  
     For asynchronous registered plug-in or custom workflow activities that returns an exception, the tracing information is shown in the **Details** area of the **System Job** form in the web application.  
  
<a name="bkmk_trace-settings"></a>   
### Enable trace logging  
 To enable trace logging in an organization that supports this feature, in the web application navigate to **Settings** > **Administration** > **System Settings**. In the **Customization** tab, locate the drop-down menu labeled **Enable logging to plug-in trace log** and select one of the available options.  
  
|Option|Description|  
|------------|-----------------|  
|Off|Writing to the trace log is disabled. No **PluginTraceLog** records will be created. However, custom code can still call the <xref:Microsoft.Xrm.Sdk.ITracingService.Trace(System.String,System.Object[])> method even though no log is written.|  
|Exceptions|Trace information is written to the log if an exception is passed back to the platform from custom code.|  
|All|Trace information is written to the log upon code completion or an exception is passed back to the platform from the custom code.|  
  
 If the trace logging setting is set to **Exception** and your custom code returns an exception back to the platform, a trace log record is created and tracing information is also written to one other location. For custom code that executes synchronously, the information is presented to the user in an error dialog box, otherwise, for asynchronous code, the information is written to the related system job.  
  
 By default, the System Administrator and System Customizer roles have the required privileges to change the trace logging setting, which is stored in a <xref:Microsoft.Xrm.Sdk.Deployment.TraceSettings> entity record. Trace settings have an organization scope.  
  
### Write to the tracing service  
 Before writing to the tracing service, you must first extract the tracing service object from the passed execution context. Afterwards, simply add <xref:Microsoft.Xrm.Sdk.ITracingService.Trace(System.String,System.Object[])> calls to your custom code where appropriate passing any relevant diagnostic information in that method call.  

 Download the sample: [Work with plug-ins](https://code.msdn.microsoft.com/Sample-Create-a-basic-plug-64d86ade).
  
 [!code-csharp[Plug-ins#AdvancedPlugin2](../snippets/csharp/CRMV8/plug-ins/cs/advancedplugin2.cs#advancedplugin2)]  
  
 Next, build and deploy the plug-in or custom workflow activity. During execution of the custom code, the information provided in the **Trace** method calls is written to a trace log entity record by <xref:Microsoft.Xrm.Sdk.ITracingService>, if supported by your organization and enabled, and may also be made available to the user in a Web dialog or system job as described in the previous section. Tracing information written to the trace log is configured in the trace settings. For more information see [Enable the trace logging feature](debug-plugin.md#bkmk_trace-settings).  
  
> [!NOTE]
>  If your custom code executes within a database transaction, and an exception occurs that causes a transaction rollback, all entity data changes by your code will be undone. However, the **PluginTraceLog** records will remain after the rollback completes.  
  
### About the tracing service  
 The <xref:Microsoft.Xrm.Sdk.ITracingService> batches the information provided to it through the **Trace** method. The information is written to a new **PluginTraceLog** record after the custom code successfully runs to completion or an exception is thrown.  
  
 PluginTraceLog records have a finite lifetime. A bulk deletion background job runs once per day to delete records that are older than 24 hours from creation. This job can be disabled when needed.  

 ## Community tools

 ### Plugin trace viewer

**Plugin Trace Viewer** is a tool that XrmToolbox community developed for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement. Please see the [Developer tools](developer-tools.md) topic for community developed tools.

 > [!NOTE]
> The community tools are not a product of [!include[pn_microsoft_dynamics](../includes/pn-microsoft-dynamics.md)] and does not extend support to the community tools. 
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com). 
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Analyze Plug-in Performance](analyze-plugin-performance.md)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)   
 [Event Execution Pipeline](event-execution-pipeline.md)   
 [Write a Plug-in](write-plugin.md)   
 [Plug-in Isolation, Trust, and the Disallowed List](plugin-isolation-trusts-statistics.md)   
 [PluginTraceLog Entity](entities/plugintracelog.md)