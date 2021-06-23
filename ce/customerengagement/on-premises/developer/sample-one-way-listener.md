---
title: "Sample: One-way listener (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample shows how to write a Azure Service Bus listener for a one-way endpoint contract. "
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
ms.assetid: 643ea291-1830-4448-b9bf-26744077721a
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: One-way listener

This sample listener application registers a remote service plug-in that executes whenever a Dynamics 365 Customer Engagement (on-premises) message is posted to a one-way endpoint on the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. When the plug-in executes, it outputs to the console the contents of the Dynamics 365 Customer Engagement (on-premises) execution context contained in the message. 
Download the sample: [Work with Microsoft Dynamics 365 Customer Engagement and Azure Integration](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Azure)

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] and [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. 
  
## Demonstrates  
 This sample shows how to write a [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] listener for a one-way endpoint contract.  
  
## Example  
 [!code-csharp[WindowsAzure#OneWayListener](../snippets/csharp/CRMV8/windowsazure/cs/onewaylistener.cs#onewaylistener)]  
  
### See also  
 [Sample Code for Dynamics 365 Customer Engagement (on-premises) and Microsoft Azure Integration](sample-code-azure-integration.md)   
 [Sample: Two-way Listener](sample-two-way-listener.md)   
 [Write a One-way, Two-way, or REST Listener](write-listener-application-azure-solution.md#bkmk_writeoneway)   
 <xref:Microsoft.Xrm.Sdk.IServiceEndpointPlugin>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]