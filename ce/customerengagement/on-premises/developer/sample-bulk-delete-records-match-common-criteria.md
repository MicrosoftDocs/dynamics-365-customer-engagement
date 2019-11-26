---
title: "Sample: Bulk delete records that match common criteria (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Sample demonstrates how to delete records, in bulk, that match common criteria."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1e5fb8b0-5938-4af7-a21d-7365b27b6e1e
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - bulk deletion of records that match common criteria sample
  - sample for deleting related records in bulk
  - deleting data in bulk in Microsoft Dynamics CRM, sample for bulk deletion of records that match common criteria
  - deleting data in bulk in Microsoft Dynamics CRM, sample for deleting related records in bulk
  - deleting related records in bulk sample
  - sample for bulk deletion of records that match common criteria
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Bulk delete records that match common criteria

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with deleting data in bulk](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BulkDelete). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to delete records, in bulk, that match common criteria.  
  
## Example  
 [!code-csharp[BulkDelete#BulkDeleteOperations](../snippets/csharp/CRMV8/bulkdelete/cs/bulkdeleteoperations.cs#bulkdeleteoperations)]  
  
### See also  
 [Delete Data in Bulk in Dynamics 365 Customer Engagement (on-premises)](delete-data-bulk.md)   
 [Run Bulk Delete](run-bulk-delete.md)   
 <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest>   
 [Recurrence Pattern in Asynchronous Job Execution](recurrence-pattern-asynchronous-job-execution.md)
