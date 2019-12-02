---
title: "Sample: Create a workflow in code (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
descrption: The sample shows how to programmatically create an asynchronous workflow in code instead of using a workflow editor or designer. This sample works only with an on-premises deployment of Dynamics 365 Customer Engagement (on-premises) because custom XAML workflows are not supported in Dynamics 365 Customer Engagement (on-premises). 
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 7105761b-9710-4ad1-a3ee-b7dd58287c81
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create a workflow in code

This sample code is for Dynamics 365 Customer Engagement (on-premises). Download the sample: [Work with workflows](hhttps://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Workflows).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 You must enable support for custom XAML workflows on your on-premises server. [!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]  
  
## Demonstrates  
 The following sample shows how to programmatically create an asynchronous workflow in code instead of using a workflow editor or designer. This sample works only with an on-premises deployment of [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] because custom XAML workflows are not supported in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]
## Example  
 [!code-csharp[Workflows#CreateAWorkflow](../snippets/csharp/CRMV8/workflows/cs/createaworkflow.cs#createaworkflow)]  
  
### See also  
 [Sample code for workflows](sample-code-processes.md)   
 [Sample: Create a real-time workflow in code](sample-create-real-time-workflow-code.md)   
 [Processes in Dynamics 365 Customer Engagement (on-premises)(formerly Workflows)](automate-business-processes-customer-engagement.md)   
 [Workflow and Process Entities](workflow-process-entities.md)
