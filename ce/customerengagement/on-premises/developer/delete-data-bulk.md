---
title: "Delete data in bulk (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Helps maintain data quality and manage the consumption of system storage by deleting data that is no longer needed."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: nabuthuk
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - bulk delete
  - deleting data in bulk in Microsoft Dynamics CRM, about the bulk deletion feature
  - deleting data in bulk in Microsoft Dynamics CRM, how the bulk deletion feature helps you delete multiple topics
  - bulk deletion feature, about
  - deleting data in bulk in Microsoft Dynamics CRM, data cleanup (periodic and scheduled)
  - deleting data in bulk in Microsoft Dynamics CRM, tasks for using bulk deletion
  - deleting data in bulk in Microsoft Dynamics CRM, failure log
  - bulk deletion
  - deleting data in bulk in Microsoft Dynamics CRM, email notifications
ms.assetid: 67a3a031-4edf-49de-983b-ba9902223278
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Delete data in bulk

The *bulk deletion* feature helps you to maintain data quality and manage the consumption of system storage in Dynamics 365 Customer Engagement (on-premises) by deleting data that you no longer need.  
  
 For example, you can delete the following data in bulk:  
  
- Stale data.  
  
- Data that is irrelevant to the business.  
  
- Unneeded test or sample data.  
  
- Data that is incorrectly imported from other systems.  
  
  With bulk deletion you can perform the following operations:  
  
- Delete data across multiple entities.  
  
- Delete records for a specified entity.  
  
- Receive email notifications when a bulk deletion finishes.  
  
- Delete data periodically.  
  
- Schedule the start time of a recurring bulk delete.  
  
- Retrieve the information about the failures that occurred during a bulk deletion.  
  
## Run bulk delete

To delete data in bulk, you have to submit a bulk delete job by using the BulkDeleteRequest message. The bulk delete job runs asynchronously in the background without blocking other activities. The query expressions that describe the records on which to run the bulk delete job are specified in the QuerySet property of this request. To learn more, see [Running Bulk Delete](/powerapps/developer/common-data-service/delete-data-bulk#run-bulk-delete) in the Dataverse documentation.
  
 <!--[BulkDeleteOperation Entity](entities/bulkdeleteoperation.md)  
  
 [BulkDeleteFailure Entity](entities/bulkdeletefailure.md)-->
  
## Related Sections  

 [Data Management](manage-data.md)  
  
 [Import data](import-data.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]