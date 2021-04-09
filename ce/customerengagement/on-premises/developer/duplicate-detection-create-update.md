---
title: "Manage duplicate detection for create and update operations (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Read how to detect duplicates during create and update operations using the Dynamics 365 Customer Engagement Web API and Organization service."
ms.custom: 
ms.date: 11/15/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - duplicate detection, Web API, Organization Service
ms.assetid: 5B84D5F0-CFB6-4212-ACCB-03AE81271F1E
caps.latest.revision: 25
author: phecke
ms.author: pehecke
manager: shujoshi
search.audienceType: 
  - developer

---

# Manage duplicate detection for create and update operations

Dynamics 365 Customer Engagement Web API allows you to detect duplicate records of an existing record in order to maintain integrity of data. 

<a name="BKMK_webapi"></a>

## Using Web API

Use Preference header `MSCRM.SuppressDuplicateDetection` and set its value to `false` to detect creation of a duplicate record during Create and Update operations.

> [!NOTE]
>  Make sure there are appropriate duplicate detection rules in place. Dynamics 365 Customer Engagement (on-premises) includes default duplicate detection rules for accounts, contacts, and leads, but not for other types of records. If you want the system to detect duplicates for other record types, you’ll need to create a new rule. For information on how to create a duplicate detection rule, see [Duplicate detection rules](../admin/set-up-duplicate-detection-rules-keep-data-clean.md).

For more information and examples on how to prohibit creation of duplicate records during create and update operations, see [Manage duplicate detection for create and update operations using Web API](/powerapps/developer/data-platform/webapi/manage-duplicate-detection-create-update).

<a name="BKMK_orgservice"></a>

## Using Organization Service

Use `SuppressDuplicateDetection` parameter and set its value to `false` to activate duplicate detection and prohibit creation of a duplicate record during create and update operations.

For more information and example on how to prohibit creation of duplicate records during create and update operations, see [Manage duplicate detection for create and update operations using Organization Service](/powerapps/developer/data-platform/run-duplicate-detection#detect-duplicates-during-create-and-update-operationsdetect-duplicates-during-create-and-update-operations).

### See Also

[Manage duplicate detection during Create and Update operation using Web API](/powerapps/developer/data-platform/webapi/manage-duplicate-detection-create-update)  
[Manage duplicate detection during Create and Update operation using Organization Service](/powerapps/developer/data-platform/run-duplicate-detection#detect-duplicates-during-create-and-update-operationsdetect-duplicates-during-create-and-update-operations)  
[Sample: Use duplicate detection when creating and updating records](/powerapps/developer/data-platform/run-duplicate-detection)  
[Sample: Detect multiple duplicate records](/powerapps/developer/data-platform/duplicate-detection-messages)  
[Run duplicate detection](run-duplicate-detection.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]