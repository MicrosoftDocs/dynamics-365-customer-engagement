---
title: "Detect duplicate data for developers (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Overview of the duplicate detection capabilities, including detection policies and duplicate detection rules for entity types."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: nabuthuk
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 872b735a-9c80-4e4e-8c04-61f8ce6836df
author: mayadumesh
ms.author: mayadu
manager: amyla
search.audienceType: 
  - developer

---
# Detect duplicate data for developers

Duplicate detection lets organizations set duplicate detection policies and create duplicate detection rules for business and custom entities. These rules can be applied across different record types in Dynamics 365 Customer Engagement (on-premises). For example, an organization may define that a lead is a duplicate of a contact, if they have the same name and phone number. Based on the duplicate detection rules set by the administrator, the system alerts the user about potential duplicates when the user tries to create new records or update existing records. To maintain data quality, you can schedule a duplicate detection job to check for duplicates for all records that match a certain criteria. You can clean the data by deleting, deactivating, or merging the duplicates reported by a duplicate detection job.  
  
 To detect duplicates in the system, create a *duplicate detection rule* for a specific entity type. A duplicate detection rule is represented by the duplicate rule [DuplicateRule entity](entities/duplicaterule.md). You can create multiple detection rules for the same entity type. However, you can publish a maximum of five duplicate detection rules per entity type at one time.  

> [!NOTE]
> For information on how to create rules and run system jobs for detecting duplicate data using the Dynamics 365 Customer Engagement (on-premises) user interface(UI), see [Detect duplicate data so you can fix or remove it](../admin/detect-duplicate-data.md).

 A rule can have one or more *duplicate detection rule conditions* that are represented by the duplicate rule condition [DuplicateRuleCondition entity](entities/duplicaterulecondition.md). The conditions are combined by the system as in logical `AND` operation. A duplicate detection rule specifies a base entity type and a matching entity type. A duplicate rule condition specifies the name of a base attribute and the name of a matching attribute. For example, specify an account as a base entity and a contact as a matching entity to compare last names and addresses. The matching criteria consist of operators such as exactly match, first n-number of characters, or last n-number of characters.  

 Duplicate detection works by comparing generated match codes of existing records with each new record being created. These match codes are created as each new record is created. Therefore, there is potential for one or more duplicate records to be created if they are processed at the exact same moment. In addition to detecting duplicates as they are created, you should schedule duplicate detection jobs to check for other potential duplicate records.

  
> [!IMPORTANT]
>  Take special precautions when you create duplicate detection rules for appointments. The recurring appointment master and the recurring appointment records share some of the same attribute values, such as subject, location, and regarding object. Using any of these attributes as a duplicate detection rule condition [DuplicateRuleCondition entity](entities/duplicaterulecondition.md), may result in incorrectly marking recurring appointment records as duplicates. To avoid this, also include a start time attribute as a duplicate detection rule condition. For more information about working with recurring appointments, see [Working with Schedules and Appointments](schedule-appointment-entities.md).  
  
 The duplicate detection rules are system-wide. You must publish them before running a duplicate detection job to detect duplicates for bulk data or retrieve duplicates for a particular entity record. To publish a duplicate detection rule, use the `PublishDuplicateRule` message(<xref href="Microsoft.Dynamics.CRM.PublishDuplicateRule?text=PublishDuplicateRule Action" /> or <xref:Microsoft.Crm.Sdk.Messages.PublishDuplicateRuleRequest>). Duplicate rule publishing is an asynchronous operation that runs in the background.  
  
## Enable and Disable Duplicate Detection

This topic covers information on how to enable and disable duplicate detection in Dynamics 365 Customer Engagement (on-premises). To learn more, see [Enable or disable duplicate detection](/powerapps/developer/common-data-service/enable-disable-duplicate-detection) in the Dataverse documentation.

## Run duplicate detection

There are several ways to perform duplicate detection after you enable it and publish the duplicate detection rules. To learn more, see [Run Duplicate Detection](/powerapps/developer/common-data-service/run-duplicate-detection) in the Dataverse documentation.

## Manage duplicate detection during Create and Update operations

Dynamics 365 Customer Engagement (on-premises) Web API allows you to detect duplicate records of an existing record in order to maintain integrity of data. To learn more, see  [Detect duplicates during Create and Update operations](/powerapps/developer/common-data-service/run-duplicate-detection#detect-duplicates-during-create-and-update-operations) in the Dataverse documentation.

## Duplicate detection messages

Use the messages listed in the topic to detect duplicates in Dynamics 365 Customer Engagement (on-premises). To learn more, see [Duplicate Detection Messages](/powerapps/developer/common-data-service/duplicate-detection-messages) in the Dataverse documentation.

## Duplicate detection entities

For more information: [Duplicate Rule entities](/powerapps/developer/common-data-service/duplicaterule-entities)

<!--## DuplicateRule entity

For more information: [DuplicateRule Entity](/powerapps/developer/common-data-service/entities/duplicaterule)

## DuplicateCondition entity

For more information: [DuplicateRuleCondition Entity](/powerapps/developer/common-data-service/entities/duplicaterulecondition)

## DuplicateRecord entity

For more information: [DuplicateRecord Entity](/powerapps/developer/common-data-service/entities/duplicaterecord)-->
  
## Related Sections  
 [Data Management in Dynamics 365 Customer Engagement (on-premises) (Auditing, Duplicate Detection, Bulk Delete, Data Import)](manage-data.md)  
 [Delete data in bulk](delete-data-bulk.md)

## See Also

[Sample: Enable Duplicate Detection and Retrieve Duplicates](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/EnableDuplicateDetection)<br />
[Sample: Invoke Duplicate Detection For Creating and Updating Records](/powerapps/developer/common-data-service/run-duplicate-detection)<br />
[Sample: Detect Multiple Duplicate Records](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/DetectMultipleDuplicateRecords)<br />
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]