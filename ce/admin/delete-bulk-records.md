---
title: "Delete bulk records for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
ms.custom: 
ms.date: 10/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: jimholtz
ms.assetid: 6c1edaef-d2d0-4e94-bb3d-819b208966c1
caps.latest.revision: 15
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Remove a large amount of specific, targeted data with bulk deletion 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

The *bulk deletion* feature helps you to maintain data quality and manage the consumption of system storage in [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps by deleting data that you no longer need.  
  
 For example, you can delete the following data in bulk:  
  
-   Stale data.  
  
-   Data that is irrelevant to the business.  
  
-   Unneeded test or sample data.  
  
-   Data that is incorrectly imported from other systems.  
  
With bulk deletion you can perform the following operations:  
  
-   Delete data across multiple entities.  
  
-   Delete records for a specified entity.  
  
-   Receive email notifications when a bulk deletion finishes.  
  
-   Delete data periodically.  
  
-   Schedule the start time of a recurring bulk delete.  
  
-   Retrieve the information about the failures that occurred during a bulk deletion.  
  
## Delete bulk data 
  
1. [!INCLUDE[proc_settings_datamanagement](../includes/proc-settings-datamanagement.md)]  
  
2. Choose **Bulk Record Deletion**.  
  
3. Choose **New** to run the **Bulk Deletion Wizard** to create a bulk deletion job with the records you want to delete.  
  
For information about how to implement bulk delete in code, see [Delete data in bulk](../developer/delete-data-bulk.md). 
  
### See also  
 [Manage your data](../admin/manage-your-data.md)   
 [Data Encryption](../admin/data-encryption.md)
