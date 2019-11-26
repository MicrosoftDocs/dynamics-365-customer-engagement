---
title: "Sample: Add a record to a queue (early bound) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
decription: The sample code demonstrates how to add a record to a queue, and creates source and destination queues.
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
  - adding records to queues (early bound), sample
  - sample for adding records to queues (early bound)
ms.assetid: 250690a7-854d-4a69-adb9-d621834344fa
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Add a record to a queue (early bound)

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to add a record to a queue. It creates source and destination queues. It adds a letter activity to the source queue and then moves it to the destination queue.  
  
## Example  
 [!code-csharp[BusinessManagement#AddToQueue](../snippets/csharp/CRMV8/businessmanagement/cs/addtoqueue.cs#addtoqueue)]  
  
### See also  
 [Sample Code for Queue Entities](sample-code-queue-entities.md)   
 [Queue Entities](queue-entities.md)   
 [Sample: Clean Up History for a Queue (Early Bound)](sample-clean-up-history-queue-early-bound.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AddToQueueRequest>
