---
title: "Disaster recovery (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Online feature to recover from a planned or unplanned service interruption."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a4b17ddb-c0a8-433d-a428-858b495e6734
caps.latest.revision: 18
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Disaster recovery in Customer Engagement (online)

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Disaster recovery is a feature of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] to recover from a planned or unplanned service interruption. An example of a planned service interruption is regular and periodic datacenter system maintenance. An example of an unplanned service interruption is a failure of a key computer system or network component in a data center. For either case, you temporarily lose access to your organization's data and the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] services.  
  
 Planned service interruptions are preceded by a public notice in the web application or [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] identifying the date and time of the service maintenance so that businesses can plan for the interruption in accessing their organization's data. Unplanned service interruptions result in a notice that the organization is currently undergoing unplanned maintenance.  
  
 When a failure or a disaster occurs, well-defined processes are applied by the administrators of the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] data center to recover from a service interruption. The processes and software to recover from these service interruptions is known as *disaster recovery failover*. Your [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] datacenter maintains a duplicate and synchronized (alternate) copy of your organization's data on a different server. Should a disaster occur in the data center where you no longer have access to your data, the administrators monitoring the datacenter can switch access from your primary organization to this alternate organization, thereby minimizing the service interruption. When the failure has been corrected, service access to your primary organization can be restored.  
  
 This recovery happens in the datacenter and is handled transparently to you and your .NET managed applications. However, there is one issue that application developers must deal with: data loss. When the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] services encounter a failure, data change operations that your application performs using web service calls may not complete successfully. This can result in data loss. The following sections in this topic describe how you can write your applications to deal with data loss issues.  
  
<a name="develop"></a>   
## Develop a .NET Managed Code application for failover recovery  
 Developers can write their applications to account for data center failure and recovery by implementing code to check for and handle a failover event gracefully. An application can subscribe to the <xref:Microsoft.Xrm.Sdk.Client.ServiceProxy`1.EndpointSwitched><!--[EndpointSwitched](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.serviceproxy`1.endpointswitched)--> and <xref:Microsoft.Xrm.Sdk.Client.ServiceProxy`1.EndpointSwitchRequired> <!--[EndpointSwitchRequired](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.serviceproxy`1.endpointswitchrequired)--> notification events. These events are also available in derived classes like <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy>. For more information about these events, see the <xref:Microsoft.Xrm.Sdk.Client.ServiceProxy`1><!--[ServiceProxy\`1](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.serviceproxy`1)--> class documentation.  
  
 Your application can check the <xref:Microsoft.Xrm.Sdk.Client.IEndpointSwitch.EndpointAutoSwitchEnabled> property to determine whether automatic failover behavior is enabled for an organization. This property is set to **true** for organizations where a failover alternate endpoint is available. No other special code is required in your application other than optionally subscribing to the notification events when `EndpointAutoSwitchEnabled` is **true**.  
  
#### Typical application logic flow for a disaster event and failover  
  
1.  A disaster event occurs in the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] datacenter.  
  
2.  Your application makes a service call through a service proxy class object: <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy>, <xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy>.  
  
3.  The service proxy class object receives an exception after attempting the service call.  
  
4.  If the target organization of the call is not enabled for failover, go to step 9.  
  
5.  The <xref:Microsoft.Xrm.Sdk.Client.ServiceProxy`1.EndpointSwitchRequired><!--[EndpointSwitchRequired](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.serviceproxy`1.endpointswitchrequired)--> event is thrown.  
  
6.  The <xref:Microsoft.Xrm.Sdk.Client.ServiceProxy`1.EndpointSwitched><!--[EndpointSwitched](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.serviceproxy`1.endpointswitched)--> event is thrown.  
  
7.  The service proxy class object automatically tries the call again.  
  
8.  If the second call was successful, the application continues normally.  
  
9. If the call was not successful, an exception is returned to the application: `EndpointNotFoundException`, `TimeoutException`, `FaultException<OrganizationServiceFault>` where `fault.Detail.ErrorCode` == -2147176347.  
  
 You may want to implement code that checks for potential data loss after endpoint switch events are received and handle it appropriately.  
  
 After the disaster affecting the primary organization endpoint has been corrected in the datacenter, a fail back from the alternate endpoint URL to the primary endpoint URL for the organization occurs as part of planned organization maintenance.  
  
<a name="develop_fail"></a>   

## Develop a Non-.NET application for failover recovery 
 
 Applications that do not use the .NET assemblies, for example Java applications that access the web services by using the Organization service or Web API can try accessing the failover URL for the target organization. The URL for a failover alternate organization is the same as the URL for the primary organization with “--S” added to the organization name. For example, an organization named Contoso would have the primary and alternate URLs shown in the following table.  
  
|Primary Organization URL|Alternate Organization URL|  
|------------------------------|--------------------------------|  
| https://contoso.api.crm.dynamics.com | https://contoso--s.api.crm.dynamics.com |  
  
 For non.NET-connected applications, there is no notification event to which your application can subscribe to receive notice of a service interruption and failover. Your application will begin to receive a variety of fault exceptions, as listed previously, during the service interruption. At that point, the application can attempt to connect to the failover alternate URL for the target organization. After the disaster has been corrected, a fail back to the primary URL for the organization occurs as part of planned organization maintenance.  
  
<a name="best_practices"></a>   
## Best practices  
 The following list describes some best practices you can implement in your applications to make them more robust when they deal with service interruptions and failure recovery.  
  
-   Write application code to check the <xref:Microsoft.Xrm.Sdk.Client.IEndpointSwitch.EndpointAutoSwitchEnabled> property value to determine whether it is set to **true**. If **true**, consider subscribing to the <xref:Microsoft.Xrm.Sdk.Client.ServiceProxy`1.EndpointSwitched><!--[EndpointSwitched](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.serviceproxy`1.endpointswitched)--> and <xref:Microsoft.Xrm.Sdk.Client.ServiceProxy`1.EndpointSwitchRequired><!--[EndpointSwitchRequired](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.serviceproxy`1.endpointswitchrequired)--> notification events.  
  
-   If your application works with critical data where any data loss is disastrous, write event handler code or catch the indicated exceptions to handle the disaster event and failover as appropriate for business needs.  
   
