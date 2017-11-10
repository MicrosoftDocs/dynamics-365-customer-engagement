---
title: "Sample: Bulk delete exported records (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to perform a bulk deletion of records that were previously exported by using the Export-to-Excel option."
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: d5483d27-ee03-428f-ad70-2765765ae262
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - "deleting data in bulk in Microsoft Dynamics CRM, sample for performing a bulk deletion of exported records"
  - "performing a bulk deletion of exported records sample"
  - "sample for performing a bulk deletion of exported records"
topic-status: Drafting
---

# Sample: Bulk delete exported records

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the delete data in bulk sample](https://code.msdn.microsoft.com/Samples-of-delete-data-in-722dd420).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to perform a *bulk deletion* of records that were previously exported from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] by using the **Export to Excel** option.  
  
## Example  
 [!code-csharp[BulkDelete#BulkDeleteBackup](../snippets/csharp/CRMV8/bulkdelete/cs/bulkdeletebackup.cs#bulkdeletebackup)]  
  
### See also  
 [Delete Data in Bulk in Dynamics 365](delete-data-bulk.md)   
 [Run Bulk Delete](run-bulk-delete.md)   
 <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest>   
 [Recurrence Pattern in Asynchronous Job Execution](recurrence-pattern-asynchronous-job-execution.md)   
 [Sample: Bulk Delete Records That Match Common Criteria](sample-bulk-delete-records-match-common-criteria.md)
