---
title: "Run bulk delete (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Delete data in bulk by submitting an asynchronous bulk delete job via the BulkDeleteRequest message."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - running bulk delete, submitting a bulk delete job by using the BulkDeleteRequest message
  - running bulk delete, using query expressions to describe the records to delete
  - using query expressions to describe the records to delete
  - bulk deletion operation entity, running bulk delete
  - BulkDeleteRequest message, see 'deleting data in bulk in Microsoft Dynamics CRM'
  - running bulk delete, running asynchronously without blocking other activities
  - bulk delete operation records, items returned in
  - submitting a bulk delete job by using the BulkDeleteRequest message, see 'deleting data in bulk in Microsoft Dynamics CRM'
  - running bulk delete, required privileges
  - running bulk delete, supported entities
  - running bulk delete, bulk deletion operation entity
ms.assetid: e4ea7edd-d1f2-4fca-bb80-bebf0a910643
caps.latest.revision: 30
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Run bulk delete

To delete data in bulk, you have to submit a bulk delete job by using the <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest> message. The bulk delete job runs asynchronously in the background without blocking other activities. The query expressions that describe the records on which to run the bulk delete job are specified in the <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest.QuerySet> property of this request.  
  
 A bulk delete job is represented by the bulk delete operation entity. The schema name for this entity is `BulkDeleteOperation`. A bulk delete operation record includes the following information:  
  
- Number of records that the bulk delete job deleted.  
  
- Number of records that the bulk delete job failed to delete.  
  
- Whether the bulk delete job is a recurring job or not.  
  
- Start time of the bulk delete job.  
  
  A bulk delete job only deletes records that are created before the job starts to run.  
  
> [!NOTE]
>  If a bulk delete job fails or ends prematurely, any records that were deleted before the failure or ending of the job are not rolled back and remain deleted. The failures of the `BulkDeleteOperation` are stored in the `BulkDeleteFailure` records and can be retrieved by using the          <xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> message or the  <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> message.  
  
 A bulk delete job deletes the specified records according to the cascading rules. These rules are based on the relationship type between the entities. For more information, see [Entity Relationship Behavior](entity-relationship-behavior.md).  
  
 To run a bulk delete job, a user must have the `BulkDelete` and `Delete` privileges for the entity types being deleted. The user must also have read permissions to the entity records that are specified in the <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest> message. By default, a system administrator has the necessary permissions; however, other users must be granted these permissions.  
  
 You can perform a bulk deletion on all entities that are supported by the delete action. For information about possible actions on entity records, see [Actions on Entity Records](introduction-entities.md#ActionsOnEntityRecords).  
  
 If a plug-in or a workflow (process) is triggered by the delete action on a specific entity type, it is triggered every time that an entity record of this type is deleted by the bulk delete job.  
  
### See also

 [Delete Data in Bulk in Dynamics 365 Customer Engagement (on-premises)](delete-data-bulk.md)   
 [Data Management in Dynamics 365 Customer Engagement (on-premises) (Auditing, Duplicate Detection, Bulk Delete, Data Import)](manage-data.md)    
 [Entity Relationship Behavior](entity-relationship-behavior.md)   
 [Recurrence Pattern in Asynchronous Job Execution](recurrence-pattern-asynchronous-job-execution.md)   
 [Sample: Bulk Delete Exported Records](sample-bulk-delete-exported-records.md)   
 [Sample: Bulk Delete Records That Match Common Criteria](sample-bulk-delete-records-match-common-criteria.md)   
 [BulkDeleteOperation Entity](entities/bulkdeleteoperation.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]