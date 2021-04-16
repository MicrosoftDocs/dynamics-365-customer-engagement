---
title: "Azure integration with Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about connecting Dynamics 365 Customer Engagement (on-premises) with the Azure platform by coupling the Dynamics 365 Customer Engagement (on-premises) event execution pipeline to the Azure Service Bus."
ms.custom: 
ms.date: 09/19/2018
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - azure, about crm integration
ms.assetid: fbfa6e40-52d2-4042-a9fb-93f1b1cd1c1a
caps.latest.revision: 73
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Azure integration with Customer Engagement

You can connect [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] with the [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] platform by coupling the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] event execution pipeline to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. Once configured,this connection allows data that’s been processed as part of the current [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] operation to be posted to the service bus. [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] solutions that are “[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]-aware” can listen for and read the Dynamics 365 Customer Engagement (on-premises) data from the service bus.  
  
 This connection between Dynamics 365 Customer Engagement (on-premises) and the [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] platform provides a secure and reliable channel for communicating [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] run-time data to external cloud-based line-of-business (LOB) applications.  
  
<a name="bkmk_identify"></a>   

## Key elements of the connection  

 The key elements that implement the connection between Dynamics 365 Customer Engagement (on-premises) and the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] are described below. A diagram in the next section shows these elements in operation.  
  
 **Data Context**  
 The *data context* contains the business data that is being processed as part of the current [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] operation. This processing was initiated when a request to perform a certain operation was made by a user, workflow, or application,  to the Dynamics 365 Customer Engagement (on-premises) platform. The data context is passed to any plug-ins or custom workflow activities that are registered with the event pipeline to execute on the specific request and entity combination that is currently being processed. The data context is of type <xref:Microsoft.Xrm.Sdk.IPluginExecutionContext> when it is being passed along the event execution pipeline and <xref:Microsoft.Xrm.Sdk.RemoteExecutionContext> when it is posted to the service bus.  
  
 The data context contained within the message that is posted to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] can be formatted in XML or JSON in addition to the default .NET binary format. This allows for cross-platform interoperability where Azure hosted non-.NET clients can read [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data from the service bus. [!INCLUDE[cc_feature_included_with_update_8_1_0_admins](../includes/cc-feature-included-with-update-8-1-0-admins.md)]. 

> [!IMPORTANT]
> When the size of the entire HTTP payload exceeds 192Kb, the following properties will be removed:
>
> - <xref:Microsoft.Xrm.Sdk.RemoteExecutionContext.ParentContext>
> - <xref:Microsoft.Xrm.Sdk.RemoteExecutionContext.InputParameters>
> - <xref:Microsoft.Xrm.Sdk.RemoteExecutionContext.PreEntityImages>
> - <xref:Microsoft.Xrm.Sdk.RemoteExecutionContext.PostEntityImages>
>
> Some operations do not include these properties. 
>
> - If the size of the payload is below 192Kb after the additional data is removed, an additional `MessageMaxSizeExceeded` property is added to the [BrokeredMessage](/dotnet/api/microsoft.servicebus.messaging.brokeredmessage) sent by the system. This indicates that some of the data has been truncated.
> - If the size of the payload exceeds 192Kb after the  additional data is removed, an error occurs and the message is not sent.
  
 [!INCLUDE[sdk_for_more_info_about](../includes/sdk-for-more-info-about.md)] the technologies described above see: [Understand the execution context](/powerapps/developer/common-data-service/understand-the-data-context), [Event execution pipeline](/powerapps/developer/common-data-service/event-framework#event-execution-pipeline), and [Write a listener application for a Microsoft Azure solution](write-listener-application-azure-solution.md).  
  
 **Plug-ins**  
 Plug-ins are one of two methods used to initiate posting the message containing the data context to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)], the other method being a custom workflow activity. There are two kinds of plug-ins supported by the Dynamics 365 Customer Engagement (on-premises)-Azure connection feature: out-of-box (OOB), and custom. In either case, it is recommended that you register the plug-in to run asynchronously for best system performance.  
  
 An [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)]-aware OOB plug-in is provided with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and can be registered using the Plug-in Registration Tool in the  SDK download. This plug-in executes in full trust with the Dynamics 365 Customer Engagement (on-premises) platform. You must register a plug-in 'step' in the event execution pipeline  that identifies the message and entity combination that triggers  the plug-in to execute and perform the posting notification. When executed, the plug-in  notifies the asynchronous service, through a service endpoint notification service (<xref:Microsoft.Xrm.Sdk.IServiceEndpointNotificationService>), to post the current request data context to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)].  
  
 You can also write your own custom plug-in that is “[!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)]-aware”. The custom plug-in executes in partial trust mode in the sandbox. A custom plug-in can initiate posting of the data context to the service bus through the service endpoint notification service. Adding code to invoke this service makes the plug-in “[!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)]-aware”. For more information about plug-ins in general, see [Write a plug-in](/powerapps/developer/common-data-service/write-plug-in). For more information about [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)]-aware plug-ins, see [Write a Custom Azure-aware Plug-in](write-custom-azure-aware-plugin.md).  
  
 **Custom Workflow Activities**  
 Similarly to plug-ins, custom workflow activities can be written to initiate posting the current request message data context to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] by using the service endpoint notification service (<xref:Microsoft.Xrm.Sdk.IServiceEndpointNotificationService>). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Sample: Azure Aware Custom Workflow Activity](sample-azure-aware-custom-workflow-activity.md).  
  
 **Asynchronous Service**  
 Once notified by the service endpoint notification service, the asynchronous service handles posting the  data context of the request message currently being processed by the event execution pipeline to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. Each post is performed by a system job of the asynchronous service. A user can view the status of each system job by using the **System Jobs** view of the Dynamics 365 Customer Engagement (on-premises) web application.  
  
 [!INCLUDE[sdk_for_more_info_about](../includes/sdk-for-more-info-about.md)] the asynchronous service see [Asynchronous service in Dynamics 365 Customer Engagement (on-premises)](asynchronous-service.md).  
  
 **Microsoft Azure Service Bus**  
 The service bus relays the request messagedata context betweenDynamics 365 Customer Engagement (on-premises) and [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] solution listener applications. The service bus also provides data security so that only authorized applications can access the posted Dynamics 365 Customer Engagement (on-premises) data.  Authorization of Dynamics 365 Customer Engagement (on-premises) to post the data context to the service bus and for listener applications to read it is managed by  [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] Shared Access Signatures (SAS).  
  
  
 [!INCLUDE[sdk_for_more_info_about](../includes/sdk-for-more-info-about.md)] the service bus see [Service Bus](https://azure.microsoft.com/services/service-bus/). [!INCLUDE[sdk_for_more_info_about](../includes/sdk-for-more-info-about.md)] service bus authorization see [Service Bus authentication and authorization](/azure/service-bus-messaging/service-bus-authentication-and-authorization).  
  
 **Microsoft Azure Solution**  
 For the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]-[!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] connection to work there must be at least one solution in an [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] solution account, where the solution contains one or more service endpoints. For a relay endpoint contract, a listener application that is “[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]-aware” must be actively listening on the endpoint for the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] request on the service bus. For a queue endpoint contract, a listener doesn’t have to be actively listening. A listener is made “[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]-aware” by linking it to the <xref:Microsoft.Xrm.Sdk> assembly so that type <xref:Microsoft.Xrm.Sdk.RemoteExecutionContext> is defined. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Write a Listener for a Microsoft Azure Solution](write-listener-application-azure-solution.md)  
  
 Dynamics 365 Customer Engagement (on-premises) support sending event data to an [!INCLUDE[pn_azure_event_hubs](../includes/pn-azure-event-hubs.md)] solution. [!INCLUDE[cc_feature_included_with_update_8_1_0_admins](../includes/cc-feature-included-with-update-8-1-0-admins.md)]. [!INCLUDE[sdk_for_more_info_about](../includes/sdk-for-more-info-about.md)] event hubs see [Work with Dynamics 365 Customer Engagement (on-premises) event data in your Azure Event Hub solution](work-event-data-azure-event-hub-solution.md).  
  
<a name="bkmk_describing"></a>  
 
## A Dynamics 365 Customer Engagement (on-premises)-to-service bus scenario  

 Let us now identify a scenario that implements the previously mentioned connection components. As a prerequisite, SAS has been configured to recognize Dynamics 365 Customer Engagement (on-premises) as the supported issuer and the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] solution configured with rules to allow Dynamics 365 Customer Engagement (on-premises) to post to the endpoint where the listener is.  
  
 The following diagram shows the physical elements that make up the scenario.  
  
 ![Dynamics 365 Customer Engagement (on-premises) to Service Bus scenario](media/crm-v5s-az.png "Dynamics 365 Customer Engagement (on-premises) to Service Bus scenario")  
  
 The sequence of events as identified in this diagram are as follows:  
  
1. A listener application is registered on a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] solution endpoint and begins actively listening for the Dynamics 365 Customer Engagement (on-premises) remote execution context on the service bus.  
  
2. A user performs some operation in Dynamics 365 Customer Engagement (on-premises) that triggers execution of the registered OOB plug-in or a custom [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)]-aware plug-in. The plug-in initiates a post, through an asynchronous service system job, of the current request data context to the service bus.  
  
3. The claims posted by Dynamics 365 Customer Engagement (on-premises) are authenticated. The service bus then relays the remote execution context to the listener. The listener processes the context information and performs some business-related task with that information. The service bus notifies the asynchronous service of a successful post and sets the related system job to a completed status.  
  
<a name="bkmk_establising"></a>  
 
## Establish a contract between Dynamics 365 Customer Engagement (on-premises) and an Azure solution  
 For each solution endpoint, you configure a contract that defines the handling of these remote execution context “messages” on the service bus and the security that should be used on that endpoint. Service bus messages are received at an endpoint using one of the supported contracts listed here.  
  
 **Queue**  
 A queue contract provides a message queue in the cloud. With a queue contract, a listener doesn’t have to be actively listening for messages on the endpoint. For queues, there is a destructive read and a non-destructive read. A destructive read reads an available message from the queue and the message is removed. A non-destructive read doesn’t remove a message from the queue.  
  
 The type of queue supported by Dynamics 365 Customer Engagement (on-premises) is called a persistent queue. Persistent queues have a long but finite message availability duration that can be specified in code.  
  
 **One-way**  
 A one-way contract requires an active listener. If there is no active listener on an endpoint, the post to the service bus fails. Dynamics 365 Customer Engagement (on-premises) will retry the post in exponentially larger and larger time spans until the asynchronous system job that is posting the request is eventually aborted and its status is set to “Failed.”  
  
 **Two-way**  
 A two-way contract is similar to a one-way contract except that a string value can be returned from the listener to the plug-in or custom workflow activity that initiated the post.  
  
 **REST**  
 A REST contract is similar to a two-way contract on a REST endpoint.  
  
 **Topic**  
 Similar to a queue except that one or more listeners can subscribe to receive messages from the topic.  
  
 **Event Hub**  
 This contract type applies to [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] Event Hub solutions.  
  
> [!IMPORTANT]
>  To use these contracts, you must write your listener applications using the [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)][SDK](https://www.windowsazure.com/develop/downloads/) v1.7 or later.  
  
 Identifying the kind of security a contract uses is part of the contract’s configuration. A contract can use Transport security, which uses Transport Layer Security (TLS) or Secure Sockets Layer (SSL) (https).  
  
 Claims authentication is used for secure access to the service bus. The claim used to authenticate to the service bus is generated in Dynamics 365 Customer Engagement (on-premises) and signed by the AppFabricIssuer certificate specified in the Dynamics 365 Customer Engagement (on-premises) configuration database.  
  
<a name="bkmk_management"></a>   

## Manage of run-time errors  

 If an error occurred after a post was attempted to the service bus, check the status of the related system job in the Dynamics 365 Customer Engagement (on-premises) web application for more information on the error. If the service bus is down or a listener/endpoint isn’t available, the current message being processed in Dynamics 365 Customer Engagement (on-premises) will not be posted to the bus. The asynchronous service will continue to try to post the message in an exponential pattern where it will try to post frequently at first and then at longer and longer intervals. For an internal Dynamics 365 Customer Engagement (on-premises) error, message posts are not attempted. For an external service bus or network error, the related system job will be in a “Wait” state.  
  
### See also  
 [Azure Extensions for Dynamics 365 Customer Engagement (on-premises)](azure-extensions.md)   
 [Configure Azure integration with Dynamics 365 Customer Engagement (on-premises)](configure-azure-integration.md)   
 [Plug-ins for Extending Dynamics 365 Customer Engagement (on-premises)](write-plugin-extend-business-processes.md)   
 [Understanding the Asynchronous Service](asynchronous-service.md)   
 [System Job (asyncoperation) Entities](asyncoperation-system-job-entity.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]