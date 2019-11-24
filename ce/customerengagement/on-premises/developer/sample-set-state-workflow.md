---
title: "Sample: Set the state of a workflow (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample shows how to change the state of a workflow, through activating and deactivating it, by using the SetStateRequest message. In addition, the sample shows how to create a custom XAML workflow. A snippet showing just the key sections of the sample is shown first, followed by the Complete Sample Code. "
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 68a5e1da-7432-4520-a9df-72372ddb8a20
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 21
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Set the state of a workflow

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with workflows](hhttps://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Workflows).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to change the state of a workflow, through activating and deactivating it, by using the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message. In addition, the sample shows how to create a custom XAML workflow. A snippet showing just the key sections of the sample is shown first, followed by the [Complete Sample Code](sample-set-state-workflow.md#complete_sample).  
  
## Example  
 Code snippet that shows how to activate and deactivate a workflow.  
  
 [!code-csharp[Workflows#SetStateWorkflow1](../snippets/csharp/CRMV8/workflows/cs/setstateworkflow1.cs#setstateworkflow1)]  
[!code-csharp[Workflows#SetStateWorkflow2](../snippets/csharp/CRMV8/workflows/cs/setstateworkflow2.cs#setstateworkflow2)]  
  
## Example  
 Code snippet that shows how to create a XAML workflow.  
  
 [!code-csharp[Workflows#SetStateWorkflow3](../snippets/csharp/CRMV8/workflows/cs/setstateworkflow3.cs#setstateworkflow3)]  
  
 For the XAML code that defines the workflow, see the [Complete Sample Code](sample-set-state-workflow.md#complete_sample).  
  
<a name="complete_sample"></a>   
## Complete Sample Code  
 [!code-csharp[Workflows#SetStateWorkflow](../snippets/csharp/CRMV8/workflows/cs/setstateworkflow.cs#setstateworkflow)]  
  
### See also  
 [Sample code for workflows](sample-code-processes.md)   
 [Processes in Dynamics 365 Customer Engagement (on-premises)(formerly Workflows)](automate-business-processes-customer-engagement.md)      
 <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
