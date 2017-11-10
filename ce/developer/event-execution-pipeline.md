---
title: "Event execution pipeline (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The messages that contains business entity information and core operation information which are passed through the event eecution pipeline where it can be read or modified by the platform core operation and any registered plug-ins. "
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
  - "transaction"
  - "pipeline"
  - "async service"
  - "plug-in"
ms.assetid: 1281920e-554b-458d-a48c-c5f6bb485062
caps.latest.revision: 42
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Event execution pipeline

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement event processing subsystem executes plug-ins based on a message pipeline execution model. A user action in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Web application or an SDK method call by a plug-in or other application results in a message being sent to the organization Web service. The message contains business entity information and core operation information. The message is passed through the event execution pipeline where it can be read or modified by the platform core operation and any registered plug-ins.  
  
> [!NOTE]
>  While there are several Web services hosted by the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] platform, only events triggered by the organization service and the Web Api can cause plug-ins to execute.  
  
<a name="bkmk_Architecture"></a>   
## Architecture and related components  
 The following figure illustrates the overall architecture of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] platform with respect to both synchronous and asynchronous event processing.  
  
 ![Event processing architecture](media/asyncservice.gif "Event processing architecture")  
Synchronous and Asynchronous Event Processing Diagram  
  
 The event execution pipeline processes events either synchronously or asynchronously. The platform core operation and any plug-ins registered for synchronous execution are executed immediately. Synchronous plug-ins that are registered for the event are executed in a well-defined order. Plug-ins registered for asynchronous execution are queued by the Asynchronous Queue Agent and executed at a later time by the asynchronous service.  
  
> [!IMPORTANT]
>  Regardless of whether a plug-in executes synchronously or asynchronously, there’s a two-minute time limit imposed on the execution of a (message) request. If the execution of your plug-in logic exceeds the time limit, a [System.TimeoutException](https://msdn.microsoft.com/library/system.timeoutexception.aspx) is thrown. If a plug-in needs more processing time than two minutes, consider using a workflow or other background process to accomplish the intended task. This two-minute time limit applies only to plug-ins registered to execute under partial trust, also known as the sandbox. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Plug-in Isolation, Trusts, and Statistics](plugin-isolation-trusts-statistics.md)  
  
<a name="bkmk_PipelineStages"></a>   
## Pipeline stages  
 The event pipeline is divided into multiple stages, of which three are available to register custom developed or 3rd party plug-ins. Multiple plug-ins that are registered in each stage can be further be ordered (ranked) within that stage during plug-in registration.  
  
|Event|Stage name|Stage number|Description|  
|-----------|----------------|------------------|-----------------|  
|Pre-Event|Pre-validation|10|Stage in the pipeline for plug-ins that are to execute before the main system operation. Plug-ins registered in this stage may execute outside the database transaction. **Security Note:**  The pre-validation stage occurs prior to security checks being performed to verify the calling or logged on user has the correct permissions to perform the intended operation.|  
|Pre-Event|Pre-operation|20|Stage in the pipeline for plug-ins that are to execute before the main system operation. Plug-ins registered in this stage are executed within the database transaction.|  
|Platform Core Operation|MainOperation|30|In-transaction main operation of the system, such as create, update, delete, and so on. No custom plug-ins can be registered in this stage. [!INCLUDE[internal](../includes/internal.md)]|  
|Post-Event|Post-operation|40|Stage in the pipeline for plug-ins which are to execute after the main operation. Plug-ins registered in this stage are executed within the database transaction.|  
  
<a name="bkmk_MessageProcessing"></a>   
## Message processing  
 Whenever application code or a workflow invokes a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Web service method, a state change in the system occurs that raises an event. The information passed as a parameter to the Web service method is internally packaged up into a <xref:Microsoft.Xrm.Sdk.OrganizationRequest> message and processed by the pipeline. The information in the `OrganizationRequest` message is passed to the first plug-in registered for that event where it can be read or modified before being passed to the next registered plug-in for that event and so on. Plug-ins receive the message information in the form of context that is passed to their [IServiceProvider)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iplugin.execute\(system.iserviceprovider\)) method. The message is also passed to the platform core operation.  
  
<a name="bkmk_PluginRegistration"></a>   
## Plug-in registration  
 Plug-ins can be registered to execute before or after the core platform operation. Pre-event registered plug-ins receive the `OrganizationRequest` message first and can modify the message information before the message is passed to the core operation. After the core platform operation has completed, the message is then known as the <xref:Microsoft.Xrm.Sdk.OrganizationResponse>. The response is passed to the registered post-event plug-ins. Post-event plug-ins have the opportunity to modify the message before a copy of the response is passed to any registered asynchronous plug-ins. Finally, the response is returned to the application or workflow that invoked the original Web service method call.  
  
 Because a single [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server can host more than one organization, the execution pipeline is organization specific. There is a virtual pipeline for every organization. Plug-ins registered with the pipeline can only process business data for a single organization. A plug-in that is designed to work with multiple organizations must be registered with each organization's execution pipeline.  
  
<a name="bkmk_DatabaseTransactions"></a>   
## Inclusion in database transactions  
 Plug-ins may or may not execute within the database transaction of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] platform. Whether a plug-in is part of the transaction is dependent on how the message request is processed by the pipeline. You can check if the plug-in is executing in-transaction by reading the <xref:Microsoft.Xrm.Sdk.IExecutionContext.IsInTransaction> property inherited by <xref:Microsoft.Xrm.Sdk.IPluginExecutionContext> that is passed to the plug-in. If a plug-in is executing in the database transaction and allows an exception to be passed back to the platform, the entire transaction will be rolled back. Stages 20 and 40 are guaranteed to be part of the database transaction while stage 10 may be part of the transaction.  
  
 Any registered plug-in that executes during the database transaction and that passes an exception back to the platform cancels the core operation. This results in a rollback of the core operation. In addition, any pre-event or post event registered plug-ins that have not yet executed and any workflow that is triggered by the same event that the plug-in was registered for will not execute.  
  
### See also  
 [Introduction to the Event Framework](introduction-event-framework.md)   
 [Plug-in Isolation, Trusts, and Statistics](plugin-isolation-trusts-statistics.md)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)   
 [Asynchronous Service in Dynamics 365](asynchronous-service.md)
