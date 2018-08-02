---
title: "Write a custom Azure-aware plug-in (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how plug-in code can be added to obtain the Azure service provider and initiate posting the execution context to the service bus by calling IExecutionContext)."
ms.custom: ""
ms.date: 06/16/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
- "Dynamics 365 (online)"
ms.assetid: 35d8e05c-245a-4eff-bc5f-3a4ee8ffcb46
caps.latest.revision: 30
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Write a custom Azure-aware plug-in

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Writing a plug-in that works with [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] is similar to writing any other [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement plug-in. However, in addition to invoking any desired web service methods, the plug-in must include code to initiate posting the execution context to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)].  
  
<a name="bkmk_design"></a>

## Plug-in design considerations  
For a plug-in that executes synchronously, the recommended design is for the plug-in to send a message to [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] for the purpose of retrieving information from a listener application or other external service. Use of a two-way or REST contract on the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] endpoint allows a data string to be returned to the plug-in.  
  
It is not recommended that a synchronous plug-in use the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] to update data with an external service. Problems can arise if the external service becomes unavailable or if there is a lot of data to update. Synchronous plug-ins should execute fast and not hold up all logged in users of an organization while a lengthy operation is performed. In addition, if a rollback of the current core operation that invoked the plug-in occurs, any data changes made by the plug-in are undone. This could leave [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and an external service in an unsynchronized state.  
  
Note that it is possible for synchronous registered plug-ins to post the execution context to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)].  
  
<a name="bkmk_writing"></a>
  
## Write the plug-in code 
 
In the following sample plug-in code has been added to obtain the [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] service provider and initiate posting the execution context to the service bus by calling <xref:Microsoft.Xrm.Sdk.IServiceEndpointNotificationService.Execute(Microsoft.Xrm.Sdk.EntityReference,Microsoft.Xrm.Sdk.IExecutionContext)>. Tracing code has been added to facilitate debugging of the plug-in because the plug-in must run in the sandbox.  

> [!NOTE]
> The `serviceEndpointId` passed into the the constructor in this code is the one you get from creating a service endpoint as described in [Walkthrough: Configure Azure (SAS) for integration with Customer Engagement](walkthrough-configure-azure-sas-integration.md)
>
> You can query available service endpoints for your environment using a `GET` request to Web API using your browser with a query like this: *`[organization Uri]`*`/api/data/v9.0/serviceendpoints?$select=name,description,serviceendpointid`
  
[!code-csharp[WindowsAzure#SandboxPlugin](../snippets/csharp/CRMV8/windowsazure/cs/sandboxplugin.cs#sandboxplugin)]  
  
In your plug-in code, you can update the writeable data in the context before initiating the post. For example, you can add a key/value pair to the shared variables in the context.  
  
<a name="bkmk_registration"></a>

## Plug-in registration

There are a few restrictions when you register a [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] aware custom plug-in. The plug-in must be registered to execute in the sandbox. Because of this, the plug-in is limited to calling <xref:Microsoft.Xrm.Sdk.IOrganizationService> methods, [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] solution methods, or accessing a network using a web client. No other external access, such as access to a local file system, is allowed.  
  
For a plug-in registered to execute in asynchronous mode, this also means that the order of plug-in execution compared to other asynchronous plug-ins is not guaranteed. In addition, asynchronous plug-ins always execute after the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] core operation.  
  
<a name="bkmk_failure"></a>
 
## Handle a failed service bus post

The expected behavior from a failed service bus post is dependent on whether the plug-in was registered for synchronous or asynchronous execution. For asynchronous plug-ins, the system job that actually posts the execution context to the service bus will retry the post. For a synchronous registered plug-in, an exception is returned. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Management and Notification of Run-time Errors](azure-integration.md#bkmk_management)  
  
> [!IMPORTANT]
>  For asynchronous registered plug-ins only, when the asynchronous job that posts to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] is retried after a post failure, the entire plug-in logic is executed again. Because of this, don’t add any other logic to the custom [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] aware plug-in other than just modifying the context and posting to the service bus.  
  
For a plug-in registered to execute asynchronously, the <xref:Microsoft.Xrm.Sdk.RemoteExecutionContext> contained in the body of the message that is sent over the service bus includes a <xref:Microsoft.Xrm.Sdk.RemoteExecutionContext.OperationId> property and a <xref:Microsoft.Xrm.Sdk.RemoteExecutionContext.OperationCreatedOn> property. These properties contain the same data as the `AsyncOperationId` and `CreatedOn` attributes of the related System Job (`AsyncOperation`) record. These additional properties facilitate sequencing and duplicate detection if the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] post must be retried.  
  
### See also

[Azure Extensions for Dynamics 365](azure-extensions.md)<br />
[Send Dynamics 365 Data over the Microsoft Azure Service Bus](work-data-azure-solution.md)<br />
[Write a Plug-In](write-plugin.md)<br />
[Plug-in Isolation, Trust, and the Disallowed List](plugin-isolation-trusts-statistics.md)<br />
[Event Execution Pipeline](event-execution-pipeline.md)<br />
[Register and Deploy Plug-Ins](register-deploy-plugins.md)
