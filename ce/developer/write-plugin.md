---
title: "Write a plug-in (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about plug-in design, writing a basic plug-in, writing a plug-in constructor, and web access for isolated plug-ins."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3ebc5b7c-313a-44c2-b6e0-b6740a0a24de
caps.latest.revision: 62
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Write a plug-in

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Plug-ins are custom classes that implement the <xref:Microsoft.Xrm.Sdk.IPlugin> interface. You can write a plug-in in any [!INCLUDE[pn_NET_Framework_452_short](../includes/pn-net-framework-452-short.md)] CLR-compliant language such as [!INCLUDE[pn_MS_Visual_C#](../includes/pn-ms-visual-csharp.md)] and [!INCLUDE[pn_Visual_Basic](../includes/pn-visual-basic.md)]. To be able to compile plug-in code, you must add Microsoft.Xrm.Sdk.dll and  Microsoft.Crm.Sdk.Proxy.dll assembly references to your project. Download these assemblies from [NuGet](https://www.nuget.org/profiles/crmsdk).
  
<a name="bkmk_design"></a>

## Plug-in design

 Your plug-in design should take into account the web application *auto-save* feature introduced in [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement. Auto-save is enabled by default but can be disabled at an organization level. When auto-save is enabled there is no **Save** button. The web application will save data in the form automatically 30 seconds after the last unsaved change. You can apply form scripts to disable the auto-save behaviors on a form level. Depending on how you registered your plug-in, auto-save may result in your plug-in being called more frequently for individual field changes instead of one plug-in invocation for all changes. You should assume that any user can save any record at any time, whether this is done using Ctrl+S, by pressing a save button, or automatically due to the auto-save feature.  
  
 It is a best practice to register your plug-in or workflow on entities and specific fields that matter most. Avoid registering a plug-in or workflow for changes to all entity fields. If you have an existing plug-or workflow that was implemented before the availability of the auto save feature, you should re-test that code to verify its proper operation. For more information see [Manage auto-save](../customize/manage-auto-save.md).  
  
<a name="bkmk_writingbasic"></a>
   
## Writing a Basic Plug-in

 The following sample shows some of the common code found in a plug-in. For this sample, the code omits any custom business logic that would perform the intended task of the plug-in. However, the code does show a plug-in class that implements the <xref:Microsoft.Xrm.Sdk.IPlugin> interface and the required <xref:Microsoft.Uii.Csr.Browser.Web.IServiceProvider> method.  
  
```csharp  
  
using System;  
using System.ServiceModel;  
using Microsoft.Xrm.Sdk;  
  
public class MyPlugin: IPlugin  
{  
    public void Execute(IServiceProvider serviceProvider)  
    {  
        // Extract the tracing service for use in debugging sandboxed plug-ins.  
        // If you are not registering the plug-in in the sandbox, then you do  
        // not have to add any tracing service related code.  
        ITracingService tracingService =  
            (ITracingService)serviceProvider.GetService(typeof(ITracingService));  
  
        // Obtain the execution context from the service provider.  
        IPluginExecutionContext context = (IPluginExecutionContext)  
            serviceProvider.GetService(typeof(IPluginExecutionContext));  
  
        // The InputParameters collection contains all the data passed in the message request.  
        if (context.InputParameters.Contains("Target") &&  
            context.InputParameters["Target"] is Entity)  
        {  
            // Obtain the target entity from the input parameters.  
            Entity entity = (Entity)context.InputParameters["Target"];  
  
            // Verify that the target entity represents an entity type you are expecting.   
            // For example, an account. If not, the plug-in was not registered correctly.  
            if (entity.LogicalName != "account")  
                return;  
  
            // Obtain the organization service reference which you will need for  
            // web service calls.  
            IOrganizationServiceFactory serviceFactory =   
                (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));  
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);  
  
            try  
            {  
                // Plug-in business logic goes here.  
            }  
  
            catch (FaultException<OrganizationServiceFault> ex)  
            {  
                throw new InvalidPluginExecutionException("An error occurred in MyPlug-in.", ex);  
            }  
  
            catch (Exception ex)  
            {  
                tracingService.Trace("MyPlugin: {0}", ex.ToString());  
                throw;  
            }  
        }  
    }  
}  
```  
  
 The [IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/microsoft.uii.csr.browser.web.iserviceprovider?view=dynamics-usd-3) parameter of the <xref:Microsoft.Xrm.Sdk.IPlugin.Execute(System.IServiceProvider)> method is a container for several service useful objects that can be accessed within a plug-in. The service provider contains instance references to the execution context, <xref:Microsoft.Xrm.Sdk.IOrganizationServiceFactory>, <xref:Microsoft.Xrm.Sdk.ITracingService>, and more. The sample code demonstrates how to obtain references to the execution context,<xref:Microsoft.Xrm.Sdk.IOrganizationService>, and <xref:Microsoft.Xrm.Sdk.ITracingService> from the service provider parameter. For more information about the tracing service, refer to [Debug a Plug-in](debug-plugin.md).  
  
 The execution context contains a wealth of information about the event that caused the plug-in to execute and the data contained in the message that is currently being processed by the pipeline. For more information about the data context, see [Understand the Data Context Passed to a Plug-in](understand-data-context-passed-plugin.md).  
  
 The platform provides the correct Web service URLs and network credentials when you obtain the organization Web service reference from the service provider. Instantiating your own Web service proxy is not supported because it creates deadlock and authentication issues. After you have the organization service reference, you can use it to make method calls to the organization Web service. You can retrieve or change business data in a single [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] organization by issuing one or more message requests to the Web service. For more information about message requests, see [Use Messages (Request and Response Classes) with the Execute Method](org-service/use-messages-request-response-classes-execute-method.md).  
  
 A typical plug-in should access the information in the context, perform the required business operations, and handle exceptions. For more information about handling exceptions in a plug-in, refer to [Handle Exceptions in Plug-ins](handle-exceptions-plugins.md). A more complete plug-in sample is available in the topic [Sample: Basic Plug-in](sample-create-basic-plugin.md).  
  
> [!IMPORTANT]
>  For improved performance, [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] caches plug-in instances. The plug-in's <xref:Microsoft.Xrm.Sdk.IPlugin.Execute(System.IServiceProvider)> method should be written to be stateless because the constructor is not called for every invocation of the plug-in. Also, multiple system threads could execute the plug-in at the same time. All per invocation state information is stored in the context, so you should not use global variables or attempt to store any data in member variables for use during the next plug-in invocation unless that data was obtained from the configuration parameter provided to the constructor. Changes to a plug-ins registration will cause the plug-in to be re-initialized.  
  
<a name="bkmk_writeconstructor"></a>

## Write a Plug-in Constructor

 The [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] platform supports an optional plug-in constructor that accepts either one or two string parameters. If you write a constructor like this, you can pass any strings of information to the plug-in at run time.  
  
 The following sample shows the format of the constructor. In this example, the plug-in class is named SamplePlugin.  
  
```csharp  
public SamplePlugin()  
public SamplePlugin(string unsecure)  
public SamplePlugin(string unsecure, string secure)  
```  
  
 The first string parameter of the constructor contains public (unsecure) information. The second string parameter contains non-public (secure) information. In this discussion, secure refers to an encrypted value while unsecure is an unencrypted value. When using [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)], the secure string is not passed to a plug-in that executes while [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] is offline.  
  
 The information that is passed to the plug-in constructor in these strings is specified when the plug-in is registered with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. When using the Plug-in Registration tool to register a plug-in, you can enter secure and unsecure information in the **Secure Configuration** and **Unsecure Configuration** fields provided in the **Register New Step** form. When registering a plug-in , `SdkMessageProcessingStep.Configuration` contains the unsecure value and `SdkMessageProcessingStep.SecureConfigId` refers to a `SdkMessageProcessingStepSecureConfig` record that contains the secure value.  
  
<a name="bkmk_supportoffline"></a>

## Support Offline Execution

 You can register plug-ins to execute in online mode, offline mode, or both. Offline mode is only supported on [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)]. Your plug-in code can check whether it is executing in offline mode by checking the <xref:Microsoft.Xrm.Sdk.IExecutionContext.IsExecutingOffline> property.  
  
 When you design a plug-in that will be registered for both online and offline execution, remember that the plug-in can execute twice. The first time is while [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)] is offline. The plug-in executes again when [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] goes online and synchronization between [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] and the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server occurs. You can check the <xref:Microsoft.Xrm.Sdk.IExecutionContext.IsOfflinePlayback> property to determine if the plug-in is executing because of this synchronization.  
  
<a name="bkmk_webaccess"></a>

## Web Access for Isolated (sandboxed) Plug-ins

 If you plan on registering your plug-in in the sandbox, you can still access Web addresses from your plug-in code. You can use any [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)] class in your plug-in code that provides Web access within the Web access restrictions outlined [Plug-in Isolation, Trust, and Statistics](plugin-isolation-trusts-statistics.md). For example, the following plug-in code downloads a Web page.  
  
 [!code-csharp[Plug-ins#WebClientPlugin2](../snippets/csharp/CRMV8/plug-ins/cs/webclientplugin2.cs#webclientplugin2)]  
  
> [!IMPORTANT]
>  For sandboxed plug-ins to be able to access external Web services, the server where the Sandbox Processing Service role is installed must be exposed to the Internet, and the account that the sandbox service runs under must have Internet access. Only outbound connections on ports 80 and 443 are required. Inbound connection access is not required. Use the Windows Firewall control panel to enable outbound connections for the Microsoft.Crm.Sandbox.WorkerProcess application located on the server in the %PROGRAMFILES%\Dynamics 365\Server\bin folder.  
  
<a name="bkmk_useearlybound"></a>

## Use Early-Bound Types

 To use early-bound [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] types in your plug-in code simply include the types file, generated using the [!INCLUDE[sdk_CodeGenUtility](../includes/sdk-codegenutility.md)] program, in your [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] plug-in project.  
  
 Conversion of a late-bound entity to an early-bound entity is handled as follows:  
  
```csharp  
Account acct = entity.ToEntity<Account>();  
```  
  
 In the previous line of code, the acct variable is an early-bound type. All <xref:Microsoft.Xrm.Sdk.Entity> values that are assigned to <xref:Microsoft.Xrm.Sdk.IPluginExecutionContext> must be late-bound types. If an early-bound type is assigned to the context, a [SerializationException](https://msdn.microsoft.com/library/system.runtime.serialization.serializationexception.aspx) will occur. For more information, see [Understand the Data Context Passed to a Plug-in](understand-data-context-passed-plugin.md). Make sure that you do not mix your types and use an early bound type where a late-bound type is called for as shown in the following code.  
  
```csharp  
context.InputParameters["Target"] = new Account() { Name = "MyAccount" }; // WRONG: Do not do this.  
```  
  
 In the example above, you do not want to store an early-bound instance in the plug-in context where a late-bound instance should go. This is to avoid requiring the platform to convert between early-bound and late bound types before calling a plug-in and when returning from the plug-in to the platform.  
  
<a name="bkmk_pluginassemblies"></a>

## Plug-in Assemblies

 There can be one or more plug-in types in an assembly. After the plug-in assembly is registered and deployed, plug-ins can perform their intended operation in response to a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] run-time event.  
  
> [!IMPORTANT]
>  - Plug-in assemblies must be no larger that 16 MB.
>  - In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], plug-in assemblies must be readable by everyone to work correctly. Therefore, it is a security best practice to develop plug-in code that does not contain any system logon information, confidential information, or company trade secrets.  
  
 Each plug-in assembly must be signed, either by using the **Signing** tab of the project's properties sheet in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] or the Strong Name tool, before being registered and deployed to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. For more information about the Strong Name tool, run the sn.exe program, without any arguments, from a [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] Command Prompt window.  
  
 If your assembly contains a plug-in that can execute while the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] is offline, there is additional security that the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] platform imposes on assemblies. For more information, see [Walkthrough: Configure Assembly Security for an Offline Plug-in](walkthrough-configure-assembly-security-offline-plugin.md).

 > [!Note]
 > Plugin and Workflow Assemblies must contain all the necessary logic within the respective dll.  Plugins may reference some core .Net assemblies. However, we do not support dependencies on .Net assemblies that interact with low-level Windows APIs, such as the graphics design interface. Previously, Dynamics 365 allowed for assemblies to refer to these interfaces, but to adhere to our security standards, changes to this behavior are required.
  
### See also

 [Plug-in Development](plugin-development.md)   
 [Understand the Data Context Passed to a Plug-in](understand-data-context-passed-plugin.md)   
 [Write a Custom Azure-aware Plug-in](write-custom-azure-aware-plugin.md)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)   
 [Handle Exceptions in Plug-ins](handle-exceptions-plugins.md)   
 [Sample: Basic Plug-in](sample-create-basic-plugin.md)   
 [Sample: Web Access from a Sandboxed Plug-in](sample-web-access-sandboxed-plugin.md)   
 [Run the Code Generation Utility](org-service/create-early-bound-entity-classes-code-generation-tool.md#bkmk_RuntheCodeGenerationUtility)   
 [Blog: Using Plug-Ins To Modify Views](http://blogs.msdn.com/b/ukcrm/archive/2011/03/10/using-plug-ins-to-modify-views.aspx)