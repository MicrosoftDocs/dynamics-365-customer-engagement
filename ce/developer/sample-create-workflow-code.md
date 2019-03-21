---
title: "Sample: Create a workflow in code (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
descrption: The sample shows how to programmatically create an asynchronous workflow in code instead of using a workflow editor or designer. This sample works only with an on-premises deployment of Dynamics 365 for Customer Engagement (online) because custom XAML workflows are not supported in Dynamics 365 for Customer Engagement (online). 
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
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

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] for Customer Engagement apps. Download the sample: [Work with workflows](https://code.msdn.microsoft.com/Work-with-workflows-edf8f3bf).

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
 [Processes in Dynamics 365 for Customer Engagement apps(formerly Workflows)](automate-business-processes-customer-engagement.md)   
 [Workflow and Process Entities](workflow-process-entities.md)
