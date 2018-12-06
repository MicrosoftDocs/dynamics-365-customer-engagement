---
title: "Sample: Create a process using a template (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "This sample demonstrates how to create a workflow process using a template using the CreateWorkflowFromTemplateRequest"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 5c7f045f-7b57-4e44-a99c-becefe533035
caps.latest.revision: 20
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create a process using a template

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] for Customer Engagement apps. Download the sample: [Work with workflows](https://code.msdn.microsoft.com/Work-with-workflows-edf8f3bf).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 The following code example demonstrates how to create a workflow process using a template using the <xref:Microsoft.Crm.Sdk.Messages.CreateWorkflowFromTemplateRequest>.  
  
## Example  
 [!code-csharp[Workflows#CreateProcessFromTemplate](../snippets/csharp/CRMV8/workflows/cs/createprocessfromtemplate.cs#createprocessfromtemplate)]  
  
### See also  
 [Sample Code for Processes](sample-code-processes.md)   
 [Sample: Execute a Workflow](sample-run-workflow.md)   
 [Processes in Dynamics 365 for Customer Engagement apps(formerly Workflows)](automate-business-processes-customer-engagement.md)   
 <xref:Microsoft.Crm.Sdk.Messages.CreateWorkflowFromTemplateRequest>
