---
title: "Sample: Create a real-time workflow in code (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows you how to create a real-time workflow in code instead of using the interactive workflow designer in the web application. This sample works only with an on-premises or an Internet-facing deployment (IFD) of Dynamics 365 because custom XAML workflows aren’t supported in Dynamics 365 (online). "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 78a964e8-0f5a-4075-8d22-32b984e3c0c3
caps.latest.revision: 16
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Create a real-time workflow in code

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code applies to on–premises [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the sample: [Work with workflows](https://code.msdn.microsoft.com/Work-with-workflows-edf8f3bf).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 You must enable support for custom XAML workflows on your on-premises server. [!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]  
  
## Demonstrates  
 The following sample shows you how to create a real-time workflow in code instead of using the interactive workflow designer in the web application. This sample works only with an on-premises or an Internet-facing deployment (IFD) of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] because custom XAML workflows aren’t supported in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
 [!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]
## Example  
 [!code-csharp[Workflows#CreateRealtimeWorkflow](../snippets/csharp/CRMV8/workflows/cs/createrealtimeworkflow.cs#createrealtimeworkflow)]  
  
### See also  
 [Create real-time workflows](create-real-time-workflows.md)   
 [Sample: Set the State of a Workflow](sample-set-state-workflow.md)   
 [Workflow and Process Entities](workflow-process-entities.md)   
 [Processes in Dynamics 365 (formerly Workflows)](automate-business-processes-customer-engagement.md)
