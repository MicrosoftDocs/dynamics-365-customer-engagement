---
title: "Sample: REST listener (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to write a Azure Service Bus Listener for a REST endpoint contract. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - azure
ms.assetid: db6a8899-9003-4ae0-b249-9fc31854583e
caps.latest.revision: 23
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: REST listener

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with Microsoft Dynamics 365 Customer Engagement (on-premises) and Azure Integration](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Azure)
  
## Requirements  
 You must configure Dynamics 365 Customer Engagement (on-premises) integration with [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] prior to registering and executing this sample activity.  
  
## Demonstrates  
 This sample shows how to write a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] Listener for a REST endpoint contract.  
  
 This sample registers a remote service plug-in that executes whenever a Dynamics 365 Customer Engagement (on-premises) message is posted to a REST endpoint on the service bus. When the plug-in executes, it prints to the console the contents of the Dynamics 365 Customer Engagement (on-premises) execution context contained in the message.  
  
## Example  
 [!code-csharp[WindowsAzure#RestListener](../snippets/csharp/CRMV8/windowsazure/cs/restlistener.cs#restlistener)]  
  
### See also  
 [Configure Microsoft Azure Integration with Dynamics 365 Customer Engagement (on-premises)](configure-azure-integration.md)   
 [Sample Code for Dynamics 365 Customer Engagement and Microsoft Azure Integration](sample-code-azure-integration.md)   
 [Sample: Persistent Queue Listener](sample-persistent-queue-listener.md)   
 <xref:Microsoft.Xrm.Sdk.IWebHttpServiceEndpointPlugin>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]