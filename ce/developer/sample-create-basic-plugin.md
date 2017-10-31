---
title: "Sample: Create a basic plug-in (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to write a basic plug-in that can access the Dynamics 365 organization Web service. "
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 40a9c015-696f-43e4-9b4d-209fe7b8ace6
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 16
topic-status: Drafting
---

# Sample: Create a basic plug-in

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement. [Download the work with plug-ins sample](https://code.msdn.microsoft.com/Sample-Create-a-basic-plug-64d86ade).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 Register this plug-in for an account entity, on the Create message, and in asynchronous mode. Alternately, you can register the plug-in on a post-event in the sandbox.  
  
## Demonstrates  
 This sample shows how to write a basic plug-in that can access the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] organization Web service.  
  
 The plug-in creates a task activity after a new account is created. The activity reminds the user to follow-up with the new account customer one week after the account was created.  
  
## Example  
 [!code-csharp[Plug-ins#FollowupPlugin](../snippets/csharp/CRMV8/plug-ins/cs/followupplugin.cs#followupplugin)]  
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Sample: Web Access from a Sandboxed Plug-in](sample-web-access-sandboxed-plugin.md)   
 [Write a Plug-in](write-plugin.md)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)   
 [Event Execution Pipeline](event-execution-pipeline.md)   
 <xref:Microsoft.Xrm.Sdk.IPlugin>   
 <xref:Microsoft.Xrm.Sdk.IPluginExecutionContext>   
 <xref:Microsoft.Xrm.Sdk.ITracingService>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationServiceFactory>