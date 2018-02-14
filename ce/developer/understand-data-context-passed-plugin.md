---
title: "Understand the data context passed to a plug-in (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "IPluginExecutionContext contains information that describes the run-time environment that the plug-in executes, information related to the execution pipeline, and entity business information. The context is contained in the System.IServiceProvider parameter that is passed at run time to a plug-in through its IServiceProvider) method. "
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
  - "infinite loop"
ms.assetid: c59e7465-e955-40cc-a470-4a528138c36d
caps.latest.revision: 42
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Understand the data context passed to a plug-in

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

When a plug-in is run in response to an execution pipeline event for which it is registered, the plug-in’s <xref:Microsoft.Xrm.Sdk.IPlugin.Execute*> method is called. That method passes an [System.IServiceProvider](https://docs.microsoft.com/dotnet/api/system.iserviceprovider) object as a parameter, which contains a number of useful objects. The following sections describe some of the information that is passed to a plug-in when executed.  
  
<a name="bkmk_context"></a>   
## Access the plug-in execution context  
 <xref:Microsoft.Xrm.Sdk.IPluginExecutionContext> contains information that describes the run-time environment that the plug-in executes, information related to the execution pipeline, and entity business information. The context is contained in the [System.IServiceProvider](https://docs.microsoft.com/dotnet/api/system.iserviceprovider) parameter that is passed at run time to a plug-in through its <xref:Microsoft.Xrm.Sdk.IPlugin.Execute*> method.  
  
 [!code-csharp[Plug-ins#FollowupPlugin1](../snippets/csharp/CRMV8/plug-ins/cs/followupplugin1.cs#followupplugin1)]  
  
 When a system event is fired that a plug-in is registered for, the system creates and populates the context and passes it to a plug-in through the previously mentioned classes and methods. The execution context is passed to each registered plug-in in the pipeline when they are executed. Each plug-in in the execution pipeline is able to modify writable properties in the context. For example, given a plug-in registered for a pre-event and another plug-in registered for a post-event, the post-event plug-in can receive a context that has been modified by the pre-event plug-in. The same situation applies to plug-ins that are registered within the same stage.  
  
 All the properties in <xref:Microsoft.Xrm.Sdk.IPluginExecutionContext> are read-only. However, your plug-in can modify the contents of those properties that are collections. For more information about infinite loop prevention, see <xref:Microsoft.Xrm.Sdk.IExecutionContext.Depth>.  
  
<a name="bkmk_access"></a>   
## Access the Organization service  
 To access the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement organization service, it is required that plug-in code create an instance of the service through the [IServiceProvider.GetService(Type)](https://docs.microsoft.com/dotnet/api/system.iserviceprovider.getservice) method.  
  
 [!code-csharp[Plug-ins#FollowupPlugin4](../snippets/csharp/CRMV8/plug-ins/cs/followupplugin4.cs#followupplugin4)]  
  
 The platform provides the correct web service URLs and network credentials for you when you use this method. Instantiating your own Web service proxy is not supported as it will create deadlock and authentication issues.  
  
<a name="bkmk_notify"></a>   
## Access the Notification service  
 Synchronous registered plug-ins can post the execution context to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. The service provider object that is passed to the plug-in contains a reference to <xref:Microsoft.Xrm.Sdk.IServiceEndpointNotificationService>. It is through that notification service that synchronous plug-ins can send brokered messages to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. For more information about [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)], see [Introduction to Microsoft Azure Integration with Dynamics 365](azure-integration.md). For more information about writing a plug-in that can post to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)], see [Write a Custom Azure-aware Plug-in](write-custom-azure-aware-plugin.md).  
  
<a name="bkmk_inputandoutput"></a>   
## Input and output parameters  
 The <xref:Microsoft.Xrm.Sdk.IExecutionContext.InputParameters> property contains the data that is in the request message currently being processed by the event execution pipeline. Your plug-in code can access this data. The property is of type <xref:Microsoft.Xrm.Sdk.ParameterCollection> where the keys to access the request data are the names of the actual public properties in the request. As an example, take a look at <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest>. One property of <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> is named <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest.Target>, which is of type <xref:Microsoft.Xrm.Sdk.Entity>. This is the entity currently being operated upon by the platform. To access the data of the entity you would use the name “Target” as the key in the input parameter collection. You also need to cast the returned instance.  
  
 [!code-csharp[Plug-ins#FollowupPlugin2](../snippets/csharp/CRMV8/plug-ins/cs/followupplugin2.cs#followupplugin2)]  
  
 Note that not all requests contain a `Target` property that is of type <xref:Microsoft.Xrm.Sdk.Entity>, so you have to look at each request or response. For example, <xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> has a <xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest.Target> property, but its type is <xref:Microsoft.Xrm.Sdk.EntityReference>. The preceding code example would be changed as follows.  
  
```csharp  
// The InputParameters collection contains all the data passed in the message request.  
if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is EntityReference)  
{  
    // Obtain the target entity from the input parameters.  
    EntityReference entity = (EntityReference)context.InputParameters["Target"];  
}  
```  
  
 Once you have access to the entity data, you can read and modify it. Any data changes to the context performed by plug-ins registered in stage 10 or 20 of the pipeline are passed in the context to the core operation in stage 30.  
  
> [!IMPORTANT]
>  Not all fields in an entity record that are passed to a plug-in through the context can be modified. You should check the field’s **IsValidForUpdate** metadata property to verify that it isn’t set to `false`. Attempting to change the value of a field that can’t be updated results in an exception.  
  
 Similarly, the <xref:Microsoft.Xrm.Sdk.IExecutionContext.OutputParameters> property contains the data that is in the response message, for example <xref:Microsoft.Xrm.Sdk.Messages.CreateResponse>, currently being passed through the event execution pipeline. However, only synchronous post-event and asynchronous registered plug-ins have <xref:Microsoft.Xrm.Sdk.IExecutionContext.OutputParameters> populated as the response is the result of the core platform operation. The property is of type <xref:Microsoft.Xrm.Sdk.ParameterCollection> where the keys to access the response data are the names of the actual public properties in the response.  
  
<a name="bkmk_preandpost"></a>   
## Pre and post entity images  
 <xref:Microsoft.Xrm.Sdk.IExecutionContext.PreEntityImages> and <xref:Microsoft.Xrm.Sdk.IExecutionContext.PostEntityImages> contain snapshots of the primary entity's attributes before (pre) and after (post) the core platform operation. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] populates the pre-entity and post-entity images based on the security privileges of the impersonated system user. Only entity attributes that are set to a value or are **null** are available in the pre or post entity images. You can specify to have the platform populate these `PreEntityImages` and `PostEntityImages` properties when you register your plug-in. The entity alias value you specify during plug-in registration is used as the key into the image collection in your plug-in code.  
  
 There are some events where images aren’t available. For example, only synchronous post-event and asynchronous registered plug-ins have <xref:Microsoft.Xrm.Sdk.IExecutionContext.PostEntityImages> populated. The create operation doesn’t support a pre-image and a delete operation doesn’t support a post-image. In addition, only a small subset of messages support pre and post images as shown in the following table.  
  
|Message Request|Property|Description|  
|---------------------|--------------|-----------------|  
|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|Target|The assigned entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest>|Target|The created entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest>|Target|The deleted entity.|  
|<xref:Microsoft.Crm.Sdk.Messages.DeliverIncomingEmailRequest>|EmailId|The delivered email ID.|  
|<xref:Microsoft.Crm.Sdk.Messages.DeliverPromoteEmailRequest>|EmailId|The delivered email ID.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExecuteWorkflowRequest>|Target|The workflow entity.|  
|<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|Target|The parent entity, into which the data from the child entity is being merged.|  
|<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|SubordinateId|The child entity that is being merged into the parent entity.|  
|<xref:Microsoft.Crm.Sdk.Messages.SendEmailRequest>|EmailId|The sent entity ID.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|EntityMoniker|The entity for which the state is set.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest>|Target|The updated entity.|  
  
 Registering for pre or post images to access entity attribute values results in improved plug-in performance as compared to obtaining entity attributes in plug-in code through <xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> requests.  
  
> [!IMPORTANT]
>  A pre-image passed in the execution context to a plug-in or custom workflow activity might contain data that the logged-on user doesn't have the privileges to access. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] administrators and other users with high-level permissions can register plug-ins to run under the “system” user account or plug-in code can make calls as a “system” user on behalf of the logged-on user. If this happens, logged-on users can access data that their field level security does not allow access to. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Impersonation in Plug-ins](impersonation-plugins.md)  
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Handle Exceptions in Plug-ins](handle-exceptions-plugins.md)   
 [Event Execution Pipeline](event-execution-pipeline.md)   
 [Use Messages (Request and Response Classes) with the Execute Method](org-service/use-messages-request-response-classes-execute-method.md)   
 [Use IOrganizationService for Your Organization](org-service/use-organization-service-read-write-data-metadata.md)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)
