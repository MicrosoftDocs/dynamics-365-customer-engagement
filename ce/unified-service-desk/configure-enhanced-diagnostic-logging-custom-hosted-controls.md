---
title: "Configure enhanced diagnostic logging for custom hosted controls | MicrosoftDocs"
description: "Learn about configuring diagnostic logging to record operational events and errors in the client application to a log file, which can be later used to identify and troubleshoot performance issues or errors."
ms.custom:
  - dyn365-USD
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: db1034db-8354-40c8-a8a8-44289d93edf3
caps.latest.revision: 10
author: kabala123
ms.author: kabala
manager: sakudes
---
# Configure enhanced diagnostic logging for custom hosted controls
[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] enables you to configure diagnostic logging to record operational events and errors in the client application to a log file, which can be later used to identify and troubleshoot performance issues or errors. For more information about diagnostic logging, see [Configure client diagnostic logging in Unified Service Desk](admin/configure-client-diagnostic-logging-unified-service-desk.md).  
  
Diagnostic logging for predefined hosted control types has been enhanced to provide rich information about an exception or error, such as the source where the error occurred (hosted control name, hosted control type, session ID) and detailed information about the error along with the stack trace. The rich diagnostic information greatly improves in quickly identifying and troubleshooting issues in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
You can leverage the same enhanced diagnostic logging capabilities available in the predefined hosted controls for your custom controls by using the [LogException](https://docs.microsoft.com/dotnet/api/Microsoft.Crm.UnifiedServiceDesk.Dynamics.DynamicsBaseHostedControl.LogException) method in your custom control code to provide rich information about the exception (if it occurs) so that its easier to identify if the issue is caused by your custom code or some other control in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
[LogException](https://docs.microsoft.com/dotnet/api/Microsoft.Crm.UnifiedServiceDesk.Dynamics.DynamicsBaseHostedControl.LogException) method is overloaded, and internally uses [DynamicsLogger](https://docs.microsoft.com/dotnet/api/Microsoft.Crm.UnifiedServiceDesk.Dynamics.DynamicsLogger) to provide rich diagnostic information for exceptions in your custom control. Use one of the following two signatures to use this method:  
  
-   Pass in the exception object and the event type that caused the trace (optional). If you do not specify the event type, by default `Error` trace event type is passed:  
  
    ```csharp  
    LogException(Exception ex, TraceEventType eventType = TraceEventType.Error);  
    ```  
  
-   Pass in the string value for custom error message, event type that caused the trace, and the exception object:  
  
    ```csharp  
    LogException(string errorMessage, TraceEventType eventType, Exception ex);  
    ```  
  
 Here is an example of the diagnostic information as a result of using [LogException](https://docs.microsoft.com/dotnet/api/Microsoft.Crm.UnifiedServiceDesk.Dynamics.DynamicsBaseHostedControl.LogException) method where detailed information about the source (session ID, hosted control name and type) and the exception detail is logged:  
  
```  
Exception raised in :  Session ID : d14893b0-6859-4827-9ddc-949d3fd36854 - Application : DemoControl - USD Component Type : USDHostedControl - Hosting Type : USD Hosted Control - Display Group : MainPanel -   
Exception details:   
Source: DemoControl  
Target: Void ThrowAndLogException_Click(System.Object, System.Windows.RoutedEventArgs)  
Exception: SampleLogException  
StackTrace:   at DemoControl.USDControl.ThrowAndLogException_Click(Object sender, RoutedEventArgs e  
```  
  
### See also  
 [Configure client diagnostic logging in Unified Service Desk](admin/configure-client-diagnostic-logging-unified-service-desk.md)   
 [Unified Service Desk Hosted Controls](../unified-service-desk/unified-service-desk-hosted-controls.md)   
 [Create custom Unified Service Desk hosted control](../unified-service-desk/walkthrough-create-custom-hosted-control-for-unified-service-desk.md)
