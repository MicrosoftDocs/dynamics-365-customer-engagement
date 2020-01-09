---
title: "Sample: Create a process using a template (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "This sample demonstrates how to create a workflow process using a template using the CreateWorkflowFromTemplateRequest"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
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

This sample code is for Dynamics 365 Customer Engagement (on-premises). Download the sample: [Work with workflows](hhttps://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Workflows).

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
 [Processes in Dynamics 365 Customer Engagement (on-premises)(formerly Workflows)](automate-business-processes-customer-engagement.md)   
 <xref:Microsoft.Crm.Sdk.Messages.CreateWorkflowFromTemplateRequest>
