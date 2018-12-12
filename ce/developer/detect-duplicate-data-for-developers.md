---
title: "Detect duplicate data for developers (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Overview of the duplicate detection capabilities, including detection policies and duplicate detection rules for entity types."
ms.custom: 
ms.date: 07/02/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 872b735a-9c80-4e4e-8c04-61f8ce6836df
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Detect duplicate data for developers

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

> [!NOTE]
> For information on how to create rules and run system jobs for detecting duplicate data using the Dynamics 365 for Customer Engagement apps user interface(UI), see [Detect duplicate data so you can fix or remove it](../admin/detect-duplicate-data.md).

Duplicate detection lets organizations set duplicate detection policies and create duplicate detection rules for business and custom entities. These rules can be applied across different record types in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] apps. For example, an organization may define that a lead is a duplicate of a contact, if they have the same name and phone number. Based on the duplicate detection rules set by the administrator, the system alerts the user about potential duplicates when the user tries to create new records or update existing records. To maintain data quality, you can schedule a duplicate detection job to check for duplicates for all records that match a certain criteria. You can clean the data by deleting, deactivating, or merging the duplicates reported by a duplicate detection job.  
  
 To detect duplicates in the system, create a *duplicate detection rule* for a specific entity type. A duplicate detection rule is represented by the duplicate rule [DuplicateRule entity](entities/duplicaterule.md). You can create multiple detection rules for the same entity type. However, you can publish a maximum of five duplicate detection rules per entity type at one time.  
  
 A rule can have one or more *duplicate detection rule conditions* that are represented by the duplicate rule condition [DuplicateRuleCondition entity](entities/duplicaterulecondition.md). The conditions are combined by the system as in logical `AND` operation. A duplicate detection rule specifies a base entity type and a matching entity type. A duplicate rule condition specifies the name of a base attribute and the name of a matching attribute. For example, specify an account as a base entity and a contact as a matching entity to compare last names and addresses. The matching criteria consist of operators such as exactly match, first n-number of characters, or last n-number of characters.  

 Duplicate detection works by comparing generated match codes of existing records with each new record being created. These match codes are created as each new record is created. Therefore, there is potential for one or more duplicate records to be created if they are processed at the exact same moment. In addition to detecting duplicates as they are created, you should schedule duplicate detection jobs to check for other potential duplicate records.

  
> [!IMPORTANT]
>  Take special precautions when you create duplicate detection rules for appointments. The recurring appointment master and the recurring appointment records share some of the same attribute values, such as subject, location, and regarding object. Using any of these attributes as a duplicate detection rule condition [DuplicateRuleCondition entity](entities/duplicaterulecondition.md), may result in incorrectly marking recurring appointment records as duplicates. To avoid this, also include a start time attribute as a duplicate detection rule condition. For more information about working with recurring appointments, see [Working with Schedules and Appointments](schedule-appointment-entities.md).  
  
 The duplicate detection rules are system-wide. You must publish them before running a duplicate detection job to detect duplicates for bulk data or retrieve duplicates for a particular entity record. To publish a duplicate detection rule, use the `PublishDuplicateRule` message(<xref href="Microsoft.Dynamics.CRM.PublishDuplicateRule?text=PublishDuplicateRule Action" /> or <xref:Microsoft.Crm.Sdk.Messages.PublishDuplicateRuleRequest>). Duplicate rule publishing is an asynchronous operation that runs in the background.  
  
## In This Section  

 [Enable and Disable Duplicate Detection](enable-disable-duplicate-detection.md)<br />
 [Run Duplicate Detection](run-duplicate-detection.md)<br />
 [Manage duplicate detection during Create and Update operations](duplicate-detection-create-update.md)<br />
 [Duplicate Detection Messages](duplicate-detection-messages.md)<br />
 [Duplicate Rule entities](duplicaterule-entities.md)<br />
 [DuplicateRule Entity](entities/duplicaterule.md)<br />
 [DuplicateRuleCondition Entity](entities/duplicaterulecondition.md)<br />
 [DuplicateRecord Entity](entities/duplicaterecord.md)<br />
  
## Related Sections  
 [Data Management in Dynamics 365 for Customer Engagement apps (Auditing, Duplicate Detection, Bulk Delete, Data Import)](manage-data.md)  
 [Delete data in bulk](delete-data-bulk.md)

## See Also

[Sample: Enable Duplicate Detection and Retrieve Duplicates](org-service/sample-enable-duplicate-detection-and-retrieve-duplicates.md)<br />
[Sample: Invoke Duplicate Detection For Creating and Updating Records](org-service/sample-use-duplicate-detection-when-creating-and-updating-records.md)<br />
[Sample: Detect Multiple Duplicate Records](org-service/sample-detect-multiple-duplicate-records.md)<br />
 
