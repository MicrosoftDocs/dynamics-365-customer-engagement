---
title: "Bulk delete in Dynamics 365 Customer Engagement (on-premises)"
description: "The bulk deletion feature helps you remove large amounts of data that you no longer need. Follow these steps to create and run a bulk record deletion job."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: Mattp123
ms.assetid: 6c1edaef-d2d0-4e94-bb3d-819b208966c1
caps.latest.revision: 15
ms.author: matp
search.audienceType: 
  - admin
---
# Use bulk deletion to remove large amounts of data

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

The *bulk deletion* feature helps you to maintain data quality and manage the consumption of system storage by deleting data that you no longer need.  
  
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


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
