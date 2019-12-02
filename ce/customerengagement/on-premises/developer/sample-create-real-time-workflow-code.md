---
title: "Sample: Create a real-time workflow in code (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample shows you how to create a real-time workflow in code instead of using the interactive workflow designer in the web application. This sample works only with an on-premises or an Internet-facing deployment (IFD) of Dynamics 365 Customer Engagement because custom XAML workflows aren’t supported in Dynamics 365 Customer Engagement (on-premises). "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 78a964e8-0f5a-4075-8d22-32b984e3c0c3
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create a real-time workflow in code

This sample code applies to Dynamics 365 Customer Engagement (on-premises). Download the sample: [Work with workflows](hhttps://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Workflows).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 You must enable support for custom XAML workflows on your on-premises server. [!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]  
  
## Demonstrates  
 The following sample shows you how to create a real-time workflow in code instead of using the interactive workflow designer in the web application. 
  
 [!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

## Example  
 [!code-csharp[Workflows#CreateRealtimeWorkflow](../snippets/csharp/CRMV8/workflows/cs/createrealtimeworkflow.cs#createrealtimeworkflow)]  
  
### See also  
 [Create real-time workflows](create-real-time-workflows.md)   
 [Sample: Set the State of a Workflow](sample-set-state-workflow.md)   
 [Workflow and Process Entities](workflow-process-entities.md)   
 [Processes in Dynamics 365 Customer Engagement (on-premises)(formerly Workflows)](automate-business-processes-customer-engagement.md)
