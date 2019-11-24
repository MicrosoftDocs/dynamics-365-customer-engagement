---
title: "Sample: Specify a queue item to work on (early bound) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
decription: The sample code demonstrates how to use PickFromQueueRequest to specify a user who will work on a queue item.
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
  - sample for specifying queue items for users to work on (early bound)
  - specifying queue items for users to work on (early bound), sample
ms.assetid: be171519-f8d0-43e6-b5a7-770802da47db
caps.latest.revision: 18
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Specify a queue item to work on (early bound)

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Business Management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement) 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to use <xref:Microsoft.Crm.Sdk.Messages.PickFromQueueRequest> to specify a user who will work on a queue item.  
  
## Example  
 [!code-csharp[BusinessManagement#AssignQueueItemWorker](../snippets/csharp/CRMV8/businessmanagement/cs/assignqueueitemworker.cs#assignqueueitemworker)]  
  
### See also  
 [Sample Code for Queue Entities](sample-code-queue-entities.md)   
 [Queue Entities](queue-entities.md)   
 [Sample: Release a Queue Item to the Queue Using (Early Bound)](sample-release-queue-item-queue-early-bound.md)
