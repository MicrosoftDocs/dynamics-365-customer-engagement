---
title: "Retrieve and delete the history of audited data changes (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Programmatically retrieve the audit change history or delete audit records."
ms.custom: audit
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - retrieving and deleting changed-data history (audit history), new partitions created quarterly
  - partitions created quarterly for auditing, used by Microsoft Dynamics 365 and SQL Server with auditing
  - retrieving and deleting changed-data history (audit history), obtaining a list of partitions
  - obtaining changed-data history
  - audit records and history, retrieving and deleting data for
  - deleting audit records, using Microsoft Dynamics 365 and SQL Server with auditing
  - changed-data history, obtaining
  - deleting change history (audit records), how to
ms.assetid: 53b9a1ac-f9c0-490f-a42f-2efc231b67ff
caps.latest.revision: 20
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Retrieve and delete the history of audited data changes

After auditing is enabled and data changes are made to those entities and attributes being audited, you can proceed to obtain the data change history. Optionally, you can delete the audit records after you review the change history. Follow the sample code link at the end of this topic for more information.  
  
## Retrieve the change history 
 
 There are several messages requests that can be used to retrieve the audit change history. These requests are differentiated by the nature of what they retrieve. 
<!-- Bug 696490 should make the Audit entity public again: Refer to the topic  [Audit Entity](entities/audit.md) for a list of message requests related to auditing. -->
Refer to the sample link at the end of this topic for sample code that demonstrates some of these change history message requests.

## Delete the change history for a record
 
 Use the <xref:Microsoft.Crm.Sdk.Messages.DeleteRecordChangeHistoryRequest> message to delete all the audit change history records for a particular record. This lets you delete the audit change history for a record instead of deleting all the audit records for a date range, which is covered in the next section. To delete the audit change history for a record, you must have a security role with the **prvDeleteRecordChangeHistory** privilege or be a System Administrator.

## Delete the change history for a date range

 You can delete `audit` records for a date range using the <xref:Microsoft.Crm.Sdk.Messages.DeleteAuditDataRequest> request. Audit data records are deleted sequentially from the oldest to the newest. The functionality of this request is slightly different based on the edition of [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] being used by your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server. [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] uses an enterprise edition of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].

 If your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server uses [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] standard edition, which does not support the database partitioning feature, the <xref:Microsoft.Crm.Sdk.Messages.DeleteAuditDataRequest> request deletes all audit records created up to the end date specified in the <xref:Microsoft.Crm.Sdk.Messages.DeleteAuditDataRequest.EndDate> property.

 If your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server uses an Enterprise edition of [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] that does support partitioning, the <xref:Microsoft.Crm.Sdk.Messages.DeleteAuditDataRequest> request will delete all audit data in those partitions where the end date is before the date specified in the <xref:Microsoft.Crm.Sdk.Messages.DeleteAuditDataRequest.EndDate> property. Any empty partitions are also deleted. However, neither the current (active) partition nor the `audit` records in that active partition can be deleted by using this request or any other request.

 New partitions are automatically created by the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] platform on a quarterly basis each year. This functionality is non-configurable and cannot be changed. You can obtain the list of partitions using the <xref:Microsoft.Crm.Sdk.Messages.RetrieveAuditPartitionListRequest> request. If the end date of any partition is later than the current date, you cannot delete that partition or any `audit` records in it.  

### See also

 [Data Management in Dynamics 365 Customer Engagement (on-premises)](manage-data.md)<br />
 [Audit entity data changes](audit-entity-data-changes.md)<br />
 [Audit user access](audit-user-access.md) <br />
 [Sample: Audit Entity Data Changes](sample-audit-entity-data-changes.md)<br />
<!-- Bug 696490 should make the Audit entity public again: [Audit Entity](entities/audit.md)<br /> -->
 [Auditing Entity Data Changes in Dynamics 365 Customer Engagement (on-premises)](audit-entity-data-changes.md)<br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]