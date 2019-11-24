---
title: "Sample: Send bulk email and monitor results (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to send bulk email using the SendBulkMailRequest and monitor the results by retrieving records from the AsyncOperation entity"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1caed83f-a80f-4abe-8f03-b1c79cc84051
caps.latest.revision: 14
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Send bulk email and monitor results

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Activity entities](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Activities).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to send bulk email using the <xref:Microsoft.Crm.Sdk.Messages.SendBulkMailRequest> and monitor the results by retrieving records from the `AsyncOperation` entity.  
  
## Example  
 [!code-csharp[Activities#SendBulkEmailAndMonitor](../snippets/csharp/CRMV8/activities/cs/sendbulkemailandmonitor.cs#sendbulkemailandmonitor)]  
  
### See also  
 [Email (E-mail) Activity Entities](email-activity-entities.md)   
 [Sample Code for Activity Entities](sample-code-activity-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.SendBulkMailRequest>
