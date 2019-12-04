---
title: "Sample: Bulk delete exported records (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Sample demonstrates how to perform a bulk deletion of records that were previously exported by using the Export-to-Excel option."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: d5483d27-ee03-428f-ad70-2765765ae262
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - deleting data in bulk in Microsoft Dynamics CRM, sample for performing a bulk deletion of exported records
  - performing a bulk deletion of exported records sample
  - sample for performing a bulk deletion of exported records
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Bulk delete exported records

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with deleting data in bulk](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BulkDelete).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to perform a *bulk deletion* of records that were previously exported from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] by using the **Export to Excel** option.  
  
## Example  
 [!code-csharp[BulkDelete#BulkDeleteBackup](../snippets/csharp/CRMV8/bulkdelete/cs/bulkdeletebackup.cs#bulkdeletebackup)]  
  
### See also  
 [Delete Data in Bulk in Dynamics 365 Customer Engagement (on-premises)](delete-data-bulk.md)   
 [Run Bulk Delete](run-bulk-delete.md)   
 <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest>   
 [Recurrence Pattern in Asynchronous Job Execution](recurrence-pattern-asynchronous-job-execution.md)   
 [Sample: Bulk Delete Records That Match Common Criteria](sample-bulk-delete-records-match-common-criteria.md)
