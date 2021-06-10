---
title: "Walkthrough: Configure Microsoft Azure (SAS) for integration with Dynamics 365 Customer Engagement (on-premises)| MicrosoftDocs"
description: "The walkthrough guides you through configuring the Azure Service Bus issuer, scope, and rules to allow a listener application to read the Dynamics 365 Customer Engagement messages posted to the Azure Service Bus. "
ms.custom: 
ms.date: 05/16/2018
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1977e223-2d7b-4019-a584-e81d1b832785
caps.latest.revision: 8
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# Walkthrough: Configure Azure (SAS) for integration with Customer Engagement (on-premises)

This walkthrough guides you through configuring the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] issuer, scope, and rules to allow a listener application to read the Dynamics 365 Customer Engagement (on-premises) messages posted to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)].  
  
> [!NOTE]
>  This walkthrough applies to any Dynamics 365 Customer Engagement (on-premises) deployment when using SAS authorization for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]-[!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] messaging. [!INCLUDE[sdk_for_more_info_about](../includes/sdk-for-more-info-about.md)][!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] authorization see [Service Bus authentication and authorization](/azure/service-bus-messaging/service-bus-authentication-and-authorization).  
> 
> You must use the Plug-in Registration Tool. To download the plug-in registration tool, see [Download tools from NuGet](download-tools-NuGet.md).
  
## Prerequisites  
  
- An [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] account with a license to create Service Bus entities.  
  
- A SAS configured service bus namespace.  
  
- A SAS configured service bus messaging entity: queue, topic, relay, or event hub.  
  
- The messaging entity must have the `Send` policy permission at a minimum. For a two-way relay, the policy must also have the `Listen` permission.  
- The authorization connection string of your messaging entity. 
  
  ![Define the Azure policy permissions](media/policy-permissions.png "Define the Azure policy permissions")  
  
  Refer to the [Create a Service Bus namespace using the Azure portal](/azure/service-bus-messaging/service-bus-create-namespace-portal) for instructions on how to create a Service Bus namespace and messaging entity.  
  
## Create a service endpoint  
 A [ServiceEndpoint Entity ](entities/serviceendpoint.md) contains configuration data that is required for external messaging with a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] solution endpoint. By using the Plug-in Registration Tool, you can easily create a service endpoint entity in a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization and configure  the service bus endpoint issuer, scope, and rules.  
  
### Register a Service Endpoint  
  
1. Run the Plug-in Registration Tool and log into your target [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization.  
  
2. Select **Register > Register New Service Endpoint**.  
  
3. Check **Let's Start with the connection string from the Azure Service Bus Portal** and paste the connection string of your service bus messaging entity.  
  
   ![Provide authorization connection string](media/sas-connection-string.PNG "Provide authorization connection string")  
  
4. Select **Next**.  
  
5. Fill out the **Service Endpoint Registration** form by entering the **Designation Type**, **Message Format**, and optionally the **User Information Sent** and **Description** fields  
  
   ![Service endpoint registration](media/service-endpoint-registration.PNG "Service endpoint registration")  
  
   For more information about the message format, see [Write a listener application for a Azure solution](write-listener-application-azure-solution.md).  
  
6. Select **Save**.  
  
7. After a few seconds or so, you will see the new service endpoint in the **Registered Plug-ins & Custom Workflow Activities** list.  
  
   ![New service endpoint](media/new-service-endpoint.PNG "New service endpoint")  
  
### See also  
 [Azure extensions for Dynamics 365 Customer Engagement (on-premises)](azure-extensions.md)   
 [Azure Service Bus](/azure/service-bus-messaging/service-bus-fundamentals-hybrid-solutions)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]