---
title: "Use SafeDispatcher for custom hosted controls in Unified Service Desk | MicrosoftDocs"
description: "Learn how to use SafeDispatcher to provide out-of-box logging for unhandled exceptions with detailed information about the source and cause of the exception in Unified Service Desk."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Use SafeDispatcher for custom hosted controls in Unified Service Desk
[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is a [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)]-based application where all the operations in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] are executed on the main *WPF Dispatcher* thread. The [WPF Dispatcher](https://msdn.microsoft.com/library/system.windows.threading.dispatcher\(v=vs.110\).aspx) class provides services for managing the queue of work items for a thread.

 You can extend [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] by creating custom controls and hosting it within [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. However, if a custom hosted control contains faulty code or executes operations using new threads without appropriately handling exceptions during code execution, it may cause stability issues in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], and might even cause the  client application to freeze or become unresponsive. The unhandled exceptions in third-party custom controls  makes it challenging to identify, troubleshoot, and resolve the issue by the product/support team as they might not have access to the information why an error/exception occurred in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], and the exact code that caused the error.

 Introducing *SafeDispatcher* that provides a powerful and informative exception handling mechanism for custom hosted controls in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] by providing out-of-box logging for unhandled exceptions with detailed information about the source and cause of the exception, and allowing you to configure or  overwrite the SafeDispatcher exception handling to perform some other steps. This also prevents the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client from becoming unresponsive because of unhandled exceptions in the custom hosted control code.

<a name="What"></a>
## What is SafeDispatcher?
 [SafeDispatcher](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.utilities.safedispatcher) is built on the same lines as the [WPF Dispatcher](https://msdn.microsoft.com/library/system.windows.threading.dispatcher\(v=vs.110\).aspx), and provides resilient and informative exception handling for  custom hosted controls within [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. It is exposed as a protected property, [SafeDispatcher](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol.safedispatcher), on the [DynamicsBaseHostedControl](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol) class, which makes SafeDispatcher automatically available for all [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] custom hosted controls that are derived from the [DynamicsBaseHostedControl](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol) class.

> [!NOTE]
>  Do not use the [SafeDispatcher](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.utilities.safedispatcher) class  in your code to work with SafeDispatcher. Instead, you must use the [SafeDispatcher](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol.safedispatcher) property on your custom hosted control instance that is derived from the  [DynamicsBaseHostedControl](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol) class to use SafeDispatcher.

 Just like [WPF Dispatcher](https://msdn.microsoft.com/library/system.windows.threading.dispatcher\(v=vs.110\).aspx), SafeDispatcher provides methods such as [BeginInvoke](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.utilities.safedispatcher.begininvoke), [Invoke](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.utilities.safedispatcher.invoke), and [InvokeAsync](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.utilities.safedispatcher.invokeasync) to run operations synchronously or asynchronously on SafeDispatcher with an additional boolean parameter, `runOnMainUiThread`, that controls whether to run SafeDispatcher on UI thread or not.

 SafeDispatcher provides the following benefits:

- **Protected UI Dispatcher thread**: Developers can run all UI-dependent operations on SafeDispatcher by setting the `runOnMainUiThread` parameter  to "true" in the invoke method to run the SafeDispatcher on UI thread. Any unhandled exception raised on main UI dispatcher will be handled safely at the hosted control level instead of bubbling up to the global [DispatcherUnhandledException Event](https://msdn.microsoft.com/library/system.windows.application.dispatcherunhandledexception\(v=vs.110\).aspx) handler.

- **Protected non-UI Dispatcher thread**: Developers can run all UI-independent code on SafeDispatcher. by setting the `runOnMainUiThread` parameter to "false" in the invoke method to run the SafeDispatcher on non-UI thread. Any unhandled exception raised on main non-UI dispatcher will be handled safely at the hosted control level instead of  bubbling up to the global [DispatcherUnhandledException Event](https://msdn.microsoft.com/library/system.windows.application.dispatcherunhandledexception\(v=vs.110\).aspx) handler.

- **Detailed information about exception source and cause:**: The SafeDispatcher exception handler is raised when an unhandled exception is raised at the [DynamicsBaseHostedControl](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol) level by the UI or non-UI thread, which allows [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to capture critical information at the hosted control level such as hosted control name, hosted control type, method name, and complete stack trace to identify the exact location and cause of the exception.

- **Configure or override SafeDispatcher exception handler**: Developers can leverage the out-of-box behavior of the SafeDispatcher exception handler to prompt the user with information about the unhandled exception or override the behavior as per their business requirement such as configure additional logging, close session based controls, or  exit the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client.

<a name="How"></a>
## How to use SafeDispatcher?
 The [SafeDispatcher](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol.safedispatcher) property is available for all [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] custom hosted control instances that are derived from the [DynamicsBaseHostedControl](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol) class. A [SafeDispatcher](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.utilities.safedispatcher) instance will be available to run on UI thread when the custom hosted control is initialized. However, a SafeDispatcher instance will only be available to run on  non-UI thread when you execute the invoke method for the first time.

-   Synchronously invoke a UI-specific function using the SafeDispatcher

    ```csharp
    SafeDispatcher.Invoke(() =>
                {
                    ProcessData();
                }, DispatcherPriority.Normal, CancellationToken.None, true);
    ```

     OR

    ```csharp
    SafeDispatcher.Invoke(() =>
                {
                    ProcessData();
                }, DispatcherPriority.Normal, CancellationToken.None);
    ```

    > [!NOTE]
    >  For UI-specific function, you should set the `runOnMainUiThread` optional parameter to "true". If you do not specify a value for this parameter, by default "true" is passed. So, any of the above method definition works fine.

-   Asynchronously invoke a UI-specific function using SafeDispatcher. You can use either the `BeginInvoke` or `InvokeAsync` method.

    ```csharp
    SafeDispatcher.BeginInvoke(new Action(() =>
                {
                   ProcessData();
                }));

    ```

     OR

    ```csharp
    SafeDispatcher.InvokeAsync(new Action(() =>
                {
                   ProcessData();
                }));

    ```

## Customize the SafeDispatcher exception handler
 With the introduction of SafeDispatcher, all unhandled exceptions in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] will raise the [SafeDispatcherUnhandledException Event](https://msdn.microsoft.com/5c67a00b-f949-4f83-9b14-f7ee396dd657) instead of the  global [DispatcherUnhandledException Event](https://msdn.microsoft.com/library/system.windows.application.dispatcherunhandledexception\(v=vs.110\).aspx). The [SafeDispatcherUnhandledExceptionHandler Method](https://msdn.microsoft.com/a394320e-4f98-4ee0-85e0-b61c49fd9a6b) provides an out-of-box exception handler for SafeDispatcher to display information to the Unified Service Desk user with the following details: source control where the exception occurred and detailed info about the exception.

 You can also override the out-of-box exception handling for SafeDispatcher to perform other operation such as prompt the user to close a session-based non-dynamic hosted control.

 The following sample code demonstrates how you can override the out-of-box SafeDispatcher exception handler to display a message box to prompt the user to close the custom hosted control when an exception occurs:

```csharp
protected override void SafeDispatcherUnhandledExceptionHandler(object sender, SafeDispatcherUnhandledExceptionEventArgs ex)
{
    string error = String.Format(CultureInfo.InvariantCulture,
        "Error in hosted control  Application:{0} - Exception : {1} \r\nInnerException\r\n {2}", this.ApplicationName, ex.Exception, ex.InnerException);
    DynamicsLogger.Logger.Log(error, TraceEventType.Error);
    if (MessageBox.Show("Exception occurred in hosted control - " + this.ApplicationName + ".Do you wish to close it ?", "Question", MessageBoxButton.YesNo,
        MessageBoxImage.Warning) == MessageBoxResult.Yes)
    {
        SafeDispatcher.BeginInvoke(() => { this.desktopAccess.CloseDynamicApplication(this.ApplicationName); });
    }
}
```

<a name="Migrating"></a>
## Migrating from WPF Dispatcher to SafeDispatcher in existing custom hosted controls
 As the contract between WPF Dispatcher and SafeDispatcher is almost identical, the effort to move from WPF Dispatcher to SafeDispatcher is minimal. To migrate any hosted control instance derived from the [DynamicsBaseHostedControl](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol) class, replace all "Dispatcher" instances with "SafeDispatcher".

 For example, consider the following code:

```csharp
Dispatcher.Invoke((System.Action)delegate()
{
    DynamicsLogger.Logger.Log("Raising SetupHotKey's", TraceEventType.Verbose);
    SetupHotkeys();
    CRMGlobalManager.AppWithFocusChanged += CRMGlobalManager_AppWithFocusChanged;
    FireEvent("DesktopReady");
    InitializeFocusSelection();
});
```

 Replace `Dispatcher` in the above code with `SafeDispatcher`; rest of the code remains the same:

```csharp
SafeDispatcher.Invoke((System.Action)delegate()
{
    DynamicsLogger.Logger.Log("Raising SetupHotKey's", TraceEventType.Verbose);
    SetupHotkeys();
    CRMGlobalManager.AppWithFocusChanged += CRMGlobalManager_AppWithFocusChanged;
    FireEvent("DesktopReady");
    InitializeFocusSelection();
});
```

<a name="Considerations"></a>
## Things to consider when using SafeDispatcher
 SafeDispatcher offers a multithreaded model that is highly beneficial in dispatching functions synchronously or asynchronously to UI or non-UI threads.  Operations that need to be run on threads that are available with fault tolerance should be executed on SafeDispatcher. However multi-threading should be implemented very carefully to avoid deadlock between threads. One such example is dispatching from non-UI thread to main WPF Dispatcher synchronously. Lets consider this example:

```csharp
Thread thread = new Thread(() =>
{
    Dispatcher.Invoke(ProcessData);
});
thread.SetApartmentState(ApartmentState.STA);
thread.Priority = ThreadPriority.Highest;
thread.IsBackground = true;
thread.Start();
thread.Join();
```

 The `thread.Join()` method is causing the main thread to get blocked waiting for the termination of single-threaded apartment (STA) thread, but the STA thread is waiting for the  main thread to finish the execution of `ProcessData`. This causes your app in a deadlock situation.

 Similarly, consider the following example:

```csharp
// Invoke on STA thread
SafeDispatcher.Invoke(() =>
{
    // Invoke back on main dispatcher
    SafeDispatcher.Invoke(() =>
    {
        ProcessData();
    });
}, false);
```

 The [SafeDispatcherUnhandledExceptionHandler](https://docs.microsoft.com/dotnet/api/Microsoft.Crm.UnifiedServiceDesk.Dynamics.DynamicsBaseHostedControl.SafeDispatcherUnhandledExceptionHandler) method will be called if an exception happens on the WPF Dispatcher or on the STA non-UI thread and will be raised on the respective thread on which the exception happened. You should be careful in making sure you don’t place the above combination in this handler, that is, if the exception occurred on non-UI thread, do not dispatch synchronously to the main UI dispatcher.

```csharp
protected override void SafeDispatcherUnhandledExceptionHandler(object sender, SafeDispatcherUnhandledExceptionEventArgs ex)
{
    Dispatcher.Invoke(LogException);            // Incorrect
    SafeDispatcher.Invoke(LogException);        // Incorrect
    SafeDispatcher.BeginInvoke(LogException);   // Correct
    SafeDispatcher.InvokeAsync(LogException);   // Correct
}
```

### See also
 [Create custom Unified Service Desk hosted control](../unified-service-desk/walkthrough-create-custom-hosted-control-for-unified-service-desk.md)
 [Extend Unified Service Desk](../unified-service-desk/extend-unified-service-desk.md)
 [Configure client diagnostic logging in Unified Service Desk](admin/configure-client-diagnostic-logging-unified-service-desk.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]