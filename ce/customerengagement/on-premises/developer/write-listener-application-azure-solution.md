---
title: "Write a listener application for a Microsoft Azure solution (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The topic describes how to write an Azure solution listener application that can read and process Dynamics 365 Customer Engagement (on-premises) Customer Engagement messages that are posted to the Azure Service Bus."
ms.custom: 
ms.date: 12/17/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: bf0b34fa-b49b-41f6-a2ca-9029a1ba64a1
caps.latest.revision: 60
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Write a listener application for a Azure solution

This topic describes how to write an [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] solution  listener application that can read and process [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] messages that are posted to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. As a prerequisite, you should familiarize yourself with how to write a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] listener before trying to learn the specifics of a Dynamics 365 Customer Engagement (on-premises) listener. For more information, see the [Azure Service Bus documentation](https://azure.microsoft.com/documentation/services/service-bus/).  
  
<a name="bkmk_writequeued"></a>

## Write a queue listener

A message *queue* is a repository of messages received at a service bus endpoint. A *queue listener* is an application that reads and processes these queued messages. Because the service bus messages are stored in a queue, a listener doesn’t have to be actively listening for messages to be received in the queue. A queue listener can be started after messages have arrived in the queue and still process those messages. Other types of listeners discussed in the next section must be actively listening or they will miss the opportunity to read a message. These messages can originate from Dynamics 365 Customer Engagement (on-premises) or from some other source. 
  
> [!IMPORTANT]
>  When writing a queue listener, check each message header action to determine if the message originated from Dynamics 365 Customer Engagement (on-premises). For information on how to do this see [Filter messages](write-listener-application-azure-solution.md#filter).  
  
You can do a destructive message read using [Receive](https://msdn.microsoft.com/library/microsoft.servicebus.messaging.queueclient.receive.aspx) in [ReceiveAndDelete](https://msdn.microsoft.com/library/microsoft.servicebus.messaging.receivemode.aspx) mode, where the message is read and removed from the queue, or a non-destructive read using [PeekLock](https://msdn.microsoft.com/library/microsoft.servicebus.messaging.receivemode.aspx) mode, where the message is read but still available in the queue. The persistent queue listener sample code provided in this SDK does a destructive read. For more information about reading messages from a queue, see [How to Receive Messages from a Queue](https://azure.microsoft.com/documentation/articles/service-bus-dotnet-how-to-use-queues/#how-to-receive-messages-from-a-queue).  
  
A *topic* is similar to a queue but implements a publish/subscribe model. One or more listeners can subscribe to the topic and receive messages from its queue. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Queues, Topics, and Subscriptions](https://msdn.microsoft.com/library/windowsazure/hh367516.aspx)  
  
> [!IMPORTANT]
>  To use these queue or topic contracts, you must write your listener applications using the [Azure SDK](https://azure.microsoft.com/downloads/archive-net-downloads/) version 1.7 or higher.  
  
Use of queues and topics in your multisystem software design can result in the decoupling of systems. If the listener application ever becomes unavailable, the message delivery from Dynamics 365 Customer Engagement (on-premises) will still succeed and the listener application can continue processing the queue message when it is back online. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Queues, Topics, and Subscriptions](https://msdn.microsoft.com/library/windowsazure/hh367516.aspx)  
  
<a name="bkmk_writeoneway"></a>

## Write a one-way, two-way, or REST listener

In addition to the queue listener described previously, you can write a listener for three other service bus contracts that are supported by Dynamics 365 Customer Engagement (on-premises): one-way, two-way, and REST. A one-way listener can read and process a message posted to the service bus. A two-way listener can do the same but can also return a string of some information back to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. A REST listener is the same as the two-way listener except that it works with a REST endpoint. Notice that these listeners must be actively listening at a service endpoint to read a message sent over the service bus. If the listener isn’t listening when Dynamics 365 Customer Engagement (on-premises) attempts to post a message to the service bus, the message doesn’t get sent.  
  
Writing a listener is structured around what is known as ABC: address, binding, and contract. 

### One-way listener
  
- Address: service URI  
  
- Binding: [WS2007HttpRelayBinding](https://msdn.microsoft.com/library/microsoft.servicebus.ws2007httprelaybinding.aspx)  
  
- Contract: <xref:Microsoft.Xrm.Sdk.IServiceEndpointPlugin>  
  
After your listener is registered with an endpoint, the listener’s <xref:Microsoft.Xrm.Sdk.IServiceEndpointPlugin.Execute*> method is invoked whenever a message is posted to the service bus by Dynamics 365 Customer Engagement (on-premises). The `Execute` method doesn’t return any data from the method call. For more information, see the one-way listener sample, [Sample: One-way Listener](sample-one-way-listener.md).  
  
### Two-way listener
  
- Address: service URI  
  
- Binding: [WS2007HttpRelayBinding](https://msdn.microsoft.com/library/microsoft.servicebus.ws2007httprelaybinding.aspx)  
  
- Contract: <xref:Microsoft.Xrm.Sdk.ITwoWayServiceEndpointPlugin>  
  
For this two-way contract, the <xref:Microsoft.Xrm.Sdk.ITwoWayServiceEndpointPlugin.Execute*> method returns a string from the method call. For more information, see the two-way listener sample, [Sample: Two-way Listener](sample-two-way-listener.md).  
  
### REST listener
  
- Address: service URI  
  
- Binding: [WebHttpRelayBinding](https://msdn.microsoft.com/library/microsoft.servicebus.webhttprelaybinding.aspx)  
  
- Contract: <xref:Microsoft.Xrm.Sdk.IWebHttpServiceEndpointPlugin>  
  
For the REST contract, the <xref:Microsoft.Xrm.Sdk.IWebHttpServiceEndpointPlugin.Execute*>  method returns a string from the method call. Refer to the REST listener sample, [Sample: REST Listener](sample-rest-listener.md), for more information. Notice that in the REST listener sample, a [WebServiceHost](https://msdn.microsoft.com/library/system.servicemodel.web.webservicehost.aspx) is instantiated and not a [ServiceHost](https://msdn.microsoft.com/library/system.servicemodel.servicehost.aspx) as was done in the two-way sample.  
  
> [!NOTE]
>  When using the out-of-box (ServiceBusPlugin) plug-in with a two-way or REST listener, the plug-in doesn’t use any string data returned from the listener. However, a custom [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)]-aware plug-in could make use of this information.  
> 
>  When you run the listener samples, the issuer secret you’re prompted for is the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] management key. The WS2007 Federation HTTP binding uses `token` mode and the WS-Trust 1.3 protocol.  
  
<a name="filter"></a>

## Filter messages

There is a property bag of extra information added to each brokered message [Properties](https://msdn.microsoft.com/library/windowsazure/microsoft.servicebus.messaging.brokeredmessage.properties.aspx) property sent from [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] and [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)]. The property bag, available with queue, relay, and topic contract endpoints, contains the following information:  
  
- Organization URI  
  
- Calling user ID  
  
- Initiating user ID  
  
- Entity logical name  
  
- Request name  
  
This information identifies the organization, user, entity, and message request being processed by Dynamics 365 Customer Engagement (on-premises) that resulted in the service bus message being posted. The availability of these properties indicates that the message was sent from Dynamics 365 Customer Engagement (on-premises). Your listener code can decide how to process the message based on these values.  
  
<a name="bkmk_multiple-formats"></a>
 
## Read the data context in multiple data formats

The data context from the current Dynamics 365 Customer Engagement (on-premises) operation is passed to your [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] solution listener application in the body of a service bus message. In previous releases, only a .NET binary format was supported.  For cross-platform (non-.NET) interoperability, you can now specify one of three data formats for the message body: .NET Binary, JSON, or XML.  This format is specified in the [MessageFormat](entities/serviceendpoint.md#BKMK_MessageFormat) attribute of the [ServiceEndpoint Entity](entities/serviceendpoint.md).  
  
> [!NOTE]
> [!INCLUDE[cc_feature_included_with_update_8_1_0_admins](../includes/cc-feature-included-with-update-8-1-0-admins.md)]  
  
When receiving messages, your listener application can read the data context in the message body based on the contenttype of the message. Sample code to do so is shown below.  
  
```csharp
var receivedMessage = inboundQueueClient.Receive(TimeSpan.MaxValue);  
  
if (receivedMessage.ContentType = "application/msbin1")  
{  
    RemoteExecutionContext context = receivedMessage.GetBody<RemoteExecutionContext>();  
}  
else if (receivedMessage.ContentType = "application/json")  
{  
    //string jsonBody = new StreamReader(receivedMessage.GetBody<Stream>(), Encoding.UTF8).ReadToEnd();  
    RemoteExecutionContext contextFromJSON = receivedMessage.GetBody<RemoteExecutionContext>(  
        new DataContractJsonSerializer(typeof(RemoteExecutionContext)));  
}  
else if (receivedMessage.ContentType = "application/xml")  
{  
    //string xmlBody = new StreamReader(receivedMessage.GetBody<Stream>(), Encoding.UTF8).ReadToEnd();  
    RemoteExecutionContext contextFromXML = receivedMessage.GetBody<RemoteExecutionContext>(  
        new DataContractSerializer(typeof(RemoteExecutionContext)));  
}  
```  
  
### See also

 [Azure Extensions](azure-extensions.md)   
 [Write a Custom Azure-aware Plug-in](write-custom-azure-aware-plugin.md)   
 [Sample: Persistent Queue Listener](sample-persistent-queue-listener.md)   
 [Sample: One-way Listener](sample-one-way-listener.md)   
 [Sample: Two-way Listener](sample-two-way-listener.md)   
 [Sample: REST Listener](sample-rest-listener.md)   
 [Send Dynamics 365 Customer Engagement Data over the Azure Service Bus](work-data-azure-solution.md)   
 [Work with Dynamics 365 Customer Engagement event data in your Azure Event Hub solution](work-event-data-azure-event-hub-solution.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]