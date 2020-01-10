---
title: "Sample: Clean up history for a queue (early bound) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
decription: The sample code demonstrates how to clean up the history for the queue using RemoveFromQueueRequest with inactive items.
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
  - cleaning up history in queues (early bound), sample
  - sample for deleting inactive items from queues (early bound)
  - sample for cleaning up history in queues (early bound)
  - deleting inactive items from queues (early bound), sample
ms.assetid: 81d686b0-7c5d-45e5-b2df-b74b0413bf6b
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Clean up history for a queue (early bound)

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement)   

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to clean up the history for the queue by using <xref:Microsoft.Crm.Sdk.Messages.RemoveFromQueueRequest> with inactive items. It finds completed phone calls in the queue and removes the associated queue items.  
  
## Example  
 [!code-csharp[BusinessManagement#CleanUpQueueItems](../snippets/csharp/CRMV8/businessmanagement/cs/cleanupqueueitems.cs#cleanupqueueitems)]  
  
### See also  
 [Sample Code for Queue Entities](sample-code-queue-entities.md)   
 [Queue Entities](queue-entities.md)   
 [Sample: Specify a Queue Item to Work On (Early Bound)](sample-specify-queue-item-work-early-bound.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AddToQueueRequest>
