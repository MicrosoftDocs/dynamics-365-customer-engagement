---
title: "Types of HAT automation activities in Unified Service Desk | MicrosoftDocs"
description: "Learn about various automation activities that you can use to automate your hosted applications in Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
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
# Types of HAT automation activities in Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

There are various types of [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)] automation activities that you can use to automate your hosted applications. To view and use the [!INCLUDE[pn_hat](../includes/pn-hat.md)] automation activities, see [Use HAT automation activities](../unified-service-desk/use-hat-automation-activities.md).  
  
<a name="AIF"></a>   
## Application Integration Framework (AIF) action activities  
 Action activities provide functionality to access and manage [UII actions](../unified-service-desk/uii-actions.md). Here are the various action activities available.  
  
 `DoAction`  
 Executes an action either in the same application or in another hosted application. This action has the following properties:  
  
- `ApplicationName`: The application on which to execute the `DoAction`. Mandatory.  
  
- `ActionData`: Data required for performing the action. Optional.  
  
- **ActionName** Name of the action that is registered with the hosted application specified in the `ApplicationName` property. Mandatory.  
  
  `GetActionData`  
  Retrieves the data from the action that invoked the workflow or automation. The value will be returned in the `ActionData` property.  
  
  `SetActionData`  
  Adds data to the current action.  
  
  Specify the data that is required for the action in the `ActionData` parameter.  
  
  `RegisterActionForEvent`  
  Registers an action to be initiated every time an event occurs. This action has the following properties:  
  
- `ActionApplication`: Name of the application with which the UII action is registered. Mandatory.  
  
- `ActionName`: Name of the action for the application that will be executed when the event is initiated. Mandatory.  
  
- `ApplicationName`: Name of the application that initiates the event. Mandatory.  
  
- `ControlName`: Name of the control that initiates the event. Optional.  
  
- `EventName`: Name of the event initiated by the application/control.  
  
  `UnRegisterActionForEvent`  
  Unregisters an action that was previously registered using the `RegisterActionForEvent` activity. The unregistered event won’t be executed anymore. This action has the following properties:  
  
- `ActionApplicationName`: Name of the application with which the UII action is registered.  
  
- `ActionName`: Name of the action for the application that would have executed when the event was initiated.  
  
- `ApplicationName`: Name of the application that initiates the event.  
  
- `ControlName`: Name of the control that initiates the event.  
  
- `EventName`: Name of the event initiated by the application or control.  
  
  `CloseDynamicApp`  
  Closes a dynamic hosted application from within the automation. You can use this action to programmatically close a dynamic hosted application in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
  Specify the name of the dynamic hosted application in the `ApplicationName` parameter that you want to close.  
  
  For more information about dynamic hosted applications, see [Dynamic UII hosted applications](../unified-service-desk/uii-hosted-applications.md#Dynamic).  
  
  `StartDynamicApp`  
  Starts a dynamic hosted application from within the automation.  
  
  Specify the name of the dynamic hosted application in the `ApplicationName` parameter that you want to start.  
  
  `FocusApp`  
  Sets focus on an application from within the automation.  
  
  Specify the name of the hosted application in the `ApplicationName` parameter that you want to set focus on.  
  
<a name="AIFContext"></a>   
## AIF context activities  
 Context activities allow accessing the AIF context from the automation. Here are the various context activities available.  
  
 `GetContext`  
 Retrieves a value for the specified key from the context. The value is returned in the `ContextValue` property.  
  
 Specify the key of the context to be retrieved in the `ContextKey` property.  
  
 `SetContext`  
 Sets the value for the specified key in the context. This action has the following properties:  
  
- `ContextKey`: Key of the context to be set.  
  
- `ContextData`: Optionally, enter the data to be set to the context specified in `ContextKey`.  
  
  `GetCredential`  
  Retrieves user credentials from the context for the specified application. This action has the following properties:  
  
- `ApplicationName`: Name of the application.  
  
- `UserName`: User name.  
  
- `Password`:  Password.  
  
> [!NOTE]
>  To retrieve the credentials from a custom store, the developer needs to provide a class that implements the [Microsoft.Uii.AifServices.ISsoLookupService](https://docs.microsoft.com/dotnet/api/Microsoft.Uii.AifServices.ISsoLookupService) interface.  
  
 `HostApplication`  
 Hosts the UI of the application. It uses the **Application Hosting** configuration data specified while configuring the hosted control in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] on Microsoft Dataverse server to determine the hosting mode. For more information about specifying the hosting mode for an application in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], see [Create and manage UII hosted applications](../unified-service-desk/create-manage-uii-hosted-applications.md).  
  
<a name="DDA"></a>   
## DDA activities  
 Data-driven adapter (DDA) activities provide access to controls specified in the bindings. Here are the various DDA activities.  
  
 `Audit`  
 Creates audit entries from within the automation. This action has the following properties:  
  
- `Audit Flag`: Name of the audit flag.  
  
- `Log data`: Value of the audit flag value.  
  
  For information about various audit flags in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], see [Configure auditing and diagnostics in Unified Service Desk](../unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk.md).  
  
  `ControlFinder`  
  Locates a control in the hosted application. The action returns `True` if the control is found in the `ControlFound` property; otherwise, returns `False`. You can set the `ExceptionsMask` property if you want to use the exception handler to execute depending activities. This action has the following properties:  
  
- `ApplicationName`: Name of the application that hosts the control. Mandatory.  
  
- `ControlName`: Name of the control in the application.  
  
- `ExceptionsMask`: Indicates whether you want to show an exception if the control isn’t found. The default setting is `False`.  
  
> [!NOTE]
>  If a workflow that you configured is blocking the UI thread and you have specified SleepInterval and Timeout parameters for the `ControlFinder` activity, the action should be configured to run asynchronously.  
  
 `ExecuteControlAction`  
 Executes the default action of a control. For example, if the control is a button, the default action is click. This action has the following properties:  
  
- `ApplicationName`: Name of the application that hosts the control.  
  
- `ControlName`: Name of the control in the application.  
  
  `GetControlValue`  
  Retrieves a value from a control in the application. The value is returned in the `ControlValue` property. This action has the following properties:  
  
- `ApplicationName`: Name of the application that hosts the control.  
  
- `ControlName`: Name of the control in the application whose value has to be retrieved.  
  
> [!NOTE]
>  When using the `GetControlValue` activity with a multi-line text control, all new line characters will be ignored and a single string is returned.  
  
 `SetControlValue`  
 Sets the value of a control in the application. This action has the following properties:  
  
-   `ApplicationName`: Name of the application that hosts the control.  
  
-   `ControlName`: Name of the control in the application whose value has to be set.  
  
-   `ControlValue`: Enter the value to be set.  
  
> [!NOTE]
>  When using the `SetControlValue` activity with a multi-line text control, all new line characters will be ignored and a single string is returned.  
  
 `Navigate`  
 Specifies a URL that a web application navigates to. For example, you can use the `Navigate` activity to force a web application to navigate to a specific URL when a user performs a task. This action has the following properties:  
  
-   `ApplicationName`: Name of the application that hosts the control.  
  
-   `URL`: Specify the URL along with the query string.  
  
> [!NOTE]
> - The `Navigate` activity shouldn’t be called concurrently on the web browser. If it is, you’ll receive the following errors:  
> 
>   ```Output  
>   AutomationAdapter (app=Contact,action=__SetControlValue__): Posted implicit action exception:  Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter.DataDrivenAdapterException: DDA0301: Web browser is busy and cannot be stopped.   
> 
>   WF/Automation <GUID> exception: Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter.DataDrivenAdapterException: DDA0301: Web browser is busy and cannot be stopped.  
>   ```  
>   - For the `Navigate` activity to work on the target application, you must configure the hosted application in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to use **Automation Adapter (HAT)**, and provide the following binding in the Automation XML field:  
> 
>   ```  
>   <DataDrivenAdapterBindingsCollection>  
>     <DataDrivenAdapterBindings>  
>        <Type>Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter.WebDataDrivenAdapter, Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter</Type>  
>        <Controls/>  
>     </DataDrivenAdapterBindings>  
>   </DataDrivenAdapterBindingsCollection>  
>   ```  
> 
>   For more information about configuring hosted controls in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], see [Create and manage UII hosted applications](../unified-service-desk/create-manage-uii-hosted-applications.md).  
  
 `ConfigReader`  
 Reads a configuration value from within the automation. This activity will either read configuration from the **Option** settings in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] or the application configuration file. This action has the following properties:  
  
- `OptionKey` as string: Used to read the **Option** setting from [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. For more information about various options, see [Manage Options for Unified Service Desk](../unified-service-desk/admin/manage-options-unified-service-desk.md).  
  
- `XPath` as string: Used to read the application configuration file.  
  
- `QueryResult` as string: Result of the search.  
  
  `InitstringReader`  
  Enables you to read the `InitString` content from within the automation. This action has the following properties:  
  
- `XPath` as string: Used to read the application configuration file.  
  
- `QueryResult` as string: Result of the search.  
  
### See also  
 [Create a HAT automation](../unified-service-desk/create-hat-automation.md)   
 [UII Application Integration Framework](../unified-service-desk/uii-application-integration-framework.md)   
 [Use Data Driven Adapters](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]