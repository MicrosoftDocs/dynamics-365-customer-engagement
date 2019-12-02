---
title: "Sample: Add a security principal (user or team) to a queue (early bound) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
decription: The sample code demonstrates how to give a user or team access to a queue. The AddPrincipalToQueueRequest adds the specified principal to the list of queue members.
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
  - sample for sharing queues (early bound)
  - giving teams limited access to queues (early bound), sample
  - sharing queues (early bound), sample
  - sample for limiting team access to queues (early bound)
ms.assetid: cd7c39d3-14cb-484a-a1e1-795d9d3d81ff
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Add a security principal (user or team) to a queue (early bound)

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to give a user or team access to a queue. The <xref:Microsoft.Crm.Sdk.Messages.AddPrincipalToQueueRequest> adds the specified principal to the list of queue members. If the passed-in security principal is a team each member of the team is added to the queue.  
  
## Example  
 [!code-csharp[BusinessManagement#AddPrincipalToQueue](../snippets/csharp/CRMV8/businessmanagement/cs/addprincipaltoqueue.cs#addprincipaltoqueue)]  
  
### See also  
  
 [Sample Code for Queue Entities](sample-code-queue-entities.md)   
 [Queue Entities](queue-entities.md)
