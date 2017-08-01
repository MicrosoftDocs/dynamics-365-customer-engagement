---
title: "Delete bulk records for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2fd7332a-f346-45ac-ac7e-49cdf65344f5
caps.latest.revision: 15
ms.author: "rdubois"
manager: "brycho"
---
# Remove a large amount of specific, targeted data with bulk deletion
The *bulk deletion* feature helps you to maintain data quality and manage the consumption of system storage in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] by deleting data that you no longer need.  
  
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
  
2.  Choose **Bulk Record Deletion**.  
  
3.  Choose **New** to run the **Bulk Deletion Wizard** to create a bulk deletion job with the records you want to delete.  
  
 For information about how to implement bulk delete in code, see [MSDN: Delete data in bulk](https://msdn.microsoft.com/library/gg334418.aspx).  
  
### See also  
 [Manage your data](../admin/manage-your-data.md)   
 [Data Encryption](../admin/data-encryption.md)