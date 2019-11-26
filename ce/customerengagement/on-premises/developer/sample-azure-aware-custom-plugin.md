---
title: "Sample: Azure aware custom plug-in (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The plug-in demonstrates how to obtain the execution context and the tracing service from the service provider parameter of the Execute method. The plug-in then posts the context to the Azure Service Bus endpoint and writes information to the trace log to facilitate debugging."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - azure
ms.assetid: 3a1fcf7e-1e86-4d55-b11f-38ee179b9f1d
caps.latest.revision: 23
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Azure aware custom plug-in

This is a sample custom plug-in that can post the pipeline execution context to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)].  
  
 This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with Microsoft Dynamics 365 Customer Engagement (on-premises) and Azure Integration](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Azure) 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 The plug-in demonstrates how to obtain the execution context and the tracing service from the service provider parameter of the `Execute` method. The plug-in then posts the context to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)] endpoint and writes information to the trace log to facilitate debugging.  
  
## Example  
 [!code-csharp[WindowsAzure#SandboxPlugin](../snippets/csharp/CRMV8/windowsazure/cs/sandboxplugin.cs#sandboxplugin)]  
  
### See also  
 [Sample Code for Dynamics 365 Customer Engagement (on-premises) and Microsoft Azure Integration](sample-code-azure-integration.md)   
 [Sample: Azure Aware Custom Workflow Activity](sample-azure-aware-custom-workflow-activity.md)   
 <xref:Microsoft.Xrm.Sdk.IPlugin>   
 <xref:Microsoft.Xrm.Sdk.IPluginExecutionContext>   
 <xref:Microsoft.Xrm.Sdk.ITracingService>   
 [Write a plug-in](/powerapps/developer/common-data-service/write-plug-in) 
