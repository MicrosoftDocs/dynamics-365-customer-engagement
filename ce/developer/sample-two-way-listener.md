---
title: "Sample: Two-way listener (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "The sample shows how to write a Azure Service Bus Listener for a two-way endpoint contract. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
helpviewer_keywords: 
  - azure
ms.assetid: 6acfffff-0045-4a1c-a3d2-9906dd93845d
caps.latest.revision: 26
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Two-way listener

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample registers a remote service plug-in that executes whenever a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement message is posted to a two-way endpoint on the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. When the plug-in executes, it prints to the console the contents of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] execution context contained in the message. 
Download the sample: [Work with Microsoft Dynamics 365 for Customer Engagement apps and Azure Integration](https://code.msdn.microsoft.com/Sample-Dynamics-365-and-6a95df2a) 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. 
  
## Demonstrates  
 This sample shows how to write a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] Listener for a two-way endpoint contract.  
  
## Example  
 [!code-csharp[WindowsAzure#TwoWayListener](../snippets/csharp/CRMV8/windowsazure/cs/twowaylistener.cs#twowaylistener)]  
  
### See also  
 [Azure Extentions for Dynamics 365 for Customer Engagement apps](azure-extensions.md)   
 [Sample Code for Dynamics 365 for Customer Engagement apps and Microsoft Azure Integration](sample-code-azure-integration.md)   
 [Sample: REST Listener](sample-rest-listener.md)   
 <xref:Microsoft.Xrm.Sdk.ITwoWayServiceEndpointPlugin>
