---
title: "Sample: Release a queue item to the queue (early bound) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
decription: The sample code demonstrates how to use ReleaseToQueueRequest to dissociate a user from a queue item release a queue item back to the queue.
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
  - dissociating users from queue items and returning items to queues, sample
  - releasing queue items back to queues (early bound), sample
  - sample for releasing queue items back to queues (early bound)
ms.assetid: 87c72e1e-3ea8-4c54-8eb2-e7fbc19ff629
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Release a queue item to the queue (early bound)

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Business Management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to use <xref:Microsoft.Crm.Sdk.Messages.ReleaseToQueueRequest> to dissociate a user from a queue item that he or she worked on and release a queue item back to the queue.  
  
## Example  
 [!code-csharp[BusinessManagement#RemoveQueueItemWorker](../snippets/csharp/CRMV8/businessmanagement/cs/removequeueitemworker.cs#removequeueitemworker)]  
  
### See also  
 [Sample Code for Queue Entities](sample-code-queue-entities.md)   
 [Queue Entities](queue-entities.md)
