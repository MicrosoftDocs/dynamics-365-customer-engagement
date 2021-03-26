---
title: "Configure client diagnostic logging in Unified Service Desk  | MicrosoftDocs"
description: "Learn how to set client diagnostic logging."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 12/31/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
tags: MigrationHO
---

# Client diagnostic logging overview

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

There are two ways you can configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client diagnostic logging:  

- By using an Audit & Diagnostics Settings record that is created and managed in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] area of Microsoft Dataverse.  

- By manually making changes to the UnifiedServiceDesk.exe.config file. This file must then be distributed to every desktop where you want [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client diagnostic logging.  

  Additionally, you can configure diagnostic logging specifically for exceptions that may occur in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  

<a name="ConfigureLogging"></a>   
## Configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client diagnostic logging  
 This section describes how to manually configure diagnostic logging in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. Rather than use the procedure described here, we recommend you use the Audit & Diagnostics Settings feature that provides centralized administration of diagnostics and the ability to connect a custom listener. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure auditing and diagnostics in Unified Service Desk](../../unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk.md)  

> [!IMPORTANT]
> - The manually configured diagnostics (as described here) will no longer work after you enable an Audit & Diagnostics Settings record that is configured for diagnostics.  
> - [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] also provides an API that lets you configure rich diagnostic logging for custom hosted controls. More information:  [Configure enhanced diagnostic logging for custom hosted controls](../../unified-service-desk/configure-enhanced-diagnostic-logging-custom-hosted-controls.md)  

 This topic describes how to change client logging characteristics.  

 You can enable logging with the **UnifiedServiceDesk.exe.config** file, which is available in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client installation directory on your computer. To configure the type of logging and location of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] log file:  

1. Open the **UnifiedServiceDesk.exe.config** file for editing. If you installed the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client at the default location, this file will typically be available at C:\Program Files\Microsoft Dynamics 365 Customer Engagement USD\USD.  

2. Go to the `<switches>` section in the file:  

   ```xml  
   <switches>  
   <!--   
        Possible values for switches: Off, Error, Warning, Information, Verbose  
           Verbose:      includes Error, Warning, Info, Trace levels  
           Information:  includes Error, Warning, Info levels  
           Warning:      includes Error, Warning levels  
           Error:        includes Error level  
    -->  
       <add name="EventTopicSwitch" value="Error"/>  
       <add name="Microsoft.Uii.Common.Logging" value="Error"/>  
       <add name="Microsoft.Xrm.Tooling.CrmConnectControl" value="Error"/>  
       <add name="Microsoft.Xrm.Tooling.Connector.CrmServiceClient" value="Error"/>  
       <add name="Microsoft.Xrm.Tooling.WebResourceUtility" value="Error"/>  
       <add name="Microsoft.Crm.UnifiedServiceDesk" value="Error"/>  
       <add name="Microsoft.Crm.UnifiedServiceDesk.Dynamics" value="Error"/>  
       <add name="Microsoft.Crm.UnifiedServiceDesk.CommonUtility.UserProfileManager" value="Error"/>  
       <add name="UnifiedServiceDesk.KPIControl" value="Error"/>  
   </switches>  

   ```  

3. In the `<switches>` section, specify a logging source (such as `EventTopicSwitch`), and then specify a logging level value (such as `Error`). The `<switches>` section controls logging levels for various sources. By default, error logging is enabled for all the switches:  

   -   For information about the available logging sources, see [Available Log Sources](configure-client-diagnostic-logging-unified-service-desk.md#LogSources) later in this topic.  

   -   For information about the values you can specify for each logging source, see [Logging Levels](configure-client-diagnostic-logging-unified-service-desk.md#LoggingLevels) later in this topic.  

4. To configure the location, maximum file size, and rollover behavior of the log files, go to the `<shareListeners>` section in the file.  

   ```xml  
   <sharedListeners>  
      <add name="fileListener"  
         type="Microsoft.Xrm.Tooling.Connector.DynamicsFileLogTraceListener, Microsoft.Xrm.Tooling.Connector"  
       BaseFileName="UnifiedServiceDesk"  
       Location="LocalUserApplicationDirectory" MaxFileSize ="52428800" MaxFileCount="10"/>  
      <add name="USDDebugListener" type="Microsoft.Crm.UnifiedServiceDesk.Dynamics.UsdTraceListener, Microsoft.Crm.UnifiedServiceDesk.Dynamics" />  
      <add name="ADALListener"  
       type="Microsoft.Xrm.Tooling.Connector.DynamicsFileLogTraceListener, Microsoft.Xrm.Tooling.Connector"  
       BaseFileName="ADAL"  
        Location="LocalUserApplicationDirectory" MaxFileSize ="52428800" MaxFileCount="10"/>  
   </sharedListeners>  
   ```  

    The `<sharelisteners>` section controls the location and type of logs that are generated for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. By default, `fileListener` will create a file called **UnifiedServiceDesk.log** in `c:\Users\<UserName>\AppData\Roaming\Microsoft\Microsoft\Microsoft Dynamics 365 Unified Service Desk\<Version>` directory, and `USDDebugListener` will create events in the [Debug output tab](../../unified-service-desk/use-debugger-control-unified-service-desk.md) of the Debugger hosted control.  

5. If you want to change the location of the **UnifiedServiceDesk.log** file, change the value of the `Location` parameter.  

6. By default, a new [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] log is created after the file size of the current log file exceeds 52.42 MB. By default, up to 10 log files are maintained at one time before the oldest log file is deleted.  

   - To change the maximum [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] log file size, change the value, in bytes, of the **MaxFileSize** parameter.  

   - To change the number of logs maintained before the oldest  log is deleted, change the value of the **MaxFileCount** parameter. If zero (0) is used rollover logging will be disabled and all [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client logs created will be saved.  

7. By default, file and debugger logging is enabled for all sources. If you want to add or remove a listener from a diagnostic source, locate the required source in the `<sources>` section, and then modify the `<listeners>` section of the source to include the listener you want.  

    For example, to add event logging for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], add the event logging listener to the `Microsoft.Crm.UnifiedServiceDesk` source.  

   ```xml  
   <source name="Microsoft.Crm.UnifiedServiceDesk" switchName="Microsoft.Crm.UnifiedServiceDesk" switchType="System.Diagnostics.SourceSwitch">  
       <listeners>  
           <add name="fileListener"/>  
           <add name="USDDebugListener" />  
           <add name="eventLogListener" type="System.Diagnostics.EventLogTraceListener" initializeData="USD"/>  
       </listeners>  
   </source>  
   ```  

    This will now report events to the [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)] event log with the tag “USD”, in addition to the file and Debugger. For more information about diagnostic listeners, see [Diagnostic Log Listeners](configure-client-diagnostic-logging-unified-service-desk.md#LogListeners) later in this topic.  

<a name="LogSources"></a>   
## Diagnostic log sources  
 Common troubleshooting log sources are listed in the following table.  


|                            Source Name                            |                                                                                                                                                        Description                                                                                                                                                        |
|-------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                         EventTopicSwitch                          |                                                                          Detailed [!INCLUDE[pn_user_inteface_integration_uii](../../includes/pn-user-interface-integration-uii.md)] logging source for monitoring messaging traffic inside UII.                                                                           |
|                   Microsoft.Uii.Common.Logging                    |                                                                                                                                   General UII Log source for messages reported by UII.                                                                                                                                    |
|              Microsoft.Xrm.Tooling.CrmConnectControl              |                                                          Log source for the sign-in process. This source will report general or detailed diagnostics information about the sign-in procedure.                                                           |
|         Microsoft.Xrm.Tooling.Connector.CrmServiceClient          |                                     Log source for all Dataverse data-level interactions. This source will report all interactions with Dataverse, exceptions and timings.                                      |
|             Microsoft.Xrm.Tooling.WebResourceUtility              |                                                                                           Log source for requests for Web Resource data via Dataverse interface link.                                                                                            |
|                 Microsoft.Crm.UnifiedServiceDesk                  |                            Log source for core [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] functionality.  This log source will report actions and events that are core to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].                             |
|             Microsoft.Crm.UnifiedServiceDesk.Dynamics             |     Log source for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] boot strap and loading processor. This source will report actions and events that are part of initializing and starting the UII and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].     |
| Microsoft.Crm.UnifiedServiceDesk.CommonUtility.UserProfileManager | Log source for actions that interact with the UserProfile system; this is part of the caching system. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure client caching for your agent application](../../unified-service-desk/admin/configure-client-caching-unified-service-desk.md) |

 You can toggle each of these log sources independently to support troubleshooting and isolation of issues or information inside [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].  

<a name="LoggingLevels"></a>   
## Diagnostic logging levels  
 There are several distinct logging levels available for use. However, as you increase the level of logging, more data is generated and stored in the log files.  

|Log Level|Description|  
|---------------|-----------------|  
|Off|Disables all events from this source.|  
|Error|Reports only error events.|  
|Warning|Reports errors and warning events.|  
|Information|Reports errors, warnings, and information events.|  
|Verbose|Reports errors, warnings, information, and verbose events.|  
|ActivityTracing|Reports errors, warnings, information, and verbose events, and activity tracing (method names). **Note:**  ActivityTracing is available only on some of the sources.|  
|All|Reports all events raised by the system.|  

<a name="LogListeners"></a>   
## Diagnostic log listeners  
 Diagnostics log listeners are used to target the diagnostic log output to files, the event log, or other sources. By default, all diagnostic sources are wired to both the default (Debugger) and file (text) listeners. You can configure additional log listeners for diagnostic logging for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. For more information about the .NET default listeners, see:  

- [MSDN:DefaultTraceListener](/dotnet/api/system.diagnostics.defaulttracelistener)  

- [MSDN:EventLogTraceListener](/dotnet/api/system.diagnostics.eventlogtracelistener)  

- [MSDN:TextWriterTraceListener](/dotnet/api/system.diagnostics.textwritertracelistener)  

  You can also create custom listeners to send diagnostic logs to a location you pick. Custom listeners are created by deriving a class from the [MSDN:TraceListener](/dotnet/api/system.diagnostics.tracelistener) abstract class. You can find a walkthrough of the process on [CodeGuru.com](https://www.codeguru.com/csharp/.net/article.php/c19405/Tracing-in-NET-and-Implementing-Your-Own-Trace-Listeners.htm).  

<a name="View_diagnostic_log"></a>   
## Viewing the diagnostic log file  
 By default, diagnostics logging is enabled for the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application. A log file, **UnifiedServiceDesk-\<date>.log**, is available at `c:\Users\<UserName>\\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\<Version>` on the client computer to record operational errors in the client application. The log file is created the first time you encounter any errors in the client application.  

 When an error occurs in a hosted control, the  information logged in the log files provide detailed information about the exception such as the originating hosted control that caused the exception along with the exception details. Notice that the entire JavaScript code that caused the exception isn't logged. Only the faulty code along with exception description are logged.  

 Here is a sample exception detail that is logged.  

```Output  
Microsoft.Crm.UnifiedServiceDesk.Dynamics   Error   2   12/27/2016 11:54:15 AM  Origin:AppdomianUnhandledException, IsFatal:True  
Source: DemoControl  
Target: Void throwExceptionMethod()  
Exception: Exception in custom control  
StackTrace:   at DemoControl.USDControl.throwExceptionMethod()  
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)  
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)  
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)  
   at System.Threading.ThreadHelper.ThreadStart()  

```  

<a name="usdmp"></a>   
## Unified Service Desk Monitoring Process  
 The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Monitoring Process (usdmp.exe) is a service that continuously monitors the health of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], and terminates, by default after 5 seconds, any browser process instances that are unresponsive and causing [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to become unresponsive.  If a browser process instance isn’t responding, but [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is responsive, the browser process instance won’t be terminated. For more information about how to change the  duration of the ProcessTerminationThreshold global option for browser process termination, see [Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md).  

<a name="exceptionlogging"></a>   
## Error diagnostics reporting  
 Having detailed and comprehensive logging and reporting that occurs during a  component, application, or system fault can help identify when and how the fault occurred. In addition to standard diagnostics logging, error diagnostics reporting records system and application state information in the event of an exception in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. More information about exceptions can be found in [How Unified Service Desk handles application and system errors](../../unified-service-desk/admin/how-unified-service-desk-handles-application-system-errors.md ).  

### Folders and files created during an exception  
 In the event of an exception, error diagnostics reporting creates a folder on the local computer named DiagnosticsLogs_*date and time*, where date and time is in the form year-month-date_time, such as DiagnosticLogs_20170322_173643. Within the DiagnosticsLogs folder the following folder and files are created.  


|                     Diagnostics file                     |                                                                                                                                                                                                                                                                                                                                     Description                                                                                                                                                                                                                                                                                                                                     |
|----------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|           UnifiedServiceDesk_*dateandtime*.log           |                                                                                                                                Standard diagnostics log that is created and appended when [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is running. The file contains logging information for the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client (UnifiedServiceDesk.exe). The current files are moved into the DiagnosticsLogs folder in the event of an exception.                                                                                                                                 |
|         UnifiedServiceDeskMonitoring_*date*.log          | Standard diagnostics log that is created and appended when [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is running. Contains logging information for the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring process (usdmp.exe), which is a process that monitors the health of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.   The current files are moved into the DiagnosticsLogs folder in the event of an exception. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Service Desk Monitoring Process](#usdmp) |
|                    Eventlogs (folder)                    |                                                                                                                                                                                                                                                                  Folder created in the event of a fatal or non-fatal exception. Contains Windows system and application event logs and error reporting text files.                                                                                                                                                                                                                                                                  |
|                      ExitReport.txt                      |                                                                                                                                                                                                             Exit log created in the event of a fatal or non-fatal exception. Contains process state information such as machine name, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version, process id, exit code, and time of exit.                                                                                                                                                                                                              |
|                 MachineHealthReport.txt                  |                                                                                                                                                                                                                                          Exit log created in the event of a fatal or non-fatal exception. Contains system state information such as computer processor, operating system, monitor details, language, and browser version.                                                                                                                                                                                                                                           |
|                    ProcessReport.csv                     |                                                                                                                                                                                                                                                    Exit log created in the event of a fatal or non-fatal exception. Provides a comprehensive list of all processes that were running on the system at the time of the exception.                                                                                                                                                                                                                                                    |
|                     RegistryLog.txt                      |                                                                                                                                                                                                                                     Exit log created in the event of a fatal or non-fatal exception. Includes a text-based  copy of the Windows Registry subkeys for [!INCLUDE[pn_Internet_Explorer](../../includes/pn-internet-explorer.md)].                                                                                                                                                                                                                                      |
| UnifiedServiceDesk_processId_CrashDump_*dateandtime*.dmp |                                                                                                                                                     Created only in the event of an unhandled fatal exception or when invoked manually by using the ManualDumpShortcut global option keyboard combination. Provides a full memory  dump file for UnifiedServiceDesk.exe. Notice that, to view the dump file, you need [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] or other Windows dump file viewing tool.                                                                                                                                                     |

<a name="exceptionoptions"></a>   
### Configure error diagnostics reporting  

1. Sign in to Unified Service Desk Administrator. 

2. Select **Auditing and Diagnostics** under **Advanced Settings**.  

2. Select **+ New**, and then select **DiagnosticsConfiguration**.  

3. Select or enter the values that you want, such as tracking, exit monitoring, and the diagnostics logs folder location. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Diagnostics](../../unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk.md#create-an-audit--diagnostics-record-to-use-for-auditing)

4. Select **Save & Close**.  

## See also  
 [Configure auditing and diagnostics in Unified Service Desk](../../unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk.md)

 [Debugging support in Unified Service Desk to troubleshoot issues](../../unified-service-desk/admin/troubleshoot-unified-service-desk.md)   
 
 [Debug issues in Unified Service Desk](../../unified-service-desk/debug-issues-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]