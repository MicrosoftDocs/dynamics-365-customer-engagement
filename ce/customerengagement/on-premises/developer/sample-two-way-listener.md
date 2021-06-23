---
title: "Sample: Two-way listener (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample shows how to write a Azure Service Bus Listener for a two-way endpoint contract. "
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
ms.assetid: 6acfffff-0045-4a1c-a3d2-9906dd93845d
caps.latest.revision: 26
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Two-way listener

This sample registers a remote service plug-in that executes whenever a Dynamics 365 Customer Engagement (on-premises) message is posted to a two-way endpoint on the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. When the plug-in executes, it prints to the console the contents of the Dynamics 365 Customer Engagement (on-premises) execution context contained in the message. 
Download the sample: [Work with Microsoft Dynamics 365 Customer Engagement (on-premises) and Azure Integration](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Azure) 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. 
  
## Demonstrates  
 This sample shows how to write a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] Listener for a two-way endpoint contract.  
  
## Example  
 [!code-csharp[WindowsAzure#TwoWayListener](../snippets/csharp/CRMV8/windowsazure/cs/twowaylistener.cs#twowaylistener)]  
  
### See also  
 [Azure Extentions for Dynamics 365 Customer Engagement (on-premises)](azure-extensions.md)   
 [Sample Code for Dynamics 365 Customer Engagement (on-premises) and Microsoft Azure Integration](sample-code-azure-integration.md)   
 [Sample: REST Listener](sample-rest-listener.md)   
 <xref:Microsoft.Xrm.Sdk.ITwoWayServiceEndpointPlugin>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]