---
title: "Sample: Persistent queue listener (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample shows how to write a Azure Service Bus listener application for a persistent queue endpoint contract. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: daf6923c-1bfb-4c14-8b81-baec2a1d0699
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Persistent queue listener

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with Microsoft Dynamics 365 Customer Engagement and Azure Integration](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Azure) 
  
## Requirements  
 This sample code requires the following additional [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] project reference: **Microsoft.ServiceBus**. The Microsoft.ServiceBus.dll assembly can be found in the [Microsoft Azure SDK](https://azure.microsoft.com/downloads/archive-net-downloads/).  
  
## Demonstrates  
 This sample shows how to write a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] listener application for a persistent queue endpoint contract.  
  
 The listener waits for a Dynamics 365 Customer Engagement (on-premises) message to be posted to the service bus and to be available in the endpoint queue. When a message is available in the queue, the listener reads the message, prints the Dynamics 365 Customer Engagement (on-premises) execution context contained in the message to the console, and deletes the message from the queue.  
  
## Example  
 [!code-csharp[WindowsAzure#PersistentQueueListener](../snippets/csharp/CRMV8/windowsazure/cs/persistentqueuelistener.cs#persistentqueuelistener)]  
  
### See also  
 [Write a Listener for a Microsoft Azure Solution](write-listener-application-azure-solution.md)   
 [Sample Code for Dynamics 365 Customer Engagement (on-premises) and Microsoft Azure Integration](sample-code-azure-integration.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]